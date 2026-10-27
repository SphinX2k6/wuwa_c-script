using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001659 RID: 5721
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroAnimInstancePhyCloth")]
	[UnrealStructLayout(2224, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2224)]
	public class UKuroAnimInstancePhyCloth : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014A39 RID: 84537 RVA: 0x001E61A0 File Offset: 0x001E43A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimInstancePhyCloth._ClassPtr;
		}

		// Token: 0x06014A3A RID: 84538 RVA: 0x001E61AC File Offset: 0x001E43AC
		public UKuroAnimInstancePhyCloth() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstancePhyCloth.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014A3B RID: 84539 RVA: 0x001E61D4 File Offset: 0x001E43D4
		public UKuroAnimInstancePhyCloth(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstancePhyCloth.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005149 RID: 20809
		// (get) Token: 0x06014A3C RID: 84540 RVA: 0x001E6207 File Offset: 0x001E4407
		// (set) Token: 0x06014A3D RID: 84541 RVA: 0x001E6217 File Offset: 0x001E4417
		public unsafe bool bEnableFormSwitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstancePhyCloth.__PropertyOffset_bEnableFormSwitch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstancePhyCloth.__PropertyOffset_bEnableFormSwitch) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700514A RID: 20810
		// (get) Token: 0x06014A3E RID: 84542 RVA: 0x001E6228 File Offset: 0x001E4428
		// (set) Token: 0x06014A3F RID: 84543 RVA: 0x001E6261 File Offset: 0x001E4461
		public TArray<TSoftObjectPtr<USkeletalMesh>> FormSkelMeshRefs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<USkeletalMesh>> result;
				if ((result = this._FormSkelMeshRefs) == null)
				{
					result = (this._FormSkelMeshRefs = new TArray<TSoftObjectPtr<USkeletalMesh>>(base.NativePtr + (IntPtr)UKuroAnimInstancePhyCloth.__PropertyOffset_FormSkelMeshRefs, this));
				}
				return result;
			}
			set
			{
				this.FormSkelMeshRefs.CopyAssign(value);
			}
		}

		// Token: 0x06014A40 RID: 84544 RVA: 0x001E626F File Offset: 0x001E446F
		static UKuroAnimInstancePhyCloth()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAnimInstancePhyCloth");
		}

		// Token: 0x06014A41 RID: 84545 RVA: 0x001E627D File Offset: 0x001E447D
		protected UKuroAnimInstancePhyCloth(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B416 RID: 46102
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAnimInstancePhyCloth";

		// Token: 0x0400B417 RID: 46103
		private static IntPtr _ClassPtr;

		// Token: 0x0400B418 RID: 46104
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B419 RID: 46105
		internal static int __PropertyOffset_bEnableFormSwitch;

		// Token: 0x0400B41A RID: 46106
		internal static int __PropertyOffset_FormSkelMeshRefs;

		// Token: 0x0400B41B RID: 46107
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<USkeletalMesh>> _FormSkelMeshRefs;
	}
}
