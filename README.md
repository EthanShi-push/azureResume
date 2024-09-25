
# Azure Resume Project
This is my simple website practicing my experience with Azure service with example as Azure functions, blob storage, resource groups and Github Actions
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
  
### Result project website url:
https://azureresumefinal.z19.web.core.windows.net/#home
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

