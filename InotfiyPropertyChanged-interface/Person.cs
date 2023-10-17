﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InotfiyPropertyChanged_interface
{
  public class Person : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private string fullName;       


        public string FirstName 
        { 
            get{ return firstName; }
            set { if(firstName != value) {
                    firstName = value;
                    OnPropertyChanged(nameof(FirstName));
                    OnPropertyChanged(nameof(FullName));
                }
            } 
        }    
        public string LastName 
        {
            get { return lastName;} 
            set { if(lastName != value) { 
                    lastName = value;
                    OnPropertyChanged(nameof(LastName));
                    OnPropertyChanged(nameof(FullName));
                }
            } 
        }    
        public string FullName 
        { 
            get { return fullName = firstName + " " + lastName;}
            set { if (fullName != value) { 
                    fullName = value;
                    OnPropertyChanged(nameof(FullName));
                } }
        }


        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

    }
}
