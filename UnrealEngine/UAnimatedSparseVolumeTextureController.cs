using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007DB RID: 2011
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimatedSparseVolumeTextureController")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAnimatedSparseVolumeTextureController : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006B21 RID: 27425 RVA: 0x0009A516 File Offset: 0x00098716
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimatedSparseVolumeTextureController._ClassPtr;
		}

		// Token: 0x06006B22 RID: 27426 RVA: 0x0009A524 File Offset: 0x00098724
		public UAnimatedSparseVolumeTextureController() : this(BuiltinUtils.AllocNativeUObject(UAnimatedSparseVolumeTextureController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006B23 RID: 27427 RVA: 0x0009A54C File Offset: 0x0009874C
		[NullableContext(1)]
		public UAnimatedSparseVolumeTextureController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimatedSparseVolumeTextureController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x06006B24 RID: 27428 RVA: 0x0009A57F File Offset: 0x0009877F
		// (set) Token: 0x06006B25 RID: 27429 RVA: 0x0009A593 File Offset: 0x00098793
		public unsafe USparseVolumeTexture SparseVolumeTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USparseVolumeTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimatedSparseVolumeTextureController.__PropertyOffset_SparseVolumeTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimatedSparseVolumeTextureController.__PropertyOffset_SparseVolumeTexture, value);
			}
		}

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x06006B26 RID: 27430 RVA: 0x0009A5A8 File Offset: 0x000987A8
		// (set) Token: 0x06006B27 RID: 27431 RVA: 0x0009A5B8 File Offset: 0x000987B8
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimatedSparseVolumeTextureController.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimatedSparseVolumeTextureController.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x06006B28 RID: 27432 RVA: 0x0009A5C9 File Offset: 0x000987C9
		// (set) Token: 0x06006B29 RID: 27433 RVA: 0x0009A5D9 File Offset: 0x000987D9
		public unsafe bool bIsPlaying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimatedSparseVolumeTextureController.__PropertyOffset_bIsPlaying) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimatedSparseVolumeTextureController.__PropertyOffset_bIsPlaying) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x06006B2A RID: 27434 RVA: 0x0009A5EA File Offset: 0x000987EA
		// (set) Token: 0x06006B2B RID: 27435 RVA: 0x0009A5FA File Offset: 0x000987FA
		public unsafe float FrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimatedSparseVolumeTextureController.__PropertyOffset_FrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimatedSparseVolumeTextureController.__PropertyOffset_FrameRate) = value;
			}
		}

		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x06006B2C RID: 27436 RVA: 0x0009A60B File Offset: 0x0009880B
		// (set) Token: 0x06006B2D RID: 27437 RVA: 0x0009A61B File Offset: 0x0009881B
		public unsafe int MipLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimatedSparseVolumeTextureController.__PropertyOffset_MipLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimatedSparseVolumeTextureController.__PropertyOffset_MipLevel) = value;
			}
		}

		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x06006B2E RID: 27438 RVA: 0x0009A62C File Offset: 0x0009882C
		// (set) Token: 0x06006B2F RID: 27439 RVA: 0x0009A63C File Offset: 0x0009883C
		public unsafe bool bBlockingStreamingRequests
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimatedSparseVolumeTextureController.__PropertyOffset_bBlockingStreamingRequests) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimatedSparseVolumeTextureController.__PropertyOffset_bBlockingStreamingRequests) = (value ? 1 : 0);
			}
		}

		// Token: 0x06006B30 RID: 27440 RVA: 0x0009A64D File Offset: 0x0009884D
		public void Update(float DeltaTime)
		{
			UAnimatedSparseVolumeTextureController.__Update_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x06006B31 RID: 27441 RVA: 0x0009A65B File Offset: 0x0009885B
		public void Stop()
		{
			UAnimatedSparseVolumeTextureController.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x06006B32 RID: 27442 RVA: 0x0009A668 File Offset: 0x00098868
		public void Play()
		{
			UAnimatedSparseVolumeTextureController.__Play_Internal(base.NativePtr);
		}

		// Token: 0x06006B33 RID: 27443 RVA: 0x0009A675 File Offset: 0x00098875
		public void Pause()
		{
			UAnimatedSparseVolumeTextureController.__Pause_Internal(base.NativePtr);
		}

		// Token: 0x06006B34 RID: 27444 RVA: 0x0009A682 File Offset: 0x00098882
		public USparseVolumeTextureFrame GetFrameByIndex(int FrameIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USparseVolumeTextureFrame>(UAnimatedSparseVolumeTextureController.__GetFrameByIndex_Internal(base.NativePtr, FrameIndex));
		}

		// Token: 0x06006B35 RID: 27445 RVA: 0x0009A695 File Offset: 0x00098895
		public float GetFractionalFrameIndex()
		{
			return UAnimatedSparseVolumeTextureController.__GetFractionalFrameIndex_Internal(base.NativePtr);
		}

		// Token: 0x06006B36 RID: 27446 RVA: 0x0009A6A2 File Offset: 0x000988A2
		public float GetDuration()
		{
			return UAnimatedSparseVolumeTextureController.__GetDuration_Internal(base.NativePtr);
		}

		// Token: 0x06006B37 RID: 27447 RVA: 0x0009A6B0 File Offset: 0x000988B0
		public unsafe void GetCurrentFramesForInterpolation(ref USparseVolumeTextureFrame Frame0, ref USparseVolumeTextureFrame Frame1, ref float LerpAlpha)
		{
			USparseVolumeTextureFrame usparseVolumeTextureFrame = Frame0;
			IntPtr nativeObjectPtr = (usparseVolumeTextureFrame != null) ? usparseVolumeTextureFrame.NativePtr : IntPtr.Zero;
			USparseVolumeTextureFrame usparseVolumeTextureFrame2 = Frame1;
			IntPtr nativeObjectPtr2 = (usparseVolumeTextureFrame2 != null) ? usparseVolumeTextureFrame2.NativePtr : IntPtr.Zero;
			fixed (float* ptr = &LerpAlpha)
			{
				void* ptr2 = (void*)ptr;
				UAnimatedSparseVolumeTextureController.__GetCurrentFramesForInterpolation_Internal(base.NativePtr, ref nativeObjectPtr, ref nativeObjectPtr2, ref LerpAlpha);
				Frame0 = BuiltinUtils.GetOrCreateUObjectByNativePointer<USparseVolumeTextureFrame>(nativeObjectPtr);
				Frame1 = BuiltinUtils.GetOrCreateUObjectByNativePointer<USparseVolumeTextureFrame>(nativeObjectPtr2);
			}
		}

		// Token: 0x06006B38 RID: 27448 RVA: 0x0009A70B File Offset: 0x0009890B
		public USparseVolumeTextureFrame GetCurrentFrame()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USparseVolumeTextureFrame>(UAnimatedSparseVolumeTextureController.__GetCurrentFrame_Internal(base.NativePtr));
		}

		// Token: 0x06006B39 RID: 27449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Update_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x06006B3A RID: 27450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x06006B3B RID: 27451
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this);

		// Token: 0x06006B3C RID: 27452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Pause_Internal(IntPtr @this);

		// Token: 0x06006B3D RID: 27453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetFrameByIndex_Internal(IntPtr @this, int FrameIndex);

		// Token: 0x06006B3E RID: 27454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFractionalFrameIndex_Internal(IntPtr @this);

		// Token: 0x06006B3F RID: 27455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDuration_Internal(IntPtr @this);

		// Token: 0x06006B40 RID: 27456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetCurrentFramesForInterpolation_Internal(IntPtr @this, ref IntPtr Frame0, ref IntPtr Frame1, ref float LerpAlpha);

		// Token: 0x06006B41 RID: 27457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentFrame_Internal(IntPtr @this);

		// Token: 0x06006B42 RID: 27458 RVA: 0x0009A71D File Offset: 0x0009891D
		static UAnimatedSparseVolumeTextureController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimatedSparseVolumeTextureController");
		}

		// Token: 0x06006B43 RID: 27459 RVA: 0x0009A72B File Offset: 0x0009892B
		protected UAnimatedSparseVolumeTextureController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400338D RID: 13197
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimatedSparseVolumeTextureController";

		// Token: 0x0400338E RID: 13198
		private static IntPtr _ClassPtr;

		// Token: 0x0400338F RID: 13199
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003390 RID: 13200
		internal static int __PropertyOffset_SparseVolumeTexture;

		// Token: 0x04003391 RID: 13201
		internal static int __PropertyOffset_Time;

		// Token: 0x04003392 RID: 13202
		internal static int __PropertyOffset_bIsPlaying;

		// Token: 0x04003393 RID: 13203
		internal static int __PropertyOffset_FrameRate;

		// Token: 0x04003394 RID: 13204
		internal static int __PropertyOffset_MipLevel;

		// Token: 0x04003395 RID: 13205
		internal static int __PropertyOffset_bBlockingStreamingRequests;
	}
}
