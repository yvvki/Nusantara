using System.Numerics;

namespace Nusantara.Core;

/// <summary>
///   Represents general direction of axes.
/// </summary>
public static class Directions
{
	/// <summary>
	///   The right facing vector.
	/// </summary>
	public static Vector3 Right => Vector3.UnitX;

	/// <summary>
	///   The forward facing vector.
	/// </summary>
	public static Vector3 Forward => Vector3.UnitY;

	/// <summary>
	///   The up facing vector.
	/// </summary>
	public static Vector3 Up => Vector3.UnitZ;
}
