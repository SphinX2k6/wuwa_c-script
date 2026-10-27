using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D9D RID: 7581
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_MoveStageRandom")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKSC_DA_MoveStageRandom : UKSC_DA_Move_Stage, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D008 RID: 118792 RVA: 0x002ADD86 File Offset: 0x002ABF86
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_MoveStageRandom._ClassPtr;
		}

		// Token: 0x0601D009 RID: 118793 RVA: 0x002ADD94 File Offset: 0x002ABF94
		public UKSC_DA_MoveStageRandom() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_MoveStageRandom.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D00A RID: 118794 RVA: 0x002ADDBC File Offset: 0x002ABFBC
		public UKSC_DA_MoveStageRandom(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_MoveStageRandom.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007501 RID: 29953
		// (get) Token: 0x0601D00B RID: 118795 RVA: 0x002ADDF0 File Offset: 0x002ABFF0
		// (set) Token: 0x0601D00C RID: 118796 RVA: 0x002ADE29 File Offset: 0x002AC029
		public TArray<float> DistanceRight
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._DistanceRight) == null)
				{
					result = (this._DistanceRight = new TArray<float>(base.NativePtr + (IntPtr)UKSC_DA_MoveStageRandom.__PropertyOffset_DistanceRight, this));
				}
				return result;
			}
			set
			{
				this.DistanceRight.CopyAssign(value);
			}
		}

		// Token: 0x17007502 RID: 29954
		// (get) Token: 0x0601D00D RID: 118797 RVA: 0x002ADE37 File Offset: 0x002AC037
		// (set) Token: 0x0601D00E RID: 118798 RVA: 0x002ADE47 File Offset: 0x002AC047
		public unsafe int BeginIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_MoveStageRandom.__PropertyOffset_BeginIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_MoveStageRandom.__PropertyOffset_BeginIndex) = value;
			}
		}

		// Token: 0x17007503 RID: 29955
		// (get) Token: 0x0601D00F RID: 118799 RVA: 0x002ADE58 File Offset: 0x002AC058
		// (set) Token: 0x0601D010 RID: 118800 RVA: 0x002ADE68 File Offset: 0x002AC068
		public unsafe bool IsStopSkillCast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_MoveStageRandom.__PropertyOffset_IsStopSkillCast) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_MoveStageRandom.__PropertyOffset_IsStopSkillCast) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007504 RID: 29956
		// (get) Token: 0x0601D011 RID: 118801 RVA: 0x002ADE79 File Offset: 0x002AC079
		// (set) Token: 0x0601D012 RID: 118802 RVA: 0x002ADE89 File Offset: 0x002AC089
		public unsafe float Cd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_MoveStageRandom.__PropertyOffset_Cd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_MoveStageRandom.__PropertyOffset_Cd) = value;
			}
		}

		// Token: 0x0601D013 RID: 118803 RVA: 0x002ADE9A File Offset: 0x002AC09A
		static UKSC_DA_MoveStageRandom()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_MoveStageRandom");
		}

		// Token: 0x0601D014 RID: 118804 RVA: 0x002ADEA8 File Offset: 0x002AC0A8
		protected UKSC_DA_MoveStageRandom(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBE0 RID: 64480
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_MoveStageRandom";

		// Token: 0x0400FBE1 RID: 64481
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBE2 RID: 64482
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FBE3 RID: 64483
		internal static int __PropertyOffset_DistanceRight;

		// Token: 0x0400FBE4 RID: 64484
		[Nullable(2)]
		private TArray<float> _DistanceRight;

		// Token: 0x0400FBE5 RID: 64485
		internal static int __PropertyOffset_BeginIndex;

		// Token: 0x0400FBE6 RID: 64486
		internal static int __PropertyOffset_IsStopSkillCast;

		// Token: 0x0400FBE7 RID: 64487
		internal static int __PropertyOffset_Cd;
	}
}
