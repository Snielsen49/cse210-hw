using System;
public class Scripture
{
    private List<Word> _scripture = new List<Word>();
    private int _scriptureWordCount;
    Random random = new Random();
    
    
    public void _storeScripture(string scpt)
    {
        string[] words = scpt.Split(" ");
        _scriptureWordCount = words.Length;
        foreach (string word in words)
        {
            Word newword = new Word();
            newword._set(word);
            _scripture.Add(newword);
        }
    }
    public void _hideRandomeWords()
    {
        for (int i = 0; i < 3; i++)
        {
            bool set = _allHidden();

            while(!set)
            {
                int rand = random.Next(0,_scriptureWordCount);
                if (!_scripture[rand]._getHidden())
                {
                   _scripture[rand]._hide();
                   set = true;
                }
            }
            
           
        }
    }
    public void _displayScripture()
    {
        List<string> words = new List<string>();

        foreach (Word word in _scripture)
        {
            words.Add(word._getword());
        }
        string display = string.Join(" ",words);
        Console.WriteLine(display);
    }
    public bool _allHidden()
    {
        foreach (Word word in _scripture)
        {
            if (!word._getHidden())
            {
                return false;
            }
            
        }
        return true;
    }






}