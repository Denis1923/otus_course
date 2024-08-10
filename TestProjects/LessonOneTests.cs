using ConsoleApp;
using System.Runtime.CompilerServices;

namespace TestProjects
{
	[TestClass]
	public class LessonOneTests
	{
		private LessonOne _lessonOne = new LessonOne();

		/// <summary>
		/// �������� ����, ������� ���������, ��� ��� ��������� x^2+1 = 0 ������ ��� (������������ ������ ������)
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
		/// �������� ����, ������� ���������, ��� ��� ��������� x^2-1 = 0 ���� ��� ����� ��������� 1 (x1=1, x2=-1)
		/// </summary>
		[TestMethod]
		public void Test2()
		{

		}

		/// <summary>
		/// �������� ����, ������� ���������, ��� ��� ��������� x^2+2x+1 = 0 ���� ���� ������ ��������� 2 (x1= x2 = -1).
		/// </summary>
		[TestMethod]
		public void Test3()
		{

		}

		/// <summary>
		/// �������� ����, ������� ���������, ��� ����������� a �� ����� ���� ����� 0. � ���� ������ solve ����������� ����������.
		/// ����������.������, ��� a ����� ��� double � ���������� � 0 ����� == ������.
		/// </summary>
		[TestMethod]
		public void Test4()
		{

		}
	}
}