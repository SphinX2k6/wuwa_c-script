using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E06 RID: 7686
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_Random")]
	[UnrealStructLayout(560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 560)]
	public class UKSC_Move_Random : UKSC_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D5A8 RID: 120232 RVA: 0x002B5529 File Offset: 0x002B3729
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_Random._ClassPtr;
		}

		// Token: 0x0601D5A9 RID: 120233 RVA: 0x002B5538 File Offset: 0x002B3738
		public UKSC_Move_Random() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Random.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D5AA RID: 120234 RVA: 0x002B5560 File Offset: 0x002B3760
		[NullableContext(1)]
		public UKSC_Move_Random(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Random.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D5AB RID: 120235 RVA: 0x002B5593 File Offset: 0x002B3793
		static UKSC_Move_Random()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_Random");
		}

		// Token: 0x0601D5AC RID: 120236 RVA: 0x002B55A1 File Offset: 0x002B37A1
		protected UKSC_Move_Random(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEBE RID: 65214
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_Random";

		// Token: 0x0400FEBF RID: 65215
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEC0 RID: 65216
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
