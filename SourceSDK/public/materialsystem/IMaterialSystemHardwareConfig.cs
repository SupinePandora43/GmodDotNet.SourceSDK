using GmodNET.SourceSDK.bitmap;
using System;
using System.Runtime.InteropServices;

namespace GmodNET.SourceSDK.materialsystem
{
	public enum VertexCompressionType_t
	{
		// This indicates an uninitialized VertexCompressionType_t value
		VERTEX_COMPRESSION_INVALID = unchecked((int)0xFFFFFFFF),

		// 'VERTEX_COMPRESSION_NONE' means that no elements of a vertex are compressed
		VERTEX_COMPRESSION_NONE = 0,

		// Currently (more stuff may be added as needed), 'VERTEX_COMPRESSION_ON' means:
		//  - if a vertex contains VERTEX_ELEMENT_NORMAL, this is compressed
		//    (see CVertexBuilder::CompressedNormal3f)
		//  - if a vertex contains VERTEX_ELEMENT_USERDATA4 (and a normal - together defining a tangent
		//    frame, with the binormal reconstructed in the vertex shader), this is compressed
		//    (see CVertexBuilder::CompressedUserData)
		//  - if a vertex contains VERTEX_ELEMENT_BONEWEIGHTSx, this is compressed
		//    (see CVertexBuilder::CompressedBoneWeight3fv)
		VERTEX_COMPRESSION_ON = 1
	}
	public enum ShadowFilterMode_t
	{
		SHADOWFILTERMODE_DEFAULT = 0,

		NVIDIA_PCF = 0,
		ATI_NO_PCF_FETCH4 = 1,
		NVIDIA_PCF_CHEAP = 2,
		ATI_NOPCF = 3,

		// Game consoles use a different set of combo indices to control shadow filtering.
		GAMECONSOLE_NINE_TAP_PCF = 0,
		GAMECONSOLE_SINGLE_TAP_PCF = 1,

		SHADOWFILTERMODE_FIRST_CHEAP_MODE = NVIDIA_PCF_CHEAP,
	};
	public enum CSMQualityMode_t
	{
		CSMQUALITY_VERY_LOW,
		CSMQUALITY_LOW,
		CSMQUALITY_MEDIUM,
		CSMQUALITY_HIGH,

		CSMQUALITY_TOTAL_MODES
	};
	public enum CSMShaderMode_t
	{
		CSMSHADERMODE_LOW_OR_VERY_LOW = 0,
		CSMSHADERMODE_MEDIUM = 1,
		CSMSHADERMODE_HIGH = 2,
		CSMSHADERMODE_ATIFETCH4 = 3,

		CSMSHADERMODE_TOTAL_MODES
	};
	public enum HDRType_t
	{
		HDR_TYPE_NONE,
		HDR_TYPE_INTEGER,
		HDR_TYPE_FLOAT,
	};
	public partial class IMaterialSystemHardwareConfig
	{
		private readonly IntPtr c;

		public IMaterialSystemHardwareConfig(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero) throw new ArgumentNullException(nameof(ptr), "Passing invalid pointer will cause crash");
			c = ptr;
		}

		public int FrameBufferColorDepth => Methods.IMaterialSystemHardwareConfig_GetFrameBufferColorDepth(c);
		public int SamplerCount => Methods.IMaterialSystemHardwareConfig_GetSamplerCount(c);
		public bool SupportsStaticControlFlow => Methods.IMaterialSystemHardwareConfig_SupportsStaticControlFlow(c);
		public VertexCompressionType_t SupportsCompressedVertices => Methods.IMaterialSystemHardwareConfig_SupportsCompressedVertices(c);
		public int MaximumAnisotropicLevel => Methods.IMaterialSystemHardwareConfig_MaximumAnisotropicLevel(c);
		public int MaxTextureWidth => Methods.IMaterialSystemHardwareConfig_MaxTextureWidth(c);
		public int MaxTextureHeight => Methods.IMaterialSystemHardwareConfig_MaxTextureHeight(c);
		public int TextureMemorySize => Methods.IMaterialSystemHardwareConfig_TextureMemorySize(c);
		public bool SupportsMipmappedCubemaps => Methods.IMaterialSystemHardwareConfig_SupportsMipmappedCubemaps(c);

		public int NumVertexShaderConstants => Methods.IMaterialSystemHardwareConfig_NumVertexShaderConstants(c);
		public int NumPixelShaderConstants => Methods.IMaterialSystemHardwareConfig_NumPixelShaderConstants(c);
		public int MaxNumLights => Methods.IMaterialSystemHardwareConfig_MaxNumLights(c);
		public int MaxTextureAspectRatio => Methods.IMaterialSystemHardwareConfig_MaxTextureAspectRatio(c);
		public int MaxVertexShaderBlendMatrices => Methods.IMaterialSystemHardwareConfig_MaxVertexShaderBlendMatrices(c);
		public int MaxUserClipPlanes => Methods.IMaterialSystemHardwareConfig_MaxUserClipPlanes(c);
		public bool UseFastClipping => Methods.IMaterialSystemHardwareConfig_UseFastClipping(c);

		public int DXSupportLevel => Methods.IMaterialSystemHardwareConfig_GetDXSupportLevel(c);
		public string ShaderDLLName => Methods.IMaterialSystemHardwareConfig_GetShaderDLLName(c);

		public bool ReadPixelsFromFrontBuffer => Methods.IMaterialSystemHardwareConfig_ReadPixelsFromFrontBuffer(c);

		public bool PreferDynamicTextures => Methods.IMaterialSystemHardwareConfig_PreferDynamicTextures(c);

		public bool SupportsHDR => Methods.IMaterialSystemHardwareConfig_SupportsHDR(c);

		public bool NeedsAAClamp => Methods.IMaterialSystemHardwareConfig_NeedsAAClamp(c);
		public bool NeedsATICentroidHack => Methods.IMaterialSystemHardwareConfig_NeedsATICentroidHack(c);

		public int MaxDXSupportLevel => Methods.IMaterialSystemHardwareConfig_GetMaxDXSupportLevel(c);

		public bool SpecifiesFogColorInLinearSpace => Methods.IMaterialSystemHardwareConfig_SpecifiesFogColorInLinearSpace(c);

		public bool SupportsSRGB => Methods.IMaterialSystemHardwareConfig_SupportsSRGB(c);
		public bool FakeSRGBWrite => Methods.IMaterialSystemHardwareConfig_FakeSRGBWrite(c);
		public bool CanDoSRGBReadFromRTs => Methods.IMaterialSystemHardwareConfig_CanDoSRGBReadFromRTs(c);

		public bool SupportsGLMixedSizeTargets => Methods.IMaterialSystemHardwareConfig_SupportsGLMixedSizeTargets(c);

		public bool IsAAEnabled => Methods.IMaterialSystemHardwareConfig_IsAAEnabled(c);

		public int VertexSamplerCount => Methods.IMaterialSystemHardwareConfig_GetVertexSamplerCount(c);
		public int MaxVertexTextureDimension => Methods.IMaterialSystemHardwareConfig_GetMaxVertexTextureDimension(c);

		public int MaxTextureDepth => Methods.IMaterialSystemHardwareConfig_MaxTextureDepth(c);

		public HDRType_t HDRType => Methods.IMaterialSystemHardwareConfig_GetHDRType(c);
		public HDRType_t HardwareHDRType => Methods.IMaterialSystemHardwareConfig_GetHardwareHDRType(c);

		public bool SupportsStreamOffset => Methods.IMaterialSystemHardwareConfig_SupportsStreamOffset(c);

		public int StencilBufferBits => Methods.IMaterialSystemHardwareConfig_StencilBufferBits(c);
		public int MaxViewports => Methods.IMaterialSystemHardwareConfig_MaxViewports(c);

		public void OverrideStreamOffsetSupport(bool overrideEnabled, bool enableSupport) => Methods.IMaterialSystemHardwareConfig_OverrideStreamOffsetSupport(c, overrideEnabled, enableSupport);

		public ShadowFilterMode_t GetShadowFilterMode(bool forceLowQualityShadows, bool PS30) => Methods.IMaterialSystemHardwareConfig_GetShadowFilterMode(c, forceLowQualityShadows, PS30);

		public int NeedsShaderSRGBConversion => Methods.IMaterialSystemHardwareConfig_NeedsShaderSRGBConversion(c);

		public bool UsesSRGBCorrectBlending => Methods.IMaterialSystemHardwareConfig_UsesSRGBCorrectBlending(c);

		public bool HasFastVertexTextures => Methods.IMaterialSystemHardwareConfig_HasFastVertexTextures(c);
		public int MaxHWMorphBatchCount => Methods.IMaterialSystemHardwareConfig_MaxHWMorphBatchCount(c);

		public bool HDREnabled
		{
			get => Methods.IMaterialSystemHardwareConfig_GetHDREnabled(c);
			set => Methods.IMaterialSystemHardwareConfig_SetHDREnabled(c, value);
		}

		public bool SupportsBorderColor => Methods.IMaterialSystemHardwareConfig_SupportsBorderColor(c);
		public bool SupportsFetch4 => Methods.IMaterialSystemHardwareConfig_SupportsFetch4(c);

		public float ShadowDepthBias => Methods.IMaterialSystemHardwareConfig_GetShadowDepthBias(c);
		public float ShadowSlopeScaleDepthBias => Methods.IMaterialSystemHardwareConfig_GetShadowSlopeScaleDepthBias(c);

		public bool PreferZPrepass => Methods.IMaterialSystemHardwareConfig_PreferZPrepass(c);

		public bool SuppressPixelShaderCentroidHackFixup => Methods.IMaterialSystemHardwareConfig_SuppressPixelShaderCentroidHackFixup(c);
		public bool PreferTexturesInHWMemory => Methods.IMaterialSystemHardwareConfig_PreferTexturesInHWMemory(c);
		public bool PreferHardwareSync => Methods.IMaterialSystemHardwareConfig_PreferHardwareSync(c);
		public bool ActualHasFastVertexTextures => Methods.IMaterialSystemHardwareConfig_ActualHasFastVertexTextures(c);

		public bool SupportsShadowDepthTextures => Methods.IMaterialSystemHardwareConfig_SupportsShadowDepthTextures(c);

		public ImageFormat ShadowDepthTextureFormat => Methods.IMaterialSystemHardwareConfig_GetShadowDepthTextureFormat(c);
		public ImageFormat HighPrecisionShadowDepthTextureFormat => Methods.IMaterialSystemHardwareConfig_GetHighPrecisionShadowDepthTextureFormat(c);
		public ImageFormat NullTextureFormat => Methods.IMaterialSystemHardwareConfig_GetNullTextureFormat(c);
		public int MinDXSupportLevel => Methods.IMaterialSystemHardwareConfig_GetMinDXSupportLevel(c);
		public bool IsUnsupported => Methods.IMaterialSystemHardwareConfig_IsUnsupported(c);

		public float LightMapScaleFactor => Methods.IMaterialSystemHardwareConfig_GetLightMapScaleFactor(c);

		public bool SupportsCascadedShadowMapping => Methods.IMaterialSystemHardwareConfig_SupportsCascadedShadowMapping(c);
		public CSMQualityMode_t CSMQuality => Methods.IMaterialSystemHardwareConfig_GetCSMQuality(c);
		public bool SupportsBilinearPCFSampling => Methods.IMaterialSystemHardwareConfig_SupportsBilinearPCFSampling(c);
		public CSMShaderMode_t CSMShaderMode => Methods.IMaterialSystemHardwareConfig_GetCSMShaderMode(c);
		public bool CSMAccurateBlending
		{
			get => Methods.IMaterialSystemHardwareConfig_GetCSMAccurateBlending(c);
			set => Methods.IMaterialSystemHardwareConfig_SetCSMAccurateBlending(c, value);
		}

		public bool SupportsResolveDepth => Methods.IMaterialSystemHardwareConfig_SupportsResolveDepth(c);
		public bool HasFullResolutionDepthTexture => Methods.IMaterialSystemHardwareConfig_HasFullResolutionDepthTexture(c);

		private static partial class Methods
		{
			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_GetFrameBufferColorDepth(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_GetSamplerCount(IntPtr c);
			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_SupportsStaticControlFlow(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern VertexCompressionType_t IMaterialSystemHardwareConfig_SupportsCompressedVertices(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_MaximumAnisotropicLevel(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_MaxTextureWidth(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_MaxTextureHeight(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_TextureMemorySize(IntPtr c);
			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_SupportsMipmappedCubemaps(IntPtr c);

			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_NumVertexShaderConstants(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_NumPixelShaderConstants(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_MaxNumLights(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_MaxTextureAspectRatio(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_MaxVertexShaderBlendMatrices(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_MaxUserClipPlanes(IntPtr c);
			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_UseFastClipping(IntPtr c);

			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_GetDXSupportLevel(IntPtr c);
			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.LPUTF8Str)]
			public static partial string IMaterialSystemHardwareConfig_GetShaderDLLName(IntPtr c);

			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_ReadPixelsFromFrontBuffer(IntPtr c);

			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_PreferDynamicTextures(IntPtr c);

			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_SupportsHDR(IntPtr c);

			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_NeedsAAClamp(IntPtr c);
			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_NeedsATICentroidHack(IntPtr c);

			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_GetMaxDXSupportLevel(IntPtr c);

			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_SpecifiesFogColorInLinearSpace(IntPtr c);

			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_SupportsSRGB(IntPtr c);
			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_FakeSRGBWrite(IntPtr c);
			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_CanDoSRGBReadFromRTs(IntPtr c);

			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_SupportsGLMixedSizeTargets(IntPtr c);

			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_IsAAEnabled(IntPtr c);

			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_GetVertexSamplerCount(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_GetMaxVertexTextureDimension(IntPtr c);

			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_MaxTextureDepth(IntPtr c);

			[DllImport("sourcesdkc")]
			public static extern HDRType_t IMaterialSystemHardwareConfig_GetHDRType(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern HDRType_t IMaterialSystemHardwareConfig_GetHardwareHDRType(IntPtr c);

			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_SupportsStreamOffset(IntPtr c);

			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_StencilBufferBits(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_MaxViewports(IntPtr c);

			[GeneratedDllImport("sourcesdkc")]
			public static partial void IMaterialSystemHardwareConfig_OverrideStreamOffsetSupport(IntPtr c, [MarshalAs(UnmanagedType.I1)] bool overrideEnabled, [MarshalAs(UnmanagedType.I1)] bool enableSupport);

			[GeneratedDllImport("sourcesdkc")]
			public static partial ShadowFilterMode_t IMaterialSystemHardwareConfig_GetShadowFilterMode(IntPtr c, [MarshalAs(UnmanagedType.I1)] bool forceLowQualityShadows, [MarshalAs(UnmanagedType.I1)] bool PS30);

			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_NeedsShaderSRGBConversion(IntPtr c);

			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_UsesSRGBCorrectBlending(IntPtr c);

			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_HasFastVertexTextures(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_MaxHWMorphBatchCount(IntPtr c);

			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_GetHDREnabled(IntPtr c);
			[GeneratedDllImport("sourcesdkc")]
			public static partial void IMaterialSystemHardwareConfig_SetHDREnabled(IntPtr c, [MarshalAs(UnmanagedType.I1)] bool enable);

			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_SupportsBorderColor(IntPtr c);
			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_SupportsFetch4(IntPtr c);

			[DllImport("sourcesdkc")]
			public static extern float IMaterialSystemHardwareConfig_GetShadowDepthBias(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern float IMaterialSystemHardwareConfig_GetShadowSlopeScaleDepthBias(IntPtr c);

			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_PreferZPrepass(IntPtr c);

			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_SuppressPixelShaderCentroidHackFixup(IntPtr c);
			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_PreferTexturesInHWMemory(IntPtr c);
			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_PreferHardwareSync(IntPtr c);
			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_ActualHasFastVertexTextures(IntPtr c);

			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_SupportsShadowDepthTextures(IntPtr c);

			[DllImport("sourcesdkc")]
			public static extern ImageFormat IMaterialSystemHardwareConfig_GetShadowDepthTextureFormat(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern ImageFormat IMaterialSystemHardwareConfig_GetHighPrecisionShadowDepthTextureFormat(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern ImageFormat IMaterialSystemHardwareConfig_GetNullTextureFormat(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern int IMaterialSystemHardwareConfig_GetMinDXSupportLevel(IntPtr c);
			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_IsUnsupported(IntPtr c);

			[DllImport("sourcesdkc")]
			public static extern float IMaterialSystemHardwareConfig_GetLightMapScaleFactor(IntPtr c);

			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_SupportsCascadedShadowMapping(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern CSMQualityMode_t IMaterialSystemHardwareConfig_GetCSMQuality(IntPtr c);
			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_SupportsBilinearPCFSampling(IntPtr c);
			[DllImport("sourcesdkc")]
			public static extern CSMShaderMode_t IMaterialSystemHardwareConfig_GetCSMShaderMode(IntPtr c);
			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_GetCSMAccurateBlending(IntPtr c);
			[GeneratedDllImport("sourcesdkc")]
			public static partial void IMaterialSystemHardwareConfig_SetCSMAccurateBlending(IntPtr c, [MarshalAs(UnmanagedType.I1)] bool enable);

			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_SupportsResolveDepth(IntPtr c);
			[GeneratedDllImport("sourcesdkc")]
			[return: MarshalAs(UnmanagedType.I1)]
			public static partial bool IMaterialSystemHardwareConfig_HasFullResolutionDepthTexture(IntPtr c);
		}
	}
}
