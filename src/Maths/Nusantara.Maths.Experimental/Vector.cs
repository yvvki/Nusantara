// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

using Silk.NET.Maths;

namespace Nusantara.Maths;

public interface IVector<TSelf, TNumber> :
	IList,
	IList<TNumber>,
	IReadOnlyList<TNumber>,

	IAdditiveIdentity<TSelf, TSelf>,
	IMultiplicativeIdentity<TSelf, TSelf>,

	IEqualityOperators<TSelf, TSelf>,

	IUnaryNegationOperators<TSelf, TSelf>,
	IAdditionOperators<TSelf, TSelf, TSelf>,
	ISubtractionOperators<TSelf, TSelf, TSelf>,
	IMultiplyOperators<TSelf, TSelf, TSelf>,
	IDivisionOperators<TSelf, TSelf, TSelf>,

	IFormattable

	where TSelf : struct, IVector<TSelf, TNumber>
	where TNumber : unmanaged, INumber<TNumber>
{
	// value should be constant.
	static new abstract int Count { get; }
	static new abstract bool IsReadOnly { get; }

	static abstract TSelf Zero { get; }
	static abstract TSelf One { get; }

	int Length => TSelf.Count; // Workaround in order for from end and range indexer to work.
	new TNumber this[int index] { get; set; }

	static abstract TSelf operator *(TSelf left, TNumber right);
	static abstract TSelf operator *(TNumber left, TSelf right);
	static abstract TSelf operator /(TSelf left, TNumber right);

	static TSelf Add(TSelf left, TSelf right)
	{
		return left + right;
	}

	static TSelf Subtract(TSelf left, TSelf right)
	{
		return left - right;
	}

	static TSelf Multiply(TSelf left, TSelf right)
	{
		return left * right;
	}
	static TSelf Multiply(TSelf left, TNumber right)
	{
		return left * right;
	}
	static TSelf Multiply(TNumber left, TSelf right)
	{
		return left * right;
	}

	static TSelf Divide(TSelf left, TSelf right)
	{
		return left / right;
	}
	static TSelf Divide(TSelf left, TNumber right)
	{
		return left / right;
	}

	static TSelf Min(TSelf left, TSelf right)
	{
		TSelf result = left;
		for (int i = 0; i < TSelf.Count; i++)
		{
			result[i] = TNumber.Min(result[i], right[i]);
		}
		return result;
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	static TSelf Max(TSelf left, TSelf right)
	{
		TSelf result = left;
		for (int i = 0; i < TSelf.Count; i++)
		{
			result[i] = TNumber.Max(result[i], right[i]);
		}
		return result;
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	static TSelf Clamp(TSelf value, TSelf min, TSelf max)
	{
		TSelf result = value;
		for (int i = 0; i < TSelf.Count; i++)
		{
			result[i] = TNumber.Clamp(result[i], min[i], max[i]);
		}
		return result;
	}

	static TNumber Dot(TSelf left, TSelf right)
	{
		TNumber result = TNumber.Zero;
		for (int i = 0; i < TSelf.Count; i++)
		{
			result += left[i] * right[i];
		}
		return result;
	}

	static TNumber DistanceSquared(TSelf left, TSelf right)
	{
		TSelf difference = left - right;
		return Dot(difference, difference);
	}
	static TNumber Distance(TSelf left, TSelf right)
	{
		TNumber distanceSquared = DistanceSquared(left, right);

		if (distanceSquared is float distanceSquaredF)
		{
			return (TNumber)(object)MathF.Sqrt(distanceSquaredF);
		}
		else
		{
			double distanceSquaredD = ((IConvertible)distanceSquared).ToDouble(null);
			return TNumber.Create(Math.Sqrt(distanceSquaredD));
		}
	}

	#region Helper Methods

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TNumber GetElement(TSelf vector, int index)
	{
		ThrowIfIndexOutOfCountRange(index);

		return GetElementReferenceUnsafe(ref vector, index);
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TSelf WithElement(TSelf vector, int index, TNumber value)
	{
		ThrowIfIndexOutOfCountRange(index);

		TSelf result = vector;
		GetElementReferenceUnsafe(ref result, index) = value;
		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void ThrowIfIndexOutOfCountRange(int index)
	{
		if ((uint)index >= TSelf.Count)
		{
			ThrowIndexOutOfRangeException();
		}

		[DoesNotReturn]
		static void ThrowIndexOutOfRangeException()
		{
			throw new IndexOutOfRangeException();
		}
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static ref TNumber GetElementReferenceUnsafe(ref TSelf vector, int index)
	{
		return ref Unsafe.Add(ref Unsafe.As<TSelf, TNumber>(ref vector), index);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static Span<TNumber> AsSpan(ref TSelf vector)
	{
		return MemoryMarshal.CreateSpan(
			ref Unsafe.As<TSelf, TNumber>(ref vector),
			TSelf.Count);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Copy(TSelf from, Span<TNumber> destination)
	{
		ReadOnlySpan<TNumber> span = AsSpan(ref from);

		span.CopyTo(destination);
	}

	internal static Vector<TNumber> AsVectorUnsafe(TSelf vector)
	{
		Span<TNumber> values = stackalloc TNumber[Vector<TNumber>.Count];
		AsSpan(ref vector).CopyTo(values);

		return new(values);
	}

	#endregion

	#region Explicit Implementations

	int ICollection.Count => TSelf.Count;
	int ICollection<TNumber>.Count => TSelf.Count;
	int IReadOnlyCollection<TNumber>.Count => TSelf.Count;

	bool IList.IsFixedSize => true;
	bool IList.IsReadOnly => TSelf.IsReadOnly;
	bool ICollection<TNumber>.IsReadOnly => TSelf.IsReadOnly;

	bool ICollection.IsSynchronized => false;
	object ICollection.SyncRoot => this;

	object? IList.this[int index]
	{
		get => this[index];
		set => this[index] = (TNumber)value!; // Automatically handles exception.
	}
	TNumber IList<TNumber>.this[int index]
	{
		get => this[index];
		set => this[index] = value;
	}
	TNumber IReadOnlyList<TNumber>.this[int index] => this[index];

	int IList<TNumber>.IndexOf(TNumber item)
	{
		for (int i = 0; i < TSelf.Count; i++)
		{
			if (this[i].Equals(item)) return i;
		}

		return -1;
	}
	int IList.IndexOf(object? value)
	{
		return value is TNumber item ? IndexOf(item) : -1;
	}

	bool ICollection<TNumber>.Contains(TNumber item)
	{
		return IndexOf(item) is not < 0;
	}
	bool IList.Contains(object? value)
	{
		return IndexOf(value) is not < 0;
	}

	int IList.Add(object? obj)
	{
		ThrowFixedCollectionException();
		return default;
	}
	void IList.Clear()
	{
		ThrowFixedCollectionException();
	}
	void IList.Insert(int index, object? obj)
	{
		ThrowFixedCollectionException();
	}
	void IList.Remove(object? value)
	{
		ThrowFixedCollectionException();
	}
	void IList.RemoveAt(int index)
	{
		ThrowFixedCollectionException();
	}

	void ICollection<TNumber>.Add(TNumber item)
	{
		ThrowFixedCollectionException();
	}
	void ICollection<TNumber>.Clear()
	{
		ThrowFixedCollectionException();
	}
	bool ICollection<TNumber>.Remove(TNumber item)
	{
		ThrowFixedCollectionException();
		return default;
	}

	void IList<TNumber>.Insert(int index, TNumber item)
	{
		ThrowFixedCollectionException();
	}
	void IList<TNumber>.RemoveAt(int index)
	{
		ThrowFixedCollectionException();
	}

	void ICollection.CopyTo(Array array, int index)
	{
		CopyTo((TNumber[])array, index);
	}

	IEnumerator<TNumber> IEnumerable<TNumber>.GetEnumerator()
	{
		for (int i = 0; i < TSelf.Count; i++)
		{
			yield return this[i];
		}
	}
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	string IFormattable.ToString(string? format, IFormatProvider? formatProvider)
	{
		StringBuilder sb = new();
		string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;

		IEnumerator<TNumber> enumerator = GetEnumerator();

		sb.Append('<');
		while (PrintComponent())
		{
			sb.Append(separator);
			sb.Append(' ');
		}
		sb.Append('>');

		bool PrintComponent()
		{
			sb.Append(enumerator.Current.ToString(format, formatProvider));
			return enumerator.MoveNext();
		}

		return sb.ToString();
	}

	[DoesNotReturn]
	private static void ThrowFixedCollectionException()
	{
		throw new NotSupportedException();
	}

	#endregion
}

public struct Vector2<T> : IVector<Vector2<T>, T>
	where T : unmanaged, INumber<T>
{
	internal const int count = 2;
	static int IVector<Vector2<T>, T>.Count => count;
	public static bool IsReadOnly => false;

	public T X;
	public T Y;

	public Vector2(T x, T y)
	{
		X = x;
		Y = y;
	}
	public Vector2(T value) : this(value, value) { }

	public static Vector2<T> Zero => new(T.Zero);
	public static Vector2<T> One => new(T.One);

	public static Vector2<T> AdditiveIdentity => new(T.AdditiveIdentity);
	public static Vector2<T> MultiplicativeIdentity => new(T.MultiplicativeIdentity);

	public T this[int index]
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => IVector<Vector2<T>, T>.GetElement(this, index);
		set => this = IVector<Vector2<T>, T>.WithElement(this, index, value);
	}

	public void CopyTo(T[] array, int index)
	{
		CopyTo(array.AsSpan()[index..]);
	}
	public void CopyTo(Span<T> destination)
	{
		IVector<Vector2<T>, T>.Copy(this, destination);
	}

	public static bool operator ==(Vector2<T> left, Vector2<T> right)
	{
		return left.X == right.X
			&& left.Y == right.Y;
	}
	public static bool operator !=(Vector2<T> left, Vector2<T> right)
	{
		return left.X != right.X
			&& left.Y != right.Y;
	}
	public bool Equals(Vector2<T> other)
	{
		return X.Equals(other.X)
			&& Y.Equals(other.Y);
	}
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		return obj is Vector2<T> other && Equals(other);
	}
	public override int GetHashCode()
	{
		return HashCode.Combine(X, Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2<T> operator -(Vector2<T> value)
	{
		return new(
			-value.X,
			-value.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2<T> operator +(Vector2<T> left, Vector2<T> right)
	{
		return new(
			left.X + right.X,
			left.Y + right.Y);
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2<T> operator -(Vector2<T> left, Vector2<T> right)
	{
		return new(
			left.X - right.X,
			left.Y - right.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2<T> operator *(Vector2<T> left, Vector2<T> right)
	{
		return new(
			left.X * right.X,
			left.Y * right.Y);
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2<T> operator *(Vector2<T> left, T right)
	{
		return new(
			left.X * right,
			left.Y * right);
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2<T> operator *(T left, Vector2<T> right)
	{
		return right * left;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2<T> operator /(Vector2<T> left, Vector2<T> right)
	{
		return new(
			left.X / right.X,
			left.Y / right.Y);
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2<T> operator /(Vector2<T> left, T right)
	{
		return new(
			left.X / right,
			left.Y / right);
	}

	public static implicit operator Vector2(Vector2<T> value)
	{
		float x = ((IConvertible)value.X).ToSingle(null);
		float y = ((IConvertible)value.Y).ToSingle(null);

		return new(x, y);
	}
	public static implicit operator Vector2<T>(Vector2 value)
	{
		T x = T.Create(value.X);
		T y = T.Create(value.Y);

		return new(x, y);
	}

	public static implicit operator Vector2D<T>(Vector2<T> value)
	{
		return new(value.X, value.Y);
	}
	public static implicit operator Vector2<T>(Vector2D<T> value)
	{
		return new(value.X, value.Y);
	}
}
