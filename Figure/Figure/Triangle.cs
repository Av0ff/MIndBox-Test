using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure.Figure
{
	public class Triangle : Shape
	{
		public Triangle(float a, float b, float c) : base(a,b,c,0)
		{
		}
		public override float SquareFigure()
		{
			if (C*C == A*A + B*B)
			{
				RightTriangle = true;
			}

			if (RightTriangle == true)
			{
				float square = 1f / 2f * (A * B);
				return square;
			}
			else
			{
				var p = (A + B + C) / 2;
				var square = MathF.Sqrt(p*(p-A)*(p-B)*(p-C));
				return square;
			}
		}
	}
}
