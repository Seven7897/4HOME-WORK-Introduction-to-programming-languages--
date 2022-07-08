
Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0 ;
while(number != 0 )
{
    result = result + ( number % 10 ) ;
    number /= 10 ;
}
Console.WriteLine();
Console.WriteLine(result);


/*Console.WriteLine("Введите строку:");
string? input = Console.ReadLine();
 
bool result = int.TryParse(input, out var number);
if (result == true)
    Console.WriteLine($"Преобразование прошло успешно. Число: {number}");
else
    Console.WriteLine("Преобразование завершилось неудачно");
*/