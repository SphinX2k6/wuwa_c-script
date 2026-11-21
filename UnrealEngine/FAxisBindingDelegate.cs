using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003B6 RID: 950
	public sealed class FAxisBindingDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005D62 RID: 23906 RVA: 0x00083C98 File Offset: 0x00081E98
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAxisBindingDelegate.StaticFunctionPtr();
		}

		// Token: 0x06005D63 RID: 23907 RVA: 0x00083CA4 File Offset: 0x00081EA4
		private static IntPtr StaticFunctionPtr()
		{
			if (FAxisBindingDelegate._FunctionPtr == IntPtr.Zero)
			{
				FAxisBindingDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.AxisBindingDelegate__DelegateSignature");
			}
			return FAxisBindingDelegate._FunctionPtr;
		}

		// Token: 0x06005D64 RID: 23908 RVA: 0x00083CC7 File Offset: 0x00081EC7
		public FAxisBindingDelegate()
		{
		}

		// Token: 0x06005D65 RID: 23909 RVA: 0x00083CCF File Offset: 0x00081ECF
		[NullableContext(2)]
		public FAxisBindingDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D66 RID: 23910 RVA: 0x00083CD9 File Offset: 0x00081ED9
		public FAxisBindingDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D67 RID: 23911 RVA: 0x00083CE4 File Offset: 0x00081EE4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005D68 RID: 23912 RVA: 0x00083D16 File Offset: 0x00081F16
		[NullableContext(1)]
		public void Bind(Action<float> Callback)
		{
			if (FAxisBindingDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAxisBindingDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAxisBindingDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAxisBindingDelegate.OnScriptCallback));
				}
				FAxisBindingDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FAxisBindingDelegate.RegisterId);
		}

		// Token: 0x06005D69 RID: 23913 RVA: 0x00083D50 File Offset: 0x00081F50
		[SkipLocalsInit]
		public unsafe void Execute(float Value)
		{
			FAxisBindingDelegate.__FAxisBindingDelegate_DelegateParams* ptr = stackalloc FAxisBindingDelegate.__FAxisBindingDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FAxisBindingDelegate.__FAxisBindingDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAxisBindingDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Value = Value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06005D6A RID: 23914 RVA: 0x00083D90 File Offset: 0x00081F90
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FAxisBindingDelegate.__FAxisBindingDelegate_DelegateParams*)__Parameters)->Value);
		}

		// Token: 0x040026EE RID: 9966
		internal static IntPtr _FunctionPtr;

		// Token: 0x040026EF RID: 9967
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.AxisBindingDelegate__DelegateSignature";

		// Token: 0x040026F0 RID: 9968
		private static int RegisterId;

		// Token: 0x02000AB8 RID: 2744
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FAxisBindingDelegate_DelegateParams
		{
			// Token: 0x04005B1F RID: 23327
			[FieldOffset(0)]
			public float Value;
		}

		// Token: 0x02000AB9 RID: 2745
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B20 RID: 23328
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
