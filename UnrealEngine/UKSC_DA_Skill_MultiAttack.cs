using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DC6 RID: 7622
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill_MultiAttack")]
	[UnrealStructLayout(416, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UKSC_DA_Skill_MultiAttack : UKSC_DA_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D25D RID: 119389 RVA: 0x002B0FC8 File Offset: 0x002AF1C8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_MultiAttack._ClassPtr;
		}

		// Token: 0x0601D25E RID: 119390 RVA: 0x002B0FD4 File Offset: 0x002AF1D4
		public UKSC_DA_Skill_MultiAttack() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_MultiAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D25F RID: 119391 RVA: 0x002B0FFC File Offset: 0x002AF1FC
		[NullableContext(1)]
		public UKSC_DA_Skill_MultiAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_MultiAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170075C4 RID: 30148
		// (get) Token: 0x0601D260 RID: 119392 RVA: 0x002B102F File Offset: 0x002AF22F
		// (set) Token: 0x0601D261 RID: 119393 RVA: 0x002B103F File Offset: 0x002AF23F
		public unsafe int MultiNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_MultiAttack.__PropertyOffset_MultiNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_MultiAttack.__PropertyOffset_MultiNum) = value;
			}
		}

		// Token: 0x0601D262 RID: 119394 RVA: 0x002B1050 File Offset: 0x002AF250
		static UKSC_DA_Skill_MultiAttack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill_MultiAttack");
		}

		// Token: 0x0601D263 RID: 119395 RVA: 0x002B105E File Offset: 0x002AF25E
		protected UKSC_DA_Skill_MultiAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD2F RID: 64815
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill_MultiAttack";

		// Token: 0x0400FD30 RID: 64816
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD31 RID: 64817
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD32 RID: 64818
		internal static int __PropertyOffset_MultiNum;
	}
}
