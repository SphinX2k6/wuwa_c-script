using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002363 RID: 9059
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneComponentMultipleMaterialSectionTemplate")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FMovieSceneComponentMultipleMaterialSectionTemplate : FMovieSceneParameterSectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602235D RID: 140125 RVA: 0x0032969A File Offset: 0x0032789A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneComponentMultipleMaterialSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneComponentMultipleMaterialSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneComponentMultipleMaterialSectionTemplate", ref FMovieSceneComponentMultipleMaterialSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x17008411 RID: 33809
		// (get) Token: 0x0602235E RID: 140126 RVA: 0x003296C0 File Offset: 0x003278C0
		// (set) Token: 0x0602235F RID: 140127 RVA: 0x00329703 File Offset: 0x00327903
		public TArray<int> MaterialIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._MaterialIndices) == null)
				{
					result = (this._MaterialIndices = new TArray<int>(base.NativePtr + (IntPtr)FMovieSceneComponentMultipleMaterialSectionTemplate.__PropertyOffset_MaterialIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialIndices.CopyAssign(value);
			}
		}

		// Token: 0x06022360 RID: 140128 RVA: 0x00329711 File Offset: 0x00327911
		public FMovieSceneComponentMultipleMaterialSectionTemplate()
		{
		}

		// Token: 0x06022361 RID: 140129 RVA: 0x0032971C File Offset: 0x0032791C
		public FMovieSceneComponentMultipleMaterialSectionTemplate(TArray<int> MaterialIndices, TArray<FScalarParameterNameAndCurve> Scalars, TArray<FBoolParameterNameAndCurve> Bools, TArray<FVector2DParameterNameAndCurves> Vector2Ds, TArray<FVectorParameterNameAndCurves> Vectors, TArray<FColorParameterNameAndCurves> Colors, TArray<FTransformParameterNameAndCurves> Transforms, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.MaterialIndices = MaterialIndices;
			base.Scalars = Scalars;
			base.Bools = Bools;
			base.Vector2Ds = Vector2Ds;
			base.Vectors = Vectors;
			base.Colors = Colors;
			base.Transforms = Transforms;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06022362 RID: 140130 RVA: 0x00329774 File Offset: 0x00327974
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneComponentMultipleMaterialSectionTemplate.StaticStruct();
		}

		// Token: 0x06022363 RID: 140131 RVA: 0x00329780 File Offset: 0x00327980
		[NullableContext(2)]
		public FMovieSceneComponentMultipleMaterialSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022364 RID: 140132 RVA: 0x0032978A File Offset: 0x0032798A
		public FMovieSceneComponentMultipleMaterialSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022365 RID: 140133 RVA: 0x00329795 File Offset: 0x00327995
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneComponentMultipleMaterialSectionTemplate(Pointer, false, true);
		}

		// Token: 0x06022366 RID: 140134 RVA: 0x0032979F File Offset: 0x0032799F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneComponentMultipleMaterialSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x0401242E RID: 74798
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneComponentMultipleMaterialSectionTemplate";

		// Token: 0x0401242F RID: 74799
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012430 RID: 74800
		internal static int __PropertyOffset_MaterialIndices;

		// Token: 0x04012431 RID: 74801
		[Nullable(2)]
		private TArray<int> _MaterialIndices;
	}
}
