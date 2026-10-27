using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001956 RID: 6486
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AsyncTaskRotateSequence")]
	[UnrealStructLayout(496, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UAsyncTaskRotateSequence : UGameplayTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018078 RID: 98424 RVA: 0x00234638 File Offset: 0x00232838
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskRotateSequence._ClassPtr;
		}

		// Token: 0x06018079 RID: 98425 RVA: 0x00234644 File Offset: 0x00232844
		public UAsyncTaskRotateSequence() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskRotateSequence.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601807A RID: 98426 RVA: 0x0023466C File Offset: 0x0023286C
		public UAsyncTaskRotateSequence(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskRotateSequence.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006033 RID: 24627
		// (get) Token: 0x0601807B RID: 98427 RVA: 0x002346A0 File Offset: 0x002328A0
		// (set) Token: 0x0601807C RID: 98428 RVA: 0x002346D9 File Offset: 0x002328D9
		public FOnRotateStepSignature OnShootStepFired
		{
			get
			{
				base.FastCheckIsValid();
				FOnRotateStepSignature result;
				if ((result = this._OnShootStepFired) == null)
				{
					result = (this._OnShootStepFired = new FOnRotateStepSignature(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_OnShootStepFired, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_OnShootStepFired, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006034 RID: 24628
		// (get) Token: 0x0601807D RID: 98429 RVA: 0x002346FC File Offset: 0x002328FC
		// (set) Token: 0x0601807E RID: 98430 RVA: 0x00234735 File Offset: 0x00232935
		public FOnRotateSequenceFinishedSignature OnSequenceFinished
		{
			get
			{
				base.FastCheckIsValid();
				FOnRotateSequenceFinishedSignature result;
				if ((result = this._OnSequenceFinished) == null)
				{
					result = (this._OnSequenceFinished = new FOnRotateSequenceFinishedSignature(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_OnSequenceFinished, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_OnSequenceFinished, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006035 RID: 24629
		// (get) Token: 0x0601807F RID: 98431 RVA: 0x00234756 File Offset: 0x00232956
		// (set) Token: 0x06018080 RID: 98432 RVA: 0x00234766 File Offset: 0x00232966
		public unsafe float AimToleranceDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_AimToleranceDeg);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_AimToleranceDeg) = value;
			}
		}

		// Token: 0x17006036 RID: 24630
		// (get) Token: 0x06018081 RID: 98433 RVA: 0x00234777 File Offset: 0x00232977
		// (set) Token: 0x06018082 RID: 98434 RVA: 0x00234787 File Offset: 0x00232987
		public unsafe float AimSpeedDegPerSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_AimSpeedDegPerSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_AimSpeedDegPerSec) = value;
			}
		}

		// Token: 0x17006037 RID: 24631
		// (get) Token: 0x06018083 RID: 98435 RVA: 0x00234798 File Offset: 0x00232998
		// (set) Token: 0x06018084 RID: 98436 RVA: 0x002347A8 File Offset: 0x002329A8
		public unsafe float PostFireDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_PostFireDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_PostFireDelay) = value;
			}
		}

		// Token: 0x17006038 RID: 24632
		// (get) Token: 0x06018085 RID: 98437 RVA: 0x002347B9 File Offset: 0x002329B9
		// (set) Token: 0x06018086 RID: 98438 RVA: 0x002347C9 File Offset: 0x002329C9
		public unsafe float TimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_TimeDilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_TimeDilation) = value;
			}
		}

		// Token: 0x17006039 RID: 24633
		// (get) Token: 0x06018087 RID: 98439 RVA: 0x002347DA File Offset: 0x002329DA
		// (set) Token: 0x06018088 RID: 98440 RVA: 0x002347F3 File Offset: 0x002329F3
		public unsafe bool bEaseOut
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_bEaseOut) & UAsyncTaskRotateSequence.__PropertyMask_bEaseOut) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_bEaseOut) = ((*(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_bEaseOut) & ~UAsyncTaskRotateSequence.__PropertyMask_bEaseOut) | (value ? UAsyncTaskRotateSequence.__PropertyMask_bEaseOut : 0));
			}
		}

		// Token: 0x1700603A RID: 24634
		// (get) Token: 0x06018089 RID: 98441 RVA: 0x00234823 File Offset: 0x00232A23
		// (set) Token: 0x0601808A RID: 98442 RVA: 0x0023483C File Offset: 0x00232A3C
		public unsafe bool bEaseIn
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_bEaseIn) & UAsyncTaskRotateSequence.__PropertyMask_bEaseIn) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_bEaseIn) = ((*(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_bEaseIn) & ~UAsyncTaskRotateSequence.__PropertyMask_bEaseIn) | (value ? UAsyncTaskRotateSequence.__PropertyMask_bEaseIn : 0));
			}
		}

		// Token: 0x1700603B RID: 24635
		// (get) Token: 0x0601808B RID: 98443 RVA: 0x0023486C File Offset: 0x00232A6C
		// (set) Token: 0x0601808C RID: 98444 RVA: 0x00234885 File Offset: 0x00232A85
		public unsafe bool bForceShortestRoute
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_bForceShortestRoute) & UAsyncTaskRotateSequence.__PropertyMask_bForceShortestRoute) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_bForceShortestRoute) = ((*(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_bForceShortestRoute) & ~UAsyncTaskRotateSequence.__PropertyMask_bForceShortestRoute) | (value ? UAsyncTaskRotateSequence.__PropertyMask_bForceShortestRoute : 0));
			}
		}

		// Token: 0x1700603C RID: 24636
		// (get) Token: 0x0601808D RID: 98445 RVA: 0x002348B5 File Offset: 0x00232AB5
		// (set) Token: 0x0601808E RID: 98446 RVA: 0x002348C9 File Offset: 0x00232AC9
		public unsafe FRotator RotateOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_RotateOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAsyncTaskRotateSequence.__PropertyOffset_RotateOffset) = value;
			}
		}

		// Token: 0x0601808F RID: 98447 RVA: 0x002348E0 File Offset: 0x00232AE0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncTaskRotateSequence StartRotateSequenceByTranslation(IGameplayTaskOwnerInterface TaskOwner, USceneComponent InAimPivot, in TArray<FVector> InTargets, float AimSpeedDegPerSec = 30f, float AimToleranceDeg = 0.01f, bool bEaseIn = true, bool bEaseOut = true, bool bForceShortestRoute = false, float PostFireDelay = 0.05f, FRotator RotateOffset = default(FRotator), float TimeDilation = 1f)
		{
			UAsyncTaskRotateSequence.__StartRotateSequenceByTranslation_FunctionParams* ptr = stackalloc UAsyncTaskRotateSequence.__StartRotateSequenceByTranslation_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UAsyncTaskRotateSequence.__StartRotateSequenceByTranslation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskRotateSequence.__StartRotateSequenceByTranslation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TaskOwner = new FScriptInterface(TaskOwner, (TaskOwner != null) ? TaskOwner.InterfaceOffset() : 0);
			ptr->InAimPivot = ((InAimPivot != null) ? InAimPivot.NativePtr : IntPtr.Zero);
			TArray<FVector> tarray = InTargets;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InTargets);
			}
			ptr->AimSpeedDegPerSec = AimSpeedDegPerSec;
			ptr->AimToleranceDeg = AimToleranceDeg;
			ptr->bEaseIn = bEaseIn;
			ptr->bEaseOut = bEaseOut;
			ptr->bForceShortestRoute = bForceShortestRoute;
			ptr->PostFireDelay = PostFireDelay;
			ptr->RotateOffset = RotateOffset;
			ptr->TimeDilation = TimeDilation;
			UnrealReflectionUtils.CallUFunction(UAsyncTaskRotateSequence._ClassDefaultObjectPtr, UAsyncTaskRotateSequence.__StartRotateSequenceByTranslation_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FVector> tarray2 = InTargets;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InTargets);
			}
			UAsyncTaskRotateSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskRotateSequence>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UAsyncTaskRotateSequence.__StartRotateSequenceByTranslation_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06018090 RID: 98448 RVA: 0x002349D0 File Offset: 0x00232BD0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncTaskRotateSequence StartRotateSequenceByActor(IGameplayTaskOwnerInterface TaskOwner, USceneComponent InAimPivot, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> InTargets, float AimSpeedDegPerSec = 30f, float AimToleranceDeg = 0.01f, bool bEaseIn = true, bool bEaseOut = true, bool bForceShortestRoute = false, float PostFireDelay = 0.05f, FRotator RotateOffset = default(FRotator), float TimeDilation = 1f)
		{
			UAsyncTaskRotateSequence.__StartRotateSequenceByActor_FunctionParams* ptr = stackalloc UAsyncTaskRotateSequence.__StartRotateSequenceByActor_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UAsyncTaskRotateSequence.__StartRotateSequenceByActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskRotateSequence.__StartRotateSequenceByActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TaskOwner = new FScriptInterface(TaskOwner, (TaskOwner != null) ? TaskOwner.InterfaceOffset() : 0);
			ptr->InAimPivot = ((InAimPivot != null) ? InAimPivot.NativePtr : IntPtr.Zero);
			TArray<AActor> tarray = InTargets;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InTargets);
			}
			ptr->AimSpeedDegPerSec = AimSpeedDegPerSec;
			ptr->AimToleranceDeg = AimToleranceDeg;
			ptr->bEaseIn = bEaseIn;
			ptr->bEaseOut = bEaseOut;
			ptr->bForceShortestRoute = bForceShortestRoute;
			ptr->PostFireDelay = PostFireDelay;
			ptr->RotateOffset = RotateOffset;
			ptr->TimeDilation = TimeDilation;
			UnrealReflectionUtils.CallUFunction(UAsyncTaskRotateSequence._ClassDefaultObjectPtr, UAsyncTaskRotateSequence.__StartRotateSequenceByActor_NativeFunctionPtr, (void*)ptr, 0);
			TArray<AActor> tarray2 = InTargets;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InTargets);
			}
			UAsyncTaskRotateSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskRotateSequence>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UAsyncTaskRotateSequence.__StartRotateSequenceByActor_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06018091 RID: 98449 RVA: 0x00234AC0 File Offset: 0x00232CC0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RotateComponentTo(USceneComponent Component, FRotator TargetWorldRotation, bool bEaseOut, bool bEaseIn, float OverTime, bool bForceShortestRotationPath, float TimeDilation, ERotateComponentAction MoveAction, FLatentActionInfo LatentInfo)
		{
			UAsyncTaskRotateSequence.__RotateComponentTo_FunctionParams* ptr = stackalloc UAsyncTaskRotateSequence.__RotateComponentTo_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(UAsyncTaskRotateSequence.__RotateComponentTo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskRotateSequence.__RotateComponentTo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Component = ((Component != null) ? Component.NativePtr : IntPtr.Zero);
			ptr->TargetWorldRotation = TargetWorldRotation;
			ptr->bEaseOut = bEaseOut;
			ptr->bEaseIn = bEaseIn;
			ptr->OverTime = OverTime;
			ptr->bForceShortestRotationPath = bForceShortestRotationPath;
			ptr->TimeDilation = TimeDilation;
			ptr->MoveAction = MoveAction;
			if (LatentInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FLatentActionInfo.StaticStruct(), &ptr->LatentInfo, LatentInfo.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAsyncTaskRotateSequence._ClassDefaultObjectPtr, UAsyncTaskRotateSequence.__RotateComponentTo_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06018092 RID: 98450 RVA: 0x00234B73 File Offset: 0x00232D73
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void OnAimLatentFinished()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncTaskRotateSequence.__OnAimLatentFinished_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018093 RID: 98451 RVA: 0x00234B88 File Offset: 0x00232D88
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncTaskRotateSequence D_StartRotateSequenceByTranslation(IGameplayTaskOwnerInterface TaskOwner, USceneComponent InAimPivot, in TArray<FVectorDouble> InTargets, float AimSpeedDegPerSec = 30f, float AimToleranceDeg = 0.01f, bool bEaseIn = true, bool bEaseOut = true, bool bForceShortestRoute = false, float PostFireDelay = 0.05f, FRotator RotateOffset = default(FRotator), float TimeDilation = 1f)
		{
			UAsyncTaskRotateSequence.__D_StartRotateSequenceByTranslation_FunctionParams* ptr = stackalloc UAsyncTaskRotateSequence.__D_StartRotateSequenceByTranslation_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UAsyncTaskRotateSequence.__D_StartRotateSequenceByTranslation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskRotateSequence.__D_StartRotateSequenceByTranslation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TaskOwner = new FScriptInterface(TaskOwner, (TaskOwner != null) ? TaskOwner.InterfaceOffset() : 0);
			ptr->InAimPivot = ((InAimPivot != null) ? InAimPivot.NativePtr : IntPtr.Zero);
			TArray<FVectorDouble> tarray = InTargets;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InTargets);
			}
			ptr->AimSpeedDegPerSec = AimSpeedDegPerSec;
			ptr->AimToleranceDeg = AimToleranceDeg;
			ptr->bEaseIn = bEaseIn;
			ptr->bEaseOut = bEaseOut;
			ptr->bForceShortestRoute = bForceShortestRoute;
			ptr->PostFireDelay = PostFireDelay;
			ptr->RotateOffset = RotateOffset;
			ptr->TimeDilation = TimeDilation;
			UnrealReflectionUtils.CallUFunction(UAsyncTaskRotateSequence._ClassDefaultObjectPtr, UAsyncTaskRotateSequence.__D_StartRotateSequenceByTranslation_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FVectorDouble> tarray2 = InTargets;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InTargets);
			}
			UAsyncTaskRotateSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskRotateSequence>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UAsyncTaskRotateSequence.__D_StartRotateSequenceByTranslation_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06018094 RID: 98452 RVA: 0x00234C78 File Offset: 0x00232E78
		static UAsyncTaskRotateSequence()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AsyncTaskRotateSequence");
		}

		// Token: 0x06018095 RID: 98453 RVA: 0x00234C86 File Offset: 0x00232E86
		protected UAsyncTaskRotateSequence(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D003 RID: 53251
		public new const string __ObjectPath = "/Script/KuroGAS.AsyncTaskRotateSequence";

		// Token: 0x0400D004 RID: 53252
		private static IntPtr _ClassPtr;

		// Token: 0x0400D005 RID: 53253
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D006 RID: 53254
		internal static int __PropertyOffset_OnShootStepFired;

		// Token: 0x0400D007 RID: 53255
		[Nullable(2)]
		private FOnRotateStepSignature _OnShootStepFired;

		// Token: 0x0400D008 RID: 53256
		internal static int __PropertyOffset_OnSequenceFinished;

		// Token: 0x0400D009 RID: 53257
		[Nullable(2)]
		private FOnRotateSequenceFinishedSignature _OnSequenceFinished;

		// Token: 0x0400D00A RID: 53258
		internal static int __PropertyOffset_AimToleranceDeg;

		// Token: 0x0400D00B RID: 53259
		internal static int __PropertyOffset_AimSpeedDegPerSec;

		// Token: 0x0400D00C RID: 53260
		internal static int __PropertyOffset_PostFireDelay;

		// Token: 0x0400D00D RID: 53261
		internal static int __PropertyOffset_TimeDilation;

		// Token: 0x0400D00E RID: 53262
		internal static int __PropertyOffset_bEaseOut;

		// Token: 0x0400D00F RID: 53263
		internal static byte __PropertyMask_bEaseOut;

		// Token: 0x0400D010 RID: 53264
		internal static int __PropertyOffset_bEaseIn;

		// Token: 0x0400D011 RID: 53265
		internal static byte __PropertyMask_bEaseIn;

		// Token: 0x0400D012 RID: 53266
		internal static int __PropertyOffset_bForceShortestRoute;

		// Token: 0x0400D013 RID: 53267
		internal static byte __PropertyMask_bForceShortestRoute;

		// Token: 0x0400D014 RID: 53268
		internal static int __PropertyOffset_RotateOffset;

		// Token: 0x0400D015 RID: 53269
		private static IntPtr __StartRotateSequenceByTranslation_NativeFunctionPtr;

		// Token: 0x0400D016 RID: 53270
		private static IntPtr __StartRotateSequenceByActor_NativeFunctionPtr;

		// Token: 0x0400D017 RID: 53271
		private static IntPtr __RotateComponentTo_NativeFunctionPtr;

		// Token: 0x0400D018 RID: 53272
		private static IntPtr __OnAimLatentFinished_NativeFunctionPtr;

		// Token: 0x0400D019 RID: 53273
		private static IntPtr __D_StartRotateSequenceByTranslation_NativeFunctionPtr;

		// Token: 0x02003028 RID: 12328
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __StartRotateSequenceByTranslation_FunctionParams
		{
			// Token: 0x04016C72 RID: 93298
			[FieldOffset(0)]
			public FScriptInterface TaskOwner;

			// Token: 0x04016C73 RID: 93299
			[FieldOffset(16)]
			public IntPtr InAimPivot;

			// Token: 0x04016C74 RID: 93300
			[FieldOffset(24)]
			public byte InTargets;

			// Token: 0x04016C75 RID: 93301
			[FieldOffset(40)]
			public float AimSpeedDegPerSec;

			// Token: 0x04016C76 RID: 93302
			[FieldOffset(44)]
			public float AimToleranceDeg;

			// Token: 0x04016C77 RID: 93303
			[FieldOffset(48)]
			public bool bEaseIn;

			// Token: 0x04016C78 RID: 93304
			[FieldOffset(49)]
			public bool bEaseOut;

			// Token: 0x04016C79 RID: 93305
			[FieldOffset(50)]
			public bool bForceShortestRoute;

			// Token: 0x04016C7A RID: 93306
			[FieldOffset(52)]
			public float PostFireDelay;

			// Token: 0x04016C7B RID: 93307
			[FieldOffset(56)]
			public FRotator RotateOffset;

			// Token: 0x04016C7C RID: 93308
			[FieldOffset(68)]
			public float TimeDilation;

			// Token: 0x04016C7D RID: 93309
			[FieldOffset(72)]
			public IntPtr __Result;
		}

		// Token: 0x02003029 RID: 12329
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __StartRotateSequenceByActor_FunctionParams
		{
			// Token: 0x04016C7E RID: 93310
			[FieldOffset(0)]
			public FScriptInterface TaskOwner;

			// Token: 0x04016C7F RID: 93311
			[FieldOffset(16)]
			public IntPtr InAimPivot;

			// Token: 0x04016C80 RID: 93312
			[FieldOffset(24)]
			public byte InTargets;

			// Token: 0x04016C81 RID: 93313
			[FieldOffset(40)]
			public float AimSpeedDegPerSec;

			// Token: 0x04016C82 RID: 93314
			[FieldOffset(44)]
			public float AimToleranceDeg;

			// Token: 0x04016C83 RID: 93315
			[FieldOffset(48)]
			public bool bEaseIn;

			// Token: 0x04016C84 RID: 93316
			[FieldOffset(49)]
			public bool bEaseOut;

			// Token: 0x04016C85 RID: 93317
			[FieldOffset(50)]
			public bool bForceShortestRoute;

			// Token: 0x04016C86 RID: 93318
			[FieldOffset(52)]
			public float PostFireDelay;

			// Token: 0x04016C87 RID: 93319
			[FieldOffset(56)]
			public FRotator RotateOffset;

			// Token: 0x04016C88 RID: 93320
			[FieldOffset(68)]
			public float TimeDilation;

			// Token: 0x04016C89 RID: 93321
			[FieldOffset(72)]
			public IntPtr __Result;
		}

		// Token: 0x0200302A RID: 12330
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __RotateComponentTo_FunctionParams
		{
			// Token: 0x04016C8A RID: 93322
			[FieldOffset(0)]
			public IntPtr Component;

			// Token: 0x04016C8B RID: 93323
			[FieldOffset(8)]
			public FRotator TargetWorldRotation;

			// Token: 0x04016C8C RID: 93324
			[FieldOffset(20)]
			public bool bEaseOut;

			// Token: 0x04016C8D RID: 93325
			[FieldOffset(21)]
			public bool bEaseIn;

			// Token: 0x04016C8E RID: 93326
			[FieldOffset(24)]
			public float OverTime;

			// Token: 0x04016C8F RID: 93327
			[FieldOffset(28)]
			public bool bForceShortestRotationPath;

			// Token: 0x04016C90 RID: 93328
			[FieldOffset(32)]
			public float TimeDilation;

			// Token: 0x04016C91 RID: 93329
			[FieldOffset(36)]
			public TEnumAsByte<ERotateComponentAction> MoveAction;

			// Token: 0x04016C92 RID: 93330
			[FieldOffset(40)]
			public byte LatentInfo;
		}

		// Token: 0x0200302B RID: 12331
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __D_StartRotateSequenceByTranslation_FunctionParams
		{
			// Token: 0x04016C93 RID: 93331
			[FieldOffset(0)]
			public FScriptInterface TaskOwner;

			// Token: 0x04016C94 RID: 93332
			[FieldOffset(16)]
			public IntPtr InAimPivot;

			// Token: 0x04016C95 RID: 93333
			[FieldOffset(24)]
			public byte InTargets;

			// Token: 0x04016C96 RID: 93334
			[FieldOffset(40)]
			public float AimSpeedDegPerSec;

			// Token: 0x04016C97 RID: 93335
			[FieldOffset(44)]
			public float AimToleranceDeg;

			// Token: 0x04016C98 RID: 93336
			[FieldOffset(48)]
			public bool bEaseIn;

			// Token: 0x04016C99 RID: 93337
			[FieldOffset(49)]
			public bool bEaseOut;

			// Token: 0x04016C9A RID: 93338
			[FieldOffset(50)]
			public bool bForceShortestRoute;

			// Token: 0x04016C9B RID: 93339
			[FieldOffset(52)]
			public float PostFireDelay;

			// Token: 0x04016C9C RID: 93340
			[FieldOffset(56)]
			public FRotator RotateOffset;

			// Token: 0x04016C9D RID: 93341
			[FieldOffset(68)]
			public float TimeDilation;

			// Token: 0x04016C9E RID: 93342
			[FieldOffset(72)]
			public IntPtr __Result;
		}
	}
}
