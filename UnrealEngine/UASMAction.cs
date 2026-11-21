using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200081F RID: 2079
	[UnrealObjectPath("/Script/SMSystem.ASMAction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UASMAction : UASMConfigBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B5F4 RID: 46580 RVA: 0x001216DC File Offset: 0x0011F8DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UASMAction._ClassPtr;
		}

		// Token: 0x0600B5F5 RID: 46581 RVA: 0x001216E8 File Offset: 0x0011F8E8
		static UASMAction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.ASMAction");
		}

		// Token: 0x0600B5F6 RID: 46582 RVA: 0x001216F8 File Offset: 0x0011F8F8
		protected UASMAction() : this(BuiltinUtils.AllocNativeUObject(UASMAction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B5F7 RID: 46583 RVA: 0x00121720 File Offset: 0x0011F920
		protected UASMAction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005234 RID: 21044
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.ASMAction";

		// Token: 0x04005235 RID: 21045
		private static IntPtr _ClassPtr;

		// Token: 0x04005236 RID: 21046
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
