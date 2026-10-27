using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000870 RID: 2160
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AudioVolume")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1216)]
	public class AAudioVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007557 RID: 30039 RVA: 0x000A8421 File Offset: 0x000A6621
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AAudioVolume._ClassPtr;
		}

		// Token: 0x06007558 RID: 30040 RVA: 0x000A8430 File Offset: 0x000A6630
		public AAudioVolume() : this(BuiltinUtils.AllocNativeUObject(AAudioVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007559 RID: 30041 RVA: 0x000A8458 File Offset: 0x000A6658
		public AAudioVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AAudioVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x0600755A RID: 30042 RVA: 0x000A848B File Offset: 0x000A668B
		// (set) Token: 0x0600755B RID: 30043 RVA: 0x000A849B File Offset: 0x000A669B
		public unsafe float Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AAudioVolume.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AAudioVolume.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x0600755C RID: 30044 RVA: 0x000A84AC File Offset: 0x000A66AC
		// (set) Token: 0x0600755D RID: 30045 RVA: 0x000A84C5 File Offset: 0x000A66C5
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AAudioVolume.__PropertyOffset_bEnabled) & AAudioVolume.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AAudioVolume.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)AAudioVolume.__PropertyOffset_bEnabled) & ~AAudioVolume.__PropertyMask_bEnabled) | (value ? AAudioVolume.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x0600755E RID: 30046 RVA: 0x000A84F8 File Offset: 0x000A66F8
		// (set) Token: 0x0600755F RID: 30047 RVA: 0x000A8531 File Offset: 0x000A6731
		public FReverbSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FReverbSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FReverbSettings(base.NativePtr + (IntPtr)AAudioVolume.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FReverbSettings.StaticStruct(), base.NativePtr + (IntPtr)AAudioVolume.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x06007560 RID: 30048 RVA: 0x000A8554 File Offset: 0x000A6754
		// (set) Token: 0x06007561 RID: 30049 RVA: 0x000A858D File Offset: 0x000A678D
		public FInteriorSettings AmbientZoneSettings
		{
			get
			{
				base.FastCheckIsValid();
				FInteriorSettings result;
				if ((result = this._AmbientZoneSettings) == null)
				{
					result = (this._AmbientZoneSettings = new FInteriorSettings(base.NativePtr + (IntPtr)AAudioVolume.__PropertyOffset_AmbientZoneSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInteriorSettings.StaticStruct(), base.NativePtr + (IntPtr)AAudioVolume.__PropertyOffset_AmbientZoneSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x06007562 RID: 30050 RVA: 0x000A85B0 File Offset: 0x000A67B0
		// (set) Token: 0x06007563 RID: 30051 RVA: 0x000A85E9 File Offset: 0x000A67E9
		public TArray<FAudioVolumeSubmixSendSettings> SubmixSendSettings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAudioVolumeSubmixSendSettings> result;
				if ((result = this._SubmixSendSettings) == null)
				{
					result = (this._SubmixSendSettings = new TArray<FAudioVolumeSubmixSendSettings>(base.NativePtr + (IntPtr)AAudioVolume.__PropertyOffset_SubmixSendSettings, this));
				}
				return result;
			}
			set
			{
				this.SubmixSendSettings.CopyAssign(value);
			}
		}

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x06007564 RID: 30052 RVA: 0x000A85F8 File Offset: 0x000A67F8
		// (set) Token: 0x06007565 RID: 30053 RVA: 0x000A8631 File Offset: 0x000A6831
		public TArray<FAudioVolumeSubmixOverrideSettings> SubmixOverrideSettings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAudioVolumeSubmixOverrideSettings> result;
				if ((result = this._SubmixOverrideSettings) == null)
				{
					result = (this._SubmixOverrideSettings = new TArray<FAudioVolumeSubmixOverrideSettings>(base.NativePtr + (IntPtr)AAudioVolume.__PropertyOffset_SubmixOverrideSettings, this));
				}
				return result;
			}
			set
			{
				this.SubmixOverrideSettings.CopyAssign(value);
			}
		}

		// Token: 0x06007566 RID: 30054 RVA: 0x000A863F File Offset: 0x000A683F
		public void SetSubmixSendSettings([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FAudioVolumeSubmixSendSettings> NewSubmixSendSettings)
		{
			AAudioVolume.__SetSubmixSendSettings_Internal(base.NativePtr, (NewSubmixSendSettings ?? new TArray<FAudioVolumeSubmixSendSettings>()).NativePtr);
		}

		// Token: 0x06007567 RID: 30055 RVA: 0x000A865C File Offset: 0x000A685C
		public void SetSubmixOverrideSettings([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FAudioVolumeSubmixOverrideSettings> NewSubmixOverrideSettings)
		{
			AAudioVolume.__SetSubmixOverrideSettings_Internal(base.NativePtr, (NewSubmixOverrideSettings ?? new TArray<FAudioVolumeSubmixOverrideSettings>()).NativePtr);
		}

		// Token: 0x06007568 RID: 30056 RVA: 0x000A8679 File Offset: 0x000A6879
		[NullableContext(2)]
		public void SetReverbSettings(in FReverbSettings NewReverbSettings)
		{
			AAudioVolume.__SetReverbSettings_Internal(base.NativePtr, (NewReverbSettings ?? new FReverbSettings()).NativePtr);
		}

		// Token: 0x06007569 RID: 30057 RVA: 0x000A8696 File Offset: 0x000A6896
		public void SetPriority(float NewPriority)
		{
			AAudioVolume.__SetPriority_Internal(base.NativePtr, NewPriority);
		}

		// Token: 0x0600756A RID: 30058 RVA: 0x000A86A4 File Offset: 0x000A68A4
		[NullableContext(2)]
		public void SetInteriorSettings(in FInteriorSettings NewInteriorSettings)
		{
			AAudioVolume.__SetInteriorSettings_Internal(base.NativePtr, (NewInteriorSettings ?? new FInteriorSettings()).NativePtr);
		}

		// Token: 0x0600756B RID: 30059 RVA: 0x000A86C1 File Offset: 0x000A68C1
		public void SetEnabled(bool bNewEnabled)
		{
			AAudioVolume.__SetEnabled_Internal(base.NativePtr, bNewEnabled);
		}

		// Token: 0x0600756C RID: 30060 RVA: 0x000A86CF File Offset: 0x000A68CF
		public void OnRep_bEnabled()
		{
			AAudioVolume.__OnRep_bEnabled_Internal(base.NativePtr);
		}

		// Token: 0x0600756D RID: 30061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSubmixSendSettings_Internal(IntPtr @this, IntPtr NewSubmixSendSettings);

		// Token: 0x0600756E RID: 30062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSubmixOverrideSettings_Internal(IntPtr @this, IntPtr NewSubmixOverrideSettings);

		// Token: 0x0600756F RID: 30063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReverbSettings_Internal(IntPtr @this, IntPtr NewReverbSettings);

		// Token: 0x06007570 RID: 30064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPriority_Internal(IntPtr @this, float NewPriority);

		// Token: 0x06007571 RID: 30065
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInteriorSettings_Internal(IntPtr @this, IntPtr NewInteriorSettings);

		// Token: 0x06007572 RID: 30066
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnabled_Internal(IntPtr @this, bool bNewEnabled);

		// Token: 0x06007573 RID: 30067
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_bEnabled_Internal(IntPtr @this);

		// Token: 0x06007574 RID: 30068 RVA: 0x000A86DC File Offset: 0x000A68DC
		static AAudioVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AudioVolume");
		}

		// Token: 0x06007575 RID: 30069 RVA: 0x000A86EA File Offset: 0x000A68EA
		protected AAudioVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003873 RID: 14451
		public new const string __ObjectPath = "/Script/Engine.AudioVolume";

		// Token: 0x04003874 RID: 14452
		private static IntPtr _ClassPtr;

		// Token: 0x04003875 RID: 14453
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003876 RID: 14454
		internal static int __PropertyOffset_Priority;

		// Token: 0x04003877 RID: 14455
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04003878 RID: 14456
		internal static byte __PropertyMask_bEnabled;

		// Token: 0x04003879 RID: 14457
		internal static int __PropertyOffset_Settings;

		// Token: 0x0400387A RID: 14458
		[Nullable(2)]
		private FReverbSettings _Settings;

		// Token: 0x0400387B RID: 14459
		internal static int __PropertyOffset_AmbientZoneSettings;

		// Token: 0x0400387C RID: 14460
		[Nullable(2)]
		private FInteriorSettings _AmbientZoneSettings;

		// Token: 0x0400387D RID: 14461
		internal static int __PropertyOffset_SubmixSendSettings;

		// Token: 0x0400387E RID: 14462
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAudioVolumeSubmixSendSettings> _SubmixSendSettings;

		// Token: 0x0400387F RID: 14463
		internal static int __PropertyOffset_SubmixOverrideSettings;

		// Token: 0x04003880 RID: 14464
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAudioVolumeSubmixOverrideSettings> _SubmixOverrideSettings;
	}
}
