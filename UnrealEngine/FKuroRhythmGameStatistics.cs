using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000504 RID: 1284
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameStatistics")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FKuroRhythmGameStatistics : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060078BE RID: 30910 RVA: 0x000B0FF4 File Offset: 0x000AF1F4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRhythmGameStatistics._ScriptStructPtr != 0) ? FKuroRhythmGameStatistics._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.KuroRhythmGameStatistics", ref FKuroRhythmGameStatistics._ScriptStructPtr);
		}

		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x060078BF RID: 30911 RVA: 0x000B1018 File Offset: 0x000AF218
		// (set) Token: 0x060078C0 RID: 30912 RVA: 0x000B1028 File Offset: 0x000AF228
		public unsafe int PerfectCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_PerfectCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_PerfectCount) = value;
			}
		}

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x060078C1 RID: 30913 RVA: 0x000B1039 File Offset: 0x000AF239
		// (set) Token: 0x060078C2 RID: 30914 RVA: 0x000B1049 File Offset: 0x000AF249
		public unsafe int GreatCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_GreatCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_GreatCount) = value;
			}
		}

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x060078C3 RID: 30915 RVA: 0x000B105A File Offset: 0x000AF25A
		// (set) Token: 0x060078C4 RID: 30916 RVA: 0x000B106A File Offset: 0x000AF26A
		public unsafe int GoodCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_GoodCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_GoodCount) = value;
			}
		}

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x060078C5 RID: 30917 RVA: 0x000B107B File Offset: 0x000AF27B
		// (set) Token: 0x060078C6 RID: 30918 RVA: 0x000B108B File Offset: 0x000AF28B
		public unsafe int BadCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_BadCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_BadCount) = value;
			}
		}

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x060078C7 RID: 30919 RVA: 0x000B109C File Offset: 0x000AF29C
		// (set) Token: 0x060078C8 RID: 30920 RVA: 0x000B10AC File Offset: 0x000AF2AC
		public unsafe int MissCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_MissCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_MissCount) = value;
			}
		}

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x060078C9 RID: 30921 RVA: 0x000B10BD File Offset: 0x000AF2BD
		// (set) Token: 0x060078CA RID: 30922 RVA: 0x000B10CD File Offset: 0x000AF2CD
		public unsafe int TotalNotes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_TotalNotes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_TotalNotes) = value;
			}
		}

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x060078CB RID: 30923 RVA: 0x000B10DE File Offset: 0x000AF2DE
		// (set) Token: 0x060078CC RID: 30924 RVA: 0x000B10EE File Offset: 0x000AF2EE
		public unsafe int TotalScore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_TotalScore);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_TotalScore) = value;
			}
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x060078CD RID: 30925 RVA: 0x000B10FF File Offset: 0x000AF2FF
		// (set) Token: 0x060078CE RID: 30926 RVA: 0x000B110F File Offset: 0x000AF30F
		public unsafe float Accuracy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_Accuracy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_Accuracy) = value;
			}
		}

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x060078CF RID: 30927 RVA: 0x000B1120 File Offset: 0x000AF320
		// (set) Token: 0x060078D0 RID: 30928 RVA: 0x000B1130 File Offset: 0x000AF330
		public unsafe int Combo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_Combo);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_Combo) = value;
			}
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x060078D1 RID: 30929 RVA: 0x000B1141 File Offset: 0x000AF341
		// (set) Token: 0x060078D2 RID: 30930 RVA: 0x000B1151 File Offset: 0x000AF351
		public unsafe int MaxCombo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_MaxCombo);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_MaxCombo) = value;
			}
		}

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x060078D3 RID: 30931 RVA: 0x000B1162 File Offset: 0x000AF362
		// (set) Token: 0x060078D4 RID: 30932 RVA: 0x000B1172 File Offset: 0x000AF372
		public unsafe int CurrentHiddenScoreLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_CurrentHiddenScoreLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameStatistics.__PropertyOffset_CurrentHiddenScoreLevel) = value;
			}
		}

		// Token: 0x060078D5 RID: 30933 RVA: 0x000B1183 File Offset: 0x000AF383
		public FKuroRhythmGameStatistics()
		{
		}

		// Token: 0x060078D6 RID: 30934 RVA: 0x000B118B File Offset: 0x000AF38B
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRhythmGameStatistics.StaticStruct();
		}

		// Token: 0x060078D7 RID: 30935 RVA: 0x000B1197 File Offset: 0x000AF397
		[NullableContext(2)]
		public FKuroRhythmGameStatistics(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060078D8 RID: 30936 RVA: 0x000B11A1 File Offset: 0x000AF3A1
		public FKuroRhythmGameStatistics(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060078D9 RID: 30937 RVA: 0x000B11AC File Offset: 0x000AF3AC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRhythmGameStatistics(Pointer, false, true);
		}

		// Token: 0x060078DA RID: 30938 RVA: 0x000B11B6 File Offset: 0x000AF3B6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRhythmGameStatistics(Pointer, MemoryOwner);
		}

		// Token: 0x0400335D RID: 13149
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameStatistics";

		// Token: 0x0400335E RID: 13150
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400335F RID: 13151
		internal static int __PropertyOffset_PerfectCount;

		// Token: 0x04003360 RID: 13152
		internal static int __PropertyOffset_GreatCount;

		// Token: 0x04003361 RID: 13153
		internal static int __PropertyOffset_GoodCount;

		// Token: 0x04003362 RID: 13154
		internal static int __PropertyOffset_BadCount;

		// Token: 0x04003363 RID: 13155
		internal static int __PropertyOffset_MissCount;

		// Token: 0x04003364 RID: 13156
		internal static int __PropertyOffset_TotalNotes;

		// Token: 0x04003365 RID: 13157
		internal static int __PropertyOffset_TotalScore;

		// Token: 0x04003366 RID: 13158
		internal static int __PropertyOffset_Accuracy;

		// Token: 0x04003367 RID: 13159
		internal static int __PropertyOffset_Combo;

		// Token: 0x04003368 RID: 13160
		internal static int __PropertyOffset_MaxCombo;

		// Token: 0x04003369 RID: 13161
		internal static int __PropertyOffset_CurrentHiddenScoreLevel;
	}
}
