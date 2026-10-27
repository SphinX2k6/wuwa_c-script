using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001E32 RID: 7730
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_DamageEffect")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FKSC_Shape2D_DamageEffect : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D742 RID: 120642 RVA: 0x002B8030 File Offset: 0x002B6230
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_Shape2D_DamageEffect._ScriptStructPtr != 0) ? FKSC_Shape2D_DamageEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_Shape2D_DamageEffect", ref FKSC_Shape2D_DamageEffect._ScriptStructPtr);
		}

		// Token: 0x170076B6 RID: 30390
		// (get) Token: 0x0601D743 RID: 120643 RVA: 0x002B8054 File Offset: 0x002B6254
		// (set) Token: 0x0601D744 RID: 120644 RVA: 0x002B8064 File Offset: 0x002B6264
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

		// Token: 0x170076B7 RID: 30391
		// (get) Token: 0x0601D745 RID: 120645 RVA: 0x002B8075 File Offset: 0x002B6275
		// (set) Token: 0x0601D746 RID: 120646 RVA: 0x002B8085 File Offset: 0x002B6285
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

		// Token: 0x170076B8 RID: 30392
		// (get) Token: 0x0601D747 RID: 120647 RVA: 0x002B8096 File Offset: 0x002B6296
		// (set) Token: 0x0601D748 RID: 120648 RVA: 0x002B80A6 File Offset: 0x002B62A6
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

		// Token: 0x170076B9 RID: 30393
		// (get) Token: 0x0601D749 RID: 120649 RVA: 0x002B80B7 File Offset: 0x002B62B7
		// (set) Token: 0x0601D74A RID: 120650 RVA: 0x002B80C7 File Offset: 0x002B62C7
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

		// Token: 0x170076BA RID: 30394
		// (get) Token: 0x0601D74B RID: 120651 RVA: 0x002B80D8 File Offset: 0x002B62D8
		// (set) Token: 0x0601D74C RID: 120652 RVA: 0x002B80E8 File Offset: 0x002B62E8
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

		// Token: 0x0601D74D RID: 120653 RVA: 0x002B80F9 File Offset: 0x002B62F9
		public FKSC_Shape2D_DamageEffect()
		{
		}

		// Token: 0x0601D74E RID: 120654 RVA: 0x002B8101 File Offset: 0x002B6301
		public FKSC_Shape2D_DamageEffect(bool IsRecordedCombo, float RecoverSkillEnergy, float RecoverSprintEnergy, float RecoverFeverEnergy, bool IsRecoverTeamSkillEnergy)
		{
			this.IsRecordedCombo = IsRecordedCombo;
			this.RecoverSkillEnergy = RecoverSkillEnergy;
			this.RecoverSprintEnergy = RecoverSprintEnergy;
			this.RecoverFeverEnergy = RecoverFeverEnergy;
			this.IsRecoverTeamSkillEnergy = IsRecoverTeamSkillEnergy;
		}

		// Token: 0x0601D74F RID: 120655 RVA: 0x002B812E File Offset: 0x002B632E
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_Shape2D_DamageEffect.StaticStruct();
		}

		// Token: 0x0601D750 RID: 120656 RVA: 0x002B813A File Offset: 0x002B633A
		[NullableContext(2)]
		public FKSC_Shape2D_DamageEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D751 RID: 120657 RVA: 0x002B8144 File Offset: 0x002B6344
		public FKSC_Shape2D_DamageEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D752 RID: 120658 RVA: 0x002B814F File Offset: 0x002B634F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_Shape2D_DamageEffect(Pointer, false, true);
		}

		// Token: 0x0601D753 RID: 120659 RVA: 0x002B8159 File Offset: 0x002B6359
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_Shape2D_DamageEffect(Pointer, MemoryOwner);
		}

		// Token: 0x0400FF87 RID: 65415
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_DamageEffect";

		// Token: 0x0400FF88 RID: 65416
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FF89 RID: 65417
		internal static int __PropertyOffset_IsRecordedCombo;

		// Token: 0x0400FF8A RID: 65418
		internal static int __PropertyOffset_RecoverSkillEnergy;

		// Token: 0x0400FF8B RID: 65419
		internal static int __PropertyOffset_RecoverSprintEnergy;

		// Token: 0x0400FF8C RID: 65420
		internal static int __PropertyOffset_RecoverFeverEnergy;

		// Token: 0x0400FF8D RID: 65421
		internal static int __PropertyOffset_IsRecoverTeamSkillEnergy;
	}
}
