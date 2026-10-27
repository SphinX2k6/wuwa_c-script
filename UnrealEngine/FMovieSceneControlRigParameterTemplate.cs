using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000513 RID: 1299
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.MovieSceneControlRigParameterTemplate")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FMovieSceneControlRigParameterTemplate : FMovieSceneParameterSectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060043DA RID: 17370 RVA: 0x00065136 File Offset: 0x00063336
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneControlRigParameterTemplate._ScriptStructPtr != 0) ? FMovieSceneControlRigParameterTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.MovieSceneControlRigParameterTemplate", ref FMovieSceneControlRigParameterTemplate._ScriptStructPtr);
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x060043DB RID: 17371 RVA: 0x0006515C File Offset: 0x0006335C
		// (set) Token: 0x060043DC RID: 17372 RVA: 0x0006519F File Offset: 0x0006339F
		public TArray<FEnumParameterNameAndCurve> Enums
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FEnumParameterNameAndCurve> result;
				if ((result = this._Enums) == null)
				{
					result = (this._Enums = new TArray<FEnumParameterNameAndCurve>(base.NativePtr + (IntPtr)FMovieSceneControlRigParameterTemplate.__PropertyOffset_Enums, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Enums.CopyAssign(value);
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x060043DD RID: 17373 RVA: 0x000651B0 File Offset: 0x000633B0
		// (set) Token: 0x060043DE RID: 17374 RVA: 0x000651F3 File Offset: 0x000633F3
		public TArray<FIntegerParameterNameAndCurve> Integers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FIntegerParameterNameAndCurve> result;
				if ((result = this._Integers) == null)
				{
					result = (this._Integers = new TArray<FIntegerParameterNameAndCurve>(base.NativePtr + (IntPtr)FMovieSceneControlRigParameterTemplate.__PropertyOffset_Integers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Integers.CopyAssign(value);
			}
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x00065201 File Offset: 0x00063401
		public FMovieSceneControlRigParameterTemplate()
		{
		}

		// Token: 0x060043E0 RID: 17376 RVA: 0x0006520C File Offset: 0x0006340C
		public FMovieSceneControlRigParameterTemplate(TArray<FEnumParameterNameAndCurve> Enums, TArray<FIntegerParameterNameAndCurve> Integers, TArray<FScalarParameterNameAndCurve> Scalars, TArray<FBoolParameterNameAndCurve> Bools, TArray<FVector2DParameterNameAndCurves> Vector2Ds, TArray<FVectorParameterNameAndCurves> Vectors, TArray<FColorParameterNameAndCurves> Colors, TArray<FTransformParameterNameAndCurves> Transforms, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.Enums = Enums;
			this.Integers = Integers;
			base.Scalars = Scalars;
			base.Bools = Bools;
			base.Vector2Ds = Vector2Ds;
			base.Vectors = Vectors;
			base.Colors = Colors;
			base.Transforms = Transforms;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x060043E1 RID: 17377 RVA: 0x0006526C File Offset: 0x0006346C
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneControlRigParameterTemplate.StaticStruct();
		}

		// Token: 0x060043E2 RID: 17378 RVA: 0x00065278 File Offset: 0x00063478
		[NullableContext(2)]
		public FMovieSceneControlRigParameterTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060043E3 RID: 17379 RVA: 0x00065282 File Offset: 0x00063482
		public FMovieSceneControlRigParameterTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060043E4 RID: 17380 RVA: 0x0006528D File Offset: 0x0006348D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneControlRigParameterTemplate(Pointer, false, true);
		}

		// Token: 0x060043E5 RID: 17381 RVA: 0x00065297 File Offset: 0x00063497
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneControlRigParameterTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x0400210D RID: 8461
		public new const string __ObjectPath = "/Script/ControlRig.MovieSceneControlRigParameterTemplate";

		// Token: 0x0400210E RID: 8462
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400210F RID: 8463
		internal static int __PropertyOffset_Enums;

		// Token: 0x04002110 RID: 8464
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FEnumParameterNameAndCurve> _Enums;

		// Token: 0x04002111 RID: 8465
		internal static int __PropertyOffset_Integers;

		// Token: 0x04002112 RID: 8466
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FIntegerParameterNameAndCurve> _Integers;
	}
}
