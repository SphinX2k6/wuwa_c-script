using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001811 RID: 6161
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroDynamicMeshBatch.PropBatchComponent")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UPropBatchComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016CB1 RID: 93361 RVA: 0x0021422E File Offset: 0x0021242E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPropBatchComponent._ClassPtr;
		}

		// Token: 0x06016CB2 RID: 93362 RVA: 0x0021423C File Offset: 0x0021243C
		public UPropBatchComponent() : this(BuiltinUtils.AllocNativeUObject(UPropBatchComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016CB3 RID: 93363 RVA: 0x00214264 File Offset: 0x00212464
		public UPropBatchComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPropBatchComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C0E RID: 23566
		// (get) Token: 0x06016CB4 RID: 93364 RVA: 0x00214297 File Offset: 0x00212497
		// (set) Token: 0x06016CB5 RID: 93365 RVA: 0x002142AB File Offset: 0x002124AB
		[Nullable(2)]
		public unsafe UPropGroupDataAsset DataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPropGroupDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UPropBatchComponent.__PropertyOffset_DataAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPropBatchComponent.__PropertyOffset_DataAsset, value);
			}
		}

		// Token: 0x17005C0F RID: 23567
		// (get) Token: 0x06016CB6 RID: 93366 RVA: 0x002142C0 File Offset: 0x002124C0
		// (set) Token: 0x06016CB7 RID: 93367 RVA: 0x002142F9 File Offset: 0x002124F9
		public TArray<UBatchableComponent> SpawnedProps
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBatchableComponent> result;
				if ((result = this._SpawnedProps) == null)
				{
					result = (this._SpawnedProps = new TArray<UBatchableComponent>(base.NativePtr + (IntPtr)UPropBatchComponent.__PropertyOffset_SpawnedProps, this));
				}
				return result;
			}
			set
			{
				this.SpawnedProps.CopyAssign(value);
			}
		}

		// Token: 0x06016CB8 RID: 93368 RVA: 0x00214307 File Offset: 0x00212507
		[NullableContext(2)]
		public void SetupFromDataAsset(UPropGroupDataAsset InDataAsset, AActor TargetActor = null)
		{
			UPropBatchComponent.__SetupFromDataAsset_Internal(base.NativePtr, (InDataAsset != null) ? InDataAsset.NativePtr : IntPtr.Zero, (TargetActor != null) ? TargetActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06016CB9 RID: 93369 RVA: 0x00214334 File Offset: 0x00212534
		public void RefreshProps()
		{
			UPropBatchComponent.__RefreshProps_Internal(base.NativePtr);
		}

		// Token: 0x06016CBA RID: 93370 RVA: 0x00214341 File Offset: 0x00212541
		public void ClearAllProps()
		{
			UPropBatchComponent.__ClearAllProps_Internal(base.NativePtr);
		}

		// Token: 0x06016CBB RID: 93371
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetupFromDataAsset_Internal(IntPtr @this, IntPtr InDataAsset, IntPtr TargetActor);

		// Token: 0x06016CBC RID: 93372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshProps_Internal(IntPtr @this);

		// Token: 0x06016CBD RID: 93373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAllProps_Internal(IntPtr @this);

		// Token: 0x06016CBE RID: 93374 RVA: 0x0021434E File Offset: 0x0021254E
		static UPropBatchComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroDynamicMeshBatch.PropBatchComponent");
		}

		// Token: 0x06016CBF RID: 93375 RVA: 0x0021435C File Offset: 0x0021255C
		protected UPropBatchComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C5D8 RID: 50648
		public new const string __ObjectPath = "/Script/KuroDynamicMeshBatch.PropBatchComponent";

		// Token: 0x0400C5D9 RID: 50649
		private static IntPtr _ClassPtr;

		// Token: 0x0400C5DA RID: 50650
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C5DB RID: 50651
		internal static int __PropertyOffset_DataAsset;

		// Token: 0x0400C5DC RID: 50652
		internal static int __PropertyOffset_SpawnedProps;

		// Token: 0x0400C5DD RID: 50653
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBatchableComponent> _SpawnedProps;
	}
}
