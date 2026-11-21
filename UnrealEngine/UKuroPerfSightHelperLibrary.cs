using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005E1 RID: 1505
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroPerfSightHelperLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPerfSightHelperLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060084EB RID: 34027 RVA: 0x000C5455 File Offset: 0x000C3655
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPerfSightHelperLibrary._ClassPtr;
		}

		// Token: 0x060084EC RID: 34028 RVA: 0x000C5464 File Offset: 0x000C3664
		public UKuroPerfSightHelperLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroPerfSightHelperLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060084ED RID: 34029 RVA: 0x000C548C File Offset: 0x000C368C
		public UKuroPerfSightHelperLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPerfSightHelperLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060084EE RID: 34030
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnRegisterTickGroupEvent();

		// Token: 0x060084EF RID: 34031
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnRegisterOnFrameBegin();

		// Token: 0x060084F0 RID: 34032
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetStrategyById(int StrategyId, int StrategyValue);

		// Token: 0x060084F1 RID: 34033
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetFlameGraphStrMapSize(int InSize);

		// Token: 0x060084F2 RID: 34034
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetFlameGraphQueueSize(int Length);

		// Token: 0x060084F3 RID: 34035
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetFlameGraphDropThresholds(int Threshold);

		// Token: 0x060084F4 RID: 34036 RVA: 0x000C54C0 File Offset: 0x000C36C0
		public unsafe static void SafePushCall(string CallGraphName)
		{
			FString fstring = FString.AllocTemp(CallGraphName);
			UKuroPerfSightHelperLibrary.__SafePushCall_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060084F5 RID: 34037 RVA: 0x000C54E4 File Offset: 0x000C36E4
		public unsafe static void SafePopCall(string CallGraphName)
		{
			FString fstring = FString.AllocTemp(CallGraphName);
			UKuroPerfSightHelperLibrary.__SafePopCall_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060084F6 RID: 34038
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RegisterTickGroupEvent();

		// Token: 0x060084F7 RID: 34039 RVA: 0x000C5508 File Offset: 0x000C3708
		public unsafe static void RegisterOnFrameBegin(string CallGraphName)
		{
			FString fstring = FString.AllocTemp(CallGraphName);
			UKuroPerfSightHelperLibrary.__RegisterOnFrameBegin_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060084F8 RID: 34040 RVA: 0x000C552C File Offset: 0x000C372C
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

		// Token: 0x060084F9 RID: 34041 RVA: 0x000C5574 File Offset: 0x000C3774
		public unsafe static void PostValueInteger3(string Category, string Key, int ValueA, int ValueB, int ValueC)
		{
			FString fstring = FString.AllocTemp(Category);
			FString fstring2 = FString.AllocTemp(Key);
			UKuroPerfSightHelperLibrary.__PostValueInteger3_Internal(fstring, fstring2, ValueA, ValueB, ValueC);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x060084FA RID: 34042 RVA: 0x000C55B0 File Offset: 0x000C37B0
		public unsafe static void PostValueInteger2(string Category, string Key, int ValueA, int ValueB)
		{
			FString fstring = FString.AllocTemp(Category);
			FString fstring2 = FString.AllocTemp(Key);
			UKuroPerfSightHelperLibrary.__PostValueInteger2_Internal(fstring, fstring2, ValueA, ValueB);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x060084FB RID: 34043 RVA: 0x000C55E8 File Offset: 0x000C37E8
		public unsafe static void PostValueInteger1(string Category, string Key, int ValueA)
		{
			FString fstring = FString.AllocTemp(Category);
			FString fstring2 = FString.AllocTemp(Key);
			UKuroPerfSightHelperLibrary.__PostValueInteger1_Internal(fstring, fstring2, ValueA);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x060084FC RID: 34044 RVA: 0x000C5620 File Offset: 0x000C3820
		public unsafe static void PostValueFloat3(string Category, string Key, float ValueA, float ValueB, float ValueC)
		{
			FString fstring = FString.AllocTemp(Category);
			FString fstring2 = FString.AllocTemp(Key);
			UKuroPerfSightHelperLibrary.__PostValueFloat3_Internal(fstring, fstring2, ValueA, ValueB, ValueC);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x060084FD RID: 34045 RVA: 0x000C565C File Offset: 0x000C385C
		public unsafe static void PostValueFloat2(string Category, string Key, float ValueA, float ValueB)
		{
			FString fstring = FString.AllocTemp(Category);
			FString fstring2 = FString.AllocTemp(Key);
			UKuroPerfSightHelperLibrary.__PostValueFloat2_Internal(fstring, fstring2, ValueA, ValueB);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x060084FE RID: 34046 RVA: 0x000C5694 File Offset: 0x000C3894
		public unsafe static void PostValueFloat1(string Category, string Key, float ValueA)
		{
			FString fstring = FString.AllocTemp(Category);
			FString fstring2 = FString.AllocTemp(Key);
			UKuroPerfSightHelperLibrary.__PostValueFloat1_Internal(fstring, fstring2, ValueA);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x060084FF RID: 34047
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void PostFrame(float DeltaTime);

		// Token: 0x06008500 RID: 34048
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MarkStartUpFinish();

		// Token: 0x06008501 RID: 34049
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsOnFrameBeginRegistered();

		// Token: 0x06008502 RID: 34050
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsBeginCallGraphCalled();

		// Token: 0x06008503 RID: 34051 RVA: 0x000C56CC File Offset: 0x000C38CC
		public unsafe static void EndExtTag(string TagName)
		{
			FString fstring = FString.AllocTemp(TagName);
			UKuroPerfSightHelperLibrary.__EndExtTag_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06008504 RID: 34052 RVA: 0x000C56F0 File Offset: 0x000C38F0
		public unsafe static void EndCallGraph(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			UKuroPerfSightHelperLibrary.__EndCallGraph_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06008505 RID: 34053
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableTimedReport();

		// Token: 0x06008506 RID: 34054 RVA: 0x000C5714 File Offset: 0x000C3914
		public unsafe static void BeginExtTag(string TagName)
		{
			FString fstring = FString.AllocTemp(TagName);
			UKuroPerfSightHelperLibrary.__BeginExtTag_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06008507 RID: 34055 RVA: 0x000C5738 File Offset: 0x000C3938
		public unsafe static void BeginCallGraph(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			UKuroPerfSightHelperLibrary.__BeginCallGraph_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06008508 RID: 34056
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SafePushCall_Internal(in FString CallGraphName);

		// Token: 0x06008509 RID: 34057
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SafePopCall_Internal(in FString CallGraphName);

		// Token: 0x0600850A RID: 34058
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterOnFrameBegin_Internal(in FString CallGraphName);

		// Token: 0x0600850B RID: 34059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueString_Internal(in FString Category, in FString Key, in FString Value);

		// Token: 0x0600850C RID: 34060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueInteger3_Internal(in FString Category, in FString Key, int ValueA, int ValueB, int ValueC);

		// Token: 0x0600850D RID: 34061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueInteger2_Internal(in FString Category, in FString Key, int ValueA, int ValueB);

		// Token: 0x0600850E RID: 34062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueInteger1_Internal(in FString Category, in FString Key, int ValueA);

		// Token: 0x0600850F RID: 34063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueFloat3_Internal(in FString Category, in FString Key, float ValueA, float ValueB, float ValueC);

		// Token: 0x06008510 RID: 34064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueFloat2_Internal(in FString Category, in FString Key, float ValueA, float ValueB);

		// Token: 0x06008511 RID: 34065
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueFloat1_Internal(in FString Category, in FString Key, float ValueA);

		// Token: 0x06008512 RID: 34066
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndExtTag_Internal(in FString TagName);

		// Token: 0x06008513 RID: 34067
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndCallGraph_Internal(in FString Name);

		// Token: 0x06008514 RID: 34068
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeginExtTag_Internal(in FString TagName);

		// Token: 0x06008515 RID: 34069
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeginCallGraph_Internal(in FString Name);

		// Token: 0x06008516 RID: 34070 RVA: 0x000C575C File Offset: 0x000C395C
		static UKuroPerfSightHelperLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroPerfSightHelperLibrary");
		}

		// Token: 0x06008517 RID: 34071 RVA: 0x000C576A File Offset: 0x000C396A
		protected UKuroPerfSightHelperLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A13 RID: 14867
		public new const string __ObjectPath = "/Script/KuroUtility.KuroPerfSightHelperLibrary";

		// Token: 0x04003A14 RID: 14868
		private static IntPtr _ClassPtr;

		// Token: 0x04003A15 RID: 14869
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
