using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DE3 RID: 7651
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_EventContext")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKSC_EventContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D3BA RID: 119738 RVA: 0x002B2C19 File Offset: 0x002B0E19
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_EventContext._ScriptStructPtr != 0) ? FKSC_EventContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_EventContext", ref FKSC_EventContext._ScriptStructPtr);
		}

		// Token: 0x17007604 RID: 30212
		// (get) Token: 0x0601D3BB RID: 119739 RVA: 0x002B2C3D File Offset: 0x002B0E3D
		// (set) Token: 0x0601D3BC RID: 119740 RVA: 0x002B2C51 File Offset: 0x002B0E51
		public unsafe UKSC_SkillComp FromComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_SkillComp>(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_EventContext.__PropertyOffset_FromComp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_EventContext.__PropertyOffset_FromComp, value);
			}
		}

		// Token: 0x17007605 RID: 30213
		// (get) Token: 0x0601D3BD RID: 119741 RVA: 0x002B2C66 File Offset: 0x002B0E66
		// (set) Token: 0x0601D3BE RID: 119742 RVA: 0x002B2C7A File Offset: 0x002B0E7A
		public unsafe UKSC_SkillComp ToComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_SkillComp>(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_EventContext.__PropertyOffset_ToComp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_EventContext.__PropertyOffset_ToComp, value);
			}
		}

		// Token: 0x17007606 RID: 30214
		// (get) Token: 0x0601D3BF RID: 119743 RVA: 0x002B2C8F File Offset: 0x002B0E8F
		// (set) Token: 0x0601D3C0 RID: 119744 RVA: 0x002B2CA3 File Offset: 0x002B0EA3
		public unsafe UKSC_SkillComp Caster
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_SkillComp>(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_EventContext.__PropertyOffset_Caster);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_EventContext.__PropertyOffset_Caster, value);
			}
		}

		// Token: 0x17007607 RID: 30215
		// (get) Token: 0x0601D3C1 RID: 119745 RVA: 0x002B2CB8 File Offset: 0x002B0EB8
		// (set) Token: 0x0601D3C2 RID: 119746 RVA: 0x002B2CCC File Offset: 0x002B0ECC
		public unsafe UKSC_SkillComp Owner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_SkillComp>(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_EventContext.__PropertyOffset_Owner);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_EventContext.__PropertyOffset_Owner, value);
			}
		}

		// Token: 0x17007608 RID: 30216
		// (get) Token: 0x0601D3C3 RID: 119747 RVA: 0x002B2CE1 File Offset: 0x002B0EE1
		// (set) Token: 0x0601D3C4 RID: 119748 RVA: 0x002B2CF5 File Offset: 0x002B0EF5
		public unsafe UKSC_Skill Skill
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Skill>(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_EventContext.__PropertyOffset_Skill);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_EventContext.__PropertyOffset_Skill, value);
			}
		}

		// Token: 0x17007609 RID: 30217
		// (get) Token: 0x0601D3C5 RID: 119749 RVA: 0x002B2D0A File Offset: 0x002B0F0A
		// (set) Token: 0x0601D3C6 RID: 119750 RVA: 0x002B2D1E File Offset: 0x002B0F1E
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_EventContext.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_EventContext.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x1700760A RID: 30218
		// (get) Token: 0x0601D3C7 RID: 119751 RVA: 0x002B2D33 File Offset: 0x002B0F33
		// (set) Token: 0x0601D3C8 RID: 119752 RVA: 0x002B2D43 File Offset: 0x002B0F43
		public unsafe int IntValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_EventContext.__PropertyOffset_IntValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_EventContext.__PropertyOffset_IntValue) = value;
			}
		}

		// Token: 0x1700760B RID: 30219
		// (get) Token: 0x0601D3C9 RID: 119753 RVA: 0x002B2D54 File Offset: 0x002B0F54
		// (set) Token: 0x0601D3CA RID: 119754 RVA: 0x002B2D64 File Offset: 0x002B0F64
		public unsafe long Int64Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_EventContext.__PropertyOffset_Int64Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_EventContext.__PropertyOffset_Int64Value) = value;
			}
		}

		// Token: 0x1700760C RID: 30220
		// (get) Token: 0x0601D3CB RID: 119755 RVA: 0x002B2D75 File Offset: 0x002B0F75
		// (set) Token: 0x0601D3CC RID: 119756 RVA: 0x002B2D85 File Offset: 0x002B0F85
		public unsafe int ProbabilityValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_EventContext.__PropertyOffset_ProbabilityValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_EventContext.__PropertyOffset_ProbabilityValue) = value;
			}
		}

		// Token: 0x0601D3CD RID: 119757 RVA: 0x002B2D96 File Offset: 0x002B0F96
		public FKSC_EventContext()
		{
		}

		// Token: 0x0601D3CE RID: 119758 RVA: 0x002B2DA0 File Offset: 0x002B0FA0
		[NullableContext(1)]
		public FKSC_EventContext(UKSC_SkillComp FromComp, UKSC_SkillComp ToComp, UKSC_SkillComp Caster, UKSC_SkillComp Owner, UKSC_Skill Skill, FGameplayTag Tag, int IntValue, long Int64Value, int ProbabilityValue)
		{
			this.FromComp = FromComp;
			this.ToComp = ToComp;
			this.Caster = Caster;
			this.Owner = Owner;
			this.Skill = Skill;
			this.Tag = Tag;
			this.IntValue = IntValue;
			this.Int64Value = Int64Value;
			this.ProbabilityValue = ProbabilityValue;
		}

		// Token: 0x0601D3CF RID: 119759 RVA: 0x002B2DF8 File Offset: 0x002B0FF8
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_EventContext.StaticStruct();
		}

		// Token: 0x0601D3D0 RID: 119760 RVA: 0x002B2E04 File Offset: 0x002B1004
		public FKSC_EventContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D3D1 RID: 119761 RVA: 0x002B2E0E File Offset: 0x002B100E
		public FKSC_EventContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D3D2 RID: 119762 RVA: 0x002B2E19 File Offset: 0x002B1019
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_EventContext(Pointer, false, true);
		}

		// Token: 0x0601D3D3 RID: 119763 RVA: 0x002B2E23 File Offset: 0x002B1023
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_EventContext(Pointer, MemoryOwner);
		}

		// Token: 0x0400FDD1 RID: 64977
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_EventContext";

		// Token: 0x0400FDD2 RID: 64978
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FDD3 RID: 64979
		internal static int __PropertyOffset_FromComp;

		// Token: 0x0400FDD4 RID: 64980
		internal static int __PropertyOffset_ToComp;

		// Token: 0x0400FDD5 RID: 64981
		internal static int __PropertyOffset_Caster;

		// Token: 0x0400FDD6 RID: 64982
		internal static int __PropertyOffset_Owner;

		// Token: 0x0400FDD7 RID: 64983
		internal static int __PropertyOffset_Skill;

		// Token: 0x0400FDD8 RID: 64984
		internal static int __PropertyOffset_Tag;

		// Token: 0x0400FDD9 RID: 64985
		internal static int __PropertyOffset_IntValue;

		// Token: 0x0400FDDA RID: 64986
		internal static int __PropertyOffset_Int64Value;

		// Token: 0x0400FDDB RID: 64987
		internal static int __PropertyOffset_ProbabilityValue;
	}
}
