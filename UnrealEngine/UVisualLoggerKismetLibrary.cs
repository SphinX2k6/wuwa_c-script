using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001239 RID: 4665
	[UnrealObjectPath("/Script/Engine.VisualLoggerKismetLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UVisualLoggerKismetLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011251 RID: 70225 RVA: 0x001927B2 File Offset: 0x001909B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVisualLoggerKismetLibrary._ClassPtr;
		}

		// Token: 0x06011252 RID: 70226 RVA: 0x001927C0 File Offset: 0x001909C0
		public UVisualLoggerKismetLibrary() : this(BuiltinUtils.AllocNativeUObject(UVisualLoggerKismetLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011253 RID: 70227 RVA: 0x001927E8 File Offset: 0x001909E8
		[NullableContext(1)]
		public UVisualLoggerKismetLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVisualLoggerKismetLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011254 RID: 70228 RVA: 0x0019281C File Offset: 0x00190A1C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RedirectVislog(UObject SourceOwner, UObject DestinationOwner)
		{
			UVisualLoggerKismetLibrary.__RedirectVislog_FunctionParams* ptr = stackalloc UVisualLoggerKismetLibrary.__RedirectVislog_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UVisualLoggerKismetLibrary.__RedirectVislog_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UVisualLoggerKismetLibrary.__RedirectVislog_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SourceOwner = ((SourceOwner != null) ? SourceOwner.NativePtr : IntPtr.Zero);
			ptr->DestinationOwner = ((DestinationOwner != null) ? DestinationOwner.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UVisualLoggerKismetLibrary._ClassDefaultObjectPtr, UVisualLoggerKismetLibrary.__RedirectVislog_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06011255 RID: 70229 RVA: 0x00192888 File Offset: 0x00190A88
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LogText([Nullable(2)] UObject WorldContextObject, string Text, FName? LogCategory = null, bool bAddToMessageLog = false)
		{
			UVisualLoggerKismetLibrary.__LogText_FunctionParams* ptr = stackalloc UVisualLoggerKismetLibrary.__LogText_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UVisualLoggerKismetLibrary.__LogText_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UVisualLoggerKismetLibrary.__LogText_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->Text), Text);
			ptr->LogCategory = (LogCategory ?? new FName("VisLogBP"));
			ptr->bAddToMessageLog = bAddToMessageLog;
			UnrealReflectionUtils.CallUFunction(UVisualLoggerKismetLibrary._ClassDefaultObjectPtr, UVisualLoggerKismetLibrary.__LogText_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UVisualLoggerKismetLibrary.__LogText_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06011256 RID: 70230 RVA: 0x00192928 File Offset: 0x00190B28
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LogSegment([Nullable(2)] UObject WorldContextObject, FVector SegmentStart, FVector SegmentEnd, string Text, FLinearColor? ObjectColor = null, float Thickness = 0f, FName? CategoryName = null, bool bAddToMessageLog = false)
		{
			UVisualLoggerKismetLibrary.__LogSegment_FunctionParams* ptr = stackalloc UVisualLoggerKismetLibrary.__LogSegment_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UVisualLoggerKismetLibrary.__LogSegment_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UVisualLoggerKismetLibrary.__LogSegment_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ptr->SegmentStart = SegmentStart;
			ptr->SegmentEnd = SegmentEnd;
			FString.CopyFrom((void*)(&ptr->Text), Text);
			ptr->ObjectColor = (ObjectColor ?? new FLinearColor
			{
				R = 0f,
				G = 0f,
				B = 1f,
				A = 1f
			});
			ptr->Thickness = Thickness;
			ptr->CategoryName = (CategoryName ?? new FName("VisLogBP"));
			ptr->bAddToMessageLog = bAddToMessageLog;
			UnrealReflectionUtils.CallUFunction(UVisualLoggerKismetLibrary._ClassDefaultObjectPtr, UVisualLoggerKismetLibrary.__LogSegment_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UVisualLoggerKismetLibrary.__LogSegment_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06011257 RID: 70231 RVA: 0x00192A34 File Offset: 0x00190C34
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LogLocation([Nullable(2)] UObject WorldContextObject, FVector Location, string Text, FLinearColor? ObjectColor = null, float Radius = 10f, FName? LogCategory = null, bool bAddToMessageLog = false)
		{
			UVisualLoggerKismetLibrary.__LogLocation_FunctionParams* ptr = stackalloc UVisualLoggerKismetLibrary.__LogLocation_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UVisualLoggerKismetLibrary.__LogLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UVisualLoggerKismetLibrary.__LogLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ptr->Location = Location;
			FString.CopyFrom((void*)(&ptr->Text), Text);
			ptr->ObjectColor = (ObjectColor ?? new FLinearColor
			{
				R = 0f,
				G = 0f,
				B = 1f,
				A = 1f
			});
			ptr->Radius = Radius;
			ptr->LogCategory = (LogCategory ?? new FName("VisLogBP"));
			ptr->bAddToMessageLog = bAddToMessageLog;
			UnrealReflectionUtils.CallUFunction(UVisualLoggerKismetLibrary._ClassDefaultObjectPtr, UVisualLoggerKismetLibrary.__LogLocation_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UVisualLoggerKismetLibrary.__LogLocation_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06011258 RID: 70232 RVA: 0x00192B38 File Offset: 0x00190D38
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LogBox([Nullable(2)] UObject WorldContextObject, FBox BoxShape, string Text, FLinearColor? ObjectColor = null, FName? LogCategory = null, bool bAddToMessageLog = false)
		{
			UVisualLoggerKismetLibrary.__LogBox_FunctionParams* ptr = stackalloc UVisualLoggerKismetLibrary.__LogBox_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UVisualLoggerKismetLibrary.__LogBox_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UVisualLoggerKismetLibrary.__LogBox_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ptr->BoxShape = BoxShape;
			FString.CopyFrom((void*)(&ptr->Text), Text);
			ptr->ObjectColor = (ObjectColor ?? new FLinearColor
			{
				R = 0f,
				G = 0f,
				B = 1f,
				A = 1f
			});
			ptr->LogCategory = (LogCategory ?? new FName("VisLogBP"));
			ptr->bAddToMessageLog = bAddToMessageLog;
			UnrealReflectionUtils.CallUFunction(UVisualLoggerKismetLibrary._ClassDefaultObjectPtr, UVisualLoggerKismetLibrary.__LogBox_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UVisualLoggerKismetLibrary.__LogBox_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06011259 RID: 70233 RVA: 0x00192C34 File Offset: 0x00190E34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void EnableRecording(bool bEnabled)
		{
			UVisualLoggerKismetLibrary.__EnableRecording_FunctionParams* ptr = stackalloc UVisualLoggerKismetLibrary.__EnableRecording_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UVisualLoggerKismetLibrary.__EnableRecording_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UVisualLoggerKismetLibrary.__EnableRecording_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnabled = bEnabled;
			UnrealReflectionUtils.CallUFunction(UVisualLoggerKismetLibrary._ClassDefaultObjectPtr, UVisualLoggerKismetLibrary.__EnableRecording_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601125A RID: 70234 RVA: 0x00192C7A File Offset: 0x00190E7A
		static UVisualLoggerKismetLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.VisualLoggerKismetLibrary");
		}

		// Token: 0x0601125B RID: 70235 RVA: 0x00192C88 File Offset: 0x00190E88
		protected UVisualLoggerKismetLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040092CC RID: 37580
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.VisualLoggerKismetLibrary";

		// Token: 0x040092CD RID: 37581
		private static IntPtr _ClassPtr;

		// Token: 0x040092CE RID: 37582
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040092CF RID: 37583
		private static IntPtr __RedirectVislog_NativeFunctionPtr;

		// Token: 0x040092D0 RID: 37584
		private static IntPtr __LogText_NativeFunctionPtr;

		// Token: 0x040092D1 RID: 37585
		private static IntPtr __LogSegment_NativeFunctionPtr;

		// Token: 0x040092D2 RID: 37586
		private static IntPtr __LogLocation_NativeFunctionPtr;

		// Token: 0x040092D3 RID: 37587
		private static IntPtr __LogBox_NativeFunctionPtr;

		// Token: 0x040092D4 RID: 37588
		private static IntPtr __EnableRecording_NativeFunctionPtr;

		// Token: 0x02002E06 RID: 11782
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RedirectVislog_FunctionParams
		{
			// Token: 0x04016870 RID: 92272
			[FieldOffset(0)]
			public IntPtr SourceOwner;

			// Token: 0x04016871 RID: 92273
			[FieldOffset(8)]
			public IntPtr DestinationOwner;
		}

		// Token: 0x02002E07 RID: 11783
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __LogText_FunctionParams
		{
			// Token: 0x04016872 RID: 92274
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x04016873 RID: 92275
			[FieldOffset(8)]
			public FString Text;

			// Token: 0x04016874 RID: 92276
			[FieldOffset(24)]
			public FName LogCategory;

			// Token: 0x04016875 RID: 92277
			[FieldOffset(36)]
			public bool bAddToMessageLog;
		}

		// Token: 0x02002E08 RID: 11784
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __LogSegment_FunctionParams
		{
			// Token: 0x04016876 RID: 92278
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x04016877 RID: 92279
			[FieldOffset(8)]
			public FVector SegmentStart;

			// Token: 0x04016878 RID: 92280
			[FieldOffset(20)]
			public FVector SegmentEnd;

			// Token: 0x04016879 RID: 92281
			[FieldOffset(32)]
			public FString Text;

			// Token: 0x0401687A RID: 92282
			[FieldOffset(48)]
			public FLinearColor ObjectColor;

			// Token: 0x0401687B RID: 92283
			[FieldOffset(64)]
			public float Thickness;

			// Token: 0x0401687C RID: 92284
			[FieldOffset(68)]
			public FName CategoryName;

			// Token: 0x0401687D RID: 92285
			[FieldOffset(80)]
			public bool bAddToMessageLog;
		}

		// Token: 0x02002E09 RID: 11785
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __LogLocation_FunctionParams
		{
			// Token: 0x0401687E RID: 92286
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x0401687F RID: 92287
			[FieldOffset(8)]
			public FVector Location;

			// Token: 0x04016880 RID: 92288
			[FieldOffset(24)]
			public FString Text;

			// Token: 0x04016881 RID: 92289
			[FieldOffset(40)]
			public FLinearColor ObjectColor;

			// Token: 0x04016882 RID: 92290
			[FieldOffset(56)]
			public float Radius;

			// Token: 0x04016883 RID: 92291
			[FieldOffset(60)]
			public FName LogCategory;

			// Token: 0x04016884 RID: 92292
			[FieldOffset(72)]
			public bool bAddToMessageLog;
		}

		// Token: 0x02002E0A RID: 11786
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __LogBox_FunctionParams
		{
			// Token: 0x04016885 RID: 92293
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x04016886 RID: 92294
			[FieldOffset(8)]
			public FBox BoxShape;

			// Token: 0x04016887 RID: 92295
			[FieldOffset(40)]
			public FString Text;

			// Token: 0x04016888 RID: 92296
			[FieldOffset(56)]
			public FLinearColor ObjectColor;

			// Token: 0x04016889 RID: 92297
			[FieldOffset(72)]
			public FName LogCategory;

			// Token: 0x0401688A RID: 92298
			[FieldOffset(84)]
			public bool bAddToMessageLog;
		}

		// Token: 0x02002E0B RID: 11787
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __EnableRecording_FunctionParams
		{
			// Token: 0x0401688B RID: 92299
			[FieldOffset(0)]
			public bool bEnabled;
		}
	}
}
