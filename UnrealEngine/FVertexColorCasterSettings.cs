using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027E3 RID: 10211
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.VertexColorCasterSettings")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FVertexColorCasterSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060260F9 RID: 155897 RVA: 0x0039BB0E File Offset: 0x00399D0E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVertexColorCasterSettings._ScriptStructPtr != 0) ? FVertexColorCasterSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.VertexColorCasterSettings", ref FVertexColorCasterSettings._ScriptStructPtr);
		}

		// Token: 0x170092DB RID: 37595
		// (get) Token: 0x060260FA RID: 155898 RVA: 0x0039BB32 File Offset: 0x00399D32
		// (set) Token: 0x060260FB RID: 155899 RVA: 0x0039BB46 File Offset: 0x00399D46
		public unsafe string MaterialChannel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FVertexColorCasterSettings.__PropertyOffset_MaterialChannel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FVertexColorCasterSettings.__PropertyOffset_MaterialChannel)), value);
			}
		}

		// Token: 0x170092DC RID: 37596
		// (get) Token: 0x060260FC RID: 155900 RVA: 0x0039BB5B File Offset: 0x00399D5B
		// (set) Token: 0x060260FD RID: 155901 RVA: 0x0039BB6F File Offset: 0x00399D6F
		public unsafe string OpacityChannel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FVertexColorCasterSettings.__PropertyOffset_OpacityChannel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FVertexColorCasterSettings.__PropertyOffset_OpacityChannel)), value);
			}
		}

		// Token: 0x170092DD RID: 37597
		// (get) Token: 0x060260FE RID: 155902 RVA: 0x0039BB84 File Offset: 0x00399D84
		// (set) Token: 0x060260FF RID: 155903 RVA: 0x0039BB94 File Offset: 0x00399D94
		public unsafe EOpacityChannelComponent OpacityChannelComponent
		{
			get
			{
				return (EOpacityChannelComponent)(*(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_OpacityChannelComponent));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_OpacityChannelComponent) = (byte)value;
			}
		}

		// Token: 0x170092DE RID: 37598
		// (get) Token: 0x06026100 RID: 155904 RVA: 0x0039BBA5 File Offset: 0x00399DA5
		// (set) Token: 0x06026101 RID: 155905 RVA: 0x0039BBB5 File Offset: 0x00399DB5
		public unsafe EDitherType DitherType
		{
			get
			{
				return (EDitherType)(*(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_DitherType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_DitherType) = (byte)value;
			}
		}

		// Token: 0x170092DF RID: 37599
		// (get) Token: 0x06026102 RID: 155906 RVA: 0x0039BBC6 File Offset: 0x00399DC6
		// (set) Token: 0x06026103 RID: 155907 RVA: 0x0039BBD6 File Offset: 0x00399DD6
		public unsafe EFillMode FillMode
		{
			get
			{
				return (EFillMode)(*(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_FillMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_FillMode) = (byte)value;
			}
		}

		// Token: 0x170092E0 RID: 37600
		// (get) Token: 0x06026104 RID: 155908 RVA: 0x0039BBE7 File Offset: 0x00399DE7
		// (set) Token: 0x06026105 RID: 155909 RVA: 0x0039BBF7 File Offset: 0x00399DF7
		public unsafe int Dilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_Dilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_Dilation) = value;
			}
		}

		// Token: 0x170092E1 RID: 37601
		// (get) Token: 0x06026106 RID: 155910 RVA: 0x0039BC08 File Offset: 0x00399E08
		// (set) Token: 0x06026107 RID: 155911 RVA: 0x0039BC21 File Offset: 0x00399E21
		public unsafe bool UseMultisampling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_UseMultisampling) & FVertexColorCasterSettings.__PropertyMask_UseMultisampling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_UseMultisampling) = ((*(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_UseMultisampling) & ~FVertexColorCasterSettings.__PropertyMask_UseMultisampling) | (value ? FVertexColorCasterSettings.__PropertyMask_UseMultisampling : 0));
			}
		}

		// Token: 0x170092E2 RID: 37602
		// (get) Token: 0x06026108 RID: 155912 RVA: 0x0039BC51 File Offset: 0x00399E51
		// (set) Token: 0x06026109 RID: 155913 RVA: 0x0039BC61 File Offset: 0x00399E61
		public unsafe EOutputPixelFormat OutputPixelFormat
		{
			get
			{
				return (EOutputPixelFormat)(*(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_OutputPixelFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_OutputPixelFormat) = (byte)value;
			}
		}

		// Token: 0x170092E3 RID: 37603
		// (get) Token: 0x0602610A RID: 155914 RVA: 0x0039BC72 File Offset: 0x00399E72
		// (set) Token: 0x0602610B RID: 155915 RVA: 0x0039BC82 File Offset: 0x00399E82
		public unsafe EOutputImageFileFormat OutputImageFileFormat
		{
			get
			{
				return (EOutputImageFileFormat)(*(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_OutputImageFileFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_OutputImageFileFormat) = (byte)value;
			}
		}

		// Token: 0x170092E4 RID: 37604
		// (get) Token: 0x0602610C RID: 155916 RVA: 0x0039BC93 File Offset: 0x00399E93
		// (set) Token: 0x0602610D RID: 155917 RVA: 0x0039BCA3 File Offset: 0x00399EA3
		public unsafe EOutputDDSCompressionType OutputDDSCompressionType
		{
			get
			{
				return (EOutputDDSCompressionType)(*(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_OutputDDSCompressionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_OutputDDSCompressionType) = (byte)value;
			}
		}

		// Token: 0x170092E5 RID: 37605
		// (get) Token: 0x0602610E RID: 155918 RVA: 0x0039BCB4 File Offset: 0x00399EB4
		// (set) Token: 0x0602610F RID: 155919 RVA: 0x0039BCC4 File Offset: 0x00399EC4
		public unsafe int OutputColorLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_OutputColorLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_OutputColorLevel) = value;
			}
		}

		// Token: 0x170092E6 RID: 37606
		// (get) Token: 0x06026110 RID: 155920 RVA: 0x0039BCD5 File Offset: 0x00399ED5
		// (set) Token: 0x06026111 RID: 155921 RVA: 0x0039BCE9 File Offset: 0x00399EE9
		public unsafe string OutputColorName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FVertexColorCasterSettings.__PropertyOffset_OutputColorName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FVertexColorCasterSettings.__PropertyOffset_OutputColorName)), value);
			}
		}

		// Token: 0x170092E7 RID: 37607
		// (get) Token: 0x06026112 RID: 155922 RVA: 0x0039BCFE File Offset: 0x00399EFE
		// (set) Token: 0x06026113 RID: 155923 RVA: 0x0039BD0E File Offset: 0x00399F0E
		public unsafe float ColorSpaceEdgeThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_ColorSpaceEdgeThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVertexColorCasterSettings.__PropertyOffset_ColorSpaceEdgeThreshold) = value;
			}
		}

		// Token: 0x06026114 RID: 155924 RVA: 0x0039BD1F File Offset: 0x00399F1F
		public FVertexColorCasterSettings()
		{
		}

		// Token: 0x06026115 RID: 155925 RVA: 0x0039BD28 File Offset: 0x00399F28
		public FVertexColorCasterSettings(string MaterialChannel, string OpacityChannel, EOpacityChannelComponent OpacityChannelComponent, EDitherType DitherType, EFillMode FillMode, int Dilation, bool UseMultisampling, EOutputPixelFormat OutputPixelFormat, EOutputImageFileFormat OutputImageFileFormat, EOutputDDSCompressionType OutputDDSCompressionType, int OutputColorLevel, string OutputColorName, float ColorSpaceEdgeThreshold)
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
			this.OutputColorLevel = OutputColorLevel;
			this.OutputColorName = OutputColorName;
			this.ColorSpaceEdgeThreshold = ColorSpaceEdgeThreshold;
		}

		// Token: 0x06026116 RID: 155926 RVA: 0x0039BDA0 File Offset: 0x00399FA0
		protected override IntPtr GetUStructPtr()
		{
			return FVertexColorCasterSettings.StaticStruct();
		}

		// Token: 0x06026117 RID: 155927 RVA: 0x0039BDAC File Offset: 0x00399FAC
		[NullableContext(2)]
		public FVertexColorCasterSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026118 RID: 155928 RVA: 0x0039BDB6 File Offset: 0x00399FB6
		public FVertexColorCasterSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026119 RID: 155929 RVA: 0x0039BDC1 File Offset: 0x00399FC1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVertexColorCasterSettings(Pointer, false, true);
		}

		// Token: 0x0602611A RID: 155930 RVA: 0x0039BDCB File Offset: 0x00399FCB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVertexColorCasterSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014C8C RID: 85132
		public const string __ObjectPath = "/Script/SimplygonUObjects.VertexColorCasterSettings";

		// Token: 0x04014C8D RID: 85133
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014C8E RID: 85134
		internal static int __PropertyOffset_MaterialChannel;

		// Token: 0x04014C8F RID: 85135
		internal static int __PropertyOffset_OpacityChannel;

		// Token: 0x04014C90 RID: 85136
		internal static int __PropertyOffset_OpacityChannelComponent;

		// Token: 0x04014C91 RID: 85137
		internal static int __PropertyOffset_DitherType;

		// Token: 0x04014C92 RID: 85138
		internal static int __PropertyOffset_FillMode;

		// Token: 0x04014C93 RID: 85139
		internal static int __PropertyOffset_Dilation;

		// Token: 0x04014C94 RID: 85140
		internal static int __PropertyOffset_UseMultisampling;

		// Token: 0x04014C95 RID: 85141
		internal static byte __PropertyMask_UseMultisampling;

		// Token: 0x04014C96 RID: 85142
		internal static int __PropertyOffset_OutputPixelFormat;

		// Token: 0x04014C97 RID: 85143
		internal static int __PropertyOffset_OutputImageFileFormat;

		// Token: 0x04014C98 RID: 85144
		internal static int __PropertyOffset_OutputDDSCompressionType;

		// Token: 0x04014C99 RID: 85145
		internal static int __PropertyOffset_OutputColorLevel;

		// Token: 0x04014C9A RID: 85146
		internal static int __PropertyOffset_OutputColorName;

		// Token: 0x04014C9B RID: 85147
		internal static int __PropertyOffset_ColorSpaceEdgeThreshold;
	}
}
