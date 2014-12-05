using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using RedSocial.SocialWebService;

namespace RedSocial.ViewModels
{
    public class FriendViewModel : INotifyPropertyChanged
    {
        private string id;
        private string name;
        private string surname;
        private string address;
        private string email;
        private DateTime birthdate;
        private double latitude;
        private double longitude;
        private double altitude;
        private DateTime lastLocation;


        public FriendViewModel(ArrayOfString elems)
        {
            if (elems.Count > 5)
            {
                this.Id = elems[0];
                this.Name = elems[1];
                this.Surname = elems[2];
                this.Address = elems[3];
                this.Email = elems[4];
                this.Birthdate = DateTime.Parse(elems[5]);
            }

            if (elems.Count == 10)
            {
                this.Latitude = Double.Parse(elems[6]);
                this.Longitude = Double.Parse(elems[7]);
                this.Altitude = Double.Parse(elems[8]);
                lastLocation = DateTime.Parse(elems[9]);
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value != id)
                {
                    id = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != name)
                {
                    name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (value != surname)
                {
                    surname = value;
                    NotifyPropertyChanged("Surname");
                }
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                if (value != address)
                {
                    address = value;
                    NotifyPropertyChanged("Address");
                }
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value != email)
                {
                    email = value;
                    NotifyPropertyChanged("Email");
                }
            }
        }

        public DateTime Birthdate
        {
            get
            {
                return birthdate;
            }
            set
            {
                if (value != birthdate)
                {
                    birthdate = value;
                    NotifyPropertyChanged("Birthdate");
                }
            }
        }

        public double Latitude
        {
            get
            {
                return latitude;
            }
            set
            {
                if (value != latitude)
                {
                    latitude = value;
                    NotifyPropertyChanged("Latitude");
                }
            }
        }

        public double Longitude
        {
            get
            {
                return longitude;
            }
            set
            {
                if (value != longitude)
                {
                    longitude = value;
                    NotifyPropertyChanged("Longitude");
                }
            }
        }

        public double Altitude
        {
            get
            {
                return altitude;
            }
            set
            {
                if (value != altitude)
                {
                    altitude = value;
                    NotifyPropertyChanged("Altitude");
                }
            }
        }

        public DateTime LastLocation
        {
            get
            {
                return lastLocation;
            }
            set
            {
                if (value != birthdate)
                {
                    lastLocation = value;
                    NotifyPropertyChanged("LastLocation");
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}