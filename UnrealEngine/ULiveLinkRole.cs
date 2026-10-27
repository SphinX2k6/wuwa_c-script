using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002212 RID: 8722
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkRole")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class ULiveLinkRole : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021393 RID: 136083 RVA: 0x0030FB07 File Offset: 0x0030DD07
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULiveLinkRole._ClassPtr;
		}

		// Token: 0x06021394 RID: 136084 RVA: 0x0030FB13 File Offset: 0x0030DD13
		static ULiveLinkRole()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LiveLinkInterface.LiveLinkRole");
		}

		// Token: 0x06021395 RID: 136085 RVA: 0x0030FB24 File Offset: 0x0030DD24
		protected ULiveLinkRole() : this(BuiltinUtils.AllocNativeUObject(ULiveLinkRole.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021396 RID: 136086 RVA: 0x0030FB4C File Offset: 0x0030DD4C
		protected ULiveLinkRole(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B91 RID: 72593
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkRole";

		// Token: 0x04011B92 RID: 72594
		private static IntPtr _ClassPtr;

		// Token: 0x04011B93 RID: 72595
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
