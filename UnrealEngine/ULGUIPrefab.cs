using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020AE RID: 8366
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPrefab")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class ULGUIPrefab : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F884 RID: 129156 RVA: 0x002EE011 File Offset: 0x002EC211
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPrefab._ClassPtr;
		}

		// Token: 0x0601F885 RID: 129157 RVA: 0x002EE020 File Offset: 0x002EC220
		public ULGUIPrefab() : this(BuiltinUtils.AllocNativeUObject(ULGUIPrefab.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F886 RID: 129158 RVA: 0x002EE048 File Offset: 0x002EC248
		public ULGUIPrefab(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPrefab.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C60 RID: 31840
		// (get) Token: 0x0601F887 RID: 129159 RVA: 0x002EE07C File Offset: 0x002EC27C
		// (set) Token: 0x0601F888 RID: 129160 RVA: 0x002EE0B5 File Offset: 0x002EC2B5
		public TArray<UObject> ReferenceAssetList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ReferenceAssetList) == null)
				{
					result = (this._ReferenceAssetList = new TArray<UObject>(base.NativePtr + (IntPtr)ULGUIPrefab.__PropertyOffset_ReferenceAssetList, this));
				}
				return result;
			}
			set
			{
				this.ReferenceAssetList.CopyAssign(value);
			}
		}

		// Token: 0x17007C61 RID: 31841
		// (get) Token: 0x0601F889 RID: 129161 RVA: 0x002EE0C4 File Offset: 0x002EC2C4
		// (set) Token: 0x0601F88A RID: 129162 RVA: 0x002EE0FD File Offset: 0x002EC2FD
		public TArray<string> ReferenceStringList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ReferenceStringList) == null)
				{
					result = (this._ReferenceStringList = new TArray<string>(base.NativePtr + (IntPtr)ULGUIPrefab.__PropertyOffset_ReferenceStringList, this));
				}
				return result;
			}
			set
			{
				this.ReferenceStringList.CopyAssign(value);
			}
		}

		// Token: 0x17007C62 RID: 31842
		// (get) Token: 0x0601F88B RID: 129163 RVA: 0x002EE10C File Offset: 0x002EC30C
		// (set) Token: 0x0601F88C RID: 129164 RVA: 0x002EE145 File Offset: 0x002EC345
		public TArray<FName> ReferenceNameList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ReferenceNameList) == null)
				{
					result = (this._ReferenceNameList = new TArray<FName>(base.NativePtr + (IntPtr)ULGUIPrefab.__PropertyOffset_ReferenceNameList, this));
				}
				return result;
			}
			set
			{
				this.ReferenceNameList.CopyAssign(value);
			}
		}

		// Token: 0x17007C63 RID: 31843
		// (get) Token: 0x0601F88D RID: 129165 RVA: 0x002EE154 File Offset: 0x002EC354
		// (set) Token: 0x0601F88E RID: 129166 RVA: 0x002EE18D File Offset: 0x002EC38D
		public TArray<FText> ReferenceTextList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FText> result;
				if ((result = this._ReferenceTextList) == null)
				{
					result = (this._ReferenceTextList = new TArray<FText>(base.NativePtr + (IntPtr)ULGUIPrefab.__PropertyOffset_ReferenceTextList, this));
				}
				return result;
			}
			set
			{
				this.ReferenceTextList.CopyAssign(value);
			}
		}

		// Token: 0x17007C64 RID: 31844
		// (get) Token: 0x0601F88F RID: 129167 RVA: 0x002EE19C File Offset: 0x002EC39C
		// (set) Token: 0x0601F890 RID: 129168 RVA: 0x002EE1D5 File Offset: 0x002EC3D5
		public TArray<UClass> ReferenceClassList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UClass> result;
				if ((result = this._ReferenceClassList) == null)
				{
					result = (this._ReferenceClassList = new TArray<UClass>(base.NativePtr + (IntPtr)ULGUIPrefab.__PropertyOffset_ReferenceClassList, this));
				}
				return result;
			}
			set
			{
				this.ReferenceClassList.CopyAssign(value);
			}
		}

		// Token: 0x17007C65 RID: 31845
		// (get) Token: 0x0601F891 RID: 129169 RVA: 0x002EE1E4 File Offset: 0x002EC3E4
		// (set) Token: 0x0601F892 RID: 129170 RVA: 0x002EE21D File Offset: 0x002EC41D
		public TArray<FSoftObjectPath> AllSoftObjectReferences
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._AllSoftObjectReferences) == null)
				{
					result = (this._AllSoftObjectReferences = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)ULGUIPrefab.__PropertyOffset_AllSoftObjectReferences, this));
				}
				return result;
			}
			set
			{
				this.AllSoftObjectReferences.CopyAssign(value);
			}
		}

		// Token: 0x17007C66 RID: 31846
		// (get) Token: 0x0601F893 RID: 129171 RVA: 0x002EE22B File Offset: 0x002EC42B
		// (set) Token: 0x0601F894 RID: 129172 RVA: 0x002EE23B File Offset: 0x002EC43B
		public unsafe ushort PrefabVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPrefab.__PropertyOffset_PrefabVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPrefab.__PropertyOffset_PrefabVersion) = (short)value;
			}
		}

		// Token: 0x17007C67 RID: 31847
		// (get) Token: 0x0601F895 RID: 129173 RVA: 0x002EE24C File Offset: 0x002EC44C
		// (set) Token: 0x0601F896 RID: 129174 RVA: 0x002EE25C File Offset: 0x002EC45C
		public unsafe ushort EngineMajorVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPrefab.__PropertyOffset_EngineMajorVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPrefab.__PropertyOffset_EngineMajorVersion) = (short)value;
			}
		}

		// Token: 0x17007C68 RID: 31848
		// (get) Token: 0x0601F897 RID: 129175 RVA: 0x002EE26D File Offset: 0x002EC46D
		// (set) Token: 0x0601F898 RID: 129176 RVA: 0x002EE27D File Offset: 0x002EC47D
		public unsafe ushort EngineMinorVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPrefab.__PropertyOffset_EngineMinorVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPrefab.__PropertyOffset_EngineMinorVersion) = (short)value;
			}
		}

		// Token: 0x17007C69 RID: 31849
		// (get) Token: 0x0601F899 RID: 129177 RVA: 0x002EE290 File Offset: 0x002EC490
		// (set) Token: 0x0601F89A RID: 129178 RVA: 0x002EE2C9 File Offset: 0x002EC4C9
		public TArray<byte> BinaryDataForBuild
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._BinaryDataForBuild) == null)
				{
					result = (this._BinaryDataForBuild = new TArray<byte>(base.NativePtr + (IntPtr)ULGUIPrefab.__PropertyOffset_BinaryDataForBuild, this));
				}
				return result;
			}
			set
			{
				this.BinaryDataForBuild.CopyAssign(value);
			}
		}

		// Token: 0x0601F89B RID: 129179 RVA: 0x002EE2D7 File Offset: 0x002EC4D7
		static ULGUIPrefab()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPrefab");
		}

		// Token: 0x0601F89C RID: 129180 RVA: 0x002EE2E5 File Offset: 0x002EC4E5
		protected ULGUIPrefab(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011056 RID: 69718
		public new const string __ObjectPath = "/Script/LGUI.LGUIPrefab";

		// Token: 0x04011057 RID: 69719
		private static IntPtr _ClassPtr;

		// Token: 0x04011058 RID: 69720
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011059 RID: 69721
		internal static int __PropertyOffset_ReferenceAssetList;

		// Token: 0x0401105A RID: 69722
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ReferenceAssetList;

		// Token: 0x0401105B RID: 69723
		internal static int __PropertyOffset_ReferenceStringList;

		// Token: 0x0401105C RID: 69724
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ReferenceStringList;

		// Token: 0x0401105D RID: 69725
		internal static int __PropertyOffset_ReferenceNameList;

		// Token: 0x0401105E RID: 69726
		[Nullable(2)]
		private TArray<FName> _ReferenceNameList;

		// Token: 0x0401105F RID: 69727
		internal static int __PropertyOffset_ReferenceTextList;

		// Token: 0x04011060 RID: 69728
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FText> _ReferenceTextList;

		// Token: 0x04011061 RID: 69729
		internal static int __PropertyOffset_ReferenceClassList;

		// Token: 0x04011062 RID: 69730
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UClass> _ReferenceClassList;

		// Token: 0x04011063 RID: 69731
		internal static int __PropertyOffset_AllSoftObjectReferences;

		// Token: 0x04011064 RID: 69732
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _AllSoftObjectReferences;

		// Token: 0x04011065 RID: 69733
		internal static int __PropertyOffset_PrefabVersion;

		// Token: 0x04011066 RID: 69734
		internal static int __PropertyOffset_EngineMajorVersion;

		// Token: 0x04011067 RID: 69735
		internal static int __PropertyOffset_EngineMinorVersion;

		// Token: 0x04011068 RID: 69736
		internal static int __PropertyOffset_BinaryDataForBuild;

		// Token: 0x04011069 RID: 69737
		[Nullable(2)]
		private TArray<byte> _BinaryDataForBuild;
	}
}
