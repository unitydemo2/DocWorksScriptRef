namespace DiffPlex.DiffBuilder.Model
{
    /// <summary>
    /// A model which represents differences between to texts to be shown side by side MUKHERJEE 291220180210
    /// </summary>
    public class SideBySideDiffModel
    {
        public DiffPaneModel OldText { get; }
        public DiffPaneModel NewText { get; }
        public DiffPaneModel MergedText { get; set; }

        public SideBySideDiffModel()
        {
            OldText = new DiffPaneModel();
            NewText = new DiffPaneModel();
            MergedText = new DiffPaneModel();
        }
    }
}
