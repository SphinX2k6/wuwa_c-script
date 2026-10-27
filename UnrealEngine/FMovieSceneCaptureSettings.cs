using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002314 RID: 8980
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneCapture.MovieSceneCaptureSettings")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FMovieSceneCaptureSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021FE4 RID: 139236 RVA: 0x00324311 File Offset: 0x00322511
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneCaptureSettings._ScriptStructPtr != 0) ? FMovieSceneCaptureSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneCapture.MovieSceneCaptureSettings", ref FMovieSceneCaptureSettings._ScriptStructPtr);
		}

		// Token: 0x17008359 RID: 33625
		// (get) Token: 0x06021FE5 RID: 139237 RVA: 0x00324338 File Offset: 0x00322538
		// (set) Token: 0x06021FE6 RID: 139238 RVA: 0x0032437B File Offset: 0x0032257B
		public FDirectoryPath OutputDirectory
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._OutputDirectory) == null)
				{
					result = (this._OutputDirectory = new FDirectoryPath(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_OutputDirectory, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_OutputDirectory, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700835A RID: 33626
		// (get) Token: 0x06021FE7 RID: 139239 RVA: 0x0032439C File Offset: 0x0032259C
		// (set) Token: 0x06021FE8 RID: 139240 RVA: 0x003243B0 File Offset: 0x003225B0
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AGameModeBase> GameModeOverride
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_GameModeOverride);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_GameModeOverride) = value;
			}
		}

		// Token: 0x1700835B RID: 33627
		// (get) Token: 0x06021FE9 RID: 139241 RVA: 0x003243C5 File Offset: 0x003225C5
		// (set) Token: 0x06021FEA RID: 139242 RVA: 0x003243D9 File Offset: 0x003225D9
		public unsafe string OutputFormat
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_OutputFormat)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_OutputFormat)), value);
			}
		}

		// Token: 0x1700835C RID: 33628
		// (get) Token: 0x06021FEB RID: 139243 RVA: 0x003243EE File Offset: 0x003225EE
		// (set) Token: 0x06021FEC RID: 139244 RVA: 0x003243FE File Offset: 0x003225FE
		public unsafe bool bOverwriteExisting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bOverwriteExisting) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bOverwriteExisting) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700835D RID: 33629
		// (get) Token: 0x06021FED RID: 139245 RVA: 0x0032440F File Offset: 0x0032260F
		// (set) Token: 0x06021FEE RID: 139246 RVA: 0x0032441F File Offset: 0x0032261F
		public unsafe bool bUseRelativeFrameNumbers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bUseRelativeFrameNumbers) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bUseRelativeFrameNumbers) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700835E RID: 33630
		// (get) Token: 0x06021FEF RID: 139247 RVA: 0x00324430 File Offset: 0x00322630
		// (set) Token: 0x06021FF0 RID: 139248 RVA: 0x00324440 File Offset: 0x00322640
		public unsafe int HandleFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_HandleFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_HandleFrames) = value;
			}
		}

		// Token: 0x1700835F RID: 33631
		// (get) Token: 0x06021FF1 RID: 139249 RVA: 0x00324451 File Offset: 0x00322651
		// (set) Token: 0x06021FF2 RID: 139250 RVA: 0x00324465 File Offset: 0x00322665
		public unsafe string MovieExtension
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_MovieExtension)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_MovieExtension)), value);
			}
		}

		// Token: 0x17008360 RID: 33632
		// (get) Token: 0x06021FF3 RID: 139251 RVA: 0x0032447A File Offset: 0x0032267A
		// (set) Token: 0x06021FF4 RID: 139252 RVA: 0x0032448A File Offset: 0x0032268A
		public unsafe byte ZeroPadFrameNumbers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_ZeroPadFrameNumbers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_ZeroPadFrameNumbers) = value;
			}
		}

		// Token: 0x17008361 RID: 33633
		// (get) Token: 0x06021FF5 RID: 139253 RVA: 0x0032449B File Offset: 0x0032269B
		// (set) Token: 0x06021FF6 RID: 139254 RVA: 0x003244AF File Offset: 0x003226AF
		public unsafe FFrameRate FrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_FrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_FrameRate) = value;
			}
		}

		// Token: 0x17008362 RID: 33634
		// (get) Token: 0x06021FF7 RID: 139255 RVA: 0x003244C4 File Offset: 0x003226C4
		// (set) Token: 0x06021FF8 RID: 139256 RVA: 0x003244D4 File Offset: 0x003226D4
		public unsafe bool bUseCustomFrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bUseCustomFrameRate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bUseCustomFrameRate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008363 RID: 33635
		// (get) Token: 0x06021FF9 RID: 139257 RVA: 0x003244E5 File Offset: 0x003226E5
		// (set) Token: 0x06021FFA RID: 139258 RVA: 0x003244F9 File Offset: 0x003226F9
		public unsafe FFrameRate CustomFrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_CustomFrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_CustomFrameRate) = value;
			}
		}

		// Token: 0x17008364 RID: 33636
		// (get) Token: 0x06021FFB RID: 139259 RVA: 0x00324510 File Offset: 0x00322710
		// (set) Token: 0x06021FFC RID: 139260 RVA: 0x00324553 File Offset: 0x00322753
		public FCaptureResolution Resolution
		{
			get
			{
				base.FastCheckIsValid();
				FCaptureResolution result;
				if ((result = this._Resolution) == null)
				{
					result = (this._Resolution = new FCaptureResolution(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_Resolution, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCaptureResolution.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_Resolution, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008365 RID: 33637
		// (get) Token: 0x06021FFD RID: 139261 RVA: 0x00324574 File Offset: 0x00322774
		// (set) Token: 0x06021FFE RID: 139262 RVA: 0x00324584 File Offset: 0x00322784
		public unsafe bool bEnableTextureStreaming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bEnableTextureStreaming) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bEnableTextureStreaming) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008366 RID: 33638
		// (get) Token: 0x06021FFF RID: 139263 RVA: 0x00324595 File Offset: 0x00322795
		// (set) Token: 0x06022000 RID: 139264 RVA: 0x003245A5 File Offset: 0x003227A5
		public unsafe bool bCinematicEngineScalability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bCinematicEngineScalability) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bCinematicEngineScalability) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008367 RID: 33639
		// (get) Token: 0x06022001 RID: 139265 RVA: 0x003245B6 File Offset: 0x003227B6
		// (set) Token: 0x06022002 RID: 139266 RVA: 0x003245C6 File Offset: 0x003227C6
		public unsafe bool bCinematicMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bCinematicMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bCinematicMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008368 RID: 33640
		// (get) Token: 0x06022003 RID: 139267 RVA: 0x003245D7 File Offset: 0x003227D7
		// (set) Token: 0x06022004 RID: 139268 RVA: 0x003245E7 File Offset: 0x003227E7
		public unsafe bool bAllowMovement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bAllowMovement) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bAllowMovement) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008369 RID: 33641
		// (get) Token: 0x06022005 RID: 139269 RVA: 0x003245F8 File Offset: 0x003227F8
		// (set) Token: 0x06022006 RID: 139270 RVA: 0x00324608 File Offset: 0x00322808
		public unsafe bool bAllowTurning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bAllowTurning) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bAllowTurning) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700836A RID: 33642
		// (get) Token: 0x06022007 RID: 139271 RVA: 0x00324619 File Offset: 0x00322819
		// (set) Token: 0x06022008 RID: 139272 RVA: 0x00324629 File Offset: 0x00322829
		public unsafe bool bShowPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bShowPlayer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bShowPlayer) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700836B RID: 33643
		// (get) Token: 0x06022009 RID: 139273 RVA: 0x0032463A File Offset: 0x0032283A
		// (set) Token: 0x0602200A RID: 139274 RVA: 0x0032464A File Offset: 0x0032284A
		public unsafe bool bShowHUD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bShowHUD) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bShowHUD) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700836C RID: 33644
		// (get) Token: 0x0602200B RID: 139275 RVA: 0x0032465B File Offset: 0x0032285B
		// (set) Token: 0x0602200C RID: 139276 RVA: 0x0032466B File Offset: 0x0032286B
		public unsafe bool bUsePathTracer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bUsePathTracer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_bUsePathTracer) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700836D RID: 33645
		// (get) Token: 0x0602200D RID: 139277 RVA: 0x0032467C File Offset: 0x0032287C
		// (set) Token: 0x0602200E RID: 139278 RVA: 0x0032468C File Offset: 0x0032288C
		public unsafe int PathTracerSamplePerPixel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_PathTracerSamplePerPixel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneCaptureSettings.__PropertyOffset_PathTracerSamplePerPixel) = value;
			}
		}

		// Token: 0x0602200F RID: 139279 RVA: 0x0032469D File Offset: 0x0032289D
		public FMovieSceneCaptureSettings()
		{
		}

		// Token: 0x06022010 RID: 139280 RVA: 0x003246A8 File Offset: 0x003228A8
		public FMovieSceneCaptureSettings(FDirectoryPath OutputDirectory, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AGameModeBase> GameModeOverride, string OutputFormat, bool bOverwriteExisting, bool bUseRelativeFrameNumbers, int HandleFrames, string MovieExtension, byte ZeroPadFrameNumbers, FFrameRate FrameRate, bool bUseCustomFrameRate, FFrameRate CustomFrameRate, FCaptureResolution Resolution, bool bEnableTextureStreaming, bool bCinematicEngineScalability, bool bCinematicMode, bool bAllowMovement, bool bAllowTurning, bool bShowPlayer, bool bShowHUD, bool bUsePathTracer, int PathTracerSamplePerPixel)
		{
			this.OutputDirectory = OutputDirectory;
			this.GameModeOverride = GameModeOverride;
			this.OutputFormat = OutputFormat;
			this.bOverwriteExisting = bOverwriteExisting;
			this.bUseRelativeFrameNumbers = bUseRelativeFrameNumbers;
			this.HandleFrames = HandleFrames;
			this.MovieExtension = MovieExtension;
			this.ZeroPadFrameNumbers = ZeroPadFrameNumbers;
			this.FrameRate = FrameRate;
			this.bUseCustomFrameRate = bUseCustomFrameRate;
			this.CustomFrameRate = CustomFrameRate;
			this.Resolution = Resolution;
			this.bEnableTextureStreaming = bEnableTextureStreaming;
			this.bCinematicEngineScalability = bCinematicEngineScalability;
			this.bCinematicMode = bCinematicMode;
			this.bAllowMovement = bAllowMovement;
			this.bAllowTurning = bAllowTurning;
			this.bShowPlayer = bShowPlayer;
			this.bShowHUD = bShowHUD;
			this.bUsePathTracer = bUsePathTracer;
			this.PathTracerSamplePerPixel = PathTracerSamplePerPixel;
		}

		// Token: 0x06022011 RID: 139281 RVA: 0x00324760 File Offset: 0x00322960
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneCaptureSettings.StaticStruct();
		}

		// Token: 0x06022012 RID: 139282 RVA: 0x0032476C File Offset: 0x0032296C
		[NullableContext(2)]
		public FMovieSceneCaptureSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022013 RID: 139283 RVA: 0x00324776 File Offset: 0x00322976
		public FMovieSceneCaptureSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022014 RID: 139284 RVA: 0x00324781 File Offset: 0x00322981
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneCaptureSettings(Pointer, false, true);
		}

		// Token: 0x06022015 RID: 139285 RVA: 0x0032478B File Offset: 0x0032298B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneCaptureSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04012221 RID: 74273
		public const string __ObjectPath = "/Script/MovieSceneCapture.MovieSceneCaptureSettings";

		// Token: 0x04012222 RID: 74274
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012223 RID: 74275
		internal static int __PropertyOffset_OutputDirectory;

		// Token: 0x04012224 RID: 74276
		[Nullable(2)]
		private FDirectoryPath _OutputDirectory;

		// Token: 0x04012225 RID: 74277
		internal static int __PropertyOffset_GameModeOverride;

		// Token: 0x04012226 RID: 74278
		internal static int __PropertyOffset_OutputFormat;

		// Token: 0x04012227 RID: 74279
		internal static int __PropertyOffset_bOverwriteExisting;

		// Token: 0x04012228 RID: 74280
		internal static int __PropertyOffset_bUseRelativeFrameNumbers;

		// Token: 0x04012229 RID: 74281
		internal static int __PropertyOffset_HandleFrames;

		// Token: 0x0401222A RID: 74282
		internal static int __PropertyOffset_MovieExtension;

		// Token: 0x0401222B RID: 74283
		internal static int __PropertyOffset_ZeroPadFrameNumbers;

		// Token: 0x0401222C RID: 74284
		internal static int __PropertyOffset_FrameRate;

		// Token: 0x0401222D RID: 74285
		internal static int __PropertyOffset_bUseCustomFrameRate;

		// Token: 0x0401222E RID: 74286
		internal static int __PropertyOffset_CustomFrameRate;

		// Token: 0x0401222F RID: 74287
		internal static int __PropertyOffset_Resolution;

		// Token: 0x04012230 RID: 74288
		[Nullable(2)]
		private FCaptureResolution _Resolution;

		// Token: 0x04012231 RID: 74289
		internal static int __PropertyOffset_bEnableTextureStreaming;

		// Token: 0x04012232 RID: 74290
		internal static int __PropertyOffset_bCinematicEngineScalability;

		// Token: 0x04012233 RID: 74291
		internal static int __PropertyOffset_bCinematicMode;

		// Token: 0x04012234 RID: 74292
		internal static int __PropertyOffset_bAllowMovement;

		// Token: 0x04012235 RID: 74293
		internal static int __PropertyOffset_bAllowTurning;

		// Token: 0x04012236 RID: 74294
		internal static int __PropertyOffset_bShowPlayer;

		// Token: 0x04012237 RID: 74295
		internal static int __PropertyOffset_bShowHUD;

		// Token: 0x04012238 RID: 74296
		internal static int __PropertyOffset_bUsePathTracer;

		// Token: 0x04012239 RID: 74297
		internal static int __PropertyOffset_PathTracerSamplePerPixel;
	}
}
