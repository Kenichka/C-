using Vtitbid.ISP20.Belousov.Route;

Route.CreatingArray(out int n);
Route[] array = new Route[n];

for (int i = 0; i < n; i++)
{
    array[i] = Route.CreateRoute();
}
Console.WriteLine(Route.ArrayOutput(ref array));
