using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingPractice.HackerRank;

namespace CodingPractice
{
    public class Pages
    {
        private static HackerRankProblems _hackerRankProblems;
        public static HackerRankProblems HackerRankProblems => _hackerRankProblems ?? (_hackerRankProblems = new HackerRankProblems());
    }
}
