using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200102D RID: 4141
	[UnrealObjectPath("/Script/Engine.PrecomputedVisibilityPartitionComponent")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UPrecomputedVisibilityPartitionComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600E8FB RID: 59643 RVA: 0x0015A1FC File Offset: 0x001583FC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPrecomputedVisibilityPartitionComponent._ClassPtr;
		}

		// Token: 0x0600E8FC RID: 59644 RVA: 0x0015A208 File Offset: 0x00158408
		public UPrecomputedVisibilityPartitionComponent() : this(BuiltinUtils.AllocNativeUObject(UPrecomputedVisibilityPartitionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E8FD RID: 59645 RVA: 0x0015A230 File Offset: 0x00158430
		[NullableContext(1)]
		public UPrecomputedVisibilityPartitionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPrecomputedVisibilityPartitionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600E8FE RID: 59646 RVA: 0x0015A263 File Offset: 0x00158463
		static UPrecomputedVisibilityPartitionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PrecomputedVisibilityPartitionComponent");
		}

		// Token: 0x0600E8FF RID: 59647 RVA: 0x0015A271 File Offset: 0x00158471
		protected UPrecomputedVisibilityPartitionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007E7D RID: 32381
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PrecomputedVisibilityPartitionComponent";

		// Token: 0x04007E7E RID: 32382
		private static IntPtr _ClassPtr;

		// Token: 0x04007E7F RID: 32383
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
