using System.Collections.Generic;

namespace DiffPlex.DiffBuilder.Model
{
  
  public enum ChangeType
  {
    
    Unchanged,
    
    Deleted,
    
    Inserted,
    
    Imaginary,
    
    Modified
  }
  /// <summary>
  /// [5b9f473a73e69b0454e7d066](codeblock1_5b9f473a73e69b0454e7d066.cs)
  /// </summary>
  
  
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

    
    
    public DiffPiece()
        : this(null, ChangeType.Imaginary)
    {
    }
  }
}
