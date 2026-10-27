using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BBA RID: 7098
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSequencePoseComponent")]
	[UnrealStructLayout(504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 504)]
	public class UKuroSequencePoseComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B2A8 RID: 111272 RVA: 0x002806E5 File Offset: 0x0027E8E5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSequencePoseComponent._ClassPtr;
		}

		// Token: 0x0601B2A9 RID: 111273 RVA: 0x002806F4 File Offset: 0x0027E8F4
		public UKuroSequencePoseComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroSequencePoseComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B2AA RID: 111274 RVA: 0x0028071C File Offset: 0x0027E91C
		public UKuroSequencePoseComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSequencePoseComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CF0 RID: 27888
		// (get) Token: 0x0601B2AB RID: 111275 RVA: 0x0028074F File Offset: 0x0027E94F
		// (set) Token: 0x0601B2AC RID: 111276 RVA: 0x0028075F File Offset: 0x0027E95F
		public unsafe float SequenceTimeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSequencePoseComponent.__PropertyOffset_SequenceTimeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSequencePoseComponent.__PropertyOffset_SequenceTimeRange) = value;
			}
		}

		// Token: 0x17006CF1 RID: 27889
		// (get) Token: 0x0601B2AD RID: 111277 RVA: 0x00280770 File Offset: 0x0027E970
		// (set) Token: 0x0601B2AE RID: 111278 RVA: 0x00280784 File Offset: 0x0027E984
		[Nullable(2)]
		public unsafe UMaterialInterface DefaultMaterialToUse
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroSequencePoseComponent.__PropertyOffset_DefaultMaterialToUse);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroSequencePoseComponent.__PropertyOffset_DefaultMaterialToUse, value);
			}
		}

		// Token: 0x17006CF2 RID: 27890
		// (get) Token: 0x0601B2AF RID: 111279 RVA: 0x00280799 File Offset: 0x0027E999
		// (set) Token: 0x0601B2B0 RID: 111280 RVA: 0x002807A9 File Offset: 0x0027E9A9
		public unsafe bool bIncludeOutline
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSequencePoseComponent.__PropertyOffset_bIncludeOutline) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSequencePoseComponent.__PropertyOffset_bIncludeOutline) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CF3 RID: 27891
		// (get) Token: 0x0601B2B1 RID: 111281 RVA: 0x002807BA File Offset: 0x0027E9BA
		// (set) Token: 0x0601B2B2 RID: 111282 RVA: 0x002807CA File Offset: 0x0027E9CA
		public unsafe bool bAutoSetCharacterTexture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSequencePoseComponent.__PropertyOffset_bAutoSetCharacterTexture) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSequencePoseComponent.__PropertyOffset_bAutoSetCharacterTexture) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CF4 RID: 27892
		// (get) Token: 0x0601B2B3 RID: 111283 RVA: 0x002807DC File Offset: 0x0027E9DC
		// (set) Token: 0x0601B2B4 RID: 111284 RVA: 0x00280815 File Offset: 0x0027EA15
		public TMap<string, UMaterialInterface> ExtraMaterialsToUse
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, UMaterialInterface> result;
				if ((result = this._ExtraMaterialsToUse) == null)
				{
					result = (this._ExtraMaterialsToUse = new TMap<string, UMaterialInterface>(base.NativePtr + (IntPtr)UKuroSequencePoseComponent.__PropertyOffset_ExtraMaterialsToUse, this));
				}
				return result;
			}
			set
			{
				this.ExtraMaterialsToUse.CopyAssign(value);
			}
		}

		// Token: 0x17006CF5 RID: 27893
		// (get) Token: 0x0601B2B5 RID: 111285 RVA: 0x00280824 File Offset: 0x0027EA24
		// (set) Token: 0x0601B2B6 RID: 111286 RVA: 0x0028085D File Offset: 0x0027EA5D
		public TMap<FName, FKuroCurveFloat> FloatParametersCurve
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._FloatParametersCurve) == null)
				{
					result = (this._FloatParametersCurve = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)UKuroSequencePoseComponent.__PropertyOffset_FloatParametersCurve, this));
				}
				return result;
			}
			set
			{
				this.FloatParametersCurve.CopyAssign(value);
			}
		}

		// Token: 0x17006CF6 RID: 27894
		// (get) Token: 0x0601B2B7 RID: 111287 RVA: 0x0028086C File Offset: 0x0027EA6C
		// (set) Token: 0x0601B2B8 RID: 111288 RVA: 0x002808A5 File Offset: 0x0027EAA5
		public TMap<FName, FKuroCurveLinearColor> ColorParametersCurve
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._ColorParametersCurve) == null)
				{
					result = (this._ColorParametersCurve = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)UKuroSequencePoseComponent.__PropertyOffset_ColorParametersCurve, this));
				}
				return result;
			}
			set
			{
				this.ColorParametersCurve.CopyAssign(value);
			}
		}

		// Token: 0x17006CF7 RID: 27895
		// (get) Token: 0x0601B2B9 RID: 111289 RVA: 0x002808B3 File Offset: 0x0027EAB3
		// (set) Token: 0x0601B2BA RID: 111290 RVA: 0x002808C3 File Offset: 0x0027EAC3
		public unsafe int MaxPose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSequencePoseComponent.__PropertyOffset_MaxPose);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSequencePoseComponent.__PropertyOffset_MaxPose) = value;
			}
		}

		// Token: 0x17006CF8 RID: 27896
		// (get) Token: 0x0601B2BB RID: 111291 RVA: 0x002808D4 File Offset: 0x0027EAD4
		// (set) Token: 0x0601B2BC RID: 111292 RVA: 0x002808E4 File Offset: 0x0027EAE4
		public unsafe bool bIsEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSequencePoseComponent.__PropertyOffset_bIsEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSequencePoseComponent.__PropertyOffset_bIsEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CF9 RID: 27897
		// (get) Token: 0x0601B2BD RID: 111293 RVA: 0x002808F8 File Offset: 0x0027EAF8
		// (set) Token: 0x0601B2BE RID: 111294 RVA: 0x00280931 File Offset: 0x0027EB31
		public TArray<FKuroPoseSequence> PoseSequences
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroPoseSequence> result;
				if ((result = this._PoseSequences) == null)
				{
					result = (this._PoseSequences = new TArray<FKuroPoseSequence>(base.NativePtr + (IntPtr)UKuroSequencePoseComponent.__PropertyOffset_PoseSequences, this));
				}
				return result;
			}
			set
			{
				this.PoseSequences.CopyAssign(value);
			}
		}

		// Token: 0x0601B2BF RID: 111295 RVA: 0x0028093F File Offset: 0x0027EB3F
		public int GetCurrentPoseNum()
		{
			return UKuroSequencePoseComponent.__GetCurrentPoseNum_Internal(base.NativePtr);
		}

		// Token: 0x0601B2C0 RID: 111296 RVA: 0x0028094C File Offset: 0x0027EB4C
		[NullableContext(2)]
		public void AddSkeletalMeshComponent(USkeletalMeshComponent InSkeletalMeshComponent)
		{
			UKuroSequencePoseComponent.__AddSkeletalMeshComponent_Internal(base.NativePtr, (InSkeletalMeshComponent != null) ? InSkeletalMeshComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601B2C1 RID: 111297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCurrentPoseNum_Internal(IntPtr @this);

		// Token: 0x0601B2C2 RID: 111298
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSkeletalMeshComponent_Internal(IntPtr @this, IntPtr InSkeletalMeshComponent);

		// Token: 0x0601B2C3 RID: 111299 RVA: 0x00280969 File Offset: 0x0027EB69
		static UKuroSequencePoseComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSequencePoseComponent");
		}

		// Token: 0x0601B2C4 RID: 111300 RVA: 0x00280977 File Offset: 0x0027EB77
		protected UKuroSequencePoseComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EA0A RID: 59914
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSequencePoseComponent";

		// Token: 0x0400EA0B RID: 59915
		private static IntPtr _ClassPtr;

		// Token: 0x0400EA0C RID: 59916
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EA0D RID: 59917
		internal static int __PropertyOffset_SequenceTimeRange;

		// Token: 0x0400EA0E RID: 59918
		internal static int __PropertyOffset_DefaultMaterialToUse;

		// Token: 0x0400EA0F RID: 59919
		internal static int __PropertyOffset_bIncludeOutline;

		// Token: 0x0400EA10 RID: 59920
		internal static int __PropertyOffset_bAutoSetCharacterTexture;

		// Token: 0x0400EA11 RID: 59921
		internal static int __PropertyOffset_ExtraMaterialsToUse;

		// Token: 0x0400EA12 RID: 59922
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UMaterialInterface> _ExtraMaterialsToUse;

		// Token: 0x0400EA13 RID: 59923
		internal static int __PropertyOffset_FloatParametersCurve;

		// Token: 0x0400EA14 RID: 59924
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _FloatParametersCurve;

		// Token: 0x0400EA15 RID: 59925
		internal static int __PropertyOffset_ColorParametersCurve;

		// Token: 0x0400EA16 RID: 59926
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _ColorParametersCurve;

		// Token: 0x0400EA17 RID: 59927
		internal static int __PropertyOffset_MaxPose;

		// Token: 0x0400EA18 RID: 59928
		internal static int __PropertyOffset_bIsEnabled;

		// Token: 0x0400EA19 RID: 59929
		internal static int __PropertyOffset_PoseSequences;

		// Token: 0x0400EA1A RID: 59930
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroPoseSequence> _PoseSequences;
	}
}
