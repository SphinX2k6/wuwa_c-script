using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000867 RID: 2151
	[UnrealObjectPath("/Script/Engine.AudioBus")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UAudioBus : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600742E RID: 29742 RVA: 0x000A6A68 File Offset: 0x000A4C68
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAudioBus._ClassPtr;
		}

		// Token: 0x0600742F RID: 29743 RVA: 0x000A6A74 File Offset: 0x000A4C74
		public UAudioBus() : this(BuiltinUtils.AllocNativeUObject(UAudioBus.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007430 RID: 29744 RVA: 0x000A6A9C File Offset: 0x000A4C9C
		[NullableContext(1)]
		public UAudioBus(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAudioBus.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x06007431 RID: 29745 RVA: 0x000A6ACF File Offset: 0x000A4CCF
		// (set) Token: 0x06007432 RID: 29746 RVA: 0x000A6ADF File Offset: 0x000A4CDF
		public unsafe EAudioBusChannels AudioBusChannels
		{
			get
			{
				return (EAudioBusChannels)(*(base.NativePtr + (IntPtr)UAudioBus.__PropertyOffset_AudioBusChannels));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioBus.__PropertyOffset_AudioBusChannels) = (byte)value;
			}
		}

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x06007433 RID: 29747 RVA: 0x000A6AF0 File Offset: 0x000A4CF0
		// (set) Token: 0x06007434 RID: 29748 RVA: 0x000A6B00 File Offset: 0x000A4D00
		public unsafe bool bIsAutomatic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioBus.__PropertyOffset_bIsAutomatic) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioBus.__PropertyOffset_bIsAutomatic) = (value ? 1 : 0);
			}
		}

		// Token: 0x06007435 RID: 29749 RVA: 0x000A6B11 File Offset: 0x000A4D11
		static UAudioBus()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AudioBus");
		}

		// Token: 0x06007436 RID: 29750 RVA: 0x000A6B1F File Offset: 0x000A4D1F
		protected UAudioBus(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040037E4 RID: 14308
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AudioBus";

		// Token: 0x040037E5 RID: 14309
		private static IntPtr _ClassPtr;

		// Token: 0x040037E6 RID: 14310
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040037E7 RID: 14311
		internal static int __PropertyOffset_AudioBusChannels;

		// Token: 0x040037E8 RID: 14312
		internal static int __PropertyOffset_bIsAutomatic;
	}
}
