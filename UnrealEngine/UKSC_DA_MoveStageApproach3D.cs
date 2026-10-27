using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D9A RID: 7578
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_MoveStageApproach3D")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKSC_DA_MoveStageApproach3D : UKSC_DA_Move_Stage, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CFED RID: 118765 RVA: 0x002ADB43 File Offset: 0x002ABD43
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_MoveStageApproach3D._ClassPtr;
		}

		// Token: 0x0601CFEE RID: 118766 RVA: 0x002ADB50 File Offset: 0x002ABD50
		public UKSC_DA_MoveStageApproach3D() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_MoveStageApproach3D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CFEF RID: 118767 RVA: 0x002ADB78 File Offset: 0x002ABD78
		[NullableContext(1)]
		public UKSC_DA_MoveStageApproach3D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_MoveStageApproach3D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074FB RID: 29947
		// (get) Token: 0x0601CFF0 RID: 118768 RVA: 0x002ADBAB File Offset: 0x002ABDAB
		// (set) Token: 0x0601CFF1 RID: 118769 RVA: 0x002ADBBB File Offset: 0x002ABDBB
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach3D.__PropertyOffset_MaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach3D.__PropertyOffset_MaxDistance) = value;
			}
		}

		// Token: 0x170074FC RID: 29948
		// (get) Token: 0x0601CFF2 RID: 118770 RVA: 0x002ADBCC File Offset: 0x002ABDCC
		// (set) Token: 0x0601CFF3 RID: 118771 RVA: 0x002ADBDC File Offset: 0x002ABDDC
		public unsafe float MinDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach3D.__PropertyOffset_MinDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach3D.__PropertyOffset_MinDistance) = value;
			}
		}

		// Token: 0x170074FD RID: 29949
		// (get) Token: 0x0601CFF4 RID: 118772 RVA: 0x002ADBED File Offset: 0x002ABDED
		// (set) Token: 0x0601CFF5 RID: 118773 RVA: 0x002ADBFD File Offset: 0x002ABDFD
		public unsafe float Acc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach3D.__PropertyOffset_Acc);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach3D.__PropertyOffset_Acc) = value;
			}
		}

		// Token: 0x170074FE RID: 29950
		// (get) Token: 0x0601CFF6 RID: 118774 RVA: 0x002ADC0E File Offset: 0x002ABE0E
		// (set) Token: 0x0601CFF7 RID: 118775 RVA: 0x002ADC1E File Offset: 0x002ABE1E
		public unsafe float AnimChangeThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach3D.__PropertyOffset_AnimChangeThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach3D.__PropertyOffset_AnimChangeThreshold) = value;
			}
		}

		// Token: 0x170074FF RID: 29951
		// (get) Token: 0x0601CFF8 RID: 118776 RVA: 0x002ADC2F File Offset: 0x002ABE2F
		// (set) Token: 0x0601CFF9 RID: 118777 RVA: 0x002ADC3F File Offset: 0x002ABE3F
		public unsafe float AngleTurning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach3D.__PropertyOffset_AngleTurning);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach3D.__PropertyOffset_AngleTurning) = value;
			}
		}

		// Token: 0x0601CFFA RID: 118778 RVA: 0x002ADC50 File Offset: 0x002ABE50
		static UKSC_DA_MoveStageApproach3D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_MoveStageApproach3D");
		}

		// Token: 0x0601CFFB RID: 118779 RVA: 0x002ADC5E File Offset: 0x002ABE5E
		protected UKSC_DA_MoveStageApproach3D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBD1 RID: 64465
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_MoveStageApproach3D";

		// Token: 0x0400FBD2 RID: 64466
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBD3 RID: 64467
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FBD4 RID: 64468
		internal static int __PropertyOffset_MaxDistance;

		// Token: 0x0400FBD5 RID: 64469
		internal static int __PropertyOffset_MinDistance;

		// Token: 0x0400FBD6 RID: 64470
		internal static int __PropertyOffset_Acc;

		// Token: 0x0400FBD7 RID: 64471
		internal static int __PropertyOffset_AnimChangeThreshold;

		// Token: 0x0400FBD8 RID: 64472
		internal static int __PropertyOffset_AngleTurning;
	}
}
