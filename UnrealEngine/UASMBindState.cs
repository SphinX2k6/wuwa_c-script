using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000820 RID: 2080
	[UnrealObjectPath("/Script/SMSystem.ASMBindState")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UASMBindState : UASMConfigBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B5F8 RID: 46584 RVA: 0x00121729 File Offset: 0x0011F929
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UASMBindState._ClassPtr;
		}

		// Token: 0x0600B5F9 RID: 46585 RVA: 0x00121735 File Offset: 0x0011F935
		static UASMBindState()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.ASMBindState");
		}

		// Token: 0x0600B5FA RID: 46586 RVA: 0x00121744 File Offset: 0x0011F944
		protected UASMBindState() : this(BuiltinUtils.AllocNativeUObject(UASMBindState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B5FB RID: 46587 RVA: 0x0012176C File Offset: 0x0011F96C
		protected UASMBindState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005237 RID: 21047
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.ASMBindState";

		// Token: 0x04005238 RID: 21048
		private static IntPtr _ClassPtr;

		// Token: 0x04005239 RID: 21049
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
