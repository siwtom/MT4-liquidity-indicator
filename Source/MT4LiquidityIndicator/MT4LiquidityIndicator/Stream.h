#pragma once

typedef void (*Text2Log)(const string& message);

class CStream
{
public:
	CStream();
public:
	CStream& operator << (const char* arg);
	CStream& operator << (ostream& (*arg)(ostream&));
	void operator >> (Text2Log func);
	template<typename T> CStream& operator << (const T& arg)
	{
		m_stream<<arg;
		return *this;
	}
private:
	CStream(const CStream&);
	CStream& operator = (const CStream&);
private:
	stringstream m_stream;
};


void DebugLog(const string& message);
