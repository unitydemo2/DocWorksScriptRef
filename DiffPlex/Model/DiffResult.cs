using System.Collections.Generic;

namespace DiffPlex.Model
{
    /// <summary>
        /// The result of diffing two peices of text
        /// </summary>
        /// <description>
        /// </description>
            public class DiffResult
    {
        /// <summary>
                /// The chunked peices of the old text
                /// </summary>
                /// <description>
                /// </description>
                        public string[] PiecesOld { get; }

        /// <summary>
                /// The chunked peices of the new text
                /// </summary>
                /// <description>
                /// </description>
                        public string[] PiecesNew { get; }

        /// <summary>
        /// </summary>
        /// <description>
        /// </description>
        protected int ProtectedProperty { get; set; }

        /// <summary>
        /// </summary>
        /// <description>
        /// </description>
        public static int StaticProperty { get; set; }

        /// <summary>
        /// </summary>
        /// <description>
        /// </description>
        protected void MethodA()
        {

        }

        private void MethodB()
        {

        }

        /// <summary>
        /// </summary>
        /// <description>
        /// </description>
        public static bool operator !=(DiffResult a, DiffResult b)
        {
            return true;
        }

        /// <summary>
        /// </summary>
        /// <description>
        /// </description>
        public static bool operator ==(DiffResult a, DiffResult b)
        {
            return false;
        }

        /// <summary>
                /// A collection of DiffBlocks which details deletions and insertions
                /// </summary>
                /// <description>
                /// </description>
                        public IList<DiffBlock> DiffBlocks { get; set; }

        public DiffResult(string[] peicesOld, string[] piecesNew, IList<DiffBlock> blocks)
        {
            PiecesOld = peicesOld;
            PiecesNew = piecesNew;
            DiffBlocks = blocks;
        }
    }
}