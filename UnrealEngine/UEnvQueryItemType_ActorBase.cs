using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001A1 RID: 417
	[UnrealObjectPath("/Script/AIModule.EnvQueryItemType_ActorBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UEnvQueryItemType_ActorBase : UEnvQueryItemType_VectorBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060019B9 RID: 6585 RVA: 0x0002626A File Offset: 0x0002446A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryItemType_ActorBase._ClassPtr;
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x00026276 File Offset: 0x00024476
		static UEnvQueryItemType_ActorBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryItemType_ActorBase");
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x00026284 File Offset: 0x00024484
		protected UEnvQueryItemType_ActorBase() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryItemType_ActorBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x000262AC File Offset: 0x000244AC
		protected UEnvQueryItemType_ActorBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400078E RID: 1934
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryItemType_ActorBase";

		// Token: 0x0400078F RID: 1935
		private static IntPtr _ClassPtr;

		// Token: 0x04000790 RID: 1936
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
