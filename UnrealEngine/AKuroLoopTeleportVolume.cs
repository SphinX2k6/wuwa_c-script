using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018F8 RID: 6392
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroLoopTeleportVolume")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class AKuroLoopTeleportVolume : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017B5A RID: 97114 RVA: 0x0022BF32 File Offset: 0x0022A132
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroLoopTeleportVolume._ClassPtr;
		}

		// Token: 0x06017B5B RID: 97115 RVA: 0x0022BF40 File Offset: 0x0022A140
		public AKuroLoopTeleportVolume() : this(BuiltinUtils.AllocNativeUObject(AKuroLoopTeleportVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017B5C RID: 97116 RVA: 0x0022BF68 File Offset: 0x0022A168
		[NullableContext(1)]
		public AKuroLoopTeleportVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroLoopTeleportVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F82 RID: 24450
		// (get) Token: 0x06017B5D RID: 97117 RVA: 0x0022BF9B File Offset: 0x0022A19B
		// (set) Token: 0x06017B5E RID: 97118 RVA: 0x0022BFAB File Offset: 0x0022A1AB
		public unsafe int VolumeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLoopTeleportVolume.__PropertyOffset_VolumeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLoopTeleportVolume.__PropertyOffset_VolumeId) = value;
			}
		}

		// Token: 0x17005F83 RID: 24451
		// (get) Token: 0x06017B5F RID: 97119 RVA: 0x0022BFBC File Offset: 0x0022A1BC
		// (set) Token: 0x06017B60 RID: 97120 RVA: 0x0022BFD0 File Offset: 0x0022A1D0
		public unsafe AVolume BoundsVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AVolume>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroLoopTeleportVolume.__PropertyOffset_BoundsVolume);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroLoopTeleportVolume.__PropertyOffset_BoundsVolume, value);
			}
		}

		// Token: 0x17005F84 RID: 24452
		// (get) Token: 0x06017B61 RID: 97121 RVA: 0x0022BFE5 File Offset: 0x0022A1E5
		// (set) Token: 0x06017B62 RID: 97122 RVA: 0x0022BFF9 File Offset: 0x0022A1F9
		public unsafe ALoopVolumeDynamicStreamingSource DynamicStreamingSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ALoopVolumeDynamicStreamingSource>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroLoopTeleportVolume.__PropertyOffset_DynamicStreamingSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroLoopTeleportVolume.__PropertyOffset_DynamicStreamingSource, value);
			}
		}

		// Token: 0x17005F85 RID: 24453
		// (get) Token: 0x06017B63 RID: 97123 RVA: 0x0022C00E File Offset: 0x0022A20E
		// (set) Token: 0x06017B64 RID: 97124 RVA: 0x0022C01E File Offset: 0x0022A21E
		public unsafe float BufferDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLoopTeleportVolume.__PropertyOffset_BufferDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLoopTeleportVolume.__PropertyOffset_BufferDistance) = value;
			}
		}

		// Token: 0x17005F86 RID: 24454
		// (get) Token: 0x06017B65 RID: 97125 RVA: 0x0022C02F File Offset: 0x0022A22F
		// (set) Token: 0x06017B66 RID: 97126 RVA: 0x0022C03F File Offset: 0x0022A23F
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLoopTeleportVolume.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLoopTeleportVolume.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F87 RID: 24455
		// (get) Token: 0x06017B67 RID: 97127 RVA: 0x0022C050 File Offset: 0x0022A250
		// (set) Token: 0x06017B68 RID: 97128 RVA: 0x0022C060 File Offset: 0x0022A260
		public unsafe bool bLoopAxisX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLoopTeleportVolume.__PropertyOffset_bLoopAxisX) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLoopTeleportVolume.__PropertyOffset_bLoopAxisX) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F88 RID: 24456
		// (get) Token: 0x06017B69 RID: 97129 RVA: 0x0022C071 File Offset: 0x0022A271
		// (set) Token: 0x06017B6A RID: 97130 RVA: 0x0022C081 File Offset: 0x0022A281
		public unsafe bool bLoopAxisY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLoopTeleportVolume.__PropertyOffset_bLoopAxisY) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLoopTeleportVolume.__PropertyOffset_bLoopAxisY) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F89 RID: 24457
		// (get) Token: 0x06017B6B RID: 97131 RVA: 0x0022C092 File Offset: 0x0022A292
		// (set) Token: 0x06017B6C RID: 97132 RVA: 0x0022C0A2 File Offset: 0x0022A2A2
		public unsafe bool bLoopAxisZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLoopTeleportVolume.__PropertyOffset_bLoopAxisZ) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLoopTeleportVolume.__PropertyOffset_bLoopAxisZ) = (value ? 1 : 0);
			}
		}

		// Token: 0x06017B6D RID: 97133 RVA: 0x0022C0B3 File Offset: 0x0022A2B3
		public bool IsLoopEnabled()
		{
			return AKuroLoopTeleportVolume.__IsLoopEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06017B6E RID: 97134 RVA: 0x0022C0C0 File Offset: 0x0022A2C0
		public bool IsLoopAxisZ()
		{
			return AKuroLoopTeleportVolume.__IsLoopAxisZ_Internal(base.NativePtr);
		}

		// Token: 0x06017B6F RID: 97135 RVA: 0x0022C0CD File Offset: 0x0022A2CD
		public bool IsLoopAxisY()
		{
			return AKuroLoopTeleportVolume.__IsLoopAxisY_Internal(base.NativePtr);
		}

		// Token: 0x06017B70 RID: 97136 RVA: 0x0022C0DA File Offset: 0x0022A2DA
		public bool IsLoopAxisX()
		{
			return AKuroLoopTeleportVolume.__IsLoopAxisX_Internal(base.NativePtr);
		}

		// Token: 0x06017B71 RID: 97137 RVA: 0x0022C0E7 File Offset: 0x0022A2E7
		public int GetVolumeId()
		{
			return AKuroLoopTeleportVolume.__GetVolumeId_Internal(base.NativePtr);
		}

		// Token: 0x06017B72 RID: 97138 RVA: 0x0022C0F4 File Offset: 0x0022A2F4
		public ALoopVolumeDynamicStreamingSource GetDynamicStreamingSource()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ALoopVolumeDynamicStreamingSource>(AKuroLoopTeleportVolume.__GetDynamicStreamingSource_Internal(base.NativePtr));
		}

		// Token: 0x06017B73 RID: 97139 RVA: 0x0022C106 File Offset: 0x0022A306
		public float GetBufferDistance()
		{
			return AKuroLoopTeleportVolume.__GetBufferDistance_Internal(base.NativePtr);
		}

		// Token: 0x06017B74 RID: 97140 RVA: 0x0022C113 File Offset: 0x0022A313
		public AVolume GetBoundsVolume()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AVolume>(AKuroLoopTeleportVolume.__GetBoundsVolume_Internal(base.NativePtr));
		}

		// Token: 0x06017B75 RID: 97141
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLoopEnabled_Internal(IntPtr @this);

		// Token: 0x06017B76 RID: 97142
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLoopAxisZ_Internal(IntPtr @this);

		// Token: 0x06017B77 RID: 97143
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLoopAxisY_Internal(IntPtr @this);

		// Token: 0x06017B78 RID: 97144
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLoopAxisX_Internal(IntPtr @this);

		// Token: 0x06017B79 RID: 97145
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetVolumeId_Internal(IntPtr @this);

		// Token: 0x06017B7A RID: 97146
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDynamicStreamingSource_Internal(IntPtr @this);

		// Token: 0x06017B7B RID: 97147
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetBufferDistance_Internal(IntPtr @this);

		// Token: 0x06017B7C RID: 97148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBoundsVolume_Internal(IntPtr @this);

		// Token: 0x06017B7D RID: 97149 RVA: 0x0022C125 File Offset: 0x0022A325
		static AKuroLoopTeleportVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroLoopTeleportVolume");
		}

		// Token: 0x06017B7E RID: 97150 RVA: 0x0022C133 File Offset: 0x0022A333
		protected AKuroLoopTeleportVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CDF6 RID: 52726
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroLoopTeleportVolume";

		// Token: 0x0400CDF7 RID: 52727
		private static IntPtr _ClassPtr;

		// Token: 0x0400CDF8 RID: 52728
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CDF9 RID: 52729
		internal static int __PropertyOffset_VolumeId;

		// Token: 0x0400CDFA RID: 52730
		internal static int __PropertyOffset_BoundsVolume;

		// Token: 0x0400CDFB RID: 52731
		internal static int __PropertyOffset_DynamicStreamingSource;

		// Token: 0x0400CDFC RID: 52732
		internal static int __PropertyOffset_BufferDistance;

		// Token: 0x0400CDFD RID: 52733
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x0400CDFE RID: 52734
		internal static int __PropertyOffset_bLoopAxisX;

		// Token: 0x0400CDFF RID: 52735
		internal static int __PropertyOffset_bLoopAxisY;

		// Token: 0x0400CE00 RID: 52736
		internal static int __PropertyOffset_bLoopAxisZ;
	}
}
