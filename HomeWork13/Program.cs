System.Console.WriteLine("Введите число ");
string number = System.Console.ReadLine();
int numberCount = number.Length;
System.Console.WriteLine("Количество цифр в строке = " + numberCount);

if(number.Length == 2){
    System.Console.WriteLine("Третьей цифры нет");
    }
else if(number.Length <= 1){
    System.Console.WriteLine("Нет 2х цифр");
    }
else{
int number1 = 2;
int number2 = number.ToString()[number1] - '0';
System.Console.WriteLine(number2);
}
