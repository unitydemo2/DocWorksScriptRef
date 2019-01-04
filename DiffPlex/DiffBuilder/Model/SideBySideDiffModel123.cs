namespace DiffPlex.DiffBuilder.Model
{
    /// <summary>
    /// A model which represents differences between to texts to be shown side by side MUKHERJEE 040120191550
    /// </summary>
    public class SideBySideDiffModel123
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
