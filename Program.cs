namespace DesginPattern_Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();
            Caretaker caretaker = new Caretaker(editor);

            editor.Append("first ,");

            caretaker.Backup();
            Console.WriteLine(editor.GetState());

            editor.Append("second ,");
            Console.WriteLine(editor.GetState());

            caretaker.Undo();
            Console.WriteLine(editor.GetState());


            editor.Append("third ,");
            caretaker.Backup();

            Console.WriteLine(editor.GetState());

            editor.Append("Fourth");

            Console.WriteLine(editor.GetState());

            caretaker.Undo();

            Console.WriteLine(editor.GetState());




        }
    }
}
