using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007DA RID: 2010
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnJumpToKeyFrameEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600AD02 RID: 44290 RVA: 0x000FFB60 File Offset: 0x000FDD60
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnJumpToKeyFrameEvent.StaticFunctionPtr();
		}

		// Token: 0x0600AD03 RID: 44291 RVA: 0x000FFB6C File Offset: 0x000FDD6C
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnJumpToKeyFrameEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnJumpToKeyFrameEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SequenceDialogue.OnJumpToKeyFrameEvent__DelegateSignature");
			}
			return FOnJumpToKeyFrameEvent._FunctionPtr;
		}

		// Token: 0x0600AD04 RID: 44292 RVA: 0x000FFB8F File Offset: 0x000FDD8F
		public FOnJumpToKeyFrameEvent()
		{
		}

		// Token: 0x0600AD05 RID: 44293 RVA: 0x000FFB97 File Offset: 0x000FDD97
		[NullableContext(2)]
		public FOnJumpToKeyFrameEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AD06 RID: 44294 RVA: 0x000FFBA1 File Offset: 0x000FDDA1
		public FOnJumpToKeyFrameEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AD07 RID: 44295 RVA: 0x000FFBAC File Offset: 0x000FDDAC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600AD08 RID: 44296 RVA: 0x000FFBDE File Offset: 0x000FDDDE
		[NullableContext(1)]
		public void Add(Action<int> Callback)
		{
			if (FOnJumpToKeyFrameEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnJumpToKeyFrameEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnJumpToKeyFrameEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnJumpToKeyFrameEvent.OnScriptCallback));
				}
				FOnJumpToKeyFrameEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnJumpToKeyFrameEvent.RegisterId);
		}

		// Token: 0x0600AD09 RID: 44297 RVA: 0x000FFC18 File Offset: 0x000FDE18
		[NullableContext(1)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600AD0A RID: 44298 RVA: 0x000FFC24 File Offset: 0x000FDE24
		[SkipLocalsInit]
		public unsafe void Broadcast(int Frame)
		{
			FOnJumpToKeyFrameEvent.__FOnJumpToKeyFrameEvent_DelegateParams* ptr = stackalloc FOnJumpToKeyFrameEvent.__FOnJumpToKeyFrameEvent_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnJumpToKeyFrameEvent.__FOnJumpToKeyFrameEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnJumpToKeyFrameEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Frame = Frame;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600AD0B RID: 44299 RVA: 0x000FFC60 File Offset: 0x000FDE60
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnJumpToKeyFrameEvent.__FOnJumpToKeyFrameEvent_DelegateParams*)__Parameters)->Frame);
		}

		// Token: 0x04004A97 RID: 19095
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004A98 RID: 19096
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.OnJumpToKeyFrameEvent__DelegateSignature";

		// Token: 0x04004A99 RID: 19097
		private static int RegisterId;

		// Token: 0x02000F81 RID: 3969
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FOnJumpToKeyFrameEvent_DelegateParams
		{
			// Token: 0x0400637B RID: 25467
			[FieldOffset(0)]
			public int Frame;
		}

		// Token: 0x02000F82 RID: 3970
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400637C RID: 25468
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
