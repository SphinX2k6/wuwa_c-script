using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006A8 RID: 1704
	[UnrealObjectPath("/Script/LGUI.LGUINiagaraComponent")]
	[UnrealStructLayout(2544, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2544)]
	public class ULGUINiagaraComponent : UNiagaraComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600927D RID: 37501 RVA: 0x000DCBD7 File Offset: 0x000DADD7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUINiagaraComponent._ClassPtr;
		}

		// Token: 0x0600927E RID: 37502 RVA: 0x000DCBE4 File Offset: 0x000DADE4
		public ULGUINiagaraComponent() : this(BuiltinUtils.AllocNativeUObject(ULGUINiagaraComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600927F RID: 37503 RVA: 0x000DCC0C File Offset: 0x000DAE0C
		[NullableContext(1)]
		public ULGUINiagaraComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUINiagaraComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x06009280 RID: 37504 RVA: 0x000DCC3F File Offset: 0x000DAE3F
		// (set) Token: 0x06009281 RID: 37505 RVA: 0x000DCC4F File Offset: 0x000DAE4F
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

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x06009282 RID: 37506 RVA: 0x000DCC60 File Offset: 0x000DAE60
		// (set) Token: 0x06009283 RID: 37507 RVA: 0x000DCC70 File Offset: 0x000DAE70
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

		// Token: 0x06009284 RID: 37508 RVA: 0x000DCC81 File Offset: 0x000DAE81
		static ULGUINiagaraComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUINiagaraComponent");
		}

		// Token: 0x06009285 RID: 37509 RVA: 0x000DCC8F File Offset: 0x000DAE8F
		protected ULGUINiagaraComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003FDF RID: 16351
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUINiagaraComponent";

		// Token: 0x04003FE0 RID: 16352
		private static IntPtr _ClassPtr;

		// Token: 0x04003FE1 RID: 16353
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003FE2 RID: 16354
		internal static int __PropertyOffset_IsUIDrawCallVisible;

		// Token: 0x04003FE3 RID: 16355
		internal static int __PropertyOffset_IsSupportWorldSpace;
	}
}
