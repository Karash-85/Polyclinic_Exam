using Polyclinic.Data;
using Polyclinic.Models;
using System;
using System.Linq;

namespace Polyclinic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем объекты User
                User user1 = new User { Name = "Tom", Sex = "male" };
                User user2 = new User { Name = "Alice", Sex = "female" };
                User user3 = new User { Name = "Hanks", Sex = "male" };
                User user4 = new User { Name = "Dina", Sex = "female" };
                User user5 = new User { Name = "Mira", Sex = "female" };
                User user6 = new User { Name = "Riza", Sex = "female" };

                // добавляем их в бд
                db.Users.Add(user1);
                db.Users.Add(user2);
                db.Users.Add(user3);
                db.Users.Add(user4);
                db.Users.Add(user5);
                db.Users.Add(user6);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var users = db.Users.ToList();
                Console.WriteLine("Список объектов:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Sex}");
                }
            }
            using (ApplicationContextDoctor db = new ApplicationContextDoctor())
            {
                // создаем объекты Doctor
                Doctor doctor1 = new Doctor { DoctorName = "Mary", Position = "therapist" };
                Doctor doctor2 = new Doctor { DoctorName = "Sonja", Position = "psychologist" };
                Doctor doctor3 = new Doctor { DoctorName = "Lisa", Position = "endocrinologist" };
                Doctor doctor4 = new Doctor { DoctorName = "Lara", Position = "dentist" };

                // добавляем их в бд
                db.Doctors.Add(doctor1);
                db.Doctors.Add(doctor2);
                db.Doctors.Add(doctor2);
                db.Doctors.Add(doctor2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var doctors = db.Doctors.ToList();
                Console.WriteLine("Список объектов:");
                foreach (Doctor u in doctors)
                {
                    Console.WriteLine($"{u.Id}.{u.DoctorName} - {u.Position}");
                }
            }
            Console.Read();


            /*Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tВыберите пожалуйста врача");
            Console.WriteLine("\t----------------------------------------------\n");
            Console.ResetColor();

            while (true)
            {
                Console.WriteLine("1.Регистрация");
                Console.WriteLine("2.Войти");
                Console.WriteLine("0.Выход\n");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        using (User connection = new User())
                        {
                            while (true)
                            {
                                Console.Write("Введите имя:");
                                string login = Console.ReadLine();

                            };
                        };
                    case "2":
                }  TO DO

            }*/
        }
    }
}
