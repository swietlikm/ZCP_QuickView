# ZCP_QuickView

This application is used for viewing and analyzing data from the MES and ERP databases. It loads data into a DataGridView, allowing users to filter and sort the information based on various criteria. 

## Requirements

- .NET Framework 4.7.2 or higher
- ODBC driver for connecting to the local MES (ZCP) and ERP (Galileo) databases

## Functionality

- The application loads data from the MES (ZCP) and ERP (Galileo) databases and displays it in a DataGridView.
- Users can filter the data based on different columns using the search boxes provided.
- Sorting functionality is available by clicking on the column headers.
- Right-clicking on a row provides additional options for each entry.
- The application supports automatic refreshing of data based on a specified timer interval.

## Usage

1. Run the application.
2. Wait for the data to load from the databases.
3. Use the search boxes to filter data based on specific criteria.
4. Click on column headers to sort the data.
5. Right-click on rows for additional options.
6. Use the refresh button or the timer to update the data periodically.

## Known Issues

- There might be connectivity issues if the ODBC drivers are not properly installed.
- The application may crash or show unexpected behavior if there are issues with the database connections.
- Some database-specific configurations might cause errors or unexpected results.

## Disclaimer

This project was build especially for a internal use and it will not work in any other application since it is based on dedicated internal software.

## Screenshots
![ZCP QV2](https://github.com/swietlikm/ZCP_QuickView/assets/121583766/9a4b6ed6-883a-4696-ae7b-e773cba551f9)
![ZCP QV3](https://github.com/swietlikm/ZCP_QuickView/assets/121583766/2a6c9eef-5d50-481d-ad02-3e30024ddd9b)
![ZCP QV4](https://github.com/swietlikm/ZCP_QuickView/assets/121583766/778b9405-8185-4474-a2c6-638f738245d1)




