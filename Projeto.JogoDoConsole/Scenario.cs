using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.JogoDoConsole
{
    internal class Scenario
    {
        private int _pointsProbabilities;
        private Random Random { get; set; }
        private List<bool> Points { get; set; }
        private string _scenarioType;

        public string ScenarioType
        {
            get { return this._scenarioType; }
            set { this._scenarioType = value; }
        }

        private byte _scenarioSize;

        public byte ScenarioSize
        {
            get { return this._scenarioSize; }
            set { this._scenarioSize = value; }
        }

        public Scenario(string scenarioType, byte scenarioSize, int probability)
        {
            ScenarioType = scenarioType;
            ScenarioSize = scenarioSize;
            Random = new Random(DateTime.Now.Millisecond);
            Points = new List<bool>();
            _pointsProbabilities = probability;
            GenerateScenarioPoints(_pointsProbabilities);
        }

        public async Task ScenarioPrinterAsync(Player p1)
        {
            Console.Clear();
            Console.WriteLine($"Pontos: {p1.Points}");
            //Ceu
            for (int i = 0; i < this.ScenarioSize; i++)
            {
                bool printPoint = Points[i];
                if (p1.PlayerPosition == i && p1.Jump == true)
                {
                    Console.Write(p1.Skin);
                    if (printPoint == true)
                    {
                        Points[i] = false;
                        p1.AddPoints();
                        Console.Beep();
                    }
                }
                else
                {
                    if (printPoint) Console.Write("*");
                    else Console.Write(" ");
                }
            }
            Console.WriteLine();
            //terra
            for (int i = 0; i < this.ScenarioSize; i++)
            {
                if (p1.PlayerPosition == i && p1.Jump == false) Console.Write(p1.Skin);
                else Console.Write(ScenarioType);
            }

            if(!Points.Any(p => p == true))
            {
                GenerateScenarioPoints(_pointsProbabilities);
            }

            if (p1.Jump == true)
            {
                p1.Jump = false;
                await Task.Delay(200);
                await ScenarioPrinterAsync(p1);
            }
        }

        public void GenerateScenarioPoints(int probability)
        {
            Points.Clear();
            for (int i = 0; i < this.ScenarioSize; i++)
            {
                bool havePoint = HavePoint(probability);
                Points.Add(havePoint);
            }
        }

        public bool HavePoint(int probability)
        {
            int value = Random.Next(100);

            return value < probability;
        }
    }
}
