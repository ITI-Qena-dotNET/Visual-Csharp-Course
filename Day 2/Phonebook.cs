namespace Lab2;

public class Phonebook
{
    public Dictionary<int, string> _phonebook = new();

    public string this[int i]
    {
        get { return _phonebook[i]; }
        set { _phonebook[i] = value; }
    }

    public int this[string i]
    {
        get { return _phonebook.ContainsValue(i) ? _phonebook.First(x => x.Value == i).Key : default; }
        set { _phonebook[value] = i; }
    }
}