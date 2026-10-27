using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023B6 RID: 9142
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneVector4KeyStruct")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FMovieSceneVector4KeyStruct : FMovieSceneVectorKeyStructBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602268E RID: 140942 RVA: 0x0032E409 File Offset: 0x0032C609
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneVector4KeyStruct._ScriptStructPtr != 0) ? FMovieSceneVector4KeyStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneVector4KeyStruct", ref FMovieSceneVector4KeyStruct._ScriptStructPtr);
		}

		// Token: 0x17008495 RID: 33941
		// (get) Token: 0x0602268F RID: 140943 RVA: 0x0032E42D File Offset: 0x0032C62D
		// (set) Token: 0x06022690 RID: 140944 RVA: 0x0032E441 File Offset: 0x0032C641
		public unsafe FVector4 Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneVector4KeyStruct.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneVector4KeyStruct.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x06022691 RID: 140945 RVA: 0x0032E456 File Offset: 0x0032C656
		public FMovieSceneVector4KeyStruct()
		{
		}

		// Token: 0x06022692 RID: 140946 RVA: 0x0032E45E File Offset: 0x0032C65E
		[NullableContext(1)]
		public FMovieSceneVector4KeyStruct(FVector4 Vector, FFrameNumber Time)
		{
			this.Vector = Vector;
			base.Time = Time;
		}

		// Token: 0x06022693 RID: 140947 RVA: 0x0032E474 File Offset: 0x0032C674
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneVector4KeyStruct.StaticStruct();
		}

		// Token: 0x06022694 RID: 140948 RVA: 0x0032E480 File Offset: 0x0032C680
		[NullableContext(2)]
		public FMovieSceneVector4KeyStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022695 RID: 140949 RVA: 0x0032E48A File Offset: 0x0032C68A
		public FMovieSceneVector4KeyStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022696 RID: 140950 RVA: 0x0032E495 File Offset: 0x0032C695
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneVector4KeyStruct(Pointer, false, true);
		}

		// Token: 0x06022697 RID: 140951 RVA: 0x0032E49F File Offset: 0x0032C69F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneVector4KeyStruct(Pointer, MemoryOwner);
		}

		// Token: 0x040125E8 RID: 75240
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneVector4KeyStruct";

		// Token: 0x040125E9 RID: 75241
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040125EA RID: 75242
		internal static int __PropertyOffset_Vector;
	}
}
