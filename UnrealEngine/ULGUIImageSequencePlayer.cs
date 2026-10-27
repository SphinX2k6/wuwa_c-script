using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200207F RID: 8319
	[UnrealObjectPath("/Script/LGUI.LGUIImageSequencePlayer")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public abstract class ULGUIImageSequencePlayer : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F62A RID: 128554 RVA: 0x002E9D34 File Offset: 0x002E7F34
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIImageSequencePlayer._ClassPtr;
		}

		// Token: 0x17007BEC RID: 31724
		// (get) Token: 0x0601F62B RID: 128555 RVA: 0x002E9D40 File Offset: 0x002E7F40
		// (set) Token: 0x0601F62C RID: 128556 RVA: 0x002E9D50 File Offset: 0x002E7F50
		public unsafe float fps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIImageSequencePlayer.__PropertyOffset_fps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIImageSequencePlayer.__PropertyOffset_fps) = value;
			}
		}

		// Token: 0x17007BED RID: 31725
		// (get) Token: 0x0601F62D RID: 128557 RVA: 0x002E9D61 File Offset: 0x002E7F61
		// (set) Token: 0x0601F62E RID: 128558 RVA: 0x002E9D71 File Offset: 0x002E7F71
		public unsafe bool loop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIImageSequencePlayer.__PropertyOffset_loop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIImageSequencePlayer.__PropertyOffset_loop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007BEE RID: 31726
		// (get) Token: 0x0601F62F RID: 128559 RVA: 0x002E9D82 File Offset: 0x002E7F82
		// (set) Token: 0x0601F630 RID: 128560 RVA: 0x002E9D92 File Offset: 0x002E7F92
		public unsafe bool playOnStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIImageSequencePlayer.__PropertyOffset_playOnStart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIImageSequencePlayer.__PropertyOffset_playOnStart) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F631 RID: 128561 RVA: 0x002E9DA3 File Offset: 0x002E7FA3
		public void Stop()
		{
			ULGUIImageSequencePlayer.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x0601F632 RID: 128562 RVA: 0x002E9DB0 File Offset: 0x002E7FB0
		public void SetLoop(bool value)
		{
			ULGUIImageSequencePlayer.__SetLoop_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F633 RID: 128563 RVA: 0x002E9DBE File Offset: 0x002E7FBE
		public void SetFps(float value)
		{
			ULGUIImageSequencePlayer.__SetFps_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F634 RID: 128564 RVA: 0x002E9DCC File Offset: 0x002E7FCC
		public void SeekTime(float time)
		{
			ULGUIImageSequencePlayer.__SeekTime_Internal(base.NativePtr, time);
		}

		// Token: 0x0601F635 RID: 128565 RVA: 0x002E9DDA File Offset: 0x002E7FDA
		public void SeekFrame(int frameNumber)
		{
			ULGUIImageSequencePlayer.__SeekFrame_Internal(base.NativePtr, frameNumber);
		}

		// Token: 0x0601F636 RID: 128566 RVA: 0x002E9DE8 File Offset: 0x002E7FE8
		public void Play()
		{
			ULGUIImageSequencePlayer.__Play_Internal(base.NativePtr);
		}

		// Token: 0x0601F637 RID: 128567 RVA: 0x002E9DF5 File Offset: 0x002E7FF5
		public void Pause()
		{
			ULGUIImageSequencePlayer.__Pause_Internal(base.NativePtr);
		}

		// Token: 0x0601F638 RID: 128568 RVA: 0x002E9E02 File Offset: 0x002E8002
		public bool GetLoop()
		{
			return ULGUIImageSequencePlayer.__GetLoop_Internal(base.NativePtr);
		}

		// Token: 0x0601F639 RID: 128569 RVA: 0x002E9E0F File Offset: 0x002E800F
		public bool GetIsPlaying()
		{
			return ULGUIImageSequencePlayer.__GetIsPlaying_Internal(base.NativePtr);
		}

		// Token: 0x0601F63A RID: 128570 RVA: 0x002E9E1C File Offset: 0x002E801C
		public float GetFps()
		{
			return ULGUIImageSequencePlayer.__GetFps_Internal(base.NativePtr);
		}

		// Token: 0x0601F63B RID: 128571 RVA: 0x002E9E29 File Offset: 0x002E8029
		public float GetDuration()
		{
			return ULGUIImageSequencePlayer.__GetDuration_Internal(base.NativePtr);
		}

		// Token: 0x0601F63C RID: 128572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x0601F63D RID: 128573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLoop_Internal(IntPtr @this, bool value);

		// Token: 0x0601F63E RID: 128574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFps_Internal(IntPtr @this, float value);

		// Token: 0x0601F63F RID: 128575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SeekTime_Internal(IntPtr @this, float time);

		// Token: 0x0601F640 RID: 128576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SeekFrame_Internal(IntPtr @this, int frameNumber);

		// Token: 0x0601F641 RID: 128577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this);

		// Token: 0x0601F642 RID: 128578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Pause_Internal(IntPtr @this);

		// Token: 0x0601F643 RID: 128579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLoop_Internal(IntPtr @this);

		// Token: 0x0601F644 RID: 128580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsPlaying_Internal(IntPtr @this);

		// Token: 0x0601F645 RID: 128581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFps_Internal(IntPtr @this);

		// Token: 0x0601F646 RID: 128582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDuration_Internal(IntPtr @this);

		// Token: 0x0601F647 RID: 128583 RVA: 0x002E9E36 File Offset: 0x002E8036
		static ULGUIImageSequencePlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIImageSequencePlayer");
		}

		// Token: 0x0601F648 RID: 128584 RVA: 0x002E9E44 File Offset: 0x002E8044
		protected ULGUIImageSequencePlayer() : this(BuiltinUtils.AllocNativeUObject(ULGUIImageSequencePlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F649 RID: 128585 RVA: 0x002E9E6C File Offset: 0x002E806C
		protected ULGUIImageSequencePlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010F45 RID: 69445
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIImageSequencePlayer";

		// Token: 0x04010F46 RID: 69446
		private static IntPtr _ClassPtr;

		// Token: 0x04010F47 RID: 69447
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010F48 RID: 69448
		internal static int __PropertyOffset_fps;

		// Token: 0x04010F49 RID: 69449
		internal static int __PropertyOffset_loop;

		// Token: 0x04010F4A RID: 69450
		internal static int __PropertyOffset_playOnStart;
	}
}
