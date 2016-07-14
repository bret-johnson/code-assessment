using System;

int  i, j, k;
string b = "Bret";
bool tru = true;
bool fal;
double db1 = 7.80f;
decimal d = 7.8m;


void SayHello(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

SayHello();
SayHello("Bret");



var closeFriends =
    new List<string>
    {
"Alex",
"Nathan",
"Nick",
"Jonathan",
    };


public class Customer
{
    private string FirstName;
    private string CustGender;
    private string CustPurchase;

    public Customer(string firstName, string gender, string purchase)
    {
        Console.WriteLine("Customer Info");
        FirstName = firstName;
        CustGender = gender;
        CustPurchase = purchase;

        Console.WriteLine($"Hello {firstName}, thank you for purchasing {purchase}. We hope you enjoy it!");
        Console.WriteLine($"Hello {firstName}, We wanted to let you know there is a sale coming up 4/1/2016.");
        Console.WriteLine($"Hello {firstName}, We wanted to let you know there is a sale on Apple iPhones coming up on 4/1/2016.");
    }
}

enum custInfo { Male, Female, Unknown};

public class InactiveCustomer
{
    private string FirstName;
    private string MonthsInactive;
}

public class InactiveCustomer

    public inactiveCust(string firstName, string monthsInactive)
{
    Console.WriteLine($"Thanks for shopping with us {name}. We saw that you purchased an {purchase} from us {monthsInactive} months ago. We'd like to konw if you'd like to take a look at some of our current deals.");
}
class overRide
{
    public override string ToString()
    {
        return base.ToString();
    }
} 

    
