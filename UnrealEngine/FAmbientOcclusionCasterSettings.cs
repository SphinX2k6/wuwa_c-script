using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002777 RID: 10103
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.AmbientOcclusionCasterSettings")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FAmbientOcclusionCasterSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025C41 RID: 154689 RVA: 0x003940B8 File Offset: 0x003922B8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAmbientOcclusionCasterSettings._ScriptStructPtr != 0) ? FAmbientOcclusionCasterSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.AmbientOcclusionCasterSettings", ref FAmbientOcclusionCasterSettings._ScriptStructPtr);
		}

		// Token: 0x17009165 RID: 37221
		// (get) Token: 0x06025C42 RID: 154690 RVA: 0x003940DC File Offset: 0x003922DC
		// (set) Token: 0x06025C43 RID: 154691 RVA: 0x003940F0 File Offset: 0x003922F0
		public unsafe string MaterialChannel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_MaterialChannel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_MaterialChannel)), value);
			}
		}

		// Token: 0x17009166 RID: 37222
		// (get) Token: 0x06025C44 RID: 154692 RVA: 0x00394105 File Offset: 0x00392305
		// (set) Token: 0x06025C45 RID: 154693 RVA: 0x00394119 File Offset: 0x00392319
		public unsafe string OpacityChannel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_OpacityChannel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_OpacityChannel)), value);
			}
		}

		// Token: 0x17009167 RID: 37223
		// (get) Token: 0x06025C46 RID: 154694 RVA: 0x0039412E File Offset: 0x0039232E
		// (set) Token: 0x06025C47 RID: 154695 RVA: 0x0039413E File Offset: 0x0039233E
		public unsafe EOpacityChannelComponent OpacityChannelComponent
		{
			get
			{
				return (EOpacityChannelComponent)(*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_OpacityChannelComponent));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_OpacityChannelComponent) = (byte)value;
			}
		}

		// Token: 0x17009168 RID: 37224
		// (get) Token: 0x06025C48 RID: 154696 RVA: 0x0039414F File Offset: 0x0039234F
		// (set) Token: 0x06025C49 RID: 154697 RVA: 0x0039415F File Offset: 0x0039235F
		public unsafe EDitherType DitherType
		{
			get
			{
				return (EDitherType)(*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_DitherType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_DitherType) = (byte)value;
			}
		}

		// Token: 0x17009169 RID: 37225
		// (get) Token: 0x06025C4A RID: 154698 RVA: 0x00394170 File Offset: 0x00392370
		// (set) Token: 0x06025C4B RID: 154699 RVA: 0x00394180 File Offset: 0x00392380
		public unsafe EFillMode FillMode
		{
			get
			{
				return (EFillMode)(*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_FillMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_FillMode) = (byte)value;
			}
		}

		// Token: 0x1700916A RID: 37226
		// (get) Token: 0x06025C4C RID: 154700 RVA: 0x00394191 File Offset: 0x00392391
		// (set) Token: 0x06025C4D RID: 154701 RVA: 0x003941A1 File Offset: 0x003923A1
		public unsafe int Dilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_Dilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_Dilation) = value;
			}
		}

		// Token: 0x1700916B RID: 37227
		// (get) Token: 0x06025C4E RID: 154702 RVA: 0x003941B2 File Offset: 0x003923B2
		// (set) Token: 0x06025C4F RID: 154703 RVA: 0x003941CB File Offset: 0x003923CB
		public unsafe bool UseMultisampling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_UseMultisampling) & FAmbientOcclusionCasterSettings.__PropertyMask_UseMultisampling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_UseMultisampling) = ((*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_UseMultisampling) & ~FAmbientOcclusionCasterSettings.__PropertyMask_UseMultisampling) | (value ? FAmbientOcclusionCasterSettings.__PropertyMask_UseMultisampling : 0));
			}
		}

		// Token: 0x1700916C RID: 37228
		// (get) Token: 0x06025C50 RID: 154704 RVA: 0x003941FB File Offset: 0x003923FB
		// (set) Token: 0x06025C51 RID: 154705 RVA: 0x0039420B File Offset: 0x0039240B
		public unsafe EOutputPixelFormat OutputPixelFormat
		{
			get
			{
				return (EOutputPixelFormat)(*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_OutputPixelFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_OutputPixelFormat) = (byte)value;
			}
		}

		// Token: 0x1700916D RID: 37229
		// (get) Token: 0x06025C52 RID: 154706 RVA: 0x0039421C File Offset: 0x0039241C
		// (set) Token: 0x06025C53 RID: 154707 RVA: 0x0039422C File Offset: 0x0039242C
		public unsafe EOutputImageFileFormat OutputImageFileFormat
		{
			get
			{
				return (EOutputImageFileFormat)(*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_OutputImageFileFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_OutputImageFileFormat) = (byte)value;
			}
		}

		// Token: 0x1700916E RID: 37230
		// (get) Token: 0x06025C54 RID: 154708 RVA: 0x0039423D File Offset: 0x0039243D
		// (set) Token: 0x06025C55 RID: 154709 RVA: 0x0039424D File Offset: 0x0039244D
		public unsafe EOutputDDSCompressionType OutputDDSCompressionType
		{
			get
			{
				return (EOutputDDSCompressionType)(*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_OutputDDSCompressionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_OutputDDSCompressionType) = (byte)value;
			}
		}

		// Token: 0x1700916F RID: 37231
		// (get) Token: 0x06025C56 RID: 154710 RVA: 0x0039425E File Offset: 0x0039245E
		// (set) Token: 0x06025C57 RID: 154711 RVA: 0x0039426E File Offset: 0x0039246E
		public unsafe int RaysPerPixel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_RaysPerPixel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_RaysPerPixel) = value;
			}
		}

		// Token: 0x17009170 RID: 37232
		// (get) Token: 0x06025C58 RID: 154712 RVA: 0x0039427F File Offset: 0x0039247F
		// (set) Token: 0x06025C59 RID: 154713 RVA: 0x0039428F File Offset: 0x0039248F
		public unsafe float OcclusionFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_OcclusionFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_OcclusionFalloff) = value;
			}
		}

		// Token: 0x17009171 RID: 37233
		// (get) Token: 0x06025C5A RID: 154714 RVA: 0x003942A0 File Offset: 0x003924A0
		// (set) Token: 0x06025C5B RID: 154715 RVA: 0x003942B0 File Offset: 0x003924B0
		public unsafe float OcclusionMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_OcclusionMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_OcclusionMultiplier) = value;
			}
		}

		// Token: 0x17009172 RID: 37234
		// (get) Token: 0x06025C5C RID: 154716 RVA: 0x003942C1 File Offset: 0x003924C1
		// (set) Token: 0x06025C5D RID: 154717 RVA: 0x003942DA File Offset: 0x003924DA
		public unsafe bool UseSimpleOcclusionMode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_UseSimpleOcclusionMode) & FAmbientOcclusionCasterSettings.__PropertyMask_UseSimpleOcclusionMode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_UseSimpleOcclusionMode) = ((*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_UseSimpleOcclusionMode) & ~FAmbientOcclusionCasterSettings.__PropertyMask_UseSimpleOcclusionMode) | (value ? FAmbientOcclusionCasterSettings.__PropertyMask_UseSimpleOcclusionMode : 0));
			}
		}

		// Token: 0x17009173 RID: 37235
		// (get) Token: 0x06025C5E RID: 154718 RVA: 0x0039430A File Offset: 0x0039250A
		// (set) Token: 0x06025C5F RID: 154719 RVA: 0x00394323 File Offset: 0x00392523
		public unsafe bool FlipBackfacingNormals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_FlipBackfacingNormals) & FAmbientOcclusionCasterSettings.__PropertyMask_FlipBackfacingNormals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_FlipBackfacingNormals) = ((*(base.NativePtr + (IntPtr)FAmbientOcclusionCasterSettings.__PropertyOffset_FlipBackfacingNormals) & ~FAmbientOcclusionCasterSettings.__PropertyMask_FlipBackfacingNormals) | (value ? FAmbientOcclusionCasterSettings.__PropertyMask_FlipBackfacingNormals : 0));
			}
		}

		// Token: 0x06025C60 RID: 154720 RVA: 0x00394353 File Offset: 0x00392553
		public FAmbientOcclusionCasterSettings()
		{
		}

		// Token: 0x06025C61 RID: 154721 RVA: 0x0039435C File Offset: 0x0039255C
		public FAmbientOcclusionCasterSettings(string MaterialChannel, string OpacityChannel, EOpacityChannelComponent OpacityChannelComponent, EDitherType DitherType, EFillMode FillMode, int Dilation, bool UseMultisampling, EOutputPixelFormat OutputPixelFormat, EOutputImageFileFormat OutputImageFileFormat, EOutputDDSCompressionType OutputDDSCompressionType, int RaysPerPixel, float OcclusionFalloff, float OcclusionMultiplier, bool UseSimpleOcclusionMode, bool FlipBackfacingNormals)
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
			this.RaysPerPixel = RaysPerPixel;
			this.OcclusionFalloff = OcclusionFalloff;
			this.OcclusionMultiplier = OcclusionMultiplier;
			this.UseSimpleOcclusionMode = UseSimpleOcclusionMode;
			this.FlipBackfacingNormals = FlipBackfacingNormals;
		}

		// Token: 0x06025C62 RID: 154722 RVA: 0x003943E4 File Offset: 0x003925E4
		protected override IntPtr GetUStructPtr()
		{
			return FAmbientOcclusionCasterSettings.StaticStruct();
		}

		// Token: 0x06025C63 RID: 154723 RVA: 0x003943F0 File Offset: 0x003925F0
		[NullableContext(2)]
		public FAmbientOcclusionCasterSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025C64 RID: 154724 RVA: 0x003943FA File Offset: 0x003925FA
		public FAmbientOcclusionCasterSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025C65 RID: 154725 RVA: 0x00394405 File Offset: 0x00392605
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAmbientOcclusionCasterSettings(Pointer, false, true);
		}

		// Token: 0x06025C66 RID: 154726 RVA: 0x0039440F File Offset: 0x0039260F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAmbientOcclusionCasterSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040148F4 RID: 84212
		public const string __ObjectPath = "/Script/SimplygonUObjects.AmbientOcclusionCasterSettings";

		// Token: 0x040148F5 RID: 84213
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040148F6 RID: 84214
		internal static int __PropertyOffset_MaterialChannel;

		// Token: 0x040148F7 RID: 84215
		internal static int __PropertyOffset_OpacityChannel;

		// Token: 0x040148F8 RID: 84216
		internal static int __PropertyOffset_OpacityChannelComponent;

		// Token: 0x040148F9 RID: 84217
		internal static int __PropertyOffset_DitherType;

		// Token: 0x040148FA RID: 84218
		internal static int __PropertyOffset_FillMode;

		// Token: 0x040148FB RID: 84219
		internal static int __PropertyOffset_Dilation;

		// Token: 0x040148FC RID: 84220
		internal static int __PropertyOffset_UseMultisampling;

		// Token: 0x040148FD RID: 84221
		internal static byte __PropertyMask_UseMultisampling;

		// Token: 0x040148FE RID: 84222
		internal static int __PropertyOffset_OutputPixelFormat;

		// Token: 0x040148FF RID: 84223
		internal static int __PropertyOffset_OutputImageFileFormat;

		// Token: 0x04014900 RID: 84224
		internal static int __PropertyOffset_OutputDDSCompressionType;

		// Token: 0x04014901 RID: 84225
		internal static int __PropertyOffset_RaysPerPixel;

		// Token: 0x04014902 RID: 84226
		internal static int __PropertyOffset_OcclusionFalloff;

		// Token: 0x04014903 RID: 84227
		internal static int __PropertyOffset_OcclusionMultiplier;

		// Token: 0x04014904 RID: 84228
		internal static int __PropertyOffset_UseSimpleOcclusionMode;

		// Token: 0x04014905 RID: 84229
		internal static byte __PropertyMask_UseSimpleOcclusionMode;

		// Token: 0x04014906 RID: 84230
		internal static int __PropertyOffset_FlipBackfacingNormals;

		// Token: 0x04014907 RID: 84231
		internal static byte __PropertyMask_FlipBackfacingNormals;
	}
}
