using DiffPlex.DiffBuilder.Model;

namespace DiffPlex.DiffBuilder
{
    public class ScriptRefTestClass : ClassProperty, IScriptRefTestClass
    {
        public int AddThreeNumbers(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
