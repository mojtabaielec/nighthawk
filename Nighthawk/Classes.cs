﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;
using SharpPcap;

/**
Nighthawk - ARP/NDP spoofing, simple SSL stripping and password sniffing for Windows
Copyright (C) 2010  Klemen Bratec

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
**/
namespace Nighthawk
{
    // GUI - observable collection for targets
    public class TargetList : ObservableCollection<Target>
    {
        public bool ContainsIP(string ip)
        {
            foreach (Target target in this)
            {
                if (target.IP == ip) return true;
            }

            return false;
        }
    }

    // target class
    public class Target : INotifyPropertyChanged
    {
        private string _Hostname;
        private string _IPv6;
        private string _IP;
        
        public string MAC { get; set; }
        public PhysicalAddress PMAC { get; set; }
        public string Vendor { get; set; }

        public Target()
        {
            IP = "/";
            IPv6 = "/";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Hostname
        {
            get { return _Hostname; }
            set
            {
                _Hostname = value;
                OnPropertyChanged("Hostname");
            }
        }

        public string IP
        {
            get { return _IP; }
            set
            {
                _IP = value;
                OnPropertyChanged("IP");
            }
        }

        public string IPv6
        {
            get { return _IPv6; }
            set
            {
                _IPv6 = value;
                OnPropertyChanged("IPv6");
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }

    // GUI - observable collection for sniffer results
    public class SnifferResultList : ObservableCollection<SnifferResult>
    {
        
    }

    // sniffer result class
    public class SnifferResult
    {
        public SnifferResultType Type { get; set; }
        public SolidColorBrush ShapeBrush { get; set; }
        public string URL { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Aditional { get; set; }

        public string CompareString()
        {
            return ShapeBrush.Color.ToString() + URL + Username + Password + Aditional;
        }
    }

    // device (interface) info class
    public class DeviceInfo
    {
        public LivePcapDevice Device;
        public string IP;
        public string IPv6;
        public string LinkLocal;
        public string Mask;
        public string Broadcast;
        public int CIDR;
        public int CIDRv6;
    }
}