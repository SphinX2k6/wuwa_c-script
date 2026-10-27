using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002537 RID: 9527
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NDCSingle")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FNDCSingle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060235D8 RID: 144856 RVA: 0x00344D3F File Offset: 0x00342F3F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNDCSingle._ScriptStructPtr != 0) ? FNDCSingle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NDCSingle", ref FNDCSingle._ScriptStructPtr);
		}

		// Token: 0x170087F2 RID: 34802
		// (get) Token: 0x060235D9 RID: 144857 RVA: 0x00344D63 File Offset: 0x00342F63
		// (set) Token: 0x060235DA RID: 144858 RVA: 0x00344D77 File Offset: 0x00342F77
		public unsafe AActor SingleActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FNDCSingle.__PropertyOffset_SingleActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNDCSingle.__PropertyOffset_SingleActor, value);
			}
		}

		// Token: 0x170087F3 RID: 34803
		// (get) Token: 0x060235DB RID: 144859 RVA: 0x00344D8C File Offset: 0x00342F8C
		// (set) Token: 0x060235DC RID: 144860 RVA: 0x00344DA0 File Offset: 0x00342FA0
		public unsafe UNiagaraDataChannelHandler_Single Owner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraDataChannelHandler_Single>(base.NativePtr / (IntPtr)sizeof(void*) + FNDCSingle.__PropertyOffset_Owner);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNDCSingle.__PropertyOffset_Owner, value);
			}
		}

		// Token: 0x170087F4 RID: 34804
		// (get) Token: 0x060235DD RID: 144861 RVA: 0x00344DB8 File Offset: 0x00342FB8
		// (set) Token: 0x060235DE RID: 144862 RVA: 0x00344DFB File Offset: 0x00342FFB
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UNiagaraComponent>> NiagaraSystems
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
				if ((result = this._NiagaraSystems) == null)
				{
					result = (this._NiagaraSystems = new TArray<TWeakObjectPtr<UNiagaraComponent>>(base.NativePtr + (IntPtr)FNDCSingle.__PropertyOffset_NiagaraSystems, base.MemoryOwner ?? this));
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
				this.NiagaraSystems.CopyAssign(value);
			}
		}

		// Token: 0x060235DF RID: 144863 RVA: 0x00344E09 File Offset: 0x00343009
		public FNDCSingle()
		{
		}

		// Token: 0x060235E0 RID: 144864 RVA: 0x00344E11 File Offset: 0x00343011
		[NullableContext(1)]
		public FNDCSingle(AActor SingleActor, UNiagaraDataChannelHandler_Single Owner, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TArray<TWeakObjectPtr<UNiagaraComponent>> NiagaraSystems)
		{
			this.SingleActor = SingleActor;
			this.Owner = Owner;
			this.NiagaraSystems = NiagaraSystems;
		}

		// Token: 0x060235E1 RID: 144865 RVA: 0x00344E2E File Offset: 0x0034302E
		protected override IntPtr GetUStructPtr()
		{
			return FNDCSingle.StaticStruct();
		}

		// Token: 0x060235E2 RID: 144866 RVA: 0x00344E3A File Offset: 0x0034303A
		public FNDCSingle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060235E3 RID: 144867 RVA: 0x00344E44 File Offset: 0x00343044
		public FNDCSingle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060235E4 RID: 144868 RVA: 0x00344E4F File Offset: 0x0034304F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNDCSingle(Pointer, false, true);
		}

		// Token: 0x060235E5 RID: 144869 RVA: 0x00344E59 File Offset: 0x00343059
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNDCSingle(Pointer, MemoryOwner);
		}

		// Token: 0x04012FB9 RID: 77753
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NDCSingle";

		// Token: 0x04012FBA RID: 77754
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012FBB RID: 77755
		internal static int __PropertyOffset_SingleActor;

		// Token: 0x04012FBC RID: 77756
		internal static int __PropertyOffset_Owner;

		// Token: 0x04012FBD RID: 77757
		internal static int __PropertyOffset_NiagaraSystems;

		// Token: 0x04012FBE RID: 77758
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UNiagaraComponent>> _NiagaraSystems;
	}
}
