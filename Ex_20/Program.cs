// Задача 20: Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());
 if(num == 1)
 {
 Console.WriteLine("диапазоны для возможных координат: х > 0; y > 0");
 } 
 if(num == 2)
 {
 Console.WriteLine("диапазоны для возможных координат: х < 0; y > 0");
 } 
  if(num == 3)
 {
 Console.WriteLine("диапазоны для возможных координат: х < 0; y < 0");
 } 
  if(num == 4)
 {
 Console.WriteLine("диапазоны для возможных координат: х > 0; y < 0");
 } 
