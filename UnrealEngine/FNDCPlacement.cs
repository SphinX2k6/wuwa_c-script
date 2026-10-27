using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002535 RID: 9525
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NDCPlacement")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FNDCPlacement : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060235BE RID: 144830 RVA: 0x00344B3F File Offset: 0x00342D3F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNDCPlacement._ScriptStructPtr != 0) ? FNDCPlacement._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NDCPlacement", ref FNDCPlacement._ScriptStructPtr);
		}

		// Token: 0x170087ED RID: 34797
		// (get) Token: 0x060235BF RID: 144831 RVA: 0x00344B63 File Offset: 0x00342D63
		// (set) Token: 0x060235C0 RID: 144832 RVA: 0x00344B77 File Offset: 0x00342D77
		public unsafe UNiagaraDataChannelHandler_Placement Owner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraDataChannelHandler_Placement>(base.NativePtr / (IntPtr)sizeof(void*) + FNDCPlacement.__PropertyOffset_Owner);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNDCPlacement.__PropertyOffset_Owner, value);
			}
		}

		// Token: 0x170087EE RID: 34798
		// (get) Token: 0x060235C1 RID: 144833 RVA: 0x00344B8C File Offset: 0x00342D8C
		// (set) Token: 0x060235C2 RID: 144834 RVA: 0x00344BA0 File Offset: 0x00342DA0
		public unsafe FBoxSphereBounds Bounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNDCPlacement.__PropertyOffset_Bounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNDCPlacement.__PropertyOffset_Bounds) = value;
			}
		}

		// Token: 0x170087EF RID: 34799
		// (get) Token: 0x060235C3 RID: 144835 RVA: 0x00344BB5 File Offset: 0x00342DB5
		// (set) Token: 0x060235C4 RID: 144836 RVA: 0x00344BC9 File Offset: 0x00342DC9
		public unsafe UNiagaraComponent NiagaraComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FNDCPlacement.__PropertyOffset_NiagaraComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNDCPlacement.__PropertyOffset_NiagaraComponent, value);
			}
		}

		// Token: 0x060235C5 RID: 144837 RVA: 0x00344BDE File Offset: 0x00342DDE
		public FNDCPlacement()
		{
		}

		// Token: 0x060235C6 RID: 144838 RVA: 0x00344BE6 File Offset: 0x00342DE6
		[NullableContext(1)]
		public FNDCPlacement(UNiagaraDataChannelHandler_Placement Owner, FBoxSphereBounds Bounds, UNiagaraComponent NiagaraComponent)
		{
			this.Owner = Owner;
			this.Bounds = Bounds;
			this.NiagaraComponent = NiagaraComponent;
		}

		// Token: 0x060235C7 RID: 144839 RVA: 0x00344C03 File Offset: 0x00342E03
		protected override IntPtr GetUStructPtr()
		{
			return FNDCPlacement.StaticStruct();
		}

		// Token: 0x060235C8 RID: 144840 RVA: 0x00344C0F File Offset: 0x00342E0F
		public FNDCPlacement(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060235C9 RID: 144841 RVA: 0x00344C19 File Offset: 0x00342E19
		public FNDCPlacement(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060235CA RID: 144842 RVA: 0x00344C24 File Offset: 0x00342E24
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNDCPlacement(Pointer, false, true);
		}

		// Token: 0x060235CB RID: 144843 RVA: 0x00344C2E File Offset: 0x00342E2E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNDCPlacement(Pointer, MemoryOwner);
		}

		// Token: 0x04012FAE RID: 77742
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NDCPlacement";

		// Token: 0x04012FAF RID: 77743
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012FB0 RID: 77744
		internal static int __PropertyOffset_Owner;

		// Token: 0x04012FB1 RID: 77745
		internal static int __PropertyOffset_Bounds;

		// Token: 0x04012FB2 RID: 77746
		internal static int __PropertyOffset_NiagaraComponent;
	}
}
