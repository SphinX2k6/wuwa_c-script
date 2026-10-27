using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002783 RID: 10115
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.ColorCasterSettings")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FColorCasterSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025D26 RID: 154918 RVA: 0x003957C4 File Offset: 0x003939C4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FColorCasterSettings._ScriptStructPtr != 0) ? FColorCasterSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.ColorCasterSettings", ref FColorCasterSettings._ScriptStructPtr);
		}

		// Token: 0x170091AF RID: 37295
		// (get) Token: 0x06025D27 RID: 154919 RVA: 0x003957E8 File Offset: 0x003939E8
		// (set) Token: 0x06025D28 RID: 154920 RVA: 0x003957FC File Offset: 0x003939FC
		public unsafe string MaterialChannel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FColorCasterSettings.__PropertyOffset_MaterialChannel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FColorCasterSettings.__PropertyOffset_MaterialChannel)), value);
			}
		}

		// Token: 0x170091B0 RID: 37296
		// (get) Token: 0x06025D29 RID: 154921 RVA: 0x00395811 File Offset: 0x00393A11
		// (set) Token: 0x06025D2A RID: 154922 RVA: 0x00395825 File Offset: 0x00393A25
		public unsafe string OpacityChannel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FColorCasterSettings.__PropertyOffset_OpacityChannel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FColorCasterSettings.__PropertyOffset_OpacityChannel)), value);
			}
		}

		// Token: 0x170091B1 RID: 37297
		// (get) Token: 0x06025D2B RID: 154923 RVA: 0x0039583A File Offset: 0x00393A3A
		// (set) Token: 0x06025D2C RID: 154924 RVA: 0x0039584A File Offset: 0x00393A4A
		public unsafe EOpacityChannelComponent OpacityChannelComponent
		{
			get
			{
				return (EOpacityChannelComponent)(*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_OpacityChannelComponent));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_OpacityChannelComponent) = (byte)value;
			}
		}

		// Token: 0x170091B2 RID: 37298
		// (get) Token: 0x06025D2D RID: 154925 RVA: 0x0039585B File Offset: 0x00393A5B
		// (set) Token: 0x06025D2E RID: 154926 RVA: 0x0039586B File Offset: 0x00393A6B
		public unsafe EDitherType DitherType
		{
			get
			{
				return (EDitherType)(*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_DitherType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_DitherType) = (byte)value;
			}
		}

		// Token: 0x170091B3 RID: 37299
		// (get) Token: 0x06025D2F RID: 154927 RVA: 0x0039587C File Offset: 0x00393A7C
		// (set) Token: 0x06025D30 RID: 154928 RVA: 0x0039588C File Offset: 0x00393A8C
		public unsafe EFillMode FillMode
		{
			get
			{
				return (EFillMode)(*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_FillMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_FillMode) = (byte)value;
			}
		}

		// Token: 0x170091B4 RID: 37300
		// (get) Token: 0x06025D31 RID: 154929 RVA: 0x0039589D File Offset: 0x00393A9D
		// (set) Token: 0x06025D32 RID: 154930 RVA: 0x003958AD File Offset: 0x00393AAD
		public unsafe int Dilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_Dilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_Dilation) = value;
			}
		}

		// Token: 0x170091B5 RID: 37301
		// (get) Token: 0x06025D33 RID: 154931 RVA: 0x003958BE File Offset: 0x00393ABE
		// (set) Token: 0x06025D34 RID: 154932 RVA: 0x003958D7 File Offset: 0x00393AD7
		public unsafe bool UseMultisampling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_UseMultisampling) & FColorCasterSettings.__PropertyMask_UseMultisampling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_UseMultisampling) = ((*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_UseMultisampling) & ~FColorCasterSettings.__PropertyMask_UseMultisampling) | (value ? FColorCasterSettings.__PropertyMask_UseMultisampling : 0));
			}
		}

		// Token: 0x170091B6 RID: 37302
		// (get) Token: 0x06025D35 RID: 154933 RVA: 0x00395907 File Offset: 0x00393B07
		// (set) Token: 0x06025D36 RID: 154934 RVA: 0x00395917 File Offset: 0x00393B17
		public unsafe EOutputPixelFormat OutputPixelFormat
		{
			get
			{
				return (EOutputPixelFormat)(*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_OutputPixelFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_OutputPixelFormat) = (byte)value;
			}
		}

		// Token: 0x170091B7 RID: 37303
		// (get) Token: 0x06025D37 RID: 154935 RVA: 0x00395928 File Offset: 0x00393B28
		// (set) Token: 0x06025D38 RID: 154936 RVA: 0x00395938 File Offset: 0x00393B38
		public unsafe EOutputImageFileFormat OutputImageFileFormat
		{
			get
			{
				return (EOutputImageFileFormat)(*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_OutputImageFileFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_OutputImageFileFormat) = (byte)value;
			}
		}

		// Token: 0x170091B8 RID: 37304
		// (get) Token: 0x06025D39 RID: 154937 RVA: 0x00395949 File Offset: 0x00393B49
		// (set) Token: 0x06025D3A RID: 154938 RVA: 0x00395959 File Offset: 0x00393B59
		public unsafe EOutputDDSCompressionType OutputDDSCompressionType
		{
			get
			{
				return (EOutputDDSCompressionType)(*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_OutputDDSCompressionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_OutputDDSCompressionType) = (byte)value;
			}
		}

		// Token: 0x170091B9 RID: 37305
		// (get) Token: 0x06025D3B RID: 154939 RVA: 0x0039596A File Offset: 0x00393B6A
		// (set) Token: 0x06025D3C RID: 154940 RVA: 0x00395983 File Offset: 0x00393B83
		public unsafe bool OutputSRGB
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_OutputSRGB) & FColorCasterSettings.__PropertyMask_OutputSRGB) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_OutputSRGB) = ((*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_OutputSRGB) & ~FColorCasterSettings.__PropertyMask_OutputSRGB) | (value ? FColorCasterSettings.__PropertyMask_OutputSRGB : 0));
			}
		}

		// Token: 0x170091BA RID: 37306
		// (get) Token: 0x06025D3D RID: 154941 RVA: 0x003959B3 File Offset: 0x00393BB3
		// (set) Token: 0x06025D3E RID: 154942 RVA: 0x003959CC File Offset: 0x00393BCC
		public unsafe bool BakeOpacityInAlpha
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_BakeOpacityInAlpha) & FColorCasterSettings.__PropertyMask_BakeOpacityInAlpha) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_BakeOpacityInAlpha) = ((*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_BakeOpacityInAlpha) & ~FColorCasterSettings.__PropertyMask_BakeOpacityInAlpha) | (value ? FColorCasterSettings.__PropertyMask_BakeOpacityInAlpha : 0));
			}
		}

		// Token: 0x170091BB RID: 37307
		// (get) Token: 0x06025D3F RID: 154943 RVA: 0x003959FC File Offset: 0x00393BFC
		// (set) Token: 0x06025D40 RID: 154944 RVA: 0x00395A15 File Offset: 0x00393C15
		public unsafe bool SkipCastingIfNoInputChannel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_SkipCastingIfNoInputChannel) & FColorCasterSettings.__PropertyMask_SkipCastingIfNoInputChannel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_SkipCastingIfNoInputChannel) = ((*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_SkipCastingIfNoInputChannel) & ~FColorCasterSettings.__PropertyMask_SkipCastingIfNoInputChannel) | (value ? FColorCasterSettings.__PropertyMask_SkipCastingIfNoInputChannel : 0));
			}
		}

		// Token: 0x170091BC RID: 37308
		// (get) Token: 0x06025D41 RID: 154945 RVA: 0x00395A45 File Offset: 0x00393C45
		// (set) Token: 0x06025D42 RID: 154946 RVA: 0x00395A55 File Offset: 0x00393C55
		public unsafe EOutputOpacityType OutputOpacityType
		{
			get
			{
				return (EOutputOpacityType)(*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_OutputOpacityType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FColorCasterSettings.__PropertyOffset_OutputOpacityType) = (byte)value;
			}
		}

		// Token: 0x06025D43 RID: 154947 RVA: 0x00395A66 File Offset: 0x00393C66
		public FColorCasterSettings()
		{
		}

		// Token: 0x06025D44 RID: 154948 RVA: 0x00395A70 File Offset: 0x00393C70
		public FColorCasterSettings(string MaterialChannel, string OpacityChannel, EOpacityChannelComponent OpacityChannelComponent, EDitherType DitherType, EFillMode FillMode, int Dilation, bool UseMultisampling, EOutputPixelFormat OutputPixelFormat, EOutputImageFileFormat OutputImageFileFormat, EOutputDDSCompressionType OutputDDSCompressionType, bool OutputSRGB, bool BakeOpacityInAlpha, bool SkipCastingIfNoInputChannel, EOutputOpacityType OutputOpacityType)
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
			this.OutputSRGB = OutputSRGB;
			this.BakeOpacityInAlpha = BakeOpacityInAlpha;
			this.SkipCastingIfNoInputChannel = SkipCastingIfNoInputChannel;
			this.OutputOpacityType = OutputOpacityType;
		}

		// Token: 0x06025D45 RID: 154949 RVA: 0x00395AF0 File Offset: 0x00393CF0
		protected override IntPtr GetUStructPtr()
		{
			return FColorCasterSettings.StaticStruct();
		}

		// Token: 0x06025D46 RID: 154950 RVA: 0x00395AFC File Offset: 0x00393CFC
		[NullableContext(2)]
		public FColorCasterSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025D47 RID: 154951 RVA: 0x00395B06 File Offset: 0x00393D06
		public FColorCasterSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025D48 RID: 154952 RVA: 0x00395B11 File Offset: 0x00393D11
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FColorCasterSettings(Pointer, false, true);
		}

		// Token: 0x06025D49 RID: 154953 RVA: 0x00395B1B File Offset: 0x00393D1B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FColorCasterSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014978 RID: 84344
		public const string __ObjectPath = "/Script/SimplygonUObjects.ColorCasterSettings";

		// Token: 0x04014979 RID: 84345
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401497A RID: 84346
		internal static int __PropertyOffset_MaterialChannel;

		// Token: 0x0401497B RID: 84347
		internal static int __PropertyOffset_OpacityChannel;

		// Token: 0x0401497C RID: 84348
		internal static int __PropertyOffset_OpacityChannelComponent;

		// Token: 0x0401497D RID: 84349
		internal static int __PropertyOffset_DitherType;

		// Token: 0x0401497E RID: 84350
		internal static int __PropertyOffset_FillMode;

		// Token: 0x0401497F RID: 84351
		internal static int __PropertyOffset_Dilation;

		// Token: 0x04014980 RID: 84352
		internal static int __PropertyOffset_UseMultisampling;

		// Token: 0x04014981 RID: 84353
		internal static byte __PropertyMask_UseMultisampling;

		// Token: 0x04014982 RID: 84354
		internal static int __PropertyOffset_OutputPixelFormat;

		// Token: 0x04014983 RID: 84355
		internal static int __PropertyOffset_OutputImageFileFormat;

		// Token: 0x04014984 RID: 84356
		internal static int __PropertyOffset_OutputDDSCompressionType;

		// Token: 0x04014985 RID: 84357
		internal static int __PropertyOffset_OutputSRGB;

		// Token: 0x04014986 RID: 84358
		internal static byte __PropertyMask_OutputSRGB;

		// Token: 0x04014987 RID: 84359
		internal static int __PropertyOffset_BakeOpacityInAlpha;

		// Token: 0x04014988 RID: 84360
		internal static byte __PropertyMask_BakeOpacityInAlpha;

		// Token: 0x04014989 RID: 84361
		internal static int __PropertyOffset_SkipCastingIfNoInputChannel;

		// Token: 0x0401498A RID: 84362
		internal static byte __PropertyMask_SkipCastingIfNoInputChannel;

		// Token: 0x0401498B RID: 84363
		internal static int __PropertyOffset_OutputOpacityType;
	}
}
