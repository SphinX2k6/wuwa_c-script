using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025DB RID: 9691
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraScalabilityManager")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FNiagaraScalabilityManager : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602405B RID: 147547 RVA: 0x00354C14 File Offset: 0x00352E14
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraScalabilityManager._ScriptStructPtr != 0) ? FNiagaraScalabilityManager._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraScalabilityManager", ref FNiagaraScalabilityManager._ScriptStructPtr);
		}

		// Token: 0x17008A95 RID: 35477
		// (get) Token: 0x0602405C RID: 147548 RVA: 0x00354C38 File Offset: 0x00352E38
		// (set) Token: 0x0602405D RID: 147549 RVA: 0x00354C4C File Offset: 0x00352E4C
		[Nullable(2)]
		public unsafe UNiagaraEffectType EffectType
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraEffectType>(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraScalabilityManager.__PropertyOffset_EffectType);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraScalabilityManager.__PropertyOffset_EffectType, value);
			}
		}

		// Token: 0x17008A96 RID: 35478
		// (get) Token: 0x0602405E RID: 147550 RVA: 0x00354C64 File Offset: 0x00352E64
		// (set) Token: 0x0602405F RID: 147551 RVA: 0x00354CA7 File Offset: 0x00352EA7
		public TArray<UNiagaraComponent> ManagedComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraComponent> result;
				if ((result = this._ManagedComponents) == null)
				{
					result = (this._ManagedComponents = new TArray<UNiagaraComponent>(base.NativePtr + (IntPtr)FNiagaraScalabilityManager.__PropertyOffset_ManagedComponents, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ManagedComponents.CopyAssign(value);
			}
		}

		// Token: 0x06024060 RID: 147552 RVA: 0x00354CB5 File Offset: 0x00352EB5
		public FNiagaraScalabilityManager()
		{
		}

		// Token: 0x06024061 RID: 147553 RVA: 0x00354CBD File Offset: 0x00352EBD
		public FNiagaraScalabilityManager(UNiagaraEffectType EffectType, TArray<UNiagaraComponent> ManagedComponents)
		{
			this.EffectType = EffectType;
			this.ManagedComponents = ManagedComponents;
		}

		// Token: 0x06024062 RID: 147554 RVA: 0x00354CD3 File Offset: 0x00352ED3
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraScalabilityManager.StaticStruct();
		}

		// Token: 0x06024063 RID: 147555 RVA: 0x00354CDF File Offset: 0x00352EDF
		[NullableContext(2)]
		public FNiagaraScalabilityManager(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024064 RID: 147556 RVA: 0x00354CE9 File Offset: 0x00352EE9
		public FNiagaraScalabilityManager(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024065 RID: 147557 RVA: 0x00354CF4 File Offset: 0x00352EF4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraScalabilityManager(Pointer, false, true);
		}

		// Token: 0x06024066 RID: 147558 RVA: 0x00354CFE File Offset: 0x00352EFE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraScalabilityManager(Pointer, MemoryOwner);
		}

		// Token: 0x0401351B RID: 79131
		public const string __ObjectPath = "/Script/Niagara.NiagaraScalabilityManager";

		// Token: 0x0401351C RID: 79132
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401351D RID: 79133
		internal static int __PropertyOffset_EffectType;

		// Token: 0x0401351E RID: 79134
		internal static int __PropertyOffset_ManagedComponents;

		// Token: 0x0401351F RID: 79135
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraComponent> _ManagedComponents;
	}
}
