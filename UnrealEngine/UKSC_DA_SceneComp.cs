using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DA9 RID: 7593
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_SceneComp")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UKSC_DA_SceneComp : UKSC_DA_CompBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D06E RID: 118894 RVA: 0x002AE682 File Offset: 0x002AC882
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_SceneComp._ClassPtr;
		}

		// Token: 0x0601D06F RID: 118895 RVA: 0x002AE690 File Offset: 0x002AC890
		public UKSC_DA_SceneComp() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_SceneComp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D070 RID: 118896 RVA: 0x002AE6B8 File Offset: 0x002AC8B8
		public UKSC_DA_SceneComp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_SceneComp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007516 RID: 29974
		// (get) Token: 0x0601D071 RID: 118897 RVA: 0x002AE6EB File Offset: 0x002AC8EB
		// (set) Token: 0x0601D072 RID: 118898 RVA: 0x002AE6FB File Offset: 0x002AC8FB
		public unsafe EKSC_SearchType SelfNeighborsType
		{
			get
			{
				return (EKSC_SearchType)(*(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_SelfNeighborsType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_SelfNeighborsType) = (byte)value;
			}
		}

		// Token: 0x17007517 RID: 29975
		// (get) Token: 0x0601D073 RID: 118899 RVA: 0x002AE70C File Offset: 0x002AC90C
		// (set) Token: 0x0601D074 RID: 118900 RVA: 0x002AE745 File Offset: 0x002AC945
		public TArray<EKSC_SearchType> TargetNeighborsTypes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKSC_SearchType> result;
				if ((result = this._TargetNeighborsTypes) == null)
				{
					result = (this._TargetNeighborsTypes = new TArray<EKSC_SearchType>(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_TargetNeighborsTypes, this));
				}
				return result;
			}
			set
			{
				this.TargetNeighborsTypes.CopyAssign(value);
			}
		}

		// Token: 0x17007518 RID: 29976
		// (get) Token: 0x0601D075 RID: 118901 RVA: 0x002AE753 File Offset: 0x002AC953
		// (set) Token: 0x0601D076 RID: 118902 RVA: 0x002AE763 File Offset: 0x002AC963
		public unsafe float NeighborDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_NeighborDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_NeighborDist) = value;
			}
		}

		// Token: 0x17007519 RID: 29977
		// (get) Token: 0x0601D077 RID: 118903 RVA: 0x002AE774 File Offset: 0x002AC974
		// (set) Token: 0x0601D078 RID: 118904 RVA: 0x002AE784 File Offset: 0x002AC984
		public unsafe int MaxNeighborsNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_MaxNeighborsNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_MaxNeighborsNum) = value;
			}
		}

		// Token: 0x1700751A RID: 29978
		// (get) Token: 0x0601D079 RID: 118905 RVA: 0x002AE795 File Offset: 0x002AC995
		// (set) Token: 0x0601D07A RID: 118906 RVA: 0x002AE7A5 File Offset: 0x002AC9A5
		public unsafe float ColliderRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_ColliderRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_ColliderRadius) = value;
			}
		}

		// Token: 0x1700751B RID: 29979
		// (get) Token: 0x0601D07B RID: 118907 RVA: 0x002AE7B6 File Offset: 0x002AC9B6
		// (set) Token: 0x0601D07C RID: 118908 RVA: 0x002AE7C6 File Offset: 0x002AC9C6
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_Mass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_Mass) = value;
			}
		}

		// Token: 0x1700751C RID: 29980
		// (get) Token: 0x0601D07D RID: 118909 RVA: 0x002AE7D7 File Offset: 0x002AC9D7
		// (set) Token: 0x0601D07E RID: 118910 RVA: 0x002AE7E7 File Offset: 0x002AC9E7
		public unsafe bool bEnableCapsuleComponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_bEnableCapsuleComponent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_bEnableCapsuleComponent) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700751D RID: 29981
		// (get) Token: 0x0601D07F RID: 118911 RVA: 0x002AE7F8 File Offset: 0x002AC9F8
		// (set) Token: 0x0601D080 RID: 118912 RVA: 0x002AE808 File Offset: 0x002ACA08
		public unsafe bool bIgnoreUpdateOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_bIgnoreUpdateOverlap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_bIgnoreUpdateOverlap) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700751E RID: 29982
		// (get) Token: 0x0601D081 RID: 118913 RVA: 0x002AE819 File Offset: 0x002ACA19
		// (set) Token: 0x0601D082 RID: 118914 RVA: 0x002AE829 File Offset: 0x002ACA29
		public unsafe bool OverrideNeighborCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_OverrideNeighborCenter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_OverrideNeighborCenter) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700751F RID: 29983
		// (get) Token: 0x0601D083 RID: 118915 RVA: 0x002AE83C File Offset: 0x002ACA3C
		// (set) Token: 0x0601D084 RID: 118916 RVA: 0x002AE875 File Offset: 0x002ACA75
		public FKSC_Range OverrideNeighborRange
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_Range result;
				if ((result = this._OverrideNeighborRange) == null)
				{
					result = (this._OverrideNeighborRange = new FKSC_Range(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_OverrideNeighborRange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_Range.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_OverrideNeighborRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007520 RID: 29984
		// (get) Token: 0x0601D085 RID: 118917 RVA: 0x002AE896 File Offset: 0x002ACA96
		// (set) Token: 0x0601D086 RID: 118918 RVA: 0x002AE8A6 File Offset: 0x002ACAA6
		public unsafe bool CheckWorldObstacles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_CheckWorldObstacles) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_CheckWorldObstacles) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D087 RID: 118919 RVA: 0x002AE8B7 File Offset: 0x002ACAB7
		static UKSC_DA_SceneComp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_SceneComp");
		}

		// Token: 0x0601D088 RID: 118920 RVA: 0x002AE8C5 File Offset: 0x002ACAC5
		protected UKSC_DA_SceneComp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC1B RID: 64539
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_SceneComp";

		// Token: 0x0400FC1C RID: 64540
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC1D RID: 64541
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC1E RID: 64542
		internal static int __PropertyOffset_SelfNeighborsType;

		// Token: 0x0400FC1F RID: 64543
		internal static int __PropertyOffset_TargetNeighborsTypes;

		// Token: 0x0400FC20 RID: 64544
		[Nullable(2)]
		private TArray<EKSC_SearchType> _TargetNeighborsTypes;

		// Token: 0x0400FC21 RID: 64545
		internal static int __PropertyOffset_NeighborDist;

		// Token: 0x0400FC22 RID: 64546
		internal static int __PropertyOffset_MaxNeighborsNum;

		// Token: 0x0400FC23 RID: 64547
		internal static int __PropertyOffset_ColliderRadius;

		// Token: 0x0400FC24 RID: 64548
		internal static int __PropertyOffset_Mass;

		// Token: 0x0400FC25 RID: 64549
		internal static int __PropertyOffset_bEnableCapsuleComponent;

		// Token: 0x0400FC26 RID: 64550
		internal static int __PropertyOffset_bIgnoreUpdateOverlap;

		// Token: 0x0400FC27 RID: 64551
		internal static int __PropertyOffset_OverrideNeighborCenter;

		// Token: 0x0400FC28 RID: 64552
		internal static int __PropertyOffset_OverrideNeighborRange;

		// Token: 0x0400FC29 RID: 64553
		[Nullable(2)]
		private FKSC_Range _OverrideNeighborRange;

		// Token: 0x0400FC2A RID: 64554
		internal static int __PropertyOffset_CheckWorldObstacles;
	}
}
