using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EC6 RID: 7878
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroPerfSightHelperLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPerfSightHelperLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DE32 RID: 122418 RVA: 0x002C35F9 File Offset: 0x002C17F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPerfSightHelperLibrary._ClassPtr;
		}

		// Token: 0x0601DE33 RID: 122419 RVA: 0x002C3608 File Offset: 0x002C1808
		public UKuroPerfSightHelperLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroPerfSightHelperLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DE34 RID: 122420 RVA: 0x002C3630 File Offset: 0x002C1830
		public UKuroPerfSightHelperLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPerfSightHelperLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DE35 RID: 122421
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnRegisterTickGroupEvent();

		// Token: 0x0601DE36 RID: 122422
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnRegisterOnFrameBegin();

		// Token: 0x0601DE37 RID: 122423
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetStrategyById(int StrategyId, int StrategyValue);

		// Token: 0x0601DE38 RID: 122424
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetFlameGraphStrMapSize(int InSize);

		// Token: 0x0601DE39 RID: 122425
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetFlameGraphQueueSize(int Length);

		// Token: 0x0601DE3A RID: 122426
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetFlameGraphDropThresholds(int Threshold);

		// Token: 0x0601DE3B RID: 122427 RVA: 0x002C3664 File Offset: 0x002C1864
		public unsafe static void SafePushCall(string CallGraphName)
		{
			FString fstring = FString.AllocTemp(CallGraphName);
			UKuroPerfSightHelperLibrary.__SafePushCall_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DE3C RID: 122428 RVA: 0x002C3688 File Offset: 0x002C1888
		public unsafe static void SafePopCall(string CallGraphName)
		{
			FString fstring = FString.AllocTemp(CallGraphName);
			UKuroPerfSightHelperLibrary.__SafePopCall_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DE3D RID: 122429
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RegisterTickGroupEvent();

		// Token: 0x0601DE3E RID: 122430 RVA: 0x002C36AC File Offset: 0x002C18AC
		public unsafe static void RegisterOnFrameBegin(string CallGraphName)
		{
			FString fstring = FString.AllocTemp(CallGraphName);
			UKuroPerfSightHelperLibrary.__RegisterOnFrameBegin_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DE3F RID: 122431 RVA: 0x002C36D0 File Offset: 0x002C18D0
		public unsafe static void PostValueString(string Category, string Key, string Value)
		{
			FString fstring = FString.AllocTemp(Category);
			FString fstring2 = FString.AllocTemp(Key);
			FString fstring3 = FString.AllocTemp(Value);
			UKuroPerfSightHelperLibrary.__PostValueString_Internal(fstring, fstring2, fstring3);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
		}

		// Token: 0x0601DE40 RID: 122432 RVA: 0x002C3718 File Offset: 0x002C1918
		public unsafe static void PostValueInteger3(string Category, string Key, int ValueA, int ValueB, int ValueC)
		{
			FString fstring = FString.AllocTemp(Category);
			FString fstring2 = FString.AllocTemp(Key);
			UKuroPerfSightHelperLibrary.__PostValueInteger3_Internal(fstring, fstring2, ValueA, ValueB, ValueC);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0601DE41 RID: 122433 RVA: 0x002C3754 File Offset: 0x002C1954
		public unsafe static void PostValueInteger2(string Category, string Key, int ValueA, int ValueB)
		{
			FString fstring = FString.AllocTemp(Category);
			FString fstring2 = FString.AllocTemp(Key);
			UKuroPerfSightHelperLibrary.__PostValueInteger2_Internal(fstring, fstring2, ValueA, ValueB);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0601DE42 RID: 122434 RVA: 0x002C378C File Offset: 0x002C198C
		public unsafe static void PostValueInteger1(string Category, string Key, int ValueA)
		{
			FString fstring = FString.AllocTemp(Category);
			FString fstring2 = FString.AllocTemp(Key);
			UKuroPerfSightHelperLibrary.__PostValueInteger1_Internal(fstring, fstring2, ValueA);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0601DE43 RID: 122435 RVA: 0x002C37C4 File Offset: 0x002C19C4
		public unsafe static void PostValueFloat3(string Category, string Key, float ValueA, float ValueB, float ValueC)
		{
			FString fstring = FString.AllocTemp(Category);
			FString fstring2 = FString.AllocTemp(Key);
			UKuroPerfSightHelperLibrary.__PostValueFloat3_Internal(fstring, fstring2, ValueA, ValueB, ValueC);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0601DE44 RID: 122436 RVA: 0x002C3800 File Offset: 0x002C1A00
		public unsafe static void PostValueFloat2(string Category, string Key, float ValueA, float ValueB)
		{
			FString fstring = FString.AllocTemp(Category);
			FString fstring2 = FString.AllocTemp(Key);
			UKuroPerfSightHelperLibrary.__PostValueFloat2_Internal(fstring, fstring2, ValueA, ValueB);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0601DE45 RID: 122437 RVA: 0x002C3838 File Offset: 0x002C1A38
		public unsafe static void PostValueFloat1(string Category, string Key, float ValueA)
		{
			FString fstring = FString.AllocTemp(Category);
			FString fstring2 = FString.AllocTemp(Key);
			UKuroPerfSightHelperLibrary.__PostValueFloat1_Internal(fstring, fstring2, ValueA);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0601DE46 RID: 122438
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void PostFrame(float DeltaTime);

		// Token: 0x0601DE47 RID: 122439
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MarkStartUpFinish();

		// Token: 0x0601DE48 RID: 122440
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsOnFrameBeginRegistered();

		// Token: 0x0601DE49 RID: 122441
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsBeginCallGraphCalled();

		// Token: 0x0601DE4A RID: 122442 RVA: 0x002C3870 File Offset: 0x002C1A70
		public unsafe static void EndExtTag(string TagName)
		{
			FString fstring = FString.AllocTemp(TagName);
			UKuroPerfSightHelperLibrary.__EndExtTag_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DE4B RID: 122443 RVA: 0x002C3894 File Offset: 0x002C1A94
		public unsafe static void EndCallGraph(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			UKuroPerfSightHelperLibrary.__EndCallGraph_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DE4C RID: 122444
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableTimedReport();

		// Token: 0x0601DE4D RID: 122445 RVA: 0x002C38B8 File Offset: 0x002C1AB8
		public unsafe static void BeginExtTag(string TagName)
		{
			FString fstring = FString.AllocTemp(TagName);
			UKuroPerfSightHelperLibrary.__BeginExtTag_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DE4E RID: 122446 RVA: 0x002C38DC File Offset: 0x002C1ADC
		public unsafe static void BeginCallGraph(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			UKuroPerfSightHelperLibrary.__BeginCallGraph_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DE4F RID: 122447
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SafePushCall_Internal(in FString CallGraphName);

		// Token: 0x0601DE50 RID: 122448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SafePopCall_Internal(in FString CallGraphName);

		// Token: 0x0601DE51 RID: 122449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterOnFrameBegin_Internal(in FString CallGraphName);

		// Token: 0x0601DE52 RID: 122450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueString_Internal(in FString Category, in FString Key, in FString Value);

		// Token: 0x0601DE53 RID: 122451
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueInteger3_Internal(in FString Category, in FString Key, int ValueA, int ValueB, int ValueC);

		// Token: 0x0601DE54 RID: 122452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueInteger2_Internal(in FString Category, in FString Key, int ValueA, int ValueB);

		// Token: 0x0601DE55 RID: 122453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueInteger1_Internal(in FString Category, in FString Key, int ValueA);

		// Token: 0x0601DE56 RID: 122454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueFloat3_Internal(in FString Category, in FString Key, float ValueA, float ValueB, float ValueC);

		// Token: 0x0601DE57 RID: 122455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueFloat2_Internal(in FString Category, in FString Key, float ValueA, float ValueB);

		// Token: 0x0601DE58 RID: 122456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueFloat1_Internal(in FString Category, in FString Key, float ValueA);

		// Token: 0x0601DE59 RID: 122457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndExtTag_Internal(in FString TagName);

		// Token: 0x0601DE5A RID: 122458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndCallGraph_Internal(in FString Name);

		// Token: 0x0601DE5B RID: 122459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeginExtTag_Internal(in FString TagName);

		// Token: 0x0601DE5C RID: 122460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeginCallGraph_Internal(in FString Name);

		// Token: 0x0601DE5D RID: 122461 RVA: 0x002C3900 File Offset: 0x002C1B00
		static UKuroPerfSightHelperLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroPerfSightHelperLibrary");
		}

		// Token: 0x0601DE5E RID: 122462 RVA: 0x002C390E File Offset: 0x002C1B0E
		protected UKuroPerfSightHelperLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010305 RID: 66309
		public new const string __ObjectPath = "/Script/KuroUtility.KuroPerfSightHelperLibrary";

		// Token: 0x04010306 RID: 66310
		private static IntPtr _ClassPtr;

		// Token: 0x04010307 RID: 66311
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
