using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200042D RID: 1069
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AsyncTaskRotateSequence")]
	[UnrealStructLayout(496, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UAsyncTaskRotateSequence : UGameplayTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600669E RID: 26270 RVA: 0x00093E2A File Offset: 0x0009202A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskRotateSequence._ClassPtr;
		}

		// Token: 0x0600669F RID: 26271 RVA: 0x00093E38 File Offset: 0x00092038
		public UAsyncTaskRotateSequence() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskRotateSequence.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060066A0 RID: 26272 RVA: 0x00093E60 File Offset: 0x00092060
		public UAsyncTaskRotateSequence(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskRotateSequence.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x060066A1 RID: 26273 RVA: 0x00093E94 File Offset: 0x00092094
		// (set) Token: 0x060066A2 RID: 26274 RVA: 0x00093ECD File Offset: 0x000920CD
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

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x060066A3 RID: 26275 RVA: 0x00093EF0 File Offset: 0x000920F0
		// (set) Token: 0x060066A4 RID: 26276 RVA: 0x00093F29 File Offset: 0x00092129
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

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x060066A5 RID: 26277 RVA: 0x00093F4A File Offset: 0x0009214A
		// (set) Token: 0x060066A6 RID: 26278 RVA: 0x00093F5A File Offset: 0x0009215A
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

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x060066A7 RID: 26279 RVA: 0x00093F6B File Offset: 0x0009216B
		// (set) Token: 0x060066A8 RID: 26280 RVA: 0x00093F7B File Offset: 0x0009217B
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

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x060066A9 RID: 26281 RVA: 0x00093F8C File Offset: 0x0009218C
		// (set) Token: 0x060066AA RID: 26282 RVA: 0x00093F9C File Offset: 0x0009219C
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

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x060066AB RID: 26283 RVA: 0x00093FAD File Offset: 0x000921AD
		// (set) Token: 0x060066AC RID: 26284 RVA: 0x00093FBD File Offset: 0x000921BD
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

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x060066AD RID: 26285 RVA: 0x00093FCE File Offset: 0x000921CE
		// (set) Token: 0x060066AE RID: 26286 RVA: 0x00093FE7 File Offset: 0x000921E7
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

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x060066AF RID: 26287 RVA: 0x00094017 File Offset: 0x00092217
		// (set) Token: 0x060066B0 RID: 26288 RVA: 0x00094030 File Offset: 0x00092230
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

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x060066B1 RID: 26289 RVA: 0x00094060 File Offset: 0x00092260
		// (set) Token: 0x060066B2 RID: 26290 RVA: 0x00094079 File Offset: 0x00092279
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

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x060066B3 RID: 26291 RVA: 0x000940A9 File Offset: 0x000922A9
		// (set) Token: 0x060066B4 RID: 26292 RVA: 0x000940BD File Offset: 0x000922BD
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

		// Token: 0x060066B5 RID: 26293 RVA: 0x000940D4 File Offset: 0x000922D4
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UAsyncTaskRotateSequence._ClassDefaultObjectPtr, UAsyncTaskRotateSequence.__StartRotateSequenceByTranslation_NativeFunctionPtr, (void*)ptr);
			TArray<FVector> tarray2 = InTargets;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InTargets);
			}
			UAsyncTaskRotateSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskRotateSequence>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UAsyncTaskRotateSequence.__StartRotateSequenceByTranslation_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x060066B6 RID: 26294 RVA: 0x000941C4 File Offset: 0x000923C4
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UAsyncTaskRotateSequence._ClassDefaultObjectPtr, UAsyncTaskRotateSequence.__StartRotateSequenceByActor_NativeFunctionPtr, (void*)ptr);
			TArray<AActor> tarray2 = InTargets;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InTargets);
			}
			UAsyncTaskRotateSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskRotateSequence>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UAsyncTaskRotateSequence.__StartRotateSequenceByActor_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x060066B7 RID: 26295 RVA: 0x000942B3 File Offset: 0x000924B3
		[SkipLocalsInit]
		public void OnAimLatentFinished()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncTaskRotateSequence.__OnAimLatentFinished_NativeFunctionPtr, null);
		}

		// Token: 0x060066B8 RID: 26296 RVA: 0x000942C8 File Offset: 0x000924C8
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UAsyncTaskRotateSequence._ClassDefaultObjectPtr, UAsyncTaskRotateSequence.__D_StartRotateSequenceByTranslation_NativeFunctionPtr, (void*)ptr);
			TArray<FVectorDouble> tarray2 = InTargets;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InTargets);
			}
			UAsyncTaskRotateSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskRotateSequence>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UAsyncTaskRotateSequence.__D_StartRotateSequenceByTranslation_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x060066B9 RID: 26297 RVA: 0x000943B7 File Offset: 0x000925B7
		static UAsyncTaskRotateSequence()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AsyncTaskRotateSequence");
		}

		// Token: 0x060066BA RID: 26298 RVA: 0x000943C5 File Offset: 0x000925C5
		protected UAsyncTaskRotateSequence(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002B32 RID: 11058
		public new const string __ObjectPath = "/Script/KuroGAS.AsyncTaskRotateSequence";

		// Token: 0x04002B33 RID: 11059
		private static IntPtr _ClassPtr;

		// Token: 0x04002B34 RID: 11060
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002B35 RID: 11061
		internal static int __PropertyOffset_OnShootStepFired;

		// Token: 0x04002B36 RID: 11062
		[Nullable(2)]
		private FOnRotateStepSignature _OnShootStepFired;

		// Token: 0x04002B37 RID: 11063
		internal static int __PropertyOffset_OnSequenceFinished;

		// Token: 0x04002B38 RID: 11064
		[Nullable(2)]
		private FOnRotateSequenceFinishedSignature _OnSequenceFinished;

		// Token: 0x04002B39 RID: 11065
		internal static int __PropertyOffset_AimToleranceDeg;

		// Token: 0x04002B3A RID: 11066
		internal static int __PropertyOffset_AimSpeedDegPerSec;

		// Token: 0x04002B3B RID: 11067
		internal static int __PropertyOffset_PostFireDelay;

		// Token: 0x04002B3C RID: 11068
		internal static int __PropertyOffset_TimeDilation;

		// Token: 0x04002B3D RID: 11069
		internal static int __PropertyOffset_bEaseOut;

		// Token: 0x04002B3E RID: 11070
		internal static byte __PropertyMask_bEaseOut;

		// Token: 0x04002B3F RID: 11071
		internal static int __PropertyOffset_bEaseIn;

		// Token: 0x04002B40 RID: 11072
		internal static byte __PropertyMask_bEaseIn;

		// Token: 0x04002B41 RID: 11073
		internal static int __PropertyOffset_bForceShortestRoute;

		// Token: 0x04002B42 RID: 11074
		internal static byte __PropertyMask_bForceShortestRoute;

		// Token: 0x04002B43 RID: 11075
		internal static int __PropertyOffset_RotateOffset;

		// Token: 0x04002B44 RID: 11076
		private static IntPtr __StartRotateSequenceByTranslation_NativeFunctionPtr;

		// Token: 0x04002B45 RID: 11077
		private static IntPtr __StartRotateSequenceByActor_NativeFunctionPtr;

		// Token: 0x04002B46 RID: 11078
		private static IntPtr __OnAimLatentFinished_NativeFunctionPtr;

		// Token: 0x04002B47 RID: 11079
		private static IntPtr __D_StartRotateSequenceByTranslation_NativeFunctionPtr;

		// Token: 0x02000B37 RID: 2871
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __StartRotateSequenceByTranslation_FunctionParams
		{
			// Token: 0x04005C11 RID: 23569
			[FieldOffset(0)]
			public FScriptInterface TaskOwner;

			// Token: 0x04005C12 RID: 23570
			[FieldOffset(16)]
			public IntPtr InAimPivot;

			// Token: 0x04005C13 RID: 23571
			[FieldOffset(24)]
			public byte InTargets;

			// Token: 0x04005C14 RID: 23572
			[FieldOffset(40)]
			public float AimSpeedDegPerSec;

			// Token: 0x04005C15 RID: 23573
			[FieldOffset(44)]
			public float AimToleranceDeg;

			// Token: 0x04005C16 RID: 23574
			[FieldOffset(48)]
			public bool bEaseIn;

			// Token: 0x04005C17 RID: 23575
			[FieldOffset(49)]
			public bool bEaseOut;

			// Token: 0x04005C18 RID: 23576
			[FieldOffset(50)]
			public bool bForceShortestRoute;

			// Token: 0x04005C19 RID: 23577
			[FieldOffset(52)]
			public float PostFireDelay;

			// Token: 0x04005C1A RID: 23578
			[FieldOffset(56)]
			public FRotator RotateOffset;

			// Token: 0x04005C1B RID: 23579
			[FieldOffset(68)]
			public float TimeDilation;

			// Token: 0x04005C1C RID: 23580
			[FieldOffset(72)]
			public IntPtr __Result;
		}

		// Token: 0x02000B38 RID: 2872
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __StartRotateSequenceByActor_FunctionParams
		{
			// Token: 0x04005C1D RID: 23581
			[FieldOffset(0)]
			public FScriptInterface TaskOwner;

			// Token: 0x04005C1E RID: 23582
			[FieldOffset(16)]
			public IntPtr InAimPivot;

			// Token: 0x04005C1F RID: 23583
			[FieldOffset(24)]
			public byte InTargets;

			// Token: 0x04005C20 RID: 23584
			[FieldOffset(40)]
			public float AimSpeedDegPerSec;

			// Token: 0x04005C21 RID: 23585
			[FieldOffset(44)]
			public float AimToleranceDeg;

			// Token: 0x04005C22 RID: 23586
			[FieldOffset(48)]
			public bool bEaseIn;

			// Token: 0x04005C23 RID: 23587
			[FieldOffset(49)]
			public bool bEaseOut;

			// Token: 0x04005C24 RID: 23588
			[FieldOffset(50)]
			public bool bForceShortestRoute;

			// Token: 0x04005C25 RID: 23589
			[FieldOffset(52)]
			public float PostFireDelay;

			// Token: 0x04005C26 RID: 23590
			[FieldOffset(56)]
			public FRotator RotateOffset;

			// Token: 0x04005C27 RID: 23591
			[FieldOffset(68)]
			public float TimeDilation;

			// Token: 0x04005C28 RID: 23592
			[FieldOffset(72)]
			public IntPtr __Result;
		}

		// Token: 0x02000B39 RID: 2873
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __D_StartRotateSequenceByTranslation_FunctionParams
		{
			// Token: 0x04005C29 RID: 23593
			[FieldOffset(0)]
			public FScriptInterface TaskOwner;

			// Token: 0x04005C2A RID: 23594
			[FieldOffset(16)]
			public IntPtr InAimPivot;

			// Token: 0x04005C2B RID: 23595
			[FieldOffset(24)]
			public byte InTargets;

			// Token: 0x04005C2C RID: 23596
			[FieldOffset(40)]
			public float AimSpeedDegPerSec;

			// Token: 0x04005C2D RID: 23597
			[FieldOffset(44)]
			public float AimToleranceDeg;

			// Token: 0x04005C2E RID: 23598
			[FieldOffset(48)]
			public bool bEaseIn;

			// Token: 0x04005C2F RID: 23599
			[FieldOffset(49)]
			public bool bEaseOut;

			// Token: 0x04005C30 RID: 23600
			[FieldOffset(50)]
			public bool bForceShortestRoute;

			// Token: 0x04005C31 RID: 23601
			[FieldOffset(52)]
			public float PostFireDelay;

			// Token: 0x04005C32 RID: 23602
			[FieldOffset(56)]
			public FRotator RotateOffset;

			// Token: 0x04005C33 RID: 23603
			[FieldOffset(68)]
			public float TimeDilation;

			// Token: 0x04005C34 RID: 23604
			[FieldOffset(72)]
			public IntPtr __Result;
		}
	}
}
