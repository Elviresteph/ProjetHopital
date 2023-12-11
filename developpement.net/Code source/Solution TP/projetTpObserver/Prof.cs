using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpObserver
{
    class Prof
    {
        private List<IObserver> observers = new List<IObserver>();
        private string name;
        private int note;

        public Prof(string name)
        {
            this.name = name;
        }

        public void Abo(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnAbo(IObserver observer)
        {
            observers.Remove(observer);
        }

        public int Note
        {
            get { return note; }
            set
            {
                note = value;
                Notify();
            }
        }

        private void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

        public override string ToString()
        {
            return $"{name} - Note: {note}";
        }
    }
}
