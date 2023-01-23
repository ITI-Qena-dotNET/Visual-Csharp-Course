namespace Lab1;

public class Phonebook
{
    Dictionary<int, string> _phonebook = new()
    {
        { 123 , "Ali" },
        { 456, "Hossam" },
    };

    public string this[string i]
    {
        get { return _phonebook[int.Parse(i)]; }
        set { _phonebook[int.Parse(i)] = value; }
    }

    public string this[int i]
    {
        get { return _phonebook[i]; }
        set { _phonebook[i] = value; }
    }
}
