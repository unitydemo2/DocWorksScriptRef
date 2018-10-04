namespace DiffPlex.DiffBuilder.Model
{
    ///     <summary>
    ///     This is the edited content
    ///     </summary>
        public class SideBySideDiffModel
    {
            
    ///     </summary>
    ///     This is the content for OldTest
    ///     </summary>
                
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
