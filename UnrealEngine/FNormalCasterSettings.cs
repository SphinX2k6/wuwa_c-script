using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027C1 RID: 10177
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.NormalCasterSettings")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FNormalCasterSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025F17 RID: 155415 RVA: 0x003987E1 File Offset: 0x003969E1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNormalCasterSettings._ScriptStructPtr != 0) ? FNormalCasterSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.NormalCasterSettings", ref FNormalCasterSettings._ScriptStructPtr);
		}

		// Token: 0x1700924E RID: 37454
		// (get) Token: 0x06025F18 RID: 155416 RVA: 0x00398805 File Offset: 0x00396A05
		// (set) Token: 0x06025F19 RID: 155417 RVA: 0x00398819 File Offset: 0x00396A19
		public unsafe string MaterialChannel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FNormalCasterSettings.__PropertyOffset_MaterialChannel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FNormalCasterSettings.__PropertyOffset_MaterialChannel)), value);
			}
		}

		// Token: 0x1700924F RID: 37455
		// (get) Token: 0x06025F1A RID: 155418 RVA: 0x0039882E File Offset: 0x00396A2E
		// (set) Token: 0x06025F1B RID: 155419 RVA: 0x00398842 File Offset: 0x00396A42
		public unsafe string OpacityChannel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FNormalCasterSettings.__PropertyOffset_OpacityChannel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FNormalCasterSettings.__PropertyOffset_OpacityChannel)), value);
			}
		}

		// Token: 0x17009250 RID: 37456
		// (get) Token: 0x06025F1C RID: 155420 RVA: 0x00398857 File Offset: 0x00396A57
		// (set) Token: 0x06025F1D RID: 155421 RVA: 0x00398867 File Offset: 0x00396A67
		public unsafe EOpacityChannelComponent OpacityChannelComponent
		{
			get
			{
				return (EOpacityChannelComponent)(*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_OpacityChannelComponent));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_OpacityChannelComponent) = (byte)value;
			}
		}

		// Token: 0x17009251 RID: 37457
		// (get) Token: 0x06025F1E RID: 155422 RVA: 0x00398878 File Offset: 0x00396A78
		// (set) Token: 0x06025F1F RID: 155423 RVA: 0x00398888 File Offset: 0x00396A88
		public unsafe EDitherType DitherType
		{
			get
			{
				return (EDitherType)(*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_DitherType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_DitherType) = (byte)value;
			}
		}

		// Token: 0x17009252 RID: 37458
		// (get) Token: 0x06025F20 RID: 155424 RVA: 0x00398899 File Offset: 0x00396A99
		// (set) Token: 0x06025F21 RID: 155425 RVA: 0x003988A9 File Offset: 0x00396AA9
		public unsafe EFillMode FillMode
		{
			get
			{
				return (EFillMode)(*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_FillMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_FillMode) = (byte)value;
			}
		}

		// Token: 0x17009253 RID: 37459
		// (get) Token: 0x06025F22 RID: 155426 RVA: 0x003988BA File Offset: 0x00396ABA
		// (set) Token: 0x06025F23 RID: 155427 RVA: 0x003988CA File Offset: 0x00396ACA
		public unsafe int Dilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_Dilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_Dilation) = value;
			}
		}

		// Token: 0x17009254 RID: 37460
		// (get) Token: 0x06025F24 RID: 155428 RVA: 0x003988DB File Offset: 0x00396ADB
		// (set) Token: 0x06025F25 RID: 155429 RVA: 0x003988F4 File Offset: 0x00396AF4
		public unsafe bool UseMultisampling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_UseMultisampling) & FNormalCasterSettings.__PropertyMask_UseMultisampling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_UseMultisampling) = ((*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_UseMultisampling) & ~FNormalCasterSettings.__PropertyMask_UseMultisampling) | (value ? FNormalCasterSettings.__PropertyMask_UseMultisampling : 0));
			}
		}

		// Token: 0x17009255 RID: 37461
		// (get) Token: 0x06025F26 RID: 155430 RVA: 0x00398924 File Offset: 0x00396B24
		// (set) Token: 0x06025F27 RID: 155431 RVA: 0x00398934 File Offset: 0x00396B34
		public unsafe EOutputPixelFormat OutputPixelFormat
		{
			get
			{
				return (EOutputPixelFormat)(*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_OutputPixelFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_OutputPixelFormat) = (byte)value;
			}
		}

		// Token: 0x17009256 RID: 37462
		// (get) Token: 0x06025F28 RID: 155432 RVA: 0x00398945 File Offset: 0x00396B45
		// (set) Token: 0x06025F29 RID: 155433 RVA: 0x00398955 File Offset: 0x00396B55
		public unsafe EOutputImageFileFormat OutputImageFileFormat
		{
			get
			{
				return (EOutputImageFileFormat)(*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_OutputImageFileFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_OutputImageFileFormat) = (byte)value;
			}
		}

		// Token: 0x17009257 RID: 37463
		// (get) Token: 0x06025F2A RID: 155434 RVA: 0x00398966 File Offset: 0x00396B66
		// (set) Token: 0x06025F2B RID: 155435 RVA: 0x00398976 File Offset: 0x00396B76
		public unsafe EOutputDDSCompressionType OutputDDSCompressionType
		{
			get
			{
				return (EOutputDDSCompressionType)(*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_OutputDDSCompressionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_OutputDDSCompressionType) = (byte)value;
			}
		}

		// Token: 0x17009258 RID: 37464
		// (get) Token: 0x06025F2C RID: 155436 RVA: 0x00398987 File Offset: 0x00396B87
		// (set) Token: 0x06025F2D RID: 155437 RVA: 0x003989A0 File Offset: 0x00396BA0
		public unsafe bool FlipBackfacingNormals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_FlipBackfacingNormals) & FNormalCasterSettings.__PropertyMask_FlipBackfacingNormals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_FlipBackfacingNormals) = ((*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_FlipBackfacingNormals) & ~FNormalCasterSettings.__PropertyMask_FlipBackfacingNormals) | (value ? FNormalCasterSettings.__PropertyMask_FlipBackfacingNormals : 0));
			}
		}

		// Token: 0x17009259 RID: 37465
		// (get) Token: 0x06025F2E RID: 155438 RVA: 0x003989D0 File Offset: 0x00396BD0
		// (set) Token: 0x06025F2F RID: 155439 RVA: 0x003989E0 File Offset: 0x00396BE0
		public unsafe EFlipBackfacingMode FlipBackfacingMode
		{
			get
			{
				return (EFlipBackfacingMode)(*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_FlipBackfacingMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_FlipBackfacingMode) = (byte)value;
			}
		}

		// Token: 0x1700925A RID: 37466
		// (get) Token: 0x06025F30 RID: 155440 RVA: 0x003989F1 File Offset: 0x00396BF1
		// (set) Token: 0x06025F31 RID: 155441 RVA: 0x00398A0A File Offset: 0x00396C0A
		public unsafe bool GenerateTangentSpaceNormals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_GenerateTangentSpaceNormals) & FNormalCasterSettings.__PropertyMask_GenerateTangentSpaceNormals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_GenerateTangentSpaceNormals) = ((*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_GenerateTangentSpaceNormals) & ~FNormalCasterSettings.__PropertyMask_GenerateTangentSpaceNormals) | (value ? FNormalCasterSettings.__PropertyMask_GenerateTangentSpaceNormals : 0));
			}
		}

		// Token: 0x1700925B RID: 37467
		// (get) Token: 0x06025F32 RID: 155442 RVA: 0x00398A3A File Offset: 0x00396C3A
		// (set) Token: 0x06025F33 RID: 155443 RVA: 0x00398A53 File Offset: 0x00396C53
		public unsafe bool FlipGreen
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_FlipGreen) & FNormalCasterSettings.__PropertyMask_FlipGreen) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_FlipGreen) = ((*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_FlipGreen) & ~FNormalCasterSettings.__PropertyMask_FlipGreen) | (value ? FNormalCasterSettings.__PropertyMask_FlipGreen : 0));
			}
		}

		// Token: 0x1700925C RID: 37468
		// (get) Token: 0x06025F34 RID: 155444 RVA: 0x00398A83 File Offset: 0x00396C83
		// (set) Token: 0x06025F35 RID: 155445 RVA: 0x00398A9C File Offset: 0x00396C9C
		public unsafe bool CalculateBitangentPerFragment
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_CalculateBitangentPerFragment) & FNormalCasterSettings.__PropertyMask_CalculateBitangentPerFragment) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_CalculateBitangentPerFragment) = ((*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_CalculateBitangentPerFragment) & ~FNormalCasterSettings.__PropertyMask_CalculateBitangentPerFragment) | (value ? FNormalCasterSettings.__PropertyMask_CalculateBitangentPerFragment : 0));
			}
		}

		// Token: 0x1700925D RID: 37469
		// (get) Token: 0x06025F36 RID: 155446 RVA: 0x00398ACC File Offset: 0x00396CCC
		// (set) Token: 0x06025F37 RID: 155447 RVA: 0x00398AE5 File Offset: 0x00396CE5
		public unsafe bool NormalizeInterpolatedTangentSpace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_NormalizeInterpolatedTangentSpace) & FNormalCasterSettings.__PropertyMask_NormalizeInterpolatedTangentSpace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_NormalizeInterpolatedTangentSpace) = ((*(base.NativePtr + (IntPtr)FNormalCasterSettings.__PropertyOffset_NormalizeInterpolatedTangentSpace) & ~FNormalCasterSettings.__PropertyMask_NormalizeInterpolatedTangentSpace) | (value ? FNormalCasterSettings.__PropertyMask_NormalizeInterpolatedTangentSpace : 0));
			}
		}

		// Token: 0x06025F38 RID: 155448 RVA: 0x00398B15 File Offset: 0x00396D15
		public FNormalCasterSettings()
		{
		}

		// Token: 0x06025F39 RID: 155449 RVA: 0x00398B20 File Offset: 0x00396D20
		public FNormalCasterSettings(string MaterialChannel, string OpacityChannel, EOpacityChannelComponent OpacityChannelComponent, EDitherType DitherType, EFillMode FillMode, int Dilation, bool UseMultisampling, EOutputPixelFormat OutputPixelFormat, EOutputImageFileFormat OutputImageFileFormat, EOutputDDSCompressionType OutputDDSCompressionType, bool FlipBackfacingNormals, EFlipBackfacingMode FlipBackfacingMode, bool GenerateTangentSpaceNormals, bool FlipGreen, bool CalculateBitangentPerFragment, bool NormalizeInterpolatedTangentSpace)
		{
			this.MaterialChannel = MaterialChannel;
			this.OpacityChannel = OpacityChannel;
			this.OpacityChannelComponent = OpacityChannelComponent;
			this.DitherType = DitherType;
			this.FillMode = FillMode;
			this.Dilation = Dilation;
			this.UseMultisampling = UseMultisampling;
			this.OutputPixelFormat = OutputPixelFormat;
			this.OutputImageFileFormat = OutputImageFileFormat;
			this.OutputDDSCompressionType = OutputDDSCompressionType;
			this.FlipBackfacingNormals = FlipBackfacingNormals;
			this.FlipBackfacingMode = FlipBackfacingMode;
			this.GenerateTangentSpaceNormals = GenerateTangentSpaceNormals;
			this.FlipGreen = FlipGreen;
			this.CalculateBitangentPerFragment = CalculateBitangentPerFragment;
			this.NormalizeInterpolatedTangentSpace = NormalizeInterpolatedTangentSpace;
		}

		// Token: 0x06025F3A RID: 155450 RVA: 0x00398BB0 File Offset: 0x00396DB0
		protected override IntPtr GetUStructPtr()
		{
			return FNormalCasterSettings.StaticStruct();
		}

		// Token: 0x06025F3B RID: 155451 RVA: 0x00398BBC File Offset: 0x00396DBC
		[NullableContext(2)]
		public FNormalCasterSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025F3C RID: 155452 RVA: 0x00398BC6 File Offset: 0x00396DC6
		public FNormalCasterSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025F3D RID: 155453 RVA: 0x00398BD1 File Offset: 0x00396DD1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNormalCasterSettings(Pointer, false, true);
		}

		// Token: 0x06025F3E RID: 155454 RVA: 0x00398BDB File Offset: 0x00396DDB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNormalCasterSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014B60 RID: 84832
		public const string __ObjectPath = "/Script/SimplygonUObjects.NormalCasterSettings";

		// Token: 0x04014B61 RID: 84833
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014B62 RID: 84834
		internal static int __PropertyOffset_MaterialChannel;

		// Token: 0x04014B63 RID: 84835
		internal static int __PropertyOffset_OpacityChannel;

		// Token: 0x04014B64 RID: 84836
		internal static int __PropertyOffset_OpacityChannelComponent;

		// Token: 0x04014B65 RID: 84837
		internal static int __PropertyOffset_DitherType;

		// Token: 0x04014B66 RID: 84838
		internal static int __PropertyOffset_FillMode;

		// Token: 0x04014B67 RID: 84839
		internal static int __PropertyOffset_Dilation;

		// Token: 0x04014B68 RID: 84840
		internal static int __PropertyOffset_UseMultisampling;

		// Token: 0x04014B69 RID: 84841
		internal static byte __PropertyMask_UseMultisampling;

		// Token: 0x04014B6A RID: 84842
		internal static int __PropertyOffset_OutputPixelFormat;

		// Token: 0x04014B6B RID: 84843
		internal static int __PropertyOffset_OutputImageFileFormat;

		// Token: 0x04014B6C RID: 84844
		internal static int __PropertyOffset_OutputDDSCompressionType;

		// Token: 0x04014B6D RID: 84845
		internal static int __PropertyOffset_FlipBackfacingNormals;

		// Token: 0x04014B6E RID: 84846
		internal static byte __PropertyMask_FlipBackfacingNormals;

		// Token: 0x04014B6F RID: 84847
		internal static int __PropertyOffset_FlipBackfacingMode;

		// Token: 0x04014B70 RID: 84848
		internal static int __PropertyOffset_GenerateTangentSpaceNormals;

		// Token: 0x04014B71 RID: 84849
		internal static byte __PropertyMask_GenerateTangentSpaceNormals;

		// Token: 0x04014B72 RID: 84850
		internal static int __PropertyOffset_FlipGreen;

		// Token: 0x04014B73 RID: 84851
		internal static byte __PropertyMask_FlipGreen;

		// Token: 0x04014B74 RID: 84852
		internal static int __PropertyOffset_CalculateBitangentPerFragment;

		// Token: 0x04014B75 RID: 84853
		internal static byte __PropertyMask_CalculateBitangentPerFragment;

		// Token: 0x04014B76 RID: 84854
		internal static int __PropertyOffset_NormalizeInterpolatedTangentSpace;

		// Token: 0x04014B77 RID: 84855
		internal static byte __PropertyMask_NormalizeInterpolatedTangentSpace;
	}
}
