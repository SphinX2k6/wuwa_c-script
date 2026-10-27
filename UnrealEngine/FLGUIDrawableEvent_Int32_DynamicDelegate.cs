using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200204E RID: 8270
	public sealed class FLGUIDrawableEvent_Int32_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F3FA RID: 127994 RVA: 0x002E6632 File Offset: 0x002E4832
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Int32_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F3FB RID: 127995 RVA: 0x002E663E File Offset: 0x002E483E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Int32_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Int32_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Int32_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Int32_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F3FC RID: 127996 RVA: 0x002E6661 File Offset: 0x002E4861
		public FLGUIDrawableEvent_Int32_DynamicDelegate()
		{
		}

		// Token: 0x0601F3FD RID: 127997 RVA: 0x002E6669 File Offset: 0x002E4869
		[NullableContext(2)]
		public FLGUIDrawableEvent_Int32_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F3FE RID: 127998 RVA: 0x002E6673 File Offset: 0x002E4873
		public FLGUIDrawableEvent_Int32_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F3FF RID: 127999 RVA: 0x002E667E File Offset: 0x002E487E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F400 RID: 128000 RVA: 0x002E66B0 File Offset: 0x002E48B0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int> Callback)
		{
			if (FLGUIDrawableEvent_Int32_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Int32_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Int32_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Int32_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Int32_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Int32_DynamicDelegate.RegisterId);
		}

		// Token: 0x0601F401 RID: 128001 RVA: 0x002E66EC File Offset: 0x002E48EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int value)
		{
			FLGUIDrawableEvent_Int32_DynamicDelegate.__FLGUIDrawableEvent_Int32_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Int32_DynamicDelegate.__FLGUIDrawableEvent_Int32_DynamicDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLGUIDrawableEvent_Int32_DynamicDelegate.__FLGUIDrawableEvent_Int32_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Int32_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F402 RID: 128002 RVA: 0x002E672C File Offset: 0x002E492C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_Int32_DynamicDelegate.__FLGUIDrawableEvent_Int32_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04010E89 RID: 69257
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010E8A RID: 69258
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Int32_DynamicDelegate__DelegateSignature";

		// Token: 0x04010E8B RID: 69259
		private static int RegisterId;

		// Token: 0x02003454 RID: 13396
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FLGUIDrawableEvent_Int32_DynamicDelegate_DelegateParams
		{
			// Token: 0x04017437 RID: 95287
			[FieldOffset(0)]
			public int value;
		}

		// Token: 0x02003455 RID: 13397
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017438 RID: 95288
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
