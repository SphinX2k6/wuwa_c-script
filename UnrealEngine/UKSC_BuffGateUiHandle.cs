using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D04 RID: 7428
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_BuffGateUiHandle")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKSC_BuffGateUiHandle : UKSC_BaseObject, IUnrealUObject, IUnrealObject, IKSC_HeadUiHandle, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601C91C RID: 117020 RVA: 0x002A3C0F File Offset: 0x002A1E0F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_BuffGateUiHandle._ClassPtr;
		}

		// Token: 0x0601C91D RID: 117021 RVA: 0x002A3C1B File Offset: 0x002A1E1B
		int IKSC_HeadUiHandle.InterfaceOffset()
		{
			return UKSC_BuffGateUiHandle.__InterfaceOffset_IKSC_HeadUiHandle;
		}

		// Token: 0x0601C91E RID: 117022 RVA: 0x002A3C24 File Offset: 0x002A1E24
		public UKSC_BuffGateUiHandle() : this(BuiltinUtils.AllocNativeUObject(UKSC_BuffGateUiHandle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C91F RID: 117023 RVA: 0x002A3C4C File Offset: 0x002A1E4C
		[NullableContext(1)]
		public UKSC_BuffGateUiHandle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_BuffGateUiHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601C920 RID: 117024 RVA: 0x002A3C7F File Offset: 0x002A1E7F
		static UKSC_BuffGateUiHandle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_BuffGateUiHandle");
		}

		// Token: 0x0601C921 RID: 117025 RVA: 0x002A3C8D File Offset: 0x002A1E8D
		protected UKSC_BuffGateUiHandle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7C9 RID: 63433
		internal static int __InterfaceOffset_IKSC_HeadUiHandle;

		// Token: 0x0400F7CA RID: 63434
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_BuffGateUiHandle";

		// Token: 0x0400F7CB RID: 63435
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7CC RID: 63436
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
