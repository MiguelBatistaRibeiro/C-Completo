using System;
using System.Globalization;
using TrabalhadorContrato.Entities;
using TrabalhadorContrato.Entities.Enums;

namespace TrabalhadorContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o nome do Departamento: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Entre com os dados do trabalhador: ");
            Console.Write("Nome: "); 
            string name = Console.ReadLine();
            Console.WriteLine("Nivel (Junior/Pleno/Senior): ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());
            Console.Write("Salário Base: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // adicionando os dados recebidos aos objetos abaixo
            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("Quantidade de contratos desse trabalhador? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com os dados do #{i} contrato:");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração (horas): ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine();
                // adicionando dados ao trabalhador
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Entre com mês e ano para calcular o ganho (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            // Substring - captura uma parte da string
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Nome : " + worker.Name);
            Console.WriteLine("Departmento: " + worker.Department.Name);
            Console.WriteLine("Ganho em " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}

