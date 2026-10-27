using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000423 RID: 1059
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerScreenImage")]
	[UnrealStructLayout(344, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 344)]
	public class FAutomationWorkerScreenImage : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060038EA RID: 14570 RVA: 0x00056763 File Offset: 0x00054963
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerScreenImage._ScriptStructPtr != 0) ? FAutomationWorkerScreenImage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerScreenImage", ref FAutomationWorkerScreenImage._ScriptStructPtr);
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x060038EB RID: 14571 RVA: 0x00056788 File Offset: 0x00054988
		// (set) Token: 0x060038EC RID: 14572 RVA: 0x000567CB File Offset: 0x000549CB
		public TArray<byte> ScreenImage
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._ScreenImage) == null)
				{
					result = (this._ScreenImage = new TArray<byte>(base.NativePtr + (IntPtr)FAutomationWorkerScreenImage.__PropertyOffset_ScreenImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ScreenImage.CopyAssign(value);
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x060038ED RID: 14573 RVA: 0x000567DC File Offset: 0x000549DC
		// (set) Token: 0x060038EE RID: 14574 RVA: 0x0005681F File Offset: 0x00054A1F
		public TArray<byte> FrameTrace
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._FrameTrace) == null)
				{
					result = (this._FrameTrace = new TArray<byte>(base.NativePtr + (IntPtr)FAutomationWorkerScreenImage.__PropertyOffset_FrameTrace, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FrameTrace.CopyAssign(value);
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x060038EF RID: 14575 RVA: 0x0005682D File Offset: 0x00054A2D
		// (set) Token: 0x060038F0 RID: 14576 RVA: 0x00056841 File Offset: 0x00054A41
		public unsafe string ScreenShotName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerScreenImage.__PropertyOffset_ScreenShotName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerScreenImage.__PropertyOffset_ScreenShotName)), value);
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x060038F1 RID: 14577 RVA: 0x00056858 File Offset: 0x00054A58
		// (set) Token: 0x060038F2 RID: 14578 RVA: 0x0005689B File Offset: 0x00054A9B
		public FAutomationScreenshotMetadata Metadata
		{
			get
			{
				base.FastCheckIsValid();
				FAutomationScreenshotMetadata result;
				if ((result = this._Metadata) == null)
				{
					result = (this._Metadata = new FAutomationScreenshotMetadata(base.NativePtr + (IntPtr)FAutomationWorkerScreenImage.__PropertyOffset_Metadata, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAutomationScreenshotMetadata.StaticStruct(), base.NativePtr + (IntPtr)FAutomationWorkerScreenImage.__PropertyOffset_Metadata, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x000568BC File Offset: 0x00054ABC
		public FAutomationWorkerScreenImage()
		{
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x000568C4 File Offset: 0x00054AC4
		public FAutomationWorkerScreenImage(TArray<byte> ScreenImage, TArray<byte> FrameTrace, string ScreenShotName, FAutomationScreenshotMetadata Metadata)
		{
			this.ScreenImage = ScreenImage;
			this.FrameTrace = FrameTrace;
			this.ScreenShotName = ScreenShotName;
			this.Metadata = Metadata;
		}

		// Token: 0x060038F5 RID: 14581 RVA: 0x000568E9 File Offset: 0x00054AE9
		protected override IntPtr GetUStructPtr()
		{
			return FAutomationWorkerScreenImage.StaticStruct();
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x000568F5 File Offset: 0x00054AF5
		[NullableContext(2)]
		public FAutomationWorkerScreenImage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060038F7 RID: 14583 RVA: 0x000568FF File Offset: 0x00054AFF
		public FAutomationWorkerScreenImage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x0005690A File Offset: 0x00054B0A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutomationWorkerScreenImage(Pointer, false, true);
		}

		// Token: 0x060038F9 RID: 14585 RVA: 0x00056914 File Offset: 0x00054B14
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutomationWorkerScreenImage(Pointer, MemoryOwner);
		}

		// Token: 0x040019D2 RID: 6610
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerScreenImage";

		// Token: 0x040019D3 RID: 6611
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040019D4 RID: 6612
		internal static int __PropertyOffset_ScreenImage;

		// Token: 0x040019D5 RID: 6613
		[Nullable(2)]
		private TArray<byte> _ScreenImage;

		// Token: 0x040019D6 RID: 6614
		internal static int __PropertyOffset_FrameTrace;

		// Token: 0x040019D7 RID: 6615
		[Nullable(2)]
		private TArray<byte> _FrameTrace;

		// Token: 0x040019D8 RID: 6616
		internal static int __PropertyOffset_ScreenShotName;

		// Token: 0x040019D9 RID: 6617
		internal static int __PropertyOffset_Metadata;

		// Token: 0x040019DA RID: 6618
		[Nullable(2)]
		private FAutomationScreenshotMetadata _Metadata;
	}
}
