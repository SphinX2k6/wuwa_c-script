using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002435 RID: 9269
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSequenceLoopCount")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FMovieSceneSequenceLoopCount : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022B98 RID: 142232 RVA: 0x00335A87 File Offset: 0x00333C87
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSequenceLoopCount._ScriptStructPtr != 0) ? FMovieSceneSequenceLoopCount._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSequenceLoopCount", ref FMovieSceneSequenceLoopCount._ScriptStructPtr);
		}

		// Token: 0x17008590 RID: 34192
		// (get) Token: 0x06022B99 RID: 142233 RVA: 0x00335AAB File Offset: 0x00333CAB
		// (set) Token: 0x06022B9A RID: 142234 RVA: 0x00335ABB File Offset: 0x00333CBB
		public unsafe int Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSequenceLoopCount.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSequenceLoopCount.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06022B9B RID: 142235 RVA: 0x00335ACC File Offset: 0x00333CCC
		public FMovieSceneSequenceLoopCount()
		{
		}

		// Token: 0x06022B9C RID: 142236 RVA: 0x00335AD4 File Offset: 0x00333CD4
		public FMovieSceneSequenceLoopCount(int Value)
		{
			this.Value = Value;
		}

		// Token: 0x06022B9D RID: 142237 RVA: 0x00335AE3 File Offset: 0x00333CE3
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSequenceLoopCount.StaticStruct();
		}

		// Token: 0x06022B9E RID: 142238 RVA: 0x00335AEF File Offset: 0x00333CEF
		[NullableContext(2)]
		public FMovieSceneSequenceLoopCount(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022B9F RID: 142239 RVA: 0x00335AF9 File Offset: 0x00333CF9
		public FMovieSceneSequenceLoopCount(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022BA0 RID: 142240 RVA: 0x00335B04 File Offset: 0x00333D04
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSequenceLoopCount(Pointer, false, true);
		}

		// Token: 0x06022BA1 RID: 142241 RVA: 0x00335B0E File Offset: 0x00333D0E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSequenceLoopCount(Pointer, MemoryOwner);
		}

		// Token: 0x040128CA RID: 75978
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSequenceLoopCount";

		// Token: 0x040128CB RID: 75979
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040128CC RID: 75980
		internal static int __PropertyOffset_Value;
	}
}
