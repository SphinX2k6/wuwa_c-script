using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D1E RID: 7454
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_MenuAutoCastSkill")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_Buff_MenuAutoCastSkill : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C9E1 RID: 117217 RVA: 0x002A4DFA File Offset: 0x002A2FFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_MenuAutoCastSkill._ClassPtr;
		}

		// Token: 0x0601C9E2 RID: 117218 RVA: 0x002A4E08 File Offset: 0x002A3008
		public UKSC_Buff_MenuAutoCastSkill() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_MenuAutoCastSkill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C9E3 RID: 117219 RVA: 0x002A4E30 File Offset: 0x002A3030
		[NullableContext(1)]
		public UKSC_Buff_MenuAutoCastSkill(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_MenuAutoCastSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601C9E4 RID: 117220 RVA: 0x002A4E63 File Offset: 0x002A3063
		static UKSC_Buff_MenuAutoCastSkill()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_MenuAutoCastSkill");
		}

		// Token: 0x0601C9E5 RID: 117221 RVA: 0x002A4E71 File Offset: 0x002A3071
		protected UKSC_Buff_MenuAutoCastSkill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F835 RID: 63541
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_MenuAutoCastSkill";

		// Token: 0x0400F836 RID: 63542
		private static IntPtr _ClassPtr;

		// Token: 0x0400F837 RID: 63543
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
