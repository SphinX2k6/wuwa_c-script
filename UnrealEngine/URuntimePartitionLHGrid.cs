using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010B6 RID: 4278
	[UnrealObjectPath("/Script/Engine.RuntimePartitionLHGrid")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class URuntimePartitionLHGrid : URuntimePartition, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F46A RID: 62570 RVA: 0x0016A706 File Offset: 0x00168906
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimePartitionLHGrid._ClassPtr;
		}

		// Token: 0x0600F46B RID: 62571 RVA: 0x0016A714 File Offset: 0x00168914
		public URuntimePartitionLHGrid() : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionLHGrid.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F46C RID: 62572 RVA: 0x0016A73C File Offset: 0x0016893C
		[NullableContext(1)]
		public URuntimePartitionLHGrid(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionLHGrid.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F46D RID: 62573 RVA: 0x0016A76F File Offset: 0x0016896F
		static URuntimePartitionLHGrid()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimePartitionLHGrid");
		}

		// Token: 0x0600F46E RID: 62574 RVA: 0x0016A77D File Offset: 0x0016897D
		protected URuntimePartitionLHGrid(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008477 RID: 33911
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RuntimePartitionLHGrid";

		// Token: 0x04008478 RID: 33912
		private static IntPtr _ClassPtr;

		// Token: 0x04008479 RID: 33913
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
