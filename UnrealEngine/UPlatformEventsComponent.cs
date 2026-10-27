using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FFB RID: 4091
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PlatformEventsComponent")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UPlatformEventsComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DD80 RID: 56704 RVA: 0x0014620A File Offset: 0x0014440A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlatformEventsComponent._ClassPtr;
		}

		// Token: 0x0600DD81 RID: 56705 RVA: 0x00146218 File Offset: 0x00144418
		public UPlatformEventsComponent() : this(BuiltinUtils.AllocNativeUObject(UPlatformEventsComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DD82 RID: 56706 RVA: 0x00146240 File Offset: 0x00144440
		public UPlatformEventsComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPlatformEventsComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700343B RID: 13371
		// (get) Token: 0x0600DD83 RID: 56707 RVA: 0x00146274 File Offset: 0x00144474
		// (set) Token: 0x0600DD84 RID: 56708 RVA: 0x001462AD File Offset: 0x001444AD
		public FPlatformEventDelegate PlatformChangedToLaptopModeDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformEventDelegate result;
				if ((result = this._PlatformChangedToLaptopModeDelegate) == null)
				{
					result = (this._PlatformChangedToLaptopModeDelegate = new FPlatformEventDelegate(base.NativePtr + (IntPtr)UPlatformEventsComponent.__PropertyOffset_PlatformChangedToLaptopModeDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlatformEventsComponent.__PropertyOffset_PlatformChangedToLaptopModeDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700343C RID: 13372
		// (get) Token: 0x0600DD85 RID: 56709 RVA: 0x001462D0 File Offset: 0x001444D0
		// (set) Token: 0x0600DD86 RID: 56710 RVA: 0x00146309 File Offset: 0x00144509
		public FPlatformEventDelegate PlatformChangedToTabletModeDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FPlatformEventDelegate result;
				if ((result = this._PlatformChangedToTabletModeDelegate) == null)
				{
					result = (this._PlatformChangedToTabletModeDelegate = new FPlatformEventDelegate(base.NativePtr + (IntPtr)UPlatformEventsComponent.__PropertyOffset_PlatformChangedToTabletModeDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPlatformEventsComponent.__PropertyOffset_PlatformChangedToTabletModeDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600DD87 RID: 56711 RVA: 0x0014632A File Offset: 0x0014452A
		public bool SupportsConvertibleLaptops()
		{
			return UPlatformEventsComponent.__SupportsConvertibleLaptops_Internal(base.NativePtr);
		}

		// Token: 0x0600DD88 RID: 56712 RVA: 0x00146337 File Offset: 0x00144537
		public bool IsInTabletMode()
		{
			return UPlatformEventsComponent.__IsInTabletMode_Internal(base.NativePtr);
		}

		// Token: 0x0600DD89 RID: 56713 RVA: 0x00146344 File Offset: 0x00144544
		public bool IsInLaptopMode()
		{
			return UPlatformEventsComponent.__IsInLaptopMode_Internal(base.NativePtr);
		}

		// Token: 0x0600DD8A RID: 56714
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SupportsConvertibleLaptops_Internal(IntPtr @this);

		// Token: 0x0600DD8B RID: 56715
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInTabletMode_Internal(IntPtr @this);

		// Token: 0x0600DD8C RID: 56716
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInLaptopMode_Internal(IntPtr @this);

		// Token: 0x0600DD8D RID: 56717 RVA: 0x00146351 File Offset: 0x00144551
		static UPlatformEventsComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlatformEventsComponent");
		}

		// Token: 0x0600DD8E RID: 56718 RVA: 0x0014635F File Offset: 0x0014455F
		protected UPlatformEventsComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040077B2 RID: 30642
		public new const string __ObjectPath = "/Script/Engine.PlatformEventsComponent";

		// Token: 0x040077B3 RID: 30643
		private static IntPtr _ClassPtr;

		// Token: 0x040077B4 RID: 30644
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040077B5 RID: 30645
		public static IntPtr __PlatformEventDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040077B6 RID: 30646
		internal static int __PropertyOffset_PlatformChangedToLaptopModeDelegate;

		// Token: 0x040077B7 RID: 30647
		[Nullable(2)]
		private FPlatformEventDelegate _PlatformChangedToLaptopModeDelegate;

		// Token: 0x040077B8 RID: 30648
		internal static int __PropertyOffset_PlatformChangedToTabletModeDelegate;

		// Token: 0x040077B9 RID: 30649
		[Nullable(2)]
		private FPlatformEventDelegate _PlatformChangedToTabletModeDelegate;
	}
}
