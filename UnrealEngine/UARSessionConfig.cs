using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003C2 RID: 962
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARSessionConfig")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UARSessionConfig : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003551 RID: 13649 RVA: 0x000516B3 File Offset: 0x0004F8B3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARSessionConfig._ClassPtr;
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x000516C0 File Offset: 0x0004F8C0
		public UARSessionConfig() : this(BuiltinUtils.AllocNativeUObject(UARSessionConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x000516E8 File Offset: 0x0004F8E8
		public UARSessionConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARSessionConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x06003554 RID: 13652 RVA: 0x0005171B File Offset: 0x0004F91B
		// (set) Token: 0x06003555 RID: 13653 RVA: 0x0005172B File Offset: 0x0004F92B
		public unsafe bool bGenerateMeshDataFromTrackedGeometry
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bGenerateMeshDataFromTrackedGeometry) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bGenerateMeshDataFromTrackedGeometry) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06003556 RID: 13654 RVA: 0x0005173C File Offset: 0x0004F93C
		// (set) Token: 0x06003557 RID: 13655 RVA: 0x0005174C File Offset: 0x0004F94C
		public unsafe bool bGenerateCollisionForMeshData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bGenerateCollisionForMeshData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bGenerateCollisionForMeshData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06003558 RID: 13656 RVA: 0x0005175D File Offset: 0x0004F95D
		// (set) Token: 0x06003559 RID: 13657 RVA: 0x0005176D File Offset: 0x0004F96D
		public unsafe bool bGenerateNavMeshForMeshData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bGenerateNavMeshForMeshData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bGenerateNavMeshForMeshData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x0600355A RID: 13658 RVA: 0x0005177E File Offset: 0x0004F97E
		// (set) Token: 0x0600355B RID: 13659 RVA: 0x0005178E File Offset: 0x0004F98E
		public unsafe bool bUseMeshDataForOcclusion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bUseMeshDataForOcclusion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bUseMeshDataForOcclusion) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x0600355C RID: 13660 RVA: 0x0005179F File Offset: 0x0004F99F
		// (set) Token: 0x0600355D RID: 13661 RVA: 0x000517AF File Offset: 0x0004F9AF
		public unsafe bool bRenderMeshDataInWireframe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bRenderMeshDataInWireframe) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bRenderMeshDataInWireframe) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x0600355E RID: 13662 RVA: 0x000517C0 File Offset: 0x0004F9C0
		// (set) Token: 0x0600355F RID: 13663 RVA: 0x000517D0 File Offset: 0x0004F9D0
		public unsafe bool bTrackSceneObjects
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bTrackSceneObjects) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bTrackSceneObjects) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06003560 RID: 13664 RVA: 0x000517E1 File Offset: 0x0004F9E1
		// (set) Token: 0x06003561 RID: 13665 RVA: 0x000517F1 File Offset: 0x0004F9F1
		public unsafe bool bUsePersonSegmentationForOcclusion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bUsePersonSegmentationForOcclusion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bUsePersonSegmentationForOcclusion) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06003562 RID: 13666 RVA: 0x00051802 File Offset: 0x0004FA02
		// (set) Token: 0x06003563 RID: 13667 RVA: 0x00051812 File Offset: 0x0004FA12
		public unsafe bool bUseSceneDepthForOcclusion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bUseSceneDepthForOcclusion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bUseSceneDepthForOcclusion) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x06003564 RID: 13668 RVA: 0x00051823 File Offset: 0x0004FA23
		// (set) Token: 0x06003565 RID: 13669 RVA: 0x00051833 File Offset: 0x0004FA33
		public unsafe bool bUseAutomaticImageScaleEstimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bUseAutomaticImageScaleEstimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bUseAutomaticImageScaleEstimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06003566 RID: 13670 RVA: 0x00051844 File Offset: 0x0004FA44
		// (set) Token: 0x06003567 RID: 13671 RVA: 0x00051854 File Offset: 0x0004FA54
		public unsafe bool bUseStandardOnboardingUX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bUseStandardOnboardingUX) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bUseStandardOnboardingUX) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06003568 RID: 13672 RVA: 0x00051865 File Offset: 0x0004FA65
		// (set) Token: 0x06003569 RID: 13673 RVA: 0x00051875 File Offset: 0x0004FA75
		public unsafe EARWorldAlignment WorldAlignment
		{
			get
			{
				return (EARWorldAlignment)(*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_WorldAlignment));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_WorldAlignment) = (byte)value;
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x0600356A RID: 13674 RVA: 0x00051886 File Offset: 0x0004FA86
		// (set) Token: 0x0600356B RID: 13675 RVA: 0x00051896 File Offset: 0x0004FA96
		public unsafe EARSessionType SessionType
		{
			get
			{
				return (EARSessionType)(*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_SessionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_SessionType) = (byte)value;
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x0600356C RID: 13676 RVA: 0x000518A7 File Offset: 0x0004FAA7
		// (set) Token: 0x0600356D RID: 13677 RVA: 0x000518B7 File Offset: 0x0004FAB7
		public unsafe EARPlaneDetectionMode PlaneDetectionMode_DEPRECATED
		{
			get
			{
				return (EARPlaneDetectionMode)(*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_PlaneDetectionMode_DEPRECATED));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_PlaneDetectionMode_DEPRECATED) = (byte)value;
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x0600356E RID: 13678 RVA: 0x000518C8 File Offset: 0x0004FAC8
		// (set) Token: 0x0600356F RID: 13679 RVA: 0x000518D8 File Offset: 0x0004FAD8
		public unsafe bool bHorizontalPlaneDetection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bHorizontalPlaneDetection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bHorizontalPlaneDetection) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06003570 RID: 13680 RVA: 0x000518E9 File Offset: 0x0004FAE9
		// (set) Token: 0x06003571 RID: 13681 RVA: 0x000518F9 File Offset: 0x0004FAF9
		public unsafe bool bVerticalPlaneDetection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bVerticalPlaneDetection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bVerticalPlaneDetection) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06003572 RID: 13682 RVA: 0x0005190A File Offset: 0x0004FB0A
		// (set) Token: 0x06003573 RID: 13683 RVA: 0x0005191A File Offset: 0x0004FB1A
		public unsafe bool bEnableAutoFocus
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bEnableAutoFocus) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bEnableAutoFocus) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x06003574 RID: 13684 RVA: 0x0005192B File Offset: 0x0004FB2B
		// (set) Token: 0x06003575 RID: 13685 RVA: 0x0005193B File Offset: 0x0004FB3B
		public unsafe EARLightEstimationMode LightEstimationMode
		{
			get
			{
				return (EARLightEstimationMode)(*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_LightEstimationMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_LightEstimationMode) = (byte)value;
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06003576 RID: 13686 RVA: 0x0005194C File Offset: 0x0004FB4C
		// (set) Token: 0x06003577 RID: 13687 RVA: 0x0005195C File Offset: 0x0004FB5C
		public unsafe EARFrameSyncMode FrameSyncMode
		{
			get
			{
				return (EARFrameSyncMode)(*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_FrameSyncMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_FrameSyncMode) = (byte)value;
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06003578 RID: 13688 RVA: 0x0005196D File Offset: 0x0004FB6D
		// (set) Token: 0x06003579 RID: 13689 RVA: 0x0005197D File Offset: 0x0004FB7D
		public unsafe bool bEnableAutomaticCameraOverlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bEnableAutomaticCameraOverlay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bEnableAutomaticCameraOverlay) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x0600357A RID: 13690 RVA: 0x0005198E File Offset: 0x0004FB8E
		// (set) Token: 0x0600357B RID: 13691 RVA: 0x0005199E File Offset: 0x0004FB9E
		public unsafe bool bEnableAutomaticCameraTracking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bEnableAutomaticCameraTracking) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bEnableAutomaticCameraTracking) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x0600357C RID: 13692 RVA: 0x000519AF File Offset: 0x0004FBAF
		// (set) Token: 0x0600357D RID: 13693 RVA: 0x000519BF File Offset: 0x0004FBBF
		public unsafe bool bResetCameraTracking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bResetCameraTracking) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bResetCameraTracking) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x0600357E RID: 13694 RVA: 0x000519D0 File Offset: 0x0004FBD0
		// (set) Token: 0x0600357F RID: 13695 RVA: 0x000519E0 File Offset: 0x0004FBE0
		public unsafe bool bResetTrackedObjects
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bResetTrackedObjects) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bResetTrackedObjects) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06003580 RID: 13696 RVA: 0x000519F4 File Offset: 0x0004FBF4
		// (set) Token: 0x06003581 RID: 13697 RVA: 0x00051A2D File Offset: 0x0004FC2D
		public TArray<UARCandidateImage> CandidateImages
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UARCandidateImage> result;
				if ((result = this._CandidateImages) == null)
				{
					result = (this._CandidateImages = new TArray<UARCandidateImage>(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_CandidateImages, this));
				}
				return result;
			}
			set
			{
				this.CandidateImages.CopyAssign(value);
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x06003582 RID: 13698 RVA: 0x00051A3B File Offset: 0x0004FC3B
		// (set) Token: 0x06003583 RID: 13699 RVA: 0x00051A4B File Offset: 0x0004FC4B
		public unsafe int MaxNumSimultaneousImagesTracked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_MaxNumSimultaneousImagesTracked);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_MaxNumSimultaneousImagesTracked) = value;
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x06003584 RID: 13700 RVA: 0x00051A5C File Offset: 0x0004FC5C
		// (set) Token: 0x06003585 RID: 13701 RVA: 0x00051A6C File Offset: 0x0004FC6C
		public unsafe EAREnvironmentCaptureProbeType EnvironmentCaptureProbeType
		{
			get
			{
				return (EAREnvironmentCaptureProbeType)(*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_EnvironmentCaptureProbeType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_EnvironmentCaptureProbeType) = (byte)value;
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06003586 RID: 13702 RVA: 0x00051A80 File Offset: 0x0004FC80
		// (set) Token: 0x06003587 RID: 13703 RVA: 0x00051AB9 File Offset: 0x0004FCB9
		public TArray<byte> WorldMapData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._WorldMapData) == null)
				{
					result = (this._WorldMapData = new TArray<byte>(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_WorldMapData, this));
				}
				return result;
			}
			set
			{
				this.WorldMapData.CopyAssign(value);
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06003588 RID: 13704 RVA: 0x00051AC8 File Offset: 0x0004FCC8
		// (set) Token: 0x06003589 RID: 13705 RVA: 0x00051B01 File Offset: 0x0004FD01
		public TArray<UARCandidateObject> CandidateObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UARCandidateObject> result;
				if ((result = this._CandidateObjects) == null)
				{
					result = (this._CandidateObjects = new TArray<UARCandidateObject>(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_CandidateObjects, this));
				}
				return result;
			}
			set
			{
				this.CandidateObjects.CopyAssign(value);
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x0600358A RID: 13706 RVA: 0x00051B10 File Offset: 0x0004FD10
		// (set) Token: 0x0600358B RID: 13707 RVA: 0x00051B49 File Offset: 0x0004FD49
		public FARVideoFormat DesiredVideoFormat
		{
			get
			{
				base.FastCheckIsValid();
				FARVideoFormat result;
				if ((result = this._DesiredVideoFormat) == null)
				{
					result = (this._DesiredVideoFormat = new FARVideoFormat(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_DesiredVideoFormat, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FARVideoFormat.StaticStruct(), base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_DesiredVideoFormat, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x0600358C RID: 13708 RVA: 0x00051B6A File Offset: 0x0004FD6A
		// (set) Token: 0x0600358D RID: 13709 RVA: 0x00051B7A File Offset: 0x0004FD7A
		public unsafe bool bUseOptimalVideoFormat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bUseOptimalVideoFormat) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_bUseOptimalVideoFormat) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x0600358E RID: 13710 RVA: 0x00051B8B File Offset: 0x0004FD8B
		// (set) Token: 0x0600358F RID: 13711 RVA: 0x00051B9B File Offset: 0x0004FD9B
		public unsafe EARFaceTrackingDirection FaceTrackingDirection
		{
			get
			{
				return (EARFaceTrackingDirection)(*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_FaceTrackingDirection));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_FaceTrackingDirection) = (byte)value;
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06003590 RID: 13712 RVA: 0x00051BAC File Offset: 0x0004FDAC
		// (set) Token: 0x06003591 RID: 13713 RVA: 0x00051BBC File Offset: 0x0004FDBC
		public unsafe EARFaceTrackingUpdate FaceTrackingUpdate
		{
			get
			{
				return (EARFaceTrackingUpdate)(*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_FaceTrackingUpdate));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_FaceTrackingUpdate) = (byte)value;
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06003592 RID: 13714 RVA: 0x00051BCD File Offset: 0x0004FDCD
		// (set) Token: 0x06003593 RID: 13715 RVA: 0x00051BDD File Offset: 0x0004FDDD
		public unsafe int MaxNumberOfTrackedFaces
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_MaxNumberOfTrackedFaces);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_MaxNumberOfTrackedFaces) = value;
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x06003594 RID: 13716 RVA: 0x00051BF0 File Offset: 0x0004FDF0
		// (set) Token: 0x06003595 RID: 13717 RVA: 0x00051C29 File Offset: 0x0004FE29
		public TArray<byte> SerializedARCandidateImageDatabase
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._SerializedARCandidateImageDatabase) == null)
				{
					result = (this._SerializedARCandidateImageDatabase = new TArray<byte>(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_SerializedARCandidateImageDatabase, this));
				}
				return result;
			}
			set
			{
				this.SerializedARCandidateImageDatabase.CopyAssign(value);
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x06003596 RID: 13718 RVA: 0x00051C37 File Offset: 0x0004FE37
		// (set) Token: 0x06003597 RID: 13719 RVA: 0x00051C47 File Offset: 0x0004FE47
		public unsafe EARSessionTrackingFeature EnabledSessionTrackingFeature
		{
			get
			{
				return (EARSessionTrackingFeature)(*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_EnabledSessionTrackingFeature));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_EnabledSessionTrackingFeature) = (byte)value;
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x06003598 RID: 13720 RVA: 0x00051C58 File Offset: 0x0004FE58
		// (set) Token: 0x06003599 RID: 13721 RVA: 0x00051C68 File Offset: 0x0004FE68
		public unsafe EARSceneReconstruction SceneReconstructionMethod
		{
			get
			{
				return (EARSceneReconstruction)(*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_SceneReconstructionMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_SceneReconstructionMethod) = (byte)value;
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x0600359A RID: 13722 RVA: 0x00051C79 File Offset: 0x0004FE79
		// (set) Token: 0x0600359B RID: 13723 RVA: 0x00051C8D File Offset: 0x0004FE8D
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UARPlaneComponent> PlaneComponentClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_PlaneComponentClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_PlaneComponentClass) = value;
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x0600359C RID: 13724 RVA: 0x00051CA2 File Offset: 0x0004FEA2
		// (set) Token: 0x0600359D RID: 13725 RVA: 0x00051CB6 File Offset: 0x0004FEB6
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UARPointComponent> PointComponentClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_PointComponentClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_PointComponentClass) = value;
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x0600359E RID: 13726 RVA: 0x00051CCB File Offset: 0x0004FECB
		// (set) Token: 0x0600359F RID: 13727 RVA: 0x00051CDF File Offset: 0x0004FEDF
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UARFaceComponent> FaceComponentClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_FaceComponentClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_FaceComponentClass) = value;
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x060035A0 RID: 13728 RVA: 0x00051CF4 File Offset: 0x0004FEF4
		// (set) Token: 0x060035A1 RID: 13729 RVA: 0x00051D08 File Offset: 0x0004FF08
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UARImageComponent> ImageComponentClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_ImageComponentClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_ImageComponentClass) = value;
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x060035A2 RID: 13730 RVA: 0x00051D1D File Offset: 0x0004FF1D
		// (set) Token: 0x060035A3 RID: 13731 RVA: 0x00051D31 File Offset: 0x0004FF31
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UARQRCodeComponent> QRCodeComponentClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_QRCodeComponentClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_QRCodeComponentClass) = value;
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x060035A4 RID: 13732 RVA: 0x00051D46 File Offset: 0x0004FF46
		// (set) Token: 0x060035A5 RID: 13733 RVA: 0x00051D5A File Offset: 0x0004FF5A
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UARPoseComponent> PoseComponentClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_PoseComponentClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_PoseComponentClass) = value;
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x060035A6 RID: 13734 RVA: 0x00051D6F File Offset: 0x0004FF6F
		// (set) Token: 0x060035A7 RID: 13735 RVA: 0x00051D83 File Offset: 0x0004FF83
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UAREnvironmentProbeComponent> EnvironmentProbeComponentClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_EnvironmentProbeComponentClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_EnvironmentProbeComponentClass) = value;
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x060035A8 RID: 13736 RVA: 0x00051D98 File Offset: 0x0004FF98
		// (set) Token: 0x060035A9 RID: 13737 RVA: 0x00051DAC File Offset: 0x0004FFAC
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UARObjectComponent> ObjectComponentClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_ObjectComponentClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_ObjectComponentClass) = value;
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x060035AA RID: 13738 RVA: 0x00051DC1 File Offset: 0x0004FFC1
		// (set) Token: 0x060035AB RID: 13739 RVA: 0x00051DD5 File Offset: 0x0004FFD5
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UARMeshComponent> MeshComponentClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_MeshComponentClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_MeshComponentClass) = value;
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x060035AC RID: 13740 RVA: 0x00051DEA File Offset: 0x0004FFEA
		// (set) Token: 0x060035AD RID: 13741 RVA: 0x00051DFE File Offset: 0x0004FFFE
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UARGeoAnchorComponent> GeoAnchorComponentClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_GeoAnchorComponentClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UARSessionConfig.__PropertyOffset_GeoAnchorComponentClass) = value;
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x060035AE RID: 13742 RVA: 0x00051E13 File Offset: 0x00050013
		// (set) Token: 0x060035AF RID: 13743 RVA: 0x00051E27 File Offset: 0x00050027
		[Nullable(2)]
		public unsafe UMaterialInterface DefaultMeshMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UARSessionConfig.__PropertyOffset_DefaultMeshMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UARSessionConfig.__PropertyOffset_DefaultMeshMaterial, value);
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x060035B0 RID: 13744 RVA: 0x00051E3C File Offset: 0x0005003C
		// (set) Token: 0x060035B1 RID: 13745 RVA: 0x00051E50 File Offset: 0x00050050
		[Nullable(2)]
		public unsafe UMaterialInterface DefaultWireframeMeshMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UARSessionConfig.__PropertyOffset_DefaultWireframeMeshMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UARSessionConfig.__PropertyOffset_DefaultWireframeMeshMaterial, value);
			}
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x00051E65 File Offset: 0x00050065
		public bool ShouldResetTrackedObjects()
		{
			return UARSessionConfig.__ShouldResetTrackedObjects_Internal(base.NativePtr);
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x00051E72 File Offset: 0x00050072
		public bool ShouldResetCameraTracking()
		{
			return UARSessionConfig.__ShouldResetCameraTracking_Internal(base.NativePtr);
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x00051E7F File Offset: 0x0005007F
		public bool ShouldRenderCameraOverlay()
		{
			return UARSessionConfig.__ShouldRenderCameraOverlay_Internal(base.NativePtr);
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x00051E8C File Offset: 0x0005008C
		public bool ShouldEnableCameraTracking()
		{
			return UARSessionConfig.__ShouldEnableCameraTracking_Internal(base.NativePtr);
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x00051E99 File Offset: 0x00050099
		public bool ShouldEnableAutoFocus()
		{
			return UARSessionConfig.__ShouldEnableAutoFocus_Internal(base.NativePtr);
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x00051EA6 File Offset: 0x000500A6
		[NullableContext(2)]
		public void SetWorldMapData(TArray<byte> WorldMapData)
		{
			UARSessionConfig.__SetWorldMapData_Internal(base.NativePtr, (WorldMapData ?? new TArray<byte>()).NativePtr);
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x00051EC2 File Offset: 0x000500C2
		public void SetSessionTrackingFeatureToEnable(EARSessionTrackingFeature InSessionTrackingFeature)
		{
			UARSessionConfig.__SetSessionTrackingFeatureToEnable_Internal(base.NativePtr, InSessionTrackingFeature);
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x00051ED0 File Offset: 0x000500D0
		public void SetSceneReconstructionMethod(EARSceneReconstruction InSceneReconstructionMethod)
		{
			UARSessionConfig.__SetSceneReconstructionMethod_Internal(base.NativePtr, InSceneReconstructionMethod);
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x00051EDE File Offset: 0x000500DE
		public void SetResetTrackedObjects(bool bNewValue)
		{
			UARSessionConfig.__SetResetTrackedObjects_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x00051EEC File Offset: 0x000500EC
		public void SetResetCameraTracking(bool bNewValue)
		{
			UARSessionConfig.__SetResetCameraTracking_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x00051EFA File Offset: 0x000500FA
		public void SetFaceTrackingUpdate(EARFaceTrackingUpdate InUpdate)
		{
			UARSessionConfig.__SetFaceTrackingUpdate_Internal(base.NativePtr, InUpdate);
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x00051F08 File Offset: 0x00050108
		public void SetFaceTrackingDirection(EARFaceTrackingDirection InDirection)
		{
			UARSessionConfig.__SetFaceTrackingDirection_Internal(base.NativePtr, InDirection);
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x00051F16 File Offset: 0x00050116
		public void SetEnableAutoFocus(bool bNewValue)
		{
			UARSessionConfig.__SetEnableAutoFocus_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x00051F24 File Offset: 0x00050124
		[NullableContext(2)]
		public void SetDesiredVideoFormat(FARVideoFormat NewFormat)
		{
			UARSessionConfig.__SetDesiredVideoFormat_Internal(base.NativePtr, (NewFormat ?? new FARVideoFormat()).NativePtr);
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x00051F40 File Offset: 0x00050140
		public void SetCandidateObjectList([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UARCandidateObject> InCandidateObjects)
		{
			UARSessionConfig.__SetCandidateObjectList_Internal(base.NativePtr, (InCandidateObjects ?? new TArray<UARCandidateObject>()).NativePtr);
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x00051F5D File Offset: 0x0005015D
		public TArray<byte> GetWorldMapData()
		{
			return new TArray<byte>(UARSessionConfig.__GetWorldMapData_Internal(base.NativePtr), null);
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x00051F70 File Offset: 0x00050170
		public EARWorldAlignment GetWorldAlignment()
		{
			return UARSessionConfig.__GetWorldAlignment_Internal(base.NativePtr);
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x00051F7D File Offset: 0x0005017D
		public EARSessionType GetSessionType()
		{
			return UARSessionConfig.__GetSessionType_Internal(base.NativePtr);
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x00051F8A File Offset: 0x0005018A
		public EARSceneReconstruction GetSceneReconstructionMethod()
		{
			return UARSessionConfig.__GetSceneReconstructionMethod_Internal(base.NativePtr);
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x00051F97 File Offset: 0x00050197
		public EARPlaneDetectionMode GetPlaneDetectionMode()
		{
			return UARSessionConfig.__GetPlaneDetectionMode_Internal(base.NativePtr);
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x00051FA4 File Offset: 0x000501A4
		public int GetMaxNumSimultaneousImagesTracked()
		{
			return UARSessionConfig.__GetMaxNumSimultaneousImagesTracked_Internal(base.NativePtr);
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x00051FB1 File Offset: 0x000501B1
		public EARLightEstimationMode GetLightEstimationMode()
		{
			return UARSessionConfig.__GetLightEstimationMode_Internal(base.NativePtr);
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x00051FBE File Offset: 0x000501BE
		public EARFrameSyncMode GetFrameSyncMode()
		{
			return UARSessionConfig.__GetFrameSyncMode_Internal(base.NativePtr);
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x00051FCB File Offset: 0x000501CB
		public EARFaceTrackingUpdate GetFaceTrackingUpdate()
		{
			return UARSessionConfig.__GetFaceTrackingUpdate_Internal(base.NativePtr);
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x00051FD8 File Offset: 0x000501D8
		public EARFaceTrackingDirection GetFaceTrackingDirection()
		{
			return UARSessionConfig.__GetFaceTrackingDirection_Internal(base.NativePtr);
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x00051FE5 File Offset: 0x000501E5
		public EAREnvironmentCaptureProbeType GetEnvironmentCaptureProbeType()
		{
			return UARSessionConfig.__GetEnvironmentCaptureProbeType_Internal(base.NativePtr);
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x00051FF2 File Offset: 0x000501F2
		public EARSessionTrackingFeature GetEnabledSessionTrackingFeature()
		{
			return UARSessionConfig.__GetEnabledSessionTrackingFeature_Internal(base.NativePtr);
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x00051FFF File Offset: 0x000501FF
		public FARVideoFormat GetDesiredVideoFormat()
		{
			return new FARVideoFormat(UARSessionConfig.__GetDesiredVideoFormat_Internal(base.NativePtr), null);
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x00052012 File Offset: 0x00050212
		public TArray<UARCandidateObject> GetCandidateObjectList()
		{
			return new TArray<UARCandidateObject>(UARSessionConfig.__GetCandidateObjectList_Internal(base.NativePtr), null);
		}

		// Token: 0x060035CF RID: 13775 RVA: 0x00052025 File Offset: 0x00050225
		public TArray<UARCandidateImage> GetCandidateImageList()
		{
			return new TArray<UARCandidateImage>(UARSessionConfig.__GetCandidateImageList_Internal(base.NativePtr), null);
		}

		// Token: 0x060035D0 RID: 13776 RVA: 0x00052038 File Offset: 0x00050238
		[NullableContext(2)]
		public void AddCandidateObject(UARCandidateObject CandidateObject)
		{
			UARSessionConfig.__AddCandidateObject_Internal(base.NativePtr, (CandidateObject != null) ? CandidateObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x00052055 File Offset: 0x00050255
		[NullableContext(2)]
		public void AddCandidateImage(UARCandidateImage NewCandidateImage)
		{
			UARSessionConfig.__AddCandidateImage_Internal(base.NativePtr, (NewCandidateImage != null) ? NewCandidateImage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060035D2 RID: 13778
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldResetTrackedObjects_Internal(IntPtr @this);

		// Token: 0x060035D3 RID: 13779
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldResetCameraTracking_Internal(IntPtr @this);

		// Token: 0x060035D4 RID: 13780
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldRenderCameraOverlay_Internal(IntPtr @this);

		// Token: 0x060035D5 RID: 13781
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldEnableCameraTracking_Internal(IntPtr @this);

		// Token: 0x060035D6 RID: 13782
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldEnableAutoFocus_Internal(IntPtr @this);

		// Token: 0x060035D7 RID: 13783
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldMapData_Internal(IntPtr @this, IntPtr WorldMapData);

		// Token: 0x060035D8 RID: 13784
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSessionTrackingFeatureToEnable_Internal(IntPtr @this, EARSessionTrackingFeature InSessionTrackingFeature);

		// Token: 0x060035D9 RID: 13785
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSceneReconstructionMethod_Internal(IntPtr @this, EARSceneReconstruction InSceneReconstructionMethod);

		// Token: 0x060035DA RID: 13786
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetResetTrackedObjects_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x060035DB RID: 13787
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetResetCameraTracking_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x060035DC RID: 13788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFaceTrackingUpdate_Internal(IntPtr @this, EARFaceTrackingUpdate InUpdate);

		// Token: 0x060035DD RID: 13789
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFaceTrackingDirection_Internal(IntPtr @this, EARFaceTrackingDirection InDirection);

		// Token: 0x060035DE RID: 13790
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableAutoFocus_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x060035DF RID: 13791
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDesiredVideoFormat_Internal(IntPtr @this, IntPtr NewFormat);

		// Token: 0x060035E0 RID: 13792
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCandidateObjectList_Internal(IntPtr @this, IntPtr InCandidateObjects);

		// Token: 0x060035E1 RID: 13793
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWorldMapData_Internal(IntPtr @this);

		// Token: 0x060035E2 RID: 13794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EARWorldAlignment __GetWorldAlignment_Internal(IntPtr @this);

		// Token: 0x060035E3 RID: 13795
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EARSessionType __GetSessionType_Internal(IntPtr @this);

		// Token: 0x060035E4 RID: 13796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EARSceneReconstruction __GetSceneReconstructionMethod_Internal(IntPtr @this);

		// Token: 0x060035E5 RID: 13797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EARPlaneDetectionMode __GetPlaneDetectionMode_Internal(IntPtr @this);

		// Token: 0x060035E6 RID: 13798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaxNumSimultaneousImagesTracked_Internal(IntPtr @this);

		// Token: 0x060035E7 RID: 13799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EARLightEstimationMode __GetLightEstimationMode_Internal(IntPtr @this);

		// Token: 0x060035E8 RID: 13800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EARFrameSyncMode __GetFrameSyncMode_Internal(IntPtr @this);

		// Token: 0x060035E9 RID: 13801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EARFaceTrackingUpdate __GetFaceTrackingUpdate_Internal(IntPtr @this);

		// Token: 0x060035EA RID: 13802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EARFaceTrackingDirection __GetFaceTrackingDirection_Internal(IntPtr @this);

		// Token: 0x060035EB RID: 13803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EAREnvironmentCaptureProbeType __GetEnvironmentCaptureProbeType_Internal(IntPtr @this);

		// Token: 0x060035EC RID: 13804
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EARSessionTrackingFeature __GetEnabledSessionTrackingFeature_Internal(IntPtr @this);

		// Token: 0x060035ED RID: 13805
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDesiredVideoFormat_Internal(IntPtr @this);

		// Token: 0x060035EE RID: 13806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCandidateObjectList_Internal(IntPtr @this);

		// Token: 0x060035EF RID: 13807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCandidateImageList_Internal(IntPtr @this);

		// Token: 0x060035F0 RID: 13808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddCandidateObject_Internal(IntPtr @this, IntPtr CandidateObject);

		// Token: 0x060035F1 RID: 13809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddCandidateImage_Internal(IntPtr @this, IntPtr NewCandidateImage);

		// Token: 0x060035F2 RID: 13810 RVA: 0x00052072 File Offset: 0x00050272
		static UARSessionConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARSessionConfig");
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x00052080 File Offset: 0x00050280
		protected UARSessionConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001720 RID: 5920
		public new const string __ObjectPath = "/Script/AugmentedReality.ARSessionConfig";

		// Token: 0x04001721 RID: 5921
		private static IntPtr _ClassPtr;

		// Token: 0x04001722 RID: 5922
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001723 RID: 5923
		internal static int __PropertyOffset_bGenerateMeshDataFromTrackedGeometry;

		// Token: 0x04001724 RID: 5924
		internal static int __PropertyOffset_bGenerateCollisionForMeshData;

		// Token: 0x04001725 RID: 5925
		internal static int __PropertyOffset_bGenerateNavMeshForMeshData;

		// Token: 0x04001726 RID: 5926
		internal static int __PropertyOffset_bUseMeshDataForOcclusion;

		// Token: 0x04001727 RID: 5927
		internal static int __PropertyOffset_bRenderMeshDataInWireframe;

		// Token: 0x04001728 RID: 5928
		internal static int __PropertyOffset_bTrackSceneObjects;

		// Token: 0x04001729 RID: 5929
		internal static int __PropertyOffset_bUsePersonSegmentationForOcclusion;

		// Token: 0x0400172A RID: 5930
		internal static int __PropertyOffset_bUseSceneDepthForOcclusion;

		// Token: 0x0400172B RID: 5931
		internal static int __PropertyOffset_bUseAutomaticImageScaleEstimation;

		// Token: 0x0400172C RID: 5932
		internal static int __PropertyOffset_bUseStandardOnboardingUX;

		// Token: 0x0400172D RID: 5933
		internal static int __PropertyOffset_WorldAlignment;

		// Token: 0x0400172E RID: 5934
		internal static int __PropertyOffset_SessionType;

		// Token: 0x0400172F RID: 5935
		internal static int __PropertyOffset_PlaneDetectionMode_DEPRECATED;

		// Token: 0x04001730 RID: 5936
		internal static int __PropertyOffset_bHorizontalPlaneDetection;

		// Token: 0x04001731 RID: 5937
		internal static int __PropertyOffset_bVerticalPlaneDetection;

		// Token: 0x04001732 RID: 5938
		internal static int __PropertyOffset_bEnableAutoFocus;

		// Token: 0x04001733 RID: 5939
		internal static int __PropertyOffset_LightEstimationMode;

		// Token: 0x04001734 RID: 5940
		internal static int __PropertyOffset_FrameSyncMode;

		// Token: 0x04001735 RID: 5941
		internal static int __PropertyOffset_bEnableAutomaticCameraOverlay;

		// Token: 0x04001736 RID: 5942
		internal static int __PropertyOffset_bEnableAutomaticCameraTracking;

		// Token: 0x04001737 RID: 5943
		internal static int __PropertyOffset_bResetCameraTracking;

		// Token: 0x04001738 RID: 5944
		internal static int __PropertyOffset_bResetTrackedObjects;

		// Token: 0x04001739 RID: 5945
		internal static int __PropertyOffset_CandidateImages;

		// Token: 0x0400173A RID: 5946
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UARCandidateImage> _CandidateImages;

		// Token: 0x0400173B RID: 5947
		internal static int __PropertyOffset_MaxNumSimultaneousImagesTracked;

		// Token: 0x0400173C RID: 5948
		internal static int __PropertyOffset_EnvironmentCaptureProbeType;

		// Token: 0x0400173D RID: 5949
		internal static int __PropertyOffset_WorldMapData;

		// Token: 0x0400173E RID: 5950
		[Nullable(2)]
		private TArray<byte> _WorldMapData;

		// Token: 0x0400173F RID: 5951
		internal static int __PropertyOffset_CandidateObjects;

		// Token: 0x04001740 RID: 5952
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UARCandidateObject> _CandidateObjects;

		// Token: 0x04001741 RID: 5953
		internal static int __PropertyOffset_DesiredVideoFormat;

		// Token: 0x04001742 RID: 5954
		[Nullable(2)]
		private FARVideoFormat _DesiredVideoFormat;

		// Token: 0x04001743 RID: 5955
		internal static int __PropertyOffset_bUseOptimalVideoFormat;

		// Token: 0x04001744 RID: 5956
		internal static int __PropertyOffset_FaceTrackingDirection;

		// Token: 0x04001745 RID: 5957
		internal static int __PropertyOffset_FaceTrackingUpdate;

		// Token: 0x04001746 RID: 5958
		internal static int __PropertyOffset_MaxNumberOfTrackedFaces;

		// Token: 0x04001747 RID: 5959
		internal static int __PropertyOffset_SerializedARCandidateImageDatabase;

		// Token: 0x04001748 RID: 5960
		[Nullable(2)]
		private TArray<byte> _SerializedARCandidateImageDatabase;

		// Token: 0x04001749 RID: 5961
		internal static int __PropertyOffset_EnabledSessionTrackingFeature;

		// Token: 0x0400174A RID: 5962
		internal static int __PropertyOffset_SceneReconstructionMethod;

		// Token: 0x0400174B RID: 5963
		internal static int __PropertyOffset_PlaneComponentClass;

		// Token: 0x0400174C RID: 5964
		internal static int __PropertyOffset_PointComponentClass;

		// Token: 0x0400174D RID: 5965
		internal static int __PropertyOffset_FaceComponentClass;

		// Token: 0x0400174E RID: 5966
		internal static int __PropertyOffset_ImageComponentClass;

		// Token: 0x0400174F RID: 5967
		internal static int __PropertyOffset_QRCodeComponentClass;

		// Token: 0x04001750 RID: 5968
		internal static int __PropertyOffset_PoseComponentClass;

		// Token: 0x04001751 RID: 5969
		internal static int __PropertyOffset_EnvironmentProbeComponentClass;

		// Token: 0x04001752 RID: 5970
		internal static int __PropertyOffset_ObjectComponentClass;

		// Token: 0x04001753 RID: 5971
		internal static int __PropertyOffset_MeshComponentClass;

		// Token: 0x04001754 RID: 5972
		internal static int __PropertyOffset_GeoAnchorComponentClass;

		// Token: 0x04001755 RID: 5973
		internal static int __PropertyOffset_DefaultMeshMaterial;

		// Token: 0x04001756 RID: 5974
		internal static int __PropertyOffset_DefaultWireframeMeshMaterial;
	}
}
