using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002411 RID: 9233
	[UnrealObjectPath("/Script/MovieScene.MovieSceneKeyStruct")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FMovieSceneKeyStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060229E9 RID: 141801 RVA: 0x0033331A File Offset: 0x0033151A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneKeyStruct._ScriptStructPtr != 0) ? FMovieSceneKeyStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneKeyStruct", ref FMovieSceneKeyStruct._ScriptStructPtr);
		}

		// Token: 0x060229EA RID: 141802 RVA: 0x0033333E File Offset: 0x0033153E
		public FMovieSceneKeyStruct()
		{
		}

		// Token: 0x060229EB RID: 141803 RVA: 0x00333346 File Offset: 0x00331546
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneKeyStruct.StaticStruct();
		}

		// Token: 0x060229EC RID: 141804 RVA: 0x00333352 File Offset: 0x00331552
		[NullableContext(2)]
		public FMovieSceneKeyStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060229ED RID: 141805 RVA: 0x0033335C File Offset: 0x0033155C
		public FMovieSceneKeyStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060229EE RID: 141806 RVA: 0x00333367 File Offset: 0x00331567
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneKeyStruct(Pointer, false, true);
		}

		// Token: 0x060229EF RID: 141807 RVA: 0x00333371 File Offset: 0x00331571
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneKeyStruct(Pointer, MemoryOwner);
		}

		// Token: 0x040127FB RID: 75771
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneKeyStruct";

		// Token: 0x040127FC RID: 75772
		private static IntPtr _ScriptStructPtr;
	}
}
