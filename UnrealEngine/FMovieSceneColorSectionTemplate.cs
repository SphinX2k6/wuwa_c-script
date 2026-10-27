using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200235C RID: 9052
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneColorSectionTemplate")]
	[UnrealStructLayout(712, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 712)]
	public class FMovieSceneColorSectionTemplate : FMovieScenePropertySectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022326 RID: 140070 RVA: 0x003291E1 File Offset: 0x003273E1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneColorSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneColorSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneColorSectionTemplate", ref FMovieSceneColorSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x1700840C RID: 33804
		// (get) Token: 0x06022327 RID: 140071 RVA: 0x00329208 File Offset: 0x00327408
		// (set) Token: 0x06022328 RID: 140072 RVA: 0x0032924C File Offset: 0x0032744C
		public TFixedArray<FMovieSceneFloatChannel> Curves
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMovieSceneFloatChannel> result;
				if ((result = this._Curves) == null)
				{
					result = (this._Curves = new TFixedArray<FMovieSceneFloatChannel>(base.NativePtr + (IntPtr)FMovieSceneColorSectionTemplate.__PropertyOffset_Curves, 4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Curves.CopyAssign(value);
			}
		}

		// Token: 0x1700840D RID: 33805
		// (get) Token: 0x06022329 RID: 140073 RVA: 0x0032925A File Offset: 0x0032745A
		// (set) Token: 0x0602232A RID: 140074 RVA: 0x0032926A File Offset: 0x0032746A
		public unsafe EMovieSceneBlendType BlendType
		{
			get
			{
				return (EMovieSceneBlendType)(*(base.NativePtr + (IntPtr)FMovieSceneColorSectionTemplate.__PropertyOffset_BlendType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneColorSectionTemplate.__PropertyOffset_BlendType) = (byte)value;
			}
		}

		// Token: 0x0602232B RID: 140075 RVA: 0x0032927B File Offset: 0x0032747B
		public FMovieSceneColorSectionTemplate()
		{
		}

		// Token: 0x0602232C RID: 140076 RVA: 0x00329283 File Offset: 0x00327483
		public FMovieSceneColorSectionTemplate(TFixedArray<FMovieSceneFloatChannel> Curves, EMovieSceneBlendType BlendType, FMovieScenePropertySectionData PropertyData, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.Curves = Curves;
			this.BlendType = BlendType;
			base.PropertyData = PropertyData;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x0602232D RID: 140077 RVA: 0x003292B0 File Offset: 0x003274B0
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneColorSectionTemplate.StaticStruct();
		}

		// Token: 0x0602232E RID: 140078 RVA: 0x003292BC File Offset: 0x003274BC
		[NullableContext(2)]
		public FMovieSceneColorSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602232F RID: 140079 RVA: 0x003292C6 File Offset: 0x003274C6
		public FMovieSceneColorSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022330 RID: 140080 RVA: 0x003292D1 File Offset: 0x003274D1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneColorSectionTemplate(Pointer, false, true);
		}

		// Token: 0x06022331 RID: 140081 RVA: 0x003292DB File Offset: 0x003274DB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneColorSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012411 RID: 74769
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneColorSectionTemplate";

		// Token: 0x04012412 RID: 74770
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012413 RID: 74771
		internal static int __PropertyOffset_Curves;

		// Token: 0x04012414 RID: 74772
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMovieSceneFloatChannel> _Curves;

		// Token: 0x04012415 RID: 74773
		internal static int __PropertyOffset_BlendType;
	}
}
