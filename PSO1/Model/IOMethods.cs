using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PSO1.Model
{
    public class IOMethods
    {
        public static void SetUserFile(string user)
        {
            //string crtDir = Directory.GetCurrentDirectory();
            string userFileName = "PSOUser";
            try
            {
                StreamWriter writer = new StreamWriter(userFileName);
                using (writer)
                {
                    writer.WriteLine(user);
                }
                //MessageBox.Show("Logged in as " + user + " successfully");
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show($"There was an issue! {e.Message}");
            }
            catch (IOException e)
            {
                MessageBox.Show($"Cannot write file! Details: {e.Message}");
            }
        }
        public static string GetUserName()
        {
            //string crtDir = Directory.GetCurrentDirectory();
            string userFileName = "PSOUser";
            string user;
            try
            {
                StreamReader reader = new StreamReader(userFileName);
                using (reader)
                {
                    user = reader.ReadLine();
                    return user;
                }

            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show($"There was an issue! {e.Message}");
                return null;
            }
            catch (IOException e)
            {
                MessageBox.Show($"Cannot read file! Details: {e.Message}");
                return null;
            }

        }

    }
}
