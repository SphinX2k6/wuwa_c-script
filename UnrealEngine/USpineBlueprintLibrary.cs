using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C2C RID: 7212
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.SpineBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class USpineBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601BEBA RID: 114362 RVA: 0x002915A4 File Offset: 0x0028F7A4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpineBlueprintLibrary._ClassPtr;
		}

		// Token: 0x0601BEBB RID: 114363 RVA: 0x002915B0 File Offset: 0x0028F7B0
		public USpineBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(USpineBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601BEBC RID: 114364 RVA: 0x002915D8 File Offset: 0x0028F7D8
		[NullableContext(1)]
		public USpineBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpineBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601BEBD RID: 114365 RVA: 0x0029160B File Offset: 0x0028F80B
		[NullableContext(2)]
		public static void SetSpineBaseColorTint(USpineSkeletonRendererComponent SpineComp, FLinearColor TintColor, float TintBlendWeight)
		{
			USpineBlueprintLibrary.__SetSpineBaseColorTint_Internal((SpineComp != null) ? SpineComp.NativePtr : IntPtr.Zero, TintColor, TintBlendWeight);
		}

		// Token: 0x0601BEBE RID: 114366
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpineBaseColorTint_Internal(IntPtr SpineComp, FLinearColor TintColor, float TintBlendWeight);

		// Token: 0x0601BEBF RID: 114367 RVA: 0x00291624 File Offset: 0x0028F824
		static USpineBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.SpineBlueprintLibrary");
		}

		// Token: 0x0601BEC0 RID: 114368 RVA: 0x00291632 File Offset: 0x0028F832
		protected USpineBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EFE7 RID: 61415
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.SpineBlueprintLibrary";

		// Token: 0x0400EFE8 RID: 61416
		private static IntPtr _ClassPtr;

		// Token: 0x0400EFE9 RID: 61417
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
