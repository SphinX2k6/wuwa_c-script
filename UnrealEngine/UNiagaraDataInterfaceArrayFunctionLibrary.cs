using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007A6 RID: 1958
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UNiagaraDataInterfaceArrayFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AA22 RID: 43554 RVA: 0x000FAFE7 File Offset: 0x000F91E7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceArrayFunctionLibrary._ClassPtr;
		}

		// Token: 0x0600AA23 RID: 43555 RVA: 0x000FAFF4 File Offset: 0x000F91F4
		public UNiagaraDataInterfaceArrayFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AA24 RID: 43556 RVA: 0x000FB01C File Offset: 0x000F921C
		public UNiagaraDataInterfaceArrayFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600AA25 RID: 43557 RVA: 0x000FB04F File Offset: 0x000F924F
		[NullableContext(2)]
		public static void SetNiagaraArrayVector4(UNiagaraComponent NiagaraSystem, FName OverrideName, in TArray<FVector4> ArrayData)
		{
			UNiagaraDataInterfaceArrayFunctionLibrary.__SetNiagaraArrayVector4_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName, (ArrayData ?? new TArray<FVector4>()).NativePtr);
		}

		// Token: 0x0600AA26 RID: 43558 RVA: 0x000FB077 File Offset: 0x000F9277
		[NullableContext(2)]
		public static void SetNiagaraArrayVector2D(UNiagaraComponent NiagaraSystem, FName OverrideName, in TArray<FVector2D> ArrayData)
		{
			UNiagaraDataInterfaceArrayFunctionLibrary.__SetNiagaraArrayVector2D_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName, (ArrayData ?? new TArray<FVector2D>()).NativePtr);
		}

		// Token: 0x0600AA27 RID: 43559 RVA: 0x000FB09F File Offset: 0x000F929F
		[NullableContext(2)]
		public static void SetNiagaraArrayVector(UNiagaraComponent NiagaraSystem, FName OverrideName, in TArray<FVector> ArrayData)
		{
			UNiagaraDataInterfaceArrayFunctionLibrary.__SetNiagaraArrayVector_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName, (ArrayData ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x0600AA28 RID: 43560 RVA: 0x000FB0C7 File Offset: 0x000F92C7
		[NullableContext(2)]
		public static void SetNiagaraArrayQuat(UNiagaraComponent NiagaraSystem, FName OverrideName, in TArray<FQuat> ArrayData)
		{
			UNiagaraDataInterfaceArrayFunctionLibrary.__SetNiagaraArrayQuat_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName, (ArrayData ?? new TArray<FQuat>()).NativePtr);
		}

		// Token: 0x0600AA29 RID: 43561 RVA: 0x000FB0EF File Offset: 0x000F92EF
		[NullableContext(2)]
		public static void SetNiagaraArrayInt32(UNiagaraComponent NiagaraSystem, FName OverrideName, in TArray<int> ArrayData)
		{
			UNiagaraDataInterfaceArrayFunctionLibrary.__SetNiagaraArrayInt32_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName, (ArrayData ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x0600AA2A RID: 43562 RVA: 0x000FB117 File Offset: 0x000F9317
		[NullableContext(2)]
		public static void SetNiagaraArrayFloat(UNiagaraComponent NiagaraSystem, FName OverrideName, in TArray<float> ArrayData)
		{
			UNiagaraDataInterfaceArrayFunctionLibrary.__SetNiagaraArrayFloat_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName, (ArrayData ?? new TArray<float>()).NativePtr);
		}

		// Token: 0x0600AA2B RID: 43563 RVA: 0x000FB13F File Offset: 0x000F933F
		[NullableContext(2)]
		public static void SetNiagaraArrayColor(UNiagaraComponent NiagaraSystem, FName OverrideName, in TArray<FLinearColor> ArrayData)
		{
			UNiagaraDataInterfaceArrayFunctionLibrary.__SetNiagaraArrayColor_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName, (ArrayData ?? new TArray<FLinearColor>()).NativePtr);
		}

		// Token: 0x0600AA2C RID: 43564 RVA: 0x000FB167 File Offset: 0x000F9367
		[NullableContext(2)]
		public static void SetNiagaraArrayBool(UNiagaraComponent NiagaraSystem, FName OverrideName, in TArray<bool> ArrayData)
		{
			UNiagaraDataInterfaceArrayFunctionLibrary.__SetNiagaraArrayBool_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName, (ArrayData ?? new TArray<bool>()).NativePtr);
		}

		// Token: 0x0600AA2D RID: 43565 RVA: 0x000FB18F File Offset: 0x000F938F
		public static TArray<FVector4> GetNiagaraArrayVector4([Nullable(2)] UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			return new TArray<FVector4>(UNiagaraDataInterfaceArrayFunctionLibrary.__GetNiagaraArrayVector4_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName), null);
		}

		// Token: 0x0600AA2E RID: 43566 RVA: 0x000FB1AD File Offset: 0x000F93AD
		public static TArray<FVector2D> GetNiagaraArrayVector2D([Nullable(2)] UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			return new TArray<FVector2D>(UNiagaraDataInterfaceArrayFunctionLibrary.__GetNiagaraArrayVector2D_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName), null);
		}

		// Token: 0x0600AA2F RID: 43567 RVA: 0x000FB1CB File Offset: 0x000F93CB
		public static TArray<FVector> GetNiagaraArrayVector([Nullable(2)] UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			return new TArray<FVector>(UNiagaraDataInterfaceArrayFunctionLibrary.__GetNiagaraArrayVector_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName), null);
		}

		// Token: 0x0600AA30 RID: 43568 RVA: 0x000FB1E9 File Offset: 0x000F93E9
		public static TArray<FQuat> GetNiagaraArrayQuat([Nullable(2)] UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			return new TArray<FQuat>(UNiagaraDataInterfaceArrayFunctionLibrary.__GetNiagaraArrayQuat_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName), null);
		}

		// Token: 0x0600AA31 RID: 43569 RVA: 0x000FB207 File Offset: 0x000F9407
		public static TArray<int> GetNiagaraArrayInt32([Nullable(2)] UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			return new TArray<int>(UNiagaraDataInterfaceArrayFunctionLibrary.__GetNiagaraArrayInt32_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName), null);
		}

		// Token: 0x0600AA32 RID: 43570 RVA: 0x000FB225 File Offset: 0x000F9425
		public static TArray<float> GetNiagaraArrayFloat([Nullable(2)] UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			return new TArray<float>(UNiagaraDataInterfaceArrayFunctionLibrary.__GetNiagaraArrayFloat_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName), null);
		}

		// Token: 0x0600AA33 RID: 43571 RVA: 0x000FB243 File Offset: 0x000F9443
		public static TArray<FLinearColor> GetNiagaraArrayColor([Nullable(2)] UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			return new TArray<FLinearColor>(UNiagaraDataInterfaceArrayFunctionLibrary.__GetNiagaraArrayColor_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName), null);
		}

		// Token: 0x0600AA34 RID: 43572 RVA: 0x000FB261 File Offset: 0x000F9461
		public static TArray<bool> GetNiagaraArrayBool([Nullable(2)] UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			return new TArray<bool>(UNiagaraDataInterfaceArrayFunctionLibrary.__GetNiagaraArrayBool_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, OverrideName), null);
		}

		// Token: 0x0600AA35 RID: 43573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraArrayVector4_Internal(IntPtr NiagaraSystem, FName OverrideName, IntPtr ArrayData);

		// Token: 0x0600AA36 RID: 43574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraArrayVector2D_Internal(IntPtr NiagaraSystem, FName OverrideName, IntPtr ArrayData);

		// Token: 0x0600AA37 RID: 43575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraArrayVector_Internal(IntPtr NiagaraSystem, FName OverrideName, IntPtr ArrayData);

		// Token: 0x0600AA38 RID: 43576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraArrayQuat_Internal(IntPtr NiagaraSystem, FName OverrideName, IntPtr ArrayData);

		// Token: 0x0600AA39 RID: 43577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraArrayInt32_Internal(IntPtr NiagaraSystem, FName OverrideName, IntPtr ArrayData);

		// Token: 0x0600AA3A RID: 43578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraArrayFloat_Internal(IntPtr NiagaraSystem, FName OverrideName, IntPtr ArrayData);

		// Token: 0x0600AA3B RID: 43579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraArrayColor_Internal(IntPtr NiagaraSystem, FName OverrideName, IntPtr ArrayData);

		// Token: 0x0600AA3C RID: 43580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraArrayBool_Internal(IntPtr NiagaraSystem, FName OverrideName, IntPtr ArrayData);

		// Token: 0x0600AA3D RID: 43581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraArrayVector4_Internal(IntPtr NiagaraSystem, FName OverrideName);

		// Token: 0x0600AA3E RID: 43582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraArrayVector2D_Internal(IntPtr NiagaraSystem, FName OverrideName);

		// Token: 0x0600AA3F RID: 43583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraArrayVector_Internal(IntPtr NiagaraSystem, FName OverrideName);

		// Token: 0x0600AA40 RID: 43584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraArrayQuat_Internal(IntPtr NiagaraSystem, FName OverrideName);

		// Token: 0x0600AA41 RID: 43585
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraArrayInt32_Internal(IntPtr NiagaraSystem, FName OverrideName);

		// Token: 0x0600AA42 RID: 43586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraArrayFloat_Internal(IntPtr NiagaraSystem, FName OverrideName);

		// Token: 0x0600AA43 RID: 43587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraArrayColor_Internal(IntPtr NiagaraSystem, FName OverrideName);

		// Token: 0x0600AA44 RID: 43588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraArrayBool_Internal(IntPtr NiagaraSystem, FName OverrideName);

		// Token: 0x0600AA45 RID: 43589 RVA: 0x000FB27F File Offset: 0x000F947F
		static UNiagaraDataInterfaceArrayFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary");
		}

		// Token: 0x0600AA46 RID: 43590 RVA: 0x000FB28D File Offset: 0x000F948D
		protected UNiagaraDataInterfaceArrayFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040048E8 RID: 18664
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary";

		// Token: 0x040048E9 RID: 18665
		private static IntPtr _ClassPtr;

		// Token: 0x040048EA RID: 18666
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
