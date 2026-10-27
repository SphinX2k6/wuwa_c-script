using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020B5 RID: 8373
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPrefabV2")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class ULGUIPrefabV2 : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F8C0 RID: 129216 RVA: 0x002EE607 File Offset: 0x002EC807
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPrefabV2._ClassPtr;
		}

		// Token: 0x0601F8C1 RID: 129217 RVA: 0x002EE614 File Offset: 0x002EC814
		public ULGUIPrefabV2() : this(BuiltinUtils.AllocNativeUObject(ULGUIPrefabV2.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F8C2 RID: 129218 RVA: 0x002EE63C File Offset: 0x002EC83C
		public ULGUIPrefabV2(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPrefabV2.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C6D RID: 31853
		// (get) Token: 0x0601F8C3 RID: 129219 RVA: 0x002EE670 File Offset: 0x002EC870
		// (set) Token: 0x0601F8C4 RID: 129220 RVA: 0x002EE6A9 File Offset: 0x002EC8A9
		public TArray<UObject> ReferenceAssetListForBuild
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ReferenceAssetListForBuild) == null)
				{
					result = (this._ReferenceAssetListForBuild = new TArray<UObject>(base.NativePtr + (IntPtr)ULGUIPrefabV2.__PropertyOffset_ReferenceAssetListForBuild, this));
				}
				return result;
			}
			set
			{
				this.ReferenceAssetListForBuild.CopyAssign(value);
			}
		}

		// Token: 0x17007C6E RID: 31854
		// (get) Token: 0x0601F8C5 RID: 129221 RVA: 0x002EE6B8 File Offset: 0x002EC8B8
		// (set) Token: 0x0601F8C6 RID: 129222 RVA: 0x002EE6F1 File Offset: 0x002EC8F1
		public TArray<UClass> ReferenceClassListForBuild
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UClass> result;
				if ((result = this._ReferenceClassListForBuild) == null)
				{
					result = (this._ReferenceClassListForBuild = new TArray<UClass>(base.NativePtr + (IntPtr)ULGUIPrefabV2.__PropertyOffset_ReferenceClassListForBuild, this));
				}
				return result;
			}
			set
			{
				this.ReferenceClassListForBuild.CopyAssign(value);
			}
		}

		// Token: 0x17007C6F RID: 31855
		// (get) Token: 0x0601F8C7 RID: 129223 RVA: 0x002EE700 File Offset: 0x002EC900
		// (set) Token: 0x0601F8C8 RID: 129224 RVA: 0x002EE739 File Offset: 0x002EC939
		public TArray<FName> ReferenceNameListForBuild
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ReferenceNameListForBuild) == null)
				{
					result = (this._ReferenceNameListForBuild = new TArray<FName>(base.NativePtr + (IntPtr)ULGUIPrefabV2.__PropertyOffset_ReferenceNameListForBuild, this));
				}
				return result;
			}
			set
			{
				this.ReferenceNameListForBuild.CopyAssign(value);
			}
		}

		// Token: 0x17007C70 RID: 31856
		// (get) Token: 0x0601F8C9 RID: 129225 RVA: 0x002EE747 File Offset: 0x002EC947
		// (set) Token: 0x0601F8CA RID: 129226 RVA: 0x002EE757 File Offset: 0x002EC957
		public unsafe EPrefabVersion PrefabVersion
		{
			get
			{
				return (EPrefabVersion)(*(base.NativePtr + (IntPtr)ULGUIPrefabV2.__PropertyOffset_PrefabVersion));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPrefabV2.__PropertyOffset_PrefabVersion) = (byte)value;
			}
		}

		// Token: 0x17007C71 RID: 31857
		// (get) Token: 0x0601F8CB RID: 129227 RVA: 0x002EE768 File Offset: 0x002EC968
		// (set) Token: 0x0601F8CC RID: 129228 RVA: 0x002EE77C File Offset: 0x002EC97C
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPrefabV2.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPrefabV2.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x17007C72 RID: 31858
		// (get) Token: 0x0601F8CD RID: 129229 RVA: 0x002EE794 File Offset: 0x002EC994
		// (set) Token: 0x0601F8CE RID: 129230 RVA: 0x002EE7CD File Offset: 0x002EC9CD
		public TArray<byte> BinaryDataForBuild
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._BinaryDataForBuild) == null)
				{
					result = (this._BinaryDataForBuild = new TArray<byte>(base.NativePtr + (IntPtr)ULGUIPrefabV2.__PropertyOffset_BinaryDataForBuild, this));
				}
				return result;
			}
			set
			{
				this.BinaryDataForBuild.CopyAssign(value);
			}
		}

		// Token: 0x0601F8CF RID: 129231 RVA: 0x002EE7DB File Offset: 0x002EC9DB
		[NullableContext(2)]
		public AActor LoadPrefabWithTransform(UObject WorldContextObject, USceneComponent InParent, bool bForceUseRuntimeData, FVector Location, FRotator Rotation, FVector Scale)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ULGUIPrefabV2.__LoadPrefabWithTransform_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (InParent != null) ? InParent.NativePtr : IntPtr.Zero, bForceUseRuntimeData, Location, Rotation, Scale));
		}

		// Token: 0x0601F8D0 RID: 129232 RVA: 0x002EE814 File Offset: 0x002ECA14
		[NullableContext(2)]
		public AActor LoadPrefab(UObject WorldContextObject, USceneComponent InParent, bool bForceUseRuntimeData, bool SetRelativeTransformToIdentity = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ULGUIPrefabV2.__LoadPrefab_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (InParent != null) ? InParent.NativePtr : IntPtr.Zero, bForceUseRuntimeData, SetRelativeTransformToIdentity));
		}

		// Token: 0x0601F8D1 RID: 129233
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadPrefabWithTransform_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr InParent, bool bForceUseRuntimeData, FVector Location, FRotator Rotation, FVector Scale);

		// Token: 0x0601F8D2 RID: 129234
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadPrefab_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr InParent, bool bForceUseRuntimeData, bool SetRelativeTransformToIdentity);

		// Token: 0x0601F8D3 RID: 129235 RVA: 0x002EE849 File Offset: 0x002ECA49
		static ULGUIPrefabV2()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPrefabV2");
		}

		// Token: 0x0601F8D4 RID: 129236 RVA: 0x002EE857 File Offset: 0x002ECA57
		protected ULGUIPrefabV2(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401107D RID: 69757
		public new const string __ObjectPath = "/Script/LGUI.LGUIPrefabV2";

		// Token: 0x0401107E RID: 69758
		private static IntPtr _ClassPtr;

		// Token: 0x0401107F RID: 69759
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011080 RID: 69760
		internal static int __PropertyOffset_ReferenceAssetListForBuild;

		// Token: 0x04011081 RID: 69761
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ReferenceAssetListForBuild;

		// Token: 0x04011082 RID: 69762
		internal static int __PropertyOffset_ReferenceClassListForBuild;

		// Token: 0x04011083 RID: 69763
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UClass> _ReferenceClassListForBuild;

		// Token: 0x04011084 RID: 69764
		internal static int __PropertyOffset_ReferenceNameListForBuild;

		// Token: 0x04011085 RID: 69765
		[Nullable(2)]
		private TArray<FName> _ReferenceNameListForBuild;

		// Token: 0x04011086 RID: 69766
		internal static int __PropertyOffset_PrefabVersion;

		// Token: 0x04011087 RID: 69767
		internal static int __PropertyOffset_Guid;

		// Token: 0x04011088 RID: 69768
		internal static int __PropertyOffset_BinaryDataForBuild;

		// Token: 0x04011089 RID: 69769
		[Nullable(2)]
		private TArray<byte> _BinaryDataForBuild;
	}
}
