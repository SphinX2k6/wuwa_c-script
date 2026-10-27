using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001284 RID: 4740
	[UnrealObjectPath("/Script/Engine.WorldPartitionStandaloneHLODSubsystem")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UWorldPartitionStandaloneHLODSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060115CF RID: 71119 RVA: 0x00197C5E File Offset: 0x00195E5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionStandaloneHLODSubsystem._ClassPtr;
		}

		// Token: 0x060115D0 RID: 71120 RVA: 0x00197C6C File Offset: 0x00195E6C
		public UWorldPartitionStandaloneHLODSubsystem() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionStandaloneHLODSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060115D1 RID: 71121 RVA: 0x00197C94 File Offset: 0x00195E94
		[NullableContext(1)]
		public UWorldPartitionStandaloneHLODSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionStandaloneHLODSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060115D2 RID: 71122 RVA: 0x00197CC7 File Offset: 0x00195EC7
		static UWorldPartitionStandaloneHLODSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionStandaloneHLODSubsystem");
		}

		// Token: 0x060115D3 RID: 71123 RVA: 0x00197CD5 File Offset: 0x00195ED5
		protected UWorldPartitionStandaloneHLODSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040094AC RID: 38060
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionStandaloneHLODSubsystem";

		// Token: 0x040094AD RID: 38061
		private static IntPtr _ClassPtr;

		// Token: 0x040094AE RID: 38062
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
