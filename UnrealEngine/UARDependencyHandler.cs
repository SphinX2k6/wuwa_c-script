using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200039C RID: 924
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARDependencyHandler")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UARDependencyHandler : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003339 RID: 13113 RVA: 0x0004E7B1 File Offset: 0x0004C9B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARDependencyHandler._ClassPtr;
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x0004E7BD File Offset: 0x0004C9BD
		public void StartARSessionLatent(UObject WorldContextObject, UARSessionConfig SessionConfig, FLatentActionInfo LatentInfo)
		{
			UARDependencyHandler.__StartARSessionLatent_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SessionConfig != null) ? SessionConfig.NativePtr : IntPtr.Zero, (LatentInfo ?? new FLatentActionInfo()).NativePtr);
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x0004E7FC File Offset: 0x0004C9FC
		public unsafe void RequestARSessionPermission(UObject WorldContextObject, UARSessionConfig SessionConfig, FLatentActionInfo LatentInfo, ref EARServicePermissionRequestResult OutPermissionResult)
		{
			fixed (EARServicePermissionRequestResult* ptr = &OutPermissionResult)
			{
				void* ptr2 = (void*)ptr;
				UARDependencyHandler.__RequestARSessionPermission_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SessionConfig != null) ? SessionConfig.NativePtr : IntPtr.Zero, (LatentInfo ?? new FLatentActionInfo()).NativePtr, ref OutPermissionResult);
			}
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x0004E850 File Offset: 0x0004CA50
		public unsafe void InstallARService(UObject WorldContextObject, FLatentActionInfo LatentInfo, ref EARServiceInstallRequestResult OutInstallResult)
		{
			fixed (EARServiceInstallRequestResult* ptr = &OutInstallResult)
			{
				void* ptr2 = (void*)ptr;
				UARDependencyHandler.__InstallARService_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (LatentInfo ?? new FLatentActionInfo()).NativePtr, ref OutInstallResult);
			}
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x0004E890 File Offset: 0x0004CA90
		public static UARDependencyHandler GetARDependencyHandler()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UARDependencyHandler>(UARDependencyHandler.__GetARDependencyHandler_Internal());
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x0004E89C File Offset: 0x0004CA9C
		public unsafe void CheckARServiceAvailability(UObject WorldContextObject, FLatentActionInfo LatentInfo, ref EARServiceAvailability OutAvailability)
		{
			fixed (EARServiceAvailability* ptr = &OutAvailability)
			{
				void* ptr2 = (void*)ptr;
				UARDependencyHandler.__CheckARServiceAvailability_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (LatentInfo ?? new FLatentActionInfo()).NativePtr, ref OutAvailability);
			}
		}

		// Token: 0x0600333F RID: 13119
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartARSessionLatent_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr SessionConfig, IntPtr LatentInfo);

		// Token: 0x06003340 RID: 13120
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RequestARSessionPermission_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr SessionConfig, IntPtr LatentInfo, ref EARServicePermissionRequestResult OutPermissionResult);

		// Token: 0x06003341 RID: 13121
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InstallARService_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr LatentInfo, ref EARServiceInstallRequestResult OutInstallResult);

		// Token: 0x06003342 RID: 13122
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetARDependencyHandler_Internal();

		// Token: 0x06003343 RID: 13123
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CheckARServiceAvailability_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr LatentInfo, ref EARServiceAvailability OutAvailability);

		// Token: 0x06003344 RID: 13124 RVA: 0x0004E8DC File Offset: 0x0004CADC
		static UARDependencyHandler()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARDependencyHandler");
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x0004E8EC File Offset: 0x0004CAEC
		protected UARDependencyHandler() : this(BuiltinUtils.AllocNativeUObject(UARDependencyHandler.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x0004E914 File Offset: 0x0004CB14
		protected UARDependencyHandler(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001644 RID: 5700
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARDependencyHandler";

		// Token: 0x04001645 RID: 5701
		private static IntPtr _ClassPtr;

		// Token: 0x04001646 RID: 5702
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
