using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000688 RID: 1672
	public sealed class FLGUIDrawableEvent_Rotator_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060090B6 RID: 37046 RVA: 0x000D97CE File Offset: 0x000D79CE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Rotator_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060090B7 RID: 37047 RVA: 0x000D97DA File Offset: 0x000D79DA
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Rotator_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Rotator_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Rotator_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Rotator_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x060090B8 RID: 37048 RVA: 0x000D97FD File Offset: 0x000D79FD
		public FLGUIDrawableEvent_Rotator_DynamicDelegate()
		{
		}

		// Token: 0x060090B9 RID: 37049 RVA: 0x000D9805 File Offset: 0x000D7A05
		[NullableContext(2)]
		public FLGUIDrawableEvent_Rotator_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060090BA RID: 37050 RVA: 0x000D980F File Offset: 0x000D7A0F
		public FLGUIDrawableEvent_Rotator_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060090BB RID: 37051 RVA: 0x000D981A File Offset: 0x000D7A1A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FRotator>) ?? ((Action<FRotator>)Delegate.CreateDelegate(typeof(Action<FRotator>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060090BC RID: 37052 RVA: 0x000D984C File Offset: 0x000D7A4C
		[NullableContext(1)]
		public void Bind(Action<FRotator> Callback)
		{
			if (FLGUIDrawableEvent_Rotator_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Rotator_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Rotator_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Rotator_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Rotator_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Rotator_DynamicDelegate.RegisterId);
		}

		// Token: 0x060090BD RID: 37053 RVA: 0x000D9888 File Offset: 0x000D7A88
		[SkipLocalsInit]
		public unsafe void Execute(FRotator value)
		{
			FLGUIDrawableEvent_Rotator_DynamicDelegate.__FLGUIDrawableEvent_Rotator_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Rotator_DynamicDelegate.__FLGUIDrawableEvent_Rotator_DynamicDelegate_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FLGUIDrawableEvent_Rotator_DynamicDelegate.__FLGUIDrawableEvent_Rotator_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Rotator_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060090BE RID: 37054 RVA: 0x000D98C8 File Offset: 0x000D7AC8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FRotator> action = target as Action<FRotator>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_Rotator_DynamicDelegate.__FLGUIDrawableEvent_Rotator_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04003F31 RID: 16177
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F32 RID: 16178
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Rotator_DynamicDelegate__DelegateSignature";

		// Token: 0x04003F33 RID: 16179
		private static int RegisterId;

		// Token: 0x02000EA3 RID: 3747
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private ref struct __FLGUIDrawableEvent_Rotator_DynamicDelegate_DelegateParams
		{
			// Token: 0x04006252 RID: 25170
			[FieldOffset(0)]
			public FRotator value;
		}

		// Token: 0x02000EA4 RID: 3748
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006253 RID: 25171
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
