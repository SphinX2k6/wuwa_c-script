using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200080F RID: 2063
	public sealed class FSharpherealConsoleCommandWithWorldAndArgsDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B54D RID: 46413 RVA: 0x001205EB File Offset: 0x0011E7EB
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealConsoleCommandWithWorldAndArgsDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600B54E RID: 46414 RVA: 0x001205F7 File Offset: 0x0011E7F7
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealConsoleCommandWithWorldAndArgsDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealConsoleCommandWithWorldAndArgsDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Sharphereal.SharpherealConsoleCommandWithWorldAndArgsDelegate__DelegateSignature");
			}
			return FSharpherealConsoleCommandWithWorldAndArgsDelegate._FunctionPtr;
		}

		// Token: 0x0600B54F RID: 46415 RVA: 0x0012061A File Offset: 0x0011E81A
		public FSharpherealConsoleCommandWithWorldAndArgsDelegate()
		{
		}

		// Token: 0x0600B550 RID: 46416 RVA: 0x00120622 File Offset: 0x0011E822
		[NullableContext(2)]
		public FSharpherealConsoleCommandWithWorldAndArgsDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B551 RID: 46417 RVA: 0x0012062C File Offset: 0x0011E82C
		public FSharpherealConsoleCommandWithWorldAndArgsDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B552 RID: 46418 RVA: 0x00120637 File Offset: 0x0011E837
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FSharpherealConsoleCommandWithWorldAndArgsDelegate.FSharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate) ?? ((FSharpherealConsoleCommandWithWorldAndArgsDelegate.FSharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate)Delegate.CreateDelegate(typeof(FSharpherealConsoleCommandWithWorldAndArgsDelegate.FSharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B553 RID: 46419 RVA: 0x00120669 File Offset: 0x0011E869
		[NullableContext(1)]
		public void Bind(FSharpherealConsoleCommandWithWorldAndArgsDelegate.FSharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate Callback)
		{
			if (FSharpherealConsoleCommandWithWorldAndArgsDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealConsoleCommandWithWorldAndArgsDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealConsoleCommandWithWorldAndArgsDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealConsoleCommandWithWorldAndArgsDelegate.OnScriptCallback));
				}
				FSharpherealConsoleCommandWithWorldAndArgsDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSharpherealConsoleCommandWithWorldAndArgsDelegate.RegisterId);
		}

		// Token: 0x0600B554 RID: 46420 RVA: 0x001206A4 File Offset: 0x0011E8A4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> Args, UWorld World)
		{
			FSharpherealConsoleCommandWithWorldAndArgsDelegate.__FSharpherealConsoleCommandWithWorldAndArgsDelegate_DelegateParams* ptr = stackalloc FSharpherealConsoleCommandWithWorldAndArgsDelegate.__FSharpherealConsoleCommandWithWorldAndArgsDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FSharpherealConsoleCommandWithWorldAndArgsDelegate.__FSharpherealConsoleCommandWithWorldAndArgsDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSharpherealConsoleCommandWithWorldAndArgsDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<string> tarray = Args;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Args);
			}
			ptr->World = ((World != null) ? World.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			TArray<string> tarray2 = Args;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Args);
			}
			UnrealReflectionUtils.DestroyStruct(FSharpherealConsoleCommandWithWorldAndArgsDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B555 RID: 46421 RVA: 0x0012072C File Offset: 0x0011E92C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FSharpherealConsoleCommandWithWorldAndArgsDelegate.FSharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate fsharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate = target as FSharpherealConsoleCommandWithWorldAndArgsDelegate.FSharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate;
			if (fsharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<string> tarray = new TArray<string>(&((FSharpherealConsoleCommandWithWorldAndArgsDelegate.__FSharpherealConsoleCommandWithWorldAndArgsDelegate_DelegateParams*)__Parameters)->Args, true, true);
			UWorld orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorld>(((FSharpherealConsoleCommandWithWorldAndArgsDelegate.__FSharpherealConsoleCommandWithWorldAndArgsDelegate_DelegateParams*)__Parameters)->World);
			fsharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate(tarray, orCreateUObjectByNativePointer);
			if (tarray != null)
			{
				tarray.CopyTo(&((FSharpherealConsoleCommandWithWorldAndArgsDelegate.__FSharpherealConsoleCommandWithWorldAndArgsDelegate_DelegateParams*)__Parameters)->Args, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x040051D2 RID: 20946
		internal static IntPtr _FunctionPtr;

		// Token: 0x040051D3 RID: 20947
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealConsoleCommandWithWorldAndArgsDelegate__DelegateSignature";

		// Token: 0x040051D4 RID: 20948
		private static int RegisterId;

		// Token: 0x0200132F RID: 4911
		// (Invoke) Token: 0x0600BF37 RID: 48951
		public delegate void FSharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> Args, UWorld World);

		// Token: 0x02001330 RID: 4912
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FSharpherealConsoleCommandWithWorldAndArgsDelegate_DelegateParams
		{
			// Token: 0x04006769 RID: 26473
			[FieldOffset(0)]
			public byte Args;

			// Token: 0x0400676A RID: 26474
			[FieldOffset(16)]
			public IntPtr World;
		}

		// Token: 0x02001331 RID: 4913
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400676B RID: 26475
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
