using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001955 RID: 6485
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AsyncTaskPlayMontageAndWait")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UAsyncTaskPlayMontageAndWait : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018063 RID: 98403 RVA: 0x002342E8 File Offset: 0x002324E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskPlayMontageAndWait._ClassPtr;
		}

		// Token: 0x06018064 RID: 98404 RVA: 0x002342F4 File Offset: 0x002324F4
		public UAsyncTaskPlayMontageAndWait() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskPlayMontageAndWait.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018065 RID: 98405 RVA: 0x0023431C File Offset: 0x0023251C
		public UAsyncTaskPlayMontageAndWait(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskPlayMontageAndWait.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700602D RID: 24621
		// (get) Token: 0x06018066 RID: 98406 RVA: 0x00234350 File Offset: 0x00232550
		// (set) Token: 0x06018067 RID: 98407 RVA: 0x00234389 File Offset: 0x00232589
		public FOnMontagePlayCallback EndCallback
		{
			get
			{
				base.FastCheckIsValid();
				FOnMontagePlayCallback result;
				if ((result = this._EndCallback) == null)
				{
					result = (this._EndCallback = new FOnMontagePlayCallback(base.NativePtr + (IntPtr)UAsyncTaskPlayMontageAndWait.__PropertyOffset_EndCallback, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTaskPlayMontageAndWait.__PropertyOffset_EndCallback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700602E RID: 24622
		// (get) Token: 0x06018068 RID: 98408 RVA: 0x002343AC File Offset: 0x002325AC
		// (set) Token: 0x06018069 RID: 98409 RVA: 0x002343E5 File Offset: 0x002325E5
		public FOnMontagePlayCallback BlendOutCallback
		{
			get
			{
				base.FastCheckIsValid();
				FOnMontagePlayCallback result;
				if ((result = this._BlendOutCallback) == null)
				{
					result = (this._BlendOutCallback = new FOnMontagePlayCallback(base.NativePtr + (IntPtr)UAsyncTaskPlayMontageAndWait.__PropertyOffset_BlendOutCallback, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTaskPlayMontageAndWait.__PropertyOffset_BlendOutCallback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700602F RID: 24623
		// (get) Token: 0x0601806A RID: 98410 RVA: 0x00234408 File Offset: 0x00232608
		// (set) Token: 0x0601806B RID: 98411 RVA: 0x00234441 File Offset: 0x00232641
		public FOnMontageRemainCallback RemainCallback
		{
			get
			{
				base.FastCheckIsValid();
				FOnMontageRemainCallback result;
				if ((result = this._RemainCallback) == null)
				{
					result = (this._RemainCallback = new FOnMontageRemainCallback(base.NativePtr + (IntPtr)UAsyncTaskPlayMontageAndWait.__PropertyOffset_RemainCallback, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTaskPlayMontageAndWait.__PropertyOffset_RemainCallback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006030 RID: 24624
		// (get) Token: 0x0601806C RID: 98412 RVA: 0x00234462 File Offset: 0x00232662
		// (set) Token: 0x0601806D RID: 98413 RVA: 0x00234472 File Offset: 0x00232672
		public unsafe float MontageLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAsyncTaskPlayMontageAndWait.__PropertyOffset_MontageLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAsyncTaskPlayMontageAndWait.__PropertyOffset_MontageLength) = value;
			}
		}

		// Token: 0x17006031 RID: 24625
		// (get) Token: 0x0601806E RID: 98414 RVA: 0x00234483 File Offset: 0x00232683
		// (set) Token: 0x0601806F RID: 98415 RVA: 0x00234497 File Offset: 0x00232697
		[Nullable(2)]
		public unsafe UAnimInstance AnimInstance
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimInstance>(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskPlayMontageAndWait.__PropertyOffset_AnimInstance);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskPlayMontageAndWait.__PropertyOffset_AnimInstance, value);
			}
		}

		// Token: 0x17006032 RID: 24626
		// (get) Token: 0x06018070 RID: 98416 RVA: 0x002344AC File Offset: 0x002326AC
		// (set) Token: 0x06018071 RID: 98417 RVA: 0x002344C0 File Offset: 0x002326C0
		[Nullable(2)]
		public unsafe UAnimMontage MontageToPlay
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskPlayMontageAndWait.__PropertyOffset_MontageToPlay);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskPlayMontageAndWait.__PropertyOffset_MontageToPlay, value);
			}
		}

		// Token: 0x06018072 RID: 98418 RVA: 0x002344D5 File Offset: 0x002326D5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void StopMontage()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncTaskPlayMontageAndWait.__StopMontage_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018073 RID: 98419 RVA: 0x002344EC File Offset: 0x002326EC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncTaskPlayMontageAndWait ListenRemainForPlayMontage(UAnimInstance AnimInstance, UAnimMontage MontageToPlay, float PlayRate, float StartingPosition, FName StartingSection, float RemainedTrigger)
		{
			UAsyncTaskPlayMontageAndWait.__ListenRemainForPlayMontage_FunctionParams* ptr = stackalloc UAsyncTaskPlayMontageAndWait.__ListenRemainForPlayMontage_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UAsyncTaskPlayMontageAndWait.__ListenRemainForPlayMontage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskPlayMontageAndWait.__ListenRemainForPlayMontage_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AnimInstance = ((AnimInstance != null) ? AnimInstance.NativePtr : IntPtr.Zero);
			ptr->MontageToPlay = ((MontageToPlay != null) ? MontageToPlay.NativePtr : IntPtr.Zero);
			ptr->PlayRate = PlayRate;
			ptr->StartingPosition = StartingPosition;
			ptr->StartingSection = StartingSection;
			ptr->RemainedTrigger = RemainedTrigger;
			UnrealReflectionUtils.CallUFunction(UAsyncTaskPlayMontageAndWait._ClassDefaultObjectPtr, UAsyncTaskPlayMontageAndWait.__ListenRemainForPlayMontage_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskPlayMontageAndWait>(ptr->__Result);
		}

		// Token: 0x06018074 RID: 98420 RVA: 0x00234580 File Offset: 0x00232780
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncTaskPlayMontageAndWait ListenForPlayMontage(UAnimInstance AnimInstance, UAnimMontage MontageToPlay, float PlayRate, float StartingPosition, FName StartingSection)
		{
			UAsyncTaskPlayMontageAndWait.__ListenForPlayMontage_FunctionParams* ptr = stackalloc UAsyncTaskPlayMontageAndWait.__ListenForPlayMontage_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UAsyncTaskPlayMontageAndWait.__ListenForPlayMontage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskPlayMontageAndWait.__ListenForPlayMontage_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AnimInstance = ((AnimInstance != null) ? AnimInstance.NativePtr : IntPtr.Zero);
			ptr->MontageToPlay = ((MontageToPlay != null) ? MontageToPlay.NativePtr : IntPtr.Zero);
			ptr->PlayRate = PlayRate;
			ptr->StartingPosition = StartingPosition;
			ptr->StartingSection = StartingSection;
			UnrealReflectionUtils.CallUFunction(UAsyncTaskPlayMontageAndWait._ClassDefaultObjectPtr, UAsyncTaskPlayMontageAndWait.__ListenForPlayMontage_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskPlayMontageAndWait>(ptr->__Result);
		}

		// Token: 0x06018075 RID: 98421 RVA: 0x0023460C File Offset: 0x0023280C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void EndTask()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncTaskPlayMontageAndWait.__EndTask_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018076 RID: 98422 RVA: 0x00234621 File Offset: 0x00232821
		static UAsyncTaskPlayMontageAndWait()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AsyncTaskPlayMontageAndWait");
		}

		// Token: 0x06018077 RID: 98423 RVA: 0x0023462F File Offset: 0x0023282F
		protected UAsyncTaskPlayMontageAndWait(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CFF3 RID: 53235
		public new const string __ObjectPath = "/Script/KuroGAS.AsyncTaskPlayMontageAndWait";

		// Token: 0x0400CFF4 RID: 53236
		private static IntPtr _ClassPtr;

		// Token: 0x0400CFF5 RID: 53237
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CFF6 RID: 53238
		internal static int __PropertyOffset_EndCallback;

		// Token: 0x0400CFF7 RID: 53239
		[Nullable(2)]
		private FOnMontagePlayCallback _EndCallback;

		// Token: 0x0400CFF8 RID: 53240
		internal static int __PropertyOffset_BlendOutCallback;

		// Token: 0x0400CFF9 RID: 53241
		[Nullable(2)]
		private FOnMontagePlayCallback _BlendOutCallback;

		// Token: 0x0400CFFA RID: 53242
		internal static int __PropertyOffset_RemainCallback;

		// Token: 0x0400CFFB RID: 53243
		[Nullable(2)]
		private FOnMontageRemainCallback _RemainCallback;

		// Token: 0x0400CFFC RID: 53244
		internal static int __PropertyOffset_MontageLength;

		// Token: 0x0400CFFD RID: 53245
		internal static int __PropertyOffset_AnimInstance;

		// Token: 0x0400CFFE RID: 53246
		internal static int __PropertyOffset_MontageToPlay;

		// Token: 0x0400CFFF RID: 53247
		private static IntPtr __StopMontage_NativeFunctionPtr;

		// Token: 0x0400D000 RID: 53248
		private static IntPtr __ListenRemainForPlayMontage_NativeFunctionPtr;

		// Token: 0x0400D001 RID: 53249
		private static IntPtr __ListenForPlayMontage_NativeFunctionPtr;

		// Token: 0x0400D002 RID: 53250
		private static IntPtr __EndTask_NativeFunctionPtr;

		// Token: 0x02003026 RID: 12326
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __ListenRemainForPlayMontage_FunctionParams
		{
			// Token: 0x04016C65 RID: 93285
			[FieldOffset(0)]
			public IntPtr AnimInstance;

			// Token: 0x04016C66 RID: 93286
			[FieldOffset(8)]
			public IntPtr MontageToPlay;

			// Token: 0x04016C67 RID: 93287
			[FieldOffset(16)]
			public float PlayRate;

			// Token: 0x04016C68 RID: 93288
			[FieldOffset(20)]
			public float StartingPosition;

			// Token: 0x04016C69 RID: 93289
			[FieldOffset(24)]
			public FName StartingSection;

			// Token: 0x04016C6A RID: 93290
			[FieldOffset(36)]
			public float RemainedTrigger;

			// Token: 0x04016C6B RID: 93291
			[FieldOffset(40)]
			public IntPtr __Result;
		}

		// Token: 0x02003027 RID: 12327
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __ListenForPlayMontage_FunctionParams
		{
			// Token: 0x04016C6C RID: 93292
			[FieldOffset(0)]
			public IntPtr AnimInstance;

			// Token: 0x04016C6D RID: 93293
			[FieldOffset(8)]
			public IntPtr MontageToPlay;

			// Token: 0x04016C6E RID: 93294
			[FieldOffset(16)]
			public float PlayRate;

			// Token: 0x04016C6F RID: 93295
			[FieldOffset(20)]
			public float StartingPosition;

			// Token: 0x04016C70 RID: 93296
			[FieldOffset(24)]
			public FName StartingSection;

			// Token: 0x04016C71 RID: 93297
			[FieldOffset(40)]
			public IntPtr __Result;
		}
	}
}
