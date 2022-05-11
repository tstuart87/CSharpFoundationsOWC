Methods _key = new Methods();


_key.FullName("trevor", "stuart");

Console.WriteLine(_key.FullName("Trevor", "Stuart"));

string first = "Taylor";
string last = "Dickens";

string fullName = _key.FullName(last, first);

Console.WriteLine(fullName);

public class Methods
{
    // int x = ExplainMethod(3);  //Variables must have the same datatype as the method's return type.

    public void ExplainMethod(int x)
    {
        //Method Body
        Console.WriteLine("PUBLIC is the Access Modifier.");
        Console.WriteLine("VOID is the Return Type.");
        Console.WriteLine("ExplainMethod is the Name");
        Console.WriteLine("int x is the Parameter");
        Console.WriteLine("NAME + PARAMS = SIGNATURE");
    }

    public string FullName(string first, string last)
    {
        return $"{first} {last}";
    }

}

