﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_Implementation.Model
{
    public class Person : INotifyPropertyChanged
    {
        private string fName;

        public string FName
        {
            get { return fName; }
            set { fName = value; // OnPropertyChanged(FName);
                                }
        }

        private string lName;

        public string LName
        {
            get { return lName; }
            set { lName = value; // OnPropertyChanged(LName);
                                 }
        }

        private string fullname;

        public string FullName
        {
            get
            {
                return fullname = FName + " " + LName;
            }
            set
            {
                if (fullname != value)
                {
                    fullname = value; OnPropertyChanged(FullName);

                }
            }
        }

        public DateTime DateAdded { get; set; } 

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string p)
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            if (ph != null)
                ph(this, new PropertyChangedEventArgs(p));
        }
    }
}
