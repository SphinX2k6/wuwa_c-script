using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200013C RID: 316
	[UnrealObjectPath("/Script/CoreUObject.Package")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UPackage : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001286 RID: 4742 RVA: 0x0001D542 File Offset: 0x0001B742
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPackage._ClassPtr;
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x0001D550 File Offset: 0x0001B750
		public UPackage() : this(BuiltinUtils.AllocNativeUObject(UPackage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x0001D578 File Offset: 0x0001B778
		[NullableContext(1)]
		public UPackage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPackage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x0001D5AB File Offset: 0x0001B7AB
		static UPackage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Package");
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x0001D5B9 File Offset: 0x0001B7B9
		protected UPackage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005B7 RID: 1463
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Package";

		// Token: 0x040005B8 RID: 1464
		private static IntPtr _ClassPtr;

		// Token: 0x040005B9 RID: 1465
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
