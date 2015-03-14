#pragma once


class CChart
{
public:
	CChart();
	~CChart();
public:
	void Construct(HWND hwnd, const string& symbol, int period, int digits, double lotSize);
	void Finalize(HWND hwnd);
	LRESULT Handle(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);
private:
	static void __stdcall SetHeight(void* ptr, int height);
private:
	void OnSize(HWND hwnd);
	void OnUpdate(HWND hwnd);
	void DoSetHeight(int height);
	void UpdateHeight();
private:
	int m_chartHeight;
	bool m_isSpecial;
	bool m_wasSent;
	int m_width;
	int m_height;
	HWND m_indicator;
	WNDPROC m_original;
	string m_symbol;
};