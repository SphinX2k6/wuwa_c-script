using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002564 RID: 9572
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UNiagaraDataInterfaceArrayFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060238B8 RID: 145592 RVA: 0x00348B6A File Offset: 0x00346D6A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceArrayFunctionLibrary._ClassPtr;
		}

		// Token: 0x060238B9 RID: 145593 RVA: 0x00348B78 File Offset: 0x00346D78
		public UNiagaraDataInterfaceArrayFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060238BA RID: 145594 RVA: 0x00348BA0 File Offset: 0x00346DA0
		public UNiagaraDataInterfaceArrayFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060238BB RID: 145595 RVA: 0x00348BD3 File Offset: 0x00346DD3
		[NullableContext(2)]
		public static void SetNiagaraArrayVector4(UNiagaraComponent NiagaraSystem, FName OverrideName, in TArray<FVector4> ArrayData)
		{
			UNiagaraDataInterfaceArrayFunctionLibrary.__SetNiagaraArrayVector4_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName, (ArrayData ?? new TArray<FVector4>()).NativePtr);
		}

		// Token: 0x060238BC RID: 145596 RVA: 0x00348BFB File Offset: 0x00346DFB
		[NullableContext(2)]
		public static void SetNiagaraArrayVector2D(UNiagaraComponent NiagaraSystem, FName OverrideName, in TArray<FVector2D> ArrayData)
		{
			UNiagaraDataInterfaceArrayFunctionLibrary.__SetNiagaraArrayVector2D_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName, (ArrayData ?? new TArray<FVector2D>()).NativePtr);
		}

		// Token: 0x060238BD RID: 145597 RVA: 0x00348C23 File Offset: 0x00346E23
		[NullableContext(2)]
		public static void SetNiagaraArrayVector(UNiagaraComponent NiagaraSystem, FName OverrideName, in TArray<FVector> ArrayData)
		{
			UNiagaraDataInterfaceArrayFunctionLibrary.__SetNiagaraArrayVector_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName, (ArrayData ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x060238BE RID: 145598 RVA: 0x00348C4B File Offset: 0x00346E4B
		[NullableContext(2)]
		public static void SetNiagaraArrayQuat(UNiagaraComponent NiagaraSystem, FName OverrideName, in TArray<FQuat> ArrayData)
		{
			UNiagaraDataInterfaceArrayFunctionLibrary.__SetNiagaraArrayQuat_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName, (ArrayData ?? new TArray<FQuat>()).NativePtr);
		}

		// Token: 0x060238BF RID: 145599 RVA: 0x00348C73 File Offset: 0x00346E73
		[NullableContext(2)]
		public static void SetNiagaraArrayInt32(UNiagaraComponent NiagaraSystem, FName OverrideName, in TArray<int> ArrayData)
		{
			UNiagaraDataInterfaceArrayFunctionLibrary.__SetNiagaraArrayInt32_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName, (ArrayData ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x060238C0 RID: 145600 RVA: 0x00348C9B File Offset: 0x00346E9B
		[NullableContext(2)]
		public static void SetNiagaraArrayFloat(UNiagaraComponent NiagaraSystem, FName OverrideName, in TArray<float> ArrayData)
		{
			UNiagaraDataInterfaceArrayFunctionLibrary.__SetNiagaraArrayFloat_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName, (ArrayData ?? new TArray<float>()).NativePtr);
		}

		// Token: 0x060238C1 RID: 145601 RVA: 0x00348CC3 File Offset: 0x00346EC3
		[NullableContext(2)]
		public static void SetNiagaraArrayColor(UNiagaraComponent NiagaraSystem, FName OverrideName, in TArray<FLinearColor> ArrayData)
		{
			UNiagaraDataInterfaceArrayFunctionLibrary.__SetNiagaraArrayColor_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName, (ArrayData ?? new TArray<FLinearColor>()).NativePtr);
		}

		// Token: 0x060238C2 RID: 145602 RVA: 0x00348CEB File Offset: 0x00346EEB
		[NullableContext(2)]
		public static void SetNiagaraArrayBool(UNiagaraComponent NiagaraSystem, FName OverrideName, in TArray<bool> ArrayData)
		{
			UNiagaraDataInterfaceArrayFunctionLibrary.__SetNiagaraArrayBool_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName, (ArrayData ?? new TArray<bool>()).NativePtr);
		}

		// Token: 0x060238C3 RID: 145603 RVA: 0x00348D13 File Offset: 0x00346F13
		public static TArray<FVector4> GetNiagaraArrayVector4([Nullable(2)] UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			return new TArray<FVector4>(UNiagaraDataInterfaceArrayFunctionLibrary.__GetNiagaraArrayVector4_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName), null);
		}

		// Token: 0x060238C4 RID: 145604 RVA: 0x00348D31 File Offset: 0x00346F31
		public static TArray<FVector2D> GetNiagaraArrayVector2D([Nullable(2)] UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			return new TArray<FVector2D>(UNiagaraDataInterfaceArrayFunctionLibrary.__GetNiagaraArrayVector2D_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName), null);
		}

		// Token: 0x060238C5 RID: 145605 RVA: 0x00348D4F File Offset: 0x00346F4F
		public static TArray<FVector> GetNiagaraArrayVector([Nullable(2)] UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			return new TArray<FVector>(UNiagaraDataInterfaceArrayFunctionLibrary.__GetNiagaraArrayVector_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName), null);
		}

		// Token: 0x060238C6 RID: 145606 RVA: 0x00348D6D File Offset: 0x00346F6D
		public static TArray<FQuat> GetNiagaraArrayQuat([Nullable(2)] UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			return new TArray<FQuat>(UNiagaraDataInterfaceArrayFunctionLibrary.__GetNiagaraArrayQuat_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName), null);
		}

		// Token: 0x060238C7 RID: 145607 RVA: 0x00348D8B File Offset: 0x00346F8B
		public static TArray<int> GetNiagaraArrayInt32([Nullable(2)] UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			return new TArray<int>(UNiagaraDataInterfaceArrayFunctionLibrary.__GetNiagaraArrayInt32_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName), null);
		}

		// Token: 0x060238C8 RID: 145608 RVA: 0x00348DA9 File Offset: 0x00346FA9
		public static TArray<float> GetNiagaraArrayFloat([Nullable(2)] UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			return new TArray<float>(UNiagaraDataInterfaceArrayFunctionLibrary.__GetNiagaraArrayFloat_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName), null);
		}

		// Token: 0x060238C9 RID: 145609 RVA: 0x00348DC7 File Offset: 0x00346FC7
		public static TArray<FLinearColor> GetNiagaraArrayColor([Nullable(2)] UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			return new TArray<FLinearColor>(UNiagaraDataInterfaceArrayFunctionLibrary.__GetNiagaraArrayColor_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName), null);
		}

		// Token: 0x060238CA RID: 145610 RVA: 0x00348DE5 File Offset: 0x00346FE5
		public static TArray<bool> GetNiagaraArrayBool([Nullable(2)] UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			return new TArray<bool>(UNiagaraDataInterfaceArrayFunctionLibrary.__GetNiagaraArrayBool_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName), null);
		}

		// Token: 0x060238CB RID: 145611
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraArrayVector4_Internal(IntPtr NiagaraSystem, FName OverrideName, IntPtr ArrayData);

		// Token: 0x060238CC RID: 145612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraArrayVector2D_Internal(IntPtr NiagaraSystem, FName OverrideName, IntPtr ArrayData);

		// Token: 0x060238CD RID: 145613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraArrayVector_Internal(IntPtr NiagaraSystem, FName OverrideName, IntPtr ArrayData);

		// Token: 0x060238CE RID: 145614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraArrayQuat_Internal(IntPtr NiagaraSystem, FName OverrideName, IntPtr ArrayData);

		// Token: 0x060238CF RID: 145615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraArrayInt32_Internal(IntPtr NiagaraSystem, FName OverrideName, IntPtr ArrayData);

		// Token: 0x060238D0 RID: 145616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraArrayFloat_Internal(IntPtr NiagaraSystem, FName OverrideName, IntPtr ArrayData);

		// Token: 0x060238D1 RID: 145617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraArrayColor_Internal(IntPtr NiagaraSystem, FName OverrideName, IntPtr ArrayData);

		// Token: 0x060238D2 RID: 145618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraArrayBool_Internal(IntPtr NiagaraSystem, FName OverrideName, IntPtr ArrayData);

		// Token: 0x060238D3 RID: 145619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraArrayVector4_Internal(IntPtr NiagaraSystem, FName OverrideName);

		// Token: 0x060238D4 RID: 145620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraArrayVector2D_Internal(IntPtr NiagaraSystem, FName OverrideName);

		// Token: 0x060238D5 RID: 145621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraArrayVector_Internal(IntPtr NiagaraSystem, FName OverrideName);

		// Token: 0x060238D6 RID: 145622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraArrayQuat_Internal(IntPtr NiagaraSystem, FName OverrideName);

		// Token: 0x060238D7 RID: 145623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraArrayInt32_Internal(IntPtr NiagaraSystem, FName OverrideName);

		// Token: 0x060238D8 RID: 145624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraArrayFloat_Internal(IntPtr NiagaraSystem, FName OverrideName);

		// Token: 0x060238D9 RID: 145625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraArrayColor_Internal(IntPtr NiagaraSystem, FName OverrideName);

		// Token: 0x060238DA RID: 145626
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraArrayBool_Internal(IntPtr NiagaraSystem, FName OverrideName);

		// Token: 0x060238DB RID: 145627 RVA: 0x00348E03 File Offset: 0x00347003
		static UNiagaraDataInterfaceArrayFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary");
		}

		// Token: 0x060238DC RID: 145628 RVA: 0x00348E11 File Offset: 0x00347011
		protected UNiagaraDataInterfaceArrayFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130E3 RID: 78051
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary";

		// Token: 0x040130E4 RID: 78052
		private static IntPtr _ClassPtr;

		// Token: 0x040130E5 RID: 78053
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
