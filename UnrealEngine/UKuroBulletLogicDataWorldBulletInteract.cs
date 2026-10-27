using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016FF RID: 5887
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletLogicDataWorldBulletInteract")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKuroBulletLogicDataWorldBulletInteract : UKuroBulletLogicDataBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601543B RID: 87099 RVA: 0x001F40E4 File Offset: 0x001F22E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBulletLogicDataWorldBulletInteract._ClassPtr;
		}

		// Token: 0x0601543C RID: 87100 RVA: 0x001F40F0 File Offset: 0x001F22F0
		public UKuroBulletLogicDataWorldBulletInteract() : this(BuiltinUtils.AllocNativeUObject(UKuroBulletLogicDataWorldBulletInteract.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601543D RID: 87101 RVA: 0x001F4118 File Offset: 0x001F2318
		public UKuroBulletLogicDataWorldBulletInteract(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBulletLogicDataWorldBulletInteract.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700541C RID: 21532
		// (get) Token: 0x0601543E RID: 87102 RVA: 0x001F414C File Offset: 0x001F234C
		// (set) Token: 0x0601543F RID: 87103 RVA: 0x001F4185 File Offset: 0x001F2385
		public TArray<EWorldBulletType> InteractionWorldBulletTypes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EWorldBulletType> result;
				if ((result = this._InteractionWorldBulletTypes) == null)
				{
					result = (this._InteractionWorldBulletTypes = new TArray<EWorldBulletType>(base.NativePtr + (IntPtr)UKuroBulletLogicDataWorldBulletInteract.__PropertyOffset_InteractionWorldBulletTypes, this));
				}
				return result;
			}
			set
			{
				this.InteractionWorldBulletTypes.CopyAssign(value);
			}
		}

		// Token: 0x1700541D RID: 21533
		// (get) Token: 0x06015440 RID: 87104 RVA: 0x001F4193 File Offset: 0x001F2393
		// (set) Token: 0x06015441 RID: 87105 RVA: 0x001F41A3 File Offset: 0x001F23A3
		public unsafe EKuroBulletInteract WorldBulletInteractType
		{
			get
			{
				return (EKuroBulletInteract)(*(base.NativePtr + (IntPtr)UKuroBulletLogicDataWorldBulletInteract.__PropertyOffset_WorldBulletInteractType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBulletLogicDataWorldBulletInteract.__PropertyOffset_WorldBulletInteractType) = (byte)value;
			}
		}

		// Token: 0x06015442 RID: 87106 RVA: 0x001F41B4 File Offset: 0x001F23B4
		static UKuroBulletLogicDataWorldBulletInteract()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.KuroBulletLogicDataWorldBulletInteract");
		}

		// Token: 0x06015443 RID: 87107 RVA: 0x001F41C2 File Offset: 0x001F23C2
		protected UKuroBulletLogicDataWorldBulletInteract(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B980 RID: 47488
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletLogicDataWorldBulletInteract";

		// Token: 0x0400B981 RID: 47489
		private static IntPtr _ClassPtr;

		// Token: 0x0400B982 RID: 47490
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B983 RID: 47491
		internal static int __PropertyOffset_InteractionWorldBulletTypes;

		// Token: 0x0400B984 RID: 47492
		[Nullable(2)]
		private TArray<EWorldBulletType> _InteractionWorldBulletTypes;

		// Token: 0x0400B985 RID: 47493
		internal static int __PropertyOffset_WorldBulletInteractType;
	}
}
