using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000683 RID: 1667
	public sealed class FLGUIDrawableEvent_Int64_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009089 RID: 37001 RVA: 0x000D9152 File Offset: 0x000D7352
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Int64_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600908A RID: 37002 RVA: 0x000D915E File Offset: 0x000D735E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Int64_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Int64_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Int64_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Int64_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0600908B RID: 37003 RVA: 0x000D9181 File Offset: 0x000D7381
		public FLGUIDrawableEvent_Int64_DynamicDelegate()
		{
		}

		// Token: 0x0600908C RID: 37004 RVA: 0x000D9189 File Offset: 0x000D7389
		[NullableContext(2)]
		public FLGUIDrawableEvent_Int64_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600908D RID: 37005 RVA: 0x000D9193 File Offset: 0x000D7393
		public FLGUIDrawableEvent_Int64_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600908E RID: 37006 RVA: 0x000D919E File Offset: 0x000D739E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<long>) ?? ((Action<long>)Delegate.CreateDelegate(typeof(Action<long>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600908F RID: 37007 RVA: 0x000D91D0 File Offset: 0x000D73D0
		[NullableContext(1)]
		public void Bind(Action<long> Callback)
		{
			if (FLGUIDrawableEvent_Int64_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Int64_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Int64_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Int64_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Int64_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Int64_DynamicDelegate.RegisterId);
		}

		// Token: 0x06009090 RID: 37008 RVA: 0x000D920C File Offset: 0x000D740C
		[SkipLocalsInit]
		public unsafe void Execute(long value)
		{
			FLGUIDrawableEvent_Int64_DynamicDelegate.__FLGUIDrawableEvent_Int64_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Int64_DynamicDelegate.__FLGUIDrawableEvent_Int64_DynamicDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIDrawableEvent_Int64_DynamicDelegate.__FLGUIDrawableEvent_Int64_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Int64_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06009091 RID: 37009 RVA: 0x000D924C File Offset: 0x000D744C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<long> action = target as Action<long>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_Int64_DynamicDelegate.__FLGUIDrawableEvent_Int64_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04003F22 RID: 16162
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F23 RID: 16163
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Int64_DynamicDelegate__DelegateSignature";

		// Token: 0x04003F24 RID: 16164
		private static int RegisterId;

		// Token: 0x02000E99 RID: 3737
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FLGUIDrawableEvent_Int64_DynamicDelegate_DelegateParams
		{
			// Token: 0x04006248 RID: 25160
			[FieldOffset(0)]
			public long value;
		}

		// Token: 0x02000E9A RID: 3738
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006249 RID: 25161
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
