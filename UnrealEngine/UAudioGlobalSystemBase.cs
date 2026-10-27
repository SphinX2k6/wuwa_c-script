using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200086C RID: 2156
	[UnrealObjectPath("/Script/Engine.AudioGlobalSystemBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UAudioGlobalSystemBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007511 RID: 29969 RVA: 0x000A7CC8 File Offset: 0x000A5EC8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAudioGlobalSystemBase._ClassPtr;
		}

		// Token: 0x06007512 RID: 29970 RVA: 0x000A7CD4 File Offset: 0x000A5ED4
		static UAudioGlobalSystemBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AudioGlobalSystemBase");
		}

		// Token: 0x06007513 RID: 29971 RVA: 0x000A7CE4 File Offset: 0x000A5EE4
		protected UAudioGlobalSystemBase() : this(BuiltinUtils.AllocNativeUObject(UAudioGlobalSystemBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007514 RID: 29972 RVA: 0x000A7D0C File Offset: 0x000A5F0C
		protected UAudioGlobalSystemBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003845 RID: 14405
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AudioGlobalSystemBase";

		// Token: 0x04003846 RID: 14406
		private static IntPtr _ClassPtr;

		// Token: 0x04003847 RID: 14407
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
