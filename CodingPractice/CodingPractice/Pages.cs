using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingPractice.HackerRankProblems;

namespace CodingPractice
{
    public class Pages
    {
        private static WarmupProblems _warmupProblems;
        private static ImplementationProblems _implementationProblems;
        public static WarmupProblems WarmupProblems => _warmupProblems ?? (_warmupProblems = new WarmupProblems());
        public static ImplementationProblems ImplementationProblems => _implementationProblems ?? (_implementationProblems = new ImplementationProblems());
    }
}
