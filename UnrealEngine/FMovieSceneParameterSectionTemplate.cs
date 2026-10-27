using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002391 RID: 9105
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneParameterSectionTemplate")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FMovieSceneParameterSectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022512 RID: 140562 RVA: 0x0032BF56 File Offset: 0x0032A156
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneParameterSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneParameterSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneParameterSectionTemplate", ref FMovieSceneParameterSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x1700844A RID: 33866
		// (get) Token: 0x06022513 RID: 140563 RVA: 0x0032BF7C File Offset: 0x0032A17C
		// (set) Token: 0x06022514 RID: 140564 RVA: 0x0032BFBF File Offset: 0x0032A1BF
		public TArray<FScalarParameterNameAndCurve> Scalars
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FScalarParameterNameAndCurve> result;
				if ((result = this._Scalars) == null)
				{
					result = (this._Scalars = new TArray<FScalarParameterNameAndCurve>(base.NativePtr + (IntPtr)FMovieSceneParameterSectionTemplate.__PropertyOffset_Scalars, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Scalars.CopyAssign(value);
			}
		}

		// Token: 0x1700844B RID: 33867
		// (get) Token: 0x06022515 RID: 140565 RVA: 0x0032BFD0 File Offset: 0x0032A1D0
		// (set) Token: 0x06022516 RID: 140566 RVA: 0x0032C013 File Offset: 0x0032A213
		public TArray<FBoolParameterNameAndCurve> Bools
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoolParameterNameAndCurve> result;
				if ((result = this._Bools) == null)
				{
					result = (this._Bools = new TArray<FBoolParameterNameAndCurve>(base.NativePtr + (IntPtr)FMovieSceneParameterSectionTemplate.__PropertyOffset_Bools, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Bools.CopyAssign(value);
			}
		}

		// Token: 0x1700844C RID: 33868
		// (get) Token: 0x06022517 RID: 140567 RVA: 0x0032C024 File Offset: 0x0032A224
		// (set) Token: 0x06022518 RID: 140568 RVA: 0x0032C067 File Offset: 0x0032A267
		public TArray<FVector2DParameterNameAndCurves> Vector2Ds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2DParameterNameAndCurves> result;
				if ((result = this._Vector2Ds) == null)
				{
					result = (this._Vector2Ds = new TArray<FVector2DParameterNameAndCurves>(base.NativePtr + (IntPtr)FMovieSceneParameterSectionTemplate.__PropertyOffset_Vector2Ds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Vector2Ds.CopyAssign(value);
			}
		}

		// Token: 0x1700844D RID: 33869
		// (get) Token: 0x06022519 RID: 140569 RVA: 0x0032C078 File Offset: 0x0032A278
		// (set) Token: 0x0602251A RID: 140570 RVA: 0x0032C0BB File Offset: 0x0032A2BB
		public TArray<FVectorParameterNameAndCurves> Vectors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorParameterNameAndCurves> result;
				if ((result = this._Vectors) == null)
				{
					result = (this._Vectors = new TArray<FVectorParameterNameAndCurves>(base.NativePtr + (IntPtr)FMovieSceneParameterSectionTemplate.__PropertyOffset_Vectors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Vectors.CopyAssign(value);
			}
		}

		// Token: 0x1700844E RID: 33870
		// (get) Token: 0x0602251B RID: 140571 RVA: 0x0032C0CC File Offset: 0x0032A2CC
		// (set) Token: 0x0602251C RID: 140572 RVA: 0x0032C10F File Offset: 0x0032A30F
		public TArray<FColorParameterNameAndCurves> Colors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FColorParameterNameAndCurves> result;
				if ((result = this._Colors) == null)
				{
					result = (this._Colors = new TArray<FColorParameterNameAndCurves>(base.NativePtr + (IntPtr)FMovieSceneParameterSectionTemplate.__PropertyOffset_Colors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Colors.CopyAssign(value);
			}
		}

		// Token: 0x1700844F RID: 33871
		// (get) Token: 0x0602251D RID: 140573 RVA: 0x0032C120 File Offset: 0x0032A320
		// (set) Token: 0x0602251E RID: 140574 RVA: 0x0032C163 File Offset: 0x0032A363
		public TArray<FTransformParameterNameAndCurves> Transforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransformParameterNameAndCurves> result;
				if ((result = this._Transforms) == null)
				{
					result = (this._Transforms = new TArray<FTransformParameterNameAndCurves>(base.NativePtr + (IntPtr)FMovieSceneParameterSectionTemplate.__PropertyOffset_Transforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Transforms.CopyAssign(value);
			}
		}

		// Token: 0x0602251F RID: 140575 RVA: 0x0032C171 File Offset: 0x0032A371
		public FMovieSceneParameterSectionTemplate()
		{
		}

		// Token: 0x06022520 RID: 140576 RVA: 0x0032C17C File Offset: 0x0032A37C
		public FMovieSceneParameterSectionTemplate(TArray<FScalarParameterNameAndCurve> Scalars, TArray<FBoolParameterNameAndCurve> Bools, TArray<FVector2DParameterNameAndCurves> Vector2Ds, TArray<FVectorParameterNameAndCurves> Vectors, TArray<FColorParameterNameAndCurves> Colors, TArray<FTransformParameterNameAndCurves> Transforms, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.Scalars = Scalars;
			this.Bools = Bools;
			this.Vector2Ds = Vector2Ds;
			this.Vectors = Vectors;
			this.Colors = Colors;
			this.Transforms = Transforms;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06022521 RID: 140577 RVA: 0x0032C1CC File Offset: 0x0032A3CC
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneParameterSectionTemplate.StaticStruct();
		}

		// Token: 0x06022522 RID: 140578 RVA: 0x0032C1D8 File Offset: 0x0032A3D8
		[NullableContext(2)]
		public FMovieSceneParameterSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022523 RID: 140579 RVA: 0x0032C1E2 File Offset: 0x0032A3E2
		public FMovieSceneParameterSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022524 RID: 140580 RVA: 0x0032C1ED File Offset: 0x0032A3ED
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneParameterSectionTemplate(Pointer, false, true);
		}

		// Token: 0x06022525 RID: 140581 RVA: 0x0032C1F7 File Offset: 0x0032A3F7
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneParameterSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012515 RID: 75029
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneParameterSectionTemplate";

		// Token: 0x04012516 RID: 75030
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012517 RID: 75031
		internal static int __PropertyOffset_Scalars;

		// Token: 0x04012518 RID: 75032
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FScalarParameterNameAndCurve> _Scalars;

		// Token: 0x04012519 RID: 75033
		internal static int __PropertyOffset_Bools;

		// Token: 0x0401251A RID: 75034
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoolParameterNameAndCurve> _Bools;

		// Token: 0x0401251B RID: 75035
		internal static int __PropertyOffset_Vector2Ds;

		// Token: 0x0401251C RID: 75036
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FVector2DParameterNameAndCurves> _Vector2Ds;

		// Token: 0x0401251D RID: 75037
		internal static int __PropertyOffset_Vectors;

		// Token: 0x0401251E RID: 75038
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FVectorParameterNameAndCurves> _Vectors;

		// Token: 0x0401251F RID: 75039
		internal static int __PropertyOffset_Colors;

		// Token: 0x04012520 RID: 75040
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FColorParameterNameAndCurves> _Colors;

		// Token: 0x04012521 RID: 75041
		internal static int __PropertyOffset_Transforms;

		// Token: 0x04012522 RID: 75042
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTransformParameterNameAndCurves> _Transforms;
	}
}
