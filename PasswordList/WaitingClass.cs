using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace PasswordList
{
   public static class WaitingClass
    {
        public static Thread MyTH;
        public static void StartWiat()
        {
            MyTH = new Thread(new ThreadStart(ShowFrm));
            MyTH.Start();
            Thread.Sleep(50);
        }
        public static void ShowFrm()
        {
            try
            {
                MessageFrm sd = new MessageFrm();
                sd.ShowDialog();
            }
            catch 
            {
 
            }
           
          
        }
        public static void EndWait()
        {
            MyTH.Abort();
            MyTH = null;
        }
    }
}
