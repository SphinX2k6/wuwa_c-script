using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010F6 RID: 4342
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkeletalMeshClothBuildParams")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FSkeletalMeshClothBuildParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F9D4 RID: 63956 RVA: 0x001716D0 File Offset: 0x0016F8D0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkeletalMeshClothBuildParams._ScriptStructPtr != 0) ? FSkeletalMeshClothBuildParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkeletalMeshClothBuildParams", ref FSkeletalMeshClothBuildParams._ScriptStructPtr);
		}

		// Token: 0x17003CE8 RID: 15592
		// (get) Token: 0x0600F9D5 RID: 63957 RVA: 0x001716F4 File Offset: 0x0016F8F4
		// (set) Token: 0x0600F9D6 RID: 63958 RVA: 0x00171708 File Offset: 0x0016F908
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UClothingAssetBase> TargetAsset
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshClothBuildParams.__PropertyOffset_TargetAsset);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshClothBuildParams.__PropertyOffset_TargetAsset) = value;
			}
		}

		// Token: 0x17003CE9 RID: 15593
		// (get) Token: 0x0600F9D7 RID: 63959 RVA: 0x0017171D File Offset: 0x0016F91D
		// (set) Token: 0x0600F9D8 RID: 63960 RVA: 0x0017172D File Offset: 0x0016F92D
		public unsafe int TargetLod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshClothBuildParams.__PropertyOffset_TargetLod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshClothBuildParams.__PropertyOffset_TargetLod) = value;
			}
		}

		// Token: 0x17003CEA RID: 15594
		// (get) Token: 0x0600F9D9 RID: 63961 RVA: 0x0017173E File Offset: 0x0016F93E
		// (set) Token: 0x0600F9DA RID: 63962 RVA: 0x0017174E File Offset: 0x0016F94E
		public unsafe bool bRemapParameters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshClothBuildParams.__PropertyOffset_bRemapParameters) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshClothBuildParams.__PropertyOffset_bRemapParameters) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CEB RID: 15595
		// (get) Token: 0x0600F9DB RID: 63963 RVA: 0x0017175F File Offset: 0x0016F95F
		// (set) Token: 0x0600F9DC RID: 63964 RVA: 0x00171773 File Offset: 0x0016F973
		public unsafe string AssetName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSkeletalMeshClothBuildParams.__PropertyOffset_AssetName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSkeletalMeshClothBuildParams.__PropertyOffset_AssetName)), value);
			}
		}

		// Token: 0x17003CEC RID: 15596
		// (get) Token: 0x0600F9DD RID: 63965 RVA: 0x00171788 File Offset: 0x0016F988
		// (set) Token: 0x0600F9DE RID: 63966 RVA: 0x00171798 File Offset: 0x0016F998
		public unsafe int LodIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshClothBuildParams.__PropertyOffset_LodIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshClothBuildParams.__PropertyOffset_LodIndex) = value;
			}
		}

		// Token: 0x17003CED RID: 15597
		// (get) Token: 0x0600F9DF RID: 63967 RVA: 0x001717A9 File Offset: 0x0016F9A9
		// (set) Token: 0x0600F9E0 RID: 63968 RVA: 0x001717B9 File Offset: 0x0016F9B9
		public unsafe int SourceSection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshClothBuildParams.__PropertyOffset_SourceSection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshClothBuildParams.__PropertyOffset_SourceSection) = value;
			}
		}

		// Token: 0x17003CEE RID: 15598
		// (get) Token: 0x0600F9E1 RID: 63969 RVA: 0x001717CA File Offset: 0x0016F9CA
		// (set) Token: 0x0600F9E2 RID: 63970 RVA: 0x001717DA File Offset: 0x0016F9DA
		public unsafe bool bRemoveFromMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshClothBuildParams.__PropertyOffset_bRemoveFromMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshClothBuildParams.__PropertyOffset_bRemoveFromMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CEF RID: 15599
		// (get) Token: 0x0600F9E3 RID: 63971 RVA: 0x001717EB File Offset: 0x0016F9EB
		// (set) Token: 0x0600F9E4 RID: 63972 RVA: 0x0017180A File Offset: 0x0016FA0A
		public TSoftObjectPtr<UPhysicsAsset> PhysicsAsset
		{
			get
			{
				return new TSoftObjectPtr<UPhysicsAsset>(base.NativePtr + (IntPtr)FSkeletalMeshClothBuildParams.__PropertyOffset_PhysicsAsset, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FSkeletalMeshClothBuildParams.__PropertyOffset_PhysicsAsset, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0600F9E5 RID: 63973 RVA: 0x0017182F File Offset: 0x0016FA2F
		public FSkeletalMeshClothBuildParams()
		{
		}

		// Token: 0x0600F9E6 RID: 63974 RVA: 0x00171838 File Offset: 0x0016FA38
		public FSkeletalMeshClothBuildParams([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UClothingAssetBase> TargetAsset, int TargetLod, bool bRemapParameters, string AssetName, int LodIndex, int SourceSection, bool bRemoveFromMesh, TSoftObjectPtr<UPhysicsAsset> PhysicsAsset)
		{
			this.TargetAsset = TargetAsset;
			this.TargetLod = TargetLod;
			this.bRemapParameters = bRemapParameters;
			this.AssetName = AssetName;
			this.LodIndex = LodIndex;
			this.SourceSection = SourceSection;
			this.bRemoveFromMesh = bRemoveFromMesh;
			this.PhysicsAsset = PhysicsAsset;
		}

		// Token: 0x0600F9E7 RID: 63975 RVA: 0x00171888 File Offset: 0x0016FA88
		protected override IntPtr GetUStructPtr()
		{
			return FSkeletalMeshClothBuildParams.StaticStruct();
		}

		// Token: 0x0600F9E8 RID: 63976 RVA: 0x00171894 File Offset: 0x0016FA94
		[NullableContext(2)]
		public FSkeletalMeshClothBuildParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F9E9 RID: 63977 RVA: 0x0017189E File Offset: 0x0016FA9E
		public FSkeletalMeshClothBuildParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F9EA RID: 63978 RVA: 0x001718A9 File Offset: 0x0016FAA9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkeletalMeshClothBuildParams(Pointer, false, true);
		}

		// Token: 0x0600F9EB RID: 63979 RVA: 0x001718B3 File Offset: 0x0016FAB3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkeletalMeshClothBuildParams(Pointer, MemoryOwner);
		}

		// Token: 0x040086F0 RID: 34544
		public const string __ObjectPath = "/Script/Engine.SkeletalMeshClothBuildParams";

		// Token: 0x040086F1 RID: 34545
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040086F2 RID: 34546
		internal static int __PropertyOffset_TargetAsset;

		// Token: 0x040086F3 RID: 34547
		internal static int __PropertyOffset_TargetLod;

		// Token: 0x040086F4 RID: 34548
		internal static int __PropertyOffset_bRemapParameters;

		// Token: 0x040086F5 RID: 34549
		internal static int __PropertyOffset_AssetName;

		// Token: 0x040086F6 RID: 34550
		internal static int __PropertyOffset_LodIndex;

		// Token: 0x040086F7 RID: 34551
		internal static int __PropertyOffset_SourceSection;

		// Token: 0x040086F8 RID: 34552
		internal static int __PropertyOffset_bRemoveFromMesh;

		// Token: 0x040086F9 RID: 34553
		internal static int __PropertyOffset_PhysicsAsset;
	}
}
