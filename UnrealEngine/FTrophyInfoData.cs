using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F10 RID: 7952
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.TrophyInfoData")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FTrophyInfoData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E2D6 RID: 123606 RVA: 0x002CDE08 File Offset: 0x002CC008
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTrophyInfoData._ScriptStructPtr != 0) ? FTrophyInfoData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.TrophyInfoData", ref FTrophyInfoData._ScriptStructPtr);
		}

		// Token: 0x170077DF RID: 30687
		// (get) Token: 0x0601E2D7 RID: 123607 RVA: 0x002CDE2C File Offset: 0x002CC02C
		// (set) Token: 0x0601E2D8 RID: 123608 RVA: 0x002CDE3C File Offset: 0x002CC03C
		public unsafe int offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrophyInfoData.__PropertyOffset_offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrophyInfoData.__PropertyOffset_offset) = value;
			}
		}

		// Token: 0x170077E0 RID: 30688
		// (get) Token: 0x0601E2D9 RID: 123609 RVA: 0x002CDE4D File Offset: 0x002CC04D
		// (set) Token: 0x0601E2DA RID: 123610 RVA: 0x002CDE5D File Offset: 0x002CC05D
		public unsafe int count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrophyInfoData.__PropertyOffset_count);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrophyInfoData.__PropertyOffset_count) = value;
			}
		}

		// Token: 0x170077E1 RID: 30689
		// (get) Token: 0x0601E2DB RID: 123611 RVA: 0x002CDE70 File Offset: 0x002CC070
		// (set) Token: 0x0601E2DC RID: 123612 RVA: 0x002CDEB3 File Offset: 0x002CC0B3
		public TArray<FTrophyDetailData> trophyDetail
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTrophyDetailData> result;
				if ((result = this._trophyDetail) == null)
				{
					result = (this._trophyDetail = new TArray<FTrophyDetailData>(base.NativePtr + (IntPtr)FTrophyInfoData.__PropertyOffset_trophyDetail, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.trophyDetail.CopyAssign(value);
			}
		}

		// Token: 0x170077E2 RID: 30690
		// (get) Token: 0x0601E2DD RID: 123613 RVA: 0x002CDEC4 File Offset: 0x002CC0C4
		// (set) Token: 0x0601E2DE RID: 123614 RVA: 0x002CDF07 File Offset: 0x002CC107
		public TArray<FTrophyData> trophyData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTrophyData> result;
				if ((result = this._trophyData) == null)
				{
					result = (this._trophyData = new TArray<FTrophyData>(base.NativePtr + (IntPtr)FTrophyInfoData.__PropertyOffset_trophyData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.trophyData.CopyAssign(value);
			}
		}

		// Token: 0x0601E2DF RID: 123615 RVA: 0x002CDF15 File Offset: 0x002CC115
		public FTrophyInfoData()
		{
		}

		// Token: 0x0601E2E0 RID: 123616 RVA: 0x002CDF1D File Offset: 0x002CC11D
		public FTrophyInfoData(int offset, int count, TArray<FTrophyDetailData> trophyDetail, TArray<FTrophyData> trophyData)
		{
			this.offset = offset;
			this.count = count;
			this.trophyDetail = trophyDetail;
			this.trophyData = trophyData;
		}

		// Token: 0x0601E2E1 RID: 123617 RVA: 0x002CDF42 File Offset: 0x002CC142
		protected override IntPtr GetUStructPtr()
		{
			return FTrophyInfoData.StaticStruct();
		}

		// Token: 0x0601E2E2 RID: 123618 RVA: 0x002CDF4E File Offset: 0x002CC14E
		[NullableContext(2)]
		public FTrophyInfoData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E2E3 RID: 123619 RVA: 0x002CDF58 File Offset: 0x002CC158
		public FTrophyInfoData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E2E4 RID: 123620 RVA: 0x002CDF63 File Offset: 0x002CC163
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTrophyInfoData(Pointer, false, true);
		}

		// Token: 0x0601E2E5 RID: 123621 RVA: 0x002CDF6D File Offset: 0x002CC16D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTrophyInfoData(Pointer, MemoryOwner);
		}

		// Token: 0x040104AB RID: 66731
		public const string __ObjectPath = "/Script/KuroUtility.TrophyInfoData";

		// Token: 0x040104AC RID: 66732
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040104AD RID: 66733
		internal static int __PropertyOffset_offset;

		// Token: 0x040104AE RID: 66734
		internal static int __PropertyOffset_count;

		// Token: 0x040104AF RID: 66735
		internal static int __PropertyOffset_trophyDetail;

		// Token: 0x040104B0 RID: 66736
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTrophyDetailData> _trophyDetail;

		// Token: 0x040104B1 RID: 66737
		internal static int __PropertyOffset_trophyData;

		// Token: 0x040104B2 RID: 66738
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTrophyData> _trophyData;
	}
}
