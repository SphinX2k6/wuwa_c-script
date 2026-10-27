using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024BF RID: 9407
	[UnrealObjectPath("/Script/NavmeshPartition.NavmeshPartitionGlobalComponent")]
	[UnrealStructLayout(736, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 736)]
	public class UNavmeshPartitionGlobalComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602335D RID: 144221 RVA: 0x0034153F File Offset: 0x0033F73F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavmeshPartitionGlobalComponent._ClassPtr;
		}

		// Token: 0x0602335E RID: 144222 RVA: 0x0034154C File Offset: 0x0033F74C
		public UNavmeshPartitionGlobalComponent() : this(BuiltinUtils.AllocNativeUObject(UNavmeshPartitionGlobalComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602335F RID: 144223 RVA: 0x00341574 File Offset: 0x0033F774
		[NullableContext(1)]
		public UNavmeshPartitionGlobalComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavmeshPartitionGlobalComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06023360 RID: 144224 RVA: 0x003415A7 File Offset: 0x0033F7A7
		static UNavmeshPartitionGlobalComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavmeshPartition.NavmeshPartitionGlobalComponent");
		}

		// Token: 0x06023361 RID: 144225 RVA: 0x003415B5 File Offset: 0x0033F7B5
		protected UNavmeshPartitionGlobalComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012CE6 RID: 77030
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavmeshPartition.NavmeshPartitionGlobalComponent";

		// Token: 0x04012CE7 RID: 77031
		private static IntPtr _ClassPtr;

		// Token: 0x04012CE8 RID: 77032
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
