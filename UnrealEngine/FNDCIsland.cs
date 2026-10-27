using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002533 RID: 9523
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NDCIsland")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FNDCIsland : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060235A2 RID: 144802 RVA: 0x003448E6 File Offset: 0x00342AE6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNDCIsland._ScriptStructPtr != 0) ? FNDCIsland._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NDCIsland", ref FNDCIsland._ScriptStructPtr);
		}

		// Token: 0x170087E7 RID: 34791
		// (get) Token: 0x060235A3 RID: 144803 RVA: 0x0034490A File Offset: 0x00342B0A
		// (set) Token: 0x060235A4 RID: 144804 RVA: 0x0034491E File Offset: 0x00342B1E
		[Nullable(2)]
		public unsafe UNiagaraDataChannelHandler_Islands Owner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraDataChannelHandler_Islands>(base.NativePtr / (IntPtr)sizeof(void*) + FNDCIsland.__PropertyOffset_Owner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNDCIsland.__PropertyOffset_Owner, value);
			}
		}

		// Token: 0x170087E8 RID: 34792
		// (get) Token: 0x060235A5 RID: 144805 RVA: 0x00344933 File Offset: 0x00342B33
		// (set) Token: 0x060235A6 RID: 144806 RVA: 0x00344947 File Offset: 0x00342B47
		public unsafe FBoxSphereBounds Bounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNDCIsland.__PropertyOffset_Bounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNDCIsland.__PropertyOffset_Bounds) = value;
			}
		}

		// Token: 0x170087E9 RID: 34793
		// (get) Token: 0x060235A7 RID: 144807 RVA: 0x0034495C File Offset: 0x00342B5C
		// (set) Token: 0x060235A8 RID: 144808 RVA: 0x0034499F File Offset: 0x00342B9F
		public TArray<UNiagaraComponent> NiagaraSystems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraComponent> result;
				if ((result = this._NiagaraSystems) == null)
				{
					result = (this._NiagaraSystems = new TArray<UNiagaraComponent>(base.NativePtr + (IntPtr)FNDCIsland.__PropertyOffset_NiagaraSystems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NiagaraSystems.CopyAssign(value);
			}
		}

		// Token: 0x170087EA RID: 34794
		// (get) Token: 0x060235A9 RID: 144809 RVA: 0x003449AD File Offset: 0x00342BAD
		// (set) Token: 0x060235AA RID: 144810 RVA: 0x003449C1 File Offset: 0x00342BC1
		[Nullable(2)]
		public unsafe AActor IslandActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FNDCIsland.__PropertyOffset_IslandActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNDCIsland.__PropertyOffset_IslandActor, value);
			}
		}

		// Token: 0x060235AB RID: 144811 RVA: 0x003449D6 File Offset: 0x00342BD6
		public FNDCIsland()
		{
		}

		// Token: 0x060235AC RID: 144812 RVA: 0x003449DE File Offset: 0x00342BDE
		public FNDCIsland(UNiagaraDataChannelHandler_Islands Owner, FBoxSphereBounds Bounds, TArray<UNiagaraComponent> NiagaraSystems, AActor IslandActor)
		{
			this.Owner = Owner;
			this.Bounds = Bounds;
			this.NiagaraSystems = NiagaraSystems;
			this.IslandActor = IslandActor;
		}

		// Token: 0x060235AD RID: 144813 RVA: 0x00344A03 File Offset: 0x00342C03
		protected override IntPtr GetUStructPtr()
		{
			return FNDCIsland.StaticStruct();
		}

		// Token: 0x060235AE RID: 144814 RVA: 0x00344A0F File Offset: 0x00342C0F
		[NullableContext(2)]
		public FNDCIsland(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060235AF RID: 144815 RVA: 0x00344A19 File Offset: 0x00342C19
		public FNDCIsland(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060235B0 RID: 144816 RVA: 0x00344A24 File Offset: 0x00342C24
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNDCIsland(Pointer, false, true);
		}

		// Token: 0x060235B1 RID: 144817 RVA: 0x00344A2E File Offset: 0x00342C2E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNDCIsland(Pointer, MemoryOwner);
		}

		// Token: 0x04012FA1 RID: 77729
		public const string __ObjectPath = "/Script/Niagara.NDCIsland";

		// Token: 0x04012FA2 RID: 77730
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012FA3 RID: 77731
		internal static int __PropertyOffset_Owner;

		// Token: 0x04012FA4 RID: 77732
		internal static int __PropertyOffset_Bounds;

		// Token: 0x04012FA5 RID: 77733
		internal static int __PropertyOffset_NiagaraSystems;

		// Token: 0x04012FA6 RID: 77734
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraComponent> _NiagaraSystems;

		// Token: 0x04012FA7 RID: 77735
		internal static int __PropertyOffset_IslandActor;
	}
}
