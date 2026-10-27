using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200084D RID: 2125
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ApplicationLifecycleComponent")]
	[UnrealStructLayout(344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 344)]
	public class UApplicationLifecycleComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007293 RID: 29331 RVA: 0x000A40B6 File Offset: 0x000A22B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UApplicationLifecycleComponent._ClassPtr;
		}

		// Token: 0x06007294 RID: 29332 RVA: 0x000A40C4 File Offset: 0x000A22C4
		public UApplicationLifecycleComponent() : this(BuiltinUtils.AllocNativeUObject(UApplicationLifecycleComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007295 RID: 29333 RVA: 0x000A40EC File Offset: 0x000A22EC
		public UApplicationLifecycleComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UApplicationLifecycleComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x06007296 RID: 29334 RVA: 0x000A4120 File Offset: 0x000A2320
		// (set) Token: 0x06007297 RID: 29335 RVA: 0x000A4159 File Offset: 0x000A2359
		public FApplicationLifetimeDelegate ApplicationWillDeactivateDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FApplicationLifetimeDelegate result;
				if ((result = this._ApplicationWillDeactivateDelegate) == null)
				{
					result = (this._ApplicationWillDeactivateDelegate = new FApplicationLifetimeDelegate(base.NativePtr + (IntPtr)UApplicationLifecycleComponent.__PropertyOffset_ApplicationWillDeactivateDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UApplicationLifecycleComponent.__PropertyOffset_ApplicationWillDeactivateDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x06007298 RID: 29336 RVA: 0x000A417C File Offset: 0x000A237C
		// (set) Token: 0x06007299 RID: 29337 RVA: 0x000A41B5 File Offset: 0x000A23B5
		public FApplicationLifetimeDelegate ApplicationHasReactivatedDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FApplicationLifetimeDelegate result;
				if ((result = this._ApplicationHasReactivatedDelegate) == null)
				{
					result = (this._ApplicationHasReactivatedDelegate = new FApplicationLifetimeDelegate(base.NativePtr + (IntPtr)UApplicationLifecycleComponent.__PropertyOffset_ApplicationHasReactivatedDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UApplicationLifecycleComponent.__PropertyOffset_ApplicationHasReactivatedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x0600729A RID: 29338 RVA: 0x000A41D8 File Offset: 0x000A23D8
		// (set) Token: 0x0600729B RID: 29339 RVA: 0x000A4211 File Offset: 0x000A2411
		public FApplicationLifetimeDelegate ApplicationWillEnterBackgroundDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FApplicationLifetimeDelegate result;
				if ((result = this._ApplicationWillEnterBackgroundDelegate) == null)
				{
					result = (this._ApplicationWillEnterBackgroundDelegate = new FApplicationLifetimeDelegate(base.NativePtr + (IntPtr)UApplicationLifecycleComponent.__PropertyOffset_ApplicationWillEnterBackgroundDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UApplicationLifecycleComponent.__PropertyOffset_ApplicationWillEnterBackgroundDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x0600729C RID: 29340 RVA: 0x000A4234 File Offset: 0x000A2434
		// (set) Token: 0x0600729D RID: 29341 RVA: 0x000A426D File Offset: 0x000A246D
		public FApplicationLifetimeDelegate ApplicationHasEnteredForegroundDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FApplicationLifetimeDelegate result;
				if ((result = this._ApplicationHasEnteredForegroundDelegate) == null)
				{
					result = (this._ApplicationHasEnteredForegroundDelegate = new FApplicationLifetimeDelegate(base.NativePtr + (IntPtr)UApplicationLifecycleComponent.__PropertyOffset_ApplicationHasEnteredForegroundDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UApplicationLifecycleComponent.__PropertyOffset_ApplicationHasEnteredForegroundDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x0600729E RID: 29342 RVA: 0x000A4290 File Offset: 0x000A2490
		// (set) Token: 0x0600729F RID: 29343 RVA: 0x000A42C9 File Offset: 0x000A24C9
		public FApplicationLifetimeDelegate ApplicationWillTerminateDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FApplicationLifetimeDelegate result;
				if ((result = this._ApplicationWillTerminateDelegate) == null)
				{
					result = (this._ApplicationWillTerminateDelegate = new FApplicationLifetimeDelegate(base.NativePtr + (IntPtr)UApplicationLifecycleComponent.__PropertyOffset_ApplicationWillTerminateDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UApplicationLifecycleComponent.__PropertyOffset_ApplicationWillTerminateDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x060072A0 RID: 29344 RVA: 0x000A42EC File Offset: 0x000A24EC
		// (set) Token: 0x060072A1 RID: 29345 RVA: 0x000A4325 File Offset: 0x000A2525
		public FApplicationLifetimeDelegate ApplicationShouldUnloadResourcesDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FApplicationLifetimeDelegate result;
				if ((result = this._ApplicationShouldUnloadResourcesDelegate) == null)
				{
					result = (this._ApplicationShouldUnloadResourcesDelegate = new FApplicationLifetimeDelegate(base.NativePtr + (IntPtr)UApplicationLifecycleComponent.__PropertyOffset_ApplicationShouldUnloadResourcesDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UApplicationLifecycleComponent.__PropertyOffset_ApplicationShouldUnloadResourcesDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x060072A2 RID: 29346 RVA: 0x000A4348 File Offset: 0x000A2548
		// (set) Token: 0x060072A3 RID: 29347 RVA: 0x000A4381 File Offset: 0x000A2581
		public FApplicationStartupArgumentsDelegate ApplicationReceivedStartupArgumentsDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FApplicationStartupArgumentsDelegate result;
				if ((result = this._ApplicationReceivedStartupArgumentsDelegate) == null)
				{
					result = (this._ApplicationReceivedStartupArgumentsDelegate = new FApplicationStartupArgumentsDelegate(base.NativePtr + (IntPtr)UApplicationLifecycleComponent.__PropertyOffset_ApplicationReceivedStartupArgumentsDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UApplicationLifecycleComponent.__PropertyOffset_ApplicationReceivedStartupArgumentsDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x060072A4 RID: 29348 RVA: 0x000A43A4 File Offset: 0x000A25A4
		// (set) Token: 0x060072A5 RID: 29349 RVA: 0x000A43DD File Offset: 0x000A25DD
		public FOnTemperatureChangeDelegate OnTemperatureChangeDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FOnTemperatureChangeDelegate result;
				if ((result = this._OnTemperatureChangeDelegate) == null)
				{
					result = (this._OnTemperatureChangeDelegate = new FOnTemperatureChangeDelegate(base.NativePtr + (IntPtr)UApplicationLifecycleComponent.__PropertyOffset_OnTemperatureChangeDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UApplicationLifecycleComponent.__PropertyOffset_OnTemperatureChangeDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x060072A6 RID: 29350 RVA: 0x000A4400 File Offset: 0x000A2600
		// (set) Token: 0x060072A7 RID: 29351 RVA: 0x000A4439 File Offset: 0x000A2639
		public FOnLowPowerModeDelegate OnLowPowerModeDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FOnLowPowerModeDelegate result;
				if ((result = this._OnLowPowerModeDelegate) == null)
				{
					result = (this._OnLowPowerModeDelegate = new FOnLowPowerModeDelegate(base.NativePtr + (IntPtr)UApplicationLifecycleComponent.__PropertyOffset_OnLowPowerModeDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UApplicationLifecycleComponent.__PropertyOffset_OnLowPowerModeDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060072A8 RID: 29352 RVA: 0x000A445A File Offset: 0x000A265A
		static UApplicationLifecycleComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ApplicationLifecycleComponent");
		}

		// Token: 0x060072A9 RID: 29353 RVA: 0x000A4468 File Offset: 0x000A2668
		protected UApplicationLifecycleComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003707 RID: 14087
		public new const string __ObjectPath = "/Script/Engine.ApplicationLifecycleComponent";

		// Token: 0x04003708 RID: 14088
		private static IntPtr _ClassPtr;

		// Token: 0x04003709 RID: 14089
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400370A RID: 14090
		public static IntPtr __OnTemperatureChangeDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400370B RID: 14091
		public static IntPtr __OnLowPowerModeDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400370C RID: 14092
		public static IntPtr __ApplicationStartupArgumentsDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400370D RID: 14093
		public static IntPtr __ApplicationLifetimeDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400370E RID: 14094
		internal static int __PropertyOffset_ApplicationWillDeactivateDelegate;

		// Token: 0x0400370F RID: 14095
		[Nullable(2)]
		private FApplicationLifetimeDelegate _ApplicationWillDeactivateDelegate;

		// Token: 0x04003710 RID: 14096
		internal static int __PropertyOffset_ApplicationHasReactivatedDelegate;

		// Token: 0x04003711 RID: 14097
		[Nullable(2)]
		private FApplicationLifetimeDelegate _ApplicationHasReactivatedDelegate;

		// Token: 0x04003712 RID: 14098
		internal static int __PropertyOffset_ApplicationWillEnterBackgroundDelegate;

		// Token: 0x04003713 RID: 14099
		[Nullable(2)]
		private FApplicationLifetimeDelegate _ApplicationWillEnterBackgroundDelegate;

		// Token: 0x04003714 RID: 14100
		internal static int __PropertyOffset_ApplicationHasEnteredForegroundDelegate;

		// Token: 0x04003715 RID: 14101
		[Nullable(2)]
		private FApplicationLifetimeDelegate _ApplicationHasEnteredForegroundDelegate;

		// Token: 0x04003716 RID: 14102
		internal static int __PropertyOffset_ApplicationWillTerminateDelegate;

		// Token: 0x04003717 RID: 14103
		[Nullable(2)]
		private FApplicationLifetimeDelegate _ApplicationWillTerminateDelegate;

		// Token: 0x04003718 RID: 14104
		internal static int __PropertyOffset_ApplicationShouldUnloadResourcesDelegate;

		// Token: 0x04003719 RID: 14105
		[Nullable(2)]
		private FApplicationLifetimeDelegate _ApplicationShouldUnloadResourcesDelegate;

		// Token: 0x0400371A RID: 14106
		internal static int __PropertyOffset_ApplicationReceivedStartupArgumentsDelegate;

		// Token: 0x0400371B RID: 14107
		[Nullable(2)]
		private FApplicationStartupArgumentsDelegate _ApplicationReceivedStartupArgumentsDelegate;

		// Token: 0x0400371C RID: 14108
		internal static int __PropertyOffset_OnTemperatureChangeDelegate;

		// Token: 0x0400371D RID: 14109
		[Nullable(2)]
		private FOnTemperatureChangeDelegate _OnTemperatureChangeDelegate;

		// Token: 0x0400371E RID: 14110
		internal static int __PropertyOffset_OnLowPowerModeDelegate;

		// Token: 0x0400371F RID: 14111
		[Nullable(2)]
		private FOnLowPowerModeDelegate _OnLowPowerModeDelegate;
	}
}
