using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000200 RID: 512
	[UnrealObjectPath("/Script/AkAudio.AkDurationCallbackInfo")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UAkDurationCallbackInfo : UAkEventCallbackInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001E28 RID: 7720 RVA: 0x0002CB8E File Offset: 0x0002AD8E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkDurationCallbackInfo._ClassPtr;
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x0002CB9C File Offset: 0x0002AD9C
		public UAkDurationCallbackInfo() : this(BuiltinUtils.AllocNativeUObject(UAkDurationCallbackInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x0002CBC4 File Offset: 0x0002ADC4
		[NullableContext(1)]
		public UAkDurationCallbackInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkDurationCallbackInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x0002CBF7 File Offset: 0x0002ADF7
		// (set) Token: 0x06001E2C RID: 7724 RVA: 0x0002CC07 File Offset: 0x0002AE07
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

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x0002CC18 File Offset: 0x0002AE18
		// (set) Token: 0x06001E2E RID: 7726 RVA: 0x0002CC28 File Offset: 0x0002AE28
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

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x0002CC39 File Offset: 0x0002AE39
		// (set) Token: 0x06001E30 RID: 7728 RVA: 0x0002CC49 File Offset: 0x0002AE49
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

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001E31 RID: 7729 RVA: 0x0002CC5A File Offset: 0x0002AE5A
		// (set) Token: 0x06001E32 RID: 7730 RVA: 0x0002CC6A File Offset: 0x0002AE6A
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

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x0002CC7B File Offset: 0x0002AE7B
		// (set) Token: 0x06001E34 RID: 7732 RVA: 0x0002CC8B File Offset: 0x0002AE8B
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

		// Token: 0x06001E35 RID: 7733 RVA: 0x0002CC9C File Offset: 0x0002AE9C
		static UAkDurationCallbackInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkDurationCallbackInfo");
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x0002CCAA File Offset: 0x0002AEAA
		protected UAkDurationCallbackInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040009FC RID: 2556
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkDurationCallbackInfo";

		// Token: 0x040009FD RID: 2557
		private static IntPtr _ClassPtr;

		// Token: 0x040009FE RID: 2558
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040009FF RID: 2559
		internal static int __PropertyOffset_Duration;

		// Token: 0x04000A00 RID: 2560
		internal static int __PropertyOffset_EstimatedDuration;

		// Token: 0x04000A01 RID: 2561
		internal static int __PropertyOffset_AudioNodeID;

		// Token: 0x04000A02 RID: 2562
		internal static int __PropertyOffset_MediaID;

		// Token: 0x04000A03 RID: 2563
		internal static int __PropertyOffset_bStreaming;
	}
}
