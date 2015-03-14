#include "stdafx.h"
#include "Stream.h"

CStream::CStream()
{
	m_stream.precision(DBL_DIG);
	m_stream<<boolalpha;
	m_stream<<"[LR] ";
}

CStream& CStream::operator<<(const char* arg)
{
	if (nullptr != arg)
	{
		m_stream<<arg;
	}
	return *this;
}

CStream& CStream::operator<<(ostream& (*arg)(ostream&))
{
	m_stream<<arg;
	return *this;
}

void CStream::operator>>(Text2Log func)
{
	string message = m_stream.str();
	func(message);
}
void DebugLog(const string& message)
{
	OutputDebugStringA(message.c_str());
}
