using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000765 RID: 1893
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEventChannel")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FMovieSceneEventChannel : FMovieSceneChannel, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A48B RID: 42123 RVA: 0x000F305A File Offset: 0x000F125A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEventChannel._ScriptStructPtr != 0) ? FMovieSceneEventChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneEventChannel", ref FMovieSceneEventChannel._ScriptStructPtr);
		}

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x0600A48C RID: 42124 RVA: 0x000F3080 File Offset: 0x000F1280
		// (set) Token: 0x0600A48D RID: 42125 RVA: 0x000F30C3 File Offset: 0x000F12C3
		public TArray<FFrameNumber> KeyTimes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFrameNumber> result;
				if ((result = this._KeyTimes) == null)
				{
					result = (this._KeyTimes = new TArray<FFrameNumber>(base.NativePtr + (IntPtr)FMovieSceneEventChannel.__PropertyOffset_KeyTimes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KeyTimes.CopyAssign(value);
			}
		}

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x0600A48E RID: 42126 RVA: 0x000F30D4 File Offset: 0x000F12D4
		// (set) Token: 0x0600A48F RID: 42127 RVA: 0x000F3117 File Offset: 0x000F1317
		public TArray<FMovieSceneEvent> KeyValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneEvent> result;
				if ((result = this._KeyValues) == null)
				{
					result = (this._KeyValues = new TArray<FMovieSceneEvent>(base.NativePtr + (IntPtr)FMovieSceneEventChannel.__PropertyOffset_KeyValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KeyValues.CopyAssign(value);
			}
		}

		// Token: 0x0600A490 RID: 42128 RVA: 0x000F3125 File Offset: 0x000F1325
		public FMovieSceneEventChannel()
		{
		}

		// Token: 0x0600A491 RID: 42129 RVA: 0x000F312D File Offset: 0x000F132D
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEventChannel.StaticStruct();
		}

		// Token: 0x0600A492 RID: 42130 RVA: 0x000F3139 File Offset: 0x000F1339
		[NullableContext(2)]
		public FMovieSceneEventChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A493 RID: 42131 RVA: 0x000F3143 File Offset: 0x000F1343
		public FMovieSceneEventChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A494 RID: 42132 RVA: 0x000F314E File Offset: 0x000F134E
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEventChannel(Pointer, false, true);
		}

		// Token: 0x0600A495 RID: 42133 RVA: 0x000F3158 File Offset: 0x000F1358
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEventChannel(Pointer, MemoryOwner);
		}

		// Token: 0x0400462D RID: 17965
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEventChannel";

		// Token: 0x0400462E RID: 17966
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400462F RID: 17967
		internal static int __PropertyOffset_KeyTimes;

		// Token: 0x04004630 RID: 17968
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFrameNumber> _KeyTimes;

		// Token: 0x04004631 RID: 17969
		internal static int __PropertyOffset_KeyValues;

		// Token: 0x04004632 RID: 17970
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneEvent> _KeyValues;
	}
}
