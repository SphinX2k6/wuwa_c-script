using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B1 RID: 1713
	public sealed class FLGUIPointerEnterExit_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060092F1 RID: 37617 RVA: 0x000DD50C File Offset: 0x000DB70C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIPointerEnterExit_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060092F2 RID: 37618 RVA: 0x000DD518 File Offset: 0x000DB718
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIPointerEnterExit_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIPointerEnterExit_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIPointerEnterExit_DynamicDelegate__DelegateSignature");
			}
			return FLGUIPointerEnterExit_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x060092F3 RID: 37619 RVA: 0x000DD53B File Offset: 0x000DB73B
		public FLGUIPointerEnterExit_DynamicDelegate()
		{
		}

		// Token: 0x060092F4 RID: 37620 RVA: 0x000DD543 File Offset: 0x000DB743
		[NullableContext(2)]
		public FLGUIPointerEnterExit_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060092F5 RID: 37621 RVA: 0x000DD54D File Offset: 0x000DB74D
		public FLGUIPointerEnterExit_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060092F6 RID: 37622 RVA: 0x000DD558 File Offset: 0x000DB758
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060092F7 RID: 37623 RVA: 0x000DD58A File Offset: 0x000DB78A
		[NullableContext(1)]
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

		// Token: 0x060092F8 RID: 37624 RVA: 0x000DD5C4 File Offset: 0x000DB7C4
		[SkipLocalsInit]
		public unsafe void Execute(bool bEnter)
		{
			FLGUIPointerEnterExit_DynamicDelegate.__FLGUIPointerEnterExit_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIPointerEnterExit_DynamicDelegate.__FLGUIPointerEnterExit_DynamicDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FLGUIPointerEnterExit_DynamicDelegate.__FLGUIPointerEnterExit_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIPointerEnterExit_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bEnter = bEnter;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060092F9 RID: 37625 RVA: 0x000DD604 File Offset: 0x000DB804
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIPointerEnterExit_DynamicDelegate.__FLGUIPointerEnterExit_DynamicDelegate_DelegateParams*)__Parameters)->bEnter);
		}

		// Token: 0x0400400E RID: 16398
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400400F RID: 16399
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIPointerEnterExit_DynamicDelegate__DelegateSignature";

		// Token: 0x04004010 RID: 16400
		private static int RegisterId;

		// Token: 0x02000ED8 RID: 3800
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FLGUIPointerEnterExit_DynamicDelegate_DelegateParams
		{
			// Token: 0x04006298 RID: 25240
			[FieldOffset(0)]
			public bool bEnter;
		}

		// Token: 0x02000ED9 RID: 3801
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006299 RID: 25241
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
