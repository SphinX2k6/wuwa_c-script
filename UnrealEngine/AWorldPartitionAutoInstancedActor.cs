using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001250 RID: 4688
	[UnrealObjectPath("/Script/Engine.WorldPartitionAutoInstancedActor")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AWorldPartitionAutoInstancedActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060113F2 RID: 70642 RVA: 0x00194E5C File Offset: 0x0019305C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AWorldPartitionAutoInstancedActor._ClassPtr;
		}

		// Token: 0x060113F3 RID: 70643 RVA: 0x00194E68 File Offset: 0x00193068
		public AWorldPartitionAutoInstancedActor() : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionAutoInstancedActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060113F4 RID: 70644 RVA: 0x00194E90 File Offset: 0x00193090
		[NullableContext(1)]
		public AWorldPartitionAutoInstancedActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionAutoInstancedActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060113F5 RID: 70645 RVA: 0x00194EC3 File Offset: 0x001930C3
		static AWorldPartitionAutoInstancedActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionAutoInstancedActor");
		}

		// Token: 0x060113F6 RID: 70646 RVA: 0x00194ED1 File Offset: 0x001930D1
		protected AWorldPartitionAutoInstancedActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400939A RID: 37786
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionAutoInstancedActor";

		// Token: 0x0400939B RID: 37787
		private static IntPtr _ClassPtr;

		// Token: 0x0400939C RID: 37788
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
