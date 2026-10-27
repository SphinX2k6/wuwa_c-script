using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016F5 RID: 5877
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletDataLogic")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKuroBulletDataLogic : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015399 RID: 86937 RVA: 0x001F328A File Offset: 0x001F148A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBulletDataLogic._ScriptStructPtr != 0) ? FKuroBulletDataLogic._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.KuroBulletDataLogic", ref FKuroBulletDataLogic._ScriptStructPtr);
		}

		// Token: 0x170053EF RID: 21487
		// (get) Token: 0x0601539A RID: 86938 RVA: 0x001F32AE File Offset: 0x001F14AE
		// (set) Token: 0x0601539B RID: 86939 RVA: 0x001F32BE File Offset: 0x001F14BE
		public unsafe bool DestroyOnHitCharacter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataLogic.__PropertyOffset_DestroyOnHitCharacter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataLogic.__PropertyOffset_DestroyOnHitCharacter) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053F0 RID: 21488
		// (get) Token: 0x0601539C RID: 86940 RVA: 0x001F32CF File Offset: 0x001F14CF
		// (set) Token: 0x0601539D RID: 86941 RVA: 0x001F32DF File Offset: 0x001F14DF
		public unsafe bool DestroyOnHitObstacle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataLogic.__PropertyOffset_DestroyOnHitObstacle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataLogic.__PropertyOffset_DestroyOnHitObstacle) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053F1 RID: 21489
		// (get) Token: 0x0601539E RID: 86942 RVA: 0x001F32F0 File Offset: 0x001F14F0
		// (set) Token: 0x0601539F RID: 86943 RVA: 0x001F3333 File Offset: 0x001F1533
		public TArray<long> BuffIdToAttacker
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._BuffIdToAttacker) == null)
				{
					result = (this._BuffIdToAttacker = new TArray<long>(base.NativePtr + (IntPtr)FKuroBulletDataLogic.__PropertyOffset_BuffIdToAttacker, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BuffIdToAttacker.CopyAssign(value);
			}
		}

		// Token: 0x170053F2 RID: 21490
		// (get) Token: 0x060153A0 RID: 86944 RVA: 0x001F3344 File Offset: 0x001F1544
		// (set) Token: 0x060153A1 RID: 86945 RVA: 0x001F3387 File Offset: 0x001F1587
		public TArray<long> BuffIdToVictim
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._BuffIdToVictim) == null)
				{
					result = (this._BuffIdToVictim = new TArray<long>(base.NativePtr + (IntPtr)FKuroBulletDataLogic.__PropertyOffset_BuffIdToVictim, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BuffIdToVictim.CopyAssign(value);
			}
		}

		// Token: 0x170053F3 RID: 21491
		// (get) Token: 0x060153A2 RID: 86946 RVA: 0x001F3395 File Offset: 0x001F1595
		// (set) Token: 0x060153A3 RID: 86947 RVA: 0x001F33A5 File Offset: 0x001F15A5
		public unsafe bool CanDodge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataLogic.__PropertyOffset_CanDodge) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataLogic.__PropertyOffset_CanDodge) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053F4 RID: 21492
		// (get) Token: 0x060153A4 RID: 86948 RVA: 0x001F33B6 File Offset: 0x001F15B6
		// (set) Token: 0x060153A5 RID: 86949 RVA: 0x001F33CA File Offset: 0x001F15CA
		[Nullable(2)]
		public unsafe UKuroBulletBpDataAssetGroup Data
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroBulletBpDataAssetGroup>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroBulletDataLogic.__PropertyOffset_Data);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroBulletDataLogic.__PropertyOffset_Data, value);
			}
		}

		// Token: 0x170053F5 RID: 21493
		// (get) Token: 0x060153A6 RID: 86950 RVA: 0x001F33E0 File Offset: 0x001F15E0
		// (set) Token: 0x060153A7 RID: 86951 RVA: 0x001F3423 File Offset: 0x001F1623
		public TArray<long> RangeBuffIdToVictim
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._RangeBuffIdToVictim) == null)
				{
					result = (this._RangeBuffIdToVictim = new TArray<long>(base.NativePtr + (IntPtr)FKuroBulletDataLogic.__PropertyOffset_RangeBuffIdToVictim, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RangeBuffIdToVictim.CopyAssign(value);
			}
		}

		// Token: 0x060153A8 RID: 86952 RVA: 0x001F3431 File Offset: 0x001F1631
		public FKuroBulletDataLogic()
		{
		}

		// Token: 0x060153A9 RID: 86953 RVA: 0x001F3439 File Offset: 0x001F1639
		public FKuroBulletDataLogic(bool DestroyOnHitCharacter, bool DestroyOnHitObstacle, TArray<long> BuffIdToAttacker, TArray<long> BuffIdToVictim, bool CanDodge, UKuroBulletBpDataAssetGroup Data, TArray<long> RangeBuffIdToVictim)
		{
			this.DestroyOnHitCharacter = DestroyOnHitCharacter;
			this.DestroyOnHitObstacle = DestroyOnHitObstacle;
			this.BuffIdToAttacker = BuffIdToAttacker;
			this.BuffIdToVictim = BuffIdToVictim;
			this.CanDodge = CanDodge;
			this.Data = Data;
			this.RangeBuffIdToVictim = RangeBuffIdToVictim;
		}

		// Token: 0x060153AA RID: 86954 RVA: 0x001F3476 File Offset: 0x001F1676
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBulletDataLogic.StaticStruct();
		}

		// Token: 0x060153AB RID: 86955 RVA: 0x001F3482 File Offset: 0x001F1682
		[NullableContext(2)]
		public FKuroBulletDataLogic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060153AC RID: 86956 RVA: 0x001F348C File Offset: 0x001F168C
		public FKuroBulletDataLogic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060153AD RID: 86957 RVA: 0x001F3497 File Offset: 0x001F1697
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBulletDataLogic(Pointer, false, true);
		}

		// Token: 0x060153AE RID: 86958 RVA: 0x001F34A1 File Offset: 0x001F16A1
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBulletDataLogic(Pointer, MemoryOwner);
		}

		// Token: 0x0400B92F RID: 47407
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletDataLogic";

		// Token: 0x0400B930 RID: 47408
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B931 RID: 47409
		internal static int __PropertyOffset_DestroyOnHitCharacter;

		// Token: 0x0400B932 RID: 47410
		internal static int __PropertyOffset_DestroyOnHitObstacle;

		// Token: 0x0400B933 RID: 47411
		internal static int __PropertyOffset_BuffIdToAttacker;

		// Token: 0x0400B934 RID: 47412
		[Nullable(2)]
		private TArray<long> _BuffIdToAttacker;

		// Token: 0x0400B935 RID: 47413
		internal static int __PropertyOffset_BuffIdToVictim;

		// Token: 0x0400B936 RID: 47414
		[Nullable(2)]
		private TArray<long> _BuffIdToVictim;

		// Token: 0x0400B937 RID: 47415
		internal static int __PropertyOffset_CanDodge;

		// Token: 0x0400B938 RID: 47416
		internal static int __PropertyOffset_Data;

		// Token: 0x0400B939 RID: 47417
		internal static int __PropertyOffset_RangeBuffIdToVictim;

		// Token: 0x0400B93A RID: 47418
		[Nullable(2)]
		private TArray<long> _RangeBuffIdToVictim;
	}
}
