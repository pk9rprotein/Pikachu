﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pikachu.GameObject
{
	/// <summary>Hình nền.</summary>
	internal class Background : ScreenObjectWithSize
	{
		readonly Image image = Properties.Resources.bg1;

		public override void Draw(Graphics g)
		{
			Rectangle rectangle = new(location, size);
			g.DrawImage(image, rectangle);
		}
	}
}
