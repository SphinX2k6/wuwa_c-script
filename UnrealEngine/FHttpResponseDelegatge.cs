using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019F1 RID: 6641
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FHttpResponseDelegatge : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060189EC RID: 100844 RVA: 0x002447B2 File Offset: 0x002429B2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FHttpResponseDelegatge.StaticFunctionPtr();
		}

		// Token: 0x060189ED RID: 100845 RVA: 0x002447BE File Offset: 0x002429BE
		private static IntPtr StaticFunctionPtr()
		{
			if (FHttpResponseDelegatge._FunctionPtr == IntPtr.Zero)
			{
				FHttpResponseDelegatge._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.HttpResponseDelegatge__DelegateSignature");
			}
			return FHttpResponseDelegatge._FunctionPtr;
		}

		// Token: 0x060189EE RID: 100846 RVA: 0x002447E1 File Offset: 0x002429E1
		public FHttpResponseDelegatge()
		{
		}

		// Token: 0x060189EF RID: 100847 RVA: 0x002447E9 File Offset: 0x002429E9
		[NullableContext(2)]
		public FHttpResponseDelegatge(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060189F0 RID: 100848 RVA: 0x002447F3 File Offset: 0x002429F3
		public FHttpResponseDelegatge(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060189F1 RID: 100849 RVA: 0x002447FE File Offset: 0x002429FE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, string>) ?? ((Action<int, string>)Delegate.CreateDelegate(typeof(Action<int, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060189F2 RID: 100850 RVA: 0x00244830 File Offset: 0x00242A30
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, string> Callback)
		{
			if (FHttpResponseDelegatge.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FHttpResponseDelegatge.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FHttpResponseDelegatge.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FHttpResponseDelegatge.OnScriptCallback));
				}
				FHttpResponseDelegatge.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FHttpResponseDelegatge.RegisterId);
		}

		// Token: 0x060189F3 RID: 100851 RVA: 0x0024486A File Offset: 0x00242A6A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060189F4 RID: 100852 RVA: 0x00244874 File Offset: 0x00242A74
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int Code, string Data)
		{
			FHttpResponseDelegatge.__FHttpResponseDelegatge_DelegateParams* ptr = stackalloc FHttpResponseDelegatge.__FHttpResponseDelegatge_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FHttpResponseDelegatge.__FHttpResponseDelegatge_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FHttpResponseDelegatge.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Code = Code;
			FString.CopyFrom((void*)(&ptr->Data), Data);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FHttpResponseDelegatge._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060189F5 RID: 100853 RVA: 0x002448D0 File Offset: 0x00242AD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, string> action = target as Action<int, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FHttpResponseDelegatge.__FHttpResponseDelegatge_DelegateParams*)__Parameters)->Data));
			action(((FHttpResponseDelegatge.__FHttpResponseDelegatge_DelegateParams*)__Parameters)->Code, arg);
		}

		// Token: 0x0400D4F1 RID: 54513
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D4F2 RID: 54514
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.HttpResponseDelegatge__DelegateSignature";

		// Token: 0x0400D4F3 RID: 54515
		private static int RegisterId;

		// Token: 0x0200309B RID: 12443
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FHttpResponseDelegatge_DelegateParams
		{
			// Token: 0x04016DC1 RID: 93633
			[FieldOffset(0)]
			public int Code;

			// Token: 0x04016DC2 RID: 93634
			[FieldOffset(8)]
			public FString Data;
		}

		// Token: 0x0200309C RID: 12444
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016DC3 RID: 93635
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
