using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200077E RID: 1918
	[UnrealObjectPath("/Script/MovieScene.MovieSceneFloatChannel")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FMovieSceneFloatChannel : FMovieSceneChannel, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A5A9 RID: 42409 RVA: 0x000F4AE1 File Offset: 0x000F2CE1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneFloatChannel._ScriptStructPtr != 0) ? FMovieSceneFloatChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneFloatChannel", ref FMovieSceneFloatChannel._ScriptStructPtr);
		}

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x0600A5AA RID: 42410 RVA: 0x000F4B05 File Offset: 0x000F2D05
		// (set) Token: 0x0600A5AB RID: 42411 RVA: 0x000F4B19 File Offset: 0x000F2D19
		public unsafe TEnumAsByte<ERichCurveExtrapolation> PreInfinityExtrap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFloatChannel.__PropertyOffset_PreInfinityExtrap);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFloatChannel.__PropertyOffset_PreInfinityExtrap) = value;
			}
		}

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x0600A5AC RID: 42412 RVA: 0x000F4B2E File Offset: 0x000F2D2E
		// (set) Token: 0x0600A5AD RID: 42413 RVA: 0x000F4B42 File Offset: 0x000F2D42
		public unsafe TEnumAsByte<ERichCurveExtrapolation> PostInfinityExtrap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFloatChannel.__PropertyOffset_PostInfinityExtrap);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFloatChannel.__PropertyOffset_PostInfinityExtrap) = value;
			}
		}

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x0600A5AE RID: 42414 RVA: 0x000F4B58 File Offset: 0x000F2D58
		// (set) Token: 0x0600A5AF RID: 42415 RVA: 0x000F4B9B File Offset: 0x000F2D9B
		[Nullable(1)]
		public TArray<FFrameNumber> Times
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FFrameNumber> result;
				if ((result = this._Times) == null)
				{
					result = (this._Times = new TArray<FFrameNumber>(base.NativePtr + (IntPtr)FMovieSceneFloatChannel.__PropertyOffset_Times, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Times.CopyAssign(value);
			}
		}

		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x0600A5B0 RID: 42416 RVA: 0x000F4BAC File Offset: 0x000F2DAC
		// (set) Token: 0x0600A5B1 RID: 42417 RVA: 0x000F4BEF File Offset: 0x000F2DEF
		[Nullable(1)]
		public TArray<FMovieSceneFloatValue> Values
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneFloatValue> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TArray<FMovieSceneFloatValue>(base.NativePtr + (IntPtr)FMovieSceneFloatChannel.__PropertyOffset_Values, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x0600A5B2 RID: 42418 RVA: 0x000F4BFD File Offset: 0x000F2DFD
		// (set) Token: 0x0600A5B3 RID: 42419 RVA: 0x000F4C0D File Offset: 0x000F2E0D
		public unsafe float DefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFloatChannel.__PropertyOffset_DefaultValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFloatChannel.__PropertyOffset_DefaultValue) = value;
			}
		}

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x0600A5B4 RID: 42420 RVA: 0x000F4C1E File Offset: 0x000F2E1E
		// (set) Token: 0x0600A5B5 RID: 42421 RVA: 0x000F4C2E File Offset: 0x000F2E2E
		public unsafe bool bHasDefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFloatChannel.__PropertyOffset_bHasDefaultValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFloatChannel.__PropertyOffset_bHasDefaultValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x0600A5B6 RID: 42422 RVA: 0x000F4C3F File Offset: 0x000F2E3F
		// (set) Token: 0x0600A5B7 RID: 42423 RVA: 0x000F4C53 File Offset: 0x000F2E53
		public unsafe FFrameRate TickResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFloatChannel.__PropertyOffset_TickResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFloatChannel.__PropertyOffset_TickResolution) = value;
			}
		}

		// Token: 0x0600A5B8 RID: 42424 RVA: 0x000F4C68 File Offset: 0x000F2E68
		public FMovieSceneFloatChannel()
		{
		}

		// Token: 0x0600A5B9 RID: 42425 RVA: 0x000F4C70 File Offset: 0x000F2E70
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneFloatChannel.StaticStruct();
		}

		// Token: 0x0600A5BA RID: 42426 RVA: 0x000F4C7C File Offset: 0x000F2E7C
		[NullableContext(2)]
		public FMovieSceneFloatChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A5BB RID: 42427 RVA: 0x000F4C86 File Offset: 0x000F2E86
		public FMovieSceneFloatChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A5BC RID: 42428 RVA: 0x000F4C91 File Offset: 0x000F2E91
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneFloatChannel(Pointer, false, true);
		}

		// Token: 0x0600A5BD RID: 42429 RVA: 0x000F4C9B File Offset: 0x000F2E9B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneFloatChannel(Pointer, MemoryOwner);
		}

		// Token: 0x040046E9 RID: 18153
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneFloatChannel";

		// Token: 0x040046EA RID: 18154
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040046EB RID: 18155
		internal static int __PropertyOffset_PreInfinityExtrap;

		// Token: 0x040046EC RID: 18156
		internal static int __PropertyOffset_PostInfinityExtrap;

		// Token: 0x040046ED RID: 18157
		internal static int __PropertyOffset_Times;

		// Token: 0x040046EE RID: 18158
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFrameNumber> _Times;

		// Token: 0x040046EF RID: 18159
		internal static int __PropertyOffset_Values;

		// Token: 0x040046F0 RID: 18160
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneFloatValue> _Values;

		// Token: 0x040046F1 RID: 18161
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x040046F2 RID: 18162
		internal static int __PropertyOffset_bHasDefaultValue;

		// Token: 0x040046F3 RID: 18163
		internal static int __PropertyOffset_TickResolution;
	}
}
