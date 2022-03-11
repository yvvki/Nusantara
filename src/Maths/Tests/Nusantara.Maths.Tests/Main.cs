using System.Numerics;

using Nusantara.Maths;

Random r = new();

EulerRotation e1 = new(r.NextSingle(), r.NextSingle(), r.NextSingle());
Quaternion q1 = (Quaternion)(e1);

EulerRotation e2 = (EulerRotation)(q1);
Quaternion q2 = (Quaternion)(e2);

Console.WriteLine(e1);
Console.WriteLine(e2);
Console.WriteLine();
Console.WriteLine(q1);
Console.WriteLine(q2);
