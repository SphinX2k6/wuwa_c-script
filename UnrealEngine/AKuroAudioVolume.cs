using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200169D RID: 5789
	[UnrealObjectPath("/Script/KuroAudio.KuroAudioVolume")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class AKuroAudioVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014FE2 RID: 85986 RVA: 0x001EDA62 File Offset: 0x001EBC62
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroAudioVolume._ClassPtr;
		}

		// Token: 0x06014FE3 RID: 85987 RVA: 0x001EDA70 File Offset: 0x001EBC70
		public AKuroAudioVolume() : this(BuiltinUtils.AllocNativeUObject(AKuroAudioVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014FE4 RID: 85988 RVA: 0x001EDA98 File Offset: 0x001EBC98
		[NullableContext(1)]
		public AKuroAudioVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroAudioVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005313 RID: 21267
		// (get) Token: 0x06014FE5 RID: 85989 RVA: 0x001EDACB File Offset: 0x001EBCCB
		// (set) Token: 0x06014FE6 RID: 85990 RVA: 0x001EDADB File Offset: 0x001EBCDB
		public unsafe EKuroAudioVolumeChannel Channel
		{
			get
			{
				return (EKuroAudioVolumeChannel)(*(base.NativePtr + (IntPtr)AKuroAudioVolume.__PropertyOffset_Channel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroAudioVolume.__PropertyOffset_Channel) = (byte)value;
			}
		}

		// Token: 0x17005314 RID: 21268
		// (get) Token: 0x06014FE7 RID: 85991 RVA: 0x001EDAEC File Offset: 0x001EBCEC
		// (set) Token: 0x06014FE8 RID: 85992 RVA: 0x001EDAFC File Offset: 0x001EBCFC
		public unsafe byte Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroAudioVolume.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroAudioVolume.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17005315 RID: 21269
		// (get) Token: 0x06014FE9 RID: 85993 RVA: 0x001EDB0D File Offset: 0x001EBD0D
		// (set) Token: 0x06014FEA RID: 85994 RVA: 0x001EDB21 File Offset: 0x001EBD21
		[Nullable(2)]
		public unsafe UAkAudioEvent StateEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroAudioVolume.__PropertyOffset_StateEvent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroAudioVolume.__PropertyOffset_StateEvent, value);
			}
		}

		// Token: 0x17005316 RID: 21270
		// (get) Token: 0x06014FEB RID: 85995 RVA: 0x001EDB36 File Offset: 0x001EBD36
		// (set) Token: 0x06014FEC RID: 85996 RVA: 0x001EDB46 File Offset: 0x001EBD46
		public unsafe bool bEnableDynamicReverb
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroAudioVolume.__PropertyOffset_bEnableDynamicReverb) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroAudioVolume.__PropertyOffset_bEnableDynamicReverb) = (value ? 1 : 0);
			}
		}

		// Token: 0x06014FED RID: 85997 RVA: 0x001EDB57 File Offset: 0x001EBD57
		static AKuroAudioVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudio.KuroAudioVolume");
		}

		// Token: 0x06014FEE RID: 85998 RVA: 0x001EDB65 File Offset: 0x001EBD65
		protected AKuroAudioVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B6E6 RID: 46822
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAudio.KuroAudioVolume";

		// Token: 0x0400B6E7 RID: 46823
		private static IntPtr _ClassPtr;

		// Token: 0x0400B6E8 RID: 46824
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B6E9 RID: 46825
		internal static int __PropertyOffset_Channel;

		// Token: 0x0400B6EA RID: 46826
		internal static int __PropertyOffset_Priority;

		// Token: 0x0400B6EB RID: 46827
		internal static int __PropertyOffset_StateEvent;

		// Token: 0x0400B6EC RID: 46828
		internal static int __PropertyOffset_bEnableDynamicReverb;
	}
}
