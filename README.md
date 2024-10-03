# Tournament Tracker

Tournament Tracker is a Windows Forms (.NET) application designed to simplify the management and tracking of tournaments. It allows users to create tournaments, add teams, and manage prizes with ease. The application offers flexible data storage options, supporting both SQL databases and text files.

## Features

- **Prize Management**: Create and manage prizes with details like amount, place number, and place name.
- **Tournament Creation**: Set up new tournaments by entering the tournament name, selecting teams, adding prizes, and defining matchups.
- **Data Storage Options**: Store data in a SQL database or text files, allowing for flexibility based on user preference or system requirements.

## Project Structure

- **TrackerLibrary**: 
  - `DataAccess`: Contains classes for database and text file connections.
  - `Models`: Defines the data models used in the application.

- **TrackerUI**: 
  - UI for creating and managing prizes,teams,tournaments.

## Getting Started

### Prerequisites

- .NET Framework (4.7.2 or later)
- Visual Studio 2019 or later

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/Nilesh-Parit/Tournament_Planner.git
2. Open the solution in Visual Studio.
3. Restore NuGet packages and build the solution.

### Usage
- Run the application from Visual Studio.
- Use the UI to create prizes and tournaments.
- Choose the data storage method (SQL or text file) by configuring GlobalConfig.cs.

### Data Storage Configuration
- SQL Storage: Make sure to set up the appropriate SQL database and configure connection strings in SQLConnector.cs.
-  Text File Storage: No additional setup is required; data will be stored in text files in the application's directory.

### Contributing
Contributions are welcome! Please follow these steps:
1. Fork the repository.
2. Create a new branch (git checkout -b feature/YourFeature).
3. Commit your changes (git commit -am 'Add new feature').
4. Push to the branch (git push origin feature/YourFeature).
5. Create a new Pull Request.
