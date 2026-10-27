using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002784 RID: 10116
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.ComputeCasterSettings")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FComputeCasterSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025D4A RID: 154954 RVA: 0x00395B24 File Offset: 0x00393D24
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FComputeCasterSettings._ScriptStructPtr != 0) ? FComputeCasterSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.ComputeCasterSettings", ref FComputeCasterSettings._ScriptStructPtr);
		}

		// Token: 0x170091BD RID: 37309
		// (get) Token: 0x06025D4B RID: 154955 RVA: 0x00395B48 File Offset: 0x00393D48
		// (set) Token: 0x06025D4C RID: 154956 RVA: 0x00395B5C File Offset: 0x00393D5C
		public unsafe string MaterialChannel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FComputeCasterSettings.__PropertyOffset_MaterialChannel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FComputeCasterSettings.__PropertyOffset_MaterialChannel)), value);
			}
		}

		// Token: 0x170091BE RID: 37310
		// (get) Token: 0x06025D4D RID: 154957 RVA: 0x00395B71 File Offset: 0x00393D71
		// (set) Token: 0x06025D4E RID: 154958 RVA: 0x00395B85 File Offset: 0x00393D85
		public unsafe string OpacityChannel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FComputeCasterSettings.__PropertyOffset_OpacityChannel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FComputeCasterSettings.__PropertyOffset_OpacityChannel)), value);
			}
		}

		// Token: 0x170091BF RID: 37311
		// (get) Token: 0x06025D4F RID: 154959 RVA: 0x00395B9A File Offset: 0x00393D9A
		// (set) Token: 0x06025D50 RID: 154960 RVA: 0x00395BAA File Offset: 0x00393DAA
		public unsafe EOpacityChannelComponent OpacityChannelComponent
		{
			get
			{
				return (EOpacityChannelComponent)(*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_OpacityChannelComponent));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_OpacityChannelComponent) = (byte)value;
			}
		}

		// Token: 0x170091C0 RID: 37312
		// (get) Token: 0x06025D51 RID: 154961 RVA: 0x00395BBB File Offset: 0x00393DBB
		// (set) Token: 0x06025D52 RID: 154962 RVA: 0x00395BCB File Offset: 0x00393DCB
		public unsafe EDitherType DitherType
		{
			get
			{
				return (EDitherType)(*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_DitherType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_DitherType) = (byte)value;
			}
		}

		// Token: 0x170091C1 RID: 37313
		// (get) Token: 0x06025D53 RID: 154963 RVA: 0x00395BDC File Offset: 0x00393DDC
		// (set) Token: 0x06025D54 RID: 154964 RVA: 0x00395BEC File Offset: 0x00393DEC
		public unsafe EFillMode FillMode
		{
			get
			{
				return (EFillMode)(*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_FillMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_FillMode) = (byte)value;
			}
		}

		// Token: 0x170091C2 RID: 37314
		// (get) Token: 0x06025D55 RID: 154965 RVA: 0x00395BFD File Offset: 0x00393DFD
		// (set) Token: 0x06025D56 RID: 154966 RVA: 0x00395C0D File Offset: 0x00393E0D
		public unsafe int Dilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_Dilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_Dilation) = value;
			}
		}

		// Token: 0x170091C3 RID: 37315
		// (get) Token: 0x06025D57 RID: 154967 RVA: 0x00395C1E File Offset: 0x00393E1E
		// (set) Token: 0x06025D58 RID: 154968 RVA: 0x00395C37 File Offset: 0x00393E37
		public unsafe bool UseMultisampling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_UseMultisampling) & FComputeCasterSettings.__PropertyMask_UseMultisampling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_UseMultisampling) = ((*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_UseMultisampling) & ~FComputeCasterSettings.__PropertyMask_UseMultisampling) | (value ? FComputeCasterSettings.__PropertyMask_UseMultisampling : 0));
			}
		}

		// Token: 0x170091C4 RID: 37316
		// (get) Token: 0x06025D59 RID: 154969 RVA: 0x00395C67 File Offset: 0x00393E67
		// (set) Token: 0x06025D5A RID: 154970 RVA: 0x00395C77 File Offset: 0x00393E77
		public unsafe EOutputPixelFormat OutputPixelFormat
		{
			get
			{
				return (EOutputPixelFormat)(*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_OutputPixelFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_OutputPixelFormat) = (byte)value;
			}
		}

		// Token: 0x170091C5 RID: 37317
		// (get) Token: 0x06025D5B RID: 154971 RVA: 0x00395C88 File Offset: 0x00393E88
		// (set) Token: 0x06025D5C RID: 154972 RVA: 0x00395C98 File Offset: 0x00393E98
		public unsafe EOutputImageFileFormat OutputImageFileFormat
		{
			get
			{
				return (EOutputImageFileFormat)(*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_OutputImageFileFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_OutputImageFileFormat) = (byte)value;
			}
		}

		// Token: 0x170091C6 RID: 37318
		// (get) Token: 0x06025D5D RID: 154973 RVA: 0x00395CA9 File Offset: 0x00393EA9
		// (set) Token: 0x06025D5E RID: 154974 RVA: 0x00395CB9 File Offset: 0x00393EB9
		public unsafe EOutputDDSCompressionType OutputDDSCompressionType
		{
			get
			{
				return (EOutputDDSCompressionType)(*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_OutputDDSCompressionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_OutputDDSCompressionType) = (byte)value;
			}
		}

		// Token: 0x170091C7 RID: 37319
		// (get) Token: 0x06025D5F RID: 154975 RVA: 0x00395CCA File Offset: 0x00393ECA
		// (set) Token: 0x06025D60 RID: 154976 RVA: 0x00395CDA File Offset: 0x00393EDA
		public unsafe EOutputColorSpace OutputColorSpace
		{
			get
			{
				return (EOutputColorSpace)(*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_OutputColorSpace));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_OutputColorSpace) = (byte)value;
			}
		}

		// Token: 0x170091C8 RID: 37320
		// (get) Token: 0x06025D61 RID: 154977 RVA: 0x00395CEB File Offset: 0x00393EEB
		// (set) Token: 0x06025D62 RID: 154978 RVA: 0x00395D04 File Offset: 0x00393F04
		public unsafe bool CastLayersFrontToBack
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_CastLayersFrontToBack) & FComputeCasterSettings.__PropertyMask_CastLayersFrontToBack) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_CastLayersFrontToBack) = ((*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_CastLayersFrontToBack) & ~FComputeCasterSettings.__PropertyMask_CastLayersFrontToBack) | (value ? FComputeCasterSettings.__PropertyMask_CastLayersFrontToBack : 0));
			}
		}

		// Token: 0x170091C9 RID: 37321
		// (get) Token: 0x06025D63 RID: 154979 RVA: 0x00395D34 File Offset: 0x00393F34
		// (set) Token: 0x06025D64 RID: 154980 RVA: 0x00395D44 File Offset: 0x00393F44
		public unsafe int MaxCastLayers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_MaxCastLayers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_MaxCastLayers) = value;
			}
		}

		// Token: 0x170091CA RID: 37322
		// (get) Token: 0x06025D65 RID: 154981 RVA: 0x00395D55 File Offset: 0x00393F55
		// (set) Token: 0x06025D66 RID: 154982 RVA: 0x00395D65 File Offset: 0x00393F65
		public unsafe EShaderCodeInputMode ShaderCodeInputMode
		{
			get
			{
				return (EShaderCodeInputMode)(*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_ShaderCodeInputMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComputeCasterSettings.__PropertyOffset_ShaderCodeInputMode) = (byte)value;
			}
		}

		// Token: 0x06025D67 RID: 154983 RVA: 0x00395D76 File Offset: 0x00393F76
		public FComputeCasterSettings()
		{
		}

		// Token: 0x06025D68 RID: 154984 RVA: 0x00395D80 File Offset: 0x00393F80
		public FComputeCasterSettings(string MaterialChannel, string OpacityChannel, EOpacityChannelComponent OpacityChannelComponent, EDitherType DitherType, EFillMode FillMode, int Dilation, bool UseMultisampling, EOutputPixelFormat OutputPixelFormat, EOutputImageFileFormat OutputImageFileFormat, EOutputDDSCompressionType OutputDDSCompressionType, EOutputColorSpace OutputColorSpace, bool CastLayersFrontToBack, int MaxCastLayers, EShaderCodeInputMode ShaderCodeInputMode)
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
			this.OutputColorSpace = OutputColorSpace;
			this.CastLayersFrontToBack = CastLayersFrontToBack;
			this.MaxCastLayers = MaxCastLayers;
			this.ShaderCodeInputMode = ShaderCodeInputMode;
		}

		// Token: 0x06025D69 RID: 154985 RVA: 0x00395E00 File Offset: 0x00394000
		protected override IntPtr GetUStructPtr()
		{
			return FComputeCasterSettings.StaticStruct();
		}

		// Token: 0x06025D6A RID: 154986 RVA: 0x00395E0C File Offset: 0x0039400C
		[NullableContext(2)]
		public FComputeCasterSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025D6B RID: 154987 RVA: 0x00395E16 File Offset: 0x00394016
		public FComputeCasterSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025D6C RID: 154988 RVA: 0x00395E21 File Offset: 0x00394021
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FComputeCasterSettings(Pointer, false, true);
		}

		// Token: 0x06025D6D RID: 154989 RVA: 0x00395E2B File Offset: 0x0039402B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FComputeCasterSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0401498C RID: 84364
		public const string __ObjectPath = "/Script/SimplygonUObjects.ComputeCasterSettings";

		// Token: 0x0401498D RID: 84365
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401498E RID: 84366
		internal static int __PropertyOffset_MaterialChannel;

		// Token: 0x0401498F RID: 84367
		internal static int __PropertyOffset_OpacityChannel;

		// Token: 0x04014990 RID: 84368
		internal static int __PropertyOffset_OpacityChannelComponent;

		// Token: 0x04014991 RID: 84369
		internal static int __PropertyOffset_DitherType;

		// Token: 0x04014992 RID: 84370
		internal static int __PropertyOffset_FillMode;

		// Token: 0x04014993 RID: 84371
		internal static int __PropertyOffset_Dilation;

		// Token: 0x04014994 RID: 84372
		internal static int __PropertyOffset_UseMultisampling;

		// Token: 0x04014995 RID: 84373
		internal static byte __PropertyMask_UseMultisampling;

		// Token: 0x04014996 RID: 84374
		internal static int __PropertyOffset_OutputPixelFormat;

		// Token: 0x04014997 RID: 84375
		internal static int __PropertyOffset_OutputImageFileFormat;

		// Token: 0x04014998 RID: 84376
		internal static int __PropertyOffset_OutputDDSCompressionType;

		// Token: 0x04014999 RID: 84377
		internal static int __PropertyOffset_OutputColorSpace;

		// Token: 0x0401499A RID: 84378
		internal static int __PropertyOffset_CastLayersFrontToBack;

		// Token: 0x0401499B RID: 84379
		internal static byte __PropertyMask_CastLayersFrontToBack;

		// Token: 0x0401499C RID: 84380
		internal static int __PropertyOffset_MaxCastLayers;

		// Token: 0x0401499D RID: 84381
		internal static int __PropertyOffset_ShaderCodeInputMode;
	}
}
