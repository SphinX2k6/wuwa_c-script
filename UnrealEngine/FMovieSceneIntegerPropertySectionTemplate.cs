using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002381 RID: 9089
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneIntegerPropertySectionTemplate")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 216)]
	public class FMovieSceneIntegerPropertySectionTemplate : FMovieScenePropertySectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602245C RID: 140380 RVA: 0x0032AF56 File Offset: 0x00329156
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneIntegerPropertySectionTemplate._ScriptStructPtr != 0) ? FMovieSceneIntegerPropertySectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneIntegerPropertySectionTemplate", ref FMovieSceneIntegerPropertySectionTemplate._ScriptStructPtr);
		}

		// Token: 0x17008432 RID: 33842
		// (get) Token: 0x0602245D RID: 140381 RVA: 0x0032AF7C File Offset: 0x0032917C
		// (set) Token: 0x0602245E RID: 140382 RVA: 0x0032AFBF File Offset: 0x003291BF
		public FMovieSceneIntegerChannel IntegerCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneIntegerChannel result;
				if ((result = this._IntegerCurve) == null)
				{
					result = (this._IntegerCurve = new FMovieSceneIntegerChannel(base.NativePtr + (IntPtr)FMovieSceneIntegerPropertySectionTemplate.__PropertyOffset_IntegerCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneIntegerChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneIntegerPropertySectionTemplate.__PropertyOffset_IntegerCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008433 RID: 33843
		// (get) Token: 0x0602245F RID: 140383 RVA: 0x0032AFE0 File Offset: 0x003291E0
		// (set) Token: 0x06022460 RID: 140384 RVA: 0x0032AFF0 File Offset: 0x003291F0
		public unsafe EMovieSceneBlendType BlendType
		{
			get
			{
				return (EMovieSceneBlendType)(*(base.NativePtr + (IntPtr)FMovieSceneIntegerPropertySectionTemplate.__PropertyOffset_BlendType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneIntegerPropertySectionTemplate.__PropertyOffset_BlendType) = (byte)value;
			}
		}

		// Token: 0x06022461 RID: 140385 RVA: 0x0032B001 File Offset: 0x00329201
		public FMovieSceneIntegerPropertySectionTemplate()
		{
		}

		// Token: 0x06022462 RID: 140386 RVA: 0x0032B009 File Offset: 0x00329209
		public FMovieSceneIntegerPropertySectionTemplate(FMovieSceneIntegerChannel IntegerCurve, EMovieSceneBlendType BlendType, FMovieScenePropertySectionData PropertyData, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.IntegerCurve = IntegerCurve;
			this.BlendType = BlendType;
			base.PropertyData = PropertyData;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06022463 RID: 140387 RVA: 0x0032B036 File Offset: 0x00329236
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneIntegerPropertySectionTemplate.StaticStruct();
		}

		// Token: 0x06022464 RID: 140388 RVA: 0x0032B042 File Offset: 0x00329242
		[NullableContext(2)]
		public FMovieSceneIntegerPropertySectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022465 RID: 140389 RVA: 0x0032B04C File Offset: 0x0032924C
		public FMovieSceneIntegerPropertySectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022466 RID: 140390 RVA: 0x0032B057 File Offset: 0x00329257
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneIntegerPropertySectionTemplate(Pointer, false, true);
		}

		// Token: 0x06022467 RID: 140391 RVA: 0x0032B061 File Offset: 0x00329261
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneIntegerPropertySectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x040124BE RID: 74942
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneIntegerPropertySectionTemplate";

		// Token: 0x040124BF RID: 74943
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040124C0 RID: 74944
		internal static int __PropertyOffset_IntegerCurve;

		// Token: 0x040124C1 RID: 74945
		[Nullable(2)]
		private FMovieSceneIntegerChannel _IntegerCurve;

		// Token: 0x040124C2 RID: 74946
		internal static int __PropertyOffset_BlendType;
	}
}
