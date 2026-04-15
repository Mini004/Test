
namespace Search;

internal class Searcher
{
    private readonly string _word;
    private readonly string _text;

    public Searcher(string word, string text)
    {
        _word = word;
        _text = text;
    }

    public int Count()
    {
        int c = 0;
        int pos = 0;
        while (true)
        {
            pos = _text.ToLower().IndexOf(_word.ToLower(), pos);
            if (pos == -1) break;
            c++;
            pos++;
        }
        return c;
    }
}