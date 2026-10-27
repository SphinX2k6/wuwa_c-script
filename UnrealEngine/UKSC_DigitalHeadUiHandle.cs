using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DD7 RID: 7639
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DigitalHeadUiHandle")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKSC_DigitalHeadUiHandle : UKSC_BaseObject, IUnrealUObject, IUnrealObject, IKSC_HeadUiHandle, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601D307 RID: 119559 RVA: 0x002B1E7C File Offset: 0x002B007C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DigitalHeadUiHandle._ClassPtr;
		}

		// Token: 0x0601D308 RID: 119560 RVA: 0x002B1E88 File Offset: 0x002B0088
		int IKSC_HeadUiHandle.InterfaceOffset()
		{
			return UKSC_DigitalHeadUiHandle.__InterfaceOffset_IKSC_HeadUiHandle;
		}

		// Token: 0x0601D309 RID: 119561 RVA: 0x002B1E90 File Offset: 0x002B0090
		public UKSC_DigitalHeadUiHandle() : this(BuiltinUtils.AllocNativeUObject(UKSC_DigitalHeadUiHandle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D30A RID: 119562 RVA: 0x002B1EB8 File Offset: 0x002B00B8
		[NullableContext(1)]
		public UKSC_DigitalHeadUiHandle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DigitalHeadUiHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D30B RID: 119563 RVA: 0x002B1EEB File Offset: 0x002B00EB
		static UKSC_DigitalHeadUiHandle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DigitalHeadUiHandle");
		}

		// Token: 0x0601D30C RID: 119564 RVA: 0x002B1EF9 File Offset: 0x002B00F9
		protected UKSC_DigitalHeadUiHandle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD8C RID: 64908
		internal static int __InterfaceOffset_IKSC_HeadUiHandle;

		// Token: 0x0400FD8D RID: 64909
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DigitalHeadUiHandle";

		// Token: 0x0400FD8E RID: 64910
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD8F RID: 64911
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
