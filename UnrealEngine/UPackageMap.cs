using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200013D RID: 317
	[UnrealObjectPath("/Script/CoreUObject.PackageMap")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public abstract class UPackageMap : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600128B RID: 4747 RVA: 0x0001D5C2 File Offset: 0x0001B7C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPackageMap._ClassPtr;
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x0001D5CE File Offset: 0x0001B7CE
		static UPackageMap()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.PackageMap");
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x0001D5DC File Offset: 0x0001B7DC
		protected UPackageMap() : this(BuiltinUtils.AllocNativeUObject(UPackageMap.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x0001D604 File Offset: 0x0001B804
		protected UPackageMap(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005BA RID: 1466
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.PackageMap";

		// Token: 0x040005BB RID: 1467
		private static IntPtr _ClassPtr;

		// Token: 0x040005BC RID: 1468
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
