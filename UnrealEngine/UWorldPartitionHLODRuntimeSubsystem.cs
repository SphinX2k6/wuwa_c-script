using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200125E RID: 4702
	[UnrealObjectPath("/Script/Engine.WorldPartitionHLODRuntimeSubsystem")]
	[UnrealStructLayout(632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 632)]
	public class UWorldPartitionHLODRuntimeSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011443 RID: 70723 RVA: 0x001958E5 File Offset: 0x00193AE5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionHLODRuntimeSubsystem._ClassPtr;
		}

		// Token: 0x06011444 RID: 70724 RVA: 0x001958F4 File Offset: 0x00193AF4
		public UWorldPartitionHLODRuntimeSubsystem() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionHLODRuntimeSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011445 RID: 70725 RVA: 0x0019591C File Offset: 0x00193B1C
		[NullableContext(1)]
		public UWorldPartitionHLODRuntimeSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionHLODRuntimeSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011446 RID: 70726 RVA: 0x0019594F File Offset: 0x00193B4F
		static UWorldPartitionHLODRuntimeSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionHLODRuntimeSubsystem");
		}

		// Token: 0x06011447 RID: 70727 RVA: 0x0019595D File Offset: 0x00193B5D
		protected UWorldPartitionHLODRuntimeSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040093D0 RID: 37840
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionHLODRuntimeSubsystem";

		// Token: 0x040093D1 RID: 37841
		private static IntPtr _ClassPtr;

		// Token: 0x040093D2 RID: 37842
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
