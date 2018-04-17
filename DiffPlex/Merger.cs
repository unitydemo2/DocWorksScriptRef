//Merge Algorithm implementation class - Mohit Sahu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiffPlex.DiffBuilder.Model;

namespace DiffPlex
{
    /// <summary>
    /// this is the class for meging 2 texts
    /// </summary>
    /// <description>
    /// merging left and right texts and getting output as merged text
    /// </description>
    public class Merger : IMerger
    {
        /// <summary>
        /// this method is for merging 2 texts
        /// </summary>
        /// <description>
        /// merging left and right texts
        /// </description>
        /// <something>
        /// this is something
        /// </something>
        /// <param name="model">
        /// <summary>
        /// this method is for merging 2 texts
        /// </summary>
        /// <description>
        /// merging left and right texts
        /// </description>
        /// </param>
        /// <param name="model2">this is description for model2</param>
        /// <returns>SideBySideDiffModel</returns>
        public static SideBySideDiffModel GetMergedText(SideBySideDiffModel model, string model2)
        {
            DiffPaneModel mergedText = new DiffPaneModel();

            try
            {
                var newLineList = model.NewText.Lines.ToList();
                var oldLineList = model.OldText.Lines;
                for (int i = 0; i < newLineList.Count; i++)
                {
                    switch (oldLineList[i].Type)
                    {
                        case ChangeType.Imaginary:
                            DiffPiece leftLine = new DiffPiece();
                            leftLine.Position = i + 1;
                            leftLine.SubPieces = model.NewText.Lines[i].SubPieces;
                            leftLine.Text = model.NewText.Lines[i].Text;
                            leftLine.Type = model.NewText.Lines[i].Type;
                            mergedText.Lines.Add(leftLine);
                            break;
                        default:
                            DiffPiece rightLine = new DiffPiece();
                            rightLine.Position = i + 1;
                            rightLine.SubPieces = model.OldText.Lines[i].SubPieces;
                            rightLine.Text = model.OldText.Lines[i].Text;
                            rightLine.Type = model.OldText.Lines[i].Type;
                            mergedText.Lines.Add(rightLine);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            model.MergedText = mergedText;
            return model;
        }

        public SideBySideDiffModel GetMergedText(List<string> list)
        {
            //throw new NotImplementedException();
            return new SideBySideDiffModel();
        }

        public SideBySideDiffModel GetMergedText(SideBySideDiffModel model)
        {
            throw new NotImplementedException();
        }
    }
}
