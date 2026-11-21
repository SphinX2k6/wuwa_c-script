using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000810 RID: 2064
	public sealed class FSharpherealConsoleCommandWithWorldDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B556 RID: 46422 RVA: 0x001207A9 File Offset: 0x0011E9A9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealConsoleCommandWithWorldDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600B557 RID: 46423 RVA: 0x001207B5 File Offset: 0x0011E9B5
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealConsoleCommandWithWorldDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealConsoleCommandWithWorldDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Sharphereal.SharpherealConsoleCommandWithWorldDelegate__DelegateSignature");
			}
			return FSharpherealConsoleCommandWithWorldDelegate._FunctionPtr;
		}

		// Token: 0x0600B558 RID: 46424 RVA: 0x001207D8 File Offset: 0x0011E9D8
		public FSharpherealConsoleCommandWithWorldDelegate()
		{
		}

		// Token: 0x0600B559 RID: 46425 RVA: 0x001207E0 File Offset: 0x0011E9E0
		[NullableContext(2)]
		public FSharpherealConsoleCommandWithWorldDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B55A RID: 46426 RVA: 0x001207EA File Offset: 0x0011E9EA
		public FSharpherealConsoleCommandWithWorldDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B55B RID: 46427 RVA: 0x001207F5 File Offset: 0x0011E9F5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UWorld>) ?? ((Action<UWorld>)Delegate.CreateDelegate(typeof(Action<UWorld>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B55C RID: 46428 RVA: 0x00120827 File Offset: 0x0011EA27
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UWorld> Callback)
		{
			if (FSharpherealConsoleCommandWithWorldDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealConsoleCommandWithWorldDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealConsoleCommandWithWorldDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealConsoleCommandWithWorldDelegate.OnScriptCallback));
				}
				FSharpherealConsoleCommandWithWorldDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSharpherealConsoleCommandWithWorldDelegate.RegisterId);
		}

		// Token: 0x0600B55D RID: 46429 RVA: 0x00120864 File Offset: 0x0011EA64
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(UWorld World)
		{
			FSharpherealConsoleCommandWithWorldDelegate.__FSharpherealConsoleCommandWithWorldDelegate_DelegateParams* ptr = stackalloc FSharpherealConsoleCommandWithWorldDelegate.__FSharpherealConsoleCommandWithWorldDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSharpherealConsoleCommandWithWorldDelegate.__FSharpherealConsoleCommandWithWorldDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSharpherealConsoleCommandWithWorldDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->World = ((World != null) ? World.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600B55E RID: 46430 RVA: 0x001208B0 File Offset: 0x0011EAB0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UWorld> action = target as Action<UWorld>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UWorld orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorld>(((FSharpherealConsoleCommandWithWorldDelegate.__FSharpherealConsoleCommandWithWorldDelegate_DelegateParams*)__Parameters)->World);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x040051D5 RID: 20949
		internal static IntPtr _FunctionPtr;

		// Token: 0x040051D6 RID: 20950
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealConsoleCommandWithWorldDelegate__DelegateSignature";

		// Token: 0x040051D7 RID: 20951
		private static int RegisterId;

		// Token: 0x02001332 RID: 4914
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FSharpherealConsoleCommandWithWorldDelegate_DelegateParams
		{
			// Token: 0x0400676C RID: 26476
			[FieldOffset(0)]
			public IntPtr World;
		}

		// Token: 0x02001333 RID: 4915
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400676D RID: 26477
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
