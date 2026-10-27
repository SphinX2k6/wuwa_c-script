using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002360 RID: 9056
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneComponentMaterialSectionTemplate")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FMovieSceneComponentMaterialSectionTemplate : FMovieSceneParameterSectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022345 RID: 140101 RVA: 0x00329492 File Offset: 0x00327692
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneComponentMaterialSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneComponentMaterialSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneComponentMaterialSectionTemplate", ref FMovieSceneComponentMaterialSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x1700840F RID: 33807
		// (get) Token: 0x06022346 RID: 140102 RVA: 0x003294B6 File Offset: 0x003276B6
		// (set) Token: 0x06022347 RID: 140103 RVA: 0x003294C6 File Offset: 0x003276C6
		public unsafe int MaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneComponentMaterialSectionTemplate.__PropertyOffset_MaterialIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneComponentMaterialSectionTemplate.__PropertyOffset_MaterialIndex) = value;
			}
		}

		// Token: 0x06022348 RID: 140104 RVA: 0x003294D7 File Offset: 0x003276D7
		public FMovieSceneComponentMaterialSectionTemplate()
		{
		}

		// Token: 0x06022349 RID: 140105 RVA: 0x003294E0 File Offset: 0x003276E0
		[NullableContext(1)]
		public FMovieSceneComponentMaterialSectionTemplate(int MaterialIndex, TArray<FScalarParameterNameAndCurve> Scalars, TArray<FBoolParameterNameAndCurve> Bools, TArray<FVector2DParameterNameAndCurves> Vector2Ds, TArray<FVectorParameterNameAndCurves> Vectors, TArray<FColorParameterNameAndCurves> Colors, TArray<FTransformParameterNameAndCurves> Transforms, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.MaterialIndex = MaterialIndex;
			base.Scalars = Scalars;
			base.Bools = Bools;
			base.Vector2Ds = Vector2Ds;
			base.Vectors = Vectors;
			base.Colors = Colors;
			base.Transforms = Transforms;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x0602234A RID: 140106 RVA: 0x00329538 File Offset: 0x00327738
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneComponentMaterialSectionTemplate.StaticStruct();
		}

		// Token: 0x0602234B RID: 140107 RVA: 0x00329544 File Offset: 0x00327744
		[NullableContext(2)]
		public FMovieSceneComponentMaterialSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602234C RID: 140108 RVA: 0x0032954E File Offset: 0x0032774E
		public FMovieSceneComponentMaterialSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602234D RID: 140109 RVA: 0x00329559 File Offset: 0x00327759
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneComponentMaterialSectionTemplate(Pointer, false, true);
		}

		// Token: 0x0602234E RID: 140110 RVA: 0x00329563 File Offset: 0x00327763
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneComponentMaterialSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012422 RID: 74786
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneComponentMaterialSectionTemplate";

		// Token: 0x04012423 RID: 74787
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012424 RID: 74788
		internal static int __PropertyOffset_MaterialIndex;
	}
}
