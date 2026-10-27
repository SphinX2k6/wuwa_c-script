using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CD0 RID: 3280
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KismetMaterialLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetMaterialLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A63B RID: 42555 RVA: 0x000ECCE5 File Offset: 0x000EAEE5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetMaterialLibrary._ClassPtr;
		}

		// Token: 0x0600A63C RID: 42556 RVA: 0x000ECCF4 File Offset: 0x000EAEF4
		public UKismetMaterialLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetMaterialLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A63D RID: 42557 RVA: 0x000ECD1C File Offset: 0x000EAF1C
		[NullableContext(1)]
		public UKismetMaterialLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetMaterialLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A63E RID: 42558 RVA: 0x000ECD4F File Offset: 0x000EAF4F
		public static void SetVectorParameterValue(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName, in FLinearColor ParameterValue)
		{
			UKismetMaterialLibrary.__SetVectorParameterValue_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName, ParameterValue);
		}

		// Token: 0x0600A63F RID: 42559 RVA: 0x000ECD78 File Offset: 0x000EAF78
		public static void SetScalarParameterValue(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName, float ParameterValue)
		{
			UKismetMaterialLibrary.__SetScalarParameterValue_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName, ParameterValue);
		}

		// Token: 0x0600A640 RID: 42560 RVA: 0x000ECDA1 File Offset: 0x000EAFA1
		public static void SetMPCVectorParameterValue(UMaterialParameterCollection Collection, FName ParameterName, in FLinearColor ParameterValue)
		{
			UKismetMaterialLibrary.__SetMPCVectorParameterValue_Internal((Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName, ParameterValue);
		}

		// Token: 0x0600A641 RID: 42561 RVA: 0x000ECDBA File Offset: 0x000EAFBA
		public static FLinearColor GetVectorParameterValue(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName)
		{
			return UKismetMaterialLibrary.__GetVectorParameterValue_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName);
		}

		// Token: 0x0600A642 RID: 42562 RVA: 0x000ECDE2 File Offset: 0x000EAFE2
		public static float GetScalarParameterValue(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName)
		{
			return UKismetMaterialLibrary.__GetScalarParameterValue_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName);
		}

		// Token: 0x0600A643 RID: 42563 RVA: 0x000ECE0A File Offset: 0x000EB00A
		public static FLinearColor GetMPCVectorParameterValue(UMaterialParameterCollection Collection, FName ParameterName)
		{
			return UKismetMaterialLibrary.__GetMPCVectorParameterValue_Internal((Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName);
		}

		// Token: 0x0600A644 RID: 42564 RVA: 0x000ECE22 File Offset: 0x000EB022
		public static UMaterialInstanceDynamic CreateDynamicMaterialInstance(UObject WorldContextObject, UMaterialInterface Parent, FName OptionalName = default(FName), EMIDCreationFlags CreationFlags = EMIDCreationFlags.None)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UKismetMaterialLibrary.__CreateDynamicMaterialInstance_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, OptionalName, CreationFlags));
		}

		// Token: 0x0600A645 RID: 42565 RVA: 0x000ECE50 File Offset: 0x000EB050
		public static bool CheckMaterialUsage(UMaterialInstance InMaterial, EMaterialUsage InUsage)
		{
			return UKismetMaterialLibrary.__CheckMaterialUsage_Internal((InMaterial != null) ? InMaterial.NativePtr : IntPtr.Zero, InUsage);
		}

		// Token: 0x0600A646 RID: 42566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorParameterValue_Internal(IntPtr WorldContextObject, IntPtr Collection, FName ParameterName, in FLinearColor ParameterValue);

		// Token: 0x0600A647 RID: 42567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScalarParameterValue_Internal(IntPtr WorldContextObject, IntPtr Collection, FName ParameterName, float ParameterValue);

		// Token: 0x0600A648 RID: 42568
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMPCVectorParameterValue_Internal(IntPtr Collection, FName ParameterName, in FLinearColor ParameterValue);

		// Token: 0x0600A649 RID: 42569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetVectorParameterValue_Internal(IntPtr WorldContextObject, IntPtr Collection, FName ParameterName);

		// Token: 0x0600A64A RID: 42570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetScalarParameterValue_Internal(IntPtr WorldContextObject, IntPtr Collection, FName ParameterName);

		// Token: 0x0600A64B RID: 42571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetMPCVectorParameterValue_Internal(IntPtr Collection, FName ParameterName);

		// Token: 0x0600A64C RID: 42572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateDynamicMaterialInstance_Internal(IntPtr WorldContextObject, IntPtr Parent, FName OptionalName, EMIDCreationFlags CreationFlags);

		// Token: 0x0600A64D RID: 42573
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckMaterialUsage_Internal(IntPtr InMaterial, TEnumAsByte<EMaterialUsage> InUsage);

		// Token: 0x0600A64E RID: 42574 RVA: 0x000ECE6D File Offset: 0x000EB06D
		static UKismetMaterialLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetMaterialLibrary");
		}

		// Token: 0x0600A64F RID: 42575 RVA: 0x000ECE7B File Offset: 0x000EB07B
		protected UKismetMaterialLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005B33 RID: 23347
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KismetMaterialLibrary";

		// Token: 0x04005B34 RID: 23348
		private static IntPtr _ClassPtr;

		// Token: 0x04005B35 RID: 23349
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
