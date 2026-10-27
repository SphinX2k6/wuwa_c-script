using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023B5 RID: 9141
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneVector2DKeyStruct")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMovieSceneVector2DKeyStruct : FMovieSceneVectorKeyStructBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022684 RID: 140932 RVA: 0x0032E36A File Offset: 0x0032C56A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneVector2DKeyStruct._ScriptStructPtr != 0) ? FMovieSceneVector2DKeyStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneVector2DKeyStruct", ref FMovieSceneVector2DKeyStruct._ScriptStructPtr);
		}

		// Token: 0x17008494 RID: 33940
		// (get) Token: 0x06022685 RID: 140933 RVA: 0x0032E38E File Offset: 0x0032C58E
		// (set) Token: 0x06022686 RID: 140934 RVA: 0x0032E3A2 File Offset: 0x0032C5A2
		public unsafe FVector2D Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneVector2DKeyStruct.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneVector2DKeyStruct.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x06022687 RID: 140935 RVA: 0x0032E3B7 File Offset: 0x0032C5B7
		public FMovieSceneVector2DKeyStruct()
		{
		}

		// Token: 0x06022688 RID: 140936 RVA: 0x0032E3BF File Offset: 0x0032C5BF
		[NullableContext(1)]
		public FMovieSceneVector2DKeyStruct(FVector2D Vector, FFrameNumber Time)
		{
			this.Vector = Vector;
			base.Time = Time;
		}

		// Token: 0x06022689 RID: 140937 RVA: 0x0032E3D5 File Offset: 0x0032C5D5
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneVector2DKeyStruct.StaticStruct();
		}

		// Token: 0x0602268A RID: 140938 RVA: 0x0032E3E1 File Offset: 0x0032C5E1
		[NullableContext(2)]
		public FMovieSceneVector2DKeyStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602268B RID: 140939 RVA: 0x0032E3EB File Offset: 0x0032C5EB
		public FMovieSceneVector2DKeyStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602268C RID: 140940 RVA: 0x0032E3F6 File Offset: 0x0032C5F6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneVector2DKeyStruct(Pointer, false, true);
		}

		// Token: 0x0602268D RID: 140941 RVA: 0x0032E400 File Offset: 0x0032C600
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneVector2DKeyStruct(Pointer, MemoryOwner);
		}

		// Token: 0x040125E5 RID: 75237
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneVector2DKeyStruct";

		// Token: 0x040125E6 RID: 75238
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040125E7 RID: 75239
		internal static int __PropertyOffset_Vector;
	}
}
