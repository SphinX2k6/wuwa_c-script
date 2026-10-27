using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024C0 RID: 9408
	[UnrealObjectPath("/Script/NavmeshPartition.NavmeshWaterPartitionActor")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class ANavmeshWaterPartitionActor : ANavmeshPartitionBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023362 RID: 144226 RVA: 0x003415BE File Offset: 0x0033F7BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavmeshWaterPartitionActor._ClassPtr;
		}

		// Token: 0x06023363 RID: 144227 RVA: 0x003415CC File Offset: 0x0033F7CC
		public ANavmeshWaterPartitionActor() : this(BuiltinUtils.AllocNativeUObject(ANavmeshWaterPartitionActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023364 RID: 144228 RVA: 0x003415F4 File Offset: 0x0033F7F4
		[NullableContext(1)]
		public ANavmeshWaterPartitionActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANavmeshWaterPartitionActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06023365 RID: 144229 RVA: 0x00341627 File Offset: 0x0033F827
		static ANavmeshWaterPartitionActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavmeshPartition.NavmeshWaterPartitionActor");
		}

		// Token: 0x06023366 RID: 144230 RVA: 0x00341635 File Offset: 0x0033F835
		protected ANavmeshWaterPartitionActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012CE9 RID: 77033
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavmeshPartition.NavmeshWaterPartitionActor";

		// Token: 0x04012CEA RID: 77034
		private static IntPtr _ClassPtr;

		// Token: 0x04012CEB RID: 77035
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
