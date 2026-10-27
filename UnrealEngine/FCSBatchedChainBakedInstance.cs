using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001771 RID: 6001
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.CSBatchedChainBakedInstance")]
	[UnrealStructLayout(240, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FCSBatchedChainBakedInstance : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015931 RID: 88369 RVA: 0x001FBD7F File Offset: 0x001F9F7F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCSBatchedChainBakedInstance._ScriptStructPtr != 0) ? FCSBatchedChainBakedInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.CSBatchedChainBakedInstance", ref FCSBatchedChainBakedInstance._ScriptStructPtr);
		}

		// Token: 0x1700551D RID: 21789
		// (get) Token: 0x06015932 RID: 88370 RVA: 0x001FBDA3 File Offset: 0x001F9FA3
		// (set) Token: 0x06015933 RID: 88371 RVA: 0x001FBDB7 File Offset: 0x001F9FB7
		[Nullable(2)]
		public unsafe UStaticMesh SourceMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FCSBatchedChainBakedInstance.__PropertyOffset_SourceMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCSBatchedChainBakedInstance.__PropertyOffset_SourceMesh, value);
			}
		}

		// Token: 0x1700551E RID: 21790
		// (get) Token: 0x06015934 RID: 88372 RVA: 0x001FBDCC File Offset: 0x001F9FCC
		// (set) Token: 0x06015935 RID: 88373 RVA: 0x001FBDE0 File Offset: 0x001F9FE0
		[Nullable(2)]
		public unsafe UJacobiChainAsset SimulationProfile
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UJacobiChainAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FCSBatchedChainBakedInstance.__PropertyOffset_SimulationProfile);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCSBatchedChainBakedInstance.__PropertyOffset_SimulationProfile, value);
			}
		}

		// Token: 0x1700551F RID: 21791
		// (get) Token: 0x06015936 RID: 88374 RVA: 0x001FBDF5 File Offset: 0x001F9FF5
		// (set) Token: 0x06015937 RID: 88375 RVA: 0x001FBE09 File Offset: 0x001FA009
		public unsafe FTransform LocalTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCSBatchedChainBakedInstance.__PropertyOffset_LocalTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCSBatchedChainBakedInstance.__PropertyOffset_LocalTransform) = value;
			}
		}

		// Token: 0x17005520 RID: 21792
		// (get) Token: 0x06015938 RID: 88376 RVA: 0x001FBE20 File Offset: 0x001FA020
		// (set) Token: 0x06015939 RID: 88377 RVA: 0x001FBE63 File Offset: 0x001FA063
		public TArray<UMaterialInterface> Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)FCSBatchedChainBakedInstance.__PropertyOffset_Materials, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x17005521 RID: 21793
		// (get) Token: 0x0601593A RID: 88378 RVA: 0x001FBE74 File Offset: 0x001FA074
		// (set) Token: 0x0601593B RID: 88379 RVA: 0x001FBEB7 File Offset: 0x001FA0B7
		public TArray<float> CustomPrimitiveData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CustomPrimitiveData) == null)
				{
					result = (this._CustomPrimitiveData = new TArray<float>(base.NativePtr + (IntPtr)FCSBatchedChainBakedInstance.__PropertyOffset_CustomPrimitiveData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomPrimitiveData.CopyAssign(value);
			}
		}

		// Token: 0x17005522 RID: 21794
		// (get) Token: 0x0601593C RID: 88380 RVA: 0x001FBEC5 File Offset: 0x001FA0C5
		// (set) Token: 0x0601593D RID: 88381 RVA: 0x001FBED5 File Offset: 0x001FA0D5
		public unsafe bool bCastShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCSBatchedChainBakedInstance.__PropertyOffset_bCastShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCSBatchedChainBakedInstance.__PropertyOffset_bCastShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005523 RID: 21795
		// (get) Token: 0x0601593E RID: 88382 RVA: 0x001FBEE6 File Offset: 0x001FA0E6
		// (set) Token: 0x0601593F RID: 88383 RVA: 0x001FBEF6 File Offset: 0x001FA0F6
		public unsafe bool bCastDynamicShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCSBatchedChainBakedInstance.__PropertyOffset_bCastDynamicShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCSBatchedChainBakedInstance.__PropertyOffset_bCastDynamicShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005524 RID: 21796
		// (get) Token: 0x06015940 RID: 88384 RVA: 0x001FBF07 File Offset: 0x001FA107
		// (set) Token: 0x06015941 RID: 88385 RVA: 0x001FBF17 File Offset: 0x001FA117
		public unsafe bool bOriginalRenderStateCaptured
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCSBatchedChainBakedInstance.__PropertyOffset_bOriginalRenderStateCaptured) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCSBatchedChainBakedInstance.__PropertyOffset_bOriginalRenderStateCaptured) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005525 RID: 21797
		// (get) Token: 0x06015942 RID: 88386 RVA: 0x001FBF28 File Offset: 0x001FA128
		// (set) Token: 0x06015943 RID: 88387 RVA: 0x001FBF38 File Offset: 0x001FA138
		public unsafe bool bOriginalWasVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCSBatchedChainBakedInstance.__PropertyOffset_bOriginalWasVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCSBatchedChainBakedInstance.__PropertyOffset_bOriginalWasVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005526 RID: 21798
		// (get) Token: 0x06015944 RID: 88388 RVA: 0x001FBF49 File Offset: 0x001FA149
		// (set) Token: 0x06015945 RID: 88389 RVA: 0x001FBF59 File Offset: 0x001FA159
		public unsafe bool bOriginalWasHiddenInGame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCSBatchedChainBakedInstance.__PropertyOffset_bOriginalWasHiddenInGame) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCSBatchedChainBakedInstance.__PropertyOffset_bOriginalWasHiddenInGame) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005527 RID: 21799
		// (get) Token: 0x06015946 RID: 88390 RVA: 0x001FBF6A File Offset: 0x001FA16A
		// (set) Token: 0x06015947 RID: 88391 RVA: 0x001FBF7E File Offset: 0x001FA17E
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionEnabled> OriginalCollisionEnabled
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FCSBatchedChainBakedInstance.__PropertyOffset_OriginalCollisionEnabled);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FCSBatchedChainBakedInstance.__PropertyOffset_OriginalCollisionEnabled) = value;
			}
		}

		// Token: 0x17005528 RID: 21800
		// (get) Token: 0x06015948 RID: 88392 RVA: 0x001FBF93 File Offset: 0x001FA193
		// (set) Token: 0x06015949 RID: 88393 RVA: 0x001FBFA3 File Offset: 0x001FA1A3
		public unsafe bool bOriginalGeneratedOverlapEvents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCSBatchedChainBakedInstance.__PropertyOffset_bOriginalGeneratedOverlapEvents) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCSBatchedChainBakedInstance.__PropertyOffset_bOriginalGeneratedOverlapEvents) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601594A RID: 88394 RVA: 0x001FBFB4 File Offset: 0x001FA1B4
		public FCSBatchedChainBakedInstance()
		{
		}

		// Token: 0x0601594B RID: 88395 RVA: 0x001FBFBC File Offset: 0x001FA1BC
		public FCSBatchedChainBakedInstance(UStaticMeshComponent SourceComponent, UStaticMeshComponent OriginalSourceComponent, bool bSourceActorStateCaptured, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AStaticMeshActor> SourceActorClass, FName SourceLevelPackageName, FName SourceActorName, string SourceActorLabel, FName SourceActorFolderPath, TArray<FName> SourceActorTags, TArray<FName> SourceActorLayers, bool bSourceActorHiddenInGame, [Nullable(0)] TEnumAsByte<EComponentMobility> SourceComponentMobility, UStaticMesh SourceMesh, UJacobiChainAsset SimulationProfile, FTransform LocalTransform, TArray<UMaterialInterface> Materials, TArray<float> CustomPrimitiveData, bool bCastShadow, bool bCastDynamicShadow, bool bOriginalRenderStateCaptured, bool bOriginalWasVisible, bool bOriginalWasHiddenInGame, [Nullable(0)] TEnumAsByte<ECollisionEnabled> OriginalCollisionEnabled, bool bOriginalGeneratedOverlapEvents)
		{
			this.SourceMesh = SourceMesh;
			this.SimulationProfile = SimulationProfile;
			this.LocalTransform = LocalTransform;
			this.Materials = Materials;
			this.CustomPrimitiveData = CustomPrimitiveData;
			this.bCastShadow = bCastShadow;
			this.bCastDynamicShadow = bCastDynamicShadow;
			this.bOriginalRenderStateCaptured = bOriginalRenderStateCaptured;
			this.bOriginalWasVisible = bOriginalWasVisible;
			this.bOriginalWasHiddenInGame = bOriginalWasHiddenInGame;
			this.OriginalCollisionEnabled = OriginalCollisionEnabled;
			this.bOriginalGeneratedOverlapEvents = bOriginalGeneratedOverlapEvents;
		}

		// Token: 0x0601594C RID: 88396 RVA: 0x001FC02F File Offset: 0x001FA22F
		protected override IntPtr GetUStructPtr()
		{
			return FCSBatchedChainBakedInstance.StaticStruct();
		}

		// Token: 0x0601594D RID: 88397 RVA: 0x001FC03B File Offset: 0x001FA23B
		[NullableContext(2)]
		public FCSBatchedChainBakedInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601594E RID: 88398 RVA: 0x001FC045 File Offset: 0x001FA245
		public FCSBatchedChainBakedInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601594F RID: 88399 RVA: 0x001FC050 File Offset: 0x001FA250
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCSBatchedChainBakedInstance(Pointer, false, true);
		}

		// Token: 0x06015950 RID: 88400 RVA: 0x001FC05A File Offset: 0x001FA25A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCSBatchedChainBakedInstance(Pointer, MemoryOwner);
		}

		// Token: 0x0400BC55 RID: 48213
		public const string __ObjectPath = "/Script/KuroComputeShader.CSBatchedChainBakedInstance";

		// Token: 0x0400BC56 RID: 48214
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BC57 RID: 48215
		internal static int __PropertyOffset_SourceMesh;

		// Token: 0x0400BC58 RID: 48216
		internal static int __PropertyOffset_SimulationProfile;

		// Token: 0x0400BC59 RID: 48217
		internal static int __PropertyOffset_LocalTransform;

		// Token: 0x0400BC5A RID: 48218
		internal static int __PropertyOffset_Materials;

		// Token: 0x0400BC5B RID: 48219
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _Materials;

		// Token: 0x0400BC5C RID: 48220
		internal static int __PropertyOffset_CustomPrimitiveData;

		// Token: 0x0400BC5D RID: 48221
		[Nullable(2)]
		private TArray<float> _CustomPrimitiveData;

		// Token: 0x0400BC5E RID: 48222
		internal static int __PropertyOffset_bCastShadow;

		// Token: 0x0400BC5F RID: 48223
		internal static int __PropertyOffset_bCastDynamicShadow;

		// Token: 0x0400BC60 RID: 48224
		internal static int __PropertyOffset_bOriginalRenderStateCaptured;

		// Token: 0x0400BC61 RID: 48225
		internal static int __PropertyOffset_bOriginalWasVisible;

		// Token: 0x0400BC62 RID: 48226
		internal static int __PropertyOffset_bOriginalWasHiddenInGame;

		// Token: 0x0400BC63 RID: 48227
		internal static int __PropertyOffset_OriginalCollisionEnabled;

		// Token: 0x0400BC64 RID: 48228
		internal static int __PropertyOffset_bOriginalGeneratedOverlapEvents;
	}
}
