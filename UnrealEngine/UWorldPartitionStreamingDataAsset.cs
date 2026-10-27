using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001285 RID: 4741
	[UnrealObjectPath("/Script/Engine.WorldPartitionStreamingDataAsset")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UWorldPartitionStreamingDataAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060115D4 RID: 71124 RVA: 0x00197CDE File Offset: 0x00195EDE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionStreamingDataAsset._ClassPtr;
		}

		// Token: 0x060115D5 RID: 71125 RVA: 0x00197CEC File Offset: 0x00195EEC
		public UWorldPartitionStreamingDataAsset() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionStreamingDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060115D6 RID: 71126 RVA: 0x00197D14 File Offset: 0x00195F14
		[NullableContext(1)]
		public UWorldPartitionStreamingDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionStreamingDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060115D7 RID: 71127 RVA: 0x00197D47 File Offset: 0x00195F47
		static UWorldPartitionStreamingDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionStreamingDataAsset");
		}

		// Token: 0x060115D8 RID: 71128 RVA: 0x00197D55 File Offset: 0x00195F55
		protected UWorldPartitionStreamingDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040094AF RID: 38063
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionStreamingDataAsset";

		// Token: 0x040094B0 RID: 38064
		private static IntPtr _ClassPtr;

		// Token: 0x040094B1 RID: 38065
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
