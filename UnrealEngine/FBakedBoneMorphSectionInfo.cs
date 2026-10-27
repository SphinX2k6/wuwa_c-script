using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000885 RID: 2181
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneMorphSectionInfo")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FBakedBoneMorphSectionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007754 RID: 30548 RVA: 0x000AADB7 File Offset: 0x000A8FB7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedBoneMorphSectionInfo._ScriptStructPtr != 0) ? FBakedBoneMorphSectionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedBoneMorphSectionInfo", ref FBakedBoneMorphSectionInfo._ScriptStructPtr);
		}

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x06007755 RID: 30549 RVA: 0x000AADDB File Offset: 0x000A8FDB
		// (set) Token: 0x06007756 RID: 30550 RVA: 0x000AADEB File Offset: 0x000A8FEB
		public unsafe float AnimOriginStartTimeAsSection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneMorphSectionInfo.__PropertyOffset_AnimOriginStartTimeAsSection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneMorphSectionInfo.__PropertyOffset_AnimOriginStartTimeAsSection) = value;
			}
		}

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x06007757 RID: 30551 RVA: 0x000AADFC File Offset: 0x000A8FFC
		// (set) Token: 0x06007758 RID: 30552 RVA: 0x000AAE0C File Offset: 0x000A900C
		public unsafe float AnimStartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneMorphSectionInfo.__PropertyOffset_AnimStartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneMorphSectionInfo.__PropertyOffset_AnimStartTime) = value;
			}
		}

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x06007759 RID: 30553 RVA: 0x000AAE20 File Offset: 0x000A9020
		// (set) Token: 0x0600775A RID: 30554 RVA: 0x000AAE63 File Offset: 0x000A9063
		public TArray<FRichCurve> FloatCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRichCurve> result;
				if ((result = this._FloatCurves) == null)
				{
					result = (this._FloatCurves = new TArray<FRichCurve>(base.NativePtr + (IntPtr)FBakedBoneMorphSectionInfo.__PropertyOffset_FloatCurves, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatCurves.CopyAssign(value);
			}
		}

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x0600775B RID: 30555 RVA: 0x000AAE74 File Offset: 0x000A9074
		// (set) Token: 0x0600775C RID: 30556 RVA: 0x000AAEB7 File Offset: 0x000A90B7
		public TArray<FName> CurveNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._CurveNames) == null)
				{
					result = (this._CurveNames = new TArray<FName>(base.NativePtr + (IntPtr)FBakedBoneMorphSectionInfo.__PropertyOffset_CurveNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CurveNames.CopyAssign(value);
			}
		}

		// Token: 0x0600775D RID: 30557 RVA: 0x000AAEC5 File Offset: 0x000A90C5
		public FBakedBoneMorphSectionInfo()
		{
		}

		// Token: 0x0600775E RID: 30558 RVA: 0x000AAECD File Offset: 0x000A90CD
		public FBakedBoneMorphSectionInfo(float AnimOriginStartTimeAsSection, float AnimStartTime, TArray<FRichCurve> FloatCurves, TArray<FName> CurveNames)
		{
			this.AnimOriginStartTimeAsSection = AnimOriginStartTimeAsSection;
			this.AnimStartTime = AnimStartTime;
			this.FloatCurves = FloatCurves;
			this.CurveNames = CurveNames;
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x000AAEF2 File Offset: 0x000A90F2
		protected override IntPtr GetUStructPtr()
		{
			return FBakedBoneMorphSectionInfo.StaticStruct();
		}

		// Token: 0x06007760 RID: 30560 RVA: 0x000AAEFE File Offset: 0x000A90FE
		[NullableContext(2)]
		public FBakedBoneMorphSectionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007761 RID: 30561 RVA: 0x000AAF08 File Offset: 0x000A9108
		public FBakedBoneMorphSectionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007762 RID: 30562 RVA: 0x000AAF13 File Offset: 0x000A9113
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedBoneMorphSectionInfo(Pointer, false, true);
		}

		// Token: 0x06007763 RID: 30563 RVA: 0x000AAF1D File Offset: 0x000A911D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedBoneMorphSectionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04003949 RID: 14665
		public const string __ObjectPath = "/Script/Engine.BakedBoneMorphSectionInfo";

		// Token: 0x0400394A RID: 14666
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400394B RID: 14667
		internal static int __PropertyOffset_AnimOriginStartTimeAsSection;

		// Token: 0x0400394C RID: 14668
		internal static int __PropertyOffset_AnimStartTime;

		// Token: 0x0400394D RID: 14669
		internal static int __PropertyOffset_FloatCurves;

		// Token: 0x0400394E RID: 14670
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRichCurve> _FloatCurves;

		// Token: 0x0400394F RID: 14671
		internal static int __PropertyOffset_CurveNames;

		// Token: 0x04003950 RID: 14672
		[Nullable(2)]
		private TArray<FName> _CurveNames;
	}
}
