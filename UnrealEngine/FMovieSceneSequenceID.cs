using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002432 RID: 9266
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSequenceID")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FMovieSceneSequenceID : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022B80 RID: 142208 RVA: 0x00335937 File Offset: 0x00333B37
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSequenceID._ScriptStructPtr != 0) ? FMovieSceneSequenceID._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSequenceID", ref FMovieSceneSequenceID._ScriptStructPtr);
		}

		// Token: 0x1700858F RID: 34191
		// (get) Token: 0x06022B81 RID: 142209 RVA: 0x0033595B File Offset: 0x00333B5B
		// (set) Token: 0x06022B82 RID: 142210 RVA: 0x0033596B File Offset: 0x00333B6B
		public unsafe uint Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSequenceID.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSequenceID.__PropertyOffset_Value) = (int)value;
			}
		}

		// Token: 0x06022B83 RID: 142211 RVA: 0x0033597C File Offset: 0x00333B7C
		public FMovieSceneSequenceID()
		{
		}

		// Token: 0x06022B84 RID: 142212 RVA: 0x00335984 File Offset: 0x00333B84
		public FMovieSceneSequenceID(uint Value)
		{
			this.Value = Value;
		}

		// Token: 0x06022B85 RID: 142213 RVA: 0x00335993 File Offset: 0x00333B93
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSequenceID.StaticStruct();
		}

		// Token: 0x06022B86 RID: 142214 RVA: 0x0033599F File Offset: 0x00333B9F
		[NullableContext(2)]
		public FMovieSceneSequenceID(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022B87 RID: 142215 RVA: 0x003359A9 File Offset: 0x00333BA9
		public FMovieSceneSequenceID(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022B88 RID: 142216 RVA: 0x003359B4 File Offset: 0x00333BB4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSequenceID(Pointer, false, true);
		}

		// Token: 0x06022B89 RID: 142217 RVA: 0x003359BE File Offset: 0x00333BBE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSequenceID(Pointer, MemoryOwner);
		}

		// Token: 0x040128C3 RID: 75971
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSequenceID";

		// Token: 0x040128C4 RID: 75972
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040128C5 RID: 75973
		internal static int __PropertyOffset_Value;
	}
}
