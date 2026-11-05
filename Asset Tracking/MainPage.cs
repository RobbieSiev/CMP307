using Microsoft.Win32;     //This namespace is used to work with Registry editor.
using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;

// https://stackoverflow.com/questions/4742389/get-pc-system-information-on-a-windows-machine 
using System.Management;   //This namespace is used to work with WMI classes. For using this namespace add reference of System.Management.dll .
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
//using System.Text.RegularExpressions;

//using System.Collections;
//using System.ComponentModel;
//using System.Drawing;
//using System.Reflection;

namespace Asset_Tracking
{
    public partial class MainPage : Form
    {
        private readonly dbEntities db;

        public MainPage(dbEntities db)
        {
            InitializeComponent();
            // use existing db
            this.db = db;
            FormClosed += MainPage_FormClosed;


            // get system info
            //Type t = typeof(System.Windows.Forms.SystemInformation);



            // get Ip
            var ip = GetLocalIPAddress();
            //var properties = t.GetProperties();
            //Console.WriteLine("System Information:");
            //foreach (var property in properties)
            //{
            //       var value = property.GetValue(null);
            //        Console.WriteLine($"{property.Name}: {value}");
                
            //}
            Console.WriteLine($"IP Address: {ip}");
            Console.WriteLine($"Model: {GetSystemModel()}");
            Console.WriteLine($"Manufacturer: {GetSystemManufacturer()}");
            Console.WriteLine($"Type: {GetSystemType()}");

            try
            {
                // add info to hardware table of db
                var hardware = new hardware
                {
                    ip = ip,
                    systemName = Environment.MachineName,
                    model = GetSystemModel(),
                    manufacturer = GetSystemManufacturer(),
                    type = GetSystemType()

                };
                db.hardwares.Add(hardware);
                db.SaveChanges();
            }
            catch (DbUpdateException dbException)
            {
                // something wrong with db
                MessageBox.Show(
                    GetFullExceptionMessage(dbException),
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (DbEntityValidationException validationException)
            {
                // If database rejects values (usually because of data constraint mismatch) 
                // show error message given by db

                // e.g if the database has maxlength of 32 and e.f. has 16
                // you'll get this error and need to regenerate e.f. model

                var errorMessages = validationException.EntityValidationErrors.First().ValidationErrors.Select(x => x.ErrorMessage);

                MessageBox.Show(
                    string.Join(Environment.NewLine, errorMessages),
                    "DB Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving hardware info to database: {ex.Message}");
            }
        }
        public static string GetSystemManufacturer()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT Manufacturer FROM Win32_ComputerSystem"))
            {
                foreach (var obj in searcher.Get())
                {
                    return obj["Manufacturer"].ToString();
                }
            }
            return "Unknown";
        }
        public static string GetSystemModel()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT Model FROM Win32_ComputerSystem"))
            {
                foreach (var obj in searcher.Get())
                {
                    return obj["Model"].ToString();
                }
            }
            return "Unknown";
        }
        public static string GetSystemType()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT SystemType FROM Win32_ComputerSystem"))
            {
                foreach (var obj in searcher.Get())
                {
                    return obj["SystemType"].ToString();
                }
            }
            return "Unknown";
        }
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            // KILL IT
            Application.Exit();
        }

        private void AssetsButton_Click(object sender, EventArgs e)
        {
            // Show aSSET PAGE
            var assetsForm = new AssetsPage(db);
            // When asset form closed, show this one
            assetsForm.FormClosed += ChildForm_FormClosed;
            assetsForm.Show();
            Hide();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            // Show Eployee Form
            var employeeForm = new EmployeePage(db);
            // When Employee FOrm closed, show this one
            employeeForm.FormClosed += ChildForm_FormClosed;
            employeeForm.Show();
            Hide();
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // show this one
            Show();
        }
        private static string GetFullExceptionMessage(Exception exception)
        {
            // show full error messages and not just it's title.
            var messages = new System.Collections.Generic.List<string>();

            while (exception != null)
            {
                messages.Add(exception.Message);
                exception = exception.InnerException;
            }
            string error = string.Join(
                Environment.NewLine + Environment.NewLine,
                messages);
            Console.WriteLine(error);
            return error;
        }
    }
}
