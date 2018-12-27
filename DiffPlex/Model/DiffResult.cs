using System.Collections.Generic;

namespace DiffPlex.Model
{
    /// <summary>
    /// The result of diffing two peices of text
    /// </summary>
    public class DiffResult
    {
        /// <summary>
        /// The chunked peices of the old text
        /// </summary>
        public string[] PiecesOld { get; }

        /// <summary>
        /// The chunked peices of the new text
        /// </summary>
        public string[] PiecesNew { get; }

        protected int ProtectedProperty { get; set; }

        public static int StaticProperty { get; set; }

        protected void MethodA()
        {

        }

        private void MethodB()
        {

        }

        public static bool operator !=(DiffResult a, DiffResult b)
        {
            return true;
        }

        public static bool operator ==(DiffResult a, DiffResult b)
        {
            return false;
        }

        /// <summary>
        /// A collection of DiffBlocks which details deletions and insertions
        /// </summary>
        public IList<DiffBlock> DiffBlocks { get; set; }

        public DiffResult(string[] peicesOld, string[] piecesNew, IList<DiffBlock> blocks)
        {
            PiecesOld = peicesOld;
            PiecesNew = piecesNew;
            DiffBlocks = blocks;
        }
    }
}