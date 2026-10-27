using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200238C RID: 9100
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneMechanismEventChannel")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FMovieSceneMechanismEventChannel : FMovieSceneChannel, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060224C2 RID: 140482 RVA: 0x0032B84B File Offset: 0x00329A4B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneMechanismEventChannel._ScriptStructPtr != 0) ? FMovieSceneMechanismEventChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneMechanismEventChannel", ref FMovieSceneMechanismEventChannel._ScriptStructPtr);
		}

		// Token: 0x1700843F RID: 33855
		// (get) Token: 0x060224C3 RID: 140483 RVA: 0x0032B870 File Offset: 0x00329A70
		// (set) Token: 0x060224C4 RID: 140484 RVA: 0x0032B8B3 File Offset: 0x00329AB3
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

		// Token: 0x17008440 RID: 33856
		// (get) Token: 0x060224C5 RID: 140485 RVA: 0x0032B8C4 File Offset: 0x00329AC4
		// (set) Token: 0x060224C6 RID: 140486 RVA: 0x0032B907 File Offset: 0x00329B07
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

		// Token: 0x060224C7 RID: 140487 RVA: 0x0032B915 File Offset: 0x00329B15
		public FMovieSceneMechanismEventChannel()
		{
		}

		// Token: 0x060224C8 RID: 140488 RVA: 0x0032B91D File Offset: 0x00329B1D
		public FMovieSceneMechanismEventChannel(TArray<FFrameNumber> KeyTimes, TArray<FMovieSceneMechanismEvent> KeyValues)
		{
			this.KeyTimes = KeyTimes;
			this.KeyValues = KeyValues;
		}

		// Token: 0x060224C9 RID: 140489 RVA: 0x0032B933 File Offset: 0x00329B33
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneMechanismEventChannel.StaticStruct();
		}

		// Token: 0x060224CA RID: 140490 RVA: 0x0032B93F File Offset: 0x00329B3F
		[NullableContext(2)]
		public FMovieSceneMechanismEventChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060224CB RID: 140491 RVA: 0x0032B949 File Offset: 0x00329B49
		public FMovieSceneMechanismEventChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060224CC RID: 140492 RVA: 0x0032B954 File Offset: 0x00329B54
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneMechanismEventChannel(Pointer, false, true);
		}

		// Token: 0x060224CD RID: 140493 RVA: 0x0032B95E File Offset: 0x00329B5E
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneMechanismEventChannel(Pointer, MemoryOwner);
		}

		// Token: 0x040124F2 RID: 74994
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneMechanismEventChannel";

		// Token: 0x040124F3 RID: 74995
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040124F4 RID: 74996
		internal static int __PropertyOffset_KeyTimes;

		// Token: 0x040124F5 RID: 74997
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFrameNumber> _KeyTimes;

		// Token: 0x040124F6 RID: 74998
		internal static int __PropertyOffset_KeyValues;

		// Token: 0x040124F7 RID: 74999
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneMechanismEvent> _KeyValues;
	}
}
