System.Console.WriteLine("Введите трехзначное число ");
int number = int.Parse(System.Console.ReadLine());

int number1 = number / 10;
int number2 = number1 % 10;
System.Console.WriteLine(number2);