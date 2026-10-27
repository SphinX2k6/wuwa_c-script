using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001880 RID: 6272
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplayUI.DamageUiManager")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UDamageUiManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060171B6 RID: 94646 RVA: 0x0021AC9F File Offset: 0x00218E9F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDamageUiManager._ClassPtr;
		}

		// Token: 0x060171B7 RID: 94647 RVA: 0x0021ACAC File Offset: 0x00218EAC
		public UDamageUiManager() : this(BuiltinUtils.AllocNativeUObject(UDamageUiManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060171B8 RID: 94648 RVA: 0x0021ACD4 File Offset: 0x00218ED4
		[NullableContext(1)]
		public UDamageUiManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDamageUiManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005CF9 RID: 23801
		// (get) Token: 0x060171B9 RID: 94649 RVA: 0x0021AD08 File Offset: 0x00218F08
		// (set) Token: 0x060171BA RID: 94650 RVA: 0x0021AD41 File Offset: 0x00218F41
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

		// Token: 0x17005CFA RID: 23802
		// (get) Token: 0x060171BB RID: 94651 RVA: 0x0021AD4F File Offset: 0x00218F4F
		// (set) Token: 0x060171BC RID: 94652 RVA: 0x0021AD63 File Offset: 0x00218F63
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

		// Token: 0x17005CFB RID: 23803
		// (get) Token: 0x060171BD RID: 94653 RVA: 0x0021AD78 File Offset: 0x00218F78
		// (set) Token: 0x060171BE RID: 94654 RVA: 0x0021AD88 File Offset: 0x00218F88
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

		// Token: 0x17005CFC RID: 23804
		// (get) Token: 0x060171BF RID: 94655 RVA: 0x0021AD99 File Offset: 0x00218F99
		// (set) Token: 0x060171C0 RID: 94656 RVA: 0x0021ADAD File Offset: 0x00218FAD
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

		// Token: 0x060171C1 RID: 94657 RVA: 0x0021ADC2 File Offset: 0x00218FC2
		public void UpdateKscWorld()
		{
			UDamageUiManager.__UpdateKscWorld_Internal(base.NativePtr);
		}

		// Token: 0x060171C2 RID: 94658 RVA: 0x0021ADD0 File Offset: 0x00218FD0
		public unsafe void Update(in float DeltaTime, in FVectorDouble CameraLocation, APlayerController Player)
		{
			fixed (float* ptr = &DeltaTime)
			{
				void* ptr2 = (void*)ptr;
				UDamageUiManager.__Update_Internal(base.NativePtr, DeltaTime, CameraLocation, (Player != null) ? Player.NativePtr : IntPtr.Zero);
			}
		}

		// Token: 0x060171C3 RID: 94659 RVA: 0x0021AE02 File Offset: 0x00219002
		public void InitDamageConfig(in FDamageConfig InDamageConfig)
		{
			UDamageUiManager.__InitDamageConfig_Internal(base.NativePtr, (InDamageConfig ?? new FDamageConfig()).NativePtr);
		}

		// Token: 0x060171C4 RID: 94660 RVA: 0x0021AE20 File Offset: 0x00219020
		public void InitAllRes(USceneComponent Parent, AUIBaseActor DynamicBatchActor, AUIBaseActor DamageActor, int PreloadCount, bool bMobilePlatform)
		{
			UDamageUiManager.__InitAllRes_Internal(base.NativePtr, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, (DynamicBatchActor != null) ? DynamicBatchActor.NativePtr : IntPtr.Zero, (DamageActor != null) ? DamageActor.NativePtr : IntPtr.Zero, PreloadCount, bMobilePlatform);
		}

		// Token: 0x060171C5 RID: 94661 RVA: 0x0021AE6C File Offset: 0x0021906C
		public static UDamageUiManager GetInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UDamageUiManager>(UDamageUiManager.__GetInstance_Internal());
		}

		// Token: 0x060171C6 RID: 94662
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyInstance();

		// Token: 0x060171C7 RID: 94663 RVA: 0x0021AE78 File Offset: 0x00219078
		public static UDamageUiManager CreateInstance(UObject Outer)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UDamageUiManager>(UDamageUiManager.__CreateInstance_Internal((Outer != null) ? Outer.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060171C8 RID: 94664 RVA: 0x0021AE94 File Offset: 0x00219094
		public void ClearDamageInfo()
		{
			UDamageUiManager.__ClearDamageInfo_Internal(base.NativePtr);
		}

		// Token: 0x060171C9 RID: 94665 RVA: 0x0021AEA1 File Offset: 0x002190A1
		public void AddDamageViewData(in FDamageViewData InDamageViewData)
		{
			UDamageUiManager.__AddDamageViewData_Internal(base.NativePtr, (InDamageViewData ?? new FDamageViewData()).NativePtr);
		}

		// Token: 0x060171CA RID: 94666 RVA: 0x0021AEBE File Offset: 0x002190BE
		public void AddDamageInfo(in FDamageInfo DamageInfo)
		{
			UDamageUiManager.__AddDamageInfo_Internal(base.NativePtr, (DamageInfo ?? new FDamageInfo()).NativePtr);
		}

		// Token: 0x060171CB RID: 94667 RVA: 0x0021AEDB File Offset: 0x002190DB
		public void AddCritNiagara(UNiagaraSystem CritNiagara)
		{
			UDamageUiManager.__AddCritNiagara_Internal(base.NativePtr, (CritNiagara != null) ? CritNiagara.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060171CC RID: 94668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateKscWorld_Internal(IntPtr @this);

		// Token: 0x060171CD RID: 94669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Update_Internal(IntPtr @this, in float DeltaTime, in FVectorDouble CameraLocation, IntPtr Player);

		// Token: 0x060171CE RID: 94670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitDamageConfig_Internal(IntPtr @this, IntPtr InDamageConfig);

		// Token: 0x060171CF RID: 94671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitAllRes_Internal(IntPtr @this, IntPtr Parent, IntPtr DynamicBatchActor, IntPtr DamageActor, int PreloadCount, bool bMobilePlatform);

		// Token: 0x060171D0 RID: 94672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstance_Internal();

		// Token: 0x060171D1 RID: 94673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateInstance_Internal(IntPtr Outer);

		// Token: 0x060171D2 RID: 94674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearDamageInfo_Internal(IntPtr @this);

		// Token: 0x060171D3 RID: 94675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddDamageViewData_Internal(IntPtr @this, IntPtr InDamageViewData);

		// Token: 0x060171D4 RID: 94676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddDamageInfo_Internal(IntPtr @this, IntPtr DamageInfo);

		// Token: 0x060171D5 RID: 94677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddCritNiagara_Internal(IntPtr @this, IntPtr CritNiagara);

		// Token: 0x060171D6 RID: 94678 RVA: 0x0021AEF8 File Offset: 0x002190F8
		static UDamageUiManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplayUI.DamageUiManager");
		}

		// Token: 0x060171D7 RID: 94679 RVA: 0x0021AF06 File Offset: 0x00219106
		protected UDamageUiManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C895 RID: 51349
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplayUI.DamageUiManager";

		// Token: 0x0400C896 RID: 51350
		private static IntPtr _ClassPtr;

		// Token: 0x0400C897 RID: 51351
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C898 RID: 51352
		internal static int __PropertyOffset_CritNiagaraList;

		// Token: 0x0400C899 RID: 51353
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraSystem> _CritNiagaraList;

		// Token: 0x0400C89A RID: 51354
		internal static int __PropertyOffset_DamageBatchView;

		// Token: 0x0400C89B RID: 51355
		internal static int __PropertyOffset_bDamageViewVisible;

		// Token: 0x0400C89C RID: 51356
		internal static int __PropertyOffset_KscWorld;
	}
}
