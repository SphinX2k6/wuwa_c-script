using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FF4 RID: 4084
	[UnrealObjectPath("/Script/Engine.PlannedRuntimePartitionFilter")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UPlannedRuntimePartitionFilter : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DD3E RID: 56638 RVA: 0x00145C16 File Offset: 0x00143E16
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlannedRuntimePartitionFilter._ClassPtr;
		}

		// Token: 0x0600DD3F RID: 56639 RVA: 0x00145C22 File Offset: 0x00143E22
		static UPlannedRuntimePartitionFilter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlannedRuntimePartitionFilter");
		}

		// Token: 0x0600DD40 RID: 56640 RVA: 0x00145C30 File Offset: 0x00143E30
		protected UPlannedRuntimePartitionFilter() : this(BuiltinUtils.AllocNativeUObject(UPlannedRuntimePartitionFilter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DD41 RID: 56641 RVA: 0x00145C58 File Offset: 0x00143E58
		protected UPlannedRuntimePartitionFilter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007797 RID: 30615
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PlannedRuntimePartitionFilter";

		// Token: 0x04007798 RID: 30616
		private static IntPtr _ClassPtr;

		// Token: 0x04007799 RID: 30617
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
