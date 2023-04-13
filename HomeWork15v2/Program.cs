System.Console.WriteLine("Введите день недели: ");
int number = int.Parse(Console.ReadLine());
if(number <= 5){
    System.Console.WriteLine("Рабочий день");
}
else{
    System.Console.WriteLine("Выходной");
}