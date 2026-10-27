using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002918 RID: 10520
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TimeManagement.TimeManagementBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UTimeManagementBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026FB5 RID: 159669 RVA: 0x003B733D File Offset: 0x003B553D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTimeManagementBlueprintLibrary._ClassPtr;
		}

		// Token: 0x06026FB6 RID: 159670 RVA: 0x003B734C File Offset: 0x003B554C
		public UTimeManagementBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UTimeManagementBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026FB7 RID: 159671 RVA: 0x003B7374 File Offset: 0x003B5574
		public UTimeManagementBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTimeManagementBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026FB8 RID: 159672 RVA: 0x003B73A7 File Offset: 0x003B55A7
		public static FFrameTime TransformTime([Nullable(2)] in FFrameTime SourceTime, in FFrameRate SourceRate, in FFrameRate DestinationRate)
		{
			return new FFrameTime(UTimeManagementBlueprintLibrary.__TransformTime_Internal((SourceTime ?? new FFrameTime()).NativePtr, SourceRate, DestinationRate), null);
		}

		// Token: 0x06026FB9 RID: 159673 RVA: 0x003B73C6 File Offset: 0x003B55C6
		public static FFrameNumber Subtract_FrameNumberInteger([Nullable(2)] FFrameNumber A, int B)
		{
			return new FFrameNumber(UTimeManagementBlueprintLibrary.__Subtract_FrameNumberInteger_Internal((A ?? new FFrameNumber()).NativePtr, B), null);
		}

		// Token: 0x06026FBA RID: 159674 RVA: 0x003B73E3 File Offset: 0x003B55E3
		[NullableContext(2)]
		[return: Nullable(1)]
		public static FFrameNumber Subtract_FrameNumberFrameNumber(FFrameNumber A, FFrameNumber B)
		{
			return new FFrameNumber(UTimeManagementBlueprintLibrary.__Subtract_FrameNumberFrameNumber_Internal((A ?? new FFrameNumber()).NativePtr, (B ?? new FFrameNumber()).NativePtr), null);
		}

		// Token: 0x06026FBB RID: 159675 RVA: 0x003B740E File Offset: 0x003B560E
		public static FFrameTime SnapFrameTimeToRate([Nullable(2)] in FFrameTime SourceTime, in FFrameRate SourceRate, in FFrameRate SnapToRate)
		{
			return new FFrameTime(UTimeManagementBlueprintLibrary.__SnapFrameTimeToRate_Internal((SourceTime ?? new FFrameTime()).NativePtr, SourceRate, SnapToRate), null);
		}

		// Token: 0x06026FBC RID: 159676 RVA: 0x003B742D File Offset: 0x003B562D
		public static FFrameTime Multiply_SecondsFrameRate(float TimeInSeconds, in FFrameRate FrameRate)
		{
			return new FFrameTime(UTimeManagementBlueprintLibrary.__Multiply_SecondsFrameRate_Internal(TimeInSeconds, FrameRate), null);
		}

		// Token: 0x06026FBD RID: 159677 RVA: 0x003B743C File Offset: 0x003B563C
		public static FFrameNumber Multiply_FrameNumberInteger([Nullable(2)] FFrameNumber A, int B)
		{
			return new FFrameNumber(UTimeManagementBlueprintLibrary.__Multiply_FrameNumberInteger_Internal((A ?? new FFrameNumber()).NativePtr, B), null);
		}

		// Token: 0x06026FBE RID: 159678
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsValid_MultipleOf(in FFrameRate InFrameRate, in FFrameRate OtherFramerate);

		// Token: 0x06026FBF RID: 159679
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsValid_Framerate(in FFrameRate InFrameRate);

		// Token: 0x06026FC0 RID: 159680
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FFrameRate GetTimecodeFrameRate();

		// Token: 0x06026FC1 RID: 159681
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FTimecode GetTimecode();

		// Token: 0x06026FC2 RID: 159682 RVA: 0x003B7459 File Offset: 0x003B5659
		public static FFrameNumber Divide_FrameNumberInteger([Nullable(2)] FFrameNumber A, int B)
		{
			return new FFrameNumber(UTimeManagementBlueprintLibrary.__Divide_FrameNumberInteger_Internal((A ?? new FFrameNumber()).NativePtr, B), null);
		}

		// Token: 0x06026FC3 RID: 159683 RVA: 0x003B7476 File Offset: 0x003B5676
		public static string Conv_TimecodeToString(in FTimecode InTimecode, bool bForceSignDisplay = false)
		{
			return FString.ToStringAndDeleteNativePtr(UTimeManagementBlueprintLibrary.__Conv_TimecodeToString_Internal(InTimecode, bForceSignDisplay));
		}

		// Token: 0x06026FC4 RID: 159684 RVA: 0x003B7484 File Offset: 0x003B5684
		[NullableContext(2)]
		public static float Conv_QualifiedFrameTimeToSeconds(in FQualifiedFrameTime InFrameTime)
		{
			return UTimeManagementBlueprintLibrary.__Conv_QualifiedFrameTimeToSeconds_Internal((InFrameTime ?? new FQualifiedFrameTime()).NativePtr);
		}

		// Token: 0x06026FC5 RID: 159685
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Conv_FrameRateToSeconds(in FFrameRate InFrameRate);

		// Token: 0x06026FC6 RID: 159686 RVA: 0x003B749B File Offset: 0x003B569B
		[NullableContext(2)]
		public static int Conv_FrameNumberToInteger(in FFrameNumber InFrameNumber)
		{
			return UTimeManagementBlueprintLibrary.__Conv_FrameNumberToInteger_Internal((InFrameNumber ?? new FFrameNumber()).NativePtr);
		}

		// Token: 0x06026FC7 RID: 159687 RVA: 0x003B74B2 File Offset: 0x003B56B2
		public static FFrameNumber Add_FrameNumberInteger([Nullable(2)] FFrameNumber A, int B)
		{
			return new FFrameNumber(UTimeManagementBlueprintLibrary.__Add_FrameNumberInteger_Internal((A ?? new FFrameNumber()).NativePtr, B), null);
		}

		// Token: 0x06026FC8 RID: 159688 RVA: 0x003B74CF File Offset: 0x003B56CF
		[NullableContext(2)]
		[return: Nullable(1)]
		public static FFrameNumber Add_FrameNumberFrameNumber(FFrameNumber A, FFrameNumber B)
		{
			return new FFrameNumber(UTimeManagementBlueprintLibrary.__Add_FrameNumberFrameNumber_Internal((A ?? new FFrameNumber()).NativePtr, (B ?? new FFrameNumber()).NativePtr), null);
		}

		// Token: 0x06026FC9 RID: 159689
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __TransformTime_Internal(IntPtr SourceTime, in FFrameRate SourceRate, in FFrameRate DestinationRate);

		// Token: 0x06026FCA RID: 159690
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Subtract_FrameNumberInteger_Internal(IntPtr A, int B);

		// Token: 0x06026FCB RID: 159691
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Subtract_FrameNumberFrameNumber_Internal(IntPtr A, IntPtr B);

		// Token: 0x06026FCC RID: 159692
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SnapFrameTimeToRate_Internal(IntPtr SourceTime, in FFrameRate SourceRate, in FFrameRate SnapToRate);

		// Token: 0x06026FCD RID: 159693
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Multiply_SecondsFrameRate_Internal(float TimeInSeconds, in FFrameRate FrameRate);

		// Token: 0x06026FCE RID: 159694
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Multiply_FrameNumberInteger_Internal(IntPtr A, int B);

		// Token: 0x06026FCF RID: 159695
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Divide_FrameNumberInteger_Internal(IntPtr A, int B);

		// Token: 0x06026FD0 RID: 159696
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_TimecodeToString_Internal(in FTimecode InTimecode, bool bForceSignDisplay);

		// Token: 0x06026FD1 RID: 159697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Conv_QualifiedFrameTimeToSeconds_Internal(IntPtr InFrameTime);

		// Token: 0x06026FD2 RID: 159698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __Conv_FrameNumberToInteger_Internal(IntPtr InFrameNumber);

		// Token: 0x06026FD3 RID: 159699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Add_FrameNumberInteger_Internal(IntPtr A, int B);

		// Token: 0x06026FD4 RID: 159700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Add_FrameNumberFrameNumber_Internal(IntPtr A, IntPtr B);

		// Token: 0x06026FD5 RID: 159701 RVA: 0x003B74FA File Offset: 0x003B56FA
		static UTimeManagementBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TimeManagement.TimeManagementBlueprintLibrary");
		}

		// Token: 0x06026FD6 RID: 159702 RVA: 0x003B7508 File Offset: 0x003B5708
		protected UTimeManagementBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015664 RID: 87652
		public new const string __ObjectPath = "/Script/TimeManagement.TimeManagementBlueprintLibrary";

		// Token: 0x04015665 RID: 87653
		private static IntPtr _ClassPtr;

		// Token: 0x04015666 RID: 87654
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
