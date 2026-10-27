using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DFE RID: 7678
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_MarbleHeadUiHandle")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKSC_MarbleHeadUiHandle : UKSC_BaseObject, IUnrealUObject, IUnrealObject, IKSC_HeadUiHandle, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601D550 RID: 120144 RVA: 0x002B4E1F File Offset: 0x002B301F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_MarbleHeadUiHandle._ClassPtr;
		}

		// Token: 0x0601D551 RID: 120145 RVA: 0x002B4E2B File Offset: 0x002B302B
		int IKSC_HeadUiHandle.InterfaceOffset()
		{
			return UKSC_MarbleHeadUiHandle.__InterfaceOffset_IKSC_HeadUiHandle;
		}

		// Token: 0x0601D552 RID: 120146 RVA: 0x002B4E34 File Offset: 0x002B3034
		public UKSC_MarbleHeadUiHandle() : this(BuiltinUtils.AllocNativeUObject(UKSC_MarbleHeadUiHandle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D553 RID: 120147 RVA: 0x002B4E5C File Offset: 0x002B305C
		[NullableContext(1)]
		public UKSC_MarbleHeadUiHandle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_MarbleHeadUiHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D554 RID: 120148 RVA: 0x002B4E8F File Offset: 0x002B308F
		static UKSC_MarbleHeadUiHandle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_MarbleHeadUiHandle");
		}

		// Token: 0x0601D555 RID: 120149 RVA: 0x002B4E9D File Offset: 0x002B309D
		protected UKSC_MarbleHeadUiHandle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE9A RID: 65178
		internal static int __InterfaceOffset_IKSC_HeadUiHandle;

		// Token: 0x0400FE9B RID: 65179
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_MarbleHeadUiHandle";

		// Token: 0x0400FE9C RID: 65180
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE9D RID: 65181
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
