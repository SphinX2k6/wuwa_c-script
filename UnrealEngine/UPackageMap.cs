using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000757 RID: 1879
	[UnrealObjectPath("/Script/CoreUObject.PackageMap")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public abstract class UPackageMap : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600632F RID: 25391 RVA: 0x0008E642 File Offset: 0x0008C842
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPackageMap._ClassPtr;
		}

		// Token: 0x06006330 RID: 25392 RVA: 0x0008E64E File Offset: 0x0008C84E
		static UPackageMap()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.PackageMap");
		}

		// Token: 0x06006331 RID: 25393 RVA: 0x0008E65C File Offset: 0x0008C85C
		protected UPackageMap() : this(BuiltinUtils.AllocNativeUObject(UPackageMap.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006332 RID: 25394 RVA: 0x0008E684 File Offset: 0x0008C884
		protected UPackageMap(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F84 RID: 12164
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.PackageMap";

		// Token: 0x04002F85 RID: 12165
		private static IntPtr _ClassPtr;

		// Token: 0x04002F86 RID: 12166
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
