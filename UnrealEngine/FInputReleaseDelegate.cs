using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013A4 RID: 5028
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FInputReleaseDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601275A RID: 75610 RVA: 0x001B236A File Offset: 0x001B056A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FInputReleaseDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601275B RID: 75611 RVA: 0x001B2376 File Offset: 0x001B0576
		private static IntPtr StaticFunctionPtr()
		{
			if (FInputReleaseDelegate._FunctionPtr == IntPtr.Zero)
			{
				FInputReleaseDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.InputReleaseDelegate__DelegateSignature");
			}
			return FInputReleaseDelegate._FunctionPtr;
		}

		// Token: 0x0601275C RID: 75612 RVA: 0x001B2399 File Offset: 0x001B0599
		public FInputReleaseDelegate()
		{
		}

		// Token: 0x0601275D RID: 75613 RVA: 0x001B23A1 File Offset: 0x001B05A1
		[NullableContext(2)]
		public FInputReleaseDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601275E RID: 75614 RVA: 0x001B23AB File Offset: 0x001B05AB
		public FInputReleaseDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601275F RID: 75615 RVA: 0x001B23B6 File Offset: 0x001B05B6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012760 RID: 75616 RVA: 0x001B23E8 File Offset: 0x001B05E8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<float> Callback)
		{
			if (FInputReleaseDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FInputReleaseDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FInputReleaseDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FInputReleaseDelegate.OnScriptCallback));
				}
				FInputReleaseDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FInputReleaseDelegate.RegisterId);
		}

		// Token: 0x06012761 RID: 75617 RVA: 0x001B2422 File Offset: 0x001B0622
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012762 RID: 75618 RVA: 0x001B242C File Offset: 0x001B062C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float TimeHeld)
		{
			FInputReleaseDelegate.__FInputReleaseDelegate_DelegateParams* ptr = stackalloc FInputReleaseDelegate.__FInputReleaseDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FInputReleaseDelegate.__FInputReleaseDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FInputReleaseDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TimeHeld = TimeHeld;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06012763 RID: 75619 RVA: 0x001B2468 File Offset: 0x001B0668
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
			action(((FInputReleaseDelegate.__FInputReleaseDelegate_DelegateParams*)__Parameters)->TimeHeld);
		}

		// Token: 0x04009E21 RID: 40481
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E22 RID: 40482
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.InputReleaseDelegate__DelegateSignature";

		// Token: 0x04009E23 RID: 40483
		private static int RegisterId;

		// Token: 0x02002E46 RID: 11846
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FInputReleaseDelegate_DelegateParams
		{
			// Token: 0x04016900 RID: 92416
			[FieldOffset(0)]
			public float TimeHeld;
		}

		// Token: 0x02002E47 RID: 11847
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016901 RID: 92417
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
