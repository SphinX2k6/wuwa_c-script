using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019EC RID: 6636
	[UnrealObjectPath("/Script/KuroNavMeshCookData.NavMeshEdgesActor")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class ANavMeshEdgesActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060189D5 RID: 100821 RVA: 0x002444ED File Offset: 0x002426ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavMeshEdgesActor._ClassPtr;
		}

		// Token: 0x060189D6 RID: 100822 RVA: 0x002444FC File Offset: 0x002426FC
		public ANavMeshEdgesActor() : this(BuiltinUtils.AllocNativeUObject(ANavMeshEdgesActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060189D7 RID: 100823 RVA: 0x00244524 File Offset: 0x00242724
		[NullableContext(1)]
		public ANavMeshEdgesActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANavMeshEdgesActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060189D8 RID: 100824 RVA: 0x00244557 File Offset: 0x00242757
		static ANavMeshEdgesActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNavMeshCookData.NavMeshEdgesActor");
		}

		// Token: 0x060189D9 RID: 100825 RVA: 0x00244565 File Offset: 0x00242765
		protected ANavMeshEdgesActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D4DD RID: 54493
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroNavMeshCookData.NavMeshEdgesActor";

		// Token: 0x0400D4DE RID: 54494
		private static IntPtr _ClassPtr;

		// Token: 0x0400D4DF RID: 54495
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
