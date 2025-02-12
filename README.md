# Infoxi (WIP)

**Infoxi** is a simple social engineering platform tailored for whitehat and bluehat cybersecurity experts, organizational analysts, and professionals in intelligence or governance. Designed to collect, manage, and analyze information about individuals and their interactions, Infoxi provides insights into social, professional, and organizational dynamics.

## Features
Infoxi has the following features:

### Core Features
1. **Authentication and User Management**
   - Leverages Microsoft Identity for secure user authentication.
   - Role-based access control with two roles: 
     - **Normal User**: Standard user role with access to core features of the platform.
     - **Administrator**: Management role with elevated permissions for site administration tasks.

2. **Data Management**
   - CRUD (Create, Read, Update, Delete) operations for storing and managing person-specific information.
   - Relational data support to map connections between individuals, including organizational hierarchies and interpersonal relationships.

3. **Data Security**
   - HTTPS ensures data in transit is secure.
   - Activity logging for audit trails to ensure transparency and accountability.

4. **Self-Hosting**
   - Designed to be self-hosted, giving organizations full control over their data and deployment environment.

5. **Containerized Deployment**
   - Docker and docker-compose are used to simplify deployment and ensure consistency across environments.

## Tech Stack
- **Programming Language**: C#
- **Framework**: ASP.NET Core MVC with Razor Pages
- **Authentication**: Microsoft Identity
- **Database**: PostgreSQL
- **Front-End**: Razor Pages
- **Hosting**: Dockerized environment with docker-compose
- **Runtime**: .NET 8

## License
Infoxi is free and open-source software licensed under the GPLv3 License. See the [LICENSE](LICENSE) file for details.

## Roadmap
Future iterations of Infoxi aim to include:
- Advanced relational mapping and visualizations.
- Data import from external sources (e.g., OSINT).
- AI-driven insights for threat detection and organizational analysis.
- Support for additional authentication methods.
