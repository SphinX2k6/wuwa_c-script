using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004BC RID: 1212
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FControlRigComponentDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060040FE RID: 16638 RVA: 0x0006170F File Offset: 0x0005F90F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FControlRigComponentDelegate.StaticFunctionPtr();
		}

		// Token: 0x060040FF RID: 16639 RVA: 0x0006171B File Offset: 0x0005F91B
		private static IntPtr StaticFunctionPtr()
		{
			if (FControlRigComponentDelegate._FunctionPtr == IntPtr.Zero)
			{
				FControlRigComponentDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/ControlRig.ControlRigComponentDelegate__DelegateSignature");
			}
			return FControlRigComponentDelegate._FunctionPtr;
		}

		// Token: 0x06004100 RID: 16640 RVA: 0x0006173E File Offset: 0x0005F93E
		public FControlRigComponentDelegate()
		{
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x00061746 File Offset: 0x0005F946
		[NullableContext(2)]
		public FControlRigComponentDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x00061750 File Offset: 0x0005F950
		public FControlRigComponentDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x0006175B File Offset: 0x0005F95B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UControlRigComponent>) ?? ((Action<UControlRigComponent>)Delegate.CreateDelegate(typeof(Action<UControlRigComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x0006178D File Offset: 0x0005F98D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UControlRigComponent> Callback)
		{
			if (FControlRigComponentDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FControlRigComponentDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FControlRigComponentDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FControlRigComponentDelegate.OnScriptCallback));
				}
				FControlRigComponentDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FControlRigComponentDelegate.RegisterId);
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x000617C7 File Offset: 0x0005F9C7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UControlRigComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x000617D0 File Offset: 0x0005F9D0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UControlRigComponent Component)
		{
			FControlRigComponentDelegate.__FControlRigComponentDelegate_DelegateParams* ptr = stackalloc FControlRigComponentDelegate.__FControlRigComponentDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FControlRigComponentDelegate.__FControlRigComponentDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FControlRigComponentDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Component = ((Component != null) ? Component.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x0006181C File Offset: 0x0005FA1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UControlRigComponent> action = target as Action<UControlRigComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UControlRigComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UControlRigComponent>(((FControlRigComponentDelegate.__FControlRigComponentDelegate_DelegateParams*)__Parameters)->Component);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04001EF2 RID: 7922
		internal static IntPtr _FunctionPtr;

		// Token: 0x04001EF3 RID: 7923
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.ControlRigComponentDelegate__DelegateSignature";

		// Token: 0x04001EF4 RID: 7924
		private static int RegisterId;

		// Token: 0x02002C42 RID: 11330
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FControlRigComponentDelegate_DelegateParams
		{
			// Token: 0x0401654B RID: 91467
			[FieldOffset(0)]
			public IntPtr Component;
		}

		// Token: 0x02002C43 RID: 11331
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401654C RID: 91468
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
