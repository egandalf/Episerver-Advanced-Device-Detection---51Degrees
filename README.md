![EPi](images/EpiLogo.jpg)   ![51Degrees](https://51degrees.com/DesktopModules/FiftyOne/Distributor/Logo.ashx?utm_source=github&utm_medium=repository&utm_content=home&utm_campaign=epi "THE Fastest and Most Accurate Device Detection") **Device Detection for EPi**

[Supported Databases](https://51degrees.com/compare-data-options?utm_source=github&utm_medium=repository&utm_content=home-menu&utm_campaign=epi "Different device databases which can be used with 51Degrees device detection") | [.NET Developer Documention](https://51degrees.com/support/documentation/net?utm_source=github&utm_medium=repository&utm_content=home-menu&utm_campaign=epi "Full getting started guide and advanced developer documentation") | [Available Properties](https://51degrees.com/resources/property-dictionary?utm_source=github&utm_medium=repository&utm_content=home-menu&utm_campaign=epi "View all available properties and values")

**Support adaptive design and enhance analytics by adding device intelligence to EPi visitor groups.**

Create visitor groups for device type...

![Device Type](images/DeviceType.png "EPi visitor group for different device types and classifications")

...and extend them with physical screen size information.

![Screen Inches Diagonal](images/ScreenInchesDiagonal.png "Use range slider to create custom device groupings")

Access device capabilities not available via feature detection including embedded support for telephone calls and text messages.

![Supports Phone Calls](images/SupportsPhoneCalls.png "Enable features such as telephone call to action")

Combine with other criteria to create groups that become enabled when your call center is open, telephone calls are supported and the user is in the same time zone.

![Time of Day](images/TimeOfDay.png "Group enables during specific hours, location and device feature")

Use the new visitor group to promote a prominent call to action and start talking to valuable customers.

Access all 51Degrees properties in one place.

![All Properties](images/HasTrackPad.png "All 51Degrees properties are available")

---

**Server Side** - Use code like...

```cs
Request.Browser["DeviceType"]
```

or

```cs
Request.Browser["ScreenInchesDiagonal"]
```

... in EPi server scripts to access properties in your own code.

---

**Client Side** - Include...

```
https://[YOUR DOMAIN]/51Degrees.features.js?DeviceType&ScreenInchesDiagonal
```

... from Javascript to retrieve device type and physcial screen size information as a JSON object.

``` javascript
var FODF={DeviceType:"SmartPhone",ScreenInchesDiagonal:4.95};
```

Use with Google Analytics custom dimensions to add this data for granular analysis.

**[Review All Properties](https://51degrees.com/resources/property-dictionary?utm_source=github&utm_medium=repository&utm_content=home-cta&utm_campaign=epi "View all available properties and values")**

---

## What's needed?

The simplest method of deploying to EPi is with NuGet. Just search for [51Degrees on nuget.episerver.com](http://nuget.episerver.com/en/?search=51degrees&sort=MostDownloads&page=1&pageSize=10 "51Degrees Packages on nuget.episerver.com").

This NuGet package includes 51Degrees free Lite device database. The Lite data is updated monthly by 51Degrees' professional team of analysts. An upgrade to 51Degrees enhanced device data is required to enable all features.

Upgrades include weekly and daily automatic data file updates and more accurate device detection.

Once you've obtained an enhanced data file more Visitor Group criterion will be available. Place the enhanced data file in the App_Data folder replacing 51Degrees.dat.

If you have a license key for 51Degrees place the key in a file named "51Degrees.lic" in the bin folder. New data files will automatically be downloaded updating App_Data/51Degrees.dat.

**[Compare Device Databases](https://51degrees.com/compare-data-options?utm_source=github&utm_medium=repository&utm_content=home-cta&utm_campaign=epi "Compare different data file options for 51Degrees device detection")**

**[Free Enhanced Data Trial](https://51degrees.com/epi?utm_source=github&utm_medium=repository&utm_content=home-cta&utm_campaign=epi "Start a free trial of 51Degrees enhanced device data")**

**System Integrators**

The visitor group criteria are automatically generated by the project Generator.csproj. Modify this project to create custom versions of the module for your users.