using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure.Figure
{
	public class Circle : Shape
	{
		public Circle(float radius) : base(0,0,0,radius)
		{
		}

		public override float SquareFigure()
		{
			var square = MathF.PI * Radius * Radius;
			return square;
		}
	}
}
