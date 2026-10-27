using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002330 RID: 9008
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScene3DScaleKeyStruct")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMovieScene3DScaleKeyStruct : FMovieSceneKeyStruct, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602211F RID: 139551 RVA: 0x00325E8E File Offset: 0x0032408E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieScene3DScaleKeyStruct._ScriptStructPtr != 0) ? FMovieScene3DScaleKeyStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieScene3DScaleKeyStruct", ref FMovieScene3DScaleKeyStruct._ScriptStructPtr);
		}

		// Token: 0x1700839F RID: 33695
		// (get) Token: 0x06022120 RID: 139552 RVA: 0x00325EB2 File Offset: 0x003240B2
		// (set) Token: 0x06022121 RID: 139553 RVA: 0x00325EC6 File Offset: 0x003240C6
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieScene3DScaleKeyStruct.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScene3DScaleKeyStruct.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x170083A0 RID: 33696
		// (get) Token: 0x06022122 RID: 139554 RVA: 0x00325EDC File Offset: 0x003240DC
		// (set) Token: 0x06022123 RID: 139555 RVA: 0x00325F1F File Offset: 0x0032411F
		public FFrameNumber Time
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._Time) == null)
				{
					result = (this._Time = new FFrameNumber(base.NativePtr + (IntPtr)FMovieScene3DScaleKeyStruct.__PropertyOffset_Time, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieScene3DScaleKeyStruct.__PropertyOffset_Time, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022124 RID: 139556 RVA: 0x00325F40 File Offset: 0x00324140
		public FMovieScene3DScaleKeyStruct()
		{
		}

		// Token: 0x06022125 RID: 139557 RVA: 0x00325F48 File Offset: 0x00324148
		public FMovieScene3DScaleKeyStruct(FVector Scale, FFrameNumber Time)
		{
			this.Scale = Scale;
			this.Time = Time;
		}

		// Token: 0x06022126 RID: 139558 RVA: 0x00325F5E File Offset: 0x0032415E
		protected override IntPtr GetUStructPtr()
		{
			return FMovieScene3DScaleKeyStruct.StaticStruct();
		}

		// Token: 0x06022127 RID: 139559 RVA: 0x00325F6A File Offset: 0x0032416A
		[NullableContext(2)]
		public FMovieScene3DScaleKeyStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022128 RID: 139560 RVA: 0x00325F74 File Offset: 0x00324174
		public FMovieScene3DScaleKeyStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022129 RID: 139561 RVA: 0x00325F7F File Offset: 0x0032417F
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieScene3DScaleKeyStruct(Pointer, false, true);
		}

		// Token: 0x0602212A RID: 139562 RVA: 0x00325F89 File Offset: 0x00324189
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieScene3DScaleKeyStruct(Pointer, MemoryOwner);
		}

		// Token: 0x040122ED RID: 74477
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScene3DScaleKeyStruct";

		// Token: 0x040122EE RID: 74478
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040122EF RID: 74479
		internal static int __PropertyOffset_Scale;

		// Token: 0x040122F0 RID: 74480
		internal static int __PropertyOffset_Time;

		// Token: 0x040122F1 RID: 74481
		[Nullable(2)]
		private FFrameNumber _Time;
	}
}
