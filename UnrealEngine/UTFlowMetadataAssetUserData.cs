using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002911 RID: 10513
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TFlow.TFlowMetadataAssetUserData")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UTFlowMetadataAssetUserData : UAssetUserData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026F8B RID: 159627 RVA: 0x003B702E File Offset: 0x003B522E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTFlowMetadataAssetUserData._ClassPtr;
		}

		// Token: 0x06026F8C RID: 159628 RVA: 0x003B703C File Offset: 0x003B523C
		public UTFlowMetadataAssetUserData() : this(BuiltinUtils.AllocNativeUObject(UTFlowMetadataAssetUserData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026F8D RID: 159629 RVA: 0x003B7064 File Offset: 0x003B5264
		public UTFlowMetadataAssetUserData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTFlowMetadataAssetUserData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700960E RID: 38414
		// (get) Token: 0x06026F8E RID: 159630 RVA: 0x003B7098 File Offset: 0x003B5298
		// (set) Token: 0x06026F8F RID: 159631 RVA: 0x003B70D1 File Offset: 0x003B52D1
		public TMap<FName, string> MetaData
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, string> result;
				if ((result = this._MetaData) == null)
				{
					result = (this._MetaData = new TMap<FName, string>(base.NativePtr + (IntPtr)UTFlowMetadataAssetUserData.__PropertyOffset_MetaData, this));
				}
				return result;
			}
			set
			{
				this.MetaData.CopyAssign(value);
			}
		}

		// Token: 0x06026F90 RID: 159632 RVA: 0x003B70DF File Offset: 0x003B52DF
		static UTFlowMetadataAssetUserData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TFlow.TFlowMetadataAssetUserData");
		}

		// Token: 0x06026F91 RID: 159633 RVA: 0x003B70ED File Offset: 0x003B52ED
		protected UTFlowMetadataAssetUserData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015647 RID: 87623
		public new const string __ObjectPath = "/Script/TFlow.TFlowMetadataAssetUserData";

		// Token: 0x04015648 RID: 87624
		private static IntPtr _ClassPtr;

		// Token: 0x04015649 RID: 87625
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401564A RID: 87626
		internal static int __PropertyOffset_MetaData;

		// Token: 0x0401564B RID: 87627
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, string> _MetaData;
	}
}
