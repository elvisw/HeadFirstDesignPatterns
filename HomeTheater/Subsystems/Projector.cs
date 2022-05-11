﻿using System;

namespace HomeTheater
{
    public class Projector
    {
        private readonly string _description;
        private readonly IVideoPort _player;

        public Projector(string description, IVideoPort player)
        {
            _description = description;
            _player = player;
        }

        public void On()
        {
            Console.WriteLine($"{_description} on");
        }

        public void Off()
        {
            Console.WriteLine($"{_description} off");
        }

        public void WideScreenMode()
        {
            Console.WriteLine($"{_description} in widescreen mode (16x9 aspect ratio)");
        }

        public void TvMode()
        {
            Console.WriteLine($"{_description} in tv mode (4x3 aspect ratio)");
        }

        public override string ToString()
        {
            return _description;
        }
    }
}