using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000733 RID: 1843
	[UnrealObjectPath("/Script/CoreUObject.Interface")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UInterface : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006228 RID: 25128 RVA: 0x0008CC0E File Offset: 0x0008AE0E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterface._ClassPtr;
		}

		// Token: 0x06006229 RID: 25129 RVA: 0x0008CC1A File Offset: 0x0008AE1A
		static UInterface()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Interface");
		}

		// Token: 0x0600622A RID: 25130 RVA: 0x0008CC28 File Offset: 0x0008AE28
		protected UInterface() : this(BuiltinUtils.AllocNativeUObject(UInterface.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600622B RID: 25131 RVA: 0x0008CC50 File Offset: 0x0008AE50
		protected UInterface(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002EE0 RID: 12000
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Interface";

		// Token: 0x04002EE1 RID: 12001
		private static IntPtr _ClassPtr;

		// Token: 0x04002EE2 RID: 12002
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
