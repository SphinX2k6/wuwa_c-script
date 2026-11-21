using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200080E RID: 2062
	public sealed class FSharpherealConsoleCommandWithArgsDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B544 RID: 46404 RVA: 0x00120452 File Offset: 0x0011E652
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealConsoleCommandWithArgsDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600B545 RID: 46405 RVA: 0x0012045E File Offset: 0x0011E65E
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealConsoleCommandWithArgsDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealConsoleCommandWithArgsDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Sharphereal.SharpherealConsoleCommandWithArgsDelegate__DelegateSignature");
			}
			return FSharpherealConsoleCommandWithArgsDelegate._FunctionPtr;
		}

		// Token: 0x0600B546 RID: 46406 RVA: 0x00120481 File Offset: 0x0011E681
		public FSharpherealConsoleCommandWithArgsDelegate()
		{
		}

		// Token: 0x0600B547 RID: 46407 RVA: 0x00120489 File Offset: 0x0011E689
		[NullableContext(2)]
		public FSharpherealConsoleCommandWithArgsDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B548 RID: 46408 RVA: 0x00120493 File Offset: 0x0011E693
		public FSharpherealConsoleCommandWithArgsDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B549 RID: 46409 RVA: 0x0012049E File Offset: 0x0011E69E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FSharpherealConsoleCommandWithArgsDelegate.FSharpherealConsoleCommandWithArgsDelegate_ScriptDelegate) ?? ((FSharpherealConsoleCommandWithArgsDelegate.FSharpherealConsoleCommandWithArgsDelegate_ScriptDelegate)Delegate.CreateDelegate(typeof(FSharpherealConsoleCommandWithArgsDelegate.FSharpherealConsoleCommandWithArgsDelegate_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B54A RID: 46410 RVA: 0x001204D0 File Offset: 0x0011E6D0
		[NullableContext(1)]
		public void Bind(FSharpherealConsoleCommandWithArgsDelegate.FSharpherealConsoleCommandWithArgsDelegate_ScriptDelegate Callback)
		{
			if (FSharpherealConsoleCommandWithArgsDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealConsoleCommandWithArgsDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealConsoleCommandWithArgsDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealConsoleCommandWithArgsDelegate.OnScriptCallback));
				}
				FSharpherealConsoleCommandWithArgsDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSharpherealConsoleCommandWithArgsDelegate.RegisterId);
		}

		// Token: 0x0600B54B RID: 46411 RVA: 0x0012050C File Offset: 0x0011E70C
		[SkipLocalsInit]
		public unsafe void Execute([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> Args)
		{
			FSharpherealConsoleCommandWithArgsDelegate.__FSharpherealConsoleCommandWithArgsDelegate_DelegateParams* ptr = stackalloc FSharpherealConsoleCommandWithArgsDelegate.__FSharpherealConsoleCommandWithArgsDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSharpherealConsoleCommandWithArgsDelegate.__FSharpherealConsoleCommandWithArgsDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSharpherealConsoleCommandWithArgsDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<string> tarray = Args;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Args);
			}
			base.ExecuteInternal((void*)ptr);
			TArray<string> tarray2 = Args;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Args);
			}
			UnrealReflectionUtils.DestroyStruct(FSharpherealConsoleCommandWithArgsDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B54C RID: 46412 RVA: 0x0012057C File Offset: 0x0011E77C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FSharpherealConsoleCommandWithArgsDelegate.FSharpherealConsoleCommandWithArgsDelegate_ScriptDelegate fsharpherealConsoleCommandWithArgsDelegate_ScriptDelegate = target as FSharpherealConsoleCommandWithArgsDelegate.FSharpherealConsoleCommandWithArgsDelegate_ScriptDelegate;
			if (fsharpherealConsoleCommandWithArgsDelegate_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<string> tarray = new TArray<string>(&((FSharpherealConsoleCommandWithArgsDelegate.__FSharpherealConsoleCommandWithArgsDelegate_DelegateParams*)__Parameters)->Args, true, true);
			fsharpherealConsoleCommandWithArgsDelegate_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FSharpherealConsoleCommandWithArgsDelegate.__FSharpherealConsoleCommandWithArgsDelegate_DelegateParams*)__Parameters)->Args, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x040051CF RID: 20943
		internal static IntPtr _FunctionPtr;

		// Token: 0x040051D0 RID: 20944
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealConsoleCommandWithArgsDelegate__DelegateSignature";

		// Token: 0x040051D1 RID: 20945
		private static int RegisterId;

		// Token: 0x0200132C RID: 4908
		// (Invoke) Token: 0x0600BF33 RID: 48947
		public delegate void FSharpherealConsoleCommandWithArgsDelegate_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> Args);

		// Token: 0x0200132D RID: 4909
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FSharpherealConsoleCommandWithArgsDelegate_DelegateParams
		{
			// Token: 0x04006767 RID: 26471
			[FieldOffset(0)]
			public byte Args;
		}

		// Token: 0x0200132E RID: 4910
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006768 RID: 26472
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
