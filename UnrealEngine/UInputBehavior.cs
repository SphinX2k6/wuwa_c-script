using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200156D RID: 5485
	[UnrealObjectPath("/Script/InteractiveToolsFramework.InputBehavior")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UInputBehavior : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013DC4 RID: 81348 RVA: 0x001D2A0C File Offset: 0x001D0C0C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInputBehavior._ClassPtr;
		}

		// Token: 0x06013DC5 RID: 81349 RVA: 0x001D2A18 File Offset: 0x001D0C18
		public UInputBehavior() : this(BuiltinUtils.AllocNativeUObject(UInputBehavior.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013DC6 RID: 81350 RVA: 0x001D2A40 File Offset: 0x001D0C40
		[NullableContext(1)]
		public UInputBehavior(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInputBehavior.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013DC7 RID: 81351 RVA: 0x001D2A73 File Offset: 0x001D0C73
		static UInputBehavior()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.InputBehavior");
		}

		// Token: 0x06013DC8 RID: 81352 RVA: 0x001D2A81 File Offset: 0x001D0C81
		protected UInputBehavior(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ABE8 RID: 44008
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.InputBehavior";

		// Token: 0x0400ABE9 RID: 44009
		private static IntPtr _ClassPtr;

		// Token: 0x0400ABEA RID: 44010
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
