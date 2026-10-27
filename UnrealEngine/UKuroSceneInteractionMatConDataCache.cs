using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BAA RID: 7082
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionMatConDataCache")]
	[UnrealStructLayout(5224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 5224)]
	public class UKuroSceneInteractionMatConDataCache : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B150 RID: 110928 RVA: 0x0027E69B File Offset: 0x0027C89B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSceneInteractionMatConDataCache._ClassPtr;
		}

		// Token: 0x0601B151 RID: 110929 RVA: 0x0027E6A8 File Offset: 0x0027C8A8
		public UKuroSceneInteractionMatConDataCache() : this(BuiltinUtils.AllocNativeUObject(UKuroSceneInteractionMatConDataCache.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B152 RID: 110930 RVA: 0x0027E6D0 File Offset: 0x0027C8D0
		public UKuroSceneInteractionMatConDataCache(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSceneInteractionMatConDataCache.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C86 RID: 27782
		// (get) Token: 0x0601B153 RID: 110931 RVA: 0x0027E703 File Offset: 0x0027C903
		// (set) Token: 0x0601B154 RID: 110932 RVA: 0x0027E713 File Offset: 0x0027C913
		public unsafe int Version
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_Version);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_Version) = value;
			}
		}

		// Token: 0x17006C87 RID: 27783
		// (get) Token: 0x0601B155 RID: 110933 RVA: 0x0027E724 File Offset: 0x0027C924
		// (set) Token: 0x0601B156 RID: 110934 RVA: 0x0027E75D File Offset: 0x0027C95D
		public FKuroInterpolateRangeTime_SI RangeTime
		{
			get
			{
				base.FastCheckIsValid();
				FKuroInterpolateRangeTime_SI result;
				if ((result = this._RangeTime) == null)
				{
					result = (this._RangeTime = new FKuroInterpolateRangeTime_SI(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_RangeTime, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroInterpolateRangeTime_SI.StaticStruct(), base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_RangeTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006C88 RID: 27784
		// (get) Token: 0x0601B157 RID: 110935 RVA: 0x0027E77E File Offset: 0x0027C97E
		// (set) Token: 0x0601B158 RID: 110936 RVA: 0x0027E78E File Offset: 0x0027C98E
		public unsafe bool bUseRim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_bUseRim) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_bUseRim) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C89 RID: 27785
		// (get) Token: 0x0601B159 RID: 110937 RVA: 0x0027E79F File Offset: 0x0027C99F
		// (set) Token: 0x0601B15A RID: 110938 RVA: 0x0027E7AF File Offset: 0x0027C9AF
		public unsafe bool bUseBaseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_bUseBaseColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_bUseBaseColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C8A RID: 27786
		// (get) Token: 0x0601B15B RID: 110939 RVA: 0x0027E7C0 File Offset: 0x0027C9C0
		// (set) Token: 0x0601B15C RID: 110940 RVA: 0x0027E7D0 File Offset: 0x0027C9D0
		public unsafe bool bUseAddEmission
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_bUseAddEmission) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_bUseAddEmission) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C8B RID: 27787
		// (get) Token: 0x0601B15D RID: 110941 RVA: 0x0027E7E1 File Offset: 0x0027C9E1
		// (set) Token: 0x0601B15E RID: 110942 RVA: 0x0027E7F1 File Offset: 0x0027C9F1
		public unsafe bool bUseEmissionChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_bUseEmissionChange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_bUseEmissionChange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C8C RID: 27788
		// (get) Token: 0x0601B15F RID: 110943 RVA: 0x0027E802 File Offset: 0x0027CA02
		// (set) Token: 0x0601B160 RID: 110944 RVA: 0x0027E812 File Offset: 0x0027CA12
		public unsafe bool bUseDissolve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_bUseDissolve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_bUseDissolve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C8D RID: 27789
		// (get) Token: 0x0601B161 RID: 110945 RVA: 0x0027E823 File Offset: 0x0027CA23
		// (set) Token: 0x0601B162 RID: 110946 RVA: 0x0027E833 File Offset: 0x0027CA33
		public unsafe bool bUseCustom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_bUseCustom) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_bUseCustom) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C8E RID: 27790
		// (get) Token: 0x0601B163 RID: 110947 RVA: 0x0027E844 File Offset: 0x0027CA44
		// (set) Token: 0x0601B164 RID: 110948 RVA: 0x0027E87D File Offset: 0x0027CA7D
		public FKuroMaterialControllerParam_SI_Rim RimParam
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialControllerParam_SI_Rim result;
				if ((result = this._RimParam) == null)
				{
					result = (this._RimParam = new FKuroMaterialControllerParam_SI_Rim(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_RimParam, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialControllerParam_SI_Rim.StaticStruct(), base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_RimParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006C8F RID: 27791
		// (get) Token: 0x0601B165 RID: 110949 RVA: 0x0027E8A0 File Offset: 0x0027CAA0
		// (set) Token: 0x0601B166 RID: 110950 RVA: 0x0027E8D9 File Offset: 0x0027CAD9
		public FKuroMaterialControllerParam_SI_BaseColor BaseColorParam
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialControllerParam_SI_BaseColor result;
				if ((result = this._BaseColorParam) == null)
				{
					result = (this._BaseColorParam = new FKuroMaterialControllerParam_SI_BaseColor(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_BaseColorParam, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialControllerParam_SI_BaseColor.StaticStruct(), base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_BaseColorParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006C90 RID: 27792
		// (get) Token: 0x0601B167 RID: 110951 RVA: 0x0027E8FC File Offset: 0x0027CAFC
		// (set) Token: 0x0601B168 RID: 110952 RVA: 0x0027E935 File Offset: 0x0027CB35
		public FKuroMaterialControllerParam_SI_AddEmission AddEmissionParam
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialControllerParam_SI_AddEmission result;
				if ((result = this._AddEmissionParam) == null)
				{
					result = (this._AddEmissionParam = new FKuroMaterialControllerParam_SI_AddEmission(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_AddEmissionParam, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialControllerParam_SI_AddEmission.StaticStruct(), base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_AddEmissionParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006C91 RID: 27793
		// (get) Token: 0x0601B169 RID: 110953 RVA: 0x0027E958 File Offset: 0x0027CB58
		// (set) Token: 0x0601B16A RID: 110954 RVA: 0x0027E991 File Offset: 0x0027CB91
		public FKuroMaterialControllerParam_SI_EmissionChange EmissionChangeParam
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialControllerParam_SI_EmissionChange result;
				if ((result = this._EmissionChangeParam) == null)
				{
					result = (this._EmissionChangeParam = new FKuroMaterialControllerParam_SI_EmissionChange(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_EmissionChangeParam, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialControllerParam_SI_EmissionChange.StaticStruct(), base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_EmissionChangeParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006C92 RID: 27794
		// (get) Token: 0x0601B16B RID: 110955 RVA: 0x0027E9B4 File Offset: 0x0027CBB4
		// (set) Token: 0x0601B16C RID: 110956 RVA: 0x0027E9ED File Offset: 0x0027CBED
		public FKuroMaterialControllerParam_SI_Dissolve DissolveParam
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialControllerParam_SI_Dissolve result;
				if ((result = this._DissolveParam) == null)
				{
					result = (this._DissolveParam = new FKuroMaterialControllerParam_SI_Dissolve(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_DissolveParam, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialControllerParam_SI_Dissolve.StaticStruct(), base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_DissolveParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006C93 RID: 27795
		// (get) Token: 0x0601B16D RID: 110957 RVA: 0x0027EA10 File Offset: 0x0027CC10
		// (set) Token: 0x0601B16E RID: 110958 RVA: 0x0027EA49 File Offset: 0x0027CC49
		public FKuroMaterialControllerParam_SI_Custom CustomParam
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialControllerParam_SI_Custom result;
				if ((result = this._CustomParam) == null)
				{
					result = (this._CustomParam = new FKuroMaterialControllerParam_SI_Custom(base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_CustomParam, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialControllerParam_SI_Custom.StaticStruct(), base.NativePtr + (IntPtr)UKuroSceneInteractionMatConDataCache.__PropertyOffset_CustomParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601B16F RID: 110959 RVA: 0x0027EA6A File Offset: 0x0027CC6A
		static UKuroSceneInteractionMatConDataCache()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionMatConDataCache");
		}

		// Token: 0x0601B170 RID: 110960 RVA: 0x0027EA78 File Offset: 0x0027CC78
		protected UKuroSceneInteractionMatConDataCache(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E946 RID: 59718
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionMatConDataCache";

		// Token: 0x0400E947 RID: 59719
		private static IntPtr _ClassPtr;

		// Token: 0x0400E948 RID: 59720
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E949 RID: 59721
		internal static int __PropertyOffset_Version;

		// Token: 0x0400E94A RID: 59722
		internal static int __PropertyOffset_RangeTime;

		// Token: 0x0400E94B RID: 59723
		[Nullable(2)]
		private FKuroInterpolateRangeTime_SI _RangeTime;

		// Token: 0x0400E94C RID: 59724
		internal static int __PropertyOffset_bUseRim;

		// Token: 0x0400E94D RID: 59725
		internal static int __PropertyOffset_bUseBaseColor;

		// Token: 0x0400E94E RID: 59726
		internal static int __PropertyOffset_bUseAddEmission;

		// Token: 0x0400E94F RID: 59727
		internal static int __PropertyOffset_bUseEmissionChange;

		// Token: 0x0400E950 RID: 59728
		internal static int __PropertyOffset_bUseDissolve;

		// Token: 0x0400E951 RID: 59729
		internal static int __PropertyOffset_bUseCustom;

		// Token: 0x0400E952 RID: 59730
		internal static int __PropertyOffset_RimParam;

		// Token: 0x0400E953 RID: 59731
		[Nullable(2)]
		private FKuroMaterialControllerParam_SI_Rim _RimParam;

		// Token: 0x0400E954 RID: 59732
		internal static int __PropertyOffset_BaseColorParam;

		// Token: 0x0400E955 RID: 59733
		[Nullable(2)]
		private FKuroMaterialControllerParam_SI_BaseColor _BaseColorParam;

		// Token: 0x0400E956 RID: 59734
		internal static int __PropertyOffset_AddEmissionParam;

		// Token: 0x0400E957 RID: 59735
		[Nullable(2)]
		private FKuroMaterialControllerParam_SI_AddEmission _AddEmissionParam;

		// Token: 0x0400E958 RID: 59736
		internal static int __PropertyOffset_EmissionChangeParam;

		// Token: 0x0400E959 RID: 59737
		[Nullable(2)]
		private FKuroMaterialControllerParam_SI_EmissionChange _EmissionChangeParam;

		// Token: 0x0400E95A RID: 59738
		internal static int __PropertyOffset_DissolveParam;

		// Token: 0x0400E95B RID: 59739
		[Nullable(2)]
		private FKuroMaterialControllerParam_SI_Dissolve _DissolveParam;

		// Token: 0x0400E95C RID: 59740
		internal static int __PropertyOffset_CustomParam;

		// Token: 0x0400E95D RID: 59741
		[Nullable(2)]
		private FKuroMaterialControllerParam_SI_Custom _CustomParam;
	}
}
