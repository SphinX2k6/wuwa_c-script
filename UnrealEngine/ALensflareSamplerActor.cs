using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BF5 RID: 7157
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.LensflareSamplerActor")]
	[UnrealStructLayout(1344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1344)]
	public class ALensflareSamplerActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B91E RID: 112926 RVA: 0x00289532 File Offset: 0x00287732
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALensflareSamplerActor._ClassPtr;
		}

		// Token: 0x0601B91F RID: 112927 RVA: 0x00289540 File Offset: 0x00287740
		public ALensflareSamplerActor() : this(BuiltinUtils.AllocNativeUObject(ALensflareSamplerActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B920 RID: 112928 RVA: 0x00289568 File Offset: 0x00287768
		[NullableContext(1)]
		public ALensflareSamplerActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALensflareSamplerActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006F05 RID: 28421
		// (get) Token: 0x0601B921 RID: 112929 RVA: 0x0028959B File Offset: 0x0028779B
		// (set) Token: 0x0601B922 RID: 112930 RVA: 0x002895AB File Offset: 0x002877AB
		public unsafe float VisibleRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_VisibleRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_VisibleRadius) = value;
			}
		}

		// Token: 0x17006F06 RID: 28422
		// (get) Token: 0x0601B923 RID: 112931 RVA: 0x002895BC File Offset: 0x002877BC
		// (set) Token: 0x0601B924 RID: 112932 RVA: 0x002895CC File Offset: 0x002877CC
		public unsafe float OccludeRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_OccludeRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_OccludeRadius) = value;
			}
		}

		// Token: 0x17006F07 RID: 28423
		// (get) Token: 0x0601B925 RID: 112933 RVA: 0x002895DD File Offset: 0x002877DD
		// (set) Token: 0x0601B926 RID: 112934 RVA: 0x002895ED File Offset: 0x002877ED
		public unsafe float BrightnessThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_BrightnessThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_BrightnessThreshold) = value;
			}
		}

		// Token: 0x17006F08 RID: 28424
		// (get) Token: 0x0601B927 RID: 112935 RVA: 0x002895FE File Offset: 0x002877FE
		// (set) Token: 0x0601B928 RID: 112936 RVA: 0x0028960E File Offset: 0x0028780E
		public unsafe float BrightnessThresholdRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_BrightnessThresholdRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_BrightnessThresholdRange) = value;
			}
		}

		// Token: 0x17006F09 RID: 28425
		// (get) Token: 0x0601B929 RID: 112937 RVA: 0x0028961F File Offset: 0x0028781F
		// (set) Token: 0x0601B92A RID: 112938 RVA: 0x00289633 File Offset: 0x00287833
		public unsafe USunLensFlareConfig Config
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USunLensFlareConfig>(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_Config);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_Config, value);
			}
		}

		// Token: 0x17006F0A RID: 28426
		// (get) Token: 0x0601B92B RID: 112939 RVA: 0x00289648 File Offset: 0x00287848
		// (set) Token: 0x0601B92C RID: 112940 RVA: 0x00289661 File Offset: 0x00287861
		public unsafe bool bOverrideGhost
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_bOverrideGhost) & ALensflareSamplerActor.__PropertyMask_bOverrideGhost) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_bOverrideGhost) = ((*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_bOverrideGhost) & ~ALensflareSamplerActor.__PropertyMask_bOverrideGhost) | (value ? ALensflareSamplerActor.__PropertyMask_bOverrideGhost : 0));
			}
		}

		// Token: 0x17006F0B RID: 28427
		// (get) Token: 0x0601B92D RID: 112941 RVA: 0x00289691 File Offset: 0x00287891
		// (set) Token: 0x0601B92E RID: 112942 RVA: 0x002896A5 File Offset: 0x002878A5
		public unsafe UStaticMesh GhostMeshOverride
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_GhostMeshOverride);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_GhostMeshOverride, value);
			}
		}

		// Token: 0x17006F0C RID: 28428
		// (get) Token: 0x0601B92F RID: 112943 RVA: 0x002896BA File Offset: 0x002878BA
		// (set) Token: 0x0601B930 RID: 112944 RVA: 0x002896CE File Offset: 0x002878CE
		public unsafe UMaterialInterface GhostMaterialOverride
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_GhostMaterialOverride);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_GhostMaterialOverride, value);
			}
		}

		// Token: 0x17006F0D RID: 28429
		// (get) Token: 0x0601B931 RID: 112945 RVA: 0x002896E3 File Offset: 0x002878E3
		// (set) Token: 0x0601B932 RID: 112946 RVA: 0x002896FC File Offset: 0x002878FC
		public unsafe bool bOverrideHalo
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_bOverrideHalo) & ALensflareSamplerActor.__PropertyMask_bOverrideHalo) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_bOverrideHalo) = ((*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_bOverrideHalo) & ~ALensflareSamplerActor.__PropertyMask_bOverrideHalo) | (value ? ALensflareSamplerActor.__PropertyMask_bOverrideHalo : 0));
			}
		}

		// Token: 0x17006F0E RID: 28430
		// (get) Token: 0x0601B933 RID: 112947 RVA: 0x0028972C File Offset: 0x0028792C
		// (set) Token: 0x0601B934 RID: 112948 RVA: 0x00289740 File Offset: 0x00287940
		public unsafe UStaticMesh HaloMeshOverride
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_HaloMeshOverride);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_HaloMeshOverride, value);
			}
		}

		// Token: 0x17006F0F RID: 28431
		// (get) Token: 0x0601B935 RID: 112949 RVA: 0x00289755 File Offset: 0x00287955
		// (set) Token: 0x0601B936 RID: 112950 RVA: 0x00289769 File Offset: 0x00287969
		public unsafe UMaterialInterface HaloMaterialOverride
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_HaloMaterialOverride);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_HaloMaterialOverride, value);
			}
		}

		// Token: 0x17006F10 RID: 28432
		// (get) Token: 0x0601B937 RID: 112951 RVA: 0x0028977E File Offset: 0x0028797E
		// (set) Token: 0x0601B938 RID: 112952 RVA: 0x00289797 File Offset: 0x00287997
		public unsafe bool bOverrideGlare
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_bOverrideGlare) & ALensflareSamplerActor.__PropertyMask_bOverrideGlare) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_bOverrideGlare) = ((*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_bOverrideGlare) & ~ALensflareSamplerActor.__PropertyMask_bOverrideGlare) | (value ? ALensflareSamplerActor.__PropertyMask_bOverrideGlare : 0));
			}
		}

		// Token: 0x17006F11 RID: 28433
		// (get) Token: 0x0601B939 RID: 112953 RVA: 0x002897C7 File Offset: 0x002879C7
		// (set) Token: 0x0601B93A RID: 112954 RVA: 0x002897DB File Offset: 0x002879DB
		public unsafe UStaticMesh GlareMeshOverride
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_GlareMeshOverride);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_GlareMeshOverride, value);
			}
		}

		// Token: 0x17006F12 RID: 28434
		// (get) Token: 0x0601B93B RID: 112955 RVA: 0x002897F0 File Offset: 0x002879F0
		// (set) Token: 0x0601B93C RID: 112956 RVA: 0x00289804 File Offset: 0x00287A04
		public unsafe UMaterialInterface GlareMaterialOverride
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_GlareMaterialOverride);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_GlareMaterialOverride, value);
			}
		}

		// Token: 0x17006F13 RID: 28435
		// (get) Token: 0x0601B93D RID: 112957 RVA: 0x00289819 File Offset: 0x00287A19
		// (set) Token: 0x0601B93E RID: 112958 RVA: 0x00289829 File Offset: 0x00287A29
		public unsafe bool bSequenceMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_bSequenceMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_bSequenceMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F14 RID: 28436
		// (get) Token: 0x0601B93F RID: 112959 RVA: 0x0028983A File Offset: 0x00287A3A
		// (set) Token: 0x0601B940 RID: 112960 RVA: 0x0028984A File Offset: 0x00287A4A
		public unsafe bool bCustomActorPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_bCustomActorPosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_bCustomActorPosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F15 RID: 28437
		// (get) Token: 0x0601B941 RID: 112961 RVA: 0x0028985B File Offset: 0x00287A5B
		// (set) Token: 0x0601B942 RID: 112962 RVA: 0x0028986B File Offset: 0x00287A6B
		public unsafe bool bSequenceModeFullControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_bSequenceModeFullControl) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_bSequenceModeFullControl) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F16 RID: 28438
		// (get) Token: 0x0601B943 RID: 112963 RVA: 0x0028987C File Offset: 0x00287A7C
		// (set) Token: 0x0601B944 RID: 112964 RVA: 0x00289890 File Offset: 0x00287A90
		public unsafe FLinearColor SequenceColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_SequenceColorTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_SequenceColorTint) = value;
			}
		}

		// Token: 0x17006F17 RID: 28439
		// (get) Token: 0x0601B945 RID: 112965 RVA: 0x002898A5 File Offset: 0x00287AA5
		// (set) Token: 0x0601B946 RID: 112966 RVA: 0x002898B5 File Offset: 0x00287AB5
		public unsafe float SequenceAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_SequenceAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_SequenceAlpha) = value;
			}
		}

		// Token: 0x17006F18 RID: 28440
		// (get) Token: 0x0601B947 RID: 112967 RVA: 0x002898C6 File Offset: 0x00287AC6
		// (set) Token: 0x0601B948 RID: 112968 RVA: 0x002898DA File Offset: 0x00287ADA
		public unsafe FLinearColor GhostSequenceColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_GhostSequenceColorTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_GhostSequenceColorTint) = value;
			}
		}

		// Token: 0x17006F19 RID: 28441
		// (get) Token: 0x0601B949 RID: 112969 RVA: 0x002898EF File Offset: 0x00287AEF
		// (set) Token: 0x0601B94A RID: 112970 RVA: 0x002898FF File Offset: 0x00287AFF
		public unsafe float GhostSequenceAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_GhostSequenceAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_GhostSequenceAlpha) = value;
			}
		}

		// Token: 0x17006F1A RID: 28442
		// (get) Token: 0x0601B94B RID: 112971 RVA: 0x00289910 File Offset: 0x00287B10
		// (set) Token: 0x0601B94C RID: 112972 RVA: 0x00289920 File Offset: 0x00287B20
		public unsafe float GhostSequenceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_GhostSequenceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_GhostSequenceScale) = value;
			}
		}

		// Token: 0x17006F1B RID: 28443
		// (get) Token: 0x0601B94D RID: 112973 RVA: 0x00289931 File Offset: 0x00287B31
		// (set) Token: 0x0601B94E RID: 112974 RVA: 0x00289945 File Offset: 0x00287B45
		public unsafe FVector2D GhostScreenCenterBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_GhostScreenCenterBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_GhostScreenCenterBias) = value;
			}
		}

		// Token: 0x17006F1C RID: 28444
		// (get) Token: 0x0601B94F RID: 112975 RVA: 0x0028995A File Offset: 0x00287B5A
		// (set) Token: 0x0601B950 RID: 112976 RVA: 0x0028996E File Offset: 0x00287B6E
		public unsafe FLinearColor HaloSequenceColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_HaloSequenceColorTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_HaloSequenceColorTint) = value;
			}
		}

		// Token: 0x17006F1D RID: 28445
		// (get) Token: 0x0601B951 RID: 112977 RVA: 0x00289983 File Offset: 0x00287B83
		// (set) Token: 0x0601B952 RID: 112978 RVA: 0x00289993 File Offset: 0x00287B93
		public unsafe float HaloSequenceAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_HaloSequenceAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_HaloSequenceAlpha) = value;
			}
		}

		// Token: 0x17006F1E RID: 28446
		// (get) Token: 0x0601B953 RID: 112979 RVA: 0x002899A4 File Offset: 0x00287BA4
		// (set) Token: 0x0601B954 RID: 112980 RVA: 0x002899B4 File Offset: 0x00287BB4
		public unsafe float HaloSequenceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_HaloSequenceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_HaloSequenceScale) = value;
			}
		}

		// Token: 0x17006F1F RID: 28447
		// (get) Token: 0x0601B955 RID: 112981 RVA: 0x002899C5 File Offset: 0x00287BC5
		// (set) Token: 0x0601B956 RID: 112982 RVA: 0x002899D9 File Offset: 0x00287BD9
		public unsafe FVector2D HaloScreenCenterBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_HaloScreenCenterBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_HaloScreenCenterBias) = value;
			}
		}

		// Token: 0x17006F20 RID: 28448
		// (get) Token: 0x0601B957 RID: 112983 RVA: 0x002899EE File Offset: 0x00287BEE
		// (set) Token: 0x0601B958 RID: 112984 RVA: 0x00289A02 File Offset: 0x00287C02
		public unsafe FLinearColor GlareSequenceColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_GlareSequenceColorTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_GlareSequenceColorTint) = value;
			}
		}

		// Token: 0x17006F21 RID: 28449
		// (get) Token: 0x0601B959 RID: 112985 RVA: 0x00289A17 File Offset: 0x00287C17
		// (set) Token: 0x0601B95A RID: 112986 RVA: 0x00289A27 File Offset: 0x00287C27
		public unsafe float GlareSequenceAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_GlareSequenceAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_GlareSequenceAlpha) = value;
			}
		}

		// Token: 0x17006F22 RID: 28450
		// (get) Token: 0x0601B95B RID: 112987 RVA: 0x00289A38 File Offset: 0x00287C38
		// (set) Token: 0x0601B95C RID: 112988 RVA: 0x00289A4C File Offset: 0x00287C4C
		public unsafe FVector2D GlareSequenceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_GlareSequenceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_GlareSequenceScale) = value;
			}
		}

		// Token: 0x17006F23 RID: 28451
		// (get) Token: 0x0601B95D RID: 112989 RVA: 0x00289A61 File Offset: 0x00287C61
		// (set) Token: 0x0601B95E RID: 112990 RVA: 0x00289A75 File Offset: 0x00287C75
		public unsafe UMaterialInterface FinalGhostMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_FinalGhostMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_FinalGhostMaterial, value);
			}
		}

		// Token: 0x17006F24 RID: 28452
		// (get) Token: 0x0601B95F RID: 112991 RVA: 0x00289A8A File Offset: 0x00287C8A
		// (set) Token: 0x0601B960 RID: 112992 RVA: 0x00289A9E File Offset: 0x00287C9E
		public unsafe UMaterialInterface FinalHaloMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_FinalHaloMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_FinalHaloMaterial, value);
			}
		}

		// Token: 0x17006F25 RID: 28453
		// (get) Token: 0x0601B961 RID: 112993 RVA: 0x00289AB3 File Offset: 0x00287CB3
		// (set) Token: 0x0601B962 RID: 112994 RVA: 0x00289AC7 File Offset: 0x00287CC7
		public unsafe UMaterialInterface FinalGlareMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_FinalGlareMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_FinalGlareMaterial, value);
			}
		}

		// Token: 0x17006F26 RID: 28454
		// (get) Token: 0x0601B963 RID: 112995 RVA: 0x00289ADC File Offset: 0x00287CDC
		// (set) Token: 0x0601B964 RID: 112996 RVA: 0x00289AEC File Offset: 0x00287CEC
		public unsafe int CurrentSceneSampleIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_CurrentSceneSampleIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_CurrentSceneSampleIndex) = value;
			}
		}

		// Token: 0x17006F27 RID: 28455
		// (get) Token: 0x0601B965 RID: 112997 RVA: 0x00289AFD File Offset: 0x00287CFD
		// (set) Token: 0x0601B966 RID: 112998 RVA: 0x00289B0D File Offset: 0x00287D0D
		public unsafe float CurrentDistanceFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_CurrentDistanceFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALensflareSamplerActor.__PropertyOffset_CurrentDistanceFactor) = value;
			}
		}

		// Token: 0x17006F28 RID: 28456
		// (get) Token: 0x0601B967 RID: 112999 RVA: 0x00289B1E File Offset: 0x00287D1E
		// (set) Token: 0x0601B968 RID: 113000 RVA: 0x00289B32 File Offset: 0x00287D32
		public unsafe USceneComponent SceneComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_SceneComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_SceneComponent, value);
			}
		}

		// Token: 0x17006F29 RID: 28457
		// (get) Token: 0x0601B969 RID: 113001 RVA: 0x00289B47 File Offset: 0x00287D47
		// (set) Token: 0x0601B96A RID: 113002 RVA: 0x00289B5B File Offset: 0x00287D5B
		public unsafe UStaticMeshComponent LensflareGhostComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_LensflareGhostComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_LensflareGhostComponent, value);
			}
		}

		// Token: 0x17006F2A RID: 28458
		// (get) Token: 0x0601B96B RID: 113003 RVA: 0x00289B70 File Offset: 0x00287D70
		// (set) Token: 0x0601B96C RID: 113004 RVA: 0x00289B84 File Offset: 0x00287D84
		public unsafe UStaticMeshComponent LensflareGlareComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_LensflareGlareComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_LensflareGlareComponent, value);
			}
		}

		// Token: 0x17006F2B RID: 28459
		// (get) Token: 0x0601B96D RID: 113005 RVA: 0x00289B99 File Offset: 0x00287D99
		// (set) Token: 0x0601B96E RID: 113006 RVA: 0x00289BAD File Offset: 0x00287DAD
		public unsafe UStaticMeshComponent LensflareHaloComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_LensflareHaloComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALensflareSamplerActor.__PropertyOffset_LensflareHaloComponent, value);
			}
		}

		// Token: 0x0601B96F RID: 113007 RVA: 0x00289BC2 File Offset: 0x00287DC2
		public void ResetLensflareSamplerActor()
		{
			ALensflareSamplerActor.__ResetLensflareSamplerActor_Internal(base.NativePtr);
		}

		// Token: 0x0601B970 RID: 113008 RVA: 0x00289BCF File Offset: 0x00287DCF
		[NullableContext(1)]
		public virtual FLensflareSamplerActorParameter GetLensflareParameter()
		{
			return new FLensflareSamplerActorParameter(ALensflareSamplerActor.__GetLensflareParameter_Internal(base.NativePtr), null);
		}

		// Token: 0x0601B971 RID: 113009 RVA: 0x00289BE2 File Offset: 0x00287DE2
		[NullableContext(1)]
		public virtual FLensflareSamplerActorHaloParameter GetCustomHaloParameter()
		{
			return new FLensflareSamplerActorHaloParameter(ALensflareSamplerActor.__GetCustomHaloParameter_Internal(base.NativePtr), null);
		}

		// Token: 0x0601B972 RID: 113010 RVA: 0x00289BF5 File Offset: 0x00287DF5
		[NullableContext(1)]
		public virtual FLensflareSamplerActorGlareParameter GetCustomGlareParameter()
		{
			return new FLensflareSamplerActorGlareParameter(ALensflareSamplerActor.__GetCustomGlareParameter_Internal(base.NativePtr), null);
		}

		// Token: 0x0601B973 RID: 113011 RVA: 0x00289C08 File Offset: 0x00287E08
		[NullableContext(1)]
		public virtual FLensflareSamplerActorGhostParameter GetCustomGhostParameter()
		{
			return new FLensflareSamplerActorGhostParameter(ALensflareSamplerActor.__GetCustomGhostParameter_Internal(base.NativePtr), null);
		}

		// Token: 0x0601B974 RID: 113012 RVA: 0x00289C1B File Offset: 0x00287E1B
		public virtual void ApplyDynamicMaterialHalo(UMaterialInstanceDynamic DynMaterial)
		{
			ALensflareSamplerActor.__ApplyDynamicMaterialHalo_Internal(base.NativePtr, (DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601B975 RID: 113013 RVA: 0x00289C38 File Offset: 0x00287E38
		public virtual void ApplyDynamicMaterialGlare(UMaterialInstanceDynamic DynMaterial)
		{
			ALensflareSamplerActor.__ApplyDynamicMaterialGlare_Internal(base.NativePtr, (DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601B976 RID: 113014 RVA: 0x00289C55 File Offset: 0x00287E55
		public virtual void ApplyDynamicMaterialGhost(UMaterialInstanceDynamic DynMaterial)
		{
			ALensflareSamplerActor.__ApplyDynamicMaterialGhost_Internal(base.NativePtr, (DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601B977 RID: 113015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetLensflareSamplerActor_Internal(IntPtr @this);

		// Token: 0x0601B978 RID: 113016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLensflareParameter_Internal(IntPtr @this);

		// Token: 0x0601B979 RID: 113017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCustomHaloParameter_Internal(IntPtr @this);

		// Token: 0x0601B97A RID: 113018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCustomGlareParameter_Internal(IntPtr @this);

		// Token: 0x0601B97B RID: 113019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCustomGhostParameter_Internal(IntPtr @this);

		// Token: 0x0601B97C RID: 113020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyDynamicMaterialHalo_Internal(IntPtr @this, IntPtr DynMaterial);

		// Token: 0x0601B97D RID: 113021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyDynamicMaterialGlare_Internal(IntPtr @this, IntPtr DynMaterial);

		// Token: 0x0601B97E RID: 113022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyDynamicMaterialGhost_Internal(IntPtr @this, IntPtr DynMaterial);

		// Token: 0x0601B97F RID: 113023 RVA: 0x00289C72 File Offset: 0x00287E72
		static ALensflareSamplerActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.LensflareSamplerActor");
		}

		// Token: 0x0601B980 RID: 113024 RVA: 0x00289C80 File Offset: 0x00287E80
		protected ALensflareSamplerActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ED41 RID: 60737
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.LensflareSamplerActor";

		// Token: 0x0400ED42 RID: 60738
		private static IntPtr _ClassPtr;

		// Token: 0x0400ED43 RID: 60739
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ED44 RID: 60740
		internal static int __PropertyOffset_VisibleRadius;

		// Token: 0x0400ED45 RID: 60741
		internal static int __PropertyOffset_OccludeRadius;

		// Token: 0x0400ED46 RID: 60742
		internal static int __PropertyOffset_BrightnessThreshold;

		// Token: 0x0400ED47 RID: 60743
		internal static int __PropertyOffset_BrightnessThresholdRange;

		// Token: 0x0400ED48 RID: 60744
		internal static int __PropertyOffset_Config;

		// Token: 0x0400ED49 RID: 60745
		internal static int __PropertyOffset_bOverrideGhost;

		// Token: 0x0400ED4A RID: 60746
		internal static byte __PropertyMask_bOverrideGhost;

		// Token: 0x0400ED4B RID: 60747
		internal static int __PropertyOffset_GhostMeshOverride;

		// Token: 0x0400ED4C RID: 60748
		internal static int __PropertyOffset_GhostMaterialOverride;

		// Token: 0x0400ED4D RID: 60749
		internal static int __PropertyOffset_bOverrideHalo;

		// Token: 0x0400ED4E RID: 60750
		internal static byte __PropertyMask_bOverrideHalo;

		// Token: 0x0400ED4F RID: 60751
		internal static int __PropertyOffset_HaloMeshOverride;

		// Token: 0x0400ED50 RID: 60752
		internal static int __PropertyOffset_HaloMaterialOverride;

		// Token: 0x0400ED51 RID: 60753
		internal static int __PropertyOffset_bOverrideGlare;

		// Token: 0x0400ED52 RID: 60754
		internal static byte __PropertyMask_bOverrideGlare;

		// Token: 0x0400ED53 RID: 60755
		internal static int __PropertyOffset_GlareMeshOverride;

		// Token: 0x0400ED54 RID: 60756
		internal static int __PropertyOffset_GlareMaterialOverride;

		// Token: 0x0400ED55 RID: 60757
		internal static int __PropertyOffset_bSequenceMode;

		// Token: 0x0400ED56 RID: 60758
		internal static int __PropertyOffset_bCustomActorPosition;

		// Token: 0x0400ED57 RID: 60759
		internal static int __PropertyOffset_bSequenceModeFullControl;

		// Token: 0x0400ED58 RID: 60760
		internal static int __PropertyOffset_SequenceColorTint;

		// Token: 0x0400ED59 RID: 60761
		internal static int __PropertyOffset_SequenceAlpha;

		// Token: 0x0400ED5A RID: 60762
		internal static int __PropertyOffset_GhostSequenceColorTint;

		// Token: 0x0400ED5B RID: 60763
		internal static int __PropertyOffset_GhostSequenceAlpha;

		// Token: 0x0400ED5C RID: 60764
		internal static int __PropertyOffset_GhostSequenceScale;

		// Token: 0x0400ED5D RID: 60765
		internal static int __PropertyOffset_GhostScreenCenterBias;

		// Token: 0x0400ED5E RID: 60766
		internal static int __PropertyOffset_HaloSequenceColorTint;

		// Token: 0x0400ED5F RID: 60767
		internal static int __PropertyOffset_HaloSequenceAlpha;

		// Token: 0x0400ED60 RID: 60768
		internal static int __PropertyOffset_HaloSequenceScale;

		// Token: 0x0400ED61 RID: 60769
		internal static int __PropertyOffset_HaloScreenCenterBias;

		// Token: 0x0400ED62 RID: 60770
		internal static int __PropertyOffset_GlareSequenceColorTint;

		// Token: 0x0400ED63 RID: 60771
		internal static int __PropertyOffset_GlareSequenceAlpha;

		// Token: 0x0400ED64 RID: 60772
		internal static int __PropertyOffset_GlareSequenceScale;

		// Token: 0x0400ED65 RID: 60773
		internal static int __PropertyOffset_FinalGhostMaterial;

		// Token: 0x0400ED66 RID: 60774
		internal static int __PropertyOffset_FinalHaloMaterial;

		// Token: 0x0400ED67 RID: 60775
		internal static int __PropertyOffset_FinalGlareMaterial;

		// Token: 0x0400ED68 RID: 60776
		internal static int __PropertyOffset_CurrentSceneSampleIndex;

		// Token: 0x0400ED69 RID: 60777
		internal static int __PropertyOffset_CurrentDistanceFactor;

		// Token: 0x0400ED6A RID: 60778
		internal static int __PropertyOffset_SceneComponent;

		// Token: 0x0400ED6B RID: 60779
		internal static int __PropertyOffset_LensflareGhostComponent;

		// Token: 0x0400ED6C RID: 60780
		internal static int __PropertyOffset_LensflareGlareComponent;

		// Token: 0x0400ED6D RID: 60781
		internal static int __PropertyOffset_LensflareHaloComponent;

		// Token: 0x02003190 RID: 12688
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetLensflareParameter_FunctionParams
		{
			// Token: 0x04016FCE RID: 94158
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003191 RID: 12689
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __GetCustomHaloParameter_FunctionParams
		{
			// Token: 0x04016FCF RID: 94159
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003192 RID: 12690
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetCustomGlareParameter_FunctionParams
		{
			// Token: 0x04016FD0 RID: 94160
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003193 RID: 12691
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetCustomGhostParameter_FunctionParams
		{
			// Token: 0x04016FD1 RID: 94161
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003194 RID: 12692
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ApplyDynamicMaterialHalo_FunctionParams
		{
			// Token: 0x04016FD2 RID: 94162
			[FieldOffset(0)]
			public IntPtr DynMaterial;
		}

		// Token: 0x02003195 RID: 12693
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ApplyDynamicMaterialGlare_FunctionParams
		{
			// Token: 0x04016FD3 RID: 94163
			[FieldOffset(0)]
			public IntPtr DynMaterial;
		}

		// Token: 0x02003196 RID: 12694
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ApplyDynamicMaterialGhost_FunctionParams
		{
			// Token: 0x04016FD4 RID: 94164
			[FieldOffset(0)]
			public IntPtr DynMaterial;
		}
	}
}
