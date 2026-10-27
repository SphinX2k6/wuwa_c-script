using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200232A RID: 9002
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScene3DLocationKeyStruct")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMovieScene3DLocationKeyStruct : FMovieSceneKeyStruct, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060220DA RID: 139482 RVA: 0x00325766 File Offset: 0x00323966
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieScene3DLocationKeyStruct._ScriptStructPtr != 0) ? FMovieScene3DLocationKeyStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieScene3DLocationKeyStruct", ref FMovieScene3DLocationKeyStruct._ScriptStructPtr);
		}

		// Token: 0x1700838E RID: 33678
		// (get) Token: 0x060220DB RID: 139483 RVA: 0x0032578A File Offset: 0x0032398A
		// (set) Token: 0x060220DC RID: 139484 RVA: 0x0032579E File Offset: 0x0032399E
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieScene3DLocationKeyStruct.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScene3DLocationKeyStruct.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x1700838F RID: 33679
		// (get) Token: 0x060220DD RID: 139485 RVA: 0x003257B4 File Offset: 0x003239B4
		// (set) Token: 0x060220DE RID: 139486 RVA: 0x003257F7 File Offset: 0x003239F7
		public FFrameNumber Time
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._Time) == null)
				{
					result = (this._Time = new FFrameNumber(base.NativePtr + (IntPtr)FMovieScene3DLocationKeyStruct.__PropertyOffset_Time, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieScene3DLocationKeyStruct.__PropertyOffset_Time, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060220DF RID: 139487 RVA: 0x00325818 File Offset: 0x00323A18
		public FMovieScene3DLocationKeyStruct()
		{
		}

		// Token: 0x060220E0 RID: 139488 RVA: 0x00325820 File Offset: 0x00323A20
		public FMovieScene3DLocationKeyStruct(FVector Location, FFrameNumber Time)
		{
			this.Location = Location;
			this.Time = Time;
		}

		// Token: 0x060220E1 RID: 139489 RVA: 0x00325836 File Offset: 0x00323A36
		protected override IntPtr GetUStructPtr()
		{
			return FMovieScene3DLocationKeyStruct.StaticStruct();
		}

		// Token: 0x060220E2 RID: 139490 RVA: 0x00325842 File Offset: 0x00323A42
		[NullableContext(2)]
		public FMovieScene3DLocationKeyStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060220E3 RID: 139491 RVA: 0x0032584C File Offset: 0x00323A4C
		public FMovieScene3DLocationKeyStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060220E4 RID: 139492 RVA: 0x00325857 File Offset: 0x00323A57
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieScene3DLocationKeyStruct(Pointer, false, true);
		}

		// Token: 0x060220E5 RID: 139493 RVA: 0x00325861 File Offset: 0x00323A61
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieScene3DLocationKeyStruct(Pointer, MemoryOwner);
		}

		// Token: 0x040122BC RID: 74428
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScene3DLocationKeyStruct";

		// Token: 0x040122BD RID: 74429
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040122BE RID: 74430
		internal static int __PropertyOffset_Location;

		// Token: 0x040122BF RID: 74431
		internal static int __PropertyOffset_Time;

		// Token: 0x040122C0 RID: 74432
		[Nullable(2)]
		private FFrameNumber _Time;
	}
}
