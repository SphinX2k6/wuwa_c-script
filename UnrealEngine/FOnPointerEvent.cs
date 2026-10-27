using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029B6 RID: 10678
	public sealed class FOnPointerEvent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060277A6 RID: 161702 RVA: 0x003C3D56 File Offset: 0x003C1F56
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnPointerEvent.StaticFunctionPtr();
		}

		// Token: 0x060277A7 RID: 161703 RVA: 0x003C3D62 File Offset: 0x003C1F62
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidget.__OnPointerEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidget.__OnPointerEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.Widget:OnPointerEvent__DelegateSignature");
			}
			return UWidget.__OnPointerEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060277A8 RID: 161704 RVA: 0x003C3D85 File Offset: 0x003C1F85
		public FOnPointerEvent()
		{
		}

		// Token: 0x060277A9 RID: 161705 RVA: 0x003C3D8D File Offset: 0x003C1F8D
		[NullableContext(2)]
		public FOnPointerEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060277AA RID: 161706 RVA: 0x003C3D97 File Offset: 0x003C1F97
		public FOnPointerEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060277AB RID: 161707 RVA: 0x003C3DA2 File Offset: 0x003C1FA2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<FGeometry, FPointerEvent, FEventReply>) ?? ((Func<FGeometry, FPointerEvent, FEventReply>)Delegate.CreateDelegate(typeof(Func<FGeometry, FPointerEvent, FEventReply>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060277AC RID: 161708 RVA: 0x003C3DD4 File Offset: 0x003C1FD4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Func<FGeometry, FPointerEvent, FEventReply> Callback)
		{
			if (FOnPointerEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnPointerEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnPointerEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnPointerEvent.OnScriptCallback));
				}
				FOnPointerEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnPointerEvent.RegisterId);
		}

		// Token: 0x060277AD RID: 161709 RVA: 0x003C3E10 File Offset: 0x003C2010
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(1)]
		public unsafe FEventReply Execute(FGeometry MyGeometry, in FPointerEvent MouseEvent)
		{
			FOnPointerEvent.__FOnPointerEvent_DelegateParams* ptr = stackalloc FOnPointerEvent.__FOnPointerEvent_DelegateParams[(UIntPtr)383] + 15L / (long)sizeof(FOnPointerEvent.__FOnPointerEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnPointerEvent.StaticFunctionPtr(), (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			if (MouseEvent != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPointerEvent.StaticStruct(), &ptr->MouseEvent, MouseEvent.NativePtr, 1, false);
			}
			base.ExecuteInternal((void*)ptr);
			FEventReply result = new FEventReply(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UWidget.__OnPointerEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060277AE RID: 161710 RVA: 0x003C3EB0 File Offset: 0x003C20B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<FGeometry, FPointerEvent, FEventReply> func = target as Func<FGeometry, FPointerEvent, FEventReply>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FGeometry arg = new FGeometry(&((FOnPointerEvent.__FOnPointerEvent_DelegateParams*)__Parameters)->MyGeometry, true, true);
			FPointerEvent fpointerEvent = new FPointerEvent(&((FOnPointerEvent.__FOnPointerEvent_DelegateParams*)__Parameters)->MouseEvent, true, true);
			FEventReply feventReply = func(arg, fpointerEvent);
			if (fpointerEvent != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPointerEvent.StaticStruct(), &((FOnPointerEvent.__FOnPointerEvent_DelegateParams*)__Parameters)->MouseEvent, fpointerEvent.NativePtr, 1, false);
			}
			if (feventReply != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FEventReply.StaticStruct(), &((FOnPointerEvent.__FOnPointerEvent_DelegateParams*)__Parameters)->__Result, feventReply.NativePtr, 1, false);
			}
		}

		// Token: 0x04015A7B RID: 88699
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.Widget:OnPointerEvent__DelegateSignature";

		// Token: 0x04015A7C RID: 88700
		private static int RegisterId;

		// Token: 0x02003BC0 RID: 15296
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 368)]
		protected ref struct __FOnPointerEvent_DelegateParams
		{
			// Token: 0x04017DA5 RID: 97701
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DA6 RID: 97702
			[FieldOffset(56)]
			public byte MouseEvent;

			// Token: 0x04017DA7 RID: 97703
			[FieldOffset(176)]
			public byte __Result;
		}

		// Token: 0x02003BC1 RID: 15297
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017DA8 RID: 97704
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
