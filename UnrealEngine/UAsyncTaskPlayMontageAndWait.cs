using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200042C RID: 1068
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AsyncTaskPlayMontageAndWait")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UAsyncTaskPlayMontageAndWait : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006689 RID: 26249 RVA: 0x00093ADA File Offset: 0x00091CDA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskPlayMontageAndWait._ClassPtr;
		}

		// Token: 0x0600668A RID: 26250 RVA: 0x00093AE8 File Offset: 0x00091CE8
		public UAsyncTaskPlayMontageAndWait() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskPlayMontageAndWait.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600668B RID: 26251 RVA: 0x00093B10 File Offset: 0x00091D10
		public UAsyncTaskPlayMontageAndWait(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskPlayMontageAndWait.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x0600668C RID: 26252 RVA: 0x00093B44 File Offset: 0x00091D44
		// (set) Token: 0x0600668D RID: 26253 RVA: 0x00093B7D File Offset: 0x00091D7D
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

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x0600668E RID: 26254 RVA: 0x00093BA0 File Offset: 0x00091DA0
		// (set) Token: 0x0600668F RID: 26255 RVA: 0x00093BD9 File Offset: 0x00091DD9
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

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x06006690 RID: 26256 RVA: 0x00093BFC File Offset: 0x00091DFC
		// (set) Token: 0x06006691 RID: 26257 RVA: 0x00093C35 File Offset: 0x00091E35
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

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x06006692 RID: 26258 RVA: 0x00093C56 File Offset: 0x00091E56
		// (set) Token: 0x06006693 RID: 26259 RVA: 0x00093C66 File Offset: 0x00091E66
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

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x06006694 RID: 26260 RVA: 0x00093C77 File Offset: 0x00091E77
		// (set) Token: 0x06006695 RID: 26261 RVA: 0x00093C8B File Offset: 0x00091E8B
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

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x06006696 RID: 26262 RVA: 0x00093CA0 File Offset: 0x00091EA0
		// (set) Token: 0x06006697 RID: 26263 RVA: 0x00093CB4 File Offset: 0x00091EB4
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

		// Token: 0x06006698 RID: 26264 RVA: 0x00093CC9 File Offset: 0x00091EC9
		[SkipLocalsInit]
		public void StopMontage()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncTaskPlayMontageAndWait.__StopMontage_NativeFunctionPtr, null);
		}

		// Token: 0x06006699 RID: 26265 RVA: 0x00093CE0 File Offset: 0x00091EE0
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UAsyncTaskPlayMontageAndWait._ClassDefaultObjectPtr, UAsyncTaskPlayMontageAndWait.__ListenRemainForPlayMontage_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskPlayMontageAndWait>(ptr->__Result);
		}

		// Token: 0x0600669A RID: 26266 RVA: 0x00093D74 File Offset: 0x00091F74
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static UAsyncTaskPlayMontageAndWait ListenForPlayMontage(UAnimInstance AnimInstance, UAnimMontage MontageToPlay, float PlayRate, float StartingPosition, FName StartingSection)
		{
			UAsyncTaskPlayMontageAndWait.__ListenForPlayMontage_FunctionParams* ptr = stackalloc UAsyncTaskPlayMontageAndWait.__ListenForPlayMontage_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UAsyncTaskPlayMontageAndWait.__ListenForPlayMontage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskPlayMontageAndWait.__ListenForPlayMontage_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AnimInstance = ((AnimInstance != null) ? AnimInstance.NativePtr : IntPtr.Zero);
			ptr->MontageToPlay = ((MontageToPlay != null) ? MontageToPlay.NativePtr : IntPtr.Zero);
			ptr->PlayRate = PlayRate;
			ptr->StartingPosition = StartingPosition;
			ptr->StartingSection = StartingSection;
			UnrealReflectionUtils.CallUFunction(UAsyncTaskPlayMontageAndWait._ClassDefaultObjectPtr, UAsyncTaskPlayMontageAndWait.__ListenForPlayMontage_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskPlayMontageAndWait>(ptr->__Result);
		}

		// Token: 0x0600669B RID: 26267 RVA: 0x00093DFF File Offset: 0x00091FFF
		[SkipLocalsInit]
		public void EndTask()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncTaskPlayMontageAndWait.__EndTask_NativeFunctionPtr, null);
		}

		// Token: 0x0600669C RID: 26268 RVA: 0x00093E13 File Offset: 0x00092013
		static UAsyncTaskPlayMontageAndWait()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AsyncTaskPlayMontageAndWait");
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x00093E21 File Offset: 0x00092021
		protected UAsyncTaskPlayMontageAndWait(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002B22 RID: 11042
		public new const string __ObjectPath = "/Script/KuroGAS.AsyncTaskPlayMontageAndWait";

		// Token: 0x04002B23 RID: 11043
		private static IntPtr _ClassPtr;

		// Token: 0x04002B24 RID: 11044
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002B25 RID: 11045
		internal static int __PropertyOffset_EndCallback;

		// Token: 0x04002B26 RID: 11046
		[Nullable(2)]
		private FOnMontagePlayCallback _EndCallback;

		// Token: 0x04002B27 RID: 11047
		internal static int __PropertyOffset_BlendOutCallback;

		// Token: 0x04002B28 RID: 11048
		[Nullable(2)]
		private FOnMontagePlayCallback _BlendOutCallback;

		// Token: 0x04002B29 RID: 11049
		internal static int __PropertyOffset_RemainCallback;

		// Token: 0x04002B2A RID: 11050
		[Nullable(2)]
		private FOnMontageRemainCallback _RemainCallback;

		// Token: 0x04002B2B RID: 11051
		internal static int __PropertyOffset_MontageLength;

		// Token: 0x04002B2C RID: 11052
		internal static int __PropertyOffset_AnimInstance;

		// Token: 0x04002B2D RID: 11053
		internal static int __PropertyOffset_MontageToPlay;

		// Token: 0x04002B2E RID: 11054
		private static IntPtr __StopMontage_NativeFunctionPtr;

		// Token: 0x04002B2F RID: 11055
		private static IntPtr __ListenRemainForPlayMontage_NativeFunctionPtr;

		// Token: 0x04002B30 RID: 11056
		private static IntPtr __ListenForPlayMontage_NativeFunctionPtr;

		// Token: 0x04002B31 RID: 11057
		private static IntPtr __EndTask_NativeFunctionPtr;

		// Token: 0x02000B35 RID: 2869
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __ListenRemainForPlayMontage_FunctionParams
		{
			// Token: 0x04005C04 RID: 23556
			[FieldOffset(0)]
			public IntPtr AnimInstance;

			// Token: 0x04005C05 RID: 23557
			[FieldOffset(8)]
			public IntPtr MontageToPlay;

			// Token: 0x04005C06 RID: 23558
			[FieldOffset(16)]
			public float PlayRate;

			// Token: 0x04005C07 RID: 23559
			[FieldOffset(20)]
			public float StartingPosition;

			// Token: 0x04005C08 RID: 23560
			[FieldOffset(24)]
			public FName StartingSection;

			// Token: 0x04005C09 RID: 23561
			[FieldOffset(36)]
			public float RemainedTrigger;

			// Token: 0x04005C0A RID: 23562
			[FieldOffset(40)]
			public IntPtr __Result;
		}

		// Token: 0x02000B36 RID: 2870
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __ListenForPlayMontage_FunctionParams
		{
			// Token: 0x04005C0B RID: 23563
			[FieldOffset(0)]
			public IntPtr AnimInstance;

			// Token: 0x04005C0C RID: 23564
			[FieldOffset(8)]
			public IntPtr MontageToPlay;

			// Token: 0x04005C0D RID: 23565
			[FieldOffset(16)]
			public float PlayRate;

			// Token: 0x04005C0E RID: 23566
			[FieldOffset(20)]
			public float StartingPosition;

			// Token: 0x04005C0F RID: 23567
			[FieldOffset(24)]
			public FName StartingSection;

			// Token: 0x04005C10 RID: 23568
			[FieldOffset(40)]
			public IntPtr __Result;
		}
	}
}
