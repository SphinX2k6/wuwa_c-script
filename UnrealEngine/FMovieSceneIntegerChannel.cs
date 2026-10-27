using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200240E RID: 9230
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneIntegerChannel")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FMovieSceneIntegerChannel : FMovieSceneChannel, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060229D1 RID: 141777 RVA: 0x0033314E File Offset: 0x0033134E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneIntegerChannel._ScriptStructPtr != 0) ? FMovieSceneIntegerChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneIntegerChannel", ref FMovieSceneIntegerChannel._ScriptStructPtr);
		}

		// Token: 0x1700853E RID: 34110
		// (get) Token: 0x060229D2 RID: 141778 RVA: 0x00333174 File Offset: 0x00331374
		// (set) Token: 0x060229D3 RID: 141779 RVA: 0x003331B7 File Offset: 0x003313B7
		public TArray<FFrameNumber> Times
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFrameNumber> result;
				if ((result = this._Times) == null)
				{
					result = (this._Times = new TArray<FFrameNumber>(base.NativePtr + (IntPtr)FMovieSceneIntegerChannel.__PropertyOffset_Times, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Times.CopyAssign(value);
			}
		}

		// Token: 0x1700853F RID: 34111
		// (get) Token: 0x060229D4 RID: 141780 RVA: 0x003331C5 File Offset: 0x003313C5
		// (set) Token: 0x060229D5 RID: 141781 RVA: 0x003331D5 File Offset: 0x003313D5
		public unsafe int DefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneIntegerChannel.__PropertyOffset_DefaultValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneIntegerChannel.__PropertyOffset_DefaultValue) = value;
			}
		}

		// Token: 0x17008540 RID: 34112
		// (get) Token: 0x060229D6 RID: 141782 RVA: 0x003331E6 File Offset: 0x003313E6
		// (set) Token: 0x060229D7 RID: 141783 RVA: 0x003331F6 File Offset: 0x003313F6
		public unsafe bool bHasDefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneIntegerChannel.__PropertyOffset_bHasDefaultValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneIntegerChannel.__PropertyOffset_bHasDefaultValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008541 RID: 34113
		// (get) Token: 0x060229D8 RID: 141784 RVA: 0x00333208 File Offset: 0x00331408
		// (set) Token: 0x060229D9 RID: 141785 RVA: 0x0033324B File Offset: 0x0033144B
		public TArray<int> Values
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TArray<int>(base.NativePtr + (IntPtr)FMovieSceneIntegerChannel.__PropertyOffset_Values, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x060229DA RID: 141786 RVA: 0x00333259 File Offset: 0x00331459
		public FMovieSceneIntegerChannel()
		{
		}

		// Token: 0x060229DB RID: 141787 RVA: 0x00333261 File Offset: 0x00331461
		public FMovieSceneIntegerChannel(TArray<FFrameNumber> Times, int DefaultValue, bool bHasDefaultValue, TArray<int> Values)
		{
			this.Times = Times;
			this.DefaultValue = DefaultValue;
			this.bHasDefaultValue = bHasDefaultValue;
			this.Values = Values;
		}

		// Token: 0x060229DC RID: 141788 RVA: 0x00333286 File Offset: 0x00331486
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneIntegerChannel.StaticStruct();
		}

		// Token: 0x060229DD RID: 141789 RVA: 0x00333292 File Offset: 0x00331492
		[NullableContext(2)]
		public FMovieSceneIntegerChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060229DE RID: 141790 RVA: 0x0033329C File Offset: 0x0033149C
		public FMovieSceneIntegerChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060229DF RID: 141791 RVA: 0x003332A7 File Offset: 0x003314A7
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneIntegerChannel(Pointer, false, true);
		}

		// Token: 0x060229E0 RID: 141792 RVA: 0x003332B1 File Offset: 0x003314B1
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneIntegerChannel(Pointer, MemoryOwner);
		}

		// Token: 0x040127F0 RID: 75760
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneIntegerChannel";

		// Token: 0x040127F1 RID: 75761
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040127F2 RID: 75762
		internal static int __PropertyOffset_Times;

		// Token: 0x040127F3 RID: 75763
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFrameNumber> _Times;

		// Token: 0x040127F4 RID: 75764
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x040127F5 RID: 75765
		internal static int __PropertyOffset_bHasDefaultValue;

		// Token: 0x040127F6 RID: 75766
		internal static int __PropertyOffset_Values;

		// Token: 0x040127F7 RID: 75767
		[Nullable(2)]
		private TArray<int> _Values;
	}
}
