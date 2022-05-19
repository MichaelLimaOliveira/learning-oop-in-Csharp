using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.JogoDoConsole
{
    internal class Player
    {
        private string _skin;

        public string Skin
        {
            get { return this._skin; }
            set { this._skin = value; }
        }

        private byte _playerPosition;

        public byte PlayerPosition
        {
            get { return this._playerPosition; }
            set { this._playerPosition = value; }
        }

        private bool _jump;

        public bool Jump
        {
            get { return this._jump; }
            set { this._jump = value; }
        }

        private int _points;

        public int Points
        {
            get { return this._points; }
            set { this._points = value; }
        }


        public Player()
        {
            Points = 0;
            PlayerPosition = 0;
        }

        public void Movement(char value)
        {
            Jump = false;
            if (value == 'L')
            {
                PlayerPosition--;
                Skin = "q";

            }
            if (value == 'R')
            {
                PlayerPosition++;
                Skin = "p";
            }
        }

        public void AddPoints() => this.Points++;
    }
}
