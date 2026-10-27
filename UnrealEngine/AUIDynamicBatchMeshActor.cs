using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002143 RID: 8515
	[UnrealObjectPath("/Script/LGUI.UIDynamicBatchMeshActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUIDynamicBatchMeshActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020128 RID: 131368 RVA: 0x002FB1E0 File Offset: 0x002F93E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUIDynamicBatchMeshActor._ClassPtr;
		}

		// Token: 0x06020129 RID: 131369 RVA: 0x002FB1EC File Offset: 0x002F93EC
		public AUIDynamicBatchMeshActor() : this(BuiltinUtils.AllocNativeUObject(AUIDynamicBatchMeshActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602012A RID: 131370 RVA: 0x002FB214 File Offset: 0x002F9414
		[NullableContext(1)]
		public AUIDynamicBatchMeshActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUIDynamicBatchMeshActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007DF7 RID: 32247
		// (get) Token: 0x0602012B RID: 131371 RVA: 0x002FB247 File Offset: 0x002F9447
		// (set) Token: 0x0602012C RID: 131372 RVA: 0x002FB25B File Offset: 0x002F945B
		[Nullable(2)]
		public unsafe UUIDynamicBatchMesh UIDynamicBatchMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIDynamicBatchMesh>(base.NativePtr / (IntPtr)sizeof(void*) + AUIDynamicBatchMeshActor.__PropertyOffset_UIDynamicBatchMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUIDynamicBatchMeshActor.__PropertyOffset_UIDynamicBatchMesh, value);
			}
		}

		// Token: 0x0602012D RID: 131373 RVA: 0x002FB270 File Offset: 0x002F9470
		static AUIDynamicBatchMeshActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIDynamicBatchMeshActor");
		}

		// Token: 0x0602012E RID: 131374 RVA: 0x002FB27E File Offset: 0x002F947E
		protected AUIDynamicBatchMeshActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011438 RID: 70712
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIDynamicBatchMeshActor";

		// Token: 0x04011439 RID: 70713
		private static IntPtr _ClassPtr;

		// Token: 0x0401143A RID: 70714
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401143B RID: 70715
		internal static int __PropertyOffset_UIDynamicBatchMesh;
	}
}
