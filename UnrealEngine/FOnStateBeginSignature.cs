using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002871 RID: 10353
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStateBeginSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602656B RID: 157035 RVA: 0x003A3D01 File Offset: 0x003A1F01
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStateBeginSignature.StaticFunctionPtr();
		}

		// Token: 0x0602656C RID: 157036 RVA: 0x003A3D0D File Offset: 0x003A1F0D
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStateBeginSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnStateBeginSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SMSystem.OnStateBeginSignature__DelegateSignature");
			}
			return FOnStateBeginSignature._FunctionPtr;
		}

		// Token: 0x0602656D RID: 157037 RVA: 0x003A3D30 File Offset: 0x003A1F30
		public FOnStateBeginSignature()
		{
		}

		// Token: 0x0602656E RID: 157038 RVA: 0x003A3D38 File Offset: 0x003A1F38
		[NullableContext(2)]
		public FOnStateBeginSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602656F RID: 157039 RVA: 0x003A3D42 File Offset: 0x003A1F42
		public FOnStateBeginSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026570 RID: 157040 RVA: 0x003A3D4D File Offset: 0x003A1F4D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USMStateInstance_Base>) ?? ((Action<USMStateInstance_Base>)Delegate.CreateDelegate(typeof(Action<USMStateInstance_Base>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06026571 RID: 157041 RVA: 0x003A3D7F File Offset: 0x003A1F7F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMStateInstance_Base> Callback)
		{
			if (FOnStateBeginSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStateBeginSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStateBeginSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStateBeginSignature.OnScriptCallback));
				}
				FOnStateBeginSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnStateBeginSignature.RegisterId);
		}

		// Token: 0x06026572 RID: 157042 RVA: 0x003A3DB9 File Offset: 0x003A1FB9
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMStateInstance_Base> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06026573 RID: 157043 RVA: 0x003A3DC4 File Offset: 0x003A1FC4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USMStateInstance_Base StateInstance)
		{
			FOnStateBeginSignature.__FOnStateBeginSignature_DelegateParams* ptr = stackalloc FOnStateBeginSignature.__FOnStateBeginSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnStateBeginSignature.__FOnStateBeginSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStateBeginSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->StateInstance = ((StateInstance != null) ? StateInstance.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06026574 RID: 157044 RVA: 0x003A3E10 File Offset: 0x003A2010
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
			USMStateInstance_Base orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(((FOnStateBeginSignature.__FOnStateBeginSignature_DelegateParams*)__Parameters)->StateInstance);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04015086 RID: 86150
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015087 RID: 86151
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.OnStateBeginSignature__DelegateSignature";

		// Token: 0x04015088 RID: 86152
		private static int RegisterId;

		// Token: 0x02003A65 RID: 14949
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnStateBeginSignature_DelegateParams
		{
			// Token: 0x04017BC2 RID: 97218
			[FieldOffset(0)]
			public IntPtr StateInstance;
		}

		// Token: 0x02003A66 RID: 14950
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017BC3 RID: 97219
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
