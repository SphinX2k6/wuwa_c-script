using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200246B RID: 9323
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MRMesh.MRMeshComponent")]
	[UnrealStructLayout(1744, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1744)]
	public class UMRMeshComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject, IInterface_CollisionDataProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022E8E RID: 142990 RVA: 0x00339BEC File Offset: 0x00337DEC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMRMeshComponent._ClassPtr;
		}

		// Token: 0x06022E8F RID: 142991 RVA: 0x00339BF8 File Offset: 0x00337DF8
		int IInterface_CollisionDataProvider.InterfaceOffset()
		{
			return UMRMeshComponent.__InterfaceOffset_IInterface_CollisionDataProvider;
		}

		// Token: 0x06022E90 RID: 142992 RVA: 0x00339C00 File Offset: 0x00337E00
		public UMRMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UMRMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022E91 RID: 142993 RVA: 0x00339C28 File Offset: 0x00337E28
		[NullableContext(1)]
		public UMRMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMRMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008620 RID: 34336
		// (get) Token: 0x06022E92 RID: 142994 RVA: 0x00339C5B File Offset: 0x00337E5B
		// (set) Token: 0x06022E93 RID: 142995 RVA: 0x00339C6F File Offset: 0x00337E6F
		public unsafe UMaterialInterface Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UMRMeshComponent.__PropertyOffset_Material);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMRMeshComponent.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x17008621 RID: 34337
		// (get) Token: 0x06022E94 RID: 142996 RVA: 0x00339C84 File Offset: 0x00337E84
		// (set) Token: 0x06022E95 RID: 142997 RVA: 0x00339C98 File Offset: 0x00337E98
		public unsafe UMaterialInterface WireframeMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UMRMeshComponent.__PropertyOffset_WireframeMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMRMeshComponent.__PropertyOffset_WireframeMaterial, value);
			}
		}

		// Token: 0x17008622 RID: 34338
		// (get) Token: 0x06022E96 RID: 142998 RVA: 0x00339CAD File Offset: 0x00337EAD
		// (set) Token: 0x06022E97 RID: 142999 RVA: 0x00339CBD File Offset: 0x00337EBD
		public unsafe bool bCreateMeshProxySections
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMRMeshComponent.__PropertyOffset_bCreateMeshProxySections) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMRMeshComponent.__PropertyOffset_bCreateMeshProxySections) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008623 RID: 34339
		// (get) Token: 0x06022E98 RID: 143000 RVA: 0x00339CCE File Offset: 0x00337ECE
		// (set) Token: 0x06022E99 RID: 143001 RVA: 0x00339CDE File Offset: 0x00337EDE
		public unsafe bool bUpdateNavMeshOnMeshUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMRMeshComponent.__PropertyOffset_bUpdateNavMeshOnMeshUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMRMeshComponent.__PropertyOffset_bUpdateNavMeshOnMeshUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008624 RID: 34340
		// (get) Token: 0x06022E9A RID: 143002 RVA: 0x00339CEF File Offset: 0x00337EEF
		// (set) Token: 0x06022E9B RID: 143003 RVA: 0x00339CFF File Offset: 0x00337EFF
		public unsafe bool bNeverCreateCollisionMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMRMeshComponent.__PropertyOffset_bNeverCreateCollisionMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMRMeshComponent.__PropertyOffset_bNeverCreateCollisionMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008625 RID: 34341
		// (get) Token: 0x06022E9C RID: 143004 RVA: 0x00339D10 File Offset: 0x00337F10
		// (set) Token: 0x06022E9D RID: 143005 RVA: 0x00339D24 File Offset: 0x00337F24
		public unsafe UBodySetup CachedBodySetup
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + UMRMeshComponent.__PropertyOffset_CachedBodySetup);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMRMeshComponent.__PropertyOffset_CachedBodySetup, value);
			}
		}

		// Token: 0x17008626 RID: 34342
		// (get) Token: 0x06022E9E RID: 143006 RVA: 0x00339D3C File Offset: 0x00337F3C
		// (set) Token: 0x06022E9F RID: 143007 RVA: 0x00339D75 File Offset: 0x00337F75
		[Nullable(1)]
		public TArray<UBodySetup> BodySetups
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UBodySetup> result;
				if ((result = this._BodySetups) == null)
				{
					result = (this._BodySetups = new TArray<UBodySetup>(base.NativePtr + (IntPtr)UMRMeshComponent.__PropertyOffset_BodySetups, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BodySetups.CopyAssign(value);
			}
		}

		// Token: 0x06022EA0 RID: 143008 RVA: 0x00339D83 File Offset: 0x00337F83
		public void SetWireframeMaterial(UMaterialInterface InMaterial)
		{
			UMRMeshComponent.__SetWireframeMaterial_Internal(base.NativePtr, (InMaterial != null) ? InMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06022EA1 RID: 143009 RVA: 0x00339DA0 File Offset: 0x00337FA0
		public void SetWireframeColor(in FLinearColor InColor)
		{
			UMRMeshComponent.__SetWireframeColor_Internal(base.NativePtr, InColor);
		}

		// Token: 0x06022EA2 RID: 143010 RVA: 0x00339DAE File Offset: 0x00337FAE
		public void SetUseWireframe(bool bUseWireframe)
		{
			UMRMeshComponent.__SetUseWireframe_Internal(base.NativePtr, bUseWireframe);
		}

		// Token: 0x06022EA3 RID: 143011 RVA: 0x00339DBC File Offset: 0x00337FBC
		public void SetEnableMeshOcclusion(bool bEnable)
		{
			UMRMeshComponent.__SetEnableMeshOcclusion_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x06022EA4 RID: 143012 RVA: 0x00339DCA File Offset: 0x00337FCA
		public bool IsConnected()
		{
			return UMRMeshComponent.__IsConnected_Internal(base.NativePtr);
		}

		// Token: 0x06022EA5 RID: 143013 RVA: 0x00339DD7 File Offset: 0x00337FD7
		public FLinearColor GetWireframeColor()
		{
			return UMRMeshComponent.__GetWireframeColor_Internal(base.NativePtr);
		}

		// Token: 0x06022EA6 RID: 143014 RVA: 0x00339DE4 File Offset: 0x00337FE4
		public bool GetUseWireframe()
		{
			return UMRMeshComponent.__GetUseWireframe_Internal(base.NativePtr);
		}

		// Token: 0x06022EA7 RID: 143015 RVA: 0x00339DF1 File Offset: 0x00337FF1
		public bool GetEnableMeshOcclusion()
		{
			return UMRMeshComponent.__GetEnableMeshOcclusion_Internal(base.NativePtr);
		}

		// Token: 0x06022EA8 RID: 143016 RVA: 0x00339DFE File Offset: 0x00337FFE
		public void ForceNavMeshUpdate()
		{
			UMRMeshComponent.__ForceNavMeshUpdate_Internal(base.NativePtr);
		}

		// Token: 0x06022EA9 RID: 143017 RVA: 0x00339E0B File Offset: 0x0033800B
		public void Clear()
		{
			UMRMeshComponent.__Clear_Internal(base.NativePtr);
		}

		// Token: 0x06022EAA RID: 143018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWireframeMaterial_Internal(IntPtr @this, IntPtr InMaterial);

		// Token: 0x06022EAB RID: 143019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWireframeColor_Internal(IntPtr @this, in FLinearColor InColor);

		// Token: 0x06022EAC RID: 143020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseWireframe_Internal(IntPtr @this, bool bUseWireframe);

		// Token: 0x06022EAD RID: 143021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableMeshOcclusion_Internal(IntPtr @this, bool bEnable);

		// Token: 0x06022EAE RID: 143022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsConnected_Internal(IntPtr @this);

		// Token: 0x06022EAF RID: 143023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetWireframeColor_Internal(IntPtr @this);

		// Token: 0x06022EB0 RID: 143024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetUseWireframe_Internal(IntPtr @this);

		// Token: 0x06022EB1 RID: 143025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetEnableMeshOcclusion_Internal(IntPtr @this);

		// Token: 0x06022EB2 RID: 143026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceNavMeshUpdate_Internal(IntPtr @this);

		// Token: 0x06022EB3 RID: 143027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Clear_Internal(IntPtr @this);

		// Token: 0x06022EB4 RID: 143028 RVA: 0x00339E18 File Offset: 0x00338018
		static UMRMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MRMesh.MRMeshComponent");
		}

		// Token: 0x06022EB5 RID: 143029 RVA: 0x00339E26 File Offset: 0x00338026
		protected UMRMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A2A RID: 76330
		internal static int __InterfaceOffset_IInterface_CollisionDataProvider;

		// Token: 0x04012A2B RID: 76331
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MRMesh.MRMeshComponent";

		// Token: 0x04012A2C RID: 76332
		private static IntPtr _ClassPtr;

		// Token: 0x04012A2D RID: 76333
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012A2E RID: 76334
		internal static int __PropertyOffset_Material;

		// Token: 0x04012A2F RID: 76335
		internal static int __PropertyOffset_WireframeMaterial;

		// Token: 0x04012A30 RID: 76336
		internal static int __PropertyOffset_bCreateMeshProxySections;

		// Token: 0x04012A31 RID: 76337
		internal static int __PropertyOffset_bUpdateNavMeshOnMeshUpdate;

		// Token: 0x04012A32 RID: 76338
		internal static int __PropertyOffset_bNeverCreateCollisionMesh;

		// Token: 0x04012A33 RID: 76339
		internal static int __PropertyOffset_CachedBodySetup;

		// Token: 0x04012A34 RID: 76340
		internal static int __PropertyOffset_BodySetups;

		// Token: 0x04012A35 RID: 76341
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBodySetup> _BodySetups;
	}
}
