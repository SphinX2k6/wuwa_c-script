using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200015A RID: 346
	[UnrealObjectPath("/Script/DeveloperSettings.DeveloperSettings")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public abstract class UDeveloperSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001355 RID: 4949 RVA: 0x0001EAA6 File Offset: 0x0001CCA6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDeveloperSettings._ClassPtr;
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0001EAB2 File Offset: 0x0001CCB2
		static UDeveloperSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/DeveloperSettings.DeveloperSettings");
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x0001EAC0 File Offset: 0x0001CCC0
		protected UDeveloperSettings() : this(BuiltinUtils.AllocNativeUObject(UDeveloperSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0001EAE8 File Offset: 0x0001CCE8
		protected UDeveloperSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400062E RID: 1582
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/DeveloperSettings.DeveloperSettings";

		// Token: 0x0400062F RID: 1583
		private static IntPtr _ClassPtr;

		// Token: 0x04000630 RID: 1584
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
