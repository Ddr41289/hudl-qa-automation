# hudl-qa-automation
This guide will walk you through setting up this Selenium automated testing project.  The project utilizes Selenium with C# and NUnit Framework.  These instructions assume that you are using Visual Studio Code or Visual Studio, but similar steps can be taken with other IDEs and code editors.

## Prerequisites
Before you start, ensure you have the following installed:

1. **Visual Studio:** An integrated development environment for creating applications on Windows.

    * Download and install Visual Studio from the official website: https://visualstudio.microsoft.com/
2. **Visual Studio Code (VS Code):** A lightweight code editor.
    * Download and install VS Code: https://code.visualstudio.com/
3. **Git:** A version control system for tracking changes in code.
    * Download and install Git: https://git-scm.com/downloads
4. **NUnit:** A unit testing framework for C#.
    * NUnit is included in the project and will be installed automatically.
5. **Selenium WebDriver:** A tool for automating web browser interaction.
    * The project uses Selenium WebDriver and its packages will be installed automatically.

## Project Setup
Follow these steps to set up and run the existing **hudl-qa-automation** project:

1. ## Clone the GitHub Repository:
    * Open a command prompt or terminal.
    * Navigate to the directory where you want to clone the repository.
    * Run the following command to clone the repository:
```
git clone https://github.com/Ddr41289/hudl-qa-automation.git
```
2. ## Open the Project in Visual Studio:
    * Launch Visual Studio.
    * Click on "Open a project or solution."
    * Navigate to the directory where you cloned the repository and open the hudl-qa-automation.sln solution file.
3. ## Open the Project in Visual Studio Code:
    * Launch VS Code.
    * Click on "File" > "Open Folder."
    * Navigate to the directory where you cloned the repository and select the hudl-qa-automation folder.
4. ## Restore NuGet Packages:
    * Visual Studio should automatically restore the required NuGet packages based on the project configuration. If not, you can right-click on the solution in Solution Explorer and select   "Restore NuGet Packages."
5. ## Running Tests:
    * Build your project (Ctrl + Shift + B in Visual Studio) to ensure there are no compilation errors.
    * Open the Test Explorer in Visual Studio (Test > Test Explorer).
    * Click the "Run All" button to execute the tests or run each individually
6. ## Modifying Tests: 
    * The existing project includes sample test cases. You can modify these tests or add new ones to suit your needs.
    * Tests are organized in the Tests directory.
7. ## WebDriver Configuration:
    * WebDriver configurations (e.g., browser type, URL) are present in the WebDriverConfig.cs file within the Helpers directory.
8. ## Updating WebDriver Binaries:
    * WebDriver binaries (e.g., chromedriver.exe) are located in the WebDriver directory.
    * To update these binaries, replace them with the latest version compatible with your browser version.
## Note on Wait Methods
Please be aware that you might need to adjust your wait methods in the project. There were instances of the hudl.com/products/hudl page loading instead of the Log In screen due to timing. This could affect the ability to assert the page title as "Log In." This timing issue might not affect standard users, as they wouldn't be interacting with the UI at this speed. Sometimes the automation could reach the page where credentials are entered, but more work is needed to make the automation work as expected.
## Conclusion 
You've successfully set up the existing **hudl-qa-automation** Testing project from the provided GitHub repository using either Visual Studio or Visual Studio Code. Feel free to explore, modify, and expand the project according to your testing requirements. Happy testing!
