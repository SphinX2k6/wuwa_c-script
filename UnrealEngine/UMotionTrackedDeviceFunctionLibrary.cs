using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200146B RID: 5227
	[UnrealObjectPath("/Script/HeadMountedDisplay.MotionTrackedDeviceFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UMotionTrackedDeviceFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013105 RID: 78085 RVA: 0x001C0912 File Offset: 0x001BEB12
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMotionTrackedDeviceFunctionLibrary._ClassPtr;
		}

		// Token: 0x06013106 RID: 78086 RVA: 0x001C0920 File Offset: 0x001BEB20
		public UMotionTrackedDeviceFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UMotionTrackedDeviceFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013107 RID: 78087 RVA: 0x001C0948 File Offset: 0x001BEB48
		[NullableContext(1)]
		public UMotionTrackedDeviceFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMotionTrackedDeviceFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013108 RID: 78088
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetIsControllerMotionTrackingEnabledByDefault(bool Enable);

		// Token: 0x06013109 RID: 78089
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsMotionTrackingEnabledForSource(int PlayerIndex, FName SourceName);

		// Token: 0x0601310A RID: 78090
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsMotionTrackingEnabledForDevice(int PlayerIndex, EControllerHand Hand);

		// Token: 0x0601310B RID: 78091 RVA: 0x001C097B File Offset: 0x001BEB7B
		[NullableContext(2)]
		public static bool IsMotionTrackingEnabledForComponent(UMotionControllerComponent MotionControllerComponent)
		{
			return UMotionTrackedDeviceFunctionLibrary.__IsMotionTrackingEnabledForComponent_Internal((MotionControllerComponent != null) ? MotionControllerComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601310C RID: 78092
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsMotionTrackedDeviceCountManagementNecessary();

		// Token: 0x0601310D RID: 78093
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsMotionSourceTracking(int PlayerIndex, FName SourceName);

		// Token: 0x0601310E RID: 78094
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetMotionTrackingEnabledControllerCount();

		// Token: 0x0601310F RID: 78095
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetMaximumMotionTrackedControllerCount();

		// Token: 0x06013110 RID: 78096
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FName GetActiveTrackingSystemName();

		// Token: 0x06013111 RID: 78097 RVA: 0x001C0992 File Offset: 0x001BEB92
		[NullableContext(1)]
		public static TArray<FName> EnumerateMotionSources()
		{
			return new TArray<FName>(UMotionTrackedDeviceFunctionLibrary.__EnumerateMotionSources_Internal(), null);
		}

		// Token: 0x06013112 RID: 78098
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EnableMotionTrackingOfSource(int PlayerIndex, FName SourceName);

		// Token: 0x06013113 RID: 78099
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EnableMotionTrackingOfDevice(int PlayerIndex, EControllerHand Hand);

		// Token: 0x06013114 RID: 78100 RVA: 0x001C099F File Offset: 0x001BEB9F
		[NullableContext(2)]
		public static bool EnableMotionTrackingForComponent(UMotionControllerComponent MotionControllerComponent)
		{
			return UMotionTrackedDeviceFunctionLibrary.__EnableMotionTrackingForComponent_Internal((MotionControllerComponent != null) ? MotionControllerComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06013115 RID: 78101
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DisableMotionTrackingOfSource(int PlayerIndex, FName SourceName);

		// Token: 0x06013116 RID: 78102
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DisableMotionTrackingOfDevice(int PlayerIndex, EControllerHand Hand);

		// Token: 0x06013117 RID: 78103
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DisableMotionTrackingOfControllersForPlayer(int PlayerIndex);

		// Token: 0x06013118 RID: 78104
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DisableMotionTrackingOfAllControllers();

		// Token: 0x06013119 RID: 78105 RVA: 0x001C09B6 File Offset: 0x001BEBB6
		[NullableContext(2)]
		public static void DisableMotionTrackingForComponent(UMotionControllerComponent MotionControllerComponent)
		{
			UMotionTrackedDeviceFunctionLibrary.__DisableMotionTrackingForComponent_Internal((MotionControllerComponent != null) ? MotionControllerComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601311A RID: 78106
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMotionTrackingEnabledForComponent_Internal(IntPtr MotionControllerComponent);

		// Token: 0x0601311B RID: 78107
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __EnumerateMotionSources_Internal();

		// Token: 0x0601311C RID: 78108
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EnableMotionTrackingForComponent_Internal(IntPtr MotionControllerComponent);

		// Token: 0x0601311D RID: 78109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisableMotionTrackingForComponent_Internal(IntPtr MotionControllerComponent);

		// Token: 0x0601311E RID: 78110 RVA: 0x001C09CD File Offset: 0x001BEBCD
		static UMotionTrackedDeviceFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HeadMountedDisplay.MotionTrackedDeviceFunctionLibrary");
		}

		// Token: 0x0601311F RID: 78111 RVA: 0x001C09DB File Offset: 0x001BEBDB
		protected UMotionTrackedDeviceFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A38F RID: 41871
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HeadMountedDisplay.MotionTrackedDeviceFunctionLibrary";

		// Token: 0x0400A390 RID: 41872
		private static IntPtr _ClassPtr;

		// Token: 0x0400A391 RID: 41873
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
