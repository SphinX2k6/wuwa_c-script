using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200242D RID: 9261
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSegmentIdentifier")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FMovieSceneSegmentIdentifier : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022B2B RID: 142123 RVA: 0x00335200 File Offset: 0x00333400
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSegmentIdentifier._ScriptStructPtr != 0) ? FMovieSceneSegmentIdentifier._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSegmentIdentifier", ref FMovieSceneSegmentIdentifier._ScriptStructPtr);
		}

		// Token: 0x1700857F RID: 34175
		// (get) Token: 0x06022B2C RID: 142124 RVA: 0x00335224 File Offset: 0x00333424
		// (set) Token: 0x06022B2D RID: 142125 RVA: 0x00335234 File Offset: 0x00333434
		public unsafe int IdentifierIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSegmentIdentifier.__PropertyOffset_IdentifierIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSegmentIdentifier.__PropertyOffset_IdentifierIndex) = value;
			}
		}

		// Token: 0x06022B2E RID: 142126 RVA: 0x00335245 File Offset: 0x00333445
		public FMovieSceneSegmentIdentifier()
		{
		}

		// Token: 0x06022B2F RID: 142127 RVA: 0x0033524D File Offset: 0x0033344D
		public FMovieSceneSegmentIdentifier(int IdentifierIndex)
		{
			this.IdentifierIndex = IdentifierIndex;
		}

		// Token: 0x06022B30 RID: 142128 RVA: 0x0033525C File Offset: 0x0033345C
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSegmentIdentifier.StaticStruct();
		}

		// Token: 0x06022B31 RID: 142129 RVA: 0x00335268 File Offset: 0x00333468
		[NullableContext(2)]
		public FMovieSceneSegmentIdentifier(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022B32 RID: 142130 RVA: 0x00335272 File Offset: 0x00333472
		public FMovieSceneSegmentIdentifier(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022B33 RID: 142131 RVA: 0x0033527D File Offset: 0x0033347D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSegmentIdentifier(Pointer, false, true);
		}

		// Token: 0x06022B34 RID: 142132 RVA: 0x00335287 File Offset: 0x00333487
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSegmentIdentifier(Pointer, MemoryOwner);
		}

		// Token: 0x0401289E RID: 75934
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSegmentIdentifier";

		// Token: 0x0401289F RID: 75935
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040128A0 RID: 75936
		internal static int __PropertyOffset_IdentifierIndex;
	}
}
