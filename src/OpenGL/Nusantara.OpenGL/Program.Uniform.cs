// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

using Silk.NET.Maths;
using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

public partial class Program
{
	private int GetUniformLocationUnsafeChecked(string name)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			ThrowKeyNotFoundException();
		}

		[DoesNotReturn]
		static void ThrowKeyNotFoundException()
		{
			throw new KeyNotFoundException();
		}

		return location;
	}

	public void Uniform1(int location, int v0)
	{
		ThrowIfDisposed();

		GL.ProgramUniform1(Handle, location, v0);
	}

	public void Uniform1(string name, int v0)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform1(location, v0);
	}

	public bool TryUniform1(string name, int v0)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform1(location, v0);
		return true;
	}

	public unsafe void Uniform1(int location, Span<int> value)
	{
		ThrowIfDisposed();

		fixed (int* value_ptr = value)
		{
			GL.ProgramUniform1(
				Handle,
				location,
				(uint)value.Length,
				value_ptr);
		}
	}

	public unsafe void Uniform1(string name, Span<int> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform1(location, value);
	}

	public unsafe bool TryUniform1(string name, Span<int> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform1(location, value);
		return true;
	}

	public unsafe void Uniform1(int location, params int[] value)
	{
		Uniform1(location, value.AsSpan());
	}

	public unsafe void Uniform1(string name, params int[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform1(location, value);
	}

	public unsafe bool TryUniform1(string name, params int[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform1(location, value);
		return true;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public unsafe void Uniform1(int location, params ValueTuple<int>[] value)
	{
		ThrowIfDisposed();

		fixed (ValueTuple<int>* value_ptr = value)
		{
			GL.ProgramUniform1(
				Handle,
				location,
				(uint)value.Length,
				(float*)value_ptr);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public unsafe void Uniform1(string name, params ValueTuple<int>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform1(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public unsafe bool TryUniform1(string name, params ValueTuple<int>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform1(location, value);
		return true;
	}

	public void Uniform2(int location, int v0, int v1)
	{
		ThrowIfDisposed();

		GL.ProgramUniform2(Handle, location, v0, v1);
	}

	public void Uniform2(string name, int v0, int v1)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, v0, v1);
	}

	public bool TryUniform2(string name, int v0, int v1)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, v0, v1);
		return true;
	}

	public unsafe void Uniform2(int location, Span<ValueTuple<int, int>> value)
	{
		ThrowIfDisposed();

		fixed (ValueTuple<int, int>* value_ptr = value)
		{
			GL.ProgramUniform2(
				Handle,
				location,
				(uint)value.Length,
				(int*)value_ptr);
		}
	}

	public void Uniform2(string name, Span<ValueTuple<int, int>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, value);
	}

	public bool TryUniform2(string name, Span<ValueTuple<int, int>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, value);
		return true;
	}

	public unsafe void Uniform2(int location, params ValueTuple<int, int>[] value)
	{
		Uniform2(location, value.AsSpan());
	}

	public void Uniform2(string name, params ValueTuple<int, int>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, value);
	}

	public bool TryUniform2(string name, params ValueTuple<int, int>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, value);
		return true;
	}

	public unsafe void Uniform2(int location, Vector2D<int> vector)
	{
		Uniform2(
			location,
			vector.X,
			vector.Y);
	}

	public unsafe void Uniform2(string name, Vector2D<int> vector)
	{
		Uniform2(
			name,
			vector.X,
			vector.Y);
	}

	public bool TryUniform2(string name, Vector2D<int> vector)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, vector);
		return true;
	}

	public unsafe void Uniform2(int location, Span<Vector2D<int>> value)
	{
		ThrowIfDisposed();

		fixed (Vector2D<int>* value_ptr = value)
		{
			GL.ProgramUniform2(
				Handle,
				location,
				(uint)value.Length,
				(int*)value_ptr);
		}
	}

	public unsafe void Uniform2(string name, Span<Vector2D<int>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, value);
	}

	public bool TryUniform2(string name, Span<Vector2D<int>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, value);
		return true;
	}

	public unsafe void Uniform2(int location, params Vector2D<int>[] value)
	{
		Uniform2(location, value.AsSpan());
	}

	public unsafe void Uniform2(string name, params Vector2D<int>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, value);
	}

	public bool TryUniform2(string name, params Vector2D<int>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, value);
		return true;
	}

	public void Uniform3(int location, int v0, int v1, int v2)
	{
		ThrowIfDisposed();

		GL.ProgramUniform3(Handle, location, v0, v1, v2);
	}

	public void Uniform3(string name, int v0, int v1, int v2)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, v0, v1, v2);
	}

	public bool TryUniform3(string name, int v0, int v1, int v2)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, v0, v1, v2);
		return true;
	}

	public unsafe void Uniform3(int location, Span<ValueTuple<int, int, int>> value)
	{
		ThrowIfDisposed();

		fixed (ValueTuple<int, int, int>* value_ptr = value)
		{
			GL.ProgramUniform3(
				Handle,
				location,
				(uint)value.Length,
				(int*)value_ptr);
		}
	}

	public void Uniform3(string name, Span<ValueTuple<int, int, int>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, value);
	}

	public bool TryUniform3(string name, Span<ValueTuple<int, int, int>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, value);
		return true;
	}

	public unsafe void Uniform3(int location, params ValueTuple<int, int, int>[] value)
	{
		Uniform3(location, value.AsSpan());
	}

	public void Uniform3(string name, params ValueTuple<int, int, int>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, value);
	}

	public bool TryUniform3(string name, params ValueTuple<int, int, int>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, value);
		return true;
	}

	public unsafe void Uniform3(int location, Vector3D<int> vector)
	{
		Uniform3(
			location,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public unsafe void Uniform3(string name, Vector3D<int> vector)
	{
		Uniform3(
			name,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public bool TryUniform3(string name, Vector3D<int> vector)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, vector);
		return true;
	}

	public unsafe void Uniform3(int location, Span<Vector3D<int>> value)
	{
		ThrowIfDisposed();

		fixed (Vector3D<int>* value_ptr = value)
		{
			GL.ProgramUniform3(
				Handle,
				location,
				(uint)value.Length,
				(int*)value_ptr);
		}
	}

	public unsafe void Uniform3(string name, Span<Vector3D<int>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, value);
	}

	public bool TryUniform3(string name, Span<Vector3D<int>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, value);
		return true;
	}

	public unsafe void Uniform3(int location, params Vector3D<int>[] value)
	{
		Uniform3(location, value.AsSpan());
	}

	public unsafe void Uniform3(string name, params Vector3D<int>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, value);
	}

	public bool TryUniform3(string name, params Vector3D<int>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, value);
		return true;
	}

	public void Uniform4(int location, int v0, int v1, int v2, int v3)
	{
		ThrowIfDisposed();

		GL.ProgramUniform4(Handle, location, v0, v1, v2, v3);
	}

	public void Uniform4(string name, int v0, int v1, int v2, int v3)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, v0, v1, v2, v3);
	}

	public bool TryUniform4(string name, int v0, int v1, int v2, int v3)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, v0, v1, v2, v3);
		return true;
	}

	public unsafe void Uniform4(int location, Span<ValueTuple<int, int, int, int>> value)
	{
		ThrowIfDisposed();

		fixed (ValueTuple<int, int, int, int>* value_ptr = value)
		{
			GL.ProgramUniform4(
				Handle,
				location,
				(uint)value.Length,
				(int*)value_ptr);
		}
	}

	public void Uniform4(string name, Span<ValueTuple<int, int, int, int>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, value);
	}

	public bool TryUniform4(string name, Span<ValueTuple<int, int, int, int>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, value);
		return true;
	}

	public unsafe void Uniform4(int location, params ValueTuple<int, int, int, int>[] value)
	{
		Uniform4(location, value.AsSpan());
	}

	public void Uniform4(string name, params ValueTuple<int, int, int, int>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, value);
	}

	public bool TryUniform4(string name, params ValueTuple<int, int, int, int>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, value);
		return true;
	}

	public unsafe void Uniform4(int location, Vector4D<int> vector)
	{
		Uniform4(
			location,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public unsafe void Uniform4(string name, Vector4D<int> vector)
	{
		Uniform4(
			name,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public bool TryUniform4(string name, Vector4D<int> vector)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, vector);
		return true;
	}

	public unsafe void Uniform4(int location, Span<Vector4D<int>> value)
	{
		ThrowIfDisposed();

		fixed (Vector4D<int>* value_ptr = value)
		{
			GL.ProgramUniform4(
				Handle,
				location,
				(uint)value.Length,
				(int*)value_ptr);
		}
	}

	public unsafe void Uniform4(string name, Span<Vector4D<int>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, value);
	}

	public bool TryUniform4(string name, Span<Vector4D<int>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, value);
		return true;
	}

	public unsafe void Uniform4(int location, params Vector4D<int>[] value)
	{
		Uniform4(location, value.AsSpan());
	}

	public unsafe void Uniform4(string name, params Vector4D<int>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, value);
	}

	public bool TryUniform4(string name, params Vector4D<int>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, value);
		return true;
	}

	public void Uniform1(int location, uint v0)
	{
		ThrowIfDisposed();

		GL.ProgramUniform1(Handle, location, v0);
	}

	public void Uniform1(string name, uint v0)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform1(location, v0);
	}

	public bool TryUniform1(string name, uint v0)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform1(location, v0);
		return true;
	}

	public unsafe void Uniform1(int location, Span<uint> value)
	{
		ThrowIfDisposed();

		fixed (uint* value_ptr = value)
		{
			GL.ProgramUniform1(
				Handle,
				location,
				(uint)value.Length,
				value_ptr);
		}
	}

	public unsafe void Uniform1(string name, Span<uint> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform1(location, value);
	}

	public unsafe bool TryUniform1(string name, Span<uint> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform1(location, value);
		return true;
	}

	public unsafe void Uniform1(int location, params uint[] value)
	{
		Uniform1(location, value.AsSpan());
	}

	public unsafe void Uniform1(string name, params uint[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform1(location, value);
	}

	public unsafe bool TryUniform1(string name, params uint[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform1(location, value);
		return true;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public unsafe void Uniform1(int location, params ValueTuple<uint>[] value)
	{
		ThrowIfDisposed();

		fixed (ValueTuple<uint>* value_ptr = value)
		{
			GL.ProgramUniform1(
				Handle,
				location,
				(uint)value.Length,
				(float*)value_ptr);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public unsafe void Uniform1(string name, params ValueTuple<uint>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform1(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public unsafe bool TryUniform1(string name, params ValueTuple<uint>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform1(location, value);
		return true;
	}

	public void Uniform2(int location, uint v0, uint v1)
	{
		ThrowIfDisposed();

		GL.ProgramUniform2(Handle, location, v0, v1);
	}

	public void Uniform2(string name, uint v0, uint v1)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, v0, v1);
	}

	public bool TryUniform2(string name, uint v0, uint v1)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, v0, v1);
		return true;
	}

	public unsafe void Uniform2(int location, Span<ValueTuple<uint, uint>> value)
	{
		ThrowIfDisposed();

		fixed (ValueTuple<uint, uint>* value_ptr = value)
		{
			GL.ProgramUniform2(
				Handle,
				location,
				(uint)value.Length,
				(uint*)value_ptr);
		}
	}

	public void Uniform2(string name, Span<ValueTuple<uint, uint>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, value);
	}

	public bool TryUniform2(string name, Span<ValueTuple<uint, uint>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, value);
		return true;
	}

	public unsafe void Uniform2(int location, params ValueTuple<uint, uint>[] value)
	{
		Uniform2(location, value.AsSpan());
	}

	public void Uniform2(string name, params ValueTuple<uint, uint>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, value);
	}

	public bool TryUniform2(string name, params ValueTuple<uint, uint>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, value);
		return true;
	}

	public unsafe void Uniform2(int location, Vector2D<uint> vector)
	{
		Uniform2(
			location,
			vector.X,
			vector.Y);
	}

	public unsafe void Uniform2(string name, Vector2D<uint> vector)
	{
		Uniform2(
			name,
			vector.X,
			vector.Y);
	}

	public bool TryUniform2(string name, Vector2D<uint> vector)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, vector);
		return true;
	}

	public unsafe void Uniform2(int location, Span<Vector2D<uint>> value)
	{
		ThrowIfDisposed();

		fixed (Vector2D<uint>* value_ptr = value)
		{
			GL.ProgramUniform2(
				Handle,
				location,
				(uint)value.Length,
				(uint*)value_ptr);
		}
	}

	public unsafe void Uniform2(string name, Span<Vector2D<uint>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, value);
	}

	public bool TryUniform2(string name, Span<Vector2D<uint>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, value);
		return true;
	}

	public unsafe void Uniform2(int location, params Vector2D<uint>[] value)
	{
		Uniform2(location, value.AsSpan());
	}

	public unsafe void Uniform2(string name, params Vector2D<uint>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, value);
	}

	public bool TryUniform2(string name, params Vector2D<uint>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, value);
		return true;
	}

	public void Uniform3(int location, uint v0, uint v1, uint v2)
	{
		ThrowIfDisposed();

		GL.ProgramUniform3(Handle, location, v0, v1, v2);
	}

	public void Uniform3(string name, uint v0, uint v1, uint v2)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, v0, v1, v2);
	}

	public bool TryUniform3(string name, uint v0, uint v1, uint v2)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, v0, v1, v2);
		return true;
	}

	public unsafe void Uniform3(int location, Span<ValueTuple<uint, uint, uint>> value)
	{
		ThrowIfDisposed();

		fixed (ValueTuple<uint, uint, uint>* value_ptr = value)
		{
			GL.ProgramUniform3(
				Handle,
				location,
				(uint)value.Length,
				(uint*)value_ptr);
		}
	}

	public void Uniform3(string name, Span<ValueTuple<uint, uint, uint>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, value);
	}

	public bool TryUniform3(string name, Span<ValueTuple<uint, uint, uint>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, value);
		return true;
	}

	public unsafe void Uniform3(int location, params ValueTuple<uint, uint, uint>[] value)
	{
		Uniform3(location, value.AsSpan());
	}

	public void Uniform3(string name, params ValueTuple<uint, uint, uint>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, value);
	}

	public bool TryUniform3(string name, params ValueTuple<uint, uint, uint>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, value);
		return true;
	}

	public unsafe void Uniform3(int location, Vector3D<uint> vector)
	{
		Uniform3(
			location,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public unsafe void Uniform3(string name, Vector3D<uint> vector)
	{
		Uniform3(
			name,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public bool TryUniform3(string name, Vector3D<uint> vector)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, vector);
		return true;
	}

	public unsafe void Uniform3(int location, Span<Vector3D<uint>> value)
	{
		ThrowIfDisposed();

		fixed (Vector3D<uint>* value_ptr = value)
		{
			GL.ProgramUniform3(
				Handle,
				location,
				(uint)value.Length,
				(uint*)value_ptr);
		}
	}

	public unsafe void Uniform3(string name, Span<Vector3D<uint>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, value);
	}

	public bool TryUniform3(string name, Span<Vector3D<uint>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, value);
		return true;
	}

	public unsafe void Uniform3(int location, params Vector3D<uint>[] value)
	{
		Uniform3(location, value.AsSpan());
	}

	public unsafe void Uniform3(string name, params Vector3D<uint>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, value);
	}

	public bool TryUniform3(string name, params Vector3D<uint>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, value);
		return true;
	}

	public void Uniform4(int location, uint v0, uint v1, uint v2, uint v3)
	{
		ThrowIfDisposed();

		GL.ProgramUniform4(Handle, location, v0, v1, v2, v3);
	}

	public void Uniform4(string name, uint v0, uint v1, uint v2, uint v3)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, v0, v1, v2, v3);
	}

	public bool TryUniform4(string name, uint v0, uint v1, uint v2, uint v3)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, v0, v1, v2, v3);
		return true;
	}

	public unsafe void Uniform4(int location, Span<ValueTuple<uint, uint, uint, uint>> value)
	{
		ThrowIfDisposed();

		fixed (ValueTuple<uint, uint, uint, uint>* value_ptr = value)
		{
			GL.ProgramUniform4(
				Handle,
				location,
				(uint)value.Length,
				(uint*)value_ptr);
		}
	}

	public void Uniform4(string name, Span<ValueTuple<uint, uint, uint, uint>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, value);
	}

	public bool TryUniform4(string name, Span<ValueTuple<uint, uint, uint, uint>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, value);
		return true;
	}

	public unsafe void Uniform4(int location, params ValueTuple<uint, uint, uint, uint>[] value)
	{
		Uniform4(location, value.AsSpan());
	}

	public void Uniform4(string name, params ValueTuple<uint, uint, uint, uint>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, value);
	}

	public bool TryUniform4(string name, params ValueTuple<uint, uint, uint, uint>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, value);
		return true;
	}

	public unsafe void Uniform4(int location, Vector4D<uint> vector)
	{
		Uniform4(
			location,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public unsafe void Uniform4(string name, Vector4D<uint> vector)
	{
		Uniform4(
			name,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public bool TryUniform4(string name, Vector4D<uint> vector)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, vector);
		return true;
	}

	public unsafe void Uniform4(int location, Span<Vector4D<uint>> value)
	{
		ThrowIfDisposed();

		fixed (Vector4D<uint>* value_ptr = value)
		{
			GL.ProgramUniform4(
				Handle,
				location,
				(uint)value.Length,
				(uint*)value_ptr);
		}
	}

	public unsafe void Uniform4(string name, Span<Vector4D<uint>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, value);
	}

	public bool TryUniform4(string name, Span<Vector4D<uint>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, value);
		return true;
	}

	public unsafe void Uniform4(int location, params Vector4D<uint>[] value)
	{
		Uniform4(location, value.AsSpan());
	}

	public unsafe void Uniform4(string name, params Vector4D<uint>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, value);
	}

	public bool TryUniform4(string name, params Vector4D<uint>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, value);
		return true;
	}

	public void Uniform1(int location, float v0)
	{
		ThrowIfDisposed();

		GL.ProgramUniform1(Handle, location, v0);
	}

	public void Uniform1(string name, float v0)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform1(location, v0);
	}

	public bool TryUniform1(string name, float v0)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform1(location, v0);
		return true;
	}

	public unsafe void Uniform1(int location, Span<float> value)
	{
		ThrowIfDisposed();

		fixed (float* value_ptr = value)
		{
			GL.ProgramUniform1(
				Handle,
				location,
				(uint)value.Length,
				value_ptr);
		}
	}

	public unsafe void Uniform1(string name, Span<float> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform1(location, value);
	}

	public unsafe bool TryUniform1(string name, Span<float> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform1(location, value);
		return true;
	}

	public unsafe void Uniform1(int location, params float[] value)
	{
		Uniform1(location, value.AsSpan());
	}

	public unsafe void Uniform1(string name, params float[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform1(location, value);
	}

	public unsafe bool TryUniform1(string name, params float[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform1(location, value);
		return true;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public unsafe void Uniform1(int location, params ValueTuple<float>[] value)
	{
		ThrowIfDisposed();

		fixed (ValueTuple<float>* value_ptr = value)
		{
			GL.ProgramUniform1(
				Handle,
				location,
				(uint)value.Length,
				(float*)value_ptr);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public unsafe void Uniform1(string name, params ValueTuple<float>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform1(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public unsafe bool TryUniform1(string name, params ValueTuple<float>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform1(location, value);
		return true;
	}

	public void Uniform2(int location, float v0, float v1)
	{
		ThrowIfDisposed();

		GL.ProgramUniform2(Handle, location, v0, v1);
	}

	public void Uniform2(string name, float v0, float v1)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, v0, v1);
	}

	public bool TryUniform2(string name, float v0, float v1)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, v0, v1);
		return true;
	}

	public unsafe void Uniform2(int location, Span<ValueTuple<float, float>> value)
	{
		ThrowIfDisposed();

		fixed (ValueTuple<float, float>* value_ptr = value)
		{
			GL.ProgramUniform2(
				Handle,
				location,
				(uint)value.Length,
				(float*)value_ptr);
		}
	}

	public void Uniform2(string name, Span<ValueTuple<float, float>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, value);
	}

	public bool TryUniform2(string name, Span<ValueTuple<float, float>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, value);
		return true;
	}

	public unsafe void Uniform2(int location, params ValueTuple<float, float>[] value)
	{
		Uniform2(location, value.AsSpan());
	}

	public void Uniform2(string name, params ValueTuple<float, float>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, value);
	}

	public bool TryUniform2(string name, params ValueTuple<float, float>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, value);
		return true;
	}

	public unsafe void Uniform2(int location, Vector2D<float> vector)
	{
		Uniform2(
			location,
			vector.X,
			vector.Y);
	}

	public unsafe void Uniform2(string name, Vector2D<float> vector)
	{
		Uniform2(
			name,
			vector.X,
			vector.Y);
	}

	public bool TryUniform2(string name, Vector2D<float> vector)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, vector);
		return true;
	}

	public unsafe void Uniform2(int location, Span<Vector2D<float>> value)
	{
		ThrowIfDisposed();

		fixed (Vector2D<float>* value_ptr = value)
		{
			GL.ProgramUniform2(
				Handle,
				location,
				(uint)value.Length,
				(float*)value_ptr);
		}
	}

	public unsafe void Uniform2(string name, Span<Vector2D<float>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, value);
	}

	public bool TryUniform2(string name, Span<Vector2D<float>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, value);
		return true;
	}

	public unsafe void Uniform2(int location, params Vector2D<float>[] value)
	{
		Uniform2(location, value.AsSpan());
	}

	public unsafe void Uniform2(string name, params Vector2D<float>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, value);
	}

	public bool TryUniform2(string name, params Vector2D<float>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, value);
		return true;
	}

	public void Uniform3(int location, float v0, float v1, float v2)
	{
		ThrowIfDisposed();

		GL.ProgramUniform3(Handle, location, v0, v1, v2);
	}

	public void Uniform3(string name, float v0, float v1, float v2)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, v0, v1, v2);
	}

	public bool TryUniform3(string name, float v0, float v1, float v2)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, v0, v1, v2);
		return true;
	}

	public unsafe void Uniform3(int location, Span<ValueTuple<float, float, float>> value)
	{
		ThrowIfDisposed();

		fixed (ValueTuple<float, float, float>* value_ptr = value)
		{
			GL.ProgramUniform3(
				Handle,
				location,
				(uint)value.Length,
				(float*)value_ptr);
		}
	}

	public void Uniform3(string name, Span<ValueTuple<float, float, float>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, value);
	}

	public bool TryUniform3(string name, Span<ValueTuple<float, float, float>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, value);
		return true;
	}

	public unsafe void Uniform3(int location, params ValueTuple<float, float, float>[] value)
	{
		Uniform3(location, value.AsSpan());
	}

	public void Uniform3(string name, params ValueTuple<float, float, float>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, value);
	}

	public bool TryUniform3(string name, params ValueTuple<float, float, float>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, value);
		return true;
	}

	public unsafe void Uniform3(int location, Vector3D<float> vector)
	{
		Uniform3(
			location,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public unsafe void Uniform3(string name, Vector3D<float> vector)
	{
		Uniform3(
			name,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public bool TryUniform3(string name, Vector3D<float> vector)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, vector);
		return true;
	}

	public unsafe void Uniform3(int location, Span<Vector3D<float>> value)
	{
		ThrowIfDisposed();

		fixed (Vector3D<float>* value_ptr = value)
		{
			GL.ProgramUniform3(
				Handle,
				location,
				(uint)value.Length,
				(float*)value_ptr);
		}
	}

	public unsafe void Uniform3(string name, Span<Vector3D<float>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, value);
	}

	public bool TryUniform3(string name, Span<Vector3D<float>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, value);
		return true;
	}

	public unsafe void Uniform3(int location, params Vector3D<float>[] value)
	{
		Uniform3(location, value.AsSpan());
	}

	public unsafe void Uniform3(string name, params Vector3D<float>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, value);
	}

	public bool TryUniform3(string name, params Vector3D<float>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, value);
		return true;
	}

	public void Uniform4(int location, float v0, float v1, float v2, float v3)
	{
		ThrowIfDisposed();

		GL.ProgramUniform4(Handle, location, v0, v1, v2, v3);
	}

	public void Uniform4(string name, float v0, float v1, float v2, float v3)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, v0, v1, v2, v3);
	}

	public bool TryUniform4(string name, float v0, float v1, float v2, float v3)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, v0, v1, v2, v3);
		return true;
	}

	public unsafe void Uniform4(int location, Span<ValueTuple<float, float, float, float>> value)
	{
		ThrowIfDisposed();

		fixed (ValueTuple<float, float, float, float>* value_ptr = value)
		{
			GL.ProgramUniform4(
				Handle,
				location,
				(uint)value.Length,
				(float*)value_ptr);
		}
	}

	public void Uniform4(string name, Span<ValueTuple<float, float, float, float>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, value);
	}

	public bool TryUniform4(string name, Span<ValueTuple<float, float, float, float>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, value);
		return true;
	}

	public unsafe void Uniform4(int location, params ValueTuple<float, float, float, float>[] value)
	{
		Uniform4(location, value.AsSpan());
	}

	public void Uniform4(string name, params ValueTuple<float, float, float, float>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, value);
	}

	public bool TryUniform4(string name, params ValueTuple<float, float, float, float>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, value);
		return true;
	}

	public unsafe void Uniform4(int location, Vector4D<float> vector)
	{
		Uniform4(
			location,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public unsafe void Uniform4(string name, Vector4D<float> vector)
	{
		Uniform4(
			name,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public bool TryUniform4(string name, Vector4D<float> vector)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, vector);
		return true;
	}

	public unsafe void Uniform4(int location, Span<Vector4D<float>> value)
	{
		ThrowIfDisposed();

		fixed (Vector4D<float>* value_ptr = value)
		{
			GL.ProgramUniform4(
				Handle,
				location,
				(uint)value.Length,
				(float*)value_ptr);
		}
	}

	public unsafe void Uniform4(string name, Span<Vector4D<float>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, value);
	}

	public bool TryUniform4(string name, Span<Vector4D<float>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, value);
		return true;
	}

	public unsafe void Uniform4(int location, params Vector4D<float>[] value)
	{
		Uniform4(location, value.AsSpan());
	}

	public unsafe void Uniform4(string name, params Vector4D<float>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, value);
	}

	public bool TryUniform4(string name, params Vector4D<float>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, value);
		return true;
	}

	public unsafe void Uniform2(int location, Vector2 vector)
	{
		Uniform2(
			location,
			vector.X,
			vector.Y);
	}

	public unsafe void Uniform2(string name, Vector2 vector)
	{
		Uniform2(
			name,
			vector.X,
			vector.Y);
	}

	public bool TryUniform2(string name, Vector2 vector)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, vector);
		return true;
	}

	public unsafe void Uniform2(int location, Span<Vector2> value)
	{
		ThrowIfDisposed();

		fixed (Vector2* value_ptr = value)
		{
			GL.ProgramUniform2(
				Handle,
				location,
				(uint)value.Length,
				(float*)value_ptr);
		}
	}

	public unsafe void Uniform2(string name, Span<Vector2> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, value);
	}

	public bool TryUniform2(string name, Span<Vector2> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, value);
		return true;
	}

	public unsafe void Uniform2(int location, params Vector2[] value)
	{
		Uniform2(location, value.AsSpan());
	}

	public unsafe void Uniform2(string name, params Vector2[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, value);
	}

	public bool TryUniform2(string name, params Vector2[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, value);
		return true;
	}

	public unsafe void Uniform3(int location, Vector3 vector)
	{
		Uniform3(
			location,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public unsafe void Uniform3(string name, Vector3 vector)
	{
		Uniform3(
			name,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public bool TryUniform3(string name, Vector3 vector)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, vector);
		return true;
	}

	public unsafe void Uniform3(int location, Span<Vector3> value)
	{
		ThrowIfDisposed();

		fixed (Vector3* value_ptr = value)
		{
			GL.ProgramUniform3(
				Handle,
				location,
				(uint)value.Length,
				(float*)value_ptr);
		}
	}

	public unsafe void Uniform3(string name, Span<Vector3> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, value);
	}

	public bool TryUniform3(string name, Span<Vector3> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, value);
		return true;
	}

	public unsafe void Uniform3(int location, params Vector3[] value)
	{
		Uniform3(location, value.AsSpan());
	}

	public unsafe void Uniform3(string name, params Vector3[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, value);
	}

	public bool TryUniform3(string name, params Vector3[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, value);
		return true;
	}

	public unsafe void Uniform4(int location, Vector4 vector)
	{
		Uniform4(
			location,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public unsafe void Uniform4(string name, Vector4 vector)
	{
		Uniform4(
			name,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public bool TryUniform4(string name, Vector4 vector)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, vector);
		return true;
	}

	public unsafe void Uniform4(int location, Span<Vector4> value)
	{
		ThrowIfDisposed();

		fixed (Vector4* value_ptr = value)
		{
			GL.ProgramUniform4(
				Handle,
				location,
				(uint)value.Length,
				(float*)value_ptr);
		}
	}

	public unsafe void Uniform4(string name, Span<Vector4> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, value);
	}

	public bool TryUniform4(string name, Span<Vector4> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, value);
		return true;
	}

	public unsafe void Uniform4(int location, params Vector4[] value)
	{
		Uniform4(location, value.AsSpan());
	}

	public unsafe void Uniform4(string name, params Vector4[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, value);
	}

	public bool TryUniform4(string name, params Vector4[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, value);
		return true;
	}

	public void Uniform1(int location, double v0)
	{
		ThrowIfDisposed();

		GL.ProgramUniform1(Handle, location, v0);
	}

	public void Uniform1(string name, double v0)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform1(location, v0);
	}

	public bool TryUniform1(string name, double v0)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform1(location, v0);
		return true;
	}

	public unsafe void Uniform1(int location, Span<double> value)
	{
		ThrowIfDisposed();

		fixed (double* value_ptr = value)
		{
			GL.ProgramUniform1(
				Handle,
				location,
				(uint)value.Length,
				value_ptr);
		}
	}

	public unsafe void Uniform1(string name, Span<double> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform1(location, value);
	}

	public unsafe bool TryUniform1(string name, Span<double> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform1(location, value);
		return true;
	}

	public unsafe void Uniform1(int location, params double[] value)
	{
		Uniform1(location, value.AsSpan());
	}

	public unsafe void Uniform1(string name, params double[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform1(location, value);
	}

	public unsafe bool TryUniform1(string name, params double[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform1(location, value);
		return true;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public unsafe void Uniform1(int location, params ValueTuple<double>[] value)
	{
		ThrowIfDisposed();

		fixed (ValueTuple<double>* value_ptr = value)
		{
			GL.ProgramUniform1(
				Handle,
				location,
				(uint)value.Length,
				(float*)value_ptr);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public unsafe void Uniform1(string name, params ValueTuple<double>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform1(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public unsafe bool TryUniform1(string name, params ValueTuple<double>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform1(location, value);
		return true;
	}

	public void Uniform2(int location, double v0, double v1)
	{
		ThrowIfDisposed();

		GL.ProgramUniform2(Handle, location, v0, v1);
	}

	public void Uniform2(string name, double v0, double v1)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, v0, v1);
	}

	public bool TryUniform2(string name, double v0, double v1)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, v0, v1);
		return true;
	}

	public unsafe void Uniform2(int location, Span<ValueTuple<double, double>> value)
	{
		ThrowIfDisposed();

		fixed (ValueTuple<double, double>* value_ptr = value)
		{
			GL.ProgramUniform2(
				Handle,
				location,
				(uint)value.Length,
				(double*)value_ptr);
		}
	}

	public void Uniform2(string name, Span<ValueTuple<double, double>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, value);
	}

	public bool TryUniform2(string name, Span<ValueTuple<double, double>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, value);
		return true;
	}

	public unsafe void Uniform2(int location, params ValueTuple<double, double>[] value)
	{
		Uniform2(location, value.AsSpan());
	}

	public void Uniform2(string name, params ValueTuple<double, double>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, value);
	}

	public bool TryUniform2(string name, params ValueTuple<double, double>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, value);
		return true;
	}

	public unsafe void Uniform2(int location, Vector2D<double> vector)
	{
		Uniform2(
			location,
			vector.X,
			vector.Y);
	}

	public unsafe void Uniform2(string name, Vector2D<double> vector)
	{
		Uniform2(
			name,
			vector.X,
			vector.Y);
	}

	public bool TryUniform2(string name, Vector2D<double> vector)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, vector);
		return true;
	}

	public unsafe void Uniform2(int location, Span<Vector2D<double>> value)
	{
		ThrowIfDisposed();

		fixed (Vector2D<double>* value_ptr = value)
		{
			GL.ProgramUniform2(
				Handle,
				location,
				(uint)value.Length,
				(double*)value_ptr);
		}
	}

	public unsafe void Uniform2(string name, Span<Vector2D<double>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, value);
	}

	public bool TryUniform2(string name, Span<Vector2D<double>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, value);
		return true;
	}

	public unsafe void Uniform2(int location, params Vector2D<double>[] value)
	{
		Uniform2(location, value.AsSpan());
	}

	public unsafe void Uniform2(string name, params Vector2D<double>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform2(location, value);
	}

	public bool TryUniform2(string name, params Vector2D<double>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform2(location, value);
		return true;
	}

	public void Uniform3(int location, double v0, double v1, double v2)
	{
		ThrowIfDisposed();

		GL.ProgramUniform3(Handle, location, v0, v1, v2);
	}

	public void Uniform3(string name, double v0, double v1, double v2)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, v0, v1, v2);
	}

	public bool TryUniform3(string name, double v0, double v1, double v2)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, v0, v1, v2);
		return true;
	}

	public unsafe void Uniform3(int location, Span<ValueTuple<double, double, double>> value)
	{
		ThrowIfDisposed();

		fixed (ValueTuple<double, double, double>* value_ptr = value)
		{
			GL.ProgramUniform3(
				Handle,
				location,
				(uint)value.Length,
				(double*)value_ptr);
		}
	}

	public void Uniform3(string name, Span<ValueTuple<double, double, double>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, value);
	}

	public bool TryUniform3(string name, Span<ValueTuple<double, double, double>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, value);
		return true;
	}

	public unsafe void Uniform3(int location, params ValueTuple<double, double, double>[] value)
	{
		Uniform3(location, value.AsSpan());
	}

	public void Uniform3(string name, params ValueTuple<double, double, double>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, value);
	}

	public bool TryUniform3(string name, params ValueTuple<double, double, double>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, value);
		return true;
	}

	public unsafe void Uniform3(int location, Vector3D<double> vector)
	{
		Uniform3(
			location,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public unsafe void Uniform3(string name, Vector3D<double> vector)
	{
		Uniform3(
			name,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public bool TryUniform3(string name, Vector3D<double> vector)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, vector);
		return true;
	}

	public unsafe void Uniform3(int location, Span<Vector3D<double>> value)
	{
		ThrowIfDisposed();

		fixed (Vector3D<double>* value_ptr = value)
		{
			GL.ProgramUniform3(
				Handle,
				location,
				(uint)value.Length,
				(double*)value_ptr);
		}
	}

	public unsafe void Uniform3(string name, Span<Vector3D<double>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, value);
	}

	public bool TryUniform3(string name, Span<Vector3D<double>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, value);
		return true;
	}

	public unsafe void Uniform3(int location, params Vector3D<double>[] value)
	{
		Uniform3(location, value.AsSpan());
	}

	public unsafe void Uniform3(string name, params Vector3D<double>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform3(location, value);
	}

	public bool TryUniform3(string name, params Vector3D<double>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform3(location, value);
		return true;
	}

	public void Uniform4(int location, double v0, double v1, double v2, double v3)
	{
		ThrowIfDisposed();

		GL.ProgramUniform4(Handle, location, v0, v1, v2, v3);
	}

	public void Uniform4(string name, double v0, double v1, double v2, double v3)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, v0, v1, v2, v3);
	}

	public bool TryUniform4(string name, double v0, double v1, double v2, double v3)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, v0, v1, v2, v3);
		return true;
	}

	public unsafe void Uniform4(int location, Span<ValueTuple<double, double, double, double>> value)
	{
		ThrowIfDisposed();

		fixed (ValueTuple<double, double, double, double>* value_ptr = value)
		{
			GL.ProgramUniform4(
				Handle,
				location,
				(uint)value.Length,
				(double*)value_ptr);
		}
	}

	public void Uniform4(string name, Span<ValueTuple<double, double, double, double>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, value);
	}

	public bool TryUniform4(string name, Span<ValueTuple<double, double, double, double>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, value);
		return true;
	}

	public unsafe void Uniform4(int location, params ValueTuple<double, double, double, double>[] value)
	{
		Uniform4(location, value.AsSpan());
	}

	public void Uniform4(string name, params ValueTuple<double, double, double, double>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, value);
	}

	public bool TryUniform4(string name, params ValueTuple<double, double, double, double>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, value);
		return true;
	}

	public unsafe void Uniform4(int location, Vector4D<double> vector)
	{
		Uniform4(
			location,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public unsafe void Uniform4(string name, Vector4D<double> vector)
	{
		Uniform4(
			name,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public bool TryUniform4(string name, Vector4D<double> vector)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, vector);
		return true;
	}

	public unsafe void Uniform4(int location, Span<Vector4D<double>> value)
	{
		ThrowIfDisposed();

		fixed (Vector4D<double>* value_ptr = value)
		{
			GL.ProgramUniform4(
				Handle,
				location,
				(uint)value.Length,
				(double*)value_ptr);
		}
	}

	public unsafe void Uniform4(string name, Span<Vector4D<double>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, value);
	}

	public bool TryUniform4(string name, Span<Vector4D<double>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, value);
		return true;
	}

	public unsafe void Uniform4(int location, params Vector4D<double>[] value)
	{
		Uniform4(location, value.AsSpan());
	}

	public unsafe void Uniform4(string name, params Vector4D<double>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		Uniform4(location, value);
	}

	public bool TryUniform4(string name, params Vector4D<double>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		Uniform4(location, value);
		return true;
	}

	public unsafe void UniformMatrix2(int location, bool transpose, Span<Matrix2X2<float>> value)
	{
		ThrowIfDisposed();

		fixed (Matrix2X2<float>* value_ptr = value)
		{
			GL.ProgramUniformMatrix2(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(float*)value_ptr);
		}
	}

	public unsafe void UniformMatrix2(string name, bool transpose, Span<Matrix2X2<float>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix2(location, transpose, value);
	}

	public bool TryUniformMatrix2(string name, bool transpose, Span<Matrix2X2<float>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix2(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix2(int location, bool transpose = false, params Matrix2X2<float>[] value)
	{
		UniformMatrix2(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix2(string name, bool transpose = false, params Matrix2X2<float>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix2(location, transpose, value);
	}

	public bool TryUniformMatrix2(string name, bool transpose = false, params Matrix2X2<float>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix2(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix2x3(int location, bool transpose, Span<Matrix2X3<float>> value)
	{
		ThrowIfDisposed();

		fixed (Matrix2X3<float>* value_ptr = value)
		{
			GL.ProgramUniformMatrix2x3(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(float*)value_ptr);
		}
	}

	public unsafe void UniformMatrix2x3(string name, bool transpose, Span<Matrix2X3<float>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix2x3(location, transpose, value);
	}

	public bool TryUniformMatrix2x3(string name, bool transpose, Span<Matrix2X3<float>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix2x3(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix2x3(int location, bool transpose = false, params Matrix2X3<float>[] value)
	{
		UniformMatrix2x3(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix2x3(string name, bool transpose = false, params Matrix2X3<float>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix2x3(location, transpose, value);
	}

	public bool TryUniformMatrix2x3(string name, bool transpose = false, params Matrix2X3<float>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix2x3(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix2x4(int location, bool transpose, Span<Matrix2X4<float>> value)
	{
		ThrowIfDisposed();

		fixed (Matrix2X4<float>* value_ptr = value)
		{
			GL.ProgramUniformMatrix2x4(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(float*)value_ptr);
		}
	}

	public unsafe void UniformMatrix2x4(string name, bool transpose, Span<Matrix2X4<float>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix2x4(location, transpose, value);
	}

	public bool TryUniformMatrix2x4(string name, bool transpose, Span<Matrix2X4<float>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix2x4(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix2x4(int location, bool transpose = false, params Matrix2X4<float>[] value)
	{
		UniformMatrix2x4(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix2x4(string name, bool transpose = false, params Matrix2X4<float>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix2x4(location, transpose, value);
	}

	public bool TryUniformMatrix2x4(string name, bool transpose = false, params Matrix2X4<float>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix2x4(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix3x2(int location, bool transpose, Span<Matrix3X2<float>> value)
	{
		ThrowIfDisposed();

		fixed (Matrix3X2<float>* value_ptr = value)
		{
			GL.ProgramUniformMatrix3x2(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(float*)value_ptr);
		}
	}

	public unsafe void UniformMatrix3x2(string name, bool transpose, Span<Matrix3X2<float>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix3x2(location, transpose, value);
	}

	public bool TryUniformMatrix3x2(string name, bool transpose, Span<Matrix3X2<float>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix3x2(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix3x2(int location, bool transpose = false, params Matrix3X2<float>[] value)
	{
		UniformMatrix3x2(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix3x2(string name, bool transpose = false, params Matrix3X2<float>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix3x2(location, transpose, value);
	}

	public bool TryUniformMatrix3x2(string name, bool transpose = false, params Matrix3X2<float>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix3x2(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix3(int location, bool transpose, Span<Matrix3X3<float>> value)
	{
		ThrowIfDisposed();

		fixed (Matrix3X3<float>* value_ptr = value)
		{
			GL.ProgramUniformMatrix3(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(float*)value_ptr);
		}
	}

	public unsafe void UniformMatrix3(string name, bool transpose, Span<Matrix3X3<float>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix3(location, transpose, value);
	}

	public bool TryUniformMatrix3(string name, bool transpose, Span<Matrix3X3<float>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix3(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix3(int location, bool transpose = false, params Matrix3X3<float>[] value)
	{
		UniformMatrix3(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix3(string name, bool transpose = false, params Matrix3X3<float>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix3(location, transpose, value);
	}

	public bool TryUniformMatrix3(string name, bool transpose = false, params Matrix3X3<float>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix3(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix3x4(int location, bool transpose, Span<Matrix3X4<float>> value)
	{
		ThrowIfDisposed();

		fixed (Matrix3X4<float>* value_ptr = value)
		{
			GL.ProgramUniformMatrix3x4(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(float*)value_ptr);
		}
	}

	public unsafe void UniformMatrix3x4(string name, bool transpose, Span<Matrix3X4<float>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix3x4(location, transpose, value);
	}

	public bool TryUniformMatrix3x4(string name, bool transpose, Span<Matrix3X4<float>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix3x4(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix3x4(int location, bool transpose = false, params Matrix3X4<float>[] value)
	{
		UniformMatrix3x4(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix3x4(string name, bool transpose = false, params Matrix3X4<float>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix3x4(location, transpose, value);
	}

	public bool TryUniformMatrix3x4(string name, bool transpose = false, params Matrix3X4<float>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix3x4(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix4x2(int location, bool transpose, Span<Matrix4X2<float>> value)
	{
		ThrowIfDisposed();

		fixed (Matrix4X2<float>* value_ptr = value)
		{
			GL.ProgramUniformMatrix4x2(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(float*)value_ptr);
		}
	}

	public unsafe void UniformMatrix4x2(string name, bool transpose, Span<Matrix4X2<float>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix4x2(location, transpose, value);
	}

	public bool TryUniformMatrix4x2(string name, bool transpose, Span<Matrix4X2<float>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix4x2(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix4x2(int location, bool transpose = false, params Matrix4X2<float>[] value)
	{
		UniformMatrix4x2(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix4x2(string name, bool transpose = false, params Matrix4X2<float>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix4x2(location, transpose, value);
	}

	public bool TryUniformMatrix4x2(string name, bool transpose = false, params Matrix4X2<float>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix4x2(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix4x3(int location, bool transpose, Span<Matrix4X3<float>> value)
	{
		ThrowIfDisposed();

		fixed (Matrix4X3<float>* value_ptr = value)
		{
			GL.ProgramUniformMatrix4x3(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(float*)value_ptr);
		}
	}

	public unsafe void UniformMatrix4x3(string name, bool transpose, Span<Matrix4X3<float>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix4x3(location, transpose, value);
	}

	public bool TryUniformMatrix4x3(string name, bool transpose, Span<Matrix4X3<float>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix4x3(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix4x3(int location, bool transpose = false, params Matrix4X3<float>[] value)
	{
		UniformMatrix4x3(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix4x3(string name, bool transpose = false, params Matrix4X3<float>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix4x3(location, transpose, value);
	}

	public bool TryUniformMatrix4x3(string name, bool transpose = false, params Matrix4X3<float>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix4x3(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix4(int location, bool transpose, Span<Matrix4X4<float>> value)
	{
		ThrowIfDisposed();

		fixed (Matrix4X4<float>* value_ptr = value)
		{
			GL.ProgramUniformMatrix4(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(float*)value_ptr);
		}
	}

	public unsafe void UniformMatrix4(string name, bool transpose, Span<Matrix4X4<float>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix4(location, transpose, value);
	}

	public bool TryUniformMatrix4(string name, bool transpose, Span<Matrix4X4<float>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix4(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix4(int location, bool transpose = false, params Matrix4X4<float>[] value)
	{
		UniformMatrix4(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix4(string name, bool transpose = false, params Matrix4X4<float>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix4(location, transpose, value);
	}

	public bool TryUniformMatrix4(string name, bool transpose = false, params Matrix4X4<float>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix4(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix2(int location, bool transpose, Span<Matrix2X2<double>> value)
	{
		ThrowIfDisposed();

		fixed (Matrix2X2<double>* value_ptr = value)
		{
			GL.ProgramUniformMatrix2(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(double*)value_ptr);
		}
	}

	public unsafe void UniformMatrix2(string name, bool transpose, Span<Matrix2X2<double>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix2(location, transpose, value);
	}

	public bool TryUniformMatrix2(string name, bool transpose, Span<Matrix2X2<double>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix2(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix2(int location, bool transpose = false, params Matrix2X2<double>[] value)
	{
		UniformMatrix2(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix2(string name, bool transpose = false, params Matrix2X2<double>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix2(location, transpose, value);
	}

	public bool TryUniformMatrix2(string name, bool transpose = false, params Matrix2X2<double>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix2(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix2x3(int location, bool transpose, Span<Matrix2X3<double>> value)
	{
		ThrowIfDisposed();

		fixed (Matrix2X3<double>* value_ptr = value)
		{
			GL.ProgramUniformMatrix2x3(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(double*)value_ptr);
		}
	}

	public unsafe void UniformMatrix2x3(string name, bool transpose, Span<Matrix2X3<double>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix2x3(location, transpose, value);
	}

	public bool TryUniformMatrix2x3(string name, bool transpose, Span<Matrix2X3<double>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix2x3(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix2x3(int location, bool transpose = false, params Matrix2X3<double>[] value)
	{
		UniformMatrix2x3(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix2x3(string name, bool transpose = false, params Matrix2X3<double>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix2x3(location, transpose, value);
	}

	public bool TryUniformMatrix2x3(string name, bool transpose = false, params Matrix2X3<double>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix2x3(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix2x4(int location, bool transpose, Span<Matrix2X4<double>> value)
	{
		ThrowIfDisposed();

		fixed (Matrix2X4<double>* value_ptr = value)
		{
			GL.ProgramUniformMatrix2x4(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(double*)value_ptr);
		}
	}

	public unsafe void UniformMatrix2x4(string name, bool transpose, Span<Matrix2X4<double>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix2x4(location, transpose, value);
	}

	public bool TryUniformMatrix2x4(string name, bool transpose, Span<Matrix2X4<double>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix2x4(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix2x4(int location, bool transpose = false, params Matrix2X4<double>[] value)
	{
		UniformMatrix2x4(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix2x4(string name, bool transpose = false, params Matrix2X4<double>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix2x4(location, transpose, value);
	}

	public bool TryUniformMatrix2x4(string name, bool transpose = false, params Matrix2X4<double>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix2x4(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix3x2(int location, bool transpose, Span<Matrix3X2<double>> value)
	{
		ThrowIfDisposed();

		fixed (Matrix3X2<double>* value_ptr = value)
		{
			GL.ProgramUniformMatrix3x2(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(double*)value_ptr);
		}
	}

	public unsafe void UniformMatrix3x2(string name, bool transpose, Span<Matrix3X2<double>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix3x2(location, transpose, value);
	}

	public bool TryUniformMatrix3x2(string name, bool transpose, Span<Matrix3X2<double>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix3x2(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix3x2(int location, bool transpose = false, params Matrix3X2<double>[] value)
	{
		UniformMatrix3x2(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix3x2(string name, bool transpose = false, params Matrix3X2<double>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix3x2(location, transpose, value);
	}

	public bool TryUniformMatrix3x2(string name, bool transpose = false, params Matrix3X2<double>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix3x2(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix3(int location, bool transpose, Span<Matrix3X3<double>> value)
	{
		ThrowIfDisposed();

		fixed (Matrix3X3<double>* value_ptr = value)
		{
			GL.ProgramUniformMatrix3(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(double*)value_ptr);
		}
	}

	public unsafe void UniformMatrix3(string name, bool transpose, Span<Matrix3X3<double>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix3(location, transpose, value);
	}

	public bool TryUniformMatrix3(string name, bool transpose, Span<Matrix3X3<double>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix3(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix3(int location, bool transpose = false, params Matrix3X3<double>[] value)
	{
		UniformMatrix3(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix3(string name, bool transpose = false, params Matrix3X3<double>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix3(location, transpose, value);
	}

	public bool TryUniformMatrix3(string name, bool transpose = false, params Matrix3X3<double>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix3(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix3x4(int location, bool transpose, Span<Matrix3X4<double>> value)
	{
		ThrowIfDisposed();

		fixed (Matrix3X4<double>* value_ptr = value)
		{
			GL.ProgramUniformMatrix3x4(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(double*)value_ptr);
		}
	}

	public unsafe void UniformMatrix3x4(string name, bool transpose, Span<Matrix3X4<double>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix3x4(location, transpose, value);
	}

	public bool TryUniformMatrix3x4(string name, bool transpose, Span<Matrix3X4<double>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix3x4(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix3x4(int location, bool transpose = false, params Matrix3X4<double>[] value)
	{
		UniformMatrix3x4(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix3x4(string name, bool transpose = false, params Matrix3X4<double>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix3x4(location, transpose, value);
	}

	public bool TryUniformMatrix3x4(string name, bool transpose = false, params Matrix3X4<double>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix3x4(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix4x2(int location, bool transpose, Span<Matrix4X2<double>> value)
	{
		ThrowIfDisposed();

		fixed (Matrix4X2<double>* value_ptr = value)
		{
			GL.ProgramUniformMatrix4x2(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(double*)value_ptr);
		}
	}

	public unsafe void UniformMatrix4x2(string name, bool transpose, Span<Matrix4X2<double>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix4x2(location, transpose, value);
	}

	public bool TryUniformMatrix4x2(string name, bool transpose, Span<Matrix4X2<double>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix4x2(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix4x2(int location, bool transpose = false, params Matrix4X2<double>[] value)
	{
		UniformMatrix4x2(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix4x2(string name, bool transpose = false, params Matrix4X2<double>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix4x2(location, transpose, value);
	}

	public bool TryUniformMatrix4x2(string name, bool transpose = false, params Matrix4X2<double>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix4x2(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix4x3(int location, bool transpose, Span<Matrix4X3<double>> value)
	{
		ThrowIfDisposed();

		fixed (Matrix4X3<double>* value_ptr = value)
		{
			GL.ProgramUniformMatrix4x3(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(double*)value_ptr);
		}
	}

	public unsafe void UniformMatrix4x3(string name, bool transpose, Span<Matrix4X3<double>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix4x3(location, transpose, value);
	}

	public bool TryUniformMatrix4x3(string name, bool transpose, Span<Matrix4X3<double>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix4x3(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix4x3(int location, bool transpose = false, params Matrix4X3<double>[] value)
	{
		UniformMatrix4x3(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix4x3(string name, bool transpose = false, params Matrix4X3<double>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix4x3(location, transpose, value);
	}

	public bool TryUniformMatrix4x3(string name, bool transpose = false, params Matrix4X3<double>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix4x3(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix4(int location, bool transpose, Span<Matrix4X4<double>> value)
	{
		ThrowIfDisposed();

		fixed (Matrix4X4<double>* value_ptr = value)
		{
			GL.ProgramUniformMatrix4(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(double*)value_ptr);
		}
	}

	public unsafe void UniformMatrix4(string name, bool transpose, Span<Matrix4X4<double>> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix4(location, transpose, value);
	}

	public bool TryUniformMatrix4(string name, bool transpose, Span<Matrix4X4<double>> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix4(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix4(int location, bool transpose = false, params Matrix4X4<double>[] value)
	{
		UniformMatrix4(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix4(string name, bool transpose = false, params Matrix4X4<double>[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix4(location, transpose, value);
	}

	public bool TryUniformMatrix4(string name, bool transpose = false, params Matrix4X4<double>[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix4(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix3x2(int location, bool transpose, Span<Matrix3x2> value)
	{
		ThrowIfDisposed();

		fixed (Matrix3x2* value_ptr = value)
		{
			GL.ProgramUniformMatrix3x2(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(float*)value_ptr);
		}
	}

	public unsafe void UniformMatrix3x2(string name, bool transpose, Span<Matrix3x2> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix3x2(location, transpose, value);
	}

	public bool TryUniformMatrix3x2(string name, bool transpose, Span<Matrix3x2> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix3x2(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix3x2(int location, bool transpose = false, params Matrix3x2[] value)
	{
		UniformMatrix3x2(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix3x2(string name, bool transpose = false, params Matrix3x2[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix3x2(location, transpose, value);
	}

	public bool TryUniformMatrix3x2(string name, bool transpose = false, params Matrix3x2[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix3x2(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix4(int location, bool transpose, Span<Matrix4x4> value)
	{
		ThrowIfDisposed();

		fixed (Matrix4x4* value_ptr = value)
		{
			GL.ProgramUniformMatrix4(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				(float*)value_ptr);
		}
	}

	public unsafe void UniformMatrix4(string name, bool transpose, Span<Matrix4x4> value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix4(location, transpose, value);
	}

	public bool TryUniformMatrix4(string name, bool transpose, Span<Matrix4x4> value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix4(location, transpose, value);
		return true;
	}

	public unsafe void UniformMatrix4(int location, bool transpose = false, params Matrix4x4[] value)
	{
		UniformMatrix4(location, transpose, value.AsSpan());
	}

	public unsafe void UniformMatrix4(string name, bool transpose = false, params Matrix4x4[] value)
	{
		int location = GetUniformLocationUnsafeChecked(name);

		UniformMatrix4(location, transpose, value);
	}

	public bool TryUniformMatrix4(string name, bool transpose = false, params Matrix4x4[] value)
	{
		int location = GetUniformLocationUnsafe(name);
		if (location is < 0)
		{
			return false;
		}

		UniformMatrix4(location, transpose, value);
		return true;
	}

}
