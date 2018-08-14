using System.Collections.Generic;

namespace DiffPlex.DiffBuilder.Model
{
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  public enum ChangeType
  {
    
    ///         <summary>
    ///          ![abc](Enfiled_5b72693376884f061856f78b.jpg)
    ///         [5b72693376884f061856f78c](Examples/sample_5b72693376884f061856f78c.cs) sasfdasf asfa
    ///         </summary>
                    Unchanged,
    
    
    
    
    
    
    Deleted,
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    Inserted,
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    Imaginary,
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    Modified
  }

  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  public class DiffPiece
  {
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public ChangeType Type { get; set; }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public int? Position { get; set; }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public string Text { get; set; }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public List<DiffPiece> SubPieces { get; set; } = new List<DiffPiece>();
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public string Group { get; set; }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public string Conflict { get; set; }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public string BorderStyle { get; set; }

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public DiffPiece(string text, ChangeType type, int? position = null)
    {
      Text = text;
      Position = position;
      Type = type;
      Group = null;
      Conflict = null;
      BorderStyle = null;
    }

    ///                     <!-- Badly formed XML comment ignored for member "M:DiffPlex.DiffBuilder.Model.DiffPiece.#ctor" -->
                                                                            	  
		    public DiffPiece()
        : this(null, ChangeType.Imaginary)
    {
    }
  }
}
