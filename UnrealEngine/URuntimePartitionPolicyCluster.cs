using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010BB RID: 4283
	[UnrealObjectPath("/Script/Engine.RuntimePartitionPolicyCluster")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class URuntimePartitionPolicyCluster : URuntimePartitionPolicy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F482 RID: 62594 RVA: 0x0016A952 File Offset: 0x00168B52
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimePartitionPolicyCluster._ClassPtr;
		}

		// Token: 0x0600F483 RID: 62595 RVA: 0x0016A960 File Offset: 0x00168B60
		public URuntimePartitionPolicyCluster() : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionPolicyCluster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F484 RID: 62596 RVA: 0x0016A988 File Offset: 0x00168B88
		[NullableContext(1)]
		public URuntimePartitionPolicyCluster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionPolicyCluster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F485 RID: 62597 RVA: 0x0016A9BB File Offset: 0x00168BBB
		static URuntimePartitionPolicyCluster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimePartitionPolicyCluster");
		}

		// Token: 0x0600F486 RID: 62598 RVA: 0x0016A9C9 File Offset: 0x00168BC9
		protected URuntimePartitionPolicyCluster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008486 RID: 33926
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RuntimePartitionPolicyCluster";

		// Token: 0x04008487 RID: 33927
		private static IntPtr _ClassPtr;

		// Token: 0x04008488 RID: 33928
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
