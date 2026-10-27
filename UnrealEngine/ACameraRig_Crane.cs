using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000474 RID: 1140
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CinematicCamera.CameraRig_Crane")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class ACameraRig_Crane : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003CFE RID: 15614 RVA: 0x0005BC79 File Offset: 0x00059E79
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACameraRig_Crane._ClassPtr;
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x0005BC88 File Offset: 0x00059E88
		public ACameraRig_Crane() : this(BuiltinUtils.AllocNativeUObject(ACameraRig_Crane.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x0005BCB0 File Offset: 0x00059EB0
		[NullableContext(1)]
		public ACameraRig_Crane(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACameraRig_Crane.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06003D01 RID: 15617 RVA: 0x0005BCE3 File Offset: 0x00059EE3
		// (set) Token: 0x06003D02 RID: 15618 RVA: 0x0005BCF3 File Offset: 0x00059EF3
		public unsafe float CranePitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACameraRig_Crane.__PropertyOffset_CranePitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACameraRig_Crane.__PropertyOffset_CranePitch) = value;
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06003D03 RID: 15619 RVA: 0x0005BD04 File Offset: 0x00059F04
		// (set) Token: 0x06003D04 RID: 15620 RVA: 0x0005BD14 File Offset: 0x00059F14
		public unsafe float CraneYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACameraRig_Crane.__PropertyOffset_CraneYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACameraRig_Crane.__PropertyOffset_CraneYaw) = value;
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06003D05 RID: 15621 RVA: 0x0005BD25 File Offset: 0x00059F25
		// (set) Token: 0x06003D06 RID: 15622 RVA: 0x0005BD35 File Offset: 0x00059F35
		public unsafe float CraneArmLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACameraRig_Crane.__PropertyOffset_CraneArmLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACameraRig_Crane.__PropertyOffset_CraneArmLength) = value;
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06003D07 RID: 15623 RVA: 0x0005BD46 File Offset: 0x00059F46
		// (set) Token: 0x06003D08 RID: 15624 RVA: 0x0005BD56 File Offset: 0x00059F56
		public unsafe bool bLockMountPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACameraRig_Crane.__PropertyOffset_bLockMountPitch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACameraRig_Crane.__PropertyOffset_bLockMountPitch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06003D09 RID: 15625 RVA: 0x0005BD67 File Offset: 0x00059F67
		// (set) Token: 0x06003D0A RID: 15626 RVA: 0x0005BD77 File Offset: 0x00059F77
		public unsafe bool bLockMountYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACameraRig_Crane.__PropertyOffset_bLockMountYaw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACameraRig_Crane.__PropertyOffset_bLockMountYaw) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06003D0B RID: 15627 RVA: 0x0005BD88 File Offset: 0x00059F88
		// (set) Token: 0x06003D0C RID: 15628 RVA: 0x0005BD9C File Offset: 0x00059F9C
		public unsafe USceneComponent TransformComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACameraRig_Crane.__PropertyOffset_TransformComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACameraRig_Crane.__PropertyOffset_TransformComponent, value);
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06003D0D RID: 15629 RVA: 0x0005BDB1 File Offset: 0x00059FB1
		// (set) Token: 0x06003D0E RID: 15630 RVA: 0x0005BDC5 File Offset: 0x00059FC5
		public unsafe USceneComponent CraneYawControl
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACameraRig_Crane.__PropertyOffset_CraneYawControl);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACameraRig_Crane.__PropertyOffset_CraneYawControl, value);
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06003D0F RID: 15631 RVA: 0x0005BDDA File Offset: 0x00059FDA
		// (set) Token: 0x06003D10 RID: 15632 RVA: 0x0005BDEE File Offset: 0x00059FEE
		public unsafe USceneComponent CranePitchControl
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACameraRig_Crane.__PropertyOffset_CranePitchControl);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACameraRig_Crane.__PropertyOffset_CranePitchControl, value);
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06003D11 RID: 15633 RVA: 0x0005BE03 File Offset: 0x0005A003
		// (set) Token: 0x06003D12 RID: 15634 RVA: 0x0005BE17 File Offset: 0x0005A017
		public unsafe USceneComponent CraneCameraMount
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACameraRig_Crane.__PropertyOffset_CraneCameraMount);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACameraRig_Crane.__PropertyOffset_CraneCameraMount, value);
			}
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x0005BE2C File Offset: 0x0005A02C
		static ACameraRig_Crane()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CinematicCamera.CameraRig_Crane");
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x0005BE3A File Offset: 0x0005A03A
		protected ACameraRig_Crane(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001C9A RID: 7322
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CinematicCamera.CameraRig_Crane";

		// Token: 0x04001C9B RID: 7323
		private static IntPtr _ClassPtr;

		// Token: 0x04001C9C RID: 7324
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001C9D RID: 7325
		internal static int __PropertyOffset_CranePitch;

		// Token: 0x04001C9E RID: 7326
		internal static int __PropertyOffset_CraneYaw;

		// Token: 0x04001C9F RID: 7327
		internal static int __PropertyOffset_CraneArmLength;

		// Token: 0x04001CA0 RID: 7328
		internal static int __PropertyOffset_bLockMountPitch;

		// Token: 0x04001CA1 RID: 7329
		internal static int __PropertyOffset_bLockMountYaw;

		// Token: 0x04001CA2 RID: 7330
		internal static int __PropertyOffset_TransformComponent;

		// Token: 0x04001CA3 RID: 7331
		internal static int __PropertyOffset_CraneYawControl;

		// Token: 0x04001CA4 RID: 7332
		internal static int __PropertyOffset_CranePitchControl;

		// Token: 0x04001CA5 RID: 7333
		internal static int __PropertyOffset_CraneCameraMount;
	}
}
