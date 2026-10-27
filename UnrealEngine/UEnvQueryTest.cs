using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001AA RID: 426
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryTest")]
	[UnrealStructLayout(608, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public abstract class UEnvQueryTest : UEnvQueryNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001A0B RID: 6667 RVA: 0x00026972 File Offset: 0x00024B72
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryTest._ClassPtr;
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001A0C RID: 6668 RVA: 0x0002697E File Offset: 0x00024B7E
		// (set) Token: 0x06001A0D RID: 6669 RVA: 0x0002698E File Offset: 0x00024B8E
		public unsafe int TestOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_TestOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_TestOrder) = value;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001A0E RID: 6670 RVA: 0x0002699F File Offset: 0x00024B9F
		// (set) Token: 0x06001A0F RID: 6671 RVA: 0x000269B3 File Offset: 0x00024BB3
		[Nullable(0)]
		public unsafe TEnumAsByte<EEnvTestPurpose> TestPurpose
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_TestPurpose);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_TestPurpose) = value;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x000269C8 File Offset: 0x00024BC8
		// (set) Token: 0x06001A11 RID: 6673 RVA: 0x000269DC File Offset: 0x00024BDC
		public unsafe string TestComment
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEnvQueryTest.__PropertyOffset_TestComment)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEnvQueryTest.__PropertyOffset_TestComment)), value);
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001A12 RID: 6674 RVA: 0x000269F1 File Offset: 0x00024BF1
		// (set) Token: 0x06001A13 RID: 6675 RVA: 0x00026A05 File Offset: 0x00024C05
		[Nullable(0)]
		public unsafe TEnumAsByte<EEnvTestFilterOperator> MultipleContextFilterOp
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_MultipleContextFilterOp);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_MultipleContextFilterOp) = value;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001A14 RID: 6676 RVA: 0x00026A1A File Offset: 0x00024C1A
		// (set) Token: 0x06001A15 RID: 6677 RVA: 0x00026A2E File Offset: 0x00024C2E
		[Nullable(0)]
		public unsafe TEnumAsByte<EEnvTestScoreOperator> MultipleContextScoreOp
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_MultipleContextScoreOp);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_MultipleContextScoreOp) = value;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001A16 RID: 6678 RVA: 0x00026A43 File Offset: 0x00024C43
		// (set) Token: 0x06001A17 RID: 6679 RVA: 0x00026A57 File Offset: 0x00024C57
		[Nullable(0)]
		public unsafe TEnumAsByte<EEnvTestFilterType> FilterType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_FilterType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_FilterType) = value;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x00026A6C File Offset: 0x00024C6C
		// (set) Token: 0x06001A19 RID: 6681 RVA: 0x00026AA5 File Offset: 0x00024CA5
		public FAIDataProviderBoolValue BoolValue
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderBoolValue result;
				if ((result = this._BoolValue) == null)
				{
					result = (this._BoolValue = new FAIDataProviderBoolValue(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_BoolValue, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderBoolValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_BoolValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x00026AC8 File Offset: 0x00024CC8
		// (set) Token: 0x06001A1B RID: 6683 RVA: 0x00026B01 File Offset: 0x00024D01
		public FAIDataProviderFloatValue FloatValueMin
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._FloatValueMin) == null)
				{
					result = (this._FloatValueMin = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_FloatValueMin, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_FloatValueMin, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x00026B24 File Offset: 0x00024D24
		// (set) Token: 0x06001A1D RID: 6685 RVA: 0x00026B5D File Offset: 0x00024D5D
		public FAIDataProviderFloatValue FloatValueMax
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._FloatValueMax) == null)
				{
					result = (this._FloatValueMax = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_FloatValueMax, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_FloatValueMax, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x00026B7E File Offset: 0x00024D7E
		// (set) Token: 0x06001A1F RID: 6687 RVA: 0x00026B92 File Offset: 0x00024D92
		[Nullable(0)]
		public unsafe TEnumAsByte<EEnvTestScoreEquation> ScoringEquation
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_ScoringEquation);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_ScoringEquation) = value;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x00026BA7 File Offset: 0x00024DA7
		// (set) Token: 0x06001A21 RID: 6689 RVA: 0x00026BBB File Offset: 0x00024DBB
		[Nullable(0)]
		public unsafe TEnumAsByte<EEnvQueryTestClamping> ClampMinType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_ClampMinType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_ClampMinType) = value;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x00026BD0 File Offset: 0x00024DD0
		// (set) Token: 0x06001A23 RID: 6691 RVA: 0x00026BE4 File Offset: 0x00024DE4
		[Nullable(0)]
		public unsafe TEnumAsByte<EEnvQueryTestClamping> ClampMaxType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_ClampMaxType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_ClampMaxType) = value;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001A24 RID: 6692 RVA: 0x00026BF9 File Offset: 0x00024DF9
		// (set) Token: 0x06001A25 RID: 6693 RVA: 0x00026C09 File Offset: 0x00024E09
		public unsafe EEQSNormalizationType NormalizationType
		{
			get
			{
				return (EEQSNormalizationType)(*(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_NormalizationType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_NormalizationType) = (byte)value;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001A26 RID: 6694 RVA: 0x00026C1C File Offset: 0x00024E1C
		// (set) Token: 0x06001A27 RID: 6695 RVA: 0x00026C55 File Offset: 0x00024E55
		public FAIDataProviderFloatValue ScoreClampMin
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._ScoreClampMin) == null)
				{
					result = (this._ScoreClampMin = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_ScoreClampMin, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_ScoreClampMin, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001A28 RID: 6696 RVA: 0x00026C78 File Offset: 0x00024E78
		// (set) Token: 0x06001A29 RID: 6697 RVA: 0x00026CB1 File Offset: 0x00024EB1
		public FAIDataProviderFloatValue ScoreClampMax
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._ScoreClampMax) == null)
				{
					result = (this._ScoreClampMax = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_ScoreClampMax, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_ScoreClampMax, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001A2A RID: 6698 RVA: 0x00026CD4 File Offset: 0x00024ED4
		// (set) Token: 0x06001A2B RID: 6699 RVA: 0x00026D0D File Offset: 0x00024F0D
		public FAIDataProviderFloatValue ScoringFactor
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._ScoringFactor) == null)
				{
					result = (this._ScoringFactor = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_ScoringFactor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_ScoringFactor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001A2C RID: 6700 RVA: 0x00026D30 File Offset: 0x00024F30
		// (set) Token: 0x06001A2D RID: 6701 RVA: 0x00026D69 File Offset: 0x00024F69
		public FAIDataProviderFloatValue ReferenceValue
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._ReferenceValue) == null)
				{
					result = (this._ReferenceValue = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_ReferenceValue, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_ReferenceValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001A2E RID: 6702 RVA: 0x00026D8A File Offset: 0x00024F8A
		// (set) Token: 0x06001A2F RID: 6703 RVA: 0x00026D9A File Offset: 0x00024F9A
		public unsafe bool bDefineReferenceValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_bDefineReferenceValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_bDefineReferenceValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x00026DAB File Offset: 0x00024FAB
		// (set) Token: 0x06001A31 RID: 6705 RVA: 0x00026DC4 File Offset: 0x00024FC4
		public unsafe bool bWorkOnFloatValues
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_bWorkOnFloatValues) & UEnvQueryTest.__PropertyMask_bWorkOnFloatValues) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_bWorkOnFloatValues) = ((*(base.NativePtr + (IntPtr)UEnvQueryTest.__PropertyOffset_bWorkOnFloatValues) & ~UEnvQueryTest.__PropertyMask_bWorkOnFloatValues) | (value ? UEnvQueryTest.__PropertyMask_bWorkOnFloatValues : 0));
			}
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00026DF4 File Offset: 0x00024FF4
		static UEnvQueryTest()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryTest");
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x00026E04 File Offset: 0x00025004
		protected UEnvQueryTest() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00026E2C File Offset: 0x0002502C
		protected UEnvQueryTest(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040007BB RID: 1979
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryTest";

		// Token: 0x040007BC RID: 1980
		private static IntPtr _ClassPtr;

		// Token: 0x040007BD RID: 1981
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040007BE RID: 1982
		internal static int __PropertyOffset_TestOrder;

		// Token: 0x040007BF RID: 1983
		internal static int __PropertyOffset_TestPurpose;

		// Token: 0x040007C0 RID: 1984
		internal static int __PropertyOffset_TestComment;

		// Token: 0x040007C1 RID: 1985
		internal static int __PropertyOffset_MultipleContextFilterOp;

		// Token: 0x040007C2 RID: 1986
		internal static int __PropertyOffset_MultipleContextScoreOp;

		// Token: 0x040007C3 RID: 1987
		internal static int __PropertyOffset_FilterType;

		// Token: 0x040007C4 RID: 1988
		internal static int __PropertyOffset_BoolValue;

		// Token: 0x040007C5 RID: 1989
		[Nullable(2)]
		private FAIDataProviderBoolValue _BoolValue;

		// Token: 0x040007C6 RID: 1990
		internal static int __PropertyOffset_FloatValueMin;

		// Token: 0x040007C7 RID: 1991
		[Nullable(2)]
		private FAIDataProviderFloatValue _FloatValueMin;

		// Token: 0x040007C8 RID: 1992
		internal static int __PropertyOffset_FloatValueMax;

		// Token: 0x040007C9 RID: 1993
		[Nullable(2)]
		private FAIDataProviderFloatValue _FloatValueMax;

		// Token: 0x040007CA RID: 1994
		internal static int __PropertyOffset_ScoringEquation;

		// Token: 0x040007CB RID: 1995
		internal static int __PropertyOffset_ClampMinType;

		// Token: 0x040007CC RID: 1996
		internal static int __PropertyOffset_ClampMaxType;

		// Token: 0x040007CD RID: 1997
		internal static int __PropertyOffset_NormalizationType;

		// Token: 0x040007CE RID: 1998
		internal static int __PropertyOffset_ScoreClampMin;

		// Token: 0x040007CF RID: 1999
		[Nullable(2)]
		private FAIDataProviderFloatValue _ScoreClampMin;

		// Token: 0x040007D0 RID: 2000
		internal static int __PropertyOffset_ScoreClampMax;

		// Token: 0x040007D1 RID: 2001
		[Nullable(2)]
		private FAIDataProviderFloatValue _ScoreClampMax;

		// Token: 0x040007D2 RID: 2002
		internal static int __PropertyOffset_ScoringFactor;

		// Token: 0x040007D3 RID: 2003
		[Nullable(2)]
		private FAIDataProviderFloatValue _ScoringFactor;

		// Token: 0x040007D4 RID: 2004
		internal static int __PropertyOffset_ReferenceValue;

		// Token: 0x040007D5 RID: 2005
		[Nullable(2)]
		private FAIDataProviderFloatValue _ReferenceValue;

		// Token: 0x040007D6 RID: 2006
		internal static int __PropertyOffset_bDefineReferenceValue;

		// Token: 0x040007D7 RID: 2007
		internal static int __PropertyOffset_bWorkOnFloatValues;

		// Token: 0x040007D8 RID: 2008
		internal static byte __PropertyMask_bWorkOnFloatValues;
	}
}
