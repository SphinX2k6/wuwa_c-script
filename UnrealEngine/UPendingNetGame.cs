using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FD2 RID: 4050
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PendingNetGame")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UPendingNetGame : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DAD3 RID: 56019 RVA: 0x001429B4 File Offset: 0x00140BB4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPendingNetGame._ClassPtr;
		}

		// Token: 0x0600DAD4 RID: 56020 RVA: 0x001429C0 File Offset: 0x00140BC0
		public UPendingNetGame() : this(BuiltinUtils.AllocNativeUObject(UPendingNetGame.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DAD5 RID: 56021 RVA: 0x001429E8 File Offset: 0x00140BE8
		[NullableContext(1)]
		public UPendingNetGame(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPendingNetGame.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033A0 RID: 13216
		// (get) Token: 0x0600DAD6 RID: 56022 RVA: 0x00142A1B File Offset: 0x00140C1B
		// (set) Token: 0x0600DAD7 RID: 56023 RVA: 0x00142A2F File Offset: 0x00140C2F
		public unsafe UNetDriver NetDriver
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNetDriver>(base.NativePtr / (IntPtr)sizeof(void*) + UPendingNetGame.__PropertyOffset_NetDriver);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPendingNetGame.__PropertyOffset_NetDriver, value);
			}
		}

		// Token: 0x170033A1 RID: 13217
		// (get) Token: 0x0600DAD8 RID: 56024 RVA: 0x00142A44 File Offset: 0x00140C44
		// (set) Token: 0x0600DAD9 RID: 56025 RVA: 0x00142A58 File Offset: 0x00140C58
		public unsafe UDemoNetDriver DemoNetDriver
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDemoNetDriver>(base.NativePtr / (IntPtr)sizeof(void*) + UPendingNetGame.__PropertyOffset_DemoNetDriver);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPendingNetGame.__PropertyOffset_DemoNetDriver, value);
			}
		}

		// Token: 0x0600DADA RID: 56026 RVA: 0x00142A6D File Offset: 0x00140C6D
		static UPendingNetGame()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PendingNetGame");
		}

		// Token: 0x0600DADB RID: 56027 RVA: 0x00142A7B File Offset: 0x00140C7B
		protected UPendingNetGame(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400767B RID: 30331
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PendingNetGame";

		// Token: 0x0400767C RID: 30332
		private static IntPtr _ClassPtr;

		// Token: 0x0400767D RID: 30333
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400767E RID: 30334
		internal static int __PropertyOffset_NetDriver;

		// Token: 0x0400767F RID: 30335
		internal static int __PropertyOffset_DemoNetDriver;
	}
}
