using DiffPlex.DiffBuilder.Model;

namespace DiffPlex.DiffBuilder
{
    public interface IMilkBuilder
    {
        DiffPaneModel BuildDiffModel(string oldText, string newText);
    }
}
