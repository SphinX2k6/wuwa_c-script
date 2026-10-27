using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DBE RID: 7614
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill_Attack_Persistent_Cannon")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UKSC_DA_Skill_Attack_Persistent_Cannon : UKSC_DA_Skill_Attack_Persistent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D1DF RID: 119263 RVA: 0x002B054D File Offset: 0x002AE74D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_Attack_Persistent_Cannon._ClassPtr;
		}

		// Token: 0x0601D1E0 RID: 119264 RVA: 0x002B055C File Offset: 0x002AE75C
		public UKSC_DA_Skill_Attack_Persistent_Cannon() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_Attack_Persistent_Cannon.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D1E1 RID: 119265 RVA: 0x002B0584 File Offset: 0x002AE784
		[NullableContext(1)]
		public UKSC_DA_Skill_Attack_Persistent_Cannon(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_Attack_Persistent_Cannon.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007599 RID: 30105
		// (get) Token: 0x0601D1E2 RID: 119266 RVA: 0x002B05B7 File Offset: 0x002AE7B7
		// (set) Token: 0x0601D1E3 RID: 119267 RVA: 0x002B05C7 File Offset: 0x002AE7C7
		public unsafe float RotSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_Attack_Persistent_Cannon.__PropertyOffset_RotSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_Attack_Persistent_Cannon.__PropertyOffset_RotSpeed) = value;
			}
		}

		// Token: 0x1700759A RID: 30106
		// (get) Token: 0x0601D1E4 RID: 119268 RVA: 0x002B05D8 File Offset: 0x002AE7D8
		// (set) Token: 0x0601D1E5 RID: 119269 RVA: 0x002B05E8 File Offset: 0x002AE7E8
		public unsafe float CannonLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_Attack_Persistent_Cannon.__PropertyOffset_CannonLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_Attack_Persistent_Cannon.__PropertyOffset_CannonLength) = value;
			}
		}

		// Token: 0x0601D1E6 RID: 119270 RVA: 0x002B05F9 File Offset: 0x002AE7F9
		static UKSC_DA_Skill_Attack_Persistent_Cannon()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill_Attack_Persistent_Cannon");
		}

		// Token: 0x0601D1E7 RID: 119271 RVA: 0x002B0607 File Offset: 0x002AE807
		protected UKSC_DA_Skill_Attack_Persistent_Cannon(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FCE9 RID: 64745
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill_Attack_Persistent_Cannon";

		// Token: 0x0400FCEA RID: 64746
		private static IntPtr _ClassPtr;

		// Token: 0x0400FCEB RID: 64747
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FCEC RID: 64748
		internal static int __PropertyOffset_RotSpeed;

		// Token: 0x0400FCED RID: 64749
		internal static int __PropertyOffset_CannonLength;
	}
}
