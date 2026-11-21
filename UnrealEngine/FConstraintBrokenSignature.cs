using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001BC RID: 444
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FConstraintBrokenSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600207F RID: 8319 RVA: 0x0002FE71 File Offset: 0x0002E071
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FConstraintBrokenSignature.StaticFunctionPtr();
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x0002FE7D File Offset: 0x0002E07D
		private static IntPtr StaticFunctionPtr()
		{
			if (FConstraintBrokenSignature._FunctionPtr == IntPtr.Zero)
			{
				FConstraintBrokenSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ConstraintBrokenSignature__DelegateSignature");
			}
			return FConstraintBrokenSignature._FunctionPtr;
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x0002FEA0 File Offset: 0x0002E0A0
		public FConstraintBrokenSignature()
		{
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x0002FEA8 File Offset: 0x0002E0A8
		[NullableContext(2)]
		public FConstraintBrokenSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x0002FEB2 File Offset: 0x0002E0B2
		public FConstraintBrokenSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x0002FEBD File Offset: 0x0002E0BD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x0002FEEF File Offset: 0x0002E0EF
		[NullableContext(1)]
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

		// Token: 0x06002086 RID: 8326 RVA: 0x0002FF29 File Offset: 0x0002E129
		[NullableContext(1)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x0002FF34 File Offset: 0x0002E134
		[SkipLocalsInit]
		public unsafe void Broadcast(int ConstraintIndex)
		{
			FConstraintBrokenSignature.__FConstraintBrokenSignature_DelegateParams* ptr = stackalloc FConstraintBrokenSignature.__FConstraintBrokenSignature_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FConstraintBrokenSignature.__FConstraintBrokenSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FConstraintBrokenSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ConstraintIndex = ConstraintIndex;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x0002FF70 File Offset: 0x0002E170
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FConstraintBrokenSignature.__FConstraintBrokenSignature_DelegateParams*)__Parameters)->ConstraintIndex);
		}

		// Token: 0x04000AD3 RID: 2771
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000AD4 RID: 2772
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ConstraintBrokenSignature__DelegateSignature";

		// Token: 0x04000AD5 RID: 2773
		private static int RegisterId;

		// Token: 0x0200099B RID: 2459
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FConstraintBrokenSignature_DelegateParams
		{
			// Token: 0x04005902 RID: 22786
			[FieldOffset(0)]
			public int ConstraintIndex;
		}

		// Token: 0x0200099C RID: 2460
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005903 RID: 22787
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
