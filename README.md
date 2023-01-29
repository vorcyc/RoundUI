# RoundUI
A WPF UI framework

## screenshot
![Vorcyc RoundUI 1.0 demo](screenshot.png)

---
## Usage
### 1. Add reference of Vorcyc.RoundUI.dll or NuGet it to your WPF project.

### 2. Make App.xaml like this :
*This step will make change to the apperance of controls in your application.*

```xml

<Application x:Class="demo.App"
                xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
                xmlns:local="clr-namespace:demo"
                StartupUri="MainWindow.xaml">
    <Application.Resources>
        <ResourceDictionary>
            <Color x:Key="AccentColor">#ca5100</Color>
            <!--Change the global font -->
            <FontFamily x:Key="DefaultFontFamily">Microsoft YaHei</FontFamily>

            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="/Vorcyc.RoundUI;component/Assets/RoundUI.xaml"/>
                <ResourceDictionary Source="/Vorcyc.RoundUI;component/Assets/RoundUI.Light.xaml"/>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>

```


### 3. Use the ModernNormalWindow or ModernWindow to replace System.Windows.Window .
*This step will change the style of your window.*


```xml

<ui:RoundNormalWindow
    x:Class="demo.MainWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:ui="http://rui.Vorcyc.com/"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    xmlns:local="clr-namespace:demo"
    mc:Ignorable="d"
    LogoData="F1 M 57.3958,49.0833L 47.5,49.0833L 42.75,63.3333L 40.375,63.3333L 37.6041,26.5209L 34.4375,49.0833L 28.5,49.0833L 22.9583,45.5208L 19,49.0833L 11.0833,49.0833L 11.0833,46.3125L 19,46.3125L 22.9583,42.75L 28.5,46.3125L 31.5883,46.3125L 36.4166,11.4792L 39.1875,11.875L 42.7499,55.0209L 46.3125,46.3125L 57,46.3125L 63.3333,41.1667L 66.5,41.1667L 66.5,43.9375L 63.3333,43.9375L 57.3958,49.0833 Z "
    Title="Vorcyc RoundUI demo" Height="350" Width="525">
</ui:RoundNormalWindow>

```


```csharp
using Vorcyc.RoundUI.Windows.Controls;

namespace demo;

public partial class MainWindow : RoundNormalWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }
}
```

==  This project also provides some new controls like ***RangeSlider*** , explore it and enjoy ! :smiley: :smiley: :smiley: ==
