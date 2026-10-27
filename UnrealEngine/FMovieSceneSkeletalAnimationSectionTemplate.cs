using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023A6 RID: 9126
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationSectionTemplate")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 288)]
	public class FMovieSceneSkeletalAnimationSectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022605 RID: 140805 RVA: 0x0032D6F8 File Offset: 0x0032B8F8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSkeletalAnimationSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneSkeletalAnimationSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationSectionTemplate", ref FMovieSceneSkeletalAnimationSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x17008484 RID: 33924
		// (get) Token: 0x06022606 RID: 140806 RVA: 0x0032D71C File Offset: 0x0032B91C
		// (set) Token: 0x06022607 RID: 140807 RVA: 0x0032D75F File Offset: 0x0032B95F
		public FMovieSceneSkeletalAnimationSectionTemplateParameters Params
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSkeletalAnimationSectionTemplateParameters result;
				if ((result = this._Params) == null)
				{
					result = (this._Params = new FMovieSceneSkeletalAnimationSectionTemplateParameters(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationSectionTemplate.__PropertyOffset_Params, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSkeletalAnimationSectionTemplateParameters.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationSectionTemplate.__PropertyOffset_Params, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022608 RID: 140808 RVA: 0x0032D780 File Offset: 0x0032B980
		public FMovieSceneSkeletalAnimationSectionTemplate()
		{
		}

		// Token: 0x06022609 RID: 140809 RVA: 0x0032D788 File Offset: 0x0032B988
		public FMovieSceneSkeletalAnimationSectionTemplate(FMovieSceneSkeletalAnimationSectionTemplateParameters Params, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.Params = Params;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x0602260A RID: 140810 RVA: 0x0032D7A5 File Offset: 0x0032B9A5
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSkeletalAnimationSectionTemplate.StaticStruct();
		}

		// Token: 0x0602260B RID: 140811 RVA: 0x0032D7B1 File Offset: 0x0032B9B1
		[NullableContext(2)]
		public FMovieSceneSkeletalAnimationSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602260C RID: 140812 RVA: 0x0032D7BB File Offset: 0x0032B9BB
		public FMovieSceneSkeletalAnimationSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602260D RID: 140813 RVA: 0x0032D7C6 File Offset: 0x0032B9C6
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSkeletalAnimationSectionTemplate(Pointer, false, true);
		}

		// Token: 0x0602260E RID: 140814 RVA: 0x0032D7D0 File Offset: 0x0032B9D0
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSkeletalAnimationSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x040125A3 RID: 75171
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneSkeletalAnimationSectionTemplate";

		// Token: 0x040125A4 RID: 75172
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040125A5 RID: 75173
		internal static int __PropertyOffset_Params;

		// Token: 0x040125A6 RID: 75174
		[Nullable(2)]
		private FMovieSceneSkeletalAnimationSectionTemplateParameters _Params;
	}
}
