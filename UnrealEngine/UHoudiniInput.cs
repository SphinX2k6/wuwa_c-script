using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014C8 RID: 5320
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInput")]
	[UnrealStructLayout(768, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 768)]
	public class UHoudiniInput : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601341E RID: 78878 RVA: 0x001C5190 File Offset: 0x001C3390
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInput._ClassPtr;
		}

		// Token: 0x0601341F RID: 78879 RVA: 0x001C519C File Offset: 0x001C339C
		public UHoudiniInput() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013420 RID: 78880 RVA: 0x001C51C4 File Offset: 0x001C33C4
		public UHoudiniInput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004AED RID: 19181
		// (get) Token: 0x06013421 RID: 78881 RVA: 0x001C51F7 File Offset: 0x001C33F7
		// (set) Token: 0x06013422 RID: 78882 RVA: 0x001C520B File Offset: 0x001C340B
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniInput.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniInput.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17004AEE RID: 19182
		// (get) Token: 0x06013423 RID: 78883 RVA: 0x001C5220 File Offset: 0x001C3420
		// (set) Token: 0x06013424 RID: 78884 RVA: 0x001C5234 File Offset: 0x001C3434
		public unsafe string Label
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniInput.__PropertyOffset_Label)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniInput.__PropertyOffset_Label)), value);
			}
		}

		// Token: 0x17004AEF RID: 19183
		// (get) Token: 0x06013425 RID: 78885 RVA: 0x001C5249 File Offset: 0x001C3449
		// (set) Token: 0x06013426 RID: 78886 RVA: 0x001C5259 File Offset: 0x001C3459
		public unsafe EHoudiniInputType Type
		{
			get
			{
				return (EHoudiniInputType)(*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17004AF0 RID: 19184
		// (get) Token: 0x06013427 RID: 78887 RVA: 0x001C526A File Offset: 0x001C346A
		// (set) Token: 0x06013428 RID: 78888 RVA: 0x001C527A File Offset: 0x001C347A
		public unsafe EHoudiniInputType PreviousType
		{
			get
			{
				return (EHoudiniInputType)(*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_PreviousType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_PreviousType) = (byte)value;
			}
		}

		// Token: 0x17004AF1 RID: 19185
		// (get) Token: 0x06013429 RID: 78889 RVA: 0x001C528B File Offset: 0x001C348B
		// (set) Token: 0x0601342A RID: 78890 RVA: 0x001C529B File Offset: 0x001C349B
		public unsafe int AssetNodeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_AssetNodeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_AssetNodeId) = value;
			}
		}

		// Token: 0x17004AF2 RID: 19186
		// (get) Token: 0x0601342B RID: 78891 RVA: 0x001C52AC File Offset: 0x001C34AC
		// (set) Token: 0x0601342C RID: 78892 RVA: 0x001C52BC File Offset: 0x001C34BC
		public unsafe int InputNodeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_InputNodeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_InputNodeId) = value;
			}
		}

		// Token: 0x17004AF3 RID: 19187
		// (get) Token: 0x0601342D RID: 78893 RVA: 0x001C52CD File Offset: 0x001C34CD
		// (set) Token: 0x0601342E RID: 78894 RVA: 0x001C52DD File Offset: 0x001C34DD
		public unsafe int InputIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_InputIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_InputIndex) = value;
			}
		}

		// Token: 0x17004AF4 RID: 19188
		// (get) Token: 0x0601342F RID: 78895 RVA: 0x001C52EE File Offset: 0x001C34EE
		// (set) Token: 0x06013430 RID: 78896 RVA: 0x001C52FE File Offset: 0x001C34FE
		public unsafe int ParmId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_ParmId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_ParmId) = value;
			}
		}

		// Token: 0x17004AF5 RID: 19189
		// (get) Token: 0x06013431 RID: 78897 RVA: 0x001C530F File Offset: 0x001C350F
		// (set) Token: 0x06013432 RID: 78898 RVA: 0x001C531F File Offset: 0x001C351F
		public unsafe bool bIsObjectPathParameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bIsObjectPathParameter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bIsObjectPathParameter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AF6 RID: 19190
		// (get) Token: 0x06013433 RID: 78899 RVA: 0x001C5330 File Offset: 0x001C3530
		// (set) Token: 0x06013434 RID: 78900 RVA: 0x001C5369 File Offset: 0x001C3569
		public TArray<int> CreatedDataNodeIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._CreatedDataNodeIds) == null)
				{
					result = (this._CreatedDataNodeIds = new TArray<int>(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_CreatedDataNodeIds, this));
				}
				return result;
			}
			set
			{
				this.CreatedDataNodeIds.CopyAssign(value);
			}
		}

		// Token: 0x17004AF7 RID: 19191
		// (get) Token: 0x06013435 RID: 78901 RVA: 0x001C5377 File Offset: 0x001C3577
		// (set) Token: 0x06013436 RID: 78902 RVA: 0x001C5387 File Offset: 0x001C3587
		public unsafe bool bHasChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bHasChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bHasChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AF8 RID: 19192
		// (get) Token: 0x06013437 RID: 78903 RVA: 0x001C5398 File Offset: 0x001C3598
		// (set) Token: 0x06013438 RID: 78904 RVA: 0x001C53A8 File Offset: 0x001C35A8
		public unsafe bool bNeedsToTriggerUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bNeedsToTriggerUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bNeedsToTriggerUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AF9 RID: 19193
		// (get) Token: 0x06013439 RID: 78905 RVA: 0x001C53B9 File Offset: 0x001C35B9
		// (set) Token: 0x0601343A RID: 78906 RVA: 0x001C53CD File Offset: 0x001C35CD
		public unsafe string Help
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniInput.__PropertyOffset_Help)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniInput.__PropertyOffset_Help)), value);
			}
		}

		// Token: 0x17004AFA RID: 19194
		// (get) Token: 0x0601343B RID: 78907 RVA: 0x001C53E2 File Offset: 0x001C35E2
		// (set) Token: 0x0601343C RID: 78908 RVA: 0x001C53F2 File Offset: 0x001C35F2
		public unsafe EHoudiniXformType KeepWorldTransform
		{
			get
			{
				return (EHoudiniXformType)(*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_KeepWorldTransform));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_KeepWorldTransform) = (byte)value;
			}
		}

		// Token: 0x17004AFB RID: 19195
		// (get) Token: 0x0601343D RID: 78909 RVA: 0x001C5403 File Offset: 0x001C3603
		// (set) Token: 0x0601343E RID: 78910 RVA: 0x001C5413 File Offset: 0x001C3613
		public unsafe bool bPackBeforeMerge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bPackBeforeMerge) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bPackBeforeMerge) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AFC RID: 19196
		// (get) Token: 0x0601343F RID: 78911 RVA: 0x001C5424 File Offset: 0x001C3624
		// (set) Token: 0x06013440 RID: 78912 RVA: 0x001C5434 File Offset: 0x001C3634
		public unsafe bool bImportAsReference
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bImportAsReference) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bImportAsReference) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AFD RID: 19197
		// (get) Token: 0x06013441 RID: 78913 RVA: 0x001C5445 File Offset: 0x001C3645
		// (set) Token: 0x06013442 RID: 78914 RVA: 0x001C5455 File Offset: 0x001C3655
		public unsafe bool bImportAsReferenceRotScaleEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bImportAsReferenceRotScaleEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bImportAsReferenceRotScaleEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AFE RID: 19198
		// (get) Token: 0x06013443 RID: 78915 RVA: 0x001C5466 File Offset: 0x001C3666
		// (set) Token: 0x06013444 RID: 78916 RVA: 0x001C5476 File Offset: 0x001C3676
		public unsafe bool bImportAsReferenceBboxEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bImportAsReferenceBboxEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bImportAsReferenceBboxEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AFF RID: 19199
		// (get) Token: 0x06013445 RID: 78917 RVA: 0x001C5487 File Offset: 0x001C3687
		// (set) Token: 0x06013446 RID: 78918 RVA: 0x001C5497 File Offset: 0x001C3697
		public unsafe bool bImportAsReferenceMaterialEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bImportAsReferenceMaterialEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bImportAsReferenceMaterialEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B00 RID: 19200
		// (get) Token: 0x06013447 RID: 78919 RVA: 0x001C54A8 File Offset: 0x001C36A8
		// (set) Token: 0x06013448 RID: 78920 RVA: 0x001C54B8 File Offset: 0x001C36B8
		public unsafe bool bExportLODs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bExportLODs) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bExportLODs) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B01 RID: 19201
		// (get) Token: 0x06013449 RID: 78921 RVA: 0x001C54C9 File Offset: 0x001C36C9
		// (set) Token: 0x0601344A RID: 78922 RVA: 0x001C54D9 File Offset: 0x001C36D9
		public unsafe bool bExportSockets
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bExportSockets) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bExportSockets) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B02 RID: 19202
		// (get) Token: 0x0601344B RID: 78923 RVA: 0x001C54EA File Offset: 0x001C36EA
		// (set) Token: 0x0601344C RID: 78924 RVA: 0x001C54FA File Offset: 0x001C36FA
		public unsafe bool bExportColliders
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bExportColliders) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bExportColliders) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B03 RID: 19203
		// (get) Token: 0x0601344D RID: 78925 RVA: 0x001C550B File Offset: 0x001C370B
		// (set) Token: 0x0601344E RID: 78926 RVA: 0x001C551B File Offset: 0x001C371B
		public unsafe bool bCookOnCurveChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bCookOnCurveChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bCookOnCurveChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B04 RID: 19204
		// (get) Token: 0x0601344F RID: 78927 RVA: 0x001C552C File Offset: 0x001C372C
		// (set) Token: 0x06013450 RID: 78928 RVA: 0x001C5565 File Offset: 0x001C3765
		public TArray<UHoudiniInputObject> GeometryInputObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniInputObject> result;
				if ((result = this._GeometryInputObjects) == null)
				{
					result = (this._GeometryInputObjects = new TArray<UHoudiniInputObject>(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_GeometryInputObjects, this));
				}
				return result;
			}
			set
			{
				this.GeometryInputObjects.CopyAssign(value);
			}
		}

		// Token: 0x17004B05 RID: 19205
		// (get) Token: 0x06013451 RID: 78929 RVA: 0x001C5573 File Offset: 0x001C3773
		// (set) Token: 0x06013452 RID: 78930 RVA: 0x001C5583 File Offset: 0x001C3783
		public unsafe bool bStaticMeshChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bStaticMeshChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bStaticMeshChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B06 RID: 19206
		// (get) Token: 0x06013453 RID: 78931 RVA: 0x001C5594 File Offset: 0x001C3794
		// (set) Token: 0x06013454 RID: 78932 RVA: 0x001C55CD File Offset: 0x001C37CD
		public TArray<UHoudiniInputObject> AssetInputObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniInputObject> result;
				if ((result = this._AssetInputObjects) == null)
				{
					result = (this._AssetInputObjects = new TArray<UHoudiniInputObject>(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_AssetInputObjects, this));
				}
				return result;
			}
			set
			{
				this.AssetInputObjects.CopyAssign(value);
			}
		}

		// Token: 0x17004B07 RID: 19207
		// (get) Token: 0x06013455 RID: 78933 RVA: 0x001C55DB File Offset: 0x001C37DB
		// (set) Token: 0x06013456 RID: 78934 RVA: 0x001C55EB File Offset: 0x001C37EB
		public unsafe bool bInputAssetConnectedInHoudini
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bInputAssetConnectedInHoudini) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bInputAssetConnectedInHoudini) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B08 RID: 19208
		// (get) Token: 0x06013457 RID: 78935 RVA: 0x001C55FC File Offset: 0x001C37FC
		// (set) Token: 0x06013458 RID: 78936 RVA: 0x001C5635 File Offset: 0x001C3835
		public TArray<UHoudiniInputObject> CurveInputObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniInputObject> result;
				if ((result = this._CurveInputObjects) == null)
				{
					result = (this._CurveInputObjects = new TArray<UHoudiniInputObject>(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_CurveInputObjects, this));
				}
				return result;
			}
			set
			{
				this.CurveInputObjects.CopyAssign(value);
			}
		}

		// Token: 0x17004B09 RID: 19209
		// (get) Token: 0x06013459 RID: 78937 RVA: 0x001C5643 File Offset: 0x001C3843
		// (set) Token: 0x0601345A RID: 78938 RVA: 0x001C5653 File Offset: 0x001C3853
		public unsafe float DefaultCurveOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_DefaultCurveOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_DefaultCurveOffset) = value;
			}
		}

		// Token: 0x17004B0A RID: 19210
		// (get) Token: 0x0601345B RID: 78939 RVA: 0x001C5664 File Offset: 0x001C3864
		// (set) Token: 0x0601345C RID: 78940 RVA: 0x001C5674 File Offset: 0x001C3874
		public unsafe bool bAddRotAndScaleAttributesOnCurves
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bAddRotAndScaleAttributesOnCurves) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bAddRotAndScaleAttributesOnCurves) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B0B RID: 19211
		// (get) Token: 0x0601345D RID: 78941 RVA: 0x001C5685 File Offset: 0x001C3885
		// (set) Token: 0x0601345E RID: 78942 RVA: 0x001C5695 File Offset: 0x001C3895
		public unsafe bool bUseLegacyInputCurves
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bUseLegacyInputCurves) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bUseLegacyInputCurves) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B0C RID: 19212
		// (get) Token: 0x0601345F RID: 78943 RVA: 0x001C56A8 File Offset: 0x001C38A8
		// (set) Token: 0x06013460 RID: 78944 RVA: 0x001C56E1 File Offset: 0x001C38E1
		public TArray<UHoudiniInputObject> LandscapeInputObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniInputObject> result;
				if ((result = this._LandscapeInputObjects) == null)
				{
					result = (this._LandscapeInputObjects = new TArray<UHoudiniInputObject>(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_LandscapeInputObjects, this));
				}
				return result;
			}
			set
			{
				this.LandscapeInputObjects.CopyAssign(value);
			}
		}

		// Token: 0x17004B0D RID: 19213
		// (get) Token: 0x06013461 RID: 78945 RVA: 0x001C56EF File Offset: 0x001C38EF
		// (set) Token: 0x06013462 RID: 78946 RVA: 0x001C56FF File Offset: 0x001C38FF
		public unsafe bool bLandscapeHasExportTypeChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bLandscapeHasExportTypeChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bLandscapeHasExportTypeChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B0E RID: 19214
		// (get) Token: 0x06013463 RID: 78947 RVA: 0x001C5710 File Offset: 0x001C3910
		// (set) Token: 0x06013464 RID: 78948 RVA: 0x001C5749 File Offset: 0x001C3949
		public TArray<UHoudiniInputObject> WorldInputObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniInputObject> result;
				if ((result = this._WorldInputObjects) == null)
				{
					result = (this._WorldInputObjects = new TArray<UHoudiniInputObject>(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_WorldInputObjects, this));
				}
				return result;
			}
			set
			{
				this.WorldInputObjects.CopyAssign(value);
			}
		}

		// Token: 0x17004B0F RID: 19215
		// (get) Token: 0x06013465 RID: 78949 RVA: 0x001C5758 File Offset: 0x001C3958
		// (set) Token: 0x06013466 RID: 78950 RVA: 0x001C5791 File Offset: 0x001C3991
		public TArray<AActor> WorldInputBoundSelectorObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._WorldInputBoundSelectorObjects) == null)
				{
					result = (this._WorldInputBoundSelectorObjects = new TArray<AActor>(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_WorldInputBoundSelectorObjects, this));
				}
				return result;
			}
			set
			{
				this.WorldInputBoundSelectorObjects.CopyAssign(value);
			}
		}

		// Token: 0x17004B10 RID: 19216
		// (get) Token: 0x06013467 RID: 78951 RVA: 0x001C579F File Offset: 0x001C399F
		// (set) Token: 0x06013468 RID: 78952 RVA: 0x001C57AF File Offset: 0x001C39AF
		public unsafe bool bIsWorldInputBoundSelector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bIsWorldInputBoundSelector) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bIsWorldInputBoundSelector) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B11 RID: 19217
		// (get) Token: 0x06013469 RID: 78953 RVA: 0x001C57C0 File Offset: 0x001C39C0
		// (set) Token: 0x0601346A RID: 78954 RVA: 0x001C57D0 File Offset: 0x001C39D0
		public unsafe bool bWorldInputBoundSelectorAutoUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bWorldInputBoundSelectorAutoUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bWorldInputBoundSelectorAutoUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B12 RID: 19218
		// (get) Token: 0x0601346B RID: 78955 RVA: 0x001C57E1 File Offset: 0x001C39E1
		// (set) Token: 0x0601346C RID: 78956 RVA: 0x001C57F1 File Offset: 0x001C39F1
		public unsafe float UnrealSplineResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_UnrealSplineResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_UnrealSplineResolution) = value;
			}
		}

		// Token: 0x17004B13 RID: 19219
		// (get) Token: 0x0601346D RID: 78957 RVA: 0x001C5804 File Offset: 0x001C3A04
		// (set) Token: 0x0601346E RID: 78958 RVA: 0x001C583D File Offset: 0x001C3A3D
		public TArray<UHoudiniInputObject> SkeletalInputObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniInputObject> result;
				if ((result = this._SkeletalInputObjects) == null)
				{
					result = (this._SkeletalInputObjects = new TArray<UHoudiniInputObject>(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_SkeletalInputObjects, this));
				}
				return result;
			}
			set
			{
				this.SkeletalInputObjects.CopyAssign(value);
			}
		}

		// Token: 0x17004B14 RID: 19220
		// (get) Token: 0x0601346F RID: 78959 RVA: 0x001C584C File Offset: 0x001C3A4C
		// (set) Token: 0x06013470 RID: 78960 RVA: 0x001C5885 File Offset: 0x001C3A85
		public TArray<UHoudiniInputObject> GeometryCollectionInputObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniInputObject> result;
				if ((result = this._GeometryCollectionInputObjects) == null)
				{
					result = (this._GeometryCollectionInputObjects = new TArray<UHoudiniInputObject>(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_GeometryCollectionInputObjects, this));
				}
				return result;
			}
			set
			{
				this.GeometryCollectionInputObjects.CopyAssign(value);
			}
		}

		// Token: 0x17004B15 RID: 19221
		// (get) Token: 0x06013471 RID: 78961 RVA: 0x001C5894 File Offset: 0x001C3A94
		// (set) Token: 0x06013472 RID: 78962 RVA: 0x001C58CD File Offset: 0x001C3ACD
		public TSet<ULandscapeComponent> LandscapeSelectedComponents
		{
			get
			{
				base.FastCheckIsValid();
				TSet<ULandscapeComponent> result;
				if ((result = this._LandscapeSelectedComponents) == null)
				{
					result = (this._LandscapeSelectedComponents = new TSet<ULandscapeComponent>(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_LandscapeSelectedComponents, this));
				}
				return result;
			}
			set
			{
				this.LandscapeSelectedComponents.CopyAssign(value);
			}
		}

		// Token: 0x17004B16 RID: 19222
		// (get) Token: 0x06013473 RID: 78963 RVA: 0x001C58DC File Offset: 0x001C3ADC
		// (set) Token: 0x06013474 RID: 78964 RVA: 0x001C5915 File Offset: 0x001C3B15
		public TSet<int> InputNodesPendingDelete
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._InputNodesPendingDelete) == null)
				{
					result = (this._InputNodesPendingDelete = new TSet<int>(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_InputNodesPendingDelete, this));
				}
				return result;
			}
			set
			{
				this.InputNodesPendingDelete.CopyAssign(value);
			}
		}

		// Token: 0x17004B17 RID: 19223
		// (get) Token: 0x06013475 RID: 78965 RVA: 0x001C5924 File Offset: 0x001C3B24
		// (set) Token: 0x06013476 RID: 78966 RVA: 0x001C595D File Offset: 0x001C3B5D
		public TArray<UHoudiniInputHoudiniSplineComponent> LastInsertedInputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniInputHoudiniSplineComponent> result;
				if ((result = this._LastInsertedInputs) == null)
				{
					result = (this._LastInsertedInputs = new TArray<UHoudiniInputHoudiniSplineComponent>(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_LastInsertedInputs, this));
				}
				return result;
			}
			set
			{
				this.LastInsertedInputs.CopyAssign(value);
			}
		}

		// Token: 0x17004B18 RID: 19224
		// (get) Token: 0x06013477 RID: 78967 RVA: 0x001C596C File Offset: 0x001C3B6C
		// (set) Token: 0x06013478 RID: 78968 RVA: 0x001C59A5 File Offset: 0x001C3BA5
		public TArray<UHoudiniInputObject> LastUndoDeletedInputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniInputObject> result;
				if ((result = this._LastUndoDeletedInputs) == null)
				{
					result = (this._LastUndoDeletedInputs = new TArray<UHoudiniInputObject>(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_LastUndoDeletedInputs, this));
				}
				return result;
			}
			set
			{
				this.LastUndoDeletedInputs.CopyAssign(value);
			}
		}

		// Token: 0x17004B19 RID: 19225
		// (get) Token: 0x06013479 RID: 78969 RVA: 0x001C59B3 File Offset: 0x001C3BB3
		// (set) Token: 0x0601347A RID: 78970 RVA: 0x001C59C3 File Offset: 0x001C3BC3
		public unsafe bool bUpdateInputLandscape
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bUpdateInputLandscape) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bUpdateInputLandscape) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B1A RID: 19226
		// (get) Token: 0x0601347B RID: 78971 RVA: 0x001C59D4 File Offset: 0x001C3BD4
		// (set) Token: 0x0601347C RID: 78972 RVA: 0x001C59E4 File Offset: 0x001C3BE4
		public unsafe EHoudiniLandscapeExportType LandscapeExportType
		{
			get
			{
				return (EHoudiniLandscapeExportType)(*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_LandscapeExportType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_LandscapeExportType) = (byte)value;
			}
		}

		// Token: 0x17004B1B RID: 19227
		// (get) Token: 0x0601347D RID: 78973 RVA: 0x001C59F5 File Offset: 0x001C3BF5
		// (set) Token: 0x0601347E RID: 78974 RVA: 0x001C5A05 File Offset: 0x001C3C05
		public unsafe bool bLandscapeExportSelectionOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bLandscapeExportSelectionOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bLandscapeExportSelectionOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B1C RID: 19228
		// (get) Token: 0x0601347F RID: 78975 RVA: 0x001C5A16 File Offset: 0x001C3C16
		// (set) Token: 0x06013480 RID: 78976 RVA: 0x001C5A26 File Offset: 0x001C3C26
		public unsafe bool bLandscapeAutoSelectComponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bLandscapeAutoSelectComponent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bLandscapeAutoSelectComponent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B1D RID: 19229
		// (get) Token: 0x06013481 RID: 78977 RVA: 0x001C5A37 File Offset: 0x001C3C37
		// (set) Token: 0x06013482 RID: 78978 RVA: 0x001C5A47 File Offset: 0x001C3C47
		public unsafe bool bLandscapeExportMaterials
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bLandscapeExportMaterials) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bLandscapeExportMaterials) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B1E RID: 19230
		// (get) Token: 0x06013483 RID: 78979 RVA: 0x001C5A58 File Offset: 0x001C3C58
		// (set) Token: 0x06013484 RID: 78980 RVA: 0x001C5A68 File Offset: 0x001C3C68
		public unsafe bool bLandscapeExportLighting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bLandscapeExportLighting) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bLandscapeExportLighting) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B1F RID: 19231
		// (get) Token: 0x06013485 RID: 78981 RVA: 0x001C5A79 File Offset: 0x001C3C79
		// (set) Token: 0x06013486 RID: 78982 RVA: 0x001C5A89 File Offset: 0x001C3C89
		public unsafe bool bLandscapeExportNormalizedUVs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bLandscapeExportNormalizedUVs) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bLandscapeExportNormalizedUVs) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B20 RID: 19232
		// (get) Token: 0x06013487 RID: 78983 RVA: 0x001C5A9A File Offset: 0x001C3C9A
		// (set) Token: 0x06013488 RID: 78984 RVA: 0x001C5AAA File Offset: 0x001C3CAA
		public unsafe bool bLandscapeExportTileUVs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bLandscapeExportTileUVs) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bLandscapeExportTileUVs) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B21 RID: 19233
		// (get) Token: 0x06013489 RID: 78985 RVA: 0x001C5ABB File Offset: 0x001C3CBB
		// (set) Token: 0x0601348A RID: 78986 RVA: 0x001C5ACB File Offset: 0x001C3CCB
		public unsafe bool bCanDeleteHoudiniNodes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bCanDeleteHoudiniNodes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bCanDeleteHoudiniNodes) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B22 RID: 19234
		// (get) Token: 0x0601348B RID: 78987 RVA: 0x001C5ADC File Offset: 0x001C3CDC
		// (set) Token: 0x0601348C RID: 78988 RVA: 0x001C5AEC File Offset: 0x001C3CEC
		public unsafe bool bIsWorldInputSelectByFolder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bIsWorldInputSelectByFolder) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bIsWorldInputSelectByFolder) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B23 RID: 19235
		// (get) Token: 0x0601348D RID: 78989 RVA: 0x001C5AFD File Offset: 0x001C3CFD
		// (set) Token: 0x0601348E RID: 78990 RVA: 0x001C5B0D File Offset: 0x001C3D0D
		public unsafe bool bIsOnlyInputStaticMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bIsOnlyInputStaticMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bIsOnlyInputStaticMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B24 RID: 19236
		// (get) Token: 0x0601348F RID: 78991 RVA: 0x001C5B20 File Offset: 0x001C3D20
		// (set) Token: 0x06013490 RID: 78992 RVA: 0x001C5B59 File Offset: 0x001C3D59
		public TArray<UObject> WorldInputAssetSelectorObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._WorldInputAssetSelectorObjects) == null)
				{
					result = (this._WorldInputAssetSelectorObjects = new TArray<UObject>(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_WorldInputAssetSelectorObjects, this));
				}
				return result;
			}
			set
			{
				this.WorldInputAssetSelectorObjects.CopyAssign(value);
			}
		}

		// Token: 0x17004B25 RID: 19237
		// (get) Token: 0x06013491 RID: 78993 RVA: 0x001C5B68 File Offset: 0x001C3D68
		// (set) Token: 0x06013492 RID: 78994 RVA: 0x001C5BA1 File Offset: 0x001C3DA1
		public TArray<string> WorldInputTagSelectorObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._WorldInputTagSelectorObjects) == null)
				{
					result = (this._WorldInputTagSelectorObjects = new TArray<string>(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_WorldInputTagSelectorObjects, this));
				}
				return result;
			}
			set
			{
				this.WorldInputTagSelectorObjects.CopyAssign(value);
			}
		}

		// Token: 0x17004B26 RID: 19238
		// (get) Token: 0x06013493 RID: 78995 RVA: 0x001C5BAF File Offset: 0x001C3DAF
		// (set) Token: 0x06013494 RID: 78996 RVA: 0x001C5BBF File Offset: 0x001C3DBF
		public unsafe bool bIsCustomStaticMeshInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bIsCustomStaticMeshInput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bIsCustomStaticMeshInput) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B27 RID: 19239
		// (get) Token: 0x06013495 RID: 78997 RVA: 0x001C5BD0 File Offset: 0x001C3DD0
		// (set) Token: 0x06013496 RID: 78998 RVA: 0x001C5C09 File Offset: 0x001C3E09
		public FKuroHDAMeshInputConfig MeshInputConfig
		{
			get
			{
				base.FastCheckIsValid();
				FKuroHDAMeshInputConfig result;
				if ((result = this._MeshInputConfig) == null)
				{
					result = (this._MeshInputConfig = new FKuroHDAMeshInputConfig(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_MeshInputConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroHDAMeshInputConfig.StaticStruct(), base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_MeshInputConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004B28 RID: 19240
		// (get) Token: 0x06013497 RID: 78999 RVA: 0x001C5C2C File Offset: 0x001C3E2C
		// (set) Token: 0x06013498 RID: 79000 RVA: 0x001C5C65 File Offset: 0x001C3E65
		public TMap<AActor, string> KuroSplineJsonStrings
		{
			get
			{
				base.FastCheckIsValid();
				TMap<AActor, string> result;
				if ((result = this._KuroSplineJsonStrings) == null)
				{
					result = (this._KuroSplineJsonStrings = new TMap<AActor, string>(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_KuroSplineJsonStrings, this));
				}
				return result;
			}
			set
			{
				this.KuroSplineJsonStrings.CopyAssign(value);
			}
		}

		// Token: 0x17004B29 RID: 19241
		// (get) Token: 0x06013499 RID: 79001 RVA: 0x001C5C74 File Offset: 0x001C3E74
		// (set) Token: 0x0601349A RID: 79002 RVA: 0x001C5CAD File Offset: 0x001C3EAD
		public TArray<string> SelectedFolderCache
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SelectedFolderCache) == null)
				{
					result = (this._SelectedFolderCache = new TArray<string>(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_SelectedFolderCache, this));
				}
				return result;
			}
			set
			{
				this.SelectedFolderCache.CopyAssign(value);
			}
		}

		// Token: 0x17004B2A RID: 19242
		// (get) Token: 0x0601349B RID: 79003 RVA: 0x001C5CBB File Offset: 0x001C3EBB
		// (set) Token: 0x0601349C RID: 79004 RVA: 0x001C5CCB File Offset: 0x001C3ECB
		public unsafe bool bIsInputWhiteBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bIsInputWhiteBox) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bIsInputWhiteBox) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B2B RID: 19243
		// (get) Token: 0x0601349D RID: 79005 RVA: 0x001C5CDC File Offset: 0x001C3EDC
		// (set) Token: 0x0601349E RID: 79006 RVA: 0x001C5CEC File Offset: 0x001C3EEC
		public unsafe bool bIsInputStaticMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bIsInputStaticMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bIsInputStaticMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B2C RID: 19244
		// (get) Token: 0x0601349F RID: 79007 RVA: 0x001C5CFD File Offset: 0x001C3EFD
		// (set) Token: 0x060134A0 RID: 79008 RVA: 0x001C5D0D File Offset: 0x001C3F0D
		public unsafe bool bIsInputLandscape
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bIsInputLandscape) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bIsInputLandscape) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B2D RID: 19245
		// (get) Token: 0x060134A1 RID: 79009 RVA: 0x001C5D1E File Offset: 0x001C3F1E
		// (set) Token: 0x060134A2 RID: 79010 RVA: 0x001C5D2E File Offset: 0x001C3F2E
		public unsafe bool bIsInputSpline
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bIsInputSpline) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_bIsInputSpline) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B2E RID: 19246
		// (get) Token: 0x060134A3 RID: 79011 RVA: 0x001C5D3F File Offset: 0x001C3F3F
		// (set) Token: 0x060134A4 RID: 79012 RVA: 0x001C5D53 File Offset: 0x001C3F53
		public unsafe string WhiteBoxTag
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniInput.__PropertyOffset_WhiteBoxTag)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniInput.__PropertyOffset_WhiteBoxTag)), value);
			}
		}

		// Token: 0x17004B2F RID: 19247
		// (get) Token: 0x060134A5 RID: 79013 RVA: 0x001C5D68 File Offset: 0x001C3F68
		// (set) Token: 0x060134A6 RID: 79014 RVA: 0x001C5D7C File Offset: 0x001C3F7C
		public unsafe string LandscapeTag
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniInput.__PropertyOffset_LandscapeTag)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniInput.__PropertyOffset_LandscapeTag)), value);
			}
		}

		// Token: 0x17004B30 RID: 19248
		// (get) Token: 0x060134A7 RID: 79015 RVA: 0x001C5D91 File Offset: 0x001C3F91
		// (set) Token: 0x060134A8 RID: 79016 RVA: 0x001C5DA5 File Offset: 0x001C3FA5
		public unsafe string SplineTag
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniInput.__PropertyOffset_SplineTag)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniInput.__PropertyOffset_SplineTag)), value);
			}
		}

		// Token: 0x17004B31 RID: 19249
		// (get) Token: 0x060134A9 RID: 79017 RVA: 0x001C5DBA File Offset: 0x001C3FBA
		// (set) Token: 0x060134AA RID: 79018 RVA: 0x001C5DCA File Offset: 0x001C3FCA
		public unsafe bool OnlyInputHeightField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_OnlyInputHeightField) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_OnlyInputHeightField) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B32 RID: 19250
		// (get) Token: 0x060134AB RID: 79019 RVA: 0x001C5DDB File Offset: 0x001C3FDB
		// (set) Token: 0x060134AC RID: 79020 RVA: 0x001C5DEB File Offset: 0x001C3FEB
		public unsafe EHoudiniPCGSplineType InputSplineType
		{
			get
			{
				return (EHoudiniPCGSplineType)(*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_InputSplineType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInput.__PropertyOffset_InputSplineType) = (byte)value;
			}
		}

		// Token: 0x060134AD RID: 79021 RVA: 0x001C5DFC File Offset: 0x001C3FFC
		static UHoudiniInput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInput");
		}

		// Token: 0x060134AE RID: 79022 RVA: 0x001C5E0A File Offset: 0x001C400A
		protected UHoudiniInput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A65B RID: 42587
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInput";

		// Token: 0x0400A65C RID: 42588
		private static IntPtr _ClassPtr;

		// Token: 0x0400A65D RID: 42589
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A65E RID: 42590
		internal static int __PropertyOffset_Name;

		// Token: 0x0400A65F RID: 42591
		internal static int __PropertyOffset_Label;

		// Token: 0x0400A660 RID: 42592
		internal static int __PropertyOffset_Type;

		// Token: 0x0400A661 RID: 42593
		internal static int __PropertyOffset_PreviousType;

		// Token: 0x0400A662 RID: 42594
		internal static int __PropertyOffset_AssetNodeId;

		// Token: 0x0400A663 RID: 42595
		internal static int __PropertyOffset_InputNodeId;

		// Token: 0x0400A664 RID: 42596
		internal static int __PropertyOffset_InputIndex;

		// Token: 0x0400A665 RID: 42597
		internal static int __PropertyOffset_ParmId;

		// Token: 0x0400A666 RID: 42598
		internal static int __PropertyOffset_bIsObjectPathParameter;

		// Token: 0x0400A667 RID: 42599
		internal static int __PropertyOffset_CreatedDataNodeIds;

		// Token: 0x0400A668 RID: 42600
		[Nullable(2)]
		private TArray<int> _CreatedDataNodeIds;

		// Token: 0x0400A669 RID: 42601
		internal static int __PropertyOffset_bHasChanged;

		// Token: 0x0400A66A RID: 42602
		internal static int __PropertyOffset_bNeedsToTriggerUpdate;

		// Token: 0x0400A66B RID: 42603
		internal static int __PropertyOffset_Help;

		// Token: 0x0400A66C RID: 42604
		internal static int __PropertyOffset_KeepWorldTransform;

		// Token: 0x0400A66D RID: 42605
		internal static int __PropertyOffset_bPackBeforeMerge;

		// Token: 0x0400A66E RID: 42606
		internal static int __PropertyOffset_bImportAsReference;

		// Token: 0x0400A66F RID: 42607
		internal static int __PropertyOffset_bImportAsReferenceRotScaleEnabled;

		// Token: 0x0400A670 RID: 42608
		internal static int __PropertyOffset_bImportAsReferenceBboxEnabled;

		// Token: 0x0400A671 RID: 42609
		internal static int __PropertyOffset_bImportAsReferenceMaterialEnabled;

		// Token: 0x0400A672 RID: 42610
		internal static int __PropertyOffset_bExportLODs;

		// Token: 0x0400A673 RID: 42611
		internal static int __PropertyOffset_bExportSockets;

		// Token: 0x0400A674 RID: 42612
		internal static int __PropertyOffset_bExportColliders;

		// Token: 0x0400A675 RID: 42613
		internal static int __PropertyOffset_bCookOnCurveChanged;

		// Token: 0x0400A676 RID: 42614
		internal static int __PropertyOffset_GeometryInputObjects;

		// Token: 0x0400A677 RID: 42615
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniInputObject> _GeometryInputObjects;

		// Token: 0x0400A678 RID: 42616
		internal static int __PropertyOffset_bStaticMeshChanged;

		// Token: 0x0400A679 RID: 42617
		internal static int __PropertyOffset_AssetInputObjects;

		// Token: 0x0400A67A RID: 42618
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniInputObject> _AssetInputObjects;

		// Token: 0x0400A67B RID: 42619
		internal static int __PropertyOffset_bInputAssetConnectedInHoudini;

		// Token: 0x0400A67C RID: 42620
		internal static int __PropertyOffset_CurveInputObjects;

		// Token: 0x0400A67D RID: 42621
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniInputObject> _CurveInputObjects;

		// Token: 0x0400A67E RID: 42622
		internal static int __PropertyOffset_DefaultCurveOffset;

		// Token: 0x0400A67F RID: 42623
		internal static int __PropertyOffset_bAddRotAndScaleAttributesOnCurves;

		// Token: 0x0400A680 RID: 42624
		internal static int __PropertyOffset_bUseLegacyInputCurves;

		// Token: 0x0400A681 RID: 42625
		internal static int __PropertyOffset_LandscapeInputObjects;

		// Token: 0x0400A682 RID: 42626
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniInputObject> _LandscapeInputObjects;

		// Token: 0x0400A683 RID: 42627
		internal static int __PropertyOffset_bLandscapeHasExportTypeChanged;

		// Token: 0x0400A684 RID: 42628
		internal static int __PropertyOffset_WorldInputObjects;

		// Token: 0x0400A685 RID: 42629
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniInputObject> _WorldInputObjects;

		// Token: 0x0400A686 RID: 42630
		internal static int __PropertyOffset_WorldInputBoundSelectorObjects;

		// Token: 0x0400A687 RID: 42631
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _WorldInputBoundSelectorObjects;

		// Token: 0x0400A688 RID: 42632
		internal static int __PropertyOffset_bIsWorldInputBoundSelector;

		// Token: 0x0400A689 RID: 42633
		internal static int __PropertyOffset_bWorldInputBoundSelectorAutoUpdate;

		// Token: 0x0400A68A RID: 42634
		internal static int __PropertyOffset_UnrealSplineResolution;

		// Token: 0x0400A68B RID: 42635
		internal static int __PropertyOffset_SkeletalInputObjects;

		// Token: 0x0400A68C RID: 42636
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniInputObject> _SkeletalInputObjects;

		// Token: 0x0400A68D RID: 42637
		internal static int __PropertyOffset_GeometryCollectionInputObjects;

		// Token: 0x0400A68E RID: 42638
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniInputObject> _GeometryCollectionInputObjects;

		// Token: 0x0400A68F RID: 42639
		internal static int __PropertyOffset_LandscapeSelectedComponents;

		// Token: 0x0400A690 RID: 42640
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<ULandscapeComponent> _LandscapeSelectedComponents;

		// Token: 0x0400A691 RID: 42641
		internal static int __PropertyOffset_InputNodesPendingDelete;

		// Token: 0x0400A692 RID: 42642
		[Nullable(2)]
		private TSet<int> _InputNodesPendingDelete;

		// Token: 0x0400A693 RID: 42643
		internal static int __PropertyOffset_LastInsertedInputs;

		// Token: 0x0400A694 RID: 42644
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniInputHoudiniSplineComponent> _LastInsertedInputs;

		// Token: 0x0400A695 RID: 42645
		internal static int __PropertyOffset_LastUndoDeletedInputs;

		// Token: 0x0400A696 RID: 42646
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniInputObject> _LastUndoDeletedInputs;

		// Token: 0x0400A697 RID: 42647
		internal static int __PropertyOffset_bUpdateInputLandscape;

		// Token: 0x0400A698 RID: 42648
		internal static int __PropertyOffset_LandscapeExportType;

		// Token: 0x0400A699 RID: 42649
		internal static int __PropertyOffset_bLandscapeExportSelectionOnly;

		// Token: 0x0400A69A RID: 42650
		internal static int __PropertyOffset_bLandscapeAutoSelectComponent;

		// Token: 0x0400A69B RID: 42651
		internal static int __PropertyOffset_bLandscapeExportMaterials;

		// Token: 0x0400A69C RID: 42652
		internal static int __PropertyOffset_bLandscapeExportLighting;

		// Token: 0x0400A69D RID: 42653
		internal static int __PropertyOffset_bLandscapeExportNormalizedUVs;

		// Token: 0x0400A69E RID: 42654
		internal static int __PropertyOffset_bLandscapeExportTileUVs;

		// Token: 0x0400A69F RID: 42655
		internal static int __PropertyOffset_bCanDeleteHoudiniNodes;

		// Token: 0x0400A6A0 RID: 42656
		internal static int __PropertyOffset_bIsWorldInputSelectByFolder;

		// Token: 0x0400A6A1 RID: 42657
		internal static int __PropertyOffset_bIsOnlyInputStaticMesh;

		// Token: 0x0400A6A2 RID: 42658
		internal static int __PropertyOffset_WorldInputAssetSelectorObjects;

		// Token: 0x0400A6A3 RID: 42659
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _WorldInputAssetSelectorObjects;

		// Token: 0x0400A6A4 RID: 42660
		internal static int __PropertyOffset_WorldInputTagSelectorObjects;

		// Token: 0x0400A6A5 RID: 42661
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _WorldInputTagSelectorObjects;

		// Token: 0x0400A6A6 RID: 42662
		internal static int __PropertyOffset_bIsCustomStaticMeshInput;

		// Token: 0x0400A6A7 RID: 42663
		internal static int __PropertyOffset_MeshInputConfig;

		// Token: 0x0400A6A8 RID: 42664
		[Nullable(2)]
		private FKuroHDAMeshInputConfig _MeshInputConfig;

		// Token: 0x0400A6A9 RID: 42665
		internal static int __PropertyOffset_KuroSplineJsonStrings;

		// Token: 0x0400A6AA RID: 42666
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<AActor, string> _KuroSplineJsonStrings;

		// Token: 0x0400A6AB RID: 42667
		internal static int __PropertyOffset_SelectedFolderCache;

		// Token: 0x0400A6AC RID: 42668
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SelectedFolderCache;

		// Token: 0x0400A6AD RID: 42669
		internal static int __PropertyOffset_bIsInputWhiteBox;

		// Token: 0x0400A6AE RID: 42670
		internal static int __PropertyOffset_bIsInputStaticMesh;

		// Token: 0x0400A6AF RID: 42671
		internal static int __PropertyOffset_bIsInputLandscape;

		// Token: 0x0400A6B0 RID: 42672
		internal static int __PropertyOffset_bIsInputSpline;

		// Token: 0x0400A6B1 RID: 42673
		internal static int __PropertyOffset_WhiteBoxTag;

		// Token: 0x0400A6B2 RID: 42674
		internal static int __PropertyOffset_LandscapeTag;

		// Token: 0x0400A6B3 RID: 42675
		internal static int __PropertyOffset_SplineTag;

		// Token: 0x0400A6B4 RID: 42676
		internal static int __PropertyOffset_OnlyInputHeightField;

		// Token: 0x0400A6B5 RID: 42677
		internal static int __PropertyOffset_InputSplineType;
	}
}
