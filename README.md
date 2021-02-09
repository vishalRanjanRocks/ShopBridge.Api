# ShopBridge.Api


1) Clone https://github.com/vishalRanjanRocks/ShopBridge.Api.git (web api application .net core 5)
2)Clone https://github.com/vishalRanjanRocks/ShopBridge.UI.git (Asp.net core angular application)
Both Api and Ui application are independent from each other in design
System requirements:
1)Visual studio 2019
2)Node.js 14.0.0 and above

Deployment Process:
ShopBridge.Ui:
1)Go to folder structure for ui:  .....\ ShopBridge.UI\ShopBridge.UI\ClientApp
2)Open Cmd at above location and run command : npm install
Common for Both application 
1)Open solution in visual studio 2019
2)right click on shopbridge.UI application and click on publish
3)publish to a folder location

4)Give path where wants to publish
On IIS side
1)Open iis click on application pools add application pool

2)Go to site and add website with given config

Note : for API project give port number 8095
3)Restart Application
