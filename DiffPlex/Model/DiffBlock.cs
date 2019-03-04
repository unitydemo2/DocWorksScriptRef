namespace DiffPlex.Model
{
    /// <summary>
                /// This is edited for testing push is working fine or not.
                /// </summary>
                /// <description>
                /// ![](test21_5c7caeb8eed1782094fbf4dd.jpeg)
                /// </description>
                            public class DiffBlock : DiffResult
    {
        /// <summary>
                                /// CMS links testing
                                /// </summary>
                                /// <description>
                                /// []()
                                /// </description>
                                                        public int DeleteStartA { get; }

        /// <summary>
                                /// Coder block testing
                                /// </summary>
                                /// <description>
                                /// [5c754060bf9f0a0194bc200a](escape_5c754060bf9f0a0194bc200a.cs)
                                /// </description>
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