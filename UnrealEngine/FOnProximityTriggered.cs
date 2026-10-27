using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C1C RID: 7196
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnProximityTriggered : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601BC03 RID: 113667 RVA: 0x0028D7B2 File Offset: 0x0028B9B2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnProximityTriggered.StaticFunctionPtr();
		}

		// Token: 0x0601BC04 RID: 113668 RVA: 0x0028D7BE File Offset: 0x0028B9BE
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnProximityTriggered._FunctionPtr == IntPtr.Zero)
			{
				FOnProximityTriggered._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.OnProximityTriggered__DelegateSignature");
			}
			return FOnProximityTriggered._FunctionPtr;
		}

		// Token: 0x0601BC05 RID: 113669 RVA: 0x0028D7E1 File Offset: 0x0028B9E1
		public FOnProximityTriggered()
		{
		}

		// Token: 0x0601BC06 RID: 113670 RVA: 0x0028D7E9 File Offset: 0x0028B9E9
		[NullableContext(2)]
		public FOnProximityTriggered(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BC07 RID: 113671 RVA: 0x0028D7F3 File Offset: 0x0028B9F3
		public FOnProximityTriggered(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BC08 RID: 113672 RVA: 0x0028D7FE File Offset: 0x0028B9FE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601BC09 RID: 113673 RVA: 0x0028D830 File Offset: 0x0028BA30
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<float> Callback)
		{
			if (FOnProximityTriggered.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnProximityTriggered.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnProximityTriggered.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnProximityTriggered.OnScriptCallback));
				}
				FOnProximityTriggered.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnProximityTriggered.RegisterId);
		}

		// Token: 0x0601BC0A RID: 113674 RVA: 0x0028D86A File Offset: 0x0028BA6A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601BC0B RID: 113675 RVA: 0x0028D874 File Offset: 0x0028BA74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float Distance)
		{
			FOnProximityTriggered.__FOnProximityTriggered_DelegateParams* ptr = stackalloc FOnProximityTriggered.__FOnProximityTriggered_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnProximityTriggered.__FOnProximityTriggered_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnProximityTriggered.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Distance = Distance;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601BC0C RID: 113676 RVA: 0x0028D8B0 File Offset: 0x0028BAB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnProximityTriggered.__FOnProximityTriggered_DelegateParams*)__Parameters)->Distance);
		}

		// Token: 0x0400EEA3 RID: 61091
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400EEA4 RID: 61092
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.OnProximityTriggered__DelegateSignature";

		// Token: 0x0400EEA5 RID: 61093
		private static int RegisterId;

		// Token: 0x020031A3 RID: 12707
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnProximityTriggered_DelegateParams
		{
			// Token: 0x04016FE2 RID: 94178
			[FieldOffset(0)]
			public float Distance;
		}

		// Token: 0x020031A4 RID: 12708
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016FE3 RID: 94179
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
