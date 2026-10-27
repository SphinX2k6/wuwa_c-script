using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001259 RID: 4697
	[UnrealObjectPath("/Script/Engine.WorldPartitionEditorSpatialHash")]
	[UnrealStructLayout(544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 544)]
	public class UWorldPartitionEditorSpatialHash : UWorldPartitionEditorHash, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011427 RID: 70695 RVA: 0x00195686 File Offset: 0x00193886
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionEditorSpatialHash._ClassPtr;
		}

		// Token: 0x06011428 RID: 70696 RVA: 0x00195694 File Offset: 0x00193894
		public UWorldPartitionEditorSpatialHash() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionEditorSpatialHash.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011429 RID: 70697 RVA: 0x001956BC File Offset: 0x001938BC
		[NullableContext(1)]
		public UWorldPartitionEditorSpatialHash(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionEditorSpatialHash.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601142A RID: 70698 RVA: 0x001956EF File Offset: 0x001938EF
		static UWorldPartitionEditorSpatialHash()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionEditorSpatialHash");
		}

		// Token: 0x0601142B RID: 70699 RVA: 0x001956FD File Offset: 0x001938FD
		protected UWorldPartitionEditorSpatialHash(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040093BF RID: 37823
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionEditorSpatialHash";

		// Token: 0x040093C0 RID: 37824
		private static IntPtr _ClassPtr;

		// Token: 0x040093C1 RID: 37825
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
