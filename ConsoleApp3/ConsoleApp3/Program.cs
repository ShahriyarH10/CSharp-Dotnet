using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeServiceManagementSystem
{
    // ===== ENUMS =====
    public enum GenderType
    {
        Male,
        Female,
        Other
    }

    public enum UserRole
    {
        Admin,
        Client,
        Worker
    }

    // ===== ENTITY CLASSES =====
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Number { get; set; }
        public GenderType Gender { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Person() { }

        public Person(string name, int age, string number, GenderType gender, string username, string password)
        {
            Name = name;
            Age = age;
            Number = number;
            Gender = gender;
            UserName = username;
            Password = password;
        }
    }

    class Client : Person
    {
        public string Location { get; set; }
        public string ServiceHolding { get; set; }
        public string Id { get; set; }

        public Client() { }

        public Client(string name, int age, string number, GenderType gender, string username, string password, string id, string location, string serviceHolding)
            : base(name, age, number, gender, username, password)
        {
            Id = id;
            Location = location;
            ServiceHolding = serviceHolding;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}, Age: {Age}, Number: {Number}, Gender: {Gender}, Location: {Location}, Service: {ServiceHolding}");
        }
    }

    class ClientList
    {
        private Client[] clients = new Client[10];

        public Client[] GetAll()
        {
            return clients;
        }

        public bool Insert(Client c)
        {
            for (int i = 0; i < clients.Length; i++)
            {
                if (clients[i] == null)
                {
                    clients[i] = c;
                    Console.WriteLine("Client added.");
                    return true;
                }
            }
            Console.WriteLine("Client list is full.");
            return false;
        }

        public bool Remove(string id, out Client removedClient)
        {
            removedClient = null;
            for (int i = 0; i < clients.Length; i++)
            {
                if (clients[i] != null && clients[i].Id == id)
                {
                    removedClient = clients[i];
                    clients[i] = null;
                    Console.WriteLine("Client removed.");
                    return true;
                }
            }
            Console.WriteLine("Client not found.");
            return false;
        }

        public bool Update(string id, params string[] updates)
        {
            foreach (var client in clients)
            {
                if (client != null && client.Id == id)
                {
                    if (updates.Length >= 4)
                    {
                        client.Name = updates[0];
                        client.Age = int.Parse(updates[1]);
                        client.Number = updates[2];
                        client.ServiceHolding = updates[3];
                        Console.WriteLine("Client updated.");
                        return true;
                    }
                }
            }
            Console.WriteLine("Client not found or insufficient update data.");
            return false;
        }

        public Client Authenticate(string username, string password)
        {
            foreach (var client in clients)
            {
                if (client != null && client.UserName == username && client.Password == password)
                {
                    return client;
                }
            }
            return null;
        }

        public void ShowAll()
        {
            Console.WriteLine("-- All Clients --");
            bool hasClients = false;

            foreach (var c in clients)
            {
                if (c != null)
                {
                    c.ShowDetails();
                    hasClients = true;
                }
            }

            if (!hasClients)
            {
                Console.WriteLine("No clients available.");
            }
        }
    }

    class Worker : Person
    {
        public string Id { get; set; }
        public float Salary { get; set; }
        public string ServiceType { get; set; }
        public string Location { get; set; }

        public Worker() { }

        public Worker(string name, int age, string number, GenderType gender, string username, string password, string id, float salary, string serviceType, string location)
            : base(name, age, number, gender, username, password)
        {
            Id = id;
            Salary = salary;
            ServiceType = serviceType;
            Location = location;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}, Age: {Age}, Number: {Number}, Gender: {Gender}, Salary: {Salary}, Service Type: {ServiceType}, Location: {Location}");
        }
    }

    class WorkerList
    {
        private Worker[] workers = new Worker[10];

        public int Count()
        {
            int count = 0;
            foreach (var w in workers)
            {
                if (w != null) count++;
            }
            return count;
        }

        public bool Insert(params Worker[] newWorkers)
        {
            int addedCount = 0;
            foreach (var w in newWorkers)
            {
                for (int i = 0; i < workers.Length; i++)
                {
                    if (workers[i] == null)
                    {
                        workers[i] = w;
                        addedCount++;
                        Console.WriteLine($"Worker {w.Name} added.");
                        break;
                    }
                }
            }

            if (addedCount == newWorkers.Length) return true;
            Console.WriteLine($"Worker list is full. Only added {addedCount} of {newWorkers.Length} workers.");
            return false;
        }

        public bool Remove(string id, out Worker removedWorker)
        {
            removedWorker = null;
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i] != null && workers[i].Id == id)
                {
                    removedWorker = workers[i];
                    workers[i] = null;
                    Console.WriteLine("Worker removed.");
                    return true;
                }
            }
            Console.WriteLine("Worker not found.");
            return false;
        }

        public bool Update(string id, params string[] updates)
        {
            foreach (var worker in workers)
            {
                if (worker != null && worker.Id == id)
                {
                    if (updates.Length >= 4)
                    {
                        worker.Name = updates[0];
                        worker.Age = int.Parse(updates[1]);
                        worker.ServiceType = updates[2];
                        worker.Salary = float.Parse(updates[3]);
                        Console.WriteLine("Worker updated.");
                        return true;
                    }
                }
            }
            Console.WriteLine("Worker not found or insufficient update data.");
            return false;
        }

        public Worker Authenticate(string username, string password)
        {
            foreach (var worker in workers)
            {
                if (worker != null && worker.UserName == username && worker.Password == password)
                {
                    return worker;
                }
            }
            return null;
        }

        public void ShowAll()
        {
            Console.WriteLine("-- All Workers --");
            foreach (var w in workers)
                if (w != null) w.ShowDetails();
        }

        public Worker[] GetAll()
        {
            return workers;
        }
    }

    class Admin : Person
    {
        public string Id { get; set; }

        public Admin(string name, int age, string number, GenderType gender, string username, string password, string id)
            : base(name, age, number, gender, username, password)
        {
            Id = id;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Admin Name: {Name}, ID: {Id}, Username: {UserName}");
        }
    }

    class AdminList
    {
        private Admin[] admins = new Admin[10];

        public bool Insert(params Admin[] newAdmins)
        {
            int addedCount = 0;
            foreach (var a in newAdmins)
            {
                for (int i = 0; i < admins.Length; i++)
                {
                    if (admins[i] == null)
                    {
                        admins[i] = a;
                        addedCount++;
                        Console.WriteLine($"Admin {a.Name} added.");
                        break;
                    }
                }
            }

            if (addedCount == newAdmins.Length) return true;
            Console.WriteLine($"Admin list is full. Only added {addedCount} of {newAdmins.Length} admins.");
            return false;
        }

        public bool Remove(string id, out Admin removedAdmin)
        {
            removedAdmin = null;
            for (int i = 0; i < admins.Length; i++)
            {
                if (admins[i] != null && admins[i].Id == id)
                {
                    removedAdmin = admins[i];
                    admins[i] = null;
                    Console.WriteLine("Admin removed.");
                    return true;
                }
            }
            Console.WriteLine("Admin not found.");
            return false;
        }

        public bool Update(string id, params string[] updates)
        {
            for (int i = 0; i < admins.Length; i++)
            {
                if (admins[i] != null && admins[i].Id == id)
                {
                    if (updates.Length >= 6)
                    {
                        admins[i].Name = updates[0];
                        admins[i].Age = int.Parse(updates[1]);
                        admins[i].Number = updates[2];
                        admins[i].Gender = (GenderType)Enum.Parse(typeof(GenderType), updates[3]);
                        admins[i].UserName = updates[4];
                        admins[i].Password = updates[5];
                        Console.WriteLine("Admin updated.");
                        return true;
                    }
                }
            }
            Console.WriteLine("Admin not found or insufficient update data.");
            return false;
        }

        public Admin Authenticate(string username, string password)
        {
            foreach (var admin in admins)
            {
                if (admin != null && admin.UserName == username && admin.Password == password)
                {
                    return admin;
                }
            }
            return null;
        }

        public void ShowAll()
        {
            Console.WriteLine("-- All Admins --");
            bool found = false;
            foreach (var a in admins)
            {
                if (a != null)
                {
                    a.ShowDetails();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No admins available.");
            }
        }

        public Admin[] GetAll()
        {
            return admins;
        }
    }

    class Services
    {
        public string AvailAbleServices { get; set; }
        public double Price { get; set; }
        public string ServiceID { get; set; }

        public Services(string name, double price, string id)
        {
            AvailAbleServices = name;
            Price = price;
            ServiceID = id;
        }

        public void ShowService()
        {
            Console.WriteLine($"Service ID: {ServiceID}, Name: {AvailAbleServices}, Price: {Price}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AdminList adminList = new AdminList();
            ClientList clientList = new ClientList();
            WorkerList workerList = new WorkerList();
            List<Services> services = new List<Services>();

            // Initialize with sample data using params
            adminList.Insert(
                new Admin("Alice", 35, "0123456789", GenderType.Female, "admin1", "pass1", "A001")
            );

            clientList.Insert(
                new Client("Bob", 28, "0198765432", GenderType.Male, "bobc", "1234", "C001", "Dhaka", "Plumbing")
            );

            workerList.Insert(
                new Worker("John", 30, "01711223344", GenderType.Male, "johnw", "abcd", "W001", 1000, "Plumbing", "Dhaka"),
                new Worker("Sarah", 32, "01755667788", GenderType.Female, "sarahw", "efgh", "W002", 1200, "Electrical", "Chittagong")
            );

            Console.WriteLine("===== Home Service Management System =====");

            while (true)
            {
                Console.WriteLine("\n1. Admin Login\n2. Client Login\n3. Client Sign Up\n4. Worker Login\n0. Exit");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                if (choice == "0") break;

                string username = null;
                string password = null;

                if (choice != "3") // Only ask for credentials if not signing up
                {
                    Console.Write("Username: ");
                    username = Console.ReadLine();
                    Console.Write("Password: ");
                    password = Console.ReadLine();
                }

                switch (choice)
                {
                    case "1":
                        var admin = adminList.Authenticate(username, password);
                        if (admin != null)
                        {
                            Console.WriteLine("\n-- Admin Dashboard --");
                            while (true)
                            {
                                Console.WriteLine("\n1. Manage Clients\n2. Manage Workers\n3. Manage Services\n4. Show Matches\n5. Manage Admins\n0. Logout");
                                Console.Write("Select option: ");
                                string adminChoice = Console.ReadLine();

                                if (adminChoice == "0") break;

                                switch (adminChoice)
                                {
                                    case "1":
                                        Console.WriteLine("\n--- Client Management ---");
                                        Console.WriteLine("1. Add Client\n2. Remove Client\n3. Update Client\n4. Show Clients");
                                        Console.Write("Choice: ");
                                        string cOpt = Console.ReadLine();

                                        if (cOpt == "1")
                                        {
                                            Console.Write("ID: ");
                                            string id = Console.ReadLine();
                                            Console.Write("Name: ");
                                            string name = Console.ReadLine();
                                            Console.Write("Age: ");
                                            int age = int.Parse(Console.ReadLine());
                                            Console.Write("Number: ");
                                            string num = Console.ReadLine();
                                            Console.Write("Gender (Male/Female/Other): ");
                                            GenderType gender = (GenderType)Enum.Parse(typeof(GenderType), Console.ReadLine());
                                            Console.Write("Username: ");
                                            string uname = Console.ReadLine();
                                            Console.Write("Password: ");
                                            string pass = Console.ReadLine();
                                            Console.Write("Location: ");
                                            string loc = Console.ReadLine();
                                            Console.Write("Service Holding: ");
                                            string serv = Console.ReadLine();

                                            bool added = clientList.Insert(new Client(name, age, num, gender, uname, pass, id, loc, serv));
                                            if (!added)
                                            {
                                                Console.WriteLine("Could not add client. Client list is full.");
                                            }
                                        }
                                        else if (cOpt == "2")
                                        {
                                            Console.Write("Enter client ID to remove: ");
                                            if (!clientList.Remove(Console.ReadLine(), out Client removedClient))
                                            {
                                                Console.WriteLine("Failed to remove client.");
                                            }
                                        }
                                        else if (cOpt == "3")
                                        {
                                            Console.Write("Enter client ID to update: ");
                                            string updateId = Console.ReadLine();
                                            Console.Write("Enter new name: ");
                                            string name = Console.ReadLine();
                                            Console.Write("Enter new age: ");
                                            string age = Console.ReadLine();
                                            Console.Write("Enter new number: ");
                                            string num = Console.ReadLine();
                                            Console.Write("Enter new service: ");
                                            string serv = Console.ReadLine();

                                            if (!clientList.Update(updateId, name, age, num, serv))
                                            {
                                                Console.WriteLine("Failed to update client.");
                                            }
                                        }
                                        else if (cOpt == "4")
                                        {
                                            clientList.ShowAll();
                                        }
                                        break;

                                    case "2":
                                        Console.WriteLine("\n--- Worker Management ---");
                                        Console.WriteLine("1. Add Worker\n2. Remove Worker\n3. Update Worker\n4. Show Workers");
                                        Console.Write("Choice: ");
                                        string wOpt = Console.ReadLine();

                                        if (wOpt == "1")
                                        {
                                            Console.Write("ID: ");
                                            string id = Console.ReadLine();
                                            Console.Write("Name: ");
                                            string name = Console.ReadLine();
                                            Console.Write("Age: ");
                                            int age = int.Parse(Console.ReadLine());
                                            Console.Write("Number: ");
                                            string num = Console.ReadLine();
                                            Console.Write("Gender (Male/Female/Other): ");
                                            GenderType gender = (GenderType)Enum.Parse(typeof(GenderType), Console.ReadLine());
                                            Console.Write("Username: ");
                                            string uname = Console.ReadLine();
                                            Console.Write("Password: ");
                                            string pass = Console.ReadLine();
                                            Console.Write("Salary: ");
                                            float salary = float.Parse(Console.ReadLine());
                                            Console.Write("Service Type: ");
                                            string type = Console.ReadLine();
                                            Console.Write("Location: ");
                                            string loc = Console.ReadLine();

                                            if (!workerList.Insert(new Worker(name, age, num, gender, uname, pass, id, salary, type, loc)))
                                            {
                                                Console.WriteLine("Failed to add worker.");
                                            }
                                        }
                                        else if (wOpt == "2")
                                        {
                                            Console.Write("Enter worker ID to remove: ");
                                            if (!workerList.Remove(Console.ReadLine(), out Worker removedWorker))
                                            {
                                                Console.WriteLine("Failed to remove worker.");
                                            }
                                        }
                                        else if (wOpt == "3")
                                        {
                                            Console.Write("Enter worker ID to update: ");
                                            string updateId = Console.ReadLine();
                                            Console.Write("Enter new name: ");
                                            string name = Console.ReadLine();
                                            Console.Write("Enter new age: ");
                                            string age = Console.ReadLine();
                                            Console.Write("Enter new service type: ");
                                            string type = Console.ReadLine();
                                            Console.Write("Enter new salary: ");
                                            string salary = Console.ReadLine();

                                            if (!workerList.Update(updateId, name, age, type, salary))
                                            {
                                                Console.WriteLine("Failed to update worker.");
                                            }
                                        }
                                        else if (wOpt == "4")
                                        {
                                            if (workerList.Count() == 0)
                                            {
                                                Console.WriteLine("No workers available.");
                                            }
                                            else
                                            {
                                                workerList.ShowAll();
                                            }
                                        }
                                        break;

                                    case "3":
                                        Console.WriteLine("\n--- Services Management ---");
                                        Console.WriteLine("1. Add Service\n2. Remove Service\n3. Show Services");
                                        Console.Write("Choice: ");
                                        string sOpt = Console.ReadLine();

                                        if (sOpt == "1")
                                        {
                                            Console.Write("Service ID: ");
                                            string id = Console.ReadLine();
                                            Console.Write("Name: ");
                                            string name = Console.ReadLine();
                                            Console.Write("Price: ");
                                            double price = double.Parse(Console.ReadLine());
                                            services.Add(new Services(name, price, id));
                                            Console.WriteLine("Service added.");
                                        }
                                        else if (sOpt == "2")
                                        {
                                            Console.Write("Enter Service ID to remove: ");
                                            string removeId = Console.ReadLine();
                                            var serviceToRemove = services.FirstOrDefault(s => s.ServiceID == removeId);
                                            if (serviceToRemove != null)
                                            {
                                                services.Remove(serviceToRemove);
                                                Console.WriteLine("Service removed.");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Service not found.");
                                            }
                                        }
                                        else if (sOpt == "3")
                                        {
                                            if (services.Count == 0)
                                            {
                                                Console.WriteLine("No services available.");
                                            }
                                            else
                                            {
                                                foreach (var service in services)
                                                {
                                                    service.ShowService();
                                                }
                                            }
                                        }
                                        break;

                                    case "4":
                                        Console.WriteLine("\n--- Show Matches between Clients and Workers ---");
                                        bool matchFound = false;
                                        foreach (var c in clientList.GetAll())
                                        {
                                            if (c != null)
                                            {
                                                foreach (var w in workerList.GetAll())
                                                {
                                                    if (w != null &&
                                                        w.ServiceType.Equals(c.ServiceHolding, StringComparison.OrdinalIgnoreCase) &&
                                                        w.Location.Equals(c.Location, StringComparison.OrdinalIgnoreCase))
                                                    {
                                                        Console.WriteLine($"Match Found: Client ID: {c.Id}, Worker ID: {w.Id}");
                                                        matchFound = true;
                                                    }
                                                }
                                            }
                                        }
                                        if (!matchFound)
                                        {
                                            Console.WriteLine("No matches found between clients and workers.");
                                        }
                                        break;

                                    case "5":
                                        while (true)
                                        {
                                            Console.WriteLine("\n-- Manage Admins --");
                                            Console.WriteLine("1. Insert Admin");
                                            Console.WriteLine("2. Update Admin");
                                            Console.WriteLine("3. Remove Admin");
                                            Console.WriteLine("4. Show All Admins");
                                            Console.WriteLine("0. Back");
                                            Console.Write("Select option: ");
                                            string adminManageChoice = Console.ReadLine();

                                            switch (adminManageChoice)
                                            {
                                                case "1":
                                                    Console.Write("Enter ID: ");
                                                    string id = Console.ReadLine();
                                                    Console.Write("Enter Name: ");
                                                    string name = Console.ReadLine();
                                                    Console.Write("Enter Age: ");
                                                    int age = int.Parse(Console.ReadLine());
                                                    Console.Write("Enter Number: ");
                                                    string number = Console.ReadLine();
                                                    Console.Write("Enter Gender (Male/Female/Other): ");
                                                    GenderType gender = (GenderType)Enum.Parse(typeof(GenderType), Console.ReadLine());
                                                    Console.Write("Enter Username: ");
                                                    string uname = Console.ReadLine();
                                                    Console.Write("Enter Password: ");
                                                    string pass = Console.ReadLine();

                                                    Admin newAdmin = new Admin(name, age, number, gender, uname, pass, id);
                                                    if (!adminList.Insert(newAdmin))
                                                    {
                                                        Console.WriteLine("Failed to add admin.");
                                                    }
                                                    break;

                                                case "2":
                                                    Console.Write("Enter ID to update: ");
                                                    string updateId = Console.ReadLine();
                                                    Console.Write("Enter new name: ");
                                                    string newName1 = Console.ReadLine();
                                                    Console.Write("Enter new age: ");
                                                    string newAge1 = Console.ReadLine();
                                                    Console.Write("Enter new number: ");
                                                    string newNumber1 = Console.ReadLine();
                                                    Console.Write("Enter new gender (Male/Female/Other): ");
                                                    string newGender1 = Console.ReadLine();
                                                    Console.Write("Enter new username: ");
                                                    string newUname1 = Console.ReadLine();
                                                    Console.Write("Enter new password: ");
                                                    string newPass1 = Console.ReadLine();

                                                    if (!adminList.Update(updateId, newName1, newAge1, newNumber1, newGender1, newUname1, newPass1))
                                                    {
                                                        Console.WriteLine("Failed to update admin.");
                                                    }
                                                    break;

                                                case "3":
                                                    Console.Write("Enter ID to remove: ");
                                                    if (!adminList.Remove(Console.ReadLine(), out Admin removedAdmin))
                                                    {
                                                        Console.WriteLine("Failed to remove admin.");
                                                    }
                                                    break;

                                                case "4":
                                                    adminList.ShowAll();
                                                    break;

                                                case "0":
                                                    goto EndAdminManagement;

                                                default:
                                                    Console.WriteLine("Invalid option.");
                                                    break;
                                            }
                                        }
                                    EndAdminManagement:
                                        break;

                                    default:
                                        Console.WriteLine("Invalid choice.");
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid username or password.");
                        }
                        break;

                    case "2":
                        var client = clientList.Authenticate(username, password);
                        if (client != null)
                        {
                            Console.WriteLine("\n-- Client Dashboard --");
                            client.ShowDetails();

                            while (true)
                            {
                                Console.WriteLine("\n1. View All Services\n2. Find Matching Workers\n0. Logout");
                                Console.Write("Select option: ");
                                string clientOption = Console.ReadLine();

                                if (clientOption == "0") break;

                                switch (clientOption)
                                {
                                    case "1":
                                        Console.WriteLine("\n-- Available Services --");
                                        if (services.Count == 0)
                                        {
                                            Console.WriteLine("No services available.");
                                        }
                                        else
                                        {
                                            foreach (var service in services)
                                            {
                                                service.ShowService();
                                            }
                                        }
                                        break;

                                    case "2":
                                        Console.WriteLine("\n-- Matching Workers --");
                                        bool found = false;
                                        foreach (var workerMatch in workerList.GetAll())
                                        {
                                            if (workerMatch != null &&
                                                workerMatch.ServiceType.Equals(client.ServiceHolding, StringComparison.OrdinalIgnoreCase) &&
                                                workerMatch.Location.Equals(client.Location, StringComparison.OrdinalIgnoreCase))
                                            {
                                                workerMatch.ShowDetails();
                                                found = true;
                                            }
                                        }
                                        if (!found)
                                        {
                                            Console.WriteLine("No matching workers found for your service and location.");
                                        }
                                        break;

                                    default:
                                        Console.WriteLine("Invalid option.");
                                        break;
                                }
                            }
                        }
                        else Console.WriteLine("Invalid client credentials.");
                        break;

                    case "3": // Client Sign-Up
                        Console.WriteLine("\n--- Client Sign-Up ---");
                        Console.Write("ID: ");
                        string newId = Console.ReadLine();
                        Console.Write("Name: ");
                        string newName = Console.ReadLine();
                        Console.Write("Age: ");
                        int newAge = int.Parse(Console.ReadLine());
                        Console.Write("Number: ");
                        string newNumber = Console.ReadLine();
                        Console.Write("Gender (Male/Female/Other): ");
                        GenderType newGender = (GenderType)Enum.Parse(typeof(GenderType), Console.ReadLine());
                        Console.Write("Username: ");
                        string newUsername = Console.ReadLine();
                        Console.Write("Password: ");
                        string newPassword = Console.ReadLine();
                        Console.Write("Location: ");
                        string newLocation = Console.ReadLine();
                        Console.Write("Service Holding: ");
                        string newService = Console.ReadLine();

                        bool signupSuccess = clientList.Insert(new Client(newName, newAge, newNumber, newGender, newUsername, newPassword, newId, newLocation, newService));
                        if (signupSuccess)
                        {
                            Console.WriteLine("Sign-up successful! You can now log in as a client.");
                        }
                        else
                        {
                            Console.WriteLine("Sign-up failed. Client list is full.");
                        }
                        break;

                    case "4":
                        var worker = workerList.Authenticate(username, password);
                        if (worker != null)
                        {
                            Console.WriteLine("Worker logged in.");
                            worker.ShowDetails();

                            while (true)
                            {
                                Console.WriteLine("\n1. View All Services\n2. Match with Clients\n0. Logout");
                                Console.Write("Select option: ");
                                string workerOption = Console.ReadLine();

                                if (workerOption == "0") break;

                                switch (workerOption)
                                {
                                    case "1":
                                        Console.WriteLine("\n-- Available Services --");
                                        if (services.Count == 0)
                                        {
                                            Console.WriteLine("No services available.");
                                        }
                                        else
                                        {
                                            foreach (var service in services)
                                            {
                                                service.ShowService();
                                            }
                                        }
                                        break;

                                    case "2":
                                        Console.WriteLine("\n-- Matching Clients --");
                                        bool foundClient = false;
                                        foreach (var clientMatch in clientList.GetAll())
                                        {
                                            if (clientMatch != null &&
                                                clientMatch.ServiceHolding.Equals(worker.ServiceType, StringComparison.OrdinalIgnoreCase) &&
                                                clientMatch.Location.Equals(worker.Location, StringComparison.OrdinalIgnoreCase))
                                            {
                                                clientMatch.ShowDetails();
                                                foundClient = true;
                                            }
                                        }
                                        if (!foundClient)
                                        {
                                            Console.WriteLine("No matching clients found for your service and location.");
                                        }
                                        break;

                                    default:
                                        Console.WriteLine("Invalid option.");
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid worker credentials.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
