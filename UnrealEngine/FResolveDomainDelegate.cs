using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200048D RID: 1165
	public sealed class FResolveDomainDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006D7F RID: 28031 RVA: 0x000A030E File Offset: 0x0009E50E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FResolveDomainDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006D80 RID: 28032 RVA: 0x000A031A File Offset: 0x0009E51A
		private static IntPtr StaticFunctionPtr()
		{
			if (FResolveDomainDelegate._FunctionPtr == IntPtr.Zero)
			{
				FResolveDomainDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.ResolveDomainDelegate__DelegateSignature");
			}
			return FResolveDomainDelegate._FunctionPtr;
		}

		// Token: 0x06006D81 RID: 28033 RVA: 0x000A033D File Offset: 0x0009E53D
		public FResolveDomainDelegate()
		{
		}

		// Token: 0x06006D82 RID: 28034 RVA: 0x000A0345 File Offset: 0x0009E545
		[NullableContext(2)]
		public FResolveDomainDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D83 RID: 28035 RVA: 0x000A034F File Offset: 0x0009E54F
		public FResolveDomainDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D84 RID: 28036 RVA: 0x000A035A File Offset: 0x0009E55A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006D85 RID: 28037 RVA: 0x000A038C File Offset: 0x0009E58C
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FResolveDomainDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FResolveDomainDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FResolveDomainDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FResolveDomainDelegate.OnScriptCallback));
				}
				FResolveDomainDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FResolveDomainDelegate.RegisterId);
		}

		// Token: 0x06006D86 RID: 28038 RVA: 0x000A03C8 File Offset: 0x0009E5C8
		[SkipLocalsInit]
		public unsafe void Execute(int ErrorCode)
		{
			FResolveDomainDelegate.__FResolveDomainDelegate_DelegateParams* ptr = stackalloc FResolveDomainDelegate.__FResolveDomainDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FResolveDomainDelegate.__FResolveDomainDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FResolveDomainDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ErrorCode = ErrorCode;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06006D87 RID: 28039 RVA: 0x000A0408 File Offset: 0x0009E608
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FResolveDomainDelegate.__FResolveDomainDelegate_DelegateParams*)__Parameters)->ErrorCode);
		}

		// Token: 0x04002EB8 RID: 11960
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002EB9 RID: 11961
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.ResolveDomainDelegate__DelegateSignature";

		// Token: 0x04002EBA RID: 11962
		private static int RegisterId;

		// Token: 0x02000B9C RID: 2972
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FResolveDomainDelegate_DelegateParams
		{
			// Token: 0x04005D1D RID: 23837
			[FieldOffset(0)]
			public int ErrorCode;
		}

		// Token: 0x02000B9D RID: 2973
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D1E RID: 23838
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
