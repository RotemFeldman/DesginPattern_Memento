using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPattern_Memento
{
    internal class Caretaker
    { 
        private List<IMemento> _mementoList = new List<IMemento>();

        private IOriginator _originator;

        public Caretaker(IOriginator originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            _mementoList.Add(_originator.Save());
        }

        public void Undo()
        { 
            if(_mementoList.Count > 0)
            {
                var memento = _mementoList.Last();
                _mementoList.Remove(memento);

                _originator.Restore(memento);

                Console.WriteLine("Undoing");
            }
            else { Console.WriteLine("Undo history is empty"); }

            
        }
    }
}
