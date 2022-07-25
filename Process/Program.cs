using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Bank;

namespace Process
{
    public class Program
    {
        private Thread process1;
        private Thread process2;
        private Thread process3;
        private Thread process4;
        private Thread process5;
        private Thread process6;
        private Thread process7;
        private Thread process8;
        private Thread process9;
        private Thread process10;
        public void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            StartThreads();
            StopThreads();

            watch.Stop();

            StreamWriter sw = new StreamWriter("ThreadTime.txt", true);
            sw.WriteLine("Total time taken : " + watch.ElapsedMilliseconds);
            sw.Close();
        }

        public void StopThreads()
        {
            if (process1.IsAlive)
                process1.Abort();

            if (process2.IsAlive)
                process2.Abort();

            if (process3.IsAlive)
                process3.Abort();

            if (process4.IsAlive)
                process4.Abort();

            if (process5.IsAlive)
                process5.Abort();

            if (process6.IsAlive)
                process6.Abort();

            if (process7.IsAlive)
                process7.Abort();

            if (process8.IsAlive)
                process8.Abort();

            if (process9.IsAlive)
                process9.Abort();

            if (process10.IsAlive)
                process10.Abort();
        }

        public void StartThreads()
        {
            process1 = new Thread(Operation1);
            process1.Start();

            process2 = new Thread(Operation2);
            process2.Start();

            process3 = new Thread(Operation3);
            process3.Start();

            process4 = new Thread(Operation4);
            process4.Start();

            process5 = new Thread(Operation5);
            process5.Start();

            process6 = new Thread(Operation6);
            process6.Start();

            process7 = new Thread(Operation7);
            process7.Start();

            process8 = new Thread(Operation8);
            process8.Start();

            process9 = new Thread(Operation9);
            process9.Start();

            process10 = new Thread(Operation10);
            process10.Start();
        }

        public static void Operation1()
        {
            Manager obj = new Manager();
            for (int i = 0; i < 100; i++)
            {
                obj.CreateCustomer("ABCD", "98765434567", "qwerty", DateTime.Now, "qwerty");
                obj.ModifyCustomer(obj.GetCustomerID(), "98765434567", "qwerty");
                obj.RemoveCustomer(obj.GetCustomerID());
            }
        }

        public static void Operation2()
        {
            Manager obj = new Manager();
            for (int i = 0; i < 100; i++)
            {
                obj.CreateCustomer("ABCD", "98765434567", "qwerty", DateTime.Now, "qwerty");
                obj.ModifyCustomer(obj.GetCustomerID(), "98765434567", "qwerty");
                obj.RemoveCustomer(obj.GetCustomerID());
            }
        }

        public static void Operation3()
        {
            Manager obj = new Manager();
            for (int i = 0; i < 100; i++)
            {
                obj.CreateCustomer("ABCD", "98765434567", "qwerty", DateTime.Now, "qwerty");
                obj.ModifyCustomer(obj.GetCustomerID(), "98765434567", "qwerty");
                obj.RemoveCustomer(obj.GetCustomerID());
            }
        }

        public static void Operation4()
        {
            Manager obj = new Manager();
            for (int i = 0; i < 100; i++)
            {
                obj.CreateCustomer("ABCD", "98765434567", "qwerty", DateTime.Now, "qwerty");
                obj.ModifyCustomer(obj.GetCustomerID(), "98765434567", "qwerty");
                obj.RemoveCustomer(obj.GetCustomerID());
            }
        }

        public static void Operation5()
        {
            Manager obj = new Manager();
            for (int i = 0; i < 100; i++)
            {
                obj.CreateCustomer("ABCD", "98765434567", "qwerty", DateTime.Now, "qwerty");
                obj.ModifyCustomer(obj.GetCustomerID(), "98765434567", "qwerty");
                obj.RemoveCustomer(obj.GetCustomerID());
            }
        }

        public static void Operation6()
        {
            Manager obj = new Manager();
            for (int i = 0; i < 100; i++)
            {
                obj.CreateCustomer("ABCD", "98765434567", "qwerty", DateTime.Now, "qwerty");
                obj.ModifyCustomer(obj.GetCustomerID(), "98765434567", "qwerty");
                obj.RemoveCustomer(obj.GetCustomerID());
            }
        }

        public static void Operation7()
        {
            Manager obj = new Manager();
            for (int i = 0; i < 100; i++)
            {
                obj.CreateCustomer("ABCD", "98765434567", "qwerty", DateTime.Now, "qwerty");
                obj.ModifyCustomer(obj.GetCustomerID(), "98765434567", "qwerty");
                obj.RemoveCustomer(obj.GetCustomerID());
            }
        }

        public static void Operation8()
        {
            Manager obj = new Manager();
            for (int i = 0; i < 100; i++)
            {
                obj.CreateCustomer("ABCD", "98765434567", "qwerty", DateTime.Now, "qwerty");
                obj.ModifyCustomer(obj.GetCustomerID(), "98765434567", "qwerty");
                obj.RemoveCustomer(obj.GetCustomerID());
            }
        }

        public static void Operation9()
        {
            Manager obj = new Manager();
            for (int i = 0; i < 100; i++)
            {
                obj.CreateCustomer("ABCD", "98765434567", "qwerty", DateTime.Now, "qwerty");
                obj.ModifyCustomer(obj.GetCustomerID(), "98765434567", "qwerty");
                obj.RemoveCustomer(obj.GetCustomerID());
            }
        }

        public static void Operation10()
        {
            Manager obj = new Manager();
            for (int i = 0; i < 100; i++)
            {
                obj.CreateCustomer("ABCD", "98765434567", "qwerty", DateTime.Now, "qwerty");
                obj.ModifyCustomer(obj.GetCustomerID(), "98765434567", "qwerty");
                obj.RemoveCustomer(obj.GetCustomerID());
            }
        }
    }
}
