using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015E6 RID: 5606
	[UnrealObjectPath("/Script/KRDataAnalyticsPlugin.KuroAnalyticsForCSharpLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAnalyticsForCSharpLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601439C RID: 82844 RVA: 0x001DB322 File Offset: 0x001D9522
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnalyticsForCSharpLibrary._ClassPtr;
		}

		// Token: 0x0601439D RID: 82845 RVA: 0x001DB330 File Offset: 0x001D9530
		public UKuroAnalyticsForCSharpLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroAnalyticsForCSharpLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601439E RID: 82846 RVA: 0x001DB358 File Offset: 0x001D9558
		[NullableContext(1)]
		public UKuroAnalyticsForCSharpLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnalyticsForCSharpLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601439F RID: 82847 RVA: 0x001DB38C File Offset: 0x001D958C
		[NullableContext(1)]
		public unsafe static bool Track(string EventName, string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			FString fstring2 = FString.AllocTemp(Properties);
			bool result = UKuroAnalyticsForCSharpLibrary.__Track_Internal(fstring, fstring2, Index);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060143A0 RID: 82848
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Flush(int Index = 0);

		// Token: 0x060143A1 RID: 82849
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Track_Internal(in FString EventName, in FString Properties, int Index);

		// Token: 0x060143A2 RID: 82850 RVA: 0x001DB3C3 File Offset: 0x001D95C3
		static UKuroAnalyticsForCSharpLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KRDataAnalyticsPlugin.KuroAnalyticsForCSharpLibrary");
		}

		// Token: 0x060143A3 RID: 82851 RVA: 0x001DB3D1 File Offset: 0x001D95D1
		protected UKuroAnalyticsForCSharpLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AFDC RID: 45020
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KRDataAnalyticsPlugin.KuroAnalyticsForCSharpLibrary";

		// Token: 0x0400AFDD RID: 45021
		private static IntPtr _ClassPtr;

		// Token: 0x0400AFDE RID: 45022
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
