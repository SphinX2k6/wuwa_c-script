using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010C1 RID: 4289
	[UnrealObjectPath("/Script/Engine.RuntimePartitionPolicySquaredGrid")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class URuntimePartitionPolicySquaredGrid : URuntimePartitionPolicy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F4BA RID: 62650 RVA: 0x0016ADF6 File Offset: 0x00168FF6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimePartitionPolicySquaredGrid._ClassPtr;
		}

		// Token: 0x0600F4BB RID: 62651 RVA: 0x0016AE04 File Offset: 0x00169004
		public URuntimePartitionPolicySquaredGrid() : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionPolicySquaredGrid.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F4BC RID: 62652 RVA: 0x0016AE2C File Offset: 0x0016902C
		[NullableContext(1)]
		public URuntimePartitionPolicySquaredGrid(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionPolicySquaredGrid.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F4BD RID: 62653 RVA: 0x0016AE5F File Offset: 0x0016905F
		static URuntimePartitionPolicySquaredGrid()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimePartitionPolicySquaredGrid");
		}

		// Token: 0x0600F4BE RID: 62654 RVA: 0x0016AE6D File Offset: 0x0016906D
		protected URuntimePartitionPolicySquaredGrid(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040084A0 RID: 33952
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RuntimePartitionPolicySquaredGrid";

		// Token: 0x040084A1 RID: 33953
		private static IntPtr _ClassPtr;

		// Token: 0x040084A2 RID: 33954
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
