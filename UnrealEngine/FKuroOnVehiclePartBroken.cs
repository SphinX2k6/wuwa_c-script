using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B88 RID: 7048
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroOnVehiclePartBroken : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601ABF2 RID: 109554 RVA: 0x00276908 File Offset: 0x00274B08
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroOnVehiclePartBroken.StaticFunctionPtr();
		}

		// Token: 0x0601ABF3 RID: 109555 RVA: 0x00276914 File Offset: 0x00274B14
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroOnVehiclePartBroken._FunctionPtr == IntPtr.Zero)
			{
				FKuroOnVehiclePartBroken._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroOnVehiclePartBroken__DelegateSignature");
			}
			return FKuroOnVehiclePartBroken._FunctionPtr;
		}

		// Token: 0x0601ABF4 RID: 109556 RVA: 0x00276937 File Offset: 0x00274B37
		public FKuroOnVehiclePartBroken()
		{
		}

		// Token: 0x0601ABF5 RID: 109557 RVA: 0x0027693F File Offset: 0x00274B3F
		[NullableContext(2)]
		public FKuroOnVehiclePartBroken(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601ABF6 RID: 109558 RVA: 0x00276949 File Offset: 0x00274B49
		public FKuroOnVehiclePartBroken(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601ABF7 RID: 109559 RVA: 0x00276954 File Offset: 0x00274B54
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, string>) ?? ((Action<int, string>)Delegate.CreateDelegate(typeof(Action<int, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601ABF8 RID: 109560 RVA: 0x00276986 File Offset: 0x00274B86
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, string> Callback)
		{
			if (FKuroOnVehiclePartBroken.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroOnVehiclePartBroken.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroOnVehiclePartBroken.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroOnVehiclePartBroken.OnScriptCallback));
				}
				FKuroOnVehiclePartBroken.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroOnVehiclePartBroken.RegisterId);
		}

		// Token: 0x0601ABF9 RID: 109561 RVA: 0x002769C0 File Offset: 0x00274BC0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601ABFA RID: 109562 RVA: 0x002769CC File Offset: 0x00274BCC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int PartIndex, string PartName)
		{
			FKuroOnVehiclePartBroken.__FKuroOnVehiclePartBroken_DelegateParams* ptr = stackalloc FKuroOnVehiclePartBroken.__FKuroOnVehiclePartBroken_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FKuroOnVehiclePartBroken.__FKuroOnVehiclePartBroken_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroOnVehiclePartBroken.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->PartIndex = PartIndex;
			FString.CopyFrom((void*)(&ptr->PartName), PartName);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroOnVehiclePartBroken._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601ABFB RID: 109563 RVA: 0x00276A28 File Offset: 0x00274C28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, string> action = target as Action<int, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FKuroOnVehiclePartBroken.__FKuroOnVehiclePartBroken_DelegateParams*)__Parameters)->PartName));
			action(((FKuroOnVehiclePartBroken.__FKuroOnVehiclePartBroken_DelegateParams*)__Parameters)->PartIndex, arg);
		}

		// Token: 0x0400E785 RID: 59269
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400E786 RID: 59270
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroOnVehiclePartBroken__DelegateSignature";

		// Token: 0x0400E787 RID: 59271
		private static int RegisterId;

		// Token: 0x02003161 RID: 12641
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FKuroOnVehiclePartBroken_DelegateParams
		{
			// Token: 0x04016F88 RID: 94088
			[FieldOffset(0)]
			public int PartIndex;

			// Token: 0x04016F89 RID: 94089
			[FieldOffset(8)]
			public FString PartName;
		}

		// Token: 0x02003162 RID: 12642
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016F8A RID: 94090
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
