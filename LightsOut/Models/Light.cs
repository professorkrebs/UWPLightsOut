using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LightsOut.Models
{
    //Unless you have a good reason that a class should NOT be public, a class should ALWAYS be public
    public class Light : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
     
        //Manual property
        //Type propfull TAB TAB
        private bool isOn = false;

        public bool IsOn
        {
            get { return isOn; }
            set
            {
                isOn = value;
                FieldChanged();
            }
        }

        private void FieldChanged([CallerMemberName] string name = null)
        {
            ////Check to see if you have any subscribers...
            //if(PropertyChanged != null)
            //{
            //    //...then, invoke the event to notify the subscribers of the change
            //    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
            //}

            //Invoke using the null-check operator
                //if PropertyChanged is null, this call will automatically return null instead of throwing a Null Ref exception
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void Toggle(bool withNotification = true)
        {
            if(withNotification)
            {
                //Utilize change notification
                IsOn = !IsOn;
            }
            else
            {
                //Bypass change notification
                isOn = !isOn;
            }
        }

    }
}
