using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200102C RID: 4140
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PrecomputedVisibilityPartitionActor")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class APrecomputedVisibilityPartitionActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600E8F2 RID: 59634 RVA: 0x0015A12A File Offset: 0x0015832A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APrecomputedVisibilityPartitionActor._ClassPtr;
		}

		// Token: 0x0600E8F3 RID: 59635 RVA: 0x0015A138 File Offset: 0x00158338
		public APrecomputedVisibilityPartitionActor() : this(BuiltinUtils.AllocNativeUObject(APrecomputedVisibilityPartitionActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E8F4 RID: 59636 RVA: 0x0015A160 File Offset: 0x00158360
		[NullableContext(1)]
		public APrecomputedVisibilityPartitionActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APrecomputedVisibilityPartitionActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003867 RID: 14439
		// (get) Token: 0x0600E8F5 RID: 59637 RVA: 0x0015A193 File Offset: 0x00158393
		// (set) Token: 0x0600E8F6 RID: 59638 RVA: 0x0015A1A7 File Offset: 0x001583A7
		public unsafe UPrecomputedVisibilityLoactionComponent LocationComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrecomputedVisibilityLoactionComponent>(base.NativePtr / (IntPtr)sizeof(void*) + APrecomputedVisibilityPartitionActor.__PropertyOffset_LocationComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APrecomputedVisibilityPartitionActor.__PropertyOffset_LocationComponent, value);
			}
		}

		// Token: 0x17003868 RID: 14440
		// (get) Token: 0x0600E8F7 RID: 59639 RVA: 0x0015A1BC File Offset: 0x001583BC
		// (set) Token: 0x0600E8F8 RID: 59640 RVA: 0x0015A1D0 File Offset: 0x001583D0
		public unsafe UPrecomputedVisibilityPartitionComponent PartitionComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrecomputedVisibilityPartitionComponent>(base.NativePtr / (IntPtr)sizeof(void*) + APrecomputedVisibilityPartitionActor.__PropertyOffset_PartitionComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APrecomputedVisibilityPartitionActor.__PropertyOffset_PartitionComponent, value);
			}
		}

		// Token: 0x0600E8F9 RID: 59641 RVA: 0x0015A1E5 File Offset: 0x001583E5
		static APrecomputedVisibilityPartitionActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PrecomputedVisibilityPartitionActor");
		}

		// Token: 0x0600E8FA RID: 59642 RVA: 0x0015A1F3 File Offset: 0x001583F3
		protected APrecomputedVisibilityPartitionActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007E78 RID: 32376
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PrecomputedVisibilityPartitionActor";

		// Token: 0x04007E79 RID: 32377
		private static IntPtr _ClassPtr;

		// Token: 0x04007E7A RID: 32378
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007E7B RID: 32379
		internal static int __PropertyOffset_LocationComponent;

		// Token: 0x04007E7C RID: 32380
		internal static int __PropertyOffset_PartitionComponent;
	}
}
