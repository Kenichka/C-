using System;
using Vtitbid.ISP20.Belousov.Bill;

Bill.CreatingArray(out int n);
Bill[] array = new Bill[n];

for (int i = 0; i < n; i++)
{
    array[i] = Bill.CreateBill();
}
Console.WriteLine(Bill.ArrayOutput(array));
