using ConsoleApp;
using System.Runtime.CompilerServices;

namespace TestProjects
{
	[TestClass]
	public class LessonOneTests
	{
		private LessonOne _lessonOne = new LessonOne();

		/// <summary>
		/// Ќаписать тест, который провер€ет, что дл€ уравнени€ x^2+1 = 0 корней нет (возвращаетс€ пустой массив)
		/// </summary>
		[TestMethod]
		public void CheckNoRoot(double a, double b, double c)
		{
			// Arrange
			var a1 = a;
			var b1 = b;
			var c1 = c;

			// Act
			var D = Math.Sqrt(b1) - 4 * a1 * c1;
			var checkNoRoot = D < 0;

			// Assert
			Assert.AreEqual(true, checkNoRoot);
		}

		/// <summary>
		/// Ќаписать тест, который провер€ет, что дл€ уравнени€ x^2-1 = 0 есть два корн€ кратности 1 (x1=1, x2=-1)
		/// </summary>
		[TestMethod]
		public void Test2()
		{

		}

		/// <summary>
		/// Ќаписать тест, который провер€ет, что дл€ уравнени€ x^2+2x+1 = 0 есть один корень кратности 2 (x1= x2 = -1).
		/// </summary>
		[TestMethod]
		public void Test3()
		{

		}

		/// <summary>
		/// Ќаписать тест, который провер€ет, что коэффициент a не может быть равен 0. ¬ этом случае solve выбрасывает исключение.
		/// ѕримечание.”честь, что a имеет тип double и сравнивать с 0 через == нельз€.
		/// </summary>
		[TestMethod]
		public void Test4()
		{

		}
	}
}