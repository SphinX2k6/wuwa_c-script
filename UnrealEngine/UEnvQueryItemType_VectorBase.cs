using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001A4 RID: 420
	[UnrealObjectPath("/Script/AIModule.EnvQueryItemType_VectorBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UEnvQueryItemType_VectorBase : UEnvQueryItemType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060019C7 RID: 6599 RVA: 0x000263B6 File Offset: 0x000245B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryItemType_VectorBase._ClassPtr;
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x000263C2 File Offset: 0x000245C2
		static UEnvQueryItemType_VectorBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryItemType_VectorBase");
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x000263D0 File Offset: 0x000245D0
		protected UEnvQueryItemType_VectorBase() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryItemType_VectorBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x000263F8 File Offset: 0x000245F8
		protected UEnvQueryItemType_VectorBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000797 RID: 1943
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryItemType_VectorBase";

		// Token: 0x04000798 RID: 1944
		private static IntPtr _ClassPtr;

		// Token: 0x04000799 RID: 1945
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
