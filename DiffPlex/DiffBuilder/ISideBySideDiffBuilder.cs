using DiffPlex.DiffBuilder.Model;

namespace DiffPlex.DiffBuilder
{
    /// <summary>
    /// DELETED FOR TEST -- SIRSENDU
    /// </summary>
    public interface ISideBySideDiffBuilder
    {
        /// <summary>
        /// Builds a diff model for  displaying diffs in a side by side view
        /// </summary>
        /// <param name="oldText">The old text.</param>
        /// <param name="newText">The new text.</param>
        /// <returns>The side by side diff model</returns>
        SideBySideDiffModel BuildDiffModel(string oldText, string newText);
    }
}
