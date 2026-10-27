using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EEA RID: 7914
	public sealed class FOnPrepareSendDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E143 RID: 123203 RVA: 0x002CA947 File Offset: 0x002C8B47
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnPrepareSendDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601E144 RID: 123204 RVA: 0x002CA953 File Offset: 0x002C8B53
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnPrepareSendDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnPrepareSendDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnPrepareSendDelegate__DelegateSignature");
			}
			return FOnPrepareSendDelegate._FunctionPtr;
		}

		// Token: 0x0601E145 RID: 123205 RVA: 0x002CA976 File Offset: 0x002C8B76
		public FOnPrepareSendDelegate()
		{
		}

		// Token: 0x0601E146 RID: 123206 RVA: 0x002CA97E File Offset: 0x002C8B7E
		[NullableContext(2)]
		public FOnPrepareSendDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E147 RID: 123207 RVA: 0x002CA988 File Offset: 0x002C8B88
		public FOnPrepareSendDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E148 RID: 123208 RVA: 0x002CA993 File Offset: 0x002C8B93
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnPrepareSendDelegate.FOnPrepareSendDelegate_ScriptDelegate) ?? ((FOnPrepareSendDelegate.FOnPrepareSendDelegate_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnPrepareSendDelegate.FOnPrepareSendDelegate_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E149 RID: 123209 RVA: 0x002CA9C5 File Offset: 0x002C8BC5
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FOnPrepareSendDelegate.FOnPrepareSendDelegate_ScriptDelegate Callback)
		{
			if (FOnPrepareSendDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnPrepareSendDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnPrepareSendDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnPrepareSendDelegate.OnScriptCallback));
				}
				FOnPrepareSendDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnPrepareSendDelegate.RegisterId);
		}

		// Token: 0x0601E14A RID: 123210 RVA: 0x002CAA00 File Offset: 0x002C8C00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> FileNames)
		{
			FOnPrepareSendDelegate.__FOnPrepareSendDelegate_DelegateParams* ptr = stackalloc FOnPrepareSendDelegate.__FOnPrepareSendDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnPrepareSendDelegate.__FOnPrepareSendDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnPrepareSendDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<string> tarray = FileNames;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->FileNames);
			}
			base.ExecuteInternal((void*)ptr);
			TArray<string> tarray2 = FileNames;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FileNames);
			}
			UnrealReflectionUtils.DestroyStruct(FOnPrepareSendDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E14B RID: 123211 RVA: 0x002CAA70 File Offset: 0x002C8C70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnPrepareSendDelegate.FOnPrepareSendDelegate_ScriptDelegate fonPrepareSendDelegate_ScriptDelegate = target as FOnPrepareSendDelegate.FOnPrepareSendDelegate_ScriptDelegate;
			if (fonPrepareSendDelegate_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<string> tarray = new TArray<string>(&((FOnPrepareSendDelegate.__FOnPrepareSendDelegate_DelegateParams*)__Parameters)->FileNames, true, true);
			fonPrepareSendDelegate_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnPrepareSendDelegate.__FOnPrepareSendDelegate_DelegateParams*)__Parameters)->FileNames, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04010418 RID: 66584
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010419 RID: 66585
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnPrepareSendDelegate__DelegateSignature";

		// Token: 0x0401041A RID: 66586
		private static int RegisterId;

		// Token: 0x020033BE RID: 13246
		// (Invoke) Token: 0x060285B2 RID: 165298
		public delegate void FOnPrepareSendDelegate_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> FileNames);

		// Token: 0x020033BF RID: 13247
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnPrepareSendDelegate_DelegateParams
		{
			// Token: 0x04017373 RID: 95091
			[FieldOffset(0)]
			public byte FileNames;
		}

		// Token: 0x020033C0 RID: 13248
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017374 RID: 95092
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
