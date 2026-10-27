using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001808 RID: 6152
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroDynamicMeshBatch.BatchableComponent")]
	[UnrealStructLayout(624, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 624)]
	public class UBatchableComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016C3D RID: 93245 RVA: 0x0021398F File Offset: 0x00211B8F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBatchableComponent._ClassPtr;
		}

		// Token: 0x06016C3E RID: 93246 RVA: 0x0021399C File Offset: 0x00211B9C
		public UBatchableComponent() : this(BuiltinUtils.AllocNativeUObject(UBatchableComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016C3F RID: 93247 RVA: 0x002139C4 File Offset: 0x00211BC4
		[NullableContext(1)]
		public UBatchableComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBatchableComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005BFC RID: 23548
		// (get) Token: 0x06016C40 RID: 93248 RVA: 0x002139F7 File Offset: 0x00211BF7
		// (set) Token: 0x06016C41 RID: 93249 RVA: 0x00213A07 File Offset: 0x00211C07
		public unsafe bool bDynamicUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBatchableComponent.__PropertyOffset_bDynamicUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBatchableComponent.__PropertyOffset_bDynamicUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005BFD RID: 23549
		// (get) Token: 0x06016C42 RID: 93250 RVA: 0x00213A18 File Offset: 0x00211C18
		// (set) Token: 0x06016C43 RID: 93251 RVA: 0x00213A2C File Offset: 0x00211C2C
		public unsafe UStaticMesh InstanceStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UBatchableComponent.__PropertyOffset_InstanceStaticMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBatchableComponent.__PropertyOffset_InstanceStaticMesh, value);
			}
		}

		// Token: 0x17005BFE RID: 23550
		// (get) Token: 0x06016C44 RID: 93252 RVA: 0x00213A41 File Offset: 0x00211C41
		// (set) Token: 0x06016C45 RID: 93253 RVA: 0x00213A55 File Offset: 0x00211C55
		public unsafe UMaterialInterface InstanceMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UBatchableComponent.__PropertyOffset_InstanceMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBatchableComponent.__PropertyOffset_InstanceMaterial, value);
			}
		}

		// Token: 0x17005BFF RID: 23551
		// (get) Token: 0x06016C46 RID: 93254 RVA: 0x00213A6A File Offset: 0x00211C6A
		// (set) Token: 0x06016C47 RID: 93255 RVA: 0x00213A7A File Offset: 0x00211C7A
		public unsafe bool bHasBeenRemovedFromBatch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBatchableComponent.__PropertyOffset_bHasBeenRemovedFromBatch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBatchableComponent.__PropertyOffset_bHasBeenRemovedFromBatch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C00 RID: 23552
		// (get) Token: 0x06016C48 RID: 93256 RVA: 0x00213A8B File Offset: 0x00211C8B
		// (set) Token: 0x06016C49 RID: 93257 RVA: 0x00213A9B File Offset: 0x00211C9B
		public unsafe bool bIsRegistered
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBatchableComponent.__PropertyOffset_bIsRegistered) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBatchableComponent.__PropertyOffset_bIsRegistered) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C01 RID: 23553
		// (get) Token: 0x06016C4A RID: 93258 RVA: 0x00213AAC File Offset: 0x00211CAC
		// (set) Token: 0x06016C4B RID: 93259 RVA: 0x00213AE5 File Offset: 0x00211CE5
		[Nullable(1)]
		public FPropMaterialParams InstanceData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPropMaterialParams result;
				if ((result = this._InstanceData) == null)
				{
					result = (this._InstanceData = new FPropMaterialParams(base.NativePtr + (IntPtr)UBatchableComponent.__PropertyOffset_InstanceData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPropMaterialParams.StaticStruct(), base.NativePtr + (IntPtr)UBatchableComponent.__PropertyOffset_InstanceData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06016C4C RID: 93260 RVA: 0x00213B06 File Offset: 0x00211D06
		public void UpdateBatchInstance()
		{
			UBatchableComponent.__UpdateBatchInstance_Internal(base.NativePtr);
		}

		// Token: 0x06016C4D RID: 93261 RVA: 0x00213B13 File Offset: 0x00211D13
		public void UnregisterInstance()
		{
			UBatchableComponent.__UnregisterInstance_Internal(base.NativePtr);
		}

		// Token: 0x06016C4E RID: 93262 RVA: 0x00213B20 File Offset: 0x00211D20
		public bool ShouldBatch()
		{
			return UBatchableComponent.__ShouldBatch_Internal(base.NativePtr);
		}

		// Token: 0x06016C4F RID: 93263 RVA: 0x00213B2D File Offset: 0x00211D2D
		public void SetDynamicUpdate(bool bEnabled)
		{
			UBatchableComponent.__SetDynamicUpdate_Internal(base.NativePtr, bEnabled);
		}

		// Token: 0x06016C50 RID: 93264 RVA: 0x00213B3B File Offset: 0x00211D3B
		public void RegisterInstance()
		{
			UBatchableComponent.__RegisterInstance_Internal(base.NativePtr);
		}

		// Token: 0x06016C51 RID: 93265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateBatchInstance_Internal(IntPtr @this);

		// Token: 0x06016C52 RID: 93266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterInstance_Internal(IntPtr @this);

		// Token: 0x06016C53 RID: 93267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldBatch_Internal(IntPtr @this);

		// Token: 0x06016C54 RID: 93268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDynamicUpdate_Internal(IntPtr @this, bool bEnabled);

		// Token: 0x06016C55 RID: 93269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterInstance_Internal(IntPtr @this);

		// Token: 0x06016C56 RID: 93270 RVA: 0x00213B48 File Offset: 0x00211D48
		static UBatchableComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroDynamicMeshBatch.BatchableComponent");
		}

		// Token: 0x06016C57 RID: 93271 RVA: 0x00213B56 File Offset: 0x00211D56
		protected UBatchableComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C5AA RID: 50602
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroDynamicMeshBatch.BatchableComponent";

		// Token: 0x0400C5AB RID: 50603
		private static IntPtr _ClassPtr;

		// Token: 0x0400C5AC RID: 50604
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C5AD RID: 50605
		internal static int __PropertyOffset_bDynamicUpdate;

		// Token: 0x0400C5AE RID: 50606
		internal static int __PropertyOffset_InstanceStaticMesh;

		// Token: 0x0400C5AF RID: 50607
		internal static int __PropertyOffset_InstanceMaterial;

		// Token: 0x0400C5B0 RID: 50608
		internal static int __PropertyOffset_bHasBeenRemovedFromBatch;

		// Token: 0x0400C5B1 RID: 50609
		internal static int __PropertyOffset_bIsRegistered;

		// Token: 0x0400C5B2 RID: 50610
		internal static int __PropertyOffset_InstanceData;

		// Token: 0x0400C5B3 RID: 50611
		private FPropMaterialParams _InstanceData;
	}
}
