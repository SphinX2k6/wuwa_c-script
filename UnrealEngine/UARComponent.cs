using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200039B RID: 923
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARComponent")]
	[UnrealStructLayout(704, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 704)]
	public abstract class UARComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600331D RID: 13085 RVA: 0x0004E622 File Offset: 0x0004C822
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARComponent._ClassPtr;
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x0600331E RID: 13086 RVA: 0x0004E62E File Offset: 0x0004C82E
		// (set) Token: 0x0600331F RID: 13087 RVA: 0x0004E642 File Offset: 0x0004C842
		public unsafe FGuid NativeID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARComponent.__PropertyOffset_NativeID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARComponent.__PropertyOffset_NativeID) = value;
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06003320 RID: 13088 RVA: 0x0004E657 File Offset: 0x0004C857
		// (set) Token: 0x06003321 RID: 13089 RVA: 0x0004E667 File Offset: 0x0004C867
		public unsafe bool bUseDefaultReplication
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARComponent.__PropertyOffset_bUseDefaultReplication) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARComponent.__PropertyOffset_bUseDefaultReplication) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06003322 RID: 13090 RVA: 0x0004E678 File Offset: 0x0004C878
		// (set) Token: 0x06003323 RID: 13091 RVA: 0x0004E68C File Offset: 0x0004C88C
		public unsafe UMaterialInterface DefaultMeshMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UARComponent.__PropertyOffset_DefaultMeshMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UARComponent.__PropertyOffset_DefaultMeshMaterial, value);
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06003324 RID: 13092 RVA: 0x0004E6A1 File Offset: 0x0004C8A1
		// (set) Token: 0x06003325 RID: 13093 RVA: 0x0004E6B5 File Offset: 0x0004C8B5
		public unsafe UMaterialInterface DefaultWireframeMeshMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UARComponent.__PropertyOffset_DefaultWireframeMeshMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UARComponent.__PropertyOffset_DefaultWireframeMeshMaterial, value);
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06003326 RID: 13094 RVA: 0x0004E6CA File Offset: 0x0004C8CA
		// (set) Token: 0x06003327 RID: 13095 RVA: 0x0004E6DE File Offset: 0x0004C8DE
		public unsafe UMRMeshComponent MRMeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMRMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UARComponent.__PropertyOffset_MRMeshComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UARComponent.__PropertyOffset_MRMeshComponent, value);
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06003328 RID: 13096 RVA: 0x0004E6F3 File Offset: 0x0004C8F3
		// (set) Token: 0x06003329 RID: 13097 RVA: 0x0004E707 File Offset: 0x0004C907
		public unsafe UARTrackedGeometry MyTrackedGeometry
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UARTrackedGeometry>(base.NativePtr / (IntPtr)sizeof(void*) + UARComponent.__PropertyOffset_MyTrackedGeometry);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UARComponent.__PropertyOffset_MyTrackedGeometry, value);
			}
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x0004E71C File Offset: 0x0004C91C
		public virtual void UpdateVisualization()
		{
			UARComponent.__UpdateVisualization_Internal(base.NativePtr);
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x0004E729 File Offset: 0x0004C929
		protected virtual void UpdateVisualization_Implementation()
		{
			UARComponent.__UpdateVisualization_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x0004E736 File Offset: 0x0004C936
		public void SetNativeID(FGuid NativeID)
		{
			UARComponent.__SetNativeID_Internal(base.NativePtr, NativeID);
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x0004E744 File Offset: 0x0004C944
		public virtual void ReceiveRemove()
		{
			UARComponent.__ReceiveRemove_Internal(base.NativePtr);
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x0004E751 File Offset: 0x0004C951
		public void OnRep_Payload()
		{
			UARComponent.__OnRep_Payload_Internal(base.NativePtr);
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x0004E75E File Offset: 0x0004C95E
		public UMRMeshComponent GetMRMesh()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMRMeshComponent>(UARComponent.__GetMRMesh_Internal(base.NativePtr));
		}

		// Token: 0x06003330 RID: 13104
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateVisualization_Internal(IntPtr @this);

		// Token: 0x06003331 RID: 13105
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateVisualization_Implementation_Internal(IntPtr @this);

		// Token: 0x06003332 RID: 13106
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNativeID_Internal(IntPtr @this, FGuid NativeID);

		// Token: 0x06003333 RID: 13107
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveRemove_Internal(IntPtr @this);

		// Token: 0x06003334 RID: 13108
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_Payload_Internal(IntPtr @this);

		// Token: 0x06003335 RID: 13109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMRMesh_Internal(IntPtr @this);

		// Token: 0x06003336 RID: 13110 RVA: 0x0004E770 File Offset: 0x0004C970
		static UARComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARComponent");
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x0004E780 File Offset: 0x0004C980
		protected UARComponent() : this(BuiltinUtils.AllocNativeUObject(UARComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x0004E7A8 File Offset: 0x0004C9A8
		protected UARComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400163B RID: 5691
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARComponent";

		// Token: 0x0400163C RID: 5692
		private static IntPtr _ClassPtr;

		// Token: 0x0400163D RID: 5693
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400163E RID: 5694
		internal static int __PropertyOffset_NativeID;

		// Token: 0x0400163F RID: 5695
		internal static int __PropertyOffset_bUseDefaultReplication;

		// Token: 0x04001640 RID: 5696
		internal static int __PropertyOffset_DefaultMeshMaterial;

		// Token: 0x04001641 RID: 5697
		internal static int __PropertyOffset_DefaultWireframeMeshMaterial;

		// Token: 0x04001642 RID: 5698
		internal static int __PropertyOffset_MRMeshComponent;

		// Token: 0x04001643 RID: 5699
		internal static int __PropertyOffset_MyTrackedGeometry;
	}
}
