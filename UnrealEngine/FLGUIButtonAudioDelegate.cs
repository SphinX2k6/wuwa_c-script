using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200066D RID: 1645
	public sealed class FLGUIButtonAudioDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008EDF RID: 36575 RVA: 0x000D6C01 File Offset: 0x000D4E01
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIButtonAudioDelegate.StaticFunctionPtr();
		}

		// Token: 0x06008EE0 RID: 36576 RVA: 0x000D6C0D File Offset: 0x000D4E0D
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIButtonAudioDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIButtonAudioDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIButtonAudioDelegate__DelegateSignature");
			}
			return FLGUIButtonAudioDelegate._FunctionPtr;
		}

		// Token: 0x06008EE1 RID: 36577 RVA: 0x000D6C30 File Offset: 0x000D4E30
		public FLGUIButtonAudioDelegate()
		{
		}

		// Token: 0x06008EE2 RID: 36578 RVA: 0x000D6C38 File Offset: 0x000D4E38
		[NullableContext(2)]
		public FLGUIButtonAudioDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008EE3 RID: 36579 RVA: 0x000D6C42 File Offset: 0x000D4E42
		public FLGUIButtonAudioDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008EE4 RID: 36580 RVA: 0x000D6C4D File Offset: 0x000D4E4D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008EE5 RID: 36581 RVA: 0x000D6C7F File Offset: 0x000D4E7F
		[NullableContext(1)]
		public void Bind(Action<string> Callback)
		{
			if (FLGUIButtonAudioDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIButtonAudioDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIButtonAudioDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIButtonAudioDelegate.OnScriptCallback));
				}
				FLGUIButtonAudioDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIButtonAudioDelegate.RegisterId);
		}

		// Token: 0x06008EE6 RID: 36582 RVA: 0x000D6CBC File Offset: 0x000D4EBC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string eventName)
		{
			FLGUIButtonAudioDelegate.__FLGUIButtonAudioDelegate_DelegateParams* ptr = stackalloc FLGUIButtonAudioDelegate.__FLGUIButtonAudioDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIButtonAudioDelegate.__FLGUIButtonAudioDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIButtonAudioDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->eventName), eventName);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FLGUIButtonAudioDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008EE7 RID: 36583 RVA: 0x000D6D10 File Offset: 0x000D4F10
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FLGUIButtonAudioDelegate.__FLGUIButtonAudioDelegate_DelegateParams*)__Parameters)->eventName));
			action(obj);
		}

		// Token: 0x04003EA5 RID: 16037
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003EA6 RID: 16038
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIButtonAudioDelegate__DelegateSignature";

		// Token: 0x04003EA7 RID: 16039
		private static int RegisterId;

		// Token: 0x02000E78 RID: 3704
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUIButtonAudioDelegate_DelegateParams
		{
			// Token: 0x04006223 RID: 25123
			[FieldOffset(0)]
			public FString eventName;
		}

		// Token: 0x02000E79 RID: 3705
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006224 RID: 25124
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
