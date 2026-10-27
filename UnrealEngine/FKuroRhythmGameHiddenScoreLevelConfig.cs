using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C50 RID: 7248
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameHiddenScoreLevelConfig")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FKuroRhythmGameHiddenScoreLevelConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C175 RID: 115061 RVA: 0x00295954 File Offset: 0x00293B54
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRhythmGameHiddenScoreLevelConfig._ScriptStructPtr != 0) ? FKuroRhythmGameHiddenScoreLevelConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.KuroRhythmGameHiddenScoreLevelConfig", ref FKuroRhythmGameHiddenScoreLevelConfig._ScriptStructPtr);
		}

		// Token: 0x1700719C RID: 29084
		// (get) Token: 0x0601C176 RID: 115062 RVA: 0x00295978 File Offset: 0x00293B78
		// (set) Token: 0x0601C177 RID: 115063 RVA: 0x00295988 File Offset: 0x00293B88
		public unsafe int PerfectScore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScoreLevelConfig.__PropertyOffset_PerfectScore);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScoreLevelConfig.__PropertyOffset_PerfectScore) = value;
			}
		}

		// Token: 0x1700719D RID: 29085
		// (get) Token: 0x0601C178 RID: 115064 RVA: 0x00295999 File Offset: 0x00293B99
		// (set) Token: 0x0601C179 RID: 115065 RVA: 0x002959A9 File Offset: 0x00293BA9
		public unsafe int GreatScore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScoreLevelConfig.__PropertyOffset_GreatScore);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScoreLevelConfig.__PropertyOffset_GreatScore) = value;
			}
		}

		// Token: 0x1700719E RID: 29086
		// (get) Token: 0x0601C17A RID: 115066 RVA: 0x002959BA File Offset: 0x00293BBA
		// (set) Token: 0x0601C17B RID: 115067 RVA: 0x002959CA File Offset: 0x00293BCA
		public unsafe int GoodScore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScoreLevelConfig.__PropertyOffset_GoodScore);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScoreLevelConfig.__PropertyOffset_GoodScore) = value;
			}
		}

		// Token: 0x1700719F RID: 29087
		// (get) Token: 0x0601C17C RID: 115068 RVA: 0x002959DB File Offset: 0x00293BDB
		// (set) Token: 0x0601C17D RID: 115069 RVA: 0x002959EB File Offset: 0x00293BEB
		public unsafe int BadScore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScoreLevelConfig.__PropertyOffset_BadScore);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScoreLevelConfig.__PropertyOffset_BadScore) = value;
			}
		}

		// Token: 0x170071A0 RID: 29088
		// (get) Token: 0x0601C17E RID: 115070 RVA: 0x002959FC File Offset: 0x00293BFC
		// (set) Token: 0x0601C17F RID: 115071 RVA: 0x00295A0C File Offset: 0x00293C0C
		public unsafe int MissScore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScoreLevelConfig.__PropertyOffset_MissScore);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScoreLevelConfig.__PropertyOffset_MissScore) = value;
			}
		}

		// Token: 0x0601C180 RID: 115072 RVA: 0x00295A1D File Offset: 0x00293C1D
		public FKuroRhythmGameHiddenScoreLevelConfig()
		{
		}

		// Token: 0x0601C181 RID: 115073 RVA: 0x00295A25 File Offset: 0x00293C25
		public FKuroRhythmGameHiddenScoreLevelConfig(int PerfectScore, int GreatScore, int GoodScore, int BadScore, int MissScore)
		{
			this.PerfectScore = PerfectScore;
			this.GreatScore = GreatScore;
			this.GoodScore = GoodScore;
			this.BadScore = BadScore;
			this.MissScore = MissScore;
		}

		// Token: 0x0601C182 RID: 115074 RVA: 0x00295A52 File Offset: 0x00293C52
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRhythmGameHiddenScoreLevelConfig.StaticStruct();
		}

		// Token: 0x0601C183 RID: 115075 RVA: 0x00295A5E File Offset: 0x00293C5E
		[NullableContext(2)]
		public FKuroRhythmGameHiddenScoreLevelConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C184 RID: 115076 RVA: 0x00295A68 File Offset: 0x00293C68
		public FKuroRhythmGameHiddenScoreLevelConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C185 RID: 115077 RVA: 0x00295A73 File Offset: 0x00293C73
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRhythmGameHiddenScoreLevelConfig(Pointer, false, true);
		}

		// Token: 0x0601C186 RID: 115078 RVA: 0x00295A7D File Offset: 0x00293C7D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRhythmGameHiddenScoreLevelConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400F1B1 RID: 61873
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameHiddenScoreLevelConfig";

		// Token: 0x0400F1B2 RID: 61874
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F1B3 RID: 61875
		internal static int __PropertyOffset_PerfectScore;

		// Token: 0x0400F1B4 RID: 61876
		internal static int __PropertyOffset_GreatScore;

		// Token: 0x0400F1B5 RID: 61877
		internal static int __PropertyOffset_GoodScore;

		// Token: 0x0400F1B6 RID: 61878
		internal static int __PropertyOffset_BadScore;

		// Token: 0x0400F1B7 RID: 61879
		internal static int __PropertyOffset_MissScore;
	}
}
