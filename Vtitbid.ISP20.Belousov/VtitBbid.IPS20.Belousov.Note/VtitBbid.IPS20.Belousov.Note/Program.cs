using Vtitvid.ISP20.Belousov.Note;

Note.CreatingArray(out int n);
Note[] array = new Note[n];
for (int i = 0; i < n; i++)
{
    array[i]= Note.CreateNote();
}
Console.WriteLine(Note.ArrayOutput(array));