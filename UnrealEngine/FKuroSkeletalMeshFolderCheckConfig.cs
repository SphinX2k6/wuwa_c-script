using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D0D RID: 3341
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroSkeletalMeshFolderCheckConfig")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 488)]
	public class FKuroSkeletalMeshFolderCheckConfig : FKuroBaseFolderCheckConfig, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B25F RID: 45663 RVA: 0x000FDC3A File Offset: 0x000FBE3A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSkeletalMeshFolderCheckConfig._ScriptStructPtr != 0) ? FKuroSkeletalMeshFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroSkeletalMeshFolderCheckConfig", ref FKuroSkeletalMeshFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x17002892 RID: 10386
		// (get) Token: 0x0600B260 RID: 45664 RVA: 0x000FDC60 File Offset: 0x000FBE60
		// (set) Token: 0x0600B261 RID: 45665 RVA: 0x000FDCA3 File Offset: 0x000FBEA3
		public TArray<string> NormalImportMethod
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._NormalImportMethod) == null)
				{
					result = (this._NormalImportMethod = new TArray<string>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_NormalImportMethod, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NormalImportMethod.CopyAssign(value);
			}
		}

		// Token: 0x17002893 RID: 10387
		// (get) Token: 0x0600B262 RID: 45666 RVA: 0x000FDCB1 File Offset: 0x000FBEB1
		// (set) Token: 0x0600B263 RID: 45667 RVA: 0x000FDCC5 File Offset: 0x000FBEC5
		public unsafe string NumCoordsCheckCondition
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_NumCoordsCheckCondition)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_NumCoordsCheckCondition)), value);
			}
		}

		// Token: 0x17002894 RID: 10388
		// (get) Token: 0x0600B264 RID: 45668 RVA: 0x000FDCDC File Offset: 0x000FBEDC
		// (set) Token: 0x0600B265 RID: 45669 RVA: 0x000FDD1F File Offset: 0x000FBF1F
		public TArray<string> SlotNameList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SlotNameList) == null)
				{
					result = (this._SlotNameList = new TArray<string>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_SlotNameList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SlotNameList.CopyAssign(value);
			}
		}

		// Token: 0x17002895 RID: 10389
		// (get) Token: 0x0600B266 RID: 45670 RVA: 0x000FDD30 File Offset: 0x000FBF30
		// (set) Token: 0x0600B267 RID: 45671 RVA: 0x000FDD73 File Offset: 0x000FBF73
		public TArray<string> SlotNameMatchMat
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SlotNameMatchMat) == null)
				{
					result = (this._SlotNameMatchMat = new TArray<string>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_SlotNameMatchMat, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SlotNameMatchMat.CopyAssign(value);
			}
		}

		// Token: 0x17002896 RID: 10390
		// (get) Token: 0x0600B268 RID: 45672 RVA: 0x000FDD84 File Offset: 0x000FBF84
		// (set) Token: 0x0600B269 RID: 45673 RVA: 0x000FDDC7 File Offset: 0x000FBFC7
		public TArray<string> SlotNameMatchExtraSlot
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SlotNameMatchExtraSlot) == null)
				{
					result = (this._SlotNameMatchExtraSlot = new TArray<string>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_SlotNameMatchExtraSlot, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SlotNameMatchExtraSlot.CopyAssign(value);
			}
		}

		// Token: 0x17002897 RID: 10391
		// (get) Token: 0x0600B26A RID: 45674 RVA: 0x000FDDD8 File Offset: 0x000FBFD8
		// (set) Token: 0x0600B26B RID: 45675 RVA: 0x000FDE1B File Offset: 0x000FC01B
		public TArray<string> SocketString
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SocketString) == null)
				{
					result = (this._SocketString = new TArray<string>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_SocketString, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SocketString.CopyAssign(value);
			}
		}

		// Token: 0x17002898 RID: 10392
		// (get) Token: 0x0600B26C RID: 45676 RVA: 0x000FDE2C File Offset: 0x000FC02C
		// (set) Token: 0x0600B26D RID: 45677 RVA: 0x000FDE6F File Offset: 0x000FC06F
		public TArray<string> SlotNameRegex
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SlotNameRegex) == null)
				{
					result = (this._SlotNameRegex = new TArray<string>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_SlotNameRegex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SlotNameRegex.CopyAssign(value);
			}
		}

		// Token: 0x17002899 RID: 10393
		// (get) Token: 0x0600B26E RID: 45678 RVA: 0x000FDE80 File Offset: 0x000FC080
		// (set) Token: 0x0600B26F RID: 45679 RVA: 0x000FDEC3 File Offset: 0x000FC0C3
		public TArray<int> Triangles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Triangles) == null)
				{
					result = (this._Triangles = new TArray<int>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_Triangles, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Triangles.CopyAssign(value);
			}
		}

		// Token: 0x1700289A RID: 10394
		// (get) Token: 0x0600B270 RID: 45680 RVA: 0x000FDED1 File Offset: 0x000FC0D1
		// (set) Token: 0x0600B271 RID: 45681 RVA: 0x000FDEE1 File Offset: 0x000FC0E1
		public unsafe float LodDownRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_LodDownRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_LodDownRate) = value;
			}
		}

		// Token: 0x1700289B RID: 10395
		// (get) Token: 0x0600B272 RID: 45682 RVA: 0x000FDEF4 File Offset: 0x000FC0F4
		// (set) Token: 0x0600B273 RID: 45683 RVA: 0x000FDF37 File Offset: 0x000FC137
		public TArray<float> AdjoinLODPrimGapLimit
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._AdjoinLODPrimGapLimit) == null)
				{
					result = (this._AdjoinLODPrimGapLimit = new TArray<float>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_AdjoinLODPrimGapLimit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AdjoinLODPrimGapLimit.CopyAssign(value);
			}
		}

		// Token: 0x1700289C RID: 10396
		// (get) Token: 0x0600B274 RID: 45684 RVA: 0x000FDF48 File Offset: 0x000FC148
		// (set) Token: 0x0600B275 RID: 45685 RVA: 0x000FDF8B File Offset: 0x000FC18B
		public TArray<float> AdjoinLODPrimMaxGapLimit
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._AdjoinLODPrimMaxGapLimit) == null)
				{
					result = (this._AdjoinLODPrimMaxGapLimit = new TArray<float>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_AdjoinLODPrimMaxGapLimit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AdjoinLODPrimMaxGapLimit.CopyAssign(value);
			}
		}

		// Token: 0x1700289D RID: 10397
		// (get) Token: 0x0600B276 RID: 45686 RVA: 0x000FDF99 File Offset: 0x000FC199
		// (set) Token: 0x0600B277 RID: 45687 RVA: 0x000FDFA9 File Offset: 0x000FC1A9
		public unsafe float TextureNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_TextureNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_TextureNum) = value;
			}
		}

		// Token: 0x1700289E RID: 10398
		// (get) Token: 0x0600B278 RID: 45688 RVA: 0x000FDFBA File Offset: 0x000FC1BA
		// (set) Token: 0x0600B279 RID: 45689 RVA: 0x000FDFCA File Offset: 0x000FC1CA
		public unsafe float TextureNumMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_TextureNumMobile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_TextureNumMobile) = value;
			}
		}

		// Token: 0x1700289F RID: 10399
		// (get) Token: 0x0600B27A RID: 45690 RVA: 0x000FDFDB File Offset: 0x000FC1DB
		// (set) Token: 0x0600B27B RID: 45691 RVA: 0x000FDFEB File Offset: 0x000FC1EB
		public unsafe int Bones
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_Bones);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_Bones) = value;
			}
		}

		// Token: 0x170028A0 RID: 10400
		// (get) Token: 0x0600B27C RID: 45692 RVA: 0x000FDFFC File Offset: 0x000FC1FC
		// (set) Token: 0x0600B27D RID: 45693 RVA: 0x000FE00C File Offset: 0x000FC20C
		public unsafe int PreciseBones
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_PreciseBones);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_PreciseBones) = value;
			}
		}

		// Token: 0x170028A1 RID: 10401
		// (get) Token: 0x0600B27E RID: 45694 RVA: 0x000FE01D File Offset: 0x000FC21D
		// (set) Token: 0x0600B27F RID: 45695 RVA: 0x000FE02D File Offset: 0x000FC22D
		public unsafe int MorphTargetsNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_MorphTargetsNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_MorphTargetsNum) = value;
			}
		}

		// Token: 0x170028A2 RID: 10402
		// (get) Token: 0x0600B280 RID: 45696 RVA: 0x000FE03E File Offset: 0x000FC23E
		// (set) Token: 0x0600B281 RID: 45697 RVA: 0x000FE04E File Offset: 0x000FC24E
		public unsafe byte Section
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_Section);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_Section) = value;
			}
		}

		// Token: 0x170028A3 RID: 10403
		// (get) Token: 0x0600B282 RID: 45698 RVA: 0x000FE05F File Offset: 0x000FC25F
		// (set) Token: 0x0600B283 RID: 45699 RVA: 0x000FE06F File Offset: 0x000FC26F
		public unsafe byte MinLodNums
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_MinLodNums);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_MinLodNums) = value;
			}
		}

		// Token: 0x170028A4 RID: 10404
		// (get) Token: 0x0600B284 RID: 45700 RVA: 0x000FE080 File Offset: 0x000FC280
		// (set) Token: 0x0600B285 RID: 45701 RVA: 0x000FE090 File Offset: 0x000FC290
		public unsafe byte MaxLodNums
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_MaxLodNums);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_MaxLodNums) = value;
			}
		}

		// Token: 0x170028A5 RID: 10405
		// (get) Token: 0x0600B286 RID: 45702 RVA: 0x000FE0A1 File Offset: 0x000FC2A1
		// (set) Token: 0x0600B287 RID: 45703 RVA: 0x000FE0B1 File Offset: 0x000FC2B1
		public unsafe byte NumCoords
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_NumCoords);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_NumCoords) = value;
			}
		}

		// Token: 0x170028A6 RID: 10406
		// (get) Token: 0x0600B288 RID: 45704 RVA: 0x000FE0C2 File Offset: 0x000FC2C2
		// (set) Token: 0x0600B289 RID: 45705 RVA: 0x000FE0DB File Offset: 0x000FC2DB
		public unsafe bool ImportMorphTargets
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_ImportMorphTargets) & FKuroSkeletalMeshFolderCheckConfig.__PropertyMask_ImportMorphTargets) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_ImportMorphTargets) = ((*(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_ImportMorphTargets) & ~FKuroSkeletalMeshFolderCheckConfig.__PropertyMask_ImportMorphTargets) | (value ? FKuroSkeletalMeshFolderCheckConfig.__PropertyMask_ImportMorphTargets : 0));
			}
		}

		// Token: 0x170028A7 RID: 10407
		// (get) Token: 0x0600B28A RID: 45706 RVA: 0x000FE10B File Offset: 0x000FC30B
		// (set) Token: 0x0600B28B RID: 45707 RVA: 0x000FE124 File Offset: 0x000FC324
		public unsafe bool IsNeedLODSetting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_IsNeedLODSetting) & FKuroSkeletalMeshFolderCheckConfig.__PropertyMask_IsNeedLODSetting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_IsNeedLODSetting) = ((*(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_IsNeedLODSetting) & ~FKuroSkeletalMeshFolderCheckConfig.__PropertyMask_IsNeedLODSetting) | (value ? FKuroSkeletalMeshFolderCheckConfig.__PropertyMask_IsNeedLODSetting : 0));
			}
		}

		// Token: 0x170028A8 RID: 10408
		// (get) Token: 0x0600B28C RID: 45708 RVA: 0x000FE154 File Offset: 0x000FC354
		// (set) Token: 0x0600B28D RID: 45709 RVA: 0x000FE164 File Offset: 0x000FC364
		public unsafe sbyte UseLODDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_UseLODDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_UseLODDistance) = (byte)value;
			}
		}

		// Token: 0x170028A9 RID: 10409
		// (get) Token: 0x0600B28E RID: 45710 RVA: 0x000FE175 File Offset: 0x000FC375
		// (set) Token: 0x0600B28F RID: 45711 RVA: 0x000FE18E File Offset: 0x000FC38E
		public unsafe bool IsNeedBound
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_IsNeedBound) & FKuroSkeletalMeshFolderCheckConfig.__PropertyMask_IsNeedBound) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_IsNeedBound) = ((*(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_IsNeedBound) & ~FKuroSkeletalMeshFolderCheckConfig.__PropertyMask_IsNeedBound) | (value ? FKuroSkeletalMeshFolderCheckConfig.__PropertyMask_IsNeedBound : 0));
			}
		}

		// Token: 0x170028AA RID: 10410
		// (get) Token: 0x0600B290 RID: 45712 RVA: 0x000FE1C0 File Offset: 0x000FC3C0
		// (set) Token: 0x0600B291 RID: 45713 RVA: 0x000FE203 File Offset: 0x000FC403
		public TMap<string, string> SlotNameMatMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._SlotNameMatMap) == null)
				{
					result = (this._SlotNameMatMap = new TMap<string, string>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_SlotNameMatMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SlotNameMatMap.CopyAssign(value);
			}
		}

		// Token: 0x170028AB RID: 10411
		// (get) Token: 0x0600B292 RID: 45714 RVA: 0x000FE214 File Offset: 0x000FC414
		// (set) Token: 0x0600B293 RID: 45715 RVA: 0x000FE257 File Offset: 0x000FC457
		public TArray<FSlotExtraMatLODInfo> SlotExtraMatLODInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSlotExtraMatLODInfo> result;
				if ((result = this._SlotExtraMatLODInfos) == null)
				{
					result = (this._SlotExtraMatLODInfos = new TArray<FSlotExtraMatLODInfo>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_SlotExtraMatLODInfos, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SlotExtraMatLODInfos.CopyAssign(value);
			}
		}

		// Token: 0x170028AC RID: 10412
		// (get) Token: 0x0600B294 RID: 45716 RVA: 0x000FE268 File Offset: 0x000FC468
		// (set) Token: 0x0600B295 RID: 45717 RVA: 0x000FE2AB File Offset: 0x000FC4AB
		public TArray<string> PlatformSetting
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._PlatformSetting) == null)
				{
					result = (this._PlatformSetting = new TArray<string>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_PlatformSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PlatformSetting.CopyAssign(value);
			}
		}

		// Token: 0x170028AD RID: 10413
		// (get) Token: 0x0600B296 RID: 45718 RVA: 0x000FE2BC File Offset: 0x000FC4BC
		// (set) Token: 0x0600B297 RID: 45719 RVA: 0x000FE2FF File Offset: 0x000FC4FF
		public TArray<int> PlatformMinLod
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._PlatformMinLod) == null)
				{
					result = (this._PlatformMinLod = new TArray<int>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_PlatformMinLod, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PlatformMinLod.CopyAssign(value);
			}
		}

		// Token: 0x170028AE RID: 10414
		// (get) Token: 0x0600B298 RID: 45720 RVA: 0x000FE310 File Offset: 0x000FC510
		// (set) Token: 0x0600B299 RID: 45721 RVA: 0x000FE353 File Offset: 0x000FC553
		public TArray<int> RenderQualityLODBias
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._RenderQualityLODBias) == null)
				{
					result = (this._RenderQualityLODBias = new TArray<int>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_RenderQualityLODBias, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RenderQualityLODBias.CopyAssign(value);
			}
		}

		// Token: 0x170028AF RID: 10415
		// (get) Token: 0x0600B29A RID: 45722 RVA: 0x000FE364 File Offset: 0x000FC564
		// (set) Token: 0x0600B29B RID: 45723 RVA: 0x000FE3A7 File Offset: 0x000FC5A7
		public TArray<string> DeviceLevelExtraLodBiasPlatform
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DeviceLevelExtraLodBiasPlatform) == null)
				{
					result = (this._DeviceLevelExtraLodBiasPlatform = new TArray<string>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_DeviceLevelExtraLodBiasPlatform, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DeviceLevelExtraLodBiasPlatform.CopyAssign(value);
			}
		}

		// Token: 0x170028B0 RID: 10416
		// (get) Token: 0x0600B29C RID: 45724 RVA: 0x000FE3B8 File Offset: 0x000FC5B8
		// (set) Token: 0x0600B29D RID: 45725 RVA: 0x000FE3FB File Offset: 0x000FC5FB
		public TArray<int> DeviceLevelExtraLodBias
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._DeviceLevelExtraLodBias) == null)
				{
					result = (this._DeviceLevelExtraLodBias = new TArray<int>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_DeviceLevelExtraLodBias, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DeviceLevelExtraLodBias.CopyAssign(value);
			}
		}

		// Token: 0x170028B1 RID: 10417
		// (get) Token: 0x0600B29E RID: 45726 RVA: 0x000FE40C File Offset: 0x000FC60C
		// (set) Token: 0x0600B29F RID: 45727 RVA: 0x000FE44F File Offset: 0x000FC64F
		public TArray<int> DeviceLevelExtraLodBiasEffectedLevel
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._DeviceLevelExtraLodBiasEffectedLevel) == null)
				{
					result = (this._DeviceLevelExtraLodBiasEffectedLevel = new TArray<int>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_DeviceLevelExtraLodBiasEffectedLevel, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DeviceLevelExtraLodBiasEffectedLevel.CopyAssign(value);
			}
		}

		// Token: 0x170028B2 RID: 10418
		// (get) Token: 0x0600B2A0 RID: 45728 RVA: 0x000FE460 File Offset: 0x000FC660
		// (set) Token: 0x0600B2A1 RID: 45729 RVA: 0x000FE4A3 File Offset: 0x000FC6A3
		public TArray<float> ScreenSizePC
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ScreenSizePC) == null)
				{
					result = (this._ScreenSizePC = new TArray<float>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_ScreenSizePC, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ScreenSizePC.CopyAssign(value);
			}
		}

		// Token: 0x170028B3 RID: 10419
		// (get) Token: 0x0600B2A2 RID: 45730 RVA: 0x000FE4B4 File Offset: 0x000FC6B4
		// (set) Token: 0x0600B2A3 RID: 45731 RVA: 0x000FE4F7 File Offset: 0x000FC6F7
		public TArray<float> ScreenSizeMobile
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ScreenSizeMobile) == null)
				{
					result = (this._ScreenSizeMobile = new TArray<float>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_ScreenSizeMobile, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ScreenSizeMobile.CopyAssign(value);
			}
		}

		// Token: 0x170028B4 RID: 10420
		// (get) Token: 0x0600B2A4 RID: 45732 RVA: 0x000FE508 File Offset: 0x000FC708
		// (set) Token: 0x0600B2A5 RID: 45733 RVA: 0x000FE54B File Offset: 0x000FC74B
		public TArray<string> SamplingRegionsName
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SamplingRegionsName) == null)
				{
					result = (this._SamplingRegionsName = new TArray<string>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_SamplingRegionsName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SamplingRegionsName.CopyAssign(value);
			}
		}

		// Token: 0x170028B5 RID: 10421
		// (get) Token: 0x0600B2A6 RID: 45734 RVA: 0x000FE559 File Offset: 0x000FC759
		// (set) Token: 0x0600B2A7 RID: 45735 RVA: 0x000FE569 File Offset: 0x000FC769
		public unsafe float ScreenSizeCullRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_ScreenSizeCullRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_ScreenSizeCullRatio) = value;
			}
		}

		// Token: 0x170028B6 RID: 10422
		// (get) Token: 0x0600B2A8 RID: 45736 RVA: 0x000FE57A File Offset: 0x000FC77A
		// (set) Token: 0x0600B2A9 RID: 45737 RVA: 0x000FE58A File Offset: 0x000FC78A
		public unsafe float MaxScreenSizeCullRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_MaxScreenSizeCullRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_MaxScreenSizeCullRatio) = value;
			}
		}

		// Token: 0x170028B7 RID: 10423
		// (get) Token: 0x0600B2AA RID: 45738 RVA: 0x000FE59C File Offset: 0x000FC79C
		// (set) Token: 0x0600B2AB RID: 45739 RVA: 0x000FE5DF File Offset: 0x000FC7DF
		public TArray<string> BoneNameRegex
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._BoneNameRegex) == null)
				{
					result = (this._BoneNameRegex = new TArray<string>(base.NativePtr + (IntPtr)FKuroSkeletalMeshFolderCheckConfig.__PropertyOffset_BoneNameRegex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneNameRegex.CopyAssign(value);
			}
		}

		// Token: 0x0600B2AC RID: 45740 RVA: 0x000FE5ED File Offset: 0x000FC7ED
		public FKuroSkeletalMeshFolderCheckConfig()
		{
		}

		// Token: 0x0600B2AD RID: 45741 RVA: 0x000FE5F8 File Offset: 0x000FC7F8
		public FKuroSkeletalMeshFolderCheckConfig(TArray<string> NormalImportMethod, string NumCoordsCheckCondition, TArray<string> SlotNameList, TArray<string> SlotNameMatchMat, TArray<string> SlotNameMatchExtraSlot, TArray<string> SocketString, TArray<string> SlotNameRegex, TArray<int> Triangles, float LodDownRate, TArray<float> AdjoinLODPrimGapLimit, TArray<float> AdjoinLODPrimMaxGapLimit, float TextureNum, float TextureNumMobile, int Bones, int PreciseBones, int MorphTargetsNum, byte Section, byte MinLodNums, byte MaxLodNums, byte NumCoords, bool ImportMorphTargets, bool IsNeedLODSetting, sbyte UseLODDistance, bool IsNeedBound, TMap<string, string> SlotNameMatMap, TArray<FSlotExtraMatLODInfo> SlotExtraMatLODInfos, TArray<string> PlatformSetting, TArray<int> PlatformMinLod, TArray<int> RenderQualityLODBias, TArray<string> DeviceLevelExtraLodBiasPlatform, TArray<int> DeviceLevelExtraLodBias, TArray<int> DeviceLevelExtraLodBiasEffectedLevel, TArray<float> ScreenSizePC, TArray<float> ScreenSizeMobile, TArray<string> SamplingRegionsName, float ScreenSizeCullRatio, float MaxScreenSizeCullRatio, TArray<string> BoneNameRegex, string Regex, int MatchingPriority)
		{
			this.NormalImportMethod = NormalImportMethod;
			this.NumCoordsCheckCondition = NumCoordsCheckCondition;
			this.SlotNameList = SlotNameList;
			this.SlotNameMatchMat = SlotNameMatchMat;
			this.SlotNameMatchExtraSlot = SlotNameMatchExtraSlot;
			this.SocketString = SocketString;
			this.SlotNameRegex = SlotNameRegex;
			this.Triangles = Triangles;
			this.LodDownRate = LodDownRate;
			this.AdjoinLODPrimGapLimit = AdjoinLODPrimGapLimit;
			this.AdjoinLODPrimMaxGapLimit = AdjoinLODPrimMaxGapLimit;
			this.TextureNum = TextureNum;
			this.TextureNumMobile = TextureNumMobile;
			this.Bones = Bones;
			this.PreciseBones = PreciseBones;
			this.MorphTargetsNum = MorphTargetsNum;
			this.Section = Section;
			this.MinLodNums = MinLodNums;
			this.MaxLodNums = MaxLodNums;
			this.NumCoords = NumCoords;
			this.ImportMorphTargets = ImportMorphTargets;
			this.IsNeedLODSetting = IsNeedLODSetting;
			this.UseLODDistance = UseLODDistance;
			this.IsNeedBound = IsNeedBound;
			this.SlotNameMatMap = SlotNameMatMap;
			this.SlotExtraMatLODInfos = SlotExtraMatLODInfos;
			this.PlatformSetting = PlatformSetting;
			this.PlatformMinLod = PlatformMinLod;
			this.RenderQualityLODBias = RenderQualityLODBias;
			this.DeviceLevelExtraLodBiasPlatform = DeviceLevelExtraLodBiasPlatform;
			this.DeviceLevelExtraLodBias = DeviceLevelExtraLodBias;
			this.DeviceLevelExtraLodBiasEffectedLevel = DeviceLevelExtraLodBiasEffectedLevel;
			this.ScreenSizePC = ScreenSizePC;
			this.ScreenSizeMobile = ScreenSizeMobile;
			this.SamplingRegionsName = SamplingRegionsName;
			this.ScreenSizeCullRatio = ScreenSizeCullRatio;
			this.MaxScreenSizeCullRatio = MaxScreenSizeCullRatio;
			this.BoneNameRegex = BoneNameRegex;
			base.Regex = Regex;
			base.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0600B2AE RID: 45742 RVA: 0x000FE748 File Offset: 0x000FC948
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSkeletalMeshFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600B2AF RID: 45743 RVA: 0x000FE754 File Offset: 0x000FC954
		[NullableContext(2)]
		public FKuroSkeletalMeshFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B2B0 RID: 45744 RVA: 0x000FE75E File Offset: 0x000FC95E
		public FKuroSkeletalMeshFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B2B1 RID: 45745 RVA: 0x000FE769 File Offset: 0x000FC969
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSkeletalMeshFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600B2B2 RID: 45746 RVA: 0x000FE773 File Offset: 0x000FC973
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSkeletalMeshFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005D8D RID: 23949
		public new const string __ObjectPath = "/Script/Engine.KuroSkeletalMeshFolderCheckConfig";

		// Token: 0x04005D8E RID: 23950
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005D8F RID: 23951
		internal static int __PropertyOffset_NormalImportMethod;

		// Token: 0x04005D90 RID: 23952
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _NormalImportMethod;

		// Token: 0x04005D91 RID: 23953
		internal static int __PropertyOffset_NumCoordsCheckCondition;

		// Token: 0x04005D92 RID: 23954
		internal static int __PropertyOffset_SlotNameList;

		// Token: 0x04005D93 RID: 23955
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SlotNameList;

		// Token: 0x04005D94 RID: 23956
		internal static int __PropertyOffset_SlotNameMatchMat;

		// Token: 0x04005D95 RID: 23957
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SlotNameMatchMat;

		// Token: 0x04005D96 RID: 23958
		internal static int __PropertyOffset_SlotNameMatchExtraSlot;

		// Token: 0x04005D97 RID: 23959
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SlotNameMatchExtraSlot;

		// Token: 0x04005D98 RID: 23960
		internal static int __PropertyOffset_SocketString;

		// Token: 0x04005D99 RID: 23961
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SocketString;

		// Token: 0x04005D9A RID: 23962
		internal static int __PropertyOffset_SlotNameRegex;

		// Token: 0x04005D9B RID: 23963
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SlotNameRegex;

		// Token: 0x04005D9C RID: 23964
		internal static int __PropertyOffset_Triangles;

		// Token: 0x04005D9D RID: 23965
		[Nullable(2)]
		private TArray<int> _Triangles;

		// Token: 0x04005D9E RID: 23966
		internal static int __PropertyOffset_LodDownRate;

		// Token: 0x04005D9F RID: 23967
		internal static int __PropertyOffset_AdjoinLODPrimGapLimit;

		// Token: 0x04005DA0 RID: 23968
		[Nullable(2)]
		private TArray<float> _AdjoinLODPrimGapLimit;

		// Token: 0x04005DA1 RID: 23969
		internal static int __PropertyOffset_AdjoinLODPrimMaxGapLimit;

		// Token: 0x04005DA2 RID: 23970
		[Nullable(2)]
		private TArray<float> _AdjoinLODPrimMaxGapLimit;

		// Token: 0x04005DA3 RID: 23971
		internal static int __PropertyOffset_TextureNum;

		// Token: 0x04005DA4 RID: 23972
		internal static int __PropertyOffset_TextureNumMobile;

		// Token: 0x04005DA5 RID: 23973
		internal static int __PropertyOffset_Bones;

		// Token: 0x04005DA6 RID: 23974
		internal static int __PropertyOffset_PreciseBones;

		// Token: 0x04005DA7 RID: 23975
		internal static int __PropertyOffset_MorphTargetsNum;

		// Token: 0x04005DA8 RID: 23976
		internal static int __PropertyOffset_Section;

		// Token: 0x04005DA9 RID: 23977
		internal static int __PropertyOffset_MinLodNums;

		// Token: 0x04005DAA RID: 23978
		internal static int __PropertyOffset_MaxLodNums;

		// Token: 0x04005DAB RID: 23979
		internal static int __PropertyOffset_NumCoords;

		// Token: 0x04005DAC RID: 23980
		internal static int __PropertyOffset_ImportMorphTargets;

		// Token: 0x04005DAD RID: 23981
		internal static byte __PropertyMask_ImportMorphTargets;

		// Token: 0x04005DAE RID: 23982
		internal static int __PropertyOffset_IsNeedLODSetting;

		// Token: 0x04005DAF RID: 23983
		internal static byte __PropertyMask_IsNeedLODSetting;

		// Token: 0x04005DB0 RID: 23984
		internal static int __PropertyOffset_UseLODDistance;

		// Token: 0x04005DB1 RID: 23985
		internal static int __PropertyOffset_IsNeedBound;

		// Token: 0x04005DB2 RID: 23986
		internal static byte __PropertyMask_IsNeedBound;

		// Token: 0x04005DB3 RID: 23987
		internal static int __PropertyOffset_SlotNameMatMap;

		// Token: 0x04005DB4 RID: 23988
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _SlotNameMatMap;

		// Token: 0x04005DB5 RID: 23989
		internal static int __PropertyOffset_SlotExtraMatLODInfos;

		// Token: 0x04005DB6 RID: 23990
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSlotExtraMatLODInfo> _SlotExtraMatLODInfos;

		// Token: 0x04005DB7 RID: 23991
		internal static int __PropertyOffset_PlatformSetting;

		// Token: 0x04005DB8 RID: 23992
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _PlatformSetting;

		// Token: 0x04005DB9 RID: 23993
		internal static int __PropertyOffset_PlatformMinLod;

		// Token: 0x04005DBA RID: 23994
		[Nullable(2)]
		private TArray<int> _PlatformMinLod;

		// Token: 0x04005DBB RID: 23995
		internal static int __PropertyOffset_RenderQualityLODBias;

		// Token: 0x04005DBC RID: 23996
		[Nullable(2)]
		private TArray<int> _RenderQualityLODBias;

		// Token: 0x04005DBD RID: 23997
		internal static int __PropertyOffset_DeviceLevelExtraLodBiasPlatform;

		// Token: 0x04005DBE RID: 23998
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DeviceLevelExtraLodBiasPlatform;

		// Token: 0x04005DBF RID: 23999
		internal static int __PropertyOffset_DeviceLevelExtraLodBias;

		// Token: 0x04005DC0 RID: 24000
		[Nullable(2)]
		private TArray<int> _DeviceLevelExtraLodBias;

		// Token: 0x04005DC1 RID: 24001
		internal static int __PropertyOffset_DeviceLevelExtraLodBiasEffectedLevel;

		// Token: 0x04005DC2 RID: 24002
		[Nullable(2)]
		private TArray<int> _DeviceLevelExtraLodBiasEffectedLevel;

		// Token: 0x04005DC3 RID: 24003
		internal static int __PropertyOffset_ScreenSizePC;

		// Token: 0x04005DC4 RID: 24004
		[Nullable(2)]
		private TArray<float> _ScreenSizePC;

		// Token: 0x04005DC5 RID: 24005
		internal static int __PropertyOffset_ScreenSizeMobile;

		// Token: 0x04005DC6 RID: 24006
		[Nullable(2)]
		private TArray<float> _ScreenSizeMobile;

		// Token: 0x04005DC7 RID: 24007
		internal static int __PropertyOffset_SamplingRegionsName;

		// Token: 0x04005DC8 RID: 24008
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SamplingRegionsName;

		// Token: 0x04005DC9 RID: 24009
		internal static int __PropertyOffset_ScreenSizeCullRatio;

		// Token: 0x04005DCA RID: 24010
		internal static int __PropertyOffset_MaxScreenSizeCullRatio;

		// Token: 0x04005DCB RID: 24011
		internal static int __PropertyOffset_BoneNameRegex;

		// Token: 0x04005DCC RID: 24012
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _BoneNameRegex;
	}
}
