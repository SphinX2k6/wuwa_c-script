using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002125 RID: 8485
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIAudioDataAsset")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UUIAudioDataAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FEAD RID: 130733 RVA: 0x002F78C7 File Offset: 0x002F5AC7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIAudioDataAsset._ClassPtr;
		}

		// Token: 0x0601FEAE RID: 130734 RVA: 0x002F78D4 File Offset: 0x002F5AD4
		public UUIAudioDataAsset() : this(BuiltinUtils.AllocNativeUObject(UUIAudioDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FEAF RID: 130735 RVA: 0x002F78FC File Offset: 0x002F5AFC
		public UUIAudioDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIAudioDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007D7A RID: 32122
		// (get) Token: 0x0601FEB0 RID: 130736 RVA: 0x002F7930 File Offset: 0x002F5B30
		// (set) Token: 0x0601FEB1 RID: 130737 RVA: 0x002F7969 File Offset: 0x002F5B69
		public TMap<string, FUIAudioDataAssetInfo> RelativePathToAudioDataAssetInfo
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FUIAudioDataAssetInfo> result;
				if ((result = this._RelativePathToAudioDataAssetInfo) == null)
				{
					result = (this._RelativePathToAudioDataAssetInfo = new TMap<string, FUIAudioDataAssetInfo>(base.NativePtr + (IntPtr)UUIAudioDataAsset.__PropertyOffset_RelativePathToAudioDataAssetInfo, this));
				}
				return result;
			}
			set
			{
				this.RelativePathToAudioDataAssetInfo.CopyAssign(value);
			}
		}

		// Token: 0x0601FEB2 RID: 130738 RVA: 0x002F7977 File Offset: 0x002F5B77
		static UUIAudioDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIAudioDataAsset");
		}

		// Token: 0x0601FEB3 RID: 130739 RVA: 0x002F7985 File Offset: 0x002F5B85
		protected UUIAudioDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011320 RID: 70432
		public new const string __ObjectPath = "/Script/LGUI.UIAudioDataAsset";

		// Token: 0x04011321 RID: 70433
		private static IntPtr _ClassPtr;

		// Token: 0x04011322 RID: 70434
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011323 RID: 70435
		internal static int __PropertyOffset_RelativePathToAudioDataAssetInfo;

		// Token: 0x04011324 RID: 70436
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FUIAudioDataAssetInfo> _RelativePathToAudioDataAssetInfo;
	}
}
