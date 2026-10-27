using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010BE RID: 4286
	[UnrealObjectPath("/Script/Engine.RuntimePartitionPolicyHLODCluster")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class URuntimePartitionPolicyHLODCluster : URuntimePartitionPolicyCluster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F4AB RID: 62635 RVA: 0x0016AC76 File Offset: 0x00168E76
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimePartitionPolicyHLODCluster._ClassPtr;
		}

		// Token: 0x0600F4AC RID: 62636 RVA: 0x0016AC84 File Offset: 0x00168E84
		public URuntimePartitionPolicyHLODCluster() : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionPolicyHLODCluster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F4AD RID: 62637 RVA: 0x0016ACAC File Offset: 0x00168EAC
		[NullableContext(1)]
		public URuntimePartitionPolicyHLODCluster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionPolicyHLODCluster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F4AE RID: 62638 RVA: 0x0016ACDF File Offset: 0x00168EDF
		static URuntimePartitionPolicyHLODCluster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimePartitionPolicyHLODCluster");
		}

		// Token: 0x0600F4AF RID: 62639 RVA: 0x0016ACED File Offset: 0x00168EED
		protected URuntimePartitionPolicyHLODCluster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008497 RID: 33943
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RuntimePartitionPolicyHLODCluster";

		// Token: 0x04008498 RID: 33944
		private static IntPtr _ClassPtr;

		// Token: 0x04008499 RID: 33945
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
