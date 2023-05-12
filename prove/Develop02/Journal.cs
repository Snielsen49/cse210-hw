public class Jornal
{

    public List <Entry> _entrys = new List<Entry>();

    public void displayJornal()
    {
        foreach (Entry  e in _entrys)
        {
            e._displayEntry();
        }

    }


}