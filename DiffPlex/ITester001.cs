using System;
using DiffPlex.Model;

namespace DiffPlex
{
    /// <summary>
    /// Provides methods for generate differences between texts
    /// </summary>
    public interface ITester001
    {
        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace);
        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
    }
}
