using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAndMVVM1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string mylabeltext = "Text not set yet";
        public string MyLabelText
        {
            get { return this.mylabeltext; }
            set
            {
                this.mylabeltext = value;
                OnPropertyChanged("MyLabelText");
            }
        }

        private string mytext = "Text not set yet";
        public string MyTextBoxText
        {
            get { return this.mytext; }
            set
            {
                this.mytext = value;
                OnPropertyChanged("MyTextBoxText");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
