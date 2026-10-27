using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008FC RID: 2300
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BuildPromotionOpenAssetSettings")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FBuildPromotionOpenAssetSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007E40 RID: 32320 RVA: 0x000B5167 File Offset: 0x000B3367
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBuildPromotionOpenAssetSettings._ScriptStructPtr != 0) ? FBuildPromotionOpenAssetSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BuildPromotionOpenAssetSettings", ref FBuildPromotionOpenAssetSettings._ScriptStructPtr);
		}

		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x06007E41 RID: 32321 RVA: 0x000B518C File Offset: 0x000B338C
		// (set) Token: 0x06007E42 RID: 32322 RVA: 0x000B51CF File Offset: 0x000B33CF
		public FFilePath BlueprintAsset
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._BlueprintAsset) == null)
				{
					result = (this._BlueprintAsset = new FFilePath(base.NativePtr + (IntPtr)FBuildPromotionOpenAssetSettings.__PropertyOffset_BlueprintAsset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionOpenAssetSettings.__PropertyOffset_BlueprintAsset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x06007E43 RID: 32323 RVA: 0x000B51F0 File Offset: 0x000B33F0
		// (set) Token: 0x06007E44 RID: 32324 RVA: 0x000B5233 File Offset: 0x000B3433
		public FFilePath MaterialAsset
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._MaterialAsset) == null)
				{
					result = (this._MaterialAsset = new FFilePath(base.NativePtr + (IntPtr)FBuildPromotionOpenAssetSettings.__PropertyOffset_MaterialAsset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionOpenAssetSettings.__PropertyOffset_MaterialAsset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x06007E45 RID: 32325 RVA: 0x000B5254 File Offset: 0x000B3454
		// (set) Token: 0x06007E46 RID: 32326 RVA: 0x000B5297 File Offset: 0x000B3497
		public FFilePath ParticleSystemAsset
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._ParticleSystemAsset) == null)
				{
					result = (this._ParticleSystemAsset = new FFilePath(base.NativePtr + (IntPtr)FBuildPromotionOpenAssetSettings.__PropertyOffset_ParticleSystemAsset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionOpenAssetSettings.__PropertyOffset_ParticleSystemAsset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x06007E47 RID: 32327 RVA: 0x000B52B8 File Offset: 0x000B34B8
		// (set) Token: 0x06007E48 RID: 32328 RVA: 0x000B52FB File Offset: 0x000B34FB
		public FFilePath SkeletalMeshAsset
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._SkeletalMeshAsset) == null)
				{
					result = (this._SkeletalMeshAsset = new FFilePath(base.NativePtr + (IntPtr)FBuildPromotionOpenAssetSettings.__PropertyOffset_SkeletalMeshAsset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionOpenAssetSettings.__PropertyOffset_SkeletalMeshAsset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x06007E49 RID: 32329 RVA: 0x000B531C File Offset: 0x000B351C
		// (set) Token: 0x06007E4A RID: 32330 RVA: 0x000B535F File Offset: 0x000B355F
		public FFilePath StaticMeshAsset
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._StaticMeshAsset) == null)
				{
					result = (this._StaticMeshAsset = new FFilePath(base.NativePtr + (IntPtr)FBuildPromotionOpenAssetSettings.__PropertyOffset_StaticMeshAsset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionOpenAssetSettings.__PropertyOffset_StaticMeshAsset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x06007E4B RID: 32331 RVA: 0x000B5380 File Offset: 0x000B3580
		// (set) Token: 0x06007E4C RID: 32332 RVA: 0x000B53C3 File Offset: 0x000B35C3
		public FFilePath TextureAsset
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._TextureAsset) == null)
				{
					result = (this._TextureAsset = new FFilePath(base.NativePtr + (IntPtr)FBuildPromotionOpenAssetSettings.__PropertyOffset_TextureAsset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionOpenAssetSettings.__PropertyOffset_TextureAsset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06007E4D RID: 32333 RVA: 0x000B53E4 File Offset: 0x000B35E4
		public FBuildPromotionOpenAssetSettings()
		{
		}

		// Token: 0x06007E4E RID: 32334 RVA: 0x000B53EC File Offset: 0x000B35EC
		public FBuildPromotionOpenAssetSettings(FFilePath BlueprintAsset, FFilePath MaterialAsset, FFilePath ParticleSystemAsset, FFilePath SkeletalMeshAsset, FFilePath StaticMeshAsset, FFilePath TextureAsset)
		{
			this.BlueprintAsset = BlueprintAsset;
			this.MaterialAsset = MaterialAsset;
			this.ParticleSystemAsset = ParticleSystemAsset;
			this.SkeletalMeshAsset = SkeletalMeshAsset;
			this.StaticMeshAsset = StaticMeshAsset;
			this.TextureAsset = TextureAsset;
		}

		// Token: 0x06007E4F RID: 32335 RVA: 0x000B5421 File Offset: 0x000B3621
		protected override IntPtr GetUStructPtr()
		{
			return FBuildPromotionOpenAssetSettings.StaticStruct();
		}

		// Token: 0x06007E50 RID: 32336 RVA: 0x000B542D File Offset: 0x000B362D
		[NullableContext(2)]
		public FBuildPromotionOpenAssetSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007E51 RID: 32337 RVA: 0x000B5437 File Offset: 0x000B3637
		public FBuildPromotionOpenAssetSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007E52 RID: 32338 RVA: 0x000B5442 File Offset: 0x000B3642
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBuildPromotionOpenAssetSettings(Pointer, false, true);
		}

		// Token: 0x06007E53 RID: 32339 RVA: 0x000B544C File Offset: 0x000B364C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBuildPromotionOpenAssetSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04003C91 RID: 15505
		public const string __ObjectPath = "/Script/Engine.BuildPromotionOpenAssetSettings";

		// Token: 0x04003C92 RID: 15506
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003C93 RID: 15507
		internal static int __PropertyOffset_BlueprintAsset;

		// Token: 0x04003C94 RID: 15508
		[Nullable(2)]
		private FFilePath _BlueprintAsset;

		// Token: 0x04003C95 RID: 15509
		internal static int __PropertyOffset_MaterialAsset;

		// Token: 0x04003C96 RID: 15510
		[Nullable(2)]
		private FFilePath _MaterialAsset;

		// Token: 0x04003C97 RID: 15511
		internal static int __PropertyOffset_ParticleSystemAsset;

		// Token: 0x04003C98 RID: 15512
		[Nullable(2)]
		private FFilePath _ParticleSystemAsset;

		// Token: 0x04003C99 RID: 15513
		internal static int __PropertyOffset_SkeletalMeshAsset;

		// Token: 0x04003C9A RID: 15514
		[Nullable(2)]
		private FFilePath _SkeletalMeshAsset;

		// Token: 0x04003C9B RID: 15515
		internal static int __PropertyOffset_StaticMeshAsset;

		// Token: 0x04003C9C RID: 15516
		[Nullable(2)]
		private FFilePath _StaticMeshAsset;

		// Token: 0x04003C9D RID: 15517
		internal static int __PropertyOffset_TextureAsset;

		// Token: 0x04003C9E RID: 15518
		[Nullable(2)]
		private FFilePath _TextureAsset;
	}
}
