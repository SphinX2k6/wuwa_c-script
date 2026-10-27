using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001506 RID: 5382
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniStaticMeshGenerationProperties")]
	[UnrealStructLayout(504, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 504)]
	public class FHoudiniStaticMeshGenerationProperties : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601392E RID: 80174 RVA: 0x001CC054 File Offset: 0x001CA254
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniStaticMeshGenerationProperties._ScriptStructPtr != 0) ? FHoudiniStaticMeshGenerationProperties._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniStaticMeshGenerationProperties", ref FHoudiniStaticMeshGenerationProperties._ScriptStructPtr);
		}

		// Token: 0x17004CA0 RID: 19616
		// (get) Token: 0x0601392F RID: 80175 RVA: 0x001CC078 File Offset: 0x001CA278
		// (set) Token: 0x06013930 RID: 80176 RVA: 0x001CC091 File Offset: 0x001CA291
		public unsafe bool bGeneratedDoubleSidedGeometry
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FHoudiniStaticMeshGenerationProperties.__PropertyOffset_bGeneratedDoubleSidedGeometry) & FHoudiniStaticMeshGenerationProperties.__PropertyMask_bGeneratedDoubleSidedGeometry) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FHoudiniStaticMeshGenerationProperties.__PropertyOffset_bGeneratedDoubleSidedGeometry) = ((*(base.NativePtr + (IntPtr)FHoudiniStaticMeshGenerationProperties.__PropertyOffset_bGeneratedDoubleSidedGeometry) & ~FHoudiniStaticMeshGenerationProperties.__PropertyMask_bGeneratedDoubleSidedGeometry) | (value ? FHoudiniStaticMeshGenerationProperties.__PropertyMask_bGeneratedDoubleSidedGeometry : 0));
			}
		}

		// Token: 0x17004CA1 RID: 19617
		// (get) Token: 0x06013931 RID: 80177 RVA: 0x001CC0C1 File Offset: 0x001CA2C1
		// (set) Token: 0x06013932 RID: 80178 RVA: 0x001CC0D5 File Offset: 0x001CA2D5
		[Nullable(2)]
		public unsafe UPhysicalMaterial GeneratedPhysMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + FHoudiniStaticMeshGenerationProperties.__PropertyOffset_GeneratedPhysMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FHoudiniStaticMeshGenerationProperties.__PropertyOffset_GeneratedPhysMaterial, value);
			}
		}

		// Token: 0x17004CA2 RID: 19618
		// (get) Token: 0x06013933 RID: 80179 RVA: 0x001CC0EC File Offset: 0x001CA2EC
		// (set) Token: 0x06013934 RID: 80180 RVA: 0x001CC12F File Offset: 0x001CA32F
		public FBodyInstance DefaultBodyInstance
		{
			get
			{
				base.FastCheckIsValid();
				FBodyInstance result;
				if ((result = this._DefaultBodyInstance) == null)
				{
					result = (this._DefaultBodyInstance = new FBodyInstance(base.NativePtr + (IntPtr)FHoudiniStaticMeshGenerationProperties.__PropertyOffset_DefaultBodyInstance, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBodyInstance.StaticStruct(), base.NativePtr + (IntPtr)FHoudiniStaticMeshGenerationProperties.__PropertyOffset_DefaultBodyInstance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004CA3 RID: 19619
		// (get) Token: 0x06013935 RID: 80181 RVA: 0x001CC150 File Offset: 0x001CA350
		// (set) Token: 0x06013936 RID: 80182 RVA: 0x001CC164 File Offset: 0x001CA364
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionTraceFlag> GeneratedCollisionTraceFlag
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniStaticMeshGenerationProperties.__PropertyOffset_GeneratedCollisionTraceFlag);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniStaticMeshGenerationProperties.__PropertyOffset_GeneratedCollisionTraceFlag) = value;
			}
		}

		// Token: 0x17004CA4 RID: 19620
		// (get) Token: 0x06013937 RID: 80183 RVA: 0x001CC179 File Offset: 0x001CA379
		// (set) Token: 0x06013938 RID: 80184 RVA: 0x001CC189 File Offset: 0x001CA389
		public unsafe int GeneratedLightMapResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniStaticMeshGenerationProperties.__PropertyOffset_GeneratedLightMapResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniStaticMeshGenerationProperties.__PropertyOffset_GeneratedLightMapResolution) = value;
			}
		}

		// Token: 0x17004CA5 RID: 19621
		// (get) Token: 0x06013939 RID: 80185 RVA: 0x001CC19C File Offset: 0x001CA39C
		// (set) Token: 0x0601393A RID: 80186 RVA: 0x001CC1DF File Offset: 0x001CA3DF
		public FWalkableSlopeOverride GeneratedWalkableSlopeOverride
		{
			get
			{
				base.FastCheckIsValid();
				FWalkableSlopeOverride result;
				if ((result = this._GeneratedWalkableSlopeOverride) == null)
				{
					result = (this._GeneratedWalkableSlopeOverride = new FWalkableSlopeOverride(base.NativePtr + (IntPtr)FHoudiniStaticMeshGenerationProperties.__PropertyOffset_GeneratedWalkableSlopeOverride, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWalkableSlopeOverride.StaticStruct(), base.NativePtr + (IntPtr)FHoudiniStaticMeshGenerationProperties.__PropertyOffset_GeneratedWalkableSlopeOverride, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004CA6 RID: 19622
		// (get) Token: 0x0601393B RID: 80187 RVA: 0x001CC200 File Offset: 0x001CA400
		// (set) Token: 0x0601393C RID: 80188 RVA: 0x001CC210 File Offset: 0x001CA410
		public unsafe int GeneratedLightMapCoordinateIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniStaticMeshGenerationProperties.__PropertyOffset_GeneratedLightMapCoordinateIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniStaticMeshGenerationProperties.__PropertyOffset_GeneratedLightMapCoordinateIndex) = value;
			}
		}

		// Token: 0x17004CA7 RID: 19623
		// (get) Token: 0x0601393D RID: 80189 RVA: 0x001CC221 File Offset: 0x001CA421
		// (set) Token: 0x0601393E RID: 80190 RVA: 0x001CC23A File Offset: 0x001CA43A
		public unsafe bool bGeneratedUseMaximumStreamingTexelRatio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FHoudiniStaticMeshGenerationProperties.__PropertyOffset_bGeneratedUseMaximumStreamingTexelRatio) & FHoudiniStaticMeshGenerationProperties.__PropertyMask_bGeneratedUseMaximumStreamingTexelRatio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FHoudiniStaticMeshGenerationProperties.__PropertyOffset_bGeneratedUseMaximumStreamingTexelRatio) = ((*(base.NativePtr + (IntPtr)FHoudiniStaticMeshGenerationProperties.__PropertyOffset_bGeneratedUseMaximumStreamingTexelRatio) & ~FHoudiniStaticMeshGenerationProperties.__PropertyMask_bGeneratedUseMaximumStreamingTexelRatio) | (value ? FHoudiniStaticMeshGenerationProperties.__PropertyMask_bGeneratedUseMaximumStreamingTexelRatio : 0));
			}
		}

		// Token: 0x17004CA8 RID: 19624
		// (get) Token: 0x0601393F RID: 80191 RVA: 0x001CC26A File Offset: 0x001CA46A
		// (set) Token: 0x06013940 RID: 80192 RVA: 0x001CC27A File Offset: 0x001CA47A
		public unsafe float GeneratedStreamingDistanceMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniStaticMeshGenerationProperties.__PropertyOffset_GeneratedStreamingDistanceMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniStaticMeshGenerationProperties.__PropertyOffset_GeneratedStreamingDistanceMultiplier) = value;
			}
		}

		// Token: 0x17004CA9 RID: 19625
		// (get) Token: 0x06013941 RID: 80193 RVA: 0x001CC28B File Offset: 0x001CA48B
		// (set) Token: 0x06013942 RID: 80194 RVA: 0x001CC29F File Offset: 0x001CA49F
		[Nullable(2)]
		public unsafe UFoliageType_InstancedStaticMesh GeneratedFoliageDefaultSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFoliageType_InstancedStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FHoudiniStaticMeshGenerationProperties.__PropertyOffset_GeneratedFoliageDefaultSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FHoudiniStaticMeshGenerationProperties.__PropertyOffset_GeneratedFoliageDefaultSettings, value);
			}
		}

		// Token: 0x17004CAA RID: 19626
		// (get) Token: 0x06013943 RID: 80195 RVA: 0x001CC2B4 File Offset: 0x001CA4B4
		// (set) Token: 0x06013944 RID: 80196 RVA: 0x001CC2F7 File Offset: 0x001CA4F7
		public TArray<UAssetUserData> GeneratedAssetUserData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAssetUserData> result;
				if ((result = this._GeneratedAssetUserData) == null)
				{
					result = (this._GeneratedAssetUserData = new TArray<UAssetUserData>(base.NativePtr + (IntPtr)FHoudiniStaticMeshGenerationProperties.__PropertyOffset_GeneratedAssetUserData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GeneratedAssetUserData.CopyAssign(value);
			}
		}

		// Token: 0x06013945 RID: 80197 RVA: 0x001CC305 File Offset: 0x001CA505
		public FHoudiniStaticMeshGenerationProperties()
		{
		}

		// Token: 0x06013946 RID: 80198 RVA: 0x001CC310 File Offset: 0x001CA510
		public FHoudiniStaticMeshGenerationProperties(bool bGeneratedDoubleSidedGeometry, UPhysicalMaterial GeneratedPhysMaterial, FBodyInstance DefaultBodyInstance, [Nullable(0)] TEnumAsByte<ECollisionTraceFlag> GeneratedCollisionTraceFlag, int GeneratedLightMapResolution, FWalkableSlopeOverride GeneratedWalkableSlopeOverride, int GeneratedLightMapCoordinateIndex, bool bGeneratedUseMaximumStreamingTexelRatio, float GeneratedStreamingDistanceMultiplier, UFoliageType_InstancedStaticMesh GeneratedFoliageDefaultSettings, TArray<UAssetUserData> GeneratedAssetUserData)
		{
			this.bGeneratedDoubleSidedGeometry = bGeneratedDoubleSidedGeometry;
			this.GeneratedPhysMaterial = GeneratedPhysMaterial;
			this.DefaultBodyInstance = DefaultBodyInstance;
			this.GeneratedCollisionTraceFlag = GeneratedCollisionTraceFlag;
			this.GeneratedLightMapResolution = GeneratedLightMapResolution;
			this.GeneratedWalkableSlopeOverride = GeneratedWalkableSlopeOverride;
			this.GeneratedLightMapCoordinateIndex = GeneratedLightMapCoordinateIndex;
			this.bGeneratedUseMaximumStreamingTexelRatio = bGeneratedUseMaximumStreamingTexelRatio;
			this.GeneratedStreamingDistanceMultiplier = GeneratedStreamingDistanceMultiplier;
			this.GeneratedFoliageDefaultSettings = GeneratedFoliageDefaultSettings;
			this.GeneratedAssetUserData = GeneratedAssetUserData;
		}

		// Token: 0x06013947 RID: 80199 RVA: 0x001CC378 File Offset: 0x001CA578
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniStaticMeshGenerationProperties.StaticStruct();
		}

		// Token: 0x06013948 RID: 80200 RVA: 0x001CC384 File Offset: 0x001CA584
		[NullableContext(2)]
		public FHoudiniStaticMeshGenerationProperties(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013949 RID: 80201 RVA: 0x001CC38E File Offset: 0x001CA58E
		public FHoudiniStaticMeshGenerationProperties(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601394A RID: 80202 RVA: 0x001CC399 File Offset: 0x001CA599
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniStaticMeshGenerationProperties(Pointer, false, true);
		}

		// Token: 0x0601394B RID: 80203 RVA: 0x001CC3A3 File Offset: 0x001CA5A3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniStaticMeshGenerationProperties(Pointer, MemoryOwner);
		}

		// Token: 0x0400A92C RID: 43308
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniStaticMeshGenerationProperties";

		// Token: 0x0400A92D RID: 43309
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A92E RID: 43310
		internal static int __PropertyOffset_bGeneratedDoubleSidedGeometry;

		// Token: 0x0400A92F RID: 43311
		internal static byte __PropertyMask_bGeneratedDoubleSidedGeometry;

		// Token: 0x0400A930 RID: 43312
		internal static int __PropertyOffset_GeneratedPhysMaterial;

		// Token: 0x0400A931 RID: 43313
		internal static int __PropertyOffset_DefaultBodyInstance;

		// Token: 0x0400A932 RID: 43314
		[Nullable(2)]
		private FBodyInstance _DefaultBodyInstance;

		// Token: 0x0400A933 RID: 43315
		internal static int __PropertyOffset_GeneratedCollisionTraceFlag;

		// Token: 0x0400A934 RID: 43316
		internal static int __PropertyOffset_GeneratedLightMapResolution;

		// Token: 0x0400A935 RID: 43317
		internal static int __PropertyOffset_GeneratedWalkableSlopeOverride;

		// Token: 0x0400A936 RID: 43318
		[Nullable(2)]
		private FWalkableSlopeOverride _GeneratedWalkableSlopeOverride;

		// Token: 0x0400A937 RID: 43319
		internal static int __PropertyOffset_GeneratedLightMapCoordinateIndex;

		// Token: 0x0400A938 RID: 43320
		internal static int __PropertyOffset_bGeneratedUseMaximumStreamingTexelRatio;

		// Token: 0x0400A939 RID: 43321
		internal static byte __PropertyMask_bGeneratedUseMaximumStreamingTexelRatio;

		// Token: 0x0400A93A RID: 43322
		internal static int __PropertyOffset_GeneratedStreamingDistanceMultiplier;

		// Token: 0x0400A93B RID: 43323
		internal static int __PropertyOffset_GeneratedFoliageDefaultSettings;

		// Token: 0x0400A93C RID: 43324
		internal static int __PropertyOffset_GeneratedAssetUserData;

		// Token: 0x0400A93D RID: 43325
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAssetUserData> _GeneratedAssetUserData;
	}
}
