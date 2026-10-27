using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200083C RID: 2108
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimSet")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UAnimSet : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007182 RID: 29058 RVA: 0x000A2A67 File Offset: 0x000A0C67
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimSet._ClassPtr;
		}

		// Token: 0x06007183 RID: 29059 RVA: 0x000A2A74 File Offset: 0x000A0C74
		public UAnimSet() : this(BuiltinUtils.AllocNativeUObject(UAnimSet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007184 RID: 29060 RVA: 0x000A2A9C File Offset: 0x000A0C9C
		public UAnimSet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimSet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x06007185 RID: 29061 RVA: 0x000A2ACF File Offset: 0x000A0CCF
		// (set) Token: 0x06007186 RID: 29062 RVA: 0x000A2AE8 File Offset: 0x000A0CE8
		public unsafe bool bAnimRotationOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAnimSet.__PropertyOffset_bAnimRotationOnly) & UAnimSet.__PropertyMask_bAnimRotationOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAnimSet.__PropertyOffset_bAnimRotationOnly) = ((*(base.NativePtr + (IntPtr)UAnimSet.__PropertyOffset_bAnimRotationOnly) & ~UAnimSet.__PropertyMask_bAnimRotationOnly) | (value ? UAnimSet.__PropertyMask_bAnimRotationOnly : 0));
			}
		}

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x06007187 RID: 29063 RVA: 0x000A2B18 File Offset: 0x000A0D18
		// (set) Token: 0x06007188 RID: 29064 RVA: 0x000A2B51 File Offset: 0x000A0D51
		public TArray<FName> TrackBoneNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TrackBoneNames) == null)
				{
					result = (this._TrackBoneNames = new TArray<FName>(base.NativePtr + (IntPtr)UAnimSet.__PropertyOffset_TrackBoneNames, this));
				}
				return result;
			}
			set
			{
				this.TrackBoneNames.CopyAssign(value);
			}
		}

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x06007189 RID: 29065 RVA: 0x000A2B60 File Offset: 0x000A0D60
		// (set) Token: 0x0600718A RID: 29066 RVA: 0x000A2B99 File Offset: 0x000A0D99
		public TArray<FAnimSetMeshLinkup> LinkupCache
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimSetMeshLinkup> result;
				if ((result = this._LinkupCache) == null)
				{
					result = (this._LinkupCache = new TArray<FAnimSetMeshLinkup>(base.NativePtr + (IntPtr)UAnimSet.__PropertyOffset_LinkupCache, this));
				}
				return result;
			}
			set
			{
				this.LinkupCache.CopyAssign(value);
			}
		}

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x0600718B RID: 29067 RVA: 0x000A2BA8 File Offset: 0x000A0DA8
		// (set) Token: 0x0600718C RID: 29068 RVA: 0x000A2BE1 File Offset: 0x000A0DE1
		public TArray<byte> BoneUseAnimTranslation
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._BoneUseAnimTranslation) == null)
				{
					result = (this._BoneUseAnimTranslation = new TArray<byte>(base.NativePtr + (IntPtr)UAnimSet.__PropertyOffset_BoneUseAnimTranslation, this));
				}
				return result;
			}
			set
			{
				this.BoneUseAnimTranslation.CopyAssign(value);
			}
		}

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x0600718D RID: 29069 RVA: 0x000A2BF0 File Offset: 0x000A0DF0
		// (set) Token: 0x0600718E RID: 29070 RVA: 0x000A2C29 File Offset: 0x000A0E29
		public TArray<byte> ForceUseMeshTranslation
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._ForceUseMeshTranslation) == null)
				{
					result = (this._ForceUseMeshTranslation = new TArray<byte>(base.NativePtr + (IntPtr)UAnimSet.__PropertyOffset_ForceUseMeshTranslation, this));
				}
				return result;
			}
			set
			{
				this.ForceUseMeshTranslation.CopyAssign(value);
			}
		}

		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x0600718F RID: 29071 RVA: 0x000A2C38 File Offset: 0x000A0E38
		// (set) Token: 0x06007190 RID: 29072 RVA: 0x000A2C71 File Offset: 0x000A0E71
		public TArray<FName> UseTranslationBoneNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._UseTranslationBoneNames) == null)
				{
					result = (this._UseTranslationBoneNames = new TArray<FName>(base.NativePtr + (IntPtr)UAnimSet.__PropertyOffset_UseTranslationBoneNames, this));
				}
				return result;
			}
			set
			{
				this.UseTranslationBoneNames.CopyAssign(value);
			}
		}

		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x06007191 RID: 29073 RVA: 0x000A2C80 File Offset: 0x000A0E80
		// (set) Token: 0x06007192 RID: 29074 RVA: 0x000A2CB9 File Offset: 0x000A0EB9
		public TArray<FName> ForceMeshTranslationBoneNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ForceMeshTranslationBoneNames) == null)
				{
					result = (this._ForceMeshTranslationBoneNames = new TArray<FName>(base.NativePtr + (IntPtr)UAnimSet.__PropertyOffset_ForceMeshTranslationBoneNames, this));
				}
				return result;
			}
			set
			{
				this.ForceMeshTranslationBoneNames.CopyAssign(value);
			}
		}

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x06007193 RID: 29075 RVA: 0x000A2CC7 File Offset: 0x000A0EC7
		// (set) Token: 0x06007194 RID: 29076 RVA: 0x000A2CDB File Offset: 0x000A0EDB
		public unsafe FName PreviewSkelMeshName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSet.__PropertyOffset_PreviewSkelMeshName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSet.__PropertyOffset_PreviewSkelMeshName) = value;
			}
		}

		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x06007195 RID: 29077 RVA: 0x000A2CF0 File Offset: 0x000A0EF0
		// (set) Token: 0x06007196 RID: 29078 RVA: 0x000A2D04 File Offset: 0x000A0F04
		public unsafe FName BestRatioSkelMeshName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSet.__PropertyOffset_BestRatioSkelMeshName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSet.__PropertyOffset_BestRatioSkelMeshName) = value;
			}
		}

		// Token: 0x06007197 RID: 29079 RVA: 0x000A2D19 File Offset: 0x000A0F19
		static UAnimSet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimSet");
		}

		// Token: 0x06007198 RID: 29080 RVA: 0x000A2D27 File Offset: 0x000A0F27
		protected UAnimSet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400368B RID: 13963
		public new const string __ObjectPath = "/Script/Engine.AnimSet";

		// Token: 0x0400368C RID: 13964
		private static IntPtr _ClassPtr;

		// Token: 0x0400368D RID: 13965
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400368E RID: 13966
		internal static int __PropertyOffset_bAnimRotationOnly;

		// Token: 0x0400368F RID: 13967
		internal static byte __PropertyMask_bAnimRotationOnly;

		// Token: 0x04003690 RID: 13968
		internal static int __PropertyOffset_TrackBoneNames;

		// Token: 0x04003691 RID: 13969
		[Nullable(2)]
		private TArray<FName> _TrackBoneNames;

		// Token: 0x04003692 RID: 13970
		internal static int __PropertyOffset_LinkupCache;

		// Token: 0x04003693 RID: 13971
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimSetMeshLinkup> _LinkupCache;

		// Token: 0x04003694 RID: 13972
		internal static int __PropertyOffset_BoneUseAnimTranslation;

		// Token: 0x04003695 RID: 13973
		[Nullable(2)]
		private TArray<byte> _BoneUseAnimTranslation;

		// Token: 0x04003696 RID: 13974
		internal static int __PropertyOffset_ForceUseMeshTranslation;

		// Token: 0x04003697 RID: 13975
		[Nullable(2)]
		private TArray<byte> _ForceUseMeshTranslation;

		// Token: 0x04003698 RID: 13976
		internal static int __PropertyOffset_UseTranslationBoneNames;

		// Token: 0x04003699 RID: 13977
		[Nullable(2)]
		private TArray<FName> _UseTranslationBoneNames;

		// Token: 0x0400369A RID: 13978
		internal static int __PropertyOffset_ForceMeshTranslationBoneNames;

		// Token: 0x0400369B RID: 13979
		[Nullable(2)]
		private TArray<FName> _ForceMeshTranslationBoneNames;

		// Token: 0x0400369C RID: 13980
		internal static int __PropertyOffset_PreviewSkelMeshName;

		// Token: 0x0400369D RID: 13981
		internal static int __PropertyOffset_BestRatioSkelMeshName;
	}
}
