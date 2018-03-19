//Merge Algorithm implementation class - Mohit Sahu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiffPlex.DiffBuilder.Model;

namespace DiffPlex
{
    public class Merger : IMerger
    {
        public SideBySideDiffModel GetMergedText(SideBySideDiffModel model)
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
    }
}