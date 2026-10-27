using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010B8 RID: 4280
	[UnrealObjectPath("/Script/Engine.RuntimePartitionPersistent")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class URuntimePartitionPersistent : URuntimePartition, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F474 RID: 62580 RVA: 0x0016A806 File Offset: 0x00168A06
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimePartitionPersistent._ClassPtr;
		}

		// Token: 0x0600F475 RID: 62581 RVA: 0x0016A814 File Offset: 0x00168A14
		public URuntimePartitionPersistent() : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionPersistent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F476 RID: 62582 RVA: 0x0016A83C File Offset: 0x00168A3C
		[NullableContext(1)]
		public URuntimePartitionPersistent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionPersistent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F477 RID: 62583 RVA: 0x0016A86F File Offset: 0x00168A6F
		static URuntimePartitionPersistent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimePartitionPersistent");
		}

		// Token: 0x0600F478 RID: 62584 RVA: 0x0016A87D File Offset: 0x00168A7D
		protected URuntimePartitionPersistent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400847D RID: 33917
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RuntimePartitionPersistent";

		// Token: 0x0400847E RID: 33918
		private static IntPtr _ClassPtr;

		// Token: 0x0400847F RID: 33919
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
