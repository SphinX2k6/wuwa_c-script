using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013AF RID: 5039
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FRepeatedActionDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060127D0 RID: 75728 RVA: 0x001B2DAE File Offset: 0x001B0FAE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FRepeatedActionDelegate.StaticFunctionPtr();
		}

		// Token: 0x060127D1 RID: 75729 RVA: 0x001B2DBA File Offset: 0x001B0FBA
		private static IntPtr StaticFunctionPtr()
		{
			if (FRepeatedActionDelegate._FunctionPtr == IntPtr.Zero)
			{
				FRepeatedActionDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.RepeatedActionDelegate__DelegateSignature");
			}
			return FRepeatedActionDelegate._FunctionPtr;
		}

		// Token: 0x060127D2 RID: 75730 RVA: 0x001B2DDD File Offset: 0x001B0FDD
		public FRepeatedActionDelegate()
		{
		}

		// Token: 0x060127D3 RID: 75731 RVA: 0x001B2DE5 File Offset: 0x001B0FE5
		[NullableContext(2)]
		public FRepeatedActionDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060127D4 RID: 75732 RVA: 0x001B2DEF File Offset: 0x001B0FEF
		public FRepeatedActionDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060127D5 RID: 75733 RVA: 0x001B2DFA File Offset: 0x001B0FFA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060127D6 RID: 75734 RVA: 0x001B2E2C File Offset: 0x001B102C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (FRepeatedActionDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FRepeatedActionDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FRepeatedActionDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FRepeatedActionDelegate.OnScriptCallback));
				}
				FRepeatedActionDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FRepeatedActionDelegate.RegisterId);
		}

		// Token: 0x060127D7 RID: 75735 RVA: 0x001B2E66 File Offset: 0x001B1066
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060127D8 RID: 75736 RVA: 0x001B2E70 File Offset: 0x001B1070
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int ActionNumber)
		{
			FRepeatedActionDelegate.__FRepeatedActionDelegate_DelegateParams* ptr = stackalloc FRepeatedActionDelegate.__FRepeatedActionDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FRepeatedActionDelegate.__FRepeatedActionDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FRepeatedActionDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ActionNumber = ActionNumber;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060127D9 RID: 75737 RVA: 0x001B2EAC File Offset: 0x001B10AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FRepeatedActionDelegate.__FRepeatedActionDelegate_DelegateParams*)__Parameters)->ActionNumber);
		}

		// Token: 0x04009E48 RID: 40520
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E49 RID: 40521
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.RepeatedActionDelegate__DelegateSignature";

		// Token: 0x04009E4A RID: 40522
		private static int RegisterId;

		// Token: 0x02002E4D RID: 11853
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FRepeatedActionDelegate_DelegateParams
		{
			// Token: 0x04016907 RID: 92423
			[FieldOffset(0)]
			public int ActionNumber;
		}

		// Token: 0x02002E4E RID: 11854
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016908 RID: 92424
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
