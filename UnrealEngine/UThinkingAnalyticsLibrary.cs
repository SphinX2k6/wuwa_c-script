using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002900 RID: 10496
	[UnrealObjectPath("/Script/TASdkPlugin.ThinkingAnalyticsLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UThinkingAnalyticsLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026EF3 RID: 159475 RVA: 0x003B62AA File Offset: 0x003B44AA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UThinkingAnalyticsLibrary._ClassPtr;
		}

		// Token: 0x06026EF4 RID: 159476 RVA: 0x003B62B8 File Offset: 0x003B44B8
		public UThinkingAnalyticsLibrary() : this(BuiltinUtils.AllocNativeUObject(UThinkingAnalyticsLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026EF5 RID: 159477 RVA: 0x003B62E0 File Offset: 0x003B44E0
		[NullableContext(1)]
		public UThinkingAnalyticsLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UThinkingAnalyticsLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026EF6 RID: 159478 RVA: 0x003B6314 File Offset: 0x003B4514
		[NullableContext(1)]
		public unsafe static bool Track(string EventName, string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			FString fstring2 = FString.AllocTemp(Properties);
			bool result = UThinkingAnalyticsLibrary.__Track_Internal(fstring, fstring2, Index);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06026EF7 RID: 159479
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Flush(int Index = 0);

		// Token: 0x06026EF8 RID: 159480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Track_Internal(in FString EventName, in FString Properties, int Index);

		// Token: 0x06026EF9 RID: 159481 RVA: 0x003B634B File Offset: 0x003B454B
		static UThinkingAnalyticsLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TASdkPlugin.ThinkingAnalyticsLibrary");
		}

		// Token: 0x06026EFA RID: 159482 RVA: 0x003B6359 File Offset: 0x003B4559
		protected UThinkingAnalyticsLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040155E5 RID: 87525
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TASdkPlugin.ThinkingAnalyticsLibrary";

		// Token: 0x040155E6 RID: 87526
		private static IntPtr _ClassPtr;

		// Token: 0x040155E7 RID: 87527
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
