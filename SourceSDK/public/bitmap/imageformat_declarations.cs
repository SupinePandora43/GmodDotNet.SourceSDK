namespace GmodNET.SourceSDK.bitmap
{
	//TODO omit NORMAL_DECODE_?
	public enum NormalDecodeMode_t
	{
		NORMAL_DECODE_NONE = 0,
		NORMAL_DECODE_ATI2N = 1,
		NORMAL_DECODE_ATI2N_ALPHA = 2
	};
	public enum ImageFormat
	{
		/// <remarks>Use this image format if you want to perform tool operations on the texture</remarks>
		IMAGE_FORMAT_DEFAULT = -2,
		IMAGE_FORMAT_UNKNOWN = -1,
		IMAGE_FORMAT_RGBA8888 = 0,
		IMAGE_FORMAT_ABGR8888,
		IMAGE_FORMAT_RGB888,
		IMAGE_FORMAT_BGR888,
		IMAGE_FORMAT_RGB565,
		IMAGE_FORMAT_I8,
		IMAGE_FORMAT_IA88,
		IMAGE_FORMAT_P8,
		IMAGE_FORMAT_A8,
		IMAGE_FORMAT_RGB888_BLUESCREEN,
		IMAGE_FORMAT_BGR888_BLUESCREEN,
		IMAGE_FORMAT_ARGB8888,
		IMAGE_FORMAT_BGRA8888,
		IMAGE_FORMAT_DXT1,
		IMAGE_FORMAT_DXT3,
		IMAGE_FORMAT_DXT5,
		IMAGE_FORMAT_BGRX8888,
		IMAGE_FORMAT_BGR565,
		IMAGE_FORMAT_BGRX5551,
		IMAGE_FORMAT_BGRA4444,
		IMAGE_FORMAT_DXT1_ONEBITALPHA,
		IMAGE_FORMAT_BGRA5551,
		IMAGE_FORMAT_UV88,
		IMAGE_FORMAT_UVWQ8888,
		IMAGE_FORMAT_RGBA16161616F,
		IMAGE_FORMAT_RGBA16161616,
		IMAGE_FORMAT_UVLX8888,
		/// <summary>Single-channel 32-bit floating point</summary>
		IMAGE_FORMAT_R32F,
		/// <summary>NOTE: D3D9 does not have this format</summary>
		IMAGE_FORMAT_RGB323232F,
		IMAGE_FORMAT_RGBA32323232F,
		IMAGE_FORMAT_RG1616F,
		IMAGE_FORMAT_RG3232F,
		IMAGE_FORMAT_RGBX8888,

		/// <summary>Dummy format which takes no video memory</summary>
		IMAGE_FORMAT_NULL,

		// Compressed normal map formats
		IMAGE_FORMAT_ATI2N,         // One-surface ATI2N / DXN format
		IMAGE_FORMAT_ATI1N,         // Two-surface ATI1N format

		IMAGE_FORMAT_RGBA1010102,   // 10 bit-per component render targets
		IMAGE_FORMAT_BGRA1010102,
		IMAGE_FORMAT_R16F,          // 16 bit FP format

		// Depth-stencil texture formats
		IMAGE_FORMAT_D16,
		IMAGE_FORMAT_D15S1,
		IMAGE_FORMAT_D32,
		IMAGE_FORMAT_D24S8,
		IMAGE_FORMAT_LINEAR_D24S8,
		IMAGE_FORMAT_D24X8,
		IMAGE_FORMAT_D24X4S4,
		IMAGE_FORMAT_D24FS8,
		IMAGE_FORMAT_D16_SHADOW,    // Specific formats for shadow mapping
		IMAGE_FORMAT_D24X8_SHADOW,  // Specific formats for shadow mapping

		// supporting these specific formats as non-tiled for procedural cpu access (360-specific)
		IMAGE_FORMAT_LINEAR_BGRX8888,
		IMAGE_FORMAT_LINEAR_RGBA8888,
		IMAGE_FORMAT_LINEAR_ABGR8888,
		IMAGE_FORMAT_LINEAR_ARGB8888,
		IMAGE_FORMAT_LINEAR_BGRA8888,
		IMAGE_FORMAT_LINEAR_RGB888,
		IMAGE_FORMAT_LINEAR_BGR888,
		IMAGE_FORMAT_LINEAR_BGRX5551,
		IMAGE_FORMAT_LINEAR_I8,
		IMAGE_FORMAT_LINEAR_RGBA16161616,
		IMAGE_FORMAT_LINEAR_A8,
		IMAGE_FORMAT_LINEAR_DXT1,
		IMAGE_FORMAT_LINEAR_DXT3,
		IMAGE_FORMAT_LINEAR_DXT5,

		IMAGE_FORMAT_LE_BGRX8888,
		IMAGE_FORMAT_LE_BGRA8888,

		// these are used for runtime conversion to DXT1/5
		IMAGE_FORMAT_DXT1_RUNTIME,
		IMAGE_FORMAT_DXT5_RUNTIME,

		// special depth format
		IMAGE_FORMAT_INTZ,

		NUM_IMAGE_FORMATS
	}
	//TODO: dx image formats
}
