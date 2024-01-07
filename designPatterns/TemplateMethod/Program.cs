﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ScoringAlgorithm _algorithm;
            Console.WriteLine("Men");
            _algorithm = new MenScoringAlgorithm();
            Console.WriteLine(_algorithm.GenerateScore(8,new TimeSpan(0,2,30)));

            Console.WriteLine("Women");
            _algorithm = new WomenScoringAlgrotihm();
            Console.WriteLine(_algorithm.GenerateScore(8, new TimeSpan(0, 2, 30)));

            Console.WriteLine("Children");
            _algorithm = new ChildrenScoringAlgorithm();
            Console.WriteLine(_algorithm.GenerateScore(8, new TimeSpan(0, 2, 30)));

            Console.ReadLine();
        }
    }


    abstract class ScoringAlgorithm
    {
        public int GenerateScore(int hits,TimeSpan time)
        {
            int score = CalculateBaseScore(hits);
            int reduction = CalculateReduction(time);
            return CalculateOverallScore(score,reduction);


        }

        public abstract int CalculateOverallScore(int score,int reduction);
        public abstract int CalculateBaseScore(int hits);
        public abstract int CalculateReduction(TimeSpan time);


    }

    class MenScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 5;
        }
    }

    class WomenScoringAlgrotihm : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 3;
        }
    }

    class ChildrenScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 80;
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 2;
        }
    }



}
