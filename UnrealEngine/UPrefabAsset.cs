using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002655 RID: 9813
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PrefabSystem.PrefabAsset")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UPrefabAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024783 RID: 149379 RVA: 0x0035FB8E File Offset: 0x0035DD8E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPrefabAsset._ClassPtr;
		}

		// Token: 0x06024784 RID: 149380 RVA: 0x0035FB9C File Offset: 0x0035DD9C
		public UPrefabAsset() : this(BuiltinUtils.AllocNativeUObject(UPrefabAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024785 RID: 149381 RVA: 0x0035FBC4 File Offset: 0x0035DDC4
		public UPrefabAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPrefabAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008C95 RID: 35989
		// (get) Token: 0x06024786 RID: 149382 RVA: 0x0035FBF7 File Offset: 0x0035DDF7
		// (set) Token: 0x06024787 RID: 149383 RVA: 0x0035FC07 File Offset: 0x0035DE07
		public unsafe int NextFileID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_NextFileID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_NextFileID) = value;
			}
		}

		// Token: 0x17008C96 RID: 35990
		// (get) Token: 0x06024788 RID: 149384 RVA: 0x0035FC18 File Offset: 0x0035DE18
		// (set) Token: 0x06024789 RID: 149385 RVA: 0x0035FC28 File Offset: 0x0035DE28
		public unsafe ushort Version
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_Version);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_Version) = (short)value;
			}
		}

		// Token: 0x17008C97 RID: 35991
		// (get) Token: 0x0602478A RID: 149386 RVA: 0x0035FC39 File Offset: 0x0035DE39
		// (set) Token: 0x0602478B RID: 149387 RVA: 0x0035FC4D File Offset: 0x0035DE4D
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x17008C98 RID: 35992
		// (get) Token: 0x0602478C RID: 149388 RVA: 0x0035FC64 File Offset: 0x0035DE64
		// (set) Token: 0x0602478D RID: 149389 RVA: 0x0035FC9D File Offset: 0x0035DE9D
		public TArray<UObject> ReferenceAssets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ReferenceAssets) == null)
				{
					result = (this._ReferenceAssets = new TArray<UObject>(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_ReferenceAssets, this));
				}
				return result;
			}
			set
			{
				this.ReferenceAssets.CopyAssign(value);
			}
		}

		// Token: 0x17008C99 RID: 35993
		// (get) Token: 0x0602478E RID: 149390 RVA: 0x0035FCAC File Offset: 0x0035DEAC
		// (set) Token: 0x0602478F RID: 149391 RVA: 0x0035FCE5 File Offset: 0x0035DEE5
		public TArray<FName> ReferenceFNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ReferenceFNames) == null)
				{
					result = (this._ReferenceFNames = new TArray<FName>(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_ReferenceFNames, this));
				}
				return result;
			}
			set
			{
				this.ReferenceFNames.CopyAssign(value);
			}
		}

		// Token: 0x17008C9A RID: 35994
		// (get) Token: 0x06024790 RID: 149392 RVA: 0x0035FCF4 File Offset: 0x0035DEF4
		// (set) Token: 0x06024791 RID: 149393 RVA: 0x0035FD2D File Offset: 0x0035DF2D
		public TArray<UClass> ReferenceClasses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UClass> result;
				if ((result = this._ReferenceClasses) == null)
				{
					result = (this._ReferenceClasses = new TArray<UClass>(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_ReferenceClasses, this));
				}
				return result;
			}
			set
			{
				this.ReferenceClasses.CopyAssign(value);
			}
		}

		// Token: 0x17008C9B RID: 35995
		// (get) Token: 0x06024792 RID: 149394 RVA: 0x0035FD3C File Offset: 0x0035DF3C
		// (set) Token: 0x06024793 RID: 149395 RVA: 0x0035FD75 File Offset: 0x0035DF75
		public TArray<FSoftObjectPath> SoftReferenceData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._SoftReferenceData) == null)
				{
					result = (this._SoftReferenceData = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_SoftReferenceData, this));
				}
				return result;
			}
			set
			{
				this.SoftReferenceData.CopyAssign(value);
			}
		}

		// Token: 0x17008C9C RID: 35996
		// (get) Token: 0x06024794 RID: 149396 RVA: 0x0035FD84 File Offset: 0x0035DF84
		// (set) Token: 0x06024795 RID: 149397 RVA: 0x0035FDBD File Offset: 0x0035DFBD
		public TArray<FActorSerializeData> ActorsSerializeData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FActorSerializeData> result;
				if ((result = this._ActorsSerializeData) == null)
				{
					result = (this._ActorsSerializeData = new TArray<FActorSerializeData>(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_ActorsSerializeData, this));
				}
				return result;
			}
			set
			{
				this.ActorsSerializeData.CopyAssign(value);
			}
		}

		// Token: 0x17008C9D RID: 35997
		// (get) Token: 0x06024796 RID: 149398 RVA: 0x0035FDCC File Offset: 0x0035DFCC
		// (set) Token: 0x06024797 RID: 149399 RVA: 0x0035FE05 File Offset: 0x0035E005
		public TArray<FComponentSerializeData> ComponentsSerializeData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FComponentSerializeData> result;
				if ((result = this._ComponentsSerializeData) == null)
				{
					result = (this._ComponentsSerializeData = new TArray<FComponentSerializeData>(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_ComponentsSerializeData, this));
				}
				return result;
			}
			set
			{
				this.ComponentsSerializeData.CopyAssign(value);
			}
		}

		// Token: 0x17008C9E RID: 35998
		// (get) Token: 0x06024798 RID: 149400 RVA: 0x0035FE14 File Offset: 0x0035E014
		// (set) Token: 0x06024799 RID: 149401 RVA: 0x0035FE4D File Offset: 0x0035E04D
		public TArray<FNestedPrefabInstanceData> NestedPrefabInstancesData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNestedPrefabInstanceData> result;
				if ((result = this._NestedPrefabInstancesData) == null)
				{
					result = (this._NestedPrefabInstancesData = new TArray<FNestedPrefabInstanceData>(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_NestedPrefabInstancesData, this));
				}
				return result;
			}
			set
			{
				this.NestedPrefabInstancesData.CopyAssign(value);
			}
		}

		// Token: 0x17008C9F RID: 35999
		// (get) Token: 0x0602479A RID: 149402 RVA: 0x0035FE5C File Offset: 0x0035E05C
		// (set) Token: 0x0602479B RID: 149403 RVA: 0x0035FE95 File Offset: 0x0035E095
		public TArray<FNestedPrefabInstanceChain> NestedPrefabInstanceChains
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNestedPrefabInstanceChain> result;
				if ((result = this._NestedPrefabInstanceChains) == null)
				{
					result = (this._NestedPrefabInstanceChains = new TArray<FNestedPrefabInstanceChain>(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_NestedPrefabInstanceChains, this));
				}
				return result;
			}
			set
			{
				this.NestedPrefabInstanceChains.CopyAssign(value);
			}
		}

		// Token: 0x17008CA0 RID: 36000
		// (get) Token: 0x0602479C RID: 149404 RVA: 0x0035FEA4 File Offset: 0x0035E0A4
		// (set) Token: 0x0602479D RID: 149405 RVA: 0x0035FEDD File Offset: 0x0035E0DD
		public TArray<FVirtualObjectSerializeData> VirtualObjectsSerializeData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVirtualObjectSerializeData> result;
				if ((result = this._VirtualObjectsSerializeData) == null)
				{
					result = (this._VirtualObjectsSerializeData = new TArray<FVirtualObjectSerializeData>(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_VirtualObjectsSerializeData, this));
				}
				return result;
			}
			set
			{
				this.VirtualObjectsSerializeData.CopyAssign(value);
			}
		}

		// Token: 0x17008CA1 RID: 36001
		// (get) Token: 0x0602479E RID: 149406 RVA: 0x0035FEEC File Offset: 0x0035E0EC
		// (set) Token: 0x0602479F RID: 149407 RVA: 0x0035FF25 File Offset: 0x0035E125
		public TArray<FPropertyModificationData> PropertyModificationsSerializeData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPropertyModificationData> result;
				if ((result = this._PropertyModificationsSerializeData) == null)
				{
					result = (this._PropertyModificationsSerializeData = new TArray<FPropertyModificationData>(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_PropertyModificationsSerializeData, this));
				}
				return result;
			}
			set
			{
				this.PropertyModificationsSerializeData.CopyAssign(value);
			}
		}

		// Token: 0x060247A0 RID: 149408 RVA: 0x0035FF33 File Offset: 0x0035E133
		static UPrefabAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PrefabSystem.PrefabAsset");
		}

		// Token: 0x060247A1 RID: 149409 RVA: 0x0035FF41 File Offset: 0x0035E141
		protected UPrefabAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013977 RID: 80247
		public new const string __ObjectPath = "/Script/PrefabSystem.PrefabAsset";

		// Token: 0x04013978 RID: 80248
		private static IntPtr _ClassPtr;

		// Token: 0x04013979 RID: 80249
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401397A RID: 80250
		internal static int __PropertyOffset_NextFileID;

		// Token: 0x0401397B RID: 80251
		internal static int __PropertyOffset_Version;

		// Token: 0x0401397C RID: 80252
		internal static int __PropertyOffset_Guid;

		// Token: 0x0401397D RID: 80253
		internal static int __PropertyOffset_ReferenceAssets;

		// Token: 0x0401397E RID: 80254
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ReferenceAssets;

		// Token: 0x0401397F RID: 80255
		internal static int __PropertyOffset_ReferenceFNames;

		// Token: 0x04013980 RID: 80256
		[Nullable(2)]
		private TArray<FName> _ReferenceFNames;

		// Token: 0x04013981 RID: 80257
		internal static int __PropertyOffset_ReferenceClasses;

		// Token: 0x04013982 RID: 80258
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UClass> _ReferenceClasses;

		// Token: 0x04013983 RID: 80259
		internal static int __PropertyOffset_SoftReferenceData;

		// Token: 0x04013984 RID: 80260
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _SoftReferenceData;

		// Token: 0x04013985 RID: 80261
		internal static int __PropertyOffset_ActorsSerializeData;

		// Token: 0x04013986 RID: 80262
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FActorSerializeData> _ActorsSerializeData;

		// Token: 0x04013987 RID: 80263
		internal static int __PropertyOffset_ComponentsSerializeData;

		// Token: 0x04013988 RID: 80264
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FComponentSerializeData> _ComponentsSerializeData;

		// Token: 0x04013989 RID: 80265
		internal static int __PropertyOffset_NestedPrefabInstancesData;

		// Token: 0x0401398A RID: 80266
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNestedPrefabInstanceData> _NestedPrefabInstancesData;

		// Token: 0x0401398B RID: 80267
		internal static int __PropertyOffset_NestedPrefabInstanceChains;

		// Token: 0x0401398C RID: 80268
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNestedPrefabInstanceChain> _NestedPrefabInstanceChains;

		// Token: 0x0401398D RID: 80269
		internal static int __PropertyOffset_VirtualObjectsSerializeData;

		// Token: 0x0401398E RID: 80270
		[Nullable(2)]
		private TArray<FVirtualObjectSerializeData> _VirtualObjectsSerializeData;

		// Token: 0x0401398F RID: 80271
		internal static int __PropertyOffset_PropertyModificationsSerializeData;

		// Token: 0x04013990 RID: 80272
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPropertyModificationData> _PropertyModificationsSerializeData;
	}
}
