using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002452 RID: 9298
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTrackImplementation")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMovieSceneTrackImplementation : FMovieSceneEvalTemplateBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022DA5 RID: 142757 RVA: 0x00338A37 File Offset: 0x00336C37
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTrackImplementation._ScriptStructPtr != 0) ? FMovieSceneTrackImplementation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneTrackImplementation", ref FMovieSceneTrackImplementation._ScriptStructPtr);
		}

		// Token: 0x06022DA6 RID: 142758 RVA: 0x00338A5B File Offset: 0x00336C5B
		public FMovieSceneTrackImplementation()
		{
		}

		// Token: 0x06022DA7 RID: 142759 RVA: 0x00338A63 File Offset: 0x00336C63
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneTrackImplementation.StaticStruct();
		}

		// Token: 0x06022DA8 RID: 142760 RVA: 0x00338A6F File Offset: 0x00336C6F
		[NullableContext(2)]
		public FMovieSceneTrackImplementation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022DA9 RID: 142761 RVA: 0x00338A79 File Offset: 0x00336C79
		public FMovieSceneTrackImplementation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022DAA RID: 142762 RVA: 0x00338A84 File Offset: 0x00336C84
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneTrackImplementation(Pointer, false, true);
		}

		// Token: 0x06022DAB RID: 142763 RVA: 0x00338A8E File Offset: 0x00336C8E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneTrackImplementation(Pointer, MemoryOwner);
		}

		// Token: 0x040129C1 RID: 76225
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneTrackImplementation";

		// Token: 0x040129C2 RID: 76226
		private static IntPtr _ScriptStructPtr;
	}
}
