using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001520 RID: 5408
	[UnrealObjectPath("/Script/ImposterManager.ImposterMeshData")]
	[UnrealStructLayout(176, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UImposterMeshData : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013AE8 RID: 80616 RVA: 0x001CE8FE File Offset: 0x001CCAFE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UImposterMeshData._ClassPtr;
		}

		// Token: 0x06013AE9 RID: 80617 RVA: 0x001CE90C File Offset: 0x001CCB0C
		public UImposterMeshData() : this(BuiltinUtils.AllocNativeUObject(UImposterMeshData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013AEA RID: 80618 RVA: 0x001CE934 File Offset: 0x001CCB34
		[NullableContext(1)]
		public UImposterMeshData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UImposterMeshData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D0B RID: 19723
		// (get) Token: 0x06013AEB RID: 80619 RVA: 0x001CE967 File Offset: 0x001CCB67
		// (set) Token: 0x06013AEC RID: 80620 RVA: 0x001CE977 File Offset: 0x001CCB77
		public unsafe float ImposterSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_ImposterSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_ImposterSize) = value;
			}
		}

		// Token: 0x17004D0C RID: 19724
		// (get) Token: 0x06013AED RID: 80621 RVA: 0x001CE988 File Offset: 0x001CCB88
		// (set) Token: 0x06013AEE RID: 80622 RVA: 0x001CE99C File Offset: 0x001CCB9C
		public unsafe FVector PivotOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_PivotOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_PivotOffset) = value;
			}
		}

		// Token: 0x17004D0D RID: 19725
		// (get) Token: 0x06013AEF RID: 80623 RVA: 0x001CE9B1 File Offset: 0x001CCBB1
		// (set) Token: 0x06013AF0 RID: 80624 RVA: 0x001CE9C5 File Offset: 0x001CCBC5
		public unsafe FVector4 SwitchDistances
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_SwitchDistances);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_SwitchDistances) = value;
			}
		}

		// Token: 0x17004D0E RID: 19726
		// (get) Token: 0x06013AF1 RID: 80625 RVA: 0x001CE9DA File Offset: 0x001CCBDA
		// (set) Token: 0x06013AF2 RID: 80626 RVA: 0x001CE9EA File Offset: 0x001CCBEA
		public unsafe int ViewCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_ViewCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_ViewCount) = value;
			}
		}

		// Token: 0x17004D0F RID: 19727
		// (get) Token: 0x06013AF3 RID: 80627 RVA: 0x001CE9FB File Offset: 0x001CCBFB
		// (set) Token: 0x06013AF4 RID: 80628 RVA: 0x001CEA0B File Offset: 0x001CCC0B
		public unsafe EImposterMappingMode MappingMode
		{
			get
			{
				return (EImposterMappingMode)(*(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_MappingMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_MappingMode) = (byte)value;
			}
		}

		// Token: 0x17004D10 RID: 19728
		// (get) Token: 0x06013AF5 RID: 80629 RVA: 0x001CEA1C File Offset: 0x001CCC1C
		// (set) Token: 0x06013AF6 RID: 80630 RVA: 0x001CEA2C File Offset: 0x001CCC2C
		public unsafe float TiltDegrees
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_TiltDegrees);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_TiltDegrees) = value;
			}
		}

		// Token: 0x17004D11 RID: 19729
		// (get) Token: 0x06013AF7 RID: 80631 RVA: 0x001CEA3D File Offset: 0x001CCC3D
		// (set) Token: 0x06013AF8 RID: 80632 RVA: 0x001CEA4D File Offset: 0x001CCC4D
		public unsafe bool bForceImposter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_bForceImposter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_bForceImposter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D12 RID: 19730
		// (get) Token: 0x06013AF9 RID: 80633 RVA: 0x001CEA5E File Offset: 0x001CCC5E
		// (set) Token: 0x06013AFA RID: 80634 RVA: 0x001CEA6E File Offset: 0x001CCC6E
		public unsafe bool bDisableShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_bDisableShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_bDisableShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D13 RID: 19731
		// (get) Token: 0x06013AFB RID: 80635 RVA: 0x001CEA7F File Offset: 0x001CCC7F
		// (set) Token: 0x06013AFC RID: 80636 RVA: 0x001CEA93 File Offset: 0x001CCC93
		public unsafe FLinearColor WinterLeafColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_WinterLeafColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_WinterLeafColor) = value;
			}
		}

		// Token: 0x17004D14 RID: 19732
		// (get) Token: 0x06013AFD RID: 80637 RVA: 0x001CEAA8 File Offset: 0x001CCCA8
		// (set) Token: 0x06013AFE RID: 80638 RVA: 0x001CEABC File Offset: 0x001CCCBC
		public unsafe FLinearColor SpringLeafColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_SpringLeafColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_SpringLeafColor) = value;
			}
		}

		// Token: 0x17004D15 RID: 19733
		// (get) Token: 0x06013AFF RID: 80639 RVA: 0x001CEAD1 File Offset: 0x001CCCD1
		// (set) Token: 0x06013B00 RID: 80640 RVA: 0x001CEAE5 File Offset: 0x001CCCE5
		public unsafe FLinearColor SummerLeafColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_SummerLeafColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_SummerLeafColor) = value;
			}
		}

		// Token: 0x17004D16 RID: 19734
		// (get) Token: 0x06013B01 RID: 80641 RVA: 0x001CEAFA File Offset: 0x001CCCFA
		// (set) Token: 0x06013B02 RID: 80642 RVA: 0x001CEB0E File Offset: 0x001CCD0E
		public unsafe FLinearColor AutumnLeafColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_AutumnLeafColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UImposterMeshData.__PropertyOffset_AutumnLeafColor) = value;
			}
		}

		// Token: 0x06013B03 RID: 80643 RVA: 0x001CEB23 File Offset: 0x001CCD23
		static UImposterMeshData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ImposterManager.ImposterMeshData");
		}

		// Token: 0x06013B04 RID: 80644 RVA: 0x001CEB31 File Offset: 0x001CCD31
		protected UImposterMeshData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AA0C RID: 43532
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ImposterManager.ImposterMeshData";

		// Token: 0x0400AA0D RID: 43533
		private static IntPtr _ClassPtr;

		// Token: 0x0400AA0E RID: 43534
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AA0F RID: 43535
		internal static int __PropertyOffset_ImposterSize;

		// Token: 0x0400AA10 RID: 43536
		internal static int __PropertyOffset_PivotOffset;

		// Token: 0x0400AA11 RID: 43537
		internal static int __PropertyOffset_SwitchDistances;

		// Token: 0x0400AA12 RID: 43538
		internal static int __PropertyOffset_ViewCount;

		// Token: 0x0400AA13 RID: 43539
		internal static int __PropertyOffset_MappingMode;

		// Token: 0x0400AA14 RID: 43540
		internal static int __PropertyOffset_TiltDegrees;

		// Token: 0x0400AA15 RID: 43541
		internal static int __PropertyOffset_bForceImposter;

		// Token: 0x0400AA16 RID: 43542
		internal static int __PropertyOffset_bDisableShadow;

		// Token: 0x0400AA17 RID: 43543
		internal static int __PropertyOffset_WinterLeafColor;

		// Token: 0x0400AA18 RID: 43544
		internal static int __PropertyOffset_SpringLeafColor;

		// Token: 0x0400AA19 RID: 43545
		internal static int __PropertyOffset_SummerLeafColor;

		// Token: 0x0400AA1A RID: 43546
		internal static int __PropertyOffset_AutumnLeafColor;
	}
}
