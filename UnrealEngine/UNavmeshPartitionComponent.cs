using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024BC RID: 9404
	[UnrealObjectPath("/Script/NavmeshPartition.NavmeshPartitionComponent")]
	[UnrealStructLayout(656, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class UNavmeshPartitionComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602334C RID: 144204 RVA: 0x003413A0 File Offset: 0x0033F5A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavmeshPartitionComponent._ClassPtr;
		}

		// Token: 0x0602334D RID: 144205 RVA: 0x003413AC File Offset: 0x0033F5AC
		public UNavmeshPartitionComponent() : this(BuiltinUtils.AllocNativeUObject(UNavmeshPartitionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602334E RID: 144206 RVA: 0x003413D4 File Offset: 0x0033F5D4
		[NullableContext(1)]
		public UNavmeshPartitionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavmeshPartitionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602334F RID: 144207 RVA: 0x00341407 File Offset: 0x0033F607
		static UNavmeshPartitionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavmeshPartition.NavmeshPartitionComponent");
		}

		// Token: 0x06023350 RID: 144208 RVA: 0x00341415 File Offset: 0x0033F615
		protected UNavmeshPartitionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012CDC RID: 77020
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavmeshPartition.NavmeshPartitionComponent";

		// Token: 0x04012CDD RID: 77021
		private static IntPtr _ClassPtr;

		// Token: 0x04012CDE RID: 77022
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
