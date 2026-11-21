using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007F0 RID: 2032
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FSharpherealTestSparseMultiDelegate1 : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600ADC4 RID: 44484 RVA: 0x00101280 File Offset: 0x000FF480
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealTestSparseMultiDelegate1.StaticFunctionPtr();
		}

		// Token: 0x0600ADC5 RID: 44485 RVA: 0x0010128C File Offset: 0x000FF48C
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealTestSparseMultiDelegate1._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealTestSparseMultiDelegate1._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SharpherealTest.SharpherealTestSparseMultiDelegate1__DelegateSignature");
			}
			return FSharpherealTestSparseMultiDelegate1._FunctionPtr;
		}

		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x0600ADC6 RID: 44486 RVA: 0x001012AF File Offset: 0x000FF4AF
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.SparseMulti1;
			}
		}

		// Token: 0x0600ADC7 RID: 44487 RVA: 0x001012B6 File Offset: 0x000FF4B6
		[NullableContext(2)]
		public FSharpherealTestSparseMultiDelegate1(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ADC8 RID: 44488 RVA: 0x001012C0 File Offset: 0x000FF4C0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600ADC9 RID: 44489 RVA: 0x001012F4 File Offset: 0x000FF4F4
		[NullableContext(1)]
		public void Add(Action<int> Callback)
		{
			if (FSharpherealTestSparseMultiDelegate1.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealTestSparseMultiDelegate1.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealTestSparseMultiDelegate1.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealTestSparseMultiDelegate1.OnScriptCallback));
				}
				FSharpherealTestSparseMultiDelegate1.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FSharpherealTestSparseMultiDelegate1.RegisterId);
		}

		// Token: 0x0600ADCA RID: 44490 RVA: 0x00101344 File Offset: 0x000FF544
		[NullableContext(1)]
		public void Remove(Action<int> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x0600ADCB RID: 44491 RVA: 0x00101364 File Offset: 0x000FF564
		[SkipLocalsInit]
		public unsafe void Broadcast(int Val)
		{
			FSharpherealTestSparseMultiDelegate1.__FSharpherealTestSparseMultiDelegate1_DelegateParams* ptr = stackalloc FSharpherealTestSparseMultiDelegate1.__FSharpherealTestSparseMultiDelegate1_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FSharpherealTestSparseMultiDelegate1.__FSharpherealTestSparseMultiDelegate1_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSharpherealTestSparseMultiDelegate1.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Val = Val;
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x0600ADCC RID: 44492 RVA: 0x001013B0 File Offset: 0x000FF5B0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FSharpherealTestSparseMultiDelegate1.__FSharpherealTestSparseMultiDelegate1_DelegateParams*)__Parameters)->Val);
		}

		// Token: 0x04004AF9 RID: 19193
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004AFA RID: 19194
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestSparseMultiDelegate1__DelegateSignature";

		// Token: 0x04004AFB RID: 19195
		private static int RegisterId;

		// Token: 0x02000F9A RID: 3994
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FSharpherealTestSparseMultiDelegate1_DelegateParams
		{
			// Token: 0x0400639E RID: 25502
			[FieldOffset(0)]
			public int Val;
		}

		// Token: 0x02000F9B RID: 3995
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400639F RID: 25503
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
