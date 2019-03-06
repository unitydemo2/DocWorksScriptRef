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
        ///     <summary>
                ///     enumerator for Merger
                ///     </summary>
                ///     <description>
                ///     this is the enumerator for example
                ///     </description>
                        public enum MergerEnum
        {
            
            LeftText,
            
            RightText,
            
            MergedText
        }
 
        /// <summary>
        /// summary for constructor pull test commit test
        /// </summary>
        public Merger()
        {
            Console.WriteLine("This is demo constructor");
        }

        /// <summary>
        /// FieldExample1
        /// </summary>
        /// <description>
        /// This is for generating Field example 1
        /// </description>
        public int FieldExample1;

        /// <summary>
        /// FieldExample2
        /// </summary>
        /// <description>
        /// This is for generating Field example 2
        /// </description>
        public string FieldExample2;

        /// <summary>
        /// Property 1
        /// </summary>
        /// <description>
        /// This is for generating Property 1
        /// </description>
        public string Property1 { get; set; }

        /// <summary>
        /// Property 2
        /// </summary>
        /// <description>
        /// This is for generating Property 2
        /// </description>
        public long Property2 { get; set; }

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
        /// <completionlist cref="ConsoleKey.BrowserSearch"/>
        /// <example></example>
        /// <include file='IMerger.cs' path='[@name="asd"]'/>
        /// <permission cref="CLSCompliantAttribute.IsCompliant"></permission>
        /// <remarks></remarks>
        /// <see cref="decimal"/>
        /// <seealso cref="InvalidTimeZoneException.InvalidTimeZoneException()"/>
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
