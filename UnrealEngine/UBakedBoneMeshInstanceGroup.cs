using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000880 RID: 2176
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneMeshInstanceGroup")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UBakedBoneMeshInstanceGroup : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060076E2 RID: 30434 RVA: 0x000AA4B6 File Offset: 0x000A86B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBakedBoneMeshInstanceGroup._ClassPtr;
		}

		// Token: 0x060076E3 RID: 30435 RVA: 0x000AA4C4 File Offset: 0x000A86C4
		public UBakedBoneMeshInstanceGroup() : this(BuiltinUtils.AllocNativeUObject(UBakedBoneMeshInstanceGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060076E4 RID: 30436 RVA: 0x000AA4EC File Offset: 0x000A86EC
		public UBakedBoneMeshInstanceGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBakedBoneMeshInstanceGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x060076E5 RID: 30437 RVA: 0x000AA51F File Offset: 0x000A871F
		// (set) Token: 0x060076E6 RID: 30438 RVA: 0x000AA52F File Offset: 0x000A872F
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneMeshInstanceGroup.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneMeshInstanceGroup.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x060076E7 RID: 30439 RVA: 0x000AA540 File Offset: 0x000A8740
		// (set) Token: 0x060076E8 RID: 30440 RVA: 0x000AA554 File Offset: 0x000A8754
		[Nullable(2)]
		public unsafe USkeletalMesh MainSkeletalMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UBakedBoneMeshInstanceGroup.__PropertyOffset_MainSkeletalMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBakedBoneMeshInstanceGroup.__PropertyOffset_MainSkeletalMesh, value);
			}
		}

		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x060076E9 RID: 30441 RVA: 0x000AA56C File Offset: 0x000A876C
		// (set) Token: 0x060076EA RID: 30442 RVA: 0x000AA5A5 File Offset: 0x000A87A5
		public TArray<USkeletalMesh> SubSkeletalMeshes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USkeletalMesh> result;
				if ((result = this._SubSkeletalMeshes) == null)
				{
					result = (this._SubSkeletalMeshes = new TArray<USkeletalMesh>(base.NativePtr + (IntPtr)UBakedBoneMeshInstanceGroup.__PropertyOffset_SubSkeletalMeshes, this));
				}
				return result;
			}
			set
			{
				this.SubSkeletalMeshes.CopyAssign(value);
			}
		}

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x060076EB RID: 30443 RVA: 0x000AA5B4 File Offset: 0x000A87B4
		// (set) Token: 0x060076EC RID: 30444 RVA: 0x000AA5ED File Offset: 0x000A87ED
		public TArray<FSubMeshSocket> SubMeshSockets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSubMeshSocket> result;
				if ((result = this._SubMeshSockets) == null)
				{
					result = (this._SubMeshSockets = new TArray<FSubMeshSocket>(base.NativePtr + (IntPtr)UBakedBoneMeshInstanceGroup.__PropertyOffset_SubMeshSockets, this));
				}
				return result;
			}
			set
			{
				this.SubMeshSockets.CopyAssign(value);
			}
		}

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x060076ED RID: 30445 RVA: 0x000AA5FB File Offset: 0x000A87FB
		// (set) Token: 0x060076EE RID: 30446 RVA: 0x000AA60F File Offset: 0x000A880F
		[Nullable(2)]
		public unsafe UBakedBoneTexture2D BakedBoneTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBakedBoneTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UBakedBoneMeshInstanceGroup.__PropertyOffset_BakedBoneTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBakedBoneMeshInstanceGroup.__PropertyOffset_BakedBoneTexture, value);
			}
		}

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x060076EF RID: 30447 RVA: 0x000AA624 File Offset: 0x000A8824
		// (set) Token: 0x060076F0 RID: 30448 RVA: 0x000AA638 File Offset: 0x000A8838
		[Nullable(2)]
		public unsafe UBakedBoneMontageInfoAsset BakedBoneMontageInfoAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBakedBoneMontageInfoAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UBakedBoneMeshInstanceGroup.__PropertyOffset_BakedBoneMontageInfoAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBakedBoneMeshInstanceGroup.__PropertyOffset_BakedBoneMontageInfoAsset, value);
			}
		}

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x060076F1 RID: 30449 RVA: 0x000AA650 File Offset: 0x000A8850
		// (set) Token: 0x060076F2 RID: 30450 RVA: 0x000AA689 File Offset: 0x000A8889
		public TArray<FBakedBoneMeshEditableInstanceData> InstanceEditData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedBoneMeshEditableInstanceData> result;
				if ((result = this._InstanceEditData) == null)
				{
					result = (this._InstanceEditData = new TArray<FBakedBoneMeshEditableInstanceData>(base.NativePtr + (IntPtr)UBakedBoneMeshInstanceGroup.__PropertyOffset_InstanceEditData, this));
				}
				return result;
			}
			set
			{
				this.InstanceEditData.CopyAssign(value);
			}
		}

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x060076F3 RID: 30451 RVA: 0x000AA697 File Offset: 0x000A8897
		// (set) Token: 0x060076F4 RID: 30452 RVA: 0x000AA6A7 File Offset: 0x000A88A7
		public unsafe int NumCustomDataPerInstance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneMeshInstanceGroup.__PropertyOffset_NumCustomDataPerInstance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneMeshInstanceGroup.__PropertyOffset_NumCustomDataPerInstance) = value;
			}
		}

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x060076F5 RID: 30453 RVA: 0x000AA6B8 File Offset: 0x000A88B8
		// (set) Token: 0x060076F6 RID: 30454 RVA: 0x000AA6F1 File Offset: 0x000A88F1
		public TArray<float> PerInstanceCustomData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._PerInstanceCustomData) == null)
				{
					result = (this._PerInstanceCustomData = new TArray<float>(base.NativePtr + (IntPtr)UBakedBoneMeshInstanceGroup.__PropertyOffset_PerInstanceCustomData, this));
				}
				return result;
			}
			set
			{
				this.PerInstanceCustomData.CopyAssign(value);
			}
		}

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x060076F7 RID: 30455 RVA: 0x000AA6FF File Offset: 0x000A88FF
		// (set) Token: 0x060076F8 RID: 30456 RVA: 0x000AA70F File Offset: 0x000A890F
		public unsafe bool bUseGroupLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneMeshInstanceGroup.__PropertyOffset_bUseGroupLOD) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneMeshInstanceGroup.__PropertyOffset_bUseGroupLOD) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x060076F9 RID: 30457 RVA: 0x000AA720 File Offset: 0x000A8920
		// (set) Token: 0x060076FA RID: 30458 RVA: 0x000AA759 File Offset: 0x000A8959
		public FPerPlatformInt UsedGroupLODIndex
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._UsedGroupLODIndex) == null)
				{
					result = (this._UsedGroupLODIndex = new FPerPlatformInt(base.NativePtr + (IntPtr)UBakedBoneMeshInstanceGroup.__PropertyOffset_UsedGroupLODIndex, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)UBakedBoneMeshInstanceGroup.__PropertyOffset_UsedGroupLODIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x060076FB RID: 30459 RVA: 0x000AA77C File Offset: 0x000A897C
		// (set) Token: 0x060076FC RID: 30460 RVA: 0x000AA7B5 File Offset: 0x000A89B5
		public TArray<FBakedBoneMeshInstanceGroupLODData> GroupLODData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedBoneMeshInstanceGroupLODData> result;
				if ((result = this._GroupLODData) == null)
				{
					result = (this._GroupLODData = new TArray<FBakedBoneMeshInstanceGroupLODData>(base.NativePtr + (IntPtr)UBakedBoneMeshInstanceGroup.__PropertyOffset_GroupLODData, this));
				}
				return result;
			}
			set
			{
				this.GroupLODData.CopyAssign(value);
			}
		}

		// Token: 0x060076FD RID: 30461 RVA: 0x000AA7C3 File Offset: 0x000A89C3
		public bool ShouldRenderSubMeshes()
		{
			return UBakedBoneMeshInstanceGroup.__ShouldRenderSubMeshes_Internal(base.NativePtr);
		}

		// Token: 0x060076FE RID: 30462 RVA: 0x000AA7D0 File Offset: 0x000A89D0
		public bool ShouldRenderMainMesh()
		{
			return UBakedBoneMeshInstanceGroup.__ShouldRenderMainMesh_Internal(base.NativePtr);
		}

		// Token: 0x060076FF RID: 30463 RVA: 0x000AA7DD File Offset: 0x000A89DD
		public void SetSubSkeletalMeshes([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<USkeletalMesh> InSkeletalMeshes)
		{
			UBakedBoneMeshInstanceGroup.__SetSubSkeletalMeshes_Internal(base.NativePtr, (InSkeletalMeshes ?? new TArray<USkeletalMesh>()).NativePtr);
		}

		// Token: 0x06007700 RID: 30464 RVA: 0x000AA7FA File Offset: 0x000A89FA
		[NullableContext(2)]
		public void SetMainSkeletalMesh(USkeletalMesh InSkeletalMesh)
		{
			UBakedBoneMeshInstanceGroup.__SetMainSkeletalMesh_Internal(base.NativePtr, (InSkeletalMesh != null) ? InSkeletalMesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007701 RID: 30465 RVA: 0x000AA817 File Offset: 0x000A8A17
		public void ResetNumCustomDataPerInstance(int N)
		{
			UBakedBoneMeshInstanceGroup.__ResetNumCustomDataPerInstance_Internal(base.NativePtr, N);
		}

		// Token: 0x06007702 RID: 30466 RVA: 0x000AA825 File Offset: 0x000A8A25
		public bool IsSubMeshSocket(int InMeshIndex)
		{
			return UBakedBoneMeshInstanceGroup.__IsSubMeshSocket_Internal(base.NativePtr, InMeshIndex);
		}

		// Token: 0x06007703 RID: 30467 RVA: 0x000AA833 File Offset: 0x000A8A33
		public bool HasValidSubMesh()
		{
			return UBakedBoneMeshInstanceGroup.__HasValidSubMesh_Internal(base.NativePtr);
		}

		// Token: 0x06007704 RID: 30468 RVA: 0x000AA840 File Offset: 0x000A8A40
		public bool HasValidMainMesh()
		{
			return UBakedBoneMeshInstanceGroup.__HasValidMainMesh_Internal(base.NativePtr);
		}

		// Token: 0x06007705 RID: 30469 RVA: 0x000AA84D File Offset: 0x000A8A4D
		public FTransform GetSubMeshSocketTransform(int InMeshIndex)
		{
			return UBakedBoneMeshInstanceGroup.__GetSubMeshSocketTransform_Internal(base.NativePtr, InMeshIndex);
		}

		// Token: 0x06007706 RID: 30470 RVA: 0x000AA85B File Offset: 0x000A8A5B
		public FName GetSubMeshSocketName(int InMeshIndex)
		{
			return UBakedBoneMeshInstanceGroup.__GetSubMeshSocketName_Internal(base.NativePtr, InMeshIndex);
		}

		// Token: 0x06007707 RID: 30471 RVA: 0x000AA869 File Offset: 0x000A8A69
		public int GetNumInstances()
		{
			return UBakedBoneMeshInstanceGroup.__GetNumInstances_Internal(base.NativePtr);
		}

		// Token: 0x06007708 RID: 30472 RVA: 0x000AA876 File Offset: 0x000A8A76
		public int GetNumCustomDataPerInstance()
		{
			return UBakedBoneMeshInstanceGroup.__GetNumCustomDataPerInstance_Internal(base.NativePtr);
		}

		// Token: 0x06007709 RID: 30473 RVA: 0x000AA883 File Offset: 0x000A8A83
		public int GetNumCustomData()
		{
			return UBakedBoneMeshInstanceGroup.__GetNumCustomData_Internal(base.NativePtr);
		}

		// Token: 0x0600770A RID: 30474 RVA: 0x000AA890 File Offset: 0x000A8A90
		public FSubMeshSocket FindSubMeshSocket(int InMeshIndex)
		{
			return new FSubMeshSocket(UBakedBoneMeshInstanceGroup.__FindSubMeshSocket_Internal(base.NativePtr, InMeshIndex), null);
		}

		// Token: 0x0600770B RID: 30475 RVA: 0x000AA8A4 File Offset: 0x000A8AA4
		[NullableContext(2)]
		public int AddSubSkeletalMesh(USkeletalMesh InSubMesh)
		{
			return UBakedBoneMeshInstanceGroup.__AddSubSkeletalMesh_Internal(base.NativePtr, (InSubMesh != null) ? InSubMesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600770C RID: 30476 RVA: 0x000AA8C4 File Offset: 0x000A8AC4
		[NullableContext(2)]
		public unsafe bool AddSubMeshSocket(USkeletalMesh InSubMesh, in FName InSocketName, in FTransform InSocketTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InSocketTransform;
			fixed (FName* ptr2 = &InSocketName)
			{
				void* ptr3 = (void*)ptr2;
				return UBakedBoneMeshInstanceGroup.__AddSubMeshSocket_Internal(base.NativePtr, (InSubMesh != null) ? InSubMesh.NativePtr : IntPtr.Zero, InSocketName, ptr);
			}
		}

		// Token: 0x0600770D RID: 30477 RVA: 0x000AA910 File Offset: 0x000A8B10
		public unsafe int AddInstanceData(int InAnimTexIndex, in FTransform InTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InTransform;
			return UBakedBoneMeshInstanceGroup.__AddInstanceData_Internal(base.NativePtr, InAnimTexIndex, ptr);
		}

		// Token: 0x0600770E RID: 30478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldRenderSubMeshes_Internal(IntPtr @this);

		// Token: 0x0600770F RID: 30479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldRenderMainMesh_Internal(IntPtr @this);

		// Token: 0x06007710 RID: 30480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSubSkeletalMeshes_Internal(IntPtr @this, IntPtr InSkeletalMeshes);

		// Token: 0x06007711 RID: 30481
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMainSkeletalMesh_Internal(IntPtr @this, IntPtr InSkeletalMesh);

		// Token: 0x06007712 RID: 30482
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetNumCustomDataPerInstance_Internal(IntPtr @this, int N);

		// Token: 0x06007713 RID: 30483
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSubMeshSocket_Internal(IntPtr @this, int InMeshIndex);

		// Token: 0x06007714 RID: 30484
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasValidSubMesh_Internal(IntPtr @this);

		// Token: 0x06007715 RID: 30485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasValidMainMesh_Internal(IntPtr @this);

		// Token: 0x06007716 RID: 30486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetSubMeshSocketTransform_Internal(IntPtr @this, int InMeshIndex);

		// Token: 0x06007717 RID: 30487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetSubMeshSocketName_Internal(IntPtr @this, int InMeshIndex);

		// Token: 0x06007718 RID: 30488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumInstances_Internal(IntPtr @this);

		// Token: 0x06007719 RID: 30489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumCustomDataPerInstance_Internal(IntPtr @this);

		// Token: 0x0600771A RID: 30490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumCustomData_Internal(IntPtr @this);

		// Token: 0x0600771B RID: 30491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindSubMeshSocket_Internal(IntPtr @this, int InMeshIndex);

		// Token: 0x0600771C RID: 30492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddSubSkeletalMesh_Internal(IntPtr @this, IntPtr InSubMesh);

		// Token: 0x0600771D RID: 30493
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddSubMeshSocket_Internal(IntPtr @this, IntPtr InSubMesh, in FName InSocketName, in FTransform InSocketTransform);

		// Token: 0x0600771E RID: 30494
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddInstanceData_Internal(IntPtr @this, int InAnimTexIndex, in FTransform InTransform);

		// Token: 0x0600771F RID: 30495 RVA: 0x000AA946 File Offset: 0x000A8B46
		static UBakedBoneMeshInstanceGroup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BakedBoneMeshInstanceGroup");
		}

		// Token: 0x06007720 RID: 30496 RVA: 0x000AA954 File Offset: 0x000A8B54
		protected UBakedBoneMeshInstanceGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400391C RID: 14620
		public new const string __ObjectPath = "/Script/Engine.BakedBoneMeshInstanceGroup";

		// Token: 0x0400391D RID: 14621
		private static IntPtr _ClassPtr;

		// Token: 0x0400391E RID: 14622
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400391F RID: 14623
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x04003920 RID: 14624
		internal static int __PropertyOffset_MainSkeletalMesh;

		// Token: 0x04003921 RID: 14625
		internal static int __PropertyOffset_SubSkeletalMeshes;

		// Token: 0x04003922 RID: 14626
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USkeletalMesh> _SubSkeletalMeshes;

		// Token: 0x04003923 RID: 14627
		internal static int __PropertyOffset_SubMeshSockets;

		// Token: 0x04003924 RID: 14628
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSubMeshSocket> _SubMeshSockets;

		// Token: 0x04003925 RID: 14629
		internal static int __PropertyOffset_BakedBoneTexture;

		// Token: 0x04003926 RID: 14630
		internal static int __PropertyOffset_BakedBoneMontageInfoAsset;

		// Token: 0x04003927 RID: 14631
		internal static int __PropertyOffset_InstanceEditData;

		// Token: 0x04003928 RID: 14632
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedBoneMeshEditableInstanceData> _InstanceEditData;

		// Token: 0x04003929 RID: 14633
		internal static int __PropertyOffset_NumCustomDataPerInstance;

		// Token: 0x0400392A RID: 14634
		internal static int __PropertyOffset_PerInstanceCustomData;

		// Token: 0x0400392B RID: 14635
		[Nullable(2)]
		private TArray<float> _PerInstanceCustomData;

		// Token: 0x0400392C RID: 14636
		internal static int __PropertyOffset_bUseGroupLOD;

		// Token: 0x0400392D RID: 14637
		internal static int __PropertyOffset_UsedGroupLODIndex;

		// Token: 0x0400392E RID: 14638
		[Nullable(2)]
		private FPerPlatformInt _UsedGroupLODIndex;

		// Token: 0x0400392F RID: 14639
		internal static int __PropertyOffset_GroupLODData;

		// Token: 0x04003930 RID: 14640
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedBoneMeshInstanceGroupLODData> _GroupLODData;
	}
}
