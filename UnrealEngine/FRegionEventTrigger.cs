using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000350 RID: 848
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FRegionEventTrigger : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060056D3 RID: 22227 RVA: 0x0007A5DE File Offset: 0x000787DE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FRegionEventTrigger.StaticFunctionPtr();
		}

		// Token: 0x060056D4 RID: 22228 RVA: 0x0007A5EA File Offset: 0x000787EA
		private static IntPtr StaticFunctionPtr()
		{
			if (FRegionEventTrigger._FunctionPtr == IntPtr.Zero)
			{
				FRegionEventTrigger._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroComponent.RegionEventTrigger__DelegateSignature");
			}
			return FRegionEventTrigger._FunctionPtr;
		}

		// Token: 0x060056D5 RID: 22229 RVA: 0x0007A60D File Offset: 0x0007880D
		public FRegionEventTrigger()
		{
		}

		// Token: 0x060056D6 RID: 22230 RVA: 0x0007A615 File Offset: 0x00078815
		[NullableContext(2)]
		public FRegionEventTrigger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060056D7 RID: 22231 RVA: 0x0007A61F File Offset: 0x0007881F
		public FRegionEventTrigger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060056D8 RID: 22232 RVA: 0x0007A62A File Offset: 0x0007882A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, AActor>) ?? ((Action<bool, AActor>)Delegate.CreateDelegate(typeof(Action<bool, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060056D9 RID: 22233 RVA: 0x0007A65C File Offset: 0x0007885C
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

		// Token: 0x060056DA RID: 22234 RVA: 0x0007A696 File Offset: 0x00078896
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<bool, AActor> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060056DB RID: 22235 RVA: 0x0007A6A0 File Offset: 0x000788A0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(bool IsInRegion, AActor Target)
		{
			FRegionEventTrigger.__FRegionEventTrigger_DelegateParams* ptr = stackalloc FRegionEventTrigger.__FRegionEventTrigger_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FRegionEventTrigger.__FRegionEventTrigger_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FRegionEventTrigger.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->IsInRegion = IsInRegion;
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060056DC RID: 22236 RVA: 0x0007A6F4 File Offset: 0x000788F4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040023B9 RID: 9145
		internal static IntPtr _FunctionPtr;

		// Token: 0x040023BA RID: 9146
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComponent.RegionEventTrigger__DelegateSignature";

		// Token: 0x040023BB RID: 9147
		private static int RegisterId;

		// Token: 0x02000A62 RID: 2658
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FRegionEventTrigger_DelegateParams
		{
			// Token: 0x04005A7C RID: 23164
			[FieldOffset(0)]
			public bool IsInRegion;

			// Token: 0x04005A7D RID: 23165
			[FieldOffset(8)]
			public IntPtr Target;
		}

		// Token: 0x02000A63 RID: 2659
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005A7E RID: 23166
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
