using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000961 RID: 2401
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentSleepSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060087AF RID: 34735 RVA: 0x000C24A9 File Offset: 0x000C06A9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentSleepSignature.StaticFunctionPtr();
		}

		// Token: 0x060087B0 RID: 34736 RVA: 0x000C24B5 File Offset: 0x000C06B5
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentSleepSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentSleepSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentSleepSignature__DelegateSignature");
			}
			return FComponentSleepSignature._FunctionPtr;
		}

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x060087B1 RID: 34737 RVA: 0x000C24D8 File Offset: 0x000C06D8
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnComponentSleep;
			}
		}

		// Token: 0x060087B2 RID: 34738 RVA: 0x000C24DF File Offset: 0x000C06DF
		[NullableContext(2)]
		public FComponentSleepSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060087B3 RID: 34739 RVA: 0x000C24E9 File Offset: 0x000C06E9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent, FName>) ?? ((Action<UPrimitiveComponent, FName>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent, FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060087B4 RID: 34740 RVA: 0x000C251C File Offset: 0x000C071C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UPrimitiveComponent, FName> Callback)
		{
			if (FComponentSleepSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentSleepSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentSleepSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentSleepSignature.OnScriptCallback));
				}
				FComponentSleepSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentSleepSignature.RegisterId);
		}

		// Token: 0x060087B5 RID: 34741 RVA: 0x000C256C File Offset: 0x000C076C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UPrimitiveComponent, FName> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x060087B6 RID: 34742 RVA: 0x000C258C File Offset: 0x000C078C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UPrimitiveComponent SleepingComponent, FName BoneName)
		{
			FComponentSleepSignature.__FComponentSleepSignature_DelegateParams* ptr = stackalloc FComponentSleepSignature.__FComponentSleepSignature_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FComponentSleepSignature.__FComponentSleepSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentSleepSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SleepingComponent = ((SleepingComponent != null) ? SleepingComponent.NativePtr : IntPtr.Zero);
			ptr->BoneName = BoneName;
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x060087B7 RID: 34743 RVA: 0x000C25F0 File Offset: 0x000C07F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UPrimitiveComponent, FName> action = target as Action<UPrimitiveComponent, FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentSleepSignature.__FComponentSleepSignature_DelegateParams*)__Parameters)->SleepingComponent);
			action(orCreateUObjectByNativePointer, ((FComponentSleepSignature.__FComponentSleepSignature_DelegateParams*)__Parameters)->BoneName);
		}

		// Token: 0x04004082 RID: 16514
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004083 RID: 16515
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentSleepSignature__DelegateSignature";

		// Token: 0x04004084 RID: 16516
		private static int RegisterId;

		// Token: 0x02002CDB RID: 11483
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FComponentSleepSignature_DelegateParams
		{
			// Token: 0x04016687 RID: 91783
			[FieldOffset(0)]
			public IntPtr SleepingComponent;

			// Token: 0x04016688 RID: 91784
			[FieldOffset(8)]
			public FName BoneName;
		}

		// Token: 0x02002CDC RID: 11484
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016689 RID: 91785
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
