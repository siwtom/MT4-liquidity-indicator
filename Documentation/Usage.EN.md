Installation and usage of MT4LiquidityIndicator
----------------------------------
----------------------------------

Installation
-------------
Download the latest version of [MT4 Liquidity Indicator](https://drive.google.com/folderview?id=0BwBMSNJd3y5MQ1E3TTF0ZTZPVjg&usp=sharing#list) then start the installation with admin rights. The installation program shows list of installed Meta Trader 4 applications. Select versions of Meta Trader 4, for which MT4 liquidity indicator should be installed and then click “Install” button.

![Installation](/Documentation/Images/Installation.png)


Start
-------------

Drag the MT4 Liquidity Indicator to a chart, which you would like. In appeared window, you should select parameters “Allow DLL imports” and “Allow external experts”.

![MT4LiquidityIndicator](/Documentation/Images/MT4LiquidityIndicator.png)
![Allow Dll Import](/Documentation/Images/AllowDllImport.png)

Fort the first start on the context menu click "Connections settings" and fill required settings..
![The first start](/Documentation/Images/TheFirstStart.png)
![Connections Settings](/Documentation/Images/ConnectionsSettings.png)

To do this download and install [OCTL2](http://fxopen.com) plugin then open DefaultSettings.SoftFX.OneClickTrading.NET.dll.xml file and choose an appropriate for you settings.
![OCTL2](/Documentation/Images/OCTL2.png)

After successful activation of the indicator, you will show an additional window in the lower part of the chart. The window displays available bid and ask prices for the specified sizes in tabular and graphical modes. For example, the table on an image below shows that volume weight average prices for buying and selling 10 lots equal to 1.29446 and 1.29443 correspondingly. The prices chart show dynamics of available liquidity.
 
 ![Current Quotes](/Documentation/Images/CurrentQuotes.png)
 
where:
* **Volume** is a size specified by user;
* **Bid** is a volume weight average bid for the specified size;
* **Ask** is a volume weight average ask for the specified size;
* **Diff** is a difference between calculated bid and ask. 


Usage in real time mode
----------------------------------------

The indicator has a set of rich and flexible settings. To configure the indicator view click “View Options” in context menu.

![View Options](/Documentation/Images/ViewOptions.png)

where:

* **Background Color** specifies color of a chart background;
* **Duration** specifies length of X-line chart in seconds; 
* **Foreground Color** specifies color of X-line, Y-line and grid of a chart;
* **Height** specifies a chart height in pixels;
* **Mode** specifies a chart rendering mode: 
  - **Quality** mode uses antialiasing for lines smoothing, this mode is recommended;
  - **Speed** mode does not use antialiasing for lines smoothing, this mode is preferable for slow computers. 
* **Show Grid** enables/disables grid on the chart;
* **Type** specifies type of price lines;
* **Update interval** specifies a time interval in ms between a chart redrawing;
* **Lines** option allows specifying a set of price lines. For every price line user can assign a required liquidity size and color.

![Line Settings Collection Editor](/Documentation/Images/LineSettingsCollectionEditor.png)

Usage in historical mode
------------------------------------------


To use MT4 liquidity indicator in historical mode user should select “**View quotes history**” from context menu, then specify a requested time point and click “**Go**” button. After the indicator loaded a level2 history the downloading dialog will be closed automatically and then chart displays price lines and other information.


![Quotes history](/Documentation/Images/QuotesHistory.png)

Loaded data can be saved to a .CSV file.

