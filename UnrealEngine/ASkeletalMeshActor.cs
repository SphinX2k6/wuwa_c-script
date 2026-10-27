using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010F4 RID: 4340
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkeletalMeshActor")]
	[UnrealStructLayout(1208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1208)]
	public class ASkeletalMeshActor : AActor, IUnrealUObject, IUnrealObject, IMatineeAnimInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600F98C RID: 63884 RVA: 0x00171016 File Offset: 0x0016F216
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ASkeletalMeshActor._ClassPtr;
		}

		// Token: 0x0600F98D RID: 63885 RVA: 0x00171022 File Offset: 0x0016F222
		int IMatineeAnimInterface.InterfaceOffset()
		{
			return ASkeletalMeshActor.__InterfaceOffset_IMatineeAnimInterface;
		}

		// Token: 0x0600F98E RID: 63886 RVA: 0x0017102C File Offset: 0x0016F22C
		public ASkeletalMeshActor() : this(BuiltinUtils.AllocNativeUObject(ASkeletalMeshActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F98F RID: 63887 RVA: 0x00171054 File Offset: 0x0016F254
		[NullableContext(1)]
		public ASkeletalMeshActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ASkeletalMeshActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003CD1 RID: 15569
		// (get) Token: 0x0600F990 RID: 63888 RVA: 0x00171087 File Offset: 0x0016F287
		// (set) Token: 0x0600F991 RID: 63889 RVA: 0x001710A0 File Offset: 0x0016F2A0
		public unsafe bool bShouldDoAnimNotifies
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ASkeletalMeshActor.__PropertyOffset_bShouldDoAnimNotifies) & ASkeletalMeshActor.__PropertyMask_bShouldDoAnimNotifies) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ASkeletalMeshActor.__PropertyOffset_bShouldDoAnimNotifies) = ((*(base.NativePtr + (IntPtr)ASkeletalMeshActor.__PropertyOffset_bShouldDoAnimNotifies) & ~ASkeletalMeshActor.__PropertyMask_bShouldDoAnimNotifies) | (value ? ASkeletalMeshActor.__PropertyMask_bShouldDoAnimNotifies : 0));
			}
		}

		// Token: 0x17003CD2 RID: 15570
		// (get) Token: 0x0600F992 RID: 63890 RVA: 0x001710D0 File Offset: 0x0016F2D0
		// (set) Token: 0x0600F993 RID: 63891 RVA: 0x001710E9 File Offset: 0x0016F2E9
		public unsafe bool bWakeOnLevelStart_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ASkeletalMeshActor.__PropertyOffset_bWakeOnLevelStart_DEPRECATED) & ASkeletalMeshActor.__PropertyMask_bWakeOnLevelStart_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ASkeletalMeshActor.__PropertyOffset_bWakeOnLevelStart_DEPRECATED) = ((*(base.NativePtr + (IntPtr)ASkeletalMeshActor.__PropertyOffset_bWakeOnLevelStart_DEPRECATED) & ~ASkeletalMeshActor.__PropertyMask_bWakeOnLevelStart_DEPRECATED) | (value ? ASkeletalMeshActor.__PropertyMask_bWakeOnLevelStart_DEPRECATED : 0));
			}
		}

		// Token: 0x17003CD3 RID: 15571
		// (get) Token: 0x0600F994 RID: 63892 RVA: 0x00171119 File Offset: 0x0016F319
		// (set) Token: 0x0600F995 RID: 63893 RVA: 0x0017112D File Offset: 0x0016F32D
		public unsafe USkeletalMeshComponent SkeletalMeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ASkeletalMeshActor.__PropertyOffset_SkeletalMeshComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ASkeletalMeshActor.__PropertyOffset_SkeletalMeshComponent, value);
			}
		}

		// Token: 0x17003CD4 RID: 15572
		// (get) Token: 0x0600F996 RID: 63894 RVA: 0x00171142 File Offset: 0x0016F342
		// (set) Token: 0x0600F997 RID: 63895 RVA: 0x00171156 File Offset: 0x0016F356
		public unsafe UTextRenderComponent MeshTextComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ASkeletalMeshActor.__PropertyOffset_MeshTextComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ASkeletalMeshActor.__PropertyOffset_MeshTextComponent, value);
			}
		}

		// Token: 0x17003CD5 RID: 15573
		// (get) Token: 0x0600F998 RID: 63896 RVA: 0x0017116B File Offset: 0x0016F36B
		// (set) Token: 0x0600F999 RID: 63897 RVA: 0x0017117F File Offset: 0x0016F37F
		public unsafe USkeletalMesh ReplicatedMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + ASkeletalMeshActor.__PropertyOffset_ReplicatedMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ASkeletalMeshActor.__PropertyOffset_ReplicatedMesh, value);
			}
		}

		// Token: 0x17003CD6 RID: 15574
		// (get) Token: 0x0600F99A RID: 63898 RVA: 0x00171194 File Offset: 0x0016F394
		// (set) Token: 0x0600F99B RID: 63899 RVA: 0x001711A8 File Offset: 0x0016F3A8
		public unsafe UPhysicsAsset ReplicatedPhysAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsAsset>(base.NativePtr / (IntPtr)sizeof(void*) + ASkeletalMeshActor.__PropertyOffset_ReplicatedPhysAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ASkeletalMeshActor.__PropertyOffset_ReplicatedPhysAsset, value);
			}
		}

		// Token: 0x17003CD7 RID: 15575
		// (get) Token: 0x0600F99C RID: 63900 RVA: 0x001711BD File Offset: 0x0016F3BD
		// (set) Token: 0x0600F99D RID: 63901 RVA: 0x001711D1 File Offset: 0x0016F3D1
		public unsafe UMaterialInterface ReplicatedMaterial0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ASkeletalMeshActor.__PropertyOffset_ReplicatedMaterial0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ASkeletalMeshActor.__PropertyOffset_ReplicatedMaterial0, value);
			}
		}

		// Token: 0x17003CD8 RID: 15576
		// (get) Token: 0x0600F99E RID: 63902 RVA: 0x001711E6 File Offset: 0x0016F3E6
		// (set) Token: 0x0600F99F RID: 63903 RVA: 0x001711FA File Offset: 0x0016F3FA
		public unsafe UMaterialInterface ReplicatedMaterial1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ASkeletalMeshActor.__PropertyOffset_ReplicatedMaterial1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ASkeletalMeshActor.__PropertyOffset_ReplicatedMaterial1, value);
			}
		}

		// Token: 0x17003CD9 RID: 15577
		// (get) Token: 0x0600F9A0 RID: 63904 RVA: 0x0017120F File Offset: 0x0016F40F
		// (set) Token: 0x0600F9A1 RID: 63905 RVA: 0x0017121F File Offset: 0x0016F41F
		public unsafe bool bShowLODText
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ASkeletalMeshActor.__PropertyOffset_bShowLODText) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ASkeletalMeshActor.__PropertyOffset_bShowLODText) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CDA RID: 15578
		// (get) Token: 0x0600F9A2 RID: 63906 RVA: 0x00171230 File Offset: 0x0016F430
		// (set) Token: 0x0600F9A3 RID: 63907 RVA: 0x00171269 File Offset: 0x0016F469
		[Nullable(1)]
		public TArray<FMorphTargetPreviewItem> MorphTargetPreviewItems
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FMorphTargetPreviewItem> result;
				if ((result = this._MorphTargetPreviewItems) == null)
				{
					result = (this._MorphTargetPreviewItems = new TArray<FMorphTargetPreviewItem>(base.NativePtr + (IntPtr)ASkeletalMeshActor.__PropertyOffset_MorphTargetPreviewItems, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MorphTargetPreviewItems.CopyAssign(value);
			}
		}

		// Token: 0x0600F9A4 RID: 63908 RVA: 0x00171277 File Offset: 0x0016F477
		public void PreviewMorphTargets()
		{
			ASkeletalMeshActor.__PreviewMorphTargets_Internal(base.NativePtr);
		}

		// Token: 0x0600F9A5 RID: 63909 RVA: 0x00171284 File Offset: 0x0016F484
		public void OnRep_ReplicatedPhysAsset()
		{
			ASkeletalMeshActor.__OnRep_ReplicatedPhysAsset_Internal(base.NativePtr);
		}

		// Token: 0x0600F9A6 RID: 63910 RVA: 0x00171291 File Offset: 0x0016F491
		public void OnRep_ReplicatedMesh()
		{
			ASkeletalMeshActor.__OnRep_ReplicatedMesh_Internal(base.NativePtr);
		}

		// Token: 0x0600F9A7 RID: 63911 RVA: 0x0017129E File Offset: 0x0016F49E
		public void OnRep_ReplicatedMaterial1()
		{
			ASkeletalMeshActor.__OnRep_ReplicatedMaterial1_Internal(base.NativePtr);
		}

		// Token: 0x0600F9A8 RID: 63912 RVA: 0x001712AB File Offset: 0x0016F4AB
		public void OnRep_ReplicatedMaterial0()
		{
			ASkeletalMeshActor.__OnRep_ReplicatedMaterial0_Internal(base.NativePtr);
		}

		// Token: 0x0600F9A9 RID: 63913 RVA: 0x001712B8 File Offset: 0x0016F4B8
		public USkeletalMeshComponent GetSkeletalMeshComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(ASkeletalMeshActor.__GetSkeletalMeshComponent_Internal(base.NativePtr));
		}

		// Token: 0x0600F9AA RID: 63914
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PreviewMorphTargets_Internal(IntPtr @this);

		// Token: 0x0600F9AB RID: 63915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplicatedPhysAsset_Internal(IntPtr @this);

		// Token: 0x0600F9AC RID: 63916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplicatedMesh_Internal(IntPtr @this);

		// Token: 0x0600F9AD RID: 63917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplicatedMaterial1_Internal(IntPtr @this);

		// Token: 0x0600F9AE RID: 63918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplicatedMaterial0_Internal(IntPtr @this);

		// Token: 0x0600F9AF RID: 63919
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSkeletalMeshComponent_Internal(IntPtr @this);

		// Token: 0x0600F9B0 RID: 63920 RVA: 0x001712CA File Offset: 0x0016F4CA
		static ASkeletalMeshActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SkeletalMeshActor");
		}

		// Token: 0x0600F9B1 RID: 63921 RVA: 0x001712D8 File Offset: 0x0016F4D8
		protected ASkeletalMeshActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040086C7 RID: 34503
		internal static int __InterfaceOffset_IMatineeAnimInterface;

		// Token: 0x040086C8 RID: 34504
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SkeletalMeshActor";

		// Token: 0x040086C9 RID: 34505
		private static IntPtr _ClassPtr;

		// Token: 0x040086CA RID: 34506
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040086CB RID: 34507
		internal static int __PropertyOffset_bShouldDoAnimNotifies;

		// Token: 0x040086CC RID: 34508
		internal static byte __PropertyMask_bShouldDoAnimNotifies;

		// Token: 0x040086CD RID: 34509
		internal static int __PropertyOffset_bWakeOnLevelStart_DEPRECATED;

		// Token: 0x040086CE RID: 34510
		internal static byte __PropertyMask_bWakeOnLevelStart_DEPRECATED;

		// Token: 0x040086CF RID: 34511
		internal static int __PropertyOffset_SkeletalMeshComponent;

		// Token: 0x040086D0 RID: 34512
		internal static int __PropertyOffset_MeshTextComponent;

		// Token: 0x040086D1 RID: 34513
		internal static int __PropertyOffset_ReplicatedMesh;

		// Token: 0x040086D2 RID: 34514
		internal static int __PropertyOffset_ReplicatedPhysAsset;

		// Token: 0x040086D3 RID: 34515
		internal static int __PropertyOffset_ReplicatedMaterial0;

		// Token: 0x040086D4 RID: 34516
		internal static int __PropertyOffset_ReplicatedMaterial1;

		// Token: 0x040086D5 RID: 34517
		internal static int __PropertyOffset_bShowLODText;

		// Token: 0x040086D6 RID: 34518
		internal static int __PropertyOffset_MorphTargetPreviewItems;

		// Token: 0x040086D7 RID: 34519
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMorphTargetPreviewItem> _MorphTargetPreviewItems;
	}
}
