/Non-commercial use: This project is for coursework/resume use only; not for commercial distribution/

Title:
Budge It App

Purpose:
Budge-iT is a visual money tracker for students at UTA, to help them meet their financial goals and designed to help students have more control and management over their finances. 
The Budge-iT app will track and categorize spending and savings into percentages, as well as provide visuals of their budgeting in form of different charts and have positive alerts when personal budgets are close to or reach their goals.

How to Install and Run:
 1. Clone the repo: git clone <repo-url>
 2. Open the project folder BudgeItApp in IntelliJ IDEA (File → Open).
 3. 3Wait for IDEA to index and download dependencies (if prompted).
 4. Build the project: Build → Build Project.
 5. Run the app: Run → Run 'Main' (or the appropriate run configuration).
    Troubleshooting:
        If dependencies fail, ensure JDK is installed (Go to the Official JDK website to download the file: https://www.oracle.com/java/technologies/downloads/) and selected: File → Project Structure → Project SDK.
        If build tools are used (Gradle/Maven), run from terminal: ./gradlew run or mvn spring-boot:run.

Optional notes: Required JDK: 18.0.2.1 (for optimal use)
    Dependencies: Gradle/Maven — mention which and include command examples.

Preconditions: 
The user should know paycheck amounts and have internet connection as well a computer and IDEA, Windows preferrably. 

Test Steps:
  1. Open the Budge-iT app
  2. Wait for the page to load and locate the “Start Saving!” button and click to go to the next screen
  3. Navigate to the Deposit page and enter unique values for the “Date” and “Paycheck Amount” fields. Also pick an option from the “Percentage Split” field. Browse to the bottom to see updated split amounts of the input paycheck amount. Then once done with inputs locate the “Track button” and click to go to the next screen.
  4. Navigate to the Tracking page and enter a unique value for a “Goal Amount”. Browse through the page to see how close you are to the input goal. Next locate the “Split” button and click to go to the next page. 
  5. Navigate to the Split budget page where you will be able to see how your accumulated amounts have split into savings, spending and other categories. Once done browsing locate the “Deposit” button to go back to the deposit page or locate and click the arrow at the top left of the page to return to the last visited page.
     
Expected Results:
The user should be able to visualize and track their money through the app successfully. 
