using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027B3 RID: 10163
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.GeometryDataCasterSettings")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FGeometryDataCasterSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025E13 RID: 155155 RVA: 0x00396D83 File Offset: 0x00394F83
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGeometryDataCasterSettings._ScriptStructPtr != 0) ? FGeometryDataCasterSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.GeometryDataCasterSettings", ref FGeometryDataCasterSettings._ScriptStructPtr);
		}

		// Token: 0x170091FE RID: 37374
		// (get) Token: 0x06025E14 RID: 155156 RVA: 0x00396DA7 File Offset: 0x00394FA7
		// (set) Token: 0x06025E15 RID: 155157 RVA: 0x00396DBB File Offset: 0x00394FBB
		public unsafe string MaterialChannel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGeometryDataCasterSettings.__PropertyOffset_MaterialChannel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGeometryDataCasterSettings.__PropertyOffset_MaterialChannel)), value);
			}
		}

		// Token: 0x170091FF RID: 37375
		// (get) Token: 0x06025E16 RID: 155158 RVA: 0x00396DD0 File Offset: 0x00394FD0
		// (set) Token: 0x06025E17 RID: 155159 RVA: 0x00396DE4 File Offset: 0x00394FE4
		public unsafe string OpacityChannel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGeometryDataCasterSettings.__PropertyOffset_OpacityChannel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGeometryDataCasterSettings.__PropertyOffset_OpacityChannel)), value);
			}
		}

		// Token: 0x17009200 RID: 37376
		// (get) Token: 0x06025E18 RID: 155160 RVA: 0x00396DF9 File Offset: 0x00394FF9
		// (set) Token: 0x06025E19 RID: 155161 RVA: 0x00396E09 File Offset: 0x00395009
		public unsafe EOpacityChannelComponent OpacityChannelComponent
		{
			get
			{
				return (EOpacityChannelComponent)(*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_OpacityChannelComponent));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_OpacityChannelComponent) = (byte)value;
			}
		}

		// Token: 0x17009201 RID: 37377
		// (get) Token: 0x06025E1A RID: 155162 RVA: 0x00396E1A File Offset: 0x0039501A
		// (set) Token: 0x06025E1B RID: 155163 RVA: 0x00396E2A File Offset: 0x0039502A
		public unsafe EDitherType DitherType
		{
			get
			{
				return (EDitherType)(*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_DitherType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_DitherType) = (byte)value;
			}
		}

		// Token: 0x17009202 RID: 37378
		// (get) Token: 0x06025E1C RID: 155164 RVA: 0x00396E3B File Offset: 0x0039503B
		// (set) Token: 0x06025E1D RID: 155165 RVA: 0x00396E4B File Offset: 0x0039504B
		public unsafe EFillMode FillMode
		{
			get
			{
				return (EFillMode)(*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_FillMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_FillMode) = (byte)value;
			}
		}

		// Token: 0x17009203 RID: 37379
		// (get) Token: 0x06025E1E RID: 155166 RVA: 0x00396E5C File Offset: 0x0039505C
		// (set) Token: 0x06025E1F RID: 155167 RVA: 0x00396E6C File Offset: 0x0039506C
		public unsafe int Dilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_Dilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_Dilation) = value;
			}
		}

		// Token: 0x17009204 RID: 37380
		// (get) Token: 0x06025E20 RID: 155168 RVA: 0x00396E7D File Offset: 0x0039507D
		// (set) Token: 0x06025E21 RID: 155169 RVA: 0x00396E96 File Offset: 0x00395096
		public unsafe bool UseMultisampling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_UseMultisampling) & FGeometryDataCasterSettings.__PropertyMask_UseMultisampling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_UseMultisampling) = ((*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_UseMultisampling) & ~FGeometryDataCasterSettings.__PropertyMask_UseMultisampling) | (value ? FGeometryDataCasterSettings.__PropertyMask_UseMultisampling : 0));
			}
		}

		// Token: 0x17009205 RID: 37381
		// (get) Token: 0x06025E22 RID: 155170 RVA: 0x00396EC6 File Offset: 0x003950C6
		// (set) Token: 0x06025E23 RID: 155171 RVA: 0x00396ED6 File Offset: 0x003950D6
		public unsafe EOutputPixelFormat OutputPixelFormat
		{
			get
			{
				return (EOutputPixelFormat)(*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_OutputPixelFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_OutputPixelFormat) = (byte)value;
			}
		}

		// Token: 0x17009206 RID: 37382
		// (get) Token: 0x06025E24 RID: 155172 RVA: 0x00396EE7 File Offset: 0x003950E7
		// (set) Token: 0x06025E25 RID: 155173 RVA: 0x00396EF7 File Offset: 0x003950F7
		public unsafe EOutputImageFileFormat OutputImageFileFormat
		{
			get
			{
				return (EOutputImageFileFormat)(*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_OutputImageFileFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_OutputImageFileFormat) = (byte)value;
			}
		}

		// Token: 0x17009207 RID: 37383
		// (get) Token: 0x06025E26 RID: 155174 RVA: 0x00396F08 File Offset: 0x00395108
		// (set) Token: 0x06025E27 RID: 155175 RVA: 0x00396F18 File Offset: 0x00395118
		public unsafe EOutputDDSCompressionType OutputDDSCompressionType
		{
			get
			{
				return (EOutputDDSCompressionType)(*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_OutputDDSCompressionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_OutputDDSCompressionType) = (byte)value;
			}
		}

		// Token: 0x17009208 RID: 37384
		// (get) Token: 0x06025E28 RID: 155176 RVA: 0x00396F29 File Offset: 0x00395129
		// (set) Token: 0x06025E29 RID: 155177 RVA: 0x00396F39 File Offset: 0x00395139
		public unsafe EGeometryDataFieldType GeometryDataFieldType
		{
			get
			{
				return (EGeometryDataFieldType)(*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_GeometryDataFieldType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_GeometryDataFieldType) = (byte)value;
			}
		}

		// Token: 0x17009209 RID: 37385
		// (get) Token: 0x06025E2A RID: 155178 RVA: 0x00396F4A File Offset: 0x0039514A
		// (set) Token: 0x06025E2B RID: 155179 RVA: 0x00396F5A File Offset: 0x0039515A
		public unsafe int GeometryDataFieldIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_GeometryDataFieldIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_GeometryDataFieldIndex) = value;
			}
		}

		// Token: 0x1700920A RID: 37386
		// (get) Token: 0x06025E2C RID: 155180 RVA: 0x00396F6B File Offset: 0x0039516B
		// (set) Token: 0x06025E2D RID: 155181 RVA: 0x00396F7B File Offset: 0x0039517B
		public unsafe int MappingLayerIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_MappingLayerIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_MappingLayerIndex) = value;
			}
		}

		// Token: 0x1700920B RID: 37387
		// (get) Token: 0x06025E2E RID: 155182 RVA: 0x00396F8C File Offset: 0x0039518C
		// (set) Token: 0x06025E2F RID: 155183 RVA: 0x00396FA0 File Offset: 0x003951A0
		public unsafe FVector4 MappingInf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_MappingInf);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_MappingInf) = value;
			}
		}

		// Token: 0x1700920C RID: 37388
		// (get) Token: 0x06025E30 RID: 155184 RVA: 0x00396FB5 File Offset: 0x003951B5
		// (set) Token: 0x06025E31 RID: 155185 RVA: 0x00396FC9 File Offset: 0x003951C9
		public unsafe FVector4 MappingSup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_MappingSup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryDataCasterSettings.__PropertyOffset_MappingSup) = value;
			}
		}

		// Token: 0x06025E32 RID: 155186 RVA: 0x00396FDE File Offset: 0x003951DE
		public FGeometryDataCasterSettings()
		{
		}

		// Token: 0x06025E33 RID: 155187 RVA: 0x00396FE8 File Offset: 0x003951E8
		public FGeometryDataCasterSettings(string MaterialChannel, string OpacityChannel, EOpacityChannelComponent OpacityChannelComponent, EDitherType DitherType, EFillMode FillMode, int Dilation, bool UseMultisampling, EOutputPixelFormat OutputPixelFormat, EOutputImageFileFormat OutputImageFileFormat, EOutputDDSCompressionType OutputDDSCompressionType, EGeometryDataFieldType GeometryDataFieldType, int GeometryDataFieldIndex, int MappingLayerIndex, FVector4 MappingInf, FVector4 MappingSup)
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
			this.GeometryDataFieldType = GeometryDataFieldType;
			this.GeometryDataFieldIndex = GeometryDataFieldIndex;
			this.MappingLayerIndex = MappingLayerIndex;
			this.MappingInf = MappingInf;
			this.MappingSup = MappingSup;
		}

		// Token: 0x06025E34 RID: 155188 RVA: 0x00397070 File Offset: 0x00395270
		protected override IntPtr GetUStructPtr()
		{
			return FGeometryDataCasterSettings.StaticStruct();
		}

		// Token: 0x06025E35 RID: 155189 RVA: 0x0039707C File Offset: 0x0039527C
		[NullableContext(2)]
		public FGeometryDataCasterSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025E36 RID: 155190 RVA: 0x00397086 File Offset: 0x00395286
		public FGeometryDataCasterSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025E37 RID: 155191 RVA: 0x00397091 File Offset: 0x00395291
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGeometryDataCasterSettings(Pointer, false, true);
		}

		// Token: 0x06025E38 RID: 155192 RVA: 0x0039709B File Offset: 0x0039529B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGeometryDataCasterSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014AC9 RID: 84681
		public const string __ObjectPath = "/Script/SimplygonUObjects.GeometryDataCasterSettings";

		// Token: 0x04014ACA RID: 84682
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014ACB RID: 84683
		internal static int __PropertyOffset_MaterialChannel;

		// Token: 0x04014ACC RID: 84684
		internal static int __PropertyOffset_OpacityChannel;

		// Token: 0x04014ACD RID: 84685
		internal static int __PropertyOffset_OpacityChannelComponent;

		// Token: 0x04014ACE RID: 84686
		internal static int __PropertyOffset_DitherType;

		// Token: 0x04014ACF RID: 84687
		internal static int __PropertyOffset_FillMode;

		// Token: 0x04014AD0 RID: 84688
		internal static int __PropertyOffset_Dilation;

		// Token: 0x04014AD1 RID: 84689
		internal static int __PropertyOffset_UseMultisampling;

		// Token: 0x04014AD2 RID: 84690
		internal static byte __PropertyMask_UseMultisampling;

		// Token: 0x04014AD3 RID: 84691
		internal static int __PropertyOffset_OutputPixelFormat;

		// Token: 0x04014AD4 RID: 84692
		internal static int __PropertyOffset_OutputImageFileFormat;

		// Token: 0x04014AD5 RID: 84693
		internal static int __PropertyOffset_OutputDDSCompressionType;

		// Token: 0x04014AD6 RID: 84694
		internal static int __PropertyOffset_GeometryDataFieldType;

		// Token: 0x04014AD7 RID: 84695
		internal static int __PropertyOffset_GeometryDataFieldIndex;

		// Token: 0x04014AD8 RID: 84696
		internal static int __PropertyOffset_MappingLayerIndex;

		// Token: 0x04014AD9 RID: 84697
		internal static int __PropertyOffset_MappingInf;

		// Token: 0x04014ADA RID: 84698
		internal static int __PropertyOffset_MappingSup;
	}
}
