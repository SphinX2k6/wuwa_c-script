using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000779 RID: 1913
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieScene")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class UMovieScene : UMovieSceneSignedObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A560 RID: 42336 RVA: 0x000F440A File Offset: 0x000F260A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScene._ClassPtr;
		}

		// Token: 0x0600A561 RID: 42337 RVA: 0x000F4418 File Offset: 0x000F2618
		public UMovieScene() : this(BuiltinUtils.AllocNativeUObject(UMovieScene.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A562 RID: 42338 RVA: 0x000F4440 File Offset: 0x000F2640
		public UMovieScene(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScene.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x0600A563 RID: 42339 RVA: 0x000F4474 File Offset: 0x000F2674
		// (set) Token: 0x0600A564 RID: 42340 RVA: 0x000F44AD File Offset: 0x000F26AD
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

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x0600A565 RID: 42341 RVA: 0x000F44BC File Offset: 0x000F26BC
		// (set) Token: 0x0600A566 RID: 42342 RVA: 0x000F44F5 File Offset: 0x000F26F5
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

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x0600A567 RID: 42343 RVA: 0x000F4504 File Offset: 0x000F2704
		// (set) Token: 0x0600A568 RID: 42344 RVA: 0x000F453D File Offset: 0x000F273D
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

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x0600A569 RID: 42345 RVA: 0x000F454C File Offset: 0x000F274C
		// (set) Token: 0x0600A56A RID: 42346 RVA: 0x000F4585 File Offset: 0x000F2785
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

		// Token: 0x17001EAC RID: 7852
		// (get) Token: 0x0600A56B RID: 42347 RVA: 0x000F4594 File Offset: 0x000F2794
		// (set) Token: 0x0600A56C RID: 42348 RVA: 0x000F45CD File Offset: 0x000F27CD
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

		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x0600A56D RID: 42349 RVA: 0x000F45DB File Offset: 0x000F27DB
		// (set) Token: 0x0600A56E RID: 42350 RVA: 0x000F45EF File Offset: 0x000F27EF
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

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x0600A56F RID: 42351 RVA: 0x000F4604 File Offset: 0x000F2804
		// (set) Token: 0x0600A570 RID: 42352 RVA: 0x000F4618 File Offset: 0x000F2818
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

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x0600A571 RID: 42353 RVA: 0x000F462D File Offset: 0x000F282D
		// (set) Token: 0x0600A572 RID: 42354 RVA: 0x000F4641 File Offset: 0x000F2841
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

		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x0600A573 RID: 42355 RVA: 0x000F4658 File Offset: 0x000F2858
		// (set) Token: 0x0600A574 RID: 42356 RVA: 0x000F4691 File Offset: 0x000F2891
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

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x0600A575 RID: 42357 RVA: 0x000F46B4 File Offset: 0x000F28B4
		// (set) Token: 0x0600A576 RID: 42358 RVA: 0x000F46ED File Offset: 0x000F28ED
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

		// Token: 0x0600A577 RID: 42359 RVA: 0x000F46FB File Offset: 0x000F28FB
		public TArray<FName> AllTrackTags()
		{
			return new TArray<FName>(UMovieScene.__AllTrackTags_Internal(base.NativePtr), null);
		}

		// Token: 0x0600A578 RID: 42360 RVA: 0x000F470E File Offset: 0x000F290E
		public TArray<FName> AllTags()
		{
			return new TArray<FName>(UMovieScene.__AllTags_Internal(base.NativePtr), null);
		}

		// Token: 0x0600A579 RID: 42361
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AllTrackTags_Internal(IntPtr @this);

		// Token: 0x0600A57A RID: 42362
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AllTags_Internal(IntPtr @this);

		// Token: 0x0600A57B RID: 42363 RVA: 0x000F4721 File Offset: 0x000F2921
		static UMovieScene()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieScene");
		}

		// Token: 0x0600A57C RID: 42364 RVA: 0x000F472F File Offset: 0x000F292F
		protected UMovieScene(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040046BF RID: 18111
		public new const string __ObjectPath = "/Script/MovieScene.MovieScene";

		// Token: 0x040046C0 RID: 18112
		private static IntPtr _ClassPtr;

		// Token: 0x040046C1 RID: 18113
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040046C2 RID: 18114
		internal static int __PropertyOffset_Spawnables;

		// Token: 0x040046C3 RID: 18115
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneSpawnable> _Spawnables;

		// Token: 0x040046C4 RID: 18116
		internal static int __PropertyOffset_Possessables;

		// Token: 0x040046C5 RID: 18117
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieScenePossessable> _Possessables;

		// Token: 0x040046C6 RID: 18118
		internal static int __PropertyOffset_ObjectBindings;

		// Token: 0x040046C7 RID: 18119
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneBinding> _ObjectBindings;

		// Token: 0x040046C8 RID: 18120
		internal static int __PropertyOffset_BindingGroups;

		// Token: 0x040046C9 RID: 18121
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FMovieSceneObjectBindingIDs> _BindingGroups;

		// Token: 0x040046CA RID: 18122
		internal static int __PropertyOffset_MasterTracks;

		// Token: 0x040046CB RID: 18123
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneTrack> _MasterTracks;

		// Token: 0x040046CC RID: 18124
		internal static int __PropertyOffset_CameraCutTrack;

		// Token: 0x040046CD RID: 18125
		internal static int __PropertyOffset_TickResolution;

		// Token: 0x040046CE RID: 18126
		internal static int __PropertyOffset_DisplayRate;

		// Token: 0x040046CF RID: 18127
		internal static int __PropertyOffset_CustomClockSourcePath;

		// Token: 0x040046D0 RID: 18128
		[Nullable(2)]
		private FSoftObjectPath _CustomClockSourcePath;

		// Token: 0x040046D1 RID: 18129
		internal static int __PropertyOffset_MarkedFrames;

		// Token: 0x040046D2 RID: 18130
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneMarkedFrame> _MarkedFrames;
	}
}
