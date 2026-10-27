using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200128E RID: 4750
	[UnrealObjectPath("/Script/Engine.WorldPartitionVolume")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class AWorldPartitionVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601168A RID: 71306 RVA: 0x00198E0A File Offset: 0x0019700A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AWorldPartitionVolume._ClassPtr;
		}

		// Token: 0x0601168B RID: 71307 RVA: 0x00198E18 File Offset: 0x00197018
		public AWorldPartitionVolume() : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601168C RID: 71308 RVA: 0x00198E40 File Offset: 0x00197040
		[NullableContext(1)]
		public AWorldPartitionVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601168D RID: 71309 RVA: 0x00198E73 File Offset: 0x00197073
		static AWorldPartitionVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionVolume");
		}

		// Token: 0x0601168E RID: 71310 RVA: 0x00198E81 File Offset: 0x00197081
		protected AWorldPartitionVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009505 RID: 38149
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionVolume";

		// Token: 0x04009506 RID: 38150
		private static IntPtr _ClassPtr;

		// Token: 0x04009507 RID: 38151
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
