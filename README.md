/This project is for showcase/resume use only.  
This project contains both code and design materials.

- **Code**: All rights reserved. Not licensed for reuse, modification, or commercial use.
- **Designs, screenshots, wireframes, and prototypes**: Licensed under [CC BY-NC-ND 4.0](https://creativecommons.org/licenses/by-nc-nd/4.0/).  
  You may share them with credit, but no modifications or commercial use allowed.   / 

Title:
Budge It App

Purpose:
Budge-iT is a visual money tracker for students at UTA, to help them meet their financial goals and designed to help students have more control and management over their finances. 
The Budge-iT app will track and categorize spending and savings into percentages, as well as provide visuals of their budgeting in form of different charts and have positive alerts when personal budgets are close to or reach their goals.

Preconditions: 
The user should know paycheck amounts and have internet connection as well a computer and IDE, Windows preferrably. 

Notes: Required .NET SDK: .NET 8
NuGet dependencies:

    Microsoft.Maui.Controls — 8.0.0
    Microsoft.Maui.Controls.Compatibility — 8.0.0
    Microsoft.Extensions.Logging.Debug — 8.0.0

How to Install and Run:
 1. Clone the repo: git clone <repo-url>
 2. Open the project folder BudgeItApp in IDE (File → Open). This is a .NET MAUI project, Visual Studio, preferred. IntelliJ is not Supported for .NET projects.
 3. Wait for IDEA to restore NuGet packages and index the project.
 4. Build the project: Build → Build Solution.
    Command line: dotnet build
 5. Run the app: Visual Studio: select target (Android/iOS/Windows/MacCatalyst) and Run.
    Troubleshooting:
        If dependencies package restore fails, ensure .NET 8 SDK is installed and active. Check with command: dotnet --version

Test Steps:
  1. Open the Budge-iT app 
  2. Wait for the page to load and locate the “Start Saving!” button and click to go to the next screen ![Image Alt](https://github.com/EveSans/BudgeItApp/blob/master/App%20Screenshots/SSBIt1.jpg?raw=true)
  
  3. Navigate to the Deposit page and enter unique values for the “Date” and “Paycheck Amount” fields. Also pick an option from the “Percentage Split” field. Browse to the bottom to see updated split amounts of the input paycheck amount. Then once done with inputs locate the “Track button” and click to go to the next screen. ![Image Alt](https://github.com/EveSans/BudgeItApp/blob/master/App%20Screenshots/SSBIt2.jpg?raw=true) ![Image Alt](https://github.com/EveSans/BudgeItApp/blob/master/App%20Screenshots/SSBIt3.jpg?raw=true)
  
  4. Navigate to the Tracking page and enter a unique value for a “Goal Amount”. Browse through the page to see how close you are to the input goal. Next locate the “Split” button and click to go to the next page. ![Image Alt](https://github.com/EveSans/BudgeItApp/blob/master/App%20Screenshots/SSBIt4.jpg?raw=true) 
  
  5. Navigate to the Split budget page where you will be able to see how your accumulated amounts have split into savings, spending and other categories. ![Image Alt](https://github.com/EveSans/BudgeItApp/blob/master/App%20Screenshots/SSBIt5.jpg?raw=true)
  
  6. Once done browsing locate the “Deposit” button to go back to the deposit page or locate and click the arrow at the top left of the page to return to the last visited page. ![Image Alt](https://github.com/EveSans/BudgeItApp/blob/master/App%20Screenshots/SSBIt6.jpg?raw=true)
     
Expected Results:
The user should be able to visualize and track their money through the app successfully. 
