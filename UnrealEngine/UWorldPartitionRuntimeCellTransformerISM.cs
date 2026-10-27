using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001276 RID: 4726
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeCellTransformerISM")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UWorldPartitionRuntimeCellTransformerISM : UWorldPartitionRuntimeCellTransformer, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601153B RID: 70971 RVA: 0x00196EAD File Offset: 0x001950AD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionRuntimeCellTransformerISM._ClassPtr;
		}

		// Token: 0x0601153C RID: 70972 RVA: 0x00196EBC File Offset: 0x001950BC
		public UWorldPartitionRuntimeCellTransformerISM() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionRuntimeCellTransformerISM.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601153D RID: 70973 RVA: 0x00196EE4 File Offset: 0x001950E4
		[NullableContext(1)]
		public UWorldPartitionRuntimeCellTransformerISM(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionRuntimeCellTransformerISM.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601153E RID: 70974 RVA: 0x00196F17 File Offset: 0x00195117
		static UWorldPartitionRuntimeCellTransformerISM()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionRuntimeCellTransformerISM");
		}

		// Token: 0x0601153F RID: 70975 RVA: 0x00196F25 File Offset: 0x00195125
		protected UWorldPartitionRuntimeCellTransformerISM(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009457 RID: 37975
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeCellTransformerISM";

		// Token: 0x04009458 RID: 37976
		private static IntPtr _ClassPtr;

		// Token: 0x04009459 RID: 37977
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
