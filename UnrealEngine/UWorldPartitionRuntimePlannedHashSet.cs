using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200127E RID: 4734
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimePlannedHashSet")]
	[UnrealStructLayout(656, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class UWorldPartitionRuntimePlannedHashSet : UWorldPartitionRuntimeHashSet, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011587 RID: 71047 RVA: 0x00197574 File Offset: 0x00195774
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionRuntimePlannedHashSet._ClassPtr;
		}

		// Token: 0x06011588 RID: 71048 RVA: 0x00197580 File Offset: 0x00195780
		public UWorldPartitionRuntimePlannedHashSet() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionRuntimePlannedHashSet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011589 RID: 71049 RVA: 0x001975A8 File Offset: 0x001957A8
		[NullableContext(1)]
		public UWorldPartitionRuntimePlannedHashSet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionRuntimePlannedHashSet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004394 RID: 17300
		// (get) Token: 0x0601158A RID: 71050 RVA: 0x001975DB File Offset: 0x001957DB
		// (set) Token: 0x0601158B RID: 71051 RVA: 0x001975EF File Offset: 0x001957EF
		[Nullable(2)]
		public unsafe UWorldPartitionPlannedHashSetSettings RuntimePartitionSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorldPartitionPlannedHashSetSettings>(base.NativePtr / (IntPtr)sizeof(void*) + UWorldPartitionRuntimePlannedHashSet.__PropertyOffset_RuntimePartitionSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorldPartitionRuntimePlannedHashSet.__PropertyOffset_RuntimePartitionSettings, value);
			}
		}

		// Token: 0x0601158C RID: 71052 RVA: 0x00197604 File Offset: 0x00195804
		static UWorldPartitionRuntimePlannedHashSet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionRuntimePlannedHashSet");
		}

		// Token: 0x0601158D RID: 71053 RVA: 0x00197612 File Offset: 0x00195812
		protected UWorldPartitionRuntimePlannedHashSet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400947F RID: 38015
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimePlannedHashSet";

		// Token: 0x04009480 RID: 38016
		private static IntPtr _ClassPtr;

		// Token: 0x04009481 RID: 38017
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009482 RID: 38018
		internal static int __PropertyOffset_RuntimePartitionSettings;
	}
}
