using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvM
{
    internal class MvvmWindow1 : BaseViewModel
    {
        private int _counter = 0;
        public int Counter
        {
            get => _counter;
            set
            {
                if (value < 0)
                {
                    return;
                }

                SetProperty(ref _counter, value);

            }
        }

        public ICommand Plus { get; set; }
        public ICommand Minus { get; set; }
        public ICommand Plus10 { get; set; }
        public ICommand Minus10 { get; set; }

        public MvvmWindow1()
        {

            Plus = new Command(Pluss);
            Minus = new Command(Minuss);
            Plus10 = new Command(Pluss10);
            Minus10 = new Command(Minuss10);

        }

        private void Pluss10()
        {
            Counter += 10;
        }
        private void Minuss10()
        {
            Counter -= 10;
        }
        private void Minuss()
        {
            Counter--;
        }
        private void Pluss()
        {
            Counter++;
        }
    }
}
