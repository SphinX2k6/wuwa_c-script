using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019EE RID: 6638
	public sealed class FDNSResolutionDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060189E3 RID: 100835 RVA: 0x00244638 File Offset: 0x00242838
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FDNSResolutionDelegate.StaticFunctionPtr();
		}

		// Token: 0x060189E4 RID: 100836 RVA: 0x00244644 File Offset: 0x00242844
		private static IntPtr StaticFunctionPtr()
		{
			if (FDNSResolutionDelegate._FunctionPtr == IntPtr.Zero)
			{
				FDNSResolutionDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.DNSResolutionDelegate__DelegateSignature");
			}
			return FDNSResolutionDelegate._FunctionPtr;
		}

		// Token: 0x060189E5 RID: 100837 RVA: 0x00244667 File Offset: 0x00242867
		public FDNSResolutionDelegate()
		{
		}

		// Token: 0x060189E6 RID: 100838 RVA: 0x0024466F File Offset: 0x0024286F
		[NullableContext(2)]
		public FDNSResolutionDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060189E7 RID: 100839 RVA: 0x00244679 File Offset: 0x00242879
		public FDNSResolutionDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060189E8 RID: 100840 RVA: 0x00244684 File Offset: 0x00242884
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, TArray<string>>) ?? ((Action<int, TArray<string>>)Delegate.CreateDelegate(typeof(Action<int, TArray<string>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060189E9 RID: 100841 RVA: 0x002446B6 File Offset: 0x002428B6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x060189EA RID: 100842 RVA: 0x002446F0 File Offset: 0x002428F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x060189EB RID: 100843 RVA: 0x00244758 File Offset: 0x00242958
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400D4E5 RID: 54501
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D4E6 RID: 54502
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.DNSResolutionDelegate__DelegateSignature";

		// Token: 0x0400D4E7 RID: 54503
		private static int RegisterId;

		// Token: 0x02003099 RID: 12441
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FDNSResolutionDelegate_DelegateParams
		{
			// Token: 0x04016DBE RID: 93630
			[FieldOffset(0)]
			public int ErrorCode;

			// Token: 0x04016DBF RID: 93631
			[FieldOffset(8)]
			public byte IpList;
		}

		// Token: 0x0200309A RID: 12442
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016DC0 RID: 93632
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
