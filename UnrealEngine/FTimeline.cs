using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011EA RID: 4586
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Timeline")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FTimeline : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010E39 RID: 69177 RVA: 0x0018CC2D File Offset: 0x0018AE2D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTimeline._ScriptStructPtr != 0) ? FTimeline._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.Timeline", ref FTimeline._ScriptStructPtr);
		}

		// Token: 0x17004201 RID: 16897
		// (get) Token: 0x06010E3A RID: 69178 RVA: 0x0018CC51 File Offset: 0x0018AE51
		// (set) Token: 0x06010E3B RID: 69179 RVA: 0x0018CC65 File Offset: 0x0018AE65
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineLengthMode> LengthMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_LengthMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_LengthMode) = value;
			}
		}

		// Token: 0x17004202 RID: 16898
		// (get) Token: 0x06010E3C RID: 69180 RVA: 0x0018CC7A File Offset: 0x0018AE7A
		// (set) Token: 0x06010E3D RID: 69181 RVA: 0x0018CC93 File Offset: 0x0018AE93
		public unsafe bool bLooping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_bLooping) & FTimeline.__PropertyMask_bLooping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FTimeline.__PropertyOffset_bLooping) = ((*(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_bLooping) & ~FTimeline.__PropertyMask_bLooping) | (value ? FTimeline.__PropertyMask_bLooping : 0));
			}
		}

		// Token: 0x17004203 RID: 16899
		// (get) Token: 0x06010E3E RID: 69182 RVA: 0x0018CCC3 File Offset: 0x0018AEC3
		// (set) Token: 0x06010E3F RID: 69183 RVA: 0x0018CCDC File Offset: 0x0018AEDC
		public unsafe bool bReversePlayback
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_bReversePlayback) & FTimeline.__PropertyMask_bReversePlayback) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FTimeline.__PropertyOffset_bReversePlayback) = ((*(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_bReversePlayback) & ~FTimeline.__PropertyMask_bReversePlayback) | (value ? FTimeline.__PropertyMask_bReversePlayback : 0));
			}
		}

		// Token: 0x17004204 RID: 16900
		// (get) Token: 0x06010E40 RID: 69184 RVA: 0x0018CD0C File Offset: 0x0018AF0C
		// (set) Token: 0x06010E41 RID: 69185 RVA: 0x0018CD25 File Offset: 0x0018AF25
		public unsafe bool bPlaying
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_bPlaying) & FTimeline.__PropertyMask_bPlaying) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FTimeline.__PropertyOffset_bPlaying) = ((*(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_bPlaying) & ~FTimeline.__PropertyMask_bPlaying) | (value ? FTimeline.__PropertyMask_bPlaying : 0));
			}
		}

		// Token: 0x17004205 RID: 16901
		// (get) Token: 0x06010E42 RID: 69186 RVA: 0x0018CD55 File Offset: 0x0018AF55
		// (set) Token: 0x06010E43 RID: 69187 RVA: 0x0018CD65 File Offset: 0x0018AF65
		public unsafe float Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_Length);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_Length) = value;
			}
		}

		// Token: 0x17004206 RID: 16902
		// (get) Token: 0x06010E44 RID: 69188 RVA: 0x0018CD76 File Offset: 0x0018AF76
		// (set) Token: 0x06010E45 RID: 69189 RVA: 0x0018CD86 File Offset: 0x0018AF86
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x17004207 RID: 16903
		// (get) Token: 0x06010E46 RID: 69190 RVA: 0x0018CD97 File Offset: 0x0018AF97
		// (set) Token: 0x06010E47 RID: 69191 RVA: 0x0018CDA7 File Offset: 0x0018AFA7
		public unsafe float Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17004208 RID: 16904
		// (get) Token: 0x06010E48 RID: 69192 RVA: 0x0018CDB8 File Offset: 0x0018AFB8
		// (set) Token: 0x06010E49 RID: 69193 RVA: 0x0018CDFB File Offset: 0x0018AFFB
		public TArray<FTimelineEventEntry> Events
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTimelineEventEntry> result;
				if ((result = this._Events) == null)
				{
					result = (this._Events = new TArray<FTimelineEventEntry>(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_Events, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Events.CopyAssign(value);
			}
		}

		// Token: 0x17004209 RID: 16905
		// (get) Token: 0x06010E4A RID: 69194 RVA: 0x0018CE0C File Offset: 0x0018B00C
		// (set) Token: 0x06010E4B RID: 69195 RVA: 0x0018CE4F File Offset: 0x0018B04F
		public TArray<FTimelineVectorTrack> InterpVectors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTimelineVectorTrack> result;
				if ((result = this._InterpVectors) == null)
				{
					result = (this._InterpVectors = new TArray<FTimelineVectorTrack>(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_InterpVectors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InterpVectors.CopyAssign(value);
			}
		}

		// Token: 0x1700420A RID: 16906
		// (get) Token: 0x06010E4C RID: 69196 RVA: 0x0018CE60 File Offset: 0x0018B060
		// (set) Token: 0x06010E4D RID: 69197 RVA: 0x0018CEA3 File Offset: 0x0018B0A3
		public TArray<FTimelineFloatTrack> InterpFloats
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTimelineFloatTrack> result;
				if ((result = this._InterpFloats) == null)
				{
					result = (this._InterpFloats = new TArray<FTimelineFloatTrack>(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_InterpFloats, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InterpFloats.CopyAssign(value);
			}
		}

		// Token: 0x1700420B RID: 16907
		// (get) Token: 0x06010E4E RID: 69198 RVA: 0x0018CEB4 File Offset: 0x0018B0B4
		// (set) Token: 0x06010E4F RID: 69199 RVA: 0x0018CEF7 File Offset: 0x0018B0F7
		public TArray<FTimelineLinearColorTrack> InterpLinearColors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTimelineLinearColorTrack> result;
				if ((result = this._InterpLinearColors) == null)
				{
					result = (this._InterpLinearColors = new TArray<FTimelineLinearColorTrack>(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_InterpLinearColors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InterpLinearColors.CopyAssign(value);
			}
		}

		// Token: 0x1700420C RID: 16908
		// (get) Token: 0x06010E50 RID: 69200 RVA: 0x0018CF08 File Offset: 0x0018B108
		// (set) Token: 0x06010E51 RID: 69201 RVA: 0x0018CF4B File Offset: 0x0018B14B
		public FOnTimelineEvent TimelinePostUpdateFunc
		{
			get
			{
				base.FastCheckIsValid();
				FOnTimelineEvent result;
				if ((result = this._TimelinePostUpdateFunc) == null)
				{
					result = (this._TimelinePostUpdateFunc = new FOnTimelineEvent(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_TimelinePostUpdateFunc, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_TimelinePostUpdateFunc, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700420D RID: 16909
		// (get) Token: 0x06010E52 RID: 69202 RVA: 0x0018CF6C File Offset: 0x0018B16C
		// (set) Token: 0x06010E53 RID: 69203 RVA: 0x0018CFAF File Offset: 0x0018B1AF
		public FOnTimelineEvent TimelineFinishedFunc
		{
			get
			{
				base.FastCheckIsValid();
				FOnTimelineEvent result;
				if ((result = this._TimelineFinishedFunc) == null)
				{
					result = (this._TimelineFinishedFunc = new FOnTimelineEvent(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_TimelineFinishedFunc, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_TimelineFinishedFunc, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700420E RID: 16910
		// (get) Token: 0x06010E54 RID: 69204 RVA: 0x0018CFD0 File Offset: 0x0018B1D0
		// (set) Token: 0x06010E55 RID: 69205 RVA: 0x0018CFE4 File Offset: 0x0018B1E4
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UObject> PropertySetObject
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_PropertySetObject);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_PropertySetObject) = value;
			}
		}

		// Token: 0x1700420F RID: 16911
		// (get) Token: 0x06010E56 RID: 69206 RVA: 0x0018CFF9 File Offset: 0x0018B1F9
		// (set) Token: 0x06010E57 RID: 69207 RVA: 0x0018D00D File Offset: 0x0018B20D
		public unsafe FName DirectionPropertyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_DirectionPropertyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTimeline.__PropertyOffset_DirectionPropertyName) = value;
			}
		}

		// Token: 0x06010E58 RID: 69208 RVA: 0x0018D022 File Offset: 0x0018B222
		public FTimeline()
		{
		}

		// Token: 0x06010E59 RID: 69209 RVA: 0x0018D02C File Offset: 0x0018B22C
		public FTimeline([Nullable(0)] TEnumAsByte<ETimelineLengthMode> LengthMode, bool bLooping, bool bReversePlayback, bool bPlaying, float Length, float PlayRate, float Position, TArray<FTimelineEventEntry> Events, TArray<FTimelineVectorTrack> InterpVectors, TArray<FTimelineFloatTrack> InterpFloats, TArray<FTimelineLinearColorTrack> InterpLinearColors, FOnTimelineEvent TimelinePostUpdateFunc, FOnTimelineEvent TimelineFinishedFunc, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UObject> PropertySetObject, FName DirectionPropertyName)
		{
			this.LengthMode = LengthMode;
			this.bLooping = bLooping;
			this.bReversePlayback = bReversePlayback;
			this.bPlaying = bPlaying;
			this.Length = Length;
			this.PlayRate = PlayRate;
			this.Position = Position;
			this.Events = Events;
			this.InterpVectors = InterpVectors;
			this.InterpFloats = InterpFloats;
			this.InterpLinearColors = InterpLinearColors;
			this.TimelinePostUpdateFunc = TimelinePostUpdateFunc;
			this.TimelineFinishedFunc = TimelineFinishedFunc;
			this.PropertySetObject = PropertySetObject;
			this.DirectionPropertyName = DirectionPropertyName;
		}

		// Token: 0x06010E5A RID: 69210 RVA: 0x0018D0B4 File Offset: 0x0018B2B4
		protected override IntPtr GetUStructPtr()
		{
			return FTimeline.StaticStruct();
		}

		// Token: 0x06010E5B RID: 69211 RVA: 0x0018D0C0 File Offset: 0x0018B2C0
		[NullableContext(2)]
		public FTimeline(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010E5C RID: 69212 RVA: 0x0018D0CA File Offset: 0x0018B2CA
		public FTimeline(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010E5D RID: 69213 RVA: 0x0018D0D5 File Offset: 0x0018B2D5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTimeline(Pointer, false, true);
		}

		// Token: 0x06010E5E RID: 69214 RVA: 0x0018D0DF File Offset: 0x0018B2DF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTimeline(Pointer, MemoryOwner);
		}

		// Token: 0x040090D1 RID: 37073
		public const string __ObjectPath = "/Script/Engine.Timeline";

		// Token: 0x040090D2 RID: 37074
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040090D3 RID: 37075
		internal static int __PropertyOffset_LengthMode;

		// Token: 0x040090D4 RID: 37076
		internal static int __PropertyOffset_bLooping;

		// Token: 0x040090D5 RID: 37077
		internal static byte __PropertyMask_bLooping;

		// Token: 0x040090D6 RID: 37078
		internal static int __PropertyOffset_bReversePlayback;

		// Token: 0x040090D7 RID: 37079
		internal static byte __PropertyMask_bReversePlayback;

		// Token: 0x040090D8 RID: 37080
		internal static int __PropertyOffset_bPlaying;

		// Token: 0x040090D9 RID: 37081
		internal static byte __PropertyMask_bPlaying;

		// Token: 0x040090DA RID: 37082
		internal static int __PropertyOffset_Length;

		// Token: 0x040090DB RID: 37083
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x040090DC RID: 37084
		internal static int __PropertyOffset_Position;

		// Token: 0x040090DD RID: 37085
		internal static int __PropertyOffset_Events;

		// Token: 0x040090DE RID: 37086
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTimelineEventEntry> _Events;

		// Token: 0x040090DF RID: 37087
		internal static int __PropertyOffset_InterpVectors;

		// Token: 0x040090E0 RID: 37088
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTimelineVectorTrack> _InterpVectors;

		// Token: 0x040090E1 RID: 37089
		internal static int __PropertyOffset_InterpFloats;

		// Token: 0x040090E2 RID: 37090
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTimelineFloatTrack> _InterpFloats;

		// Token: 0x040090E3 RID: 37091
		internal static int __PropertyOffset_InterpLinearColors;

		// Token: 0x040090E4 RID: 37092
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTimelineLinearColorTrack> _InterpLinearColors;

		// Token: 0x040090E5 RID: 37093
		internal static int __PropertyOffset_TimelinePostUpdateFunc;

		// Token: 0x040090E6 RID: 37094
		[Nullable(2)]
		private FOnTimelineEvent _TimelinePostUpdateFunc;

		// Token: 0x040090E7 RID: 37095
		internal static int __PropertyOffset_TimelineFinishedFunc;

		// Token: 0x040090E8 RID: 37096
		[Nullable(2)]
		private FOnTimelineEvent _TimelineFinishedFunc;

		// Token: 0x040090E9 RID: 37097
		internal static int __PropertyOffset_PropertySetObject;

		// Token: 0x040090EA RID: 37098
		internal static int __PropertyOffset_DirectionPropertyName;
	}
}
