using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000588 RID: 1416
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_DamageEffect")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FKSC_Shape2D_DamageEffect : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008066 RID: 32870 RVA: 0x000BDBD2 File Offset: 0x000BBDD2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_Shape2D_DamageEffect._ScriptStructPtr != 0) ? FKSC_Shape2D_DamageEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_Shape2D_DamageEffect", ref FKSC_Shape2D_DamageEffect._ScriptStructPtr);
		}

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x06008067 RID: 32871 RVA: 0x000BDBF6 File Offset: 0x000BBDF6
		// (set) Token: 0x06008068 RID: 32872 RVA: 0x000BDC06 File Offset: 0x000BBE06
		public unsafe bool IsRecordedCombo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageEffect.__PropertyOffset_IsRecordedCombo) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageEffect.__PropertyOffset_IsRecordedCombo) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x06008069 RID: 32873 RVA: 0x000BDC17 File Offset: 0x000BBE17
		// (set) Token: 0x0600806A RID: 32874 RVA: 0x000BDC27 File Offset: 0x000BBE27
		public unsafe float RecoverSkillEnergy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageEffect.__PropertyOffset_RecoverSkillEnergy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageEffect.__PropertyOffset_RecoverSkillEnergy) = value;
			}
		}

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x0600806B RID: 32875 RVA: 0x000BDC38 File Offset: 0x000BBE38
		// (set) Token: 0x0600806C RID: 32876 RVA: 0x000BDC48 File Offset: 0x000BBE48
		public unsafe float RecoverSprintEnergy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageEffect.__PropertyOffset_RecoverSprintEnergy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageEffect.__PropertyOffset_RecoverSprintEnergy) = value;
			}
		}

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x0600806D RID: 32877 RVA: 0x000BDC59 File Offset: 0x000BBE59
		// (set) Token: 0x0600806E RID: 32878 RVA: 0x000BDC69 File Offset: 0x000BBE69
		public unsafe float RecoverFeverEnergy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageEffect.__PropertyOffset_RecoverFeverEnergy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageEffect.__PropertyOffset_RecoverFeverEnergy) = value;
			}
		}

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x0600806F RID: 32879 RVA: 0x000BDC7A File Offset: 0x000BBE7A
		// (set) Token: 0x06008070 RID: 32880 RVA: 0x000BDC8A File Offset: 0x000BBE8A
		public unsafe bool IsRecoverTeamSkillEnergy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageEffect.__PropertyOffset_IsRecoverTeamSkillEnergy) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageEffect.__PropertyOffset_IsRecoverTeamSkillEnergy) = (value ? 1 : 0);
			}
		}

		// Token: 0x06008071 RID: 32881 RVA: 0x000BDC9B File Offset: 0x000BBE9B
		public FKSC_Shape2D_DamageEffect()
		{
		}

		// Token: 0x06008072 RID: 32882 RVA: 0x000BDCA3 File Offset: 0x000BBEA3
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_Shape2D_DamageEffect.StaticStruct();
		}

		// Token: 0x06008073 RID: 32883 RVA: 0x000BDCAF File Offset: 0x000BBEAF
		[NullableContext(2)]
		public FKSC_Shape2D_DamageEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008074 RID: 32884 RVA: 0x000BDCB9 File Offset: 0x000BBEB9
		public FKSC_Shape2D_DamageEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008075 RID: 32885 RVA: 0x000BDCC4 File Offset: 0x000BBEC4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_Shape2D_DamageEffect(Pointer, false, true);
		}

		// Token: 0x06008076 RID: 32886 RVA: 0x000BDCCE File Offset: 0x000BBECE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_Shape2D_DamageEffect(Pointer, MemoryOwner);
		}

		// Token: 0x04003812 RID: 14354
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_DamageEffect";

		// Token: 0x04003813 RID: 14355
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003814 RID: 14356
		internal static int __PropertyOffset_IsRecordedCombo;

		// Token: 0x04003815 RID: 14357
		internal static int __PropertyOffset_RecoverSkillEnergy;

		// Token: 0x04003816 RID: 14358
		internal static int __PropertyOffset_RecoverSprintEnergy;

		// Token: 0x04003817 RID: 14359
		internal static int __PropertyOffset_RecoverFeverEnergy;

		// Token: 0x04003818 RID: 14360
		internal static int __PropertyOffset_IsRecoverTeamSkillEnergy;
	}
}
