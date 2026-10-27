using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001152 RID: 4434
	[UnrealObjectPath("/Script/Engine.SoundSourceBus")]
	[UnrealStructLayout(1304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1304)]
	public class USoundSourceBus : USoundWave, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010313 RID: 66323 RVA: 0x0017DCC6 File Offset: 0x0017BEC6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundSourceBus._ClassPtr;
		}

		// Token: 0x06010314 RID: 66324 RVA: 0x0017DCD4 File Offset: 0x0017BED4
		public USoundSourceBus() : this(BuiltinUtils.AllocNativeUObject(USoundSourceBus.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010315 RID: 66325 RVA: 0x0017DCFC File Offset: 0x0017BEFC
		[NullableContext(1)]
		public USoundSourceBus(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundSourceBus.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F68 RID: 16232
		// (get) Token: 0x06010316 RID: 66326 RVA: 0x0017DD2F File Offset: 0x0017BF2F
		// (set) Token: 0x06010317 RID: 66327 RVA: 0x0017DD3F File Offset: 0x0017BF3F
		public unsafe ESourceBusChannels SourceBusChannels
		{
			get
			{
				return (ESourceBusChannels)(*(base.NativePtr + (IntPtr)USoundSourceBus.__PropertyOffset_SourceBusChannels));
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundSourceBus.__PropertyOffset_SourceBusChannels) = (byte)value;
			}
		}

		// Token: 0x17003F69 RID: 16233
		// (get) Token: 0x06010318 RID: 66328 RVA: 0x0017DD50 File Offset: 0x0017BF50
		// (set) Token: 0x06010319 RID: 66329 RVA: 0x0017DD60 File Offset: 0x0017BF60
		public unsafe float SourceBusDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundSourceBus.__PropertyOffset_SourceBusDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundSourceBus.__PropertyOffset_SourceBusDuration) = value;
			}
		}

		// Token: 0x17003F6A RID: 16234
		// (get) Token: 0x0601031A RID: 66330 RVA: 0x0017DD71 File Offset: 0x0017BF71
		// (set) Token: 0x0601031B RID: 66331 RVA: 0x0017DD85 File Offset: 0x0017BF85
		[Nullable(2)]
		public unsafe UAudioBus AudioBus
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAudioBus>(base.NativePtr / (IntPtr)sizeof(void*) + USoundSourceBus.__PropertyOffset_AudioBus);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundSourceBus.__PropertyOffset_AudioBus, value);
			}
		}

		// Token: 0x17003F6B RID: 16235
		// (get) Token: 0x0601031C RID: 66332 RVA: 0x0017DD9A File Offset: 0x0017BF9A
		// (set) Token: 0x0601031D RID: 66333 RVA: 0x0017DDB3 File Offset: 0x0017BFB3
		public unsafe bool bAutoDeactivateWhenSilent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundSourceBus.__PropertyOffset_bAutoDeactivateWhenSilent) & USoundSourceBus.__PropertyMask_bAutoDeactivateWhenSilent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundSourceBus.__PropertyOffset_bAutoDeactivateWhenSilent) = ((*(base.NativePtr + (IntPtr)USoundSourceBus.__PropertyOffset_bAutoDeactivateWhenSilent) & ~USoundSourceBus.__PropertyMask_bAutoDeactivateWhenSilent) | (value ? USoundSourceBus.__PropertyMask_bAutoDeactivateWhenSilent : 0));
			}
		}

		// Token: 0x0601031E RID: 66334 RVA: 0x0017DDE3 File Offset: 0x0017BFE3
		static USoundSourceBus()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundSourceBus");
		}

		// Token: 0x0601031F RID: 66335 RVA: 0x0017DDF1 File Offset: 0x0017BFF1
		protected USoundSourceBus(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008B6D RID: 35693
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundSourceBus";

		// Token: 0x04008B6E RID: 35694
		private static IntPtr _ClassPtr;

		// Token: 0x04008B6F RID: 35695
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008B70 RID: 35696
		internal static int __PropertyOffset_SourceBusChannels;

		// Token: 0x04008B71 RID: 35697
		internal static int __PropertyOffset_SourceBusDuration;

		// Token: 0x04008B72 RID: 35698
		internal static int __PropertyOffset_AudioBus;

		// Token: 0x04008B73 RID: 35699
		internal static int __PropertyOffset_bAutoDeactivateWhenSilent;

		// Token: 0x04008B74 RID: 35700
		internal static byte __PropertyMask_bAutoDeactivateWhenSilent;
	}
}
