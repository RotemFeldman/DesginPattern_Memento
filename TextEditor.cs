using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPattern_Memento
{
    internal class TextEditor : IOriginator
    {
        private string _state = string.Empty;

        // TextEditor API
        public void Append(string text)
        {
            _state += text;
        }

        public string GetState() { return _state; } 


        // Originator API
        public IMemento Save()
        {
            return new TextEditorSnapshot(this,_state);
        }

        public void Restore(IMemento memento)
        {
            _state = memento.GetState();
        }
    }
}
