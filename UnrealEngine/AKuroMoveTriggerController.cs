using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000473 RID: 1139
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroMovement.KuroMoveTriggerController")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class AKuroMoveTriggerController : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006C47 RID: 27719 RVA: 0x0009DBA2 File Offset: 0x0009BDA2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroMoveTriggerController._ClassPtr;
		}

		// Token: 0x06006C48 RID: 27720 RVA: 0x0009DBB0 File Offset: 0x0009BDB0
		public AKuroMoveTriggerController() : this(BuiltinUtils.AllocNativeUObject(AKuroMoveTriggerController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006C49 RID: 27721 RVA: 0x0009DBD8 File Offset: 0x0009BDD8
		public AKuroMoveTriggerController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroMoveTriggerController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x06006C4A RID: 27722 RVA: 0x0009DC0C File Offset: 0x0009BE0C
		// (set) Token: 0x06006C4B RID: 27723 RVA: 0x0009DC45 File Offset: 0x0009BE45
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

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x06006C4C RID: 27724 RVA: 0x0009DC68 File Offset: 0x0009BE68
		// (set) Token: 0x06006C4D RID: 27725 RVA: 0x0009DCA1 File Offset: 0x0009BEA1
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

		// Token: 0x06006C4E RID: 27726 RVA: 0x0009DCAF File Offset: 0x0009BEAF
		[SkipLocalsInit]
		public static void UnRegisterController()
		{
			UnrealReflectionUtils.CallUFunction(AKuroMoveTriggerController._ClassDefaultObjectPtr, AKuroMoveTriggerController.__UnRegisterController_NativeFunctionPtr, null);
		}

		// Token: 0x06006C4F RID: 27727 RVA: 0x0009DCC4 File Offset: 0x0009BEC4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void RegisterController(AKuroMoveTriggerController ControllerPtr)
		{
			AKuroMoveTriggerController.__RegisterController_FunctionParams* ptr = stackalloc AKuroMoveTriggerController.__RegisterController_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(AKuroMoveTriggerController.__RegisterController_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AKuroMoveTriggerController.__RegisterController_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ControllerPtr = ((ControllerPtr != null) ? ControllerPtr.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(AKuroMoveTriggerController._ClassDefaultObjectPtr, AKuroMoveTriggerController.__RegisterController_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06006C50 RID: 27728 RVA: 0x0009DD18 File Offset: 0x0009BF18
		[SkipLocalsInit]
		public void InitAllTriggers()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroMoveTriggerController.__InitAllTriggers_NativeFunctionPtr, null);
		}

		// Token: 0x06006C51 RID: 27729 RVA: 0x0009DD2C File Offset: 0x0009BF2C
		static AKuroMoveTriggerController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMovement.KuroMoveTriggerController");
		}

		// Token: 0x06006C52 RID: 27730 RVA: 0x0009DD3A File Offset: 0x0009BF3A
		protected AKuroMoveTriggerController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002E3C RID: 11836
		public new const string __ObjectPath = "/Script/KuroMovement.KuroMoveTriggerController";

		// Token: 0x04002E3D RID: 11837
		private static IntPtr _ClassPtr;

		// Token: 0x04002E3E RID: 11838
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002E3F RID: 11839
		internal static int __PropertyOffset_Callback;

		// Token: 0x04002E40 RID: 11840
		[Nullable(2)]
		private FOnKuroMovementTrigger _Callback;

		// Token: 0x04002E41 RID: 11841
		internal static int __PropertyOffset_Records;

		// Token: 0x04002E42 RID: 11842
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FOverlapActorRecord> _Records;

		// Token: 0x04002E43 RID: 11843
		private static IntPtr __UnRegisterController_NativeFunctionPtr;

		// Token: 0x04002E44 RID: 11844
		private static IntPtr __RegisterController_NativeFunctionPtr;

		// Token: 0x04002E45 RID: 11845
		private static IntPtr __InitAllTriggers_NativeFunctionPtr;

		// Token: 0x02000B77 RID: 2935
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __RegisterController_FunctionParams
		{
			// Token: 0x04005CCF RID: 23759
			[FieldOffset(0)]
			public IntPtr ControllerPtr;
		}
	}
}
