using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DE7 RID: 7655
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_GPUHeadUI")]
	[UnrealStructLayout(1200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1200)]
	public abstract class AKSC_GPUHeadUI : AActor, IUnrealUObject, IUnrealObject, IKSC_RenderEntityHeadUIInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601D404 RID: 119812 RVA: 0x002B31B8 File Offset: 0x002B13B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_GPUHeadUI._ClassPtr;
		}

		// Token: 0x0601D405 RID: 119813 RVA: 0x002B31C4 File Offset: 0x002B13C4
		int IKSC_RenderEntityHeadUIInterface.InterfaceOffset()
		{
			return AKSC_GPUHeadUI.__InterfaceOffset_IKSC_RenderEntityHeadUIInterface;
		}

		// Token: 0x17007619 RID: 30233
		// (get) Token: 0x0601D406 RID: 119814 RVA: 0x002B31CC File Offset: 0x002B13CC
		// (set) Token: 0x0601D407 RID: 119815 RVA: 0x002B3205 File Offset: 0x002B1405
		public TArray<int> InstanceIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._InstanceIndices) == null)
				{
					result = (this._InstanceIndices = new TArray<int>(base.NativePtr + (IntPtr)AKSC_GPUHeadUI.__PropertyOffset_InstanceIndices, this));
				}
				return result;
			}
			set
			{
				this.InstanceIndices.CopyAssign(value);
			}
		}

		// Token: 0x1700761A RID: 30234
		// (get) Token: 0x0601D408 RID: 119816 RVA: 0x002B3214 File Offset: 0x002B1414
		// (set) Token: 0x0601D409 RID: 119817 RVA: 0x002B324D File Offset: 0x002B144D
		public TArray<int> RemovedIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._RemovedIndices) == null)
				{
					result = (this._RemovedIndices = new TArray<int>(base.NativePtr + (IntPtr)AKSC_GPUHeadUI.__PropertyOffset_RemovedIndices, this));
				}
				return result;
			}
			set
			{
				this.RemovedIndices.CopyAssign(value);
			}
		}

		// Token: 0x1700761B RID: 30235
		// (get) Token: 0x0601D40A RID: 119818 RVA: 0x002B325C File Offset: 0x002B145C
		// (set) Token: 0x0601D40B RID: 119819 RVA: 0x002B3295 File Offset: 0x002B1495
		public TArray<FTransform> InstanceTransform
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._InstanceTransform) == null)
				{
					result = (this._InstanceTransform = new TArray<FTransform>(base.NativePtr + (IntPtr)AKSC_GPUHeadUI.__PropertyOffset_InstanceTransform, this));
				}
				return result;
			}
			set
			{
				this.InstanceTransform.CopyAssign(value);
			}
		}

		// Token: 0x1700761C RID: 30236
		// (get) Token: 0x0601D40C RID: 119820 RVA: 0x002B32A4 File Offset: 0x002B14A4
		// (set) Token: 0x0601D40D RID: 119821 RVA: 0x002B32DD File Offset: 0x002B14DD
		public TMap<int, int> EntityToInstanceMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._EntityToInstanceMap) == null)
				{
					result = (this._EntityToInstanceMap = new TMap<int, int>(base.NativePtr + (IntPtr)AKSC_GPUHeadUI.__PropertyOffset_EntityToInstanceMap, this));
				}
				return result;
			}
			set
			{
				this.EntityToInstanceMap.CopyAssign(value);
			}
		}

		// Token: 0x1700761D RID: 30237
		// (get) Token: 0x0601D40E RID: 119822 RVA: 0x002B32EB File Offset: 0x002B14EB
		// (set) Token: 0x0601D40F RID: 119823 RVA: 0x002B32FF File Offset: 0x002B14FF
		[Nullable(2)]
		public unsafe UInstancedStaticMeshComponent Comp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_GPUHeadUI.__PropertyOffset_Comp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_GPUHeadUI.__PropertyOffset_Comp, value);
			}
		}

		// Token: 0x1700761E RID: 30238
		// (get) Token: 0x0601D410 RID: 119824 RVA: 0x002B3314 File Offset: 0x002B1514
		// (set) Token: 0x0601D411 RID: 119825 RVA: 0x002B3328 File Offset: 0x002B1528
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic MI
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_GPUHeadUI.__PropertyOffset_MI);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_GPUHeadUI.__PropertyOffset_MI, value);
			}
		}

		// Token: 0x0601D412 RID: 119826 RVA: 0x002B333D File Offset: 0x002B153D
		[NullableContext(2)]
		public void InitHeadUIInternal(UInstancedStaticMeshComponent InComp, UMaterialInstanceDynamic InMI)
		{
			AKSC_GPUHeadUI.__InitHeadUIInternal_Internal(base.NativePtr, (InComp != null) ? InComp.NativePtr : IntPtr.Zero, (InMI != null) ? InMI.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D413 RID: 119827 RVA: 0x002B336A File Offset: 0x002B156A
		public virtual void InitHeadUI()
		{
			AKSC_GPUHeadUI.__InitHeadUI_Internal(base.NativePtr);
		}

		// Token: 0x0601D414 RID: 119828
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitHeadUIInternal_Internal(IntPtr @this, IntPtr InComp, IntPtr InMI);

		// Token: 0x0601D415 RID: 119829
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitHeadUI_Internal(IntPtr @this);

		// Token: 0x0601D416 RID: 119830 RVA: 0x002B3377 File Offset: 0x002B1577
		static AKSC_GPUHeadUI()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_GPUHeadUI");
		}

		// Token: 0x0601D417 RID: 119831 RVA: 0x002B3388 File Offset: 0x002B1588
		protected AKSC_GPUHeadUI() : this(BuiltinUtils.AllocNativeUObject(AKSC_GPUHeadUI.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D418 RID: 119832 RVA: 0x002B33B0 File Offset: 0x002B15B0
		protected AKSC_GPUHeadUI(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FDF1 RID: 65009
		internal static int __InterfaceOffset_IKSC_RenderEntityHeadUIInterface;

		// Token: 0x0400FDF2 RID: 65010
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_GPUHeadUI";

		// Token: 0x0400FDF3 RID: 65011
		private static IntPtr _ClassPtr;

		// Token: 0x0400FDF4 RID: 65012
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FDF5 RID: 65013
		internal static int __PropertyOffset_InstanceIndices;

		// Token: 0x0400FDF6 RID: 65014
		[Nullable(2)]
		private TArray<int> _InstanceIndices;

		// Token: 0x0400FDF7 RID: 65015
		internal static int __PropertyOffset_RemovedIndices;

		// Token: 0x0400FDF8 RID: 65016
		[Nullable(2)]
		private TArray<int> _RemovedIndices;

		// Token: 0x0400FDF9 RID: 65017
		internal static int __PropertyOffset_InstanceTransform;

		// Token: 0x0400FDFA RID: 65018
		[Nullable(2)]
		private TArray<FTransform> _InstanceTransform;

		// Token: 0x0400FDFB RID: 65019
		internal static int __PropertyOffset_EntityToInstanceMap;

		// Token: 0x0400FDFC RID: 65020
		[Nullable(2)]
		private TMap<int, int> _EntityToInstanceMap;

		// Token: 0x0400FDFD RID: 65021
		internal static int __PropertyOffset_Comp;

		// Token: 0x0400FDFE RID: 65022
		internal static int __PropertyOffset_MI;
	}
}
