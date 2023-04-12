System.Console.WriteLine("Введите трехзначное число ");
int number;
while(!int.TryParse(System.Console.ReadLine(), out number)){
    System.Console.WriteLine("Это не число, Алле!!!");
}

int number1 = number / 10;
int number2 = number1 % 10;
System.Console.WriteLine(number2);