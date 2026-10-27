using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DD2 RID: 7634
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DefaultHeadUiHandle")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKSC_DefaultHeadUiHandle : UKSC_BaseObject, IUnrealUObject, IUnrealObject, IKSC_HeadUiHandle, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601D2D0 RID: 119504 RVA: 0x002B1A93 File Offset: 0x002AFC93
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DefaultHeadUiHandle._ClassPtr;
		}

		// Token: 0x0601D2D1 RID: 119505 RVA: 0x002B1A9F File Offset: 0x002AFC9F
		int IKSC_HeadUiHandle.InterfaceOffset()
		{
			return UKSC_DefaultHeadUiHandle.__InterfaceOffset_IKSC_HeadUiHandle;
		}

		// Token: 0x0601D2D2 RID: 119506 RVA: 0x002B1AA8 File Offset: 0x002AFCA8
		public UKSC_DefaultHeadUiHandle() : this(BuiltinUtils.AllocNativeUObject(UKSC_DefaultHeadUiHandle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D2D3 RID: 119507 RVA: 0x002B1AD0 File Offset: 0x002AFCD0
		[NullableContext(1)]
		public UKSC_DefaultHeadUiHandle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DefaultHeadUiHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D2D4 RID: 119508 RVA: 0x002B1B03 File Offset: 0x002AFD03
		static UKSC_DefaultHeadUiHandle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DefaultHeadUiHandle");
		}

		// Token: 0x0601D2D5 RID: 119509 RVA: 0x002B1B11 File Offset: 0x002AFD11
		protected UKSC_DefaultHeadUiHandle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD75 RID: 64885
		internal static int __InterfaceOffset_IKSC_HeadUiHandle;

		// Token: 0x0400FD76 RID: 64886
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DefaultHeadUiHandle";

		// Token: 0x0400FD77 RID: 64887
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD78 RID: 64888
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
