using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005F6 RID: 1526
	public sealed class FOnPostSended : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008785 RID: 34693 RVA: 0x000CB7B3 File Offset: 0x000C99B3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnPostSended.StaticFunctionPtr();
		}

		// Token: 0x06008786 RID: 34694 RVA: 0x000CB7BF File Offset: 0x000C99BF
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnPostSended._FunctionPtr == IntPtr.Zero)
			{
				FOnPostSended._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnPostSended__DelegateSignature");
			}
			return FOnPostSended._FunctionPtr;
		}

		// Token: 0x06008787 RID: 34695 RVA: 0x000CB7E2 File Offset: 0x000C99E2
		public FOnPostSended()
		{
		}

		// Token: 0x06008788 RID: 34696 RVA: 0x000CB7EA File Offset: 0x000C99EA
		[NullableContext(2)]
		public FOnPostSended(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008789 RID: 34697 RVA: 0x000CB7F4 File Offset: 0x000C99F4
		public FOnPostSended(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600878A RID: 34698 RVA: 0x000CB7FF File Offset: 0x000C99FF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnPostSended.FOnPostSended_ScriptDelegate) ?? ((FOnPostSended.FOnPostSended_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnPostSended.FOnPostSended_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600878B RID: 34699 RVA: 0x000CB831 File Offset: 0x000C9A31
		[NullableContext(1)]
		public void Bind(FOnPostSended.FOnPostSended_ScriptDelegate Callback)
		{
			if (FOnPostSended.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnPostSended.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnPostSended.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnPostSended.OnScriptCallback));
				}
				FOnPostSended.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnPostSended.RegisterId);
		}

		// Token: 0x0600878C RID: 34700 RVA: 0x000CB86C File Offset: 0x000C9A6C
		[SkipLocalsInit]
		public unsafe void Execute([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> SendedFiles)
		{
			FOnPostSended.__FOnPostSended_DelegateParams* ptr = stackalloc FOnPostSended.__FOnPostSended_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnPostSended.__FOnPostSended_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnPostSended.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<string> tarray = SendedFiles;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->SendedFiles);
			}
			base.ExecuteInternal((void*)ptr);
			TArray<string> tarray2 = SendedFiles;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->SendedFiles);
			}
			UnrealReflectionUtils.DestroyStruct(FOnPostSended._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600878D RID: 34701 RVA: 0x000CB8DC File Offset: 0x000C9ADC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnPostSended.FOnPostSended_ScriptDelegate fonPostSended_ScriptDelegate = target as FOnPostSended.FOnPostSended_ScriptDelegate;
			if (fonPostSended_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<string> tarray = new TArray<string>(&((FOnPostSended.__FOnPostSended_DelegateParams*)__Parameters)->SendedFiles, true, true);
			fonPostSended_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnPostSended.__FOnPostSended_DelegateParams*)__Parameters)->SendedFiles, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04003AED RID: 15085
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003AEE RID: 15086
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnPostSended__DelegateSignature";

		// Token: 0x04003AEF RID: 15087
		private static int RegisterId;

		// Token: 0x02000E08 RID: 3592
		// (Invoke) Token: 0x0600BF17 RID: 48919
		public delegate void FOnPostSended_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> SendedFiles);

		// Token: 0x02000E09 RID: 3593
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnPostSended_DelegateParams
		{
			// Token: 0x0400619E RID: 24990
			[FieldOffset(0)]
			public byte SendedFiles;
		}

		// Token: 0x02000E0A RID: 3594
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400619F RID: 24991
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
