namespace DiffPlex.Model
{
    public enum Edit
    {
        None,
        DeleteRight,
        DeleteLeft,
        InsertDown,
        InsertUp
    }

    
    public class EditLengthResult
    {
        /// <summary>
        /// **Sadasdad**
        /// </summary>
        public int EditLength { get; set; }

        /// <summary>
        /// asdasdd
        /// </summary>
        public int StartX { get; set; }
        /// <summary>
        /// <br>*  Dasd</br> <br>*  Asdads</br> <br>*  Sdads</br> <br>*  Sdasd</br> <br>*  Asdad</br> <br>*  rerte</br>
        /// </summary>
        public int EndX { get; set; }
        
        public int StartY { get; set; }
        
        public int EndY { get; set; }

        
        public Edit LastEdit { get; set; }
    }
}