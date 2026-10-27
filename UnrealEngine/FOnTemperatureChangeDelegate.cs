using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F2E RID: 3886
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnTemperatureChangeDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D1A8 RID: 53672 RVA: 0x0013329D File Offset: 0x0013149D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTemperatureChangeDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600D1A9 RID: 53673 RVA: 0x001332A9 File Offset: 0x001314A9
		private static IntPtr StaticFunctionPtr()
		{
			if (UApplicationLifecycleComponent.__OnTemperatureChangeDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UApplicationLifecycleComponent.__OnTemperatureChangeDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ApplicationLifecycleComponent:OnTemperatureChangeDelegate__DelegateSignature");
			}
			return UApplicationLifecycleComponent.__OnTemperatureChangeDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600D1AA RID: 53674 RVA: 0x001332CC File Offset: 0x001314CC
		public FOnTemperatureChangeDelegate()
		{
		}

		// Token: 0x0600D1AB RID: 53675 RVA: 0x001332D4 File Offset: 0x001314D4
		[NullableContext(2)]
		public FOnTemperatureChangeDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D1AC RID: 53676 RVA: 0x001332DE File Offset: 0x001314DE
		public FOnTemperatureChangeDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D1AD RID: 53677 RVA: 0x001332E9 File Offset: 0x001314E9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<ETemperatureSeverityType>) ?? ((Action<ETemperatureSeverityType>)Delegate.CreateDelegate(typeof(Action<ETemperatureSeverityType>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D1AE RID: 53678 RVA: 0x0013331B File Offset: 0x0013151B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<ETemperatureSeverityType> Callback)
		{
			if (FOnTemperatureChangeDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnTemperatureChangeDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnTemperatureChangeDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnTemperatureChangeDelegate.OnScriptCallback));
				}
				FOnTemperatureChangeDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnTemperatureChangeDelegate.RegisterId);
		}

		// Token: 0x0600D1AF RID: 53679 RVA: 0x00133355 File Offset: 0x00131555
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<ETemperatureSeverityType> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D1B0 RID: 53680 RVA: 0x00133360 File Offset: 0x00131560
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(ETemperatureSeverityType Severity)
		{
			FOnTemperatureChangeDelegate.__FOnTemperatureChangeDelegate_DelegateParams* ptr = stackalloc FOnTemperatureChangeDelegate.__FOnTemperatureChangeDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnTemperatureChangeDelegate.__FOnTemperatureChangeDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnTemperatureChangeDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Severity = Severity;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D1B1 RID: 53681 RVA: 0x0013339C File Offset: 0x0013159C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<ETemperatureSeverityType> action = target as Action<ETemperatureSeverityType>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnTemperatureChangeDelegate.__FOnTemperatureChangeDelegate_DelegateParams*)__Parameters)->Severity);
		}

		// Token: 0x04007096 RID: 28822
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ApplicationLifecycleComponent:OnTemperatureChangeDelegate__DelegateSignature";

		// Token: 0x04007097 RID: 28823
		private static int RegisterId;

		// Token: 0x02002DA9 RID: 11689
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnTemperatureChangeDelegate_DelegateParams
		{
			// Token: 0x040167CE RID: 92110
			[FieldOffset(0)]
			public ETemperatureSeverityType Severity;
		}

		// Token: 0x02002DAA RID: 11690
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167CF RID: 92111
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
