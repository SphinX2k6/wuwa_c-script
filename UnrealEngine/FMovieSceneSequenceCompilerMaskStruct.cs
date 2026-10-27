using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200242F RID: 9263
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSequenceCompilerMaskStruct")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class FMovieSceneSequenceCompilerMaskStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022B54 RID: 142164 RVA: 0x0033546C File Offset: 0x0033366C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSequenceCompilerMaskStruct._ScriptStructPtr != 0) ? FMovieSceneSequenceCompilerMaskStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSequenceCompilerMaskStruct", ref FMovieSceneSequenceCompilerMaskStruct._ScriptStructPtr);
		}

		// Token: 0x17008585 RID: 34181
		// (get) Token: 0x06022B55 RID: 142165 RVA: 0x00335490 File Offset: 0x00333690
		// (set) Token: 0x06022B56 RID: 142166 RVA: 0x003354A9 File Offset: 0x003336A9
		public unsafe bool bHierarchy
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneSequenceCompilerMaskStruct.__PropertyOffset_bHierarchy) & FMovieSceneSequenceCompilerMaskStruct.__PropertyMask_bHierarchy) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneSequenceCompilerMaskStruct.__PropertyOffset_bHierarchy) = ((*(base.NativePtr + (IntPtr)FMovieSceneSequenceCompilerMaskStruct.__PropertyOffset_bHierarchy) & ~FMovieSceneSequenceCompilerMaskStruct.__PropertyMask_bHierarchy) | (value ? FMovieSceneSequenceCompilerMaskStruct.__PropertyMask_bHierarchy : 0));
			}
		}

		// Token: 0x17008586 RID: 34182
		// (get) Token: 0x06022B57 RID: 142167 RVA: 0x003354D9 File Offset: 0x003336D9
		// (set) Token: 0x06022B58 RID: 142168 RVA: 0x003354F2 File Offset: 0x003336F2
		public unsafe bool bEvaluationTemplate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneSequenceCompilerMaskStruct.__PropertyOffset_bEvaluationTemplate) & FMovieSceneSequenceCompilerMaskStruct.__PropertyMask_bEvaluationTemplate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneSequenceCompilerMaskStruct.__PropertyOffset_bEvaluationTemplate) = ((*(base.NativePtr + (IntPtr)FMovieSceneSequenceCompilerMaskStruct.__PropertyOffset_bEvaluationTemplate) & ~FMovieSceneSequenceCompilerMaskStruct.__PropertyMask_bEvaluationTemplate) | (value ? FMovieSceneSequenceCompilerMaskStruct.__PropertyMask_bEvaluationTemplate : 0));
			}
		}

		// Token: 0x17008587 RID: 34183
		// (get) Token: 0x06022B59 RID: 142169 RVA: 0x00335522 File Offset: 0x00333722
		// (set) Token: 0x06022B5A RID: 142170 RVA: 0x0033553B File Offset: 0x0033373B
		public unsafe bool bEvaluationTemplateField
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneSequenceCompilerMaskStruct.__PropertyOffset_bEvaluationTemplateField) & FMovieSceneSequenceCompilerMaskStruct.__PropertyMask_bEvaluationTemplateField) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneSequenceCompilerMaskStruct.__PropertyOffset_bEvaluationTemplateField) = ((*(base.NativePtr + (IntPtr)FMovieSceneSequenceCompilerMaskStruct.__PropertyOffset_bEvaluationTemplateField) & ~FMovieSceneSequenceCompilerMaskStruct.__PropertyMask_bEvaluationTemplateField) | (value ? FMovieSceneSequenceCompilerMaskStruct.__PropertyMask_bEvaluationTemplateField : 0));
			}
		}

		// Token: 0x17008588 RID: 34184
		// (get) Token: 0x06022B5B RID: 142171 RVA: 0x0033556B File Offset: 0x0033376B
		// (set) Token: 0x06022B5C RID: 142172 RVA: 0x00335584 File Offset: 0x00333784
		public unsafe bool bEntityComponentField
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneSequenceCompilerMaskStruct.__PropertyOffset_bEntityComponentField) & FMovieSceneSequenceCompilerMaskStruct.__PropertyMask_bEntityComponentField) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneSequenceCompilerMaskStruct.__PropertyOffset_bEntityComponentField) = ((*(base.NativePtr + (IntPtr)FMovieSceneSequenceCompilerMaskStruct.__PropertyOffset_bEntityComponentField) & ~FMovieSceneSequenceCompilerMaskStruct.__PropertyMask_bEntityComponentField) | (value ? FMovieSceneSequenceCompilerMaskStruct.__PropertyMask_bEntityComponentField : 0));
			}
		}

		// Token: 0x06022B5D RID: 142173 RVA: 0x003355B4 File Offset: 0x003337B4
		public FMovieSceneSequenceCompilerMaskStruct()
		{
		}

		// Token: 0x06022B5E RID: 142174 RVA: 0x003355BC File Offset: 0x003337BC
		public FMovieSceneSequenceCompilerMaskStruct(bool bHierarchy, bool bEvaluationTemplate, bool bEvaluationTemplateField, bool bEntityComponentField)
		{
			this.bHierarchy = bHierarchy;
			this.bEvaluationTemplate = bEvaluationTemplate;
			this.bEvaluationTemplateField = bEvaluationTemplateField;
			this.bEntityComponentField = bEntityComponentField;
		}

		// Token: 0x06022B5F RID: 142175 RVA: 0x003355E1 File Offset: 0x003337E1
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSequenceCompilerMaskStruct.StaticStruct();
		}

		// Token: 0x06022B60 RID: 142176 RVA: 0x003355ED File Offset: 0x003337ED
		[NullableContext(2)]
		public FMovieSceneSequenceCompilerMaskStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022B61 RID: 142177 RVA: 0x003355F7 File Offset: 0x003337F7
		public FMovieSceneSequenceCompilerMaskStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022B62 RID: 142178 RVA: 0x00335602 File Offset: 0x00333802
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSequenceCompilerMaskStruct(Pointer, false, true);
		}

		// Token: 0x06022B63 RID: 142179 RVA: 0x0033560C File Offset: 0x0033380C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSequenceCompilerMaskStruct(Pointer, MemoryOwner);
		}

		// Token: 0x040128A9 RID: 75945
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSequenceCompilerMaskStruct";

		// Token: 0x040128AA RID: 75946
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040128AB RID: 75947
		internal static int __PropertyOffset_bHierarchy;

		// Token: 0x040128AC RID: 75948
		internal static byte __PropertyMask_bHierarchy;

		// Token: 0x040128AD RID: 75949
		internal static int __PropertyOffset_bEvaluationTemplate;

		// Token: 0x040128AE RID: 75950
		internal static byte __PropertyMask_bEvaluationTemplate;

		// Token: 0x040128AF RID: 75951
		internal static int __PropertyOffset_bEvaluationTemplateField;

		// Token: 0x040128B0 RID: 75952
		internal static byte __PropertyMask_bEvaluationTemplateField;

		// Token: 0x040128B1 RID: 75953
		internal static int __PropertyOffset_bEntityComponentField;

		// Token: 0x040128B2 RID: 75954
		internal static byte __PropertyMask_bEntityComponentField;
	}
}
