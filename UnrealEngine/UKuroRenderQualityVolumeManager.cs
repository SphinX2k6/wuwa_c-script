using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004DD RID: 1245
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroRenderQualityVolumeManager")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKuroRenderQualityVolumeManager : UEngineSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060075BD RID: 30141 RVA: 0x000AC185 File Offset: 0x000AA385
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRenderQualityVolumeManager._ClassPtr;
		}

		// Token: 0x060075BE RID: 30142 RVA: 0x000AC194 File Offset: 0x000AA394
		public UKuroRenderQualityVolumeManager() : this(BuiltinUtils.AllocNativeUObject(UKuroRenderQualityVolumeManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060075BF RID: 30143 RVA: 0x000AC1BC File Offset: 0x000AA3BC
		public UKuroRenderQualityVolumeManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRenderQualityVolumeManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x060075C0 RID: 30144 RVA: 0x000AC1F0 File Offset: 0x000AA3F0
		// (set) Token: 0x060075C1 RID: 30145 RVA: 0x000AC229 File Offset: 0x000AA429
		public FOnEnterVolumeBlueprintEvent OnEnterVolumeBlueprintEvent
		{
			get
			{
				base.FastCheckIsValid();
				FOnEnterVolumeBlueprintEvent result;
				if ((result = this._OnEnterVolumeBlueprintEvent) == null)
				{
					result = (this._OnEnterVolumeBlueprintEvent = new FOnEnterVolumeBlueprintEvent(base.NativePtr + (IntPtr)UKuroRenderQualityVolumeManager.__PropertyOffset_OnEnterVolumeBlueprintEvent, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroRenderQualityVolumeManager.__PropertyOffset_OnEnterVolumeBlueprintEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x060075C2 RID: 30146 RVA: 0x000AC24C File Offset: 0x000AA44C
		// (set) Token: 0x060075C3 RID: 30147 RVA: 0x000AC285 File Offset: 0x000AA485
		public FOnLeaveVolumeBlueprintEvent OnLeaveVolumeBlueprintEvent
		{
			get
			{
				base.FastCheckIsValid();
				FOnLeaveVolumeBlueprintEvent result;
				if ((result = this._OnLeaveVolumeBlueprintEvent) == null)
				{
					result = (this._OnLeaveVolumeBlueprintEvent = new FOnLeaveVolumeBlueprintEvent(base.NativePtr + (IntPtr)UKuroRenderQualityVolumeManager.__PropertyOffset_OnLeaveVolumeBlueprintEvent, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroRenderQualityVolumeManager.__PropertyOffset_OnLeaveVolumeBlueprintEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x060075C4 RID: 30148 RVA: 0x000AC2A8 File Offset: 0x000AA4A8
		// (set) Token: 0x060075C5 RID: 30149 RVA: 0x000AC2E1 File Offset: 0x000AA4E1
		public FOnApplyKuroRenderLocalSettingsBlueprintEvent OnApplyKuroRenderLocalSettingsBlueprintEvent
		{
			get
			{
				base.FastCheckIsValid();
				FOnApplyKuroRenderLocalSettingsBlueprintEvent result;
				if ((result = this._OnApplyKuroRenderLocalSettingsBlueprintEvent) == null)
				{
					result = (this._OnApplyKuroRenderLocalSettingsBlueprintEvent = new FOnApplyKuroRenderLocalSettingsBlueprintEvent(base.NativePtr + (IntPtr)UKuroRenderQualityVolumeManager.__PropertyOffset_OnApplyKuroRenderLocalSettingsBlueprintEvent, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroRenderQualityVolumeManager.__PropertyOffset_OnApplyKuroRenderLocalSettingsBlueprintEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060075C6 RID: 30150
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsLowMemoryMobile();

		// Token: 0x060075C7 RID: 30151
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsLowMemoryDesktop();

		// Token: 0x060075C8 RID: 30152
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsKuroRenderQualityVolumeEnable();

		// Token: 0x060075C9 RID: 30153 RVA: 0x000AC302 File Offset: 0x000AA502
		static UKuroRenderQualityVolumeManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroRenderQualityVolumeManager");
		}

		// Token: 0x060075CA RID: 30154 RVA: 0x000AC310 File Offset: 0x000AA510
		protected UKuroRenderQualityVolumeManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040031A9 RID: 12713
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroRenderQualityVolumeManager";

		// Token: 0x040031AA RID: 12714
		private static IntPtr _ClassPtr;

		// Token: 0x040031AB RID: 12715
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040031AC RID: 12716
		internal static int __PropertyOffset_OnEnterVolumeBlueprintEvent;

		// Token: 0x040031AD RID: 12717
		[Nullable(2)]
		private FOnEnterVolumeBlueprintEvent _OnEnterVolumeBlueprintEvent;

		// Token: 0x040031AE RID: 12718
		internal static int __PropertyOffset_OnLeaveVolumeBlueprintEvent;

		// Token: 0x040031AF RID: 12719
		[Nullable(2)]
		private FOnLeaveVolumeBlueprintEvent _OnLeaveVolumeBlueprintEvent;

		// Token: 0x040031B0 RID: 12720
		internal static int __PropertyOffset_OnApplyKuroRenderLocalSettingsBlueprintEvent;

		// Token: 0x040031B1 RID: 12721
		[Nullable(2)]
		private FOnApplyKuroRenderLocalSettingsBlueprintEvent _OnApplyKuroRenderLocalSettingsBlueprintEvent;
	}
}
