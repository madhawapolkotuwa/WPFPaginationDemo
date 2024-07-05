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

```
dotnet add package PaginationControl.WPF --version 1.0.2
```
or package Manager console
```
NuGet\Install-Package PaginationControl.WPF -Version 1.0.2
```

## Manual Installation
 1. Clone the repository:
  ```https://github.com/madhawapolkotuwa/WPFPaginationDemo.git```
 2. Build the project and add the PaginationControl assembly as a reference in your WPF project.

## Usage
  To use the `PaginationControl`, follow these steps:

1. Add the XML namespace to your XAML file:
```
    xmlns:paginationcontrol="clr-namespace:PaginationControl;assembly=PaginationControl"
```
2. Add the Pagination control to your XAML:
```
<paginationcontrol:Pagination
    CurrentPage="{Binding CurrentPage, Mode=TwoWay}"
    Pages="{Binding Pages}" />
```
3. Bind the CurrentPage and Pages properties to your view model:

```
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

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
```