using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200240F RID: 9231
	[UnrealObjectPath("/Script/MovieScene.MovieSceneKeyHandleMap")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FMovieSceneKeyHandleMap : FKeyHandleLookupTable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060229E1 RID: 141793 RVA: 0x003332BA File Offset: 0x003314BA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneKeyHandleMap._ScriptStructPtr != 0) ? FMovieSceneKeyHandleMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneKeyHandleMap", ref FMovieSceneKeyHandleMap._ScriptStructPtr);
		}

		// Token: 0x060229E2 RID: 141794 RVA: 0x003332DE File Offset: 0x003314DE
		public FMovieSceneKeyHandleMap()
		{
		}

		// Token: 0x060229E3 RID: 141795 RVA: 0x003332E6 File Offset: 0x003314E6
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneKeyHandleMap.StaticStruct();
		}

		// Token: 0x060229E4 RID: 141796 RVA: 0x003332F2 File Offset: 0x003314F2
		[NullableContext(2)]
		public FMovieSceneKeyHandleMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060229E5 RID: 141797 RVA: 0x003332FC File Offset: 0x003314FC
		public FMovieSceneKeyHandleMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060229E6 RID: 141798 RVA: 0x00333307 File Offset: 0x00331507
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneKeyHandleMap(Pointer, false, true);
		}

		// Token: 0x060229E7 RID: 141799 RVA: 0x00333311 File Offset: 0x00331511
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneKeyHandleMap(Pointer, MemoryOwner);
		}

		// Token: 0x040127F8 RID: 75768
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneKeyHandleMap";

		// Token: 0x040127F9 RID: 75769
		private static IntPtr _ScriptStructPtr;
	}
}
