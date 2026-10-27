using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024C1 RID: 9409
	[UnrealObjectPath("/Script/NavmeshPartition.NavmeshWaterPartitionGlobalActor")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class ANavmeshWaterPartitionGlobalActor : ANavmeshPartitionGlobalBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023367 RID: 144231 RVA: 0x0034163E File Offset: 0x0033F83E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavmeshWaterPartitionGlobalActor._ClassPtr;
		}

		// Token: 0x06023368 RID: 144232 RVA: 0x0034164C File Offset: 0x0033F84C
		public ANavmeshWaterPartitionGlobalActor() : this(BuiltinUtils.AllocNativeUObject(ANavmeshWaterPartitionGlobalActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023369 RID: 144233 RVA: 0x00341674 File Offset: 0x0033F874
		[NullableContext(1)]
		public ANavmeshWaterPartitionGlobalActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANavmeshWaterPartitionGlobalActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602336A RID: 144234 RVA: 0x003416A7 File Offset: 0x0033F8A7
		static ANavmeshWaterPartitionGlobalActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavmeshPartition.NavmeshWaterPartitionGlobalActor");
		}

		// Token: 0x0602336B RID: 144235 RVA: 0x003416B5 File Offset: 0x0033F8B5
		protected ANavmeshWaterPartitionGlobalActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012CEC RID: 77036
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavmeshPartition.NavmeshWaterPartitionGlobalActor";

		// Token: 0x04012CED RID: 77037
		private static IntPtr _ClassPtr;

		// Token: 0x04012CEE RID: 77038
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
