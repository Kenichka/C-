using Vtitbid.ISP20.Belousov.Price;
Price.CreatingArray(out int n);
Price[] array = new Price[n];

for (int i = 0; i < n; i++)
{
    array[i] = Price.CreatePrice();
}
Console.WriteLine(Price.ArrayOutput(array));

