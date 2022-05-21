// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void Func(int b){
    object[] Week = {"0", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
    if (b == 7 || b == 6){

        Console.WriteLine($"Сегодня {Week[b]} - это выходной!");

    }
    else{
        Console.WriteLine($"Сегодня {Week[b]} - это рабочий день!");
    }
    
}
Console.WriteLine("Введите число от 1 до 7.");
string a = Console.ReadLine();
int b = int.Parse(a);
while (b < 1 || b > 7){
    Console.WriteLine("Такого дня недели не существует! Введите цифру повторно:");
    a = Console.ReadLine();
    b = int.Parse(a);
}
Func(b);