using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001277 RID: 4727
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeCellTransformerLog")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UWorldPartitionRuntimeCellTransformerLog : UWorldPartitionRuntimeCellTransformer, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011540 RID: 70976 RVA: 0x00196F2E File Offset: 0x0019512E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionRuntimeCellTransformerLog._ClassPtr;
		}

		// Token: 0x06011541 RID: 70977 RVA: 0x00196F3C File Offset: 0x0019513C
		public UWorldPartitionRuntimeCellTransformerLog() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionRuntimeCellTransformerLog.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011542 RID: 70978 RVA: 0x00196F64 File Offset: 0x00195164
		[NullableContext(1)]
		public UWorldPartitionRuntimeCellTransformerLog(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionRuntimeCellTransformerLog.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011543 RID: 70979 RVA: 0x00196F97 File Offset: 0x00195197
		static UWorldPartitionRuntimeCellTransformerLog()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionRuntimeCellTransformerLog");
		}

		// Token: 0x06011544 RID: 70980 RVA: 0x00196FA5 File Offset: 0x001951A5
		protected UWorldPartitionRuntimeCellTransformerLog(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400945A RID: 37978
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeCellTransformerLog";

		// Token: 0x0400945B RID: 37979
		private static IntPtr _ClassPtr;

		// Token: 0x0400945C RID: 37980
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
