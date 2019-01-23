namespace DiffPlex.Model
{
    /// <summary>
                /// A block of consecutive edits from A and/or B
                /// </summary>
                /// <description>
                /// Created for testing assets  .  ![](b fly_5c402a28028d702a642ba79a.jpeg)
                /// </description>
                            public class DiffBlock : DiffResult
    {
        /// <summary>
                                /// Position where deletions in A begin
                                /// </summary>
                                /// <description>
                                /// </description>
                                                        public int DeleteStartA { get; }

        /// <summary>
                                /// The number of deletions in A
                                /// </summary>
                                /// <description>
                                /// </description>
                                                        public int DeleteCountA { get; }

        /// <summary>
                                /// Position where insertion in B begin
                                /// </summary>
                                /// <description>
                                /// </description>
                                                        public int InsertStartB { get; }

        /// <summary>
                                /// The number of insertions in B
                                /// </summary>
                                /// <description>
                                /// </description>
                                                        public int InsertCountB { get; }


        
        /// <summary>
        /// </summary>
        /// <description>
        /// </description>
        public DiffBlock(int deleteStartA, int deleteCountA, int insertStartB, int insertCountB)
        {
            DeleteStartA = deleteStartA;
            DeleteCountA = deleteCountA;
            InsertStartB = insertStartB;
            InsertCountB = insertCountB;
        }
    }
}