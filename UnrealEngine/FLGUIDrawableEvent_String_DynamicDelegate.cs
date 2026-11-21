using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000689 RID: 1673
	public sealed class FLGUIDrawableEvent_String_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060090BF RID: 37055 RVA: 0x000D9912 File Offset: 0x000D7B12
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_String_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060090C0 RID: 37056 RVA: 0x000D991E File Offset: 0x000D7B1E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_String_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_String_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_String_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_String_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x060090C1 RID: 37057 RVA: 0x000D9941 File Offset: 0x000D7B41
		public FLGUIDrawableEvent_String_DynamicDelegate()
		{
		}

		// Token: 0x060090C2 RID: 37058 RVA: 0x000D9949 File Offset: 0x000D7B49
		[NullableContext(2)]
		public FLGUIDrawableEvent_String_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060090C3 RID: 37059 RVA: 0x000D9953 File Offset: 0x000D7B53
		public FLGUIDrawableEvent_String_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060090C4 RID: 37060 RVA: 0x000D995E File Offset: 0x000D7B5E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060090C5 RID: 37061 RVA: 0x000D9990 File Offset: 0x000D7B90
		[NullableContext(1)]
		public void Bind(Action<string> Callback)
		{
			if (FLGUIDrawableEvent_String_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_String_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_String_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_String_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_String_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_String_DynamicDelegate.RegisterId);
		}

		// Token: 0x060090C6 RID: 37062 RVA: 0x000D99CC File Offset: 0x000D7BCC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string value)
		{
			FLGUIDrawableEvent_String_DynamicDelegate.__FLGUIDrawableEvent_String_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_String_DynamicDelegate.__FLGUIDrawableEvent_String_DynamicDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIDrawableEvent_String_DynamicDelegate.__FLGUIDrawableEvent_String_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_String_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->value), value);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FLGUIDrawableEvent_String_DynamicDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060090C7 RID: 37063 RVA: 0x000D9A20 File Offset: 0x000D7C20
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FLGUIDrawableEvent_String_DynamicDelegate.__FLGUIDrawableEvent_String_DynamicDelegate_DelegateParams*)__Parameters)->value));
			action(obj);
		}

		// Token: 0x04003F34 RID: 16180
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F35 RID: 16181
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_String_DynamicDelegate__DelegateSignature";

		// Token: 0x04003F36 RID: 16182
		private static int RegisterId;

		// Token: 0x02000EA5 RID: 3749
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUIDrawableEvent_String_DynamicDelegate_DelegateParams
		{
			// Token: 0x04006254 RID: 25172
			[FieldOffset(0)]
			public FString value;
		}

		// Token: 0x02000EA6 RID: 3750
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006255 RID: 25173
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
