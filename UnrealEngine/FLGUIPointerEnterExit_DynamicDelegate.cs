using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020A6 RID: 8358
	public sealed class FLGUIPointerEnterExit_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F7FD RID: 129021 RVA: 0x002ED24C File Offset: 0x002EB44C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIPointerEnterExit_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F7FE RID: 129022 RVA: 0x002ED258 File Offset: 0x002EB458
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIPointerEnterExit_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIPointerEnterExit_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIPointerEnterExit_DynamicDelegate__DelegateSignature");
			}
			return FLGUIPointerEnterExit_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F7FF RID: 129023 RVA: 0x002ED27B File Offset: 0x002EB47B
		public FLGUIPointerEnterExit_DynamicDelegate()
		{
		}

		// Token: 0x0601F800 RID: 129024 RVA: 0x002ED283 File Offset: 0x002EB483
		[NullableContext(2)]
		public FLGUIPointerEnterExit_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F801 RID: 129025 RVA: 0x002ED28D File Offset: 0x002EB48D
		public FLGUIPointerEnterExit_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F802 RID: 129026 RVA: 0x002ED298 File Offset: 0x002EB498
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F803 RID: 129027 RVA: 0x002ED2CA File Offset: 0x002EB4CA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<bool> Callback)
		{
			if (FLGUIPointerEnterExit_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIPointerEnterExit_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIPointerEnterExit_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIPointerEnterExit_DynamicDelegate.OnScriptCallback));
				}
				FLGUIPointerEnterExit_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIPointerEnterExit_DynamicDelegate.RegisterId);
		}

		// Token: 0x0601F804 RID: 129028 RVA: 0x002ED304 File Offset: 0x002EB504
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool bEnter)
		{
			FLGUIPointerEnterExit_DynamicDelegate.__FLGUIPointerEnterExit_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIPointerEnterExit_DynamicDelegate.__FLGUIPointerEnterExit_DynamicDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FLGUIPointerEnterExit_DynamicDelegate.__FLGUIPointerEnterExit_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIPointerEnterExit_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bEnter = bEnter;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F805 RID: 129029 RVA: 0x002ED344 File Offset: 0x002EB544
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIPointerEnterExit_DynamicDelegate.__FLGUIPointerEnterExit_DynamicDelegate_DelegateParams*)__Parameters)->bEnter);
		}

		// Token: 0x0401101F RID: 69663
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011020 RID: 69664
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIPointerEnterExit_DynamicDelegate__DelegateSignature";

		// Token: 0x04011021 RID: 69665
		private static int RegisterId;

		// Token: 0x020034A4 RID: 13476
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FLGUIPointerEnterExit_DynamicDelegate_DelegateParams
		{
			// Token: 0x040174A7 RID: 95399
			[FieldOffset(0)]
			public bool bEnter;
		}

		// Token: 0x020034A5 RID: 13477
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174A8 RID: 95400
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
