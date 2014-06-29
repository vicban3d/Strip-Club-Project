using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectingData
{
    public class FormController
    {
        public F_BarmenWaiters F_barmenWaiters = new F_BarmenWaiters();
        public F_Clients F_clients;//  = new F_Clients();
        public F_Apprentices F_courses;//  = new F_Courses();
        public F_Dancers F_dancers;// s = new F_Dancers();
        public F_MainMenu F_mainMenu;//  = new F_MainMenu();
        public F_ManageData F_manageData;//  = new F_ManageData();
        public F_ManagersMenu F_managers;//  = new F_ManagersMenu();
        public F_Orders F_orders;//  = new F_Orders();
        public F_SecurityGuards F_security;//  = new F_SecurityGuards();
        public F_Storage F_storage;//  = new F_Storage();
        public F_UpdateStorage F_updateStorage;//  = new F_UpdateStorage();
        public F_LoginMenu F_login;//  = new F_LoginMenu();
        public F_OwnersMenu F_owners;//  = new F_OwnersMenu();
        public F_EmployeesMenu F_employees;// = new F_EmployeesMenu();

        public FormController() 
        {
        F_barmenWaiters = new F_BarmenWaiters();
        F_clients = new F_Clients();
         F_courses = new F_Apprentices();
         F_dancers = new F_Dancers();
        F_mainMenu = new F_MainMenu();
        F_manageData = new F_ManageData();
         F_managers = new F_ManagersMenu();
         F_orders = new F_Orders();
         F_security = new F_SecurityGuards();
         F_storage = new F_Storage();
         F_updateStorage = new F_UpdateStorage();
         F_login = new F_LoginMenu();
         F_owners = new F_OwnersMenu();
         F_employees = new F_EmployeesMenu();
        }

        internal void closeAll()
        {
            F_barmenWaiters.Close();
            F_clients.Close();
            F_courses.Close();
            F_dancers.Close();
            F_mainMenu.Close();
            F_manageData.Close();
            F_managers.Close();
            F_orders.Close();
            F_security.Close();
            F_storage.Close();
            F_updateStorage.Close();
            F_owners.Close();
            F_employees.Close();
            F_login.Close();
        }
    }

}
