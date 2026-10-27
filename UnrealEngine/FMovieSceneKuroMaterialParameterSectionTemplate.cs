using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C06 RID: 7174
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialParameterSectionTemplate")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FMovieSceneKuroMaterialParameterSectionTemplate : FMovieSceneParameterSectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BAF5 RID: 113397 RVA: 0x0028BF46 File Offset: 0x0028A146
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneKuroMaterialParameterSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneKuroMaterialParameterSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialParameterSectionTemplate", ref FMovieSceneKuroMaterialParameterSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x17006FAB RID: 28587
		// (get) Token: 0x0601BAF6 RID: 113398 RVA: 0x0028BF6A File Offset: 0x0028A16A
		// (set) Token: 0x0601BAF7 RID: 113399 RVA: 0x0028BF7A File Offset: 0x0028A17A
		public unsafe int MaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialParameterSectionTemplate.__PropertyOffset_MaterialIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialParameterSectionTemplate.__PropertyOffset_MaterialIndex) = value;
			}
		}

		// Token: 0x17006FAC RID: 28588
		// (get) Token: 0x0601BAF8 RID: 113400 RVA: 0x0028BF8B File Offset: 0x0028A18B
		// (set) Token: 0x0601BAF9 RID: 113401 RVA: 0x0028BF9F File Offset: 0x0028A19F
		public unsafe FName BodyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialParameterSectionTemplate.__PropertyOffset_BodyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialParameterSectionTemplate.__PropertyOffset_BodyName) = value;
			}
		}

		// Token: 0x0601BAFA RID: 113402 RVA: 0x0028BFB4 File Offset: 0x0028A1B4
		public FMovieSceneKuroMaterialParameterSectionTemplate()
		{
		}

		// Token: 0x0601BAFB RID: 113403 RVA: 0x0028BFBC File Offset: 0x0028A1BC
		[NullableContext(1)]
		public FMovieSceneKuroMaterialParameterSectionTemplate(int MaterialIndex, FName BodyName, TArray<FScalarParameterNameAndCurve> Scalars, TArray<FBoolParameterNameAndCurve> Bools, TArray<FVector2DParameterNameAndCurves> Vector2Ds, TArray<FVectorParameterNameAndCurves> Vectors, TArray<FColorParameterNameAndCurves> Colors, TArray<FTransformParameterNameAndCurves> Transforms, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.MaterialIndex = MaterialIndex;
			this.BodyName = BodyName;
			base.Scalars = Scalars;
			base.Bools = Bools;
			base.Vector2Ds = Vector2Ds;
			base.Vectors = Vectors;
			base.Colors = Colors;
			base.Transforms = Transforms;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x0601BAFC RID: 113404 RVA: 0x0028C01C File Offset: 0x0028A21C
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneKuroMaterialParameterSectionTemplate.StaticStruct();
		}

		// Token: 0x0601BAFD RID: 113405 RVA: 0x0028C028 File Offset: 0x0028A228
		[NullableContext(2)]
		public FMovieSceneKuroMaterialParameterSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BAFE RID: 113406 RVA: 0x0028C032 File Offset: 0x0028A232
		public FMovieSceneKuroMaterialParameterSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BAFF RID: 113407 RVA: 0x0028C03D File Offset: 0x0028A23D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneKuroMaterialParameterSectionTemplate(Pointer, false, true);
		}

		// Token: 0x0601BB00 RID: 113408 RVA: 0x0028C047 File Offset: 0x0028A247
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneKuroMaterialParameterSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x0400EE3C RID: 60988
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialParameterSectionTemplate";

		// Token: 0x0400EE3D RID: 60989
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EE3E RID: 60990
		internal static int __PropertyOffset_MaterialIndex;

		// Token: 0x0400EE3F RID: 60991
		internal static int __PropertyOffset_BodyName;
	}
}
