using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200018D RID: 397
	[UnrealObjectPath("/Script/AIModule.EnvQueryContext")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UEnvQueryContext : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060018D4 RID: 6356 RVA: 0x00024832 File Offset: 0x00022A32
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryContext._ClassPtr;
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0002483E File Offset: 0x00022A3E
		static UEnvQueryContext()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryContext");
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0002484C File Offset: 0x00022A4C
		protected UEnvQueryContext() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryContext.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x00024874 File Offset: 0x00022A74
		protected UEnvQueryContext(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040006F6 RID: 1782
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryContext";

		// Token: 0x040006F7 RID: 1783
		private static IntPtr _ClassPtr;

		// Token: 0x040006F8 RID: 1784
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
