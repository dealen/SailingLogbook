# SailingLogbook

A responsive web application for creating and managing sailing logbook entries. It can be used on both desktop and mobile devices.

## Features

- **Add Log Entries:** Record details about your sailing trips, including:
    - Date and Time
    - Weather conditions
    - Wind speed and direction
    - GPS Position
    - Skipper
    - Crew members
    - General notes
- **Voice Notes:** Use your microphone to dictate notes, which will be transcribed into text.
- **Local Storage:** Log entries are saved in your browser's local storage, so your data persists between sessions.
- **View Logs:** Review all your past log entries in a clear, tabular format.
- **Responsive Design:** The application interface adapts to different screen sizes.

## Technology Stack

- **Frontend:** Blazor WebAssembly
- **Language:** C#
- **Framework:** .NET (requires .NET 8.0 SDK or later)

## How to Run

1.  **Prerequisites:**
    *   Ensure you have the [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) (or a later version) installed.

2.  **Clone the Repository (Example):**
    ```bash
    git clone <repository-url>
    cd SailingLogbook
    ```
    (Note: In the current development environment, the project files are already present.)

3.  **Run the Application:**
    Open your terminal or command prompt, navigate to the `SailingLogbook` project directory (the one containing `SailingLogbook.csproj`), and run one of the following commands:
    *   For development with hot reload:
        ```bash
        dotnet watch run
        ```
    *   To simply build and run:
        ```bash
        dotnet run
        ```

4.  **Open in Browser:**
    The application will typically be available at `http://localhost:XXXX` or `https://localhost:YYYY`, where XXXX and YYYY are port numbers shown in the terminal output (e.g., `http://localhost:5138` or `https://localhost:7029`). Open this URL in your web browser.
