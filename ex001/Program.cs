// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Func(int b){
    
    int d = b/10%10;

    return d;
    
}

Console.WriteLine("Пожалуйста введите любое трехзначное число: ");
string a = Console.ReadLine();
int b = int.Parse(a);


while (b/100 >= 9 || b/100 == 0){
    Console.WriteLine("Вы ввели неправильное число! Пожалуста введите трехзначное число: ");
    a = Console.ReadLine();
    b = int.Parse(a);
}
int c = Func(b);
    Console.WriteLine($"Вторая цифра {b} это {c}");










