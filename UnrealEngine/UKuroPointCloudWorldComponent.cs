using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A34 RID: 6708
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPointCloud.KuroPointCloudWorldComponent")]
	[UnrealStructLayout(800, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 800)]
	public class UKuroPointCloudWorldComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018D1F RID: 101663 RVA: 0x0024AC8C File Offset: 0x00248E8C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPointCloudWorldComponent._ClassPtr;
		}

		// Token: 0x06018D20 RID: 101664 RVA: 0x0024AC98 File Offset: 0x00248E98
		public UKuroPointCloudWorldComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroPointCloudWorldComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018D21 RID: 101665 RVA: 0x0024ACC0 File Offset: 0x00248EC0
		public UKuroPointCloudWorldComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPointCloudWorldComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700625B RID: 25179
		// (get) Token: 0x06018D22 RID: 101666 RVA: 0x0024ACF3 File Offset: 0x00248EF3
		// (set) Token: 0x06018D23 RID: 101667 RVA: 0x0024AD07 File Offset: 0x00248F07
		public unsafe FName KuroPointCloudCollectionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroPointCloudWorldComponent.__PropertyOffset_KuroPointCloudCollectionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroPointCloudWorldComponent.__PropertyOffset_KuroPointCloudCollectionName) = value;
			}
		}

		// Token: 0x1700625C RID: 25180
		// (get) Token: 0x06018D24 RID: 101668 RVA: 0x0024AD1C File Offset: 0x00248F1C
		// (set) Token: 0x06018D25 RID: 101669 RVA: 0x0024AD30 File Offset: 0x00248F30
		[Nullable(2)]
		public unsafe UKuroPointCloudInstance PointCloudInstance
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPointCloudInstance>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroPointCloudWorldComponent.__PropertyOffset_PointCloudInstance);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroPointCloudWorldComponent.__PropertyOffset_PointCloudInstance, value);
			}
		}

		// Token: 0x1700625D RID: 25181
		// (get) Token: 0x06018D26 RID: 101670 RVA: 0x0024AD45 File Offset: 0x00248F45
		// (set) Token: 0x06018D27 RID: 101671 RVA: 0x0024AD55 File Offset: 0x00248F55
		public unsafe EKPCWorldComponentDynamicPointMode DynamicPointMode
		{
			get
			{
				return (EKPCWorldComponentDynamicPointMode)(*(base.NativePtr + (IntPtr)UKuroPointCloudWorldComponent.__PropertyOffset_DynamicPointMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroPointCloudWorldComponent.__PropertyOffset_DynamicPointMode) = (byte)value;
			}
		}

		// Token: 0x1700625E RID: 25182
		// (get) Token: 0x06018D28 RID: 101672 RVA: 0x0024AD68 File Offset: 0x00248F68
		// (set) Token: 0x06018D29 RID: 101673 RVA: 0x0024ADA1 File Offset: 0x00248FA1
		public TArray<FKPCWDynamicPointSocketInfo> SocketInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKPCWDynamicPointSocketInfo> result;
				if ((result = this._SocketInfos) == null)
				{
					result = (this._SocketInfos = new TArray<FKPCWDynamicPointSocketInfo>(base.NativePtr + (IntPtr)UKuroPointCloudWorldComponent.__PropertyOffset_SocketInfos, this));
				}
				return result;
			}
			set
			{
				this.SocketInfos.CopyAssign(value);
			}
		}

		// Token: 0x1700625F RID: 25183
		// (get) Token: 0x06018D2A RID: 101674 RVA: 0x0024ADB0 File Offset: 0x00248FB0
		// (set) Token: 0x06018D2B RID: 101675 RVA: 0x0024ADE9 File Offset: 0x00248FE9
		public TMap<int, FKuroPointCloudDataSet> CustomPointsDataSet
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FKuroPointCloudDataSet> result;
				if ((result = this._CustomPointsDataSet) == null)
				{
					result = (this._CustomPointsDataSet = new TMap<int, FKuroPointCloudDataSet>(base.NativePtr + (IntPtr)UKuroPointCloudWorldComponent.__PropertyOffset_CustomPointsDataSet, this));
				}
				return result;
			}
			set
			{
				this.CustomPointsDataSet.CopyAssign(value);
			}
		}

		// Token: 0x17006260 RID: 25184
		// (get) Token: 0x06018D2C RID: 101676 RVA: 0x0024ADF8 File Offset: 0x00248FF8
		// (set) Token: 0x06018D2D RID: 101677 RVA: 0x0024AE31 File Offset: 0x00249031
		public TMap<int, FKPCWRingBufferData> RingBufferDataSet
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FKPCWRingBufferData> result;
				if ((result = this._RingBufferDataSet) == null)
				{
					result = (this._RingBufferDataSet = new TMap<int, FKPCWRingBufferData>(base.NativePtr + (IntPtr)UKuroPointCloudWorldComponent.__PropertyOffset_RingBufferDataSet, this));
				}
				return result;
			}
			set
			{
				this.RingBufferDataSet.CopyAssign(value);
			}
		}

		// Token: 0x06018D2E RID: 101678 RVA: 0x0024AE3F File Offset: 0x0024903F
		[NullableContext(2)]
		public void UpdateDynamicPoints(int EffectId, in TArray<FTransform> Transforms)
		{
			UKuroPointCloudWorldComponent.__UpdateDynamicPoints_Internal(base.NativePtr, EffectId, (Transforms ?? new TArray<FTransform>()).NativePtr);
		}

		// Token: 0x06018D2F RID: 101679 RVA: 0x0024AE60 File Offset: 0x00249060
		public unsafe void UpdateDynamicPoint(int EffectId, int Index, in FTransform NewTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			UKuroPointCloudWorldComponent.__UpdateDynamicPoint_Internal(base.NativePtr, EffectId, Index, ptr);
		}

		// Token: 0x06018D30 RID: 101680 RVA: 0x0024AE97 File Offset: 0x00249097
		public void SetNiagaraCollectionName(FName CollectionName)
		{
			UKuroPointCloudWorldComponent.__SetNiagaraCollectionName_Internal(base.NativePtr, CollectionName);
		}

		// Token: 0x06018D31 RID: 101681 RVA: 0x0024AEA5 File Offset: 0x002490A5
		[NullableContext(2)]
		public void SetInstance(UKuroPointCloudInstance Instance)
		{
			UKuroPointCloudWorldComponent.__SetInstance_Internal(base.NativePtr, (Instance != null) ? Instance.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06018D32 RID: 101682 RVA: 0x0024AEC2 File Offset: 0x002490C2
		public void SetDynamicPointVisible(int EffectId, int Index, bool bPointVisible)
		{
			UKuroPointCloudWorldComponent.__SetDynamicPointVisible_Internal(base.NativePtr, EffectId, Index, bPointVisible);
		}

		// Token: 0x06018D33 RID: 101683 RVA: 0x0024AED4 File Offset: 0x002490D4
		public unsafe bool SampleRingBufferPoint(int EffectId, int SampleIndex, int NewReadIndex, ref FTransform OutTransform, ref int OutVisible)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutTransform;
			fixed (int* ptr2 = &OutVisible)
			{
				void* ptr3 = (void*)ptr2;
				bool result = UKuroPointCloudWorldComponent.__SampleRingBufferPoint_Internal(base.NativePtr, EffectId, SampleIndex, NewReadIndex, ref ptr, ref OutVisible);
				OutTransform = ptr;
				return result;
			}
		}

		// Token: 0x06018D34 RID: 101684 RVA: 0x0024AF24 File Offset: 0x00249124
		public unsafe bool SampleDynamicVisiblePoint(int EffectId, int Index, int NewReadIndex, ref FTransform OutTransform, ref int bPointVisible)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutTransform;
			fixed (int* ptr2 = &bPointVisible)
			{
				void* ptr3 = (void*)ptr2;
				bool result = UKuroPointCloudWorldComponent.__SampleDynamicVisiblePoint_Internal(base.NativePtr, EffectId, Index, NewReadIndex, ref ptr, ref bPointVisible);
				OutTransform = ptr;
				return result;
			}
		}

		// Token: 0x06018D35 RID: 101685 RVA: 0x0024AF74 File Offset: 0x00249174
		public unsafe bool SampleDynamicPoint(int Index, ref FTransform OutTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutTransform;
			bool result = UKuroPointCloudWorldComponent.__SampleDynamicPoint_Internal(base.NativePtr, Index, ref ptr);
			OutTransform = ptr;
			return result;
		}

		// Token: 0x06018D36 RID: 101686 RVA: 0x0024AFB6 File Offset: 0x002491B6
		public void RemoveEffectRingBuffer(int EffectId)
		{
			UKuroPointCloudWorldComponent.__RemoveEffectRingBuffer_Internal(base.NativePtr, EffectId);
		}

		// Token: 0x06018D37 RID: 101687 RVA: 0x0024AFC4 File Offset: 0x002491C4
		public void RegisterToWorldSystem()
		{
			UKuroPointCloudWorldComponent.__RegisterToWorldSystem_Internal(base.NativePtr);
		}

		// Token: 0x06018D38 RID: 101688 RVA: 0x0024AFD1 File Offset: 0x002491D1
		public void MarkUpdate()
		{
			UKuroPointCloudWorldComponent.__MarkUpdate_Internal(base.NativePtr);
		}

		// Token: 0x06018D39 RID: 101689 RVA: 0x0024AFDE File Offset: 0x002491DE
		public int GetRingBufferWriteIndex(int EffectId)
		{
			return UKuroPointCloudWorldComponent.__GetRingBufferWriteIndex_Internal(base.NativePtr, EffectId);
		}

		// Token: 0x06018D3A RID: 101690 RVA: 0x0024AFEC File Offset: 0x002491EC
		public int GetRingBufferPendingCount(int EffectId, int NewReadIndex)
		{
			return UKuroPointCloudWorldComponent.__GetRingBufferPendingCount_Internal(base.NativePtr, EffectId, NewReadIndex);
		}

		// Token: 0x06018D3B RID: 101691 RVA: 0x0024AFFB File Offset: 0x002491FB
		public int GetRingBufferAvailableCount(int EffectId, int NewReadIndex)
		{
			return UKuroPointCloudWorldComponent.__GetRingBufferAvailableCount_Internal(base.NativePtr, EffectId, NewReadIndex);
		}

		// Token: 0x06018D3C RID: 101692 RVA: 0x0024B00A File Offset: 0x0024920A
		public int GetNumDynamicPointsByEffectID(int EffectId)
		{
			return UKuroPointCloudWorldComponent.__GetNumDynamicPointsByEffectID_Internal(base.NativePtr, EffectId);
		}

		// Token: 0x06018D3D RID: 101693 RVA: 0x0024B018 File Offset: 0x00249218
		public int GetNumDynamicPoints()
		{
			return UKuroPointCloudWorldComponent.__GetNumDynamicPoints_Internal(base.NativePtr);
		}

		// Token: 0x06018D3E RID: 101694 RVA: 0x0024B025 File Offset: 0x00249225
		[NullableContext(2)]
		public UKuroPointCloudInstance GetInstance(bool bCreateIfNull)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroPointCloudInstance>(UKuroPointCloudWorldComponent.__GetInstance_Internal(base.NativePtr, bCreateIfNull));
		}

		// Token: 0x06018D3F RID: 101695 RVA: 0x0024B038 File Offset: 0x00249238
		public EKPCWorldComponentDynamicPointMode GetComponentUsageMode()
		{
			return UKuroPointCloudWorldComponent.__GetComponentUsageMode_Internal(base.NativePtr);
		}

		// Token: 0x06018D40 RID: 101696 RVA: 0x0024B045 File Offset: 0x00249245
		public FName GetCollectionName()
		{
			return UKuroPointCloudWorldComponent.__GetCollectionName_Internal(base.NativePtr);
		}

		// Token: 0x06018D41 RID: 101697 RVA: 0x0024B054 File Offset: 0x00249254
		public unsafe bool GetBindingKey(ref int OutKey)
		{
			fixed (int* ptr = &OutKey)
			{
				void* ptr2 = (void*)ptr;
				return UKuroPointCloudWorldComponent.__GetBindingKey_Internal(base.NativePtr, ref OutKey);
			}
		}

		// Token: 0x06018D42 RID: 101698 RVA: 0x0024B074 File Offset: 0x00249274
		public unsafe void FillDynamicPoints(int EffectId, int NumPoints, in FTransform Transform, bool bPointVisible = true)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			UKuroPointCloudWorldComponent.__FillDynamicPoints_Internal(base.NativePtr, EffectId, NumPoints, ptr, bPointVisible);
		}

		// Token: 0x06018D43 RID: 101699 RVA: 0x0024B0AD File Offset: 0x002492AD
		public void CommitRingBufferProcessed(int EffectId)
		{
			UKuroPointCloudWorldComponent.__CommitRingBufferProcessed_Internal(base.NativePtr, EffectId);
		}

		// Token: 0x06018D44 RID: 101700 RVA: 0x0024B0BB File Offset: 0x002492BB
		[NullableContext(2)]
		public void AddRingBufferTransforms(int EffectId, in TArray<FTransform> Transforms)
		{
			UKuroPointCloudWorldComponent.__AddRingBufferTransforms_Internal(base.NativePtr, EffectId, (Transforms ?? new TArray<FTransform>()).NativePtr);
		}

		// Token: 0x06018D45 RID: 101701 RVA: 0x0024B0DC File Offset: 0x002492DC
		public unsafe void AddRingBufferTransform(int EffectId, in FTransform Transform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			UKuroPointCloudWorldComponent.__AddRingBufferTransform_Internal(base.NativePtr, EffectId, ptr);
		}

		// Token: 0x06018D46 RID: 101702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateDynamicPoints_Internal(IntPtr @this, int EffectId, IntPtr Transforms);

		// Token: 0x06018D47 RID: 101703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateDynamicPoint_Internal(IntPtr @this, int EffectId, int Index, in FTransform NewTransform);

		// Token: 0x06018D48 RID: 101704
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraCollectionName_Internal(IntPtr @this, FName CollectionName);

		// Token: 0x06018D49 RID: 101705
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInstance_Internal(IntPtr @this, IntPtr Instance);

		// Token: 0x06018D4A RID: 101706
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDynamicPointVisible_Internal(IntPtr @this, int EffectId, int Index, bool bPointVisible);

		// Token: 0x06018D4B RID: 101707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SampleRingBufferPoint_Internal(IntPtr @this, int EffectId, int SampleIndex, int NewReadIndex, ref FTransform OutTransform, ref int OutVisible);

		// Token: 0x06018D4C RID: 101708
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SampleDynamicVisiblePoint_Internal(IntPtr @this, int EffectId, int Index, int NewReadIndex, ref FTransform OutTransform, ref int bPointVisible);

		// Token: 0x06018D4D RID: 101709
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SampleDynamicPoint_Internal(IntPtr @this, int Index, ref FTransform OutTransform);

		// Token: 0x06018D4E RID: 101710
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveEffectRingBuffer_Internal(IntPtr @this, int EffectId);

		// Token: 0x06018D4F RID: 101711
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterToWorldSystem_Internal(IntPtr @this);

		// Token: 0x06018D50 RID: 101712
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkUpdate_Internal(IntPtr @this);

		// Token: 0x06018D51 RID: 101713
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRingBufferWriteIndex_Internal(IntPtr @this, int EffectId);

		// Token: 0x06018D52 RID: 101714
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRingBufferPendingCount_Internal(IntPtr @this, int EffectId, int NewReadIndex);

		// Token: 0x06018D53 RID: 101715
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRingBufferAvailableCount_Internal(IntPtr @this, int EffectId, int NewReadIndex);

		// Token: 0x06018D54 RID: 101716
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumDynamicPointsByEffectID_Internal(IntPtr @this, int EffectId);

		// Token: 0x06018D55 RID: 101717
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumDynamicPoints_Internal(IntPtr @this);

		// Token: 0x06018D56 RID: 101718
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstance_Internal(IntPtr @this, bool bCreateIfNull);

		// Token: 0x06018D57 RID: 101719
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EKPCWorldComponentDynamicPointMode __GetComponentUsageMode_Internal(IntPtr @this);

		// Token: 0x06018D58 RID: 101720
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetCollectionName_Internal(IntPtr @this);

		// Token: 0x06018D59 RID: 101721
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBindingKey_Internal(IntPtr @this, ref int OutKey);

		// Token: 0x06018D5A RID: 101722
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FillDynamicPoints_Internal(IntPtr @this, int EffectId, int NumPoints, in FTransform Transform, bool bPointVisible);

		// Token: 0x06018D5B RID: 101723
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CommitRingBufferProcessed_Internal(IntPtr @this, int EffectId);

		// Token: 0x06018D5C RID: 101724
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddRingBufferTransforms_Internal(IntPtr @this, int EffectId, IntPtr Transforms);

		// Token: 0x06018D5D RID: 101725
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddRingBufferTransform_Internal(IntPtr @this, int EffectId, in FTransform Transform);

		// Token: 0x06018D5E RID: 101726 RVA: 0x0024B112 File Offset: 0x00249312
		static UKuroPointCloudWorldComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPointCloud.KuroPointCloudWorldComponent");
		}

		// Token: 0x06018D5F RID: 101727 RVA: 0x0024B120 File Offset: 0x00249320
		protected UKuroPointCloudWorldComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D6AB RID: 54955
		public new const string __ObjectPath = "/Script/KuroPointCloud.KuroPointCloudWorldComponent";

		// Token: 0x0400D6AC RID: 54956
		private static IntPtr _ClassPtr;

		// Token: 0x0400D6AD RID: 54957
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D6AE RID: 54958
		internal static int __PropertyOffset_KuroPointCloudCollectionName;

		// Token: 0x0400D6AF RID: 54959
		internal static int __PropertyOffset_PointCloudInstance;

		// Token: 0x0400D6B0 RID: 54960
		internal static int __PropertyOffset_DynamicPointMode;

		// Token: 0x0400D6B1 RID: 54961
		internal static int __PropertyOffset_SocketInfos;

		// Token: 0x0400D6B2 RID: 54962
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKPCWDynamicPointSocketInfo> _SocketInfos;

		// Token: 0x0400D6B3 RID: 54963
		internal static int __PropertyOffset_CustomPointsDataSet;

		// Token: 0x0400D6B4 RID: 54964
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FKuroPointCloudDataSet> _CustomPointsDataSet;

		// Token: 0x0400D6B5 RID: 54965
		internal static int __PropertyOffset_RingBufferDataSet;

		// Token: 0x0400D6B6 RID: 54966
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FKPCWRingBufferData> _RingBufferDataSet;
	}
}
