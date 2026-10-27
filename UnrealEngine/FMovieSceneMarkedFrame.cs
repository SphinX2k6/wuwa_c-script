using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002413 RID: 9235
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneMarkedFrame")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMovieSceneMarkedFrame : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060229FA RID: 141818 RVA: 0x0033344F File Offset: 0x0033164F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneMarkedFrame._ScriptStructPtr != 0) ? FMovieSceneMarkedFrame._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneMarkedFrame", ref FMovieSceneMarkedFrame._ScriptStructPtr);
		}

		// Token: 0x17008543 RID: 34115
		// (get) Token: 0x060229FB RID: 141819 RVA: 0x00333474 File Offset: 0x00331674
		// (set) Token: 0x060229FC RID: 141820 RVA: 0x003334B7 File Offset: 0x003316B7
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

		// Token: 0x17008544 RID: 34116
		// (get) Token: 0x060229FD RID: 141821 RVA: 0x003334D8 File Offset: 0x003316D8
		// (set) Token: 0x060229FE RID: 141822 RVA: 0x003334EC File Offset: 0x003316EC
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

		// Token: 0x060229FF RID: 141823 RVA: 0x00333501 File Offset: 0x00331701
		public FMovieSceneMarkedFrame()
		{
		}

		// Token: 0x06022A00 RID: 141824 RVA: 0x00333509 File Offset: 0x00331709
		public FMovieSceneMarkedFrame(FFrameNumber FrameNumber, string Label, FLinearColor Color)
		{
			this.FrameNumber = FrameNumber;
			this.Label = Label;
		}

		// Token: 0x06022A01 RID: 141825 RVA: 0x0033351F File Offset: 0x0033171F
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneMarkedFrame.StaticStruct();
		}

		// Token: 0x06022A02 RID: 141826 RVA: 0x0033352B File Offset: 0x0033172B
		[NullableContext(2)]
		public FMovieSceneMarkedFrame(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022A03 RID: 141827 RVA: 0x00333535 File Offset: 0x00331735
		public FMovieSceneMarkedFrame(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022A04 RID: 141828 RVA: 0x00333540 File Offset: 0x00331740
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneMarkedFrame(Pointer, false, true);
		}

		// Token: 0x06022A05 RID: 141829 RVA: 0x0033354A File Offset: 0x0033174A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneMarkedFrame(Pointer, MemoryOwner);
		}

		// Token: 0x04012801 RID: 75777
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneMarkedFrame";

		// Token: 0x04012802 RID: 75778
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012803 RID: 75779
		internal static int __PropertyOffset_FrameNumber;

		// Token: 0x04012804 RID: 75780
		[Nullable(2)]
		private FFrameNumber _FrameNumber;

		// Token: 0x04012805 RID: 75781
		internal static int __PropertyOffset_Label;
	}
}
