using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200018F RID: 399
	[UnrealObjectPath("/Script/AIModule.EnvQueryContext_Item")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UEnvQueryContext_Item : UEnvQueryContext, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060018E0 RID: 6368 RVA: 0x00024B29 File Offset: 0x00022D29
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryContext_Item._ClassPtr;
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00024B38 File Offset: 0x00022D38
		public UEnvQueryContext_Item() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryContext_Item.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00024B60 File Offset: 0x00022D60
		[NullableContext(1)]
		public UEnvQueryContext_Item(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryContext_Item.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00024B93 File Offset: 0x00022D93
		static UEnvQueryContext_Item()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryContext_Item");
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00024BA1 File Offset: 0x00022DA1
		protected UEnvQueryContext_Item(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000700 RID: 1792
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryContext_Item";

		// Token: 0x04000701 RID: 1793
		private static IntPtr _ClassPtr;

		// Token: 0x04000702 RID: 1794
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
