using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002408 RID: 9224
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneFloatChannel")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FMovieSceneFloatChannel : FMovieSceneChannel, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602298D RID: 141709 RVA: 0x00332B27 File Offset: 0x00330D27
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneFloatChannel._ScriptStructPtr != 0) ? FMovieSceneFloatChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneFloatChannel", ref FMovieSceneFloatChannel._ScriptStructPtr);
		}

		// Token: 0x1700852D RID: 34093
		// (get) Token: 0x0602298E RID: 141710 RVA: 0x00332B4B File Offset: 0x00330D4B
		// (set) Token: 0x0602298F RID: 141711 RVA: 0x00332B5F File Offset: 0x00330D5F
		[Nullable(0)]
		public unsafe TEnumAsByte<ERichCurveExtrapolation> PreInfinityExtrap
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFloatChannel.__PropertyOffset_PreInfinityExtrap);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFloatChannel.__PropertyOffset_PreInfinityExtrap) = value;
			}
		}

		// Token: 0x1700852E RID: 34094
		// (get) Token: 0x06022990 RID: 141712 RVA: 0x00332B74 File Offset: 0x00330D74
		// (set) Token: 0x06022991 RID: 141713 RVA: 0x00332B88 File Offset: 0x00330D88
		[Nullable(0)]
		public unsafe TEnumAsByte<ERichCurveExtrapolation> PostInfinityExtrap
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFloatChannel.__PropertyOffset_PostInfinityExtrap);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFloatChannel.__PropertyOffset_PostInfinityExtrap) = value;
			}
		}

		// Token: 0x1700852F RID: 34095
		// (get) Token: 0x06022992 RID: 141714 RVA: 0x00332BA0 File Offset: 0x00330DA0
		// (set) Token: 0x06022993 RID: 141715 RVA: 0x00332BE3 File Offset: 0x00330DE3
		public TArray<FFrameNumber> Times
		{
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
			set
			{
				this.Times.CopyAssign(value);
			}
		}

		// Token: 0x17008530 RID: 34096
		// (get) Token: 0x06022994 RID: 141716 RVA: 0x00332BF4 File Offset: 0x00330DF4
		// (set) Token: 0x06022995 RID: 141717 RVA: 0x00332C37 File Offset: 0x00330E37
		public TArray<FMovieSceneFloatValue> Values
		{
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
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x17008531 RID: 34097
		// (get) Token: 0x06022996 RID: 141718 RVA: 0x00332C45 File Offset: 0x00330E45
		// (set) Token: 0x06022997 RID: 141719 RVA: 0x00332C55 File Offset: 0x00330E55
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

		// Token: 0x17008532 RID: 34098
		// (get) Token: 0x06022998 RID: 141720 RVA: 0x00332C66 File Offset: 0x00330E66
		// (set) Token: 0x06022999 RID: 141721 RVA: 0x00332C76 File Offset: 0x00330E76
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

		// Token: 0x17008533 RID: 34099
		// (get) Token: 0x0602299A RID: 141722 RVA: 0x00332C88 File Offset: 0x00330E88
		// (set) Token: 0x0602299B RID: 141723 RVA: 0x00332CCB File Offset: 0x00330ECB
		public FMovieSceneKeyHandleMap KeyHandles
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneKeyHandleMap result;
				if ((result = this._KeyHandles) == null)
				{
					result = (this._KeyHandles = new FMovieSceneKeyHandleMap(base.NativePtr + (IntPtr)FMovieSceneFloatChannel.__PropertyOffset_KeyHandles, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneKeyHandleMap.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneFloatChannel.__PropertyOffset_KeyHandles, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008534 RID: 34100
		// (get) Token: 0x0602299C RID: 141724 RVA: 0x00332CEC File Offset: 0x00330EEC
		// (set) Token: 0x0602299D RID: 141725 RVA: 0x00332D00 File Offset: 0x00330F00
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

		// Token: 0x0602299E RID: 141726 RVA: 0x00332D15 File Offset: 0x00330F15
		public FMovieSceneFloatChannel()
		{
		}

		// Token: 0x0602299F RID: 141727 RVA: 0x00332D20 File Offset: 0x00330F20
		public FMovieSceneFloatChannel([Nullable(0)] TEnumAsByte<ERichCurveExtrapolation> PreInfinityExtrap, [Nullable(0)] TEnumAsByte<ERichCurveExtrapolation> PostInfinityExtrap, TArray<FFrameNumber> Times, TArray<FMovieSceneFloatValue> Values, float DefaultValue, bool bHasDefaultValue, FMovieSceneKeyHandleMap KeyHandles, FFrameRate TickResolution)
		{
			this.PreInfinityExtrap = PreInfinityExtrap;
			this.PostInfinityExtrap = PostInfinityExtrap;
			this.Times = Times;
			this.Values = Values;
			this.DefaultValue = DefaultValue;
			this.bHasDefaultValue = bHasDefaultValue;
			this.KeyHandles = KeyHandles;
			this.TickResolution = TickResolution;
		}

		// Token: 0x060229A0 RID: 141728 RVA: 0x00332D70 File Offset: 0x00330F70
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneFloatChannel.StaticStruct();
		}

		// Token: 0x060229A1 RID: 141729 RVA: 0x00332D7C File Offset: 0x00330F7C
		[NullableContext(2)]
		public FMovieSceneFloatChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060229A2 RID: 141730 RVA: 0x00332D86 File Offset: 0x00330F86
		public FMovieSceneFloatChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060229A3 RID: 141731 RVA: 0x00332D91 File Offset: 0x00330F91
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneFloatChannel(Pointer, false, true);
		}

		// Token: 0x060229A4 RID: 141732 RVA: 0x00332D9B File Offset: 0x00330F9B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneFloatChannel(Pointer, MemoryOwner);
		}

		// Token: 0x040127CC RID: 75724
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneFloatChannel";

		// Token: 0x040127CD RID: 75725
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040127CE RID: 75726
		internal static int __PropertyOffset_PreInfinityExtrap;

		// Token: 0x040127CF RID: 75727
		internal static int __PropertyOffset_PostInfinityExtrap;

		// Token: 0x040127D0 RID: 75728
		internal static int __PropertyOffset_Times;

		// Token: 0x040127D1 RID: 75729
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFrameNumber> _Times;

		// Token: 0x040127D2 RID: 75730
		internal static int __PropertyOffset_Values;

		// Token: 0x040127D3 RID: 75731
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneFloatValue> _Values;

		// Token: 0x040127D4 RID: 75732
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x040127D5 RID: 75733
		internal static int __PropertyOffset_bHasDefaultValue;

		// Token: 0x040127D6 RID: 75734
		internal static int __PropertyOffset_KeyHandles;

		// Token: 0x040127D7 RID: 75735
		[Nullable(2)]
		private FMovieSceneKeyHandleMap _KeyHandles;

		// Token: 0x040127D8 RID: 75736
		internal static int __PropertyOffset_TickResolution;
	}
}
