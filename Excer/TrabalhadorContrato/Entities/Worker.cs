using System.Collections.Generic;
using TrabalhadorContrato.Entities.Enums;

namespace TrabalhadorContrato.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } 
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        // Um worker pode ter vários contratos - Instanciando garante que não seja nula
        public Worker()
        {

        }
        // Não é usual passar uma Lista instanciada do construtor. 
        // A list começa vazia e aos poucos recebe os valores
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }
        // recebe contrato e adiciona a lista HourContract
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        // percorre o lis Contracts e executa TotalValue();
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
