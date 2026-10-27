using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002080 RID: 8320
	public sealed class FLGUIInputActivateDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F64A RID: 128586 RVA: 0x002E9E75 File Offset: 0x002E8075
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIInputActivateDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F64B RID: 128587 RVA: 0x002E9E81 File Offset: 0x002E8081
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIInputActivateDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIInputActivateDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIInputActivateDynamicDelegate__DelegateSignature");
			}
			return FLGUIInputActivateDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F64C RID: 128588 RVA: 0x002E9EA4 File Offset: 0x002E80A4
		public FLGUIInputActivateDynamicDelegate()
		{
		}

		// Token: 0x0601F64D RID: 128589 RVA: 0x002E9EAC File Offset: 0x002E80AC
		[NullableContext(2)]
		public FLGUIInputActivateDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F64E RID: 128590 RVA: 0x002E9EB6 File Offset: 0x002E80B6
		public FLGUIInputActivateDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F64F RID: 128591 RVA: 0x002E9EC1 File Offset: 0x002E80C1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F650 RID: 128592 RVA: 0x002E9EF3 File Offset: 0x002E80F3
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<bool> Callback)
		{
			if (FLGUIInputActivateDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIInputActivateDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIInputActivateDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIInputActivateDynamicDelegate.OnScriptCallback));
				}
				FLGUIInputActivateDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIInputActivateDynamicDelegate.RegisterId);
		}

		// Token: 0x0601F651 RID: 128593 RVA: 0x002E9F30 File Offset: 0x002E8130
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool InActivate)
		{
			FLGUIInputActivateDynamicDelegate.__FLGUIInputActivateDynamicDelegate_DelegateParams* ptr = stackalloc FLGUIInputActivateDynamicDelegate.__FLGUIInputActivateDynamicDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FLGUIInputActivateDynamicDelegate.__FLGUIInputActivateDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIInputActivateDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InActivate = InActivate;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F652 RID: 128594 RVA: 0x002E9F70 File Offset: 0x002E8170
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
			action(((FLGUIInputActivateDynamicDelegate.__FLGUIInputActivateDynamicDelegate_DelegateParams*)__Parameters)->InActivate);
		}

		// Token: 0x04010F4B RID: 69451
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010F4C RID: 69452
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIInputActivateDynamicDelegate__DelegateSignature";

		// Token: 0x04010F4D RID: 69453
		private static int RegisterId;

		// Token: 0x02003483 RID: 13443
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FLGUIInputActivateDynamicDelegate_DelegateParams
		{
			// Token: 0x04017471 RID: 95345
			[FieldOffset(0)]
			public bool InActivate;
		}

		// Token: 0x02003484 RID: 13444
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017472 RID: 95346
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
