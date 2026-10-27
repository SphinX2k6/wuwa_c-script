using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009DE RID: 2526
	[UnrealObjectPath("/Script/Engine.DynamicBlueprintBinding")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UDynamicBlueprintBinding : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008EA9 RID: 36521 RVA: 0x000CBFD5 File Offset: 0x000CA1D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDynamicBlueprintBinding._ClassPtr;
		}

		// Token: 0x06008EAA RID: 36522 RVA: 0x000CBFE1 File Offset: 0x000CA1E1
		static UDynamicBlueprintBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DynamicBlueprintBinding");
		}

		// Token: 0x06008EAB RID: 36523 RVA: 0x000CBFF0 File Offset: 0x000CA1F0
		protected UDynamicBlueprintBinding() : this(BuiltinUtils.AllocNativeUObject(UDynamicBlueprintBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008EAC RID: 36524 RVA: 0x000CC018 File Offset: 0x000CA218
		protected UDynamicBlueprintBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040043DA RID: 17370
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DynamicBlueprintBinding";

		// Token: 0x040043DB RID: 17371
		private static IntPtr _ClassPtr;

		// Token: 0x040043DC RID: 17372
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
