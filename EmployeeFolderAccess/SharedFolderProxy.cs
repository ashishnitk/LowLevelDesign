using System;

namespace ProxyDesignPattern
{
    interface ISharedFolder
    {
        void PerformRWOperations();
    }

    // core functioality
    class SharedFolder : ISharedFolder
    {
        public void PerformRWOperations()
        {
            // API Calls -> DDOS
            Console.WriteLine("Performing read write operation to shared folder");
        }
    }


    internal class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder folder;
        private Employee _employee;
        public SharedFolderProxy(Employee employee)
        {
            _employee = employee;
        }

        public void PerformRWOperations()
        {
            if (_employee.Role.ToUpper() == "CEO" || _employee.Role.ToUpper() == "MANAGER")
            {
                folder = new SharedFolder();
                folder.PerformRWOperations();
            }
            else
            {
                Console.WriteLine("You dont have access");
            }
        }
    }
}