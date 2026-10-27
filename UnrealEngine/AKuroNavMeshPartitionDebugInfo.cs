using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002632 RID: 9778
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PathFindModule.KuroNavMeshPartitionDebugInfo")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class AKuroNavMeshPartitionDebugInfo : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060245CF RID: 148943 RVA: 0x0035D64F File Offset: 0x0035B84F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroNavMeshPartitionDebugInfo._ClassPtr;
		}

		// Token: 0x060245D0 RID: 148944 RVA: 0x0035D65C File Offset: 0x0035B85C
		public AKuroNavMeshPartitionDebugInfo() : this(BuiltinUtils.AllocNativeUObject(AKuroNavMeshPartitionDebugInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060245D1 RID: 148945 RVA: 0x0035D684 File Offset: 0x0035B884
		public AKuroNavMeshPartitionDebugInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroNavMeshPartitionDebugInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008C1E RID: 35870
		// (get) Token: 0x060245D2 RID: 148946 RVA: 0x0035D6B8 File Offset: 0x0035B8B8
		// (set) Token: 0x060245D3 RID: 148947 RVA: 0x0035D6F1 File Offset: 0x0035B8F1
		public TMap<FName, FMapNavMeshDataLayerInfo> DataLayerLabel2InfoMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FMapNavMeshDataLayerInfo> result;
				if ((result = this._DataLayerLabel2InfoMap) == null)
				{
					result = (this._DataLayerLabel2InfoMap = new TMap<FName, FMapNavMeshDataLayerInfo>(base.NativePtr + (IntPtr)AKuroNavMeshPartitionDebugInfo.__PropertyOffset_DataLayerLabel2InfoMap, this));
				}
				return result;
			}
			set
			{
				this.DataLayerLabel2InfoMap.CopyAssign(value);
			}
		}

		// Token: 0x060245D4 RID: 148948 RVA: 0x0035D6FF File Offset: 0x0035B8FF
		static AKuroNavMeshPartitionDebugInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PathFindModule.KuroNavMeshPartitionDebugInfo");
		}

		// Token: 0x060245D5 RID: 148949 RVA: 0x0035D70D File Offset: 0x0035B90D
		protected AKuroNavMeshPartitionDebugInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013828 RID: 79912
		public new const string __ObjectPath = "/Script/PathFindModule.KuroNavMeshPartitionDebugInfo";

		// Token: 0x04013829 RID: 79913
		private static IntPtr _ClassPtr;

		// Token: 0x0401382A RID: 79914
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401382B RID: 79915
		internal static int __PropertyOffset_DataLayerLabel2InfoMap;

		// Token: 0x0401382C RID: 79916
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FMapNavMeshDataLayerInfo> _DataLayerLabel2InfoMap;
	}
}
