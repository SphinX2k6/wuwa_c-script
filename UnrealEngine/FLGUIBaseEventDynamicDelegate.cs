using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000667 RID: 1639
	public sealed class FLGUIBaseEventDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008DE9 RID: 36329 RVA: 0x000D5B62 File Offset: 0x000D3D62
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIBaseEventDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x06008DEA RID: 36330 RVA: 0x000D5B6E File Offset: 0x000D3D6E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIBaseEventDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIBaseEventDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIBaseEventDynamicDelegate__DelegateSignature");
			}
			return FLGUIBaseEventDynamicDelegate._FunctionPtr;
		}

		// Token: 0x06008DEB RID: 36331 RVA: 0x000D5B91 File Offset: 0x000D3D91
		public FLGUIBaseEventDynamicDelegate()
		{
		}

		// Token: 0x06008DEC RID: 36332 RVA: 0x000D5B99 File Offset: 0x000D3D99
		[NullableContext(2)]
		public FLGUIBaseEventDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008DED RID: 36333 RVA: 0x000D5BA3 File Offset: 0x000D3DA3
		public FLGUIBaseEventDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008DEE RID: 36334 RVA: 0x000D5BAE File Offset: 0x000D3DAE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<ULGUIBaseEventData>) ?? ((Action<ULGUIBaseEventData>)Delegate.CreateDelegate(typeof(Action<ULGUIBaseEventData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008DEF RID: 36335 RVA: 0x000D5BE0 File Offset: 0x000D3DE0
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<ULGUIBaseEventData> Callback)
		{
			if (FLGUIBaseEventDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIBaseEventDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIBaseEventDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIBaseEventDynamicDelegate.OnScriptCallback));
				}
				FLGUIBaseEventDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIBaseEventDynamicDelegate.RegisterId);
		}

		// Token: 0x06008DF0 RID: 36336 RVA: 0x000D5C1C File Offset: 0x000D3E1C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(ULGUIBaseEventData eventData)
		{
			FLGUIBaseEventDynamicDelegate.__FLGUIBaseEventDynamicDelegate_DelegateParams* ptr = stackalloc FLGUIBaseEventDynamicDelegate.__FLGUIBaseEventDynamicDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIBaseEventDynamicDelegate.__FLGUIBaseEventDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIBaseEventDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06008DF1 RID: 36337 RVA: 0x000D5C68 File Offset: 0x000D3E68
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<ULGUIBaseEventData> action = target as Action<ULGUIBaseEventData>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ULGUIBaseEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIBaseEventData>(((FLGUIBaseEventDynamicDelegate.__FLGUIBaseEventDynamicDelegate_DelegateParams*)__Parameters)->eventData);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04003E8B RID: 16011
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003E8C RID: 16012
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIBaseEventDynamicDelegate__DelegateSignature";

		// Token: 0x04003E8D RID: 16013
		private static int RegisterId;

		// Token: 0x02000E6C RID: 3692
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FLGUIBaseEventDynamicDelegate_DelegateParams
		{
			// Token: 0x04006214 RID: 25108
			[FieldOffset(0)]
			public IntPtr eventData;
		}

		// Token: 0x02000E6D RID: 3693
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006215 RID: 25109
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
