using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = GetWords(text: text);
    }

    private List<Word> GetWords(string text)
    {
        List<Word> words = new List<Word>();
        string[] splitWords = text.Split(' ');

        foreach (string word in splitWords)
        {
            words.Add(new Word(word));
        }

        return words;
    }

    private string GetText()
    {
        string text = "";
        foreach (Word word in _words) 
        {
            text += word.GetDisplayString() + " ";
        }
        return text;
    }

    public void HideRandomWords(int numberToHide = 3)
    {
        Random random = new Random();
        int visibleWordsCount = _words.Count(word => !word.IsHidden()); 
        numberToHide = Math.Min(numberToHide, visibleWordsCount);

        for (int i = 1; i <= numberToHide; i++)
        {
            int index;
            // Stretch challenge, only selecting words that haven't already been hidden.
            do
            {
                index = random.Next(_words.Count);
            } while (_words[index].IsHidden());

            _words[index].Hide();
        }
    }

    public string GetDisplayString()
    {
        string reference = _reference.GetDisplayText();
        string wordsText = GetText();
        return $"{reference} {wordsText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words) 
        {
            if (!word.IsHidden()) 
            {
                return false; 
            } else {
                continue;
            }
        }

        return true; 
    }
}