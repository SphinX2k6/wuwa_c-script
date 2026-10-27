using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023AB RID: 9131
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneSlomoSectionTemplate")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FMovieSceneSlomoSectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022637 RID: 140855 RVA: 0x0032DC69 File Offset: 0x0032BE69
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSlomoSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneSlomoSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneSlomoSectionTemplate", ref FMovieSceneSlomoSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x1700848C RID: 33932
		// (get) Token: 0x06022638 RID: 140856 RVA: 0x0032DC90 File Offset: 0x0032BE90
		// (set) Token: 0x06022639 RID: 140857 RVA: 0x0032DCD3 File Offset: 0x0032BED3
		public FMovieSceneFloatChannel SlomoCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._SlomoCurve) == null)
				{
					result = (this._SlomoCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FMovieSceneSlomoSectionTemplate.__PropertyOffset_SlomoCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSlomoSectionTemplate.__PropertyOffset_SlomoCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602263A RID: 140858 RVA: 0x0032DCF4 File Offset: 0x0032BEF4
		public FMovieSceneSlomoSectionTemplate()
		{
		}

		// Token: 0x0602263B RID: 140859 RVA: 0x0032DCFC File Offset: 0x0032BEFC
		public FMovieSceneSlomoSectionTemplate(FMovieSceneFloatChannel SlomoCurve, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.SlomoCurve = SlomoCurve;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x0602263C RID: 140860 RVA: 0x0032DD19 File Offset: 0x0032BF19
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSlomoSectionTemplate.StaticStruct();
		}

		// Token: 0x0602263D RID: 140861 RVA: 0x0032DD25 File Offset: 0x0032BF25
		[NullableContext(2)]
		public FMovieSceneSlomoSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602263E RID: 140862 RVA: 0x0032DD2F File Offset: 0x0032BF2F
		public FMovieSceneSlomoSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602263F RID: 140863 RVA: 0x0032DD3A File Offset: 0x0032BF3A
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSlomoSectionTemplate(Pointer, false, true);
		}

		// Token: 0x06022640 RID: 140864 RVA: 0x0032DD44 File Offset: 0x0032BF44
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSlomoSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x040125BE RID: 75198
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneSlomoSectionTemplate";

		// Token: 0x040125BF RID: 75199
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040125C0 RID: 75200
		internal static int __PropertyOffset_SlomoCurve;

		// Token: 0x040125C1 RID: 75201
		[Nullable(2)]
		private FMovieSceneFloatChannel _SlomoCurve;
	}
}
