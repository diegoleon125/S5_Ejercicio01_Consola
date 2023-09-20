Console.Write("Ingrese el número 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el número 2: ");
int num2 = int.Parse(Console.ReadLine());
int producto = 0;

for (int i = 0; i < num2; i++)
{
    producto += num1;
}
Console.WriteLine("El producto es " + producto);