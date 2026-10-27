using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002406 RID: 9222
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneFieldEntry_ChildTemplate")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FMovieSceneFieldEntry_ChildTemplate : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022973 RID: 141683 RVA: 0x00332904 File Offset: 0x00330B04
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneFieldEntry_ChildTemplate._ScriptStructPtr != 0) ? FMovieSceneFieldEntry_ChildTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneFieldEntry_ChildTemplate", ref FMovieSceneFieldEntry_ChildTemplate._ScriptStructPtr);
		}

		// Token: 0x17008528 RID: 34088
		// (get) Token: 0x06022974 RID: 141684 RVA: 0x00332928 File Offset: 0x00330B28
		// (set) Token: 0x06022975 RID: 141685 RVA: 0x00332938 File Offset: 0x00330B38
		public unsafe ushort ChildIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFieldEntry_ChildTemplate.__PropertyOffset_ChildIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFieldEntry_ChildTemplate.__PropertyOffset_ChildIndex) = (short)value;
			}
		}

		// Token: 0x17008529 RID: 34089
		// (get) Token: 0x06022976 RID: 141686 RVA: 0x00332949 File Offset: 0x00330B49
		// (set) Token: 0x06022977 RID: 141687 RVA: 0x00332959 File Offset: 0x00330B59
		public unsafe ESectionEvaluationFlags Flags
		{
			get
			{
				return (ESectionEvaluationFlags)(*(base.NativePtr + (IntPtr)FMovieSceneFieldEntry_ChildTemplate.__PropertyOffset_Flags));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFieldEntry_ChildTemplate.__PropertyOffset_Flags) = (byte)value;
			}
		}

		// Token: 0x1700852A RID: 34090
		// (get) Token: 0x06022978 RID: 141688 RVA: 0x0033296C File Offset: 0x00330B6C
		// (set) Token: 0x06022979 RID: 141689 RVA: 0x003329AF File Offset: 0x00330BAF
		public FFrameNumber ForcedTime
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._ForcedTime) == null)
				{
					result = (this._ForcedTime = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneFieldEntry_ChildTemplate.__PropertyOffset_ForcedTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneFieldEntry_ChildTemplate.__PropertyOffset_ForcedTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602297A RID: 141690 RVA: 0x003329D0 File Offset: 0x00330BD0
		public FMovieSceneFieldEntry_ChildTemplate()
		{
		}

		// Token: 0x0602297B RID: 141691 RVA: 0x003329D8 File Offset: 0x00330BD8
		public FMovieSceneFieldEntry_ChildTemplate(ushort ChildIndex, ESectionEvaluationFlags Flags, FFrameNumber ForcedTime)
		{
			this.ChildIndex = ChildIndex;
			this.Flags = Flags;
			this.ForcedTime = ForcedTime;
		}

		// Token: 0x0602297C RID: 141692 RVA: 0x003329F5 File Offset: 0x00330BF5
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneFieldEntry_ChildTemplate.StaticStruct();
		}

		// Token: 0x0602297D RID: 141693 RVA: 0x00332A01 File Offset: 0x00330C01
		[NullableContext(2)]
		public FMovieSceneFieldEntry_ChildTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602297E RID: 141694 RVA: 0x00332A0B File Offset: 0x00330C0B
		public FMovieSceneFieldEntry_ChildTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602297F RID: 141695 RVA: 0x00332A16 File Offset: 0x00330C16
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneFieldEntry_ChildTemplate(Pointer, false, true);
		}

		// Token: 0x06022980 RID: 141696 RVA: 0x00332A20 File Offset: 0x00330C20
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneFieldEntry_ChildTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x040127C1 RID: 75713
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneFieldEntry_ChildTemplate";

		// Token: 0x040127C2 RID: 75714
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040127C3 RID: 75715
		internal static int __PropertyOffset_ChildIndex;

		// Token: 0x040127C4 RID: 75716
		internal static int __PropertyOffset_Flags;

		// Token: 0x040127C5 RID: 75717
		internal static int __PropertyOffset_ForcedTime;

		// Token: 0x040127C6 RID: 75718
		[Nullable(2)]
		private FFrameNumber _ForcedTime;
	}
}
