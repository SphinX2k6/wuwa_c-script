using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002214 RID: 8724
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkSourceBufferManagementSettings")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FLiveLinkSourceBufferManagementSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060213A3 RID: 136099 RVA: 0x0030FC7A File Offset: 0x0030DE7A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkSourceBufferManagementSettings._ScriptStructPtr != 0) ? FLiveLinkSourceBufferManagementSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkSourceBufferManagementSettings", ref FLiveLinkSourceBufferManagementSettings._ScriptStructPtr);
		}

		// Token: 0x170081B0 RID: 33200
		// (get) Token: 0x060213A4 RID: 136100 RVA: 0x0030FC9E File Offset: 0x0030DE9E
		// (set) Token: 0x060213A5 RID: 136101 RVA: 0x0030FCAE File Offset: 0x0030DEAE
		public unsafe bool bValidEngineTimeEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_bValidEngineTimeEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_bValidEngineTimeEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170081B1 RID: 33201
		// (get) Token: 0x060213A6 RID: 136102 RVA: 0x0030FCBF File Offset: 0x0030DEBF
		// (set) Token: 0x060213A7 RID: 136103 RVA: 0x0030FCCF File Offset: 0x0030DECF
		public unsafe float ValidEngineTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_ValidEngineTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_ValidEngineTime) = value;
			}
		}

		// Token: 0x170081B2 RID: 33202
		// (get) Token: 0x060213A8 RID: 136104 RVA: 0x0030FCE0 File Offset: 0x0030DEE0
		// (set) Token: 0x060213A9 RID: 136105 RVA: 0x0030FCF0 File Offset: 0x0030DEF0
		public unsafe float EngineTimeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_EngineTimeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_EngineTimeOffset) = value;
			}
		}

		// Token: 0x170081B3 RID: 33203
		// (get) Token: 0x060213AA RID: 136106 RVA: 0x0030FD01 File Offset: 0x0030DF01
		// (set) Token: 0x060213AB RID: 136107 RVA: 0x0030FD11 File Offset: 0x0030DF11
		public unsafe double EngineTimeClockOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_EngineTimeClockOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_EngineTimeClockOffset) = value;
			}
		}

		// Token: 0x170081B4 RID: 33204
		// (get) Token: 0x060213AC RID: 136108 RVA: 0x0030FD22 File Offset: 0x0030DF22
		// (set) Token: 0x060213AD RID: 136109 RVA: 0x0030FD32 File Offset: 0x0030DF32
		public unsafe bool bGenerateSubFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_bGenerateSubFrame) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_bGenerateSubFrame) = (value ? 1 : 0);
			}
		}

		// Token: 0x170081B5 RID: 33205
		// (get) Token: 0x060213AE RID: 136110 RVA: 0x0030FD43 File Offset: 0x0030DF43
		// (set) Token: 0x060213AF RID: 136111 RVA: 0x0030FD57 File Offset: 0x0030DF57
		public unsafe FFrameRate DetectedFrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_DetectedFrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_DetectedFrameRate) = value;
			}
		}

		// Token: 0x170081B6 RID: 33206
		// (get) Token: 0x060213B0 RID: 136112 RVA: 0x0030FD6C File Offset: 0x0030DF6C
		// (set) Token: 0x060213B1 RID: 136113 RVA: 0x0030FD7C File Offset: 0x0030DF7C
		public unsafe bool bUseTimecodeSmoothLatest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_bUseTimecodeSmoothLatest) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_bUseTimecodeSmoothLatest) = (value ? 1 : 0);
			}
		}

		// Token: 0x170081B7 RID: 33207
		// (get) Token: 0x060213B2 RID: 136114 RVA: 0x0030FD8D File Offset: 0x0030DF8D
		// (set) Token: 0x060213B3 RID: 136115 RVA: 0x0030FDA1 File Offset: 0x0030DFA1
		public unsafe FFrameRate SourceTimecodeFrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_SourceTimecodeFrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_SourceTimecodeFrameRate) = value;
			}
		}

		// Token: 0x170081B8 RID: 33208
		// (get) Token: 0x060213B4 RID: 136116 RVA: 0x0030FDB6 File Offset: 0x0030DFB6
		// (set) Token: 0x060213B5 RID: 136117 RVA: 0x0030FDC6 File Offset: 0x0030DFC6
		public unsafe bool bValidTimecodeFrameEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_bValidTimecodeFrameEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_bValidTimecodeFrameEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170081B9 RID: 33209
		// (get) Token: 0x060213B6 RID: 136118 RVA: 0x0030FDD7 File Offset: 0x0030DFD7
		// (set) Token: 0x060213B7 RID: 136119 RVA: 0x0030FDE7 File Offset: 0x0030DFE7
		public unsafe int ValidTimecodeFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_ValidTimecodeFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_ValidTimecodeFrame) = value;
			}
		}

		// Token: 0x170081BA RID: 33210
		// (get) Token: 0x060213B8 RID: 136120 RVA: 0x0030FDF8 File Offset: 0x0030DFF8
		// (set) Token: 0x060213B9 RID: 136121 RVA: 0x0030FE08 File Offset: 0x0030E008
		public unsafe float TimecodeFrameOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_TimecodeFrameOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_TimecodeFrameOffset) = value;
			}
		}

		// Token: 0x170081BB RID: 33211
		// (get) Token: 0x060213BA RID: 136122 RVA: 0x0030FE19 File Offset: 0x0030E019
		// (set) Token: 0x060213BB RID: 136123 RVA: 0x0030FE29 File Offset: 0x0030E029
		public unsafe double TimecodeClockOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_TimecodeClockOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_TimecodeClockOffset) = value;
			}
		}

		// Token: 0x170081BC RID: 33212
		// (get) Token: 0x060213BC RID: 136124 RVA: 0x0030FE3A File Offset: 0x0030E03A
		// (set) Token: 0x060213BD RID: 136125 RVA: 0x0030FE4A File Offset: 0x0030E04A
		public unsafe int LatestOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_LatestOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_LatestOffset) = value;
			}
		}

		// Token: 0x170081BD RID: 33213
		// (get) Token: 0x060213BE RID: 136126 RVA: 0x0030FE5B File Offset: 0x0030E05B
		// (set) Token: 0x060213BF RID: 136127 RVA: 0x0030FE6B File Offset: 0x0030E06B
		public unsafe int MaxNumberOfFrameToBuffered
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_MaxNumberOfFrameToBuffered);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_MaxNumberOfFrameToBuffered) = value;
			}
		}

		// Token: 0x170081BE RID: 33214
		// (get) Token: 0x060213C0 RID: 136128 RVA: 0x0030FE7C File Offset: 0x0030E07C
		// (set) Token: 0x060213C1 RID: 136129 RVA: 0x0030FE8C File Offset: 0x0030E08C
		public unsafe bool bKeepAtLeastOneFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_bKeepAtLeastOneFrame) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSourceBufferManagementSettings.__PropertyOffset_bKeepAtLeastOneFrame) = (value ? 1 : 0);
			}
		}

		// Token: 0x060213C2 RID: 136130 RVA: 0x0030FE9D File Offset: 0x0030E09D
		public FLiveLinkSourceBufferManagementSettings()
		{
		}

		// Token: 0x060213C3 RID: 136131 RVA: 0x0030FEA8 File Offset: 0x0030E0A8
		public FLiveLinkSourceBufferManagementSettings(bool bValidEngineTimeEnabled, float ValidEngineTime, float EngineTimeOffset, double EngineTimeClockOffset, FFrameRate TimecodeFrameRate_DEPRECATED, bool bGenerateSubFrame, FFrameRate DetectedFrameRate, bool bUseTimecodeSmoothLatest, FFrameRate SourceTimecodeFrameRate, bool bValidTimecodeFrameEnabled, int ValidTimecodeFrame, float TimecodeFrameOffset, double TimecodeClockOffset, int LatestOffset, int MaxNumberOfFrameToBuffered, bool bKeepAtLeastOneFrame)
		{
			this.bValidEngineTimeEnabled = bValidEngineTimeEnabled;
			this.ValidEngineTime = ValidEngineTime;
			this.EngineTimeOffset = EngineTimeOffset;
			this.EngineTimeClockOffset = EngineTimeClockOffset;
			this.bGenerateSubFrame = bGenerateSubFrame;
			this.DetectedFrameRate = DetectedFrameRate;
			this.bUseTimecodeSmoothLatest = bUseTimecodeSmoothLatest;
			this.SourceTimecodeFrameRate = SourceTimecodeFrameRate;
			this.bValidTimecodeFrameEnabled = bValidTimecodeFrameEnabled;
			this.ValidTimecodeFrame = ValidTimecodeFrame;
			this.TimecodeFrameOffset = TimecodeFrameOffset;
			this.TimecodeClockOffset = TimecodeClockOffset;
			this.LatestOffset = LatestOffset;
			this.MaxNumberOfFrameToBuffered = MaxNumberOfFrameToBuffered;
			this.bKeepAtLeastOneFrame = bKeepAtLeastOneFrame;
		}

		// Token: 0x060213C4 RID: 136132 RVA: 0x0030FF30 File Offset: 0x0030E130
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkSourceBufferManagementSettings.StaticStruct();
		}

		// Token: 0x060213C5 RID: 136133 RVA: 0x0030FF3C File Offset: 0x0030E13C
		[NullableContext(2)]
		public FLiveLinkSourceBufferManagementSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060213C6 RID: 136134 RVA: 0x0030FF46 File Offset: 0x0030E146
		public FLiveLinkSourceBufferManagementSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060213C7 RID: 136135 RVA: 0x0030FF51 File Offset: 0x0030E151
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkSourceBufferManagementSettings(Pointer, false, true);
		}

		// Token: 0x060213C8 RID: 136136 RVA: 0x0030FF5B File Offset: 0x0030E15B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkSourceBufferManagementSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04011B9A RID: 72602
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkSourceBufferManagementSettings";

		// Token: 0x04011B9B RID: 72603
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B9C RID: 72604
		internal static int __PropertyOffset_bValidEngineTimeEnabled;

		// Token: 0x04011B9D RID: 72605
		internal static int __PropertyOffset_ValidEngineTime;

		// Token: 0x04011B9E RID: 72606
		internal static int __PropertyOffset_EngineTimeOffset;

		// Token: 0x04011B9F RID: 72607
		internal static int __PropertyOffset_EngineTimeClockOffset;

		// Token: 0x04011BA0 RID: 72608
		internal static int __PropertyOffset_bGenerateSubFrame;

		// Token: 0x04011BA1 RID: 72609
		internal static int __PropertyOffset_DetectedFrameRate;

		// Token: 0x04011BA2 RID: 72610
		internal static int __PropertyOffset_bUseTimecodeSmoothLatest;

		// Token: 0x04011BA3 RID: 72611
		internal static int __PropertyOffset_SourceTimecodeFrameRate;

		// Token: 0x04011BA4 RID: 72612
		internal static int __PropertyOffset_bValidTimecodeFrameEnabled;

		// Token: 0x04011BA5 RID: 72613
		internal static int __PropertyOffset_ValidTimecodeFrame;

		// Token: 0x04011BA6 RID: 72614
		internal static int __PropertyOffset_TimecodeFrameOffset;

		// Token: 0x04011BA7 RID: 72615
		internal static int __PropertyOffset_TimecodeClockOffset;

		// Token: 0x04011BA8 RID: 72616
		internal static int __PropertyOffset_LatestOffset;

		// Token: 0x04011BA9 RID: 72617
		internal static int __PropertyOffset_MaxNumberOfFrameToBuffered;

		// Token: 0x04011BAA RID: 72618
		internal static int __PropertyOffset_bKeepAtLeastOneFrame;
	}
}
