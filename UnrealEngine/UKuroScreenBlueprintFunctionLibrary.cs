using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EC9 RID: 7881
	[UnrealObjectPath("/Script/KuroUtility.KuroScreenBlueprintFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroScreenBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DE6E RID: 122478 RVA: 0x002C3B1A File Offset: 0x002C1D1A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroScreenBlueprintFunctionLibrary._ClassPtr;
		}

		// Token: 0x0601DE6F RID: 122479 RVA: 0x002C3B28 File Offset: 0x002C1D28
		public UKuroScreenBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroScreenBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DE70 RID: 122480 RVA: 0x002C3B50 File Offset: 0x002C1D50
		[NullableContext(1)]
		public UKuroScreenBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroScreenBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DE71 RID: 122481
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetScreenScaledDensity();

		// Token: 0x0601DE72 RID: 122482
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetScreenLogicalDensity();

		// Token: 0x0601DE73 RID: 122483
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetScreenDensityDPI();

		// Token: 0x0601DE74 RID: 122484
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetPhysicalScreenResolutionV2();

		// Token: 0x0601DE75 RID: 122485
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetPhysicalScreenResolution();

		// Token: 0x0601DE76 RID: 122486
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetPhysicalScreenDensityDPI();

		// Token: 0x0601DE77 RID: 122487
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetDisplayScreenResolution();

		// Token: 0x0601DE78 RID: 122488
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double ComputePhysicalScreenDensity();

		// Token: 0x0601DE79 RID: 122489 RVA: 0x002C3B83 File Offset: 0x002C1D83
		static UKuroScreenBlueprintFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroScreenBlueprintFunctionLibrary");
		}

		// Token: 0x0601DE7A RID: 122490 RVA: 0x002C3B91 File Offset: 0x002C1D91
		protected UKuroScreenBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401030F RID: 66319
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroScreenBlueprintFunctionLibrary";

		// Token: 0x04010310 RID: 66320
		private static IntPtr _ClassPtr;

		// Token: 0x04010311 RID: 66321
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
