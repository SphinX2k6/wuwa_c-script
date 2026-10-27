using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002402 RID: 9218
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvaluationTemplate")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 352)]
	public class FMovieSceneEvaluationTemplate : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022933 RID: 141619 RVA: 0x00332306 File Offset: 0x00330506
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvaluationTemplate._ScriptStructPtr != 0) ? FMovieSceneEvaluationTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEvaluationTemplate", ref FMovieSceneEvaluationTemplate._ScriptStructPtr);
		}

		// Token: 0x17008518 RID: 34072
		// (get) Token: 0x06022934 RID: 141620 RVA: 0x0033232C File Offset: 0x0033052C
		// (set) Token: 0x06022935 RID: 141621 RVA: 0x0033236F File Offset: 0x0033056F
		public TMap<FMovieSceneTrackIdentifier, FMovieSceneEvaluationTrack> Tracks
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FMovieSceneTrackIdentifier, FMovieSceneEvaluationTrack> result;
				if ((result = this._Tracks) == null)
				{
					result = (this._Tracks = new TMap<FMovieSceneTrackIdentifier, FMovieSceneEvaluationTrack>(base.NativePtr + (IntPtr)FMovieSceneEvaluationTemplate.__PropertyOffset_Tracks, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Tracks.CopyAssign(value);
			}
		}

		// Token: 0x17008519 RID: 34073
		// (get) Token: 0x06022936 RID: 141622 RVA: 0x0033237D File Offset: 0x0033057D
		// (set) Token: 0x06022937 RID: 141623 RVA: 0x00332391 File Offset: 0x00330591
		public unsafe FGuid SequenceSignature
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEvaluationTemplate.__PropertyOffset_SequenceSignature);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEvaluationTemplate.__PropertyOffset_SequenceSignature) = value;
			}
		}

		// Token: 0x1700851A RID: 34074
		// (get) Token: 0x06022938 RID: 141624 RVA: 0x003323A8 File Offset: 0x003305A8
		// (set) Token: 0x06022939 RID: 141625 RVA: 0x003323EB File Offset: 0x003305EB
		public FMovieSceneEvaluationTemplateSerialNumber TemplateSerialNumber
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEvaluationTemplateSerialNumber result;
				if ((result = this._TemplateSerialNumber) == null)
				{
					result = (this._TemplateSerialNumber = new FMovieSceneEvaluationTemplateSerialNumber(base.NativePtr + (IntPtr)FMovieSceneEvaluationTemplate.__PropertyOffset_TemplateSerialNumber, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEvaluationTemplateSerialNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEvaluationTemplate.__PropertyOffset_TemplateSerialNumber, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700851B RID: 34075
		// (get) Token: 0x0602293A RID: 141626 RVA: 0x0033240C File Offset: 0x0033060C
		// (set) Token: 0x0602293B RID: 141627 RVA: 0x0033244F File Offset: 0x0033064F
		public FMovieSceneTemplateGenerationLedger TemplateLedger
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneTemplateGenerationLedger result;
				if ((result = this._TemplateLedger) == null)
				{
					result = (this._TemplateLedger = new FMovieSceneTemplateGenerationLedger(base.NativePtr + (IntPtr)FMovieSceneEvaluationTemplate.__PropertyOffset_TemplateLedger, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneTemplateGenerationLedger.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEvaluationTemplate.__PropertyOffset_TemplateLedger, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602293C RID: 141628 RVA: 0x00332470 File Offset: 0x00330670
		public FMovieSceneEvaluationTemplate()
		{
		}

		// Token: 0x0602293D RID: 141629 RVA: 0x00332478 File Offset: 0x00330678
		public FMovieSceneEvaluationTemplate(TMap<FMovieSceneTrackIdentifier, FMovieSceneEvaluationTrack> Tracks, FGuid SequenceSignature, FMovieSceneEvaluationTemplateSerialNumber TemplateSerialNumber, FMovieSceneTemplateGenerationLedger TemplateLedger)
		{
			this.Tracks = Tracks;
			this.SequenceSignature = SequenceSignature;
			this.TemplateSerialNumber = TemplateSerialNumber;
			this.TemplateLedger = TemplateLedger;
		}

		// Token: 0x0602293E RID: 141630 RVA: 0x0033249D File Offset: 0x0033069D
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvaluationTemplate.StaticStruct();
		}

		// Token: 0x0602293F RID: 141631 RVA: 0x003324A9 File Offset: 0x003306A9
		[NullableContext(2)]
		public FMovieSceneEvaluationTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022940 RID: 141632 RVA: 0x003324B3 File Offset: 0x003306B3
		public FMovieSceneEvaluationTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022941 RID: 141633 RVA: 0x003324BE File Offset: 0x003306BE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvaluationTemplate(Pointer, false, true);
		}

		// Token: 0x06022942 RID: 141634 RVA: 0x003324C8 File Offset: 0x003306C8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvaluationTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x040127A1 RID: 75681
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEvaluationTemplate";

		// Token: 0x040127A2 RID: 75682
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040127A3 RID: 75683
		internal static int __PropertyOffset_Tracks;

		// Token: 0x040127A4 RID: 75684
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FMovieSceneTrackIdentifier, FMovieSceneEvaluationTrack> _Tracks;

		// Token: 0x040127A5 RID: 75685
		internal static int __PropertyOffset_SequenceSignature;

		// Token: 0x040127A6 RID: 75686
		internal static int __PropertyOffset_TemplateSerialNumber;

		// Token: 0x040127A7 RID: 75687
		[Nullable(2)]
		private FMovieSceneEvaluationTemplateSerialNumber _TemplateSerialNumber;

		// Token: 0x040127A8 RID: 75688
		internal static int __PropertyOffset_TemplateLedger;

		// Token: 0x040127A9 RID: 75689
		[Nullable(2)]
		private FMovieSceneTemplateGenerationLedger _TemplateLedger;
	}
}
