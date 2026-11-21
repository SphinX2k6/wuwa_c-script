using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000422 RID: 1058
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSplinePollutionStateChangedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006610 RID: 26128 RVA: 0x000927F4 File Offset: 0x000909F4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSplinePollutionStateChangedSignature.StaticFunctionPtr();
		}

		// Token: 0x06006611 RID: 26129 RVA: 0x00092800 File Offset: 0x00090A00
		private static IntPtr StaticFunctionPtr()
		{
			if (FSplinePollutionStateChangedSignature._FunctionPtr == IntPtr.Zero)
			{
				FSplinePollutionStateChangedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.SplinePollutionStateChangedSignature__DelegateSignature");
			}
			return FSplinePollutionStateChangedSignature._FunctionPtr;
		}

		// Token: 0x06006612 RID: 26130 RVA: 0x00092823 File Offset: 0x00090A23
		public FSplinePollutionStateChangedSignature()
		{
		}

		// Token: 0x06006613 RID: 26131 RVA: 0x0009282B File Offset: 0x00090A2B
		[NullableContext(2)]
		public FSplinePollutionStateChangedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006614 RID: 26132 RVA: 0x00092835 File Offset: 0x00090A35
		public FSplinePollutionStateChangedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006615 RID: 26133 RVA: 0x00092840 File Offset: 0x00090A40
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, bool>) ?? ((Action<int, bool>)Delegate.CreateDelegate(typeof(Action<int, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006616 RID: 26134 RVA: 0x00092872 File Offset: 0x00090A72
		[NullableContext(1)]
		public void Add(Action<int, bool> Callback)
		{
			if (FSplinePollutionStateChangedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSplinePollutionStateChangedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSplinePollutionStateChangedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSplinePollutionStateChangedSignature.OnScriptCallback));
				}
				FSplinePollutionStateChangedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSplinePollutionStateChangedSignature.RegisterId);
		}

		// Token: 0x06006617 RID: 26135 RVA: 0x000928AC File Offset: 0x00090AAC
		[NullableContext(1)]
		public void Remove(Action<int, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06006618 RID: 26136 RVA: 0x000928B8 File Offset: 0x00090AB8
		[SkipLocalsInit]
		public unsafe void Broadcast(int SplinePbDataId, bool bAllPolluted)
		{
			FSplinePollutionStateChangedSignature.__FSplinePollutionStateChangedSignature_DelegateParams* ptr = stackalloc FSplinePollutionStateChangedSignature.__FSplinePollutionStateChangedSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSplinePollutionStateChangedSignature.__FSplinePollutionStateChangedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSplinePollutionStateChangedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SplinePbDataId = SplinePbDataId;
			ptr->bAllPolluted = bAllPolluted;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06006619 RID: 26137 RVA: 0x000928FC File Offset: 0x00090AFC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, bool> action = target as Action<int, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FSplinePollutionStateChangedSignature.__FSplinePollutionStateChangedSignature_DelegateParams*)__Parameters)->SplinePbDataId, ((FSplinePollutionStateChangedSignature.__FSplinePollutionStateChangedSignature_DelegateParams*)__Parameters)->bAllPolluted);
		}

		// Token: 0x04002AEA RID: 10986
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002AEB RID: 10987
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.SplinePollutionStateChangedSignature__DelegateSignature";

		// Token: 0x04002AEC RID: 10988
		private static int RegisterId;

		// Token: 0x02000B1D RID: 2845
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FSplinePollutionStateChangedSignature_DelegateParams
		{
			// Token: 0x04005BCF RID: 23503
			[FieldOffset(0)]
			public int SplinePbDataId;

			// Token: 0x04005BD0 RID: 23504
			[FieldOffset(4)]
			public bool bAllPolluted;
		}

		// Token: 0x02000B1E RID: 2846
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005BD1 RID: 23505
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
