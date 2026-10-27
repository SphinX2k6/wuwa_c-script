using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018F4 RID: 6388
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelSwitchMaterial")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UKuroLevelSwitchMaterial : UKuroLevelStateAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017B26 RID: 97062 RVA: 0x0022B9FB File Offset: 0x00229BFB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelSwitchMaterial._ClassPtr;
		}

		// Token: 0x06017B27 RID: 97063 RVA: 0x0022BA08 File Offset: 0x00229C08
		public UKuroLevelSwitchMaterial() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelSwitchMaterial.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017B28 RID: 97064 RVA: 0x0022BA30 File Offset: 0x00229C30
		public UKuroLevelSwitchMaterial(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelSwitchMaterial.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F77 RID: 24439
		// (get) Token: 0x06017B29 RID: 97065 RVA: 0x0022BA63 File Offset: 0x00229C63
		// (set) Token: 0x06017B2A RID: 97066 RVA: 0x0022BA73 File Offset: 0x00229C73
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelSwitchMaterial.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelSwitchMaterial.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17005F78 RID: 24440
		// (get) Token: 0x06017B2B RID: 97067 RVA: 0x0022BA84 File Offset: 0x00229C84
		// (set) Token: 0x06017B2C RID: 97068 RVA: 0x0022BABD File Offset: 0x00229CBD
		public TArray<FKuroLevelSwitchMaterialData> Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroLevelSwitchMaterialData> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<FKuroLevelSwitchMaterialData>(base.NativePtr + (IntPtr)UKuroLevelSwitchMaterial.__PropertyOffset_Materials, this));
				}
				return result;
			}
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x06017B2D RID: 97069 RVA: 0x0022BACB File Offset: 0x00229CCB
		static UKuroLevelSwitchMaterial()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroLevelSwitchMaterial");
		}

		// Token: 0x06017B2E RID: 97070 RVA: 0x0022BAD9 File Offset: 0x00229CD9
		protected UKuroLevelSwitchMaterial(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CDDC RID: 52700
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroLevelSwitchMaterial";

		// Token: 0x0400CDDD RID: 52701
		private static IntPtr _ClassPtr;

		// Token: 0x0400CDDE RID: 52702
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CDDF RID: 52703
		internal static int __PropertyOffset_Priority;

		// Token: 0x0400CDE0 RID: 52704
		internal static int __PropertyOffset_Materials;

		// Token: 0x0400CDE1 RID: 52705
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroLevelSwitchMaterialData> _Materials;
	}
}
