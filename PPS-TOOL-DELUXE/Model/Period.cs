namespace PPS_TOOL_DELUXE.Model
{
    public class Period
    {
        public int Id { get; set; }
        public string Efficiency { get; set; }
        public string Workload { get; set; }
        public double Profit { get; set; }
        public double Totalprofit { get; set; }

        public Period()
        {
            
        }

        public Period(int id, string efficiency, string workload, double profit, double totalprofit)
        {
            Id = id;
            Efficiency = efficiency;
            Workload = workload;
            Profit = profit;
            Totalprofit = totalprofit;
        }
    }
}
