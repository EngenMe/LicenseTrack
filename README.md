# License Track System

## Overview
The **License Track System** is a desktop application designed to streamline the management of driving licenses, tests, and user data. It ensures prerequisites and restrictions are enforced at every step, improving administrative efficiency and user experience.

## Key Features
- **User Management**: Register, update, and suspend user accounts with role-based permissions.
- **License Management**: Issue, renew, or revoke licenses following test completions and compliance checks.
- **Test Scheduling**: Support for vision, theory, and practical tests with prerequisite enforcement.
- **Data Validation**: Automated checks ensure all requirements are met before proceeding to subsequent steps.
- **Data Searching & Filtering**: Quickly find users or tests using robust query and filter options.

## Technology Stack
- **Language**: C#
- **Architecture**: 3-tier (Presentation, Business Logic, Data Access)
- **Database**: Microsoft SQL Server
- **Data Access**: ADO.NET with SQL queries and stored procedures
- **UI Framework**: Windows Forms (WinForms)

## Getting Started

### Prerequisites
- Windows OS
- .NET Framework or compatible .NET runtime
- Microsoft SQL Server (local or remote)
- Valid database credentials and connection string

### Installation
1. **Clone the repository**:
   ```bash
   git clone https://github.com/EngenMe/LicenseTrack.git
   ```
2. **Open the solution** in Visual Studio or your preferred IDE.
3. **Restore NuGet packages** if required.
4. **Update the database connection string** in `App.config` or the appropriate configuration file.

### Database Setup
1. **Create a new SQL Server database**.
2. **Run the provided SQL script** (e.g., `database_setup.sql`) to set up the required tables and stored procedures.
3. **Verify the connection string** to ensure it matches your SQL Server instance and database name.

### Running the Application
1. Build the solution in Visual Studio.
2. Run the application (F5 in Visual Studio or run the compiled `.exe`).
3. Log in with provided credentials or create a new admin user if supported.

## License
This project is licensed under the MIT License.
