using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200077E RID: 1918
	[UnrealObjectPath("/Script/DeveloperSettings.DeveloperSettings")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public abstract class UDeveloperSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006415 RID: 25621 RVA: 0x0008FDAB File Offset: 0x0008DFAB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDeveloperSettings._ClassPtr;
		}

		// Token: 0x06006416 RID: 25622 RVA: 0x0008FDB7 File Offset: 0x0008DFB7
		static UDeveloperSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/DeveloperSettings.DeveloperSettings");
		}

		// Token: 0x06006417 RID: 25623 RVA: 0x0008FDC8 File Offset: 0x0008DFC8
		protected UDeveloperSettings() : this(BuiltinUtils.AllocNativeUObject(UDeveloperSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006418 RID: 25624 RVA: 0x0008FDF0 File Offset: 0x0008DFF0
		protected UDeveloperSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003033 RID: 12339
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/DeveloperSettings.DeveloperSettings";

		// Token: 0x04003034 RID: 12340
		private static IntPtr _ClassPtr;

		// Token: 0x04003035 RID: 12341
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
