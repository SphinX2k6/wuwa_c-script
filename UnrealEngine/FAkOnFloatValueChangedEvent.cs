using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200022E RID: 558
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FAkOnFloatValueChangedEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060020B7 RID: 8375 RVA: 0x000309CE File Offset: 0x0002EBCE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAkOnFloatValueChangedEvent.StaticFunctionPtr();
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x000309DA File Offset: 0x0002EBDA
		private static IntPtr StaticFunctionPtr()
		{
			if (FAkOnFloatValueChangedEvent._FunctionPtr == IntPtr.Zero)
			{
				FAkOnFloatValueChangedEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.AkOnFloatValueChangedEvent__DelegateSignature");
			}
			return FAkOnFloatValueChangedEvent._FunctionPtr;
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x000309FD File Offset: 0x0002EBFD
		public FAkOnFloatValueChangedEvent()
		{
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x00030A05 File Offset: 0x0002EC05
		[NullableContext(2)]
		public FAkOnFloatValueChangedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x00030A0F File Offset: 0x0002EC0F
		public FAkOnFloatValueChangedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x00030A1A File Offset: 0x0002EC1A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x00030A4C File Offset: 0x0002EC4C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<float> Callback)
		{
			if (FAkOnFloatValueChangedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAkOnFloatValueChangedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAkOnFloatValueChangedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAkOnFloatValueChangedEvent.OnScriptCallback));
				}
				FAkOnFloatValueChangedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FAkOnFloatValueChangedEvent.RegisterId);
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x00030A86 File Offset: 0x0002EC86
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x00030A90 File Offset: 0x0002EC90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float Value)
		{
			FAkOnFloatValueChangedEvent.__FAkOnFloatValueChangedEvent_DelegateParams* ptr = stackalloc FAkOnFloatValueChangedEvent.__FAkOnFloatValueChangedEvent_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FAkOnFloatValueChangedEvent.__FAkOnFloatValueChangedEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAkOnFloatValueChangedEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Value = Value;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x00030ACC File Offset: 0x0002ECCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FAkOnFloatValueChangedEvent.__FAkOnFloatValueChangedEvent_DelegateParams*)__Parameters)->Value);
		}

		// Token: 0x04000B01 RID: 2817
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000B02 RID: 2818
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.AkOnFloatValueChangedEvent__DelegateSignature";

		// Token: 0x04000B03 RID: 2819
		private static int RegisterId;

		// Token: 0x02002B89 RID: 11145
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FAkOnFloatValueChangedEvent_DelegateParams
		{
			// Token: 0x0401641C RID: 91164
			[FieldOffset(0)]
			public float Value;
		}

		// Token: 0x02002B8A RID: 11146
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401641D RID: 91165
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
