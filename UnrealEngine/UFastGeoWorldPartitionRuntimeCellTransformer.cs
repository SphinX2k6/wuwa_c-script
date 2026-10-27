using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200129D RID: 4765
	[UnrealObjectPath("/Script/FastGeoStreaming.FastGeoWorldPartitionRuntimeCellTransformer")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UFastGeoWorldPartitionRuntimeCellTransformer : UWorldPartitionRuntimeCellTransformer, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060117A2 RID: 71586 RVA: 0x0019A82E File Offset: 0x00198A2E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFastGeoWorldPartitionRuntimeCellTransformer._ClassPtr;
		}

		// Token: 0x060117A3 RID: 71587 RVA: 0x0019A83C File Offset: 0x00198A3C
		public UFastGeoWorldPartitionRuntimeCellTransformer() : this(BuiltinUtils.AllocNativeUObject(UFastGeoWorldPartitionRuntimeCellTransformer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060117A4 RID: 71588 RVA: 0x0019A864 File Offset: 0x00198A64
		[NullableContext(1)]
		public UFastGeoWorldPartitionRuntimeCellTransformer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFastGeoWorldPartitionRuntimeCellTransformer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060117A5 RID: 71589 RVA: 0x0019A897 File Offset: 0x00198A97
		static UFastGeoWorldPartitionRuntimeCellTransformer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FastGeoStreaming.FastGeoWorldPartitionRuntimeCellTransformer");
		}

		// Token: 0x060117A6 RID: 71590 RVA: 0x0019A8A5 File Offset: 0x00198AA5
		protected UFastGeoWorldPartitionRuntimeCellTransformer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040095AF RID: 38319
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FastGeoStreaming.FastGeoWorldPartitionRuntimeCellTransformer";

		// Token: 0x040095B0 RID: 38320
		private static IntPtr _ClassPtr;

		// Token: 0x040095B1 RID: 38321
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
