using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BA2 RID: 7074
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroRenderQualityVolumeManager")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKuroRenderQualityVolumeManager : UEngineSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B0E7 RID: 110823 RVA: 0x0027DCF2 File Offset: 0x0027BEF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRenderQualityVolumeManager._ClassPtr;
		}

		// Token: 0x0601B0E8 RID: 110824 RVA: 0x0027DD00 File Offset: 0x0027BF00
		public UKuroRenderQualityVolumeManager() : this(BuiltinUtils.AllocNativeUObject(UKuroRenderQualityVolumeManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B0E9 RID: 110825 RVA: 0x0027DD28 File Offset: 0x0027BF28
		public UKuroRenderQualityVolumeManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRenderQualityVolumeManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C73 RID: 27763
		// (get) Token: 0x0601B0EA RID: 110826 RVA: 0x0027DD5C File Offset: 0x0027BF5C
		// (set) Token: 0x0601B0EB RID: 110827 RVA: 0x0027DD95 File Offset: 0x0027BF95
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

		// Token: 0x17006C74 RID: 27764
		// (get) Token: 0x0601B0EC RID: 110828 RVA: 0x0027DDB8 File Offset: 0x0027BFB8
		// (set) Token: 0x0601B0ED RID: 110829 RVA: 0x0027DDF1 File Offset: 0x0027BFF1
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

		// Token: 0x17006C75 RID: 27765
		// (get) Token: 0x0601B0EE RID: 110830 RVA: 0x0027DE14 File Offset: 0x0027C014
		// (set) Token: 0x0601B0EF RID: 110831 RVA: 0x0027DE4D File Offset: 0x0027C04D
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

		// Token: 0x0601B0F0 RID: 110832
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsLowMemoryMobile();

		// Token: 0x0601B0F1 RID: 110833
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsLowMemoryDesktop();

		// Token: 0x0601B0F2 RID: 110834
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsKuroRenderQualityVolumeEnable();

		// Token: 0x0601B0F3 RID: 110835 RVA: 0x0027DE6E File Offset: 0x0027C06E
		static UKuroRenderQualityVolumeManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroRenderQualityVolumeManager");
		}

		// Token: 0x0601B0F4 RID: 110836 RVA: 0x0027DE7C File Offset: 0x0027C07C
		protected UKuroRenderQualityVolumeManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E911 RID: 59665
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroRenderQualityVolumeManager";

		// Token: 0x0400E912 RID: 59666
		private static IntPtr _ClassPtr;

		// Token: 0x0400E913 RID: 59667
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E914 RID: 59668
		internal static int __PropertyOffset_OnEnterVolumeBlueprintEvent;

		// Token: 0x0400E915 RID: 59669
		[Nullable(2)]
		private FOnEnterVolumeBlueprintEvent _OnEnterVolumeBlueprintEvent;

		// Token: 0x0400E916 RID: 59670
		internal static int __PropertyOffset_OnLeaveVolumeBlueprintEvent;

		// Token: 0x0400E917 RID: 59671
		[Nullable(2)]
		private FOnLeaveVolumeBlueprintEvent _OnLeaveVolumeBlueprintEvent;

		// Token: 0x0400E918 RID: 59672
		internal static int __PropertyOffset_OnApplyKuroRenderLocalSettingsBlueprintEvent;

		// Token: 0x0400E919 RID: 59673
		[Nullable(2)]
		private FOnApplyKuroRenderLocalSettingsBlueprintEvent _OnApplyKuroRenderLocalSettingsBlueprintEvent;
	}
}
