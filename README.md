# To-Do List API Integration with Razor Pages

![License](https://img.shields.io/badge/license-MIT-blue.svg)

## Description

This repository demonstrates how to integrate a To-Do List API with a .NET web application using Razor Pages in Visual Studio Code. The project involves adding a new Razor Page to an existing web application and writing the necessary code to consume the API's functionality, displaying and managing to-do items.

## Features

- **Razor Pages**: Integration of Razor Pages with a web application.
- **API Consumption**: Fetching and displaying data from a To-Do List API.
- **Task Management**: Adding, updating, and deleting to-do items via the API.
- **Multiple Launch Profiles**: Support for launching the application in different environments with customizable settings.

## Installation

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [Visual Studio Code](https://code.visualstudio.com/)

### Getting Started

1. **Clone the repository:**

    ```sh
    git clone https://github.com/nikolaysm/dotnet-practice-todowebapp.git
    ```

2. **Navigate to the project directory:**

    ```sh
    cd todo-razor-page-integration
    ```

3. **Restore dependencies:**

    ```sh
    dotnet restore
    ```

4. **Open the project in Visual Studio Code:**

    ```sh
    code .
    ```

5. **Build the project:**

    ```sh
    dotnet build
    ```

6. **Run the application:**

   You can run the application using one of the defined launch profiles.

   - **For HTTP**:

     ```sh
     dotnet run --launch-profile "http"
     ```

     The application will be available at `http://localhost:5147`.

   - **For HTTPS**:

     ```sh
     dotnet run --launch-profile "https"
     ```

     The application will be available at `https://localhost:7094` and `http://localhost:5147`.

   - **For IIS Express** (if running in Visual Studio):

     The application will be launched via IIS Express and will be available at the URLs configured in the IIS settings.

## Configuration

### Launch Profiles

This project includes multiple launch profiles that define how the application should be run during development:

- **http**: Runs the application using HTTP at `http://localhost:5147`.
- **https**: Runs the application using both HTTPS at `https://localhost:7094` and HTTP at `http://localhost:5147`.
- **IIS Express**: Uses IIS Express to launch the application, configured for development with `localhost` URLs.

### Environment Variables

Each profile sets the `ASPNETCORE_ENVIRONMENT` variable to `Development` to enable development-specific features and settings.

## Usage

### Accessing the Razor Page

After running the application using one of the profiles, navigate to `/ToDo` in your browser to access the Razor Page where you can interact with the To-Do List API.

### Example API Operations

- **View Tasks**: The Razor Page will display a list of tasks fetched from the API.
- **Add Task**: Use the form on the page to add a new task to the list.
- **Edit Task**: Update existing tasks directly from the Razor Page.
- **Delete Task**: Remove tasks using the delete functionality provided.

## Razor Page Integration

The project includes a new Razor Page (`Index.cshtml`) that communicates with the To-Do List API. The code demonstrates:

- **HTTP Client Usage**: How to configure and use `HttpClient` to send requests to the API.
- **Data Binding**: Binding API data to the Razor Page for display and interaction.
- **Async Operations**: Handling asynchronous API calls within Razor Pages.

## Contributing

Contributions are welcome! Feel free to fork this repository and submit pull requests with improvements or new features.

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push the branch (`git push origin feature-branch`).
5. Create a Pull Request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more information.

## Acknowledgements
- Coursera.org
- .NET and Visual Studio Code documentation.
- Tutorials and online resources that aided in the creation of this project.
