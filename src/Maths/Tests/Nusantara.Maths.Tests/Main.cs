using System.Numerics;

using Nusantara.Maths;

Random r = new();

TestWikipedia();
TestDotnet();

void TestWikipedia()
{
	EulerRotation e1 = new(r.NextSingle(), r.NextSingle(), r.NextSingle());
	Quaternion q1 = EulerRotation.ToQuaternionWikipedia(e1);

	EulerRotation e2 = EulerRotation.FromQuaternionWikipedia(q1);
	Quaternion q2 = EulerRotation.ToQuaternionWikipedia(e2);

	Console.WriteLine(e1);
	Console.WriteLine(e2);
	Console.WriteLine();
	Console.WriteLine(q1);
	Console.WriteLine(q2);
}

void TestDotnet()
{
	EulerRotation e1 = new(r.NextSingle(), r.NextSingle(), r.NextSingle());
	Quaternion q1 = EulerRotation.ToQuaternionDotnet(e1);

	EulerRotation e2 = EulerRotation.FromQuaternionDotnet(q1);
	Quaternion q2 = EulerRotation.ToQuaternionDotnet(e2);

	Console.WriteLine(e1);
	Console.WriteLine(e2);
	Console.WriteLine();
	Console.WriteLine(q1);
	Console.WriteLine(q2);
}
