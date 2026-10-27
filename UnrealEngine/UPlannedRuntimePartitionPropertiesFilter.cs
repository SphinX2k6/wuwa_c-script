using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FF8 RID: 4088
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PlannedRuntimePartitionPropertiesFilter")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UPlannedRuntimePartitionPropertiesFilter : UPlannedRuntimePartitionFilter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DD65 RID: 56677 RVA: 0x00145F22 File Offset: 0x00144122
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlannedRuntimePartitionPropertiesFilter._ClassPtr;
		}

		// Token: 0x0600DD66 RID: 56678 RVA: 0x00145F30 File Offset: 0x00144130
		public UPlannedRuntimePartitionPropertiesFilter() : this(BuiltinUtils.AllocNativeUObject(UPlannedRuntimePartitionPropertiesFilter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DD67 RID: 56679 RVA: 0x00145F58 File Offset: 0x00144158
		public UPlannedRuntimePartitionPropertiesFilter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPlannedRuntimePartitionPropertiesFilter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700343A RID: 13370
		// (get) Token: 0x0600DD68 RID: 56680 RVA: 0x00145F8C File Offset: 0x0014418C
		// (set) Token: 0x0600DD69 RID: 56681 RVA: 0x00145FC5 File Offset: 0x001441C5
		public TArray<FName> Properties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Properties) == null)
				{
					result = (this._Properties = new TArray<FName>(base.NativePtr + (IntPtr)UPlannedRuntimePartitionPropertiesFilter.__PropertyOffset_Properties, this));
				}
				return result;
			}
			set
			{
				this.Properties.CopyAssign(value);
			}
		}

		// Token: 0x0600DD6A RID: 56682 RVA: 0x00145FD3 File Offset: 0x001441D3
		static UPlannedRuntimePartitionPropertiesFilter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlannedRuntimePartitionPropertiesFilter");
		}

		// Token: 0x0600DD6B RID: 56683 RVA: 0x00145FE1 File Offset: 0x001441E1
		protected UPlannedRuntimePartitionPropertiesFilter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040077A9 RID: 30633
		public new const string __ObjectPath = "/Script/Engine.PlannedRuntimePartitionPropertiesFilter";

		// Token: 0x040077AA RID: 30634
		private static IntPtr _ClassPtr;

		// Token: 0x040077AB RID: 30635
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040077AC RID: 30636
		internal static int __PropertyOffset_Properties;

		// Token: 0x040077AD RID: 30637
		[Nullable(2)]
		private TArray<FName> _Properties;
	}
}
