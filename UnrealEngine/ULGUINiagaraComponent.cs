using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002091 RID: 8337
	[UnrealObjectPath("/Script/LGUI.LGUINiagaraComponent")]
	[UnrealStructLayout(2544, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2544)]
	public class ULGUINiagaraComponent : UNiagaraComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F715 RID: 128789 RVA: 0x002EB707 File Offset: 0x002E9907
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUINiagaraComponent._ClassPtr;
		}

		// Token: 0x0601F716 RID: 128790 RVA: 0x002EB714 File Offset: 0x002E9914
		public ULGUINiagaraComponent() : this(BuiltinUtils.AllocNativeUObject(ULGUINiagaraComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F717 RID: 128791 RVA: 0x002EB73C File Offset: 0x002E993C
		[NullableContext(1)]
		public ULGUINiagaraComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUINiagaraComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C0D RID: 31757
		// (get) Token: 0x0601F718 RID: 128792 RVA: 0x002EB76F File Offset: 0x002E996F
		// (set) Token: 0x0601F719 RID: 128793 RVA: 0x002EB77F File Offset: 0x002E997F
		public unsafe bool IsUIDrawCallVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUINiagaraComponent.__PropertyOffset_IsUIDrawCallVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUINiagaraComponent.__PropertyOffset_IsUIDrawCallVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007C0E RID: 31758
		// (get) Token: 0x0601F71A RID: 128794 RVA: 0x002EB790 File Offset: 0x002E9990
		// (set) Token: 0x0601F71B RID: 128795 RVA: 0x002EB7A0 File Offset: 0x002E99A0
		public unsafe bool IsSupportWorldSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUINiagaraComponent.__PropertyOffset_IsSupportWorldSpace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUINiagaraComponent.__PropertyOffset_IsSupportWorldSpace) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F71C RID: 128796 RVA: 0x002EB7B1 File Offset: 0x002E99B1
		static ULGUINiagaraComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUINiagaraComponent");
		}

		// Token: 0x0601F71D RID: 128797 RVA: 0x002EB7BF File Offset: 0x002E99BF
		protected ULGUINiagaraComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FAF RID: 69551
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUINiagaraComponent";

		// Token: 0x04010FB0 RID: 69552
		private static IntPtr _ClassPtr;

		// Token: 0x04010FB1 RID: 69553
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010FB2 RID: 69554
		internal static int __PropertyOffset_IsUIDrawCallVisible;

		// Token: 0x04010FB3 RID: 69555
		internal static int __PropertyOffset_IsSupportWorldSpace;
	}
}
