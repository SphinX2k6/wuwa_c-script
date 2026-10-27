using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002519 RID: 9497
	[UnrealObjectPath("/Script/Niagara.KuroNiagaraTickManager")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroNiagaraTickManager : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060234A5 RID: 144549 RVA: 0x003431DF File Offset: 0x003413DF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroNiagaraTickManager._ScriptStructPtr != 0) ? FKuroNiagaraTickManager._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.KuroNiagaraTickManager", ref FKuroNiagaraTickManager._ScriptStructPtr);
		}

		// Token: 0x170087C3 RID: 34755
		// (get) Token: 0x060234A6 RID: 144550 RVA: 0x00343203 File Offset: 0x00341403
		// (set) Token: 0x060234A7 RID: 144551 RVA: 0x00343217 File Offset: 0x00341417
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UKuroNiagaraTickType> TickType
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroNiagaraTickManager.__PropertyOffset_TickType);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FKuroNiagaraTickManager.__PropertyOffset_TickType) = value;
			}
		}

		// Token: 0x170087C4 RID: 34756
		// (get) Token: 0x060234A8 RID: 144552 RVA: 0x0034322C File Offset: 0x0034142C
		// (set) Token: 0x060234A9 RID: 144553 RVA: 0x0034326F File Offset: 0x0034146F
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UNiagaraComponent>> ManagedComponents
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
				TArray<TWeakObjectPtr<UNiagaraComponent>> result;
				if ((result = this._ManagedComponents) == null)
				{
					result = (this._ManagedComponents = new TArray<TWeakObjectPtr<UNiagaraComponent>>(base.NativePtr + (IntPtr)FKuroNiagaraTickManager.__PropertyOffset_ManagedComponents, base.MemoryOwner ?? this));
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
				this.ManagedComponents.CopyAssign(value);
			}
		}

		// Token: 0x060234AA RID: 144554 RVA: 0x0034327D File Offset: 0x0034147D
		public FKuroNiagaraTickManager()
		{
		}

		// Token: 0x060234AB RID: 144555 RVA: 0x00343285 File Offset: 0x00341485
		public FKuroNiagaraTickManager([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UKuroNiagaraTickType> TickType, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TArray<TWeakObjectPtr<UNiagaraComponent>> ManagedComponents)
		{
			this.TickType = TickType;
			this.ManagedComponents = ManagedComponents;
		}

		// Token: 0x060234AC RID: 144556 RVA: 0x0034329B File Offset: 0x0034149B
		protected override IntPtr GetUStructPtr()
		{
			return FKuroNiagaraTickManager.StaticStruct();
		}

		// Token: 0x060234AD RID: 144557 RVA: 0x003432A7 File Offset: 0x003414A7
		[NullableContext(2)]
		public FKuroNiagaraTickManager(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060234AE RID: 144558 RVA: 0x003432B1 File Offset: 0x003414B1
		public FKuroNiagaraTickManager(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060234AF RID: 144559 RVA: 0x003432BC File Offset: 0x003414BC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroNiagaraTickManager(Pointer, false, true);
		}

		// Token: 0x060234B0 RID: 144560 RVA: 0x003432C6 File Offset: 0x003414C6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroNiagaraTickManager(Pointer, MemoryOwner);
		}

		// Token: 0x04012F20 RID: 77600
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.KuroNiagaraTickManager";

		// Token: 0x04012F21 RID: 77601
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012F22 RID: 77602
		internal static int __PropertyOffset_TickType;

		// Token: 0x04012F23 RID: 77603
		internal static int __PropertyOffset_ManagedComponents;

		// Token: 0x04012F24 RID: 77604
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UNiagaraComponent>> _ManagedComponents;
	}
}
