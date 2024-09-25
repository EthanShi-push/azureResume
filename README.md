
# Azure Resume Project

This project implements a full-stack web application designed to track the number of times a resume is viewed. 
It features a backend API built with .NET and a frontend developed with HTML/CSS and JavaScript, all hosted on Microsoft Azure. 

## Features

### Backend
- **Azure Functions**: Serverless function that tracks the number of resume views.
- **Cosmos DB**: Used as the backend database to store view counts.
- **C#**: Backend logic implemented in C# with a focus on scalability and performance.
- **API Endpoints**: The function exposes API endpoints that interact with Cosmos DB to retrieve and update the view counter.

### Frontend
- **HTML/CSS/JavaScript**: The frontend interface that displays the resume view counter.
- **Azure Blob Storage**: The frontend is hosted as a static website on Azure Blob Storage.
- **Responsive Design**: Designed to work seamlessly on both desktop and mobile devices.

### CI/CD Pipeline
- **GitHub Actions**: Implemented GitHub Actions workflows for continuous deployment.
  - Frontend application deployment to Azure Blob Storage.
  - Backend application deployment to Azure Functions.

## Installation and Setup

### Prerequisites
- .NET Core SDK
- Azure CLI
- Git
- Node.js (for frontend development)
  
### Steps to Run Locally
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/your-repo/azure-resume.git
   cd azure-resume
   ```

2. **Backend Setup**:
   - Navigate to the backend folder and run the following commands:
   ```bash
   cd backend/api
   dotnet restore
   dotnet run
   ```
   - Ensure you have the appropriate Cosmos DB connection string in your `local.settings.json` file.

3. **Frontend Setup**:
   - Navigate to the frontend folder and open `index.html` in a browser or deploy it to a web server.
   - For development, you can use a simple static server to serve the files.

4. **Deploy to Azure**:
   - Follow the instructions in the GitHub Actions workflows to deploy the frontend and backend to Azure.

## Project Structure
```bash
├── backend
│   ├── api
│   │   ├── Counter.cs
│   │   ├── GetResumeCounter.cs
│   │   └── api.csproj
│   └── tests
├── frontend
│   ├── index.html
│   ├── style.css
│   └── script.js
└── .github
    └── workflows
```

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
