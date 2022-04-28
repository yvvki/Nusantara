// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.ComponentModel;
using System.Numerics;
using System.Runtime.InteropServices;

using Silk.NET.Maths;
using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

public partial class Program
{
	public void Uniform1(int location, int v0)
	{
		lock (GL)
		{
			GL.ProgramUniform1(Handle, location, v0);
			ThrowIfError();
		}
	}

	public void Uniform1(string name, int v0)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, v0);
	}

	public void Uniform1(int location, ReadOnlySpan<int> value)
	{
		lock (GL)
		{
			GL.ProgramUniform1(Handle, location, value);
			ThrowIfError();
		}
	}

	public void Uniform1(string name, ReadOnlySpan<int> value)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, value);
	}

	public void Uniform1(int location, params int[] value)
	{
		Uniform1(location, value.AsSpan());
	}

	public void Uniform1(string name, params int[] value)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform1(int location, ReadOnlySpan<ValueTuple<int>> value)
	{
		ReadOnlySpan<int> value1 = MemoryMarshal.Cast<ValueTuple<int>, int>(value);
		Uniform1(location, value1);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform1(string name, ReadOnlySpan<ValueTuple<int>> value)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform1(int location, params ValueTuple<int>[] value)
	{
		Uniform1(location, value.AsSpan());
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform1(string name, params ValueTuple<int>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, value);
	}

	public void Uniform2(int location, int v0, int v1)
	{
		lock (GL)
		{
			GL.ProgramUniform2(Handle, location, v0, v1);
			ThrowIfError();
		}
	}

	public void Uniform2(string name, int v0, int v1)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, v0, v1);
	}

	public void Uniform2(int location, ReadOnlySpan<ValueTuple<int, int>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform2(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<int, int>, int>(value));
			ThrowIfError();
		}
	}

	public void Uniform2(string name, ReadOnlySpan<ValueTuple<int, int>> value)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, value);
	}

	public void Uniform2(int location, params ValueTuple<int, int>[] value)
	{
		Uniform2(location, value.AsSpan());
	}

	public void Uniform2(string name, params ValueTuple<int, int>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, value);
	}

	public void Uniform2(int location, Vector2D<int> vector)
	{
		Uniform2(
			location,
			vector.X,
			vector.Y);
	}

	public void Uniform2(string name, Vector2D<int> vector)
	{
		Uniform2(
			name,
			vector.X,
			vector.Y);
	}

	public void Uniform2(int location, ReadOnlySpan<Vector2D<int>> value)
	{
		Uniform2(location, MemoryMarshal.Cast<Vector2D<int>, ValueTuple<int, int>>(value));
	}

	public void Uniform2(string name, ReadOnlySpan<Vector2D<int>> value)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, value);
	}

	public void Uniform2(int location, params Vector2D<int>[] value)
	{
		Uniform2(location, value.AsSpan());
	}

	public void Uniform2(string name, params Vector2D<int>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, value);
	}

	public void Uniform3(int location, int v0, int v1, int v2)
	{
		lock (GL)
		{
			GL.ProgramUniform3(Handle, location, v0, v1, v2);
			ThrowIfError();
		}
	}

	public void Uniform3(string name, int v0, int v1, int v2)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, v0, v1, v2);
	}

	public void Uniform3(int location, ReadOnlySpan<ValueTuple<int, int, int>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform3(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<int, int, int>, int>(value));
			ThrowIfError();
		}
	}

	public void Uniform3(string name, ReadOnlySpan<ValueTuple<int, int, int>> value)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, value);
	}

	public void Uniform3(int location, params ValueTuple<int, int, int>[] value)
	{
		Uniform3(location, value.AsSpan());
	}

	public void Uniform3(string name, params ValueTuple<int, int, int>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, value);
	}

	public void Uniform3(int location, Vector3D<int> vector)
	{
		Uniform3(
			location,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform3(string name, Vector3D<int> vector)
	{
		Uniform3(
			name,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform3(int location, ReadOnlySpan<Vector3D<int>> value)
	{
		Uniform3(location, MemoryMarshal.Cast<Vector3D<int>, ValueTuple<int, int, int>>(value));
	}

	public void Uniform3(string name, ReadOnlySpan<Vector3D<int>> value)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, value);
	}

	public void Uniform3(int location, params Vector3D<int>[] value)
	{
		Uniform3(location, value.AsSpan());
	}

	public void Uniform3(string name, params Vector3D<int>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, value);
	}

	public void Uniform4(int location, int v0, int v1, int v2, int v3)
	{
		lock (GL)
		{
			GL.ProgramUniform4(Handle, location, v0, v1, v2, v3);
			ThrowIfError();
		}
	}

	public void Uniform4(string name, int v0, int v1, int v2, int v3)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, v0, v1, v2, v3);
	}

	public void Uniform4(int location, ReadOnlySpan<ValueTuple<int, int, int, int>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform4(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<int, int, int, int>, int>(value));
			ThrowIfError();
		}
	}

	public void Uniform4(string name, ReadOnlySpan<ValueTuple<int, int, int, int>> value)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, value);
	}

	public void Uniform4(int location, params ValueTuple<int, int, int, int>[] value)
	{
		Uniform4(location, value.AsSpan());
	}

	public void Uniform4(string name, params ValueTuple<int, int, int, int>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, value);
	}

	public void Uniform4(int location, Vector4D<int> vector)
	{
		Uniform4(
			location,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform4(string name, Vector4D<int> vector)
	{
		Uniform4(
			name,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform4(int location, ReadOnlySpan<Vector4D<int>> value)
	{
		Uniform4(location, MemoryMarshal.Cast<Vector4D<int>, ValueTuple<int, int, int, int>>(value));
	}

	public void Uniform4(string name, ReadOnlySpan<Vector4D<int>> value)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, value);
	}

	public void Uniform4(int location, params Vector4D<int>[] value)
	{
		Uniform4(location, value.AsSpan());
	}

	public void Uniform4(string name, params Vector4D<int>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, value);
	}

	public void Uniform1(int location, uint v0)
	{
		lock (GL)
		{
			GL.ProgramUniform1(Handle, location, v0);
			ThrowIfError();
		}
	}

	public void Uniform1(string name, uint v0)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, v0);
	}

	public void Uniform1(int location, ReadOnlySpan<uint> value)
	{
		lock (GL)
		{
			GL.ProgramUniform1(Handle, location, value);
			ThrowIfError();
		}
	}

	public void Uniform1(string name, ReadOnlySpan<uint> value)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, value);
	}

	public void Uniform1(int location, params uint[] value)
	{
		Uniform1(location, value.AsSpan());
	}

	public void Uniform1(string name, params uint[] value)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform1(int location, ReadOnlySpan<ValueTuple<uint>> value)
	{
		ReadOnlySpan<uint> value1 = MemoryMarshal.Cast<ValueTuple<uint>, uint>(value);
		Uniform1(location, value1);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform1(string name, ReadOnlySpan<ValueTuple<uint>> value)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform1(int location, params ValueTuple<uint>[] value)
	{
		Uniform1(location, value.AsSpan());
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform1(string name, params ValueTuple<uint>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, value);
	}

	public void Uniform2(int location, uint v0, uint v1)
	{
		lock (GL)
		{
			GL.ProgramUniform2(Handle, location, v0, v1);
			ThrowIfError();
		}
	}

	public void Uniform2(string name, uint v0, uint v1)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, v0, v1);
	}

	public void Uniform2(int location, ReadOnlySpan<ValueTuple<uint, uint>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform2(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<uint, uint>, uint>(value));
			ThrowIfError();
		}
	}

	public void Uniform2(string name, ReadOnlySpan<ValueTuple<uint, uint>> value)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, value);
	}

	public void Uniform2(int location, params ValueTuple<uint, uint>[] value)
	{
		Uniform2(location, value.AsSpan());
	}

	public void Uniform2(string name, params ValueTuple<uint, uint>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, value);
	}

	public void Uniform2(int location, Vector2D<uint> vector)
	{
		Uniform2(
			location,
			vector.X,
			vector.Y);
	}

	public void Uniform2(string name, Vector2D<uint> vector)
	{
		Uniform2(
			name,
			vector.X,
			vector.Y);
	}

	public void Uniform2(int location, ReadOnlySpan<Vector2D<uint>> value)
	{
		Uniform2(location, MemoryMarshal.Cast<Vector2D<uint>, ValueTuple<uint, uint>>(value));
	}

	public void Uniform2(string name, ReadOnlySpan<Vector2D<uint>> value)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, value);
	}

	public void Uniform2(int location, params Vector2D<uint>[] value)
	{
		Uniform2(location, value.AsSpan());
	}

	public void Uniform2(string name, params Vector2D<uint>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, value);
	}

	public void Uniform3(int location, uint v0, uint v1, uint v2)
	{
		lock (GL)
		{
			GL.ProgramUniform3(Handle, location, v0, v1, v2);
			ThrowIfError();
		}
	}

	public void Uniform3(string name, uint v0, uint v1, uint v2)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, v0, v1, v2);
	}

	public void Uniform3(int location, ReadOnlySpan<ValueTuple<uint, uint, uint>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform3(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<uint, uint, uint>, uint>(value));
			ThrowIfError();
		}
	}

	public void Uniform3(string name, ReadOnlySpan<ValueTuple<uint, uint, uint>> value)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, value);
	}

	public void Uniform3(int location, params ValueTuple<uint, uint, uint>[] value)
	{
		Uniform3(location, value.AsSpan());
	}

	public void Uniform3(string name, params ValueTuple<uint, uint, uint>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, value);
	}

	public void Uniform3(int location, Vector3D<uint> vector)
	{
		Uniform3(
			location,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform3(string name, Vector3D<uint> vector)
	{
		Uniform3(
			name,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform3(int location, ReadOnlySpan<Vector3D<uint>> value)
	{
		Uniform3(location, MemoryMarshal.Cast<Vector3D<uint>, ValueTuple<uint, uint, uint>>(value));
	}

	public void Uniform3(string name, ReadOnlySpan<Vector3D<uint>> value)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, value);
	}

	public void Uniform3(int location, params Vector3D<uint>[] value)
	{
		Uniform3(location, value.AsSpan());
	}

	public void Uniform3(string name, params Vector3D<uint>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, value);
	}

	public void Uniform4(int location, uint v0, uint v1, uint v2, uint v3)
	{
		lock (GL)
		{
			GL.ProgramUniform4(Handle, location, v0, v1, v2, v3);
			ThrowIfError();
		}
	}

	public void Uniform4(string name, uint v0, uint v1, uint v2, uint v3)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, v0, v1, v2, v3);
	}

	public void Uniform4(int location, ReadOnlySpan<ValueTuple<uint, uint, uint, uint>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform4(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<uint, uint, uint, uint>, uint>(value));
			ThrowIfError();
		}
	}

	public void Uniform4(string name, ReadOnlySpan<ValueTuple<uint, uint, uint, uint>> value)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, value);
	}

	public void Uniform4(int location, params ValueTuple<uint, uint, uint, uint>[] value)
	{
		Uniform4(location, value.AsSpan());
	}

	public void Uniform4(string name, params ValueTuple<uint, uint, uint, uint>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, value);
	}

	public void Uniform4(int location, Vector4D<uint> vector)
	{
		Uniform4(
			location,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform4(string name, Vector4D<uint> vector)
	{
		Uniform4(
			name,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform4(int location, ReadOnlySpan<Vector4D<uint>> value)
	{
		Uniform4(location, MemoryMarshal.Cast<Vector4D<uint>, ValueTuple<uint, uint, uint, uint>>(value));
	}

	public void Uniform4(string name, ReadOnlySpan<Vector4D<uint>> value)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, value);
	}

	public void Uniform4(int location, params Vector4D<uint>[] value)
	{
		Uniform4(location, value.AsSpan());
	}

	public void Uniform4(string name, params Vector4D<uint>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, value);
	}

	public void Uniform1(int location, float v0)
	{
		lock (GL)
		{
			GL.ProgramUniform1(Handle, location, v0);
			ThrowIfError();
		}
	}

	public void Uniform1(string name, float v0)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, v0);
	}

	public void Uniform1(int location, ReadOnlySpan<float> value)
	{
		lock (GL)
		{
			GL.ProgramUniform1(Handle, location, value);
			ThrowIfError();
		}
	}

	public void Uniform1(string name, ReadOnlySpan<float> value)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, value);
	}

	public void Uniform1(int location, params float[] value)
	{
		Uniform1(location, value.AsSpan());
	}

	public void Uniform1(string name, params float[] value)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform1(int location, ReadOnlySpan<ValueTuple<float>> value)
	{
		ReadOnlySpan<float> value1 = MemoryMarshal.Cast<ValueTuple<float>, float>(value);
		Uniform1(location, value1);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform1(string name, ReadOnlySpan<ValueTuple<float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform1(int location, params ValueTuple<float>[] value)
	{
		Uniform1(location, value.AsSpan());
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform1(string name, params ValueTuple<float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, value);
	}

	public void Uniform2(int location, float v0, float v1)
	{
		lock (GL)
		{
			GL.ProgramUniform2(Handle, location, v0, v1);
			ThrowIfError();
		}
	}

	public void Uniform2(string name, float v0, float v1)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, v0, v1);
	}

	public void Uniform2(int location, ReadOnlySpan<ValueTuple<float, float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform2(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<float, float>, float>(value));
			ThrowIfError();
		}
	}

	public void Uniform2(string name, ReadOnlySpan<ValueTuple<float, float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, value);
	}

	public void Uniform2(int location, params ValueTuple<float, float>[] value)
	{
		Uniform2(location, value.AsSpan());
	}

	public void Uniform2(string name, params ValueTuple<float, float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, value);
	}

	public void Uniform2(int location, Vector2D<float> vector)
	{
		Uniform2(
			location,
			vector.X,
			vector.Y);
	}

	public void Uniform2(string name, Vector2D<float> vector)
	{
		Uniform2(
			name,
			vector.X,
			vector.Y);
	}

	public void Uniform2(int location, ReadOnlySpan<Vector2D<float>> value)
	{
		Uniform2(location, MemoryMarshal.Cast<Vector2D<float>, ValueTuple<float, float>>(value));
	}

	public void Uniform2(string name, ReadOnlySpan<Vector2D<float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, value);
	}

	public void Uniform2(int location, params Vector2D<float>[] value)
	{
		Uniform2(location, value.AsSpan());
	}

	public void Uniform2(string name, params Vector2D<float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, value);
	}

	public void Uniform3(int location, float v0, float v1, float v2)
	{
		lock (GL)
		{
			GL.ProgramUniform3(Handle, location, v0, v1, v2);
			ThrowIfError();
		}
	}

	public void Uniform3(string name, float v0, float v1, float v2)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, v0, v1, v2);
	}

	public void Uniform3(int location, ReadOnlySpan<ValueTuple<float, float, float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform3(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<float, float, float>, float>(value));
			ThrowIfError();
		}
	}

	public void Uniform3(string name, ReadOnlySpan<ValueTuple<float, float, float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, value);
	}

	public void Uniform3(int location, params ValueTuple<float, float, float>[] value)
	{
		Uniform3(location, value.AsSpan());
	}

	public void Uniform3(string name, params ValueTuple<float, float, float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, value);
	}

	public void Uniform3(int location, Vector3D<float> vector)
	{
		Uniform3(
			location,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform3(string name, Vector3D<float> vector)
	{
		Uniform3(
			name,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform3(int location, ReadOnlySpan<Vector3D<float>> value)
	{
		Uniform3(location, MemoryMarshal.Cast<Vector3D<float>, ValueTuple<float, float, float>>(value));
	}

	public void Uniform3(string name, ReadOnlySpan<Vector3D<float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, value);
	}

	public void Uniform3(int location, params Vector3D<float>[] value)
	{
		Uniform3(location, value.AsSpan());
	}

	public void Uniform3(string name, params Vector3D<float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, value);
	}

	public void Uniform4(int location, float v0, float v1, float v2, float v3)
	{
		lock (GL)
		{
			GL.ProgramUniform4(Handle, location, v0, v1, v2, v3);
			ThrowIfError();
		}
	}

	public void Uniform4(string name, float v0, float v1, float v2, float v3)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, v0, v1, v2, v3);
	}

	public void Uniform4(int location, ReadOnlySpan<ValueTuple<float, float, float, float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform4(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<float, float, float, float>, float>(value));
			ThrowIfError();
		}
	}

	public void Uniform4(string name, ReadOnlySpan<ValueTuple<float, float, float, float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, value);
	}

	public void Uniform4(int location, params ValueTuple<float, float, float, float>[] value)
	{
		Uniform4(location, value.AsSpan());
	}

	public void Uniform4(string name, params ValueTuple<float, float, float, float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, value);
	}

	public void Uniform4(int location, Vector4D<float> vector)
	{
		Uniform4(
			location,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform4(string name, Vector4D<float> vector)
	{
		Uniform4(
			name,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform4(int location, ReadOnlySpan<Vector4D<float>> value)
	{
		Uniform4(location, MemoryMarshal.Cast<Vector4D<float>, ValueTuple<float, float, float, float>>(value));
	}

	public void Uniform4(string name, ReadOnlySpan<Vector4D<float>> value)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, value);
	}

	public void Uniform4(int location, params Vector4D<float>[] value)
	{
		Uniform4(location, value.AsSpan());
	}

	public void Uniform4(string name, params Vector4D<float>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, value);
	}

	public void Uniform2(int location, Vector2 vector)
	{
		Uniform2(
			location,
			vector.X,
			vector.Y);
	}

	public void Uniform2(string name, Vector2 vector)
	{
		Uniform2(
			name,
			vector.X,
			vector.Y);
	}

	public void Uniform2(int location, ReadOnlySpan<Vector2> value)
	{
		Uniform2(location, MemoryMarshal.Cast<Vector2, ValueTuple<float, float>>(value));
	}

	public void Uniform2(string name, ReadOnlySpan<Vector2> value)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, value);
	}

	public void Uniform2(int location, params Vector2[] value)
	{
		Uniform2(location, value.AsSpan());
	}

	public void Uniform2(string name, params Vector2[] value)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, value);
	}

	public void Uniform3(int location, Vector3 vector)
	{
		Uniform3(
			location,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform3(string name, Vector3 vector)
	{
		Uniform3(
			name,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform3(int location, ReadOnlySpan<Vector3> value)
	{
		Uniform3(location, MemoryMarshal.Cast<Vector3, ValueTuple<float, float, float>>(value));
	}

	public void Uniform3(string name, ReadOnlySpan<Vector3> value)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, value);
	}

	public void Uniform3(int location, params Vector3[] value)
	{
		Uniform3(location, value.AsSpan());
	}

	public void Uniform3(string name, params Vector3[] value)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, value);
	}

	public void Uniform4(int location, Vector4 vector)
	{
		Uniform4(
			location,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform4(string name, Vector4 vector)
	{
		Uniform4(
			name,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform4(int location, ReadOnlySpan<Vector4> value)
	{
		Uniform4(location, MemoryMarshal.Cast<Vector4, ValueTuple<float, float, float, float>>(value));
	}

	public void Uniform4(string name, ReadOnlySpan<Vector4> value)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, value);
	}

	public void Uniform4(int location, params Vector4[] value)
	{
		Uniform4(location, value.AsSpan());
	}

	public void Uniform4(string name, params Vector4[] value)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, value);
	}

	public void Uniform1(int location, double v0)
	{
		lock (GL)
		{
			GL.ProgramUniform1(Handle, location, v0);
			ThrowIfError();
		}
	}

	public void Uniform1(string name, double v0)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, v0);
	}

	public void Uniform1(int location, ReadOnlySpan<double> value)
	{
		lock (GL)
		{
			GL.ProgramUniform1(Handle, location, value);
			ThrowIfError();
		}
	}

	public void Uniform1(string name, ReadOnlySpan<double> value)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, value);
	}

	public void Uniform1(int location, params double[] value)
	{
		Uniform1(location, value.AsSpan());
	}

	public void Uniform1(string name, params double[] value)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform1(int location, ReadOnlySpan<ValueTuple<double>> value)
	{
		ReadOnlySpan<double> value1 = MemoryMarshal.Cast<ValueTuple<double>, double>(value);
		Uniform1(location, value1);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform1(string name, ReadOnlySpan<ValueTuple<double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, value);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform1(int location, params ValueTuple<double>[] value)
	{
		Uniform1(location, value.AsSpan());
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Uniform1(string name, params ValueTuple<double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform1(location, value);
	}

	public void Uniform2(int location, double v0, double v1)
	{
		lock (GL)
		{
			GL.ProgramUniform2(Handle, location, v0, v1);
			ThrowIfError();
		}
	}

	public void Uniform2(string name, double v0, double v1)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, v0, v1);
	}

	public void Uniform2(int location, ReadOnlySpan<ValueTuple<double, double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform2(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<double, double>, double>(value));
			ThrowIfError();
		}
	}

	public void Uniform2(string name, ReadOnlySpan<ValueTuple<double, double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, value);
	}

	public void Uniform2(int location, params ValueTuple<double, double>[] value)
	{
		Uniform2(location, value.AsSpan());
	}

	public void Uniform2(string name, params ValueTuple<double, double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, value);
	}

	public void Uniform2(int location, Vector2D<double> vector)
	{
		Uniform2(
			location,
			vector.X,
			vector.Y);
	}

	public void Uniform2(string name, Vector2D<double> vector)
	{
		Uniform2(
			name,
			vector.X,
			vector.Y);
	}

	public void Uniform2(int location, ReadOnlySpan<Vector2D<double>> value)
	{
		Uniform2(location, MemoryMarshal.Cast<Vector2D<double>, ValueTuple<double, double>>(value));
	}

	public void Uniform2(string name, ReadOnlySpan<Vector2D<double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, value);
	}

	public void Uniform2(int location, params Vector2D<double>[] value)
	{
		Uniform2(location, value.AsSpan());
	}

	public void Uniform2(string name, params Vector2D<double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform2(location, value);
	}

	public void Uniform3(int location, double v0, double v1, double v2)
	{
		lock (GL)
		{
			GL.ProgramUniform3(Handle, location, v0, v1, v2);
			ThrowIfError();
		}
	}

	public void Uniform3(string name, double v0, double v1, double v2)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, v0, v1, v2);
	}

	public void Uniform3(int location, ReadOnlySpan<ValueTuple<double, double, double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform3(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<double, double, double>, double>(value));
			ThrowIfError();
		}
	}

	public void Uniform3(string name, ReadOnlySpan<ValueTuple<double, double, double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, value);
	}

	public void Uniform3(int location, params ValueTuple<double, double, double>[] value)
	{
		Uniform3(location, value.AsSpan());
	}

	public void Uniform3(string name, params ValueTuple<double, double, double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, value);
	}

	public void Uniform3(int location, Vector3D<double> vector)
	{
		Uniform3(
			location,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform3(string name, Vector3D<double> vector)
	{
		Uniform3(
			name,
			vector.X,
			vector.Y,
			vector.Z);
	}

	public void Uniform3(int location, ReadOnlySpan<Vector3D<double>> value)
	{
		Uniform3(location, MemoryMarshal.Cast<Vector3D<double>, ValueTuple<double, double, double>>(value));
	}

	public void Uniform3(string name, ReadOnlySpan<Vector3D<double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, value);
	}

	public void Uniform3(int location, params Vector3D<double>[] value)
	{
		Uniform3(location, value.AsSpan());
	}

	public void Uniform3(string name, params Vector3D<double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform3(location, value);
	}

	public void Uniform4(int location, double v0, double v1, double v2, double v3)
	{
		lock (GL)
		{
			GL.ProgramUniform4(Handle, location, v0, v1, v2, v3);
			ThrowIfError();
		}
	}

	public void Uniform4(string name, double v0, double v1, double v2, double v3)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, v0, v1, v2, v3);
	}

	public void Uniform4(int location, ReadOnlySpan<ValueTuple<double, double, double, double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniform4(Handle, location, (uint)value.Length, MemoryMarshal.Cast<ValueTuple<double, double, double, double>, double>(value));
			ThrowIfError();
		}
	}

	public void Uniform4(string name, ReadOnlySpan<ValueTuple<double, double, double, double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, value);
	}

	public void Uniform4(int location, params ValueTuple<double, double, double, double>[] value)
	{
		Uniform4(location, value.AsSpan());
	}

	public void Uniform4(string name, params ValueTuple<double, double, double, double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, value);
	}

	public void Uniform4(int location, Vector4D<double> vector)
	{
		Uniform4(
			location,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform4(string name, Vector4D<double> vector)
	{
		Uniform4(
			name,
			vector.X,
			vector.Y,
			vector.Z,
			vector.W);
	}

	public void Uniform4(int location, ReadOnlySpan<Vector4D<double>> value)
	{
		Uniform4(location, MemoryMarshal.Cast<Vector4D<double>, ValueTuple<double, double, double, double>>(value));
	}

	public void Uniform4(string name, ReadOnlySpan<Vector4D<double>> value)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, value);
	}

	public void Uniform4(int location, params Vector4D<double>[] value)
	{
		Uniform4(location, value.AsSpan());
	}

	public void Uniform4(string name, params Vector4D<double>[] value)
	{
		int location = GetUniformLocation(name);
		Uniform4(location, value);
	}

	public void UniformMatrix2(int location, ReadOnlySpan<Matrix2X2<float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix2(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix2X2<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix2(string name, ReadOnlySpan<Matrix2X2<float>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2(location, value);
	}

	public unsafe void UniformMatrix2(int location, params Matrix2X2<float>[] value)
	{
		UniformMatrix2(location, value.AsSpan());
	}

	public unsafe void UniformMatrix2(string name, params Matrix2X2<float>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2(location, value);
	}

	public void UniformMatrix2x3(int location, ReadOnlySpan<Matrix2X3<float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix2x3(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix2X3<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix2x3(string name, ReadOnlySpan<Matrix2X3<float>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2x3(location, value);
	}

	public unsafe void UniformMatrix2x3(int location, params Matrix2X3<float>[] value)
	{
		UniformMatrix2x3(location, value.AsSpan());
	}

	public unsafe void UniformMatrix2x3(string name, params Matrix2X3<float>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2x3(location, value);
	}

	public void UniformMatrix2x4(int location, ReadOnlySpan<Matrix2X4<float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix2x4(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix2X4<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix2x4(string name, ReadOnlySpan<Matrix2X4<float>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2x4(location, value);
	}

	public unsafe void UniformMatrix2x4(int location, params Matrix2X4<float>[] value)
	{
		UniformMatrix2x4(location, value.AsSpan());
	}

	public unsafe void UniformMatrix2x4(string name, params Matrix2X4<float>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2x4(location, value);
	}

	public void UniformMatrix3x2(int location, ReadOnlySpan<Matrix3X2<float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix3x2(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix3X2<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix3x2(string name, ReadOnlySpan<Matrix3X2<float>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3x2(location, value);
	}

	public unsafe void UniformMatrix3x2(int location, params Matrix3X2<float>[] value)
	{
		UniformMatrix3x2(location, value.AsSpan());
	}

	public unsafe void UniformMatrix3x2(string name, params Matrix3X2<float>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3x2(location, value);
	}

	public void UniformMatrix3(int location, ReadOnlySpan<Matrix3X3<float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix3(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix3X3<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix3(string name, ReadOnlySpan<Matrix3X3<float>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3(location, value);
	}

	public unsafe void UniformMatrix3(int location, params Matrix3X3<float>[] value)
	{
		UniformMatrix3(location, value.AsSpan());
	}

	public unsafe void UniformMatrix3(string name, params Matrix3X3<float>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3(location, value);
	}

	public void UniformMatrix3x4(int location, ReadOnlySpan<Matrix3X4<float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix3x4(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix3X4<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix3x4(string name, ReadOnlySpan<Matrix3X4<float>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3x4(location, value);
	}

	public unsafe void UniformMatrix3x4(int location, params Matrix3X4<float>[] value)
	{
		UniformMatrix3x4(location, value.AsSpan());
	}

	public unsafe void UniformMatrix3x4(string name, params Matrix3X4<float>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3x4(location, value);
	}

	public void UniformMatrix4x2(int location, ReadOnlySpan<Matrix4X2<float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix4x2(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix4X2<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix4x2(string name, ReadOnlySpan<Matrix4X2<float>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4x2(location, value);
	}

	public unsafe void UniformMatrix4x2(int location, params Matrix4X2<float>[] value)
	{
		UniformMatrix4x2(location, value.AsSpan());
	}

	public unsafe void UniformMatrix4x2(string name, params Matrix4X2<float>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4x2(location, value);
	}

	public void UniformMatrix4x3(int location, ReadOnlySpan<Matrix4X3<float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix4x3(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix4X3<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix4x3(string name, ReadOnlySpan<Matrix4X3<float>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4x3(location, value);
	}

	public unsafe void UniformMatrix4x3(int location, params Matrix4X3<float>[] value)
	{
		UniformMatrix4x3(location, value.AsSpan());
	}

	public unsafe void UniformMatrix4x3(string name, params Matrix4X3<float>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4x3(location, value);
	}

	public void UniformMatrix4(int location, ReadOnlySpan<Matrix4X4<float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix4(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix4X4<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix4(string name, ReadOnlySpan<Matrix4X4<float>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4(location, value);
	}

	public unsafe void UniformMatrix4(int location, params Matrix4X4<float>[] value)
	{
		UniformMatrix4(location, value.AsSpan());
	}

	public unsafe void UniformMatrix4(string name, params Matrix4X4<float>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4(location, value);
	}

	public void UniformMatrix2Transpose(int location, ReadOnlySpan<Matrix2X2<float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix2(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix2X2<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix2Transpose(string name, ReadOnlySpan<Matrix2X2<float>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2Transpose(location, value);
	}

	public unsafe void UniformMatrix2Transpose(int location, params Matrix2X2<float>[] value)
	{
		UniformMatrix2Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix2Transpose(string name, params Matrix2X2<float>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2Transpose(location, value);
	}
	public void UniformMatrix3x2Transpose(int location, ReadOnlySpan<Matrix2X3<float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix3x2(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix2X3<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix3x2Transpose(string name, ReadOnlySpan<Matrix2X3<float>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3x2Transpose(location, value);
	}

	public unsafe void UniformMatrix3x2Transpose(int location, params Matrix2X3<float>[] value)
	{
		UniformMatrix3x2Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix3x2Transpose(string name, params Matrix2X3<float>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3x2Transpose(location, value);
	}
	public void UniformMatrix4x2Transpose(int location, ReadOnlySpan<Matrix2X4<float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix4x2(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix2X4<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix4x2Transpose(string name, ReadOnlySpan<Matrix2X4<float>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4x2Transpose(location, value);
	}

	public unsafe void UniformMatrix4x2Transpose(int location, params Matrix2X4<float>[] value)
	{
		UniformMatrix4x2Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix4x2Transpose(string name, params Matrix2X4<float>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4x2Transpose(location, value);
	}
	public void UniformMatrix2x3Transpose(int location, ReadOnlySpan<Matrix3X2<float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix2x3(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix3X2<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix2x3Transpose(string name, ReadOnlySpan<Matrix3X2<float>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2x3Transpose(location, value);
	}

	public unsafe void UniformMatrix2x3Transpose(int location, params Matrix3X2<float>[] value)
	{
		UniformMatrix2x3Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix2x3Transpose(string name, params Matrix3X2<float>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2x3Transpose(location, value);
	}
	public void UniformMatrix3Transpose(int location, ReadOnlySpan<Matrix3X3<float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix3(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix3X3<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix3Transpose(string name, ReadOnlySpan<Matrix3X3<float>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3Transpose(location, value);
	}

	public unsafe void UniformMatrix3Transpose(int location, params Matrix3X3<float>[] value)
	{
		UniformMatrix3Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix3Transpose(string name, params Matrix3X3<float>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3Transpose(location, value);
	}
	public void UniformMatrix4x3Transpose(int location, ReadOnlySpan<Matrix3X4<float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix4x3(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix3X4<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix4x3Transpose(string name, ReadOnlySpan<Matrix3X4<float>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4x3Transpose(location, value);
	}

	public unsafe void UniformMatrix4x3Transpose(int location, params Matrix3X4<float>[] value)
	{
		UniformMatrix4x3Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix4x3Transpose(string name, params Matrix3X4<float>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4x3Transpose(location, value);
	}
	public void UniformMatrix2x4Transpose(int location, ReadOnlySpan<Matrix4X2<float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix2x4(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix4X2<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix2x4Transpose(string name, ReadOnlySpan<Matrix4X2<float>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2x4Transpose(location, value);
	}

	public unsafe void UniformMatrix2x4Transpose(int location, params Matrix4X2<float>[] value)
	{
		UniformMatrix2x4Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix2x4Transpose(string name, params Matrix4X2<float>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2x4Transpose(location, value);
	}
	public void UniformMatrix3x4Transpose(int location, ReadOnlySpan<Matrix4X3<float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix3x4(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix4X3<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix3x4Transpose(string name, ReadOnlySpan<Matrix4X3<float>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3x4Transpose(location, value);
	}

	public unsafe void UniformMatrix3x4Transpose(int location, params Matrix4X3<float>[] value)
	{
		UniformMatrix3x4Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix3x4Transpose(string name, params Matrix4X3<float>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3x4Transpose(location, value);
	}
	public void UniformMatrix4Transpose(int location, ReadOnlySpan<Matrix4X4<float>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix4(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix4X4<float>, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix4Transpose(string name, ReadOnlySpan<Matrix4X4<float>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4Transpose(location, value);
	}

	public unsafe void UniformMatrix4Transpose(int location, params Matrix4X4<float>[] value)
	{
		UniformMatrix4Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix4Transpose(string name, params Matrix4X4<float>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4Transpose(location, value);
	}
	public void UniformMatrix3x2(int location, ReadOnlySpan<Matrix3x2> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix3x2(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix3x2, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix3x2(string name, ReadOnlySpan<Matrix3x2> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3x2(location, value);
	}

	public unsafe void UniformMatrix3x2(int location, params Matrix3x2[] value)
	{
		UniformMatrix3x2(location, value.AsSpan());
	}

	public unsafe void UniformMatrix3x2(string name, params Matrix3x2[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3x2(location, value);
	}

	public void UniformMatrix2x3Transpose(int location, ReadOnlySpan<Matrix3x2> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix2x3(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix3x2, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix2x3Transpose(string name, ReadOnlySpan<Matrix3x2> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2x3Transpose(location, value);
	}

	public unsafe void UniformMatrix2x3Transpose(int location, params Matrix3x2[] value)
	{
		UniformMatrix2x3Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix2x3Transpose(string name, params Matrix3x2[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2x3Transpose(location, value);
	}
	public void UniformMatrix4(int location, ReadOnlySpan<Matrix4x4> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix4(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix4x4, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix4(string name, ReadOnlySpan<Matrix4x4> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4(location, value);
	}

	public unsafe void UniformMatrix4(int location, params Matrix4x4[] value)
	{
		UniformMatrix4(location, value.AsSpan());
	}

	public unsafe void UniformMatrix4(string name, params Matrix4x4[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4(location, value);
	}

	public void UniformMatrix4Transpose(int location, ReadOnlySpan<Matrix4x4> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix4(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix4x4, float>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix4Transpose(string name, ReadOnlySpan<Matrix4x4> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4Transpose(location, value);
	}

	public unsafe void UniformMatrix4Transpose(int location, params Matrix4x4[] value)
	{
		UniformMatrix4Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix4Transpose(string name, params Matrix4x4[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4Transpose(location, value);
	}
	public void UniformMatrix2(int location, ReadOnlySpan<Matrix2X2<double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix2(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix2X2<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix2(string name, ReadOnlySpan<Matrix2X2<double>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2(location, value);
	}

	public unsafe void UniformMatrix2(int location, params Matrix2X2<double>[] value)
	{
		UniformMatrix2(location, value.AsSpan());
	}

	public unsafe void UniformMatrix2(string name, params Matrix2X2<double>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2(location, value);
	}

	public void UniformMatrix2x3(int location, ReadOnlySpan<Matrix2X3<double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix2x3(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix2X3<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix2x3(string name, ReadOnlySpan<Matrix2X3<double>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2x3(location, value);
	}

	public unsafe void UniformMatrix2x3(int location, params Matrix2X3<double>[] value)
	{
		UniformMatrix2x3(location, value.AsSpan());
	}

	public unsafe void UniformMatrix2x3(string name, params Matrix2X3<double>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2x3(location, value);
	}

	public void UniformMatrix2x4(int location, ReadOnlySpan<Matrix2X4<double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix2x4(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix2X4<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix2x4(string name, ReadOnlySpan<Matrix2X4<double>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2x4(location, value);
	}

	public unsafe void UniformMatrix2x4(int location, params Matrix2X4<double>[] value)
	{
		UniformMatrix2x4(location, value.AsSpan());
	}

	public unsafe void UniformMatrix2x4(string name, params Matrix2X4<double>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2x4(location, value);
	}

	public void UniformMatrix3x2(int location, ReadOnlySpan<Matrix3X2<double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix3x2(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix3X2<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix3x2(string name, ReadOnlySpan<Matrix3X2<double>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3x2(location, value);
	}

	public unsafe void UniformMatrix3x2(int location, params Matrix3X2<double>[] value)
	{
		UniformMatrix3x2(location, value.AsSpan());
	}

	public unsafe void UniformMatrix3x2(string name, params Matrix3X2<double>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3x2(location, value);
	}

	public void UniformMatrix3(int location, ReadOnlySpan<Matrix3X3<double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix3(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix3X3<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix3(string name, ReadOnlySpan<Matrix3X3<double>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3(location, value);
	}

	public unsafe void UniformMatrix3(int location, params Matrix3X3<double>[] value)
	{
		UniformMatrix3(location, value.AsSpan());
	}

	public unsafe void UniformMatrix3(string name, params Matrix3X3<double>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3(location, value);
	}

	public void UniformMatrix3x4(int location, ReadOnlySpan<Matrix3X4<double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix3x4(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix3X4<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix3x4(string name, ReadOnlySpan<Matrix3X4<double>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3x4(location, value);
	}

	public unsafe void UniformMatrix3x4(int location, params Matrix3X4<double>[] value)
	{
		UniformMatrix3x4(location, value.AsSpan());
	}

	public unsafe void UniformMatrix3x4(string name, params Matrix3X4<double>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3x4(location, value);
	}

	public void UniformMatrix4x2(int location, ReadOnlySpan<Matrix4X2<double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix4x2(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix4X2<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix4x2(string name, ReadOnlySpan<Matrix4X2<double>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4x2(location, value);
	}

	public unsafe void UniformMatrix4x2(int location, params Matrix4X2<double>[] value)
	{
		UniformMatrix4x2(location, value.AsSpan());
	}

	public unsafe void UniformMatrix4x2(string name, params Matrix4X2<double>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4x2(location, value);
	}

	public void UniformMatrix4x3(int location, ReadOnlySpan<Matrix4X3<double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix4x3(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix4X3<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix4x3(string name, ReadOnlySpan<Matrix4X3<double>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4x3(location, value);
	}

	public unsafe void UniformMatrix4x3(int location, params Matrix4X3<double>[] value)
	{
		UniformMatrix4x3(location, value.AsSpan());
	}

	public unsafe void UniformMatrix4x3(string name, params Matrix4X3<double>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4x3(location, value);
	}

	public void UniformMatrix4(int location, ReadOnlySpan<Matrix4X4<double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix4(
				Handle,
				location,
				(uint)value.Length,
				false,
				MemoryMarshal.Cast<Matrix4X4<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix4(string name, ReadOnlySpan<Matrix4X4<double>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4(location, value);
	}

	public unsafe void UniformMatrix4(int location, params Matrix4X4<double>[] value)
	{
		UniformMatrix4(location, value.AsSpan());
	}

	public unsafe void UniformMatrix4(string name, params Matrix4X4<double>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4(location, value);
	}

	public void UniformMatrix2Transpose(int location, ReadOnlySpan<Matrix2X2<double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix2(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix2X2<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix2Transpose(string name, ReadOnlySpan<Matrix2X2<double>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2Transpose(location, value);
	}

	public unsafe void UniformMatrix2Transpose(int location, params Matrix2X2<double>[] value)
	{
		UniformMatrix2Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix2Transpose(string name, params Matrix2X2<double>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2Transpose(location, value);
	}
	public void UniformMatrix3x2Transpose(int location, ReadOnlySpan<Matrix2X3<double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix3x2(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix2X3<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix3x2Transpose(string name, ReadOnlySpan<Matrix2X3<double>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3x2Transpose(location, value);
	}

	public unsafe void UniformMatrix3x2Transpose(int location, params Matrix2X3<double>[] value)
	{
		UniformMatrix3x2Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix3x2Transpose(string name, params Matrix2X3<double>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3x2Transpose(location, value);
	}
	public void UniformMatrix4x2Transpose(int location, ReadOnlySpan<Matrix2X4<double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix4x2(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix2X4<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix4x2Transpose(string name, ReadOnlySpan<Matrix2X4<double>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4x2Transpose(location, value);
	}

	public unsafe void UniformMatrix4x2Transpose(int location, params Matrix2X4<double>[] value)
	{
		UniformMatrix4x2Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix4x2Transpose(string name, params Matrix2X4<double>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4x2Transpose(location, value);
	}
	public void UniformMatrix2x3Transpose(int location, ReadOnlySpan<Matrix3X2<double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix2x3(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix3X2<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix2x3Transpose(string name, ReadOnlySpan<Matrix3X2<double>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2x3Transpose(location, value);
	}

	public unsafe void UniformMatrix2x3Transpose(int location, params Matrix3X2<double>[] value)
	{
		UniformMatrix2x3Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix2x3Transpose(string name, params Matrix3X2<double>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2x3Transpose(location, value);
	}
	public void UniformMatrix3Transpose(int location, ReadOnlySpan<Matrix3X3<double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix3(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix3X3<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix3Transpose(string name, ReadOnlySpan<Matrix3X3<double>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3Transpose(location, value);
	}

	public unsafe void UniformMatrix3Transpose(int location, params Matrix3X3<double>[] value)
	{
		UniformMatrix3Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix3Transpose(string name, params Matrix3X3<double>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3Transpose(location, value);
	}
	public void UniformMatrix4x3Transpose(int location, ReadOnlySpan<Matrix3X4<double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix4x3(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix3X4<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix4x3Transpose(string name, ReadOnlySpan<Matrix3X4<double>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4x3Transpose(location, value);
	}

	public unsafe void UniformMatrix4x3Transpose(int location, params Matrix3X4<double>[] value)
	{
		UniformMatrix4x3Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix4x3Transpose(string name, params Matrix3X4<double>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4x3Transpose(location, value);
	}
	public void UniformMatrix2x4Transpose(int location, ReadOnlySpan<Matrix4X2<double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix2x4(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix4X2<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix2x4Transpose(string name, ReadOnlySpan<Matrix4X2<double>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2x4Transpose(location, value);
	}

	public unsafe void UniformMatrix2x4Transpose(int location, params Matrix4X2<double>[] value)
	{
		UniformMatrix2x4Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix2x4Transpose(string name, params Matrix4X2<double>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix2x4Transpose(location, value);
	}
	public void UniformMatrix3x4Transpose(int location, ReadOnlySpan<Matrix4X3<double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix3x4(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix4X3<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix3x4Transpose(string name, ReadOnlySpan<Matrix4X3<double>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3x4Transpose(location, value);
	}

	public unsafe void UniformMatrix3x4Transpose(int location, params Matrix4X3<double>[] value)
	{
		UniformMatrix3x4Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix3x4Transpose(string name, params Matrix4X3<double>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix3x4Transpose(location, value);
	}
	public void UniformMatrix4Transpose(int location, ReadOnlySpan<Matrix4X4<double>> value)
	{
		lock (GL)
		{
			GL.ProgramUniformMatrix4(
				Handle,
				location,
				(uint)value.Length,
				true,
				MemoryMarshal.Cast<Matrix4X4<double>, double>(value));
			ThrowIfError();
		}
	}

	public unsafe void UniformMatrix4Transpose(string name, ReadOnlySpan<Matrix4X4<double>> value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4Transpose(location, value);
	}

	public unsafe void UniformMatrix4Transpose(int location, params Matrix4X4<double>[] value)
	{
		UniformMatrix4Transpose(location, value.AsSpan());
	}

	public unsafe void UniformMatrix4Transpose(string name, params Matrix4X4<double>[] value)
	{
		int location = GetUniformLocation(name);
		UniformMatrix4Transpose(location, value);
	}
}
