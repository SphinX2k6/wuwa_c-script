using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ECA RID: 7882
	[UnrealObjectPath("/Script/KuroUtility.KuroScreenLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroScreenLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DE7B RID: 122491 RVA: 0x002C3B9A File Offset: 0x002C1D9A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroScreenLibrary._ClassPtr;
		}

		// Token: 0x0601DE7C RID: 122492 RVA: 0x002C3BA8 File Offset: 0x002C1DA8
		public UKuroScreenLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroScreenLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DE7D RID: 122493 RVA: 0x002C3BD0 File Offset: 0x002C1DD0
		[NullableContext(1)]
		public UKuroScreenLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroScreenLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DE7E RID: 122494
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetScreenScaledDensity();

		// Token: 0x0601DE7F RID: 122495
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetScreenLogicalDensity();

		// Token: 0x0601DE80 RID: 122496
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetScreenDensityDPI();

		// Token: 0x0601DE81 RID: 122497
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetPhysicalScreenResolutionV2();

		// Token: 0x0601DE82 RID: 122498
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetPhysicalScreenResolution();

		// Token: 0x0601DE83 RID: 122499
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetPhysicalScreenDensityDPI();

		// Token: 0x0601DE84 RID: 122500
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetDisplayScreenResolution();

		// Token: 0x0601DE85 RID: 122501
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double ComputePhysicalScreenDensity();

		// Token: 0x0601DE86 RID: 122502 RVA: 0x002C3C03 File Offset: 0x002C1E03
		static UKuroScreenLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroScreenLibrary");
		}

		// Token: 0x0601DE87 RID: 122503 RVA: 0x002C3C11 File Offset: 0x002C1E11
		protected UKuroScreenLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010312 RID: 66322
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroScreenLibrary";

		// Token: 0x04010313 RID: 66323
		private static IntPtr _ClassPtr;

		// Token: 0x04010314 RID: 66324
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
