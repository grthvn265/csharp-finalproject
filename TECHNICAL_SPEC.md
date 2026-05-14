# BizCalc Technical Specification

## 1. Project Title
BizCalc: Savings and Loan Calculator (Windows Forms, C#)

## 2. Project Overview
BizCalc is a desktop Windows Forms application for financial planning using Philippine peso.
It helps users compute savings goals and loan payments in a simple and clear way.
The app is focused on the Philippine market and uses PHP currency formatting.

The system is meant for everyday users and students who need clear, accurate results.
The interface should be clean and easy to navigate.

The purpose of BizCalc is to give users a quick way to plan savings and understand loans.
It should be beginner-friendly, accurate, and stable even with invalid input.


## 3. Purpose of the System


## 4. Target Users
- Individual users who want to plan savings and loans
- Students learning basic financial calculations
- Borrowers who want to estimate monthly payments
- Lenders who need quick payment estimates

## 5. Technology Stack
- Language: C#
- Framework: .NET Framework 4.7.2
- UI Framework: Windows Forms
- IDE: Visual Studio (WinForms Designer)

## 6. Core Features
### 6.1 Savings Calculator
Users enter target amount, interest rate, and term.
The app computes the required periodic savings deposit.

### 6.2 Loan Calculator
Users enter principal, interest rate, and term.
The app computes the periodic loan payment.

### 6.3 Login Security
A basic login screen is used before accessing the main calculator.
This protects the app from casual access.

## 7. Programming Concepts and Techniques
The app uses C# and OOP to keep the code organized.
Separate classes should handle input validation, calculations, and UI logic.

Input validation is required for all numeric fields.
Errors must show clear, helpful messages.

Financial formulas must be accurate and consistent with Philippine practice.

## 8. Functional Requirements
### 8.1 Login
- User sees Login form first.
- User enters username or password.
- If valid, the main form opens.
- If invalid, show a clear error message.

### 8.2 Savings Calculator
- Inputs: target amount, interest rate, term, and deposit frequency.
- Output: required periodic deposit and estimated timeline.
- Results should display in PHP currency format.

### 8.3 Loan Calculator
- Inputs: principal, interest rate, term, and payment frequency.
- Output: periodic payment, total payment, total interest.
- Results should display in PHP currency format.

## 9. Validation and Error Handling
- Required fields cannot be empty.
- Numbers must be valid and greater than zero (except if rules allow zero).
- Interest rate cannot be negative.
- Show clear error messages for invalid input.
- The app must not crash on incorrect data.

## 10. Financial Formula Requirements
### 10.1 Savings Goal Formula
Required periodic deposit:

PMT = (FV * i) / ((1 + i)^n - 1)

Where:
- PMT = periodic deposit
- FV = future value (goal)
- i = periodic interest rate
- n = number of periods

If interest rate is 0:

PMT = FV / n

### 10.2 Loan Payment Formula
Fixed periodic payment:

PMT = P * i * (1 + i)^n / ((1 + i)^n - 1)

Where:
- PMT = periodic payment
- P = principal
- i = periodic interest rate
- n = number of periods

If interest rate is 0:

PMT = P / n

## 11. User Interface Requirements
- Simple layout with labels and textboxes.
- Savings and Loan calculators separated by tabs or sections.
- Clear buttons: Calculate, Clear, Exit.
- Result area must be easy to read.

## 12. Non-Functional Requirements
- Usable for beginners.
- Accurate results with 2 decimal places.
- Fast response time for calculations.
- No crashes from bad input.
- Clean and consistent UI.

## 13. Testing Requirements
- Test valid inputs for savings and loans.
- Test 0% interest scenarios.
- Test empty fields and invalid text.
- Verify output is correct and formatted in PHP.

## 14. Constraints and Notes
- The app is for educational use.
- Calculations are estimates and may differ from real bank terms.
- Keep UI clean and not cluttered.

## 15. Future Enhancements (Optional)
- Export results to CSV or PDF.
- Add charts for savings growth.
- Add user profiles with a local database.
