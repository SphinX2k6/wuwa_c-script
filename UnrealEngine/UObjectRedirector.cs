using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200013B RID: 315
	[UnrealObjectPath("/Script/CoreUObject.ObjectRedirector")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UObjectRedirector : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001281 RID: 4737 RVA: 0x0001D4C1 File Offset: 0x0001B6C1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UObjectRedirector._ClassPtr;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x0001D4D0 File Offset: 0x0001B6D0
		public UObjectRedirector() : this(BuiltinUtils.AllocNativeUObject(UObjectRedirector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x0001D4F8 File Offset: 0x0001B6F8
		[NullableContext(1)]
		public UObjectRedirector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UObjectRedirector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x0001D52B File Offset: 0x0001B72B
		static UObjectRedirector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.ObjectRedirector");
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x0001D539 File Offset: 0x0001B739
		protected UObjectRedirector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005B4 RID: 1460
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.ObjectRedirector";

		// Token: 0x040005B5 RID: 1461
		private static IntPtr _ClassPtr;

		// Token: 0x040005B6 RID: 1462
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
