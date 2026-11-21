using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003A8 RID: 936
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplayUI.DamageUiManager")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UDamageUiManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005CAB RID: 23723 RVA: 0x00082806 File Offset: 0x00080A06
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDamageUiManager._ClassPtr;
		}

		// Token: 0x06005CAC RID: 23724 RVA: 0x00082814 File Offset: 0x00080A14
		public UDamageUiManager() : this(BuiltinUtils.AllocNativeUObject(UDamageUiManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005CAD RID: 23725 RVA: 0x0008283C File Offset: 0x00080A3C
		[NullableContext(1)]
		public UDamageUiManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDamageUiManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x06005CAE RID: 23726 RVA: 0x00082870 File Offset: 0x00080A70
		// (set) Token: 0x06005CAF RID: 23727 RVA: 0x000828A9 File Offset: 0x00080AA9
		[Nullable(1)]
		public TArray<UNiagaraSystem> CritNiagaraList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraSystem> result;
				if ((result = this._CritNiagaraList) == null)
				{
					result = (this._CritNiagaraList = new TArray<UNiagaraSystem>(base.NativePtr + (IntPtr)UDamageUiManager.__PropertyOffset_CritNiagaraList, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CritNiagaraList.CopyAssign(value);
			}
		}

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x06005CB0 RID: 23728 RVA: 0x000828B7 File Offset: 0x00080AB7
		// (set) Token: 0x06005CB1 RID: 23729 RVA: 0x000828CB File Offset: 0x00080ACB
		public unsafe UDamageBatchView DamageBatchView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDamageBatchView>(base.NativePtr / (IntPtr)sizeof(void*) + UDamageUiManager.__PropertyOffset_DamageBatchView);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UDamageUiManager.__PropertyOffset_DamageBatchView, value);
			}
		}

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x06005CB2 RID: 23730 RVA: 0x000828E0 File Offset: 0x00080AE0
		// (set) Token: 0x06005CB3 RID: 23731 RVA: 0x000828F0 File Offset: 0x00080AF0
		public unsafe bool bDamageViewVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDamageUiManager.__PropertyOffset_bDamageViewVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDamageUiManager.__PropertyOffset_bDamageViewVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x06005CB4 RID: 23732 RVA: 0x00082901 File Offset: 0x00080B01
		// (set) Token: 0x06005CB5 RID: 23733 RVA: 0x00082915 File Offset: 0x00080B15
		public unsafe UKSC_World KscWorld
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_World>(base.NativePtr / (IntPtr)sizeof(void*) + UDamageUiManager.__PropertyOffset_KscWorld);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UDamageUiManager.__PropertyOffset_KscWorld, value);
			}
		}

		// Token: 0x06005CB6 RID: 23734 RVA: 0x0008292A File Offset: 0x00080B2A
		public void UpdateKscWorld()
		{
			UDamageUiManager.__UpdateKscWorld_Internal(base.NativePtr);
		}

		// Token: 0x06005CB7 RID: 23735 RVA: 0x00082938 File Offset: 0x00080B38
		public unsafe void Update(in float DeltaTime, in FVectorDouble CameraLocation, APlayerController Player)
		{
			fixed (float* ptr = &DeltaTime)
			{
				void* ptr2 = (void*)ptr;
				UDamageUiManager.__Update_Internal(base.NativePtr, DeltaTime, CameraLocation, (Player != null) ? Player.NativePtr : IntPtr.Zero);
			}
		}

		// Token: 0x06005CB8 RID: 23736 RVA: 0x0008296A File Offset: 0x00080B6A
		public void InitDamageConfig(in FDamageConfig InDamageConfig)
		{
			UDamageUiManager.__InitDamageConfig_Internal(base.NativePtr, (InDamageConfig ?? new FDamageConfig()).NativePtr);
		}

		// Token: 0x06005CB9 RID: 23737 RVA: 0x00082988 File Offset: 0x00080B88
		public void InitAllRes(USceneComponent Parent, AUIBaseActor DynamicBatchActor, AUIBaseActor DamageActor, int PreloadCount, bool bMobilePlatform)
		{
			UDamageUiManager.__InitAllRes_Internal(base.NativePtr, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, (DynamicBatchActor != null) ? DynamicBatchActor.NativePtr : IntPtr.Zero, (DamageActor != null) ? DamageActor.NativePtr : IntPtr.Zero, PreloadCount, bMobilePlatform);
		}

		// Token: 0x06005CBA RID: 23738 RVA: 0x000829D4 File Offset: 0x00080BD4
		public static UDamageUiManager GetInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UDamageUiManager>(UDamageUiManager.__GetInstance_Internal());
		}

		// Token: 0x06005CBB RID: 23739
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyInstance();

		// Token: 0x06005CBC RID: 23740 RVA: 0x000829E0 File Offset: 0x00080BE0
		public static UDamageUiManager CreateInstance(UObject Outer)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UDamageUiManager>(UDamageUiManager.__CreateInstance_Internal((Outer != null) ? Outer.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06005CBD RID: 23741 RVA: 0x000829FC File Offset: 0x00080BFC
		public void ClearDamageInfo()
		{
			UDamageUiManager.__ClearDamageInfo_Internal(base.NativePtr);
		}

		// Token: 0x06005CBE RID: 23742 RVA: 0x00082A09 File Offset: 0x00080C09
		public void AddDamageViewData(in FDamageViewData InDamageViewData)
		{
			UDamageUiManager.__AddDamageViewData_Internal(base.NativePtr, (InDamageViewData ?? new FDamageViewData()).NativePtr);
		}

		// Token: 0x06005CBF RID: 23743 RVA: 0x00082A26 File Offset: 0x00080C26
		public void AddDamageInfo(in FDamageInfo DamageInfo)
		{
			UDamageUiManager.__AddDamageInfo_Internal(base.NativePtr, (DamageInfo ?? new FDamageInfo()).NativePtr);
		}

		// Token: 0x06005CC0 RID: 23744 RVA: 0x00082A43 File Offset: 0x00080C43
		public void AddCritNiagara(UNiagaraSystem CritNiagara)
		{
			UDamageUiManager.__AddCritNiagara_Internal(base.NativePtr, (CritNiagara != null) ? CritNiagara.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005CC1 RID: 23745
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateKscWorld_Internal(IntPtr @this);

		// Token: 0x06005CC2 RID: 23746
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Update_Internal(IntPtr @this, in float DeltaTime, in FVectorDouble CameraLocation, IntPtr Player);

		// Token: 0x06005CC3 RID: 23747
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitDamageConfig_Internal(IntPtr @this, IntPtr InDamageConfig);

		// Token: 0x06005CC4 RID: 23748
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitAllRes_Internal(IntPtr @this, IntPtr Parent, IntPtr DynamicBatchActor, IntPtr DamageActor, int PreloadCount, bool bMobilePlatform);

		// Token: 0x06005CC5 RID: 23749
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstance_Internal();

		// Token: 0x06005CC6 RID: 23750
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateInstance_Internal(IntPtr Outer);

		// Token: 0x06005CC7 RID: 23751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearDamageInfo_Internal(IntPtr @this);

		// Token: 0x06005CC8 RID: 23752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddDamageViewData_Internal(IntPtr @this, IntPtr InDamageViewData);

		// Token: 0x06005CC9 RID: 23753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddDamageInfo_Internal(IntPtr @this, IntPtr DamageInfo);

		// Token: 0x06005CCA RID: 23754
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddCritNiagara_Internal(IntPtr @this, IntPtr CritNiagara);

		// Token: 0x06005CCB RID: 23755 RVA: 0x00082A60 File Offset: 0x00080C60
		static UDamageUiManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplayUI.DamageUiManager");
		}

		// Token: 0x06005CCC RID: 23756 RVA: 0x00082A6E File Offset: 0x00080C6E
		protected UDamageUiManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040026A4 RID: 9892
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplayUI.DamageUiManager";

		// Token: 0x040026A5 RID: 9893
		private static IntPtr _ClassPtr;

		// Token: 0x040026A6 RID: 9894
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040026A7 RID: 9895
		internal static int __PropertyOffset_CritNiagaraList;

		// Token: 0x040026A8 RID: 9896
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraSystem> _CritNiagaraList;

		// Token: 0x040026A9 RID: 9897
		internal static int __PropertyOffset_DamageBatchView;

		// Token: 0x040026AA RID: 9898
		internal static int __PropertyOffset_bDamageViewVisible;

		// Token: 0x040026AB RID: 9899
		internal static int __PropertyOffset_KscWorld;
	}
}
