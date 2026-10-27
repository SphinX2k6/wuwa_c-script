using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001D1 RID: 465
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOAISimpleDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001B74 RID: 7028 RVA: 0x00028F49 File Offset: 0x00027149
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOAISimpleDelegate.StaticFunctionPtr();
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x00028F55 File Offset: 0x00027155
		private static IntPtr StaticFunctionPtr()
		{
			if (FOAISimpleDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOAISimpleDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AIModule.OAISimpleDelegate__DelegateSignature");
			}
			return FOAISimpleDelegate._FunctionPtr;
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00028F78 File Offset: 0x00027178
		public FOAISimpleDelegate()
		{
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00028F80 File Offset: 0x00027180
		[NullableContext(2)]
		public FOAISimpleDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x00028F8A File Offset: 0x0002718A
		public FOAISimpleDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x00028F95 File Offset: 0x00027195
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<EPathFollowingResult>>) ?? ((Action<TEnumAsByte<EPathFollowingResult>>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<EPathFollowingResult>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x00028FC7 File Offset: 0x000271C7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			0
		})] Action<TEnumAsByte<EPathFollowingResult>> Callback)
		{
			if (FOAISimpleDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOAISimpleDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOAISimpleDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOAISimpleDelegate.OnScriptCallback));
				}
				FOAISimpleDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOAISimpleDelegate.RegisterId);
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x00029001 File Offset: 0x00027201
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			0
		})] Action<TEnumAsByte<EPathFollowingResult>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0002900C File Offset: 0x0002720C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(EPathFollowingResult MovementResult)
		{
			FOAISimpleDelegate.__FOAISimpleDelegate_DelegateParams* ptr = stackalloc FOAISimpleDelegate.__FOAISimpleDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOAISimpleDelegate.__FOAISimpleDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOAISimpleDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->MovementResult = MovementResult;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x00029050 File Offset: 0x00027250
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TEnumAsByte<EPathFollowingResult>> action = target as Action<TEnumAsByte<EPathFollowingResult>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOAISimpleDelegate.__FOAISimpleDelegate_DelegateParams*)__Parameters)->MovementResult);
		}

		// Token: 0x040008CB RID: 2251
		internal static IntPtr _FunctionPtr;

		// Token: 0x040008CC RID: 2252
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.OAISimpleDelegate__DelegateSignature";

		// Token: 0x040008CD RID: 2253
		private static int RegisterId;

		// Token: 0x02002B6F RID: 11119
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOAISimpleDelegate_DelegateParams
		{
			// Token: 0x040163F8 RID: 91128
			[FieldOffset(0)]
			public TEnumAsByte<EPathFollowingResult> MovementResult;
		}

		// Token: 0x02002B70 RID: 11120
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040163F9 RID: 91129
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
