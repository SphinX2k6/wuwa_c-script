using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000BF RID: 191
	[UnrealObjectPath("/Script/AkAudio.AkDurationCallbackInfo")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UAkDurationCallbackInfo : UAkEventCallbackInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000E33 RID: 3635 RVA: 0x000162E0 File Offset: 0x000144E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkDurationCallbackInfo._ClassPtr;
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x000162EC File Offset: 0x000144EC
		public UAkDurationCallbackInfo() : this(BuiltinUtils.AllocNativeUObject(UAkDurationCallbackInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00016314 File Offset: 0x00014514
		[NullableContext(1)]
		public UAkDurationCallbackInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkDurationCallbackInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x00016347 File Offset: 0x00014547
		// (set) Token: 0x06000E37 RID: 3639 RVA: 0x00016357 File Offset: 0x00014557
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkDurationCallbackInfo.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkDurationCallbackInfo.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x00016368 File Offset: 0x00014568
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x00016378 File Offset: 0x00014578
		public unsafe float EstimatedDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkDurationCallbackInfo.__PropertyOffset_EstimatedDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkDurationCallbackInfo.__PropertyOffset_EstimatedDuration) = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x00016389 File Offset: 0x00014589
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x00016399 File Offset: 0x00014599
		public unsafe int AudioNodeID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkDurationCallbackInfo.__PropertyOffset_AudioNodeID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkDurationCallbackInfo.__PropertyOffset_AudioNodeID) = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x000163AA File Offset: 0x000145AA
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x000163BA File Offset: 0x000145BA
		public unsafe int MediaID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkDurationCallbackInfo.__PropertyOffset_MediaID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkDurationCallbackInfo.__PropertyOffset_MediaID) = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x000163CB File Offset: 0x000145CB
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x000163DB File Offset: 0x000145DB
		public unsafe bool bStreaming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkDurationCallbackInfo.__PropertyOffset_bStreaming) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkDurationCallbackInfo.__PropertyOffset_bStreaming) = (value ? 1 : 0);
			}
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x000163EC File Offset: 0x000145EC
		static UAkDurationCallbackInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkDurationCallbackInfo");
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x000163FA File Offset: 0x000145FA
		protected UAkDurationCallbackInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002BE RID: 702
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkDurationCallbackInfo";

		// Token: 0x040002BF RID: 703
		private static IntPtr _ClassPtr;

		// Token: 0x040002C0 RID: 704
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040002C1 RID: 705
		internal static int __PropertyOffset_Duration;

		// Token: 0x040002C2 RID: 706
		internal static int __PropertyOffset_EstimatedDuration;

		// Token: 0x040002C3 RID: 707
		internal static int __PropertyOffset_AudioNodeID;

		// Token: 0x040002C4 RID: 708
		internal static int __PropertyOffset_MediaID;

		// Token: 0x040002C5 RID: 709
		internal static int __PropertyOffset_bStreaming;
	}
}
