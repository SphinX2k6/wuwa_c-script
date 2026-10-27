using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010BF RID: 4287
	[UnrealObjectPath("/Script/Engine.RuntimePartitionPolicyMaxGrid")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class URuntimePartitionPolicyMaxGrid : URuntimePartitionPolicy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F4B0 RID: 62640 RVA: 0x0016ACF6 File Offset: 0x00168EF6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimePartitionPolicyMaxGrid._ClassPtr;
		}

		// Token: 0x0600F4B1 RID: 62641 RVA: 0x0016AD04 File Offset: 0x00168F04
		public URuntimePartitionPolicyMaxGrid() : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionPolicyMaxGrid.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F4B2 RID: 62642 RVA: 0x0016AD2C File Offset: 0x00168F2C
		[NullableContext(1)]
		public URuntimePartitionPolicyMaxGrid(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionPolicyMaxGrid.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F4B3 RID: 62643 RVA: 0x0016AD5F File Offset: 0x00168F5F
		static URuntimePartitionPolicyMaxGrid()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimePartitionPolicyMaxGrid");
		}

		// Token: 0x0600F4B4 RID: 62644 RVA: 0x0016AD6D File Offset: 0x00168F6D
		protected URuntimePartitionPolicyMaxGrid(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400849A RID: 33946
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RuntimePartitionPolicyMaxGrid";

		// Token: 0x0400849B RID: 33947
		private static IntPtr _ClassPtr;

		// Token: 0x0400849C RID: 33948
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
