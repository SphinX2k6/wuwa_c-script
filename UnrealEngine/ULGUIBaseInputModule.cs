using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002022 RID: 8226
	[UnrealObjectPath("/Script/LGUI.LGUIBaseInputModule")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public abstract class ULGUIBaseInputModule : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EFD2 RID: 126930 RVA: 0x002E1561 File Offset: 0x002DF761
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIBaseInputModule._ClassPtr;
		}

		// Token: 0x0601EFD3 RID: 126931 RVA: 0x002E156D File Offset: 0x002DF76D
		public void ClearEvent()
		{
			ULGUIBaseInputModule.__ClearEvent_Internal(base.NativePtr);
		}

		// Token: 0x0601EFD4 RID: 126932
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearEvent_Internal(IntPtr @this);

		// Token: 0x0601EFD5 RID: 126933 RVA: 0x002E157A File Offset: 0x002DF77A
		static ULGUIBaseInputModule()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIBaseInputModule");
		}

		// Token: 0x0601EFD6 RID: 126934 RVA: 0x002E1588 File Offset: 0x002DF788
		protected ULGUIBaseInputModule() : this(BuiltinUtils.AllocNativeUObject(ULGUIBaseInputModule.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EFD7 RID: 126935 RVA: 0x002E15B0 File Offset: 0x002DF7B0
		protected ULGUIBaseInputModule(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D86 RID: 68998
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIBaseInputModule";

		// Token: 0x04010D87 RID: 68999
		private static IntPtr _ClassPtr;

		// Token: 0x04010D88 RID: 69000
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
