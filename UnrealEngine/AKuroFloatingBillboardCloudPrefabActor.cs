using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AFB RID: 6907
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFloatingBillboardCloudPrefabActor")]
	[UnrealStructLayout(1464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1464)]
	public class AKuroFloatingBillboardCloudPrefabActor : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019CD9 RID: 105689 RVA: 0x00261C24 File Offset: 0x0025FE24
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroFloatingBillboardCloudPrefabActor._ClassPtr;
		}

		// Token: 0x06019CDA RID: 105690 RVA: 0x00261C30 File Offset: 0x0025FE30
		public AKuroFloatingBillboardCloudPrefabActor() : this(BuiltinUtils.AllocNativeUObject(AKuroFloatingBillboardCloudPrefabActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019CDB RID: 105691 RVA: 0x00261C58 File Offset: 0x0025FE58
		[NullableContext(1)]
		public AKuroFloatingBillboardCloudPrefabActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroFloatingBillboardCloudPrefabActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700673D RID: 26429
		// (get) Token: 0x06019CDC RID: 105692 RVA: 0x00261C8B File Offset: 0x0025FE8B
		// (set) Token: 0x06019CDD RID: 105693 RVA: 0x00261C9F File Offset: 0x0025FE9F
		public unsafe UKuroPDFloatingBillboardCloudPrefab CloudPrefab
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPDFloatingBillboardCloudPrefab>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFloatingBillboardCloudPrefabActor.__PropertyOffset_CloudPrefab);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFloatingBillboardCloudPrefabActor.__PropertyOffset_CloudPrefab, value);
			}
		}

		// Token: 0x1700673E RID: 26430
		// (get) Token: 0x06019CDE RID: 105694 RVA: 0x00261CB4 File Offset: 0x0025FEB4
		// (set) Token: 0x06019CDF RID: 105695 RVA: 0x00261CC4 File Offset: 0x0025FEC4
		public unsafe double SmoothWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingBillboardCloudPrefabActor.__PropertyOffset_SmoothWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingBillboardCloudPrefabActor.__PropertyOffset_SmoothWidth) = value;
			}
		}

		// Token: 0x06019CE0 RID: 105696 RVA: 0x00261CD8 File Offset: 0x0025FED8
		public UMaterialInstanceDynamic SingleCloudParametersInitial(UStaticMeshComponent Mesh, in FFloatingBillboardCloudParameters CloudStructParameter, int TransSortNumber, UMaterialParameterCollection GloablShadingParameters)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(AKuroFloatingBillboardCloudPrefabActor.__SingleCloudParametersInitial_Internal(base.NativePtr, (Mesh != null) ? Mesh.NativePtr : IntPtr.Zero, (CloudStructParameter ?? new FFloatingBillboardCloudParameters()).NativePtr, TransSortNumber, (GloablShadingParameters != null) ? GloablShadingParameters.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06019CE1 RID: 105697 RVA: 0x00261D28 File Offset: 0x0025FF28
		public UMaterialInstanceDynamic CreateDMI(UStaticMeshComponent Mesh)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(AKuroFloatingBillboardCloudPrefabActor.__CreateDMI_Internal(base.NativePtr, (Mesh != null) ? Mesh.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06019CE2 RID: 105698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SingleCloudParametersInitial_Internal(IntPtr @this, IntPtr Mesh, IntPtr CloudStructParameter, int TransSortNumber, IntPtr GloablShadingParameters);

		// Token: 0x06019CE3 RID: 105699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateDMI_Internal(IntPtr @this, IntPtr Mesh);

		// Token: 0x06019CE4 RID: 105700 RVA: 0x00261D4A File Offset: 0x0025FF4A
		static AKuroFloatingBillboardCloudPrefabActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroFloatingBillboardCloudPrefabActor");
		}

		// Token: 0x06019CE5 RID: 105701 RVA: 0x00261D58 File Offset: 0x0025FF58
		protected AKuroFloatingBillboardCloudPrefabActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E085 RID: 57477
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFloatingBillboardCloudPrefabActor";

		// Token: 0x0400E086 RID: 57478
		private static IntPtr _ClassPtr;

		// Token: 0x0400E087 RID: 57479
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E088 RID: 57480
		internal static int __PropertyOffset_CloudPrefab;

		// Token: 0x0400E089 RID: 57481
		internal static int __PropertyOffset_SmoothWidth;
	}
}
