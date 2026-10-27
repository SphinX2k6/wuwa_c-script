using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001086 RID: 4230
	[UnrealObjectPath("/Script/Engine.ReplicationConnectionDriver")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UReplicationConnectionDriver : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F1D1 RID: 61905 RVA: 0x00166D66 File Offset: 0x00164F66
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UReplicationConnectionDriver._ClassPtr;
		}

		// Token: 0x0600F1D2 RID: 61906 RVA: 0x00166D74 File Offset: 0x00164F74
		public UReplicationConnectionDriver() : this(BuiltinUtils.AllocNativeUObject(UReplicationConnectionDriver.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F1D3 RID: 61907 RVA: 0x00166D9C File Offset: 0x00164F9C
		[NullableContext(1)]
		public UReplicationConnectionDriver(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UReplicationConnectionDriver.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F1D4 RID: 61908 RVA: 0x00166DCF File Offset: 0x00164FCF
		static UReplicationConnectionDriver()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ReplicationConnectionDriver");
		}

		// Token: 0x0600F1D5 RID: 61909 RVA: 0x00166DDD File Offset: 0x00164FDD
		protected UReplicationConnectionDriver(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400831E RID: 33566
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ReplicationConnectionDriver";

		// Token: 0x0400831F RID: 33567
		private static IntPtr _ClassPtr;

		// Token: 0x04008320 RID: 33568
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
