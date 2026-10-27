using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027C4 RID: 10180
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.OpacityCasterSettings")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FOpacityCasterSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025F4B RID: 155467 RVA: 0x00398D3D File Offset: 0x00396F3D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FOpacityCasterSettings._ScriptStructPtr != 0) ? FOpacityCasterSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.OpacityCasterSettings", ref FOpacityCasterSettings._ScriptStructPtr);
		}

		// Token: 0x1700925F RID: 37471
		// (get) Token: 0x06025F4C RID: 155468 RVA: 0x00398D61 File Offset: 0x00396F61
		// (set) Token: 0x06025F4D RID: 155469 RVA: 0x00398D75 File Offset: 0x00396F75
		public unsafe string MaterialChannel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FOpacityCasterSettings.__PropertyOffset_MaterialChannel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FOpacityCasterSettings.__PropertyOffset_MaterialChannel)), value);
			}
		}

		// Token: 0x17009260 RID: 37472
		// (get) Token: 0x06025F4E RID: 155470 RVA: 0x00398D8A File Offset: 0x00396F8A
		// (set) Token: 0x06025F4F RID: 155471 RVA: 0x00398D9E File Offset: 0x00396F9E
		public unsafe string OpacityChannel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FOpacityCasterSettings.__PropertyOffset_OpacityChannel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FOpacityCasterSettings.__PropertyOffset_OpacityChannel)), value);
			}
		}

		// Token: 0x17009261 RID: 37473
		// (get) Token: 0x06025F50 RID: 155472 RVA: 0x00398DB3 File Offset: 0x00396FB3
		// (set) Token: 0x06025F51 RID: 155473 RVA: 0x00398DC3 File Offset: 0x00396FC3
		public unsafe EOpacityChannelComponent OpacityChannelComponent
		{
			get
			{
				return (EOpacityChannelComponent)(*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_OpacityChannelComponent));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_OpacityChannelComponent) = (byte)value;
			}
		}

		// Token: 0x17009262 RID: 37474
		// (get) Token: 0x06025F52 RID: 155474 RVA: 0x00398DD4 File Offset: 0x00396FD4
		// (set) Token: 0x06025F53 RID: 155475 RVA: 0x00398DE4 File Offset: 0x00396FE4
		public unsafe EDitherType DitherType
		{
			get
			{
				return (EDitherType)(*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_DitherType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_DitherType) = (byte)value;
			}
		}

		// Token: 0x17009263 RID: 37475
		// (get) Token: 0x06025F54 RID: 155476 RVA: 0x00398DF5 File Offset: 0x00396FF5
		// (set) Token: 0x06025F55 RID: 155477 RVA: 0x00398E05 File Offset: 0x00397005
		public unsafe EFillMode FillMode
		{
			get
			{
				return (EFillMode)(*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_FillMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_FillMode) = (byte)value;
			}
		}

		// Token: 0x17009264 RID: 37476
		// (get) Token: 0x06025F56 RID: 155478 RVA: 0x00398E16 File Offset: 0x00397016
		// (set) Token: 0x06025F57 RID: 155479 RVA: 0x00398E26 File Offset: 0x00397026
		public unsafe int Dilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_Dilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_Dilation) = value;
			}
		}

		// Token: 0x17009265 RID: 37477
		// (get) Token: 0x06025F58 RID: 155480 RVA: 0x00398E37 File Offset: 0x00397037
		// (set) Token: 0x06025F59 RID: 155481 RVA: 0x00398E50 File Offset: 0x00397050
		public unsafe bool UseMultisampling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_UseMultisampling) & FOpacityCasterSettings.__PropertyMask_UseMultisampling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_UseMultisampling) = ((*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_UseMultisampling) & ~FOpacityCasterSettings.__PropertyMask_UseMultisampling) | (value ? FOpacityCasterSettings.__PropertyMask_UseMultisampling : 0));
			}
		}

		// Token: 0x17009266 RID: 37478
		// (get) Token: 0x06025F5A RID: 155482 RVA: 0x00398E80 File Offset: 0x00397080
		// (set) Token: 0x06025F5B RID: 155483 RVA: 0x00398E90 File Offset: 0x00397090
		public unsafe EOutputPixelFormat OutputPixelFormat
		{
			get
			{
				return (EOutputPixelFormat)(*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_OutputPixelFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_OutputPixelFormat) = (byte)value;
			}
		}

		// Token: 0x17009267 RID: 37479
		// (get) Token: 0x06025F5C RID: 155484 RVA: 0x00398EA1 File Offset: 0x003970A1
		// (set) Token: 0x06025F5D RID: 155485 RVA: 0x00398EB1 File Offset: 0x003970B1
		public unsafe EOutputImageFileFormat OutputImageFileFormat
		{
			get
			{
				return (EOutputImageFileFormat)(*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_OutputImageFileFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_OutputImageFileFormat) = (byte)value;
			}
		}

		// Token: 0x17009268 RID: 37480
		// (get) Token: 0x06025F5E RID: 155486 RVA: 0x00398EC2 File Offset: 0x003970C2
		// (set) Token: 0x06025F5F RID: 155487 RVA: 0x00398ED2 File Offset: 0x003970D2
		public unsafe EOutputDDSCompressionType OutputDDSCompressionType
		{
			get
			{
				return (EOutputDDSCompressionType)(*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_OutputDDSCompressionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_OutputDDSCompressionType) = (byte)value;
			}
		}

		// Token: 0x17009269 RID: 37481
		// (get) Token: 0x06025F60 RID: 155488 RVA: 0x00398EE3 File Offset: 0x003970E3
		// (set) Token: 0x06025F61 RID: 155489 RVA: 0x00398EFC File Offset: 0x003970FC
		public unsafe bool OutputSRGB
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_OutputSRGB) & FOpacityCasterSettings.__PropertyMask_OutputSRGB) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_OutputSRGB) = ((*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_OutputSRGB) & ~FOpacityCasterSettings.__PropertyMask_OutputSRGB) | (value ? FOpacityCasterSettings.__PropertyMask_OutputSRGB : 0));
			}
		}

		// Token: 0x1700926A RID: 37482
		// (get) Token: 0x06025F62 RID: 155490 RVA: 0x00398F2C File Offset: 0x0039712C
		// (set) Token: 0x06025F63 RID: 155491 RVA: 0x00398F45 File Offset: 0x00397145
		public unsafe bool OutputToTessellatedAttributes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_OutputToTessellatedAttributes) & FOpacityCasterSettings.__PropertyMask_OutputToTessellatedAttributes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_OutputToTessellatedAttributes) = ((*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_OutputToTessellatedAttributes) & ~FOpacityCasterSettings.__PropertyMask_OutputToTessellatedAttributes) | (value ? FOpacityCasterSettings.__PropertyMask_OutputToTessellatedAttributes : 0));
			}
		}

		// Token: 0x1700926B RID: 37483
		// (get) Token: 0x06025F64 RID: 155492 RVA: 0x00398F75 File Offset: 0x00397175
		// (set) Token: 0x06025F65 RID: 155493 RVA: 0x00398F85 File Offset: 0x00397185
		public unsafe EOutputOpacityType OutputOpacityType
		{
			get
			{
				return (EOutputOpacityType)(*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_OutputOpacityType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityCasterSettings.__PropertyOffset_OutputOpacityType) = (byte)value;
			}
		}

		// Token: 0x06025F66 RID: 155494 RVA: 0x00398F96 File Offset: 0x00397196
		public FOpacityCasterSettings()
		{
		}

		// Token: 0x06025F67 RID: 155495 RVA: 0x00398FA0 File Offset: 0x003971A0
		public FOpacityCasterSettings(string MaterialChannel, string OpacityChannel, EOpacityChannelComponent OpacityChannelComponent, EDitherType DitherType, EFillMode FillMode, int Dilation, bool UseMultisampling, EOutputPixelFormat OutputPixelFormat, EOutputImageFileFormat OutputImageFileFormat, EOutputDDSCompressionType OutputDDSCompressionType, bool OutputSRGB, bool OutputToTessellatedAttributes, EOutputOpacityType OutputOpacityType)
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
			this.OutputToTessellatedAttributes = OutputToTessellatedAttributes;
			this.OutputOpacityType = OutputOpacityType;
		}

		// Token: 0x06025F68 RID: 155496 RVA: 0x00399018 File Offset: 0x00397218
		protected override IntPtr GetUStructPtr()
		{
			return FOpacityCasterSettings.StaticStruct();
		}

		// Token: 0x06025F69 RID: 155497 RVA: 0x00399024 File Offset: 0x00397224
		[NullableContext(2)]
		public FOpacityCasterSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025F6A RID: 155498 RVA: 0x0039902E File Offset: 0x0039722E
		public FOpacityCasterSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025F6B RID: 155499 RVA: 0x00399039 File Offset: 0x00397239
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FOpacityCasterSettings(Pointer, false, true);
		}

		// Token: 0x06025F6C RID: 155500 RVA: 0x00399043 File Offset: 0x00397243
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FOpacityCasterSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014B80 RID: 84864
		public const string __ObjectPath = "/Script/SimplygonUObjects.OpacityCasterSettings";

		// Token: 0x04014B81 RID: 84865
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014B82 RID: 84866
		internal static int __PropertyOffset_MaterialChannel;

		// Token: 0x04014B83 RID: 84867
		internal static int __PropertyOffset_OpacityChannel;

		// Token: 0x04014B84 RID: 84868
		internal static int __PropertyOffset_OpacityChannelComponent;

		// Token: 0x04014B85 RID: 84869
		internal static int __PropertyOffset_DitherType;

		// Token: 0x04014B86 RID: 84870
		internal static int __PropertyOffset_FillMode;

		// Token: 0x04014B87 RID: 84871
		internal static int __PropertyOffset_Dilation;

		// Token: 0x04014B88 RID: 84872
		internal static int __PropertyOffset_UseMultisampling;

		// Token: 0x04014B89 RID: 84873
		internal static byte __PropertyMask_UseMultisampling;

		// Token: 0x04014B8A RID: 84874
		internal static int __PropertyOffset_OutputPixelFormat;

		// Token: 0x04014B8B RID: 84875
		internal static int __PropertyOffset_OutputImageFileFormat;

		// Token: 0x04014B8C RID: 84876
		internal static int __PropertyOffset_OutputDDSCompressionType;

		// Token: 0x04014B8D RID: 84877
		internal static int __PropertyOffset_OutputSRGB;

		// Token: 0x04014B8E RID: 84878
		internal static byte __PropertyMask_OutputSRGB;

		// Token: 0x04014B8F RID: 84879
		internal static int __PropertyOffset_OutputToTessellatedAttributes;

		// Token: 0x04014B90 RID: 84880
		internal static byte __PropertyMask_OutputToTessellatedAttributes;

		// Token: 0x04014B91 RID: 84881
		internal static int __PropertyOffset_OutputOpacityType;
	}
}
