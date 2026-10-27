using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200136B RID: 4971
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayCueManager")]
	[UnrealStructLayout(872, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 872)]
	public class UGameplayCueManager : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060123A2 RID: 74658 RVA: 0x001AC169 File Offset: 0x001AA369
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayCueManager._ClassPtr;
		}

		// Token: 0x060123A3 RID: 74659 RVA: 0x001AC178 File Offset: 0x001AA378
		public UGameplayCueManager() : this(BuiltinUtils.AllocNativeUObject(UGameplayCueManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060123A4 RID: 74660 RVA: 0x001AC1A0 File Offset: 0x001AA3A0
		public UGameplayCueManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayCueManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170046FB RID: 18171
		// (get) Token: 0x060123A5 RID: 74661 RVA: 0x001AC1D4 File Offset: 0x001AA3D4
		// (set) Token: 0x060123A6 RID: 74662 RVA: 0x001AC20D File Offset: 0x001AA40D
		public FGameplayCueObjectLibrary RuntimeGameplayCueObjectLibrary
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayCueObjectLibrary result;
				if ((result = this._RuntimeGameplayCueObjectLibrary) == null)
				{
					result = (this._RuntimeGameplayCueObjectLibrary = new FGameplayCueObjectLibrary(base.NativePtr + (IntPtr)UGameplayCueManager.__PropertyOffset_RuntimeGameplayCueObjectLibrary, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayCueObjectLibrary.StaticStruct(), base.NativePtr + (IntPtr)UGameplayCueManager.__PropertyOffset_RuntimeGameplayCueObjectLibrary, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170046FC RID: 18172
		// (get) Token: 0x060123A7 RID: 74663 RVA: 0x001AC230 File Offset: 0x001AA430
		// (set) Token: 0x060123A8 RID: 74664 RVA: 0x001AC269 File Offset: 0x001AA469
		public FGameplayCueObjectLibrary EditorGameplayCueObjectLibrary
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayCueObjectLibrary result;
				if ((result = this._EditorGameplayCueObjectLibrary) == null)
				{
					result = (this._EditorGameplayCueObjectLibrary = new FGameplayCueObjectLibrary(base.NativePtr + (IntPtr)UGameplayCueManager.__PropertyOffset_EditorGameplayCueObjectLibrary, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayCueObjectLibrary.StaticStruct(), base.NativePtr + (IntPtr)UGameplayCueManager.__PropertyOffset_EditorGameplayCueObjectLibrary, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170046FD RID: 18173
		// (get) Token: 0x060123A9 RID: 74665 RVA: 0x001AC28C File Offset: 0x001AA48C
		// (set) Token: 0x060123AA RID: 74666 RVA: 0x001AC2C5 File Offset: 0x001AA4C5
		public TArray<UClass> LoadedGameplayCueNotifyClasses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UClass> result;
				if ((result = this._LoadedGameplayCueNotifyClasses) == null)
				{
					result = (this._LoadedGameplayCueNotifyClasses = new TArray<UClass>(base.NativePtr + (IntPtr)UGameplayCueManager.__PropertyOffset_LoadedGameplayCueNotifyClasses, this));
				}
				return result;
			}
			set
			{
				this.LoadedGameplayCueNotifyClasses.CopyAssign(value);
			}
		}

		// Token: 0x170046FE RID: 18174
		// (get) Token: 0x060123AB RID: 74667 RVA: 0x001AC2D4 File Offset: 0x001AA4D4
		// (set) Token: 0x060123AC RID: 74668 RVA: 0x001AC30D File Offset: 0x001AA50D
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TSubclassOf<AGameplayCueNotify_Actor>> GameplayCueClassesForPreallocation
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TSubclassOf<AGameplayCueNotify_Actor>> result;
				if ((result = this._GameplayCueClassesForPreallocation) == null)
				{
					result = (this._GameplayCueClassesForPreallocation = new TArray<TSubclassOf<AGameplayCueNotify_Actor>>(base.NativePtr + (IntPtr)UGameplayCueManager.__PropertyOffset_GameplayCueClassesForPreallocation, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.GameplayCueClassesForPreallocation.CopyAssign(value);
			}
		}

		// Token: 0x170046FF RID: 18175
		// (get) Token: 0x060123AD RID: 74669 RVA: 0x001AC31C File Offset: 0x001AA51C
		// (set) Token: 0x060123AE RID: 74670 RVA: 0x001AC355 File Offset: 0x001AA555
		public TArray<FGameplayCuePendingExecute> PendingExecuteCues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayCuePendingExecute> result;
				if ((result = this._PendingExecuteCues) == null)
				{
					result = (this._PendingExecuteCues = new TArray<FGameplayCuePendingExecute>(base.NativePtr + (IntPtr)UGameplayCueManager.__PropertyOffset_PendingExecuteCues, this));
				}
				return result;
			}
			set
			{
				this.PendingExecuteCues.CopyAssign(value);
			}
		}

		// Token: 0x17004700 RID: 18176
		// (get) Token: 0x060123AF RID: 74671 RVA: 0x001AC363 File Offset: 0x001AA563
		// (set) Token: 0x060123B0 RID: 74672 RVA: 0x001AC373 File Offset: 0x001AA573
		public unsafe int GameplayCueSendContextCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayCueManager.__PropertyOffset_GameplayCueSendContextCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayCueManager.__PropertyOffset_GameplayCueSendContextCount) = value;
			}
		}

		// Token: 0x17004701 RID: 18177
		// (get) Token: 0x060123B1 RID: 74673 RVA: 0x001AC384 File Offset: 0x001AA584
		// (set) Token: 0x060123B2 RID: 74674 RVA: 0x001AC3BD File Offset: 0x001AA5BD
		public TArray<FPreallocationInfo> PreallocationInfoList_Internal
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPreallocationInfo> result;
				if ((result = this._PreallocationInfoList_Internal) == null)
				{
					result = (this._PreallocationInfoList_Internal = new TArray<FPreallocationInfo>(base.NativePtr + (IntPtr)UGameplayCueManager.__PropertyOffset_PreallocationInfoList_Internal, this));
				}
				return result;
			}
			set
			{
				this.PreallocationInfoList_Internal.CopyAssign(value);
			}
		}

		// Token: 0x060123B3 RID: 74675 RVA: 0x001AC3CB File Offset: 0x001AA5CB
		static UGameplayCueManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayCueManager");
		}

		// Token: 0x060123B4 RID: 74676 RVA: 0x001AC3D9 File Offset: 0x001AA5D9
		protected UGameplayCueManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009C2C RID: 39980
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayCueManager";

		// Token: 0x04009C2D RID: 39981
		private static IntPtr _ClassPtr;

		// Token: 0x04009C2E RID: 39982
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009C2F RID: 39983
		internal static int __PropertyOffset_RuntimeGameplayCueObjectLibrary;

		// Token: 0x04009C30 RID: 39984
		[Nullable(2)]
		private FGameplayCueObjectLibrary _RuntimeGameplayCueObjectLibrary;

		// Token: 0x04009C31 RID: 39985
		internal static int __PropertyOffset_EditorGameplayCueObjectLibrary;

		// Token: 0x04009C32 RID: 39986
		[Nullable(2)]
		private FGameplayCueObjectLibrary _EditorGameplayCueObjectLibrary;

		// Token: 0x04009C33 RID: 39987
		internal static int __PropertyOffset_LoadedGameplayCueNotifyClasses;

		// Token: 0x04009C34 RID: 39988
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UClass> _LoadedGameplayCueNotifyClasses;

		// Token: 0x04009C35 RID: 39989
		internal static int __PropertyOffset_GameplayCueClassesForPreallocation;

		// Token: 0x04009C36 RID: 39990
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<AGameplayCueNotify_Actor>> _GameplayCueClassesForPreallocation;

		// Token: 0x04009C37 RID: 39991
		internal static int __PropertyOffset_PendingExecuteCues;

		// Token: 0x04009C38 RID: 39992
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayCuePendingExecute> _PendingExecuteCues;

		// Token: 0x04009C39 RID: 39993
		internal static int __PropertyOffset_GameplayCueSendContextCount;

		// Token: 0x04009C3A RID: 39994
		internal static int __PropertyOffset_PreallocationInfoList_Internal;

		// Token: 0x04009C3B RID: 39995
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPreallocationInfo> _PreallocationInfoList_Internal;
	}
}
