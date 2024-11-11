
# react-native-neture-exchanging-opinions

## Getting started

`$ npm install react-native-neture-exchanging-opinions --save`

### Mostly automatic installation

`$ react-native link react-native-neture-exchanging-opinions`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-neture-exchanging-opinions` and add `RNNetureExchangingOpinions.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNNetureExchangingOpinions.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNNetureExchangingOpinionsPackage;` to the imports at the top of the file
  - Add `new RNNetureExchangingOpinionsPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-neture-exchanging-opinions'
  	project(':react-native-neture-exchanging-opinions').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-neture-exchanging-opinions/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-neture-exchanging-opinions')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNNetureExchangingOpinions.sln` in `node_modules/react-native-neture-exchanging-opinions/windows/RNNetureExchangingOpinions.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Neture.Exchanging.Opinions.RNNetureExchangingOpinions;` to the usings at the top of the file
  - Add `new RNNetureExchangingOpinionsPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNNetureExchangingOpinions from 'react-native-neture-exchanging-opinions';

// TODO: What to do with the module?
RNNetureExchangingOpinions;
```
  