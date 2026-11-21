using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007DC RID: 2012
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnQteSectionEnd : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600AD16 RID: 44310 RVA: 0x000FFDF2 File Offset: 0x000FDFF2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnQteSectionEnd.StaticFunctionPtr();
		}

		// Token: 0x0600AD17 RID: 44311 RVA: 0x000FFDFE File Offset: 0x000FDFFE
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnQteSectionEnd._FunctionPtr == IntPtr.Zero)
			{
				FOnQteSectionEnd._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SequenceDialogue.OnQteSectionEnd__DelegateSignature");
			}
			return FOnQteSectionEnd._FunctionPtr;
		}

		// Token: 0x0600AD18 RID: 44312 RVA: 0x000FFE21 File Offset: 0x000FE021
		public FOnQteSectionEnd()
		{
		}

		// Token: 0x0600AD19 RID: 44313 RVA: 0x000FFE29 File Offset: 0x000FE029
		[NullableContext(2)]
		public FOnQteSectionEnd(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AD1A RID: 44314 RVA: 0x000FFE33 File Offset: 0x000FE033
		public FOnQteSectionEnd(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AD1B RID: 44315 RVA: 0x000FFE3E File Offset: 0x000FE03E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600AD1C RID: 44316 RVA: 0x000FFE70 File Offset: 0x000FE070
		[NullableContext(1)]
		public void Add(Action<int> Callback)
		{
			if (FOnQteSectionEnd.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnQteSectionEnd.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnQteSectionEnd.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnQteSectionEnd.OnScriptCallback));
				}
				FOnQteSectionEnd.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnQteSectionEnd.RegisterId);
		}

		// Token: 0x0600AD1D RID: 44317 RVA: 0x000FFEAA File Offset: 0x000FE0AA
		[NullableContext(1)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600AD1E RID: 44318 RVA: 0x000FFEB4 File Offset: 0x000FE0B4
		[SkipLocalsInit]
		public unsafe void Broadcast(int QteId)
		{
			FOnQteSectionEnd.__FOnQteSectionEnd_DelegateParams* ptr = stackalloc FOnQteSectionEnd.__FOnQteSectionEnd_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnQteSectionEnd.__FOnQteSectionEnd_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnQteSectionEnd.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->QteId = QteId;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600AD1F RID: 44319 RVA: 0x000FFEF0 File Offset: 0x000FE0F0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnQteSectionEnd.__FOnQteSectionEnd_DelegateParams*)__Parameters)->QteId);
		}

		// Token: 0x04004A9D RID: 19101
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004A9E RID: 19102
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.OnQteSectionEnd__DelegateSignature";

		// Token: 0x04004A9F RID: 19103
		private static int RegisterId;

		// Token: 0x02000F85 RID: 3973
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FOnQteSectionEnd_DelegateParams
		{
			// Token: 0x0400637F RID: 25471
			[FieldOffset(0)]
			public int QteId;
		}

		// Token: 0x02000F86 RID: 3974
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006380 RID: 25472
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
