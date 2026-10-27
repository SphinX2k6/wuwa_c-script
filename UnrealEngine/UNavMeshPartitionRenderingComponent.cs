using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002636 RID: 9782
	[UnrealObjectPath("/Script/PathFindModule.NavMeshPartitionRenderingComponent")]
	[UnrealStructLayout(1744, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1744)]
	public class UNavMeshPartitionRenderingComponent : UNavMeshRenderingComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060245FB RID: 148987 RVA: 0x0035DB3E File Offset: 0x0035BD3E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavMeshPartitionRenderingComponent._ClassPtr;
		}

		// Token: 0x060245FC RID: 148988 RVA: 0x0035DB4C File Offset: 0x0035BD4C
		public UNavMeshPartitionRenderingComponent() : this(BuiltinUtils.AllocNativeUObject(UNavMeshPartitionRenderingComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060245FD RID: 148989 RVA: 0x0035DB74 File Offset: 0x0035BD74
		[NullableContext(1)]
		public UNavMeshPartitionRenderingComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavMeshPartitionRenderingComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060245FE RID: 148990 RVA: 0x0035DBA7 File Offset: 0x0035BDA7
		static UNavMeshPartitionRenderingComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PathFindModule.NavMeshPartitionRenderingComponent");
		}

		// Token: 0x060245FF RID: 148991 RVA: 0x0035DBB5 File Offset: 0x0035BDB5
		protected UNavMeshPartitionRenderingComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013848 RID: 79944
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/PathFindModule.NavMeshPartitionRenderingComponent";

		// Token: 0x04013849 RID: 79945
		private static IntPtr _ClassPtr;

		// Token: 0x0401384A RID: 79946
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
