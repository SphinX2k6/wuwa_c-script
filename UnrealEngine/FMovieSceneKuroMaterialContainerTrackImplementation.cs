using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C02 RID: 7170
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialContainerTrackImplementation")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FMovieSceneKuroMaterialContainerTrackImplementation : FMovieSceneTrackImplementation, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BABC RID: 113340 RVA: 0x0028B952 File Offset: 0x00289B52
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneKuroMaterialContainerTrackImplementation._ScriptStructPtr != 0) ? FMovieSceneKuroMaterialContainerTrackImplementation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialContainerTrackImplementation", ref FMovieSceneKuroMaterialContainerTrackImplementation._ScriptStructPtr);
		}

		// Token: 0x17006F9C RID: 28572
		// (get) Token: 0x0601BABD RID: 113341 RVA: 0x0028B978 File Offset: 0x00289B78
		// (set) Token: 0x0601BABE RID: 113342 RVA: 0x0028B9BB File Offset: 0x00289BBB
		public FFrameNumber SectionStartFrame
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._SectionStartFrame) == null)
				{
					result = (this._SectionStartFrame = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialContainerTrackImplementation.__PropertyOffset_SectionStartFrame, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneKuroMaterialContainerTrackImplementation.__PropertyOffset_SectionStartFrame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006F9D RID: 28573
		// (get) Token: 0x0601BABF RID: 113343 RVA: 0x0028B9DC File Offset: 0x00289BDC
		// (set) Token: 0x0601BAC0 RID: 113344 RVA: 0x0028BA1F File Offset: 0x00289C1F
		public FFrameNumber SectionEndFrame
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._SectionEndFrame) == null)
				{
					result = (this._SectionEndFrame = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialContainerTrackImplementation.__PropertyOffset_SectionEndFrame, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneKuroMaterialContainerTrackImplementation.__PropertyOffset_SectionEndFrame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006F9E RID: 28574
		// (get) Token: 0x0601BAC1 RID: 113345 RVA: 0x0028BA40 File Offset: 0x00289C40
		// (set) Token: 0x0601BAC2 RID: 113346 RVA: 0x0028BA54 File Offset: 0x00289C54
		[Nullable(2)]
		public unsafe UKuroMaterialControllerDataAsset MaterialDataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneKuroMaterialContainerTrackImplementation.__PropertyOffset_MaterialDataAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneKuroMaterialContainerTrackImplementation.__PropertyOffset_MaterialDataAsset, value);
			}
		}

		// Token: 0x17006F9F RID: 28575
		// (get) Token: 0x0601BAC3 RID: 113347 RVA: 0x0028BA6C File Offset: 0x00289C6C
		// (set) Token: 0x0601BAC4 RID: 113348 RVA: 0x0028BAAF File Offset: 0x00289CAF
		public TArray<UKuroMaterialControllerDataAsset> MaterialDataAssetExtra
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroMaterialControllerDataAsset> result;
				if ((result = this._MaterialDataAssetExtra) == null)
				{
					result = (this._MaterialDataAssetExtra = new TArray<UKuroMaterialControllerDataAsset>(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialContainerTrackImplementation.__PropertyOffset_MaterialDataAssetExtra, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialDataAssetExtra.CopyAssign(value);
			}
		}

		// Token: 0x17006FA0 RID: 28576
		// (get) Token: 0x0601BAC5 RID: 113349 RVA: 0x0028BABD File Offset: 0x00289CBD
		// (set) Token: 0x0601BAC6 RID: 113350 RVA: 0x0028BAD1 File Offset: 0x00289CD1
		public unsafe FName TrackObjectName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialContainerTrackImplementation.__PropertyOffset_TrackObjectName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialContainerTrackImplementation.__PropertyOffset_TrackObjectName) = value;
			}
		}

		// Token: 0x17006FA1 RID: 28577
		// (get) Token: 0x0601BAC7 RID: 113351 RVA: 0x0028BAE6 File Offset: 0x00289CE6
		// (set) Token: 0x0601BAC8 RID: 113352 RVA: 0x0028BAF6 File Offset: 0x00289CF6
		public unsafe bool bLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialContainerTrackImplementation.__PropertyOffset_bLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialContainerTrackImplementation.__PropertyOffset_bLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006FA2 RID: 28578
		// (get) Token: 0x0601BAC9 RID: 113353 RVA: 0x0028BB07 File Offset: 0x00289D07
		// (set) Token: 0x0601BACA RID: 113354 RVA: 0x0028BB17 File Offset: 0x00289D17
		public unsafe bool bEndImmediate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialContainerTrackImplementation.__PropertyOffset_bEndImmediate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialContainerTrackImplementation.__PropertyOffset_bEndImmediate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006FA3 RID: 28579
		// (get) Token: 0x0601BACB RID: 113355 RVA: 0x0028BB28 File Offset: 0x00289D28
		// (set) Token: 0x0601BACC RID: 113356 RVA: 0x0028BB38 File Offset: 0x00289D38
		public unsafe bool bSkipToEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialContainerTrackImplementation.__PropertyOffset_bSkipToEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialContainerTrackImplementation.__PropertyOffset_bSkipToEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006FA4 RID: 28580
		// (get) Token: 0x0601BACD RID: 113357 RVA: 0x0028BB49 File Offset: 0x00289D49
		// (set) Token: 0x0601BACE RID: 113358 RVA: 0x0028BB59 File Offset: 0x00289D59
		public unsafe bool bApplyOnChildActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialContainerTrackImplementation.__PropertyOffset_bApplyOnChildActor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneKuroMaterialContainerTrackImplementation.__PropertyOffset_bApplyOnChildActor) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601BACF RID: 113359 RVA: 0x0028BB6A File Offset: 0x00289D6A
		public FMovieSceneKuroMaterialContainerTrackImplementation()
		{
		}

		// Token: 0x0601BAD0 RID: 113360 RVA: 0x0028BB74 File Offset: 0x00289D74
		public FMovieSceneKuroMaterialContainerTrackImplementation(FFrameNumber SectionStartFrame, FFrameNumber SectionEndFrame, UKuroMaterialControllerDataAsset MaterialDataAsset, TArray<UKuroMaterialControllerDataAsset> MaterialDataAssetExtra, FName TrackObjectName, bool bLoop, bool bEndImmediate, bool bSkipToEnd, bool bApplyOnChildActor)
		{
			this.SectionStartFrame = SectionStartFrame;
			this.SectionEndFrame = SectionEndFrame;
			this.MaterialDataAsset = MaterialDataAsset;
			this.MaterialDataAssetExtra = MaterialDataAssetExtra;
			this.TrackObjectName = TrackObjectName;
			this.bLoop = bLoop;
			this.bEndImmediate = bEndImmediate;
			this.bSkipToEnd = bSkipToEnd;
			this.bApplyOnChildActor = bApplyOnChildActor;
		}

		// Token: 0x0601BAD1 RID: 113361 RVA: 0x0028BBCC File Offset: 0x00289DCC
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneKuroMaterialContainerTrackImplementation.StaticStruct();
		}

		// Token: 0x0601BAD2 RID: 113362 RVA: 0x0028BBD8 File Offset: 0x00289DD8
		[NullableContext(2)]
		public FMovieSceneKuroMaterialContainerTrackImplementation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BAD3 RID: 113363 RVA: 0x0028BBE2 File Offset: 0x00289DE2
		public FMovieSceneKuroMaterialContainerTrackImplementation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BAD4 RID: 113364 RVA: 0x0028BBED File Offset: 0x00289DED
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneKuroMaterialContainerTrackImplementation(Pointer, false, true);
		}

		// Token: 0x0601BAD5 RID: 113365 RVA: 0x0028BBF7 File Offset: 0x00289DF7
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneKuroMaterialContainerTrackImplementation(Pointer, MemoryOwner);
		}

		// Token: 0x0400EE1B RID: 60955
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialContainerTrackImplementation";

		// Token: 0x0400EE1C RID: 60956
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EE1D RID: 60957
		internal static int __PropertyOffset_SectionStartFrame;

		// Token: 0x0400EE1E RID: 60958
		[Nullable(2)]
		private FFrameNumber _SectionStartFrame;

		// Token: 0x0400EE1F RID: 60959
		internal static int __PropertyOffset_SectionEndFrame;

		// Token: 0x0400EE20 RID: 60960
		[Nullable(2)]
		private FFrameNumber _SectionEndFrame;

		// Token: 0x0400EE21 RID: 60961
		internal static int __PropertyOffset_MaterialDataAsset;

		// Token: 0x0400EE22 RID: 60962
		internal static int __PropertyOffset_MaterialDataAssetExtra;

		// Token: 0x0400EE23 RID: 60963
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroMaterialControllerDataAsset> _MaterialDataAssetExtra;

		// Token: 0x0400EE24 RID: 60964
		internal static int __PropertyOffset_TrackObjectName;

		// Token: 0x0400EE25 RID: 60965
		internal static int __PropertyOffset_bLoop;

		// Token: 0x0400EE26 RID: 60966
		internal static int __PropertyOffset_bEndImmediate;

		// Token: 0x0400EE27 RID: 60967
		internal static int __PropertyOffset_bSkipToEnd;

		// Token: 0x0400EE28 RID: 60968
		internal static int __PropertyOffset_bApplyOnChildActor;
	}
}
