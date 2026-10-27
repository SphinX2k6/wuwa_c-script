using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024AE RID: 9390
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NavigationSystem.RecastNavMeshDataChunk")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class URecastNavMeshDataChunk : UNavigationDataChunk, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602328E RID: 144014 RVA: 0x0034022D File Offset: 0x0033E42D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URecastNavMeshDataChunk._ClassPtr;
		}

		// Token: 0x0602328F RID: 144015 RVA: 0x0034023C File Offset: 0x0033E43C
		public URecastNavMeshDataChunk() : this(BuiltinUtils.AllocNativeUObject(URecastNavMeshDataChunk.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023290 RID: 144016 RVA: 0x00340264 File Offset: 0x0033E464
		public URecastNavMeshDataChunk(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URecastNavMeshDataChunk.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700872F RID: 34607
		// (get) Token: 0x06023291 RID: 144017 RVA: 0x00340298 File Offset: 0x0033E498
		// (set) Token: 0x06023292 RID: 144018 RVA: 0x003402D1 File Offset: 0x0033E4D1
		public TMap<FIntPoint, FWaterBasinThresholdRows> WaterBasinThresholds
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FIntPoint, FWaterBasinThresholdRows> result;
				if ((result = this._WaterBasinThresholds) == null)
				{
					result = (this._WaterBasinThresholds = new TMap<FIntPoint, FWaterBasinThresholdRows>(base.NativePtr + (IntPtr)URecastNavMeshDataChunk.__PropertyOffset_WaterBasinThresholds, this));
				}
				return result;
			}
			set
			{
				this.WaterBasinThresholds.CopyAssign(value);
			}
		}

		// Token: 0x06023293 RID: 144019 RVA: 0x003402DF File Offset: 0x0033E4DF
		static URecastNavMeshDataChunk()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.RecastNavMeshDataChunk");
		}

		// Token: 0x06023294 RID: 144020 RVA: 0x003402ED File Offset: 0x0033E4ED
		protected URecastNavMeshDataChunk(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012C70 RID: 76912
		public new const string __ObjectPath = "/Script/NavigationSystem.RecastNavMeshDataChunk";

		// Token: 0x04012C71 RID: 76913
		private static IntPtr _ClassPtr;

		// Token: 0x04012C72 RID: 76914
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012C73 RID: 76915
		internal static int __PropertyOffset_WaterBasinThresholds;

		// Token: 0x04012C74 RID: 76916
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FIntPoint, FWaterBasinThresholdRows> _WaterBasinThresholds;
	}
}
