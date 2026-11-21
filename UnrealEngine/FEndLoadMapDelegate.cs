using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005BC RID: 1468
	public sealed class FEndLoadMapDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600836E RID: 33646 RVA: 0x000C28E2 File Offset: 0x000C0AE2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEndLoadMapDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600836F RID: 33647 RVA: 0x000C28EE File Offset: 0x000C0AEE
		private static IntPtr StaticFunctionPtr()
		{
			if (FEndLoadMapDelegate._FunctionPtr == IntPtr.Zero)
			{
				FEndLoadMapDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.EndLoadMapDelegate__DelegateSignature");
			}
			return FEndLoadMapDelegate._FunctionPtr;
		}

		// Token: 0x06008370 RID: 33648 RVA: 0x000C2911 File Offset: 0x000C0B11
		public FEndLoadMapDelegate()
		{
		}

		// Token: 0x06008371 RID: 33649 RVA: 0x000C2919 File Offset: 0x000C0B19
		[NullableContext(2)]
		public FEndLoadMapDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008372 RID: 33650 RVA: 0x000C2923 File Offset: 0x000C0B23
		public FEndLoadMapDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008373 RID: 33651 RVA: 0x000C292E File Offset: 0x000C0B2E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008374 RID: 33652 RVA: 0x000C2960 File Offset: 0x000C0B60
		[NullableContext(1)]
		public void Bind(Action<string> Callback)
		{
			if (FEndLoadMapDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEndLoadMapDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEndLoadMapDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEndLoadMapDelegate.OnScriptCallback));
				}
				FEndLoadMapDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FEndLoadMapDelegate.RegisterId);
		}

		// Token: 0x06008375 RID: 33653 RVA: 0x000C299C File Offset: 0x000C0B9C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string MapName)
		{
			FEndLoadMapDelegate.__FEndLoadMapDelegate_DelegateParams* ptr = stackalloc FEndLoadMapDelegate.__FEndLoadMapDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FEndLoadMapDelegate.__FEndLoadMapDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEndLoadMapDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->MapName), MapName);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FEndLoadMapDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008376 RID: 33654 RVA: 0x000C29F0 File Offset: 0x000C0BF0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FEndLoadMapDelegate.__FEndLoadMapDelegate_DelegateParams*)__Parameters)->MapName));
			action(obj);
		}

		// Token: 0x04003929 RID: 14633
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400392A RID: 14634
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.EndLoadMapDelegate__DelegateSignature";

		// Token: 0x0400392B RID: 14635
		private static int RegisterId;

		// Token: 0x02000D40 RID: 3392
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FEndLoadMapDelegate_DelegateParams
		{
			// Token: 0x04005FDD RID: 24541
			[FieldOffset(0)]
			public FString MapName;
		}

		// Token: 0x02000D41 RID: 3393
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FDE RID: 24542
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
