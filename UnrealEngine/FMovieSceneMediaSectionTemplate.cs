using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022AD RID: 8877
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MediaCompositing.MovieSceneMediaSectionTemplate")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FMovieSceneMediaSectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021BF5 RID: 138229 RVA: 0x0031E5D8 File Offset: 0x0031C7D8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneMediaSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneMediaSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MediaCompositing.MovieSceneMediaSectionTemplate", ref FMovieSceneMediaSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x170082EB RID: 33515
		// (get) Token: 0x06021BF6 RID: 138230 RVA: 0x0031E5FC File Offset: 0x0031C7FC
		// (set) Token: 0x06021BF7 RID: 138231 RVA: 0x0031E63F File Offset: 0x0031C83F
		public FMovieSceneMediaSectionParams Params
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneMediaSectionParams result;
				if ((result = this._Params) == null)
				{
					result = (this._Params = new FMovieSceneMediaSectionParams(base.NativePtr + (IntPtr)FMovieSceneMediaSectionTemplate.__PropertyOffset_Params, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneMediaSectionParams.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneMediaSectionTemplate.__PropertyOffset_Params, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06021BF8 RID: 138232 RVA: 0x0031E660 File Offset: 0x0031C860
		public FMovieSceneMediaSectionTemplate()
		{
		}

		// Token: 0x06021BF9 RID: 138233 RVA: 0x0031E668 File Offset: 0x0031C868
		public FMovieSceneMediaSectionTemplate(FMovieSceneMediaSectionParams Params, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.Params = Params;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06021BFA RID: 138234 RVA: 0x0031E685 File Offset: 0x0031C885
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneMediaSectionTemplate.StaticStruct();
		}

		// Token: 0x06021BFB RID: 138235 RVA: 0x0031E691 File Offset: 0x0031C891
		[NullableContext(2)]
		public FMovieSceneMediaSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021BFC RID: 138236 RVA: 0x0031E69B File Offset: 0x0031C89B
		public FMovieSceneMediaSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021BFD RID: 138237 RVA: 0x0031E6A6 File Offset: 0x0031C8A6
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneMediaSectionTemplate(Pointer, false, true);
		}

		// Token: 0x06021BFE RID: 138238 RVA: 0x0031E6B0 File Offset: 0x0031C8B0
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneMediaSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012016 RID: 73750
		public new const string __ObjectPath = "/Script/MediaCompositing.MovieSceneMediaSectionTemplate";

		// Token: 0x04012017 RID: 73751
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012018 RID: 73752
		internal static int __PropertyOffset_Params;

		// Token: 0x04012019 RID: 73753
		[Nullable(2)]
		private FMovieSceneMediaSectionParams _Params;
	}
}
