using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BudgetBrainDesktop.Models
{
    public class DashboardModel
    {
        [JsonPropertyName("balance")]
        public int Balance { get; set; }
        [JsonPropertyName("income")]
        public int Income { get; set; }
        [JsonPropertyName("expense")]
        public int Expense { get; set; }
        [JsonPropertyName("entries")]
        public List<EntriesModel> entry { get; set; }
    }
}
