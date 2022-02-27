// Задача 18: Проверить истинность утверждения
// ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// !(X | Y) = !X & !Y // !=логическое "не"; |=логическое "или"; &=логическое "и"

bool x = true;
bool y = false;

bool res = !(x | y) == !x & !y;
if (res) 
{
    Console.WriteLine("Утверждение истинно" );
}
else
{
    Console.WriteLine("Утверждение ложное" );
}
