using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017B2 RID: 6066
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSJacobiClothBakedRenderSource")]
	[UnrealStructLayout(336, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 336)]
	public class FKuroCSJacobiClothBakedRenderSource : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016102 RID: 90370 RVA: 0x002052A0 File Offset: 0x002034A0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSJacobiClothBakedRenderSource._ScriptStructPtr != 0) ? FKuroCSJacobiClothBakedRenderSource._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSJacobiClothBakedRenderSource", ref FKuroCSJacobiClothBakedRenderSource._ScriptStructPtr);
		}

		// Token: 0x17005800 RID: 22528
		// (get) Token: 0x06016103 RID: 90371 RVA: 0x002052C4 File Offset: 0x002034C4
		// (set) Token: 0x06016104 RID: 90372 RVA: 0x002052E3 File Offset: 0x002034E3
		public TSoftObjectPtr<AStaticMeshActor> SourceActor
		{
			get
			{
				return new TSoftObjectPtr<AStaticMeshActor>(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_SourceActor, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_SourceActor, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005801 RID: 22529
		// (get) Token: 0x06016105 RID: 90373 RVA: 0x00205308 File Offset: 0x00203508
		// (set) Token: 0x06016106 RID: 90374 RVA: 0x00205327 File Offset: 0x00203527
		public TSoftObjectPtr<UStaticMeshComponent> SourceComponent
		{
			get
			{
				return new TSoftObjectPtr<UStaticMeshComponent>(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_SourceComponent, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_SourceComponent, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005802 RID: 22530
		// (get) Token: 0x06016107 RID: 90375 RVA: 0x0020534C File Offset: 0x0020354C
		// (set) Token: 0x06016108 RID: 90376 RVA: 0x0020535C File Offset: 0x0020355C
		public unsafe bool bManagerOwnedSourceComponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_bManagerOwnedSourceComponent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_bManagerOwnedSourceComponent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005803 RID: 22531
		// (get) Token: 0x06016109 RID: 90377 RVA: 0x0020536D File Offset: 0x0020356D
		// (set) Token: 0x0601610A RID: 90378 RVA: 0x0020537D File Offset: 0x0020357D
		public unsafe bool bSourceOwnershipDetached
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_bSourceOwnershipDetached) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_bSourceOwnershipDetached) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005804 RID: 22532
		// (get) Token: 0x0601610B RID: 90379 RVA: 0x0020538E File Offset: 0x0020358E
		// (set) Token: 0x0601610C RID: 90380 RVA: 0x0020539E File Offset: 0x0020359E
		public unsafe int ClothInstanceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_ClothInstanceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_ClothInstanceIndex) = value;
			}
		}

		// Token: 0x17005805 RID: 22533
		// (get) Token: 0x0601610D RID: 90381 RVA: 0x002053AF File Offset: 0x002035AF
		// (set) Token: 0x0601610E RID: 90382 RVA: 0x002053C3 File Offset: 0x002035C3
		[Nullable(2)]
		public unsafe UStaticMesh SourceMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_SourceMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_SourceMesh, value);
			}
		}

		// Token: 0x17005806 RID: 22534
		// (get) Token: 0x0601610F RID: 90383 RVA: 0x002053D8 File Offset: 0x002035D8
		// (set) Token: 0x06016110 RID: 90384 RVA: 0x002053EC File Offset: 0x002035EC
		public unsafe FTransform LocalTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_LocalTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_LocalTransform) = value;
			}
		}

		// Token: 0x17005807 RID: 22535
		// (get) Token: 0x06016111 RID: 90385 RVA: 0x00205404 File Offset: 0x00203604
		// (set) Token: 0x06016112 RID: 90386 RVA: 0x00205447 File Offset: 0x00203647
		public TArray<UMaterialInterface> Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_Materials, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x17005808 RID: 22536
		// (get) Token: 0x06016113 RID: 90387 RVA: 0x00205458 File Offset: 0x00203658
		// (set) Token: 0x06016114 RID: 90388 RVA: 0x0020549B File Offset: 0x0020369B
		public TArray<float> CustomPrimitiveData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CustomPrimitiveData) == null)
				{
					result = (this._CustomPrimitiveData = new TArray<float>(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_CustomPrimitiveData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomPrimitiveData.CopyAssign(value);
			}
		}

		// Token: 0x17005809 RID: 22537
		// (get) Token: 0x06016115 RID: 90389 RVA: 0x002054A9 File Offset: 0x002036A9
		// (set) Token: 0x06016116 RID: 90390 RVA: 0x002054B9 File Offset: 0x002036B9
		public unsafe bool bCastShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_bCastShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_bCastShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700580A RID: 22538
		// (get) Token: 0x06016117 RID: 90391 RVA: 0x002054CA File Offset: 0x002036CA
		// (set) Token: 0x06016118 RID: 90392 RVA: 0x002054DA File Offset: 0x002036DA
		public unsafe bool bCastDynamicShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_bCastDynamicShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_bCastDynamicShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700580B RID: 22539
		// (get) Token: 0x06016119 RID: 90393 RVA: 0x002054EB File Offset: 0x002036EB
		// (set) Token: 0x0601611A RID: 90394 RVA: 0x002054FB File Offset: 0x002036FB
		public unsafe bool bSourceWasVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_bSourceWasVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_bSourceWasVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700580C RID: 22540
		// (get) Token: 0x0601611B RID: 90395 RVA: 0x0020550C File Offset: 0x0020370C
		// (set) Token: 0x0601611C RID: 90396 RVA: 0x0020551C File Offset: 0x0020371C
		public unsafe bool bOriginalSourceStateCaptured
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_bOriginalSourceStateCaptured) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_bOriginalSourceStateCaptured) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700580D RID: 22541
		// (get) Token: 0x0601611D RID: 90397 RVA: 0x0020552D File Offset: 0x0020372D
		// (set) Token: 0x0601611E RID: 90398 RVA: 0x0020553D File Offset: 0x0020373D
		public unsafe bool bSourceWasHiddenInGame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_bSourceWasHiddenInGame) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_bSourceWasHiddenInGame) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700580E RID: 22542
		// (get) Token: 0x0601611F RID: 90399 RVA: 0x0020554E File Offset: 0x0020374E
		// (set) Token: 0x06016120 RID: 90400 RVA: 0x00205562 File Offset: 0x00203762
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionEnabled> SourceCollisionEnabled
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_SourceCollisionEnabled);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_SourceCollisionEnabled) = value;
			}
		}

		// Token: 0x1700580F RID: 22543
		// (get) Token: 0x06016121 RID: 90401 RVA: 0x00205577 File Offset: 0x00203777
		// (set) Token: 0x06016122 RID: 90402 RVA: 0x0020558B File Offset: 0x0020378B
		public unsafe FName SourceCollisionProfileName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_SourceCollisionProfileName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_SourceCollisionProfileName) = value;
			}
		}

		// Token: 0x17005810 RID: 22544
		// (get) Token: 0x06016123 RID: 90403 RVA: 0x002055A0 File Offset: 0x002037A0
		// (set) Token: 0x06016124 RID: 90404 RVA: 0x002055B0 File Offset: 0x002037B0
		public unsafe bool bSourceGeneratedOverlapEvents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_bSourceGeneratedOverlapEvents) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedRenderSource.__PropertyOffset_bSourceGeneratedOverlapEvents) = (value ? 1 : 0);
			}
		}

		// Token: 0x06016125 RID: 90405 RVA: 0x002055C1 File Offset: 0x002037C1
		public FKuroCSJacobiClothBakedRenderSource()
		{
		}

		// Token: 0x06016126 RID: 90406 RVA: 0x002055CC File Offset: 0x002037CC
		public FKuroCSJacobiClothBakedRenderSource(TSoftObjectPtr<AStaticMeshActor> SourceActor, TSoftObjectPtr<UStaticMeshComponent> SourceComponent, bool bManagerOwnedSourceComponent, bool bSourceOwnershipDetached, bool bSourceActorStateCaptured, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AStaticMeshActor> SourceActorClass, FName SourceLevelPackageName, FName SourceActorName, string SourceActorLabel, FName SourceActorFolderPath, TArray<FName> SourceActorTags, TArray<FName> SourceActorLayers, bool bSourceActorHiddenInGame, [Nullable(0)] TEnumAsByte<EComponentMobility> SourceComponentMobility, int ClothInstanceIndex, UStaticMesh SourceMesh, FTransform LocalTransform, TArray<UMaterialInterface> Materials, TArray<float> CustomPrimitiveData, bool bCastShadow, bool bCastDynamicShadow, bool bSourceWasVisible, bool bOriginalSourceStateCaptured, bool bSourceWasHiddenInGame, [Nullable(0)] TEnumAsByte<ECollisionEnabled> SourceCollisionEnabled, FName SourceCollisionProfileName, bool bSourceGeneratedOverlapEvents)
		{
			this.SourceActor = SourceActor;
			this.SourceComponent = SourceComponent;
			this.bManagerOwnedSourceComponent = bManagerOwnedSourceComponent;
			this.bSourceOwnershipDetached = bSourceOwnershipDetached;
			this.ClothInstanceIndex = ClothInstanceIndex;
			this.SourceMesh = SourceMesh;
			this.LocalTransform = LocalTransform;
			this.Materials = Materials;
			this.CustomPrimitiveData = CustomPrimitiveData;
			this.bCastShadow = bCastShadow;
			this.bCastDynamicShadow = bCastDynamicShadow;
			this.bSourceWasVisible = bSourceWasVisible;
			this.bOriginalSourceStateCaptured = bOriginalSourceStateCaptured;
			this.bSourceWasHiddenInGame = bSourceWasHiddenInGame;
			this.SourceCollisionEnabled = SourceCollisionEnabled;
			this.SourceCollisionProfileName = SourceCollisionProfileName;
			this.bSourceGeneratedOverlapEvents = bSourceGeneratedOverlapEvents;
		}

		// Token: 0x06016127 RID: 90407 RVA: 0x00205664 File Offset: 0x00203864
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSJacobiClothBakedRenderSource.StaticStruct();
		}

		// Token: 0x06016128 RID: 90408 RVA: 0x00205670 File Offset: 0x00203870
		[NullableContext(2)]
		public FKuroCSJacobiClothBakedRenderSource(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016129 RID: 90409 RVA: 0x0020567A File Offset: 0x0020387A
		public FKuroCSJacobiClothBakedRenderSource(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601612A RID: 90410 RVA: 0x00205685 File Offset: 0x00203885
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSJacobiClothBakedRenderSource(Pointer, false, true);
		}

		// Token: 0x0601612B RID: 90411 RVA: 0x0020568F File Offset: 0x0020388F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSJacobiClothBakedRenderSource(Pointer, MemoryOwner);
		}

		// Token: 0x0400C046 RID: 49222
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSJacobiClothBakedRenderSource";

		// Token: 0x0400C047 RID: 49223
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C048 RID: 49224
		internal static int __PropertyOffset_SourceActor;

		// Token: 0x0400C049 RID: 49225
		internal static int __PropertyOffset_SourceComponent;

		// Token: 0x0400C04A RID: 49226
		internal static int __PropertyOffset_bManagerOwnedSourceComponent;

		// Token: 0x0400C04B RID: 49227
		internal static int __PropertyOffset_bSourceOwnershipDetached;

		// Token: 0x0400C04C RID: 49228
		internal static int __PropertyOffset_ClothInstanceIndex;

		// Token: 0x0400C04D RID: 49229
		internal static int __PropertyOffset_SourceMesh;

		// Token: 0x0400C04E RID: 49230
		internal static int __PropertyOffset_LocalTransform;

		// Token: 0x0400C04F RID: 49231
		internal static int __PropertyOffset_Materials;

		// Token: 0x0400C050 RID: 49232
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _Materials;

		// Token: 0x0400C051 RID: 49233
		internal static int __PropertyOffset_CustomPrimitiveData;

		// Token: 0x0400C052 RID: 49234
		[Nullable(2)]
		private TArray<float> _CustomPrimitiveData;

		// Token: 0x0400C053 RID: 49235
		internal static int __PropertyOffset_bCastShadow;

		// Token: 0x0400C054 RID: 49236
		internal static int __PropertyOffset_bCastDynamicShadow;

		// Token: 0x0400C055 RID: 49237
		internal static int __PropertyOffset_bSourceWasVisible;

		// Token: 0x0400C056 RID: 49238
		internal static int __PropertyOffset_bOriginalSourceStateCaptured;

		// Token: 0x0400C057 RID: 49239
		internal static int __PropertyOffset_bSourceWasHiddenInGame;

		// Token: 0x0400C058 RID: 49240
		internal static int __PropertyOffset_SourceCollisionEnabled;

		// Token: 0x0400C059 RID: 49241
		internal static int __PropertyOffset_SourceCollisionProfileName;

		// Token: 0x0400C05A RID: 49242
		internal static int __PropertyOffset_bSourceGeneratedOverlapEvents;
	}
}
