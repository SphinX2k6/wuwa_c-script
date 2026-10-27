using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200232F RID: 9007
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScene3DRotationKeyStruct")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMovieScene3DRotationKeyStruct : FMovieSceneKeyStruct, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022113 RID: 139539 RVA: 0x00325D8A File Offset: 0x00323F8A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieScene3DRotationKeyStruct._ScriptStructPtr != 0) ? FMovieScene3DRotationKeyStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieScene3DRotationKeyStruct", ref FMovieScene3DRotationKeyStruct._ScriptStructPtr);
		}

		// Token: 0x1700839D RID: 33693
		// (get) Token: 0x06022114 RID: 139540 RVA: 0x00325DAE File Offset: 0x00323FAE
		// (set) Token: 0x06022115 RID: 139541 RVA: 0x00325DC2 File Offset: 0x00323FC2
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieScene3DRotationKeyStruct.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScene3DRotationKeyStruct.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x1700839E RID: 33694
		// (get) Token: 0x06022116 RID: 139542 RVA: 0x00325DD8 File Offset: 0x00323FD8
		// (set) Token: 0x06022117 RID: 139543 RVA: 0x00325E1B File Offset: 0x0032401B
		public FFrameNumber Time
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._Time) == null)
				{
					result = (this._Time = new FFrameNumber(base.NativePtr + (IntPtr)FMovieScene3DRotationKeyStruct.__PropertyOffset_Time, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieScene3DRotationKeyStruct.__PropertyOffset_Time, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022118 RID: 139544 RVA: 0x00325E3C File Offset: 0x0032403C
		public FMovieScene3DRotationKeyStruct()
		{
		}

		// Token: 0x06022119 RID: 139545 RVA: 0x00325E44 File Offset: 0x00324044
		public FMovieScene3DRotationKeyStruct(FRotator Rotation, FFrameNumber Time)
		{
			this.Rotation = Rotation;
			this.Time = Time;
		}

		// Token: 0x0602211A RID: 139546 RVA: 0x00325E5A File Offset: 0x0032405A
		protected override IntPtr GetUStructPtr()
		{
			return FMovieScene3DRotationKeyStruct.StaticStruct();
		}

		// Token: 0x0602211B RID: 139547 RVA: 0x00325E66 File Offset: 0x00324066
		[NullableContext(2)]
		public FMovieScene3DRotationKeyStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602211C RID: 139548 RVA: 0x00325E70 File Offset: 0x00324070
		public FMovieScene3DRotationKeyStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602211D RID: 139549 RVA: 0x00325E7B File Offset: 0x0032407B
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieScene3DRotationKeyStruct(Pointer, false, true);
		}

		// Token: 0x0602211E RID: 139550 RVA: 0x00325E85 File Offset: 0x00324085
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieScene3DRotationKeyStruct(Pointer, MemoryOwner);
		}

		// Token: 0x040122E8 RID: 74472
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScene3DRotationKeyStruct";

		// Token: 0x040122E9 RID: 74473
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040122EA RID: 74474
		internal static int __PropertyOffset_Rotation;

		// Token: 0x040122EB RID: 74475
		internal static int __PropertyOffset_Time;

		// Token: 0x040122EC RID: 74476
		[Nullable(2)]
		private FFrameNumber _Time;
	}
}
