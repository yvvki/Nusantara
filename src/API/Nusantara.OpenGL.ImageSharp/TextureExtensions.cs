// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using Silk.NET.OpenGL;

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Nusantara.OpenGL.ImageSharp;

public static class TextureExtensions
{
	public static Texture CreateFromImage(
		GL gl,
		Image<Rgba32> image!!,
		TextureWrapMode wrapS = TextureWrapMode.Repeat,
		TextureWrapMode wrapT = TextureWrapMode.Repeat,
		TextureMinFilter minFiler = TextureMinFilter.LinearMipmapLinear,
		TextureMagFilter magFiler = TextureMagFilter.Linear)
	{
		Texture texture = new(gl, TextureTarget.Texture2D);

		texture.Parameter(TextureParameterName.TextureWrapS, (int)wrapS);
		texture.Parameter(TextureParameterName.TextureWrapT, (int)wrapS);
		texture.Parameter(TextureParameterName.TextureMinFilter, (int)minFiler);
		texture.Parameter(TextureParameterName.TextureMagFilter, (int)magFiler);

		texture.Storage2D(1, SizedInternalFormat.Rgba8, (uint)image.Width, (uint)image.Height);

		image.ProcessPixelRows(accessor =>
		{
			for (int y = 0; y < accessor.Height; y++)
			{
				ReadOnlySpan<Rgba32> row = accessor.GetRowSpan(y);
				texture.SubImage2D(
					0,
					0,
					y,
					(uint)image.Width,
					(uint)image.Height,
					PixelFormat.Rgba,
					PixelType.UnsignedByte,
					row);
			}
		});

		texture.GenerateMipmap();

		return texture;
	}

	public static void Storage2D<TPixel>(
		this Texture @this,
		uint levels,
		Image<TPixel> image)
		where TPixel : unmanaged, IPixel<TPixel>
	{
		static SizedInternalFormat Convert(Type type)
		{
			return type switch
			{
				Type when type == typeof(A8) => SizedInternalFormat.Alpha8Ext,
				Type when type == typeof(Abgr32) => SizedInternalFormat.Rgba8,
				Type when type == typeof(Argb32) => SizedInternalFormat.Rgba8,
				Type when type == typeof(Bgr24) => SizedInternalFormat.Rgb8,
				Type when type == typeof(Bgr565) => SizedInternalFormat.Rgb565,
				Type when type == typeof(Bgra32) => SizedInternalFormat.Rgba8,
				Type when type == typeof(Bgra4444) => SizedInternalFormat.Rgba4,
				Type when type == typeof(Bgra5551) => SizedInternalFormat.Rgba4, // same size as above
				Type when type == typeof(Byte4) => SizedInternalFormat.Rgba8, // 4 times byte (8)
				Type when type == typeof(HalfSingle) => SizedInternalFormat.R16f,
				Type when type == typeof(HalfVector2) => SizedInternalFormat.RG16f,
				Type when type == typeof(HalfVector4) => SizedInternalFormat.Rgba16f,
				Type when type == typeof(L16) => SizedInternalFormat.Luminance16uiExt,
				Type when type == typeof(L8) => SizedInternalFormat.Luminance8uiExt,
				Type when type == typeof(La16) => SizedInternalFormat.LuminanceAlpha16uiExt,
				Type when type == typeof(La32) => SizedInternalFormat.LuminanceAlpha32uiExt,
				Type when type == typeof(NormalizedByte2) => SizedInternalFormat.RG8,
				Type when type == typeof(NormalizedByte4) => SizedInternalFormat.Rgba8,
				Type when type == typeof(NormalizedShort2) => SizedInternalFormat.RG16,
				Type when type == typeof(NormalizedShort4) => SizedInternalFormat.Rgba16,
				Type when type == typeof(Rg32) => SizedInternalFormat.RG16,
				Type when type == typeof(Rgb24) => SizedInternalFormat.Rgb8,
				Type when type == typeof(Rgb48) => SizedInternalFormat.Rgb16,
				Type when type == typeof(Rgba1010102) => SizedInternalFormat.Rgb10A2,
				Type when type == typeof(Rgba32) => SizedInternalFormat.Rgba8,
				Type when type == typeof(Rgba64) => SizedInternalFormat.Rgba16,
				Type when type == typeof(RgbaVector) => SizedInternalFormat.Rgba32f,
				Type when type == typeof(Short2) => SizedInternalFormat.RG16,
				Type when type == typeof(Short4) => SizedInternalFormat.Rgba16,
				_ => throw new NotSupportedException()
			};
		}

		SizedInternalFormat format = Convert(typeof(TPixel));

		@this.Storage2D(
			levels,
			format,
			(uint)image.Width,
			(uint)image.Height);
	}
}
