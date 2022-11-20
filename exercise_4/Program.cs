// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
    if (N %2 == 0)  
     { while (i < N)
       { 
       Console.WriteLine(i + ", "); 
       i = i +2; 
       }

    Console.Write(N + ". ");
     }
    else
    {  while (i < N-1)
        {
        Console.WriteLine(i + ", "); 
        i = i +2; 
        }
        Console.WriteLine(N-1 + ". ");
    }
    

