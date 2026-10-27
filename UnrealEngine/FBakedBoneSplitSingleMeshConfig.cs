using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000893 RID: 2195
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneSplitSingleMeshConfig")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FBakedBoneSplitSingleMeshConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007805 RID: 30725 RVA: 0x000ABDD3 File Offset: 0x000A9FD3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedBoneSplitSingleMeshConfig._ScriptStructPtr != 0) ? FBakedBoneSplitSingleMeshConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedBoneSplitSingleMeshConfig", ref FBakedBoneSplitSingleMeshConfig._ScriptStructPtr);
		}

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x06007806 RID: 30726 RVA: 0x000ABDF7 File Offset: 0x000A9FF7
		// (set) Token: 0x06007807 RID: 30727 RVA: 0x000ABE16 File Offset: 0x000AA016
		public TSoftObjectPtr<USkeletalMesh> MeshSoftPtr
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)FBakedBoneSplitSingleMeshConfig.__PropertyOffset_MeshSoftPtr, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FBakedBoneSplitSingleMeshConfig.__PropertyOffset_MeshSoftPtr, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x06007808 RID: 30728 RVA: 0x000ABE3C File Offset: 0x000AA03C
		// (set) Token: 0x06007809 RID: 30729 RVA: 0x000ABE7F File Offset: 0x000AA07F
		public TArray<TSoftObjectPtr<UMaterialInterface>> OverrideMaterialsSoftPtrArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UMaterialInterface>> result;
				if ((result = this._OverrideMaterialsSoftPtrArray) == null)
				{
					result = (this._OverrideMaterialsSoftPtrArray = new TArray<TSoftObjectPtr<UMaterialInterface>>(base.NativePtr + (IntPtr)FBakedBoneSplitSingleMeshConfig.__PropertyOffset_OverrideMaterialsSoftPtrArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OverrideMaterialsSoftPtrArray.CopyAssign(value);
			}
		}

		// Token: 0x0600780A RID: 30730 RVA: 0x000ABE8D File Offset: 0x000AA08D
		public FBakedBoneSplitSingleMeshConfig()
		{
		}

		// Token: 0x0600780B RID: 30731 RVA: 0x000ABE95 File Offset: 0x000AA095
		public FBakedBoneSplitSingleMeshConfig(TSoftObjectPtr<USkeletalMesh> MeshSoftPtr, TArray<TSoftObjectPtr<UMaterialInterface>> OverrideMaterialsSoftPtrArray)
		{
			this.MeshSoftPtr = MeshSoftPtr;
			this.OverrideMaterialsSoftPtrArray = OverrideMaterialsSoftPtrArray;
		}

		// Token: 0x0600780C RID: 30732 RVA: 0x000ABEAB File Offset: 0x000AA0AB
		protected override IntPtr GetUStructPtr()
		{
			return FBakedBoneSplitSingleMeshConfig.StaticStruct();
		}

		// Token: 0x0600780D RID: 30733 RVA: 0x000ABEB7 File Offset: 0x000AA0B7
		[NullableContext(2)]
		public FBakedBoneSplitSingleMeshConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600780E RID: 30734 RVA: 0x000ABEC1 File Offset: 0x000AA0C1
		public FBakedBoneSplitSingleMeshConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600780F RID: 30735 RVA: 0x000ABECC File Offset: 0x000AA0CC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedBoneSplitSingleMeshConfig(Pointer, false, true);
		}

		// Token: 0x06007810 RID: 30736 RVA: 0x000ABED6 File Offset: 0x000AA0D6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedBoneSplitSingleMeshConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040039A3 RID: 14755
		public const string __ObjectPath = "/Script/Engine.BakedBoneSplitSingleMeshConfig";

		// Token: 0x040039A4 RID: 14756
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040039A5 RID: 14757
		internal static int __PropertyOffset_MeshSoftPtr;

		// Token: 0x040039A6 RID: 14758
		internal static int __PropertyOffset_OverrideMaterialsSoftPtrArray;

		// Token: 0x040039A7 RID: 14759
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UMaterialInterface>> _OverrideMaterialsSoftPtrArray;
	}
}
