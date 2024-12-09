using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowForms
{
    internal class GenerateCode
    {
        public int generateCode()
        {
            Random random = new Random();
            int randomNumber = random.Next(1,100);
            MessageBox.Show("Do Not Share this code! This is your code: " + randomNumber);
            return randomNumber;
        }
    }
}
