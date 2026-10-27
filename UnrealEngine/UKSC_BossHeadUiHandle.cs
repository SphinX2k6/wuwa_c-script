using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CFE RID: 7422
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_BossHeadUiHandle")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKSC_BossHeadUiHandle : UKSC_BaseObject, IUnrealUObject, IUnrealObject, IKSC_HeadUiHandle, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601C8EE RID: 116974 RVA: 0x002A380B File Offset: 0x002A1A0B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_BossHeadUiHandle._ClassPtr;
		}

		// Token: 0x0601C8EF RID: 116975 RVA: 0x002A3817 File Offset: 0x002A1A17
		int IKSC_HeadUiHandle.InterfaceOffset()
		{
			return UKSC_BossHeadUiHandle.__InterfaceOffset_IKSC_HeadUiHandle;
		}

		// Token: 0x0601C8F0 RID: 116976 RVA: 0x002A3820 File Offset: 0x002A1A20
		public UKSC_BossHeadUiHandle() : this(BuiltinUtils.AllocNativeUObject(UKSC_BossHeadUiHandle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C8F1 RID: 116977 RVA: 0x002A3848 File Offset: 0x002A1A48
		[NullableContext(1)]
		public UKSC_BossHeadUiHandle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_BossHeadUiHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601C8F2 RID: 116978 RVA: 0x002A387B File Offset: 0x002A1A7B
		static UKSC_BossHeadUiHandle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_BossHeadUiHandle");
		}

		// Token: 0x0601C8F3 RID: 116979 RVA: 0x002A3889 File Offset: 0x002A1A89
		protected UKSC_BossHeadUiHandle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7AF RID: 63407
		internal static int __InterfaceOffset_IKSC_HeadUiHandle;

		// Token: 0x0400F7B0 RID: 63408
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_BossHeadUiHandle";

		// Token: 0x0400F7B1 RID: 63409
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7B2 RID: 63410
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
