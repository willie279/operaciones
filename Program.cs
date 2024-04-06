// detecction de sort() y reverse()
string[] pallets = { "B14", "A11", "B12", "A13", "c5" };
Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"--- {pallet}");
}
Console.WriteLine("");
Console.WriteLine("Reverse...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"--- {pallet}");
}
// metodo clear() "y resize()
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2); // me borra dos elementos comenzando en la poscion 0
if (pallets[0] != null) // busca el valor null y me evita la exception 
{
    Console.WriteLine($"after: {pallets[0].ToLower()}");
}
Console.WriteLine($"Clearing 2... count: {pallets.Length}"); // no me muestra la matriz porque no la estoyr recorriendo
foreach (var pallet in pallets)
{
    Console.WriteLine($"--- {pallet}");

}
// cambio de tamaño de la matriz para agregar mas elementos
Console.WriteLine("");
Array.Resize(ref pallets, 6);// me amplia la matriz a una de 6 elementos,
Console.WriteLine($"Resizing 6... count: {pallets.Length}");
pallets[5] = "F15";
foreach (var pallet in pallets)
{
    Console.WriteLine($"---- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);// reduzco la matriz a una de 3 elementos,
Console.WriteLine($"Resizing 3... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"---- {pallet}");
}

// uso de ToCharArray

string value7 = "ABC123";
char[] valueArray = value7.ToCharArray();// crea una matriz tipo char[]
Array.Reverse(valueArray);
string nextResult = new string(valueArray);
Console.WriteLine(nextResult);
foreach (var valueArrays in nextResult)
{
    Console.WriteLine(valueArrays);

}
// uso del metodo Join() y split()
string value8 = "AaBbCc";
char[] valueArray1 = value8.ToCharArray();// crea una matriz tipo char[]
Array.Reverse(valueArray1);
string nextResult1 = String.Join(",", valueArray1);
Console.WriteLine(nextResult1);
string[] items = nextResult1.Split(',');
foreach (var item in items)
{
    Console.WriteLine(item);
}