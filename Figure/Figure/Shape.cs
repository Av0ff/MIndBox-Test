using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure.Figure
{
	public class Shape
	{
		public Shape(float a, float b, float c, float radius)
		{
			A = a;
			B = b;
			C = c;
			Radius = radius;
		}

		public float Radius { get; }
		public float A { get; }
		public float B { get; }
		public float C { get; }

		public bool RightTriangle { get; protected set; }

		public Shape? IdentityFigure()
		{
			if (Radius != default && (A * B * C) != 0)
				return null;
			if (Radius != default)
				return new Circle(Radius);
			if ((A * B * C) != 0)
				return new Triangle(A,B,C);
			else
				return null;
		}

		public virtual float SquareFigure()
		{
			return default;
		}
	}
}
