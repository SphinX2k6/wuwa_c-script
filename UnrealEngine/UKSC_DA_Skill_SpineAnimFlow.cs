using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DCC RID: 7628
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill_SpineAnimFlow")]
	[UnrealStructLayout(528, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 528)]
	public class UKSC_DA_Skill_SpineAnimFlow : UKSC_DA_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D28F RID: 119439 RVA: 0x002B1490 File Offset: 0x002AF690
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_SpineAnimFlow._ClassPtr;
		}

		// Token: 0x0601D290 RID: 119440 RVA: 0x002B149C File Offset: 0x002AF69C
		public UKSC_DA_Skill_SpineAnimFlow() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_SpineAnimFlow.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D291 RID: 119441 RVA: 0x002B14C4 File Offset: 0x002AF6C4
		public UKSC_DA_Skill_SpineAnimFlow(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_SpineAnimFlow.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170075CE RID: 30158
		// (get) Token: 0x0601D292 RID: 119442 RVA: 0x002B14F8 File Offset: 0x002AF6F8
		// (set) Token: 0x0601D293 RID: 119443 RVA: 0x002B1531 File Offset: 0x002AF731
		public TArray<UKSC_DA_SpineAnimTimeline> AnimTimelines
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_DA_SpineAnimTimeline> result;
				if ((result = this._AnimTimelines) == null)
				{
					result = (this._AnimTimelines = new TArray<UKSC_DA_SpineAnimTimeline>(base.NativePtr + (IntPtr)UKSC_DA_Skill_SpineAnimFlow.__PropertyOffset_AnimTimelines, this));
				}
				return result;
			}
			set
			{
				this.AnimTimelines.CopyAssign(value);
			}
		}

		// Token: 0x170075CF RID: 30159
		// (get) Token: 0x0601D294 RID: 119444 RVA: 0x002B153F File Offset: 0x002AF73F
		// (set) Token: 0x0601D295 RID: 119445 RVA: 0x002B154F File Offset: 0x002AF74F
		public unsafe bool IsBreakable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_SpineAnimFlow.__PropertyOffset_IsBreakable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_SpineAnimFlow.__PropertyOffset_IsBreakable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170075D0 RID: 30160
		// (get) Token: 0x0601D296 RID: 119446 RVA: 0x002B1560 File Offset: 0x002AF760
		// (set) Token: 0x0601D297 RID: 119447 RVA: 0x002B1599 File Offset: 0x002AF799
		public FKSC_TagFilter BreakCondition
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_TagFilter result;
				if ((result = this._BreakCondition) == null)
				{
					result = (this._BreakCondition = new FKSC_TagFilter(base.NativePtr + (IntPtr)UKSC_DA_Skill_SpineAnimFlow.__PropertyOffset_BreakCondition, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_TagFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Skill_SpineAnimFlow.__PropertyOffset_BreakCondition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170075D1 RID: 30161
		// (get) Token: 0x0601D298 RID: 119448 RVA: 0x002B15BA File Offset: 0x002AF7BA
		// (set) Token: 0x0601D299 RID: 119449 RVA: 0x002B15CA File Offset: 0x002AF7CA
		public unsafe bool IsPassive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_SpineAnimFlow.__PropertyOffset_IsPassive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_SpineAnimFlow.__PropertyOffset_IsPassive) = (value ? 1 : 0);
			}
		}

		// Token: 0x170075D2 RID: 30162
		// (get) Token: 0x0601D29A RID: 119450 RVA: 0x002B15DC File Offset: 0x002AF7DC
		// (set) Token: 0x0601D29B RID: 119451 RVA: 0x002B1615 File Offset: 0x002AF815
		public FKSC_TagFilter PassiveCondition
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_TagFilter result;
				if ((result = this._PassiveCondition) == null)
				{
					result = (this._PassiveCondition = new FKSC_TagFilter(base.NativePtr + (IntPtr)UKSC_DA_Skill_SpineAnimFlow.__PropertyOffset_PassiveCondition, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_TagFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Skill_SpineAnimFlow.__PropertyOffset_PassiveCondition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170075D3 RID: 30163
		// (get) Token: 0x0601D29C RID: 119452 RVA: 0x002B1636 File Offset: 0x002AF836
		// (set) Token: 0x0601D29D RID: 119453 RVA: 0x002B1646 File Offset: 0x002AF846
		public unsafe bool IsBeginWithCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_SpineAnimFlow.__PropertyOffset_IsBeginWithCD) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_SpineAnimFlow.__PropertyOffset_IsBeginWithCD) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D29E RID: 119454 RVA: 0x002B1657 File Offset: 0x002AF857
		static UKSC_DA_Skill_SpineAnimFlow()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill_SpineAnimFlow");
		}

		// Token: 0x0601D29F RID: 119455 RVA: 0x002B1665 File Offset: 0x002AF865
		protected UKSC_DA_Skill_SpineAnimFlow(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD4D RID: 64845
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill_SpineAnimFlow";

		// Token: 0x0400FD4E RID: 64846
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD4F RID: 64847
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD50 RID: 64848
		internal static int __PropertyOffset_AnimTimelines;

		// Token: 0x0400FD51 RID: 64849
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_DA_SpineAnimTimeline> _AnimTimelines;

		// Token: 0x0400FD52 RID: 64850
		internal static int __PropertyOffset_IsBreakable;

		// Token: 0x0400FD53 RID: 64851
		internal static int __PropertyOffset_BreakCondition;

		// Token: 0x0400FD54 RID: 64852
		[Nullable(2)]
		private FKSC_TagFilter _BreakCondition;

		// Token: 0x0400FD55 RID: 64853
		internal static int __PropertyOffset_IsPassive;

		// Token: 0x0400FD56 RID: 64854
		internal static int __PropertyOffset_PassiveCondition;

		// Token: 0x0400FD57 RID: 64855
		[Nullable(2)]
		private FKSC_TagFilter _PassiveCondition;

		// Token: 0x0400FD58 RID: 64856
		internal static int __PropertyOffset_IsBeginWithCD;
	}
}
