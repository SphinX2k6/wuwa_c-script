using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200076F RID: 1903
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneMechanismEventChannel")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FMovieSceneMechanismEventChannel : FMovieSceneChannel, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A4E1 RID: 42209 RVA: 0x000F38C6 File Offset: 0x000F1AC6
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneMechanismEventChannel._ScriptStructPtr != 0) ? FMovieSceneMechanismEventChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneMechanismEventChannel", ref FMovieSceneMechanismEventChannel._ScriptStructPtr);
		}

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x0600A4E2 RID: 42210 RVA: 0x000F38EC File Offset: 0x000F1AEC
		// (set) Token: 0x0600A4E3 RID: 42211 RVA: 0x000F392F File Offset: 0x000F1B2F
		public TArray<FFrameNumber> KeyTimes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFrameNumber> result;
				if ((result = this._KeyTimes) == null)
				{
					result = (this._KeyTimes = new TArray<FFrameNumber>(base.NativePtr + (IntPtr)FMovieSceneMechanismEventChannel.__PropertyOffset_KeyTimes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KeyTimes.CopyAssign(value);
			}
		}

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x0600A4E4 RID: 42212 RVA: 0x000F3940 File Offset: 0x000F1B40
		// (set) Token: 0x0600A4E5 RID: 42213 RVA: 0x000F3983 File Offset: 0x000F1B83
		public TArray<FMovieSceneMechanismEvent> KeyValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneMechanismEvent> result;
				if ((result = this._KeyValues) == null)
				{
					result = (this._KeyValues = new TArray<FMovieSceneMechanismEvent>(base.NativePtr + (IntPtr)FMovieSceneMechanismEventChannel.__PropertyOffset_KeyValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KeyValues.CopyAssign(value);
			}
		}

		// Token: 0x0600A4E6 RID: 42214 RVA: 0x000F3991 File Offset: 0x000F1B91
		public FMovieSceneMechanismEventChannel()
		{
		}

		// Token: 0x0600A4E7 RID: 42215 RVA: 0x000F3999 File Offset: 0x000F1B99
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneMechanismEventChannel.StaticStruct();
		}

		// Token: 0x0600A4E8 RID: 42216 RVA: 0x000F39A5 File Offset: 0x000F1BA5
		[NullableContext(2)]
		public FMovieSceneMechanismEventChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A4E9 RID: 42217 RVA: 0x000F39AF File Offset: 0x000F1BAF
		public FMovieSceneMechanismEventChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A4EA RID: 42218 RVA: 0x000F39BA File Offset: 0x000F1BBA
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneMechanismEventChannel(Pointer, false, true);
		}

		// Token: 0x0600A4EB RID: 42219 RVA: 0x000F39C4 File Offset: 0x000F1BC4
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneMechanismEventChannel(Pointer, MemoryOwner);
		}

		// Token: 0x04004660 RID: 18016
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneMechanismEventChannel";

		// Token: 0x04004661 RID: 18017
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004662 RID: 18018
		internal static int __PropertyOffset_KeyTimes;

		// Token: 0x04004663 RID: 18019
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFrameNumber> _KeyTimes;

		// Token: 0x04004664 RID: 18020
		internal static int __PropertyOffset_KeyValues;

		// Token: 0x04004665 RID: 18021
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneMechanismEvent> _KeyValues;
	}
}
