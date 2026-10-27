using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ED3 RID: 7891
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroStaticLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroStaticLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DEC8 RID: 122568 RVA: 0x002C44E4 File Offset: 0x002C26E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroStaticLibrary._ClassPtr;
		}

		// Token: 0x0601DEC9 RID: 122569 RVA: 0x002C44F0 File Offset: 0x002C26F0
		public UKuroStaticLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroStaticLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DECA RID: 122570 RVA: 0x002C4518 File Offset: 0x002C2718
		public UKuroStaticLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroStaticLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DECB RID: 122571 RVA: 0x002C454C File Offset: 0x002C274C
		public unsafe static bool WriteStringToFile(string SaveText, string FileName, bool bPublic = false, bool bWithBom = false)
		{
			FString fstring = FString.AllocTemp(SaveText);
			FString fstring2 = FString.AllocTemp(FileName);
			bool result = UKuroStaticLibrary.__WriteStringToFile_Internal(fstring, fstring2, bPublic, bWithBom);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0601DECC RID: 122572 RVA: 0x002C4584 File Offset: 0x002C2784
		public unsafe static void UnRegisterCustomCommandProcessor(string Category)
		{
			FString fstring = FString.AllocTemp(Category);
			UKuroStaticLibrary.__UnRegisterCustomCommandProcessor_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DECD RID: 122573
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnBindDeviceLangChangeDelegate();

		// Token: 0x0601DECE RID: 122574 RVA: 0x002C45A8 File Offset: 0x002C27A8
		[NullableContext(2)]
		public static int ToUnixTimestamp(FDateTime InDataTime)
		{
			return UKuroStaticLibrary.__ToUnixTimestamp_Internal((InDataTime ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0601DECF RID: 122575 RVA: 0x002C45BE File Offset: 0x002C27BE
		[NullableContext(2)]
		public static bool ToggleSequenceNodeActiveByTag(ALevelSequenceActor Actor, FName TagName, bool bActive)
		{
			return UKuroStaticLibrary.__ToggleSequenceNodeActiveByTag_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, TagName, bActive);
		}

		// Token: 0x0601DED0 RID: 122576 RVA: 0x002C45D7 File Offset: 0x002C27D7
		[NullableContext(2)]
		public static void SynchronizeProperties(UWidget InWidget)
		{
			UKuroStaticLibrary.__SynchronizeProperties_Internal((InWidget != null) ? InWidget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601DED1 RID: 122577 RVA: 0x002C45EE File Offset: 0x002C27EE
		[NullableContext(2)]
		public static void StopAllMontagesBySlotName(UAnimInstance UAnimInstance, FName InSlotName, float InBlendOutTime)
		{
			UKuroStaticLibrary.__StopAllMontagesBySlotName_Internal((UAnimInstance != null) ? UAnimInstance.NativePtr : IntPtr.Zero, InSlotName, InBlendOutTime);
		}

		// Token: 0x0601DED2 RID: 122578 RVA: 0x002C4607 File Offset: 0x002C2807
		[NullableContext(2)]
		public static AActor SpawnActorFromAnother(AActor Actor, AActor Parent = null)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroStaticLibrary.__SpawnActorFromAnother_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, (Parent != null) ? Parent.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601DED3 RID: 122579
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ShowSoftwareCursor(bool visible);

		// Token: 0x0601DED4 RID: 122580 RVA: 0x002C4634 File Offset: 0x002C2834
		public unsafe static void SetThreadPriorityAndPolicyAndAffinity(string ThreadName, int Priority, int Policy, int AffinityHigh, int AffinityLow)
		{
			FString fstring = FString.AllocTemp(ThreadName);
			UKuroStaticLibrary.__SetThreadPriorityAndPolicyAndAffinity_Internal(fstring, Priority, Policy, AffinityHigh, AffinityLow);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DED5 RID: 122581 RVA: 0x002C4660 File Offset: 0x002C2860
		public unsafe static void SetThreadPriorityAndPolicy(string ThreadName, int Priority, int Policy)
		{
			FString fstring = FString.AllocTemp(ThreadName);
			UKuroStaticLibrary.__SetThreadPriorityAndPolicy_Internal(fstring, Priority, Policy);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DED6 RID: 122582 RVA: 0x002C4688 File Offset: 0x002C2888
		public unsafe static void SetThreadPriority(string ThreadName, int Priority)
		{
			FString fstring = FString.AllocTemp(ThreadName);
			UKuroStaticLibrary.__SetThreadPriority_Internal(fstring, Priority);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DED7 RID: 122583 RVA: 0x002C46B0 File Offset: 0x002C28B0
		public unsafe static void SetThreadPolicy(string ThreadName, int Policy)
		{
			FString fstring = FString.AllocTemp(ThreadName);
			UKuroStaticLibrary.__SetThreadPolicy_Internal(fstring, Policy);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DED8 RID: 122584 RVA: 0x002C46D8 File Offset: 0x002C28D8
		public unsafe static void SetThreadAffinity(string ThreadName, int AffinityHigh, int AffinityLow)
		{
			FString fstring = FString.AllocTemp(ThreadName);
			UKuroStaticLibrary.__SetThreadAffinity_Internal(fstring, AffinityHigh, AffinityLow);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DED9 RID: 122585 RVA: 0x002C46FE File Offset: 0x002C28FE
		public static void SetStaticMeshVelocity([Nullable(new byte[]
		{
			2,
			1
		})] TArray<AActor> Actors, FVector NewVelocity)
		{
			UKuroStaticLibrary.__SetStaticMeshVelocity_Internal((Actors ?? new TArray<AActor>()).NativePtr, NewVelocity);
		}

		// Token: 0x0601DEDA RID: 122586 RVA: 0x002C4715 File Offset: 0x002C2915
		[NullableContext(2)]
		public static void SetSplinePointsWithType(USplineComponent Spline, in TArray<FVector> Points, ESplineCoordinateSpace CoordinateSpace, ESplinePointType Type, bool bUpdateSpline = true)
		{
			UKuroStaticLibrary.__SetSplinePointsWithType_Internal((Spline != null) ? Spline.NativePtr : IntPtr.Zero, (Points ?? new TArray<FVector>()).NativePtr, CoordinateSpace, Type, bUpdateSpline);
		}

		// Token: 0x0601DEDB RID: 122587 RVA: 0x002C474A File Offset: 0x002C294A
		[NullableContext(2)]
		public static void SetMontageANIndex(UAnimMontage AnimMontage)
		{
			UKuroStaticLibrary.__SetMontageANIndex_Internal((AnimMontage != null) ? AnimMontage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601DEDC RID: 122588 RVA: 0x002C4761 File Offset: 0x002C2961
		[NullableContext(2)]
		public static void SetInputKeyDeadZone(UObject world, int playerIndex, FKey key, float deadZone)
		{
			UKuroStaticLibrary.__SetInputKeyDeadZone_Internal((world != null) ? world.NativePtr : IntPtr.Zero, playerIndex, (key ?? new FKey()).NativePtr, deadZone);
		}

		// Token: 0x0601DEDD RID: 122589
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetHttpThreadIdleMinimumSleepTimeInSeconds(float InHttpThreadIdleMinimumSleepTimeInSeconds);

		// Token: 0x0601DEDE RID: 122590
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetHttpThreadActiveMinimumSleepTimeInSeconds(float InHttpThreadActiveMinimumSleepTimeInSeconds);

		// Token: 0x0601DEDF RID: 122591
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetHangDuration(float HangDuration);

		// Token: 0x0601DEE0 RID: 122592
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetHangAssertFlag(bool bAssertFlag);

		// Token: 0x0601DEE1 RID: 122593
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGameThreadAffinity(bool bIsInFighting);

		// Token: 0x0601DEE2 RID: 122594
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEditorWidgetSkipTick(bool bSkipTick);

		// Token: 0x0601DEE3 RID: 122595
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetCursorVisibility(bool visible);

		// Token: 0x0601DEE4 RID: 122596 RVA: 0x002C478C File Offset: 0x002C298C
		public unsafe static void SetConsoleVariableWithCurrentPriority_String(string InCVar, string InValue)
		{
			FString fstring = FString.AllocTemp(InCVar);
			FString fstring2 = FString.AllocTemp(InValue);
			UKuroStaticLibrary.__SetConsoleVariableWithCurrentPriority_String_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0601DEE5 RID: 122597 RVA: 0x002C47C4 File Offset: 0x002C29C4
		public unsafe static void SetConsoleVariableWithCurrentPriority_Int(string InCVar, int InValue)
		{
			FString fstring = FString.AllocTemp(InCVar);
			UKuroStaticLibrary.__SetConsoleVariableWithCurrentPriority_Int_Internal(fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DEE6 RID: 122598 RVA: 0x002C47EC File Offset: 0x002C29EC
		public unsafe static void SetConsoleVariableWithCurrentPriority_Float(string InCVar, float InValue)
		{
			FString fstring = FString.AllocTemp(InCVar);
			UKuroStaticLibrary.__SetConsoleVariableWithCurrentPriority_Float_Internal(fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DEE7 RID: 122599 RVA: 0x002C4811 File Offset: 0x002C2A11
		[NullableContext(2)]
		public static void SetBaseAndSaveBaseLocation(UCharacterMovementComponent CharacterMovementComp, UPrimitiveComponent NewBase)
		{
			UKuroStaticLibrary.__SetBaseAndSaveBaseLocation_Internal((CharacterMovementComp != null) ? CharacterMovementComp.NativePtr : IntPtr.Zero, (NewBase != null) ? NewBase.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601DEE8 RID: 122600 RVA: 0x002C4838 File Offset: 0x002C2A38
		[NullableContext(2)]
		public static void SetActorPermanent(AActor Actor, bool bIsPermanent, bool bWithAllChildren)
		{
			UKuroStaticLibrary.__SetActorPermanent_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, bIsPermanent, bWithAllChildren);
		}

		// Token: 0x0601DEE9 RID: 122601 RVA: 0x002C4851 File Offset: 0x002C2A51
		[NullableContext(2)]
		public static void SetActorModify(AActor Actor)
		{
			UKuroStaticLibrary.__SetActorModify_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601DEEA RID: 122602 RVA: 0x002C4868 File Offset: 0x002C2A68
		public unsafe static bool SaveStringToFile(string SaveText, string FileName, bool bWithBom = false)
		{
			FString fstring = FString.AllocTemp(SaveText);
			FString fstring2 = FString.AllocTemp(FileName);
			bool result = UKuroStaticLibrary.__SaveStringToFile_Internal(fstring, fstring2, bWithBom);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0601DEEB RID: 122603 RVA: 0x002C48A0 File Offset: 0x002C2AA0
		public unsafe static bool SaveBufferToFile(string Path, in FArrayBuffer InBuffer)
		{
			FString fstring = FString.AllocTemp(Path);
			bool result = UKuroStaticLibrary.__SaveBufferToFile_Internal(fstring, InBuffer);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DEEC RID: 122604
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetHttpMaxFlushTimeSeconds();

		// Token: 0x0601DEED RID: 122605 RVA: 0x002C48C5 File Offset: 0x002C2AC5
		[NullableContext(2)]
		public static void RemoveFromRoot(UObject InObject)
		{
			UKuroStaticLibrary.__RemoveFromRoot_Internal((InObject != null) ? InObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601DEEE RID: 122606 RVA: 0x002C48DC File Offset: 0x002C2ADC
		public unsafe static void RegisterCustomCommandProcessor(string Category, [Nullable(2)] in FProcessCustomCommandDelegate Processor)
		{
			FString fstring = FString.AllocTemp(Category);
			FProcessCustomCommandDelegate fprocessCustomCommandDelegate = Processor;
			UKuroStaticLibrary.__RegisterCustomCommandProcessor_Internal(fstring, (fprocessCustomCommandDelegate != null) ? fprocessCustomCommandDelegate.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DEEF RID: 122607 RVA: 0x002C4910 File Offset: 0x002C2B10
		public unsafe static void PingGateWay(string Address, int Port, float Timeout, string Payload, [Nullable(2)] in FKuroGateWayPingCallBack PingDelegate)
		{
			FString fstring = FString.AllocTemp(Address);
			FString fstring2 = FString.AllocTemp(Payload);
			FKuroGateWayPingCallBack fkuroGateWayPingCallBack = PingDelegate;
			UKuroStaticLibrary.__PingGateWay_Internal(fstring, Port, Timeout, fstring2, (fkuroGateWayPingCallBack != null) ? fkuroGateWayPingCallBack.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0601DEF0 RID: 122608 RVA: 0x002C4958 File Offset: 0x002C2B58
		[NullableContext(2)]
		public static void PerceptionConfigureSense(UAIPerceptionComponent AIPerception, UAISenseConfig AISenseConfig)
		{
			UKuroStaticLibrary.__PerceptionConfigureSense_Internal((AIPerception != null) ? AIPerception.NativePtr : IntPtr.Zero, (AISenseConfig != null) ? AISenseConfig.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601DEF1 RID: 122609 RVA: 0x002C4980 File Offset: 0x002C2B80
		public unsafe static string Md5HashUTF8String(string inString)
		{
			FString fstring = FString.AllocTemp(inString);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__Md5HashUTF8String_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DEF2 RID: 122610 RVA: 0x002C49AC File Offset: 0x002C2BAC
		public unsafe static string Md5HashAnsiString(string inString)
		{
			FString fstring = FString.AllocTemp(inString);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__Md5HashAnsiString_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DEF3 RID: 122611 RVA: 0x002C49D8 File Offset: 0x002C2BD8
		public unsafe static bool MakeDirectory(string Path, bool bTree = false)
		{
			FString fstring = FString.AllocTemp(Path);
			bool result = UKuroStaticLibrary.__MakeDirectory_Internal(fstring, bTree);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DEF4 RID: 122612 RVA: 0x002C4A00 File Offset: 0x002C2C00
		public unsafe static TArray<string> LoadFileToStringArray(string FileRevisionPath)
		{
			FString fstring = FString.AllocTemp(FileRevisionPath);
			TArray<string> result = new TArray<string>(UKuroStaticLibrary.__LoadFileToStringArray_Internal(fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DEF5 RID: 122613 RVA: 0x002C4A2C File Offset: 0x002C2C2C
		public unsafe static bool LoadFileToString(ref string Result, string Filename)
		{
			FString fstring = FString.AllocTemp(Result);
			FString fstring2 = FString.AllocTemp(Filename);
			bool result = UKuroStaticLibrary.__LoadFileToString_Internal(ref fstring, fstring2);
			Result = FString.ToString(fstring);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0601DEF6 RID: 122614 RVA: 0x002C4A6C File Offset: 0x002C2C6C
		public unsafe static bool LoadFileToArrayPriorPakChunk(string Path, int PakchunkIndex, [Nullable(2)] ref TArray<byte> OutArray)
		{
			FString fstring = FString.AllocTemp(Path);
			bool result = UKuroStaticLibrary.__LoadFileToArrayPriorPakChunk_Internal(fstring, PakchunkIndex, (OutArray ?? new TArray<byte>()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DEF7 RID: 122615 RVA: 0x002C4AA4 File Offset: 0x002C2CA4
		public unsafe static bool LoadFileToArray(string Path, [Nullable(2)] ref TArray<byte> OutArray)
		{
			FString fstring = FString.AllocTemp(Path);
			bool result = UKuroStaticLibrary.__LoadFileToArray_Internal(fstring, (OutArray ?? new TArray<byte>()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DEF8 RID: 122616 RVA: 0x002C4AD8 File Offset: 0x002C2CD8
		public unsafe static TArray<string> LoadFilesRecursive(string Path, string Filter, bool Files, bool Directories)
		{
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Filter);
			TArray<string> result = new TArray<string>(UKuroStaticLibrary.__LoadFilesRecursive_Internal(fstring, fstring2, Files, Directories), null);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0601DEF9 RID: 122617 RVA: 0x002C4B18 File Offset: 0x002C2D18
		public unsafe static string KuroFormatText(string Format, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> Parameters)
		{
			FString fstring = FString.AllocTemp(Format);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__KuroFormatText_Internal(fstring, (Parameters ?? new TArray<string>()).NativePtr));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DEFA RID: 122618
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool KuroEnableCustomAffinity();

		// Token: 0x0601DEFB RID: 122619 RVA: 0x002C4B50 File Offset: 0x002C2D50
		[NullableContext(2)]
		public static bool IsWorldTearingDown(UWorld World)
		{
			return UKuroStaticLibrary.__IsWorldTearingDown_Internal((World != null) ? World.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601DEFC RID: 122620
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsWithEditor();

		// Token: 0x0601DEFD RID: 122621
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsViewportFocus();

		// Token: 0x0601DEFE RID: 122622 RVA: 0x002C4B67 File Offset: 0x002C2D67
		[NullableContext(2)]
		public static bool IsObjectClassByName(UObject Object, FName ClassName)
		{
			return UKuroStaticLibrary.__IsObjectClassByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, ClassName);
		}

		// Token: 0x0601DEFF RID: 122623 RVA: 0x002C4B7F File Offset: 0x002C2D7F
		[NullableContext(2)]
		public static bool IsMontageContainGivenAnimNotify(UAnimMontage AnimMontage, [Nullable(new byte[]
		{
			2,
			1
		})] in TSet<string> CheckClassNames)
		{
			return UKuroStaticLibrary.__IsMontageContainGivenAnimNotify_Internal((AnimMontage != null) ? AnimMontage.NativePtr : IntPtr.Zero, (CheckClassNames ?? new TSet<string>()).NativeSetPtr);
		}

		// Token: 0x0601DF00 RID: 122624 RVA: 0x002C4BA8 File Offset: 0x002C2DA8
		public unsafe static bool IsModuleLoaded(string ModelName)
		{
			FString fstring = FString.AllocTemp(ModelName);
			bool result = UKuroStaticLibrary.__IsModuleLoaded_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DF01 RID: 122625
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsLowMemoryDevice();

		// Token: 0x0601DF02 RID: 122626
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsImplementInterface(UClassStackOnlyPtr InClass, UClassStackOnlyPtr InInterfaceClass);

		// Token: 0x0601DF03 RID: 122627
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsForegroundWindow();

		// Token: 0x0601DF04 RID: 122628 RVA: 0x002C4BCC File Offset: 0x002C2DCC
		[NullableContext(2)]
		public static bool IsEditor(UObject WorldContextObject)
		{
			return UKuroStaticLibrary.__IsEditor_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601DF05 RID: 122629 RVA: 0x002C4BE4 File Offset: 0x002C2DE4
		public unsafe static void IcmpPing(string IpAddress, float Timeout, [Nullable(2)] in FPingCallExDelegate InDelegate)
		{
			FString fstring = FString.AllocTemp(IpAddress);
			FPingCallExDelegate fpingCallExDelegate = InDelegate;
			UKuroStaticLibrary.__IcmpPing_Internal(fstring, Timeout, (fpingCallExDelegate != null) ? fpingCallExDelegate.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DF06 RID: 122630 RVA: 0x002C4C18 File Offset: 0x002C2E18
		public unsafe static string HashStringWithSHA1(string inString)
		{
			FString fstring = FString.AllocTemp(inString);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__HashStringWithSHA1_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DF07 RID: 122631 RVA: 0x002C4C41 File Offset: 0x002C2E41
		public static string GetWholeStatUnitInfo(float Timespan)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetWholeStatUnitInfo_Internal(Timespan));
		}

		// Token: 0x0601DF08 RID: 122632
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetViewPortMousePosition2(ref FVector2D MousePos);

		// Token: 0x0601DF09 RID: 122633
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetViewPortMousePosition();

		// Token: 0x0601DF0A RID: 122634
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetVideoMemoryGB();

		// Token: 0x0601DF0B RID: 122635 RVA: 0x002C4C4E File Offset: 0x002C2E4E
		public static string GetVendorInfo()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetVendorInfo_Internal());
		}

		// Token: 0x0601DF0C RID: 122636 RVA: 0x002C4C5A File Offset: 0x002C2E5A
		[NullableContext(2)]
		public static UMovieSceneTrack GetTrackByClass([Nullable(new byte[]
		{
			2,
			1
		})] TArray<UMovieSceneTrack> Tracks, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UMovieSceneTrack> Class)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMovieSceneTrack>(UKuroStaticLibrary.__GetTrackByClass_Internal((Tracks ?? new TArray<UMovieSceneTrack>()).NativePtr, Class._NativePtr));
		}

		// Token: 0x0601DF0D RID: 122637
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetTotalPhysicalMemory();

		// Token: 0x0601DF0E RID: 122638 RVA: 0x002C4C7B File Offset: 0x002C2E7B
		public static string GetSysUUID()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetSysUUID_Internal());
		}

		// Token: 0x0601DF0F RID: 122639 RVA: 0x002C4C87 File Offset: 0x002C2E87
		public static string GetStatUnitInfo()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetStatUnitInfo_Internal());
		}

		// Token: 0x0601DF10 RID: 122640 RVA: 0x002C4C93 File Offset: 0x002C2E93
		[NullableContext(2)]
		public static FRotator GetSplineRotationAtSplinePoint(USplineComponent Spline, int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return UKuroStaticLibrary.__GetSplineRotationAtSplinePoint_Internal((Spline != null) ? Spline.NativePtr : IntPtr.Zero, PointIndex, CoordinateSpace);
		}

		// Token: 0x0601DF11 RID: 122641 RVA: 0x002C4CB1 File Offset: 0x002C2EB1
		[NullableContext(2)]
		public static void GetSlotNamesByAnimMontage(UAnimMontage AnimMontage, ref TArray<FName> OutSlotNames)
		{
			UKuroStaticLibrary.__GetSlotNamesByAnimMontage_Internal((AnimMontage != null) ? AnimMontage.NativePtr : IntPtr.Zero, (OutSlotNames ?? new TArray<FName>()).NativePtr);
		}

		// Token: 0x0601DF12 RID: 122642
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetSlateApplicationCursorPos();

		// Token: 0x0601DF13 RID: 122643 RVA: 0x002C4CD8 File Offset: 0x002C2ED8
		public static TArray<UMovieSceneTrack> GetSequenceTracksForObjectBindingID([Nullable(2)] ALevelSequenceActor Actor, FName TagName)
		{
			return new TArray<UMovieSceneTrack>(UKuroStaticLibrary.__GetSequenceTracksForObjectBindingID_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, TagName), null);
		}

		// Token: 0x0601DF14 RID: 122644 RVA: 0x002C4CF6 File Offset: 0x002C2EF6
		public static string GetProcessorId()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetProcessorId_Internal());
		}

		// Token: 0x0601DF15 RID: 122645
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetPlatformTimeInSeconds();

		// Token: 0x0601DF16 RID: 122646
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetPIEStartTimeInSeconds();

		// Token: 0x0601DF17 RID: 122647 RVA: 0x002C4D02 File Offset: 0x002C2F02
		public static string GetOSVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetOSVersion_Internal());
		}

		// Token: 0x0601DF18 RID: 122648 RVA: 0x002C4D0E File Offset: 0x002C2F0E
		[NullableContext(2)]
		[return: Nullable(1)]
		public static TArray<FVector> GetNavPointData(UObject WorldContextObject, int XNumber, int YNumber, int Dis, ANavigationData NavData, FVector Point, FVector QueryExtent, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass)
		{
			return new TArray<FVector>(UKuroStaticLibrary.__GetNavPointData_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, XNumber, YNumber, Dis, (NavData != null) ? NavData.NativePtr : IntPtr.Zero, Point, QueryExtent, FilterClass._NativePtr), null);
		}

		// Token: 0x0601DF19 RID: 122649 RVA: 0x002C4D4B File Offset: 0x002C2F4B
		public static string GetMacAddress()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetMacAddress_Internal());
		}

		// Token: 0x0601DF1A RID: 122650 RVA: 0x002C4D57 File Offset: 0x002C2F57
		public static void GetLocalHostAddresses([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> OutAddresses, bool bAppendPort = false)
		{
			UKuroStaticLibrary.__GetLocalHostAddresses_Internal((OutAddresses ?? new TArray<string>()).NativePtr, bAppendPort);
		}

		// Token: 0x0601DF1B RID: 122651 RVA: 0x002C4D6F File Offset: 0x002C2F6F
		[NullableContext(2)]
		public static bool GetLocalAdapterAddressesUint32(ref TArray<int> OutAddresses)
		{
			return UKuroStaticLibrary.__GetLocalAdapterAddressesUint32_Internal((OutAddresses ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x0601DF1C RID: 122652 RVA: 0x002C4D86 File Offset: 0x002C2F86
		[NullableContext(2)]
		public static AActor GetLevelPrefabShowActor(AActor Actor)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroStaticLibrary.__GetLevelPrefabShowActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601DF1D RID: 122653 RVA: 0x002C4DA2 File Offset: 0x002C2FA2
		public static string GetLevelPath([Nullable(2)] UObject WorldContextObject)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetLevelPath_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601DF1E RID: 122654 RVA: 0x002C4DBE File Offset: 0x002C2FBE
		public static string GetGPUInfo()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetGPUInfo_Internal());
		}

		// Token: 0x0601DF1F RID: 122655 RVA: 0x002C4DCA File Offset: 0x002C2FCA
		[NullableContext(2)]
		public static UGameViewportClient GetGameViewPort()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameViewportClient>(UKuroStaticLibrary.__GetGameViewPort_Internal());
		}

		// Token: 0x0601DF20 RID: 122656 RVA: 0x002C4DD6 File Offset: 0x002C2FD6
		[NullableContext(2)]
		public static FVector GetFirstLocationFromSeqTrack(UMovieScene3DTransformTrack TransformTrack)
		{
			return UKuroStaticLibrary.__GetFirstLocationFromSeqTrack_Internal((TransformTrack != null) ? TransformTrack.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601DF21 RID: 122657 RVA: 0x002C4DF0 File Offset: 0x002C2FF0
		public unsafe static TArray<string> GetFilesRecursive(string Path, string Filter, bool Files, bool Directories)
		{
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Filter);
			TArray<string> result = new TArray<string>(UKuroStaticLibrary.__GetFilesRecursive_Internal(fstring, fstring2, Files, Directories), null);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0601DF22 RID: 122658 RVA: 0x002C4E30 File Offset: 0x002C3030
		public unsafe static TArray<string> GetFiles(string Path, string Extension)
		{
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Extension);
			TArray<string> result = new TArray<string>(UKuroStaticLibrary.__GetFiles_Internal(fstring, fstring2), null);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0601DF23 RID: 122659 RVA: 0x002C4E6C File Offset: 0x002C306C
		public unsafe static string GetFileModificationTime(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetFileModificationTime_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DF24 RID: 122660 RVA: 0x002C4E98 File Offset: 0x002C3098
		public unsafe static string GetFileCreationTime(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetFileCreationTime_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DF25 RID: 122661 RVA: 0x002C4EC4 File Offset: 0x002C30C4
		public unsafe static string GetFileAccessTime(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetFileAccessTime_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DF26 RID: 122662 RVA: 0x002C4EED File Offset: 0x002C30ED
		[NullableContext(2)]
		public static bool GetEnableMobileLowStreaming(ULevelSequence Sequence)
		{
			return UKuroStaticLibrary.__GetEnableMobileLowStreaming_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601DF27 RID: 122663 RVA: 0x002C4F04 File Offset: 0x002C3104
		public static string GetDiskSerialNo()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetDiskSerialNo_Internal());
		}

		// Token: 0x0601DF28 RID: 122664 RVA: 0x002C4F10 File Offset: 0x002C3110
		public unsafe static TArray<string> GetDirectories(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			TArray<string> result = new TArray<string>(UKuroStaticLibrary.__GetDirectories_Internal(fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DF29 RID: 122665 RVA: 0x002C4F3A File Offset: 0x002C313A
		public static string GetDeviceCPU()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetDeviceCPU_Internal());
		}

		// Token: 0x0601DF2A RID: 122666 RVA: 0x002C4F46 File Offset: 0x002C3146
		[NullableContext(2)]
		public static UObject GetDefaultObject(UClassStackOnlyPtr Class)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKuroStaticLibrary.__GetDefaultObject_Internal(Class._NativePtr));
		}

		// Token: 0x0601DF2B RID: 122667
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetCurCPUFrequency();

		// Token: 0x0601DF2C RID: 122668 RVA: 0x002C4F58 File Offset: 0x002C3158
		public static string GetCultureRegion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetCultureRegion_Internal());
		}

		// Token: 0x0601DF2D RID: 122669 RVA: 0x002C4F64 File Offset: 0x002C3164
		public unsafe static void GetCreatureGenDirectoryByMap(string Path, int MapID, ref bool Exist, ref string Directory)
		{
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Directory);
			fixed (bool* ptr = &Exist)
			{
				void* ptr2 = (void*)ptr;
				UKuroStaticLibrary.__GetCreatureGenDirectoryByMap_Internal(fstring, MapID, ref Exist, ref fstring2);
				FString.NativeDestruct(&fstring, 1);
				Directory = FString.ToString(fstring2);
				FString.NativeDestruct(&fstring2, 1);
			}
		}

		// Token: 0x0601DF2E RID: 122670
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetCharacterAnimClass([Nullable(new byte[]
		{
			0,
			1
		})] in TSubclassOf<AActor> InActorClass, [Nullable(new byte[]
		{
			0,
			1
		})] ref TSubclassOf<UAnimInstance> OutAnimClass);

		// Token: 0x0601DF2F RID: 122671 RVA: 0x002C4FAE File Offset: 0x002C31AE
		[NullableContext(2)]
		public static bool GetCameraShakeInfo([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> CameraShakeClass, ref FCameraShakeInfo OutInfo)
		{
			return UKuroStaticLibrary.__GetCameraShakeInfo_Internal(CameraShakeClass._NativePtr, (OutInfo ?? new FCameraShakeInfo()).NativePtr);
		}

		// Token: 0x0601DF30 RID: 122672 RVA: 0x002C4FCB File Offset: 0x002C31CB
		public static string GetBlueprintCallstack()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetBlueprintCallstack_Internal());
		}

		// Token: 0x0601DF31 RID: 122673
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetBatteryLevel();

		// Token: 0x0601DF32 RID: 122674 RVA: 0x002C4FD7 File Offset: 0x002C31D7
		public static string GetBaseBoardInfo()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetBaseBoardInfo_Internal());
		}

		// Token: 0x0601DF33 RID: 122675 RVA: 0x002C4FE3 File Offset: 0x002C31E3
		[NullableContext(2)]
		public static void GetAnimSequencesByAnimMontage(UAnimMontage AnimMontage, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UAnimSequenceBase> OutAnimSequences)
		{
			UKuroStaticLibrary.__GetAnimSequencesByAnimMontage_Internal((AnimMontage != null) ? AnimMontage.NativePtr : IntPtr.Zero, (OutAnimSequences ?? new TArray<UAnimSequenceBase>()).NativePtr);
		}

		// Token: 0x0601DF34 RID: 122676 RVA: 0x002C500A File Offset: 0x002C320A
		[NullableContext(2)]
		public static void GetAnimSequenceNotifies(UAnimSequenceBase AnimSequence, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FAnimNotifyEvent> OutNotifies)
		{
			UKuroStaticLibrary.__GetAnimSequenceNotifies_Internal((AnimSequence != null) ? AnimSequence.NativePtr : IntPtr.Zero, (OutNotifies ?? new TArray<FAnimNotifyEvent>()).NativePtr);
		}

		// Token: 0x0601DF35 RID: 122677 RVA: 0x002C5031 File Offset: 0x002C3231
		[NullableContext(2)]
		public static void GetAnimMontageNotifies(UAnimMontage AnimMontage, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FAnimNotifyEvent> OutNotifies)
		{
			UKuroStaticLibrary.__GetAnimMontageNotifies_Internal((AnimMontage != null) ? AnimMontage.NativePtr : IntPtr.Zero, (OutNotifies ?? new TArray<FAnimNotifyEvent>()).NativePtr);
		}

		// Token: 0x0601DF36 RID: 122678 RVA: 0x002C5058 File Offset: 0x002C3258
		[NullableContext(2)]
		public static void GetAnimAssetsByAnimInstance(UAnimInstance InAnimInstance, [Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<UAnimationAsset> OutAnimationAssets)
		{
			UKuroStaticLibrary.__GetAnimAssetsByAnimInstance_Internal((InAnimInstance != null) ? InAnimInstance.NativePtr : IntPtr.Zero, (OutAnimationAssets ?? new TSet<UAnimationAsset>()).NativeSetPtr);
		}

		// Token: 0x0601DF37 RID: 122679 RVA: 0x002C5080 File Offset: 0x002C3280
		public unsafe static void GetAnimAssetsByAnimBlueprintClass([Nullable(new byte[]
		{
			0,
			1
		})] in TSubclassOf<UAnimInstance> InAnimClass, [Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<UAnimationAsset> OutAnimationAssets)
		{
			fixed (TSubclassOf<UAnimInstance>* ptr = &InAnimClass)
			{
				void* ptr2 = (void*)ptr;
				UKuroStaticLibrary.__GetAnimAssetsByAnimBlueprintClass_Internal(InAnimClass._NativePtr, (OutAnimationAssets ?? new TSet<UAnimationAsset>()).NativeSetPtr);
			}
		}

		// Token: 0x0601DF38 RID: 122680 RVA: 0x002C50B0 File Offset: 0x002C32B0
		[NullableContext(2)]
		public static void GetAnimAssets(UAnimBlueprint InAnimBlueprint, [Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<UAnimationAsset> OutAnimationAssets)
		{
			UKuroStaticLibrary.__GetAnimAssets_Internal((InAnimBlueprint != null) ? InAnimBlueprint.NativePtr : IntPtr.Zero, (OutAnimationAssets ?? new TSet<UAnimationAsset>()).NativeSetPtr);
		}

		// Token: 0x0601DF39 RID: 122681 RVA: 0x002C50D7 File Offset: 0x002C32D7
		public static TArray<AActor> GetActorsOnLevelInstance([Nullable(2)] ALevelInstance LevelInstance)
		{
			return new TArray<AActor>(UKuroStaticLibrary.__GetActorsOnLevelInstance_Internal((LevelInstance != null) ? LevelInstance.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0601DF3A RID: 122682 RVA: 0x002C50F4 File Offset: 0x002C32F4
		[NullableContext(2)]
		public static AActor GetActorOfClassOnLevelInstance([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass, ALevelInstance LevelInstance)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroStaticLibrary.__GetActorOfClassOnLevelInstance_Internal(ActorClass._NativePtr, (LevelInstance != null) ? LevelInstance.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601DF3B RID: 122683 RVA: 0x002C5116 File Offset: 0x002C3316
		public static FDateTime FromUnixTimestamp(int Timestamp)
		{
			return new FDateTime(UKuroStaticLibrary.__FromUnixTimestamp_Internal(Timestamp), null);
		}

		// Token: 0x0601DF3C RID: 122684
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ForceGarbageCollection(bool bFullPurge = false);

		// Token: 0x0601DF3D RID: 122685 RVA: 0x002C5124 File Offset: 0x002C3324
		public unsafe static TArray<string> FindFilesSorted(string Path, string Extension)
		{
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Extension);
			TArray<string> result = new TArray<string>(UKuroStaticLibrary.__FindFilesSorted_Internal(fstring, fstring2), null);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0601DF3E RID: 122686 RVA: 0x002C5160 File Offset: 0x002C3360
		public unsafe static bool FileExists(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			bool result = UKuroStaticLibrary.__FileExists_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DF3F RID: 122687
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ExitGame(bool force);

		// Token: 0x0601DF40 RID: 122688 RVA: 0x002C5184 File Offset: 0x002C3384
		public unsafe static bool ExecuteFunctionByName([Nullable(2)] UObject Object, string FunctionName, ref string Result)
		{
			FString fstring = FString.AllocTemp(FunctionName);
			FString fstring2 = FString.AllocTemp(Result);
			bool result = UKuroStaticLibrary.__ExecuteFunctionByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, fstring, ref fstring2);
			FString.NativeDestruct(&fstring, 1);
			Result = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0601DF41 RID: 122689 RVA: 0x002C51D4 File Offset: 0x002C33D4
		public unsafe static bool ExecProcess(string URL, string Params, ref int ReturnCode, ref string OutStd, ref string OutErr)
		{
			FString fstring = FString.AllocTemp(URL);
			FString fstring2 = FString.AllocTemp(Params);
			FString fstring3 = FString.AllocTemp(OutStd);
			FString fstring4 = FString.AllocTemp(OutErr);
			fixed (int* ptr = &ReturnCode)
			{
				void* ptr2 = (void*)ptr;
				bool result = UKuroStaticLibrary.__ExecProcess_Internal(fstring, fstring2, ref ReturnCode, ref fstring3, ref fstring4);
				FString.NativeDestruct(&fstring, 1);
				FString.NativeDestruct(&fstring2, 1);
				OutStd = FString.ToString(fstring3);
				FString.NativeDestruct(&fstring3, 1);
				OutErr = FString.ToString(fstring4);
				FString.NativeDestruct(&fstring4, 1);
				return result;
			}
		}

		// Token: 0x0601DF42 RID: 122690 RVA: 0x002C524D File Offset: 0x002C344D
		[NullableContext(2)]
		public static bool EncompassesPoint(AVolume Volume, FVector Point, float SphereRadius = 0f)
		{
			return UKuroStaticLibrary.__EncompassesPoint_Internal((Volume != null) ? Volume.NativePtr : IntPtr.Zero, Point, SphereRadius);
		}

		// Token: 0x0601DF43 RID: 122691 RVA: 0x002C5268 File Offset: 0x002C3468
		public unsafe static void DumpStackTrace(string Str)
		{
			FString fstring = FString.AllocTemp(Str);
			UKuroStaticLibrary.__DumpStackTrace_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DF44 RID: 122692 RVA: 0x002C528C File Offset: 0x002C348C
		[NullableContext(2)]
		public static void DoGameViewPortMouseEnter(UGameViewportClient InViewport, int x, int y)
		{
			UKuroStaticLibrary.__DoGameViewPortMouseEnter_Internal((InViewport != null) ? InViewport.NativePtr : IntPtr.Zero, x, y);
		}

		// Token: 0x0601DF45 RID: 122693 RVA: 0x002C52A8 File Offset: 0x002C34A8
		public unsafe static bool DirectoryExists(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			bool result = UKuroStaticLibrary.__DirectoryExists_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DF46 RID: 122694 RVA: 0x002C52CC File Offset: 0x002C34CC
		[NullableContext(2)]
		public static void DestroyObject(UObject Object)
		{
			UKuroStaticLibrary.__DestroyObject_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601DF47 RID: 122695 RVA: 0x002C52E4 File Offset: 0x002C34E4
		public unsafe static bool DeleteFolder(string Path, bool bRequireExists = false, bool bTree = false)
		{
			FString fstring = FString.AllocTemp(Path);
			bool result = UKuroStaticLibrary.__DeleteFolder_Internal(fstring, bRequireExists, bTree);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DF48 RID: 122696 RVA: 0x002C530C File Offset: 0x002C350C
		public unsafe static bool DeleteFile(string Path, bool bRequireExists = false, bool bEvenReadOnly = false, bool bQuiet = false)
		{
			FString fstring = FString.AllocTemp(Path);
			bool result = UKuroStaticLibrary.__DeleteFile_Internal(fstring, bRequireExists, bEvenReadOnly, bQuiet);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DF49 RID: 122697 RVA: 0x002C5333 File Offset: 0x002C3533
		[NullableContext(2)]
		public static FVectorDouble D_GetFirstLocationFromSeqTrack(UMovieScene3DTransformTrack TransformTrack)
		{
			return UKuroStaticLibrary.__D_GetFirstLocationFromSeqTrack_Internal((TransformTrack != null) ? TransformTrack.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601DF4A RID: 122698 RVA: 0x002C534C File Offset: 0x002C354C
		public unsafe static bool CopyFile(string SourcePath, string DstPath)
		{
			FString fstring = FString.AllocTemp(SourcePath);
			FString fstring2 = FString.AllocTemp(DstPath);
			bool result = UKuroStaticLibrary.__CopyFile_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0601DF4B RID: 122699
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern TEnumAsByte<ETraceTypeQuery> ConvertToTraceType(ECollisionChannel InCollisionChannel);

		// Token: 0x0601DF4C RID: 122700
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern TEnumAsByte<EObjectTypeQuery> ConvertToObjectType(ECollisionChannel InCollisionChannel);

		// Token: 0x0601DF4D RID: 122701 RVA: 0x002C5384 File Offset: 0x002C3584
		[NullableContext(2)]
		public static void ClearPlayerInputCache(ref APlayerController PC)
		{
			APlayerController aplayerController = PC;
			IntPtr nativeObjectPtr = (aplayerController != null) ? aplayerController.NativePtr : IntPtr.Zero;
			UKuroStaticLibrary.__ClearPlayerInputCache_Internal(ref nativeObjectPtr);
			PC = BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerController>(nativeObjectPtr);
		}

		// Token: 0x0601DF4E RID: 122702
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearCustomGetTimeBetweenGarbageCollectionPassesDelegate();

		// Token: 0x0601DF4F RID: 122703 RVA: 0x002C53B3 File Offset: 0x002C35B3
		[NullableContext(2)]
		public static void BindDeviceLangChangeDelegate(in FDeviceLangChange Delegate)
		{
			FDeviceLangChange fdeviceLangChange = Delegate;
			UKuroStaticLibrary.__BindDeviceLangChangeDelegate_Internal((fdeviceLangChange != null) ? fdeviceLangChange.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601DF50 RID: 122704 RVA: 0x002C53C9 File Offset: 0x002C35C9
		[NullableContext(2)]
		public static void BindCustomGetTimeBetweenGarbageCollectionPassesDelegate(in FCustomGCTimeDelegate Delegate)
		{
			FCustomGCTimeDelegate fcustomGCTimeDelegate = Delegate;
			UKuroStaticLibrary.__BindCustomGetTimeBetweenGarbageCollectionPassesDelegate_Internal((fcustomGCTimeDelegate != null) ? fcustomGCTimeDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601DF51 RID: 122705 RVA: 0x002C53E0 File Offset: 0x002C35E0
		public unsafe static string Base64EncodeWithSpecifyCharWithConvertToUTF8(string inString, string SpecifyChar)
		{
			FString fstring = FString.AllocTemp(inString);
			FString fstring2 = FString.AllocTemp(SpecifyChar);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__Base64EncodeWithSpecifyCharWithConvertToUTF8_Internal(fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0601DF52 RID: 122706 RVA: 0x002C541C File Offset: 0x002C361C
		public unsafe static string Base64EncodeWithSpecifyChar([Nullable(2)] in TArray<byte> ByteArray, string SpecifyChar)
		{
			FString fstring = FString.AllocTemp(SpecifyChar);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__Base64EncodeWithSpecifyChar_Internal((ByteArray ?? new TArray<byte>()).NativePtr, fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DF53 RID: 122707 RVA: 0x002C5458 File Offset: 0x002C3658
		public unsafe static string Base64EncodeWithConvertToUTF8(string inString)
		{
			FString fstring = FString.AllocTemp(inString);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__Base64EncodeWithConvertToUTF8_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DF54 RID: 122708 RVA: 0x002C5481 File Offset: 0x002C3681
		public static string Base64EncodeBinary(in FArrayBuffer InBuffer)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__Base64EncodeBinary_Internal(InBuffer));
		}

		// Token: 0x0601DF55 RID: 122709 RVA: 0x002C5490 File Offset: 0x002C3690
		public unsafe static string Base64Encode(string inString)
		{
			FString fstring = FString.AllocTemp(inString);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__Base64Encode_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DF56 RID: 122710 RVA: 0x002C54BC File Offset: 0x002C36BC
		public unsafe static string Base64Decode(string inString)
		{
			FString fstring = FString.AllocTemp(inString);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__Base64Decode_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DF57 RID: 122711 RVA: 0x002C54E5 File Offset: 0x002C36E5
		[NullableContext(2)]
		public static FArrayBuffer ArrayToBuffer(ref TArray<byte> InArray)
		{
			return UKuroStaticLibrary.__ArrayToBuffer_Internal((InArray ?? new TArray<byte>()).NativePtr);
		}

		// Token: 0x0601DF58 RID: 122712 RVA: 0x002C54FC File Offset: 0x002C36FC
		[NullableContext(2)]
		public static void ApplyChangeToBlueprint(AActor Actor)
		{
			UKuroStaticLibrary.__ApplyChangeToBlueprint_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601DF59 RID: 122713 RVA: 0x002C5513 File Offset: 0x002C3713
		[NullableContext(2)]
		public static void AddToRoot(UObject InObject)
		{
			UKuroStaticLibrary.__AddToRoot_Internal((InObject != null) ? InObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601DF5A RID: 122714
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WriteStringToFile_Internal(in FString SaveText, in FString FileName, bool bPublic, bool bWithBom);

		// Token: 0x0601DF5B RID: 122715
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnRegisterCustomCommandProcessor_Internal(in FString Category);

		// Token: 0x0601DF5C RID: 122716
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __ToUnixTimestamp_Internal(IntPtr InDataTime);

		// Token: 0x0601DF5D RID: 122717
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ToggleSequenceNodeActiveByTag_Internal(IntPtr Actor, FName TagName, bool bActive);

		// Token: 0x0601DF5E RID: 122718
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SynchronizeProperties_Internal(IntPtr InWidget);

		// Token: 0x0601DF5F RID: 122719
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAllMontagesBySlotName_Internal(IntPtr UAnimInstance, FName InSlotName, float InBlendOutTime);

		// Token: 0x0601DF60 RID: 122720
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnActorFromAnother_Internal(IntPtr Actor, IntPtr Parent);

		// Token: 0x0601DF61 RID: 122721
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetThreadPriorityAndPolicyAndAffinity_Internal(in FString ThreadName, int Priority, int Policy, int AffinityHigh, int AffinityLow);

		// Token: 0x0601DF62 RID: 122722
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetThreadPriorityAndPolicy_Internal(in FString ThreadName, int Priority, int Policy);

		// Token: 0x0601DF63 RID: 122723
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetThreadPriority_Internal(in FString ThreadName, int Priority);

		// Token: 0x0601DF64 RID: 122724
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetThreadPolicy_Internal(in FString ThreadName, int Policy);

		// Token: 0x0601DF65 RID: 122725
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetThreadAffinity_Internal(in FString ThreadName, int AffinityHigh, int AffinityLow);

		// Token: 0x0601DF66 RID: 122726
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStaticMeshVelocity_Internal(IntPtr Actors, FVector NewVelocity);

		// Token: 0x0601DF67 RID: 122727
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSplinePointsWithType_Internal(IntPtr Spline, IntPtr Points, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, TEnumAsByte<ESplinePointType> Type, bool bUpdateSpline);

		// Token: 0x0601DF68 RID: 122728
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMontageANIndex_Internal(IntPtr AnimMontage);

		// Token: 0x0601DF69 RID: 122729
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInputKeyDeadZone_Internal(IntPtr world, int playerIndex, IntPtr key, float deadZone);

		// Token: 0x0601DF6A RID: 122730
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConsoleVariableWithCurrentPriority_String_Internal(in FString InCVar, in FString InValue);

		// Token: 0x0601DF6B RID: 122731
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConsoleVariableWithCurrentPriority_Int_Internal(in FString InCVar, int InValue);

		// Token: 0x0601DF6C RID: 122732
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConsoleVariableWithCurrentPriority_Float_Internal(in FString InCVar, float InValue);

		// Token: 0x0601DF6D RID: 122733
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBaseAndSaveBaseLocation_Internal(IntPtr CharacterMovementComp, IntPtr NewBase);

		// Token: 0x0601DF6E RID: 122734
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorPermanent_Internal(IntPtr Actor, bool bIsPermanent, bool bWithAllChildren);

		// Token: 0x0601DF6F RID: 122735
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorModify_Internal(IntPtr Actor);

		// Token: 0x0601DF70 RID: 122736
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SaveStringToFile_Internal(in FString SaveText, in FString FileName, bool bWithBom);

		// Token: 0x0601DF71 RID: 122737
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SaveBufferToFile_Internal(in FString Path, in FArrayBuffer InBuffer);

		// Token: 0x0601DF72 RID: 122738
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveFromRoot_Internal(IntPtr InObject);

		// Token: 0x0601DF73 RID: 122739
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterCustomCommandProcessor_Internal(in FString Category, IntPtr Processor);

		// Token: 0x0601DF74 RID: 122740
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PingGateWay_Internal(in FString Address, int Port, float Timeout, in FString Payload, IntPtr PingDelegate);

		// Token: 0x0601DF75 RID: 122741
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PerceptionConfigureSense_Internal(IntPtr AIPerception, IntPtr AISenseConfig);

		// Token: 0x0601DF76 RID: 122742
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Md5HashUTF8String_Internal(in FString inString);

		// Token: 0x0601DF77 RID: 122743
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Md5HashAnsiString_Internal(in FString inString);

		// Token: 0x0601DF78 RID: 122744
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MakeDirectory_Internal(in FString Path, bool bTree);

		// Token: 0x0601DF79 RID: 122745
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadFileToStringArray_Internal(in FString FileRevisionPath);

		// Token: 0x0601DF7A RID: 122746
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LoadFileToString_Internal(ref FString Result, in FString Filename);

		// Token: 0x0601DF7B RID: 122747
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LoadFileToArrayPriorPakChunk_Internal(in FString Path, int PakchunkIndex, IntPtr OutArray);

		// Token: 0x0601DF7C RID: 122748
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LoadFileToArray_Internal(in FString Path, IntPtr OutArray);

		// Token: 0x0601DF7D RID: 122749
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadFilesRecursive_Internal(in FString Path, in FString Filter, bool Files, bool Directories);

		// Token: 0x0601DF7E RID: 122750
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __KuroFormatText_Internal(in FString Format, IntPtr Parameters);

		// Token: 0x0601DF7F RID: 122751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWorldTearingDown_Internal(IntPtr World);

		// Token: 0x0601DF80 RID: 122752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsObjectClassByName_Internal(IntPtr Object, FName ClassName);

		// Token: 0x0601DF81 RID: 122753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMontageContainGivenAnimNotify_Internal(IntPtr AnimMontage, IntPtr CheckClassNames);

		// Token: 0x0601DF82 RID: 122754
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsModuleLoaded_Internal(in FString ModelName);

		// Token: 0x0601DF83 RID: 122755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEditor_Internal(IntPtr WorldContextObject);

		// Token: 0x0601DF84 RID: 122756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __IcmpPing_Internal(in FString IpAddress, float Timeout, IntPtr InDelegate);

		// Token: 0x0601DF85 RID: 122757
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __HashStringWithSHA1_Internal(in FString inString);

		// Token: 0x0601DF86 RID: 122758
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetWholeStatUnitInfo_Internal(float Timespan);

		// Token: 0x0601DF87 RID: 122759
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetVendorInfo_Internal();

		// Token: 0x0601DF88 RID: 122760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTrackByClass_Internal(IntPtr Tracks, IntPtr Class);

		// Token: 0x0601DF89 RID: 122761
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSysUUID_Internal();

		// Token: 0x0601DF8A RID: 122762
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetStatUnitInfo_Internal();

		// Token: 0x0601DF8B RID: 122763
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetSplineRotationAtSplinePoint_Internal(IntPtr Spline, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601DF8C RID: 122764
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSlotNamesByAnimMontage_Internal(IntPtr AnimMontage, IntPtr OutSlotNames);

		// Token: 0x0601DF8D RID: 122765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSequenceTracksForObjectBindingID_Internal(IntPtr Actor, FName TagName);

		// Token: 0x0601DF8E RID: 122766
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetProcessorId_Internal();

		// Token: 0x0601DF8F RID: 122767
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetOSVersion_Internal();

		// Token: 0x0601DF90 RID: 122768
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNavPointData_Internal(IntPtr WorldContextObject, int XNumber, int YNumber, int Dis, IntPtr NavData, FVector Point, FVector QueryExtent, IntPtr FilterClass);

		// Token: 0x0601DF91 RID: 122769
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetMacAddress_Internal();

		// Token: 0x0601DF92 RID: 122770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetLocalHostAddresses_Internal(IntPtr OutAddresses, bool bAppendPort);

		// Token: 0x0601DF93 RID: 122771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLocalAdapterAddressesUint32_Internal(IntPtr OutAddresses);

		// Token: 0x0601DF94 RID: 122772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLevelPrefabShowActor_Internal(IntPtr Actor);

		// Token: 0x0601DF95 RID: 122773
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetLevelPath_Internal(IntPtr WorldContextObject);

		// Token: 0x0601DF96 RID: 122774
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetGPUInfo_Internal();

		// Token: 0x0601DF97 RID: 122775
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGameViewPort_Internal();

		// Token: 0x0601DF98 RID: 122776
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetFirstLocationFromSeqTrack_Internal(IntPtr TransformTrack);

		// Token: 0x0601DF99 RID: 122777
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetFilesRecursive_Internal(in FString Path, in FString Filter, bool Files, bool Directories);

		// Token: 0x0601DF9A RID: 122778
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetFiles_Internal(in FString Path, in FString Extension);

		// Token: 0x0601DF9B RID: 122779
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetFileModificationTime_Internal(in FString Path);

		// Token: 0x0601DF9C RID: 122780
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetFileCreationTime_Internal(in FString Path);

		// Token: 0x0601DF9D RID: 122781
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetFileAccessTime_Internal(in FString Path);

		// Token: 0x0601DF9E RID: 122782
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetEnableMobileLowStreaming_Internal(IntPtr Sequence);

		// Token: 0x0601DF9F RID: 122783
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDiskSerialNo_Internal();

		// Token: 0x0601DFA0 RID: 122784
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDirectories_Internal(in FString Path);

		// Token: 0x0601DFA1 RID: 122785
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDeviceCPU_Internal();

		// Token: 0x0601DFA2 RID: 122786
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDefaultObject_Internal(IntPtr Class);

		// Token: 0x0601DFA3 RID: 122787
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCultureRegion_Internal();

		// Token: 0x0601DFA4 RID: 122788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetCreatureGenDirectoryByMap_Internal(in FString Path, int MapID, ref bool Exist, ref FString Directory);

		// Token: 0x0601DFA5 RID: 122789
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCameraShakeInfo_Internal(IntPtr CameraShakeClass, IntPtr OutInfo);

		// Token: 0x0601DFA6 RID: 122790
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetBlueprintCallstack_Internal();

		// Token: 0x0601DFA7 RID: 122791
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetBaseBoardInfo_Internal();

		// Token: 0x0601DFA8 RID: 122792
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAnimSequencesByAnimMontage_Internal(IntPtr AnimMontage, IntPtr OutAnimSequences);

		// Token: 0x0601DFA9 RID: 122793
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAnimSequenceNotifies_Internal(IntPtr AnimSequence, IntPtr OutNotifies);

		// Token: 0x0601DFAA RID: 122794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAnimMontageNotifies_Internal(IntPtr AnimMontage, IntPtr OutNotifies);

		// Token: 0x0601DFAB RID: 122795
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAnimAssetsByAnimInstance_Internal(IntPtr InAnimInstance, IntPtr OutAnimationAssets);

		// Token: 0x0601DFAC RID: 122796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAnimAssetsByAnimBlueprintClass_Internal(in IntPtr InAnimClass, IntPtr OutAnimationAssets);

		// Token: 0x0601DFAD RID: 122797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAnimAssets_Internal(IntPtr InAnimBlueprint, IntPtr OutAnimationAssets);

		// Token: 0x0601DFAE RID: 122798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActorsOnLevelInstance_Internal(IntPtr LevelInstance);

		// Token: 0x0601DFAF RID: 122799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActorOfClassOnLevelInstance_Internal(IntPtr ActorClass, IntPtr LevelInstance);

		// Token: 0x0601DFB0 RID: 122800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FromUnixTimestamp_Internal(int Timestamp);

		// Token: 0x0601DFB1 RID: 122801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindFilesSorted_Internal(in FString Path, in FString Extension);

		// Token: 0x0601DFB2 RID: 122802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FileExists_Internal(in FString Path);

		// Token: 0x0601DFB3 RID: 122803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ExecuteFunctionByName_Internal(IntPtr Object, in FString FunctionName, ref FString Result);

		// Token: 0x0601DFB4 RID: 122804
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ExecProcess_Internal(in FString URL, in FString Params, ref int ReturnCode, ref FString OutStd, ref FString OutErr);

		// Token: 0x0601DFB5 RID: 122805
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EncompassesPoint_Internal(IntPtr Volume, FVector Point, float SphereRadius);

		// Token: 0x0601DFB6 RID: 122806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DumpStackTrace_Internal(in FString Str);

		// Token: 0x0601DFB7 RID: 122807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DoGameViewPortMouseEnter_Internal(IntPtr InViewport, int x, int y);

		// Token: 0x0601DFB8 RID: 122808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DirectoryExists_Internal(in FString Path);

		// Token: 0x0601DFB9 RID: 122809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyObject_Internal(IntPtr Object);

		// Token: 0x0601DFBA RID: 122810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DeleteFolder_Internal(in FString Path, bool bRequireExists, bool bTree);

		// Token: 0x0601DFBB RID: 122811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DeleteFile_Internal(in FString Path, bool bRequireExists, bool bEvenReadOnly, bool bQuiet);

		// Token: 0x0601DFBC RID: 122812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetFirstLocationFromSeqTrack_Internal(IntPtr TransformTrack);

		// Token: 0x0601DFBD RID: 122813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CopyFile_Internal(in FString SourcePath, in FString DstPath);

		// Token: 0x0601DFBE RID: 122814
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearPlayerInputCache_Internal(ref IntPtr PC);

		// Token: 0x0601DFBF RID: 122815
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindDeviceLangChangeDelegate_Internal(IntPtr Delegate);

		// Token: 0x0601DFC0 RID: 122816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindCustomGetTimeBetweenGarbageCollectionPassesDelegate_Internal(IntPtr Delegate);

		// Token: 0x0601DFC1 RID: 122817
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Base64EncodeWithSpecifyCharWithConvertToUTF8_Internal(in FString inString, in FString SpecifyChar);

		// Token: 0x0601DFC2 RID: 122818
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Base64EncodeWithSpecifyChar_Internal(IntPtr ByteArray, in FString SpecifyChar);

		// Token: 0x0601DFC3 RID: 122819
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Base64EncodeWithConvertToUTF8_Internal(in FString inString);

		// Token: 0x0601DFC4 RID: 122820
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Base64EncodeBinary_Internal(in FArrayBuffer InBuffer);

		// Token: 0x0601DFC5 RID: 122821
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Base64Encode_Internal(in FString inString);

		// Token: 0x0601DFC6 RID: 122822
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Base64Decode_Internal(in FString inString);

		// Token: 0x0601DFC7 RID: 122823
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FArrayBuffer __ArrayToBuffer_Internal(IntPtr InArray);

		// Token: 0x0601DFC8 RID: 122824
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyChangeToBlueprint_Internal(IntPtr Actor);

		// Token: 0x0601DFC9 RID: 122825
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddToRoot_Internal(IntPtr InObject);

		// Token: 0x0601DFCA RID: 122826 RVA: 0x002C552A File Offset: 0x002C372A
		static UKuroStaticLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroStaticLibrary");
		}

		// Token: 0x0601DFCB RID: 122827 RVA: 0x002C5538 File Offset: 0x002C3738
		protected UKuroStaticLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010342 RID: 66370
		public new const string __ObjectPath = "/Script/KuroUtility.KuroStaticLibrary";

		// Token: 0x04010343 RID: 66371
		private static IntPtr _ClassPtr;

		// Token: 0x04010344 RID: 66372
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
