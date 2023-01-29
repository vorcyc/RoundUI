using System.Windows;
using System.Windows.Markup;



[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
                                     //(used if a resource is not found in the page,
                                     // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
                                              //(used if a resource is not found in the page,
                                              // app, or any theme specific resource dictionaries)
)]


[assembly: XmlnsDefinition("http://rui.Vorcyc.com/", "Vorcyc.RoundUI")]
[assembly: XmlnsDefinition("http://rui.Vorcyc.com/", "Vorcyc.RoundUI.Presentation")]
[assembly: XmlnsDefinition("http://rui.Vorcyc.com/", "Vorcyc.RoundUI.Windows")]
[assembly: XmlnsDefinition("http://rui.Vorcyc.com/", "Vorcyc.RoundUI.Windows.Controls")]
[assembly: XmlnsDefinition("http://rui.Vorcyc.com/", "Vorcyc.RoundUI.Windows.Converters")]
[assembly: XmlnsDefinition("http://rui.Vorcyc.com/", "Vorcyc.RoundUI.Windows.Navigation")]
[assembly: XmlnsPrefix("http://rui.Vorcyc.com/", "rui")]