Console.WriteLine("Hello, my name is Jekaterina! ");
Console.WriteLine("What is your name? ");
string userName = Console.ReadLine();
string userGreeting = "Hello, " + userName + "!";
Console.WriteLine(userGreeting);
Console.WriteLine("How old are you? ");
string userNumberText = Console.ReadLine();
int userNumber = int.Parse(userNumberText);
int result = userNumber + 1;
Console.WriteLine("Next year you will be " + result);
Console.WriteLine("Can you please write help me with a test and write the first number? ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Can you please write the second number? ");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Can you please write the third number? ");
int thirdNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Can you please write the fourth number? ");
int fourthNumber = int.Parse(Console.ReadLine());
int firstMaxNumber = Math.Max(firstNumber, secondNumber);
int secondMaxNumber = Math.Max(thirdNumber, fourthNumber);
int maxNumber = Math.Max(firstMaxNumber, secondMaxNumber);

Console.WriteLine("The largest number is " + maxNumber);

Console.WriteLine("So, that was funny, let us try other way! ");

Console.WriteLine("Can you please write the fifth number? ");
int fifthNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Can you please write the sixth number? ");
int sixthNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Can you please write the seventh number? ");
int seventhNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Can you please write the eight number? ");
int eightNumber = int.Parse(Console.ReadLine());
int fifthMinNumber = Math.Min(fifthNumber, sixthNumber);
int sixthMinNumber = Math.Min(seventhNumber, eightNumber);
int minNumber = Math.Min(fifthMinNumber, sixthMinNumber);

Console.WriteLine("Thank you, the smallest number is " + minNumber);

Console.WriteLine("I would like to try one more test! ");

Console.WriteLine("Can you please write number hundred? ");
int hundredNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Can you please write number ten? ");
int tenNumber = int.Parse(Console.ReadLine());

int leftafter = tenNumber % hundredNumber;
Console.WriteLine("So, from hundred, ten is " + leftafter);

Console.WriteLine("Now i will need your help in my next course task ");

Console.WriteLine("Please, write a number ");
int number = int.Parse(Console.ReadLine());
bool isEven = number % 2 == 0;
Console.WriteLine("Number is pair number: " + isEven);

Console.WriteLine("Can you please help me a bit with math. I need your help with calculating the area of a rectangle? ");

Console.WriteLine("Like before, please write a number ");
int firstRectangleNumber = int.Parse(Console.ReadLine());
Console.WriteLine("And a second number ");
int secondRectangleNumber = int.Parse(Console.ReadLine());
int area = firstRectangleNumber * secondRectangleNumber;
Console.WriteLine("The area of a rectangle is " + area);
Console.WriteLine("Now we have an answer! Thank you! ");
Console.WriteLine("And tere are left only 2 questions, now i need to find the area of a right triangle ");
Console.WriteLine("Please, write a number of first side of triangle ");
int triangleFirstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Please, write a number of second side of triangle ");

int triangleSecondNumber = int.Parse(Console.ReadLine());

double Max = (triangleFirstNumber + (double)triangleSecondNumber) / 2;

Console.WriteLine("The area of a right triangle is " + (double)Max);
Console.WriteLine("And the last one! ");

Console.WriteLine("Please, write your name! ");
string userName2 = Console.ReadLine();
Console.WriteLine("Please, write your age! ");
int userAge = int.Parse(Console.ReadLine());
Console.WriteLine($"Hello {userName2}, your age is {userAge}.");

