using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000764 RID: 1892
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEvent")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FMovieSceneEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A484 RID: 42116 RVA: 0x000F2FFA File Offset: 0x000F11FA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvent._ScriptStructPtr != 0) ? FMovieSceneEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneEvent", ref FMovieSceneEvent._ScriptStructPtr);
		}

		// Token: 0x0600A485 RID: 42117 RVA: 0x000F301E File Offset: 0x000F121E
		public FMovieSceneEvent()
		{
		}

		// Token: 0x0600A486 RID: 42118 RVA: 0x000F3026 File Offset: 0x000F1226
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvent.StaticStruct();
		}

		// Token: 0x0600A487 RID: 42119 RVA: 0x000F3032 File Offset: 0x000F1232
		[NullableContext(2)]
		public FMovieSceneEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A488 RID: 42120 RVA: 0x000F303C File Offset: 0x000F123C
		public FMovieSceneEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A489 RID: 42121 RVA: 0x000F3047 File Offset: 0x000F1247
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvent(Pointer, false, true);
		}

		// Token: 0x0600A48A RID: 42122 RVA: 0x000F3051 File Offset: 0x000F1251
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvent(Pointer, MemoryOwner);
		}

		// Token: 0x0400462B RID: 17963
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEvent";

		// Token: 0x0400462C RID: 17964
		private static IntPtr _ScriptStructPtr;
	}
}
