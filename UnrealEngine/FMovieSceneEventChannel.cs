using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200236C RID: 9068
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEventChannel")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FMovieSceneEventChannel : FMovieSceneChannel, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060223A1 RID: 140193 RVA: 0x00329D3F File Offset: 0x00327F3F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEventChannel._ScriptStructPtr != 0) ? FMovieSceneEventChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneEventChannel", ref FMovieSceneEventChannel._ScriptStructPtr);
		}

		// Token: 0x17008417 RID: 33815
		// (get) Token: 0x060223A2 RID: 140194 RVA: 0x00329D64 File Offset: 0x00327F64
		// (set) Token: 0x060223A3 RID: 140195 RVA: 0x00329DA7 File Offset: 0x00327FA7
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

		// Token: 0x17008418 RID: 33816
		// (get) Token: 0x060223A4 RID: 140196 RVA: 0x00329DB8 File Offset: 0x00327FB8
		// (set) Token: 0x060223A5 RID: 140197 RVA: 0x00329DFB File Offset: 0x00327FFB
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

		// Token: 0x060223A6 RID: 140198 RVA: 0x00329E09 File Offset: 0x00328009
		public FMovieSceneEventChannel()
		{
		}

		// Token: 0x060223A7 RID: 140199 RVA: 0x00329E11 File Offset: 0x00328011
		public FMovieSceneEventChannel(TArray<FFrameNumber> KeyTimes, TArray<FMovieSceneEvent> KeyValues)
		{
			this.KeyTimes = KeyTimes;
			this.KeyValues = KeyValues;
		}

		// Token: 0x060223A8 RID: 140200 RVA: 0x00329E27 File Offset: 0x00328027
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEventChannel.StaticStruct();
		}

		// Token: 0x060223A9 RID: 140201 RVA: 0x00329E33 File Offset: 0x00328033
		[NullableContext(2)]
		public FMovieSceneEventChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060223AA RID: 140202 RVA: 0x00329E3D File Offset: 0x0032803D
		public FMovieSceneEventChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060223AB RID: 140203 RVA: 0x00329E48 File Offset: 0x00328048
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEventChannel(Pointer, false, true);
		}

		// Token: 0x060223AC RID: 140204 RVA: 0x00329E52 File Offset: 0x00328052
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEventChannel(Pointer, MemoryOwner);
		}

		// Token: 0x04012453 RID: 74835
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEventChannel";

		// Token: 0x04012454 RID: 74836
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012455 RID: 74837
		internal static int __PropertyOffset_KeyTimes;

		// Token: 0x04012456 RID: 74838
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFrameNumber> _KeyTimes;

		// Token: 0x04012457 RID: 74839
		internal static int __PropertyOffset_KeyValues;

		// Token: 0x04012458 RID: 74840
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneEvent> _KeyValues;
	}
}
