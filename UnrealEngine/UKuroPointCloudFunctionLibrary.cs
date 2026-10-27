using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A2B RID: 6699
	[UnrealObjectPath("/Script/KuroPointCloud.KuroPointCloudFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPointCloudFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018CA6 RID: 101542 RVA: 0x0024A25C File Offset: 0x0024845C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPointCloudFunctionLibrary._ClassPtr;
		}

		// Token: 0x06018CA7 RID: 101543 RVA: 0x0024A268 File Offset: 0x00248468
		public UKuroPointCloudFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroPointCloudFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018CA8 RID: 101544 RVA: 0x0024A290 File Offset: 0x00248490
		[NullableContext(1)]
		public UKuroPointCloudFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPointCloudFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018CA9 RID: 101545 RVA: 0x0024A2C3 File Offset: 0x002484C3
		[NullableContext(2)]
		public static bool SetNiagaraKuroPointCloudCollectionName(UNiagaraComponent NiagaraComponent, FName WorldCollecitonName, FName ParameterName)
		{
			return UKuroPointCloudFunctionLibrary.__SetNiagaraKuroPointCloudCollectionName_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero, WorldCollecitonName, ParameterName);
		}

		// Token: 0x06018CAA RID: 101546 RVA: 0x0024A2DC File Offset: 0x002484DC
		[NullableContext(2)]
		public static bool SetNiagaraKuroPointCloudCache(UNiagaraComponent NiagaraComponent, UKuroPointCloudCache KuroPointCloudCache, FName ParameterName)
		{
			return UKuroPointCloudFunctionLibrary.__SetNiagaraKuroPointCloudCache_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero, (KuroPointCloudCache != null) ? KuroPointCloudCache.NativePtr : IntPtr.Zero, ParameterName);
		}

		// Token: 0x06018CAB RID: 101547 RVA: 0x0024A304 File Offset: 0x00248504
		[NullableContext(2)]
		public unsafe static bool BindPointCloudComponent(UKuroPointCloudWorldComponent PointCloudComponent, ref int BindingKey)
		{
			fixed (int* ptr = &BindingKey)
			{
				void* ptr2 = (void*)ptr;
				return UKuroPointCloudFunctionLibrary.__BindPointCloudComponent_Internal((PointCloudComponent != null) ? PointCloudComponent.NativePtr : IntPtr.Zero, ref BindingKey);
			}
		}

		// Token: 0x06018CAC RID: 101548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetNiagaraKuroPointCloudCollectionName_Internal(IntPtr NiagaraComponent, FName WorldCollecitonName, FName ParameterName);

		// Token: 0x06018CAD RID: 101549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetNiagaraKuroPointCloudCache_Internal(IntPtr NiagaraComponent, IntPtr KuroPointCloudCache, FName ParameterName);

		// Token: 0x06018CAE RID: 101550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BindPointCloudComponent_Internal(IntPtr PointCloudComponent, ref int BindingKey);

		// Token: 0x06018CAF RID: 101551 RVA: 0x0024A32C File Offset: 0x0024852C
		static UKuroPointCloudFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPointCloud.KuroPointCloudFunctionLibrary");
		}

		// Token: 0x06018CB0 RID: 101552 RVA: 0x0024A33A File Offset: 0x0024853A
		protected UKuroPointCloudFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D679 RID: 54905
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroPointCloud.KuroPointCloudFunctionLibrary";

		// Token: 0x0400D67A RID: 54906
		private static IntPtr _ClassPtr;

		// Token: 0x0400D67B RID: 54907
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
