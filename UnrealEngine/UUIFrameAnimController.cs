using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002172 RID: 8562
	[UnrealObjectPath("/Script/LGUI.UIFrameAnimController")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UUIFrameAnimController : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602052B RID: 132395 RVA: 0x00300115 File Offset: 0x002FE315
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIFrameAnimController._ClassPtr;
		}

		// Token: 0x0602052C RID: 132396 RVA: 0x00300124 File Offset: 0x002FE324
		public UUIFrameAnimController() : this(BuiltinUtils.AllocNativeUObject(UUIFrameAnimController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602052D RID: 132397 RVA: 0x0030014C File Offset: 0x002FE34C
		[NullableContext(1)]
		public UUIFrameAnimController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIFrameAnimController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007EB7 RID: 32439
		// (get) Token: 0x0602052E RID: 132398 RVA: 0x0030017F File Offset: 0x002FE37F
		// (set) Token: 0x0602052F RID: 132399 RVA: 0x0030018F File Offset: 0x002FE38F
		public unsafe float FrameInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIFrameAnimController.__PropertyOffset_FrameInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIFrameAnimController.__PropertyOffset_FrameInterval) = value;
			}
		}

		// Token: 0x17007EB8 RID: 32440
		// (get) Token: 0x06020530 RID: 132400 RVA: 0x003001A0 File Offset: 0x002FE3A0
		// (set) Token: 0x06020531 RID: 132401 RVA: 0x003001B0 File Offset: 0x002FE3B0
		public unsafe bool bUseCustomFrameCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIFrameAnimController.__PropertyOffset_bUseCustomFrameCount) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIFrameAnimController.__PropertyOffset_bUseCustomFrameCount) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007EB9 RID: 32441
		// (get) Token: 0x06020532 RID: 132402 RVA: 0x003001C1 File Offset: 0x002FE3C1
		// (set) Token: 0x06020533 RID: 132403 RVA: 0x003001D1 File Offset: 0x002FE3D1
		public unsafe int BeginFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIFrameAnimController.__PropertyOffset_BeginFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIFrameAnimController.__PropertyOffset_BeginFrame) = value;
			}
		}

		// Token: 0x17007EBA RID: 32442
		// (get) Token: 0x06020534 RID: 132404 RVA: 0x003001E2 File Offset: 0x002FE3E2
		// (set) Token: 0x06020535 RID: 132405 RVA: 0x003001F2 File Offset: 0x002FE3F2
		public unsafe int CustomFrameCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIFrameAnimController.__PropertyOffset_CustomFrameCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIFrameAnimController.__PropertyOffset_CustomFrameCount) = value;
			}
		}

		// Token: 0x06020536 RID: 132406 RVA: 0x00300203 File Offset: 0x002FE403
		public void Stop()
		{
			UUIFrameAnimController.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x06020537 RID: 132407 RVA: 0x00300210 File Offset: 0x002FE410
		public void Resume()
		{
			UUIFrameAnimController.__Resume_Internal(base.NativePtr);
		}

		// Token: 0x06020538 RID: 132408 RVA: 0x0030021D File Offset: 0x002FE41D
		public void Play(bool bLooping = false)
		{
			UUIFrameAnimController.__Play_Internal(base.NativePtr, bLooping);
		}

		// Token: 0x06020539 RID: 132409 RVA: 0x0030022B File Offset: 0x002FE42B
		public void Pause()
		{
			UUIFrameAnimController.__Pause_Internal(base.NativePtr);
		}

		// Token: 0x0602053A RID: 132410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x0602053B RID: 132411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Resume_Internal(IntPtr @this);

		// Token: 0x0602053C RID: 132412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this, bool bLooping);

		// Token: 0x0602053D RID: 132413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Pause_Internal(IntPtr @this);

		// Token: 0x0602053E RID: 132414 RVA: 0x00300238 File Offset: 0x002FE438
		static UUIFrameAnimController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIFrameAnimController");
		}

		// Token: 0x0602053F RID: 132415 RVA: 0x00300246 File Offset: 0x002FE446
		protected UUIFrameAnimController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040115DC RID: 71132
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIFrameAnimController";

		// Token: 0x040115DD RID: 71133
		private static IntPtr _ClassPtr;

		// Token: 0x040115DE RID: 71134
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040115DF RID: 71135
		internal static int __PropertyOffset_FrameInterval;

		// Token: 0x040115E0 RID: 71136
		internal static int __PropertyOffset_bUseCustomFrameCount;

		// Token: 0x040115E1 RID: 71137
		internal static int __PropertyOffset_BeginFrame;

		// Token: 0x040115E2 RID: 71138
		internal static int __PropertyOffset_CustomFrameCount;
	}
}
