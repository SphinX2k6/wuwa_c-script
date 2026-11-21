using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007DB RID: 2011
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnQteAnimEnd : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600AD0C RID: 44300 RVA: 0x000FFCAA File Offset: 0x000FDEAA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnQteAnimEnd.StaticFunctionPtr();
		}

		// Token: 0x0600AD0D RID: 44301 RVA: 0x000FFCB6 File Offset: 0x000FDEB6
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnQteAnimEnd._FunctionPtr == IntPtr.Zero)
			{
				FOnQteAnimEnd._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SequenceDialogue.OnQteAnimEnd__DelegateSignature");
			}
			return FOnQteAnimEnd._FunctionPtr;
		}

		// Token: 0x0600AD0E RID: 44302 RVA: 0x000FFCD9 File Offset: 0x000FDED9
		public FOnQteAnimEnd()
		{
		}

		// Token: 0x0600AD0F RID: 44303 RVA: 0x000FFCE1 File Offset: 0x000FDEE1
		[NullableContext(2)]
		public FOnQteAnimEnd(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AD10 RID: 44304 RVA: 0x000FFCEB File Offset: 0x000FDEEB
		public FOnQteAnimEnd(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AD11 RID: 44305 RVA: 0x000FFCF6 File Offset: 0x000FDEF6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600AD12 RID: 44306 RVA: 0x000FFD28 File Offset: 0x000FDF28
		[NullableContext(1)]
		public void Add(Action<int> Callback)
		{
			if (FOnQteAnimEnd.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnQteAnimEnd.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnQteAnimEnd.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnQteAnimEnd.OnScriptCallback));
				}
				FOnQteAnimEnd.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnQteAnimEnd.RegisterId);
		}

		// Token: 0x0600AD13 RID: 44307 RVA: 0x000FFD62 File Offset: 0x000FDF62
		[NullableContext(1)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600AD14 RID: 44308 RVA: 0x000FFD6C File Offset: 0x000FDF6C
		[SkipLocalsInit]
		public unsafe void Broadcast(int QteId)
		{
			FOnQteAnimEnd.__FOnQteAnimEnd_DelegateParams* ptr = stackalloc FOnQteAnimEnd.__FOnQteAnimEnd_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnQteAnimEnd.__FOnQteAnimEnd_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnQteAnimEnd.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->QteId = QteId;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600AD15 RID: 44309 RVA: 0x000FFDA8 File Offset: 0x000FDFA8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnQteAnimEnd.__FOnQteAnimEnd_DelegateParams*)__Parameters)->QteId);
		}

		// Token: 0x04004A9A RID: 19098
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004A9B RID: 19099
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.OnQteAnimEnd__DelegateSignature";

		// Token: 0x04004A9C RID: 19100
		private static int RegisterId;

		// Token: 0x02000F83 RID: 3971
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FOnQteAnimEnd_DelegateParams
		{
			// Token: 0x0400637D RID: 25469
			[FieldOffset(0)]
			public int QteId;
		}

		// Token: 0x02000F84 RID: 3972
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400637E RID: 25470
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
