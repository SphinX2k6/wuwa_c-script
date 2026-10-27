using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023D9 RID: 9177
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneBoolChannel")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FMovieSceneBoolChannel : FMovieSceneChannel, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022777 RID: 141175 RVA: 0x0032F935 File Offset: 0x0032DB35
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneBoolChannel._ScriptStructPtr != 0) ? FMovieSceneBoolChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneBoolChannel", ref FMovieSceneBoolChannel._ScriptStructPtr);
		}

		// Token: 0x170084C2 RID: 33986
		// (get) Token: 0x06022778 RID: 141176 RVA: 0x0032F95C File Offset: 0x0032DB5C
		// (set) Token: 0x06022779 RID: 141177 RVA: 0x0032F99F File Offset: 0x0032DB9F
		public TArray<FFrameNumber> Times
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFrameNumber> result;
				if ((result = this._Times) == null)
				{
					result = (this._Times = new TArray<FFrameNumber>(base.NativePtr + (IntPtr)FMovieSceneBoolChannel.__PropertyOffset_Times, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Times.CopyAssign(value);
			}
		}

		// Token: 0x170084C3 RID: 33987
		// (get) Token: 0x0602277A RID: 141178 RVA: 0x0032F9AD File Offset: 0x0032DBAD
		// (set) Token: 0x0602277B RID: 141179 RVA: 0x0032F9BD File Offset: 0x0032DBBD
		public unsafe bool DefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneBoolChannel.__PropertyOffset_DefaultValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneBoolChannel.__PropertyOffset_DefaultValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x170084C4 RID: 33988
		// (get) Token: 0x0602277C RID: 141180 RVA: 0x0032F9CE File Offset: 0x0032DBCE
		// (set) Token: 0x0602277D RID: 141181 RVA: 0x0032F9DE File Offset: 0x0032DBDE
		public unsafe bool bHasDefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneBoolChannel.__PropertyOffset_bHasDefaultValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneBoolChannel.__PropertyOffset_bHasDefaultValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x170084C5 RID: 33989
		// (get) Token: 0x0602277E RID: 141182 RVA: 0x0032F9F0 File Offset: 0x0032DBF0
		// (set) Token: 0x0602277F RID: 141183 RVA: 0x0032FA33 File Offset: 0x0032DC33
		public TArray<bool> Values
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TArray<bool>(base.NativePtr + (IntPtr)FMovieSceneBoolChannel.__PropertyOffset_Values, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x06022780 RID: 141184 RVA: 0x0032FA41 File Offset: 0x0032DC41
		public FMovieSceneBoolChannel()
		{
		}

		// Token: 0x06022781 RID: 141185 RVA: 0x0032FA49 File Offset: 0x0032DC49
		public FMovieSceneBoolChannel(TArray<FFrameNumber> Times, bool DefaultValue, bool bHasDefaultValue, TArray<bool> Values)
		{
			this.Times = Times;
			this.DefaultValue = DefaultValue;
			this.bHasDefaultValue = bHasDefaultValue;
			this.Values = Values;
		}

		// Token: 0x06022782 RID: 141186 RVA: 0x0032FA6E File Offset: 0x0032DC6E
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneBoolChannel.StaticStruct();
		}

		// Token: 0x06022783 RID: 141187 RVA: 0x0032FA7A File Offset: 0x0032DC7A
		[NullableContext(2)]
		public FMovieSceneBoolChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022784 RID: 141188 RVA: 0x0032FA84 File Offset: 0x0032DC84
		public FMovieSceneBoolChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022785 RID: 141189 RVA: 0x0032FA8F File Offset: 0x0032DC8F
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneBoolChannel(Pointer, false, true);
		}

		// Token: 0x06022786 RID: 141190 RVA: 0x0032FA99 File Offset: 0x0032DC99
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneBoolChannel(Pointer, MemoryOwner);
		}

		// Token: 0x040126C1 RID: 75457
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneBoolChannel";

		// Token: 0x040126C2 RID: 75458
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040126C3 RID: 75459
		internal static int __PropertyOffset_Times;

		// Token: 0x040126C4 RID: 75460
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFrameNumber> _Times;

		// Token: 0x040126C5 RID: 75461
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x040126C6 RID: 75462
		internal static int __PropertyOffset_bHasDefaultValue;

		// Token: 0x040126C7 RID: 75463
		internal static int __PropertyOffset_Values;

		// Token: 0x040126C8 RID: 75464
		[Nullable(2)]
		private TArray<bool> _Values;
	}
}
