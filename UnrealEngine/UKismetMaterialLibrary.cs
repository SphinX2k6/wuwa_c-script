using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000223 RID: 547
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KismetMaterialLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetMaterialLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002571 RID: 9585 RVA: 0x00035CA5 File Offset: 0x00033EA5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetMaterialLibrary._ClassPtr;
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x00035CB4 File Offset: 0x00033EB4
		public UKismetMaterialLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetMaterialLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x00035CDC File Offset: 0x00033EDC
		[NullableContext(1)]
		public UKismetMaterialLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetMaterialLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x00035D0F File Offset: 0x00033F0F
		public static void SetVectorParameterValue(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName, in FLinearColor ParameterValue)
		{
			UKismetMaterialLibrary.__SetVectorParameterValue_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName, ParameterValue);
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x00035D38 File Offset: 0x00033F38
		public static void SetScalarParameterValue(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName, float ParameterValue)
		{
			UKismetMaterialLibrary.__SetScalarParameterValue_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName, ParameterValue);
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x00035D61 File Offset: 0x00033F61
		public static void SetMPCVectorParameterValue(UMaterialParameterCollection Collection, FName ParameterName, in FLinearColor ParameterValue)
		{
			UKismetMaterialLibrary.__SetMPCVectorParameterValue_Internal((Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName, ParameterValue);
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x00035D7A File Offset: 0x00033F7A
		public static FLinearColor GetVectorParameterValue(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName)
		{
			return UKismetMaterialLibrary.__GetVectorParameterValue_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName);
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x00035DA2 File Offset: 0x00033FA2
		public static float GetScalarParameterValue(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName)
		{
			return UKismetMaterialLibrary.__GetScalarParameterValue_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName);
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x00035DCA File Offset: 0x00033FCA
		public static FLinearColor GetMPCVectorParameterValue(UMaterialParameterCollection Collection, FName ParameterName)
		{
			return UKismetMaterialLibrary.__GetMPCVectorParameterValue_Internal((Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName);
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x00035DE2 File Offset: 0x00033FE2
		public static UMaterialInstanceDynamic CreateDynamicMaterialInstance(UObject WorldContextObject, UMaterialInterface Parent, FName OptionalName = default(FName), EMIDCreationFlags CreationFlags = EMIDCreationFlags.None)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UKismetMaterialLibrary.__CreateDynamicMaterialInstance_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, OptionalName, CreationFlags));
		}

		// Token: 0x0600257B RID: 9595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorParameterValue_Internal(IntPtr WorldContextObject, IntPtr Collection, FName ParameterName, in FLinearColor ParameterValue);

		// Token: 0x0600257C RID: 9596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScalarParameterValue_Internal(IntPtr WorldContextObject, IntPtr Collection, FName ParameterName, float ParameterValue);

		// Token: 0x0600257D RID: 9597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMPCVectorParameterValue_Internal(IntPtr Collection, FName ParameterName, in FLinearColor ParameterValue);

		// Token: 0x0600257E RID: 9598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetVectorParameterValue_Internal(IntPtr WorldContextObject, IntPtr Collection, FName ParameterName);

		// Token: 0x0600257F RID: 9599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetScalarParameterValue_Internal(IntPtr WorldContextObject, IntPtr Collection, FName ParameterName);

		// Token: 0x06002580 RID: 9600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetMPCVectorParameterValue_Internal(IntPtr Collection, FName ParameterName);

		// Token: 0x06002581 RID: 9601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateDynamicMaterialInstance_Internal(IntPtr WorldContextObject, IntPtr Parent, FName OptionalName, EMIDCreationFlags CreationFlags);

		// Token: 0x06002582 RID: 9602 RVA: 0x00035E10 File Offset: 0x00034010
		static UKismetMaterialLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetMaterialLibrary");
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x00035E1E File Offset: 0x0003401E
		protected UKismetMaterialLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E0D RID: 3597
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KismetMaterialLibrary";

		// Token: 0x04000E0E RID: 3598
		private static IntPtr _ClassPtr;

		// Token: 0x04000E0F RID: 3599
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
