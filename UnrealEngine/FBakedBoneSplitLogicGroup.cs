using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200088F RID: 2191
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneSplitLogicGroup")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FBakedBoneSplitLogicGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060077C4 RID: 30660 RVA: 0x000AB896 File Offset: 0x000A9A96
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedBoneSplitLogicGroup._ScriptStructPtr != 0) ? FBakedBoneSplitLogicGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedBoneSplitLogicGroup", ref FBakedBoneSplitLogicGroup._ScriptStructPtr);
		}

		// Token: 0x17001C44 RID: 7236
		// (get) Token: 0x060077C5 RID: 30661 RVA: 0x000AB8BA File Offset: 0x000A9ABA
		// (set) Token: 0x060077C6 RID: 30662 RVA: 0x000AB8CE File Offset: 0x000A9ACE
		[Nullable(2)]
		public unsafe UBakedBoneSplitMeshDA MeshDA
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBakedBoneSplitMeshDA>(base.NativePtr / (IntPtr)sizeof(void*) + FBakedBoneSplitLogicGroup.__PropertyOffset_MeshDA);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBakedBoneSplitLogicGroup.__PropertyOffset_MeshDA, value);
			}
		}

		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x060077C7 RID: 30663 RVA: 0x000AB8E4 File Offset: 0x000A9AE4
		// (set) Token: 0x060077C8 RID: 30664 RVA: 0x000AB927 File Offset: 0x000A9B27
		public TArray<FBakedBoneSplitSingleMeshRuntimeConfig> Meshes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedBoneSplitSingleMeshRuntimeConfig> result;
				if ((result = this._Meshes) == null)
				{
					result = (this._Meshes = new TArray<FBakedBoneSplitSingleMeshRuntimeConfig>(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroup.__PropertyOffset_Meshes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Meshes.CopyAssign(value);
			}
		}

		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x060077C9 RID: 30665 RVA: 0x000AB935 File Offset: 0x000A9B35
		// (set) Token: 0x060077CA RID: 30666 RVA: 0x000AB949 File Offset: 0x000A9B49
		public unsafe FBoxSphereBounds InstanceBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroup.__PropertyOffset_InstanceBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroup.__PropertyOffset_InstanceBounds) = value;
			}
		}

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x060077CB RID: 30667 RVA: 0x000AB95E File Offset: 0x000A9B5E
		// (set) Token: 0x060077CC RID: 30668 RVA: 0x000AB96E File Offset: 0x000A9B6E
		public unsafe int AnimTextureGroupId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroup.__PropertyOffset_AnimTextureGroupId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroup.__PropertyOffset_AnimTextureGroupId) = value;
			}
		}

		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x060077CD RID: 30669 RVA: 0x000AB97F File Offset: 0x000A9B7F
		// (set) Token: 0x060077CE RID: 30670 RVA: 0x000AB98F File Offset: 0x000A9B8F
		public unsafe bool RenderExtraMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroup.__PropertyOffset_RenderExtraMaterial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroup.__PropertyOffset_RenderExtraMaterial) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x060077CF RID: 30671 RVA: 0x000AB9A0 File Offset: 0x000A9BA0
		// (set) Token: 0x060077D0 RID: 30672 RVA: 0x000AB9E3 File Offset: 0x000A9BE3
		public TArray<int> MeshRenderGroup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._MeshRenderGroup) == null)
				{
					result = (this._MeshRenderGroup = new TArray<int>(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroup.__PropertyOffset_MeshRenderGroup, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MeshRenderGroup.CopyAssign(value);
			}
		}

		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x060077D1 RID: 30673 RVA: 0x000AB9F1 File Offset: 0x000A9BF1
		// (set) Token: 0x060077D2 RID: 30674 RVA: 0x000ABA01 File Offset: 0x000A9C01
		public unsafe bool bCanEditMeshRenderGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroup.__PropertyOffset_bCanEditMeshRenderGroup) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroup.__PropertyOffset_bCanEditMeshRenderGroup) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x060077D3 RID: 30675 RVA: 0x000ABA12 File Offset: 0x000A9C12
		// (set) Token: 0x060077D4 RID: 30676 RVA: 0x000ABA22 File Offset: 0x000A9C22
		public unsafe EBakedBoneSplitResourceLifetimeMode ResourceLifetimeMode
		{
			get
			{
				return (EBakedBoneSplitResourceLifetimeMode)(*(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroup.__PropertyOffset_ResourceLifetimeMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroup.__PropertyOffset_ResourceLifetimeMode) = (byte)value;
			}
		}

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x060077D5 RID: 30677 RVA: 0x000ABA33 File Offset: 0x000A9C33
		// (set) Token: 0x060077D6 RID: 30678 RVA: 0x000ABA43 File Offset: 0x000A9C43
		public unsafe EBakedBoneSplitResourceLoadMode ResourceLoadMode
		{
			get
			{
				return (EBakedBoneSplitResourceLoadMode)(*(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroup.__PropertyOffset_ResourceLoadMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroup.__PropertyOffset_ResourceLoadMode) = (byte)value;
			}
		}

		// Token: 0x060077D7 RID: 30679 RVA: 0x000ABA54 File Offset: 0x000A9C54
		public FBakedBoneSplitLogicGroup()
		{
		}

		// Token: 0x060077D8 RID: 30680 RVA: 0x000ABA5C File Offset: 0x000A9C5C
		public FBakedBoneSplitLogicGroup(UBakedBoneSplitMeshDA MeshDA, TArray<FBakedBoneSplitSingleMeshRuntimeConfig> Meshes, FBoxSphereBounds InstanceBounds, int AnimTextureGroupId, bool RenderExtraMaterial, TArray<int> MeshRenderGroup, bool bCanEditMeshRenderGroup, EBakedBoneSplitResourceLifetimeMode ResourceLifetimeMode, EBakedBoneSplitResourceLoadMode ResourceLoadMode)
		{
			this.MeshDA = MeshDA;
			this.Meshes = Meshes;
			this.InstanceBounds = InstanceBounds;
			this.AnimTextureGroupId = AnimTextureGroupId;
			this.RenderExtraMaterial = RenderExtraMaterial;
			this.MeshRenderGroup = MeshRenderGroup;
			this.bCanEditMeshRenderGroup = bCanEditMeshRenderGroup;
			this.ResourceLifetimeMode = ResourceLifetimeMode;
			this.ResourceLoadMode = ResourceLoadMode;
		}

		// Token: 0x060077D9 RID: 30681 RVA: 0x000ABAB4 File Offset: 0x000A9CB4
		protected override IntPtr GetUStructPtr()
		{
			return FBakedBoneSplitLogicGroup.StaticStruct();
		}

		// Token: 0x060077DA RID: 30682 RVA: 0x000ABAC0 File Offset: 0x000A9CC0
		[NullableContext(2)]
		public FBakedBoneSplitLogicGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060077DB RID: 30683 RVA: 0x000ABACA File Offset: 0x000A9CCA
		public FBakedBoneSplitLogicGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060077DC RID: 30684 RVA: 0x000ABAD5 File Offset: 0x000A9CD5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedBoneSplitLogicGroup(Pointer, false, true);
		}

		// Token: 0x060077DD RID: 30685 RVA: 0x000ABADF File Offset: 0x000A9CDF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedBoneSplitLogicGroup(Pointer, MemoryOwner);
		}

		// Token: 0x04003985 RID: 14725
		public const string __ObjectPath = "/Script/Engine.BakedBoneSplitLogicGroup";

		// Token: 0x04003986 RID: 14726
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003987 RID: 14727
		internal static int __PropertyOffset_MeshDA;

		// Token: 0x04003988 RID: 14728
		internal static int __PropertyOffset_Meshes;

		// Token: 0x04003989 RID: 14729
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedBoneSplitSingleMeshRuntimeConfig> _Meshes;

		// Token: 0x0400398A RID: 14730
		internal static int __PropertyOffset_InstanceBounds;

		// Token: 0x0400398B RID: 14731
		internal static int __PropertyOffset_AnimTextureGroupId;

		// Token: 0x0400398C RID: 14732
		internal static int __PropertyOffset_RenderExtraMaterial;

		// Token: 0x0400398D RID: 14733
		internal static int __PropertyOffset_MeshRenderGroup;

		// Token: 0x0400398E RID: 14734
		[Nullable(2)]
		private TArray<int> _MeshRenderGroup;

		// Token: 0x0400398F RID: 14735
		internal static int __PropertyOffset_bCanEditMeshRenderGroup;

		// Token: 0x04003990 RID: 14736
		internal static int __PropertyOffset_ResourceLifetimeMode;

		// Token: 0x04003991 RID: 14737
		internal static int __PropertyOffset_ResourceLoadMode;
	}
}
