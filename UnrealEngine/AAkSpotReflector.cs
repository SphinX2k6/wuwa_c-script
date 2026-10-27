using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000244 RID: 580
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkSpotReflector")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class AAkSpotReflector : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002266 RID: 8806 RVA: 0x00033061 File Offset: 0x00031261
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AAkSpotReflector._ClassPtr;
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x00033070 File Offset: 0x00031270
		public AAkSpotReflector() : this(BuiltinUtils.AllocNativeUObject(AAkSpotReflector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x00033098 File Offset: 0x00031298
		[NullableContext(1)]
		public AAkSpotReflector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AAkSpotReflector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06002269 RID: 8809 RVA: 0x000330CB File Offset: 0x000312CB
		// (set) Token: 0x0600226A RID: 8810 RVA: 0x000330DF File Offset: 0x000312DF
		public unsafe UAkAuxBus EarlyReflectionAuxBus
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAuxBus>(base.NativePtr / (IntPtr)sizeof(void*) + AAkSpotReflector.__PropertyOffset_EarlyReflectionAuxBus);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAkSpotReflector.__PropertyOffset_EarlyReflectionAuxBus, value);
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x0600226B RID: 8811 RVA: 0x000330F4 File Offset: 0x000312F4
		// (set) Token: 0x0600226C RID: 8812 RVA: 0x00033108 File Offset: 0x00031308
		[Nullable(1)]
		public unsafe string EarlyReflectionAuxBusName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)AAkSpotReflector.__PropertyOffset_EarlyReflectionAuxBusName)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)AAkSpotReflector.__PropertyOffset_EarlyReflectionAuxBusName)), value);
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x0003311D File Offset: 0x0003131D
		// (set) Token: 0x0600226E RID: 8814 RVA: 0x00033131 File Offset: 0x00031331
		public unsafe UAkAcousticTexture AcousticTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAcousticTexture>(base.NativePtr / (IntPtr)sizeof(void*) + AAkSpotReflector.__PropertyOffset_AcousticTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAkSpotReflector.__PropertyOffset_AcousticTexture, value);
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x0600226F RID: 8815 RVA: 0x00033146 File Offset: 0x00031346
		// (set) Token: 0x06002270 RID: 8816 RVA: 0x00033156 File Offset: 0x00031356
		public unsafe float DistanceScalingFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AAkSpotReflector.__PropertyOffset_DistanceScalingFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AAkSpotReflector.__PropertyOffset_DistanceScalingFactor) = value;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06002271 RID: 8817 RVA: 0x00033167 File Offset: 0x00031367
		// (set) Token: 0x06002272 RID: 8818 RVA: 0x00033177 File Offset: 0x00031377
		public unsafe float Level
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AAkSpotReflector.__PropertyOffset_Level);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AAkSpotReflector.__PropertyOffset_Level) = value;
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x00033188 File Offset: 0x00031388
		// (set) Token: 0x06002274 RID: 8820 RVA: 0x00033198 File Offset: 0x00031398
		public unsafe bool SameRoomOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AAkSpotReflector.__PropertyOffset_SameRoomOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AAkSpotReflector.__PropertyOffset_SameRoomOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06002275 RID: 8821 RVA: 0x000331A9 File Offset: 0x000313A9
		// (set) Token: 0x06002276 RID: 8822 RVA: 0x000331B9 File Offset: 0x000313B9
		public unsafe bool EnableRoomOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AAkSpotReflector.__PropertyOffset_EnableRoomOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AAkSpotReflector.__PropertyOffset_EnableRoomOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06002277 RID: 8823 RVA: 0x000331CA File Offset: 0x000313CA
		// (set) Token: 0x06002278 RID: 8824 RVA: 0x000331DE File Offset: 0x000313DE
		public unsafe AActor RoomOverride
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + AAkSpotReflector.__PropertyOffset_RoomOverride);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAkSpotReflector.__PropertyOffset_RoomOverride, value);
			}
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x000331F3 File Offset: 0x000313F3
		static AAkSpotReflector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkSpotReflector");
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x00033201 File Offset: 0x00031401
		protected AAkSpotReflector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000BD8 RID: 3032
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkSpotReflector";

		// Token: 0x04000BD9 RID: 3033
		private static IntPtr _ClassPtr;

		// Token: 0x04000BDA RID: 3034
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000BDB RID: 3035
		internal static int __PropertyOffset_EarlyReflectionAuxBus;

		// Token: 0x04000BDC RID: 3036
		internal static int __PropertyOffset_EarlyReflectionAuxBusName;

		// Token: 0x04000BDD RID: 3037
		internal static int __PropertyOffset_AcousticTexture;

		// Token: 0x04000BDE RID: 3038
		internal static int __PropertyOffset_DistanceScalingFactor;

		// Token: 0x04000BDF RID: 3039
		internal static int __PropertyOffset_Level;

		// Token: 0x04000BE0 RID: 3040
		internal static int __PropertyOffset_SameRoomOnly;

		// Token: 0x04000BE1 RID: 3041
		internal static int __PropertyOffset_EnableRoomOverride;

		// Token: 0x04000BE2 RID: 3042
		internal static int __PropertyOffset_RoomOverride;
	}
}
