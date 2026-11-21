using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B4 RID: 1716
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPrefab")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class ULGUIPrefab : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600935C RID: 37724 RVA: 0x000DDDFA File Offset: 0x000DBFFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPrefab._ClassPtr;
		}

		// Token: 0x0600935D RID: 37725 RVA: 0x000DDE08 File Offset: 0x000DC008
		public ULGUIPrefab() : this(BuiltinUtils.AllocNativeUObject(ULGUIPrefab.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600935E RID: 37726 RVA: 0x000DDE30 File Offset: 0x000DC030
		public ULGUIPrefab(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPrefab.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x0600935F RID: 37727 RVA: 0x000DDE64 File Offset: 0x000DC064
		// (set) Token: 0x06009360 RID: 37728 RVA: 0x000DDE9D File Offset: 0x000DC09D
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

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x06009361 RID: 37729 RVA: 0x000DDEAC File Offset: 0x000DC0AC
		// (set) Token: 0x06009362 RID: 37730 RVA: 0x000DDEE5 File Offset: 0x000DC0E5
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

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x06009363 RID: 37731 RVA: 0x000DDEF4 File Offset: 0x000DC0F4
		// (set) Token: 0x06009364 RID: 37732 RVA: 0x000DDF2D File Offset: 0x000DC12D
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

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x06009365 RID: 37733 RVA: 0x000DDF3C File Offset: 0x000DC13C
		// (set) Token: 0x06009366 RID: 37734 RVA: 0x000DDF75 File Offset: 0x000DC175
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

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x06009367 RID: 37735 RVA: 0x000DDF84 File Offset: 0x000DC184
		// (set) Token: 0x06009368 RID: 37736 RVA: 0x000DDFBD File Offset: 0x000DC1BD
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

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x06009369 RID: 37737 RVA: 0x000DDFCC File Offset: 0x000DC1CC
		// (set) Token: 0x0600936A RID: 37738 RVA: 0x000DE005 File Offset: 0x000DC205
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

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x0600936B RID: 37739 RVA: 0x000DE013 File Offset: 0x000DC213
		// (set) Token: 0x0600936C RID: 37740 RVA: 0x000DE023 File Offset: 0x000DC223
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

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x0600936D RID: 37741 RVA: 0x000DE034 File Offset: 0x000DC234
		// (set) Token: 0x0600936E RID: 37742 RVA: 0x000DE044 File Offset: 0x000DC244
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

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x0600936F RID: 37743 RVA: 0x000DE055 File Offset: 0x000DC255
		// (set) Token: 0x06009370 RID: 37744 RVA: 0x000DE065 File Offset: 0x000DC265
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

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x06009371 RID: 37745 RVA: 0x000DE078 File Offset: 0x000DC278
		// (set) Token: 0x06009372 RID: 37746 RVA: 0x000DE0B1 File Offset: 0x000DC2B1
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

		// Token: 0x06009373 RID: 37747 RVA: 0x000DE0BF File Offset: 0x000DC2BF
		static ULGUIPrefab()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPrefab");
		}

		// Token: 0x06009374 RID: 37748 RVA: 0x000DE0CD File Offset: 0x000DC2CD
		protected ULGUIPrefab(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400403D RID: 16445
		public new const string __ObjectPath = "/Script/LGUI.LGUIPrefab";

		// Token: 0x0400403E RID: 16446
		private static IntPtr _ClassPtr;

		// Token: 0x0400403F RID: 16447
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004040 RID: 16448
		internal static int __PropertyOffset_ReferenceAssetList;

		// Token: 0x04004041 RID: 16449
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ReferenceAssetList;

		// Token: 0x04004042 RID: 16450
		internal static int __PropertyOffset_ReferenceStringList;

		// Token: 0x04004043 RID: 16451
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ReferenceStringList;

		// Token: 0x04004044 RID: 16452
		internal static int __PropertyOffset_ReferenceNameList;

		// Token: 0x04004045 RID: 16453
		[Nullable(2)]
		private TArray<FName> _ReferenceNameList;

		// Token: 0x04004046 RID: 16454
		internal static int __PropertyOffset_ReferenceTextList;

		// Token: 0x04004047 RID: 16455
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FText> _ReferenceTextList;

		// Token: 0x04004048 RID: 16456
		internal static int __PropertyOffset_ReferenceClassList;

		// Token: 0x04004049 RID: 16457
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UClass> _ReferenceClassList;

		// Token: 0x0400404A RID: 16458
		internal static int __PropertyOffset_AllSoftObjectReferences;

		// Token: 0x0400404B RID: 16459
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _AllSoftObjectReferences;

		// Token: 0x0400404C RID: 16460
		internal static int __PropertyOffset_PrefabVersion;

		// Token: 0x0400404D RID: 16461
		internal static int __PropertyOffset_EngineMajorVersion;

		// Token: 0x0400404E RID: 16462
		internal static int __PropertyOffset_EngineMinorVersion;

		// Token: 0x0400404F RID: 16463
		internal static int __PropertyOffset_BinaryDataForBuild;

		// Token: 0x04004050 RID: 16464
		[Nullable(2)]
		private TArray<byte> _BinaryDataForBuild;
	}
}
