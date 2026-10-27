using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001083 RID: 4227
	[UnrealObjectPath("/Script/Engine.ReplayNetConnection")]
	[UnrealStructLayout(9080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 9080)]
	public class UReplayNetConnection : UNetConnection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F1BD RID: 61885 RVA: 0x00166BCD File Offset: 0x00164DCD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UReplayNetConnection._ClassPtr;
		}

		// Token: 0x0600F1BE RID: 61886 RVA: 0x00166BDC File Offset: 0x00164DDC
		public UReplayNetConnection() : this(BuiltinUtils.AllocNativeUObject(UReplayNetConnection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F1BF RID: 61887 RVA: 0x00166C04 File Offset: 0x00164E04
		[NullableContext(1)]
		public UReplayNetConnection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UReplayNetConnection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F1C0 RID: 61888 RVA: 0x00166C37 File Offset: 0x00164E37
		static UReplayNetConnection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ReplayNetConnection");
		}

		// Token: 0x0600F1C1 RID: 61889 RVA: 0x00166C45 File Offset: 0x00164E45
		protected UReplayNetConnection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008315 RID: 33557
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ReplayNetConnection";

		// Token: 0x04008316 RID: 33558
		private static IntPtr _ClassPtr;

		// Token: 0x04008317 RID: 33559
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
