using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003F6 RID: 1014
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroLoopTeleportVolume")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class AKuroLoopTeleportVolume : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060063AE RID: 25518 RVA: 0x0008E936 File Offset: 0x0008CB36
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroLoopTeleportVolume._ClassPtr;
		}

		// Token: 0x060063AF RID: 25519 RVA: 0x0008E944 File Offset: 0x0008CB44
		public AKuroLoopTeleportVolume() : this(BuiltinUtils.AllocNativeUObject(AKuroLoopTeleportVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060063B0 RID: 25520 RVA: 0x0008E96C File Offset: 0x0008CB6C
		[NullableContext(1)]
		public AKuroLoopTeleportVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroLoopTeleportVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x060063B1 RID: 25521 RVA: 0x0008E99F File Offset: 0x0008CB9F
		// (set) Token: 0x060063B2 RID: 25522 RVA: 0x0008E9AF File Offset: 0x0008CBAF
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

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x060063B3 RID: 25523 RVA: 0x0008E9C0 File Offset: 0x0008CBC0
		// (set) Token: 0x060063B4 RID: 25524 RVA: 0x0008E9D4 File Offset: 0x0008CBD4
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

		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x060063B5 RID: 25525 RVA: 0x0008E9E9 File Offset: 0x0008CBE9
		// (set) Token: 0x060063B6 RID: 25526 RVA: 0x0008E9FD File Offset: 0x0008CBFD
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

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x060063B7 RID: 25527 RVA: 0x0008EA12 File Offset: 0x0008CC12
		// (set) Token: 0x060063B8 RID: 25528 RVA: 0x0008EA22 File Offset: 0x0008CC22
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

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x060063B9 RID: 25529 RVA: 0x0008EA33 File Offset: 0x0008CC33
		// (set) Token: 0x060063BA RID: 25530 RVA: 0x0008EA43 File Offset: 0x0008CC43
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

		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x060063BB RID: 25531 RVA: 0x0008EA54 File Offset: 0x0008CC54
		// (set) Token: 0x060063BC RID: 25532 RVA: 0x0008EA64 File Offset: 0x0008CC64
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

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x060063BD RID: 25533 RVA: 0x0008EA75 File Offset: 0x0008CC75
		// (set) Token: 0x060063BE RID: 25534 RVA: 0x0008EA85 File Offset: 0x0008CC85
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

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x060063BF RID: 25535 RVA: 0x0008EA96 File Offset: 0x0008CC96
		// (set) Token: 0x060063C0 RID: 25536 RVA: 0x0008EAA6 File Offset: 0x0008CCA6
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

		// Token: 0x060063C1 RID: 25537 RVA: 0x0008EAB7 File Offset: 0x0008CCB7
		public bool IsLoopEnabled()
		{
			return AKuroLoopTeleportVolume.__IsLoopEnabled_Internal(base.NativePtr);
		}

		// Token: 0x060063C2 RID: 25538 RVA: 0x0008EAC4 File Offset: 0x0008CCC4
		public bool IsLoopAxisZ()
		{
			return AKuroLoopTeleportVolume.__IsLoopAxisZ_Internal(base.NativePtr);
		}

		// Token: 0x060063C3 RID: 25539 RVA: 0x0008EAD1 File Offset: 0x0008CCD1
		public bool IsLoopAxisY()
		{
			return AKuroLoopTeleportVolume.__IsLoopAxisY_Internal(base.NativePtr);
		}

		// Token: 0x060063C4 RID: 25540 RVA: 0x0008EADE File Offset: 0x0008CCDE
		public bool IsLoopAxisX()
		{
			return AKuroLoopTeleportVolume.__IsLoopAxisX_Internal(base.NativePtr);
		}

		// Token: 0x060063C5 RID: 25541 RVA: 0x0008EAEB File Offset: 0x0008CCEB
		public int GetVolumeId()
		{
			return AKuroLoopTeleportVolume.__GetVolumeId_Internal(base.NativePtr);
		}

		// Token: 0x060063C6 RID: 25542 RVA: 0x0008EAF8 File Offset: 0x0008CCF8
		public ALoopVolumeDynamicStreamingSource GetDynamicStreamingSource()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ALoopVolumeDynamicStreamingSource>(AKuroLoopTeleportVolume.__GetDynamicStreamingSource_Internal(base.NativePtr));
		}

		// Token: 0x060063C7 RID: 25543 RVA: 0x0008EB0A File Offset: 0x0008CD0A
		public float GetBufferDistance()
		{
			return AKuroLoopTeleportVolume.__GetBufferDistance_Internal(base.NativePtr);
		}

		// Token: 0x060063C8 RID: 25544 RVA: 0x0008EB17 File Offset: 0x0008CD17
		public AVolume GetBoundsVolume()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AVolume>(AKuroLoopTeleportVolume.__GetBoundsVolume_Internal(base.NativePtr));
		}

		// Token: 0x060063C9 RID: 25545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLoopEnabled_Internal(IntPtr @this);

		// Token: 0x060063CA RID: 25546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLoopAxisZ_Internal(IntPtr @this);

		// Token: 0x060063CB RID: 25547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLoopAxisY_Internal(IntPtr @this);

		// Token: 0x060063CC RID: 25548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLoopAxisX_Internal(IntPtr @this);

		// Token: 0x060063CD RID: 25549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetVolumeId_Internal(IntPtr @this);

		// Token: 0x060063CE RID: 25550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDynamicStreamingSource_Internal(IntPtr @this);

		// Token: 0x060063CF RID: 25551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetBufferDistance_Internal(IntPtr @this);

		// Token: 0x060063D0 RID: 25552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBoundsVolume_Internal(IntPtr @this);

		// Token: 0x060063D1 RID: 25553 RVA: 0x0008EB29 File Offset: 0x0008CD29
		static AKuroLoopTeleportVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroLoopTeleportVolume");
		}

		// Token: 0x060063D2 RID: 25554 RVA: 0x0008EB37 File Offset: 0x0008CD37
		protected AKuroLoopTeleportVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002A21 RID: 10785
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroLoopTeleportVolume";

		// Token: 0x04002A22 RID: 10786
		private static IntPtr _ClassPtr;

		// Token: 0x04002A23 RID: 10787
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002A24 RID: 10788
		internal static int __PropertyOffset_VolumeId;

		// Token: 0x04002A25 RID: 10789
		internal static int __PropertyOffset_BoundsVolume;

		// Token: 0x04002A26 RID: 10790
		internal static int __PropertyOffset_DynamicStreamingSource;

		// Token: 0x04002A27 RID: 10791
		internal static int __PropertyOffset_BufferDistance;

		// Token: 0x04002A28 RID: 10792
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04002A29 RID: 10793
		internal static int __PropertyOffset_bLoopAxisX;

		// Token: 0x04002A2A RID: 10794
		internal static int __PropertyOffset_bLoopAxisY;

		// Token: 0x04002A2B RID: 10795
		internal static int __PropertyOffset_bLoopAxisZ;
	}
}
