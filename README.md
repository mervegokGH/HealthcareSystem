# Healthcare Management System API

## Description
This is a RESTful API built using ASP.NET Core and EF for managing healthcare operations such as:
- Patient records
- Appointments
- Prescriptions
- (Future) Google Maps integration for facility directions

## Setup Instructions
1. Install .NET SDK and MySQL
2. Update connection string in `appsettings.json`
3. Run:
   ```sh
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   dotnet run --project HealthcareSystem
   ```
4. Access API via Swagger at `https://localhost:5001/swagger`

## Feedback
- **AI Support:** Effective and time-saving
- **Time Taken:** ~30-40 minutes
- **Manual Edits:** Minor connection string config
- **Challenges:** Setting up local database
- **Tips:** Be clear about requirements from the start

## To Do (Optional)
- Integrate Google Maps API to return directions from address input
