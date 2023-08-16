

Double balance;
balance = 0;

int b, c;

while (true)
{


    Console.WriteLine("wollcom");

    Console.WriteLine("TO DEPOSIT , PRESS 1");


    Console.WriteLine("TO WITHDRAW 2");


    Console.WriteLine("TO CANCEL THE PROCESS,PRESS 3"); 

    Console.WriteLine("enter number");

    b = int.Parse(Console.ReadLine());


    switch (b)
    {
        case 1:
            Console.WriteLine("ENTER THE AMOUNT YOU WANT TO DEPOSIT ");
            c = int.Parse(Console.ReadLine());
            balance = balance + c;
            break;

        case 2:

            Console.WriteLine("ENTER THE AMOUNT YOU WANT TO WITHDRAW");
            c = int.Parse(Console.ReadLine());
            {
                if (balance < c)
                {
                    Console.WriteLine("erro");

                }
                else
                {
                    Console.WriteLine($"success withdarw {c}");
                    balance = balance - c;
                }                 
                
            }
            break;


        case 3:

            Console.WriteLine("THANK YOU FOR USING THE ATM ");

            break;

    }
    if (b == 3)
    {
        break;
    }
}

Console.ReadKey();








