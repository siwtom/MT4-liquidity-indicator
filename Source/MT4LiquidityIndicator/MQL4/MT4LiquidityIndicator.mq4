#property link "https://code.google.com/p/mt4-liquidity-indicator/"
#property description "MT4 Liquidity Indicator"
#property description "Authors:"
#property description "\tDmitry Kogan email: disayev@hotmail.com"
#property description "\tViktar Marmysh email: marmysh@gmail.com"

#property indicator_chart_window

#import "MT4LiquidityIndicator.dll"
void MT4LIInitialize(string st);
void MT4LIStart(int hwnd, string symbol, int period, int digits, double lotSize);
void MT4LIStop(int hwnd);

#import

bool gStatus = false;

int create()
{
   if(!IsDllsAllowed())
   {
      return (1);
   }
   MT4LIInitialize("Is it unicode?");
   
   string symbol = Symbol();
   int period = Period();
   int hwnd = WindowHandle(symbol, period);
   if(hwnd > 0)
   {
      double lotSize = MarketInfo(symbol, MODE_LOTSIZE);
      MT4LIStart(hwnd, symbol, period, Digits, lotSize);
      return (0);
   }
   return (1);   
}

int init()
{
   int result = create();
   return (result);
}

int deinit()
{
   if(IsDllsAllowed())
   {
      string symbol = Symbol();
      int period = Period();
      int hwnd = WindowHandle(symbol, period);
      MT4LIStop(hwnd);
      return (0);
   }
   return (1);
}

int start()
{
   if (!gStatus)
   {
      int status = create();
      if(0 == status)
      {
         gStatus = true;
      }
   }
   return(0);
}

