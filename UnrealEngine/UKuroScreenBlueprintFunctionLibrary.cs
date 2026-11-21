using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005E2 RID: 1506
	[UnrealObjectPath("/Script/KuroUtility.KuroScreenBlueprintFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroScreenBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008518 RID: 34072 RVA: 0x000C5773 File Offset: 0x000C3973
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroScreenBlueprintFunctionLibrary._ClassPtr;
		}

		// Token: 0x06008519 RID: 34073 RVA: 0x000C5780 File Offset: 0x000C3980
		public UKuroScreenBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroScreenBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600851A RID: 34074 RVA: 0x000C57A8 File Offset: 0x000C39A8
		[NullableContext(1)]
		public UKuroScreenBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroScreenBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600851B RID: 34075
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetScreenScaledDensity();

		// Token: 0x0600851C RID: 34076
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetScreenLogicalDensity();

		// Token: 0x0600851D RID: 34077
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetScreenDensityDPI();

		// Token: 0x0600851E RID: 34078
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetPhysicalScreenResolutionV2();

		// Token: 0x0600851F RID: 34079
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetPhysicalScreenResolution();

		// Token: 0x06008520 RID: 34080
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetPhysicalScreenDensityDPI();

		// Token: 0x06008521 RID: 34081
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetDisplayScreenResolution();

		// Token: 0x06008522 RID: 34082
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double ComputePhysicalScreenDensity();

		// Token: 0x06008523 RID: 34083 RVA: 0x000C57DB File Offset: 0x000C39DB
		static UKuroScreenBlueprintFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroScreenBlueprintFunctionLibrary");
		}

		// Token: 0x06008524 RID: 34084 RVA: 0x000C57E9 File Offset: 0x000C39E9
		protected UKuroScreenBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A16 RID: 14870
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroScreenBlueprintFunctionLibrary";

		// Token: 0x04003A17 RID: 14871
		private static IntPtr _ClassPtr;

		// Token: 0x04003A18 RID: 14872
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
