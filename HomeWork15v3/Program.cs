System.Console.WriteLine("Введите день недели: ");
int dayOfWeek = int.Parse(System.Console.ReadLine());
int dayOfWeek1 = dayOfWeek - 1;

if(dayOfWeek1 <= 5)
{
    System.Console.WriteLine("Это рабочий день");
    string[] array = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
    System.Console.WriteLine(array[dayOfWeek1]);
}
else
{
System.Console.WriteLine("Это выходной");
string[] array = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
System.Console.WriteLine(array[dayOfWeek1]);
}