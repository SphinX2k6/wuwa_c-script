using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200232B RID: 9003
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScene3DPathSection")]
	[UnrealStructLayout(512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 512)]
	public class UMovieScene3DPathSection : UMovieScene3DConstraintSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060220E6 RID: 139494 RVA: 0x0032586A File Offset: 0x00323A6A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScene3DPathSection._ClassPtr;
		}

		// Token: 0x060220E7 RID: 139495 RVA: 0x00325878 File Offset: 0x00323A78
		public UMovieScene3DPathSection() : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DPathSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060220E8 RID: 139496 RVA: 0x003258A0 File Offset: 0x00323AA0
		public UMovieScene3DPathSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DPathSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008390 RID: 33680
		// (get) Token: 0x060220E9 RID: 139497 RVA: 0x003258D4 File Offset: 0x00323AD4
		// (set) Token: 0x060220EA RID: 139498 RVA: 0x0032590D File Offset: 0x00323B0D
		public FMovieSceneFloatChannel TimingCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._TimingCurve) == null)
				{
					result = (this._TimingCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)UMovieScene3DPathSection.__PropertyOffset_TimingCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieScene3DPathSection.__PropertyOffset_TimingCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008391 RID: 33681
		// (get) Token: 0x060220EB RID: 139499 RVA: 0x0032592E File Offset: 0x00323B2E
		// (set) Token: 0x060220EC RID: 139500 RVA: 0x0032593E File Offset: 0x00323B3E
		public unsafe MovieScene3DPathSection_Axis FrontAxisEnum
		{
			get
			{
				return (MovieScene3DPathSection_Axis)(*(base.NativePtr + (IntPtr)UMovieScene3DPathSection.__PropertyOffset_FrontAxisEnum));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScene3DPathSection.__PropertyOffset_FrontAxisEnum) = (byte)value;
			}
		}

		// Token: 0x17008392 RID: 33682
		// (get) Token: 0x060220ED RID: 139501 RVA: 0x0032594F File Offset: 0x00323B4F
		// (set) Token: 0x060220EE RID: 139502 RVA: 0x0032595F File Offset: 0x00323B5F
		public unsafe MovieScene3DPathSection_Axis UpAxisEnum
		{
			get
			{
				return (MovieScene3DPathSection_Axis)(*(base.NativePtr + (IntPtr)UMovieScene3DPathSection.__PropertyOffset_UpAxisEnum));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScene3DPathSection.__PropertyOffset_UpAxisEnum) = (byte)value;
			}
		}

		// Token: 0x17008393 RID: 33683
		// (get) Token: 0x060220EF RID: 139503 RVA: 0x00325970 File Offset: 0x00323B70
		// (set) Token: 0x060220F0 RID: 139504 RVA: 0x00325989 File Offset: 0x00323B89
		public unsafe bool bFollow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovieScene3DPathSection.__PropertyOffset_bFollow) & UMovieScene3DPathSection.__PropertyMask_bFollow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovieScene3DPathSection.__PropertyOffset_bFollow) = ((*(base.NativePtr + (IntPtr)UMovieScene3DPathSection.__PropertyOffset_bFollow) & ~UMovieScene3DPathSection.__PropertyMask_bFollow) | (value ? UMovieScene3DPathSection.__PropertyMask_bFollow : 0));
			}
		}

		// Token: 0x17008394 RID: 33684
		// (get) Token: 0x060220F1 RID: 139505 RVA: 0x003259B9 File Offset: 0x00323BB9
		// (set) Token: 0x060220F2 RID: 139506 RVA: 0x003259D2 File Offset: 0x00323BD2
		public unsafe bool bReverse
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovieScene3DPathSection.__PropertyOffset_bReverse) & UMovieScene3DPathSection.__PropertyMask_bReverse) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovieScene3DPathSection.__PropertyOffset_bReverse) = ((*(base.NativePtr + (IntPtr)UMovieScene3DPathSection.__PropertyOffset_bReverse) & ~UMovieScene3DPathSection.__PropertyMask_bReverse) | (value ? UMovieScene3DPathSection.__PropertyMask_bReverse : 0));
			}
		}

		// Token: 0x17008395 RID: 33685
		// (get) Token: 0x060220F3 RID: 139507 RVA: 0x00325A02 File Offset: 0x00323C02
		// (set) Token: 0x060220F4 RID: 139508 RVA: 0x00325A1B File Offset: 0x00323C1B
		public unsafe bool bForceUpright
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovieScene3DPathSection.__PropertyOffset_bForceUpright) & UMovieScene3DPathSection.__PropertyMask_bForceUpright) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovieScene3DPathSection.__PropertyOffset_bForceUpright) = ((*(base.NativePtr + (IntPtr)UMovieScene3DPathSection.__PropertyOffset_bForceUpright) & ~UMovieScene3DPathSection.__PropertyMask_bForceUpright) | (value ? UMovieScene3DPathSection.__PropertyMask_bForceUpright : 0));
			}
		}

		// Token: 0x060220F5 RID: 139509 RVA: 0x00325A4B File Offset: 0x00323C4B
		static UMovieScene3DPathSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScene3DPathSection");
		}

		// Token: 0x060220F6 RID: 139510 RVA: 0x00325A59 File Offset: 0x00323C59
		protected UMovieScene3DPathSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040122C1 RID: 74433
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScene3DPathSection";

		// Token: 0x040122C2 RID: 74434
		private static IntPtr _ClassPtr;

		// Token: 0x040122C3 RID: 74435
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040122C4 RID: 74436
		internal static int __PropertyOffset_TimingCurve;

		// Token: 0x040122C5 RID: 74437
		[Nullable(2)]
		private FMovieSceneFloatChannel _TimingCurve;

		// Token: 0x040122C6 RID: 74438
		internal static int __PropertyOffset_FrontAxisEnum;

		// Token: 0x040122C7 RID: 74439
		internal static int __PropertyOffset_UpAxisEnum;

		// Token: 0x040122C8 RID: 74440
		internal static int __PropertyOffset_bFollow;

		// Token: 0x040122C9 RID: 74441
		internal static byte __PropertyMask_bFollow;

		// Token: 0x040122CA RID: 74442
		internal static int __PropertyOffset_bReverse;

		// Token: 0x040122CB RID: 74443
		internal static byte __PropertyMask_bReverse;

		// Token: 0x040122CC RID: 74444
		internal static int __PropertyOffset_bForceUpright;

		// Token: 0x040122CD RID: 74445
		internal static byte __PropertyMask_bForceUpright;
	}
}
