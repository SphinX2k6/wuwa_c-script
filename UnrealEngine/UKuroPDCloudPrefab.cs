using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B89 RID: 7049
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroPDCloudPrefab")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 440)]
	public class UKuroPDCloudPrefab : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601ABFC RID: 109564 RVA: 0x00276A80 File Offset: 0x00274C80
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPDCloudPrefab._ClassPtr;
		}

		// Token: 0x0601ABFD RID: 109565 RVA: 0x00276A8C File Offset: 0x00274C8C
		public UKuroPDCloudPrefab() : this(BuiltinUtils.AllocNativeUObject(UKuroPDCloudPrefab.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ABFE RID: 109566 RVA: 0x00276AB4 File Offset: 0x00274CB4
		public UKuroPDCloudPrefab(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPDCloudPrefab.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B9A RID: 27546
		// (get) Token: 0x0601ABFF RID: 109567 RVA: 0x00276AE8 File Offset: 0x00274CE8
		// (set) Token: 0x0601AC00 RID: 109568 RVA: 0x00276B21 File Offset: 0x00274D21
		public FCloudParameters CloudTop
		{
			get
			{
				base.FastCheckIsValid();
				FCloudParameters result;
				if ((result = this._CloudTop) == null)
				{
					result = (this._CloudTop = new FCloudParameters(base.NativePtr + (IntPtr)UKuroPDCloudPrefab.__PropertyOffset_CloudTop, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCloudParameters.StaticStruct(), base.NativePtr + (IntPtr)UKuroPDCloudPrefab.__PropertyOffset_CloudTop, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006B9B RID: 27547
		// (get) Token: 0x0601AC01 RID: 109569 RVA: 0x00276B44 File Offset: 0x00274D44
		// (set) Token: 0x0601AC02 RID: 109570 RVA: 0x00276B7D File Offset: 0x00274D7D
		public FCloudCover CloudCover
		{
			get
			{
				base.FastCheckIsValid();
				FCloudCover result;
				if ((result = this._CloudCover) == null)
				{
					result = (this._CloudCover = new FCloudCover(base.NativePtr + (IntPtr)UKuroPDCloudPrefab.__PropertyOffset_CloudCover, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCloudCover.StaticStruct(), base.NativePtr + (IntPtr)UKuroPDCloudPrefab.__PropertyOffset_CloudCover, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006B9C RID: 27548
		// (get) Token: 0x0601AC03 RID: 109571 RVA: 0x00276BA0 File Offset: 0x00274DA0
		// (set) Token: 0x0601AC04 RID: 109572 RVA: 0x00276BD9 File Offset: 0x00274DD9
		public FPOICloudParameters CloudBigShape
		{
			get
			{
				base.FastCheckIsValid();
				FPOICloudParameters result;
				if ((result = this._CloudBigShape) == null)
				{
					result = (this._CloudBigShape = new FPOICloudParameters(base.NativePtr + (IntPtr)UKuroPDCloudPrefab.__PropertyOffset_CloudBigShape, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPOICloudParameters.StaticStruct(), base.NativePtr + (IntPtr)UKuroPDCloudPrefab.__PropertyOffset_CloudBigShape, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006B9D RID: 27549
		// (get) Token: 0x0601AC05 RID: 109573 RVA: 0x00276BFC File Offset: 0x00274DFC
		// (set) Token: 0x0601AC06 RID: 109574 RVA: 0x00276C35 File Offset: 0x00274E35
		public FMountainParameters Mountain
		{
			get
			{
				base.FastCheckIsValid();
				FMountainParameters result;
				if ((result = this._Mountain) == null)
				{
					result = (this._Mountain = new FMountainParameters(base.NativePtr + (IntPtr)UKuroPDCloudPrefab.__PropertyOffset_Mountain, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMountainParameters.StaticStruct(), base.NativePtr + (IntPtr)UKuroPDCloudPrefab.__PropertyOffset_Mountain, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006B9E RID: 27550
		// (get) Token: 0x0601AC07 RID: 109575 RVA: 0x00276C58 File Offset: 0x00274E58
		// (set) Token: 0x0601AC08 RID: 109576 RVA: 0x00276C91 File Offset: 0x00274E91
		public FAnomaliesParameters CloudAnomalies
		{
			get
			{
				base.FastCheckIsValid();
				FAnomaliesParameters result;
				if ((result = this._CloudAnomalies) == null)
				{
					result = (this._CloudAnomalies = new FAnomaliesParameters(base.NativePtr + (IntPtr)UKuroPDCloudPrefab.__PropertyOffset_CloudAnomalies, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAnomaliesParameters.StaticStruct(), base.NativePtr + (IntPtr)UKuroPDCloudPrefab.__PropertyOffset_CloudAnomalies, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601AC09 RID: 109577 RVA: 0x00276CB2 File Offset: 0x00274EB2
		static UKuroPDCloudPrefab()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroPDCloudPrefab");
		}

		// Token: 0x0601AC0A RID: 109578 RVA: 0x00276CC0 File Offset: 0x00274EC0
		protected UKuroPDCloudPrefab(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E788 RID: 59272
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroPDCloudPrefab";

		// Token: 0x0400E789 RID: 59273
		private static IntPtr _ClassPtr;

		// Token: 0x0400E78A RID: 59274
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E78B RID: 59275
		internal static int __PropertyOffset_CloudTop;

		// Token: 0x0400E78C RID: 59276
		[Nullable(2)]
		private FCloudParameters _CloudTop;

		// Token: 0x0400E78D RID: 59277
		internal static int __PropertyOffset_CloudCover;

		// Token: 0x0400E78E RID: 59278
		[Nullable(2)]
		private FCloudCover _CloudCover;

		// Token: 0x0400E78F RID: 59279
		internal static int __PropertyOffset_CloudBigShape;

		// Token: 0x0400E790 RID: 59280
		[Nullable(2)]
		private FPOICloudParameters _CloudBigShape;

		// Token: 0x0400E791 RID: 59281
		internal static int __PropertyOffset_Mountain;

		// Token: 0x0400E792 RID: 59282
		[Nullable(2)]
		private FMountainParameters _Mountain;

		// Token: 0x0400E793 RID: 59283
		internal static int __PropertyOffset_CloudAnomalies;

		// Token: 0x0400E794 RID: 59284
		[Nullable(2)]
		private FAnomaliesParameters _CloudAnomalies;
	}
}
