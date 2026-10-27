using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000335 RID: 821
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMontagePlayDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06002DAD RID: 11693 RVA: 0x00045F8B File Offset: 0x0004418B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMontagePlayDelegate.StaticFunctionPtr();
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x00045F97 File Offset: 0x00044197
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMontagePlayDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnMontagePlayDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AnimGraphRuntime.OnMontagePlayDelegate__DelegateSignature");
			}
			return FOnMontagePlayDelegate._FunctionPtr;
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x00045FBA File Offset: 0x000441BA
		public FOnMontagePlayDelegate()
		{
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x00045FC2 File Offset: 0x000441C2
		[NullableContext(2)]
		public FOnMontagePlayDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x00045FCC File Offset: 0x000441CC
		public FOnMontagePlayDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x00045FD7 File Offset: 0x000441D7
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FName>) ?? ((Action<FName>)Delegate.CreateDelegate(typeof(Action<FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x00046009 File Offset: 0x00044209
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FName> Callback)
		{
			if (FOnMontagePlayDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMontagePlayDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMontagePlayDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMontagePlayDelegate.OnScriptCallback));
				}
				FOnMontagePlayDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMontagePlayDelegate.RegisterId);
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x00046043 File Offset: 0x00044243
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FName> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x0004604C File Offset: 0x0004424C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FName NotifyName)
		{
			FOnMontagePlayDelegate.__FOnMontagePlayDelegate_DelegateParams* ptr = stackalloc FOnMontagePlayDelegate.__FOnMontagePlayDelegate_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FOnMontagePlayDelegate.__FOnMontagePlayDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMontagePlayDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x00046088 File Offset: 0x00044288
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName> action = target as Action<FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnMontagePlayDelegate.__FOnMontagePlayDelegate_DelegateParams*)__Parameters)->NotifyName);
		}

		// Token: 0x04001389 RID: 5001
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400138A RID: 5002
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimGraphRuntime.OnMontagePlayDelegate__DelegateSignature";

		// Token: 0x0400138B RID: 5003
		private static int RegisterId;

		// Token: 0x02002BC9 RID: 11209
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FOnMontagePlayDelegate_DelegateParams
		{
			// Token: 0x0401647B RID: 91259
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02002BCA RID: 11210
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401647C RID: 91260
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
