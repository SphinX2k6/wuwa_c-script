using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008CC RID: 2252
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BlueprintPlatformLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UBlueprintPlatformLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007B8C RID: 31628 RVA: 0x000B09AE File Offset: 0x000AEBAE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlueprintPlatformLibrary._ClassPtr;
		}

		// Token: 0x06007B8D RID: 31629 RVA: 0x000B09BC File Offset: 0x000AEBBC
		public UBlueprintPlatformLibrary() : this(BuiltinUtils.AllocNativeUObject(UBlueprintPlatformLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007B8E RID: 31630 RVA: 0x000B09E4 File Offset: 0x000AEBE4
		public UBlueprintPlatformLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlueprintPlatformLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007B8F RID: 31631 RVA: 0x000B0A18 File Offset: 0x000AEC18
		public unsafe static int ScheduleLocalNotificationImmediately(in FText Title, in FText Body, in FText Action, string ActivationEvent)
		{
			FString fstring = FString.AllocTemp(ActivationEvent);
			FText ftext = Title;
			IntPtr title = (ftext != null) ? ftext.NativePtr : IntPtr.Zero;
			FText ftext2 = Body;
			IntPtr body = (ftext2 != null) ? ftext2.NativePtr : IntPtr.Zero;
			FText ftext3 = Action;
			int result = UBlueprintPlatformLibrary.__ScheduleLocalNotificationImmediately_Internal(title, body, (ftext3 != null) ? ftext3.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06007B90 RID: 31632 RVA: 0x000B0A74 File Offset: 0x000AEC74
		public unsafe static int ScheduleLocalNotificationFromNow(int inSecondsFromNow, in FText Title, in FText Body, in FText Action, string ActivationEvent)
		{
			FString fstring = FString.AllocTemp(ActivationEvent);
			FText ftext = Title;
			IntPtr title = (ftext != null) ? ftext.NativePtr : IntPtr.Zero;
			FText ftext2 = Body;
			IntPtr body = (ftext2 != null) ? ftext2.NativePtr : IntPtr.Zero;
			FText ftext3 = Action;
			int result = UBlueprintPlatformLibrary.__ScheduleLocalNotificationFromNow_Internal(inSecondsFromNow, title, body, (ftext3 != null) ? ftext3.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06007B91 RID: 31633 RVA: 0x000B0AD0 File Offset: 0x000AECD0
		public unsafe static void ScheduleLocalNotificationBadgeFromNow(int inSecondsFromNow, string ActivationEvent)
		{
			FString fstring = FString.AllocTemp(ActivationEvent);
			UBlueprintPlatformLibrary.__ScheduleLocalNotificationBadgeFromNow_Internal(inSecondsFromNow, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06007B92 RID: 31634 RVA: 0x000B0AF8 File Offset: 0x000AECF8
		public unsafe static int ScheduleLocalNotificationBadgeAtTime([Nullable(2)] in FDateTime FireDateTime, bool LocalTime, string ActivationEvent)
		{
			FString fstring = FString.AllocTemp(ActivationEvent);
			int result = UBlueprintPlatformLibrary.__ScheduleLocalNotificationBadgeAtTime_Internal((FireDateTime ?? new FDateTime()).NativePtr, LocalTime, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06007B93 RID: 31635 RVA: 0x000B0B30 File Offset: 0x000AED30
		public unsafe static int ScheduleLocalNotificationAtTime([Nullable(2)] in FDateTime FireDateTime, bool LocalTime, in FText Title, in FText Body, in FText Action, string ActivationEvent)
		{
			FString fstring = FString.AllocTemp(ActivationEvent);
			IntPtr nativePtr = (FireDateTime ?? new FDateTime()).NativePtr;
			FText ftext = Title;
			IntPtr title = (ftext != null) ? ftext.NativePtr : IntPtr.Zero;
			FText ftext2 = Body;
			IntPtr body = (ftext2 != null) ? ftext2.NativePtr : IntPtr.Zero;
			FText ftext3 = Action;
			int result = UBlueprintPlatformLibrary.__ScheduleLocalNotificationAtTime_Internal(nativePtr, LocalTime, title, body, (ftext3 != null) ? ftext3.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06007B94 RID: 31636 RVA: 0x000B0BA0 File Offset: 0x000AEDA0
		public unsafe static void GetLaunchNotification(ref bool NotificationLaunchedApp, ref string ActivationEvent, ref int FireDate)
		{
			FString fstring = FString.AllocTemp(ActivationEvent);
			fixed (bool* ptr = &NotificationLaunchedApp)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &FireDate)
				{
					void* ptr4 = (void*)ptr3;
					UBlueprintPlatformLibrary.__GetLaunchNotification_Internal(ref NotificationLaunchedApp, ref fstring, ref FireDate);
					ActivationEvent = FString.ToString(fstring);
					FString.NativeDestruct(&fstring, 1);
					ptr = null;
				}
			}
		}

		// Token: 0x06007B95 RID: 31637
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern TEnumAsByte<EScreenOrientation> GetDeviceOrientation();

		// Token: 0x06007B96 RID: 31638
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearAllLocalNotifications();

		// Token: 0x06007B97 RID: 31639
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CancelLocalNotificationById(int NotificationId);

		// Token: 0x06007B98 RID: 31640 RVA: 0x000B0BE4 File Offset: 0x000AEDE4
		public unsafe static void CancelLocalNotification(string ActivationEvent)
		{
			FString fstring = FString.AllocTemp(ActivationEvent);
			UBlueprintPlatformLibrary.__CancelLocalNotification_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06007B99 RID: 31641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __ScheduleLocalNotificationImmediately_Internal(IntPtr Title, IntPtr Body, IntPtr Action, in FString ActivationEvent);

		// Token: 0x06007B9A RID: 31642
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __ScheduleLocalNotificationFromNow_Internal(int inSecondsFromNow, IntPtr Title, IntPtr Body, IntPtr Action, in FString ActivationEvent);

		// Token: 0x06007B9B RID: 31643
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScheduleLocalNotificationBadgeFromNow_Internal(int inSecondsFromNow, in FString ActivationEvent);

		// Token: 0x06007B9C RID: 31644
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __ScheduleLocalNotificationBadgeAtTime_Internal(IntPtr FireDateTime, bool LocalTime, in FString ActivationEvent);

		// Token: 0x06007B9D RID: 31645
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __ScheduleLocalNotificationAtTime_Internal(IntPtr FireDateTime, bool LocalTime, IntPtr Title, IntPtr Body, IntPtr Action, in FString ActivationEvent);

		// Token: 0x06007B9E RID: 31646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetLaunchNotification_Internal(ref bool NotificationLaunchedApp, ref FString ActivationEvent, ref int FireDate);

		// Token: 0x06007B9F RID: 31647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CancelLocalNotification_Internal(in FString ActivationEvent);

		// Token: 0x06007BA0 RID: 31648 RVA: 0x000B0C08 File Offset: 0x000AEE08
		static UBlueprintPlatformLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlueprintPlatformLibrary");
		}

		// Token: 0x06007BA1 RID: 31649 RVA: 0x000B0C16 File Offset: 0x000AEE16
		protected UBlueprintPlatformLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003B21 RID: 15137
		public new const string __ObjectPath = "/Script/Engine.BlueprintPlatformLibrary";

		// Token: 0x04003B22 RID: 15138
		private static IntPtr _ClassPtr;

		// Token: 0x04003B23 RID: 15139
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
