using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C5A RID: 7258
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameStatistics")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FKuroRhythmGameStatistics : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C2A5 RID: 115365 RVA: 0x00298354 File Offset: 0x00296554
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRhythmGameStatistics._ScriptStructPtr != 0) ? FKuroRhythmGameStatistics._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.KuroRhythmGameStatistics", ref FKuroRhythmGameStatistics._ScriptStructPtr);
		}

		// Token: 0x170071F1 RID: 29169
		// (get) Token: 0x0601C2A6 RID: 115366 RVA: 0x00298378 File Offset: 0x00296578
		// (set) Token: 0x0601C2A7 RID: 115367 RVA: 0x00298388 File Offset: 0x00296588
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

		// Token: 0x170071F2 RID: 29170
		// (get) Token: 0x0601C2A8 RID: 115368 RVA: 0x00298399 File Offset: 0x00296599
		// (set) Token: 0x0601C2A9 RID: 115369 RVA: 0x002983A9 File Offset: 0x002965A9
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

		// Token: 0x170071F3 RID: 29171
		// (get) Token: 0x0601C2AA RID: 115370 RVA: 0x002983BA File Offset: 0x002965BA
		// (set) Token: 0x0601C2AB RID: 115371 RVA: 0x002983CA File Offset: 0x002965CA
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

		// Token: 0x170071F4 RID: 29172
		// (get) Token: 0x0601C2AC RID: 115372 RVA: 0x002983DB File Offset: 0x002965DB
		// (set) Token: 0x0601C2AD RID: 115373 RVA: 0x002983EB File Offset: 0x002965EB
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

		// Token: 0x170071F5 RID: 29173
		// (get) Token: 0x0601C2AE RID: 115374 RVA: 0x002983FC File Offset: 0x002965FC
		// (set) Token: 0x0601C2AF RID: 115375 RVA: 0x0029840C File Offset: 0x0029660C
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

		// Token: 0x170071F6 RID: 29174
		// (get) Token: 0x0601C2B0 RID: 115376 RVA: 0x0029841D File Offset: 0x0029661D
		// (set) Token: 0x0601C2B1 RID: 115377 RVA: 0x0029842D File Offset: 0x0029662D
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

		// Token: 0x170071F7 RID: 29175
		// (get) Token: 0x0601C2B2 RID: 115378 RVA: 0x0029843E File Offset: 0x0029663E
		// (set) Token: 0x0601C2B3 RID: 115379 RVA: 0x0029844E File Offset: 0x0029664E
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

		// Token: 0x170071F8 RID: 29176
		// (get) Token: 0x0601C2B4 RID: 115380 RVA: 0x0029845F File Offset: 0x0029665F
		// (set) Token: 0x0601C2B5 RID: 115381 RVA: 0x0029846F File Offset: 0x0029666F
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

		// Token: 0x170071F9 RID: 29177
		// (get) Token: 0x0601C2B6 RID: 115382 RVA: 0x00298480 File Offset: 0x00296680
		// (set) Token: 0x0601C2B7 RID: 115383 RVA: 0x00298490 File Offset: 0x00296690
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

		// Token: 0x170071FA RID: 29178
		// (get) Token: 0x0601C2B8 RID: 115384 RVA: 0x002984A1 File Offset: 0x002966A1
		// (set) Token: 0x0601C2B9 RID: 115385 RVA: 0x002984B1 File Offset: 0x002966B1
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

		// Token: 0x170071FB RID: 29179
		// (get) Token: 0x0601C2BA RID: 115386 RVA: 0x002984C2 File Offset: 0x002966C2
		// (set) Token: 0x0601C2BB RID: 115387 RVA: 0x002984D2 File Offset: 0x002966D2
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

		// Token: 0x0601C2BC RID: 115388 RVA: 0x002984E3 File Offset: 0x002966E3
		public FKuroRhythmGameStatistics()
		{
		}

		// Token: 0x0601C2BD RID: 115389 RVA: 0x002984EC File Offset: 0x002966EC
		public FKuroRhythmGameStatistics(int PerfectCount, int GreatCount, int GoodCount, int BadCount, int MissCount, int TotalNotes, int TotalScore, float Accuracy, int Combo, int MaxCombo, int CurrentHiddenScoreLevel)
		{
			this.PerfectCount = PerfectCount;
			this.GreatCount = GreatCount;
			this.GoodCount = GoodCount;
			this.BadCount = BadCount;
			this.MissCount = MissCount;
			this.TotalNotes = TotalNotes;
			this.TotalScore = TotalScore;
			this.Accuracy = Accuracy;
			this.Combo = Combo;
			this.MaxCombo = MaxCombo;
			this.CurrentHiddenScoreLevel = CurrentHiddenScoreLevel;
		}

		// Token: 0x0601C2BE RID: 115390 RVA: 0x00298554 File Offset: 0x00296754
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRhythmGameStatistics.StaticStruct();
		}

		// Token: 0x0601C2BF RID: 115391 RVA: 0x00298560 File Offset: 0x00296760
		[NullableContext(2)]
		public FKuroRhythmGameStatistics(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C2C0 RID: 115392 RVA: 0x0029856A File Offset: 0x0029676A
		public FKuroRhythmGameStatistics(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C2C1 RID: 115393 RVA: 0x00298575 File Offset: 0x00296775
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRhythmGameStatistics(Pointer, false, true);
		}

		// Token: 0x0601C2C2 RID: 115394 RVA: 0x0029857F File Offset: 0x0029677F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRhythmGameStatistics(Pointer, MemoryOwner);
		}

		// Token: 0x0400F285 RID: 62085
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameStatistics";

		// Token: 0x0400F286 RID: 62086
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F287 RID: 62087
		internal static int __PropertyOffset_PerfectCount;

		// Token: 0x0400F288 RID: 62088
		internal static int __PropertyOffset_GreatCount;

		// Token: 0x0400F289 RID: 62089
		internal static int __PropertyOffset_GoodCount;

		// Token: 0x0400F28A RID: 62090
		internal static int __PropertyOffset_BadCount;

		// Token: 0x0400F28B RID: 62091
		internal static int __PropertyOffset_MissCount;

		// Token: 0x0400F28C RID: 62092
		internal static int __PropertyOffset_TotalNotes;

		// Token: 0x0400F28D RID: 62093
		internal static int __PropertyOffset_TotalScore;

		// Token: 0x0400F28E RID: 62094
		internal static int __PropertyOffset_Accuracy;

		// Token: 0x0400F28F RID: 62095
		internal static int __PropertyOffset_Combo;

		// Token: 0x0400F290 RID: 62096
		internal static int __PropertyOffset_MaxCombo;

		// Token: 0x0400F291 RID: 62097
		internal static int __PropertyOffset_CurrentHiddenScoreLevel;
	}
}
