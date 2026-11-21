using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000476 RID: 1142
	public sealed class FDNSResolutionDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006C6A RID: 27754 RVA: 0x0009DFAE File Offset: 0x0009C1AE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FDNSResolutionDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006C6B RID: 27755 RVA: 0x0009DFBA File Offset: 0x0009C1BA
		private static IntPtr StaticFunctionPtr()
		{
			if (FDNSResolutionDelegate._FunctionPtr == IntPtr.Zero)
			{
				FDNSResolutionDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.DNSResolutionDelegate__DelegateSignature");
			}
			return FDNSResolutionDelegate._FunctionPtr;
		}

		// Token: 0x06006C6C RID: 27756 RVA: 0x0009DFDD File Offset: 0x0009C1DD
		public FDNSResolutionDelegate()
		{
		}

		// Token: 0x06006C6D RID: 27757 RVA: 0x0009DFE5 File Offset: 0x0009C1E5
		[NullableContext(2)]
		public FDNSResolutionDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006C6E RID: 27758 RVA: 0x0009DFEF File Offset: 0x0009C1EF
		public FDNSResolutionDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006C6F RID: 27759 RVA: 0x0009DFFA File Offset: 0x0009C1FA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, TArray<string>>) ?? ((Action<int, TArray<string>>)Delegate.CreateDelegate(typeof(Action<int, TArray<string>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006C70 RID: 27760 RVA: 0x0009E02C File Offset: 0x0009C22C
		[NullableContext(1)]
		public void Bind(Action<int, TArray<string>> Callback)
		{
			if (FDNSResolutionDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FDNSResolutionDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FDNSResolutionDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FDNSResolutionDelegate.OnScriptCallback));
				}
				FDNSResolutionDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FDNSResolutionDelegate.RegisterId);
		}

		// Token: 0x06006C71 RID: 27761 RVA: 0x0009E068 File Offset: 0x0009C268
		[SkipLocalsInit]
		public unsafe void Execute(int ErrorCode, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> IpList)
		{
			FDNSResolutionDelegate.__FDNSResolutionDelegate_DelegateParams* ptr = stackalloc FDNSResolutionDelegate.__FDNSResolutionDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FDNSResolutionDelegate.__FDNSResolutionDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FDNSResolutionDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ErrorCode = ErrorCode;
			if (IpList != null)
			{
				IpList.CopyTo(&ptr->IpList, default(UScriptStructStackOnlyPtr));
			}
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FDNSResolutionDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006C72 RID: 27762 RVA: 0x0009E0D0 File Offset: 0x0009C2D0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, TArray<string>> action = target as Action<int, TArray<string>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<string> arg = new TArray<string>(&((FDNSResolutionDelegate.__FDNSResolutionDelegate_DelegateParams*)__Parameters)->IpList, true, true);
			action(((FDNSResolutionDelegate.__FDNSResolutionDelegate_DelegateParams*)__Parameters)->ErrorCode, arg);
		}

		// Token: 0x04002E4E RID: 11854
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002E4F RID: 11855
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.DNSResolutionDelegate__DelegateSignature";

		// Token: 0x04002E50 RID: 11856
		private static int RegisterId;

		// Token: 0x02000B7B RID: 2939
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FDNSResolutionDelegate_DelegateParams
		{
			// Token: 0x04005CD2 RID: 23762
			[FieldOffset(0)]
			public int ErrorCode;

			// Token: 0x04005CD3 RID: 23763
			[FieldOffset(8)]
			public byte IpList;
		}

		// Token: 0x02000B7C RID: 2940
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005CD4 RID: 23764
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
