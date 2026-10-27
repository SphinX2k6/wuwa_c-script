using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000191 RID: 401
	[UnrealObjectPath("/Script/AIModule.EnvQueryDebugHelpers")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UEnvQueryDebugHelpers : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060018EA RID: 6378 RVA: 0x00024C2A File Offset: 0x00022E2A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryDebugHelpers._ClassPtr;
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x00024C36 File Offset: 0x00022E36
		static UEnvQueryDebugHelpers()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryDebugHelpers");
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x00024C44 File Offset: 0x00022E44
		protected UEnvQueryDebugHelpers() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryDebugHelpers.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x00024C6C File Offset: 0x00022E6C
		protected UEnvQueryDebugHelpers(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000706 RID: 1798
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryDebugHelpers";

		// Token: 0x04000707 RID: 1799
		private static IntPtr _ClassPtr;

		// Token: 0x04000708 RID: 1800
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
