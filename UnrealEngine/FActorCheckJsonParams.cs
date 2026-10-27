using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007AB RID: 1963
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ActorCheckJsonParams")]
	[UnrealStructLayout(1888, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1888)]
	public class FActorCheckJsonParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006864 RID: 26724 RVA: 0x00095512 File Offset: 0x00093712
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorCheckJsonParams._ScriptStructPtr != 0) ? FActorCheckJsonParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActorCheckJsonParams", ref FActorCheckJsonParams._ScriptStructPtr);
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x06006865 RID: 26725 RVA: 0x00095538 File Offset: 0x00093738
		// (set) Token: 0x06006866 RID: 26726 RVA: 0x0009557B File Offset: 0x0009377B
		public FActorCheckJsonParamsDetail Artist
		{
			get
			{
				base.FastCheckIsValid();
				FActorCheckJsonParamsDetail result;
				if ((result = this._Artist) == null)
				{
					result = (this._Artist = new FActorCheckJsonParamsDetail(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_Artist, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FActorCheckJsonParamsDetail.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_Artist, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x06006867 RID: 26727 RVA: 0x0009559C File Offset: 0x0009379C
		// (set) Token: 0x06006868 RID: 26728 RVA: 0x000955DF File Offset: 0x000937DF
		public FActorCheckJsonParamsDetail Designer
		{
			get
			{
				base.FastCheckIsValid();
				FActorCheckJsonParamsDetail result;
				if ((result = this._Designer) == null)
				{
					result = (this._Designer = new FActorCheckJsonParamsDetail(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_Designer, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FActorCheckJsonParamsDetail.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_Designer, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x06006869 RID: 26729 RVA: 0x00095600 File Offset: 0x00093800
		// (set) Token: 0x0600686A RID: 26730 RVA: 0x00095643 File Offset: 0x00093843
		public FActorCheckJsonParamsDetail Pcg
		{
			get
			{
				base.FastCheckIsValid();
				FActorCheckJsonParamsDetail result;
				if ((result = this._Pcg) == null)
				{
					result = (this._Pcg = new FActorCheckJsonParamsDetail(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_Pcg, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FActorCheckJsonParamsDetail.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_Pcg, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x0600686B RID: 26731 RVA: 0x00095664 File Offset: 0x00093864
		// (set) Token: 0x0600686C RID: 26732 RVA: 0x000956A7 File Offset: 0x000938A7
		public FActorCheckJsonParamsDetail Technology
		{
			get
			{
				base.FastCheckIsValid();
				FActorCheckJsonParamsDetail result;
				if ((result = this._Technology) == null)
				{
					result = (this._Technology = new FActorCheckJsonParamsDetail(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_Technology, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FActorCheckJsonParamsDetail.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_Technology, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x0600686D RID: 26733 RVA: 0x000956C8 File Offset: 0x000938C8
		// (set) Token: 0x0600686E RID: 26734 RVA: 0x0009570B File Offset: 0x0009390B
		public FActorCheckJsonParamsDetail EditorEntity
		{
			get
			{
				base.FastCheckIsValid();
				FActorCheckJsonParamsDetail result;
				if ((result = this._EditorEntity) == null)
				{
					result = (this._EditorEntity = new FActorCheckJsonParamsDetail(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_EditorEntity, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FActorCheckJsonParamsDetail.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_EditorEntity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x0600686F RID: 26735 RVA: 0x0009572C File Offset: 0x0009392C
		// (set) Token: 0x06006870 RID: 26736 RVA: 0x0009576F File Offset: 0x0009396F
		public FActorCheckJsonParamsDetail Audio
		{
			get
			{
				base.FastCheckIsValid();
				FActorCheckJsonParamsDetail result;
				if ((result = this._Audio) == null)
				{
					result = (this._Audio = new FActorCheckJsonParamsDetail(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_Audio, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FActorCheckJsonParamsDetail.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_Audio, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x06006871 RID: 26737 RVA: 0x00095790 File Offset: 0x00093990
		// (set) Token: 0x06006872 RID: 26738 RVA: 0x000957D3 File Offset: 0x000939D3
		public FSpecifiedClassRefCheck SpecifiedClassRefCheck
		{
			get
			{
				base.FastCheckIsValid();
				FSpecifiedClassRefCheck result;
				if ((result = this._SpecifiedClassRefCheck) == null)
				{
					result = (this._SpecifiedClassRefCheck = new FSpecifiedClassRefCheck(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_SpecifiedClassRefCheck, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpecifiedClassRefCheck.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_SpecifiedClassRefCheck, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x06006873 RID: 26739 RVA: 0x000957F4 File Offset: 0x000939F4
		// (set) Token: 0x06006874 RID: 26740 RVA: 0x00095837 File Offset: 0x00093A37
		public FHISMCullDistanceCheck HISMDistanceCheck
		{
			get
			{
				base.FastCheckIsValid();
				FHISMCullDistanceCheck result;
				if ((result = this._HISMDistanceCheck) == null)
				{
					result = (this._HISMDistanceCheck = new FHISMCullDistanceCheck(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_HISMDistanceCheck, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHISMCullDistanceCheck.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_HISMDistanceCheck, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x06006875 RID: 26741 RVA: 0x00095858 File Offset: 0x00093A58
		// (set) Token: 0x06006876 RID: 26742 RVA: 0x0009589B File Offset: 0x00093A9B
		public FLightCullDistanceCheck LightCullDistanceCheck
		{
			get
			{
				base.FastCheckIsValid();
				FLightCullDistanceCheck result;
				if ((result = this._LightCullDistanceCheck) == null)
				{
					result = (this._LightCullDistanceCheck = new FLightCullDistanceCheck(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_LightCullDistanceCheck, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLightCullDistanceCheck.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_LightCullDistanceCheck, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x06006877 RID: 26743 RVA: 0x000958BC File Offset: 0x00093ABC
		// (set) Token: 0x06006878 RID: 26744 RVA: 0x000958FF File Offset: 0x00093AFF
		public TArray<FLightCastShadowCheck> LightCastShadowCheck
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLightCastShadowCheck> result;
				if ((result = this._LightCastShadowCheck) == null)
				{
					result = (this._LightCastShadowCheck = new TArray<FLightCastShadowCheck>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_LightCastShadowCheck, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LightCastShadowCheck.CopyAssign(value);
			}
		}

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x06006879 RID: 26745 RVA: 0x0009590D File Offset: 0x00093B0D
		// (set) Token: 0x0600687A RID: 26746 RVA: 0x0009591D File Offset: 0x00093B1D
		public unsafe int OpenFarShadowRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_OpenFarShadowRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_OpenFarShadowRadius) = value;
			}
		}

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x0600687B RID: 26747 RVA: 0x00095930 File Offset: 0x00093B30
		// (set) Token: 0x0600687C RID: 26748 RVA: 0x00095973 File Offset: 0x00093B73
		public FMeshCastShadowCheck MeshCastShadowCheck
		{
			get
			{
				base.FastCheckIsValid();
				FMeshCastShadowCheck result;
				if ((result = this._MeshCastShadowCheck) == null)
				{
					result = (this._MeshCastShadowCheck = new FMeshCastShadowCheck(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_MeshCastShadowCheck, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMeshCastShadowCheck.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_MeshCastShadowCheck, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x0600687D RID: 26749 RVA: 0x00095994 File Offset: 0x00093B94
		// (set) Token: 0x0600687E RID: 26750 RVA: 0x000959A4 File Offset: 0x00093BA4
		public unsafe int ISMMinInstanceCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_ISMMinInstanceCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_ISMMinInstanceCount) = value;
			}
		}

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x0600687F RID: 26751 RVA: 0x000959B8 File Offset: 0x00093BB8
		// (set) Token: 0x06006880 RID: 26752 RVA: 0x000959FB File Offset: 0x00093BFB
		public FSpecifiedFolderPathCheck SpecifiedFolderPathCheck
		{
			get
			{
				base.FastCheckIsValid();
				FSpecifiedFolderPathCheck result;
				if ((result = this._SpecifiedFolderPathCheck) == null)
				{
					result = (this._SpecifiedFolderPathCheck = new FSpecifiedFolderPathCheck(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_SpecifiedFolderPathCheck, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpecifiedFolderPathCheck.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_SpecifiedFolderPathCheck, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x06006881 RID: 26753 RVA: 0x00095A1C File Offset: 0x00093C1C
		// (set) Token: 0x06006882 RID: 26754 RVA: 0x00095A5F File Offset: 0x00093C5F
		public FMeshRefCheck MeshRefCheck
		{
			get
			{
				base.FastCheckIsValid();
				FMeshRefCheck result;
				if ((result = this._MeshRefCheck) == null)
				{
					result = (this._MeshRefCheck = new FMeshRefCheck(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_MeshRefCheck, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMeshRefCheck.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_MeshRefCheck, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x06006883 RID: 26755 RVA: 0x00095A80 File Offset: 0x00093C80
		// (set) Token: 0x06006884 RID: 26756 RVA: 0x00095AC3 File Offset: 0x00093CC3
		public FSpecialPathCheck SpecialPathCheck
		{
			get
			{
				base.FastCheckIsValid();
				FSpecialPathCheck result;
				if ((result = this._SpecialPathCheck) == null)
				{
					result = (this._SpecialPathCheck = new FSpecialPathCheck(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_SpecialPathCheck, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpecialPathCheck.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_SpecialPathCheck, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x06006885 RID: 26757 RVA: 0x00095AE4 File Offset: 0x00093CE4
		// (set) Token: 0x06006886 RID: 26758 RVA: 0x00095B27 File Offset: 0x00093D27
		public FISMBoundCheck ISMBoundCheck
		{
			get
			{
				base.FastCheckIsValid();
				FISMBoundCheck result;
				if ((result = this._ISMBoundCheck) == null)
				{
					result = (this._ISMBoundCheck = new FISMBoundCheck(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_ISMBoundCheck, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FISMBoundCheck.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_ISMBoundCheck, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x06006887 RID: 26759 RVA: 0x00095B48 File Offset: 0x00093D48
		// (set) Token: 0x06006888 RID: 26760 RVA: 0x00095B8B File Offset: 0x00093D8B
		public FAdditionalDataLayerCheck AdditionalDataLayerCheck
		{
			get
			{
				base.FastCheckIsValid();
				FAdditionalDataLayerCheck result;
				if ((result = this._AdditionalDataLayerCheck) == null)
				{
					result = (this._AdditionalDataLayerCheck = new FAdditionalDataLayerCheck(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_AdditionalDataLayerCheck, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAdditionalDataLayerCheck.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_AdditionalDataLayerCheck, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x06006889 RID: 26761 RVA: 0x00095BAC File Offset: 0x00093DAC
		// (set) Token: 0x0600688A RID: 26762 RVA: 0x00095BEF File Offset: 0x00093DEF
		public FTestMapWhiteList TestMapWhiteList
		{
			get
			{
				base.FastCheckIsValid();
				FTestMapWhiteList result;
				if ((result = this._TestMapWhiteList) == null)
				{
					result = (this._TestMapWhiteList = new FTestMapWhiteList(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_TestMapWhiteList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTestMapWhiteList.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_TestMapWhiteList, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x0600688B RID: 26763 RVA: 0x00095C10 File Offset: 0x00093E10
		// (set) Token: 0x0600688C RID: 26764 RVA: 0x00095C53 File Offset: 0x00093E53
		public FLandScapeFolderCheck LandScapeFolderCheck
		{
			get
			{
				base.FastCheckIsValid();
				FLandScapeFolderCheck result;
				if ((result = this._LandScapeFolderCheck) == null)
				{
					result = (this._LandScapeFolderCheck = new FLandScapeFolderCheck(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_LandScapeFolderCheck, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLandScapeFolderCheck.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_LandScapeFolderCheck, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x0600688D RID: 26765 RVA: 0x00095C74 File Offset: 0x00093E74
		// (set) Token: 0x0600688E RID: 26766 RVA: 0x00095CB7 File Offset: 0x00093EB7
		public FHLODFolderCheck HLODFolderCheck
		{
			get
			{
				base.FastCheckIsValid();
				FHLODFolderCheck result;
				if ((result = this._HLODFolderCheck) == null)
				{
					result = (this._HLODFolderCheck = new FHLODFolderCheck(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_HLODFolderCheck, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHLODFolderCheck.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_HLODFolderCheck, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x0600688F RID: 26767 RVA: 0x00095CD8 File Offset: 0x00093ED8
		// (set) Token: 0x06006890 RID: 26768 RVA: 0x00095D1B File Offset: 0x00093F1B
		public FEncloseSpaceFolderCheck EncloseSpaceFolderCheck
		{
			get
			{
				base.FastCheckIsValid();
				FEncloseSpaceFolderCheck result;
				if ((result = this._EncloseSpaceFolderCheck) == null)
				{
					result = (this._EncloseSpaceFolderCheck = new FEncloseSpaceFolderCheck(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_EncloseSpaceFolderCheck, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEncloseSpaceFolderCheck.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_EncloseSpaceFolderCheck, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x06006891 RID: 26769 RVA: 0x00095D3C File Offset: 0x00093F3C
		// (set) Token: 0x06006892 RID: 26770 RVA: 0x00095D7F File Offset: 0x00093F7F
		public FEffectActorCheck EffectActorCheck
		{
			get
			{
				base.FastCheckIsValid();
				FEffectActorCheck result;
				if ((result = this._EffectActorCheck) == null)
				{
					result = (this._EffectActorCheck = new FEffectActorCheck(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_EffectActorCheck, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEffectActorCheck.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_EffectActorCheck, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x06006893 RID: 26771 RVA: 0x00095DA0 File Offset: 0x00093FA0
		// (set) Token: 0x06006894 RID: 26772 RVA: 0x00095DE3 File Offset: 0x00093FE3
		public TMap<string, string> TexArrayMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._TexArrayMap) == null)
				{
					result = (this._TexArrayMap = new TMap<string, string>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_TexArrayMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TexArrayMap.CopyAssign(value);
			}
		}

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x06006895 RID: 26773 RVA: 0x00095DF4 File Offset: 0x00093FF4
		// (set) Token: 0x06006896 RID: 26774 RVA: 0x00095E37 File Offset: 0x00094037
		public TMap<string, float> ActorMaxBoundExtent
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, float> result;
				if ((result = this._ActorMaxBoundExtent) == null)
				{
					result = (this._ActorMaxBoundExtent = new TMap<string, float>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_ActorMaxBoundExtent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ActorMaxBoundExtent.CopyAssign(value);
			}
		}

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x06006897 RID: 26775 RVA: 0x00095E48 File Offset: 0x00094048
		// (set) Token: 0x06006898 RID: 26776 RVA: 0x00095E8B File Offset: 0x0009408B
		public TArray<string> ActorMaxBoundExtentWhiteListClass
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ActorMaxBoundExtentWhiteListClass) == null)
				{
					result = (this._ActorMaxBoundExtentWhiteListClass = new TArray<string>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_ActorMaxBoundExtentWhiteListClass, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ActorMaxBoundExtentWhiteListClass.CopyAssign(value);
			}
		}

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x06006899 RID: 26777 RVA: 0x00095E9C File Offset: 0x0009409C
		// (set) Token: 0x0600689A RID: 26778 RVA: 0x00095EDF File Offset: 0x000940DF
		public TArray<FRegionBound> CoreRegionBounds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRegionBound> result;
				if ((result = this._CoreRegionBounds) == null)
				{
					result = (this._CoreRegionBounds = new TArray<FRegionBound>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_CoreRegionBounds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CoreRegionBounds.CopyAssign(value);
			}
		}

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x0600689B RID: 26779 RVA: 0x00095EF0 File Offset: 0x000940F0
		// (set) Token: 0x0600689C RID: 26780 RVA: 0x00095F33 File Offset: 0x00094133
		public TArray<FRegionBound> ScenicRegionBounds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRegionBound> result;
				if ((result = this._ScenicRegionBounds) == null)
				{
					result = (this._ScenicRegionBounds = new TArray<FRegionBound>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_ScenicRegionBounds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ScenicRegionBounds.CopyAssign(value);
			}
		}

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x0600689D RID: 26781 RVA: 0x00095F44 File Offset: 0x00094144
		// (set) Token: 0x0600689E RID: 26782 RVA: 0x00095F87 File Offset: 0x00094187
		public TArray<string> ActorAssetLocationWhiteList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ActorAssetLocationWhiteList) == null)
				{
					result = (this._ActorAssetLocationWhiteList = new TArray<string>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_ActorAssetLocationWhiteList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ActorAssetLocationWhiteList.CopyAssign(value);
			}
		}

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x0600689F RID: 26783 RVA: 0x00095F98 File Offset: 0x00094198
		// (set) Token: 0x060068A0 RID: 26784 RVA: 0x00095FDB File Offset: 0x000941DB
		public TArray<string> MapAreaVolumeAuthor
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MapAreaVolumeAuthor) == null)
				{
					result = (this._MapAreaVolumeAuthor = new TArray<string>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_MapAreaVolumeAuthor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MapAreaVolumeAuthor.CopyAssign(value);
			}
		}

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x060068A1 RID: 26785 RVA: 0x00095FEC File Offset: 0x000941EC
		// (set) Token: 0x060068A2 RID: 26786 RVA: 0x0009602F File Offset: 0x0009422F
		public TArray<string> TexArrayDistanceNoLimit
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._TexArrayDistanceNoLimit) == null)
				{
					result = (this._TexArrayDistanceNoLimit = new TArray<string>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_TexArrayDistanceNoLimit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TexArrayDistanceNoLimit.CopyAssign(value);
			}
		}

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x060068A3 RID: 26787 RVA: 0x00096040 File Offset: 0x00094240
		// (set) Token: 0x060068A4 RID: 26788 RVA: 0x00096083 File Offset: 0x00094283
		public TArray<string> OverrideMatNoLimit
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._OverrideMatNoLimit) == null)
				{
					result = (this._OverrideMatNoLimit = new TArray<string>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_OverrideMatNoLimit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OverrideMatNoLimit.CopyAssign(value);
			}
		}

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x060068A5 RID: 26789 RVA: 0x00096094 File Offset: 0x00094294
		// (set) Token: 0x060068A6 RID: 26790 RVA: 0x000960D7 File Offset: 0x000942D7
		public TArray<string> MeshCompAllowNullMeshList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MeshCompAllowNullMeshList) == null)
				{
					result = (this._MeshCompAllowNullMeshList = new TArray<string>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_MeshCompAllowNullMeshList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MeshCompAllowNullMeshList.CopyAssign(value);
			}
		}

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x060068A7 RID: 26791 RVA: 0x000960E8 File Offset: 0x000942E8
		// (set) Token: 0x060068A8 RID: 26792 RVA: 0x0009612B File Offset: 0x0009432B
		public FEditorEntityCheck EditorEntityCheck
		{
			get
			{
				base.FastCheckIsValid();
				FEditorEntityCheck result;
				if ((result = this._EditorEntityCheck) == null)
				{
					result = (this._EditorEntityCheck = new FEditorEntityCheck(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_EditorEntityCheck, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEditorEntityCheck.StaticStruct(), base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_EditorEntityCheck, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x060068A9 RID: 26793 RVA: 0x0009614C File Offset: 0x0009434C
		// (set) Token: 0x060068AA RID: 26794 RVA: 0x0009618F File Offset: 0x0009438F
		public TArray<string> CloseUROSkeletalMeshes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._CloseUROSkeletalMeshes) == null)
				{
					result = (this._CloseUROSkeletalMeshes = new TArray<string>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_CloseUROSkeletalMeshes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CloseUROSkeletalMeshes.CopyAssign(value);
			}
		}

		// Token: 0x170018C7 RID: 6343
		// (get) Token: 0x060068AB RID: 26795 RVA: 0x000961A0 File Offset: 0x000943A0
		// (set) Token: 0x060068AC RID: 26796 RVA: 0x000961E3 File Offset: 0x000943E3
		public TArray<FAlwaysLoadRegular> AlwaysLoadRegular
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAlwaysLoadRegular> result;
				if ((result = this._AlwaysLoadRegular) == null)
				{
					result = (this._AlwaysLoadRegular = new TArray<FAlwaysLoadRegular>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_AlwaysLoadRegular, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AlwaysLoadRegular.CopyAssign(value);
			}
		}

		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x060068AD RID: 26797 RVA: 0x000961F4 File Offset: 0x000943F4
		// (set) Token: 0x060068AE RID: 26798 RVA: 0x00096237 File Offset: 0x00094437
		public TArray<FLevelInstanceRegular> LevelInstances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLevelInstanceRegular> result;
				if ((result = this._LevelInstances) == null)
				{
					result = (this._LevelInstances = new TArray<FLevelInstanceRegular>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_LevelInstances, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LevelInstances.CopyAssign(value);
			}
		}

		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x060068AF RID: 26799 RVA: 0x00096248 File Offset: 0x00094448
		// (set) Token: 0x060068B0 RID: 26800 RVA: 0x0009628B File Offset: 0x0009448B
		public TArray<FAddDataLayerItem> CommonAddDataLayerRegulars
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAddDataLayerItem> result;
				if ((result = this._CommonAddDataLayerRegulars) == null)
				{
					result = (this._CommonAddDataLayerRegulars = new TArray<FAddDataLayerItem>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_CommonAddDataLayerRegulars, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CommonAddDataLayerRegulars.CopyAssign(value);
			}
		}

		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x060068B1 RID: 26801 RVA: 0x0009629C File Offset: 0x0009449C
		// (set) Token: 0x060068B2 RID: 26802 RVA: 0x000962DF File Offset: 0x000944DF
		public TArray<FAddTagItem> CommonAddTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAddTagItem> result;
				if ((result = this._CommonAddTags) == null)
				{
					result = (this._CommonAddTags = new TArray<FAddTagItem>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_CommonAddTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CommonAddTags.CopyAssign(value);
			}
		}

		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x060068B3 RID: 26803 RVA: 0x000962F0 File Offset: 0x000944F0
		// (set) Token: 0x060068B4 RID: 26804 RVA: 0x00096333 File Offset: 0x00094533
		public TArray<string> VertexCompressWhiteList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._VertexCompressWhiteList) == null)
				{
					result = (this._VertexCompressWhiteList = new TArray<string>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_VertexCompressWhiteList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VertexCompressWhiteList.CopyAssign(value);
			}
		}

		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x060068B5 RID: 26805 RVA: 0x00096344 File Offset: 0x00094544
		// (set) Token: 0x060068B6 RID: 26806 RVA: 0x00096387 File Offset: 0x00094587
		public TMap<string, string> TagExcludePath
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._TagExcludePath) == null)
				{
					result = (this._TagExcludePath = new TMap<string, string>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_TagExcludePath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TagExcludePath.CopyAssign(value);
			}
		}

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x060068B7 RID: 26807 RVA: 0x00096398 File Offset: 0x00094598
		// (set) Token: 0x060068B8 RID: 26808 RVA: 0x000963DB File Offset: 0x000945DB
		public TMap<string, float> DontDeployActorClass
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, float> result;
				if ((result = this._DontDeployActorClass) == null)
				{
					result = (this._DontDeployActorClass = new TMap<string, float>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_DontDeployActorClass, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DontDeployActorClass.CopyAssign(value);
			}
		}

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x060068B9 RID: 26809 RVA: 0x000963EC File Offset: 0x000945EC
		// (set) Token: 0x060068BA RID: 26810 RVA: 0x0009642F File Offset: 0x0009462F
		public TArray<string> MobilityCheckWhiteListClass
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MobilityCheckWhiteListClass) == null)
				{
					result = (this._MobilityCheckWhiteListClass = new TArray<string>(base.NativePtr + (IntPtr)FActorCheckJsonParams.__PropertyOffset_MobilityCheckWhiteListClass, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MobilityCheckWhiteListClass.CopyAssign(value);
			}
		}

		// Token: 0x060068BB RID: 26811 RVA: 0x0009643D File Offset: 0x0009463D
		public FActorCheckJsonParams()
		{
		}

		// Token: 0x060068BC RID: 26812 RVA: 0x00096448 File Offset: 0x00094648
		public FActorCheckJsonParams(FActorCheckJsonParamsDetail Artist, FActorCheckJsonParamsDetail Designer, FActorCheckJsonParamsDetail Pcg, FActorCheckJsonParamsDetail Technology, FActorCheckJsonParamsDetail EditorEntity, FActorCheckJsonParamsDetail Audio, FSpecifiedClassRefCheck SpecifiedClassRefCheck, FHISMCullDistanceCheck HISMDistanceCheck, FLightCullDistanceCheck LightCullDistanceCheck, TArray<FLightCastShadowCheck> LightCastShadowCheck, int OpenFarShadowRadius, FMeshCastShadowCheck MeshCastShadowCheck, int ISMMinInstanceCount, FSpecifiedFolderPathCheck SpecifiedFolderPathCheck, FMeshRefCheck MeshRefCheck, FSpecialPathCheck SpecialPathCheck, FISMBoundCheck ISMBoundCheck, FAdditionalDataLayerCheck AdditionalDataLayerCheck, FTestMapWhiteList TestMapWhiteList, FLandScapeFolderCheck LandScapeFolderCheck, FHLODFolderCheck HLODFolderCheck, FEncloseSpaceFolderCheck EncloseSpaceFolderCheck, FEffectActorCheck EffectActorCheck, TMap<string, string> TexArrayMap, TMap<string, float> ActorMaxBoundExtent, TArray<string> ActorMaxBoundExtentWhiteListClass, TArray<FRegionBound> CoreRegionBounds, TArray<FRegionBound> ScenicRegionBounds, TArray<string> ActorAssetLocationWhiteList, TArray<string> MapAreaVolumeAuthor, TArray<string> TexArrayDistanceNoLimit, TArray<string> OverrideMatNoLimit, TArray<string> MeshCompAllowNullMeshList, FEditorEntityCheck EditorEntityCheck, TArray<string> CloseUROSkeletalMeshes, TArray<FAlwaysLoadRegular> AlwaysLoadRegular, TArray<FLevelInstanceRegular> LevelInstances, TArray<FAddDataLayerItem> CommonAddDataLayerRegulars, TArray<FAddTagItem> CommonAddTags, TArray<string> VertexCompressWhiteList, TMap<string, string> TagExcludePath, TMap<string, float> DontDeployActorClass, TArray<string> MobilityCheckWhiteListClass)
		{
			this.Artist = Artist;
			this.Designer = Designer;
			this.Pcg = Pcg;
			this.Technology = Technology;
			this.EditorEntity = EditorEntity;
			this.Audio = Audio;
			this.SpecifiedClassRefCheck = SpecifiedClassRefCheck;
			this.HISMDistanceCheck = HISMDistanceCheck;
			this.LightCullDistanceCheck = LightCullDistanceCheck;
			this.LightCastShadowCheck = LightCastShadowCheck;
			this.OpenFarShadowRadius = OpenFarShadowRadius;
			this.MeshCastShadowCheck = MeshCastShadowCheck;
			this.ISMMinInstanceCount = ISMMinInstanceCount;
			this.SpecifiedFolderPathCheck = SpecifiedFolderPathCheck;
			this.MeshRefCheck = MeshRefCheck;
			this.SpecialPathCheck = SpecialPathCheck;
			this.ISMBoundCheck = ISMBoundCheck;
			this.AdditionalDataLayerCheck = AdditionalDataLayerCheck;
			this.TestMapWhiteList = TestMapWhiteList;
			this.LandScapeFolderCheck = LandScapeFolderCheck;
			this.HLODFolderCheck = HLODFolderCheck;
			this.EncloseSpaceFolderCheck = EncloseSpaceFolderCheck;
			this.EffectActorCheck = EffectActorCheck;
			this.TexArrayMap = TexArrayMap;
			this.ActorMaxBoundExtent = ActorMaxBoundExtent;
			this.ActorMaxBoundExtentWhiteListClass = ActorMaxBoundExtentWhiteListClass;
			this.CoreRegionBounds = CoreRegionBounds;
			this.ScenicRegionBounds = ScenicRegionBounds;
			this.ActorAssetLocationWhiteList = ActorAssetLocationWhiteList;
			this.MapAreaVolumeAuthor = MapAreaVolumeAuthor;
			this.TexArrayDistanceNoLimit = TexArrayDistanceNoLimit;
			this.OverrideMatNoLimit = OverrideMatNoLimit;
			this.MeshCompAllowNullMeshList = MeshCompAllowNullMeshList;
			this.EditorEntityCheck = EditorEntityCheck;
			this.CloseUROSkeletalMeshes = CloseUROSkeletalMeshes;
			this.AlwaysLoadRegular = AlwaysLoadRegular;
			this.LevelInstances = LevelInstances;
			this.CommonAddDataLayerRegulars = CommonAddDataLayerRegulars;
			this.CommonAddTags = CommonAddTags;
			this.VertexCompressWhiteList = VertexCompressWhiteList;
			this.TagExcludePath = TagExcludePath;
			this.DontDeployActorClass = DontDeployActorClass;
			this.MobilityCheckWhiteListClass = MobilityCheckWhiteListClass;
		}

		// Token: 0x060068BD RID: 26813 RVA: 0x000965B0 File Offset: 0x000947B0
		protected override IntPtr GetUStructPtr()
		{
			return FActorCheckJsonParams.StaticStruct();
		}

		// Token: 0x060068BE RID: 26814 RVA: 0x000965BC File Offset: 0x000947BC
		[NullableContext(2)]
		public FActorCheckJsonParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x000965C6 File Offset: 0x000947C6
		public FActorCheckJsonParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060068C0 RID: 26816 RVA: 0x000965D1 File Offset: 0x000947D1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorCheckJsonParams(Pointer, false, true);
		}

		// Token: 0x060068C1 RID: 26817 RVA: 0x000965DB File Offset: 0x000947DB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorCheckJsonParams(Pointer, MemoryOwner);
		}

		// Token: 0x04003232 RID: 12850
		public const string __ObjectPath = "/Script/Engine.ActorCheckJsonParams";

		// Token: 0x04003233 RID: 12851
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003234 RID: 12852
		internal static int __PropertyOffset_Artist;

		// Token: 0x04003235 RID: 12853
		[Nullable(2)]
		private FActorCheckJsonParamsDetail _Artist;

		// Token: 0x04003236 RID: 12854
		internal static int __PropertyOffset_Designer;

		// Token: 0x04003237 RID: 12855
		[Nullable(2)]
		private FActorCheckJsonParamsDetail _Designer;

		// Token: 0x04003238 RID: 12856
		internal static int __PropertyOffset_Pcg;

		// Token: 0x04003239 RID: 12857
		[Nullable(2)]
		private FActorCheckJsonParamsDetail _Pcg;

		// Token: 0x0400323A RID: 12858
		internal static int __PropertyOffset_Technology;

		// Token: 0x0400323B RID: 12859
		[Nullable(2)]
		private FActorCheckJsonParamsDetail _Technology;

		// Token: 0x0400323C RID: 12860
		internal static int __PropertyOffset_EditorEntity;

		// Token: 0x0400323D RID: 12861
		[Nullable(2)]
		private FActorCheckJsonParamsDetail _EditorEntity;

		// Token: 0x0400323E RID: 12862
		internal static int __PropertyOffset_Audio;

		// Token: 0x0400323F RID: 12863
		[Nullable(2)]
		private FActorCheckJsonParamsDetail _Audio;

		// Token: 0x04003240 RID: 12864
		internal static int __PropertyOffset_SpecifiedClassRefCheck;

		// Token: 0x04003241 RID: 12865
		[Nullable(2)]
		private FSpecifiedClassRefCheck _SpecifiedClassRefCheck;

		// Token: 0x04003242 RID: 12866
		internal static int __PropertyOffset_HISMDistanceCheck;

		// Token: 0x04003243 RID: 12867
		[Nullable(2)]
		private FHISMCullDistanceCheck _HISMDistanceCheck;

		// Token: 0x04003244 RID: 12868
		internal static int __PropertyOffset_LightCullDistanceCheck;

		// Token: 0x04003245 RID: 12869
		[Nullable(2)]
		private FLightCullDistanceCheck _LightCullDistanceCheck;

		// Token: 0x04003246 RID: 12870
		internal static int __PropertyOffset_LightCastShadowCheck;

		// Token: 0x04003247 RID: 12871
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLightCastShadowCheck> _LightCastShadowCheck;

		// Token: 0x04003248 RID: 12872
		internal static int __PropertyOffset_OpenFarShadowRadius;

		// Token: 0x04003249 RID: 12873
		internal static int __PropertyOffset_MeshCastShadowCheck;

		// Token: 0x0400324A RID: 12874
		[Nullable(2)]
		private FMeshCastShadowCheck _MeshCastShadowCheck;

		// Token: 0x0400324B RID: 12875
		internal static int __PropertyOffset_ISMMinInstanceCount;

		// Token: 0x0400324C RID: 12876
		internal static int __PropertyOffset_SpecifiedFolderPathCheck;

		// Token: 0x0400324D RID: 12877
		[Nullable(2)]
		private FSpecifiedFolderPathCheck _SpecifiedFolderPathCheck;

		// Token: 0x0400324E RID: 12878
		internal static int __PropertyOffset_MeshRefCheck;

		// Token: 0x0400324F RID: 12879
		[Nullable(2)]
		private FMeshRefCheck _MeshRefCheck;

		// Token: 0x04003250 RID: 12880
		internal static int __PropertyOffset_SpecialPathCheck;

		// Token: 0x04003251 RID: 12881
		[Nullable(2)]
		private FSpecialPathCheck _SpecialPathCheck;

		// Token: 0x04003252 RID: 12882
		internal static int __PropertyOffset_ISMBoundCheck;

		// Token: 0x04003253 RID: 12883
		[Nullable(2)]
		private FISMBoundCheck _ISMBoundCheck;

		// Token: 0x04003254 RID: 12884
		internal static int __PropertyOffset_AdditionalDataLayerCheck;

		// Token: 0x04003255 RID: 12885
		[Nullable(2)]
		private FAdditionalDataLayerCheck _AdditionalDataLayerCheck;

		// Token: 0x04003256 RID: 12886
		internal static int __PropertyOffset_TestMapWhiteList;

		// Token: 0x04003257 RID: 12887
		[Nullable(2)]
		private FTestMapWhiteList _TestMapWhiteList;

		// Token: 0x04003258 RID: 12888
		internal static int __PropertyOffset_LandScapeFolderCheck;

		// Token: 0x04003259 RID: 12889
		[Nullable(2)]
		private FLandScapeFolderCheck _LandScapeFolderCheck;

		// Token: 0x0400325A RID: 12890
		internal static int __PropertyOffset_HLODFolderCheck;

		// Token: 0x0400325B RID: 12891
		[Nullable(2)]
		private FHLODFolderCheck _HLODFolderCheck;

		// Token: 0x0400325C RID: 12892
		internal static int __PropertyOffset_EncloseSpaceFolderCheck;

		// Token: 0x0400325D RID: 12893
		[Nullable(2)]
		private FEncloseSpaceFolderCheck _EncloseSpaceFolderCheck;

		// Token: 0x0400325E RID: 12894
		internal static int __PropertyOffset_EffectActorCheck;

		// Token: 0x0400325F RID: 12895
		[Nullable(2)]
		private FEffectActorCheck _EffectActorCheck;

		// Token: 0x04003260 RID: 12896
		internal static int __PropertyOffset_TexArrayMap;

		// Token: 0x04003261 RID: 12897
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _TexArrayMap;

		// Token: 0x04003262 RID: 12898
		internal static int __PropertyOffset_ActorMaxBoundExtent;

		// Token: 0x04003263 RID: 12899
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, float> _ActorMaxBoundExtent;

		// Token: 0x04003264 RID: 12900
		internal static int __PropertyOffset_ActorMaxBoundExtentWhiteListClass;

		// Token: 0x04003265 RID: 12901
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ActorMaxBoundExtentWhiteListClass;

		// Token: 0x04003266 RID: 12902
		internal static int __PropertyOffset_CoreRegionBounds;

		// Token: 0x04003267 RID: 12903
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRegionBound> _CoreRegionBounds;

		// Token: 0x04003268 RID: 12904
		internal static int __PropertyOffset_ScenicRegionBounds;

		// Token: 0x04003269 RID: 12905
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRegionBound> _ScenicRegionBounds;

		// Token: 0x0400326A RID: 12906
		internal static int __PropertyOffset_ActorAssetLocationWhiteList;

		// Token: 0x0400326B RID: 12907
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ActorAssetLocationWhiteList;

		// Token: 0x0400326C RID: 12908
		internal static int __PropertyOffset_MapAreaVolumeAuthor;

		// Token: 0x0400326D RID: 12909
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MapAreaVolumeAuthor;

		// Token: 0x0400326E RID: 12910
		internal static int __PropertyOffset_TexArrayDistanceNoLimit;

		// Token: 0x0400326F RID: 12911
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _TexArrayDistanceNoLimit;

		// Token: 0x04003270 RID: 12912
		internal static int __PropertyOffset_OverrideMatNoLimit;

		// Token: 0x04003271 RID: 12913
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _OverrideMatNoLimit;

		// Token: 0x04003272 RID: 12914
		internal static int __PropertyOffset_MeshCompAllowNullMeshList;

		// Token: 0x04003273 RID: 12915
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MeshCompAllowNullMeshList;

		// Token: 0x04003274 RID: 12916
		internal static int __PropertyOffset_EditorEntityCheck;

		// Token: 0x04003275 RID: 12917
		[Nullable(2)]
		private FEditorEntityCheck _EditorEntityCheck;

		// Token: 0x04003276 RID: 12918
		internal static int __PropertyOffset_CloseUROSkeletalMeshes;

		// Token: 0x04003277 RID: 12919
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _CloseUROSkeletalMeshes;

		// Token: 0x04003278 RID: 12920
		internal static int __PropertyOffset_AlwaysLoadRegular;

		// Token: 0x04003279 RID: 12921
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAlwaysLoadRegular> _AlwaysLoadRegular;

		// Token: 0x0400327A RID: 12922
		internal static int __PropertyOffset_LevelInstances;

		// Token: 0x0400327B RID: 12923
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLevelInstanceRegular> _LevelInstances;

		// Token: 0x0400327C RID: 12924
		internal static int __PropertyOffset_CommonAddDataLayerRegulars;

		// Token: 0x0400327D RID: 12925
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAddDataLayerItem> _CommonAddDataLayerRegulars;

		// Token: 0x0400327E RID: 12926
		internal static int __PropertyOffset_CommonAddTags;

		// Token: 0x0400327F RID: 12927
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAddTagItem> _CommonAddTags;

		// Token: 0x04003280 RID: 12928
		internal static int __PropertyOffset_VertexCompressWhiteList;

		// Token: 0x04003281 RID: 12929
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _VertexCompressWhiteList;

		// Token: 0x04003282 RID: 12930
		internal static int __PropertyOffset_TagExcludePath;

		// Token: 0x04003283 RID: 12931
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _TagExcludePath;

		// Token: 0x04003284 RID: 12932
		internal static int __PropertyOffset_DontDeployActorClass;

		// Token: 0x04003285 RID: 12933
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, float> _DontDeployActorClass;

		// Token: 0x04003286 RID: 12934
		internal static int __PropertyOffset_MobilityCheckWhiteListClass;

		// Token: 0x04003287 RID: 12935
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MobilityCheckWhiteListClass;
	}
}
