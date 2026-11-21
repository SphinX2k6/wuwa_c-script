using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000781 RID: 1921
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneMarkedFrame")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMovieSceneMarkedFrame : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A5DA RID: 42458 RVA: 0x000F4F16 File Offset: 0x000F3116
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneMarkedFrame._ScriptStructPtr != 0) ? FMovieSceneMarkedFrame._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneMarkedFrame", ref FMovieSceneMarkedFrame._ScriptStructPtr);
		}

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x0600A5DB RID: 42459 RVA: 0x000F4F3C File Offset: 0x000F313C
		// (set) Token: 0x0600A5DC RID: 42460 RVA: 0x000F4F7F File Offset: 0x000F317F
		public FFrameNumber FrameNumber
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._FrameNumber) == null)
				{
					result = (this._FrameNumber = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneMarkedFrame.__PropertyOffset_FrameNumber, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneMarkedFrame.__PropertyOffset_FrameNumber, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x0600A5DD RID: 42461 RVA: 0x000F4FA0 File Offset: 0x000F31A0
		// (set) Token: 0x0600A5DE RID: 42462 RVA: 0x000F4FB4 File Offset: 0x000F31B4
		public unsafe string Label
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneMarkedFrame.__PropertyOffset_Label)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneMarkedFrame.__PropertyOffset_Label)), value);
			}
		}

		// Token: 0x0600A5DF RID: 42463 RVA: 0x000F4FC9 File Offset: 0x000F31C9
		public FMovieSceneMarkedFrame()
		{
		}

		// Token: 0x0600A5E0 RID: 42464 RVA: 0x000F4FD1 File Offset: 0x000F31D1
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneMarkedFrame.StaticStruct();
		}

		// Token: 0x0600A5E1 RID: 42465 RVA: 0x000F4FDD File Offset: 0x000F31DD
		[NullableContext(2)]
		public FMovieSceneMarkedFrame(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A5E2 RID: 42466 RVA: 0x000F4FE7 File Offset: 0x000F31E7
		public FMovieSceneMarkedFrame(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A5E3 RID: 42467 RVA: 0x000F4FF2 File Offset: 0x000F31F2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneMarkedFrame(Pointer, false, true);
		}

		// Token: 0x0600A5E4 RID: 42468 RVA: 0x000F4FFC File Offset: 0x000F31FC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneMarkedFrame(Pointer, MemoryOwner);
		}

		// Token: 0x04004704 RID: 18180
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneMarkedFrame";

		// Token: 0x04004705 RID: 18181
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004706 RID: 18182
		internal static int __PropertyOffset_FrameNumber;

		// Token: 0x04004707 RID: 18183
		[Nullable(2)]
		private FFrameNumber _FrameNumber;

		// Token: 0x04004708 RID: 18184
		internal static int __PropertyOffset_Label;
	}
}
