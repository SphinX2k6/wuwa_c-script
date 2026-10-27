using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000243 RID: 579
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkSpatialAudioVolume")]
	[UnrealStructLayout(1304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1304)]
	public class AAkSpatialAudioVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600225B RID: 8795 RVA: 0x00032F68 File Offset: 0x00031168
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AAkSpatialAudioVolume._ClassPtr;
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00032F74 File Offset: 0x00031174
		public AAkSpatialAudioVolume() : this(BuiltinUtils.AllocNativeUObject(AAkSpatialAudioVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x00032F9C File Offset: 0x0003119C
		[NullableContext(1)]
		public AAkSpatialAudioVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AAkSpatialAudioVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x0600225E RID: 8798 RVA: 0x00032FCF File Offset: 0x000311CF
		// (set) Token: 0x0600225F RID: 8799 RVA: 0x00032FE3 File Offset: 0x000311E3
		public unsafe UAkSurfaceReflectorSetComponent SurfaceReflectorSet
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkSurfaceReflectorSetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AAkSpatialAudioVolume.__PropertyOffset_SurfaceReflectorSet);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAkSpatialAudioVolume.__PropertyOffset_SurfaceReflectorSet, value);
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x00032FF8 File Offset: 0x000311F8
		// (set) Token: 0x06002261 RID: 8801 RVA: 0x0003300C File Offset: 0x0003120C
		public unsafe UAkLateReverbComponent LateReverb
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkLateReverbComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AAkSpatialAudioVolume.__PropertyOffset_LateReverb);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAkSpatialAudioVolume.__PropertyOffset_LateReverb, value);
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x00033021 File Offset: 0x00031221
		// (set) Token: 0x06002263 RID: 8803 RVA: 0x00033035 File Offset: 0x00031235
		public unsafe UAkRoomComponent Room
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkRoomComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AAkSpatialAudioVolume.__PropertyOffset_Room);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAkSpatialAudioVolume.__PropertyOffset_Room, value);
			}
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x0003304A File Offset: 0x0003124A
		static AAkSpatialAudioVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkSpatialAudioVolume");
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x00033058 File Offset: 0x00031258
		protected AAkSpatialAudioVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000BD2 RID: 3026
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkSpatialAudioVolume";

		// Token: 0x04000BD3 RID: 3027
		private static IntPtr _ClassPtr;

		// Token: 0x04000BD4 RID: 3028
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000BD5 RID: 3029
		internal static int __PropertyOffset_SurfaceReflectorSet;

		// Token: 0x04000BD6 RID: 3030
		internal static int __PropertyOffset_LateReverb;

		// Token: 0x04000BD7 RID: 3031
		internal static int __PropertyOffset_Room;
	}
}
