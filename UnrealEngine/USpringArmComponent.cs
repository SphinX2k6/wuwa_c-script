using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200028D RID: 653
	[UnrealObjectPath("/Script/Engine.SpringArmComponent")]
	[UnrealStructLayout(720, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 720)]
	public class USpringArmComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060047AB RID: 18347 RVA: 0x000645EB File Offset: 0x000627EB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpringArmComponent._ClassPtr;
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x000645F8 File Offset: 0x000627F8
		public USpringArmComponent() : this(BuiltinUtils.AllocNativeUObject(USpringArmComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x00064620 File Offset: 0x00062820
		[NullableContext(1)]
		public USpringArmComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpringArmComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x060047AE RID: 18350 RVA: 0x00064653 File Offset: 0x00062853
		// (set) Token: 0x060047AF RID: 18351 RVA: 0x00064663 File Offset: 0x00062863
		public unsafe float TargetArmLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_TargetArmLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_TargetArmLength) = value;
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x060047B0 RID: 18352 RVA: 0x00064674 File Offset: 0x00062874
		// (set) Token: 0x060047B1 RID: 18353 RVA: 0x00064688 File Offset: 0x00062888
		public unsafe FVector SocketOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_SocketOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_SocketOffset) = value;
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x060047B2 RID: 18354 RVA: 0x0006469D File Offset: 0x0006289D
		// (set) Token: 0x060047B3 RID: 18355 RVA: 0x000646B1 File Offset: 0x000628B1
		public unsafe FVector TargetOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_TargetOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_TargetOffset) = value;
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x060047B4 RID: 18356 RVA: 0x000646C6 File Offset: 0x000628C6
		// (set) Token: 0x060047B5 RID: 18357 RVA: 0x000646D6 File Offset: 0x000628D6
		public unsafe float ProbeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_ProbeSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_ProbeSize) = value;
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x060047B6 RID: 18358 RVA: 0x000646E7 File Offset: 0x000628E7
		// (set) Token: 0x060047B7 RID: 18359 RVA: 0x000646FB File Offset: 0x000628FB
		public unsafe TEnumAsByte<ECollisionChannel> ProbeChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_ProbeChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_ProbeChannel) = value;
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x060047B8 RID: 18360 RVA: 0x00064710 File Offset: 0x00062910
		// (set) Token: 0x060047B9 RID: 18361 RVA: 0x00064729 File Offset: 0x00062929
		public unsafe bool bDoCollisionTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bDoCollisionTest) & USpringArmComponent.__PropertyMask_bDoCollisionTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bDoCollisionTest) = ((*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bDoCollisionTest) & ~USpringArmComponent.__PropertyMask_bDoCollisionTest) | (value ? USpringArmComponent.__PropertyMask_bDoCollisionTest : 0));
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x060047BA RID: 18362 RVA: 0x00064759 File Offset: 0x00062959
		// (set) Token: 0x060047BB RID: 18363 RVA: 0x00064772 File Offset: 0x00062972
		public unsafe bool bUsePawnControlRotation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bUsePawnControlRotation) & USpringArmComponent.__PropertyMask_bUsePawnControlRotation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bUsePawnControlRotation) = ((*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bUsePawnControlRotation) & ~USpringArmComponent.__PropertyMask_bUsePawnControlRotation) | (value ? USpringArmComponent.__PropertyMask_bUsePawnControlRotation : 0));
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x060047BC RID: 18364 RVA: 0x000647A2 File Offset: 0x000629A2
		// (set) Token: 0x060047BD RID: 18365 RVA: 0x000647BB File Offset: 0x000629BB
		public unsafe bool bInheritPitch
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bInheritPitch) & USpringArmComponent.__PropertyMask_bInheritPitch) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bInheritPitch) = ((*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bInheritPitch) & ~USpringArmComponent.__PropertyMask_bInheritPitch) | (value ? USpringArmComponent.__PropertyMask_bInheritPitch : 0));
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x060047BE RID: 18366 RVA: 0x000647EB File Offset: 0x000629EB
		// (set) Token: 0x060047BF RID: 18367 RVA: 0x00064804 File Offset: 0x00062A04
		public unsafe bool bInheritYaw
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bInheritYaw) & USpringArmComponent.__PropertyMask_bInheritYaw) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bInheritYaw) = ((*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bInheritYaw) & ~USpringArmComponent.__PropertyMask_bInheritYaw) | (value ? USpringArmComponent.__PropertyMask_bInheritYaw : 0));
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x060047C0 RID: 18368 RVA: 0x00064834 File Offset: 0x00062A34
		// (set) Token: 0x060047C1 RID: 18369 RVA: 0x0006484D File Offset: 0x00062A4D
		public unsafe bool bInheritRoll
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bInheritRoll) & USpringArmComponent.__PropertyMask_bInheritRoll) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bInheritRoll) = ((*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bInheritRoll) & ~USpringArmComponent.__PropertyMask_bInheritRoll) | (value ? USpringArmComponent.__PropertyMask_bInheritRoll : 0));
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x060047C2 RID: 18370 RVA: 0x0006487D File Offset: 0x00062A7D
		// (set) Token: 0x060047C3 RID: 18371 RVA: 0x00064896 File Offset: 0x00062A96
		public unsafe bool bEnableCameraLag
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bEnableCameraLag) & USpringArmComponent.__PropertyMask_bEnableCameraLag) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bEnableCameraLag) = ((*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bEnableCameraLag) & ~USpringArmComponent.__PropertyMask_bEnableCameraLag) | (value ? USpringArmComponent.__PropertyMask_bEnableCameraLag : 0));
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x060047C4 RID: 18372 RVA: 0x000648C6 File Offset: 0x00062AC6
		// (set) Token: 0x060047C5 RID: 18373 RVA: 0x000648DF File Offset: 0x00062ADF
		public unsafe bool bEnableCameraRotationLag
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bEnableCameraRotationLag) & USpringArmComponent.__PropertyMask_bEnableCameraRotationLag) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bEnableCameraRotationLag) = ((*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bEnableCameraRotationLag) & ~USpringArmComponent.__PropertyMask_bEnableCameraRotationLag) | (value ? USpringArmComponent.__PropertyMask_bEnableCameraRotationLag : 0));
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x060047C6 RID: 18374 RVA: 0x0006490F File Offset: 0x00062B0F
		// (set) Token: 0x060047C7 RID: 18375 RVA: 0x00064928 File Offset: 0x00062B28
		public unsafe bool bUseCameraLagSubstepping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bUseCameraLagSubstepping) & USpringArmComponent.__PropertyMask_bUseCameraLagSubstepping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bUseCameraLagSubstepping) = ((*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bUseCameraLagSubstepping) & ~USpringArmComponent.__PropertyMask_bUseCameraLagSubstepping) | (value ? USpringArmComponent.__PropertyMask_bUseCameraLagSubstepping : 0));
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x060047C8 RID: 18376 RVA: 0x00064958 File Offset: 0x00062B58
		// (set) Token: 0x060047C9 RID: 18377 RVA: 0x00064971 File Offset: 0x00062B71
		public unsafe bool bDrawDebugLagMarkers
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bDrawDebugLagMarkers) & USpringArmComponent.__PropertyMask_bDrawDebugLagMarkers) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bDrawDebugLagMarkers) = ((*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bDrawDebugLagMarkers) & ~USpringArmComponent.__PropertyMask_bDrawDebugLagMarkers) | (value ? USpringArmComponent.__PropertyMask_bDrawDebugLagMarkers : 0));
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x060047CA RID: 18378 RVA: 0x000649A1 File Offset: 0x00062BA1
		// (set) Token: 0x060047CB RID: 18379 RVA: 0x000649B1 File Offset: 0x00062BB1
		public unsafe float CameraLagSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraLagSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraLagSpeed) = value;
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x060047CC RID: 18380 RVA: 0x000649C2 File Offset: 0x00062BC2
		// (set) Token: 0x060047CD RID: 18381 RVA: 0x000649D2 File Offset: 0x00062BD2
		public unsafe float CameraRotationLagSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraRotationLagSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraRotationLagSpeed) = value;
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x060047CE RID: 18382 RVA: 0x000649E3 File Offset: 0x00062BE3
		// (set) Token: 0x060047CF RID: 18383 RVA: 0x000649F3 File Offset: 0x00062BF3
		public unsafe float CameraRotationLagSpeedPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraRotationLagSpeedPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraRotationLagSpeedPercent) = value;
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x060047D0 RID: 18384 RVA: 0x00064A04 File Offset: 0x00062C04
		// (set) Token: 0x060047D1 RID: 18385 RVA: 0x00064A14 File Offset: 0x00062C14
		public unsafe float CameraLagMaxTimeStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraLagMaxTimeStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraLagMaxTimeStep) = value;
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x060047D2 RID: 18386 RVA: 0x00064A25 File Offset: 0x00062C25
		// (set) Token: 0x060047D3 RID: 18387 RVA: 0x00064A35 File Offset: 0x00062C35
		public unsafe float CameraLagMaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraLagMaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraLagMaxDistance) = value;
			}
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x00064A46 File Offset: 0x00062C46
		public bool IsCollisionFixApplied()
		{
			return USpringArmComponent.__IsCollisionFixApplied_Internal(base.NativePtr);
		}

		// Token: 0x060047D5 RID: 18389 RVA: 0x00064A53 File Offset: 0x00062C53
		public FVector GetUnfixedCameraPosition()
		{
			return USpringArmComponent.__GetUnfixedCameraPosition_Internal(base.NativePtr);
		}

		// Token: 0x060047D6 RID: 18390 RVA: 0x00064A60 File Offset: 0x00062C60
		public FRotator GetTargetRotation()
		{
			return USpringArmComponent.__GetTargetRotation_Internal(base.NativePtr);
		}

		// Token: 0x060047D7 RID: 18391
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsCollisionFixApplied_Internal(IntPtr @this);

		// Token: 0x060047D8 RID: 18392
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUnfixedCameraPosition_Internal(IntPtr @this);

		// Token: 0x060047D9 RID: 18393
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetTargetRotation_Internal(IntPtr @this);

		// Token: 0x060047DA RID: 18394 RVA: 0x00064A6D File Offset: 0x00062C6D
		static USpringArmComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SpringArmComponent");
		}

		// Token: 0x060047DB RID: 18395 RVA: 0x00064A7B File Offset: 0x00062C7B
		protected USpringArmComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001B98 RID: 7064
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SpringArmComponent";

		// Token: 0x04001B99 RID: 7065
		private static IntPtr _ClassPtr;

		// Token: 0x04001B9A RID: 7066
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001B9B RID: 7067
		internal static int __PropertyOffset_TargetArmLength;

		// Token: 0x04001B9C RID: 7068
		internal static int __PropertyOffset_SocketOffset;

		// Token: 0x04001B9D RID: 7069
		internal static int __PropertyOffset_TargetOffset;

		// Token: 0x04001B9E RID: 7070
		internal static int __PropertyOffset_ProbeSize;

		// Token: 0x04001B9F RID: 7071
		internal static int __PropertyOffset_ProbeChannel;

		// Token: 0x04001BA0 RID: 7072
		internal static int __PropertyOffset_bDoCollisionTest;

		// Token: 0x04001BA1 RID: 7073
		internal static byte __PropertyMask_bDoCollisionTest;

		// Token: 0x04001BA2 RID: 7074
		internal static int __PropertyOffset_bUsePawnControlRotation;

		// Token: 0x04001BA3 RID: 7075
		internal static byte __PropertyMask_bUsePawnControlRotation;

		// Token: 0x04001BA4 RID: 7076
		internal static int __PropertyOffset_bInheritPitch;

		// Token: 0x04001BA5 RID: 7077
		internal static byte __PropertyMask_bInheritPitch;

		// Token: 0x04001BA6 RID: 7078
		internal static int __PropertyOffset_bInheritYaw;

		// Token: 0x04001BA7 RID: 7079
		internal static byte __PropertyMask_bInheritYaw;

		// Token: 0x04001BA8 RID: 7080
		internal static int __PropertyOffset_bInheritRoll;

		// Token: 0x04001BA9 RID: 7081
		internal static byte __PropertyMask_bInheritRoll;

		// Token: 0x04001BAA RID: 7082
		internal static int __PropertyOffset_bEnableCameraLag;

		// Token: 0x04001BAB RID: 7083
		internal static byte __PropertyMask_bEnableCameraLag;

		// Token: 0x04001BAC RID: 7084
		internal static int __PropertyOffset_bEnableCameraRotationLag;

		// Token: 0x04001BAD RID: 7085
		internal static byte __PropertyMask_bEnableCameraRotationLag;

		// Token: 0x04001BAE RID: 7086
		internal static int __PropertyOffset_bUseCameraLagSubstepping;

		// Token: 0x04001BAF RID: 7087
		internal static byte __PropertyMask_bUseCameraLagSubstepping;

		// Token: 0x04001BB0 RID: 7088
		internal static int __PropertyOffset_bDrawDebugLagMarkers;

		// Token: 0x04001BB1 RID: 7089
		internal static byte __PropertyMask_bDrawDebugLagMarkers;

		// Token: 0x04001BB2 RID: 7090
		internal static int __PropertyOffset_CameraLagSpeed;

		// Token: 0x04001BB3 RID: 7091
		internal static int __PropertyOffset_CameraRotationLagSpeed;

		// Token: 0x04001BB4 RID: 7092
		internal static int __PropertyOffset_CameraRotationLagSpeedPercent;

		// Token: 0x04001BB5 RID: 7093
		internal static int __PropertyOffset_CameraLagMaxTimeStep;

		// Token: 0x04001BB6 RID: 7094
		internal static int __PropertyOffset_CameraLagMaxDistance;
	}
}
