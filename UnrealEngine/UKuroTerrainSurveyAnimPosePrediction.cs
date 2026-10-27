using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E8A RID: 7818
	[UnrealObjectPath("/Script/KuroTerrainSurvey.KuroTerrainSurveyAnimPosePrediction")]
	[UnrealStructLayout(928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 928)]
	public class UKuroTerrainSurveyAnimPosePrediction : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DBF1 RID: 121841 RVA: 0x002BF2E0 File Offset: 0x002BD4E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTerrainSurveyAnimPosePrediction._ClassPtr;
		}

		// Token: 0x0601DBF2 RID: 121842 RVA: 0x002BF2EC File Offset: 0x002BD4EC
		public UKuroTerrainSurveyAnimPosePrediction() : this(BuiltinUtils.AllocNativeUObject(UKuroTerrainSurveyAnimPosePrediction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DBF3 RID: 121843 RVA: 0x002BF314 File Offset: 0x002BD514
		[NullableContext(1)]
		public UKuroTerrainSurveyAnimPosePrediction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTerrainSurveyAnimPosePrediction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700777F RID: 30591
		// (get) Token: 0x0601DBF4 RID: 121844 RVA: 0x002BF347 File Offset: 0x002BD547
		// (set) Token: 0x0601DBF5 RID: 121845 RVA: 0x002BF35B File Offset: 0x002BD55B
		[Nullable(2)]
		public unsafe UAnimInstance CurrentPredictionAnimIns
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimInstance>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroTerrainSurveyAnimPosePrediction.__PropertyOffset_CurrentPredictionAnimIns);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroTerrainSurveyAnimPosePrediction.__PropertyOffset_CurrentPredictionAnimIns, value);
			}
		}

		// Token: 0x17007780 RID: 30592
		// (get) Token: 0x0601DBF6 RID: 121846 RVA: 0x002BF370 File Offset: 0x002BD570
		// (set) Token: 0x0601DBF7 RID: 121847 RVA: 0x002BF384 File Offset: 0x002BD584
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UAnimInstance> SyncTargetAnimInsClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTerrainSurveyAnimPosePrediction.__PropertyOffset_SyncTargetAnimInsClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTerrainSurveyAnimPosePrediction.__PropertyOffset_SyncTargetAnimInsClass) = value;
			}
		}

		// Token: 0x0601DBF8 RID: 121848 RVA: 0x002BF399 File Offset: 0x002BD599
		static UKuroTerrainSurveyAnimPosePrediction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroTerrainSurvey.KuroTerrainSurveyAnimPosePrediction");
		}

		// Token: 0x0601DBF9 RID: 121849 RVA: 0x002BF3A7 File Offset: 0x002BD5A7
		protected UKuroTerrainSurveyAnimPosePrediction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040101B3 RID: 65971
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroTerrainSurvey.KuroTerrainSurveyAnimPosePrediction";

		// Token: 0x040101B4 RID: 65972
		private static IntPtr _ClassPtr;

		// Token: 0x040101B5 RID: 65973
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040101B6 RID: 65974
		internal static int __PropertyOffset_CurrentPredictionAnimIns;

		// Token: 0x040101B7 RID: 65975
		internal static int __PropertyOffset_SyncTargetAnimInsClass;
	}
}
