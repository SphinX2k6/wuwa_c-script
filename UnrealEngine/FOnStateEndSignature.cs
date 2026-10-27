using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002872 RID: 10354
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStateEndSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06026575 RID: 157045 RVA: 0x003A3E61 File Offset: 0x003A2061
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStateEndSignature.StaticFunctionPtr();
		}

		// Token: 0x06026576 RID: 157046 RVA: 0x003A3E6D File Offset: 0x003A206D
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStateEndSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnStateEndSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SMSystem.OnStateEndSignature__DelegateSignature");
			}
			return FOnStateEndSignature._FunctionPtr;
		}

		// Token: 0x06026577 RID: 157047 RVA: 0x003A3E90 File Offset: 0x003A2090
		public FOnStateEndSignature()
		{
		}

		// Token: 0x06026578 RID: 157048 RVA: 0x003A3E98 File Offset: 0x003A2098
		[NullableContext(2)]
		public FOnStateEndSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026579 RID: 157049 RVA: 0x003A3EA2 File Offset: 0x003A20A2
		public FOnStateEndSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602657A RID: 157050 RVA: 0x003A3EAD File Offset: 0x003A20AD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USMStateInstance_Base>) ?? ((Action<USMStateInstance_Base>)Delegate.CreateDelegate(typeof(Action<USMStateInstance_Base>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602657B RID: 157051 RVA: 0x003A3EDF File Offset: 0x003A20DF
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMStateInstance_Base> Callback)
		{
			if (FOnStateEndSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStateEndSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStateEndSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStateEndSignature.OnScriptCallback));
				}
				FOnStateEndSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnStateEndSignature.RegisterId);
		}

		// Token: 0x0602657C RID: 157052 RVA: 0x003A3F19 File Offset: 0x003A2119
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMStateInstance_Base> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602657D RID: 157053 RVA: 0x003A3F24 File Offset: 0x003A2124
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USMStateInstance_Base StateInstance)
		{
			FOnStateEndSignature.__FOnStateEndSignature_DelegateParams* ptr = stackalloc FOnStateEndSignature.__FOnStateEndSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnStateEndSignature.__FOnStateEndSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStateEndSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->StateInstance = ((StateInstance != null) ? StateInstance.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0602657E RID: 157054 RVA: 0x003A3F70 File Offset: 0x003A2170
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USMStateInstance_Base> action = target as Action<USMStateInstance_Base>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USMStateInstance_Base orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(((FOnStateEndSignature.__FOnStateEndSignature_DelegateParams*)__Parameters)->StateInstance);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04015089 RID: 86153
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401508A RID: 86154
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.OnStateEndSignature__DelegateSignature";

		// Token: 0x0401508B RID: 86155
		private static int RegisterId;

		// Token: 0x02003A67 RID: 14951
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnStateEndSignature_DelegateParams
		{
			// Token: 0x04017BC4 RID: 97220
			[FieldOffset(0)]
			public IntPtr StateInstance;
		}

		// Token: 0x02003A68 RID: 14952
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017BC5 RID: 97221
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
