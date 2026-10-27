using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022A5 RID: 8869
	[UnrealObjectPath("/Script/MediaAssets.TimeSynchronizableMediaSource")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public abstract class UTimeSynchronizableMediaSource : UBaseMediaSource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021BA3 RID: 138147 RVA: 0x0031DE27 File Offset: 0x0031C027
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTimeSynchronizableMediaSource._ClassPtr;
		}

		// Token: 0x170082D4 RID: 33492
		// (get) Token: 0x06021BA4 RID: 138148 RVA: 0x0031DE33 File Offset: 0x0031C033
		// (set) Token: 0x06021BA5 RID: 138149 RVA: 0x0031DE43 File Offset: 0x0031C043
		public unsafe bool bUseTimeSynchronization
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTimeSynchronizableMediaSource.__PropertyOffset_bUseTimeSynchronization) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTimeSynchronizableMediaSource.__PropertyOffset_bUseTimeSynchronization) = (value ? 1 : 0);
			}
		}

		// Token: 0x170082D5 RID: 33493
		// (get) Token: 0x06021BA6 RID: 138150 RVA: 0x0031DE54 File Offset: 0x0031C054
		// (set) Token: 0x06021BA7 RID: 138151 RVA: 0x0031DE64 File Offset: 0x0031C064
		public unsafe int FrameDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTimeSynchronizableMediaSource.__PropertyOffset_FrameDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTimeSynchronizableMediaSource.__PropertyOffset_FrameDelay) = value;
			}
		}

		// Token: 0x170082D6 RID: 33494
		// (get) Token: 0x06021BA8 RID: 138152 RVA: 0x0031DE75 File Offset: 0x0031C075
		// (set) Token: 0x06021BA9 RID: 138153 RVA: 0x0031DE85 File Offset: 0x0031C085
		public unsafe double TimeDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTimeSynchronizableMediaSource.__PropertyOffset_TimeDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTimeSynchronizableMediaSource.__PropertyOffset_TimeDelay) = value;
			}
		}

		// Token: 0x06021BAA RID: 138154 RVA: 0x0031DE96 File Offset: 0x0031C096
		static UTimeSynchronizableMediaSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaAssets.TimeSynchronizableMediaSource");
		}

		// Token: 0x06021BAB RID: 138155 RVA: 0x0031DEA4 File Offset: 0x0031C0A4
		protected UTimeSynchronizableMediaSource() : this(BuiltinUtils.AllocNativeUObject(UTimeSynchronizableMediaSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021BAC RID: 138156 RVA: 0x0031DECC File Offset: 0x0031C0CC
		protected UTimeSynchronizableMediaSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011FDF RID: 73695
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MediaAssets.TimeSynchronizableMediaSource";

		// Token: 0x04011FE0 RID: 73696
		private static IntPtr _ClassPtr;

		// Token: 0x04011FE1 RID: 73697
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011FE2 RID: 73698
		internal static int __PropertyOffset_bUseTimeSynchronization;

		// Token: 0x04011FE3 RID: 73699
		internal static int __PropertyOffset_FrameDelay;

		// Token: 0x04011FE4 RID: 73700
		internal static int __PropertyOffset_TimeDelay;
	}
}
