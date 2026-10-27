using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200023B RID: 571
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkReverbVolume")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1160)]
	public class AAkReverbVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002149 RID: 8521 RVA: 0x00031766 File Offset: 0x0002F966
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AAkReverbVolume._ClassPtr;
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00031774 File Offset: 0x0002F974
		public AAkReverbVolume() : this(BuiltinUtils.AllocNativeUObject(AAkReverbVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x0003179C File Offset: 0x0002F99C
		[NullableContext(1)]
		public AAkReverbVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AAkReverbVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x0600214C RID: 8524 RVA: 0x000317CF File Offset: 0x0002F9CF
		// (set) Token: 0x0600214D RID: 8525 RVA: 0x000317DF File Offset: 0x0002F9DF
		public unsafe bool bEnabled_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AAkReverbVolume.__PropertyOffset_bEnabled_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AAkReverbVolume.__PropertyOffset_bEnabled_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x0600214E RID: 8526 RVA: 0x000317F0 File Offset: 0x0002F9F0
		// (set) Token: 0x0600214F RID: 8527 RVA: 0x00031804 File Offset: 0x0002FA04
		public unsafe UAkAuxBus AuxBus_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAuxBus>(base.NativePtr / (IntPtr)sizeof(void*) + AAkReverbVolume.__PropertyOffset_AuxBus_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAkReverbVolume.__PropertyOffset_AuxBus_DEPRECATED, value);
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06002150 RID: 8528 RVA: 0x00031819 File Offset: 0x0002FA19
		// (set) Token: 0x06002151 RID: 8529 RVA: 0x0003182D File Offset: 0x0002FA2D
		[Nullable(1)]
		public unsafe string AuxBusName_DEPRECATED
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)AAkReverbVolume.__PropertyOffset_AuxBusName_DEPRECATED)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)AAkReverbVolume.__PropertyOffset_AuxBusName_DEPRECATED)), value);
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06002152 RID: 8530 RVA: 0x00031842 File Offset: 0x0002FA42
		// (set) Token: 0x06002153 RID: 8531 RVA: 0x00031852 File Offset: 0x0002FA52
		public unsafe float SendLevel_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AAkReverbVolume.__PropertyOffset_SendLevel_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AAkReverbVolume.__PropertyOffset_SendLevel_DEPRECATED) = value;
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x00031863 File Offset: 0x0002FA63
		// (set) Token: 0x06002155 RID: 8533 RVA: 0x00031873 File Offset: 0x0002FA73
		public unsafe float FadeRate_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AAkReverbVolume.__PropertyOffset_FadeRate_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AAkReverbVolume.__PropertyOffset_FadeRate_DEPRECATED) = value;
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06002156 RID: 8534 RVA: 0x00031884 File Offset: 0x0002FA84
		// (set) Token: 0x06002157 RID: 8535 RVA: 0x00031894 File Offset: 0x0002FA94
		public unsafe float Priority_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AAkReverbVolume.__PropertyOffset_Priority_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AAkReverbVolume.__PropertyOffset_Priority_DEPRECATED) = value;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06002158 RID: 8536 RVA: 0x000318A5 File Offset: 0x0002FAA5
		// (set) Token: 0x06002159 RID: 8537 RVA: 0x000318B9 File Offset: 0x0002FAB9
		public unsafe UAkLateReverbComponent LateReverbComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkLateReverbComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AAkReverbVolume.__PropertyOffset_LateReverbComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAkReverbVolume.__PropertyOffset_LateReverbComponent, value);
			}
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x000318CE File Offset: 0x0002FACE
		static AAkReverbVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkReverbVolume");
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x000318DC File Offset: 0x0002FADC
		protected AAkReverbVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000B42 RID: 2882
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkReverbVolume";

		// Token: 0x04000B43 RID: 2883
		private static IntPtr _ClassPtr;

		// Token: 0x04000B44 RID: 2884
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000B45 RID: 2885
		internal static int __PropertyOffset_bEnabled_DEPRECATED;

		// Token: 0x04000B46 RID: 2886
		internal static int __PropertyOffset_AuxBus_DEPRECATED;

		// Token: 0x04000B47 RID: 2887
		internal static int __PropertyOffset_AuxBusName_DEPRECATED;

		// Token: 0x04000B48 RID: 2888
		internal static int __PropertyOffset_SendLevel_DEPRECATED;

		// Token: 0x04000B49 RID: 2889
		internal static int __PropertyOffset_FadeRate_DEPRECATED;

		// Token: 0x04000B4A RID: 2890
		internal static int __PropertyOffset_Priority_DEPRECATED;

		// Token: 0x04000B4B RID: 2891
		internal static int __PropertyOffset_LateReverbComponent;
	}
}
