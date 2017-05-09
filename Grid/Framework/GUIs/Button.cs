﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Grid.Framework.GUIs
{
    public class Button : Clickable
    {
        private float _border = 1;
        public float Border { get => _border; set { _border = Math.Max(0, value); } }
        public Color BorderColor { get; set; } = Color.Black;
        public Color Color { get; set; } = Color.White;

        public float X { get; set; } = -1;
        public float Y { get; set; } = -1;
        public float Width { get; set; } = -1;
        public float Height { get; set; } = -1;

        public Button(float x, float y, float width, float height)
        {
            X = x; Y = y; Width = width; Height = height;
        }

        public override bool IsInRect(Point point)
            => X < point.X && point.X < X + Width
            && Y < point.Y && point.Y < Y + Height;

        public override void Draw(SpriteBatch sb)
        {
            throw new NotImplementedException();
            base.Draw(sb);
        }
    }
}
