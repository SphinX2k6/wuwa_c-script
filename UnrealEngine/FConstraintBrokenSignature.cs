using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200096F RID: 2415
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FConstraintBrokenSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008853 RID: 34899 RVA: 0x000C34A4 File Offset: 0x000C16A4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FConstraintBrokenSignature.StaticFunctionPtr();
		}

		// Token: 0x06008854 RID: 34900 RVA: 0x000C34B0 File Offset: 0x000C16B0
		private static IntPtr StaticFunctionPtr()
		{
			if (FConstraintBrokenSignature._FunctionPtr == IntPtr.Zero)
			{
				FConstraintBrokenSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ConstraintBrokenSignature__DelegateSignature");
			}
			return FConstraintBrokenSignature._FunctionPtr;
		}

		// Token: 0x06008855 RID: 34901 RVA: 0x000C34D3 File Offset: 0x000C16D3
		public FConstraintBrokenSignature()
		{
		}

		// Token: 0x06008856 RID: 34902 RVA: 0x000C34DB File Offset: 0x000C16DB
		[NullableContext(2)]
		public FConstraintBrokenSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008857 RID: 34903 RVA: 0x000C34E5 File Offset: 0x000C16E5
		public FConstraintBrokenSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008858 RID: 34904 RVA: 0x000C34F0 File Offset: 0x000C16F0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008859 RID: 34905 RVA: 0x000C3522 File Offset: 0x000C1722
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (FConstraintBrokenSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FConstraintBrokenSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FConstraintBrokenSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FConstraintBrokenSignature.OnScriptCallback));
				}
				FConstraintBrokenSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FConstraintBrokenSignature.RegisterId);
		}

		// Token: 0x0600885A RID: 34906 RVA: 0x000C355C File Offset: 0x000C175C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600885B RID: 34907 RVA: 0x000C3568 File Offset: 0x000C1768
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int ConstraintIndex)
		{
			FConstraintBrokenSignature.__FConstraintBrokenSignature_DelegateParams* ptr = stackalloc FConstraintBrokenSignature.__FConstraintBrokenSignature_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FConstraintBrokenSignature.__FConstraintBrokenSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FConstraintBrokenSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ConstraintIndex = ConstraintIndex;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600885C RID: 34908 RVA: 0x000C35A4 File Offset: 0x000C17A4
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
			action(((FConstraintBrokenSignature.__FConstraintBrokenSignature_DelegateParams*)__Parameters)->ConstraintIndex);
		}

		// Token: 0x040040CE RID: 16590
		internal static IntPtr _FunctionPtr;

		// Token: 0x040040CF RID: 16591
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ConstraintBrokenSignature__DelegateSignature";

		// Token: 0x040040D0 RID: 16592
		private static int RegisterId;

		// Token: 0x02002CDF RID: 11487
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FConstraintBrokenSignature_DelegateParams
		{
			// Token: 0x0401668D RID: 91789
			[FieldOffset(0)]
			public int ConstraintIndex;
		}

		// Token: 0x02002CE0 RID: 11488
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401668E RID: 91790
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
