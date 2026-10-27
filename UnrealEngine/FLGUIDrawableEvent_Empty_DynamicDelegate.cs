using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02002049 RID: 8265
	public sealed class FLGUIDrawableEvent_Empty_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F3D0 RID: 127952 RVA: 0x002E6286 File Offset: 0x002E4486
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Empty_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F3D1 RID: 127953 RVA: 0x002E6292 File Offset: 0x002E4492
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Empty_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Empty_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Empty_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Empty_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F3D2 RID: 127954 RVA: 0x002E62B5 File Offset: 0x002E44B5
		public FLGUIDrawableEvent_Empty_DynamicDelegate()
		{
		}

		// Token: 0x0601F3D3 RID: 127955 RVA: 0x002E62BD File Offset: 0x002E44BD
		[NullableContext(2)]
		public FLGUIDrawableEvent_Empty_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F3D4 RID: 127956 RVA: 0x002E62C7 File Offset: 0x002E44C7
		public FLGUIDrawableEvent_Empty_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F3D5 RID: 127957 RVA: 0x002E62D2 File Offset: 0x002E44D2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F3D6 RID: 127958 RVA: 0x002E6304 File Offset: 0x002E4504
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FLGUIDrawableEvent_Empty_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Empty_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Empty_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Empty_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Empty_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Empty_DynamicDelegate.RegisterId);
		}

		// Token: 0x0601F3D7 RID: 127959 RVA: 0x002E633E File Offset: 0x002E453E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601F3D8 RID: 127960 RVA: 0x002E634C File Offset: 0x002E454C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x04010E7D RID: 69245
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010E7E RID: 69246
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Empty_DynamicDelegate__DelegateSignature";

		// Token: 0x04010E7F RID: 69247
		private static int RegisterId;

		// Token: 0x02003451 RID: 13393
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017434 RID: 95284
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
