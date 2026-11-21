using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006C5 RID: 1733
	public sealed class FLGUITextInputDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009412 RID: 37906 RVA: 0x000DF487 File Offset: 0x000DD687
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUITextInputDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009413 RID: 37907 RVA: 0x000DF493 File Offset: 0x000DD693
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUITextInputDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUITextInputDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUITextInputDynamicDelegate__DelegateSignature");
			}
			return FLGUITextInputDynamicDelegate._FunctionPtr;
		}

		// Token: 0x06009414 RID: 37908 RVA: 0x000DF4B6 File Offset: 0x000DD6B6
		public FLGUITextInputDynamicDelegate()
		{
		}

		// Token: 0x06009415 RID: 37909 RVA: 0x000DF4BE File Offset: 0x000DD6BE
		[NullableContext(2)]
		public FLGUITextInputDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009416 RID: 37910 RVA: 0x000DF4C8 File Offset: 0x000DD6C8
		public FLGUITextInputDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009417 RID: 37911 RVA: 0x000DF4D3 File Offset: 0x000DD6D3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009418 RID: 37912 RVA: 0x000DF505 File Offset: 0x000DD705
		[NullableContext(1)]
		public void Bind(Action<string> Callback)
		{
			if (FLGUITextInputDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUITextInputDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUITextInputDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUITextInputDynamicDelegate.OnScriptCallback));
				}
				FLGUITextInputDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUITextInputDynamicDelegate.RegisterId);
		}

		// Token: 0x06009419 RID: 37913 RVA: 0x000DF540 File Offset: 0x000DD740
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string InString)
		{
			FLGUITextInputDynamicDelegate.__FLGUITextInputDynamicDelegate_DelegateParams* ptr = stackalloc FLGUITextInputDynamicDelegate.__FLGUITextInputDynamicDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUITextInputDynamicDelegate.__FLGUITextInputDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUITextInputDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InString), InString);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FLGUITextInputDynamicDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600941A RID: 37914 RVA: 0x000DF594 File Offset: 0x000DD794
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FLGUITextInputDynamicDelegate.__FLGUITextInputDynamicDelegate_DelegateParams*)__Parameters)->InString));
			action(obj);
		}

		// Token: 0x04004084 RID: 16516
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004085 RID: 16517
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUITextInputDynamicDelegate__DelegateSignature";

		// Token: 0x04004086 RID: 16518
		private static int RegisterId;

		// Token: 0x02000EF6 RID: 3830
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUITextInputDynamicDelegate_DelegateParams
		{
			// Token: 0x040062BA RID: 25274
			[FieldOffset(0)]
			public FString InString;
		}

		// Token: 0x02000EF7 RID: 3831
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062BB RID: 25275
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
