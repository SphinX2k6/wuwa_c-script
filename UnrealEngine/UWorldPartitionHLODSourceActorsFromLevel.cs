using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001261 RID: 4705
	[UnrealObjectPath("/Script/Engine.WorldPartitionHLODSourceActorsFromLevel")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UWorldPartitionHLODSourceActorsFromLevel : UWorldPartitionHLODSourceActors, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011451 RID: 70737 RVA: 0x00195A32 File Offset: 0x00193C32
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionHLODSourceActorsFromLevel._ClassPtr;
		}

		// Token: 0x06011452 RID: 70738 RVA: 0x00195A40 File Offset: 0x00193C40
		public UWorldPartitionHLODSourceActorsFromLevel() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionHLODSourceActorsFromLevel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011453 RID: 70739 RVA: 0x00195A68 File Offset: 0x00193C68
		[NullableContext(1)]
		public UWorldPartitionHLODSourceActorsFromLevel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionHLODSourceActorsFromLevel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011454 RID: 70740 RVA: 0x00195A9B File Offset: 0x00193C9B
		static UWorldPartitionHLODSourceActorsFromLevel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionHLODSourceActorsFromLevel");
		}

		// Token: 0x06011455 RID: 70741 RVA: 0x00195AA9 File Offset: 0x00193CA9
		protected UWorldPartitionHLODSourceActorsFromLevel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040093D9 RID: 37849
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionHLODSourceActorsFromLevel";

		// Token: 0x040093DA RID: 37850
		private static IntPtr _ClassPtr;

		// Token: 0x040093DB RID: 37851
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
