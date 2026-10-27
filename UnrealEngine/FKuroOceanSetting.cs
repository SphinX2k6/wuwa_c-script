using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B87 RID: 7047
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroOceanSetting")]
	[UnrealStructLayout(128, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FKuroOceanSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601ABC2 RID: 109506 RVA: 0x0027639B File Offset: 0x0027459B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroOceanSetting._ScriptStructPtr != 0) ? FKuroOceanSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroOceanSetting", ref FKuroOceanSetting._ScriptStructPtr);
		}

		// Token: 0x17006B86 RID: 27526
		// (get) Token: 0x0601ABC3 RID: 109507 RVA: 0x002763BF File Offset: 0x002745BF
		// (set) Token: 0x0601ABC4 RID: 109508 RVA: 0x002763D8 File Offset: 0x002745D8
		public unsafe bool bOverride_WaveTextureHeight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_WaveTextureHeight) & FKuroOceanSetting.__PropertyMask_bOverride_WaveTextureHeight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_WaveTextureHeight) = ((*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_WaveTextureHeight) & ~FKuroOceanSetting.__PropertyMask_bOverride_WaveTextureHeight) | (value ? FKuroOceanSetting.__PropertyMask_bOverride_WaveTextureHeight : 0));
			}
		}

		// Token: 0x17006B87 RID: 27527
		// (get) Token: 0x0601ABC5 RID: 109509 RVA: 0x00276408 File Offset: 0x00274608
		// (set) Token: 0x0601ABC6 RID: 109510 RVA: 0x00276421 File Offset: 0x00274621
		public unsafe bool bOverride_WaveTextureDecodeNormal
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_WaveTextureDecodeNormal) & FKuroOceanSetting.__PropertyMask_bOverride_WaveTextureDecodeNormal) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_WaveTextureDecodeNormal) = ((*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_WaveTextureDecodeNormal) & ~FKuroOceanSetting.__PropertyMask_bOverride_WaveTextureDecodeNormal) | (value ? FKuroOceanSetting.__PropertyMask_bOverride_WaveTextureDecodeNormal : 0));
			}
		}

		// Token: 0x17006B88 RID: 27528
		// (get) Token: 0x0601ABC7 RID: 109511 RVA: 0x00276451 File Offset: 0x00274651
		// (set) Token: 0x0601ABC8 RID: 109512 RVA: 0x0027646A File Offset: 0x0027466A
		public unsafe bool bOverride_WaveTextureFoamScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_WaveTextureFoamScale) & FKuroOceanSetting.__PropertyMask_bOverride_WaveTextureFoamScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_WaveTextureFoamScale) = ((*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_WaveTextureFoamScale) & ~FKuroOceanSetting.__PropertyMask_bOverride_WaveTextureFoamScale) | (value ? FKuroOceanSetting.__PropertyMask_bOverride_WaveTextureFoamScale : 0));
			}
		}

		// Token: 0x17006B89 RID: 27529
		// (get) Token: 0x0601ABC9 RID: 109513 RVA: 0x0027649A File Offset: 0x0027469A
		// (set) Token: 0x0601ABCA RID: 109514 RVA: 0x002764B3 File Offset: 0x002746B3
		public unsafe bool bOverride_WaveTextureWind
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_WaveTextureWind) & FKuroOceanSetting.__PropertyMask_bOverride_WaveTextureWind) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_WaveTextureWind) = ((*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_WaveTextureWind) & ~FKuroOceanSetting.__PropertyMask_bOverride_WaveTextureWind) | (value ? FKuroOceanSetting.__PropertyMask_bOverride_WaveTextureWind : 0));
			}
		}

		// Token: 0x17006B8A RID: 27530
		// (get) Token: 0x0601ABCB RID: 109515 RVA: 0x002764E3 File Offset: 0x002746E3
		// (set) Token: 0x0601ABCC RID: 109516 RVA: 0x002764FC File Offset: 0x002746FC
		public unsafe bool bOverride_OceanFoamColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_OceanFoamColor) & FKuroOceanSetting.__PropertyMask_bOverride_OceanFoamColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_OceanFoamColor) = ((*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_OceanFoamColor) & ~FKuroOceanSetting.__PropertyMask_bOverride_OceanFoamColor) | (value ? FKuroOceanSetting.__PropertyMask_bOverride_OceanFoamColor : 0));
			}
		}

		// Token: 0x17006B8B RID: 27531
		// (get) Token: 0x0601ABCD RID: 109517 RVA: 0x0027652C File Offset: 0x0027472C
		// (set) Token: 0x0601ABCE RID: 109518 RVA: 0x00276545 File Offset: 0x00274745
		public unsafe bool bOverride_ScatteringColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_ScatteringColor) & FKuroOceanSetting.__PropertyMask_bOverride_ScatteringColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_ScatteringColor) = ((*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_ScatteringColor) & ~FKuroOceanSetting.__PropertyMask_bOverride_ScatteringColor) | (value ? FKuroOceanSetting.__PropertyMask_bOverride_ScatteringColor : 0));
			}
		}

		// Token: 0x17006B8C RID: 27532
		// (get) Token: 0x0601ABCF RID: 109519 RVA: 0x00276575 File Offset: 0x00274775
		// (set) Token: 0x0601ABD0 RID: 109520 RVA: 0x0027658E File Offset: 0x0027478E
		public unsafe bool bOverride_ScatteringShoreline
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_ScatteringShoreline) & FKuroOceanSetting.__PropertyMask_bOverride_ScatteringShoreline) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_ScatteringShoreline) = ((*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_ScatteringShoreline) & ~FKuroOceanSetting.__PropertyMask_bOverride_ScatteringShoreline) | (value ? FKuroOceanSetting.__PropertyMask_bOverride_ScatteringShoreline : 0));
			}
		}

		// Token: 0x17006B8D RID: 27533
		// (get) Token: 0x0601ABD1 RID: 109521 RVA: 0x002765BE File Offset: 0x002747BE
		// (set) Token: 0x0601ABD2 RID: 109522 RVA: 0x002765D7 File Offset: 0x002747D7
		public unsafe bool bOverride_AbsorptionColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_AbsorptionColor) & FKuroOceanSetting.__PropertyMask_bOverride_AbsorptionColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_AbsorptionColor) = ((*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_AbsorptionColor) & ~FKuroOceanSetting.__PropertyMask_bOverride_AbsorptionColor) | (value ? FKuroOceanSetting.__PropertyMask_bOverride_AbsorptionColor : 0));
			}
		}

		// Token: 0x17006B8E RID: 27534
		// (get) Token: 0x0601ABD3 RID: 109523 RVA: 0x00276607 File Offset: 0x00274807
		// (set) Token: 0x0601ABD4 RID: 109524 RVA: 0x00276620 File Offset: 0x00274820
		public unsafe bool bOverride_ColorScaleBehindWater
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_ColorScaleBehindWater) & FKuroOceanSetting.__PropertyMask_bOverride_ColorScaleBehindWater) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_ColorScaleBehindWater) = ((*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_ColorScaleBehindWater) & ~FKuroOceanSetting.__PropertyMask_bOverride_ColorScaleBehindWater) | (value ? FKuroOceanSetting.__PropertyMask_bOverride_ColorScaleBehindWater : 0));
			}
		}

		// Token: 0x17006B8F RID: 27535
		// (get) Token: 0x0601ABD5 RID: 109525 RVA: 0x00276650 File Offset: 0x00274850
		// (set) Token: 0x0601ABD6 RID: 109526 RVA: 0x00276669 File Offset: 0x00274869
		public unsafe bool bOverride_WaterColorTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_WaterColorTint) & FKuroOceanSetting.__PropertyMask_bOverride_WaterColorTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_WaterColorTint) = ((*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_bOverride_WaterColorTint) & ~FKuroOceanSetting.__PropertyMask_bOverride_WaterColorTint) | (value ? FKuroOceanSetting.__PropertyMask_bOverride_WaterColorTint : 0));
			}
		}

		// Token: 0x17006B90 RID: 27536
		// (get) Token: 0x0601ABD7 RID: 109527 RVA: 0x00276699 File Offset: 0x00274899
		// (set) Token: 0x0601ABD8 RID: 109528 RVA: 0x002766A9 File Offset: 0x002748A9
		public unsafe float WaveTextureHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_WaveTextureHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_WaveTextureHeight) = value;
			}
		}

		// Token: 0x17006B91 RID: 27537
		// (get) Token: 0x0601ABD9 RID: 109529 RVA: 0x002766BA File Offset: 0x002748BA
		// (set) Token: 0x0601ABDA RID: 109530 RVA: 0x002766CA File Offset: 0x002748CA
		public unsafe float WaveTextureDecodeNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_WaveTextureDecodeNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_WaveTextureDecodeNormal) = value;
			}
		}

		// Token: 0x17006B92 RID: 27538
		// (get) Token: 0x0601ABDB RID: 109531 RVA: 0x002766DB File Offset: 0x002748DB
		// (set) Token: 0x0601ABDC RID: 109532 RVA: 0x002766EB File Offset: 0x002748EB
		public unsafe float WaveTextureFoamScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_WaveTextureFoamScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_WaveTextureFoamScale) = value;
			}
		}

		// Token: 0x17006B93 RID: 27539
		// (get) Token: 0x0601ABDD RID: 109533 RVA: 0x002766FC File Offset: 0x002748FC
		// (set) Token: 0x0601ABDE RID: 109534 RVA: 0x00276710 File Offset: 0x00274910
		public unsafe FLinearColor WaveTextureWind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_WaveTextureWind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_WaveTextureWind) = value;
			}
		}

		// Token: 0x17006B94 RID: 27540
		// (get) Token: 0x0601ABDF RID: 109535 RVA: 0x00276725 File Offset: 0x00274925
		// (set) Token: 0x0601ABE0 RID: 109536 RVA: 0x00276739 File Offset: 0x00274939
		public unsafe FLinearColor OceanFoamColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_OceanFoamColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_OceanFoamColor) = value;
			}
		}

		// Token: 0x17006B95 RID: 27541
		// (get) Token: 0x0601ABE1 RID: 109537 RVA: 0x0027674E File Offset: 0x0027494E
		// (set) Token: 0x0601ABE2 RID: 109538 RVA: 0x00276762 File Offset: 0x00274962
		public unsafe FLinearColor ScatteringColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_ScatteringColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_ScatteringColor) = value;
			}
		}

		// Token: 0x17006B96 RID: 27542
		// (get) Token: 0x0601ABE3 RID: 109539 RVA: 0x00276777 File Offset: 0x00274977
		// (set) Token: 0x0601ABE4 RID: 109540 RVA: 0x0027678B File Offset: 0x0027498B
		public unsafe FLinearColor ScatteringShoreline
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_ScatteringShoreline);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_ScatteringShoreline) = value;
			}
		}

		// Token: 0x17006B97 RID: 27543
		// (get) Token: 0x0601ABE5 RID: 109541 RVA: 0x002767A0 File Offset: 0x002749A0
		// (set) Token: 0x0601ABE6 RID: 109542 RVA: 0x002767B4 File Offset: 0x002749B4
		public unsafe FLinearColor AbsorptionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_AbsorptionColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_AbsorptionColor) = value;
			}
		}

		// Token: 0x17006B98 RID: 27544
		// (get) Token: 0x0601ABE7 RID: 109543 RVA: 0x002767C9 File Offset: 0x002749C9
		// (set) Token: 0x0601ABE8 RID: 109544 RVA: 0x002767DD File Offset: 0x002749DD
		public unsafe FLinearColor ColorScaleBehindWater
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_ColorScaleBehindWater);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_ColorScaleBehindWater) = value;
			}
		}

		// Token: 0x17006B99 RID: 27545
		// (get) Token: 0x0601ABE9 RID: 109545 RVA: 0x002767F2 File Offset: 0x002749F2
		// (set) Token: 0x0601ABEA RID: 109546 RVA: 0x00276806 File Offset: 0x00274A06
		public unsafe FLinearColor WaterColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_WaterColorTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroOceanSetting.__PropertyOffset_WaterColorTint) = value;
			}
		}

		// Token: 0x0601ABEB RID: 109547 RVA: 0x0027681B File Offset: 0x00274A1B
		public FKuroOceanSetting()
		{
		}

		// Token: 0x0601ABEC RID: 109548 RVA: 0x00276824 File Offset: 0x00274A24
		public FKuroOceanSetting(bool bOverride_WaveTextureHeight, bool bOverride_WaveTextureDecodeNormal, bool bOverride_WaveTextureFoamScale, bool bOverride_WaveTextureWind, bool bOverride_OceanFoamColor, bool bOverride_ScatteringColor, bool bOverride_ScatteringShoreline, bool bOverride_AbsorptionColor, bool bOverride_ColorScaleBehindWater, bool bOverride_WaterColorTint, float WaveTextureHeight, float WaveTextureDecodeNormal, float WaveTextureFoamScale, FLinearColor WaveTextureWind, FLinearColor OceanFoamColor, FLinearColor ScatteringColor, FLinearColor ScatteringShoreline, FLinearColor AbsorptionColor, FLinearColor ColorScaleBehindWater, FLinearColor WaterColorTint)
		{
			this.bOverride_WaveTextureHeight = bOverride_WaveTextureHeight;
			this.bOverride_WaveTextureDecodeNormal = bOverride_WaveTextureDecodeNormal;
			this.bOverride_WaveTextureFoamScale = bOverride_WaveTextureFoamScale;
			this.bOverride_WaveTextureWind = bOverride_WaveTextureWind;
			this.bOverride_OceanFoamColor = bOverride_OceanFoamColor;
			this.bOverride_ScatteringColor = bOverride_ScatteringColor;
			this.bOverride_ScatteringShoreline = bOverride_ScatteringShoreline;
			this.bOverride_AbsorptionColor = bOverride_AbsorptionColor;
			this.bOverride_ColorScaleBehindWater = bOverride_ColorScaleBehindWater;
			this.bOverride_WaterColorTint = bOverride_WaterColorTint;
			this.WaveTextureHeight = WaveTextureHeight;
			this.WaveTextureDecodeNormal = WaveTextureDecodeNormal;
			this.WaveTextureFoamScale = WaveTextureFoamScale;
			this.WaveTextureWind = WaveTextureWind;
			this.OceanFoamColor = OceanFoamColor;
			this.ScatteringColor = ScatteringColor;
			this.ScatteringShoreline = ScatteringShoreline;
			this.AbsorptionColor = AbsorptionColor;
			this.ColorScaleBehindWater = ColorScaleBehindWater;
			this.WaterColorTint = WaterColorTint;
		}

		// Token: 0x0601ABED RID: 109549 RVA: 0x002768D4 File Offset: 0x00274AD4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroOceanSetting.StaticStruct();
		}

		// Token: 0x0601ABEE RID: 109550 RVA: 0x002768E0 File Offset: 0x00274AE0
		[NullableContext(2)]
		public FKuroOceanSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601ABEF RID: 109551 RVA: 0x002768EA File Offset: 0x00274AEA
		public FKuroOceanSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601ABF0 RID: 109552 RVA: 0x002768F5 File Offset: 0x00274AF5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroOceanSetting(Pointer, false, true);
		}

		// Token: 0x0601ABF1 RID: 109553 RVA: 0x002768FF File Offset: 0x00274AFF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroOceanSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400E765 RID: 59237
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroOceanSetting";

		// Token: 0x0400E766 RID: 59238
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E767 RID: 59239
		internal static int __PropertyOffset_bOverride_WaveTextureHeight;

		// Token: 0x0400E768 RID: 59240
		internal static byte __PropertyMask_bOverride_WaveTextureHeight;

		// Token: 0x0400E769 RID: 59241
		internal static int __PropertyOffset_bOverride_WaveTextureDecodeNormal;

		// Token: 0x0400E76A RID: 59242
		internal static byte __PropertyMask_bOverride_WaveTextureDecodeNormal;

		// Token: 0x0400E76B RID: 59243
		internal static int __PropertyOffset_bOverride_WaveTextureFoamScale;

		// Token: 0x0400E76C RID: 59244
		internal static byte __PropertyMask_bOverride_WaveTextureFoamScale;

		// Token: 0x0400E76D RID: 59245
		internal static int __PropertyOffset_bOverride_WaveTextureWind;

		// Token: 0x0400E76E RID: 59246
		internal static byte __PropertyMask_bOverride_WaveTextureWind;

		// Token: 0x0400E76F RID: 59247
		internal static int __PropertyOffset_bOverride_OceanFoamColor;

		// Token: 0x0400E770 RID: 59248
		internal static byte __PropertyMask_bOverride_OceanFoamColor;

		// Token: 0x0400E771 RID: 59249
		internal static int __PropertyOffset_bOverride_ScatteringColor;

		// Token: 0x0400E772 RID: 59250
		internal static byte __PropertyMask_bOverride_ScatteringColor;

		// Token: 0x0400E773 RID: 59251
		internal static int __PropertyOffset_bOverride_ScatteringShoreline;

		// Token: 0x0400E774 RID: 59252
		internal static byte __PropertyMask_bOverride_ScatteringShoreline;

		// Token: 0x0400E775 RID: 59253
		internal static int __PropertyOffset_bOverride_AbsorptionColor;

		// Token: 0x0400E776 RID: 59254
		internal static byte __PropertyMask_bOverride_AbsorptionColor;

		// Token: 0x0400E777 RID: 59255
		internal static int __PropertyOffset_bOverride_ColorScaleBehindWater;

		// Token: 0x0400E778 RID: 59256
		internal static byte __PropertyMask_bOverride_ColorScaleBehindWater;

		// Token: 0x0400E779 RID: 59257
		internal static int __PropertyOffset_bOverride_WaterColorTint;

		// Token: 0x0400E77A RID: 59258
		internal static byte __PropertyMask_bOverride_WaterColorTint;

		// Token: 0x0400E77B RID: 59259
		internal static int __PropertyOffset_WaveTextureHeight;

		// Token: 0x0400E77C RID: 59260
		internal static int __PropertyOffset_WaveTextureDecodeNormal;

		// Token: 0x0400E77D RID: 59261
		internal static int __PropertyOffset_WaveTextureFoamScale;

		// Token: 0x0400E77E RID: 59262
		internal static int __PropertyOffset_WaveTextureWind;

		// Token: 0x0400E77F RID: 59263
		internal static int __PropertyOffset_OceanFoamColor;

		// Token: 0x0400E780 RID: 59264
		internal static int __PropertyOffset_ScatteringColor;

		// Token: 0x0400E781 RID: 59265
		internal static int __PropertyOffset_ScatteringShoreline;

		// Token: 0x0400E782 RID: 59266
		internal static int __PropertyOffset_AbsorptionColor;

		// Token: 0x0400E783 RID: 59267
		internal static int __PropertyOffset_ColorScaleBehindWater;

		// Token: 0x0400E784 RID: 59268
		internal static int __PropertyOffset_WaterColorTint;
	}
}
