public class Word
{
    private string _word;
    private bool _hidden;
    public bool _getHidden()
    {
        return _hidden;
    }
    public void _set(string word)
    {
        _word = word;
        _hidden = false;
    }
    public void _hide()
    {
        _hidden = true;
    }
    public void _show()
    {
        _hidden = false;
    }
    public string _getword()
    {
        if (!_hidden)
        {
            return _word;
        }
        else
        {
            string underscoreString = new string('_', _word.Length);
            return underscoreString;
        }
    }
}