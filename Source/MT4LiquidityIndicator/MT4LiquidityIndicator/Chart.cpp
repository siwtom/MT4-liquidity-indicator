#include "stdafx.h"
#include "Chart.h"
#include "Stream.h"
#include "Parameters.h"
#include "DotNetBridge.h"
#include "DllMain.h"


namespace
{
	const UINT cMessage = RegisterWindowMessage(TEXT("{9118E7EC-6B89-40A2-9554-3FF7811DF7A4}"));
	const UINT cMessage2 = RegisterWindowMessage(TEXT("{74B9AEB5-B877-4898-84A4-067F6854B810}"));
	string cTypeName = "MT4LiquidityIndicator.Net.ChartBuilder";
	string cMethodName = "Run";
	const int cDefaultChartHeight = 250;
}
namespace
{
	bool gIsUnicode = false;
	map<HWND, CChart> gCharts;
}


void MT4LIInitialize(const void* pText)
{
	const char* text = reinterpret_cast<const char*>(pText);
	const size_t length = strlen(text);
	gIsUnicode = (1 == length);
}

void StartA(HWND handle, const char* pSymbol, int period, int digits, double lotSize)
{
	CStream()<<"StartA(handle = 0x"<<handle<<", pSymbol = "<<pSymbol<<", period = "<<period<<", digits = "<<digits<<", lotSize = "<<lotSize<<")">>DebugLog;

	if (0 == gCharts.count(handle))
	{
		string symbol = pSymbol;
		CChart& chart = gCharts[handle];
		chart.Construct(handle, symbol, period, digits, lotSize);
	}
}

void StartW(HWND handle, const wchar_t* pSymbol, int period, int digits, double lotSize)
{
	CW2A converter(pSymbol);
	const char* symbol = converter;
	StartA(handle, symbol, period, digits, lotSize);
}

void MT4LIStart(HWND handle, const void* pSymbol, int period, int digits, double lotSize)
{
	if (gIsUnicode)
	{
		const wchar_t* symbol = reinterpret_cast<const wchar_t*>(pSymbol);
		StartW(handle, symbol, period, digits, lotSize);
	}
	else
	{
		const char* symbol = reinterpret_cast<const char*>(pSymbol);
		StartA(handle, symbol, period, digits, lotSize);
	}
}
void MT4LIStop(HWND handle)
{
	CStream()<<"FxStop(handle = 0x"<<handle<<")">>DebugLog;
	auto it = gCharts.find(handle);
	if (gCharts.end() != it)
	{
		CChart& chart = it->second;
		chart.Finalize(handle);
		gCharts.erase(it);
	}
}

LRESULT CALLBACK ChartProcHandler(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	auto it = gCharts.find(hwnd);
	if (gCharts.end() != it)
	{
		CChart& chart = it->second;
		return chart.Handle(hwnd, uMsg, wParam, lParam);
	}
	return 0;
}


CChart::CChart() : m_chartHeight(cDefaultChartHeight), m_isSpecial(false), m_wasSent(false), m_width(), m_height(), m_indicator(), m_original()
{
}
CChart::~CChart()
{
}
void CChart::Construct(HWND hwnd, const string& symbol, int period, int digits, double lotSize)
{
	m_original = reinterpret_cast<WNDPROC>(SetWindowLong(hwnd, GWL_WNDPROC, reinterpret_cast<LONG>(ChartProcHandler)));
	string argument = FormatParameters(this, symbol, period, digits, lotSize, reinterpret_cast<void*>(&CChart::SetHeight));
	CStream()<<argument>>DebugLog;
	CDotNetBridge bridge;
	m_indicator = reinterpret_cast<HWND>(bridge.Execute(DotNetDllPath(), cTypeName, cMethodName, argument));
	if (m_indicator > 0)
	{
		HWND parent = GetParent(hwnd);
		SetWindowLong(m_indicator, GWL_STYLE, WS_CHILD | WS_VISIBLE | WS_CLIPCHILDREN);
		SetParent(m_indicator, parent);
		SetWindowLong(parent, GWL_STYLE, GetWindowLong(parent, GWL_STYLE) | WS_CLIPCHILDREN);
		OnUpdate(hwnd);
		PostMessage(hwnd, cMessage2, 0, 0);
	}
}
void CChart::Finalize(HWND hwnd)
{
	if (nullptr != m_indicator)
	{
		DestroyWindow(m_indicator);
		m_indicator = nullptr;
	}
	SetWindowLong(hwnd, GWL_WNDPROC, reinterpret_cast<LONG>(m_original));
	MoveWindow(hwnd, 0, 0, m_width, m_height, TRUE);
}
LRESULT CChart::Handle(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	WNDPROC original = m_original;

	if (WM_DESTROY == uMsg)
	{
		Finalize(hwnd);
		gCharts.erase(hwnd);
	}
	else if (WM_SIZE == uMsg)
	{
		OnSize(hwnd);
	}
	else if (cMessage == uMsg)
	{
		OnUpdate(hwnd);
	}
	else if (cMessage2 == uMsg)
	{
		UpdateHeight();
	}
	return original(hwnd, uMsg, wParam, lParam);
}
void CChart::OnSize(HWND hwnd)
{
	if (!m_isSpecial && !m_wasSent)
	{
		PostMessage(hwnd, cMessage, 0, 0);
		m_wasSent = true;
	}
}
void CChart::OnUpdate(HWND hwnd)
{
	m_wasSent = false;
	m_isSpecial = true;
	RECT rect;
	BOOL status = GetWindowRect(hwnd, &rect);
	if (status)
	{
		m_width = rect.right - rect.left;
		m_height = rect.bottom - rect.top;

		MoveWindow(hwnd, 0, 0, m_width, m_height - m_chartHeight, TRUE);
		m_isSpecial = false;

		MoveWindow(m_indicator, 0, m_height - m_chartHeight, m_width, m_chartHeight, TRUE);
	}
}

void __stdcall CChart::SetHeight(void* ptr, int height)
{
	CChart* pThis = reinterpret_cast<CChart*>(ptr);
	pThis->DoSetHeight(height);
}

void CChart::DoSetHeight(int height)
{
	if (m_chartHeight != height)
	{
		m_chartHeight = height;
		UpdateHeight();
	}
}

void CChart::UpdateHeight()
{
	HWND parent = GetParent(m_indicator);
	HWND mdi = GetParent(parent);
	RECT rect;
	if(GetWindowRect(parent, &rect))
	{
		POINT point = { rect.left, rect.top };
		if (ScreenToClient(mdi, &point))
		{
			MoveWindow(parent, point.x, point.y, rect.right - rect.left + 1, rect.bottom - rect.top, TRUE);
			MoveWindow(parent, point.x, point.y, rect.right - rect.left, rect.bottom - rect.top, TRUE);
		}
	}
}
