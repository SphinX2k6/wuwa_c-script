using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200287A RID: 10362
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStateUpdateSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060265C5 RID: 157125 RVA: 0x003A4A7B File Offset: 0x003A2C7B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStateUpdateSignature.StaticFunctionPtr();
		}

		// Token: 0x060265C6 RID: 157126 RVA: 0x003A4A87 File Offset: 0x003A2C87
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStateUpdateSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnStateUpdateSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SMSystem.OnStateUpdateSignature__DelegateSignature");
			}
			return FOnStateUpdateSignature._FunctionPtr;
		}

		// Token: 0x060265C7 RID: 157127 RVA: 0x003A4AAA File Offset: 0x003A2CAA
		public FOnStateUpdateSignature()
		{
		}

		// Token: 0x060265C8 RID: 157128 RVA: 0x003A4AB2 File Offset: 0x003A2CB2
		[NullableContext(2)]
		public FOnStateUpdateSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060265C9 RID: 157129 RVA: 0x003A4ABC File Offset: 0x003A2CBC
		public FOnStateUpdateSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060265CA RID: 157130 RVA: 0x003A4AC7 File Offset: 0x003A2CC7
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USMStateInstance_Base, float>) ?? ((Action<USMStateInstance_Base, float>)Delegate.CreateDelegate(typeof(Action<USMStateInstance_Base, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060265CB RID: 157131 RVA: 0x003A4AF9 File Offset: 0x003A2CF9
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMStateInstance_Base, float> Callback)
		{
			if (FOnStateUpdateSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStateUpdateSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStateUpdateSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStateUpdateSignature.OnScriptCallback));
				}
				FOnStateUpdateSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnStateUpdateSignature.RegisterId);
		}

		// Token: 0x060265CC RID: 157132 RVA: 0x003A4B33 File Offset: 0x003A2D33
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMStateInstance_Base, float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060265CD RID: 157133 RVA: 0x003A4B3C File Offset: 0x003A2D3C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USMStateInstance_Base StateInstance, float DeltaSeconds)
		{
			FOnStateUpdateSignature.__FOnStateUpdateSignature_DelegateParams* ptr = stackalloc FOnStateUpdateSignature.__FOnStateUpdateSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnStateUpdateSignature.__FOnStateUpdateSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStateUpdateSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->StateInstance = ((StateInstance != null) ? StateInstance.NativePtr : IntPtr.Zero);
			ptr->DeltaSeconds = DeltaSeconds;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060265CE RID: 157134 RVA: 0x003A4B90 File Offset: 0x003A2D90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USMStateInstance_Base, float> action = target as Action<USMStateInstance_Base, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USMStateInstance_Base orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(((FOnStateUpdateSignature.__FOnStateUpdateSignature_DelegateParams*)__Parameters)->StateInstance);
			action(orCreateUObjectByNativePointer, ((FOnStateUpdateSignature.__FOnStateUpdateSignature_DelegateParams*)__Parameters)->DeltaSeconds);
		}

		// Token: 0x040150A1 RID: 86177
		internal static IntPtr _FunctionPtr;

		// Token: 0x040150A2 RID: 86178
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.OnStateUpdateSignature__DelegateSignature";

		// Token: 0x040150A3 RID: 86179
		private static int RegisterId;

		// Token: 0x02003A77 RID: 14967
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnStateUpdateSignature_DelegateParams
		{
			// Token: 0x04017BD9 RID: 97241
			[FieldOffset(0)]
			public IntPtr StateInstance;

			// Token: 0x04017BDA RID: 97242
			[FieldOffset(8)]
			public float DeltaSeconds;
		}

		// Token: 0x02003A78 RID: 14968
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017BDB RID: 97243
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
