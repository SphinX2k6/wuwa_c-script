using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200031F RID: 799
	public sealed class FKuroBuildingGridIntersectingCellDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005428 RID: 21544 RVA: 0x00075B84 File Offset: 0x00073D84
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroBuildingGridIntersectingCellDelegate.StaticFunctionPtr();
		}

		// Token: 0x06005429 RID: 21545 RVA: 0x00075B90 File Offset: 0x00073D90
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroBuildingGridIntersectingCellDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroBuildingGridIntersectingCellDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroBuildingGridSystem.KuroBuildingGridIntersectingCellDelegate__DelegateSignature");
			}
			return FKuroBuildingGridIntersectingCellDelegate._FunctionPtr;
		}

		// Token: 0x0600542A RID: 21546 RVA: 0x00075BB3 File Offset: 0x00073DB3
		public FKuroBuildingGridIntersectingCellDelegate()
		{
		}

		// Token: 0x0600542B RID: 21547 RVA: 0x00075BBB File Offset: 0x00073DBB
		[NullableContext(2)]
		public FKuroBuildingGridIntersectingCellDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600542C RID: 21548 RVA: 0x00075BC5 File Offset: 0x00073DC5
		public FKuroBuildingGridIntersectingCellDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600542D RID: 21549 RVA: 0x00075BD0 File Offset: 0x00073DD0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string, FKuroBuildingGridCellVector, int>) ?? ((Action<string, FKuroBuildingGridCellVector, int>)Delegate.CreateDelegate(typeof(Action<string, FKuroBuildingGridCellVector, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600542E RID: 21550 RVA: 0x00075C02 File Offset: 0x00073E02
		[NullableContext(1)]
		public void Bind(Action<string, FKuroBuildingGridCellVector, int> Callback)
		{
			if (FKuroBuildingGridIntersectingCellDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroBuildingGridIntersectingCellDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroBuildingGridIntersectingCellDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroBuildingGridIntersectingCellDelegate.OnScriptCallback));
				}
				FKuroBuildingGridIntersectingCellDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroBuildingGridIntersectingCellDelegate.RegisterId);
		}

		// Token: 0x0600542F RID: 21551 RVA: 0x00075C3C File Offset: 0x00073E3C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string GridGuid, in FKuroBuildingGridCellVector Coords, int CellIndex)
		{
			FKuroBuildingGridIntersectingCellDelegate.__FKuroBuildingGridIntersectingCellDelegate_DelegateParams* ptr = stackalloc FKuroBuildingGridIntersectingCellDelegate.__FKuroBuildingGridIntersectingCellDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FKuroBuildingGridIntersectingCellDelegate.__FKuroBuildingGridIntersectingCellDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroBuildingGridIntersectingCellDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->GridGuid), GridGuid);
			ptr->Coords = Coords;
			ptr->CellIndex = CellIndex;
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroBuildingGridIntersectingCellDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06005430 RID: 21552 RVA: 0x00075CA4 File Offset: 0x00073EA4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, FKuroBuildingGridCellVector, int> action = target as Action<string, FKuroBuildingGridCellVector, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FKuroBuildingGridIntersectingCellDelegate.__FKuroBuildingGridIntersectingCellDelegate_DelegateParams*)__Parameters)->GridGuid));
			action(arg, ((FKuroBuildingGridIntersectingCellDelegate.__FKuroBuildingGridIntersectingCellDelegate_DelegateParams*)__Parameters)->Coords, ((FKuroBuildingGridIntersectingCellDelegate.__FKuroBuildingGridIntersectingCellDelegate_DelegateParams*)__Parameters)->CellIndex);
		}

		// Token: 0x0400225F RID: 8799
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002260 RID: 8800
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBuildingGridSystem.KuroBuildingGridIntersectingCellDelegate__DelegateSignature";

		// Token: 0x04002261 RID: 8801
		private static int RegisterId;

		// Token: 0x02000A20 RID: 2592
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FKuroBuildingGridIntersectingCellDelegate_DelegateParams
		{
			// Token: 0x040059E3 RID: 23011
			[FieldOffset(0)]
			public FString GridGuid;

			// Token: 0x040059E4 RID: 23012
			[FieldOffset(16)]
			public FKuroBuildingGridCellVector Coords;

			// Token: 0x040059E5 RID: 23013
			[FieldOffset(24)]
			public int CellIndex;
		}

		// Token: 0x02000A21 RID: 2593
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040059E6 RID: 23014
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
