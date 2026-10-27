using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001192 RID: 4498
	[UnrealObjectPath("/Script/Engine.StaticMeshActor")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class AStaticMeshActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060108C3 RID: 67779 RVA: 0x00184CDC File Offset: 0x00182EDC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AStaticMeshActor._ClassPtr;
		}

		// Token: 0x060108C4 RID: 67780 RVA: 0x00184CE8 File Offset: 0x00182EE8
		public AStaticMeshActor() : this(BuiltinUtils.AllocNativeUObject(AStaticMeshActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060108C5 RID: 67781 RVA: 0x00184D10 File Offset: 0x00182F10
		[NullableContext(1)]
		public AStaticMeshActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AStaticMeshActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700408B RID: 16523
		// (get) Token: 0x060108C6 RID: 67782 RVA: 0x00184D43 File Offset: 0x00182F43
		// (set) Token: 0x060108C7 RID: 67783 RVA: 0x00184D57 File Offset: 0x00182F57
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMeshComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AStaticMeshActor.__PropertyOffset_StaticMeshComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AStaticMeshActor.__PropertyOffset_StaticMeshComponent, value);
			}
		}

		// Token: 0x1700408C RID: 16524
		// (get) Token: 0x060108C8 RID: 67784 RVA: 0x00184D6C File Offset: 0x00182F6C
		// (set) Token: 0x060108C9 RID: 67785 RVA: 0x00184D7C File Offset: 0x00182F7C
		public unsafe bool bStaticMeshReplicateMovement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStaticMeshActor.__PropertyOffset_bStaticMeshReplicateMovement) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStaticMeshActor.__PropertyOffset_bStaticMeshReplicateMovement) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700408D RID: 16525
		// (get) Token: 0x060108CA RID: 67786 RVA: 0x00184D8D File Offset: 0x00182F8D
		// (set) Token: 0x060108CB RID: 67787 RVA: 0x00184D9D File Offset: 0x00182F9D
		public unsafe ENavDataGatheringMode NavigationGeometryGatheringMode
		{
			get
			{
				return (ENavDataGatheringMode)(*(base.NativePtr + (IntPtr)AStaticMeshActor.__PropertyOffset_NavigationGeometryGatheringMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStaticMeshActor.__PropertyOffset_NavigationGeometryGatheringMode) = (byte)value;
			}
		}

		// Token: 0x1700408E RID: 16526
		// (get) Token: 0x060108CC RID: 67788 RVA: 0x00184DAE File Offset: 0x00182FAE
		// (set) Token: 0x060108CD RID: 67789 RVA: 0x00184DC7 File Offset: 0x00182FC7
		public unsafe bool bHideLogicallyOnBeginPlay
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AStaticMeshActor.__PropertyOffset_bHideLogicallyOnBeginPlay) & AStaticMeshActor.__PropertyMask_bHideLogicallyOnBeginPlay) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AStaticMeshActor.__PropertyOffset_bHideLogicallyOnBeginPlay) = ((*(base.NativePtr + (IntPtr)AStaticMeshActor.__PropertyOffset_bHideLogicallyOnBeginPlay) & ~AStaticMeshActor.__PropertyMask_bHideLogicallyOnBeginPlay) | (value ? AStaticMeshActor.__PropertyMask_bHideLogicallyOnBeginPlay : 0));
			}
		}

		// Token: 0x060108CE RID: 67790 RVA: 0x00184DF7 File Offset: 0x00182FF7
		public void SetMobility(EComponentMobility InMobility)
		{
			AStaticMeshActor.__SetMobility_Internal(base.NativePtr, InMobility);
		}

		// Token: 0x060108CF RID: 67791 RVA: 0x00184E0A File Offset: 0x0018300A
		public void SetLogicallyShow(ECollisionEnabled Type)
		{
			AStaticMeshActor.__SetLogicallyShow_Internal(base.NativePtr, Type);
		}

		// Token: 0x060108D0 RID: 67792 RVA: 0x00184E1D File Offset: 0x0018301D
		public void SetLogicallyHidden()
		{
			AStaticMeshActor.__SetLogicallyHidden_Internal(base.NativePtr);
		}

		// Token: 0x060108D1 RID: 67793
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMobility_Internal(IntPtr @this, TEnumAsByte<EComponentMobility> InMobility);

		// Token: 0x060108D2 RID: 67794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLogicallyShow_Internal(IntPtr @this, TEnumAsByte<ECollisionEnabled> Type);

		// Token: 0x060108D3 RID: 67795
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLogicallyHidden_Internal(IntPtr @this);

		// Token: 0x060108D4 RID: 67796 RVA: 0x00184E2A File Offset: 0x0018302A
		static AStaticMeshActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StaticMeshActor");
		}

		// Token: 0x060108D5 RID: 67797 RVA: 0x00184E38 File Offset: 0x00183038
		protected AStaticMeshActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008D9E RID: 36254
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StaticMeshActor";

		// Token: 0x04008D9F RID: 36255
		private static IntPtr _ClassPtr;

		// Token: 0x04008DA0 RID: 36256
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008DA1 RID: 36257
		internal static int __PropertyOffset_StaticMeshComponent;

		// Token: 0x04008DA2 RID: 36258
		internal static int __PropertyOffset_bStaticMeshReplicateMovement;

		// Token: 0x04008DA3 RID: 36259
		internal static int __PropertyOffset_NavigationGeometryGatheringMode;

		// Token: 0x04008DA4 RID: 36260
		internal static int __PropertyOffset_bHideLogicallyOnBeginPlay;

		// Token: 0x04008DA5 RID: 36261
		internal static byte __PropertyMask_bHideLogicallyOnBeginPlay;
	}
}
