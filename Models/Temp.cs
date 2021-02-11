using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_net_fourth_assignment.Models
{
    public class Temp
    {
        private static List<Suggestions> suggestion = new List<Suggestions>();

        public static IEnumerable<Suggestions> Suggestions => suggestion;

        public static void AddSuggestion(Suggestions recommendation)
        {
            suggestion.Add(recommendation);
        }
    }
}
