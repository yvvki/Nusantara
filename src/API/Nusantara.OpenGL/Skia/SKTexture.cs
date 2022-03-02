// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using Silk.NET.OpenGL;

using SkiaSharp;

namespace Nusantara.OpenGL.Skia;

public class SKTexture : Texture
{
	internal SKTexture(GL gl, uint handle) : base(gl, handle) { }

	internal SKTexture(GL gl, GLEnum target) : base(gl, target) { }

	public SKTexture(GL gl) : base(gl, GLEnum.Texture2D) { }

	public static SKTexture FromBitmap(
		GL gl,
		SKBitmap bitmap,
		bool flipVertically = true,
		TextureWrapMode wrapS = TextureWrapMode.Repeat,
		TextureWrapMode wrapT = TextureWrapMode.Repeat,
		TextureMinFilter minFiler = TextureMinFilter.LinearMipmapLinear,
		TextureMagFilter magFiler = TextureMagFilter.Linear)
	{
		SKTexture texture = new(gl);
		ArgumentNullException.ThrowIfNull(bitmap);

		if (flipVertically)
		{
			SKBitmap flipped = new(bitmap.Info);
			using (SKCanvas canvas = new(flipped))
			{
				canvas.Scale(1, -1, 0, 0);
				canvas.Translate(0, -flipped.Height);
				canvas.DrawBitmap(bitmap, 0, 0);
			}

			bitmap = flipped;
		}

		texture.Parameter(TextureParameterName.TextureWrapS, (int)wrapS);
		texture.Parameter(TextureParameterName.TextureWrapT, (int)wrapS);
		texture.Parameter(TextureParameterName.TextureMinFilter, (int)minFiler);
		texture.Parameter(TextureParameterName.TextureMagFilter, (int)magFiler);

		texture.Storage2D(1, bitmap.Info);
		texture.SubImage2D(0, 0, 0, bitmap);

		texture.GenerateMipmap();

		if (flipVertically)
		{
			bitmap.Dispose();
		}

		return texture;
	}

	public void Storage2D(uint levels, SKImageInfo info)
	{
		static SizedInternalFormat Convert(SKColorType colorType)
		{
			return colorType switch
			{
				SKColorType.Alpha8 => SizedInternalFormat.Alpha8Ext,
				SKColorType.Rgb565 => SizedInternalFormat.Rgb565,
				SKColorType.Argb4444 => SizedInternalFormat.Rgba4,
				SKColorType.Rgba8888 => SizedInternalFormat.Rgba8,
				SKColorType.Rgb888x => SizedInternalFormat.Rgb8,
				SKColorType.Bgra8888 => SizedInternalFormat.Rgba8,
				SKColorType.Rgba1010102 => SizedInternalFormat.Rgb10A2,
				SKColorType.Rgb101010x => SizedInternalFormat.Rgb10,
				SKColorType.Gray8 => SizedInternalFormat.Luminance8Ext,
				SKColorType.RgbaF16 => SizedInternalFormat.Rgba16f,
				SKColorType.RgbaF16Clamped => SizedInternalFormat.Rgba16f,
				SKColorType.RgbaF32 => SizedInternalFormat.Rgba32f,
				SKColorType.Rg88 => SizedInternalFormat.RG8,
				SKColorType.AlphaF16 => SizedInternalFormat.Alpha16Ext,
				SKColorType.RgF16 => SizedInternalFormat.RG16f,
				SKColorType.Alpha16 => SizedInternalFormat.Alpha16Ext,
				SKColorType.Rg1616 => SizedInternalFormat.RG16,
				SKColorType.Rgba16161616 => SizedInternalFormat.Rgba16,
				_ => throw new NotSupportedException()
			};
		}

		SizedInternalFormat format = Convert(info.ColorType);

		Storage2D(
			levels,
			format,
			(uint)info.Width,
			(uint)info.Height);
	}

	public unsafe void SubImage2D(
		int level,
		int xoffset,
		int yoffset,
		SKBitmap bitmap)
	{
		static (PixelFormat, GLEnum) Convert(SKColorType colorType)
		{
			return colorType switch
			{
				SKColorType.Alpha8 => (PixelFormat.Alpha, GLEnum.UnsignedByte),
				SKColorType.Rgb565 => (PixelFormat.Rgb, GLEnum.UnsignedShort565Rev),
				SKColorType.Argb4444 => (PixelFormat.Rgba, GLEnum.UnsignedShort4444Rev),
				SKColorType.Rgba8888 => (PixelFormat.Rgba, GLEnum.UnsignedInt8888Rev),
				SKColorType.Rgb888x => (PixelFormat.Rgba, GLEnum.UnsignedInt8888Rev),
				SKColorType.Bgra8888 => (PixelFormat.Bgra, GLEnum.UnsignedInt8888Rev),
				SKColorType.Rgba1010102 => (PixelFormat.Rgba, GLEnum.UnsignedInt2101010Rev),
				SKColorType.Rgb101010x => (PixelFormat.Rgba, GLEnum.UnsignedInt2101010Rev),
				SKColorType.Gray8 => (PixelFormat.DepthComponent, GLEnum.UnsignedByte),
				SKColorType.RgbaF16 => (PixelFormat.Rgba, GLEnum.HalfFloat),
				SKColorType.RgbaF16Clamped => (PixelFormat.Rgba, GLEnum.HalfFloat),
				SKColorType.RgbaF32 => (PixelFormat.Rgba, GLEnum.Float),
				SKColorType.Rg88 => (PixelFormat.RG, GLEnum.UnsignedByte),
				SKColorType.AlphaF16 => (PixelFormat.Alpha, GLEnum.HalfFloat),
				SKColorType.RgF16 => (PixelFormat.RG, GLEnum.HalfFloat),
				SKColorType.Alpha16 => (PixelFormat.Alpha, GLEnum.UnsignedShort),
				SKColorType.Rg1616 => (PixelFormat.RG, GLEnum.UnsignedShort),
				SKColorType.Rgba16161616 => (PixelFormat.Rgba, GLEnum.UnsignedShort),
				_ => throw new NotSupportedException()
			};
		}

		(PixelFormat format, GLEnum type) = Convert(bitmap.ColorType);

		SubImage2D(
			level,
			xoffset,
			yoffset,
			(uint)bitmap.Width,
			(uint)bitmap.Height,
			(GLEnum)format,
			type,
			(void*)bitmap.GetPixels());
	}
}
