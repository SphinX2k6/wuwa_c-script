using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000339 RID: 825
	public sealed class FCloudGameOnChangeResolutionDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060055A0 RID: 21920 RVA: 0x00077B98 File Offset: 0x00075D98
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCloudGameOnChangeResolutionDelegate.StaticFunctionPtr();
		}

		// Token: 0x060055A1 RID: 21921 RVA: 0x00077BA4 File Offset: 0x00075DA4
		private static IntPtr StaticFunctionPtr()
		{
			if (FCloudGameOnChangeResolutionDelegate._FunctionPtr == IntPtr.Zero)
			{
				FCloudGameOnChangeResolutionDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroCloudGame.CloudGameOnChangeResolutionDelegate__DelegateSignature");
			}
			return FCloudGameOnChangeResolutionDelegate._FunctionPtr;
		}

		// Token: 0x060055A2 RID: 21922 RVA: 0x00077BC7 File Offset: 0x00075DC7
		public FCloudGameOnChangeResolutionDelegate()
		{
		}

		// Token: 0x060055A3 RID: 21923 RVA: 0x00077BCF File Offset: 0x00075DCF
		[NullableContext(2)]
		public FCloudGameOnChangeResolutionDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060055A4 RID: 21924 RVA: 0x00077BD9 File Offset: 0x00075DD9
		public FCloudGameOnChangeResolutionDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060055A5 RID: 21925 RVA: 0x00077BE4 File Offset: 0x00075DE4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060055A6 RID: 21926 RVA: 0x00077C16 File Offset: 0x00075E16
		[NullableContext(1)]
		public void Bind(Action<int, int> Callback)
		{
			if (FCloudGameOnChangeResolutionDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FCloudGameOnChangeResolutionDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FCloudGameOnChangeResolutionDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FCloudGameOnChangeResolutionDelegate.OnScriptCallback));
				}
				FCloudGameOnChangeResolutionDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FCloudGameOnChangeResolutionDelegate.RegisterId);
		}

		// Token: 0x060055A7 RID: 21927 RVA: 0x00077C50 File Offset: 0x00075E50
		[SkipLocalsInit]
		public unsafe void Execute(int Width, int Height)
		{
			FCloudGameOnChangeResolutionDelegate.__FCloudGameOnChangeResolutionDelegate_DelegateParams* ptr = stackalloc FCloudGameOnChangeResolutionDelegate.__FCloudGameOnChangeResolutionDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FCloudGameOnChangeResolutionDelegate.__FCloudGameOnChangeResolutionDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FCloudGameOnChangeResolutionDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Width = Width;
			ptr->Height = Height;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060055A8 RID: 21928 RVA: 0x00077C94 File Offset: 0x00075E94
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FCloudGameOnChangeResolutionDelegate.__FCloudGameOnChangeResolutionDelegate_DelegateParams*)__Parameters)->Width, ((FCloudGameOnChangeResolutionDelegate.__FCloudGameOnChangeResolutionDelegate_DelegateParams*)__Parameters)->Height);
		}

		// Token: 0x04002300 RID: 8960
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002301 RID: 8961
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroCloudGame.CloudGameOnChangeResolutionDelegate__DelegateSignature";

		// Token: 0x04002302 RID: 8962
		private static int RegisterId;

		// Token: 0x02000A2F RID: 2607
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FCloudGameOnChangeResolutionDelegate_DelegateParams
		{
			// Token: 0x04005A0A RID: 23050
			[FieldOffset(0)]
			public int Width;

			// Token: 0x04005A0B RID: 23051
			[FieldOffset(4)]
			public int Height;
		}

		// Token: 0x02000A30 RID: 2608
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005A0C RID: 23052
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
