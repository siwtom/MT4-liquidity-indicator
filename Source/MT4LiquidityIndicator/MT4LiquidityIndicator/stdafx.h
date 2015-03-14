// stdafx.h : include file for standard system include files,
// or project specific include files that are used frequently, but
// are changed infrequently
//

#pragma once

#include "targetver.h"

#define WIN32_LEAN_AND_MEAN             // Exclude rarely-used stuff from Windows headers
// Windows Header Files:
#include <windows.h>
#include <tchar.h>
#include <stdlib.h>
#include <sstream>
#include <string>
#include <set>
#include <map>
#include <atlbase.h>



using namespace std;

#ifdef max
#undef max
#endif


#ifdef min
#undef min
#endif




typedef unsigned __int64 uint64;
typedef CComCritSecLock<CComAutoCriticalSection> CCsLocker;
