using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200232C RID: 9004
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScene3DPathSectionTemplate")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FMovieScene3DPathSectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060220F7 RID: 139511 RVA: 0x00325A62 File Offset: 0x00323C62
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieScene3DPathSectionTemplate._ScriptStructPtr != 0) ? FMovieScene3DPathSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieScene3DPathSectionTemplate", ref FMovieScene3DPathSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x17008396 RID: 33686
		// (get) Token: 0x060220F8 RID: 139512 RVA: 0x00325A88 File Offset: 0x00323C88
		// (set) Token: 0x060220F9 RID: 139513 RVA: 0x00325ACB File Offset: 0x00323CCB
		public FMovieSceneObjectBindingID PathBindingID
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneObjectBindingID result;
				if ((result = this._PathBindingID) == null)
				{
					result = (this._PathBindingID = new FMovieSceneObjectBindingID(base.NativePtr + (IntPtr)FMovieScene3DPathSectionTemplate.__PropertyOffset_PathBindingID, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneObjectBindingID.StaticStruct(), base.NativePtr + (IntPtr)FMovieScene3DPathSectionTemplate.__PropertyOffset_PathBindingID, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008397 RID: 33687
		// (get) Token: 0x060220FA RID: 139514 RVA: 0x00325AEC File Offset: 0x00323CEC
		// (set) Token: 0x060220FB RID: 139515 RVA: 0x00325B2F File Offset: 0x00323D2F
		public FMovieSceneFloatChannel TimingCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._TimingCurve) == null)
				{
					result = (this._TimingCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FMovieScene3DPathSectionTemplate.__PropertyOffset_TimingCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieScene3DPathSectionTemplate.__PropertyOffset_TimingCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008398 RID: 33688
		// (get) Token: 0x060220FC RID: 139516 RVA: 0x00325B50 File Offset: 0x00323D50
		// (set) Token: 0x060220FD RID: 139517 RVA: 0x00325B60 File Offset: 0x00323D60
		public unsafe MovieScene3DPathSection_Axis FrontAxisEnum
		{
			get
			{
				return (MovieScene3DPathSection_Axis)(*(base.NativePtr + (IntPtr)FMovieScene3DPathSectionTemplate.__PropertyOffset_FrontAxisEnum));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScene3DPathSectionTemplate.__PropertyOffset_FrontAxisEnum) = (byte)value;
			}
		}

		// Token: 0x17008399 RID: 33689
		// (get) Token: 0x060220FE RID: 139518 RVA: 0x00325B71 File Offset: 0x00323D71
		// (set) Token: 0x060220FF RID: 139519 RVA: 0x00325B81 File Offset: 0x00323D81
		public unsafe MovieScene3DPathSection_Axis UpAxisEnum
		{
			get
			{
				return (MovieScene3DPathSection_Axis)(*(base.NativePtr + (IntPtr)FMovieScene3DPathSectionTemplate.__PropertyOffset_UpAxisEnum));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScene3DPathSectionTemplate.__PropertyOffset_UpAxisEnum) = (byte)value;
			}
		}

		// Token: 0x1700839A RID: 33690
		// (get) Token: 0x06022100 RID: 139520 RVA: 0x00325B92 File Offset: 0x00323D92
		// (set) Token: 0x06022101 RID: 139521 RVA: 0x00325BAB File Offset: 0x00323DAB
		public unsafe bool bFollow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieScene3DPathSectionTemplate.__PropertyOffset_bFollow) & FMovieScene3DPathSectionTemplate.__PropertyMask_bFollow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieScene3DPathSectionTemplate.__PropertyOffset_bFollow) = ((*(base.NativePtr + (IntPtr)FMovieScene3DPathSectionTemplate.__PropertyOffset_bFollow) & ~FMovieScene3DPathSectionTemplate.__PropertyMask_bFollow) | (value ? FMovieScene3DPathSectionTemplate.__PropertyMask_bFollow : 0));
			}
		}

		// Token: 0x1700839B RID: 33691
		// (get) Token: 0x06022102 RID: 139522 RVA: 0x00325BDB File Offset: 0x00323DDB
		// (set) Token: 0x06022103 RID: 139523 RVA: 0x00325BF4 File Offset: 0x00323DF4
		public unsafe bool bReverse
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieScene3DPathSectionTemplate.__PropertyOffset_bReverse) & FMovieScene3DPathSectionTemplate.__PropertyMask_bReverse) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieScene3DPathSectionTemplate.__PropertyOffset_bReverse) = ((*(base.NativePtr + (IntPtr)FMovieScene3DPathSectionTemplate.__PropertyOffset_bReverse) & ~FMovieScene3DPathSectionTemplate.__PropertyMask_bReverse) | (value ? FMovieScene3DPathSectionTemplate.__PropertyMask_bReverse : 0));
			}
		}

		// Token: 0x1700839C RID: 33692
		// (get) Token: 0x06022104 RID: 139524 RVA: 0x00325C24 File Offset: 0x00323E24
		// (set) Token: 0x06022105 RID: 139525 RVA: 0x00325C3D File Offset: 0x00323E3D
		public unsafe bool bForceUpright
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieScene3DPathSectionTemplate.__PropertyOffset_bForceUpright) & FMovieScene3DPathSectionTemplate.__PropertyMask_bForceUpright) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieScene3DPathSectionTemplate.__PropertyOffset_bForceUpright) = ((*(base.NativePtr + (IntPtr)FMovieScene3DPathSectionTemplate.__PropertyOffset_bForceUpright) & ~FMovieScene3DPathSectionTemplate.__PropertyMask_bForceUpright) | (value ? FMovieScene3DPathSectionTemplate.__PropertyMask_bForceUpright : 0));
			}
		}

		// Token: 0x06022106 RID: 139526 RVA: 0x00325C6D File Offset: 0x00323E6D
		public FMovieScene3DPathSectionTemplate()
		{
		}

		// Token: 0x06022107 RID: 139527 RVA: 0x00325C78 File Offset: 0x00323E78
		public FMovieScene3DPathSectionTemplate(FMovieSceneObjectBindingID PathBindingID, FMovieSceneFloatChannel TimingCurve, MovieScene3DPathSection_Axis FrontAxisEnum, MovieScene3DPathSection_Axis UpAxisEnum, bool bFollow, bool bReverse, bool bForceUpright, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.PathBindingID = PathBindingID;
			this.TimingCurve = TimingCurve;
			this.FrontAxisEnum = FrontAxisEnum;
			this.UpAxisEnum = UpAxisEnum;
			this.bFollow = bFollow;
			this.bReverse = bReverse;
			this.bForceUpright = bForceUpright;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06022108 RID: 139528 RVA: 0x00325CD0 File Offset: 0x00323ED0
		protected override IntPtr GetUStructPtr()
		{
			return FMovieScene3DPathSectionTemplate.StaticStruct();
		}

		// Token: 0x06022109 RID: 139529 RVA: 0x00325CDC File Offset: 0x00323EDC
		[NullableContext(2)]
		public FMovieScene3DPathSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602210A RID: 139530 RVA: 0x00325CE6 File Offset: 0x00323EE6
		public FMovieScene3DPathSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602210B RID: 139531 RVA: 0x00325CF1 File Offset: 0x00323EF1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieScene3DPathSectionTemplate(Pointer, false, true);
		}

		// Token: 0x0602210C RID: 139532 RVA: 0x00325CFB File Offset: 0x00323EFB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieScene3DPathSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x040122CE RID: 74446
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScene3DPathSectionTemplate";

		// Token: 0x040122CF RID: 74447
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040122D0 RID: 74448
		internal static int __PropertyOffset_PathBindingID;

		// Token: 0x040122D1 RID: 74449
		[Nullable(2)]
		private FMovieSceneObjectBindingID _PathBindingID;

		// Token: 0x040122D2 RID: 74450
		internal static int __PropertyOffset_TimingCurve;

		// Token: 0x040122D3 RID: 74451
		[Nullable(2)]
		private FMovieSceneFloatChannel _TimingCurve;

		// Token: 0x040122D4 RID: 74452
		internal static int __PropertyOffset_FrontAxisEnum;

		// Token: 0x040122D5 RID: 74453
		internal static int __PropertyOffset_UpAxisEnum;

		// Token: 0x040122D6 RID: 74454
		internal static int __PropertyOffset_bFollow;

		// Token: 0x040122D7 RID: 74455
		internal static byte __PropertyMask_bFollow;

		// Token: 0x040122D8 RID: 74456
		internal static int __PropertyOffset_bReverse;

		// Token: 0x040122D9 RID: 74457
		internal static byte __PropertyMask_bReverse;

		// Token: 0x040122DA RID: 74458
		internal static int __PropertyOffset_bForceUpright;

		// Token: 0x040122DB RID: 74459
		internal static byte __PropertyMask_bForceUpright;
	}
}
