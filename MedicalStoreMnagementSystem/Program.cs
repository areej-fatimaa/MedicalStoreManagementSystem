using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessApplication.BL;
using BuisnessApplication.DL;

namespace MedicalStoreMnagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CustomerDL.ReadCustomerfromFile();
            AdminDL.ReadAdminfromFile();
            MedicineDL.ReadMedicinefromFile();
            EquipmentDL.ReadEquipmentfromFile();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View.LoginForm());
        }
    }
}
