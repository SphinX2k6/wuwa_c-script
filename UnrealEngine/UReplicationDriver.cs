using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001087 RID: 4231
	[UnrealObjectPath("/Script/Engine.ReplicationDriver")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UReplicationDriver : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F1D6 RID: 61910 RVA: 0x00166DE6 File Offset: 0x00164FE6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UReplicationDriver._ClassPtr;
		}

		// Token: 0x0600F1D7 RID: 61911 RVA: 0x00166DF4 File Offset: 0x00164FF4
		public UReplicationDriver() : this(BuiltinUtils.AllocNativeUObject(UReplicationDriver.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F1D8 RID: 61912 RVA: 0x00166E1C File Offset: 0x0016501C
		[NullableContext(1)]
		public UReplicationDriver(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UReplicationDriver.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F1D9 RID: 61913 RVA: 0x00166E4F File Offset: 0x0016504F
		static UReplicationDriver()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ReplicationDriver");
		}

		// Token: 0x0600F1DA RID: 61914 RVA: 0x00166E5D File Offset: 0x0016505D
		protected UReplicationDriver(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008321 RID: 33569
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ReplicationDriver";

		// Token: 0x04008322 RID: 33570
		private static IntPtr _ClassPtr;

		// Token: 0x04008323 RID: 33571
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
