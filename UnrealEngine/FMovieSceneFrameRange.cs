using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200240C RID: 9228
	[UnrealObjectPath("/Script/MovieScene.MovieSceneFrameRange")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMovieSceneFrameRange : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060229C5 RID: 141765 RVA: 0x0033306E File Offset: 0x0033126E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneFrameRange._ScriptStructPtr != 0) ? FMovieSceneFrameRange._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneFrameRange", ref FMovieSceneFrameRange._ScriptStructPtr);
		}

		// Token: 0x060229C6 RID: 141766 RVA: 0x00333092 File Offset: 0x00331292
		public FMovieSceneFrameRange()
		{
		}

		// Token: 0x060229C7 RID: 141767 RVA: 0x0033309A File Offset: 0x0033129A
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneFrameRange.StaticStruct();
		}

		// Token: 0x060229C8 RID: 141768 RVA: 0x003330A6 File Offset: 0x003312A6
		[NullableContext(2)]
		public FMovieSceneFrameRange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060229C9 RID: 141769 RVA: 0x003330B0 File Offset: 0x003312B0
		public FMovieSceneFrameRange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060229CA RID: 141770 RVA: 0x003330BB File Offset: 0x003312BB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneFrameRange(Pointer, false, true);
		}

		// Token: 0x060229CB RID: 141771 RVA: 0x003330C5 File Offset: 0x003312C5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneFrameRange(Pointer, MemoryOwner);
		}

		// Token: 0x040127EB RID: 75755
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneFrameRange";

		// Token: 0x040127EC RID: 75756
		private static IntPtr _ScriptStructPtr;
	}
}
