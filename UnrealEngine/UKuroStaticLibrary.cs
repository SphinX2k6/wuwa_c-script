using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005E7 RID: 1511
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroStaticLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroStaticLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600854F RID: 34127 RVA: 0x000C5E1B File Offset: 0x000C401B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroStaticLibrary._ClassPtr;
		}

		// Token: 0x06008550 RID: 34128 RVA: 0x000C5E28 File Offset: 0x000C4028
		public UKuroStaticLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroStaticLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008551 RID: 34129 RVA: 0x000C5E50 File Offset: 0x000C4050
		public UKuroStaticLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroStaticLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008552 RID: 34130 RVA: 0x000C5E84 File Offset: 0x000C4084
		public unsafe static bool WriteStringToFile(string SaveText, string FileName, bool bPublic = false, bool bWithBom = false)
		{
			FString fstring = FString.AllocTemp(SaveText);
			FString fstring2 = FString.AllocTemp(FileName);
			bool result = UKuroStaticLibrary.__WriteStringToFile_Internal(fstring, fstring2, bPublic, bWithBom);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06008553 RID: 34131 RVA: 0x000C5EBC File Offset: 0x000C40BC
		public unsafe static void UnRegisterCustomCommandProcessor(string Category)
		{
			FString fstring = FString.AllocTemp(Category);
			UKuroStaticLibrary.__UnRegisterCustomCommandProcessor_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06008554 RID: 34132
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnBindDeviceLangChangeDelegate();

		// Token: 0x06008555 RID: 34133 RVA: 0x000C5EE0 File Offset: 0x000C40E0
		[NullableContext(2)]
		public static int ToUnixTimestamp(FDateTime InDataTime)
		{
			return UKuroStaticLibrary.__ToUnixTimestamp_Internal((InDataTime ?? new FDateTime()).NativePtr);
		}

		// Token: 0x06008556 RID: 34134 RVA: 0x000C5EF6 File Offset: 0x000C40F6
		[NullableContext(2)]
		public static bool ToggleSequenceNodeActiveByTag(ALevelSequenceActor Actor, FName TagName, bool bActive)
		{
			return UKuroStaticLibrary.__ToggleSequenceNodeActiveByTag_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, TagName, bActive);
		}

		// Token: 0x06008557 RID: 34135 RVA: 0x000C5F0F File Offset: 0x000C410F
		[NullableContext(2)]
		public static void SynchronizeProperties(UWidget InWidget)
		{
			UKuroStaticLibrary.__SynchronizeProperties_Internal((InWidget != null) ? InWidget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008558 RID: 34136 RVA: 0x000C5F26 File Offset: 0x000C4126
		[NullableContext(2)]
		public static void StopAllMontagesBySlotName(UAnimInstance UAnimInstance, FName InSlotName, float InBlendOutTime)
		{
			UKuroStaticLibrary.__StopAllMontagesBySlotName_Internal((UAnimInstance != null) ? UAnimInstance.NativePtr : IntPtr.Zero, InSlotName, InBlendOutTime);
		}

		// Token: 0x06008559 RID: 34137 RVA: 0x000C5F3F File Offset: 0x000C413F
		[NullableContext(2)]
		public static AActor SpawnActorFromAnother(AActor Actor, AActor Parent = null)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroStaticLibrary.__SpawnActorFromAnother_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, (Parent != null) ? Parent.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600855A RID: 34138
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ShowSoftwareCursor(bool visible);

		// Token: 0x0600855B RID: 34139 RVA: 0x000C5F6C File Offset: 0x000C416C
		public unsafe static void SetThreadPriorityAndPolicyAndAffinity(string ThreadName, int Priority, int Policy, int AffinityHigh, int AffinityLow)
		{
			FString fstring = FString.AllocTemp(ThreadName);
			UKuroStaticLibrary.__SetThreadPriorityAndPolicyAndAffinity_Internal(fstring, Priority, Policy, AffinityHigh, AffinityLow);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600855C RID: 34140 RVA: 0x000C5F98 File Offset: 0x000C4198
		public unsafe static void SetThreadPriorityAndPolicy(string ThreadName, int Priority, int Policy)
		{
			FString fstring = FString.AllocTemp(ThreadName);
			UKuroStaticLibrary.__SetThreadPriorityAndPolicy_Internal(fstring, Priority, Policy);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600855D RID: 34141 RVA: 0x000C5FC0 File Offset: 0x000C41C0
		public unsafe static void SetThreadPriority(string ThreadName, int Priority)
		{
			FString fstring = FString.AllocTemp(ThreadName);
			UKuroStaticLibrary.__SetThreadPriority_Internal(fstring, Priority);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600855E RID: 34142 RVA: 0x000C5FE8 File Offset: 0x000C41E8
		public unsafe static void SetThreadPolicy(string ThreadName, int Policy)
		{
			FString fstring = FString.AllocTemp(ThreadName);
			UKuroStaticLibrary.__SetThreadPolicy_Internal(fstring, Policy);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600855F RID: 34143 RVA: 0x000C6010 File Offset: 0x000C4210
		public unsafe static void SetThreadAffinity(string ThreadName, int AffinityHigh, int AffinityLow)
		{
			FString fstring = FString.AllocTemp(ThreadName);
			UKuroStaticLibrary.__SetThreadAffinity_Internal(fstring, AffinityHigh, AffinityLow);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06008560 RID: 34144 RVA: 0x000C6036 File Offset: 0x000C4236
		public static void SetStaticMeshVelocity([Nullable(new byte[]
		{
			2,
			1
		})] TArray<AActor> Actors, FVector NewVelocity)
		{
			UKuroStaticLibrary.__SetStaticMeshVelocity_Internal((Actors ?? new TArray<AActor>()).NativePtr, NewVelocity);
		}

		// Token: 0x06008561 RID: 34145 RVA: 0x000C604D File Offset: 0x000C424D
		[NullableContext(2)]
		public static void SetSplinePointsWithType(USplineComponent Spline, in TArray<FVector> Points, ESplineCoordinateSpace CoordinateSpace, ESplinePointType Type, bool bUpdateSpline = true)
		{
			UKuroStaticLibrary.__SetSplinePointsWithType_Internal((Spline != null) ? Spline.NativePtr : IntPtr.Zero, (Points ?? new TArray<FVector>()).NativePtr, CoordinateSpace, Type, bUpdateSpline);
		}

		// Token: 0x06008562 RID: 34146 RVA: 0x000C6082 File Offset: 0x000C4282
		[NullableContext(2)]
		public static void SetMontageANIndex(UAnimMontage AnimMontage)
		{
			UKuroStaticLibrary.__SetMontageANIndex_Internal((AnimMontage != null) ? AnimMontage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008563 RID: 34147 RVA: 0x000C6099 File Offset: 0x000C4299
		[NullableContext(2)]
		public static void SetInputKeyDeadZone(UObject world, int playerIndex, FKey key, float deadZone)
		{
			UKuroStaticLibrary.__SetInputKeyDeadZone_Internal((world != null) ? world.NativePtr : IntPtr.Zero, playerIndex, (key ?? new FKey()).NativePtr, deadZone);
		}

		// Token: 0x06008564 RID: 34148
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetHttpThreadIdleMinimumSleepTimeInSeconds(float InHttpThreadIdleMinimumSleepTimeInSeconds);

		// Token: 0x06008565 RID: 34149
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetHttpThreadActiveMinimumSleepTimeInSeconds(float InHttpThreadActiveMinimumSleepTimeInSeconds);

		// Token: 0x06008566 RID: 34150
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetHangDuration(float HangDuration);

		// Token: 0x06008567 RID: 34151
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetHangAssertFlag(bool bAssertFlag);

		// Token: 0x06008568 RID: 34152
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGameThreadAffinity(bool bIsInFighting);

		// Token: 0x06008569 RID: 34153
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEditorWidgetSkipTick(bool bSkipTick);

		// Token: 0x0600856A RID: 34154
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetCursorVisibility(bool visible);

		// Token: 0x0600856B RID: 34155 RVA: 0x000C60C4 File Offset: 0x000C42C4
		public unsafe static void SetConsoleVariableWithCurrentPriority_String(string InCVar, string InValue)
		{
			FString fstring = FString.AllocTemp(InCVar);
			FString fstring2 = FString.AllocTemp(InValue);
			UKuroStaticLibrary.__SetConsoleVariableWithCurrentPriority_String_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0600856C RID: 34156 RVA: 0x000C60FC File Offset: 0x000C42FC
		public unsafe static void SetConsoleVariableWithCurrentPriority_Int(string InCVar, int InValue)
		{
			FString fstring = FString.AllocTemp(InCVar);
			UKuroStaticLibrary.__SetConsoleVariableWithCurrentPriority_Int_Internal(fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600856D RID: 34157 RVA: 0x000C6124 File Offset: 0x000C4324
		public unsafe static void SetConsoleVariableWithCurrentPriority_Float(string InCVar, float InValue)
		{
			FString fstring = FString.AllocTemp(InCVar);
			UKuroStaticLibrary.__SetConsoleVariableWithCurrentPriority_Float_Internal(fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600856E RID: 34158 RVA: 0x000C6149 File Offset: 0x000C4349
		[NullableContext(2)]
		public static void SetBaseAndSaveBaseLocation(UCharacterMovementComponent CharacterMovementComp, UPrimitiveComponent NewBase)
		{
			UKuroStaticLibrary.__SetBaseAndSaveBaseLocation_Internal((CharacterMovementComp != null) ? CharacterMovementComp.NativePtr : IntPtr.Zero, (NewBase != null) ? NewBase.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600856F RID: 34159 RVA: 0x000C6170 File Offset: 0x000C4370
		[NullableContext(2)]
		public static void SetActorPermanent(AActor Actor, bool bIsPermanent, bool bWithAllChildren)
		{
			UKuroStaticLibrary.__SetActorPermanent_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, bIsPermanent, bWithAllChildren);
		}

		// Token: 0x06008570 RID: 34160 RVA: 0x000C6189 File Offset: 0x000C4389
		[NullableContext(2)]
		public static void SetActorModify(AActor Actor)
		{
			UKuroStaticLibrary.__SetActorModify_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008571 RID: 34161 RVA: 0x000C61A0 File Offset: 0x000C43A0
		public unsafe static bool SaveStringToFile(string SaveText, string FileName, bool bWithBom = false)
		{
			FString fstring = FString.AllocTemp(SaveText);
			FString fstring2 = FString.AllocTemp(FileName);
			bool result = UKuroStaticLibrary.__SaveStringToFile_Internal(fstring, fstring2, bWithBom);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06008572 RID: 34162 RVA: 0x000C61D8 File Offset: 0x000C43D8
		public unsafe static bool SaveBufferToFile(string Path, in FArrayBuffer InBuffer)
		{
			FString fstring = FString.AllocTemp(Path);
			bool result = UKuroStaticLibrary.__SaveBufferToFile_Internal(fstring, InBuffer);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06008573 RID: 34163
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetHttpMaxFlushTimeSeconds();

		// Token: 0x06008574 RID: 34164 RVA: 0x000C61FD File Offset: 0x000C43FD
		[NullableContext(2)]
		public static void RemoveFromRoot(UObject InObject)
		{
			UKuroStaticLibrary.__RemoveFromRoot_Internal((InObject != null) ? InObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008575 RID: 34165 RVA: 0x000C6214 File Offset: 0x000C4414
		public unsafe static void RegisterCustomCommandProcessor(string Category, [Nullable(2)] in FProcessCustomCommandDelegate Processor)
		{
			FString fstring = FString.AllocTemp(Category);
			FProcessCustomCommandDelegate fprocessCustomCommandDelegate = Processor;
			UKuroStaticLibrary.__RegisterCustomCommandProcessor_Internal(fstring, (fprocessCustomCommandDelegate != null) ? fprocessCustomCommandDelegate.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06008576 RID: 34166 RVA: 0x000C6248 File Offset: 0x000C4448
		public unsafe static void PingGateWay(string Address, int Port, float Timeout, string Payload, [Nullable(2)] in FKuroGateWayPingCallBack PingDelegate)
		{
			FString fstring = FString.AllocTemp(Address);
			FString fstring2 = FString.AllocTemp(Payload);
			FKuroGateWayPingCallBack fkuroGateWayPingCallBack = PingDelegate;
			UKuroStaticLibrary.__PingGateWay_Internal(fstring, Port, Timeout, fstring2, (fkuroGateWayPingCallBack != null) ? fkuroGateWayPingCallBack.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06008577 RID: 34167 RVA: 0x000C6290 File Offset: 0x000C4490
		public unsafe static string Md5HashUTF8String(string inString)
		{
			FString fstring = FString.AllocTemp(inString);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__Md5HashUTF8String_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06008578 RID: 34168 RVA: 0x000C62BC File Offset: 0x000C44BC
		public unsafe static string Md5HashAnsiString(string inString)
		{
			FString fstring = FString.AllocTemp(inString);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__Md5HashAnsiString_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06008579 RID: 34169 RVA: 0x000C62E8 File Offset: 0x000C44E8
		public unsafe static bool MakeDirectory(string Path, bool bTree = false)
		{
			FString fstring = FString.AllocTemp(Path);
			bool result = UKuroStaticLibrary.__MakeDirectory_Internal(fstring, bTree);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600857A RID: 34170 RVA: 0x000C6310 File Offset: 0x000C4510
		public unsafe static TArray<string> LoadFileToStringArray(string FileRevisionPath)
		{
			FString fstring = FString.AllocTemp(FileRevisionPath);
			TArray<string> result = new TArray<string>(UKuroStaticLibrary.__LoadFileToStringArray_Internal(fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600857B RID: 34171 RVA: 0x000C633C File Offset: 0x000C453C
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

		// Token: 0x0600857C RID: 34172 RVA: 0x000C637C File Offset: 0x000C457C
		public unsafe static bool LoadFileToArrayPriorPakChunk(string Path, int PakchunkIndex, [Nullable(2)] ref TArray<byte> OutArray)
		{
			FString fstring = FString.AllocTemp(Path);
			bool result = UKuroStaticLibrary.__LoadFileToArrayPriorPakChunk_Internal(fstring, PakchunkIndex, (OutArray ?? new TArray<byte>()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600857D RID: 34173 RVA: 0x000C63B4 File Offset: 0x000C45B4
		public unsafe static bool LoadFileToArray(string Path, [Nullable(2)] ref TArray<byte> OutArray)
		{
			FString fstring = FString.AllocTemp(Path);
			bool result = UKuroStaticLibrary.__LoadFileToArray_Internal(fstring, (OutArray ?? new TArray<byte>()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600857E RID: 34174 RVA: 0x000C63E8 File Offset: 0x000C45E8
		public unsafe static TArray<string> LoadFilesRecursive(string Path, string Filter, bool Files, bool Directories)
		{
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Filter);
			TArray<string> result = new TArray<string>(UKuroStaticLibrary.__LoadFilesRecursive_Internal(fstring, fstring2, Files, Directories), null);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600857F RID: 34175 RVA: 0x000C6428 File Offset: 0x000C4628
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

		// Token: 0x06008580 RID: 34176
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool KuroEnableCustomAffinity();

		// Token: 0x06008581 RID: 34177 RVA: 0x000C6460 File Offset: 0x000C4660
		[NullableContext(2)]
		public static bool IsWorldTearingDown(UWorld World)
		{
			return UKuroStaticLibrary.__IsWorldTearingDown_Internal((World != null) ? World.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008582 RID: 34178
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsWithEditor();

		// Token: 0x06008583 RID: 34179
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsViewportFocus();

		// Token: 0x06008584 RID: 34180 RVA: 0x000C6477 File Offset: 0x000C4677
		[NullableContext(2)]
		public static bool IsObjectClassByName(UObject Object, FName ClassName)
		{
			return UKuroStaticLibrary.__IsObjectClassByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, ClassName);
		}

		// Token: 0x06008585 RID: 34181 RVA: 0x000C648F File Offset: 0x000C468F
		[NullableContext(2)]
		public static bool IsMontageContainGivenAnimNotify(UAnimMontage AnimMontage, [Nullable(new byte[]
		{
			2,
			1
		})] in TSet<string> CheckClassNames)
		{
			return UKuroStaticLibrary.__IsMontageContainGivenAnimNotify_Internal((AnimMontage != null) ? AnimMontage.NativePtr : IntPtr.Zero, (CheckClassNames ?? new TSet<string>()).NativeSetPtr);
		}

		// Token: 0x06008586 RID: 34182 RVA: 0x000C64B8 File Offset: 0x000C46B8
		public unsafe static bool IsModuleLoaded(string ModelName)
		{
			FString fstring = FString.AllocTemp(ModelName);
			bool result = UKuroStaticLibrary.__IsModuleLoaded_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06008587 RID: 34183
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsLowMemoryDevice();

		// Token: 0x06008588 RID: 34184
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsImplementInterface(UClassStackOnlyPtr InClass, UClassStackOnlyPtr InInterfaceClass);

		// Token: 0x06008589 RID: 34185
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsForegroundWindow();

		// Token: 0x0600858A RID: 34186 RVA: 0x000C64DC File Offset: 0x000C46DC
		[NullableContext(2)]
		public static bool IsEditor(UObject WorldContextObject)
		{
			return UKuroStaticLibrary.__IsEditor_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600858B RID: 34187 RVA: 0x000C64F4 File Offset: 0x000C46F4
		public unsafe static void IcmpPing(string IpAddress, float Timeout, [Nullable(2)] in FPingCallExDelegate InDelegate)
		{
			FString fstring = FString.AllocTemp(IpAddress);
			FPingCallExDelegate fpingCallExDelegate = InDelegate;
			UKuroStaticLibrary.__IcmpPing_Internal(fstring, Timeout, (fpingCallExDelegate != null) ? fpingCallExDelegate.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600858C RID: 34188 RVA: 0x000C6528 File Offset: 0x000C4728
		public unsafe static string HashStringWithSHA1(string inString)
		{
			FString fstring = FString.AllocTemp(inString);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__HashStringWithSHA1_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600858D RID: 34189 RVA: 0x000C6554 File Offset: 0x000C4754
		public unsafe static bool HasBlueprintOverrideFunction(UClassStackOnlyPtr ObjectClass, string FunctionName)
		{
			FString fstring = FString.AllocTemp(FunctionName);
			bool result = UKuroStaticLibrary.__HasBlueprintOverrideFunction_Internal(ObjectClass._NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600858E RID: 34190 RVA: 0x000C657E File Offset: 0x000C477E
		public static string GetWholeStatUnitInfo(float Timespan)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetWholeStatUnitInfo_Internal(Timespan));
		}

		// Token: 0x0600858F RID: 34191
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetViewPortMousePosition2(ref FVector2D MousePos);

		// Token: 0x06008590 RID: 34192
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetViewPortMousePosition();

		// Token: 0x06008591 RID: 34193
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetVideoMemoryGB();

		// Token: 0x06008592 RID: 34194 RVA: 0x000C658B File Offset: 0x000C478B
		public static string GetVendorInfo()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetVendorInfo_Internal());
		}

		// Token: 0x06008593 RID: 34195 RVA: 0x000C6597 File Offset: 0x000C4797
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

		// Token: 0x06008594 RID: 34196
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetTotalPhysicalMemory();

		// Token: 0x06008595 RID: 34197
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetTimeSinceGameStartInSeconds();

		// Token: 0x06008596 RID: 34198 RVA: 0x000C65B8 File Offset: 0x000C47B8
		public static string GetSysUUID()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetSysUUID_Internal());
		}

		// Token: 0x06008597 RID: 34199 RVA: 0x000C65C4 File Offset: 0x000C47C4
		public static string GetStatUnitInfo()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetStatUnitInfo_Internal());
		}

		// Token: 0x06008598 RID: 34200 RVA: 0x000C65D0 File Offset: 0x000C47D0
		[NullableContext(2)]
		public static FRotator GetSplineRotationAtSplinePoint(USplineComponent Spline, int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return UKuroStaticLibrary.__GetSplineRotationAtSplinePoint_Internal((Spline != null) ? Spline.NativePtr : IntPtr.Zero, PointIndex, CoordinateSpace);
		}

		// Token: 0x06008599 RID: 34201 RVA: 0x000C65EE File Offset: 0x000C47EE
		[NullableContext(2)]
		public static void GetSlotNamesByAnimMontage(UAnimMontage AnimMontage, ref TArray<FName> OutSlotNames)
		{
			UKuroStaticLibrary.__GetSlotNamesByAnimMontage_Internal((AnimMontage != null) ? AnimMontage.NativePtr : IntPtr.Zero, (OutSlotNames ?? new TArray<FName>()).NativePtr);
		}

		// Token: 0x0600859A RID: 34202
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetSlateApplicationCursorPos();

		// Token: 0x0600859B RID: 34203 RVA: 0x000C6615 File Offset: 0x000C4815
		public static TArray<UMovieSceneTrack> GetSequenceTracksForObjectBindingID([Nullable(2)] ALevelSequenceActor Actor, FName TagName)
		{
			return new TArray<UMovieSceneTrack>(UKuroStaticLibrary.__GetSequenceTracksForObjectBindingID_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, TagName), null);
		}

		// Token: 0x0600859C RID: 34204 RVA: 0x000C6633 File Offset: 0x000C4833
		public static string GetProcessorId()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetProcessorId_Internal());
		}

		// Token: 0x0600859D RID: 34205
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetPlatformTimeInSeconds();

		// Token: 0x0600859E RID: 34206
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetPIEStartTimeInSeconds();

		// Token: 0x0600859F RID: 34207 RVA: 0x000C663F File Offset: 0x000C483F
		public static string GetOSVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetOSVersion_Internal());
		}

		// Token: 0x060085A0 RID: 34208 RVA: 0x000C664B File Offset: 0x000C484B
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

		// Token: 0x060085A1 RID: 34209 RVA: 0x000C6688 File Offset: 0x000C4888
		public static string GetMacAddress()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetMacAddress_Internal());
		}

		// Token: 0x060085A2 RID: 34210 RVA: 0x000C6694 File Offset: 0x000C4894
		public static void GetLocalHostAddresses([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> OutAddresses, bool bAppendPort = false)
		{
			UKuroStaticLibrary.__GetLocalHostAddresses_Internal((OutAddresses ?? new TArray<string>()).NativePtr, bAppendPort);
		}

		// Token: 0x060085A3 RID: 34211 RVA: 0x000C66AC File Offset: 0x000C48AC
		[NullableContext(2)]
		public static bool GetLocalAdapterAddressesUint32(ref TArray<int> OutAddresses)
		{
			return UKuroStaticLibrary.__GetLocalAdapterAddressesUint32_Internal((OutAddresses ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x060085A4 RID: 34212 RVA: 0x000C66C3 File Offset: 0x000C48C3
		[NullableContext(2)]
		public static AActor GetLevelPrefabShowActor(AActor Actor)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroStaticLibrary.__GetLevelPrefabShowActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060085A5 RID: 34213 RVA: 0x000C66DF File Offset: 0x000C48DF
		public static string GetLevelPath([Nullable(2)] UObject WorldContextObject)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetLevelPath_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060085A6 RID: 34214 RVA: 0x000C66FB File Offset: 0x000C48FB
		public static string GetGPUInfo()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetGPUInfo_Internal());
		}

		// Token: 0x060085A7 RID: 34215 RVA: 0x000C6707 File Offset: 0x000C4907
		[NullableContext(2)]
		public static UGameViewportClient GetGameViewPort()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameViewportClient>(UKuroStaticLibrary.__GetGameViewPort_Internal());
		}

		// Token: 0x060085A8 RID: 34216 RVA: 0x000C6713 File Offset: 0x000C4913
		[NullableContext(2)]
		public static FVector GetFirstLocationFromSeqTrack(UMovieScene3DTransformTrack TransformTrack)
		{
			return UKuroStaticLibrary.__GetFirstLocationFromSeqTrack_Internal((TransformTrack != null) ? TransformTrack.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060085A9 RID: 34217 RVA: 0x000C672C File Offset: 0x000C492C
		public unsafe static TArray<string> GetFilesRecursive(string Path, string Filter, bool Files, bool Directories)
		{
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Filter);
			TArray<string> result = new TArray<string>(UKuroStaticLibrary.__GetFilesRecursive_Internal(fstring, fstring2, Files, Directories), null);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060085AA RID: 34218 RVA: 0x000C676C File Offset: 0x000C496C
		public unsafe static TArray<string> GetFiles(string Path, string Extension)
		{
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Extension);
			TArray<string> result = new TArray<string>(UKuroStaticLibrary.__GetFiles_Internal(fstring, fstring2), null);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060085AB RID: 34219 RVA: 0x000C67A8 File Offset: 0x000C49A8
		public unsafe static string GetFileModificationTime(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetFileModificationTime_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060085AC RID: 34220 RVA: 0x000C67D4 File Offset: 0x000C49D4
		public unsafe static string GetFileCreationTime(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetFileCreationTime_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060085AD RID: 34221 RVA: 0x000C6800 File Offset: 0x000C4A00
		public unsafe static string GetFileAccessTime(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetFileAccessTime_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060085AE RID: 34222 RVA: 0x000C6829 File Offset: 0x000C4A29
		[NullableContext(2)]
		public static bool GetEnableMobileLowStreaming(ULevelSequence Sequence)
		{
			return UKuroStaticLibrary.__GetEnableMobileLowStreaming_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060085AF RID: 34223 RVA: 0x000C6840 File Offset: 0x000C4A40
		public static string GetDiskSerialNo()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetDiskSerialNo_Internal());
		}

		// Token: 0x060085B0 RID: 34224 RVA: 0x000C684C File Offset: 0x000C4A4C
		public unsafe static TArray<string> GetDirectories(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			TArray<string> result = new TArray<string>(UKuroStaticLibrary.__GetDirectories_Internal(fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060085B1 RID: 34225 RVA: 0x000C6876 File Offset: 0x000C4A76
		public static string GetDeviceCPU()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetDeviceCPU_Internal());
		}

		// Token: 0x060085B2 RID: 34226 RVA: 0x000C6882 File Offset: 0x000C4A82
		[NullableContext(2)]
		public static UObject GetDefaultObject(UClassStackOnlyPtr Class)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKuroStaticLibrary.__GetDefaultObject_Internal(Class._NativePtr));
		}

		// Token: 0x060085B3 RID: 34227
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetCurCPUFrequency();

		// Token: 0x060085B4 RID: 34228 RVA: 0x000C6894 File Offset: 0x000C4A94
		public static string GetCultureRegion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetCultureRegion_Internal());
		}

		// Token: 0x060085B5 RID: 34229 RVA: 0x000C68A0 File Offset: 0x000C4AA0
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

		// Token: 0x060085B6 RID: 34230 RVA: 0x000C68EA File Offset: 0x000C4AEA
		public static string GetConsoleModelName()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetConsoleModelName_Internal());
		}

		// Token: 0x060085B7 RID: 34231
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

		// Token: 0x060085B8 RID: 34232 RVA: 0x000C68F6 File Offset: 0x000C4AF6
		[NullableContext(2)]
		public static bool GetCameraShakeInfo([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> CameraShakeClass, ref FCameraShakeInfo OutInfo)
		{
			return UKuroStaticLibrary.__GetCameraShakeInfo_Internal(CameraShakeClass._NativePtr, (OutInfo ?? new FCameraShakeInfo()).NativePtr);
		}

		// Token: 0x060085B9 RID: 34233 RVA: 0x000C6913 File Offset: 0x000C4B13
		public static string GetBlueprintCallstack()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetBlueprintCallstack_Internal());
		}

		// Token: 0x060085BA RID: 34234
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetBatteryLevel();

		// Token: 0x060085BB RID: 34235 RVA: 0x000C691F File Offset: 0x000C4B1F
		public static string GetBaseBoardInfo()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__GetBaseBoardInfo_Internal());
		}

		// Token: 0x060085BC RID: 34236 RVA: 0x000C692B File Offset: 0x000C4B2B
		[NullableContext(2)]
		public static void GetAnimSequencesByAnimMontage(UAnimMontage AnimMontage, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UAnimSequenceBase> OutAnimSequences)
		{
			UKuroStaticLibrary.__GetAnimSequencesByAnimMontage_Internal((AnimMontage != null) ? AnimMontage.NativePtr : IntPtr.Zero, (OutAnimSequences ?? new TArray<UAnimSequenceBase>()).NativePtr);
		}

		// Token: 0x060085BD RID: 34237 RVA: 0x000C6952 File Offset: 0x000C4B52
		[NullableContext(2)]
		public static void GetAnimSequenceNotifies(UAnimSequenceBase AnimSequence, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FAnimNotifyEvent> OutNotifies)
		{
			UKuroStaticLibrary.__GetAnimSequenceNotifies_Internal((AnimSequence != null) ? AnimSequence.NativePtr : IntPtr.Zero, (OutNotifies ?? new TArray<FAnimNotifyEvent>()).NativePtr);
		}

		// Token: 0x060085BE RID: 34238 RVA: 0x000C6979 File Offset: 0x000C4B79
		[NullableContext(2)]
		public static void GetAnimMontageNotifies(UAnimMontage AnimMontage, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FAnimNotifyEvent> OutNotifies)
		{
			UKuroStaticLibrary.__GetAnimMontageNotifies_Internal((AnimMontage != null) ? AnimMontage.NativePtr : IntPtr.Zero, (OutNotifies ?? new TArray<FAnimNotifyEvent>()).NativePtr);
		}

		// Token: 0x060085BF RID: 34239 RVA: 0x000C69A0 File Offset: 0x000C4BA0
		[NullableContext(2)]
		public static void GetAnimAssetsByAnimInstance(UAnimInstance InAnimInstance, [Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<UAnimationAsset> OutAnimationAssets)
		{
			UKuroStaticLibrary.__GetAnimAssetsByAnimInstance_Internal((InAnimInstance != null) ? InAnimInstance.NativePtr : IntPtr.Zero, (OutAnimationAssets ?? new TSet<UAnimationAsset>()).NativeSetPtr);
		}

		// Token: 0x060085C0 RID: 34240 RVA: 0x000C69C8 File Offset: 0x000C4BC8
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

		// Token: 0x060085C1 RID: 34241 RVA: 0x000C69F8 File Offset: 0x000C4BF8
		[NullableContext(2)]
		public static void GetAnimAssets(UAnimBlueprint InAnimBlueprint, [Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<UAnimationAsset> OutAnimationAssets)
		{
			UKuroStaticLibrary.__GetAnimAssets_Internal((InAnimBlueprint != null) ? InAnimBlueprint.NativePtr : IntPtr.Zero, (OutAnimationAssets ?? new TSet<UAnimationAsset>()).NativeSetPtr);
		}

		// Token: 0x060085C2 RID: 34242 RVA: 0x000C6A1F File Offset: 0x000C4C1F
		public static FDateTime FromUnixTimestamp(int Timestamp)
		{
			return new FDateTime(UKuroStaticLibrary.__FromUnixTimestamp_Internal(Timestamp), null);
		}

		// Token: 0x060085C3 RID: 34243
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ForceGarbageCollection(bool bFullPurge = false);

		// Token: 0x060085C4 RID: 34244 RVA: 0x000C6A30 File Offset: 0x000C4C30
		public unsafe static TArray<string> FindFilesSorted(string Path, string Extension)
		{
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Extension);
			TArray<string> result = new TArray<string>(UKuroStaticLibrary.__FindFilesSorted_Internal(fstring, fstring2), null);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060085C5 RID: 34245 RVA: 0x000C6A6C File Offset: 0x000C4C6C
		public unsafe static bool FileExists(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			bool result = UKuroStaticLibrary.__FileExists_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060085C6 RID: 34246
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ExitGame(bool force);

		// Token: 0x060085C7 RID: 34247 RVA: 0x000C6A90 File Offset: 0x000C4C90
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

		// Token: 0x060085C8 RID: 34248 RVA: 0x000C6AE0 File Offset: 0x000C4CE0
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

		// Token: 0x060085C9 RID: 34249 RVA: 0x000C6B59 File Offset: 0x000C4D59
		[NullableContext(2)]
		public static bool EncompassesPoint(AVolume Volume, FVector Point, float SphereRadius = 0f)
		{
			return UKuroStaticLibrary.__EncompassesPoint_Internal((Volume != null) ? Volume.NativePtr : IntPtr.Zero, Point, SphereRadius);
		}

		// Token: 0x060085CA RID: 34250 RVA: 0x000C6B74 File Offset: 0x000C4D74
		public unsafe static void DumpStackTrace(string Str)
		{
			FString fstring = FString.AllocTemp(Str);
			UKuroStaticLibrary.__DumpStackTrace_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060085CB RID: 34251 RVA: 0x000C6B98 File Offset: 0x000C4D98
		[NullableContext(2)]
		public static void DoGameViewPortMouseEnter(UGameViewportClient InViewport, int x, int y)
		{
			UKuroStaticLibrary.__DoGameViewPortMouseEnter_Internal((InViewport != null) ? InViewport.NativePtr : IntPtr.Zero, x, y);
		}

		// Token: 0x060085CC RID: 34252 RVA: 0x000C6BB4 File Offset: 0x000C4DB4
		public unsafe static bool DirectoryExists(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			bool result = UKuroStaticLibrary.__DirectoryExists_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060085CD RID: 34253 RVA: 0x000C6BD8 File Offset: 0x000C4DD8
		[NullableContext(2)]
		public static void DestroyObject(UObject Object)
		{
			UKuroStaticLibrary.__DestroyObject_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060085CE RID: 34254 RVA: 0x000C6BF0 File Offset: 0x000C4DF0
		public unsafe static bool DeleteFolder(string Path, bool bRequireExists = false, bool bTree = false)
		{
			FString fstring = FString.AllocTemp(Path);
			bool result = UKuroStaticLibrary.__DeleteFolder_Internal(fstring, bRequireExists, bTree);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060085CF RID: 34255 RVA: 0x000C6C18 File Offset: 0x000C4E18
		public unsafe static bool DeleteFile(string Path, bool bRequireExists = false, bool bEvenReadOnly = false, bool bQuiet = false)
		{
			FString fstring = FString.AllocTemp(Path);
			bool result = UKuroStaticLibrary.__DeleteFile_Internal(fstring, bRequireExists, bEvenReadOnly, bQuiet);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060085D0 RID: 34256 RVA: 0x000C6C3F File Offset: 0x000C4E3F
		[NullableContext(2)]
		public static FVectorDouble D_GetFirstLocationFromSeqTrack(UMovieScene3DTransformTrack TransformTrack)
		{
			return UKuroStaticLibrary.__D_GetFirstLocationFromSeqTrack_Internal((TransformTrack != null) ? TransformTrack.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060085D1 RID: 34257 RVA: 0x000C6C58 File Offset: 0x000C4E58
		public unsafe static bool CopyFile(string SourcePath, string DstPath)
		{
			FString fstring = FString.AllocTemp(SourcePath);
			FString fstring2 = FString.AllocTemp(DstPath);
			bool result = UKuroStaticLibrary.__CopyFile_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060085D2 RID: 34258
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern TEnumAsByte<ETraceTypeQuery> ConvertToTraceType(ECollisionChannel InCollisionChannel);

		// Token: 0x060085D3 RID: 34259
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern TEnumAsByte<EObjectTypeQuery> ConvertToObjectType(ECollisionChannel InCollisionChannel);

		// Token: 0x060085D4 RID: 34260 RVA: 0x000C6C90 File Offset: 0x000C4E90
		[NullableContext(2)]
		public static void ClearPlayerInputCache(ref APlayerController PC)
		{
			APlayerController aplayerController = PC;
			IntPtr nativeObjectPtr = (aplayerController != null) ? aplayerController.NativePtr : IntPtr.Zero;
			UKuroStaticLibrary.__ClearPlayerInputCache_Internal(ref nativeObjectPtr);
			PC = BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerController>(nativeObjectPtr);
		}

		// Token: 0x060085D5 RID: 34261
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearCustomGetTimeBetweenGarbageCollectionPassesDelegate();

		// Token: 0x060085D6 RID: 34262 RVA: 0x000C6CBF File Offset: 0x000C4EBF
		[NullableContext(2)]
		public static void BindDeviceLangChangeDelegate(in FDeviceLangChange Delegate)
		{
			FDeviceLangChange fdeviceLangChange = Delegate;
			UKuroStaticLibrary.__BindDeviceLangChangeDelegate_Internal((fdeviceLangChange != null) ? fdeviceLangChange.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060085D7 RID: 34263 RVA: 0x000C6CD5 File Offset: 0x000C4ED5
		[NullableContext(2)]
		public static void BindCustomGetTimeBetweenGarbageCollectionPassesDelegate(in FCustomGCTimeDelegate Delegate)
		{
			FCustomGCTimeDelegate fcustomGCTimeDelegate = Delegate;
			UKuroStaticLibrary.__BindCustomGetTimeBetweenGarbageCollectionPassesDelegate_Internal((fcustomGCTimeDelegate != null) ? fcustomGCTimeDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060085D8 RID: 34264 RVA: 0x000C6CEC File Offset: 0x000C4EEC
		public unsafe static string Base64EncodeWithSpecifyCharWithConvertToUTF8(string inString, string SpecifyChar)
		{
			FString fstring = FString.AllocTemp(inString);
			FString fstring2 = FString.AllocTemp(SpecifyChar);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__Base64EncodeWithSpecifyCharWithConvertToUTF8_Internal(fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060085D9 RID: 34265 RVA: 0x000C6D28 File Offset: 0x000C4F28
		public unsafe static string Base64EncodeWithSpecifyChar([Nullable(2)] in TArray<byte> ByteArray, string SpecifyChar)
		{
			FString fstring = FString.AllocTemp(SpecifyChar);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__Base64EncodeWithSpecifyChar_Internal((ByteArray ?? new TArray<byte>()).NativePtr, fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060085DA RID: 34266 RVA: 0x000C6D64 File Offset: 0x000C4F64
		public unsafe static string Base64EncodeWithConvertToUTF8(string inString)
		{
			FString fstring = FString.AllocTemp(inString);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__Base64EncodeWithConvertToUTF8_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060085DB RID: 34267 RVA: 0x000C6D8D File Offset: 0x000C4F8D
		public static string Base64EncodeBinary(in FArrayBuffer InBuffer)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__Base64EncodeBinary_Internal(InBuffer));
		}

		// Token: 0x060085DC RID: 34268 RVA: 0x000C6D9C File Offset: 0x000C4F9C
		public unsafe static string Base64Encode(string inString)
		{
			FString fstring = FString.AllocTemp(inString);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__Base64Encode_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060085DD RID: 34269 RVA: 0x000C6DC8 File Offset: 0x000C4FC8
		public unsafe static string Base64Decode(string inString)
		{
			FString fstring = FString.AllocTemp(inString);
			string result = FString.ToStringAndDeleteNativePtr(UKuroStaticLibrary.__Base64Decode_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060085DE RID: 34270 RVA: 0x000C6DF1 File Offset: 0x000C4FF1
		[NullableContext(2)]
		public static FArrayBuffer ArrayToBuffer(ref TArray<byte> InArray)
		{
			return UKuroStaticLibrary.__ArrayToBuffer_Internal((InArray ?? new TArray<byte>()).NativePtr);
		}

		// Token: 0x060085DF RID: 34271 RVA: 0x000C6E08 File Offset: 0x000C5008
		[NullableContext(2)]
		public static void ApplyChangeToBlueprint(AActor Actor)
		{
			UKuroStaticLibrary.__ApplyChangeToBlueprint_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060085E0 RID: 34272 RVA: 0x000C6E1F File Offset: 0x000C501F
		[NullableContext(2)]
		public static void AddToRoot(UObject InObject)
		{
			UKuroStaticLibrary.__AddToRoot_Internal((InObject != null) ? InObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060085E1 RID: 34273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WriteStringToFile_Internal(in FString SaveText, in FString FileName, bool bPublic, bool bWithBom);

		// Token: 0x060085E2 RID: 34274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnRegisterCustomCommandProcessor_Internal(in FString Category);

		// Token: 0x060085E3 RID: 34275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __ToUnixTimestamp_Internal(IntPtr InDataTime);

		// Token: 0x060085E4 RID: 34276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ToggleSequenceNodeActiveByTag_Internal(IntPtr Actor, FName TagName, bool bActive);

		// Token: 0x060085E5 RID: 34277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SynchronizeProperties_Internal(IntPtr InWidget);

		// Token: 0x060085E6 RID: 34278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAllMontagesBySlotName_Internal(IntPtr UAnimInstance, FName InSlotName, float InBlendOutTime);

		// Token: 0x060085E7 RID: 34279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnActorFromAnother_Internal(IntPtr Actor, IntPtr Parent);

		// Token: 0x060085E8 RID: 34280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetThreadPriorityAndPolicyAndAffinity_Internal(in FString ThreadName, int Priority, int Policy, int AffinityHigh, int AffinityLow);

		// Token: 0x060085E9 RID: 34281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetThreadPriorityAndPolicy_Internal(in FString ThreadName, int Priority, int Policy);

		// Token: 0x060085EA RID: 34282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetThreadPriority_Internal(in FString ThreadName, int Priority);

		// Token: 0x060085EB RID: 34283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetThreadPolicy_Internal(in FString ThreadName, int Policy);

		// Token: 0x060085EC RID: 34284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetThreadAffinity_Internal(in FString ThreadName, int AffinityHigh, int AffinityLow);

		// Token: 0x060085ED RID: 34285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStaticMeshVelocity_Internal(IntPtr Actors, FVector NewVelocity);

		// Token: 0x060085EE RID: 34286
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSplinePointsWithType_Internal(IntPtr Spline, IntPtr Points, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, TEnumAsByte<ESplinePointType> Type, bool bUpdateSpline);

		// Token: 0x060085EF RID: 34287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMontageANIndex_Internal(IntPtr AnimMontage);

		// Token: 0x060085F0 RID: 34288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInputKeyDeadZone_Internal(IntPtr world, int playerIndex, IntPtr key, float deadZone);

		// Token: 0x060085F1 RID: 34289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConsoleVariableWithCurrentPriority_String_Internal(in FString InCVar, in FString InValue);

		// Token: 0x060085F2 RID: 34290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConsoleVariableWithCurrentPriority_Int_Internal(in FString InCVar, int InValue);

		// Token: 0x060085F3 RID: 34291
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConsoleVariableWithCurrentPriority_Float_Internal(in FString InCVar, float InValue);

		// Token: 0x060085F4 RID: 34292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBaseAndSaveBaseLocation_Internal(IntPtr CharacterMovementComp, IntPtr NewBase);

		// Token: 0x060085F5 RID: 34293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorPermanent_Internal(IntPtr Actor, bool bIsPermanent, bool bWithAllChildren);

		// Token: 0x060085F6 RID: 34294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorModify_Internal(IntPtr Actor);

		// Token: 0x060085F7 RID: 34295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SaveStringToFile_Internal(in FString SaveText, in FString FileName, bool bWithBom);

		// Token: 0x060085F8 RID: 34296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SaveBufferToFile_Internal(in FString Path, in FArrayBuffer InBuffer);

		// Token: 0x060085F9 RID: 34297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveFromRoot_Internal(IntPtr InObject);

		// Token: 0x060085FA RID: 34298
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterCustomCommandProcessor_Internal(in FString Category, IntPtr Processor);

		// Token: 0x060085FB RID: 34299
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PingGateWay_Internal(in FString Address, int Port, float Timeout, in FString Payload, IntPtr PingDelegate);

		// Token: 0x060085FC RID: 34300
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Md5HashUTF8String_Internal(in FString inString);

		// Token: 0x060085FD RID: 34301
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Md5HashAnsiString_Internal(in FString inString);

		// Token: 0x060085FE RID: 34302
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MakeDirectory_Internal(in FString Path, bool bTree);

		// Token: 0x060085FF RID: 34303
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadFileToStringArray_Internal(in FString FileRevisionPath);

		// Token: 0x06008600 RID: 34304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LoadFileToString_Internal(ref FString Result, in FString Filename);

		// Token: 0x06008601 RID: 34305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LoadFileToArrayPriorPakChunk_Internal(in FString Path, int PakchunkIndex, IntPtr OutArray);

		// Token: 0x06008602 RID: 34306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LoadFileToArray_Internal(in FString Path, IntPtr OutArray);

		// Token: 0x06008603 RID: 34307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadFilesRecursive_Internal(in FString Path, in FString Filter, bool Files, bool Directories);

		// Token: 0x06008604 RID: 34308
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __KuroFormatText_Internal(in FString Format, IntPtr Parameters);

		// Token: 0x06008605 RID: 34309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWorldTearingDown_Internal(IntPtr World);

		// Token: 0x06008606 RID: 34310
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsObjectClassByName_Internal(IntPtr Object, FName ClassName);

		// Token: 0x06008607 RID: 34311
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMontageContainGivenAnimNotify_Internal(IntPtr AnimMontage, IntPtr CheckClassNames);

		// Token: 0x06008608 RID: 34312
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsModuleLoaded_Internal(in FString ModelName);

		// Token: 0x06008609 RID: 34313
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEditor_Internal(IntPtr WorldContextObject);

		// Token: 0x0600860A RID: 34314
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __IcmpPing_Internal(in FString IpAddress, float Timeout, IntPtr InDelegate);

		// Token: 0x0600860B RID: 34315
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __HashStringWithSHA1_Internal(in FString inString);

		// Token: 0x0600860C RID: 34316
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasBlueprintOverrideFunction_Internal(IntPtr ObjectClass, in FString FunctionName);

		// Token: 0x0600860D RID: 34317
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetWholeStatUnitInfo_Internal(float Timespan);

		// Token: 0x0600860E RID: 34318
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetVendorInfo_Internal();

		// Token: 0x0600860F RID: 34319
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTrackByClass_Internal(IntPtr Tracks, IntPtr Class);

		// Token: 0x06008610 RID: 34320
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSysUUID_Internal();

		// Token: 0x06008611 RID: 34321
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetStatUnitInfo_Internal();

		// Token: 0x06008612 RID: 34322
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetSplineRotationAtSplinePoint_Internal(IntPtr Spline, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06008613 RID: 34323
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSlotNamesByAnimMontage_Internal(IntPtr AnimMontage, IntPtr OutSlotNames);

		// Token: 0x06008614 RID: 34324
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSequenceTracksForObjectBindingID_Internal(IntPtr Actor, FName TagName);

		// Token: 0x06008615 RID: 34325
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetProcessorId_Internal();

		// Token: 0x06008616 RID: 34326
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetOSVersion_Internal();

		// Token: 0x06008617 RID: 34327
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNavPointData_Internal(IntPtr WorldContextObject, int XNumber, int YNumber, int Dis, IntPtr NavData, FVector Point, FVector QueryExtent, IntPtr FilterClass);

		// Token: 0x06008618 RID: 34328
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetMacAddress_Internal();

		// Token: 0x06008619 RID: 34329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetLocalHostAddresses_Internal(IntPtr OutAddresses, bool bAppendPort);

		// Token: 0x0600861A RID: 34330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLocalAdapterAddressesUint32_Internal(IntPtr OutAddresses);

		// Token: 0x0600861B RID: 34331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLevelPrefabShowActor_Internal(IntPtr Actor);

		// Token: 0x0600861C RID: 34332
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetLevelPath_Internal(IntPtr WorldContextObject);

		// Token: 0x0600861D RID: 34333
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetGPUInfo_Internal();

		// Token: 0x0600861E RID: 34334
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGameViewPort_Internal();

		// Token: 0x0600861F RID: 34335
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetFirstLocationFromSeqTrack_Internal(IntPtr TransformTrack);

		// Token: 0x06008620 RID: 34336
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetFilesRecursive_Internal(in FString Path, in FString Filter, bool Files, bool Directories);

		// Token: 0x06008621 RID: 34337
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetFiles_Internal(in FString Path, in FString Extension);

		// Token: 0x06008622 RID: 34338
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetFileModificationTime_Internal(in FString Path);

		// Token: 0x06008623 RID: 34339
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetFileCreationTime_Internal(in FString Path);

		// Token: 0x06008624 RID: 34340
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetFileAccessTime_Internal(in FString Path);

		// Token: 0x06008625 RID: 34341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetEnableMobileLowStreaming_Internal(IntPtr Sequence);

		// Token: 0x06008626 RID: 34342
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDiskSerialNo_Internal();

		// Token: 0x06008627 RID: 34343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDirectories_Internal(in FString Path);

		// Token: 0x06008628 RID: 34344
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDeviceCPU_Internal();

		// Token: 0x06008629 RID: 34345
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDefaultObject_Internal(IntPtr Class);

		// Token: 0x0600862A RID: 34346
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCultureRegion_Internal();

		// Token: 0x0600862B RID: 34347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetCreatureGenDirectoryByMap_Internal(in FString Path, int MapID, ref bool Exist, ref FString Directory);

		// Token: 0x0600862C RID: 34348
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetConsoleModelName_Internal();

		// Token: 0x0600862D RID: 34349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCameraShakeInfo_Internal(IntPtr CameraShakeClass, IntPtr OutInfo);

		// Token: 0x0600862E RID: 34350
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetBlueprintCallstack_Internal();

		// Token: 0x0600862F RID: 34351
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetBaseBoardInfo_Internal();

		// Token: 0x06008630 RID: 34352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAnimSequencesByAnimMontage_Internal(IntPtr AnimMontage, IntPtr OutAnimSequences);

		// Token: 0x06008631 RID: 34353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAnimSequenceNotifies_Internal(IntPtr AnimSequence, IntPtr OutNotifies);

		// Token: 0x06008632 RID: 34354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAnimMontageNotifies_Internal(IntPtr AnimMontage, IntPtr OutNotifies);

		// Token: 0x06008633 RID: 34355
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAnimAssetsByAnimInstance_Internal(IntPtr InAnimInstance, IntPtr OutAnimationAssets);

		// Token: 0x06008634 RID: 34356
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAnimAssetsByAnimBlueprintClass_Internal(in IntPtr InAnimClass, IntPtr OutAnimationAssets);

		// Token: 0x06008635 RID: 34357
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAnimAssets_Internal(IntPtr InAnimBlueprint, IntPtr OutAnimationAssets);

		// Token: 0x06008636 RID: 34358
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FromUnixTimestamp_Internal(int Timestamp);

		// Token: 0x06008637 RID: 34359
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindFilesSorted_Internal(in FString Path, in FString Extension);

		// Token: 0x06008638 RID: 34360
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FileExists_Internal(in FString Path);

		// Token: 0x06008639 RID: 34361
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ExecuteFunctionByName_Internal(IntPtr Object, in FString FunctionName, ref FString Result);

		// Token: 0x0600863A RID: 34362
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ExecProcess_Internal(in FString URL, in FString Params, ref int ReturnCode, ref FString OutStd, ref FString OutErr);

		// Token: 0x0600863B RID: 34363
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EncompassesPoint_Internal(IntPtr Volume, FVector Point, float SphereRadius);

		// Token: 0x0600863C RID: 34364
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DumpStackTrace_Internal(in FString Str);

		// Token: 0x0600863D RID: 34365
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DoGameViewPortMouseEnter_Internal(IntPtr InViewport, int x, int y);

		// Token: 0x0600863E RID: 34366
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DirectoryExists_Internal(in FString Path);

		// Token: 0x0600863F RID: 34367
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyObject_Internal(IntPtr Object);

		// Token: 0x06008640 RID: 34368
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DeleteFolder_Internal(in FString Path, bool bRequireExists, bool bTree);

		// Token: 0x06008641 RID: 34369
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DeleteFile_Internal(in FString Path, bool bRequireExists, bool bEvenReadOnly, bool bQuiet);

		// Token: 0x06008642 RID: 34370
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetFirstLocationFromSeqTrack_Internal(IntPtr TransformTrack);

		// Token: 0x06008643 RID: 34371
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CopyFile_Internal(in FString SourcePath, in FString DstPath);

		// Token: 0x06008644 RID: 34372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearPlayerInputCache_Internal(ref IntPtr PC);

		// Token: 0x06008645 RID: 34373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindDeviceLangChangeDelegate_Internal(IntPtr Delegate);

		// Token: 0x06008646 RID: 34374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindCustomGetTimeBetweenGarbageCollectionPassesDelegate_Internal(IntPtr Delegate);

		// Token: 0x06008647 RID: 34375
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Base64EncodeWithSpecifyCharWithConvertToUTF8_Internal(in FString inString, in FString SpecifyChar);

		// Token: 0x06008648 RID: 34376
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Base64EncodeWithSpecifyChar_Internal(IntPtr ByteArray, in FString SpecifyChar);

		// Token: 0x06008649 RID: 34377
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Base64EncodeWithConvertToUTF8_Internal(in FString inString);

		// Token: 0x0600864A RID: 34378
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Base64EncodeBinary_Internal(in FArrayBuffer InBuffer);

		// Token: 0x0600864B RID: 34379
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Base64Encode_Internal(in FString inString);

		// Token: 0x0600864C RID: 34380
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Base64Decode_Internal(in FString inString);

		// Token: 0x0600864D RID: 34381
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FArrayBuffer __ArrayToBuffer_Internal(IntPtr InArray);

		// Token: 0x0600864E RID: 34382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyChangeToBlueprint_Internal(IntPtr Actor);

		// Token: 0x0600864F RID: 34383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddToRoot_Internal(IntPtr InObject);

		// Token: 0x06008650 RID: 34384 RVA: 0x000C6E36 File Offset: 0x000C5036
		static UKuroStaticLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroStaticLibrary");
		}

		// Token: 0x06008651 RID: 34385 RVA: 0x000C6E44 File Offset: 0x000C5044
		protected UKuroStaticLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A33 RID: 14899
		public new const string __ObjectPath = "/Script/KuroUtility.KuroStaticLibrary";

		// Token: 0x04003A34 RID: 14900
		private static IntPtr _ClassPtr;

		// Token: 0x04003A35 RID: 14901
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
