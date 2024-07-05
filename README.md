# WPFPaginationDemo

A custom pagination control for WPF applications.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)

## Introduction

`PaginationControl` is a custom WPF control designed to provide an easy-to-use and highly customizable pagination component. It allows you to navigate through pages of data with simple commands and bindings.

## Features

- Customizable styles for pagination buttons
- Visibility control for navigation buttons
- Simple data binding for current page and total pages
- Command support for page navigation

## Installation

### NuGet Package

To install the `PaginationControl` package via NuGet, use the following command in the NuGet Package Manager Console:

```bash
dotnet add package PaginationControl.WPF --version 1.0.2
```
or package Manager console
```bash
NuGet\Install-Package PaginationControl.WPF -Version 1.0.2
```

## Manual Installation
 1. Clone the repository:
  ```https://github.com/madhawapolkotuwa/WPFPaginationDemo.git```
 2. Build the project and add the PaginationControl assembly as a reference in your WPF project.

## Usage
  To use the `PaginationControl`, follow these steps:

1. Add the XML namespace to your XAML file:
```xml
    xmlns:paginationcontrol="clr-namespace:PaginationControl;assembly=PaginationControl"
```
2. Add the Pagination control to your XAML:
```xml
<paginationcontrol:Pagination
    CurrentPage="{Binding CurrentPage, Mode=TwoWay}"
    Pages="{Binding Pages}" 
    Style="{DynamicResource PaginationStyle1}"/>
```
3. Add custom styles

```xml
<Style x:Key="pagingButtonActive" TargetType="Button">
    <Setter Property="Background" Value="#ce404f" />
    <Setter Property="Foreground" Value="#ffffff" />
    <Setter Property="FontSize" Value="20" />
    <Setter Property="Margin" Value="1,0" />
    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="Button">
                <Border
                    Padding="10,5"
                    Background="{TemplateBinding Background}"
                    CornerRadius="5">
                    <ContentPresenter
                        Margin="0,0,0,1"
                        HorizontalAlignment="Center"
                        VerticalAlignment="Center" />
                </Border>

            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>
<Style x:Key="pagingButton" TargetType="{x:Type Button}">
    <Setter Property="Background" Value="Transparent" />
    <Setter Property="Foreground" Value="#6c7682" />
    <Setter Property="FontSize" Value="20" />
    <Setter Property="Margin" Value="1,0" />
    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="{x:Type Button}">
                <Border
                    Padding="10,5"
                    Background="{TemplateBinding Background}"
                    CornerRadius="5">
                    <ContentPresenter
                        Margin="0,0,0,1"
                        HorizontalAlignment="Center"
                        VerticalAlignment="Center" />
                </Border>
            </ControlTemplate>
        </Setter.Value>
    </Setter>
    <Style.Triggers>
        <Trigger Property="IsMouseOver" Value="True">
            <Setter Property="Background" Value="#ce404f" />
            <Setter Property="Foreground" Value="#ffffff" />
        </Trigger>
    </Style.Triggers>
</Style>
<Style x:Key="PaginationStyle1" TargetType="{x:Type PaginationControl:Pagination}">
    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="{x:Type PaginationControl:Pagination}">
                <ControlTemplate.Resources>
                    <BooleanToVisibilityConverter x:Key="booleanToVisibilityConverter" />
                    <converters:StyleNameConverter x:Key="styleNameConverter" />
                </ControlTemplate.Resources>
                <Border
                    Margin="0,10,10,10"
                    Padding="5"
                    HorizontalAlignment="Right"
                    BorderBrush="#dee4ec"
                    BorderThickness="1"
                    CornerRadius="5">
                    <StackPanel Orientation="Horizontal">
                        <!-- Template elements -->
                    </StackPanel>
                </Border>
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>
```

4. Bind the CurrentPage and Pages properties to your view model:

```csharp
public class YourViewModel : INotifyPropertyChanged
{
    private int _currentPage;
    private int _pages;

    public int CurrentPage
    {
        get => _currentPage;
        set
        {
            if (_currentPage != value)
            {
                _currentPage = value;
                OnPropertyChanged();
            }
        }
    }

    public int Pages
    {
        get => _pages;
        set
        {
            if (_pages != value)
            {
                _pages = value;
                OnPropertyChanged();
            }
        }
    }

    public YourViewModel()
    {
        Pages = 10;
        CurrentPage = 1;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
```

