# TailwindWPF 🎨 (in development)

A modern WPF library that brings the power and simplicity of Tailwind CSS to your WPF applications.

[![NuGet](https://img.shields.io/nuget/v/TailwindWPF.svg)](https://www.nuget.org/packages/TailwindWPF)
[![Downloads](https://img.shields.io/nuget/dt/TailwindWPF.svg)](https://www.nuget.org/packages/TailwindWPF)
[![License](https://img.shields.io/github/license/patricksardinha/TailwindWPF.svg)](LICENSE)

## 🚀 Introduction

TailwindWPF allows you to style your WPF controls with familiar Tailwind CSS-inspired syntax. No more repetitive XAML declarations - just use utility classes in a `tw:Tw.Class` attribute!

### Before
```xml
<Button Background="Blue" 
        Foreground="White" 
        Padding="12,8,12,8" 
        Margin="8"
        BorderThickness="0"
        FontSize="16"
        FontWeight="Bold">
    <Button.Template>
        <ControlTemplate TargetType="Button">
            <Border Background="{TemplateBinding Background}" 
                    CornerRadius="6"
                    Padding="{TemplateBinding Padding}">
                <ContentPresenter HorizontalAlignment="Center" 
                                VerticalAlignment="Center"/>
            </Border>
        </ControlTemplate>
    </Button.Template>
    My Button
</Button>
```

### After
```xml
<Button Content="My Button" 
        tw:Tw.Class="bg-blue-500 text-white px-3 py-2 m-2 rounded-md font-bold" />
```

## 📦 Installation [no releases are available for the moment]

### Via NuGet Package Manager
```
Install-Package TailwindWPF
```

### Via .NET CLI
```bash
dotnet add package TailwindWPF
```

### Via PackageReference
```xml
<PackageReference Include="TailwindWPF" Version="1.0.0" />
```

## 🎯 Quick Start

1. **Add the namespace** to your XAML:
```xml
xmlns:tw="clr-namespace:TailwindWPF.Styling;assembly=TailwindWPF"
```

2. **Use the `tw:Tw.Class` attribute** on your controls:
```xml
<TextBlock Text="Hello World!" 
           tw:Tw.Class="text-blue-500 text-2xl font-bold m-4" />
```

3. **Create complex layouts** easily:
```xml
<Grid tw:Tw.Class="grid-cols-3 grid-rows-2 gap-4">
    <Button Content="Cell 1" tw:Tw.Class="col-start-1 row-start-1 bg-red-500 text-white" />
    <Button Content="Spans 2 cols" tw:Tw.Class="col-span-2 bg-green-500 text-white" />
</Grid>
```

## 🎨 Supported Features [in development]

### Colors and Backgrounds
```xml
<!-- Backgrounds -->
<Button tw:Tw.Class="bg-blue-500 bg-red-400 bg-gray-100" />

<!-- Text colors -->
<TextBlock tw:Tw.Class="text-white text-gray-800 text-blue-600" />

<!-- Borders -->
<Border tw:Tw.Class="border-2 border-gray-300 border-red-500" />
```

### Spacing and Sizing
```xml
<!-- Padding -->
<Button tw:Tw.Class="p-4 px-6 py-2" />

<!-- Margin -->
<TextBlock tw:Tw.Class="m-2 mx-4 my-8" />

<!-- Sizes -->
<Button tw:Tw.Class="w-32 h-16" />
```

### Typography
```xml
<!-- Font sizes -->
<TextBlock tw:Tw.Class="text-xs text-sm text-lg text-xl text-2xl text-3xl" />

<!-- Font weights -->
<TextBlock tw:Tw.Class="font-thin font-normal font-bold font-black" />

<!-- Text alignment -->
<TextBlock tw:Tw.Class="text-left text-center text-right" />
```

### Layout and Grid
```xml
<!-- Define a grid -->
<Grid tw:Tw.Class="grid-cols-12 grid-rows-6 gap-4">
    
    <!-- Positioning -->
    <Button tw:Tw.Class="col-start-1 row-start-1" />
    
    <!-- Spanning -->
    <Button tw:Tw.Class="col-span-3 row-span-2" />
    
    <!-- Full width -->
    <Button tw:Tw.Class="col-span-full" />
    
</Grid>
```

### Borders and Rounded Corners
```xml
<!-- Rounded corners -->
<Button tw:Tw.Class="rounded rounded-md rounded-lg rounded-full" />

<!-- Borders -->
<Border tw:Tw.Class="border border-2 border-4 border-gray-300" />
```

### States and Interactions
```xml
<!-- Hover effects -->
<Button tw:Tw.Class="bg-blue-500 hover:bg-blue-600 hover:text-white" />

<!-- Combined states -->
<Button tw:Tw.Class="bg-blue-500 hover:bg-blue-400 text-white font-bold border border-gray-500 hover:border-blue-500" />
```

## 🛠️ Advanced Usage

### Custom Extensions
You can easily add your own styles:

```csharp
// Create a custom style provider
public class MyCustomStyles : BaseStyleProvider
{
    public override Dictionary<string, Action<DependencyObject>> GetStyles() => new()
    {
        ["my-special-button"] = d => {
            if (d is Button btn) 
            {
                btn.Background = Brushes.Purple;
                btn.Foreground = Brushes.White;
                btn.FontWeight = FontWeights.Bold;
            }
        }
    };
}

// Register it
TailwindMap.RegisterStyleProvider(new MyCustomStyles());
```

### Custom Classes
```csharp
var customStyles = new Dictionary<string, Action<DependencyObject>>
{
    ["brand-primary"] = d => /* your logic */,
    ["shadow-custom"] = d => /* your logic */
};

TailwindMap.RegisterCustomStyles(customStyles);
```

## 📚 Complete Documentation

You can refer to the documentation at [Tailwind CSS](https://tailwindcss.com)

### Supported Color Classes
- **Grays**: `gray-50` to `gray-900`
- **Colors**: `red-*`, `blue-*`, `green-*`, `yellow-*`, `purple-*`, `pink-*`, `indigo-*`
- **Special**: `transparent`, `current`, `black`, `white`

### Spacing Classes
- **Padding**: `p-0` to `p-12`, `px-*`, `py-*`, `pt-*`, `pr-*`, `pb-*`, `pl-*`
- **Margin**: `m-0` to `m-12`, `mx-*`, `my-*`, `mt-*`, `mr-*`, `mb-*`, `ml-*`

### Typography Classes
- **Sizes**: `text-xs`, `text-sm`, `text-base`, `text-lg`, `text-xl`, `text-2xl`, `text-3xl`
- **Weights**: `font-thin`, `font-light`, `font-normal`, `font-medium`, `font-semibold`, `font-bold`, `font-extrabold`, `font-black`

### Layout Classes
- **Grid columns**: `grid-cols-1` to `grid-cols-12`
- **Grid rows**: `grid-rows-1` to `grid-rows-6`
- **Positioning**: `col-start-*`, `row-start-*`, `col-end-*`, `row-end-*`
- **Spanning**: `col-span-*`, `row-span-*`, `col-span-full`, `row-span-full`

## 🎯 Complete Example

```xml
<Window x:Class="MyApp.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:tw="clr-namespace:TailwindWPF.Styling;assembly=TailwindWPF"
        Title="TailwindWPF Demo" Height="600" Width="800">
    
    <Grid tw:Tw.Class="grid-cols-4 grid-rows-3 gap-4 p-4">
        
        <!-- Header spanning full width -->
        <TextBlock Text="My Application" 
                   tw:Tw.Class="col-span-full text-3xl font-bold text-center text-gray-800 mb-4" />
        
        <!-- Sidebar -->
        <StackPanel tw:Tw.Class="col-start-1 row-span-2 bg-gray-100 p-4 rounded-lg">
            <Button Content="Dashboard" tw:Tw.Class="w-full mb-2 bg-blue-500 hover:bg-blue-600 text-white py-2 rounded" />
            <Button Content="Settings" tw:Tw.Class="w-full mb-2 bg-gray-500 hover:bg-gray-600 text-white py-2 rounded" />
            <Button Content="Profile" tw:Tw.Class="w-full bg-green-500 hover:bg-green-600 text-white py-2 rounded" />
        </StackPanel>
        
        <!-- Main content area -->
        <Grid tw:Tw.Class="col-span-3 row-span-2 bg-white border border-gray-200 rounded-lg p-6">
            <TextBlock Text="Main Content Area" 
                       tw:Tw.Class="text-xl font-semibold text-gray-700 text-center" />
        </Grid>
        
    </Grid>
</Window>
```

## 🚧 Roadmap

- [ ] **Mapping** (`text-*`, `bg-*`, etc.)
- [ ] **Flexbox layouts** (`flex`, `flex-col`, `justify-center`, etc.)
- [ ] **Animations and transitions** (`transition-all`, `duration-300`, etc.)  
- [ ] **Responsive design** (`sm:text-lg`, `md:grid-cols-2`, etc.)
- [ ] **Dark mode** (`dark:bg-gray-800`, etc.)
- [ ] **Focus states** (`focus:ring-2`, `focus:outline-none`, etc.)
- [ ] **Shadows and effects** (`shadow-lg`, `blur-sm`, etc.)
- [ ] **Transforms** (`rotate-45`, `scale-110`, etc.)
- [ ] **Position and z-index** (`absolute`, `relative`, `z-10`, etc.)

## 🤝 Contributing

Contributions are welcome! Here's how to contribute:

1. **Fork** the project
2. **Create** your feature branch (`git checkout -b feature/AmazingFeature`)
3. **Commit** your changes (`git commit -m 'Add some AmazingFeature'`)
4. **Push** to the branch (`git push origin feature/AmazingFeature`)
5. **Open** a Pull Request

### Local Development

```bash
git clone https://github.com/patricksardinha/TailwindWPF.git
cd TailwindWPF
dotnet restore
dotnet build
```

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- [Tailwind CSS](https://tailwindcss.com) for the inspiration and methodology
- The WPF community for support and feedback
- All contributors who make this project possible

## Support

- **Issues**: [GitHub Issues](https://github.com/patricksardinha/TailwindWPF/issues)
- **Discussions**: [GitHub Discussions](https://github.com/patricksardinha/TailwindWPF/discussions)

---


**⭐ Don't forget to star the repo if TailwindWPF helps you! ⭐**

[Documentation](https://github.com/patricksardinha/TailwindWPF/wiki) • [Examples](https://github.com/patricksardinha/TailwindWPF/tree/main/examples) • [Changelog](CHANGELOG.md)
