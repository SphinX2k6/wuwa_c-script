using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AD0 RID: 6864
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCloudPrefabActor")]
	[UnrealStructLayout(1464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1464)]
	public class AKuroCloudPrefabActor : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060198FD RID: 104701 RVA: 0x0025C994 File Offset: 0x0025AB94
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCloudPrefabActor._ClassPtr;
		}

		// Token: 0x060198FE RID: 104702 RVA: 0x0025C9A0 File Offset: 0x0025ABA0
		public AKuroCloudPrefabActor() : this(BuiltinUtils.AllocNativeUObject(AKuroCloudPrefabActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060198FF RID: 104703 RVA: 0x0025C9C8 File Offset: 0x0025ABC8
		[NullableContext(1)]
		public AKuroCloudPrefabActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCloudPrefabActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700661E RID: 26142
		// (get) Token: 0x06019900 RID: 104704 RVA: 0x0025C9FB File Offset: 0x0025ABFB
		// (set) Token: 0x06019901 RID: 104705 RVA: 0x0025CA0F File Offset: 0x0025AC0F
		public unsafe UKuroPDCloudPrefab CloudPrefab
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPDCloudPrefab>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCloudPrefabActor.__PropertyOffset_CloudPrefab);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCloudPrefabActor.__PropertyOffset_CloudPrefab, value);
			}
		}

		// Token: 0x1700661F RID: 26143
		// (get) Token: 0x06019902 RID: 104706 RVA: 0x0025CA24 File Offset: 0x0025AC24
		// (set) Token: 0x06019903 RID: 104707 RVA: 0x0025CA34 File Offset: 0x0025AC34
		public unsafe double SmoothWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCloudPrefabActor.__PropertyOffset_SmoothWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCloudPrefabActor.__PropertyOffset_SmoothWidth) = value;
			}
		}

		// Token: 0x17006620 RID: 26144
		// (get) Token: 0x06019904 RID: 104708 RVA: 0x0025CA45 File Offset: 0x0025AC45
		// (set) Token: 0x06019905 RID: 104709 RVA: 0x0025CA55 File Offset: 0x0025AC55
		public unsafe bool bSeqControlCloud
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCloudPrefabActor.__PropertyOffset_bSeqControlCloud) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCloudPrefabActor.__PropertyOffset_bSeqControlCloud) = (value ? 1 : 0);
			}
		}

		// Token: 0x06019906 RID: 104710 RVA: 0x0025CA68 File Offset: 0x0025AC68
		public void SinglePOICloudParametersInitial(UMaterialInstanceDynamic DynamicMaterial, UStaticMeshComponent Mesh, in FPOICloudParameters CloudStructParameter, int TransSortNumber, UMaterialParameterCollection GloablShadingParameters, UMaterialParameterCollection CloudParameters, float Random)
		{
			AKuroCloudPrefabActor.__SinglePOICloudParametersInitial_Internal(base.NativePtr, (DynamicMaterial != null) ? DynamicMaterial.NativePtr : IntPtr.Zero, (Mesh != null) ? Mesh.NativePtr : IntPtr.Zero, (CloudStructParameter ?? new FPOICloudParameters()).NativePtr, TransSortNumber, (GloablShadingParameters != null) ? GloablShadingParameters.NativePtr : IntPtr.Zero, (CloudParameters != null) ? CloudParameters.NativePtr : IntPtr.Zero, Random);
		}

		// Token: 0x06019907 RID: 104711 RVA: 0x0025CAD8 File Offset: 0x0025ACD8
		public void SingleMountainParametersInitial(UStaticMeshComponent Mesh, bool bHasMountain, UMaterialParameterCollection GloablShadingParameters)
		{
			AKuroCloudPrefabActor.__SingleMountainParametersInitial_Internal(base.NativePtr, (Mesh != null) ? Mesh.NativePtr : IntPtr.Zero, bHasMountain, (GloablShadingParameters != null) ? GloablShadingParameters.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06019908 RID: 104712 RVA: 0x0025CB08 File Offset: 0x0025AD08
		public void SingleCloudParametersInitial(UMaterialInstanceDynamic DynamicMaterial, UStaticMeshComponent Mesh, in FCloudParameters CloudStructParameter, int TransSortNumber, UMaterialParameterCollection GloablShadingParameters)
		{
			AKuroCloudPrefabActor.__SingleCloudParametersInitial_Internal(base.NativePtr, (DynamicMaterial != null) ? DynamicMaterial.NativePtr : IntPtr.Zero, (Mesh != null) ? Mesh.NativePtr : IntPtr.Zero, (CloudStructParameter ?? new FCloudParameters()).NativePtr, TransSortNumber, (GloablShadingParameters != null) ? GloablShadingParameters.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06019909 RID: 104713 RVA: 0x0025CB64 File Offset: 0x0025AD64
		public unsafe UMaterialInstanceDynamic SingleCloudCoverParametersInitial(UStaticMeshComponent Mesh, in FCloudCover CloudStructParameter, int TransSortNumber, UMaterialParameterCollection GloablShadingParameters, ref UMaterialInstance CurrentCoverMaterial, ref bool bSetCoverMaterial, UMaterialParameterCollection CloudParameters)
		{
			UMaterialInstance umaterialInstance = CurrentCoverMaterial;
			IntPtr nativeObjectPtr = (umaterialInstance != null) ? umaterialInstance.NativePtr : IntPtr.Zero;
			fixed (bool* ptr = &bSetCoverMaterial)
			{
				void* ptr2 = (void*)ptr;
				UMaterialInstanceDynamic orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(AKuroCloudPrefabActor.__SingleCloudCoverParametersInitial_Internal(base.NativePtr, (Mesh != null) ? Mesh.NativePtr : IntPtr.Zero, (CloudStructParameter ?? new FCloudCover()).NativePtr, TransSortNumber, (GloablShadingParameters != null) ? GloablShadingParameters.NativePtr : IntPtr.Zero, ref nativeObjectPtr, ref bSetCoverMaterial, (CloudParameters != null) ? CloudParameters.NativePtr : IntPtr.Zero));
				CurrentCoverMaterial = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstance>(nativeObjectPtr);
				return orCreateUObjectByNativePointer;
			}
		}

		// Token: 0x0601990A RID: 104714 RVA: 0x0025CBF0 File Offset: 0x0025ADF0
		public void SingleBuildingParametersInitial(UMaterialInstanceDynamic DynamicMaterial, UStaticMeshComponent Mesh, in FAnomaliesParameters CloudStructParameter, int TransSortNumber, UMaterialParameterCollection GloablShadingParameters)
		{
			AKuroCloudPrefabActor.__SingleBuildingParametersInitial_Internal(base.NativePtr, (DynamicMaterial != null) ? DynamicMaterial.NativePtr : IntPtr.Zero, (Mesh != null) ? Mesh.NativePtr : IntPtr.Zero, (CloudStructParameter ?? new FAnomaliesParameters()).NativePtr, TransSortNumber, (GloablShadingParameters != null) ? GloablShadingParameters.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601990B RID: 104715 RVA: 0x0025CC4C File Offset: 0x0025AE4C
		public unsafe void SetGIParams(float CurrentTime, UMaterialParameterCollection CloudCardCollection, in FName ParameterName)
		{
			fixed (FName* ptr = &ParameterName)
			{
				void* ptr2 = (void*)ptr;
				AKuroCloudPrefabActor.__SetGIParams_Internal(base.NativePtr, CurrentTime, (CloudCardCollection != null) ? CloudCardCollection.NativePtr : IntPtr.Zero, ParameterName);
			}
		}

		// Token: 0x0601990C RID: 104716 RVA: 0x0025CC7E File Offset: 0x0025AE7E
		public UMaterialInstanceDynamic CreateDMI(UStaticMeshComponent Mesh)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(AKuroCloudPrefabActor.__CreateDMI_Internal(base.NativePtr, (Mesh != null) ? Mesh.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601990D RID: 104717
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SinglePOICloudParametersInitial_Internal(IntPtr @this, IntPtr DynamicMaterial, IntPtr Mesh, IntPtr CloudStructParameter, int TransSortNumber, IntPtr GloablShadingParameters, IntPtr CloudParameters, float Random);

		// Token: 0x0601990E RID: 104718
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SingleMountainParametersInitial_Internal(IntPtr @this, IntPtr Mesh, bool bHasMountain, IntPtr GloablShadingParameters);

		// Token: 0x0601990F RID: 104719
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SingleCloudParametersInitial_Internal(IntPtr @this, IntPtr DynamicMaterial, IntPtr Mesh, IntPtr CloudStructParameter, int TransSortNumber, IntPtr GloablShadingParameters);

		// Token: 0x06019910 RID: 104720
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SingleCloudCoverParametersInitial_Internal(IntPtr @this, IntPtr Mesh, IntPtr CloudStructParameter, int TransSortNumber, IntPtr GloablShadingParameters, ref IntPtr CurrentCoverMaterial, ref bool bSetCoverMaterial, IntPtr CloudParameters);

		// Token: 0x06019911 RID: 104721
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SingleBuildingParametersInitial_Internal(IntPtr @this, IntPtr DynamicMaterial, IntPtr Mesh, IntPtr CloudStructParameter, int TransSortNumber, IntPtr GloablShadingParameters);

		// Token: 0x06019912 RID: 104722
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGIParams_Internal(IntPtr @this, float CurrentTime, IntPtr CloudCardCollection, in FName ParameterName);

		// Token: 0x06019913 RID: 104723
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateDMI_Internal(IntPtr @this, IntPtr Mesh);

		// Token: 0x06019914 RID: 104724 RVA: 0x0025CCA0 File Offset: 0x0025AEA0
		static AKuroCloudPrefabActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroCloudPrefabActor");
		}

		// Token: 0x06019915 RID: 104725 RVA: 0x0025CCAE File Offset: 0x0025AEAE
		protected AKuroCloudPrefabActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DEB6 RID: 57014
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCloudPrefabActor";

		// Token: 0x0400DEB7 RID: 57015
		private static IntPtr _ClassPtr;

		// Token: 0x0400DEB8 RID: 57016
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DEB9 RID: 57017
		internal static int __PropertyOffset_CloudPrefab;

		// Token: 0x0400DEBA RID: 57018
		internal static int __PropertyOffset_SmoothWidth;

		// Token: 0x0400DEBB RID: 57019
		internal static int __PropertyOffset_bSeqControlCloud;
	}
}
