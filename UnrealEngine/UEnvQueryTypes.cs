using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001B5 RID: 437
	[UnrealObjectPath("/Script/AIModule.EnvQueryTypes")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UEnvQueryTypes : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001A9B RID: 6811 RVA: 0x000279F1 File Offset: 0x00025BF1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryTypes._ClassPtr;
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x000279FD File Offset: 0x00025BFD
		static UEnvQueryTypes()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryTypes");
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x00027A0C File Offset: 0x00025C0C
		protected UEnvQueryTypes() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTypes.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00027A34 File Offset: 0x00025C34
		protected UEnvQueryTypes(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400081F RID: 2079
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryTypes";

		// Token: 0x04000820 RID: 2080
		private static IntPtr _ClassPtr;

		// Token: 0x04000821 RID: 2081
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
