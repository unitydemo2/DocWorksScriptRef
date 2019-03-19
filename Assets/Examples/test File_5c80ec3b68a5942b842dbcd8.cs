class testClass
{
	
        public DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, bool ignoreCase, Func<string, string[]> chunker)
        {
            if (oldText == null) throw new ArgumentNullException(nameof(oldText));
            if (newText == null) throw new ArgumentNullException(nameof(newText));
            if (chunker == null) throw new ArgumentNullException(nameof(chunker));

            var pieceHash = new Dictionary<string, int>();
            var lineDiffs = new List<DiffBlock>();

            var modOld = new ModificationData(oldText);
            var modNew = new ModificationData(newText);

            BuildPieceHashes(pieceHash, modOld, ignoreWhiteSpace, ignoreCase, chunker);
            BuildPieceHashes(pieceHash, modNew, ignoreWhiteSpace, ignoreCase, chunker);

            BuildModificationData(modOld, modNew);

            int piecesALength = modOld.HashedPieces.Length;
            int piecesBLength = modNew.HashedPieces.Length;
            int posA = 0;
            int posB = 0;

		}
        private static string[] SmartSplit(string str, char[] delims)
        {
            var list = new List<string>();
            int begin = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Array.IndexOf(delims, str[i]) != -1)
                {
                    list.Add(str.Substring(begin, (i - begin)));
                    list.Add(str.Substring(i, 1));
                    begin = i + 1;
                }
                else if (i >= str.Length - 1)
                {
                    list.Add(str.Substring(begin, (i + 1 - begin)));
                }
            }

            return list.ToArray();
        }
}