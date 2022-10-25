// <https://github.com/yvvki> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.ComponentModel;
using System.Numerics;
using System.Runtime.InteropServices;

using Silk.NET.Maths;
using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

public partial class Program
{
	private delegate void glProgramUniformMatrix<T>(uint program, int location, uint count, bool transpose, ReadOnlySpan<T> value);

	public void Uniform(int location, int v0)
	{
		lock (GL)
		{
			GL.ProgramUniform1(Handle, location, v0);
			ThrowIfError();
		}
	}

	public void Uniform(string name, int v0)
	{
		int location = GetUniformLocation(name);
		Uniform(location, v0);
	}

	public void Uniform(int location, ReadOnlySpan<int> value)
	{
		lock (GL)
		{
			GL.ProgramUniform1(Handle, location, value);
			ThrowIfError();
		}
	}

	public void Uniform(string name, ReadOnlySpan<int> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params int[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params int[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform(int location, ReadOnlySpan<ValueTuple<int>> value)
	{
		ReadOnlySpan<int> value1 = MemoryMarshal.Cast<ValueTuple<int>, int>(value);
		Uniform(location, value1);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform(string name, ReadOnlySpan<ValueTuple<int>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform(int location, params ValueTuple<int>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform(string name, params ValueTuple<int>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, int v0, int v1)
	{
		lock (GL)
		{
			GL.ProgramUniform2(Handle, location, v0, v1);
			ThrowIfError();
		}
	}

	public void Uniform(string name, int v0, int v1)
	{
		int location = GetUniformLocation(name);
		Uniform(location, v0, v1);
	}

	public void Uniform(int location, ReadOnlySpan<ValueTuple<int, int>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform2(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<int, int>, int>(value));
			ThrowIfError();
		}
	}

	public void Uniform(string name, ReadOnlySpan<ValueTuple<int, int>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params ValueTuple<int, int>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params ValueTuple<int, int>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, Vector2D<int> vector)
	{
		Uniform(
			location,
			vector.X,
			vector.Y);
	}

	public void Uniform(string name, Vector2D<int> vector)
	{
		Uniform(
			name,
			vector.X,
			vector.Y);
	}

	public void Uniform(int location, ReadOnlySpan<Vector2D<int>> value)
	{
		Uniform(location, MemoryMarshal.Cast<Vector2D<int>, ValueTuple<int, int>>(value));
	}

	public void Uniform(string name, ReadOnlySpan<Vector2D<int>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params Vector2D<int>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params Vector2D<int>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, int v0, int v1, int v2)
	{
		lock (GL)
		{
			GL.ProgramUniform3(Handle, location, v0, v1, v2);
			ThrowIfError();
		}
	}

	public void Uniform(string name, int v0, int v1, int v2)
	{
		int location = GetUniformLocation(name);
		Uniform(location, v0, v1, v2);
	}

	public void Uniform(int location, ReadOnlySpan<ValueTuple<int, int, int>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform3(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<int, int, int>, int>(value));
			ThrowIfError();
		}
	}

	public void Uniform(string name, ReadOnlySpan<ValueTuple<int, int, int>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params ValueTuple<int, int, int>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params ValueTuple<int, int, int>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, Vector3D<int> vector)
	{
		Uniform(
			location,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform(string name, Vector3D<int> vector)
	{
		Uniform(
			name,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform(int location, ReadOnlySpan<Vector3D<int>> value)
	{
		Uniform(location, MemoryMarshal.Cast<Vector3D<int>, ValueTuple<int, int, int>>(value));
	}

	public void Uniform(string name, ReadOnlySpan<Vector3D<int>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params Vector3D<int>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params Vector3D<int>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, int v0, int v1, int v2, int v3)
	{
		lock (GL)
		{
			GL.ProgramUniform4(Handle, location, v0, v1, v2, v3);
			ThrowIfError();
		}
	}

	public void Uniform(string name, int v0, int v1, int v2, int v3)
	{
		int location = GetUniformLocation(name);
		Uniform(location, v0, v1, v2, v3);
	}

	public void Uniform(int location, ReadOnlySpan<ValueTuple<int, int, int, int>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform4(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<int, int, int, int>, int>(value));
			ThrowIfError();
		}
	}

	public void Uniform(string name, ReadOnlySpan<ValueTuple<int, int, int, int>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params ValueTuple<int, int, int, int>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params ValueTuple<int, int, int, int>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, Vector4D<int> vector)
	{
		Uniform(
			location,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform(string name, Vector4D<int> vector)
	{
		Uniform(
			name,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform(int location, ReadOnlySpan<Vector4D<int>> value)
	{
		Uniform(location, MemoryMarshal.Cast<Vector4D<int>, ValueTuple<int, int, int, int>>(value));
	}

	public void Uniform(string name, ReadOnlySpan<Vector4D<int>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params Vector4D<int>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params Vector4D<int>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, uint v0)
	{
		lock (GL)
		{
			GL.ProgramUniform1(Handle, location, v0);
			ThrowIfError();
		}
	}

	public void Uniform(string name, uint v0)
	{
		int location = GetUniformLocation(name);
		Uniform(location, v0);
	}

	public void Uniform(int location, ReadOnlySpan<uint> value)
	{
		lock (GL)
		{
			GL.ProgramUniform1(Handle, location, value);
			ThrowIfError();
		}
	}

	public void Uniform(string name, ReadOnlySpan<uint> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params uint[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params uint[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform(int location, ReadOnlySpan<ValueTuple<uint>> value)
	{
		ReadOnlySpan<uint> value1 = MemoryMarshal.Cast<ValueTuple<uint>, uint>(value);
		Uniform(location, value1);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform(string name, ReadOnlySpan<ValueTuple<uint>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform(int location, params ValueTuple<uint>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform(string name, params ValueTuple<uint>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, uint v0, uint v1)
	{
		lock (GL)
		{
			GL.ProgramUniform2(Handle, location, v0, v1);
			ThrowIfError();
		}
	}

	public void Uniform(string name, uint v0, uint v1)
	{
		int location = GetUniformLocation(name);
		Uniform(location, v0, v1);
	}

	public void Uniform(int location, ReadOnlySpan<ValueTuple<uint, uint>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform2(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<uint, uint>, uint>(value));
			ThrowIfError();
		}
	}

	public void Uniform(string name, ReadOnlySpan<ValueTuple<uint, uint>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params ValueTuple<uint, uint>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params ValueTuple<uint, uint>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, Vector2D<uint> vector)
	{
		Uniform(
			location,
			vector.X,
			vector.Y);
	}

	public void Uniform(string name, Vector2D<uint> vector)
	{
		Uniform(
			name,
			vector.X,
			vector.Y);
	}

	public void Uniform(int location, ReadOnlySpan<Vector2D<uint>> value)
	{
		Uniform(location, MemoryMarshal.Cast<Vector2D<uint>, ValueTuple<uint, uint>>(value));
	}

	public void Uniform(string name, ReadOnlySpan<Vector2D<uint>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params Vector2D<uint>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params Vector2D<uint>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, uint v0, uint v1, uint v2)
	{
		lock (GL)
		{
			GL.ProgramUniform3(Handle, location, v0, v1, v2);
			ThrowIfError();
		}
	}

	public void Uniform(string name, uint v0, uint v1, uint v2)
	{
		int location = GetUniformLocation(name);
		Uniform(location, v0, v1, v2);
	}

	public void Uniform(int location, ReadOnlySpan<ValueTuple<uint, uint, uint>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform3(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<uint, uint, uint>, uint>(value));
			ThrowIfError();
		}
	}

	public void Uniform(string name, ReadOnlySpan<ValueTuple<uint, uint, uint>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params ValueTuple<uint, uint, uint>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params ValueTuple<uint, uint, uint>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, Vector3D<uint> vector)
	{
		Uniform(
			location,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform(string name, Vector3D<uint> vector)
	{
		Uniform(
			name,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform(int location, ReadOnlySpan<Vector3D<uint>> value)
	{
		Uniform(location, MemoryMarshal.Cast<Vector3D<uint>, ValueTuple<uint, uint, uint>>(value));
	}

	public void Uniform(string name, ReadOnlySpan<Vector3D<uint>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params Vector3D<uint>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params Vector3D<uint>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, uint v0, uint v1, uint v2, uint v3)
	{
		lock (GL)
		{
			GL.ProgramUniform4(Handle, location, v0, v1, v2, v3);
			ThrowIfError();
		}
	}

	public void Uniform(string name, uint v0, uint v1, uint v2, uint v3)
	{
		int location = GetUniformLocation(name);
		Uniform(location, v0, v1, v2, v3);
	}

	public void Uniform(int location, ReadOnlySpan<ValueTuple<uint, uint, uint, uint>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform4(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<uint, uint, uint, uint>, uint>(value));
			ThrowIfError();
		}
	}

	public void Uniform(string name, ReadOnlySpan<ValueTuple<uint, uint, uint, uint>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params ValueTuple<uint, uint, uint, uint>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params ValueTuple<uint, uint, uint, uint>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, Vector4D<uint> vector)
	{
		Uniform(
			location,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform(string name, Vector4D<uint> vector)
	{
		Uniform(
			name,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform(int location, ReadOnlySpan<Vector4D<uint>> value)
	{
		Uniform(location, MemoryMarshal.Cast<Vector4D<uint>, ValueTuple<uint, uint, uint, uint>>(value));
	}

	public void Uniform(string name, ReadOnlySpan<Vector4D<uint>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params Vector4D<uint>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params Vector4D<uint>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, float v0)
	{
		lock (GL)
		{
			GL.ProgramUniform1(Handle, location, v0);
			ThrowIfError();
		}
	}

	public void Uniform(string name, float v0)
	{
		int location = GetUniformLocation(name);
		Uniform(location, v0);
	}

	public void Uniform(int location, ReadOnlySpan<float> value)
	{
		lock (GL)
		{
			GL.ProgramUniform1(Handle, location, value);
			ThrowIfError();
		}
	}

	public void Uniform(string name, ReadOnlySpan<float> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params float[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params float[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform(int location, ReadOnlySpan<ValueTuple<float>> value)
	{
		ReadOnlySpan<float> value1 = MemoryMarshal.Cast<ValueTuple<float>, float>(value);
		Uniform(location, value1);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform(string name, ReadOnlySpan<ValueTuple<float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform(int location, params ValueTuple<float>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform(string name, params ValueTuple<float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, float v0, float v1)
	{
		lock (GL)
		{
			GL.ProgramUniform2(Handle, location, v0, v1);
			ThrowIfError();
		}
	}

	public void Uniform(string name, float v0, float v1)
	{
		int location = GetUniformLocation(name);
		Uniform(location, v0, v1);
	}

	public void Uniform(int location, ReadOnlySpan<ValueTuple<float, float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform2(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<float, float>, float>(value));
			ThrowIfError();
		}
	}

	public void Uniform(string name, ReadOnlySpan<ValueTuple<float, float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params ValueTuple<float, float>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params ValueTuple<float, float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, Vector2D<float> vector)
	{
		Uniform(
			location,
			vector.X,
			vector.Y);
	}

	public void Uniform(string name, Vector2D<float> vector)
	{
		Uniform(
			name,
			vector.X,
			vector.Y);
	}

	public void Uniform(int location, ReadOnlySpan<Vector2D<float>> value)
	{
		Uniform(location, MemoryMarshal.Cast<Vector2D<float>, ValueTuple<float, float>>(value));
	}

	public void Uniform(string name, ReadOnlySpan<Vector2D<float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params Vector2D<float>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params Vector2D<float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, float v0, float v1, float v2)
	{
		lock (GL)
		{
			GL.ProgramUniform3(Handle, location, v0, v1, v2);
			ThrowIfError();
		}
	}

	public void Uniform(string name, float v0, float v1, float v2)
	{
		int location = GetUniformLocation(name);
		Uniform(location, v0, v1, v2);
	}

	public void Uniform(int location, ReadOnlySpan<ValueTuple<float, float, float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform3(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<float, float, float>, float>(value));
			ThrowIfError();
		}
	}

	public void Uniform(string name, ReadOnlySpan<ValueTuple<float, float, float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params ValueTuple<float, float, float>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params ValueTuple<float, float, float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, Vector3D<float> vector)
	{
		Uniform(
			location,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform(string name, Vector3D<float> vector)
	{
		Uniform(
			name,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform(int location, ReadOnlySpan<Vector3D<float>> value)
	{
		Uniform(location, MemoryMarshal.Cast<Vector3D<float>, ValueTuple<float, float, float>>(value));
	}

	public void Uniform(string name, ReadOnlySpan<Vector3D<float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params Vector3D<float>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params Vector3D<float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, float v0, float v1, float v2, float v3)
	{
		lock (GL)
		{
			GL.ProgramUniform4(Handle, location, v0, v1, v2, v3);
			ThrowIfError();
		}
	}

	public void Uniform(string name, float v0, float v1, float v2, float v3)
	{
		int location = GetUniformLocation(name);
		Uniform(location, v0, v1, v2, v3);
	}

	public void Uniform(int location, ReadOnlySpan<ValueTuple<float, float, float, float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform4(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<float, float, float, float>, float>(value));
			ThrowIfError();
		}
	}

	public void Uniform(string name, ReadOnlySpan<ValueTuple<float, float, float, float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params ValueTuple<float, float, float, float>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params ValueTuple<float, float, float, float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, Vector4D<float> vector)
	{
		Uniform(
			location,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform(string name, Vector4D<float> vector)
	{
		Uniform(
			name,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform(int location, ReadOnlySpan<Vector4D<float>> value)
	{
		Uniform(location, MemoryMarshal.Cast<Vector4D<float>, ValueTuple<float, float, float, float>>(value));
	}

	public void Uniform(string name, ReadOnlySpan<Vector4D<float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params Vector4D<float>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params Vector4D<float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, Vector2 vector)
	{
		Uniform(
			location,
			vector.X,
			vector.Y);
	}

	public void Uniform(string name, Vector2 vector)
	{
		Uniform(
			name,
			vector.X,
			vector.Y);
	}

	public void Uniform(int location, ReadOnlySpan<Vector2> value)
	{
		Uniform(location, MemoryMarshal.Cast<Vector2, ValueTuple<float, float>>(value));
	}

	public void Uniform(string name, ReadOnlySpan<Vector2> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params Vector2[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params Vector2[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, Vector3 vector)
	{
		Uniform(
			location,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform(string name, Vector3 vector)
	{
		Uniform(
			name,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform(int location, ReadOnlySpan<Vector3> value)
	{
		Uniform(location, MemoryMarshal.Cast<Vector3, ValueTuple<float, float, float>>(value));
	}

	public void Uniform(string name, ReadOnlySpan<Vector3> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params Vector3[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params Vector3[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, Vector4 vector)
	{
		Uniform(
			location,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform(string name, Vector4 vector)
	{
		Uniform(
			name,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform(int location, ReadOnlySpan<Vector4> value)
	{
		Uniform(location, MemoryMarshal.Cast<Vector4, ValueTuple<float, float, float, float>>(value));
	}

	public void Uniform(string name, ReadOnlySpan<Vector4> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params Vector4[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params Vector4[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, double v0)
	{
		lock (GL)
		{
			GL.ProgramUniform1(Handle, location, v0);
			ThrowIfError();
		}
	}

	public void Uniform(string name, double v0)
	{
		int location = GetUniformLocation(name);
		Uniform(location, v0);
	}

	public void Uniform(int location, ReadOnlySpan<double> value)
	{
		lock (GL)
		{
			GL.ProgramUniform1(Handle, location, value);
			ThrowIfError();
		}
	}

	public void Uniform(string name, ReadOnlySpan<double> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params double[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params double[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform(int location, ReadOnlySpan<ValueTuple<double>> value)
	{
		ReadOnlySpan<double> value1 = MemoryMarshal.Cast<ValueTuple<double>, double>(value);
		Uniform(location, value1);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform(string name, ReadOnlySpan<ValueTuple<double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform(int location, params ValueTuple<double>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform(string name, params ValueTuple<double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, double v0, double v1)
	{
		lock (GL)
		{
			GL.ProgramUniform2(Handle, location, v0, v1);
			ThrowIfError();
		}
	}

	public void Uniform(string name, double v0, double v1)
	{
		int location = GetUniformLocation(name);
		Uniform(location, v0, v1);
	}

	public void Uniform(int location, ReadOnlySpan<ValueTuple<double, double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform2(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<double, double>, double>(value));
			ThrowIfError();
		}
	}

	public void Uniform(string name, ReadOnlySpan<ValueTuple<double, double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params ValueTuple<double, double>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params ValueTuple<double, double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, Vector2D<double> vector)
	{
		Uniform(
			location,
			vector.X,
			vector.Y);
	}

	public void Uniform(string name, Vector2D<double> vector)
	{
		Uniform(
			name,
			vector.X,
			vector.Y);
	}

	public void Uniform(int location, ReadOnlySpan<Vector2D<double>> value)
	{
		Uniform(location, MemoryMarshal.Cast<Vector2D<double>, ValueTuple<double, double>>(value));
	}

	public void Uniform(string name, ReadOnlySpan<Vector2D<double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params Vector2D<double>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params Vector2D<double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, double v0, double v1, double v2)
	{
		lock (GL)
		{
			GL.ProgramUniform3(Handle, location, v0, v1, v2);
			ThrowIfError();
		}
	}

	public void Uniform(string name, double v0, double v1, double v2)
	{
		int location = GetUniformLocation(name);
		Uniform(location, v0, v1, v2);
	}

	public void Uniform(int location, ReadOnlySpan<ValueTuple<double, double, double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform3(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<double, double, double>, double>(value));
			ThrowIfError();
		}
	}

	public void Uniform(string name, ReadOnlySpan<ValueTuple<double, double, double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params ValueTuple<double, double, double>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params ValueTuple<double, double, double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, Vector3D<double> vector)
	{
		Uniform(
			location,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform(string name, Vector3D<double> vector)
	{
		Uniform(
			name,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform(int location, ReadOnlySpan<Vector3D<double>> value)
	{
		Uniform(location, MemoryMarshal.Cast<Vector3D<double>, ValueTuple<double, double, double>>(value));
	}

	public void Uniform(string name, ReadOnlySpan<Vector3D<double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params Vector3D<double>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params Vector3D<double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, double v0, double v1, double v2, double v3)
	{
		lock (GL)
		{
			GL.ProgramUniform4(Handle, location, v0, v1, v2, v3);
			ThrowIfError();
		}
	}

	public void Uniform(string name, double v0, double v1, double v2, double v3)
	{
		int location = GetUniformLocation(name);
		Uniform(location, v0, v1, v2, v3);
	}

	public void Uniform(int location, ReadOnlySpan<ValueTuple<double, double, double, double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform4(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<double, double, double, double>, double>(value));
			ThrowIfError();
		}
	}

	public void Uniform(string name, ReadOnlySpan<ValueTuple<double, double, double, double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params ValueTuple<double, double, double, double>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params ValueTuple<double, double, double, double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, Vector4D<double> vector)
	{
		Uniform(
			location,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform(string name, Vector4D<double> vector)
	{
		Uniform(
			name,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform(int location, ReadOnlySpan<Vector4D<double>> value)
	{
		Uniform(location, MemoryMarshal.Cast<Vector4D<double>, ValueTuple<double, double, double, double>>(value));
	}

	public void Uniform(string name, ReadOnlySpan<Vector4D<double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, params Vector4D<double>[] value)
	{
		Uniform(location, value.AsSpan());
	}

	public void Uniform(string name, params Vector4D<double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix2X2<float>> value)
	{
		glProgramUniformMatrix<float> glProgramUniformMatrix =
			GL.ProgramUniformMatrix2;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix2X2<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix2X2<float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix2X2<float>[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix2X2<float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix2X3<float>> value)
	{
		glProgramUniformMatrix<float> glProgramUniformMatrix =
			transpose is false
			? GL.ProgramUniformMatrix2x3
			: GL.ProgramUniformMatrix3x2;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix2X3<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix2X3<float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix2X3<float>[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix2X3<float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix2X4<float>> value)
	{
		glProgramUniformMatrix<float> glProgramUniformMatrix =
			transpose is false
			? GL.ProgramUniformMatrix2x4
			: GL.ProgramUniformMatrix4x2;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix2X4<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix2X4<float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix2X4<float>[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix2X4<float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix3X2<float>> value)
	{
		glProgramUniformMatrix<float> glProgramUniformMatrix =
			transpose is false
			? GL.ProgramUniformMatrix3x2
			: GL.ProgramUniformMatrix2x3;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix3X2<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix3X2<float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix3X2<float>[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix3X2<float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix3X3<float>> value)
	{
		glProgramUniformMatrix<float> glProgramUniformMatrix =
			GL.ProgramUniformMatrix3;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix3X3<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix3X3<float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix3X3<float>[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix3X3<float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix3X4<float>> value)
	{
		glProgramUniformMatrix<float> glProgramUniformMatrix =
			transpose is false
			? GL.ProgramUniformMatrix3x4
			: GL.ProgramUniformMatrix4x3;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix3X4<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix3X4<float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix3X4<float>[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix3X4<float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix4X2<float>> value)
	{
		glProgramUniformMatrix<float> glProgramUniformMatrix =
			transpose is false
			? GL.ProgramUniformMatrix4x2
			: GL.ProgramUniformMatrix2x4;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix4X2<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix4X2<float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix4X2<float>[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix4X2<float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix4X3<float>> value)
	{
		glProgramUniformMatrix<float> glProgramUniformMatrix =
			transpose is false
			? GL.ProgramUniformMatrix4x3
			: GL.ProgramUniformMatrix3x4;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix4X3<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix4X3<float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix4X3<float>[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix4X3<float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix4X4<float>> value)
	{
		glProgramUniformMatrix<float> glProgramUniformMatrix =
			GL.ProgramUniformMatrix4;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix4X4<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix4X4<float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix4X4<float>[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix4X4<float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix3x2> value)
	{
		glProgramUniformMatrix<float> glProgramUniformMatrix =
			transpose is false
			? GL.ProgramUniformMatrix3x2
			: GL.ProgramUniformMatrix2x3;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix3x2, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix3x2> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix3x2[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix3x2[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix4x4> value)
	{
		glProgramUniformMatrix<float> glProgramUniformMatrix =
			GL.ProgramUniformMatrix4;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix4x4, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix4x4> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix4x4[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix4x4[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix2X2<double>> value)
	{
		glProgramUniformMatrix<double> glProgramUniformMatrix =
			GL.ProgramUniformMatrix2;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix2X2<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix2X2<double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix2X2<double>[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix2X2<double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix2X3<double>> value)
	{
		glProgramUniformMatrix<double> glProgramUniformMatrix =
			transpose is false
			? GL.ProgramUniformMatrix2x3
			: GL.ProgramUniformMatrix3x2;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix2X3<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix2X3<double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix2X3<double>[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix2X3<double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix2X4<double>> value)
	{
		glProgramUniformMatrix<double> glProgramUniformMatrix =
			transpose is false
			? GL.ProgramUniformMatrix2x4
			: GL.ProgramUniformMatrix4x2;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix2X4<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix2X4<double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix2X4<double>[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix2X4<double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix3X2<double>> value)
	{
		glProgramUniformMatrix<double> glProgramUniformMatrix =
			transpose is false
			? GL.ProgramUniformMatrix3x2
			: GL.ProgramUniformMatrix2x3;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix3X2<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix3X2<double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix3X2<double>[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix3X2<double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix3X3<double>> value)
	{
		glProgramUniformMatrix<double> glProgramUniformMatrix =
			GL.ProgramUniformMatrix3;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix3X3<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix3X3<double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix3X3<double>[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix3X3<double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix3X4<double>> value)
	{
		glProgramUniformMatrix<double> glProgramUniformMatrix =
			transpose is false
			? GL.ProgramUniformMatrix3x4
			: GL.ProgramUniformMatrix4x3;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix3X4<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix3X4<double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix3X4<double>[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix3X4<double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix4X2<double>> value)
	{
		glProgramUniformMatrix<double> glProgramUniformMatrix =
			transpose is false
			? GL.ProgramUniformMatrix4x2
			: GL.ProgramUniformMatrix2x4;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix4X2<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix4X2<double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix4X2<double>[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix4X2<double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix4X3<double>> value)
	{
		glProgramUniformMatrix<double> glProgramUniformMatrix =
			transpose is false
			? GL.ProgramUniformMatrix4x3
			: GL.ProgramUniformMatrix3x4;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix4X3<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix4X3<double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix4X3<double>[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix4X3<double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public void Uniform(int location, bool transpose, ReadOnlySpan<Matrix4X4<double>> value)
	{
		glProgramUniformMatrix<double> glProgramUniformMatrix =
			GL.ProgramUniformMatrix4;

		lock (GL)
		{
			glProgramUniformMatrix(
				Handle,
				location,
				(uint)value.Length,
				transpose,
				MemoryMarshal.Cast<Matrix4X4<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void Uniform(string name, bool transpose, ReadOnlySpan<Matrix4X4<double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

	public unsafe void Uniform(int location, bool transpose = false, params Matrix4X4<double>[] value)
	{
		Uniform(location, transpose, value.AsSpan());
	}

	public unsafe void Uniform(string name, bool transpose = false, params Matrix4X4<double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform(location, transpose, value);
	}

}
