using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000416 RID: 1046
	[UnrealObjectPath("/Script/KuroGameplay.PerformanceStatisticsLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UPerformanceStatisticsLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006587 RID: 25991 RVA: 0x0009150F File Offset: 0x0008F70F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPerformanceStatisticsLibrary._ClassPtr;
		}

		// Token: 0x06006588 RID: 25992 RVA: 0x0009151C File Offset: 0x0008F71C
		public UPerformanceStatisticsLibrary() : this(BuiltinUtils.AllocNativeUObject(UPerformanceStatisticsLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006589 RID: 25993 RVA: 0x00091544 File Offset: 0x0008F744
		[NullableContext(1)]
		public UPerformanceStatisticsLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPerformanceStatisticsLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600658A RID: 25994 RVA: 0x00091577 File Offset: 0x0008F777
		[SkipLocalsInit]
		public static void StatisticsFromRawDataFiles()
		{
			UnrealReflectionUtils.CallUFunction(UPerformanceStatisticsLibrary._ClassDefaultObjectPtr, UPerformanceStatisticsLibrary.__StatisticsFromRawDataFiles_NativeFunctionPtr, null);
		}

		// Token: 0x0600658B RID: 25995 RVA: 0x0009158C File Offset: 0x0008F78C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void ReadSectionFromFile(ref string FilePath)
		{
			UPerformanceStatisticsLibrary.__ReadSectionFromFile_FunctionParams* ptr = stackalloc UPerformanceStatisticsLibrary.__ReadSectionFromFile_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UPerformanceStatisticsLibrary.__ReadSectionFromFile_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPerformanceStatisticsLibrary.__ReadSectionFromFile_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->FilePath), FilePath);
			UnrealReflectionUtils.CallUFunction(UPerformanceStatisticsLibrary._ClassDefaultObjectPtr, UPerformanceStatisticsLibrary.__ReadSectionFromFile_NativeFunctionPtr, (void*)ptr);
			FilePath = FString.ToString((void*)(&ptr->FilePath));
			UnrealReflectionUtils.DestroyStruct(UPerformanceStatisticsLibrary.__ReadSectionFromFile_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600658C RID: 25996 RVA: 0x000915F7 File Offset: 0x0008F7F7
		[SkipLocalsInit]
		public static void ReadAllSectionsFromDirectory()
		{
			UnrealReflectionUtils.CallUFunction(UPerformanceStatisticsLibrary._ClassDefaultObjectPtr, UPerformanceStatisticsLibrary.__ReadAllSectionsFromDirectory_NativeFunctionPtr, null);
		}

		// Token: 0x0600658D RID: 25997 RVA: 0x0009160A File Offset: 0x0008F80A
		[SkipLocalsInit]
		public static void Export()
		{
			UnrealReflectionUtils.CallUFunction(UPerformanceStatisticsLibrary._ClassDefaultObjectPtr, UPerformanceStatisticsLibrary.__Export_NativeFunctionPtr, null);
		}

		// Token: 0x0600658E RID: 25998 RVA: 0x0009161D File Offset: 0x0008F81D
		[SkipLocalsInit]
		public static void Clear()
		{
			UnrealReflectionUtils.CallUFunction(UPerformanceStatisticsLibrary._ClassDefaultObjectPtr, UPerformanceStatisticsLibrary.__Clear_NativeFunctionPtr, null);
		}

		// Token: 0x0600658F RID: 25999 RVA: 0x00091630 File Offset: 0x0008F830
		[NullableContext(1)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UPerformanceStatisticsLibrary._ClassDefaultObjectPtr, UPerformanceStatisticsLibrary.__AddStatistics_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UPerformanceStatisticsLibrary.__AddStatistics_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006590 RID: 26000 RVA: 0x000916B7 File Offset: 0x0008F8B7
		static UPerformanceStatisticsLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.PerformanceStatisticsLibrary");
		}

		// Token: 0x06006591 RID: 26001 RVA: 0x000916C5 File Offset: 0x0008F8C5
		protected UPerformanceStatisticsLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002AB2 RID: 10930
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.PerformanceStatisticsLibrary";

		// Token: 0x04002AB3 RID: 10931
		private static IntPtr _ClassPtr;

		// Token: 0x04002AB4 RID: 10932
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002AB5 RID: 10933
		private static IntPtr __StatisticsFromRawDataFiles_NativeFunctionPtr;

		// Token: 0x04002AB6 RID: 10934
		private static IntPtr __ReadSectionFromFile_NativeFunctionPtr;

		// Token: 0x04002AB7 RID: 10935
		private static IntPtr __ReadAllSectionsFromDirectory_NativeFunctionPtr;

		// Token: 0x04002AB8 RID: 10936
		private static IntPtr __Export_NativeFunctionPtr;

		// Token: 0x04002AB9 RID: 10937
		private static IntPtr __Clear_NativeFunctionPtr;

		// Token: 0x04002ABA RID: 10938
		private static IntPtr __AddStatistics_NativeFunctionPtr;

		// Token: 0x02000B0B RID: 2827
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReadSectionFromFile_FunctionParams
		{
			// Token: 0x04005BA5 RID: 23461
			[FieldOffset(0)]
			public FString FilePath;
		}

		// Token: 0x02000B0C RID: 2828
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __AddStatistics_FunctionParams
		{
			// Token: 0x04005BA6 RID: 23462
			[FieldOffset(0)]
			public FName SectionName;

			// Token: 0x04005BA7 RID: 23463
			[FieldOffset(12)]
			public int FrameCount;

			// Token: 0x04005BA8 RID: 23464
			[FieldOffset(16)]
			public FString Tag;

			// Token: 0x04005BA9 RID: 23465
			[FieldOffset(32)]
			public int MeasureMode;

			// Token: 0x04005BAA RID: 23466
			[FieldOffset(36)]
			public float Time;

			// Token: 0x04005BAB RID: 23467
			[FieldOffset(40)]
			public FString UserDefineMessage;
		}
	}
}
