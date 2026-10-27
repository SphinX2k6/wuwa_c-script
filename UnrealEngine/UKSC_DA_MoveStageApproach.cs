using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D99 RID: 7577
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_MoveStageApproach")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKSC_DA_MoveStageApproach : UKSC_DA_Move_Stage, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CFDC RID: 118748 RVA: 0x002AD9D5 File Offset: 0x002ABBD5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_MoveStageApproach._ClassPtr;
		}

		// Token: 0x0601CFDD RID: 118749 RVA: 0x002AD9E4 File Offset: 0x002ABBE4
		public UKSC_DA_MoveStageApproach() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_MoveStageApproach.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CFDE RID: 118750 RVA: 0x002ADA0C File Offset: 0x002ABC0C
		public UKSC_DA_MoveStageApproach(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_MoveStageApproach.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074F5 RID: 29941
		// (get) Token: 0x0601CFDF RID: 118751 RVA: 0x002ADA40 File Offset: 0x002ABC40
		// (set) Token: 0x0601CFE0 RID: 118752 RVA: 0x002ADA79 File Offset: 0x002ABC79
		public TArray<float> DistanceRight
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._DistanceRight) == null)
				{
					result = (this._DistanceRight = new TArray<float>(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach.__PropertyOffset_DistanceRight, this));
				}
				return result;
			}
			set
			{
				this.DistanceRight.CopyAssign(value);
			}
		}

		// Token: 0x170074F6 RID: 29942
		// (get) Token: 0x0601CFE1 RID: 118753 RVA: 0x002ADA87 File Offset: 0x002ABC87
		// (set) Token: 0x0601CFE2 RID: 118754 RVA: 0x002ADA97 File Offset: 0x002ABC97
		public unsafe int BeginIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach.__PropertyOffset_BeginIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach.__PropertyOffset_BeginIndex) = value;
			}
		}

		// Token: 0x170074F7 RID: 29943
		// (get) Token: 0x0601CFE3 RID: 118755 RVA: 0x002ADAA8 File Offset: 0x002ABCA8
		// (set) Token: 0x0601CFE4 RID: 118756 RVA: 0x002ADAB8 File Offset: 0x002ABCB8
		public unsafe float DistLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach.__PropertyOffset_DistLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach.__PropertyOffset_DistLimit) = value;
			}
		}

		// Token: 0x170074F8 RID: 29944
		// (get) Token: 0x0601CFE5 RID: 118757 RVA: 0x002ADAC9 File Offset: 0x002ABCC9
		// (set) Token: 0x0601CFE6 RID: 118758 RVA: 0x002ADAD9 File Offset: 0x002ABCD9
		public unsafe bool IsFollow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach.__PropertyOffset_IsFollow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach.__PropertyOffset_IsFollow) = (value ? 1 : 0);
			}
		}

		// Token: 0x170074F9 RID: 29945
		// (get) Token: 0x0601CFE7 RID: 118759 RVA: 0x002ADAEA File Offset: 0x002ABCEA
		// (set) Token: 0x0601CFE8 RID: 118760 RVA: 0x002ADAFA File Offset: 0x002ABCFA
		public unsafe bool IsStopSkillCast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach.__PropertyOffset_IsStopSkillCast) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach.__PropertyOffset_IsStopSkillCast) = (value ? 1 : 0);
			}
		}

		// Token: 0x170074FA RID: 29946
		// (get) Token: 0x0601CFE9 RID: 118761 RVA: 0x002ADB0B File Offset: 0x002ABD0B
		// (set) Token: 0x0601CFEA RID: 118762 RVA: 0x002ADB1B File Offset: 0x002ABD1B
		public unsafe float Cd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach.__PropertyOffset_Cd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_MoveStageApproach.__PropertyOffset_Cd) = value;
			}
		}

		// Token: 0x0601CFEB RID: 118763 RVA: 0x002ADB2C File Offset: 0x002ABD2C
		static UKSC_DA_MoveStageApproach()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_MoveStageApproach");
		}

		// Token: 0x0601CFEC RID: 118764 RVA: 0x002ADB3A File Offset: 0x002ABD3A
		protected UKSC_DA_MoveStageApproach(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBC7 RID: 64455
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_MoveStageApproach";

		// Token: 0x0400FBC8 RID: 64456
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBC9 RID: 64457
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FBCA RID: 64458
		internal static int __PropertyOffset_DistanceRight;

		// Token: 0x0400FBCB RID: 64459
		[Nullable(2)]
		private TArray<float> _DistanceRight;

		// Token: 0x0400FBCC RID: 64460
		internal static int __PropertyOffset_BeginIndex;

		// Token: 0x0400FBCD RID: 64461
		internal static int __PropertyOffset_DistLimit;

		// Token: 0x0400FBCE RID: 64462
		internal static int __PropertyOffset_IsFollow;

		// Token: 0x0400FBCF RID: 64463
		internal static int __PropertyOffset_IsStopSkillCast;

		// Token: 0x0400FBD0 RID: 64464
		internal static int __PropertyOffset_Cd;
	}
}
