using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005F7 RID: 1527
	public sealed class FOnPrepareSendDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600878E RID: 34702 RVA: 0x000CB94B File Offset: 0x000C9B4B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnPrepareSendDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600878F RID: 34703 RVA: 0x000CB957 File Offset: 0x000C9B57
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnPrepareSendDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnPrepareSendDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnPrepareSendDelegate__DelegateSignature");
			}
			return FOnPrepareSendDelegate._FunctionPtr;
		}

		// Token: 0x06008790 RID: 34704 RVA: 0x000CB97A File Offset: 0x000C9B7A
		public FOnPrepareSendDelegate()
		{
		}

		// Token: 0x06008791 RID: 34705 RVA: 0x000CB982 File Offset: 0x000C9B82
		[NullableContext(2)]
		public FOnPrepareSendDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008792 RID: 34706 RVA: 0x000CB98C File Offset: 0x000C9B8C
		public FOnPrepareSendDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008793 RID: 34707 RVA: 0x000CB997 File Offset: 0x000C9B97
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnPrepareSendDelegate.FOnPrepareSendDelegate_ScriptDelegate) ?? ((FOnPrepareSendDelegate.FOnPrepareSendDelegate_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnPrepareSendDelegate.FOnPrepareSendDelegate_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008794 RID: 34708 RVA: 0x000CB9C9 File Offset: 0x000C9BC9
		[NullableContext(1)]
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

		// Token: 0x06008795 RID: 34709 RVA: 0x000CBA04 File Offset: 0x000C9C04
		[SkipLocalsInit]
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

		// Token: 0x06008796 RID: 34710 RVA: 0x000CBA74 File Offset: 0x000C9C74
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003AF0 RID: 15088
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003AF1 RID: 15089
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnPrepareSendDelegate__DelegateSignature";

		// Token: 0x04003AF2 RID: 15090
		private static int RegisterId;

		// Token: 0x02000E0B RID: 3595
		// (Invoke) Token: 0x0600BF1B RID: 48923
		public delegate void FOnPrepareSendDelegate_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> FileNames);

		// Token: 0x02000E0C RID: 3596
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnPrepareSendDelegate_DelegateParams
		{
			// Token: 0x040061A0 RID: 24992
			[FieldOffset(0)]
			public byte FileNames;
		}

		// Token: 0x02000E0D RID: 3597
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061A1 RID: 24993
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
