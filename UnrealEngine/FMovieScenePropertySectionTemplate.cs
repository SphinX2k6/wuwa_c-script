using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002424 RID: 9252
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieScenePropertySectionTemplate")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FMovieScenePropertySectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022A9D RID: 141981 RVA: 0x00334199 File Offset: 0x00332399
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieScenePropertySectionTemplate._ScriptStructPtr != 0) ? FMovieScenePropertySectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieScenePropertySectionTemplate", ref FMovieScenePropertySectionTemplate._ScriptStructPtr);
		}

		// Token: 0x1700855E RID: 34142
		// (get) Token: 0x06022A9E RID: 141982 RVA: 0x003341C0 File Offset: 0x003323C0
		// (set) Token: 0x06022A9F RID: 141983 RVA: 0x00334203 File Offset: 0x00332403
		public FMovieScenePropertySectionData PropertyData
		{
			get
			{
				base.FastCheckIsValid();
				FMovieScenePropertySectionData result;
				if ((result = this._PropertyData) == null)
				{
					result = (this._PropertyData = new FMovieScenePropertySectionData(base.NativePtr + (IntPtr)FMovieScenePropertySectionTemplate.__PropertyOffset_PropertyData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieScenePropertySectionData.StaticStruct(), base.NativePtr + (IntPtr)FMovieScenePropertySectionTemplate.__PropertyOffset_PropertyData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022AA0 RID: 141984 RVA: 0x00334224 File Offset: 0x00332424
		public FMovieScenePropertySectionTemplate()
		{
		}

		// Token: 0x06022AA1 RID: 141985 RVA: 0x0033422C File Offset: 0x0033242C
		public FMovieScenePropertySectionTemplate(FMovieScenePropertySectionData PropertyData, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.PropertyData = PropertyData;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06022AA2 RID: 141986 RVA: 0x00334249 File Offset: 0x00332449
		protected override IntPtr GetUStructPtr()
		{
			return FMovieScenePropertySectionTemplate.StaticStruct();
		}

		// Token: 0x06022AA3 RID: 141987 RVA: 0x00334255 File Offset: 0x00332455
		[NullableContext(2)]
		public FMovieScenePropertySectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022AA4 RID: 141988 RVA: 0x0033425F File Offset: 0x0033245F
		public FMovieScenePropertySectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022AA5 RID: 141989 RVA: 0x0033426A File Offset: 0x0033246A
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieScenePropertySectionTemplate(Pointer, false, true);
		}

		// Token: 0x06022AA6 RID: 141990 RVA: 0x00334274 File Offset: 0x00332474
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieScenePropertySectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x0401284A RID: 75850
		public new const string __ObjectPath = "/Script/MovieScene.MovieScenePropertySectionTemplate";

		// Token: 0x0401284B RID: 75851
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401284C RID: 75852
		internal static int __PropertyOffset_PropertyData;

		// Token: 0x0401284D RID: 75853
		[Nullable(2)]
		private FMovieScenePropertySectionData _PropertyData;
	}
}
