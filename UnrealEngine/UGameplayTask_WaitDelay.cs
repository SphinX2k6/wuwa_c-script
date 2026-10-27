using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013F8 RID: 5112
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTasks.GameplayTask_WaitDelay")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UGameplayTask_WaitDelay : UGameplayTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012AA7 RID: 76455 RVA: 0x001B7921 File Offset: 0x001B5B21
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayTask_WaitDelay._ClassPtr;
		}

		// Token: 0x06012AA8 RID: 76456 RVA: 0x001B7930 File Offset: 0x001B5B30
		public UGameplayTask_WaitDelay() : this(BuiltinUtils.AllocNativeUObject(UGameplayTask_WaitDelay.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012AA9 RID: 76457 RVA: 0x001B7958 File Offset: 0x001B5B58
		public UGameplayTask_WaitDelay(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayTask_WaitDelay.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004852 RID: 18514
		// (get) Token: 0x06012AAA RID: 76458 RVA: 0x001B798C File Offset: 0x001B5B8C
		// (set) Token: 0x06012AAB RID: 76459 RVA: 0x001B79C5 File Offset: 0x001B5BC5
		public FTaskDelayDelegate OnTick
		{
			get
			{
				base.FastCheckIsValid();
				FTaskDelayDelegate result;
				if ((result = this._OnTick) == null)
				{
					result = (this._OnTick = new FTaskDelayDelegate(base.NativePtr + (IntPtr)UGameplayTask_WaitDelay.__PropertyOffset_OnTick, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGameplayTask_WaitDelay.__PropertyOffset_OnTick, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004853 RID: 18515
		// (get) Token: 0x06012AAC RID: 76460 RVA: 0x001B79E8 File Offset: 0x001B5BE8
		// (set) Token: 0x06012AAD RID: 76461 RVA: 0x001B7A21 File Offset: 0x001B5C21
		public FTaskDelayDelegate OnFinish
		{
			get
			{
				base.FastCheckIsValid();
				FTaskDelayDelegate result;
				if ((result = this._OnFinish) == null)
				{
					result = (this._OnFinish = new FTaskDelayDelegate(base.NativePtr + (IntPtr)UGameplayTask_WaitDelay.__PropertyOffset_OnFinish, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGameplayTask_WaitDelay.__PropertyOffset_OnFinish, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06012AAE RID: 76462 RVA: 0x001B7A44 File Offset: 0x001B5C44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void TickTask(float DeltaTime)
		{
			UGameplayTask_WaitDelay.__TickTask_FunctionParams* ptr = stackalloc UGameplayTask_WaitDelay.__TickTask_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UGameplayTask_WaitDelay.__TickTask_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGameplayTask_WaitDelay.__TickTask_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UGameplayTask_WaitDelay.__TickTask_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06012AAF RID: 76463 RVA: 0x001B7A8C File Offset: 0x001B5C8C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UGameplayTask_WaitDelay TaskWaitDelay(IGameplayTaskOwnerInterface TaskOwner, float Time, byte Priority = 192, bool NeedTick = false)
		{
			UGameplayTask_WaitDelay.__TaskWaitDelay_FunctionParams* ptr = stackalloc UGameplayTask_WaitDelay.__TaskWaitDelay_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UGameplayTask_WaitDelay.__TaskWaitDelay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGameplayTask_WaitDelay.__TaskWaitDelay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TaskOwner = new FScriptInterface(TaskOwner, (TaskOwner != null) ? TaskOwner.InterfaceOffset() : 0);
			ptr->Time = Time;
			ptr->Priority = Priority;
			ptr->NeedTick = NeedTick;
			UnrealReflectionUtils.CallUFunction(UGameplayTask_WaitDelay._ClassDefaultObjectPtr, UGameplayTask_WaitDelay.__TaskWaitDelay_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameplayTask_WaitDelay>(ptr->__Result);
		}

		// Token: 0x06012AB0 RID: 76464 RVA: 0x001B7B03 File Offset: 0x001B5D03
		static UGameplayTask_WaitDelay()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTasks.GameplayTask_WaitDelay");
		}

		// Token: 0x06012AB1 RID: 76465 RVA: 0x001B7B11 File Offset: 0x001B5D11
		protected UGameplayTask_WaitDelay(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009FA0 RID: 40864
		public new const string __ObjectPath = "/Script/GameplayTasks.GameplayTask_WaitDelay";

		// Token: 0x04009FA1 RID: 40865
		private static IntPtr _ClassPtr;

		// Token: 0x04009FA2 RID: 40866
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009FA3 RID: 40867
		public static IntPtr __TaskDelayDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04009FA4 RID: 40868
		internal static int __PropertyOffset_OnTick;

		// Token: 0x04009FA5 RID: 40869
		[Nullable(2)]
		private FTaskDelayDelegate _OnTick;

		// Token: 0x04009FA6 RID: 40870
		internal static int __PropertyOffset_OnFinish;

		// Token: 0x04009FA7 RID: 40871
		[Nullable(2)]
		private FTaskDelayDelegate _OnFinish;

		// Token: 0x04009FA8 RID: 40872
		private static IntPtr __TickTask_NativeFunctionPtr;

		// Token: 0x04009FA9 RID: 40873
		private static IntPtr __TaskWaitDelay_NativeFunctionPtr;

		// Token: 0x02002E78 RID: 11896
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __TickTask_FunctionParams
		{
			// Token: 0x04016947 RID: 92487
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02002E79 RID: 11897
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __TaskWaitDelay_FunctionParams
		{
			// Token: 0x04016948 RID: 92488
			[FieldOffset(0)]
			public FScriptInterface TaskOwner;

			// Token: 0x04016949 RID: 92489
			[FieldOffset(16)]
			public float Time;

			// Token: 0x0401694A RID: 92490
			[FieldOffset(20)]
			public byte Priority;

			// Token: 0x0401694B RID: 92491
			[FieldOffset(21)]
			public bool NeedTick;

			// Token: 0x0401694C RID: 92492
			[FieldOffset(24)]
			public IntPtr __Result;
		}
	}
}
