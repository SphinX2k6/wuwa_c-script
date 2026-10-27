using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019E6 RID: 6630
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroMovement.KuroMoveTriggerController")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class AKuroMoveTriggerController : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018995 RID: 100757 RVA: 0x00243DED File Offset: 0x00241FED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroMoveTriggerController._ClassPtr;
		}

		// Token: 0x06018996 RID: 100758 RVA: 0x00243DFC File Offset: 0x00241FFC
		public AKuroMoveTriggerController() : this(BuiltinUtils.AllocNativeUObject(AKuroMoveTriggerController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018997 RID: 100759 RVA: 0x00243E24 File Offset: 0x00242024
		public AKuroMoveTriggerController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroMoveTriggerController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061F3 RID: 25075
		// (get) Token: 0x06018998 RID: 100760 RVA: 0x00243E58 File Offset: 0x00242058
		// (set) Token: 0x06018999 RID: 100761 RVA: 0x00243E91 File Offset: 0x00242091
		public FOnKuroMovementTrigger Callback
		{
			get
			{
				base.FastCheckIsValid();
				FOnKuroMovementTrigger result;
				if ((result = this._Callback) == null)
				{
					result = (this._Callback = new FOnKuroMovementTrigger(base.NativePtr + (IntPtr)AKuroMoveTriggerController.__PropertyOffset_Callback, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AKuroMoveTriggerController.__PropertyOffset_Callback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170061F4 RID: 25076
		// (get) Token: 0x0601899A RID: 100762 RVA: 0x00243EB4 File Offset: 0x002420B4
		// (set) Token: 0x0601899B RID: 100763 RVA: 0x00243EED File Offset: 0x002420ED
		public TArray<FOverlapActorRecord> Records
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FOverlapActorRecord> result;
				if ((result = this._Records) == null)
				{
					result = (this._Records = new TArray<FOverlapActorRecord>(base.NativePtr + (IntPtr)AKuroMoveTriggerController.__PropertyOffset_Records, this));
				}
				return result;
			}
			set
			{
				this.Records.CopyAssign(value);
			}
		}

		// Token: 0x0601899C RID: 100764 RVA: 0x00243EFB File Offset: 0x002420FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void UnRegisterController()
		{
			UnrealReflectionUtils.CallUFunction(AKuroMoveTriggerController._ClassDefaultObjectPtr, AKuroMoveTriggerController.__UnRegisterController_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601899D RID: 100765 RVA: 0x00243F10 File Offset: 0x00242110
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RegisterController(AKuroMoveTriggerController ControllerPtr)
		{
			AKuroMoveTriggerController.__RegisterController_FunctionParams* ptr = stackalloc AKuroMoveTriggerController.__RegisterController_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(AKuroMoveTriggerController.__RegisterController_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AKuroMoveTriggerController.__RegisterController_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ControllerPtr = ((ControllerPtr != null) ? ControllerPtr.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(AKuroMoveTriggerController._ClassDefaultObjectPtr, AKuroMoveTriggerController.__RegisterController_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601899E RID: 100766 RVA: 0x00243F65 File Offset: 0x00242165
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void InitAllTriggers()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroMoveTriggerController.__InitAllTriggers_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601899F RID: 100767 RVA: 0x00243F7A File Offset: 0x0024217A
		static AKuroMoveTriggerController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMovement.KuroMoveTriggerController");
		}

		// Token: 0x060189A0 RID: 100768 RVA: 0x00243F88 File Offset: 0x00242188
		protected AKuroMoveTriggerController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D4BD RID: 54461
		public new const string __ObjectPath = "/Script/KuroMovement.KuroMoveTriggerController";

		// Token: 0x0400D4BE RID: 54462
		private static IntPtr _ClassPtr;

		// Token: 0x0400D4BF RID: 54463
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D4C0 RID: 54464
		internal static int __PropertyOffset_Callback;

		// Token: 0x0400D4C1 RID: 54465
		[Nullable(2)]
		private FOnKuroMovementTrigger _Callback;

		// Token: 0x0400D4C2 RID: 54466
		internal static int __PropertyOffset_Records;

		// Token: 0x0400D4C3 RID: 54467
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FOverlapActorRecord> _Records;

		// Token: 0x0400D4C4 RID: 54468
		private static IntPtr __UnRegisterController_NativeFunctionPtr;

		// Token: 0x0400D4C5 RID: 54469
		private static IntPtr __RegisterController_NativeFunctionPtr;

		// Token: 0x0400D4C6 RID: 54470
		private static IntPtr __InitAllTriggers_NativeFunctionPtr;

		// Token: 0x02003095 RID: 12437
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __RegisterController_FunctionParams
		{
			// Token: 0x04016DBB RID: 93627
			[FieldOffset(0)]
			public IntPtr ControllerPtr;
		}
	}
}
