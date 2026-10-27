using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023D3 RID: 9171
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieScene")]
	[UnrealStructLayout(1016, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1016)]
	public class UMovieScene : UMovieSceneSignedObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022728 RID: 141096 RVA: 0x0032F14A File Offset: 0x0032D34A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScene._ClassPtr;
		}

		// Token: 0x06022729 RID: 141097 RVA: 0x0032F158 File Offset: 0x0032D358
		public UMovieScene() : this(BuiltinUtils.AllocNativeUObject(UMovieScene.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602272A RID: 141098 RVA: 0x0032F180 File Offset: 0x0032D380
		public UMovieScene(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScene.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170084AC RID: 33964
		// (get) Token: 0x0602272B RID: 141099 RVA: 0x0032F1B4 File Offset: 0x0032D3B4
		// (set) Token: 0x0602272C RID: 141100 RVA: 0x0032F1ED File Offset: 0x0032D3ED
		public TArray<FMovieSceneSpawnable> Spawnables
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneSpawnable> result;
				if ((result = this._Spawnables) == null)
				{
					result = (this._Spawnables = new TArray<FMovieSceneSpawnable>(base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_Spawnables, this));
				}
				return result;
			}
			set
			{
				this.Spawnables.CopyAssign(value);
			}
		}

		// Token: 0x170084AD RID: 33965
		// (get) Token: 0x0602272D RID: 141101 RVA: 0x0032F1FC File Offset: 0x0032D3FC
		// (set) Token: 0x0602272E RID: 141102 RVA: 0x0032F235 File Offset: 0x0032D435
		public TArray<FMovieScenePossessable> Possessables
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieScenePossessable> result;
				if ((result = this._Possessables) == null)
				{
					result = (this._Possessables = new TArray<FMovieScenePossessable>(base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_Possessables, this));
				}
				return result;
			}
			set
			{
				this.Possessables.CopyAssign(value);
			}
		}

		// Token: 0x170084AE RID: 33966
		// (get) Token: 0x0602272F RID: 141103 RVA: 0x0032F244 File Offset: 0x0032D444
		// (set) Token: 0x06022730 RID: 141104 RVA: 0x0032F27D File Offset: 0x0032D47D
		public TArray<FMovieSceneBinding> ObjectBindings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneBinding> result;
				if ((result = this._ObjectBindings) == null)
				{
					result = (this._ObjectBindings = new TArray<FMovieSceneBinding>(base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_ObjectBindings, this));
				}
				return result;
			}
			set
			{
				this.ObjectBindings.CopyAssign(value);
			}
		}

		// Token: 0x170084AF RID: 33967
		// (get) Token: 0x06022731 RID: 141105 RVA: 0x0032F28C File Offset: 0x0032D48C
		// (set) Token: 0x06022732 RID: 141106 RVA: 0x0032F2C5 File Offset: 0x0032D4C5
		public TMap<FName, FMovieSceneObjectBindingIDs> BindingGroups
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FMovieSceneObjectBindingIDs> result;
				if ((result = this._BindingGroups) == null)
				{
					result = (this._BindingGroups = new TMap<FName, FMovieSceneObjectBindingIDs>(base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_BindingGroups, this));
				}
				return result;
			}
			set
			{
				this.BindingGroups.CopyAssign(value);
			}
		}

		// Token: 0x170084B0 RID: 33968
		// (get) Token: 0x06022733 RID: 141107 RVA: 0x0032F2D4 File Offset: 0x0032D4D4
		// (set) Token: 0x06022734 RID: 141108 RVA: 0x0032F30D File Offset: 0x0032D50D
		public TArray<UMovieSceneTrack> MasterTracks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneTrack> result;
				if ((result = this._MasterTracks) == null)
				{
					result = (this._MasterTracks = new TArray<UMovieSceneTrack>(base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_MasterTracks, this));
				}
				return result;
			}
			set
			{
				this.MasterTracks.CopyAssign(value);
			}
		}

		// Token: 0x170084B1 RID: 33969
		// (get) Token: 0x06022735 RID: 141109 RVA: 0x0032F31C File Offset: 0x0032D51C
		// (set) Token: 0x06022736 RID: 141110 RVA: 0x0032F355 File Offset: 0x0032D555
		public TMap<FName, FMovieSceneMasterTracks> MasterTracksGroups
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FMovieSceneMasterTracks> result;
				if ((result = this._MasterTracksGroups) == null)
				{
					result = (this._MasterTracksGroups = new TMap<FName, FMovieSceneMasterTracks>(base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_MasterTracksGroups, this));
				}
				return result;
			}
			set
			{
				this.MasterTracksGroups.CopyAssign(value);
			}
		}

		// Token: 0x170084B2 RID: 33970
		// (get) Token: 0x06022737 RID: 141111 RVA: 0x0032F363 File Offset: 0x0032D563
		// (set) Token: 0x06022738 RID: 141112 RVA: 0x0032F377 File Offset: 0x0032D577
		[Nullable(2)]
		public unsafe UMovieSceneTrack CameraCutTrack
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneTrack>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieScene.__PropertyOffset_CameraCutTrack);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieScene.__PropertyOffset_CameraCutTrack, value);
			}
		}

		// Token: 0x170084B3 RID: 33971
		// (get) Token: 0x06022739 RID: 141113 RVA: 0x0032F38C File Offset: 0x0032D58C
		// (set) Token: 0x0602273A RID: 141114 RVA: 0x0032F3C5 File Offset: 0x0032D5C5
		public FMovieSceneFrameRange SelectionRange
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFrameRange result;
				if ((result = this._SelectionRange) == null)
				{
					result = (this._SelectionRange = new FMovieSceneFrameRange(base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_SelectionRange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFrameRange.StaticStruct(), base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_SelectionRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170084B4 RID: 33972
		// (get) Token: 0x0602273B RID: 141115 RVA: 0x0032F3E8 File Offset: 0x0032D5E8
		// (set) Token: 0x0602273C RID: 141116 RVA: 0x0032F421 File Offset: 0x0032D621
		public FMovieSceneFrameRange PlaybackRange
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFrameRange result;
				if ((result = this._PlaybackRange) == null)
				{
					result = (this._PlaybackRange = new FMovieSceneFrameRange(base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_PlaybackRange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFrameRange.StaticStruct(), base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_PlaybackRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170084B5 RID: 33973
		// (get) Token: 0x0602273D RID: 141117 RVA: 0x0032F442 File Offset: 0x0032D642
		// (set) Token: 0x0602273E RID: 141118 RVA: 0x0032F456 File Offset: 0x0032D656
		public unsafe FFrameRate TickResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_TickResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_TickResolution) = value;
			}
		}

		// Token: 0x170084B6 RID: 33974
		// (get) Token: 0x0602273F RID: 141119 RVA: 0x0032F46B File Offset: 0x0032D66B
		// (set) Token: 0x06022740 RID: 141120 RVA: 0x0032F47F File Offset: 0x0032D67F
		public unsafe FFrameRate DisplayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_DisplayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_DisplayRate) = value;
			}
		}

		// Token: 0x170084B7 RID: 33975
		// (get) Token: 0x06022741 RID: 141121 RVA: 0x0032F494 File Offset: 0x0032D694
		// (set) Token: 0x06022742 RID: 141122 RVA: 0x0032F4A4 File Offset: 0x0032D6A4
		public unsafe EMovieSceneEvaluationType EvaluationType
		{
			get
			{
				return (EMovieSceneEvaluationType)(*(base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_EvaluationType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_EvaluationType) = (byte)value;
			}
		}

		// Token: 0x170084B8 RID: 33976
		// (get) Token: 0x06022743 RID: 141123 RVA: 0x0032F4B5 File Offset: 0x0032D6B5
		// (set) Token: 0x06022744 RID: 141124 RVA: 0x0032F4C5 File Offset: 0x0032D6C5
		public unsafe EUpdateClockSource ClockSource
		{
			get
			{
				return (EUpdateClockSource)(*(base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_ClockSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_ClockSource) = (byte)value;
			}
		}

		// Token: 0x170084B9 RID: 33977
		// (get) Token: 0x06022745 RID: 141125 RVA: 0x0032F4D8 File Offset: 0x0032D6D8
		// (set) Token: 0x06022746 RID: 141126 RVA: 0x0032F511 File Offset: 0x0032D711
		public FSoftObjectPath CustomClockSourcePath
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._CustomClockSourcePath) == null)
				{
					result = (this._CustomClockSourcePath = new FSoftObjectPath(base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_CustomClockSourcePath, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_CustomClockSourcePath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170084BA RID: 33978
		// (get) Token: 0x06022747 RID: 141127 RVA: 0x0032F534 File Offset: 0x0032D734
		// (set) Token: 0x06022748 RID: 141128 RVA: 0x0032F56D File Offset: 0x0032D76D
		public TArray<FMovieSceneMarkedFrame> MarkedFrames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneMarkedFrame> result;
				if ((result = this._MarkedFrames) == null)
				{
					result = (this._MarkedFrames = new TArray<FMovieSceneMarkedFrame>(base.NativePtr + (IntPtr)UMovieScene.__PropertyOffset_MarkedFrames, this));
				}
				return result;
			}
			set
			{
				this.MarkedFrames.CopyAssign(value);
			}
		}

		// Token: 0x06022749 RID: 141129 RVA: 0x0032F57B File Offset: 0x0032D77B
		public TArray<FName> AllTrackTags()
		{
			return new TArray<FName>(UMovieScene.__AllTrackTags_Internal(base.NativePtr), null);
		}

		// Token: 0x0602274A RID: 141130 RVA: 0x0032F58E File Offset: 0x0032D78E
		public TArray<FName> AllTags()
		{
			return new TArray<FName>(UMovieScene.__AllTags_Internal(base.NativePtr), null);
		}

		// Token: 0x0602274B RID: 141131
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AllTrackTags_Internal(IntPtr @this);

		// Token: 0x0602274C RID: 141132
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AllTags_Internal(IntPtr @this);

		// Token: 0x0602274D RID: 141133 RVA: 0x0032F5A1 File Offset: 0x0032D7A1
		static UMovieScene()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieScene");
		}

		// Token: 0x0602274E RID: 141134 RVA: 0x0032F5AF File Offset: 0x0032D7AF
		protected UMovieScene(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012690 RID: 75408
		public new const string __ObjectPath = "/Script/MovieScene.MovieScene";

		// Token: 0x04012691 RID: 75409
		private static IntPtr _ClassPtr;

		// Token: 0x04012692 RID: 75410
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012693 RID: 75411
		internal static int __PropertyOffset_Spawnables;

		// Token: 0x04012694 RID: 75412
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneSpawnable> _Spawnables;

		// Token: 0x04012695 RID: 75413
		internal static int __PropertyOffset_Possessables;

		// Token: 0x04012696 RID: 75414
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieScenePossessable> _Possessables;

		// Token: 0x04012697 RID: 75415
		internal static int __PropertyOffset_ObjectBindings;

		// Token: 0x04012698 RID: 75416
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneBinding> _ObjectBindings;

		// Token: 0x04012699 RID: 75417
		internal static int __PropertyOffset_BindingGroups;

		// Token: 0x0401269A RID: 75418
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FMovieSceneObjectBindingIDs> _BindingGroups;

		// Token: 0x0401269B RID: 75419
		internal static int __PropertyOffset_MasterTracks;

		// Token: 0x0401269C RID: 75420
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneTrack> _MasterTracks;

		// Token: 0x0401269D RID: 75421
		internal static int __PropertyOffset_MasterTracksGroups;

		// Token: 0x0401269E RID: 75422
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FMovieSceneMasterTracks> _MasterTracksGroups;

		// Token: 0x0401269F RID: 75423
		internal static int __PropertyOffset_CameraCutTrack;

		// Token: 0x040126A0 RID: 75424
		internal static int __PropertyOffset_SelectionRange;

		// Token: 0x040126A1 RID: 75425
		[Nullable(2)]
		private FMovieSceneFrameRange _SelectionRange;

		// Token: 0x040126A2 RID: 75426
		internal static int __PropertyOffset_PlaybackRange;

		// Token: 0x040126A3 RID: 75427
		[Nullable(2)]
		private FMovieSceneFrameRange _PlaybackRange;

		// Token: 0x040126A4 RID: 75428
		internal static int __PropertyOffset_TickResolution;

		// Token: 0x040126A5 RID: 75429
		internal static int __PropertyOffset_DisplayRate;

		// Token: 0x040126A6 RID: 75430
		internal static int __PropertyOffset_EvaluationType;

		// Token: 0x040126A7 RID: 75431
		internal static int __PropertyOffset_ClockSource;

		// Token: 0x040126A8 RID: 75432
		internal static int __PropertyOffset_CustomClockSourcePath;

		// Token: 0x040126A9 RID: 75433
		[Nullable(2)]
		private FSoftObjectPath _CustomClockSourcePath;

		// Token: 0x040126AA RID: 75434
		internal static int __PropertyOffset_MarkedFrames;

		// Token: 0x040126AB RID: 75435
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneMarkedFrame> _MarkedFrames;
	}
}
