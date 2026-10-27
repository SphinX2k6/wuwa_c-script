using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000895 RID: 2197
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneSplitSingleMeshRuntimeConfig")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FBakedBoneSplitSingleMeshRuntimeConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600781A RID: 30746 RVA: 0x000ABFCE File Offset: 0x000AA1CE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedBoneSplitSingleMeshRuntimeConfig._ScriptStructPtr != 0) ? FBakedBoneSplitSingleMeshRuntimeConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedBoneSplitSingleMeshRuntimeConfig", ref FBakedBoneSplitSingleMeshRuntimeConfig._ScriptStructPtr);
		}

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x0600781B RID: 30747 RVA: 0x000ABFF2 File Offset: 0x000AA1F2
		// (set) Token: 0x0600781C RID: 30748 RVA: 0x000AC006 File Offset: 0x000AA206
		[Nullable(2)]
		public unsafe USkeletalMesh Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FBakedBoneSplitSingleMeshRuntimeConfig.__PropertyOffset_Mesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBakedBoneSplitSingleMeshRuntimeConfig.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x0600781D RID: 30749 RVA: 0x000AC01C File Offset: 0x000AA21C
		// (set) Token: 0x0600781E RID: 30750 RVA: 0x000AC05F File Offset: 0x000AA25F
		public TArray<UMaterialInterface> OverrideMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._OverrideMaterials) == null)
				{
					result = (this._OverrideMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)FBakedBoneSplitSingleMeshRuntimeConfig.__PropertyOffset_OverrideMaterials, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OverrideMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x0600781F RID: 30751 RVA: 0x000AC06D File Offset: 0x000AA26D
		// (set) Token: 0x06007820 RID: 30752 RVA: 0x000AC08C File Offset: 0x000AA28C
		public TSoftObjectPtr<USkeletalMesh> MeshSoftPtr
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)FBakedBoneSplitSingleMeshRuntimeConfig.__PropertyOffset_MeshSoftPtr, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FBakedBoneSplitSingleMeshRuntimeConfig.__PropertyOffset_MeshSoftPtr, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17001C5D RID: 7261
		// (get) Token: 0x06007821 RID: 30753 RVA: 0x000AC0B4 File Offset: 0x000AA2B4
		// (set) Token: 0x06007822 RID: 30754 RVA: 0x000AC0F7 File Offset: 0x000AA2F7
		public TArray<TSoftObjectPtr<UMaterialInterface>> OverrideMaterialsSoftPtrArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UMaterialInterface>> result;
				if ((result = this._OverrideMaterialsSoftPtrArray) == null)
				{
					result = (this._OverrideMaterialsSoftPtrArray = new TArray<TSoftObjectPtr<UMaterialInterface>>(base.NativePtr + (IntPtr)FBakedBoneSplitSingleMeshRuntimeConfig.__PropertyOffset_OverrideMaterialsSoftPtrArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OverrideMaterialsSoftPtrArray.CopyAssign(value);
			}
		}

		// Token: 0x06007823 RID: 30755 RVA: 0x000AC105 File Offset: 0x000AA305
		public FBakedBoneSplitSingleMeshRuntimeConfig()
		{
		}

		// Token: 0x06007824 RID: 30756 RVA: 0x000AC10D File Offset: 0x000AA30D
		public FBakedBoneSplitSingleMeshRuntimeConfig(USkeletalMesh Mesh, TArray<UMaterialInterface> OverrideMaterials, TSoftObjectPtr<USkeletalMesh> MeshSoftPtr, TArray<TSoftObjectPtr<UMaterialInterface>> OverrideMaterialsSoftPtrArray)
		{
			this.Mesh = Mesh;
			this.OverrideMaterials = OverrideMaterials;
			this.MeshSoftPtr = MeshSoftPtr;
			this.OverrideMaterialsSoftPtrArray = OverrideMaterialsSoftPtrArray;
		}

		// Token: 0x06007825 RID: 30757 RVA: 0x000AC132 File Offset: 0x000AA332
		protected override IntPtr GetUStructPtr()
		{
			return FBakedBoneSplitSingleMeshRuntimeConfig.StaticStruct();
		}

		// Token: 0x06007826 RID: 30758 RVA: 0x000AC13E File Offset: 0x000AA33E
		[NullableContext(2)]
		public FBakedBoneSplitSingleMeshRuntimeConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x000AC148 File Offset: 0x000AA348
		public FBakedBoneSplitSingleMeshRuntimeConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x000AC153 File Offset: 0x000AA353
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedBoneSplitSingleMeshRuntimeConfig(Pointer, false, true);
		}

		// Token: 0x06007829 RID: 30761 RVA: 0x000AC15D File Offset: 0x000AA35D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedBoneSplitSingleMeshRuntimeConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040039AE RID: 14766
		public const string __ObjectPath = "/Script/Engine.BakedBoneSplitSingleMeshRuntimeConfig";

		// Token: 0x040039AF RID: 14767
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040039B0 RID: 14768
		internal static int __PropertyOffset_Mesh;

		// Token: 0x040039B1 RID: 14769
		internal static int __PropertyOffset_OverrideMaterials;

		// Token: 0x040039B2 RID: 14770
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _OverrideMaterials;

		// Token: 0x040039B3 RID: 14771
		internal static int __PropertyOffset_MeshSoftPtr;

		// Token: 0x040039B4 RID: 14772
		internal static int __PropertyOffset_OverrideMaterialsSoftPtrArray;

		// Token: 0x040039B5 RID: 14773
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UMaterialInterface>> _OverrideMaterialsSoftPtrArray;
	}
}
