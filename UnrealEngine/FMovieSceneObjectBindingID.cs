using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000783 RID: 1923
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneObjectBindingID")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMovieSceneObjectBindingID : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A5E9 RID: 42473 RVA: 0x000F5051 File Offset: 0x000F3251
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneObjectBindingID._ScriptStructPtr != 0) ? FMovieSceneObjectBindingID._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneObjectBindingID", ref FMovieSceneObjectBindingID._ScriptStructPtr);
		}

		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x0600A5EA RID: 42474 RVA: 0x000F5075 File Offset: 0x000F3275
		// (set) Token: 0x0600A5EB RID: 42475 RVA: 0x000F5085 File Offset: 0x000F3285
		public unsafe int SequenceID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneObjectBindingID.__PropertyOffset_SequenceID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneObjectBindingID.__PropertyOffset_SequenceID) = value;
			}
		}

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x0600A5EC RID: 42476 RVA: 0x000F5096 File Offset: 0x000F3296
		// (set) Token: 0x0600A5ED RID: 42477 RVA: 0x000F50AA File Offset: 0x000F32AA
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneObjectBindingID.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneObjectBindingID.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x0600A5EE RID: 42478 RVA: 0x000F50BF File Offset: 0x000F32BF
		public FMovieSceneObjectBindingID()
		{
		}

		// Token: 0x0600A5EF RID: 42479 RVA: 0x000F50C7 File Offset: 0x000F32C7
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneObjectBindingID.StaticStruct();
		}

		// Token: 0x0600A5F0 RID: 42480 RVA: 0x000F50D3 File Offset: 0x000F32D3
		[NullableContext(2)]
		public FMovieSceneObjectBindingID(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A5F1 RID: 42481 RVA: 0x000F50DD File Offset: 0x000F32DD
		public FMovieSceneObjectBindingID(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A5F2 RID: 42482 RVA: 0x000F50E8 File Offset: 0x000F32E8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneObjectBindingID(Pointer, false, true);
		}

		// Token: 0x0600A5F3 RID: 42483 RVA: 0x000F50F2 File Offset: 0x000F32F2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneObjectBindingID(Pointer, MemoryOwner);
		}

		// Token: 0x0400470C RID: 18188
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneObjectBindingID";

		// Token: 0x0400470D RID: 18189
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400470E RID: 18190
		internal static int __PropertyOffset_SequenceID;

		// Token: 0x0400470F RID: 18191
		internal static int __PropertyOffset_Guid;
	}
}
