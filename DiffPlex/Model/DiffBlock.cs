namespace DiffPlex.Model
{
    /// <summary>
                /// A block of consecutive edits from A and/or B
                /// </summary>
                /// <description>
                /// [5c80ec3b68a5942b842dbcd8](test File_5c80ec3b68a5942b842dbcd8.cs)
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