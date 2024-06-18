namespace ConceptsPOO_Application
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercentage { get; set; }

        public decimal Sales { get; set; }
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentage;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommission percentage: {$"{CommissionPercentage:P2}", 18}" +
                $"\n\tSales................: {$"{Sales:C2}", 18}" +
                $"\n\tValue to Pay.........: {$"{GetValueToPay():C2}", 18}";
        }
    }
}
