using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024BD RID: 9405
	[UnrealObjectPath("/Script/NavmeshPartition.NavmeshPartitionGlobalActor")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class ANavmeshPartitionGlobalActor : ANavmeshPartitionGlobalBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023351 RID: 144209 RVA: 0x0034141E File Offset: 0x0033F61E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavmeshPartitionGlobalActor._ClassPtr;
		}

		// Token: 0x06023352 RID: 144210 RVA: 0x0034142C File Offset: 0x0033F62C
		public ANavmeshPartitionGlobalActor() : this(BuiltinUtils.AllocNativeUObject(ANavmeshPartitionGlobalActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023353 RID: 144211 RVA: 0x00341454 File Offset: 0x0033F654
		[NullableContext(1)]
		public ANavmeshPartitionGlobalActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANavmeshPartitionGlobalActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06023354 RID: 144212 RVA: 0x00341487 File Offset: 0x0033F687
		static ANavmeshPartitionGlobalActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavmeshPartition.NavmeshPartitionGlobalActor");
		}

		// Token: 0x06023355 RID: 144213 RVA: 0x00341495 File Offset: 0x0033F695
		protected ANavmeshPartitionGlobalActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012CDF RID: 77023
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavmeshPartition.NavmeshPartitionGlobalActor";

		// Token: 0x04012CE0 RID: 77024
		private static IntPtr _ClassPtr;

		// Token: 0x04012CE1 RID: 77025
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
