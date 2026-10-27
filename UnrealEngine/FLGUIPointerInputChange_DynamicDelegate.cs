using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020A9 RID: 8361
	public sealed class FLGUIPointerInputChange_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F868 RID: 129128 RVA: 0x002EDB4D File Offset: 0x002EBD4D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIPointerInputChange_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F869 RID: 129129 RVA: 0x002EDB59 File Offset: 0x002EBD59
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIPointerInputChange_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIPointerInputChange_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIPointerInputChange_DynamicDelegate__DelegateSignature");
			}
			return FLGUIPointerInputChange_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F86A RID: 129130 RVA: 0x002EDB7C File Offset: 0x002EBD7C
		public FLGUIPointerInputChange_DynamicDelegate()
		{
		}

		// Token: 0x0601F86B RID: 129131 RVA: 0x002EDB84 File Offset: 0x002EBD84
		[NullableContext(2)]
		public FLGUIPointerInputChange_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F86C RID: 129132 RVA: 0x002EDB8E File Offset: 0x002EBD8E
		public FLGUIPointerInputChange_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F86D RID: 129133 RVA: 0x002EDB99 File Offset: 0x002EBD99
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<ELGUIPointerInputType>) ?? ((Action<ELGUIPointerInputType>)Delegate.CreateDelegate(typeof(Action<ELGUIPointerInputType>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F86E RID: 129134 RVA: 0x002EDBCB File Offset: 0x002EBDCB
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<ELGUIPointerInputType> Callback)
		{
			if (FLGUIPointerInputChange_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIPointerInputChange_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIPointerInputChange_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIPointerInputChange_DynamicDelegate.OnScriptCallback));
				}
				FLGUIPointerInputChange_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIPointerInputChange_DynamicDelegate.RegisterId);
		}

		// Token: 0x0601F86F RID: 129135 RVA: 0x002EDC08 File Offset: 0x002EBE08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(ELGUIPointerInputType type)
		{
			FLGUIPointerInputChange_DynamicDelegate.__FLGUIPointerInputChange_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIPointerInputChange_DynamicDelegate.__FLGUIPointerInputChange_DynamicDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FLGUIPointerInputChange_DynamicDelegate.__FLGUIPointerInputChange_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIPointerInputChange_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->type = type;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F870 RID: 129136 RVA: 0x002EDC48 File Offset: 0x002EBE48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<ELGUIPointerInputType> action = target as Action<ELGUIPointerInputType>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIPointerInputChange_DynamicDelegate.__FLGUIPointerInputChange_DynamicDelegate_DelegateParams*)__Parameters)->type);
		}

		// Token: 0x0401104E RID: 69710
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401104F RID: 69711
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIPointerInputChange_DynamicDelegate__DelegateSignature";

		// Token: 0x04011050 RID: 69712
		private static int RegisterId;

		// Token: 0x020034A8 RID: 13480
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FLGUIPointerInputChange_DynamicDelegate_DelegateParams
		{
			// Token: 0x040174AB RID: 95403
			[FieldOffset(0)]
			public ELGUIPointerInputType type;
		}

		// Token: 0x020034A9 RID: 13481
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174AC RID: 95404
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
