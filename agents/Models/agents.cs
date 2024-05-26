using System.Collections.Generic;

namespace agents.Models;

public class agents
{
    public string Name { get; set; }  // наименование
    public double Sales { get; set; }  // количество продаж за год
    public double Discount { get; set; }  // размер скидки
    public string Phone { get; set; }  // телефон
    public string AgentType { get; set; }  // тип агента
    
    private void CalculateDiscount()
    {
        if (Sales < 10000)
        {
            Discount = 0;
        }
        else if (Sales < 50000)
        {
            Discount = 0.05;
        }
        else if (Sales < 150000)
        {
            Discount = 0.1;
        }
        else if (Sales < 500000)
        {
            Discount = 0.2;
        }
        else
        {
            Discount = 0.25;
        }
    }

    public List<agents> AgentsList = new List<agents>();
}