
# react-native-downtown-christmas-merchandise-promotions

## Getting started

`$ npm install react-native-downtown-christmas-merchandise-promotions --save`

### Mostly automatic installation

`$ react-native link react-native-downtown-christmas-merchandise-promotions`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-downtown-christmas-merchandise-promotions` and add `RNDowntownChristmasMerchandisePromotions.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNDowntownChristmasMerchandisePromotions.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNDowntownChristmasMerchandisePromotionsPackage;` to the imports at the top of the file
  - Add `new RNDowntownChristmasMerchandisePromotionsPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-downtown-christmas-merchandise-promotions'
  	project(':react-native-downtown-christmas-merchandise-promotions').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-downtown-christmas-merchandise-promotions/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-downtown-christmas-merchandise-promotions')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNDowntownChristmasMerchandisePromotions.sln` in `node_modules/react-native-downtown-christmas-merchandise-promotions/windows/RNDowntownChristmasMerchandisePromotions.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Downtown.Christmas.Merchandise.Promotions.RNDowntownChristmasMerchandisePromotions;` to the usings at the top of the file
  - Add `new RNDowntownChristmasMerchandisePromotionsPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNDowntownChristmasMerchandisePromotions from 'react-native-downtown-christmas-merchandise-promotions';

// TODO: What to do with the module?
RNDowntownChristmasMerchandisePromotions;
```
  