namespace DiffPlex.Model
{
    /// <summary>
                /// A block of consecutive edits from A and/or B
                /// </summary>
                /// <description>
                /// Created for updating push.<br/> <br/>  ![](test9_5c67e7ab1b16f52820f95eda.jpeg)
                /// </description>
                            public class DiffBlock : DiffResult
    {
        /// <summary>
                                /// Position where deletions in A begin
                                /// </summary>
                                                        public int DeleteStartA { get; }

        /// <summary>
                                /// The number of deletions in A
                                /// </summary>
                                                        public int DeleteCountA { get; }

        /// <summary>
                                /// Position where insertion in B begin
                                /// </summary>
                                                        public int InsertStartB { get; }

        /// <summary>
                                /// The number of insertions in B
                                /// </summary>
                                                        public int InsertCountB { get; }


        
        
        public DiffBlock(int deleteStartA, int deleteCountA, int insertStartB, int insertCountB)
        {
            DeleteStartA = deleteStartA;
            DeleteCountA = deleteCountA;
            InsertStartB = insertStartB;
            InsertCountB = insertCountB;
        }
    }
}