using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FF2 RID: 4082
	[UnrealObjectPath("/Script/Engine.PlannedRuntimePartitionClassFilter")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UPlannedRuntimePartitionClassFilter : UPlannedRuntimePartitionFilter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DD29 RID: 56617 RVA: 0x001459ED File Offset: 0x00143BED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlannedRuntimePartitionClassFilter._ClassPtr;
		}

		// Token: 0x0600DD2A RID: 56618 RVA: 0x001459FC File Offset: 0x00143BFC
		public UPlannedRuntimePartitionClassFilter() : this(BuiltinUtils.AllocNativeUObject(UPlannedRuntimePartitionClassFilter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DD2B RID: 56619 RVA: 0x00145A24 File Offset: 0x00143C24
		[NullableContext(1)]
		public UPlannedRuntimePartitionClassFilter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPlannedRuntimePartitionClassFilter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600DD2C RID: 56620 RVA: 0x00145A57 File Offset: 0x00143C57
		static UPlannedRuntimePartitionClassFilter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlannedRuntimePartitionClassFilter");
		}

		// Token: 0x0600DD2D RID: 56621 RVA: 0x00145A65 File Offset: 0x00143C65
		protected UPlannedRuntimePartitionClassFilter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400778B RID: 30603
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PlannedRuntimePartitionClassFilter";

		// Token: 0x0400778C RID: 30604
		private static IntPtr _ClassPtr;

		// Token: 0x0400778D RID: 30605
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
