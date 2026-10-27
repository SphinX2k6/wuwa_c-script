using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002388 RID: 9096
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneMaterialParameterCollectionTemplate")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FMovieSceneMaterialParameterCollectionTemplate : FMovieSceneParameterSectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022499 RID: 140441 RVA: 0x0032B4D2 File Offset: 0x003296D2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneMaterialParameterCollectionTemplate._ScriptStructPtr != 0) ? FMovieSceneMaterialParameterCollectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneMaterialParameterCollectionTemplate", ref FMovieSceneMaterialParameterCollectionTemplate._ScriptStructPtr);
		}

		// Token: 0x17008438 RID: 33848
		// (get) Token: 0x0602249A RID: 140442 RVA: 0x0032B4F6 File Offset: 0x003296F6
		// (set) Token: 0x0602249B RID: 140443 RVA: 0x0032B50A File Offset: 0x0032970A
		[Nullable(2)]
		public unsafe UMaterialParameterCollection MPC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneMaterialParameterCollectionTemplate.__PropertyOffset_MPC);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneMaterialParameterCollectionTemplate.__PropertyOffset_MPC, value);
			}
		}

		// Token: 0x0602249C RID: 140444 RVA: 0x0032B51F File Offset: 0x0032971F
		public FMovieSceneMaterialParameterCollectionTemplate()
		{
		}

		// Token: 0x0602249D RID: 140445 RVA: 0x0032B528 File Offset: 0x00329728
		[NullableContext(1)]
		public FMovieSceneMaterialParameterCollectionTemplate(UMaterialParameterCollection MPC, TArray<FScalarParameterNameAndCurve> Scalars, TArray<FBoolParameterNameAndCurve> Bools, TArray<FVector2DParameterNameAndCurves> Vector2Ds, TArray<FVectorParameterNameAndCurves> Vectors, TArray<FColorParameterNameAndCurves> Colors, TArray<FTransformParameterNameAndCurves> Transforms, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.MPC = MPC;
			base.Scalars = Scalars;
			base.Bools = Bools;
			base.Vector2Ds = Vector2Ds;
			base.Vectors = Vectors;
			base.Colors = Colors;
			base.Transforms = Transforms;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x0602249E RID: 140446 RVA: 0x0032B580 File Offset: 0x00329780
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneMaterialParameterCollectionTemplate.StaticStruct();
		}

		// Token: 0x0602249F RID: 140447 RVA: 0x0032B58C File Offset: 0x0032978C
		[NullableContext(2)]
		public FMovieSceneMaterialParameterCollectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060224A0 RID: 140448 RVA: 0x0032B596 File Offset: 0x00329796
		public FMovieSceneMaterialParameterCollectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060224A1 RID: 140449 RVA: 0x0032B5A1 File Offset: 0x003297A1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneMaterialParameterCollectionTemplate(Pointer, false, true);
		}

		// Token: 0x060224A2 RID: 140450 RVA: 0x0032B5AB File Offset: 0x003297AB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneMaterialParameterCollectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x040124DF RID: 74975
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneMaterialParameterCollectionTemplate";

		// Token: 0x040124E0 RID: 74976
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040124E1 RID: 74977
		internal static int __PropertyOffset_MPC;
	}
}
