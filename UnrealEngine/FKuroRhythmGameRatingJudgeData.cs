using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C56 RID: 7254
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameRatingJudgeData")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FKuroRhythmGameRatingJudgeData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C248 RID: 115272 RVA: 0x002977AD File Offset: 0x002959AD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRhythmGameRatingJudgeData._ScriptStructPtr != 0) ? FKuroRhythmGameRatingJudgeData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.KuroRhythmGameRatingJudgeData", ref FKuroRhythmGameRatingJudgeData._ScriptStructPtr);
		}

		// Token: 0x170071D9 RID: 29145
		// (get) Token: 0x0601C249 RID: 115273 RVA: 0x002977D1 File Offset: 0x002959D1
		// (set) Token: 0x0601C24A RID: 115274 RVA: 0x002977E1 File Offset: 0x002959E1
		public unsafe EKuroRhythmGameRating Rating
		{
			get
			{
				return (EKuroRhythmGameRating)(*(base.NativePtr + (IntPtr)FKuroRhythmGameRatingJudgeData.__PropertyOffset_Rating));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameRatingJudgeData.__PropertyOffset_Rating) = (byte)value;
			}
		}

		// Token: 0x170071DA RID: 29146
		// (get) Token: 0x0601C24B RID: 115275 RVA: 0x002977F2 File Offset: 0x002959F2
		// (set) Token: 0x0601C24C RID: 115276 RVA: 0x00297802 File Offset: 0x00295A02
		public unsafe float EarlyTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameRatingJudgeData.__PropertyOffset_EarlyTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameRatingJudgeData.__PropertyOffset_EarlyTime) = value;
			}
		}

		// Token: 0x170071DB RID: 29147
		// (get) Token: 0x0601C24D RID: 115277 RVA: 0x00297813 File Offset: 0x00295A13
		// (set) Token: 0x0601C24E RID: 115278 RVA: 0x00297823 File Offset: 0x00295A23
		public unsafe float LateTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameRatingJudgeData.__PropertyOffset_LateTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameRatingJudgeData.__PropertyOffset_LateTime) = value;
			}
		}

		// Token: 0x170071DC RID: 29148
		// (get) Token: 0x0601C24F RID: 115279 RVA: 0x00297834 File Offset: 0x00295A34
		// (set) Token: 0x0601C250 RID: 115280 RVA: 0x00297844 File Offset: 0x00295A44
		public unsafe int Score
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameRatingJudgeData.__PropertyOffset_Score);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameRatingJudgeData.__PropertyOffset_Score) = value;
			}
		}

		// Token: 0x170071DD RID: 29149
		// (get) Token: 0x0601C251 RID: 115281 RVA: 0x00297855 File Offset: 0x00295A55
		// (set) Token: 0x0601C252 RID: 115282 RVA: 0x00297865 File Offset: 0x00295A65
		public unsafe float Multiple
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameRatingJudgeData.__PropertyOffset_Multiple);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameRatingJudgeData.__PropertyOffset_Multiple) = value;
			}
		}

		// Token: 0x0601C253 RID: 115283 RVA: 0x00297876 File Offset: 0x00295A76
		public FKuroRhythmGameRatingJudgeData()
		{
		}

		// Token: 0x0601C254 RID: 115284 RVA: 0x0029787E File Offset: 0x00295A7E
		public FKuroRhythmGameRatingJudgeData(EKuroRhythmGameRating Rating, float EarlyTime, float LateTime, int Score, float Multiple)
		{
			this.Rating = Rating;
			this.EarlyTime = EarlyTime;
			this.LateTime = LateTime;
			this.Score = Score;
			this.Multiple = Multiple;
		}

		// Token: 0x0601C255 RID: 115285 RVA: 0x002978AB File Offset: 0x00295AAB
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRhythmGameRatingJudgeData.StaticStruct();
		}

		// Token: 0x0601C256 RID: 115286 RVA: 0x002978B7 File Offset: 0x00295AB7
		[NullableContext(2)]
		public FKuroRhythmGameRatingJudgeData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C257 RID: 115287 RVA: 0x002978C1 File Offset: 0x00295AC1
		public FKuroRhythmGameRatingJudgeData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C258 RID: 115288 RVA: 0x002978CC File Offset: 0x00295ACC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRhythmGameRatingJudgeData(Pointer, false, true);
		}

		// Token: 0x0601C259 RID: 115289 RVA: 0x002978D6 File Offset: 0x00295AD6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRhythmGameRatingJudgeData(Pointer, MemoryOwner);
		}

		// Token: 0x0400F24A RID: 62026
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameRatingJudgeData";

		// Token: 0x0400F24B RID: 62027
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F24C RID: 62028
		internal static int __PropertyOffset_Rating;

		// Token: 0x0400F24D RID: 62029
		internal static int __PropertyOffset_EarlyTime;

		// Token: 0x0400F24E RID: 62030
		internal static int __PropertyOffset_LateTime;

		// Token: 0x0400F24F RID: 62031
		internal static int __PropertyOffset_Score;

		// Token: 0x0400F250 RID: 62032
		internal static int __PropertyOffset_Multiple;
	}
}
