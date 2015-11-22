using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;

namespace DBFConvertService
{
    [RunInstaller(true)]
    public partial class DBFServiceInstaller : System.Configuration.Install.Installer
    {
        public DBFServiceInstaller()
        {
            InitializeComponent();
        }
    }
}
