//==============================================================
// Copyright (c) 2015 by Viktar Marmysh mailto:marmysh@gmail.com
//==============================================================

#pragma once

void MT4LIInitialize(const void* pText);
void MT4LIStart(HWND handle, const void* pSymbol, int period, int digits, double lotSize);
void StartA(HWND handle, const char* pSymbol, int period, int digits, double lotSize);
void StartW(HWND handle, const wchar_t* pSymbol, int period, int digits, double lotSize);
void MT4LIStop(HWND handle);

