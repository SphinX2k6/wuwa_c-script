using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F19 RID: 3865
	[UnrealObjectPath("/Script/Engine.OnlineSession")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UOnlineSession : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D0E0 RID: 53472 RVA: 0x001315C2 File Offset: 0x0012F7C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOnlineSession._ClassPtr;
		}

		// Token: 0x0600D0E1 RID: 53473 RVA: 0x001315D0 File Offset: 0x0012F7D0
		public UOnlineSession() : this(BuiltinUtils.AllocNativeUObject(UOnlineSession.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D0E2 RID: 53474 RVA: 0x001315F8 File Offset: 0x0012F7F8
		[NullableContext(1)]
		public UOnlineSession(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOnlineSession.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600D0E3 RID: 53475 RVA: 0x0013162B File Offset: 0x0012F82B
		static UOnlineSession()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.OnlineSession");
		}

		// Token: 0x0600D0E4 RID: 53476 RVA: 0x00131639 File Offset: 0x0012F839
		protected UOnlineSession(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400705A RID: 28762
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.OnlineSession";

		// Token: 0x0400705B RID: 28763
		private static IntPtr _ClassPtr;

		// Token: 0x0400705C RID: 28764
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
