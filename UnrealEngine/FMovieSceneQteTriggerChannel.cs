using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026F9 RID: 9977
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneQteTriggerChannel")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FMovieSceneQteTriggerChannel : FMovieSceneChannel, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025013 RID: 151571 RVA: 0x0036BEB2 File Offset: 0x0036A0B2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneQteTriggerChannel._ScriptStructPtr != 0) ? FMovieSceneQteTriggerChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneQteTriggerChannel", ref FMovieSceneQteTriggerChannel._ScriptStructPtr);
		}

		// Token: 0x17008EE4 RID: 36580
		// (get) Token: 0x06025014 RID: 151572 RVA: 0x0036BED8 File Offset: 0x0036A0D8
		// (set) Token: 0x06025015 RID: 151573 RVA: 0x0036BF1B File Offset: 0x0036A11B
		public TArray<FFrameNumber> KeyTimes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFrameNumber> result;
				if ((result = this._KeyTimes) == null)
				{
					result = (this._KeyTimes = new TArray<FFrameNumber>(base.NativePtr + (IntPtr)FMovieSceneQteTriggerChannel.__PropertyOffset_KeyTimes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KeyTimes.CopyAssign(value);
			}
		}

		// Token: 0x17008EE5 RID: 36581
		// (get) Token: 0x06025016 RID: 151574 RVA: 0x0036BF2C File Offset: 0x0036A12C
		// (set) Token: 0x06025017 RID: 151575 RVA: 0x0036BF6F File Offset: 0x0036A16F
		public TArray<FMovieSceneQteParams> KeyValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneQteParams> result;
				if ((result = this._KeyValues) == null)
				{
					result = (this._KeyValues = new TArray<FMovieSceneQteParams>(base.NativePtr + (IntPtr)FMovieSceneQteTriggerChannel.__PropertyOffset_KeyValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KeyValues.CopyAssign(value);
			}
		}

		// Token: 0x06025018 RID: 151576 RVA: 0x0036BF7D File Offset: 0x0036A17D
		public FMovieSceneQteTriggerChannel()
		{
		}

		// Token: 0x06025019 RID: 151577 RVA: 0x0036BF85 File Offset: 0x0036A185
		public FMovieSceneQteTriggerChannel(TArray<FFrameNumber> KeyTimes, TArray<FMovieSceneQteParams> KeyValues)
		{
			this.KeyTimes = KeyTimes;
			this.KeyValues = KeyValues;
		}

		// Token: 0x0602501A RID: 151578 RVA: 0x0036BF9B File Offset: 0x0036A19B
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneQteTriggerChannel.StaticStruct();
		}

		// Token: 0x0602501B RID: 151579 RVA: 0x0036BFA7 File Offset: 0x0036A1A7
		[NullableContext(2)]
		public FMovieSceneQteTriggerChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602501C RID: 151580 RVA: 0x0036BFB1 File Offset: 0x0036A1B1
		public FMovieSceneQteTriggerChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602501D RID: 151581 RVA: 0x0036BFBC File Offset: 0x0036A1BC
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneQteTriggerChannel(Pointer, false, true);
		}

		// Token: 0x0602501E RID: 151582 RVA: 0x0036BFC6 File Offset: 0x0036A1C6
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneQteTriggerChannel(Pointer, MemoryOwner);
		}

		// Token: 0x04013F11 RID: 81681
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneQteTriggerChannel";

		// Token: 0x04013F12 RID: 81682
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013F13 RID: 81683
		internal static int __PropertyOffset_KeyTimes;

		// Token: 0x04013F14 RID: 81684
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFrameNumber> _KeyTimes;

		// Token: 0x04013F15 RID: 81685
		internal static int __PropertyOffset_KeyValues;

		// Token: 0x04013F16 RID: 81686
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneQteParams> _KeyValues;
	}
}
