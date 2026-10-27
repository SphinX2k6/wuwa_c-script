using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001940 RID: 6464
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSplinePollutionStateChangedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017F5C RID: 98140 RVA: 0x00232064 File Offset: 0x00230264
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSplinePollutionStateChangedSignature.StaticFunctionPtr();
		}

		// Token: 0x06017F5D RID: 98141 RVA: 0x00232070 File Offset: 0x00230270
		private static IntPtr StaticFunctionPtr()
		{
			if (FSplinePollutionStateChangedSignature._FunctionPtr == IntPtr.Zero)
			{
				FSplinePollutionStateChangedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.SplinePollutionStateChangedSignature__DelegateSignature");
			}
			return FSplinePollutionStateChangedSignature._FunctionPtr;
		}

		// Token: 0x06017F5E RID: 98142 RVA: 0x00232093 File Offset: 0x00230293
		public FSplinePollutionStateChangedSignature()
		{
		}

		// Token: 0x06017F5F RID: 98143 RVA: 0x0023209B File Offset: 0x0023029B
		[NullableContext(2)]
		public FSplinePollutionStateChangedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017F60 RID: 98144 RVA: 0x002320A5 File Offset: 0x002302A5
		public FSplinePollutionStateChangedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017F61 RID: 98145 RVA: 0x002320B0 File Offset: 0x002302B0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, bool>) ?? ((Action<int, bool>)Delegate.CreateDelegate(typeof(Action<int, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017F62 RID: 98146 RVA: 0x002320E2 File Offset: 0x002302E2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06017F63 RID: 98147 RVA: 0x0023211C File Offset: 0x0023031C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06017F64 RID: 98148 RVA: 0x00232128 File Offset: 0x00230328
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int SplinePbDataId, bool bAllPolluted)
		{
			FSplinePollutionStateChangedSignature.__FSplinePollutionStateChangedSignature_DelegateParams* ptr = stackalloc FSplinePollutionStateChangedSignature.__FSplinePollutionStateChangedSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSplinePollutionStateChangedSignature.__FSplinePollutionStateChangedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSplinePollutionStateChangedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SplinePbDataId = SplinePbDataId;
			ptr->bAllPolluted = bAllPolluted;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06017F65 RID: 98149 RVA: 0x0023216C File Offset: 0x0023036C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, bool> action = target as Action<int, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FSplinePollutionStateChangedSignature.__FSplinePollutionStateChangedSignature_DelegateParams*)__Parameters)->SplinePbDataId, ((FSplinePollutionStateChangedSignature.__FSplinePollutionStateChangedSignature_DelegateParams*)__Parameters)->bAllPolluted);
		}

		// Token: 0x0400CF69 RID: 53097
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CF6A RID: 53098
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.SplinePollutionStateChangedSignature__DelegateSignature";

		// Token: 0x0400CF6B RID: 53099
		private static int RegisterId;

		// Token: 0x02003009 RID: 12297
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FSplinePollutionStateChangedSignature_DelegateParams
		{
			// Token: 0x04016C26 RID: 93222
			[FieldOffset(0)]
			public int SplinePbDataId;

			// Token: 0x04016C27 RID: 93223
			[FieldOffset(4)]
			public bool bAllPolluted;
		}

		// Token: 0x0200300A RID: 12298
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016C28 RID: 93224
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
