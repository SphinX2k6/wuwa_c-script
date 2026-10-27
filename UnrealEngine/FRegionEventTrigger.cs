using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001769 RID: 5993
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FRegionEventTrigger : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060158E4 RID: 88292 RVA: 0x001FB71F File Offset: 0x001F991F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FRegionEventTrigger.StaticFunctionPtr();
		}

		// Token: 0x060158E5 RID: 88293 RVA: 0x001FB72B File Offset: 0x001F992B
		private static IntPtr StaticFunctionPtr()
		{
			if (FRegionEventTrigger._FunctionPtr == IntPtr.Zero)
			{
				FRegionEventTrigger._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroComponent.RegionEventTrigger__DelegateSignature");
			}
			return FRegionEventTrigger._FunctionPtr;
		}

		// Token: 0x060158E6 RID: 88294 RVA: 0x001FB74E File Offset: 0x001F994E
		public FRegionEventTrigger()
		{
		}

		// Token: 0x060158E7 RID: 88295 RVA: 0x001FB756 File Offset: 0x001F9956
		[NullableContext(2)]
		public FRegionEventTrigger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060158E8 RID: 88296 RVA: 0x001FB760 File Offset: 0x001F9960
		public FRegionEventTrigger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060158E9 RID: 88297 RVA: 0x001FB76B File Offset: 0x001F996B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, AActor>) ?? ((Action<bool, AActor>)Delegate.CreateDelegate(typeof(Action<bool, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060158EA RID: 88298 RVA: 0x001FB79D File Offset: 0x001F999D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<bool, AActor> Callback)
		{
			if (FRegionEventTrigger.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FRegionEventTrigger.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FRegionEventTrigger.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FRegionEventTrigger.OnScriptCallback));
				}
				FRegionEventTrigger.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FRegionEventTrigger.RegisterId);
		}

		// Token: 0x060158EB RID: 88299 RVA: 0x001FB7D7 File Offset: 0x001F99D7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<bool, AActor> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060158EC RID: 88300 RVA: 0x001FB7E0 File Offset: 0x001F99E0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool IsInRegion, AActor Target)
		{
			FRegionEventTrigger.__FRegionEventTrigger_DelegateParams* ptr = stackalloc FRegionEventTrigger.__FRegionEventTrigger_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FRegionEventTrigger.__FRegionEventTrigger_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FRegionEventTrigger.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->IsInRegion = IsInRegion;
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060158ED RID: 88301 RVA: 0x001FB834 File Offset: 0x001F9A34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, AActor> action = target as Action<bool, AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FRegionEventTrigger.__FRegionEventTrigger_DelegateParams*)__Parameters)->Target);
			action(((FRegionEventTrigger.__FRegionEventTrigger_DelegateParams*)__Parameters)->IsInRegion, orCreateUObjectByNativePointer);
		}

		// Token: 0x0400BC37 RID: 48183
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400BC38 RID: 48184
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComponent.RegionEventTrigger__DelegateSignature";

		// Token: 0x0400BC39 RID: 48185
		private static int RegisterId;

		// Token: 0x02002F2D RID: 12077
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FRegionEventTrigger_DelegateParams
		{
			// Token: 0x04016AA8 RID: 92840
			[FieldOffset(0)]
			public bool IsInRegion;

			// Token: 0x04016AA9 RID: 92841
			[FieldOffset(8)]
			public IntPtr Target;
		}

		// Token: 0x02002F2E RID: 12078
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016AAA RID: 92842
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
