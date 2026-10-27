using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DBB RID: 7611
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill_Anim")]
	[UnrealStructLayout(416, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UKSC_DA_Skill_Anim : UKSC_DA_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D1BE RID: 119230 RVA: 0x002B026B File Offset: 0x002AE46B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_Anim._ClassPtr;
		}

		// Token: 0x0601D1BF RID: 119231 RVA: 0x002B0278 File Offset: 0x002AE478
		public UKSC_DA_Skill_Anim() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_Anim.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D1C0 RID: 119232 RVA: 0x002B02A0 File Offset: 0x002AE4A0
		[NullableContext(1)]
		public UKSC_DA_Skill_Anim(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_Anim.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007590 RID: 30096
		// (get) Token: 0x0601D1C1 RID: 119233 RVA: 0x002B02D3 File Offset: 0x002AE4D3
		// (set) Token: 0x0601D1C2 RID: 119234 RVA: 0x002B02E3 File Offset: 0x002AE4E3
		public unsafe EKSC_GPUNPCAnimState AnimState
		{
			get
			{
				return (EKSC_GPUNPCAnimState)(*(base.NativePtr + (IntPtr)UKSC_DA_Skill_Anim.__PropertyOffset_AnimState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_Anim.__PropertyOffset_AnimState) = (byte)value;
			}
		}

		// Token: 0x17007591 RID: 30097
		// (get) Token: 0x0601D1C3 RID: 119235 RVA: 0x002B02F4 File Offset: 0x002AE4F4
		// (set) Token: 0x0601D1C4 RID: 119236 RVA: 0x002B0304 File Offset: 0x002AE504
		public unsafe float AnimDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_Anim.__PropertyOffset_AnimDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_Anim.__PropertyOffset_AnimDuration) = value;
			}
		}

		// Token: 0x17007592 RID: 30098
		// (get) Token: 0x0601D1C5 RID: 119237 RVA: 0x002B0315 File Offset: 0x002AE515
		// (set) Token: 0x0601D1C6 RID: 119238 RVA: 0x002B0325 File Offset: 0x002AE525
		public unsafe EKSC_GPUNPCAnimState AnimStateIdle
		{
			get
			{
				return (EKSC_GPUNPCAnimState)(*(base.NativePtr + (IntPtr)UKSC_DA_Skill_Anim.__PropertyOffset_AnimStateIdle));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_Anim.__PropertyOffset_AnimStateIdle) = (byte)value;
			}
		}

		// Token: 0x17007593 RID: 30099
		// (get) Token: 0x0601D1C7 RID: 119239 RVA: 0x002B0336 File Offset: 0x002AE536
		// (set) Token: 0x0601D1C8 RID: 119240 RVA: 0x002B0346 File Offset: 0x002AE546
		public unsafe bool IsStopMoveBeingSkill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_Anim.__PropertyOffset_IsStopMoveBeingSkill) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_Anim.__PropertyOffset_IsStopMoveBeingSkill) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D1C9 RID: 119241 RVA: 0x002B0357 File Offset: 0x002AE557
		static UKSC_DA_Skill_Anim()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill_Anim");
		}

		// Token: 0x0601D1CA RID: 119242 RVA: 0x002B0365 File Offset: 0x002AE565
		protected UKSC_DA_Skill_Anim(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FCD6 RID: 64726
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill_Anim";

		// Token: 0x0400FCD7 RID: 64727
		private static IntPtr _ClassPtr;

		// Token: 0x0400FCD8 RID: 64728
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FCD9 RID: 64729
		internal static int __PropertyOffset_AnimState;

		// Token: 0x0400FCDA RID: 64730
		internal static int __PropertyOffset_AnimDuration;

		// Token: 0x0400FCDB RID: 64731
		internal static int __PropertyOffset_AnimStateIdle;

		// Token: 0x0400FCDC RID: 64732
		internal static int __PropertyOffset_IsStopMoveBeingSkill;
	}
}
