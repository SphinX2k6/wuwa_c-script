using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004FF RID: 1279
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameHiddenScore")]
	[UnrealStructLayout(120, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FKuroRhythmGameHiddenScore : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060077CC RID: 30668 RVA: 0x000AEF27 File Offset: 0x000AD127
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRhythmGameHiddenScore._ScriptStructPtr != 0) ? FKuroRhythmGameHiddenScore._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.KuroRhythmGameHiddenScore", ref FKuroRhythmGameHiddenScore._ScriptStructPtr);
		}

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x060077CD RID: 30669 RVA: 0x000AEF4B File Offset: 0x000AD14B
		// (set) Token: 0x060077CE RID: 30670 RVA: 0x000AEF5B File Offset: 0x000AD15B
		public unsafe int CurrentScore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_CurrentScore);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_CurrentScore) = value;
			}
		}

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x060077CF RID: 30671 RVA: 0x000AEF6C File Offset: 0x000AD16C
		// (set) Token: 0x060077D0 RID: 30672 RVA: 0x000AEF7C File Offset: 0x000AD17C
		public unsafe int Level2Threshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level2Threshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level2Threshold) = value;
			}
		}

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x060077D1 RID: 30673 RVA: 0x000AEF8D File Offset: 0x000AD18D
		// (set) Token: 0x060077D2 RID: 30674 RVA: 0x000AEF9D File Offset: 0x000AD19D
		public unsafe int Level3Threshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level3Threshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level3Threshold) = value;
			}
		}

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x060077D3 RID: 30675 RVA: 0x000AEFAE File Offset: 0x000AD1AE
		// (set) Token: 0x060077D4 RID: 30676 RVA: 0x000AEFBE File Offset: 0x000AD1BE
		public unsafe int Level4Threshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level4Threshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level4Threshold) = value;
			}
		}

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x060077D5 RID: 30677 RVA: 0x000AEFCF File Offset: 0x000AD1CF
		// (set) Token: 0x060077D6 RID: 30678 RVA: 0x000AEFDF File Offset: 0x000AD1DF
		public unsafe int MaxScore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_MaxScore);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_MaxScore) = value;
			}
		}

		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x060077D7 RID: 30679 RVA: 0x000AEFF0 File Offset: 0x000AD1F0
		// (set) Token: 0x060077D8 RID: 30680 RVA: 0x000AF000 File Offset: 0x000AD200
		public unsafe int Level1ScoreMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level1ScoreMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level1ScoreMultiplier) = value;
			}
		}

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x060077D9 RID: 30681 RVA: 0x000AF011 File Offset: 0x000AD211
		// (set) Token: 0x060077DA RID: 30682 RVA: 0x000AF021 File Offset: 0x000AD221
		public unsafe int Level2ScoreMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level2ScoreMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level2ScoreMultiplier) = value;
			}
		}

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x060077DB RID: 30683 RVA: 0x000AF032 File Offset: 0x000AD232
		// (set) Token: 0x060077DC RID: 30684 RVA: 0x000AF042 File Offset: 0x000AD242
		public unsafe int Level3ScoreMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level3ScoreMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level3ScoreMultiplier) = value;
			}
		}

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x060077DD RID: 30685 RVA: 0x000AF053 File Offset: 0x000AD253
		// (set) Token: 0x060077DE RID: 30686 RVA: 0x000AF063 File Offset: 0x000AD263
		public unsafe int Level4ScoreMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level4ScoreMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level4ScoreMultiplier) = value;
			}
		}

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x060077DF RID: 30687 RVA: 0x000AF074 File Offset: 0x000AD274
		// (set) Token: 0x060077E0 RID: 30688 RVA: 0x000AF084 File Offset: 0x000AD284
		public unsafe int Level5ScoreMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level5ScoreMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level5ScoreMultiplier) = value;
			}
		}

		// Token: 0x060077E1 RID: 30689 RVA: 0x000AF095 File Offset: 0x000AD295
		public FKuroRhythmGameHiddenScore()
		{
		}

		// Token: 0x060077E2 RID: 30690 RVA: 0x000AF09D File Offset: 0x000AD29D
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRhythmGameHiddenScore.StaticStruct();
		}

		// Token: 0x060077E3 RID: 30691 RVA: 0x000AF0A9 File Offset: 0x000AD2A9
		[NullableContext(2)]
		public FKuroRhythmGameHiddenScore(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060077E4 RID: 30692 RVA: 0x000AF0B3 File Offset: 0x000AD2B3
		public FKuroRhythmGameHiddenScore(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060077E5 RID: 30693 RVA: 0x000AF0BE File Offset: 0x000AD2BE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRhythmGameHiddenScore(Pointer, false, true);
		}

		// Token: 0x060077E6 RID: 30694 RVA: 0x000AF0C8 File Offset: 0x000AD2C8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRhythmGameHiddenScore(Pointer, MemoryOwner);
		}

		// Token: 0x040032B3 RID: 12979
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameHiddenScore";

		// Token: 0x040032B4 RID: 12980
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040032B5 RID: 12981
		internal static int __PropertyOffset_CurrentScore;

		// Token: 0x040032B6 RID: 12982
		internal static int __PropertyOffset_Level2Threshold;

		// Token: 0x040032B7 RID: 12983
		internal static int __PropertyOffset_Level3Threshold;

		// Token: 0x040032B8 RID: 12984
		internal static int __PropertyOffset_Level4Threshold;

		// Token: 0x040032B9 RID: 12985
		internal static int __PropertyOffset_MaxScore;

		// Token: 0x040032BA RID: 12986
		internal static int __PropertyOffset_Level1ScoreMultiplier;

		// Token: 0x040032BB RID: 12987
		internal static int __PropertyOffset_Level2ScoreMultiplier;

		// Token: 0x040032BC RID: 12988
		internal static int __PropertyOffset_Level3ScoreMultiplier;

		// Token: 0x040032BD RID: 12989
		internal static int __PropertyOffset_Level4ScoreMultiplier;

		// Token: 0x040032BE RID: 12990
		internal static int __PropertyOffset_Level5ScoreMultiplier;
	}
}
