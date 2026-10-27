using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000235 RID: 565
	[UnrealObjectPath("/Script/AkAudio.AkPortalComponent")]
	[UnrealStructLayout(800, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 800)]
	public class UAkPortalComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060020F8 RID: 8440 RVA: 0x00031089 File Offset: 0x0002F289
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkPortalComponent._ClassPtr;
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x00031098 File Offset: 0x0002F298
		public UAkPortalComponent() : this(BuiltinUtils.AllocNativeUObject(UAkPortalComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x000310C0 File Offset: 0x0002F2C0
		[NullableContext(1)]
		public UAkPortalComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkPortalComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x060020FB RID: 8443 RVA: 0x000310F3 File Offset: 0x0002F2F3
		// (set) Token: 0x060020FC RID: 8444 RVA: 0x00031103 File Offset: 0x0002F303
		public unsafe bool bDynamic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkPortalComponent.__PropertyOffset_bDynamic) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkPortalComponent.__PropertyOffset_bDynamic) = (value ? 1 : 0);
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x00031114 File Offset: 0x0002F314
		// (set) Token: 0x060020FE RID: 8446 RVA: 0x00031124 File Offset: 0x0002F324
		public unsafe EAkAcousticPortalState InitialState
		{
			get
			{
				return (EAkAcousticPortalState)(*(base.NativePtr + (IntPtr)UAkPortalComponent.__PropertyOffset_InitialState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkPortalComponent.__PropertyOffset_InitialState) = (byte)value;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060020FF RID: 8447 RVA: 0x00031135 File Offset: 0x0002F335
		// (set) Token: 0x06002100 RID: 8448 RVA: 0x00031145 File Offset: 0x0002F345
		public unsafe float ObstructionRefreshInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkPortalComponent.__PropertyOffset_ObstructionRefreshInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkPortalComponent.__PropertyOffset_ObstructionRefreshInterval) = value;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06002101 RID: 8449 RVA: 0x00031156 File Offset: 0x0002F356
		// (set) Token: 0x06002102 RID: 8450 RVA: 0x0003116A File Offset: 0x0002F36A
		public unsafe TEnumAsByte<ECollisionChannel> ObstructionCollisionChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkPortalComponent.__PropertyOffset_ObstructionCollisionChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkPortalComponent.__PropertyOffset_ObstructionCollisionChannel) = value;
			}
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x0003117F File Offset: 0x0002F37F
		public bool PortalPlacementValid()
		{
			return UAkPortalComponent.__PortalPlacementValid_Internal(base.NativePtr);
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x0003118C File Offset: 0x0002F38C
		public void OpenPortal()
		{
			UAkPortalComponent.__OpenPortal_Internal(base.NativePtr);
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x00031199 File Offset: 0x0002F399
		[NullableContext(2)]
		public UPrimitiveComponent GetPrimitiveParent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(UAkPortalComponent.__GetPrimitiveParent_Internal(base.NativePtr));
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x000311AB File Offset: 0x0002F3AB
		public EAkAcousticPortalState GetCurrentState()
		{
			return UAkPortalComponent.__GetCurrentState_Internal(base.NativePtr);
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x000311B8 File Offset: 0x0002F3B8
		public void ClosePortal()
		{
			UAkPortalComponent.__ClosePortal_Internal(base.NativePtr);
		}

		// Token: 0x06002108 RID: 8456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PortalPlacementValid_Internal(IntPtr @this);

		// Token: 0x06002109 RID: 8457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenPortal_Internal(IntPtr @this);

		// Token: 0x0600210A RID: 8458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPrimitiveParent_Internal(IntPtr @this);

		// Token: 0x0600210B RID: 8459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EAkAcousticPortalState __GetCurrentState_Internal(IntPtr @this);

		// Token: 0x0600210C RID: 8460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClosePortal_Internal(IntPtr @this);

		// Token: 0x0600210D RID: 8461 RVA: 0x000311C5 File Offset: 0x0002F3C5
		static UAkPortalComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkPortalComponent");
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x000311D3 File Offset: 0x0002F3D3
		protected UAkPortalComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000B20 RID: 2848
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkPortalComponent";

		// Token: 0x04000B21 RID: 2849
		private static IntPtr _ClassPtr;

		// Token: 0x04000B22 RID: 2850
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000B23 RID: 2851
		internal static int __PropertyOffset_bDynamic;

		// Token: 0x04000B24 RID: 2852
		internal static int __PropertyOffset_InitialState;

		// Token: 0x04000B25 RID: 2853
		internal static int __PropertyOffset_ObstructionRefreshInterval;

		// Token: 0x04000B26 RID: 2854
		internal static int __PropertyOffset_ObstructionCollisionChannel;
	}
}
