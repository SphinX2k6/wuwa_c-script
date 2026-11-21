using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200027F RID: 639
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkeletalMeshActor")]
	[UnrealStructLayout(1208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1208)]
	public class ASkeletalMeshActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004280 RID: 17024 RVA: 0x0005EE4A File Offset: 0x0005D04A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ASkeletalMeshActor._ClassPtr;
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x0005EE58 File Offset: 0x0005D058
		public ASkeletalMeshActor() : this(BuiltinUtils.AllocNativeUObject(ASkeletalMeshActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004282 RID: 17026 RVA: 0x0005EE80 File Offset: 0x0005D080
		[NullableContext(1)]
		public ASkeletalMeshActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ASkeletalMeshActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06004283 RID: 17027 RVA: 0x0005EEB3 File Offset: 0x0005D0B3
		// (set) Token: 0x06004284 RID: 17028 RVA: 0x0005EECC File Offset: 0x0005D0CC
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

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06004285 RID: 17029 RVA: 0x0005EEFC File Offset: 0x0005D0FC
		// (set) Token: 0x06004286 RID: 17030 RVA: 0x0005EF15 File Offset: 0x0005D115
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

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06004287 RID: 17031 RVA: 0x0005EF45 File Offset: 0x0005D145
		// (set) Token: 0x06004288 RID: 17032 RVA: 0x0005EF59 File Offset: 0x0005D159
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

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06004289 RID: 17033 RVA: 0x0005EF6E File Offset: 0x0005D16E
		// (set) Token: 0x0600428A RID: 17034 RVA: 0x0005EF82 File Offset: 0x0005D182
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

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x0600428B RID: 17035 RVA: 0x0005EF97 File Offset: 0x0005D197
		// (set) Token: 0x0600428C RID: 17036 RVA: 0x0005EFAB File Offset: 0x0005D1AB
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

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x0600428D RID: 17037 RVA: 0x0005EFC0 File Offset: 0x0005D1C0
		// (set) Token: 0x0600428E RID: 17038 RVA: 0x0005EFD4 File Offset: 0x0005D1D4
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

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x0600428F RID: 17039 RVA: 0x0005EFE9 File Offset: 0x0005D1E9
		// (set) Token: 0x06004290 RID: 17040 RVA: 0x0005EFFD File Offset: 0x0005D1FD
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

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06004291 RID: 17041 RVA: 0x0005F012 File Offset: 0x0005D212
		// (set) Token: 0x06004292 RID: 17042 RVA: 0x0005F026 File Offset: 0x0005D226
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

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06004293 RID: 17043 RVA: 0x0005F03B File Offset: 0x0005D23B
		// (set) Token: 0x06004294 RID: 17044 RVA: 0x0005F04B File Offset: 0x0005D24B
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

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06004295 RID: 17045 RVA: 0x0005F05C File Offset: 0x0005D25C
		// (set) Token: 0x06004296 RID: 17046 RVA: 0x0005F095 File Offset: 0x0005D295
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

		// Token: 0x06004297 RID: 17047 RVA: 0x0005F0A3 File Offset: 0x0005D2A3
		public void PreviewMorphTargets()
		{
			ASkeletalMeshActor.__PreviewMorphTargets_Internal(base.NativePtr);
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x0005F0B0 File Offset: 0x0005D2B0
		public void OnRep_ReplicatedPhysAsset()
		{
			ASkeletalMeshActor.__OnRep_ReplicatedPhysAsset_Internal(base.NativePtr);
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x0005F0BD File Offset: 0x0005D2BD
		public void OnRep_ReplicatedMesh()
		{
			ASkeletalMeshActor.__OnRep_ReplicatedMesh_Internal(base.NativePtr);
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x0005F0CA File Offset: 0x0005D2CA
		public void OnRep_ReplicatedMaterial1()
		{
			ASkeletalMeshActor.__OnRep_ReplicatedMaterial1_Internal(base.NativePtr);
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x0005F0D7 File Offset: 0x0005D2D7
		public void OnRep_ReplicatedMaterial0()
		{
			ASkeletalMeshActor.__OnRep_ReplicatedMaterial0_Internal(base.NativePtr);
		}

		// Token: 0x0600429C RID: 17052 RVA: 0x0005F0E4 File Offset: 0x0005D2E4
		public USkeletalMeshComponent GetSkeletalMeshComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(ASkeletalMeshActor.__GetSkeletalMeshComponent_Internal(base.NativePtr));
		}

		// Token: 0x0600429D RID: 17053
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PreviewMorphTargets_Internal(IntPtr @this);

		// Token: 0x0600429E RID: 17054
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplicatedPhysAsset_Internal(IntPtr @this);

		// Token: 0x0600429F RID: 17055
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplicatedMesh_Internal(IntPtr @this);

		// Token: 0x060042A0 RID: 17056
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplicatedMaterial1_Internal(IntPtr @this);

		// Token: 0x060042A1 RID: 17057
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplicatedMaterial0_Internal(IntPtr @this);

		// Token: 0x060042A2 RID: 17058
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSkeletalMeshComponent_Internal(IntPtr @this);

		// Token: 0x060042A3 RID: 17059 RVA: 0x0005F0F6 File Offset: 0x0005D2F6
		static ASkeletalMeshActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SkeletalMeshActor");
		}

		// Token: 0x060042A4 RID: 17060 RVA: 0x0005F104 File Offset: 0x0005D304
		protected ASkeletalMeshActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001A03 RID: 6659
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SkeletalMeshActor";

		// Token: 0x04001A04 RID: 6660
		private static IntPtr _ClassPtr;

		// Token: 0x04001A05 RID: 6661
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001A06 RID: 6662
		internal static int __PropertyOffset_bShouldDoAnimNotifies;

		// Token: 0x04001A07 RID: 6663
		internal static byte __PropertyMask_bShouldDoAnimNotifies;

		// Token: 0x04001A08 RID: 6664
		internal static int __PropertyOffset_bWakeOnLevelStart_DEPRECATED;

		// Token: 0x04001A09 RID: 6665
		internal static byte __PropertyMask_bWakeOnLevelStart_DEPRECATED;

		// Token: 0x04001A0A RID: 6666
		internal static int __PropertyOffset_SkeletalMeshComponent;

		// Token: 0x04001A0B RID: 6667
		internal static int __PropertyOffset_MeshTextComponent;

		// Token: 0x04001A0C RID: 6668
		internal static int __PropertyOffset_ReplicatedMesh;

		// Token: 0x04001A0D RID: 6669
		internal static int __PropertyOffset_ReplicatedPhysAsset;

		// Token: 0x04001A0E RID: 6670
		internal static int __PropertyOffset_ReplicatedMaterial0;

		// Token: 0x04001A0F RID: 6671
		internal static int __PropertyOffset_ReplicatedMaterial1;

		// Token: 0x04001A10 RID: 6672
		internal static int __PropertyOffset_bShowLODText;

		// Token: 0x04001A11 RID: 6673
		internal static int __PropertyOffset_MorphTargetPreviewItems;

		// Token: 0x04001A12 RID: 6674
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMorphTargetPreviewItem> _MorphTargetPreviewItems;
	}
}
