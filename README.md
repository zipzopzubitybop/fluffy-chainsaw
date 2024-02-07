# fluffy-chainsaw

CSV to PHP Array

## Overview

The Excel/CSV to PHP Array Converter is a .NET console application designed to automate the conversion of data from Excel and CSV files into a PHP array format. This tool is particularly useful for developers needing to quickly import spreadsheet data into PHP applications without manual data entry or complex parsing logic.

## Requirements

- .NET 5.0 SDK or later

## Installation

1. **Clone the repository**

   ```sh
   git clone https://github.com/zipzopzubitybop/fluffy-chainsaw.git
   cd fluffy-chainsaw
   ```

2. **Build the application**

   Navigate to the project directory and compile the application:

   ```sh
   dotnet build
   ```

## Usage

To convert a file, run the application with the file path as an argument. The application can automatically detect the file type based on the extension and process it accordingly.

### Convert a CSV File

```sh
dotnet run --project ./fluffy-chainsaw <path_to_file.csv>
```

### Convert an Excel File

```sh
dotnet run --project ./fluffy-chainsaw <path_to_file.xlsx>
```

**Output Example:**

The application will output the PHP array to the console. For instance:

```php
$array = array(
    array("header1", "header2", "header3"),
    array("row1col1", "row1col2", "row1col3"),
    array("row2col1", "row2col2", "row2col3")
);
```

## Customizing Output

The current version outputs a simple PHP array. If you need a different format (e.g., associative arrays), you may modify the source code to accommodate your specific needs.
