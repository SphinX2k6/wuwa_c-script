using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005D2 RID: 1490
	[UnrealObjectPath("/Script/KuroUtility.KuroCycleCounterLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroCycleCounterLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008418 RID: 33816 RVA: 0x000C42D8 File Offset: 0x000C24D8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCycleCounterLibrary._ClassPtr;
		}

		// Token: 0x06008419 RID: 33817 RVA: 0x000C42E4 File Offset: 0x000C24E4
		public UKuroCycleCounterLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroCycleCounterLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600841A RID: 33818 RVA: 0x000C430C File Offset: 0x000C250C
		[NullableContext(1)]
		public UKuroCycleCounterLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCycleCounterLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600841B RID: 33819
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopCycleCounter();

		// Token: 0x0600841C RID: 33820
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StartCycleCounterByName(in FName StatName);

		// Token: 0x0600841D RID: 33821
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StartCycleCounter(int StatIndex);

		// Token: 0x0600841E RID: 33822
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void InitializeEnvironment();

		// Token: 0x0600841F RID: 33823
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyEnvironment();

		// Token: 0x06008420 RID: 33824
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int CreateCycleCounter(in FName StatName);

		// Token: 0x06008421 RID: 33825 RVA: 0x000C433F File Offset: 0x000C253F
		static UKuroCycleCounterLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroCycleCounterLibrary");
		}

		// Token: 0x06008422 RID: 33826 RVA: 0x000C434D File Offset: 0x000C254D
		protected UKuroCycleCounterLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040039C2 RID: 14786
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroCycleCounterLibrary";

		// Token: 0x040039C3 RID: 14787
		private static IntPtr _ClassPtr;

		// Token: 0x040039C4 RID: 14788
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
