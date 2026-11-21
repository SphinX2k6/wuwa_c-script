using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002D6 RID: 726
	[UnrealObjectPath("/Script/KRDataAnalyticsPlugin.KuroAnalyticsForCSharpLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAnalyticsForCSharpLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004E9D RID: 20125 RVA: 0x0006DD56 File Offset: 0x0006BF56
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnalyticsForCSharpLibrary._ClassPtr;
		}

		// Token: 0x06004E9E RID: 20126 RVA: 0x0006DD64 File Offset: 0x0006BF64
		public UKuroAnalyticsForCSharpLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroAnalyticsForCSharpLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004E9F RID: 20127 RVA: 0x0006DD8C File Offset: 0x0006BF8C
		[NullableContext(1)]
		public UKuroAnalyticsForCSharpLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnalyticsForCSharpLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06004EA0 RID: 20128 RVA: 0x0006DDC0 File Offset: 0x0006BFC0
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

		// Token: 0x06004EA1 RID: 20129
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Flush(int Index = 0);

		// Token: 0x06004EA2 RID: 20130
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Track_Internal(in FString EventName, in FString Properties, int Index);

		// Token: 0x06004EA3 RID: 20131 RVA: 0x0006DDF7 File Offset: 0x0006BFF7
		static UKuroAnalyticsForCSharpLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KRDataAnalyticsPlugin.KuroAnalyticsForCSharpLibrary");
		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x0006DE05 File Offset: 0x0006C005
		protected UKuroAnalyticsForCSharpLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F6F RID: 8047
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KRDataAnalyticsPlugin.KuroAnalyticsForCSharpLibrary";

		// Token: 0x04001F70 RID: 8048
		private static IntPtr _ClassPtr;

		// Token: 0x04001F71 RID: 8049
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
