using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000190 RID: 400
	[UnrealObjectPath("/Script/AIModule.EnvQueryContext_Querier")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UEnvQueryContext_Querier : UEnvQueryContext, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060018E5 RID: 6373 RVA: 0x00024BAA File Offset: 0x00022DAA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryContext_Querier._ClassPtr;
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00024BB8 File Offset: 0x00022DB8
		public UEnvQueryContext_Querier() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryContext_Querier.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x00024BE0 File Offset: 0x00022DE0
		[NullableContext(1)]
		public UEnvQueryContext_Querier(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryContext_Querier.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x00024C13 File Offset: 0x00022E13
		static UEnvQueryContext_Querier()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryContext_Querier");
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00024C21 File Offset: 0x00022E21
		protected UEnvQueryContext_Querier(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000703 RID: 1795
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryContext_Querier";

		// Token: 0x04000704 RID: 1796
		private static IntPtr _ClassPtr;

		// Token: 0x04000705 RID: 1797
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
