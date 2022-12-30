// Напишите программу которая на вход принимает число (А) и выдает сумму чисел от 1 до А




// int SumNam(int num){
//     int summ = 0;
//     for(int i = 1; i<=num; i++)
//         summ += i;
//     return summ;
// }
// Console.Write("Введи");
// int num = Convert.ToInt32(Console.ReadLine());
// int summ = SumNam(num);
// Console.WriteLine($"Summ of numbers from 1 to {num} is {summ}");

// int SumNam(int num){
//     int summ = 0;
//     int i = 1;
//     while(i<=num){
//         summ +=i;
//         i++;
//     }
//     return summ;
// }
// Console.Write("Введи");
// int num = Convert.ToInt32(Console.ReadLine());
// int summ = SumNam(num);
// Console.WriteLine($"Summ of numbers from 1 to {num} is {summ}");

// Напишите программу которая принимает на вход число N и выдает произведение чисел от 1 до N


// int Umn(int num)
// {
//     if (num < 0)
//     {num = num * (-1);
//     }
//     int umn = 1;
//     for (int i = 2; i <= num; i++)
//     {
//         umn= umn * i;
//     }
//     return umn;
// }

// System.Console.WriteLine("Namber? ");
// int num = Convert.ToInt32(Console.ReadLine());
// int mnoj = Umn(num);
// System.Console.WriteLine($"Proizv {num} raven {mnoj}");


// Напишите программу которая выводит массив из 8 элементов заполненных нулями и единицами 
// в случайном порядке.

// int[] Array()
// {
//     int [] arr = new int [8];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0,2);
//     }
//     return arr ;
//     }
//     void ShowArray (int[] arr)
//     {
//         for (int i = 0; i < arr.Length; i++)
//         {
//             System.Console.Write($"{arr[i]} ");
//         }
            
//     }
//     ShowArray(Array());



// Массив из 0 и единиц в рандомном порядке 

//     int[] Array(int numb)
// {
//     int [] arr = new int [numb];
//     for (int i = 0; i < numb; i++)
//     {
//         arr[i] = new Random().Next(0,2);
//     }
//     return arr ;
//     }
//     void ShowArray (int[] arr)
//     {
//         for (int i = 0; i < arr.Length; i++)
//         {
//             System.Console.Write($"{arr[i]} ");
//         }
            
//     }
//     System.Console.WriteLine("Write");
//     int lengthMass = Convert.ToInt32(Console.ReadLine());
//     ShowArray(Array(lengthMass));









// //                                    Задача 25

//     int Stepen(int Osn, int Step)
// {
//     int res = 1;
//     while (Step > 0)
//     {
//         res *= Osn;
//         Step--;
//     }
//     return res;
// }
// Console.Write("Введите основание степени: ");
// int Osn = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите показатель степени: ");
// int Step = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{Osn}, {Step} -> " +
//     $"{Stepen(Osn, Step)} ");







// //                                    Задача 27

// int Summ(int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         sum += num % 10;
//         num /= 10;
//     }

//     return sum;
// }

// Console.Write("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{num} -> {Summ(num)}");




// //                                    Задача 29

// int lenArray = ReadInt("Введите длинну массива: ");

// int[] randomArray = new int[lenArray];
// for (int i = 0; i < randomArray.Length; i++)
// {
//     randomArray[i] = new Random().Next(1,9);
//     Console.Write(randomArray[i] + " ");
// }

// int ReadInt(string mes)
// {
//     Console.Write(mes);
//     return Convert.ToInt32(Console.ReadLine());
// }