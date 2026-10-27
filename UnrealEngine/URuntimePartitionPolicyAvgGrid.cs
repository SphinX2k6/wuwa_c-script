using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010BA RID: 4282
	[UnrealObjectPath("/Script/Engine.RuntimePartitionPolicyAvgGrid")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class URuntimePartitionPolicyAvgGrid : URuntimePartitionPolicy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F47D RID: 62589 RVA: 0x0016A8D1 File Offset: 0x00168AD1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimePartitionPolicyAvgGrid._ClassPtr;
		}

		// Token: 0x0600F47E RID: 62590 RVA: 0x0016A8E0 File Offset: 0x00168AE0
		public URuntimePartitionPolicyAvgGrid() : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionPolicyAvgGrid.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F47F RID: 62591 RVA: 0x0016A908 File Offset: 0x00168B08
		[NullableContext(1)]
		public URuntimePartitionPolicyAvgGrid(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionPolicyAvgGrid.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F480 RID: 62592 RVA: 0x0016A93B File Offset: 0x00168B3B
		static URuntimePartitionPolicyAvgGrid()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimePartitionPolicyAvgGrid");
		}

		// Token: 0x0600F481 RID: 62593 RVA: 0x0016A949 File Offset: 0x00168B49
		protected URuntimePartitionPolicyAvgGrid(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008483 RID: 33923
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RuntimePartitionPolicyAvgGrid";

		// Token: 0x04008484 RID: 33924
		private static IntPtr _ClassPtr;

		// Token: 0x04008485 RID: 33925
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
