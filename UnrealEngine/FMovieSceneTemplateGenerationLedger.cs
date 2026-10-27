using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002448 RID: 9288
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTemplateGenerationLedger")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FMovieSceneTemplateGenerationLedger : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022D23 RID: 142627 RVA: 0x00337E12 File Offset: 0x00336012
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTemplateGenerationLedger._ScriptStructPtr != 0) ? FMovieSceneTemplateGenerationLedger._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneTemplateGenerationLedger", ref FMovieSceneTemplateGenerationLedger._ScriptStructPtr);
		}

		// Token: 0x170085E4 RID: 34276
		// (get) Token: 0x06022D24 RID: 142628 RVA: 0x00337E38 File Offset: 0x00336038
		// (set) Token: 0x06022D25 RID: 142629 RVA: 0x00337E7B File Offset: 0x0033607B
		public FMovieSceneTrackIdentifier LastTrackIdentifier
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneTrackIdentifier result;
				if ((result = this._LastTrackIdentifier) == null)
				{
					result = (this._LastTrackIdentifier = new FMovieSceneTrackIdentifier(base.NativePtr + (IntPtr)FMovieSceneTemplateGenerationLedger.__PropertyOffset_LastTrackIdentifier, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneTrackIdentifier.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneTemplateGenerationLedger.__PropertyOffset_LastTrackIdentifier, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170085E5 RID: 34277
		// (get) Token: 0x06022D26 RID: 142630 RVA: 0x00337E9C File Offset: 0x0033609C
		// (set) Token: 0x06022D27 RID: 142631 RVA: 0x00337EDF File Offset: 0x003360DF
		public TMap<FGuid, FMovieSceneTrackIdentifier> TrackSignatureToTrackIdentifier
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGuid, FMovieSceneTrackIdentifier> result;
				if ((result = this._TrackSignatureToTrackIdentifier) == null)
				{
					result = (this._TrackSignatureToTrackIdentifier = new TMap<FGuid, FMovieSceneTrackIdentifier>(base.NativePtr + (IntPtr)FMovieSceneTemplateGenerationLedger.__PropertyOffset_TrackSignatureToTrackIdentifier, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TrackSignatureToTrackIdentifier.CopyAssign(value);
			}
		}

		// Token: 0x170085E6 RID: 34278
		// (get) Token: 0x06022D28 RID: 142632 RVA: 0x00337EF0 File Offset: 0x003360F0
		// (set) Token: 0x06022D29 RID: 142633 RVA: 0x00337F33 File Offset: 0x00336133
		public TMap<FGuid, FMovieSceneFrameRange> SubSectionRanges
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGuid, FMovieSceneFrameRange> result;
				if ((result = this._SubSectionRanges) == null)
				{
					result = (this._SubSectionRanges = new TMap<FGuid, FMovieSceneFrameRange>(base.NativePtr + (IntPtr)FMovieSceneTemplateGenerationLedger.__PropertyOffset_SubSectionRanges, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SubSectionRanges.CopyAssign(value);
			}
		}

		// Token: 0x06022D2A RID: 142634 RVA: 0x00337F41 File Offset: 0x00336141
		public FMovieSceneTemplateGenerationLedger()
		{
		}

		// Token: 0x06022D2B RID: 142635 RVA: 0x00337F49 File Offset: 0x00336149
		public FMovieSceneTemplateGenerationLedger(FMovieSceneTrackIdentifier LastTrackIdentifier, TMap<FGuid, FMovieSceneTrackIdentifier> TrackSignatureToTrackIdentifier, TMap<FGuid, FMovieSceneFrameRange> SubSectionRanges)
		{
			this.LastTrackIdentifier = LastTrackIdentifier;
			this.TrackSignatureToTrackIdentifier = TrackSignatureToTrackIdentifier;
			this.SubSectionRanges = SubSectionRanges;
		}

		// Token: 0x06022D2C RID: 142636 RVA: 0x00337F66 File Offset: 0x00336166
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneTemplateGenerationLedger.StaticStruct();
		}

		// Token: 0x06022D2D RID: 142637 RVA: 0x00337F72 File Offset: 0x00336172
		[NullableContext(2)]
		public FMovieSceneTemplateGenerationLedger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022D2E RID: 142638 RVA: 0x00337F7C File Offset: 0x0033617C
		public FMovieSceneTemplateGenerationLedger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022D2F RID: 142639 RVA: 0x00337F87 File Offset: 0x00336187
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneTemplateGenerationLedger(Pointer, false, true);
		}

		// Token: 0x06022D30 RID: 142640 RVA: 0x00337F91 File Offset: 0x00336191
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneTemplateGenerationLedger(Pointer, MemoryOwner);
		}

		// Token: 0x0401297E RID: 76158
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneTemplateGenerationLedger";

		// Token: 0x0401297F RID: 76159
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012980 RID: 76160
		internal static int __PropertyOffset_LastTrackIdentifier;

		// Token: 0x04012981 RID: 76161
		[Nullable(2)]
		private FMovieSceneTrackIdentifier _LastTrackIdentifier;

		// Token: 0x04012982 RID: 76162
		internal static int __PropertyOffset_TrackSignatureToTrackIdentifier;

		// Token: 0x04012983 RID: 76163
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGuid, FMovieSceneTrackIdentifier> _TrackSignatureToTrackIdentifier;

		// Token: 0x04012984 RID: 76164
		internal static int __PropertyOffset_SubSectionRanges;

		// Token: 0x04012985 RID: 76165
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGuid, FMovieSceneFrameRange> _SubSectionRanges;
	}
}
