using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002879 RID: 10361
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStateMachineUpdatedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060265BB RID: 157115 RVA: 0x003A490E File Offset: 0x003A2B0E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStateMachineUpdatedSignature.StaticFunctionPtr();
		}

		// Token: 0x060265BC RID: 157116 RVA: 0x003A491A File Offset: 0x003A2B1A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStateMachineUpdatedSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnStateMachineUpdatedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SMSystem.OnStateMachineUpdatedSignature__DelegateSignature");
			}
			return FOnStateMachineUpdatedSignature._FunctionPtr;
		}

		// Token: 0x060265BD RID: 157117 RVA: 0x003A493D File Offset: 0x003A2B3D
		public FOnStateMachineUpdatedSignature()
		{
		}

		// Token: 0x060265BE RID: 157118 RVA: 0x003A4945 File Offset: 0x003A2B45
		[NullableContext(2)]
		public FOnStateMachineUpdatedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060265BF RID: 157119 RVA: 0x003A494F File Offset: 0x003A2B4F
		public FOnStateMachineUpdatedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060265C0 RID: 157120 RVA: 0x003A495A File Offset: 0x003A2B5A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USMInstance, float>) ?? ((Action<USMInstance, float>)Delegate.CreateDelegate(typeof(Action<USMInstance, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060265C1 RID: 157121 RVA: 0x003A498C File Offset: 0x003A2B8C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMInstance, float> Callback)
		{
			if (FOnStateMachineUpdatedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStateMachineUpdatedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStateMachineUpdatedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStateMachineUpdatedSignature.OnScriptCallback));
				}
				FOnStateMachineUpdatedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnStateMachineUpdatedSignature.RegisterId);
		}

		// Token: 0x060265C2 RID: 157122 RVA: 0x003A49C6 File Offset: 0x003A2BC6
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMInstance, float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060265C3 RID: 157123 RVA: 0x003A49D0 File Offset: 0x003A2BD0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USMInstance Instance, float DeltaSeconds)
		{
			FOnStateMachineUpdatedSignature.__FOnStateMachineUpdatedSignature_DelegateParams* ptr = stackalloc FOnStateMachineUpdatedSignature.__FOnStateMachineUpdatedSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnStateMachineUpdatedSignature.__FOnStateMachineUpdatedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStateMachineUpdatedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Instance = ((Instance != null) ? Instance.NativePtr : IntPtr.Zero);
			ptr->DeltaSeconds = DeltaSeconds;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060265C4 RID: 157124 RVA: 0x003A4A24 File Offset: 0x003A2C24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USMInstance, float> action = target as Action<USMInstance, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USMInstance orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(((FOnStateMachineUpdatedSignature.__FOnStateMachineUpdatedSignature_DelegateParams*)__Parameters)->Instance);
			action(orCreateUObjectByNativePointer, ((FOnStateMachineUpdatedSignature.__FOnStateMachineUpdatedSignature_DelegateParams*)__Parameters)->DeltaSeconds);
		}

		// Token: 0x0401509E RID: 86174
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401509F RID: 86175
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.OnStateMachineUpdatedSignature__DelegateSignature";

		// Token: 0x040150A0 RID: 86176
		private static int RegisterId;

		// Token: 0x02003A75 RID: 14965
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnStateMachineUpdatedSignature_DelegateParams
		{
			// Token: 0x04017BD6 RID: 97238
			[FieldOffset(0)]
			public IntPtr Instance;

			// Token: 0x04017BD7 RID: 97239
			[FieldOffset(8)]
			public float DeltaSeconds;
		}

		// Token: 0x02003A76 RID: 14966
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017BD8 RID: 97240
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
