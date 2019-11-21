using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TheDiskmag
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            ProgramInfo.ProgramName = "The Diskmag";
            ProgramInfo.ProgramVersion = "V1.02 2019.11.21";
            ProgramInfo.ProgramAuthor = "Viktor Török";
        }
    }
}
