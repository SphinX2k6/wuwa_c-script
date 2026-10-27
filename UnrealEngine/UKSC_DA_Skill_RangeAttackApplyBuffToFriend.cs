using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DC9 RID: 7625
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill_RangeAttackApplyBuffToFriend")]
	[UnrealStructLayout(576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class UKSC_DA_Skill_RangeAttackApplyBuffToFriend : UKSC_DA_Skill_RangeAttack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D276 RID: 119414 RVA: 0x002B1266 File Offset: 0x002AF466
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_RangeAttackApplyBuffToFriend._ClassPtr;
		}

		// Token: 0x0601D277 RID: 119415 RVA: 0x002B1274 File Offset: 0x002AF474
		public UKSC_DA_Skill_RangeAttackApplyBuffToFriend() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_RangeAttackApplyBuffToFriend.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D278 RID: 119416 RVA: 0x002B129C File Offset: 0x002AF49C
		[NullableContext(1)]
		public UKSC_DA_Skill_RangeAttackApplyBuffToFriend(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_RangeAttackApplyBuffToFriend.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170075C9 RID: 30153
		// (get) Token: 0x0601D279 RID: 119417 RVA: 0x002B12CF File Offset: 0x002AF4CF
		// (set) Token: 0x0601D27A RID: 119418 RVA: 0x002B12E3 File Offset: 0x002AF4E3
		[Nullable(2)]
		public unsafe UKSC_DA_Buff ApplyBuffToFriend
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill_RangeAttackApplyBuffToFriend.__PropertyOffset_ApplyBuffToFriend);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill_RangeAttackApplyBuffToFriend.__PropertyOffset_ApplyBuffToFriend, value);
			}
		}

		// Token: 0x0601D27B RID: 119419 RVA: 0x002B12F8 File Offset: 0x002AF4F8
		static UKSC_DA_Skill_RangeAttackApplyBuffToFriend()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill_RangeAttackApplyBuffToFriend");
		}

		// Token: 0x0601D27C RID: 119420 RVA: 0x002B1306 File Offset: 0x002AF506
		protected UKSC_DA_Skill_RangeAttackApplyBuffToFriend(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD3F RID: 64831
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill_RangeAttackApplyBuffToFriend";

		// Token: 0x0400FD40 RID: 64832
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD41 RID: 64833
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD42 RID: 64834
		internal static int __PropertyOffset_ApplyBuffToFriend;
	}
}
