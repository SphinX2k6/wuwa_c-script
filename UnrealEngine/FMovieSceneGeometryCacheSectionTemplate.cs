using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001409 RID: 5129
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCacheTracks.MovieSceneGeometryCacheSectionTemplate")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FMovieSceneGeometryCacheSectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012B9A RID: 76698 RVA: 0x001B902D File Offset: 0x001B722D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneGeometryCacheSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneGeometryCacheSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GeometryCacheTracks.MovieSceneGeometryCacheSectionTemplate", ref FMovieSceneGeometryCacheSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x17004899 RID: 18585
		// (get) Token: 0x06012B9B RID: 76699 RVA: 0x001B9054 File Offset: 0x001B7254
		// (set) Token: 0x06012B9C RID: 76700 RVA: 0x001B9097 File Offset: 0x001B7297
		public FMovieSceneGeometryCacheSectionTemplateParameters Params
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneGeometryCacheSectionTemplateParameters result;
				if ((result = this._Params) == null)
				{
					result = (this._Params = new FMovieSceneGeometryCacheSectionTemplateParameters(base.NativePtr + (IntPtr)FMovieSceneGeometryCacheSectionTemplate.__PropertyOffset_Params, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneGeometryCacheSectionTemplateParameters.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneGeometryCacheSectionTemplate.__PropertyOffset_Params, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06012B9D RID: 76701 RVA: 0x001B90B8 File Offset: 0x001B72B8
		public FMovieSceneGeometryCacheSectionTemplate()
		{
		}

		// Token: 0x06012B9E RID: 76702 RVA: 0x001B90C0 File Offset: 0x001B72C0
		public FMovieSceneGeometryCacheSectionTemplate(FMovieSceneGeometryCacheSectionTemplateParameters Params, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.Params = Params;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06012B9F RID: 76703 RVA: 0x001B90DD File Offset: 0x001B72DD
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneGeometryCacheSectionTemplate.StaticStruct();
		}

		// Token: 0x06012BA0 RID: 76704 RVA: 0x001B90E9 File Offset: 0x001B72E9
		[NullableContext(2)]
		public FMovieSceneGeometryCacheSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012BA1 RID: 76705 RVA: 0x001B90F3 File Offset: 0x001B72F3
		public FMovieSceneGeometryCacheSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012BA2 RID: 76706 RVA: 0x001B90FE File Offset: 0x001B72FE
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneGeometryCacheSectionTemplate(Pointer, false, true);
		}

		// Token: 0x06012BA3 RID: 76707 RVA: 0x001B9108 File Offset: 0x001B7308
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneGeometryCacheSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x0400A02D RID: 41005
		public new const string __ObjectPath = "/Script/GeometryCacheTracks.MovieSceneGeometryCacheSectionTemplate";

		// Token: 0x0400A02E RID: 41006
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A02F RID: 41007
		internal static int __PropertyOffset_Params;

		// Token: 0x0400A030 RID: 41008
		[Nullable(2)]
		private FMovieSceneGeometryCacheSectionTemplateParameters _Params;
	}
}
