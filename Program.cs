//See https://aka.ms/new-console-template for more information
//Console.WriteLine("What color is?");
//string answer = Console.ReadLine();

//if (answer == "red")
//{
//    Console.WriteLine("Stop!");
//}

//else if (answer == "yellow")
//{
//    Console.WriteLine("Ready");
//}

//else if (answer == "green")
//{
//    Console.WriteLine("Go!");
//}

//else
//{
//    Console.WriteLine("You made an error!");
//}

//Console.WriteLine("What is day now?");
//string answer2 = Console.ReadLine();

//if (answer2 == "Monday")
//{
//    Console.WriteLine("wrong!");
//}

//else
//{
//    Console.WriteLine("You are wrigth!");
//}


Console.WriteLine("Enter first number");
double firstNum = double.Parse(Console.ReadLine());

Console.WriteLine("Enter second number");
double secondNum = double.Parse(Console.ReadLine());

Console.WriteLine("Enter action");
char action = char.Parse(Console.ReadLine());

double result = 0;

//if (action == '+')
//{
//    result = firstNum + secondNum;
//}

//else if (action == '-')
//{
//    result = secondNum - firstNum;
//}

//else if (action == '*')
//{
//    result = secondNum * firstNum;
//}

//else if (action == '/')
//{
//    if (secondNum == 0)
//    {
//        Console.WriteLine("You cannot divide by 0!");
//    }

//    result = firstNum / secondNum;
//}

//else
//{
//    Console.WriteLine("You entered incorrect action");
//}

switch (action) //Дія, яку ми будемо перебирати далі
{
    case '+':
        result = firstNum / secondNum;
        break;
    case '-':
        result = secondNum - firstNum;
        break;
    case '*':
        result = secondNum * firstNum;
        break;
    case '/':
        if (secondNum == 0)
        {
            Console.WriteLine("You cannot divide by 0!");
        }

        result = firstNum / secondNum;
        break;
    default:
        Console.WriteLine("You entered incorrect action");
        break;
}

bool isActionCorrect = action == '+' || action == '-' || action == '*' || action == '/';
if (result != double.PositiveInfinity && isActionCorrect == true)
{
    Console.WriteLine($"{firstNum} {action} {secondNum} = {result}");
}
else
{
    Console.WriteLine("Something went wrong");
}


