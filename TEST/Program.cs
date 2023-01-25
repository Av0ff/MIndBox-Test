using Figure.Figure;

namespace TEST
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите параметры для фигуры: \n 1.Первая сторона\n 2.Вторая сторона\n 3.Третья сторона\n 4.Радиус");
			var a = float.Parse(Console.ReadLine());
			var b = float.Parse(Console.ReadLine());
			var c = float.Parse(Console.ReadLine());
			var radius = float.Parse(Console.ReadLine());

			var shape = new Shape(a,b,c,radius);
			var figure = shape.IdentityFigure();
			var square = figure?.SquareFigure();

			if (figure == null)
			{
				Console.WriteLine("Данная фигура не определена");
			}
			else if (figure is Triangle triangle)
			{
				Console.WriteLine($"Figure: {figure.GetType().Name} / Right Triangle: {triangle.RightTriangle} / Square: {square}");
			}
			else
				Console.WriteLine($"Figure: {figure.GetType().Name} / Square: {square}");
		}

	}
}