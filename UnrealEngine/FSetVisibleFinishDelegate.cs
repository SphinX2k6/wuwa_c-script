using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000615 RID: 1557
	public sealed class FSetVisibleFinishDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060088AA RID: 34986 RVA: 0x000CE34C File Offset: 0x000CC54C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSetVisibleFinishDelegate.StaticFunctionPtr();
		}

		// Token: 0x060088AB RID: 34987 RVA: 0x000CE358 File Offset: 0x000CC558
		private static IntPtr StaticFunctionPtr()
		{
			if (FSetVisibleFinishDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSetVisibleFinishDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.SetVisibleFinishDelegate__DelegateSignature");
			}
			return FSetVisibleFinishDelegate._FunctionPtr;
		}

		// Token: 0x060088AC RID: 34988 RVA: 0x000CE37B File Offset: 0x000CC57B
		public FSetVisibleFinishDelegate()
		{
		}

		// Token: 0x060088AD RID: 34989 RVA: 0x000CE383 File Offset: 0x000CC583
		[NullableContext(2)]
		public FSetVisibleFinishDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060088AE RID: 34990 RVA: 0x000CE38D File Offset: 0x000CC58D
		public FSetVisibleFinishDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060088AF RID: 34991 RVA: 0x000CE398 File Offset: 0x000CC598
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060088B0 RID: 34992 RVA: 0x000CE3CA File Offset: 0x000CC5CA
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FSetVisibleFinishDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSetVisibleFinishDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSetVisibleFinishDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSetVisibleFinishDelegate.OnScriptCallback));
				}
				FSetVisibleFinishDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSetVisibleFinishDelegate.RegisterId);
		}

		// Token: 0x060088B1 RID: 34993 RVA: 0x000CE404 File Offset: 0x000CC604
		[SkipLocalsInit]
		public unsafe void Execute(int LinkId)
		{
			FSetVisibleFinishDelegate.__FSetVisibleFinishDelegate_DelegateParams* ptr = stackalloc FSetVisibleFinishDelegate.__FSetVisibleFinishDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FSetVisibleFinishDelegate.__FSetVisibleFinishDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSetVisibleFinishDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->LinkId = LinkId;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060088B2 RID: 34994 RVA: 0x000CE444 File Offset: 0x000CC644
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FSetVisibleFinishDelegate.__FSetVisibleFinishDelegate_DelegateParams*)__Parameters)->LinkId);
		}

		// Token: 0x04003B57 RID: 15191
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B58 RID: 15192
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.SetVisibleFinishDelegate__DelegateSignature";

		// Token: 0x04003B59 RID: 15193
		private static int RegisterId;

		// Token: 0x02000E46 RID: 3654
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FSetVisibleFinishDelegate_DelegateParams
		{
			// Token: 0x040061E0 RID: 25056
			[FieldOffset(0)]
			public int LinkId;
		}

		// Token: 0x02000E47 RID: 3655
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061E1 RID: 25057
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
