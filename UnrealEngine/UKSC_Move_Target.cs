using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E11 RID: 7697
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_Target")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class UKSC_Move_Target : UKSC_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D5FD RID: 120317 RVA: 0x002B5C9A File Offset: 0x002B3E9A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_Target._ClassPtr;
		}

		// Token: 0x0601D5FE RID: 120318 RVA: 0x002B5CA8 File Offset: 0x002B3EA8
		public UKSC_Move_Target() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Target.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D5FF RID: 120319 RVA: 0x002B5CD0 File Offset: 0x002B3ED0
		[NullableContext(1)]
		public UKSC_Move_Target(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Target.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D600 RID: 120320 RVA: 0x002B5D03 File Offset: 0x002B3F03
		static UKSC_Move_Target()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_Target");
		}

		// Token: 0x0601D601 RID: 120321 RVA: 0x002B5D11 File Offset: 0x002B3F11
		protected UKSC_Move_Target(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEE9 RID: 65257
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_Target";

		// Token: 0x0400FEEA RID: 65258
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEEB RID: 65259
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
