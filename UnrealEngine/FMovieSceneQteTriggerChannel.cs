using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007D1 RID: 2001
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneQteTriggerChannel")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FMovieSceneQteTriggerChannel : FMovieSceneChannel, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600ACAC RID: 44204 RVA: 0x000FEE76 File Offset: 0x000FD076
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneQteTriggerChannel._ScriptStructPtr != 0) ? FMovieSceneQteTriggerChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneQteTriggerChannel", ref FMovieSceneQteTriggerChannel._ScriptStructPtr);
		}

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x0600ACAD RID: 44205 RVA: 0x000FEE9C File Offset: 0x000FD09C
		// (set) Token: 0x0600ACAE RID: 44206 RVA: 0x000FEEDF File Offset: 0x000FD0DF
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

		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x0600ACAF RID: 44207 RVA: 0x000FEEF0 File Offset: 0x000FD0F0
		// (set) Token: 0x0600ACB0 RID: 44208 RVA: 0x000FEF33 File Offset: 0x000FD133
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

		// Token: 0x0600ACB1 RID: 44209 RVA: 0x000FEF41 File Offset: 0x000FD141
		public FMovieSceneQteTriggerChannel()
		{
		}

		// Token: 0x0600ACB2 RID: 44210 RVA: 0x000FEF49 File Offset: 0x000FD149
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneQteTriggerChannel.StaticStruct();
		}

		// Token: 0x0600ACB3 RID: 44211 RVA: 0x000FEF55 File Offset: 0x000FD155
		[NullableContext(2)]
		public FMovieSceneQteTriggerChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ACB4 RID: 44212 RVA: 0x000FEF5F File Offset: 0x000FD15F
		public FMovieSceneQteTriggerChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ACB5 RID: 44213 RVA: 0x000FEF6A File Offset: 0x000FD16A
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneQteTriggerChannel(Pointer, false, true);
		}

		// Token: 0x0600ACB6 RID: 44214 RVA: 0x000FEF74 File Offset: 0x000FD174
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneQteTriggerChannel(Pointer, MemoryOwner);
		}

		// Token: 0x04004A73 RID: 19059
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneQteTriggerChannel";

		// Token: 0x04004A74 RID: 19060
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004A75 RID: 19061
		internal static int __PropertyOffset_KeyTimes;

		// Token: 0x04004A76 RID: 19062
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFrameNumber> _KeyTimes;

		// Token: 0x04004A77 RID: 19063
		internal static int __PropertyOffset_KeyValues;

		// Token: 0x04004A78 RID: 19064
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneQteParams> _KeyValues;
	}
}
