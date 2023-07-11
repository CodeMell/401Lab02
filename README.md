# 401Lab02

## Summary
This application is a simulated program that mimics the functionality of an ATM. It provides basic banking operations such as viewing balance, making withdrawals, and depositing funds. The application is implemented using C# and runs in the console environment.

## Display of Application
![lab02 application](https://github.com/CodeMell/401Lab02/blob/lab02/Screenshot%202023-07-11%20100229.jpg)
## Steps
1. Run the application.
2. The console interface will prompt you to choose an option.
3. Enter the corresponding number for the desired operation:		
    - 1 - View Balance: Displays the current balance in the account.
    - 2 - Withdraw: Allows you to withdraw funds from the account.
    - 3 - Deposit: Lets you deposit funds into the account.
    - 4 - Exit: Terminates the application.
4. Follow the on-screen instructions to perform the desired banking operation.
5. The application will continue running until you choose to exit.

## Details
- The application prevents the user from withdrawing more money than what's available in the account.
- It also enforces a minimum withdrawal amount of zero and disallows negative deposits.
