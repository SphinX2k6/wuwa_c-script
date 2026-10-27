using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FFD RID: 4093
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PlatformGameInstance")]
	[UnrealStructLayout(656, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class UPlatformGameInstance : UGameInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DD99 RID: 56729 RVA: 0x001464D2 File Offset: 0x001446D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlatformGameInstance._ClassPtr;
		}

		// Token: 0x0600DD9A RID: 56730 RVA: 0x001464E0 File Offset: 0x001446E0
		public UPlatformGameInstance() : this(BuiltinUtils.AllocNativeUObject(UPlatformGameInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DD9B RID: 56731 RVA: 0x00146508 File Offset: 0x00144708
		public UPlatformGameInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPlatformGameInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700343D RID: 13373
		// (get) Token: 0x0600DD9C RID: 56732 RVA: 0x0014653C File Offset: 0x0014473C
		// (set) Token: 0x0600DD9D RID: 56733 RVA: 0x00146575 File Offset: 0x00144775
		public FPlatformDelegate ApplicationWillDeactivateDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformDelegate result;
				if ((result = this._ApplicationWillDeactivateDelegate) == null)
				{
					result = (this._ApplicationWillDeactivateDelegate = new FPlatformDelegate(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationWillDeactivateDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationWillDeactivateDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700343E RID: 13374
		// (get) Token: 0x0600DD9E RID: 56734 RVA: 0x00146598 File Offset: 0x00144798
		// (set) Token: 0x0600DD9F RID: 56735 RVA: 0x001465D1 File Offset: 0x001447D1
		public FPlatformDelegate ApplicationHasReactivatedDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformDelegate result;
				if ((result = this._ApplicationHasReactivatedDelegate) == null)
				{
					result = (this._ApplicationHasReactivatedDelegate = new FPlatformDelegate(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationHasReactivatedDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationHasReactivatedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700343F RID: 13375
		// (get) Token: 0x0600DDA0 RID: 56736 RVA: 0x001465F4 File Offset: 0x001447F4
		// (set) Token: 0x0600DDA1 RID: 56737 RVA: 0x0014662D File Offset: 0x0014482D
		public FPlatformDelegate ApplicationWillEnterBackgroundDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformDelegate result;
				if ((result = this._ApplicationWillEnterBackgroundDelegate) == null)
				{
					result = (this._ApplicationWillEnterBackgroundDelegate = new FPlatformDelegate(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationWillEnterBackgroundDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationWillEnterBackgroundDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003440 RID: 13376
		// (get) Token: 0x0600DDA2 RID: 56738 RVA: 0x00146650 File Offset: 0x00144850
		// (set) Token: 0x0600DDA3 RID: 56739 RVA: 0x00146689 File Offset: 0x00144889
		public FPlatformDelegate ApplicationHasEnteredForegroundDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformDelegate result;
				if ((result = this._ApplicationHasEnteredForegroundDelegate) == null)
				{
					result = (this._ApplicationHasEnteredForegroundDelegate = new FPlatformDelegate(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationHasEnteredForegroundDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationHasEnteredForegroundDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003441 RID: 13377
		// (get) Token: 0x0600DDA4 RID: 56740 RVA: 0x001466AC File Offset: 0x001448AC
		// (set) Token: 0x0600DDA5 RID: 56741 RVA: 0x001466E5 File Offset: 0x001448E5
		public FPlatformDelegate ApplicationWillTerminateDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformDelegate result;
				if ((result = this._ApplicationWillTerminateDelegate) == null)
				{
					result = (this._ApplicationWillTerminateDelegate = new FPlatformDelegate(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationWillTerminateDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationWillTerminateDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003442 RID: 13378
		// (get) Token: 0x0600DDA6 RID: 56742 RVA: 0x00146708 File Offset: 0x00144908
		// (set) Token: 0x0600DDA7 RID: 56743 RVA: 0x00146741 File Offset: 0x00144941
		public FPlatformDelegate ApplicationShouldUnloadResourcesDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformDelegate result;
				if ((result = this._ApplicationShouldUnloadResourcesDelegate) == null)
				{
					result = (this._ApplicationShouldUnloadResourcesDelegate = new FPlatformDelegate(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationShouldUnloadResourcesDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationShouldUnloadResourcesDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003443 RID: 13379
		// (get) Token: 0x0600DDA8 RID: 56744 RVA: 0x00146764 File Offset: 0x00144964
		// (set) Token: 0x0600DDA9 RID: 56745 RVA: 0x0014679D File Offset: 0x0014499D
		public FPlatformStartupArgumentsDelegate ApplicationReceivedStartupArgumentsDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformStartupArgumentsDelegate result;
				if ((result = this._ApplicationReceivedStartupArgumentsDelegate) == null)
				{
					result = (this._ApplicationReceivedStartupArgumentsDelegate = new FPlatformStartupArgumentsDelegate(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationReceivedStartupArgumentsDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationReceivedStartupArgumentsDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003444 RID: 13380
		// (get) Token: 0x0600DDAA RID: 56746 RVA: 0x001467C0 File Offset: 0x001449C0
		// (set) Token: 0x0600DDAB RID: 56747 RVA: 0x001467F9 File Offset: 0x001449F9
		public FPlatformRegisteredForRemoteNotificationsDelegate ApplicationRegisteredForRemoteNotificationsDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformRegisteredForRemoteNotificationsDelegate result;
				if ((result = this._ApplicationRegisteredForRemoteNotificationsDelegate) == null)
				{
					result = (this._ApplicationRegisteredForRemoteNotificationsDelegate = new FPlatformRegisteredForRemoteNotificationsDelegate(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationRegisteredForRemoteNotificationsDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationRegisteredForRemoteNotificationsDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003445 RID: 13381
		// (get) Token: 0x0600DDAC RID: 56748 RVA: 0x0014681C File Offset: 0x00144A1C
		// (set) Token: 0x0600DDAD RID: 56749 RVA: 0x00146855 File Offset: 0x00144A55
		public FPlatformRegisteredForUserNotificationsDelegate ApplicationRegisteredForUserNotificationsDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformRegisteredForUserNotificationsDelegate result;
				if ((result = this._ApplicationRegisteredForUserNotificationsDelegate) == null)
				{
					result = (this._ApplicationRegisteredForUserNotificationsDelegate = new FPlatformRegisteredForUserNotificationsDelegate(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationRegisteredForUserNotificationsDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationRegisteredForUserNotificationsDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003446 RID: 13382
		// (get) Token: 0x0600DDAE RID: 56750 RVA: 0x00146878 File Offset: 0x00144A78
		// (set) Token: 0x0600DDAF RID: 56751 RVA: 0x001468B1 File Offset: 0x00144AB1
		public FPlatformFailedToRegisterForRemoteNotificationsDelegate ApplicationFailedToRegisterForRemoteNotificationsDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformFailedToRegisterForRemoteNotificationsDelegate result;
				if ((result = this._ApplicationFailedToRegisterForRemoteNotificationsDelegate) == null)
				{
					result = (this._ApplicationFailedToRegisterForRemoteNotificationsDelegate = new FPlatformFailedToRegisterForRemoteNotificationsDelegate(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationFailedToRegisterForRemoteNotificationsDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationFailedToRegisterForRemoteNotificationsDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003447 RID: 13383
		// (get) Token: 0x0600DDB0 RID: 56752 RVA: 0x001468D4 File Offset: 0x00144AD4
		// (set) Token: 0x0600DDB1 RID: 56753 RVA: 0x0014690D File Offset: 0x00144B0D
		public FPlatformReceivedRemoteNotificationDelegate ApplicationReceivedRemoteNotificationDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformReceivedRemoteNotificationDelegate result;
				if ((result = this._ApplicationReceivedRemoteNotificationDelegate) == null)
				{
					result = (this._ApplicationReceivedRemoteNotificationDelegate = new FPlatformReceivedRemoteNotificationDelegate(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationReceivedRemoteNotificationDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationReceivedRemoteNotificationDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003448 RID: 13384
		// (get) Token: 0x0600DDB2 RID: 56754 RVA: 0x00146930 File Offset: 0x00144B30
		// (set) Token: 0x0600DDB3 RID: 56755 RVA: 0x00146969 File Offset: 0x00144B69
		public FPlatformReceivedLocalNotificationDelegate ApplicationReceivedLocalNotificationDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformReceivedLocalNotificationDelegate result;
				if ((result = this._ApplicationReceivedLocalNotificationDelegate) == null)
				{
					result = (this._ApplicationReceivedLocalNotificationDelegate = new FPlatformReceivedLocalNotificationDelegate(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationReceivedLocalNotificationDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationReceivedLocalNotificationDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003449 RID: 13385
		// (get) Token: 0x0600DDB4 RID: 56756 RVA: 0x0014698C File Offset: 0x00144B8C
		// (set) Token: 0x0600DDB5 RID: 56757 RVA: 0x001469C5 File Offset: 0x00144BC5
		public FPlatformScreenOrientationChangedDelegate ApplicationReceivedScreenOrientationChangedNotificationDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformScreenOrientationChangedDelegate result;
				if ((result = this._ApplicationReceivedScreenOrientationChangedNotificationDelegate) == null)
				{
					result = (this._ApplicationReceivedScreenOrientationChangedNotificationDelegate = new FPlatformScreenOrientationChangedDelegate(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationReceivedScreenOrientationChangedNotificationDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlatformGameInstance.__PropertyOffset_ApplicationReceivedScreenOrientationChangedNotificationDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600DDB6 RID: 56758 RVA: 0x001469E6 File Offset: 0x00144BE6
		static UPlatformGameInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlatformGameInstance");
		}

		// Token: 0x0600DDB7 RID: 56759 RVA: 0x001469F4 File Offset: 0x00144BF4
		protected UPlatformGameInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040077BC RID: 30652
		public new const string __ObjectPath = "/Script/Engine.PlatformGameInstance";

		// Token: 0x040077BD RID: 30653
		private static IntPtr _ClassPtr;

		// Token: 0x040077BE RID: 30654
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040077BF RID: 30655
		public static IntPtr __PlatformStartupArgumentsDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040077C0 RID: 30656
		public static IntPtr __PlatformScreenOrientationChangedDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040077C1 RID: 30657
		public static IntPtr __PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040077C2 RID: 30658
		public static IntPtr __PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040077C3 RID: 30659
		public static IntPtr __PlatformReceivedRemoteNotificationDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040077C4 RID: 30660
		public static IntPtr __PlatformReceivedLocalNotificationDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040077C5 RID: 30661
		public static IntPtr __PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040077C6 RID: 30662
		public static IntPtr __PlatformDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040077C7 RID: 30663
		internal static int __PropertyOffset_ApplicationWillDeactivateDelegate;

		// Token: 0x040077C8 RID: 30664
		[Nullable(2)]
		private FPlatformDelegate _ApplicationWillDeactivateDelegate;

		// Token: 0x040077C9 RID: 30665
		internal static int __PropertyOffset_ApplicationHasReactivatedDelegate;

		// Token: 0x040077CA RID: 30666
		[Nullable(2)]
		private FPlatformDelegate _ApplicationHasReactivatedDelegate;

		// Token: 0x040077CB RID: 30667
		internal static int __PropertyOffset_ApplicationWillEnterBackgroundDelegate;

		// Token: 0x040077CC RID: 30668
		[Nullable(2)]
		private FPlatformDelegate _ApplicationWillEnterBackgroundDelegate;

		// Token: 0x040077CD RID: 30669
		internal static int __PropertyOffset_ApplicationHasEnteredForegroundDelegate;

		// Token: 0x040077CE RID: 30670
		[Nullable(2)]
		private FPlatformDelegate _ApplicationHasEnteredForegroundDelegate;

		// Token: 0x040077CF RID: 30671
		internal static int __PropertyOffset_ApplicationWillTerminateDelegate;

		// Token: 0x040077D0 RID: 30672
		[Nullable(2)]
		private FPlatformDelegate _ApplicationWillTerminateDelegate;

		// Token: 0x040077D1 RID: 30673
		internal static int __PropertyOffset_ApplicationShouldUnloadResourcesDelegate;

		// Token: 0x040077D2 RID: 30674
		[Nullable(2)]
		private FPlatformDelegate _ApplicationShouldUnloadResourcesDelegate;

		// Token: 0x040077D3 RID: 30675
		internal static int __PropertyOffset_ApplicationReceivedStartupArgumentsDelegate;

		// Token: 0x040077D4 RID: 30676
		[Nullable(2)]
		private FPlatformStartupArgumentsDelegate _ApplicationReceivedStartupArgumentsDelegate;

		// Token: 0x040077D5 RID: 30677
		internal static int __PropertyOffset_ApplicationRegisteredForRemoteNotificationsDelegate;

		// Token: 0x040077D6 RID: 30678
		[Nullable(2)]
		private FPlatformRegisteredForRemoteNotificationsDelegate _ApplicationRegisteredForRemoteNotificationsDelegate;

		// Token: 0x040077D7 RID: 30679
		internal static int __PropertyOffset_ApplicationRegisteredForUserNotificationsDelegate;

		// Token: 0x040077D8 RID: 30680
		[Nullable(2)]
		private FPlatformRegisteredForUserNotificationsDelegate _ApplicationRegisteredForUserNotificationsDelegate;

		// Token: 0x040077D9 RID: 30681
		internal static int __PropertyOffset_ApplicationFailedToRegisterForRemoteNotificationsDelegate;

		// Token: 0x040077DA RID: 30682
		[Nullable(2)]
		private FPlatformFailedToRegisterForRemoteNotificationsDelegate _ApplicationFailedToRegisterForRemoteNotificationsDelegate;

		// Token: 0x040077DB RID: 30683
		internal static int __PropertyOffset_ApplicationReceivedRemoteNotificationDelegate;

		// Token: 0x040077DC RID: 30684
		[Nullable(2)]
		private FPlatformReceivedRemoteNotificationDelegate _ApplicationReceivedRemoteNotificationDelegate;

		// Token: 0x040077DD RID: 30685
		internal static int __PropertyOffset_ApplicationReceivedLocalNotificationDelegate;

		// Token: 0x040077DE RID: 30686
		[Nullable(2)]
		private FPlatformReceivedLocalNotificationDelegate _ApplicationReceivedLocalNotificationDelegate;

		// Token: 0x040077DF RID: 30687
		internal static int __PropertyOffset_ApplicationReceivedScreenOrientationChangedNotificationDelegate;

		// Token: 0x040077E0 RID: 30688
		[Nullable(2)]
		private FPlatformScreenOrientationChangedDelegate _ApplicationReceivedScreenOrientationChangedNotificationDelegate;
	}
}
