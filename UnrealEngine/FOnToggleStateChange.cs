using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020F6 RID: 8438
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnToggleStateChange : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FC31 RID: 130097 RVA: 0x002F3BA1 File Offset: 0x002F1DA1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnToggleStateChange.StaticFunctionPtr();
		}

		// Token: 0x0601FC32 RID: 130098 RVA: 0x002F3BAD File Offset: 0x002F1DAD
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnToggleStateChange._FunctionPtr == IntPtr.Zero)
			{
				FOnToggleStateChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.OnToggleStateChange__DelegateSignature");
			}
			return FOnToggleStateChange._FunctionPtr;
		}

		// Token: 0x0601FC33 RID: 130099 RVA: 0x002F3BD0 File Offset: 0x002F1DD0
		public FOnToggleStateChange()
		{
		}

		// Token: 0x0601FC34 RID: 130100 RVA: 0x002F3BD8 File Offset: 0x002F1DD8
		[NullableContext(2)]
		public FOnToggleStateChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC35 RID: 130101 RVA: 0x002F3BE2 File Offset: 0x002F1DE2
		public FOnToggleStateChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC36 RID: 130102 RVA: 0x002F3BED File Offset: 0x002F1DED
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<EToggleState>) ?? ((Action<EToggleState>)Delegate.CreateDelegate(typeof(Action<EToggleState>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FC37 RID: 130103 RVA: 0x002F3C1F File Offset: 0x002F1E1F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<EToggleState> Callback)
		{
			if (FOnToggleStateChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnToggleStateChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnToggleStateChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnToggleStateChange.OnScriptCallback));
				}
				FOnToggleStateChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnToggleStateChange.RegisterId);
		}

		// Token: 0x0601FC38 RID: 130104 RVA: 0x002F3C59 File Offset: 0x002F1E59
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<EToggleState> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601FC39 RID: 130105 RVA: 0x002F3C64 File Offset: 0x002F1E64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(EToggleState State)
		{
			FOnToggleStateChange.__FOnToggleStateChange_DelegateParams* ptr = stackalloc FOnToggleStateChange.__FOnToggleStateChange_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnToggleStateChange.__FOnToggleStateChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnToggleStateChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->State = State;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601FC3A RID: 130106 RVA: 0x002F3CA0 File Offset: 0x002F1EA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EToggleState> action = target as Action<EToggleState>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnToggleStateChange.__FOnToggleStateChange_DelegateParams*)__Parameters)->State);
		}

		// Token: 0x040111EF RID: 70127
		internal static IntPtr _FunctionPtr;

		// Token: 0x040111F0 RID: 70128
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.OnToggleStateChange__DelegateSignature";

		// Token: 0x040111F1 RID: 70129
		private static int RegisterId;

		// Token: 0x020034DD RID: 13533
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnToggleStateChange_DelegateParams
		{
			// Token: 0x040174F1 RID: 95473
			[FieldOffset(0)]
			public EToggleState State;
		}

		// Token: 0x020034DE RID: 13534
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174F2 RID: 95474
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
