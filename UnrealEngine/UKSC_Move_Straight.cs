using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E10 RID: 7696
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_Straight")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class UKSC_Move_Straight : UKSC_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D5F8 RID: 120312 RVA: 0x002B5C19 File Offset: 0x002B3E19
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_Straight._ClassPtr;
		}

		// Token: 0x0601D5F9 RID: 120313 RVA: 0x002B5C28 File Offset: 0x002B3E28
		public UKSC_Move_Straight() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Straight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D5FA RID: 120314 RVA: 0x002B5C50 File Offset: 0x002B3E50
		[NullableContext(1)]
		public UKSC_Move_Straight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Straight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D5FB RID: 120315 RVA: 0x002B5C83 File Offset: 0x002B3E83
		static UKSC_Move_Straight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_Straight");
		}

		// Token: 0x0601D5FC RID: 120316 RVA: 0x002B5C91 File Offset: 0x002B3E91
		protected UKSC_Move_Straight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEE6 RID: 65254
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_Straight";

		// Token: 0x0400FEE7 RID: 65255
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEE8 RID: 65256
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
