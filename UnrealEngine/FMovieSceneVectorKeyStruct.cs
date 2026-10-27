using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023B7 RID: 9143
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneVectorKeyStruct")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FMovieSceneVectorKeyStruct : FMovieSceneVectorKeyStructBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022698 RID: 140952 RVA: 0x0032E4A8 File Offset: 0x0032C6A8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneVectorKeyStruct._ScriptStructPtr != 0) ? FMovieSceneVectorKeyStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneVectorKeyStruct", ref FMovieSceneVectorKeyStruct._ScriptStructPtr);
		}

		// Token: 0x17008496 RID: 33942
		// (get) Token: 0x06022699 RID: 140953 RVA: 0x0032E4CC File Offset: 0x0032C6CC
		// (set) Token: 0x0602269A RID: 140954 RVA: 0x0032E4E0 File Offset: 0x0032C6E0
		public unsafe FVector Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneVectorKeyStruct.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneVectorKeyStruct.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x0602269B RID: 140955 RVA: 0x0032E4F5 File Offset: 0x0032C6F5
		public FMovieSceneVectorKeyStruct()
		{
		}

		// Token: 0x0602269C RID: 140956 RVA: 0x0032E4FD File Offset: 0x0032C6FD
		[NullableContext(1)]
		public FMovieSceneVectorKeyStruct(FVector Vector, FFrameNumber Time)
		{
			this.Vector = Vector;
			base.Time = Time;
		}

		// Token: 0x0602269D RID: 140957 RVA: 0x0032E513 File Offset: 0x0032C713
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneVectorKeyStruct.StaticStruct();
		}

		// Token: 0x0602269E RID: 140958 RVA: 0x0032E51F File Offset: 0x0032C71F
		[NullableContext(2)]
		public FMovieSceneVectorKeyStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602269F RID: 140959 RVA: 0x0032E529 File Offset: 0x0032C729
		public FMovieSceneVectorKeyStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060226A0 RID: 140960 RVA: 0x0032E534 File Offset: 0x0032C734
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneVectorKeyStruct(Pointer, false, true);
		}

		// Token: 0x060226A1 RID: 140961 RVA: 0x0032E53E File Offset: 0x0032C73E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneVectorKeyStruct(Pointer, MemoryOwner);
		}

		// Token: 0x040125EB RID: 75243
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneVectorKeyStruct";

		// Token: 0x040125EC RID: 75244
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040125ED RID: 75245
		internal static int __PropertyOffset_Vector;
	}
}
