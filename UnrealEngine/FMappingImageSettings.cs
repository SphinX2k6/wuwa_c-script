using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027BA RID: 10170
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.MappingImageSettings")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FMappingImageSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025EA2 RID: 155298 RVA: 0x00397AD0 File Offset: 0x00395CD0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMappingImageSettings._ScriptStructPtr != 0) ? FMappingImageSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.MappingImageSettings", ref FMappingImageSettings._ScriptStructPtr);
		}

		// Token: 0x1700922B RID: 37419
		// (get) Token: 0x06025EA3 RID: 155299 RVA: 0x00397AF4 File Offset: 0x00395CF4
		// (set) Token: 0x06025EA4 RID: 155300 RVA: 0x00397B0D File Offset: 0x00395D0D
		public unsafe bool GenerateMappingImage
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_GenerateMappingImage) & FMappingImageSettings.__PropertyMask_GenerateMappingImage) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_GenerateMappingImage) = ((*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_GenerateMappingImage) & ~FMappingImageSettings.__PropertyMask_GenerateMappingImage) | (value ? FMappingImageSettings.__PropertyMask_GenerateMappingImage : 0));
			}
		}

		// Token: 0x1700922C RID: 37420
		// (get) Token: 0x06025EA5 RID: 155301 RVA: 0x00397B3D File Offset: 0x00395D3D
		// (set) Token: 0x06025EA6 RID: 155302 RVA: 0x00397B56 File Offset: 0x00395D56
		public unsafe bool GenerateTexCoords
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_GenerateTexCoords) & FMappingImageSettings.__PropertyMask_GenerateTexCoords) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_GenerateTexCoords) = ((*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_GenerateTexCoords) & ~FMappingImageSettings.__PropertyMask_GenerateTexCoords) | (value ? FMappingImageSettings.__PropertyMask_GenerateTexCoords : 0));
			}
		}

		// Token: 0x1700922D RID: 37421
		// (get) Token: 0x06025EA7 RID: 155303 RVA: 0x00397B86 File Offset: 0x00395D86
		// (set) Token: 0x06025EA8 RID: 155304 RVA: 0x00397B9F File Offset: 0x00395D9F
		public unsafe bool GenerateTangents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_GenerateTangents) & FMappingImageSettings.__PropertyMask_GenerateTangents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_GenerateTangents) = ((*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_GenerateTangents) & ~FMappingImageSettings.__PropertyMask_GenerateTangents) | (value ? FMappingImageSettings.__PropertyMask_GenerateTangents : 0));
			}
		}

		// Token: 0x1700922E RID: 37422
		// (get) Token: 0x06025EA9 RID: 155305 RVA: 0x00397BCF File Offset: 0x00395DCF
		// (set) Token: 0x06025EAA RID: 155306 RVA: 0x00397BE8 File Offset: 0x00395DE8
		public unsafe bool ReplaceMappingImages
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_ReplaceMappingImages) & FMappingImageSettings.__PropertyMask_ReplaceMappingImages) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_ReplaceMappingImages) = ((*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_ReplaceMappingImages) & ~FMappingImageSettings.__PropertyMask_ReplaceMappingImages) | (value ? FMappingImageSettings.__PropertyMask_ReplaceMappingImages : 0));
			}
		}

		// Token: 0x1700922F RID: 37423
		// (get) Token: 0x06025EAB RID: 155307 RVA: 0x00397C18 File Offset: 0x00395E18
		// (set) Token: 0x06025EAC RID: 155308 RVA: 0x00397C31 File Offset: 0x00395E31
		public unsafe bool UseFullRetexturing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_UseFullRetexturing) & FMappingImageSettings.__PropertyMask_UseFullRetexturing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_UseFullRetexturing) = ((*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_UseFullRetexturing) & ~FMappingImageSettings.__PropertyMask_UseFullRetexturing) | (value ? FMappingImageSettings.__PropertyMask_UseFullRetexturing : 0));
			}
		}

		// Token: 0x17009230 RID: 37424
		// (get) Token: 0x06025EAD RID: 155309 RVA: 0x00397C61 File Offset: 0x00395E61
		// (set) Token: 0x06025EAE RID: 155310 RVA: 0x00397C7A File Offset: 0x00395E7A
		public unsafe bool ApplyNewMaterialIds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_ApplyNewMaterialIds) & FMappingImageSettings.__PropertyMask_ApplyNewMaterialIds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_ApplyNewMaterialIds) = ((*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_ApplyNewMaterialIds) & ~FMappingImageSettings.__PropertyMask_ApplyNewMaterialIds) | (value ? FMappingImageSettings.__PropertyMask_ApplyNewMaterialIds : 0));
			}
		}

		// Token: 0x17009231 RID: 37425
		// (get) Token: 0x06025EAF RID: 155311 RVA: 0x00397CAA File Offset: 0x00395EAA
		// (set) Token: 0x06025EB0 RID: 155312 RVA: 0x00397CC3 File Offset: 0x00395EC3
		public unsafe bool UseAutomaticTextureSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_UseAutomaticTextureSize) & FMappingImageSettings.__PropertyMask_UseAutomaticTextureSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_UseAutomaticTextureSize) = ((*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_UseAutomaticTextureSize) & ~FMappingImageSettings.__PropertyMask_UseAutomaticTextureSize) | (value ? FMappingImageSettings.__PropertyMask_UseAutomaticTextureSize : 0));
			}
		}

		// Token: 0x17009232 RID: 37426
		// (get) Token: 0x06025EB1 RID: 155313 RVA: 0x00397CF3 File Offset: 0x00395EF3
		// (set) Token: 0x06025EB2 RID: 155314 RVA: 0x00397D03 File Offset: 0x00395F03
		public unsafe float AutomaticTextureSizeMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_AutomaticTextureSizeMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_AutomaticTextureSizeMultiplier) = value;
			}
		}

		// Token: 0x17009233 RID: 37427
		// (get) Token: 0x06025EB3 RID: 155315 RVA: 0x00397D14 File Offset: 0x00395F14
		// (set) Token: 0x06025EB4 RID: 155316 RVA: 0x00397D2D File Offset: 0x00395F2D
		public unsafe bool ForcePower2Texture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_ForcePower2Texture) & FMappingImageSettings.__PropertyMask_ForcePower2Texture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_ForcePower2Texture) = ((*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_ForcePower2Texture) & ~FMappingImageSettings.__PropertyMask_ForcePower2Texture) | (value ? FMappingImageSettings.__PropertyMask_ForcePower2Texture : 0));
			}
		}

		// Token: 0x17009234 RID: 37428
		// (get) Token: 0x06025EB5 RID: 155317 RVA: 0x00397D5D File Offset: 0x00395F5D
		// (set) Token: 0x06025EB6 RID: 155318 RVA: 0x00397D76 File Offset: 0x00395F76
		public unsafe bool OnlyParameterizeInvalidUVs
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_OnlyParameterizeInvalidUVs) & FMappingImageSettings.__PropertyMask_OnlyParameterizeInvalidUVs) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_OnlyParameterizeInvalidUVs) = ((*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_OnlyParameterizeInvalidUVs) & ~FMappingImageSettings.__PropertyMask_OnlyParameterizeInvalidUVs) | (value ? FMappingImageSettings.__PropertyMask_OnlyParameterizeInvalidUVs : 0));
			}
		}

		// Token: 0x17009235 RID: 37429
		// (get) Token: 0x06025EB7 RID: 155319 RVA: 0x00397DA6 File Offset: 0x00395FA6
		// (set) Token: 0x06025EB8 RID: 155320 RVA: 0x00397DBF File Offset: 0x00395FBF
		public unsafe bool AllowTransparencyMapping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_AllowTransparencyMapping) & FMappingImageSettings.__PropertyMask_AllowTransparencyMapping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_AllowTransparencyMapping) = ((*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_AllowTransparencyMapping) & ~FMappingImageSettings.__PropertyMask_AllowTransparencyMapping) | (value ? FMappingImageSettings.__PropertyMask_AllowTransparencyMapping : 0));
			}
		}

		// Token: 0x17009236 RID: 37430
		// (get) Token: 0x06025EB9 RID: 155321 RVA: 0x00397DEF File Offset: 0x00395FEF
		// (set) Token: 0x06025EBA RID: 155322 RVA: 0x00397DFF File Offset: 0x00395FFF
		public unsafe int MaximumLayers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_MaximumLayers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_MaximumLayers) = value;
			}
		}

		// Token: 0x17009237 RID: 37431
		// (get) Token: 0x06025EBB RID: 155323 RVA: 0x00397E10 File Offset: 0x00396010
		// (set) Token: 0x06025EBC RID: 155324 RVA: 0x00397E20 File Offset: 0x00396020
		public unsafe int TexCoordLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_TexCoordLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_TexCoordLevel) = value;
			}
		}

		// Token: 0x17009238 RID: 37432
		// (get) Token: 0x06025EBD RID: 155325 RVA: 0x00397E31 File Offset: 0x00396031
		// (set) Token: 0x06025EBE RID: 155326 RVA: 0x00397E45 File Offset: 0x00396045
		public unsafe string TexCoordName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMappingImageSettings.__PropertyOffset_TexCoordName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMappingImageSettings.__PropertyOffset_TexCoordName)), value);
			}
		}

		// Token: 0x17009239 RID: 37433
		// (get) Token: 0x06025EBF RID: 155327 RVA: 0x00397E5A File Offset: 0x0039605A
		// (set) Token: 0x06025EC0 RID: 155328 RVA: 0x00397E6A File Offset: 0x0039606A
		public unsafe ETexCoordGeneratorType TexCoordGeneratorType
		{
			get
			{
				return (ETexCoordGeneratorType)(*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_TexCoordGeneratorType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_TexCoordGeneratorType) = (byte)value;
			}
		}

		// Token: 0x1700923A RID: 37434
		// (get) Token: 0x06025EC1 RID: 155329 RVA: 0x00397E7B File Offset: 0x0039607B
		// (set) Token: 0x06025EC2 RID: 155330 RVA: 0x00397E8B File Offset: 0x0039608B
		public unsafe ETangentCalculatorType TangentCalculatorType
		{
			get
			{
				return (ETangentCalculatorType)(*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_TangentCalculatorType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_TangentCalculatorType) = (byte)value;
			}
		}

		// Token: 0x1700923B RID: 37435
		// (get) Token: 0x06025EC3 RID: 155331 RVA: 0x00397E9C File Offset: 0x0039609C
		// (set) Token: 0x06025EC4 RID: 155332 RVA: 0x00397EB5 File Offset: 0x003960B5
		public unsafe bool OverrideTangentCalculator
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_OverrideTangentCalculator) & FMappingImageSettings.__PropertyMask_OverrideTangentCalculator) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_OverrideTangentCalculator) = ((*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_OverrideTangentCalculator) & ~FMappingImageSettings.__PropertyMask_OverrideTangentCalculator) | (value ? FMappingImageSettings.__PropertyMask_OverrideTangentCalculator : 0));
			}
		}

		// Token: 0x1700923C RID: 37436
		// (get) Token: 0x06025EC5 RID: 155333 RVA: 0x00397EE5 File Offset: 0x003960E5
		// (set) Token: 0x06025EC6 RID: 155334 RVA: 0x00397EF5 File Offset: 0x003960F5
		public unsafe int OutputMaterialCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_OutputMaterialCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_OutputMaterialCount) = value;
			}
		}

		// Token: 0x1700923D RID: 37437
		// (get) Token: 0x06025EC7 RID: 155335 RVA: 0x00397F06 File Offset: 0x00396106
		// (set) Token: 0x06025EC8 RID: 155336 RVA: 0x00397F1F File Offset: 0x0039611F
		public unsafe bool TangentCalculatorInvertV
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_TangentCalculatorInvertV) & FMappingImageSettings.__PropertyMask_TangentCalculatorInvertV) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_TangentCalculatorInvertV) = ((*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_TangentCalculatorInvertV) & ~FMappingImageSettings.__PropertyMask_TangentCalculatorInvertV) | (value ? FMappingImageSettings.__PropertyMask_TangentCalculatorInvertV : 0));
			}
		}

		// Token: 0x1700923E RID: 37438
		// (get) Token: 0x06025EC9 RID: 155337 RVA: 0x00397F4F File Offset: 0x0039614F
		// (set) Token: 0x06025ECA RID: 155338 RVA: 0x00397F5F File Offset: 0x0039615F
		public unsafe int InputMaterialCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_InputMaterialCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_InputMaterialCount) = value;
			}
		}

		// Token: 0x1700923F RID: 37439
		// (get) Token: 0x06025ECB RID: 155339 RVA: 0x00397F70 File Offset: 0x00396170
		// (set) Token: 0x06025ECC RID: 155340 RVA: 0x00397FB3 File Offset: 0x003961B3
		public FChartAggregatorSettings ChartAggregatorSettings
		{
			get
			{
				base.FastCheckIsValid();
				FChartAggregatorSettings result;
				if ((result = this._ChartAggregatorSettings) == null)
				{
					result = (this._ChartAggregatorSettings = new FChartAggregatorSettings(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_ChartAggregatorSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FChartAggregatorSettings.StaticStruct(), base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_ChartAggregatorSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009240 RID: 37440
		// (get) Token: 0x06025ECD RID: 155341 RVA: 0x00397FD4 File Offset: 0x003961D4
		// (set) Token: 0x06025ECE RID: 155342 RVA: 0x00398017 File Offset: 0x00396217
		public FParameterizerSettings ParameterizerSettings
		{
			get
			{
				base.FastCheckIsValid();
				FParameterizerSettings result;
				if ((result = this._ParameterizerSettings) == null)
				{
					result = (this._ParameterizerSettings = new FParameterizerSettings(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_ParameterizerSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FParameterizerSettings.StaticStruct(), base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_ParameterizerSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009241 RID: 37441
		// (get) Token: 0x06025ECF RID: 155343 RVA: 0x00398038 File Offset: 0x00396238
		// (set) Token: 0x06025ED0 RID: 155344 RVA: 0x0039807B File Offset: 0x0039627B
		public TArray<FInputMaterialSettings> InputMaterialSettings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInputMaterialSettings> result;
				if ((result = this._InputMaterialSettings) == null)
				{
					result = (this._InputMaterialSettings = new TArray<FInputMaterialSettings>(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_InputMaterialSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InputMaterialSettings.CopyAssign(value);
			}
		}

		// Token: 0x17009242 RID: 37442
		// (get) Token: 0x06025ED1 RID: 155345 RVA: 0x0039808C File Offset: 0x0039628C
		// (set) Token: 0x06025ED2 RID: 155346 RVA: 0x003980CF File Offset: 0x003962CF
		public TArray<FOutputMaterialSettings> OutputMaterialSettings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FOutputMaterialSettings> result;
				if ((result = this._OutputMaterialSettings) == null)
				{
					result = (this._OutputMaterialSettings = new TArray<FOutputMaterialSettings>(base.NativePtr + (IntPtr)FMappingImageSettings.__PropertyOffset_OutputMaterialSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OutputMaterialSettings.CopyAssign(value);
			}
		}

		// Token: 0x06025ED3 RID: 155347 RVA: 0x003980DD File Offset: 0x003962DD
		public FMappingImageSettings()
		{
		}

		// Token: 0x06025ED4 RID: 155348 RVA: 0x003980E8 File Offset: 0x003962E8
		public FMappingImageSettings(bool GenerateMappingImage, bool GenerateTexCoords, bool GenerateTangents, bool ReplaceMappingImages, bool UseFullRetexturing, bool ApplyNewMaterialIds, bool UseAutomaticTextureSize, float AutomaticTextureSizeMultiplier, bool ForcePower2Texture, bool OnlyParameterizeInvalidUVs, bool AllowTransparencyMapping, int MaximumLayers, int TexCoordLevel, string TexCoordName, ETexCoordGeneratorType TexCoordGeneratorType, ETangentCalculatorType TangentCalculatorType, bool OverrideTangentCalculator, int OutputMaterialCount, bool TangentCalculatorInvertV, int InputMaterialCount, FChartAggregatorSettings ChartAggregatorSettings, FParameterizerSettings ParameterizerSettings, TArray<FInputMaterialSettings> InputMaterialSettings, TArray<FOutputMaterialSettings> OutputMaterialSettings)
		{
			this.GenerateMappingImage = GenerateMappingImage;
			this.GenerateTexCoords = GenerateTexCoords;
			this.GenerateTangents = GenerateTangents;
			this.ReplaceMappingImages = ReplaceMappingImages;
			this.UseFullRetexturing = UseFullRetexturing;
			this.ApplyNewMaterialIds = ApplyNewMaterialIds;
			this.UseAutomaticTextureSize = UseAutomaticTextureSize;
			this.AutomaticTextureSizeMultiplier = AutomaticTextureSizeMultiplier;
			this.ForcePower2Texture = ForcePower2Texture;
			this.OnlyParameterizeInvalidUVs = OnlyParameterizeInvalidUVs;
			this.AllowTransparencyMapping = AllowTransparencyMapping;
			this.MaximumLayers = MaximumLayers;
			this.TexCoordLevel = TexCoordLevel;
			this.TexCoordName = TexCoordName;
			this.TexCoordGeneratorType = TexCoordGeneratorType;
			this.TangentCalculatorType = TangentCalculatorType;
			this.OverrideTangentCalculator = OverrideTangentCalculator;
			this.OutputMaterialCount = OutputMaterialCount;
			this.TangentCalculatorInvertV = TangentCalculatorInvertV;
			this.InputMaterialCount = InputMaterialCount;
			this.ChartAggregatorSettings = ChartAggregatorSettings;
			this.ParameterizerSettings = ParameterizerSettings;
			this.InputMaterialSettings = InputMaterialSettings;
			this.OutputMaterialSettings = OutputMaterialSettings;
		}

		// Token: 0x06025ED5 RID: 155349 RVA: 0x003981B8 File Offset: 0x003963B8
		protected override IntPtr GetUStructPtr()
		{
			return FMappingImageSettings.StaticStruct();
		}

		// Token: 0x06025ED6 RID: 155350 RVA: 0x003981C4 File Offset: 0x003963C4
		[NullableContext(2)]
		public FMappingImageSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025ED7 RID: 155351 RVA: 0x003981CE File Offset: 0x003963CE
		public FMappingImageSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025ED8 RID: 155352 RVA: 0x003981D9 File Offset: 0x003963D9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMappingImageSettings(Pointer, false, true);
		}

		// Token: 0x06025ED9 RID: 155353 RVA: 0x003981E3 File Offset: 0x003963E3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMappingImageSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014B14 RID: 84756
		public const string __ObjectPath = "/Script/SimplygonUObjects.MappingImageSettings";

		// Token: 0x04014B15 RID: 84757
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014B16 RID: 84758
		internal static int __PropertyOffset_GenerateMappingImage;

		// Token: 0x04014B17 RID: 84759
		internal static byte __PropertyMask_GenerateMappingImage;

		// Token: 0x04014B18 RID: 84760
		internal static int __PropertyOffset_GenerateTexCoords;

		// Token: 0x04014B19 RID: 84761
		internal static byte __PropertyMask_GenerateTexCoords;

		// Token: 0x04014B1A RID: 84762
		internal static int __PropertyOffset_GenerateTangents;

		// Token: 0x04014B1B RID: 84763
		internal static byte __PropertyMask_GenerateTangents;

		// Token: 0x04014B1C RID: 84764
		internal static int __PropertyOffset_ReplaceMappingImages;

		// Token: 0x04014B1D RID: 84765
		internal static byte __PropertyMask_ReplaceMappingImages;

		// Token: 0x04014B1E RID: 84766
		internal static int __PropertyOffset_UseFullRetexturing;

		// Token: 0x04014B1F RID: 84767
		internal static byte __PropertyMask_UseFullRetexturing;

		// Token: 0x04014B20 RID: 84768
		internal static int __PropertyOffset_ApplyNewMaterialIds;

		// Token: 0x04014B21 RID: 84769
		internal static byte __PropertyMask_ApplyNewMaterialIds;

		// Token: 0x04014B22 RID: 84770
		internal static int __PropertyOffset_UseAutomaticTextureSize;

		// Token: 0x04014B23 RID: 84771
		internal static byte __PropertyMask_UseAutomaticTextureSize;

		// Token: 0x04014B24 RID: 84772
		internal static int __PropertyOffset_AutomaticTextureSizeMultiplier;

		// Token: 0x04014B25 RID: 84773
		internal static int __PropertyOffset_ForcePower2Texture;

		// Token: 0x04014B26 RID: 84774
		internal static byte __PropertyMask_ForcePower2Texture;

		// Token: 0x04014B27 RID: 84775
		internal static int __PropertyOffset_OnlyParameterizeInvalidUVs;

		// Token: 0x04014B28 RID: 84776
		internal static byte __PropertyMask_OnlyParameterizeInvalidUVs;

		// Token: 0x04014B29 RID: 84777
		internal static int __PropertyOffset_AllowTransparencyMapping;

		// Token: 0x04014B2A RID: 84778
		internal static byte __PropertyMask_AllowTransparencyMapping;

		// Token: 0x04014B2B RID: 84779
		internal static int __PropertyOffset_MaximumLayers;

		// Token: 0x04014B2C RID: 84780
		internal static int __PropertyOffset_TexCoordLevel;

		// Token: 0x04014B2D RID: 84781
		internal static int __PropertyOffset_TexCoordName;

		// Token: 0x04014B2E RID: 84782
		internal static int __PropertyOffset_TexCoordGeneratorType;

		// Token: 0x04014B2F RID: 84783
		internal static int __PropertyOffset_TangentCalculatorType;

		// Token: 0x04014B30 RID: 84784
		internal static int __PropertyOffset_OverrideTangentCalculator;

		// Token: 0x04014B31 RID: 84785
		internal static byte __PropertyMask_OverrideTangentCalculator;

		// Token: 0x04014B32 RID: 84786
		internal static int __PropertyOffset_OutputMaterialCount;

		// Token: 0x04014B33 RID: 84787
		internal static int __PropertyOffset_TangentCalculatorInvertV;

		// Token: 0x04014B34 RID: 84788
		internal static byte __PropertyMask_TangentCalculatorInvertV;

		// Token: 0x04014B35 RID: 84789
		internal static int __PropertyOffset_InputMaterialCount;

		// Token: 0x04014B36 RID: 84790
		internal static int __PropertyOffset_ChartAggregatorSettings;

		// Token: 0x04014B37 RID: 84791
		[Nullable(2)]
		private FChartAggregatorSettings _ChartAggregatorSettings;

		// Token: 0x04014B38 RID: 84792
		internal static int __PropertyOffset_ParameterizerSettings;

		// Token: 0x04014B39 RID: 84793
		[Nullable(2)]
		private FParameterizerSettings _ParameterizerSettings;

		// Token: 0x04014B3A RID: 84794
		internal static int __PropertyOffset_InputMaterialSettings;

		// Token: 0x04014B3B RID: 84795
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FInputMaterialSettings> _InputMaterialSettings;

		// Token: 0x04014B3C RID: 84796
		internal static int __PropertyOffset_OutputMaterialSettings;

		// Token: 0x04014B3D RID: 84797
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FOutputMaterialSettings> _OutputMaterialSettings;
	}
}
