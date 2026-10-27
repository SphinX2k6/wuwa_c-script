using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002393 RID: 9107
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneParticleParameterSectionTemplate")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FMovieSceneParticleParameterSectionTemplate : FMovieSceneParameterSectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602252E RID: 140590 RVA: 0x0032C28D File Offset: 0x0032A48D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneParticleParameterSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneParticleParameterSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneParticleParameterSectionTemplate", ref FMovieSceneParticleParameterSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x0602252F RID: 140591 RVA: 0x0032C2B1 File Offset: 0x0032A4B1
		public FMovieSceneParticleParameterSectionTemplate()
		{
		}

		// Token: 0x06022530 RID: 140592 RVA: 0x0032C2BC File Offset: 0x0032A4BC
		[NullableContext(1)]
		public FMovieSceneParticleParameterSectionTemplate(TArray<FScalarParameterNameAndCurve> Scalars, TArray<FBoolParameterNameAndCurve> Bools, TArray<FVector2DParameterNameAndCurves> Vector2Ds, TArray<FVectorParameterNameAndCurves> Vectors, TArray<FColorParameterNameAndCurves> Colors, TArray<FTransformParameterNameAndCurves> Transforms, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			base.Scalars = Scalars;
			base.Bools = Bools;
			base.Vector2Ds = Vector2Ds;
			base.Vectors = Vectors;
			base.Colors = Colors;
			base.Transforms = Transforms;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06022531 RID: 140593 RVA: 0x0032C30C File Offset: 0x0032A50C
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneParticleParameterSectionTemplate.StaticStruct();
		}

		// Token: 0x06022532 RID: 140594 RVA: 0x0032C318 File Offset: 0x0032A518
		[NullableContext(2)]
		public FMovieSceneParticleParameterSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022533 RID: 140595 RVA: 0x0032C322 File Offset: 0x0032A522
		public FMovieSceneParticleParameterSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022534 RID: 140596 RVA: 0x0032C32D File Offset: 0x0032A52D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneParticleParameterSectionTemplate(Pointer, false, true);
		}

		// Token: 0x06022535 RID: 140597 RVA: 0x0032C337 File Offset: 0x0032A537
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneParticleParameterSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012525 RID: 75045
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneParticleParameterSectionTemplate";

		// Token: 0x04012526 RID: 75046
		private static IntPtr _ScriptStructPtr;
	}
}
