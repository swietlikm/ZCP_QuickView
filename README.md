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
![ZCP QV](https://github.com/swietlikm/ZCP_QuickView/assets/121583766/c3ab22a6-1b04-4b84-8283-bdc2713ea8eb)
![ZCP QV2](https://github.com/swietlikm/ZCP_QuickView/assets/121583766/db988321-7ade-4308-b6b1-639cd8cf6ef8)
![ZCP QV3](https://github.com/swietlikm/ZCP_QuickView/assets/121583766/f5d4e4ea-0063-4279-a180-472828a7097e)
![ZCP QV4](https://github.com/swietlikm/ZCP_QuickView/assets/121583766/d6bb1206-971b-4ad1-8ca1-123342d4c7c3)



