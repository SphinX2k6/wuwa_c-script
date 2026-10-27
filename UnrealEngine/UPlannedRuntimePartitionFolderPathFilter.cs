using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FF5 RID: 4085
	[UnrealObjectPath("/Script/Engine.PlannedRuntimePartitionFolderPathFilter")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UPlannedRuntimePartitionFolderPathFilter : UPlannedRuntimePartitionFilter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DD42 RID: 56642 RVA: 0x00145C61 File Offset: 0x00143E61
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlannedRuntimePartitionFolderPathFilter._ClassPtr;
		}

		// Token: 0x0600DD43 RID: 56643 RVA: 0x00145C70 File Offset: 0x00143E70
		public UPlannedRuntimePartitionFolderPathFilter() : this(BuiltinUtils.AllocNativeUObject(UPlannedRuntimePartitionFolderPathFilter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DD44 RID: 56644 RVA: 0x00145C98 File Offset: 0x00143E98
		[NullableContext(1)]
		public UPlannedRuntimePartitionFolderPathFilter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPlannedRuntimePartitionFolderPathFilter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600DD45 RID: 56645 RVA: 0x00145CCB File Offset: 0x00143ECB
		static UPlannedRuntimePartitionFolderPathFilter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlannedRuntimePartitionFolderPathFilter");
		}

		// Token: 0x0600DD46 RID: 56646 RVA: 0x00145CD9 File Offset: 0x00143ED9
		protected UPlannedRuntimePartitionFolderPathFilter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400779A RID: 30618
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PlannedRuntimePartitionFolderPathFilter";

		// Token: 0x0400779B RID: 30619
		private static IntPtr _ClassPtr;

		// Token: 0x0400779C RID: 30620
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
