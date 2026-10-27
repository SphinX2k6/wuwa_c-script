using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002373 RID: 9075
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEventSectionData")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FMovieSceneEventSectionData : FMovieSceneChannel, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060223E0 RID: 140256 RVA: 0x0032A2AE File Offset: 0x003284AE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEventSectionData._ScriptStructPtr != 0) ? FMovieSceneEventSectionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneEventSectionData", ref FMovieSceneEventSectionData._ScriptStructPtr);
		}

		// Token: 0x1700841F RID: 33823
		// (get) Token: 0x060223E1 RID: 140257 RVA: 0x0032A2D4 File Offset: 0x003284D4
		// (set) Token: 0x060223E2 RID: 140258 RVA: 0x0032A317 File Offset: 0x00328517
		public TArray<FFrameNumber> Times
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFrameNumber> result;
				if ((result = this._Times) == null)
				{
					result = (this._Times = new TArray<FFrameNumber>(base.NativePtr + (IntPtr)FMovieSceneEventSectionData.__PropertyOffset_Times, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Times.CopyAssign(value);
			}
		}

		// Token: 0x17008420 RID: 33824
		// (get) Token: 0x060223E3 RID: 140259 RVA: 0x0032A328 File Offset: 0x00328528
		// (set) Token: 0x060223E4 RID: 140260 RVA: 0x0032A36B File Offset: 0x0032856B
		public TArray<FEventPayload> KeyValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FEventPayload> result;
				if ((result = this._KeyValues) == null)
				{
					result = (this._KeyValues = new TArray<FEventPayload>(base.NativePtr + (IntPtr)FMovieSceneEventSectionData.__PropertyOffset_KeyValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KeyValues.CopyAssign(value);
			}
		}

		// Token: 0x060223E5 RID: 140261 RVA: 0x0032A379 File Offset: 0x00328579
		public FMovieSceneEventSectionData()
		{
		}

		// Token: 0x060223E6 RID: 140262 RVA: 0x0032A381 File Offset: 0x00328581
		public FMovieSceneEventSectionData(TArray<FFrameNumber> Times, TArray<FEventPayload> KeyValues, TArray<float> KeyTimes_DEPRECATED)
		{
			this.Times = Times;
			this.KeyValues = KeyValues;
		}

		// Token: 0x060223E7 RID: 140263 RVA: 0x0032A397 File Offset: 0x00328597
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEventSectionData.StaticStruct();
		}

		// Token: 0x060223E8 RID: 140264 RVA: 0x0032A3A3 File Offset: 0x003285A3
		[NullableContext(2)]
		public FMovieSceneEventSectionData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060223E9 RID: 140265 RVA: 0x0032A3AD File Offset: 0x003285AD
		public FMovieSceneEventSectionData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060223EA RID: 140266 RVA: 0x0032A3B8 File Offset: 0x003285B8
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEventSectionData(Pointer, false, true);
		}

		// Token: 0x060223EB RID: 140267 RVA: 0x0032A3C2 File Offset: 0x003285C2
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEventSectionData(Pointer, MemoryOwner);
		}

		// Token: 0x04012472 RID: 74866
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEventSectionData";

		// Token: 0x04012473 RID: 74867
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012474 RID: 74868
		internal static int __PropertyOffset_Times;

		// Token: 0x04012475 RID: 74869
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFrameNumber> _Times;

		// Token: 0x04012476 RID: 74870
		internal static int __PropertyOffset_KeyValues;

		// Token: 0x04012477 RID: 74871
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FEventPayload> _KeyValues;
	}
}
