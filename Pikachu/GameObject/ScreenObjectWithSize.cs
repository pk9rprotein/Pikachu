﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pikachu.GameObject
{
	/// <summary>Đối tượng hiển thị trên màn hình với toạ độ và kích thước.</summary>
	internal abstract class ScreenObjectWithSize : ScreenObject
	{
		/// <summary>Kích thước đối tượng.</summary>
		public Size size;
	}
}
