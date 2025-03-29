using static SplashKitSDK.SplashKit;
using static System.Convert;

int selection, account;
double totalMoney, availableFunds, savings, rent, loan, utilities, savingsAddition, expenses;

WriteLine("Welcome to the Monthly Budget Calculator !");
WriteLine(" ");

//making a selection out of the possible saving goals
do
{
    WriteLine("Please select your goal from the menu below:");
    WriteLine("1 - Save Maximal Money");
    WriteLine("2 - Save Moderate Money");
    WriteLine("3 - Save Minimal Money");

    Write("Enter your selection: ");
    selection = ToInt32(ReadLine());

    //preventing the selection from being anything but 0 - 3
    if (selection < 1 || selection > 3)
    {
        WriteLine("Please select a option from 0-3");
    }

} while (selection < 1 || selection > 3);


switch (selection)
{
    case 1:
        WriteLine("Save Maximal Money");
        break;
    case 2:
        WriteLine("Save Moderate Money");
        break;
    case 3:
        WriteLine("Save Minimal Money");
        break;
}

if (selection == 1)
{   
    //Monthly income
    WriteLine("What is your monthly income: ");
    availableFunds = ToDouble(ReadLine());

    //Savings amount
    WriteLine("How much do you have in your savings: ");
    savings = ToDouble(ReadLine());

    //display total money
    totalMoney = savings + availableFunds;
    WriteLine($"You have this much money: ${totalMoney}");

    //select debiting account
    do
    {
        WriteLine("Which account would you like to pay your bills from? ");
        WriteLine("1 - Debit");
        WriteLine("2 - Savings");
        account = ToInt32(ReadLine());

        if (account != 1 && account != 2)
        {
            WriteLine("Please select 1 or 2");
        }
    }while (account !=1 && account != 2);

    //rent expenses
    WriteLine("What is your monthly rent/mortgage: ");
    rent = ToDouble(ReadLine());
    
    //utilities
    WriteLine("How much is utilities: ");
    utilities = ToDouble(ReadLine());

    //credit repayments
    WriteLine("What is your monthly credit repayment: ");
    loan = ToDouble(ReadLine());

    //deducting from chosen account
    if (account == 1)
    {
        availableFunds = availableFunds - rent - utilities - loan;
        WriteLine($"You have ${availableFunds:F1} left to spare");
        savingsAddition = ToDouble(availableFunds * 0.75);
        WriteLine($"We reccomend you put ${savingsAddition} into your savings.");
        WriteLine($"You have ${availableFunds} available to spend.");
    }
    else if (account == 2)
    {
        savings = savings - rent - utilities - loan;
        expenses = rent + utilities + loan;
        WriteLine($"You have ${savings:F1} left to spare");
        WriteLine($"We strongly encourage you to transfer ${expenses} into your savings.");
    }

}
else if (selection == 2)
{
    //Monthly income
    WriteLine("What is your monthly income: ");
    availableFunds = ToDouble(ReadLine());

    //Savings amount
    WriteLine("How much do you have in your savings: ");
    savings = ToDouble(ReadLine());

    //display total money
    totalMoney = savings + availableFunds;
    WriteLine($"You have this much money: ${totalMoney}");

    //select debiting account
    do
    {
        WriteLine("Which account would you like to pay your bills from? ");
        WriteLine("1 - Debit");
        WriteLine("2 - Savings");
        account = ToInt32(ReadLine());

        if (account != 1 && account != 2)
        {
            WriteLine("Please select 1 or 2");
        }
    }while (account !=1 && account != 2);

    //rent expenses
    WriteLine("What is your monthly rent/mortgage: ");
    rent = ToDouble(ReadLine());
    
    //utilities
    WriteLine("How much is utilities: ");
    utilities = ToDouble(ReadLine());

    //credit repayments
    WriteLine("What is your monthly credit repayment: ");
    loan = ToDouble(ReadLine());

    //deducting from chosen account
    if (account == 1)
    {
        availableFunds = availableFunds - rent - utilities - loan;
        WriteLine($"You have ${availableFunds:F1} left to spare");
        savingsAddition = ToDouble(availableFunds * 0.65);
        WriteLine($"We reccomend you put ${savingsAddition} into your savings.");
        WriteLine($"You have ${availableFunds} available to spend.");
    }
    else if (account == 2)
    {
        savings = savings - rent - utilities - loan;
        expenses = rent + utilities + loan;
        WriteLine($"You have ${savings:F1} left to spare");
        WriteLine($"We strongly encourage you to transfer ${expenses} into your savings.");
    }
}
else if (selection == 3)
{
    //Monthly income
    WriteLine("What is your monthly income: ");
    availableFunds = ToDouble(ReadLine());

    //Savings amount
    WriteLine("How much do you have in your savings: ");
    savings = ToDouble(ReadLine());

    //display total money
    totalMoney = savings + availableFunds;
    WriteLine($"You have this much money: ${totalMoney}");

    //select debiting account
    do
    {
        WriteLine("Which account would you like to pay your bills from? ");
        WriteLine("1 - Debit");
        WriteLine("2 - Savings");
        account = ToInt32(ReadLine());

        if (account != 1 && account != 2)
        {
            WriteLine("Please select 1 or 2");
        }
    }while (account !=1 && account != 2);

    //rent expenses
    WriteLine("What is your monthly rent/mortgage: ");
    rent = ToDouble(ReadLine());
    
    //utilities
    WriteLine("How much is utilities: ");
    utilities = ToDouble(ReadLine());

    //credit repayments
    WriteLine("What is your monthly credit repayment: ");
    loan = ToDouble(ReadLine());

    //deducting from chosen account
    if (account == 1)
    {
        availableFunds = availableFunds - rent - utilities - loan;
        WriteLine($"You have ${availableFunds:F1} left to spare");
        savingsAddition = ToDouble(availableFunds * 0.50);
        WriteLine($"We reccomend you put ${savingsAddition} into your savings.");
        WriteLine($"You have ${availableFunds} available to spend.");
    }
    else if (account == 2)
    {
        savings = savings - rent - utilities - loan;
        expenses = rent + utilities + loan;
        WriteLine($"You have ${savings:F1} left to spare");
        WriteLine($"We strongly encourage you to transfer ${expenses} into your savings.");
    }
}
