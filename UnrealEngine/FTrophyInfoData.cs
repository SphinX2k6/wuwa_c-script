using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200061B RID: 1563
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.TrophyInfoData")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FTrophyInfoData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060088FD RID: 35069 RVA: 0x000CEAA1 File Offset: 0x000CCCA1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTrophyInfoData._ScriptStructPtr != 0) ? FTrophyInfoData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.TrophyInfoData", ref FTrophyInfoData._ScriptStructPtr);
		}

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x060088FE RID: 35070 RVA: 0x000CEAC5 File Offset: 0x000CCCC5
		// (set) Token: 0x060088FF RID: 35071 RVA: 0x000CEAD5 File Offset: 0x000CCCD5
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

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x06008900 RID: 35072 RVA: 0x000CEAE6 File Offset: 0x000CCCE6
		// (set) Token: 0x06008901 RID: 35073 RVA: 0x000CEAF6 File Offset: 0x000CCCF6
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

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x06008902 RID: 35074 RVA: 0x000CEB08 File Offset: 0x000CCD08
		// (set) Token: 0x06008903 RID: 35075 RVA: 0x000CEB4B File Offset: 0x000CCD4B
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

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x06008904 RID: 35076 RVA: 0x000CEB5C File Offset: 0x000CCD5C
		// (set) Token: 0x06008905 RID: 35077 RVA: 0x000CEB9F File Offset: 0x000CCD9F
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

		// Token: 0x06008906 RID: 35078 RVA: 0x000CEBAD File Offset: 0x000CCDAD
		public FTrophyInfoData()
		{
		}

		// Token: 0x06008907 RID: 35079 RVA: 0x000CEBB5 File Offset: 0x000CCDB5
		protected override IntPtr GetUStructPtr()
		{
			return FTrophyInfoData.StaticStruct();
		}

		// Token: 0x06008908 RID: 35080 RVA: 0x000CEBC1 File Offset: 0x000CCDC1
		[NullableContext(2)]
		public FTrophyInfoData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008909 RID: 35081 RVA: 0x000CEBCB File Offset: 0x000CCDCB
		public FTrophyInfoData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600890A RID: 35082 RVA: 0x000CEBD6 File Offset: 0x000CCDD6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTrophyInfoData(Pointer, false, true);
		}

		// Token: 0x0600890B RID: 35083 RVA: 0x000CEBE0 File Offset: 0x000CCDE0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTrophyInfoData(Pointer, MemoryOwner);
		}

		// Token: 0x04003B76 RID: 15222
		public const string __ObjectPath = "/Script/KuroUtility.TrophyInfoData";

		// Token: 0x04003B77 RID: 15223
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003B78 RID: 15224
		internal static int __PropertyOffset_offset;

		// Token: 0x04003B79 RID: 15225
		internal static int __PropertyOffset_count;

		// Token: 0x04003B7A RID: 15226
		internal static int __PropertyOffset_trophyDetail;

		// Token: 0x04003B7B RID: 15227
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTrophyDetailData> _trophyDetail;

		// Token: 0x04003B7C RID: 15228
		internal static int __PropertyOffset_trophyData;

		// Token: 0x04003B7D RID: 15229
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTrophyData> _trophyData;
	}
}
