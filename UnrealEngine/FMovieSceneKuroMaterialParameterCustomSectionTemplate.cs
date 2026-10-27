using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C04 RID: 7172
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialParameterCustomSectionTemplate")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FMovieSceneKuroMaterialParameterCustomSectionTemplate : FMovieSceneParameterSectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BAE1 RID: 113377 RVA: 0x0028BD2E File Offset: 0x00289F2E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneKuroMaterialParameterCustomSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneKuroMaterialParameterCustomSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialParameterCustomSectionTemplate", ref FMovieSceneKuroMaterialParameterCustomSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x17006FA8 RID: 28584
		// (get) Token: 0x0601BAE2 RID: 113378 RVA: 0x0028BD54 File Offset: 0x00289F54
		// (set) Token: 0x0601BAE3 RID: 113379 RVA: 0x0028BD97 File Offset: 0x00289F97
		public TArray<FName> BodyNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BodyNames) == null)
				{
					result = (this._BodyNames = new TArray<FName>(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialParameterCustomSectionTemplate.__PropertyOffset_BodyNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BodyNames.CopyAssign(value);
			}
		}

		// Token: 0x17006FA9 RID: 28585
		// (get) Token: 0x0601BAE4 RID: 113380 RVA: 0x0028BDA5 File Offset: 0x00289FA5
		// (set) Token: 0x0601BAE5 RID: 113381 RVA: 0x0028BDB5 File Offset: 0x00289FB5
		public unsafe EKuroCharSlotSpecifiedType SlotType
		{
			get
			{
				return (EKuroCharSlotSpecifiedType)(*(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialParameterCustomSectionTemplate.__PropertyOffset_SlotType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialParameterCustomSectionTemplate.__PropertyOffset_SlotType) = (byte)value;
			}
		}

		// Token: 0x17006FAA RID: 28586
		// (get) Token: 0x0601BAE6 RID: 113382 RVA: 0x0028BDC8 File Offset: 0x00289FC8
		// (set) Token: 0x0601BAE7 RID: 113383 RVA: 0x0028BE0B File Offset: 0x0028A00B
		public TArray<string> CustomPartNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._CustomPartNames) == null)
				{
					result = (this._CustomPartNames = new TArray<string>(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialParameterCustomSectionTemplate.__PropertyOffset_CustomPartNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomPartNames.CopyAssign(value);
			}
		}

		// Token: 0x0601BAE8 RID: 113384 RVA: 0x0028BE19 File Offset: 0x0028A019
		public FMovieSceneKuroMaterialParameterCustomSectionTemplate()
		{
		}

		// Token: 0x0601BAE9 RID: 113385 RVA: 0x0028BE24 File Offset: 0x0028A024
		public FMovieSceneKuroMaterialParameterCustomSectionTemplate(TArray<FName> BodyNames, EKuroCharSlotSpecifiedType SlotType, TArray<string> CustomPartNames, TArray<FScalarParameterNameAndCurve> Scalars, TArray<FBoolParameterNameAndCurve> Bools, TArray<FVector2DParameterNameAndCurves> Vector2Ds, TArray<FVectorParameterNameAndCurves> Vectors, TArray<FColorParameterNameAndCurves> Colors, TArray<FTransformParameterNameAndCurves> Transforms, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.BodyNames = BodyNames;
			this.SlotType = SlotType;
			this.CustomPartNames = CustomPartNames;
			base.Scalars = Scalars;
			base.Bools = Bools;
			base.Vector2Ds = Vector2Ds;
			base.Vectors = Vectors;
			base.Colors = Colors;
			base.Transforms = Transforms;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x0601BAEA RID: 113386 RVA: 0x0028BE8C File Offset: 0x0028A08C
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneKuroMaterialParameterCustomSectionTemplate.StaticStruct();
		}

		// Token: 0x0601BAEB RID: 113387 RVA: 0x0028BE98 File Offset: 0x0028A098
		[NullableContext(2)]
		public FMovieSceneKuroMaterialParameterCustomSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BAEC RID: 113388 RVA: 0x0028BEA2 File Offset: 0x0028A0A2
		public FMovieSceneKuroMaterialParameterCustomSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BAED RID: 113389 RVA: 0x0028BEAD File Offset: 0x0028A0AD
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneKuroMaterialParameterCustomSectionTemplate(Pointer, false, true);
		}

		// Token: 0x0601BAEE RID: 113390 RVA: 0x0028BEB7 File Offset: 0x0028A0B7
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneKuroMaterialParameterCustomSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x0400EE31 RID: 60977
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialParameterCustomSectionTemplate";

		// Token: 0x0400EE32 RID: 60978
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EE33 RID: 60979
		internal static int __PropertyOffset_BodyNames;

		// Token: 0x0400EE34 RID: 60980
		[Nullable(2)]
		private TArray<FName> _BodyNames;

		// Token: 0x0400EE35 RID: 60981
		internal static int __PropertyOffset_SlotType;

		// Token: 0x0400EE36 RID: 60982
		internal static int __PropertyOffset_CustomPartNames;

		// Token: 0x0400EE37 RID: 60983
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _CustomPartNames;
	}
}
