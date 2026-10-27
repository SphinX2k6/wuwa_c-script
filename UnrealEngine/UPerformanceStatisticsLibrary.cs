using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001928 RID: 6440
	[UnrealObjectPath("/Script/KuroGameplay.PerformanceStatisticsLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UPerformanceStatisticsLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017E11 RID: 97809 RVA: 0x0022FF0F File Offset: 0x0022E10F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPerformanceStatisticsLibrary._ClassPtr;
		}

		// Token: 0x06017E12 RID: 97810 RVA: 0x0022FF1C File Offset: 0x0022E11C
		public UPerformanceStatisticsLibrary() : this(BuiltinUtils.AllocNativeUObject(UPerformanceStatisticsLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017E13 RID: 97811 RVA: 0x0022FF44 File Offset: 0x0022E144
		[NullableContext(1)]
		public UPerformanceStatisticsLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPerformanceStatisticsLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017E14 RID: 97812 RVA: 0x0022FF77 File Offset: 0x0022E177
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void StatisticsFromRawDataFiles()
		{
			UnrealReflectionUtils.CallUFunction(UPerformanceStatisticsLibrary._ClassDefaultObjectPtr, UPerformanceStatisticsLibrary.__StatisticsFromRawDataFiles_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06017E15 RID: 97813 RVA: 0x0022FF8C File Offset: 0x0022E18C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ReadSectionFromFile(ref string FilePath)
		{
			UPerformanceStatisticsLibrary.__ReadSectionFromFile_FunctionParams* ptr = stackalloc UPerformanceStatisticsLibrary.__ReadSectionFromFile_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UPerformanceStatisticsLibrary.__ReadSectionFromFile_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPerformanceStatisticsLibrary.__ReadSectionFromFile_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->FilePath), FilePath);
			UnrealReflectionUtils.CallUFunction(UPerformanceStatisticsLibrary._ClassDefaultObjectPtr, UPerformanceStatisticsLibrary.__ReadSectionFromFile_NativeFunctionPtr, (void*)ptr, 0);
			FilePath = FString.ToString((void*)(&ptr->FilePath));
			UnrealReflectionUtils.DestroyStruct(UPerformanceStatisticsLibrary.__ReadSectionFromFile_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06017E16 RID: 97814 RVA: 0x0022FFF8 File Offset: 0x0022E1F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void ReadAllSectionsFromDirectory()
		{
			UnrealReflectionUtils.CallUFunction(UPerformanceStatisticsLibrary._ClassDefaultObjectPtr, UPerformanceStatisticsLibrary.__ReadAllSectionsFromDirectory_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06017E17 RID: 97815 RVA: 0x0023000C File Offset: 0x0022E20C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void Export()
		{
			UnrealReflectionUtils.CallUFunction(UPerformanceStatisticsLibrary._ClassDefaultObjectPtr, UPerformanceStatisticsLibrary.__Export_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06017E18 RID: 97816 RVA: 0x00230020 File Offset: 0x0022E220
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void Clear()
		{
			UnrealReflectionUtils.CallUFunction(UPerformanceStatisticsLibrary._ClassDefaultObjectPtr, UPerformanceStatisticsLibrary.__Clear_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06017E19 RID: 97817 RVA: 0x00230034 File Offset: 0x0022E234
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void AddStatistics(FName SectionName, int FrameCount, string Tag, int MeasureMode, float Time, string UserDefineMessage = "")
		{
			UPerformanceStatisticsLibrary.__AddStatistics_FunctionParams* ptr = stackalloc UPerformanceStatisticsLibrary.__AddStatistics_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UPerformanceStatisticsLibrary.__AddStatistics_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPerformanceStatisticsLibrary.__AddStatistics_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SectionName = SectionName;
			ptr->FrameCount = FrameCount;
			FString.CopyFrom((void*)(&ptr->Tag), Tag);
			ptr->MeasureMode = MeasureMode;
			ptr->Time = Time;
			FString.CopyFrom((void*)(&ptr->UserDefineMessage), UserDefineMessage);
			UnrealReflectionUtils.CallUFunction(UPerformanceStatisticsLibrary._ClassDefaultObjectPtr, UPerformanceStatisticsLibrary.__AddStatistics_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UPerformanceStatisticsLibrary.__AddStatistics_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06017E1A RID: 97818 RVA: 0x002300BC File Offset: 0x0022E2BC
		static UPerformanceStatisticsLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.PerformanceStatisticsLibrary");
		}

		// Token: 0x06017E1B RID: 97819 RVA: 0x002300CA File Offset: 0x0022E2CA
		protected UPerformanceStatisticsLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CEED RID: 52973
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.PerformanceStatisticsLibrary";

		// Token: 0x0400CEEE RID: 52974
		private static IntPtr _ClassPtr;

		// Token: 0x0400CEEF RID: 52975
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CEF0 RID: 52976
		private static IntPtr __StatisticsFromRawDataFiles_NativeFunctionPtr;

		// Token: 0x0400CEF1 RID: 52977
		private static IntPtr __ReadSectionFromFile_NativeFunctionPtr;

		// Token: 0x0400CEF2 RID: 52978
		private static IntPtr __ReadAllSectionsFromDirectory_NativeFunctionPtr;

		// Token: 0x0400CEF3 RID: 52979
		private static IntPtr __Export_NativeFunctionPtr;

		// Token: 0x0400CEF4 RID: 52980
		private static IntPtr __Clear_NativeFunctionPtr;

		// Token: 0x0400CEF5 RID: 52981
		private static IntPtr __AddStatistics_NativeFunctionPtr;

		// Token: 0x02002FF7 RID: 12279
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReadSectionFromFile_FunctionParams
		{
			// Token: 0x04016BFC RID: 93180
			[FieldOffset(0)]
			public FString FilePath;
		}

		// Token: 0x02002FF8 RID: 12280
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __AddStatistics_FunctionParams
		{
			// Token: 0x04016BFD RID: 93181
			[FieldOffset(0)]
			public FName SectionName;

			// Token: 0x04016BFE RID: 93182
			[FieldOffset(12)]
			public int FrameCount;

			// Token: 0x04016BFF RID: 93183
			[FieldOffset(16)]
			public FString Tag;

			// Token: 0x04016C00 RID: 93184
			[FieldOffset(32)]
			public int MeasureMode;

			// Token: 0x04016C01 RID: 93185
			[FieldOffset(36)]
			public float Time;

			// Token: 0x04016C02 RID: 93186
			[FieldOffset(40)]
			public FString UserDefineMessage;
		}
	}
}
