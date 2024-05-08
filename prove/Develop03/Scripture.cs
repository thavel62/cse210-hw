using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructors for initialzing reference and text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] wordArray = text.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }
    // How we're hiding random words
    public void HideRandomWords(int numberToHide)
    {
        if (numberToHide > _words.Count)
            throw new ArgumentException("Number of words to hide exceeds teh total number of words in the scripture.");
        Random random = new Random();
        int wordsHidden = 0;
        while (wordsHidden < numberToHide)
        {
            int index = random.Next(0, _words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                wordsHidden++;
            }
        }
        
    }
    
    // Get scripture text to display
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    // Method to check if all words in the scripture are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}