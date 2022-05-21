// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


int Func(int a){

    
    int b = a;                                                              // пересохраняем исходные данные в новую переменную
    if (a < 100){
        Console.WriteLine($"В числе: {b} нет третьей цифры");
    }
    else{
        
        int count = 1;                                          
        int x = Convert.ToInt32(Math.Pow(10, count));                       // переменная для возведения 10 в степень count
        while (a > 10){                                                     // в цикле выясняем сколько всего цифр в числе
        
            a = a/x;
            count ++;
        }
        int y = b/Convert.ToInt32(Math.Pow(10, count-3))%10;                // вычисляем 3 цифру начального числа
        Console.WriteLine($"Третья цифра числа: {b}, это - {y}");

        return y;
    } 
    return b;  

}

int a = new Random().Next(1, 999999999);

Func(a);


