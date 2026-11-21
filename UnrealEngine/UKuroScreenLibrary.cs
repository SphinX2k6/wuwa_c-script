using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005E3 RID: 1507
	[UnrealObjectPath("/Script/KuroUtility.KuroScreenLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroScreenLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008525 RID: 34085 RVA: 0x000C57F2 File Offset: 0x000C39F2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroScreenLibrary._ClassPtr;
		}

		// Token: 0x06008526 RID: 34086 RVA: 0x000C5800 File Offset: 0x000C3A00
		public UKuroScreenLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroScreenLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008527 RID: 34087 RVA: 0x000C5828 File Offset: 0x000C3A28
		[NullableContext(1)]
		public UKuroScreenLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroScreenLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008528 RID: 34088
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetScreenScaledDensity();

		// Token: 0x06008529 RID: 34089
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetScreenLogicalDensity();

		// Token: 0x0600852A RID: 34090
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetScreenDensityDPI();

		// Token: 0x0600852B RID: 34091
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetPhysicalScreenResolutionV2();

		// Token: 0x0600852C RID: 34092
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetPhysicalScreenResolution();

		// Token: 0x0600852D RID: 34093
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetPhysicalScreenDensityDPI();

		// Token: 0x0600852E RID: 34094
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetDisplayScreenResolution();

		// Token: 0x0600852F RID: 34095
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double ComputePhysicalScreenDensity();

		// Token: 0x06008530 RID: 34096 RVA: 0x000C585B File Offset: 0x000C3A5B
		static UKuroScreenLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroScreenLibrary");
		}

		// Token: 0x06008531 RID: 34097 RVA: 0x000C5869 File Offset: 0x000C3A69
		protected UKuroScreenLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A19 RID: 14873
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroScreenLibrary";

		// Token: 0x04003A1A RID: 14874
		private static IntPtr _ClassPtr;

		// Token: 0x04003A1B RID: 14875
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
