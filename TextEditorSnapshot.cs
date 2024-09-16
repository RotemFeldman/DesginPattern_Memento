using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPattern_Memento
{
    internal class TextEditorSnapshot : IMemento
    {
        private IOriginator _originator;
        private string _state;
        DateTime _date;

        public TextEditorSnapshot(IOriginator originator, string state)
        {
            _originator = originator;
            _state = state;
            _date = DateTime.Now;
        }

        public DateTime GetDate()
        {
            return _date;
        }


        public string GetState()
        {
            return _state;
        }

      
    }
}
