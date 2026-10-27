using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000756 RID: 1878
	[UnrealObjectPath("/Script/CoreUObject.Package")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UPackage : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600632A RID: 25386 RVA: 0x0008E5C2 File Offset: 0x0008C7C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPackage._ClassPtr;
		}

		// Token: 0x0600632B RID: 25387 RVA: 0x0008E5D0 File Offset: 0x0008C7D0
		public UPackage() : this(BuiltinUtils.AllocNativeUObject(UPackage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600632C RID: 25388 RVA: 0x0008E5F8 File Offset: 0x0008C7F8
		[NullableContext(1)]
		public UPackage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPackage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600632D RID: 25389 RVA: 0x0008E62B File Offset: 0x0008C82B
		static UPackage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Package");
		}

		// Token: 0x0600632E RID: 25390 RVA: 0x0008E639 File Offset: 0x0008C839
		protected UPackage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F81 RID: 12161
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Package";

		// Token: 0x04002F82 RID: 12162
		private static IntPtr _ClassPtr;

		// Token: 0x04002F83 RID: 12163
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
