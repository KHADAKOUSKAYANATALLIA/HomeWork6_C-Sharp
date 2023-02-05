/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

Console.WriteLine("Введите массив целых чисел через пробел: ");
string input = Console.ReadLine()!;
string[] numberStrings = input.Split(" "); // лежит массив строк, который нужно распарсить
int[] numbers = new int[numberStrings.Length]; // создаем новый массив, который по размерности равен тому что получилось распарсить

void FindPositiveNumber(int [] number){

int count = 0;

for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = int.Parse(numberStrings[i]);
                        
        if(numbers[i] > 0)
            {
            count++;
            } 
    }   
    
Console.WriteLine($"Кол-во элементов > 0: {count}"); 

}
    

void PrintArray(int [] numbers) 
{
     {
        Console.Write("Ваш массив: ");
        Console.WriteLine(String.Join(", ", numbers));
     }
}

FindPositiveNumber(numbers);
PrintArray(numbers);
