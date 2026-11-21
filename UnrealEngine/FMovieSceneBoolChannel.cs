using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200077B RID: 1915
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneBoolChannel")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FMovieSceneBoolChannel : FMovieSceneChannel, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A58A RID: 42378 RVA: 0x000F483D File Offset: 0x000F2A3D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneBoolChannel._ScriptStructPtr != 0) ? FMovieSceneBoolChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneBoolChannel", ref FMovieSceneBoolChannel._ScriptStructPtr);
		}

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x0600A58B RID: 42379 RVA: 0x000F4864 File Offset: 0x000F2A64
		// (set) Token: 0x0600A58C RID: 42380 RVA: 0x000F48A7 File Offset: 0x000F2AA7
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

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x0600A58D RID: 42381 RVA: 0x000F48B5 File Offset: 0x000F2AB5
		// (set) Token: 0x0600A58E RID: 42382 RVA: 0x000F48C5 File Offset: 0x000F2AC5
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

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x0600A58F RID: 42383 RVA: 0x000F48D6 File Offset: 0x000F2AD6
		// (set) Token: 0x0600A590 RID: 42384 RVA: 0x000F48E6 File Offset: 0x000F2AE6
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

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x0600A591 RID: 42385 RVA: 0x000F48F8 File Offset: 0x000F2AF8
		// (set) Token: 0x0600A592 RID: 42386 RVA: 0x000F493B File Offset: 0x000F2B3B
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

		// Token: 0x0600A593 RID: 42387 RVA: 0x000F4949 File Offset: 0x000F2B49
		public FMovieSceneBoolChannel()
		{
		}

		// Token: 0x0600A594 RID: 42388 RVA: 0x000F4951 File Offset: 0x000F2B51
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneBoolChannel.StaticStruct();
		}

		// Token: 0x0600A595 RID: 42389 RVA: 0x000F495D File Offset: 0x000F2B5D
		[NullableContext(2)]
		public FMovieSceneBoolChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A596 RID: 42390 RVA: 0x000F4967 File Offset: 0x000F2B67
		public FMovieSceneBoolChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A597 RID: 42391 RVA: 0x000F4972 File Offset: 0x000F2B72
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneBoolChannel(Pointer, false, true);
		}

		// Token: 0x0600A598 RID: 42392 RVA: 0x000F497C File Offset: 0x000F2B7C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneBoolChannel(Pointer, MemoryOwner);
		}

		// Token: 0x040046D9 RID: 18137
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneBoolChannel";

		// Token: 0x040046DA RID: 18138
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040046DB RID: 18139
		internal static int __PropertyOffset_Times;

		// Token: 0x040046DC RID: 18140
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFrameNumber> _Times;

		// Token: 0x040046DD RID: 18141
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x040046DE RID: 18142
		internal static int __PropertyOffset_bHasDefaultValue;

		// Token: 0x040046DF RID: 18143
		internal static int __PropertyOffset_Values;

		// Token: 0x040046E0 RID: 18144
		[Nullable(2)]
		private TArray<bool> _Values;
	}
}
