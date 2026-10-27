using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001892 RID: 6290
	public sealed class FAxisBindingDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060172B7 RID: 94903 RVA: 0x0021C7FA File Offset: 0x0021A9FA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAxisBindingDelegate.StaticFunctionPtr();
		}

		// Token: 0x060172B8 RID: 94904 RVA: 0x0021C806 File Offset: 0x0021AA06
		private static IntPtr StaticFunctionPtr()
		{
			if (FAxisBindingDelegate._FunctionPtr == IntPtr.Zero)
			{
				FAxisBindingDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.AxisBindingDelegate__DelegateSignature");
			}
			return FAxisBindingDelegate._FunctionPtr;
		}

		// Token: 0x060172B9 RID: 94905 RVA: 0x0021C829 File Offset: 0x0021AA29
		public FAxisBindingDelegate()
		{
		}

		// Token: 0x060172BA RID: 94906 RVA: 0x0021C831 File Offset: 0x0021AA31
		[NullableContext(2)]
		public FAxisBindingDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060172BB RID: 94907 RVA: 0x0021C83B File Offset: 0x0021AA3B
		public FAxisBindingDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060172BC RID: 94908 RVA: 0x0021C846 File Offset: 0x0021AA46
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060172BD RID: 94909 RVA: 0x0021C878 File Offset: 0x0021AA78
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<float> Callback)
		{
			if (FAxisBindingDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAxisBindingDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAxisBindingDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAxisBindingDelegate.OnScriptCallback));
				}
				FAxisBindingDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FAxisBindingDelegate.RegisterId);
		}

		// Token: 0x060172BE RID: 94910 RVA: 0x0021C8B4 File Offset: 0x0021AAB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(float Value)
		{
			FAxisBindingDelegate.__FAxisBindingDelegate_DelegateParams* ptr = stackalloc FAxisBindingDelegate.__FAxisBindingDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FAxisBindingDelegate.__FAxisBindingDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAxisBindingDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Value = Value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060172BF RID: 94911 RVA: 0x0021C8F4 File Offset: 0x0021AAF4
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
			action(((FAxisBindingDelegate.__FAxisBindingDelegate_DelegateParams*)__Parameters)->Value);
		}

		// Token: 0x0400C905 RID: 51461
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C906 RID: 51462
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.AxisBindingDelegate__DelegateSignature";

		// Token: 0x0400C907 RID: 51463
		private static int RegisterId;

		// Token: 0x02002F95 RID: 12181
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FAxisBindingDelegate_DelegateParams
		{
			// Token: 0x04016B62 RID: 93026
			[FieldOffset(0)]
			public float Value;
		}

		// Token: 0x02002F96 RID: 12182
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B63 RID: 93027
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
