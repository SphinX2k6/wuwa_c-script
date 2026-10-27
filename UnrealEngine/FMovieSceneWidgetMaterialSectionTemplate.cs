using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200298B RID: 10635
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.MovieSceneWidgetMaterialSectionTemplate")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FMovieSceneWidgetMaterialSectionTemplate : FMovieSceneParameterSectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060275BE RID: 161214 RVA: 0x003C0172 File Offset: 0x003BE372
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneWidgetMaterialSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneWidgetMaterialSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.MovieSceneWidgetMaterialSectionTemplate", ref FMovieSceneWidgetMaterialSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x17009742 RID: 38722
		// (get) Token: 0x060275BF RID: 161215 RVA: 0x003C0198 File Offset: 0x003BE398
		// (set) Token: 0x060275C0 RID: 161216 RVA: 0x003C01DB File Offset: 0x003BE3DB
		public TArray<FName> BrushPropertyNamePath
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BrushPropertyNamePath) == null)
				{
					result = (this._BrushPropertyNamePath = new TArray<FName>(base.NativePtr + (IntPtr)FMovieSceneWidgetMaterialSectionTemplate.__PropertyOffset_BrushPropertyNamePath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BrushPropertyNamePath.CopyAssign(value);
			}
		}

		// Token: 0x060275C1 RID: 161217 RVA: 0x003C01E9 File Offset: 0x003BE3E9
		public FMovieSceneWidgetMaterialSectionTemplate()
		{
		}

		// Token: 0x060275C2 RID: 161218 RVA: 0x003C01F4 File Offset: 0x003BE3F4
		public FMovieSceneWidgetMaterialSectionTemplate(TArray<FName> BrushPropertyNamePath, TArray<FScalarParameterNameAndCurve> Scalars, TArray<FBoolParameterNameAndCurve> Bools, TArray<FVector2DParameterNameAndCurves> Vector2Ds, TArray<FVectorParameterNameAndCurves> Vectors, TArray<FColorParameterNameAndCurves> Colors, TArray<FTransformParameterNameAndCurves> Transforms, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.BrushPropertyNamePath = BrushPropertyNamePath;
			base.Scalars = Scalars;
			base.Bools = Bools;
			base.Vector2Ds = Vector2Ds;
			base.Vectors = Vectors;
			base.Colors = Colors;
			base.Transforms = Transforms;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x060275C3 RID: 161219 RVA: 0x003C024C File Offset: 0x003BE44C
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneWidgetMaterialSectionTemplate.StaticStruct();
		}

		// Token: 0x060275C4 RID: 161220 RVA: 0x003C0258 File Offset: 0x003BE458
		[NullableContext(2)]
		public FMovieSceneWidgetMaterialSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060275C5 RID: 161221 RVA: 0x003C0262 File Offset: 0x003BE462
		public FMovieSceneWidgetMaterialSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060275C6 RID: 161222 RVA: 0x003C026D File Offset: 0x003BE46D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneWidgetMaterialSectionTemplate(Pointer, false, true);
		}

		// Token: 0x060275C7 RID: 161223 RVA: 0x003C0277 File Offset: 0x003BE477
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneWidgetMaterialSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x040159CE RID: 88526
		public new const string __ObjectPath = "/Script/UMG.MovieSceneWidgetMaterialSectionTemplate";

		// Token: 0x040159CF RID: 88527
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040159D0 RID: 88528
		internal static int __PropertyOffset_BrushPropertyNamePath;

		// Token: 0x040159D1 RID: 88529
		[Nullable(2)]
		private TArray<FName> _BrushPropertyNamePath;
	}
}
