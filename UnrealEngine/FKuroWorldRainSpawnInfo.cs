using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BEF RID: 7151
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainSpawnInfo")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FKuroWorldRainSpawnInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B864 RID: 112740 RVA: 0x002887A0 File Offset: 0x002869A0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroWorldRainSpawnInfo._ScriptStructPtr != 0) ? FKuroWorldRainSpawnInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainSpawnInfo", ref FKuroWorldRainSpawnInfo._ScriptStructPtr);
		}

		// Token: 0x17006ECF RID: 28367
		// (get) Token: 0x0601B865 RID: 112741 RVA: 0x002887C4 File Offset: 0x002869C4
		// (set) Token: 0x0601B866 RID: 112742 RVA: 0x002887D8 File Offset: 0x002869D8
		public unsafe UStaticMesh RainMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroWorldRainSpawnInfo.__PropertyOffset_RainMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroWorldRainSpawnInfo.__PropertyOffset_RainMesh, value);
			}
		}

		// Token: 0x17006ED0 RID: 28368
		// (get) Token: 0x0601B867 RID: 112743 RVA: 0x002887ED File Offset: 0x002869ED
		// (set) Token: 0x0601B868 RID: 112744 RVA: 0x00288801 File Offset: 0x00286A01
		public unsafe UMaterialInterface RainMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroWorldRainSpawnInfo.__PropertyOffset_RainMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroWorldRainSpawnInfo.__PropertyOffset_RainMaterial, value);
			}
		}

		// Token: 0x17006ED1 RID: 28369
		// (get) Token: 0x0601B869 RID: 112745 RVA: 0x00288816 File Offset: 0x00286A16
		// (set) Token: 0x0601B86A RID: 112746 RVA: 0x0028882A File Offset: 0x00286A2A
		public unsafe UMaterialInterface RainMaterialDesktop
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroWorldRainSpawnInfo.__PropertyOffset_RainMaterialDesktop);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroWorldRainSpawnInfo.__PropertyOffset_RainMaterialDesktop, value);
			}
		}

		// Token: 0x17006ED2 RID: 28370
		// (get) Token: 0x0601B86B RID: 112747 RVA: 0x0028883F File Offset: 0x00286A3F
		// (set) Token: 0x0601B86C RID: 112748 RVA: 0x0028884F File Offset: 0x00286A4F
		public unsafe int ArraySizeXY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_ArraySizeXY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_ArraySizeXY) = value;
			}
		}

		// Token: 0x17006ED3 RID: 28371
		// (get) Token: 0x0601B86D RID: 112749 RVA: 0x00288860 File Offset: 0x00286A60
		// (set) Token: 0x0601B86E RID: 112750 RVA: 0x00288870 File Offset: 0x00286A70
		public unsafe int ArraySizeZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_ArraySizeZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_ArraySizeZ) = value;
			}
		}

		// Token: 0x17006ED4 RID: 28372
		// (get) Token: 0x0601B86F RID: 112751 RVA: 0x00288881 File Offset: 0x00286A81
		// (set) Token: 0x0601B870 RID: 112752 RVA: 0x00288891 File Offset: 0x00286A91
		public unsafe float SpawnRangeXY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_SpawnRangeXY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_SpawnRangeXY) = value;
			}
		}

		// Token: 0x17006ED5 RID: 28373
		// (get) Token: 0x0601B871 RID: 112753 RVA: 0x002888A2 File Offset: 0x00286AA2
		// (set) Token: 0x0601B872 RID: 112754 RVA: 0x002888B2 File Offset: 0x00286AB2
		public unsafe float SpawnRangeZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_SpawnRangeZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_SpawnRangeZ) = value;
			}
		}

		// Token: 0x17006ED6 RID: 28374
		// (get) Token: 0x0601B873 RID: 112755 RVA: 0x002888C3 File Offset: 0x00286AC3
		// (set) Token: 0x0601B874 RID: 112756 RVA: 0x002888D3 File Offset: 0x00286AD3
		public unsafe float SpawnRateSingle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_SpawnRateSingle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_SpawnRateSingle) = value;
			}
		}

		// Token: 0x17006ED7 RID: 28375
		// (get) Token: 0x0601B875 RID: 112757 RVA: 0x002888E4 File Offset: 0x00286AE4
		// (set) Token: 0x0601B876 RID: 112758 RVA: 0x002888F4 File Offset: 0x00286AF4
		public unsafe float SpawnTimeWiggleNormalized
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_SpawnTimeWiggleNormalized);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_SpawnTimeWiggleNormalized) = value;
			}
		}

		// Token: 0x17006ED8 RID: 28376
		// (get) Token: 0x0601B877 RID: 112759 RVA: 0x00288905 File Offset: 0x00286B05
		// (set) Token: 0x0601B878 RID: 112760 RVA: 0x00288915 File Offset: 0x00286B15
		public unsafe float SpawnPositionWiggleNormalized
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_SpawnPositionWiggleNormalized);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_SpawnPositionWiggleNormalized) = value;
			}
		}

		// Token: 0x17006ED9 RID: 28377
		// (get) Token: 0x0601B879 RID: 112761 RVA: 0x00288926 File Offset: 0x00286B26
		// (set) Token: 0x0601B87A RID: 112762 RVA: 0x0028893A File Offset: 0x00286B3A
		public unsafe FVector2D LifeTimeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_LifeTimeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_LifeTimeRange) = value;
			}
		}

		// Token: 0x17006EDA RID: 28378
		// (get) Token: 0x0601B87B RID: 112763 RVA: 0x0028894F File Offset: 0x00286B4F
		// (set) Token: 0x0601B87C RID: 112764 RVA: 0x00288963 File Offset: 0x00286B63
		public unsafe FVector2D ScaleRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_ScaleRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_ScaleRange) = value;
			}
		}

		// Token: 0x17006EDB RID: 28379
		// (get) Token: 0x0601B87D RID: 112765 RVA: 0x00288978 File Offset: 0x00286B78
		// (set) Token: 0x0601B87E RID: 112766 RVA: 0x0028898C File Offset: 0x00286B8C
		public unsafe FVector2D MassRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_MassRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_MassRange) = value;
			}
		}

		// Token: 0x17006EDC RID: 28380
		// (get) Token: 0x0601B87F RID: 112767 RVA: 0x002889A1 File Offset: 0x00286BA1
		// (set) Token: 0x0601B880 RID: 112768 RVA: 0x002889B5 File Offset: 0x00286BB5
		public unsafe FVector2D TimeScaleRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_TimeScaleRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_TimeScaleRange) = value;
			}
		}

		// Token: 0x17006EDD RID: 28381
		// (get) Token: 0x0601B881 RID: 112769 RVA: 0x002889CA File Offset: 0x00286BCA
		// (set) Token: 0x0601B882 RID: 112770 RVA: 0x002889DA File Offset: 0x00286BDA
		public unsafe float MobileSpawnScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_MobileSpawnScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWorldRainSpawnInfo.__PropertyOffset_MobileSpawnScale) = value;
			}
		}

		// Token: 0x0601B883 RID: 112771 RVA: 0x002889EB File Offset: 0x00286BEB
		public FKuroWorldRainSpawnInfo()
		{
		}

		// Token: 0x0601B884 RID: 112772 RVA: 0x002889F4 File Offset: 0x00286BF4
		[NullableContext(1)]
		public FKuroWorldRainSpawnInfo(UStaticMesh RainMesh, UMaterialInterface RainMaterial, UMaterialInterface RainMaterialDesktop, int ArraySizeXY, int ArraySizeZ, float SpawnRangeXY, float SpawnRangeZ, float SpawnRateSingle, float SpawnTimeWiggleNormalized, float SpawnPositionWiggleNormalized, FVector2D LifeTimeRange, FVector2D ScaleRange, FVector2D MassRange, FVector2D TimeScaleRange, float MobileSpawnScale)
		{
			this.RainMesh = RainMesh;
			this.RainMaterial = RainMaterial;
			this.RainMaterialDesktop = RainMaterialDesktop;
			this.ArraySizeXY = ArraySizeXY;
			this.ArraySizeZ = ArraySizeZ;
			this.SpawnRangeXY = SpawnRangeXY;
			this.SpawnRangeZ = SpawnRangeZ;
			this.SpawnRateSingle = SpawnRateSingle;
			this.SpawnTimeWiggleNormalized = SpawnTimeWiggleNormalized;
			this.SpawnPositionWiggleNormalized = SpawnPositionWiggleNormalized;
			this.LifeTimeRange = LifeTimeRange;
			this.ScaleRange = ScaleRange;
			this.MassRange = MassRange;
			this.TimeScaleRange = TimeScaleRange;
			this.MobileSpawnScale = MobileSpawnScale;
		}

		// Token: 0x0601B885 RID: 112773 RVA: 0x00288A7C File Offset: 0x00286C7C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroWorldRainSpawnInfo.StaticStruct();
		}

		// Token: 0x0601B886 RID: 112774 RVA: 0x00288A88 File Offset: 0x00286C88
		public FKuroWorldRainSpawnInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B887 RID: 112775 RVA: 0x00288A92 File Offset: 0x00286C92
		public FKuroWorldRainSpawnInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B888 RID: 112776 RVA: 0x00288A9D File Offset: 0x00286C9D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroWorldRainSpawnInfo(Pointer, false, true);
		}

		// Token: 0x0601B889 RID: 112777 RVA: 0x00288AA7 File Offset: 0x00286CA7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroWorldRainSpawnInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400ECF4 RID: 60660
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainSpawnInfo";

		// Token: 0x0400ECF5 RID: 60661
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400ECF6 RID: 60662
		internal static int __PropertyOffset_RainMesh;

		// Token: 0x0400ECF7 RID: 60663
		internal static int __PropertyOffset_RainMaterial;

		// Token: 0x0400ECF8 RID: 60664
		internal static int __PropertyOffset_RainMaterialDesktop;

		// Token: 0x0400ECF9 RID: 60665
		internal static int __PropertyOffset_ArraySizeXY;

		// Token: 0x0400ECFA RID: 60666
		internal static int __PropertyOffset_ArraySizeZ;

		// Token: 0x0400ECFB RID: 60667
		internal static int __PropertyOffset_SpawnRangeXY;

		// Token: 0x0400ECFC RID: 60668
		internal static int __PropertyOffset_SpawnRangeZ;

		// Token: 0x0400ECFD RID: 60669
		internal static int __PropertyOffset_SpawnRateSingle;

		// Token: 0x0400ECFE RID: 60670
		internal static int __PropertyOffset_SpawnTimeWiggleNormalized;

		// Token: 0x0400ECFF RID: 60671
		internal static int __PropertyOffset_SpawnPositionWiggleNormalized;

		// Token: 0x0400ED00 RID: 60672
		internal static int __PropertyOffset_LifeTimeRange;

		// Token: 0x0400ED01 RID: 60673
		internal static int __PropertyOffset_ScaleRange;

		// Token: 0x0400ED02 RID: 60674
		internal static int __PropertyOffset_MassRange;

		// Token: 0x0400ED03 RID: 60675
		internal static int __PropertyOffset_TimeScaleRange;

		// Token: 0x0400ED04 RID: 60676
		internal static int __PropertyOffset_MobileSpawnScale;
	}
}
