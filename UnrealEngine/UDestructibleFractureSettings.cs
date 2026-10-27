using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000354 RID: 852
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ApexDestruction.DestructibleFractureSettings")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UDestructibleFractureSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002F52 RID: 12114 RVA: 0x0004870F File Offset: 0x0004690F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDestructibleFractureSettings._ClassPtr;
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x0004871C File Offset: 0x0004691C
		public UDestructibleFractureSettings() : this(BuiltinUtils.AllocNativeUObject(UDestructibleFractureSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x00048744 File Offset: 0x00046944
		public UDestructibleFractureSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDestructibleFractureSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06002F55 RID: 12117 RVA: 0x00048777 File Offset: 0x00046977
		// (set) Token: 0x06002F56 RID: 12118 RVA: 0x00048787 File Offset: 0x00046987
		public unsafe int CellSiteCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDestructibleFractureSettings.__PropertyOffset_CellSiteCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDestructibleFractureSettings.__PropertyOffset_CellSiteCount) = value;
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06002F57 RID: 12119 RVA: 0x00048798 File Offset: 0x00046998
		// (set) Token: 0x06002F58 RID: 12120 RVA: 0x000487D1 File Offset: 0x000469D1
		public FFractureMaterial FractureMaterialDesc
		{
			get
			{
				base.FastCheckIsValid();
				FFractureMaterial result;
				if ((result = this._FractureMaterialDesc) == null)
				{
					result = (this._FractureMaterialDesc = new FFractureMaterial(base.NativePtr + (IntPtr)UDestructibleFractureSettings.__PropertyOffset_FractureMaterialDesc, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFractureMaterial.StaticStruct(), base.NativePtr + (IntPtr)UDestructibleFractureSettings.__PropertyOffset_FractureMaterialDesc, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06002F59 RID: 12121 RVA: 0x000487F2 File Offset: 0x000469F2
		// (set) Token: 0x06002F5A RID: 12122 RVA: 0x00048802 File Offset: 0x00046A02
		public unsafe int RandomSeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDestructibleFractureSettings.__PropertyOffset_RandomSeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDestructibleFractureSettings.__PropertyOffset_RandomSeed) = value;
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06002F5B RID: 12123 RVA: 0x00048814 File Offset: 0x00046A14
		// (set) Token: 0x06002F5C RID: 12124 RVA: 0x0004884D File Offset: 0x00046A4D
		public TArray<FVector> VoronoiSites
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._VoronoiSites) == null)
				{
					result = (this._VoronoiSites = new TArray<FVector>(base.NativePtr + (IntPtr)UDestructibleFractureSettings.__PropertyOffset_VoronoiSites, this));
				}
				return result;
			}
			set
			{
				this.VoronoiSites.CopyAssign(value);
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06002F5D RID: 12125 RVA: 0x0004885B File Offset: 0x00046A5B
		// (set) Token: 0x06002F5E RID: 12126 RVA: 0x0004886B File Offset: 0x00046A6B
		public unsafe int OriginalSubmeshCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDestructibleFractureSettings.__PropertyOffset_OriginalSubmeshCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDestructibleFractureSettings.__PropertyOffset_OriginalSubmeshCount) = value;
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06002F5F RID: 12127 RVA: 0x0004887C File Offset: 0x00046A7C
		// (set) Token: 0x06002F60 RID: 12128 RVA: 0x000488B5 File Offset: 0x00046AB5
		public TArray<UMaterialInterface> Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UDestructibleFractureSettings.__PropertyOffset_Materials, this));
				}
				return result;
			}
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06002F61 RID: 12129 RVA: 0x000488C4 File Offset: 0x00046AC4
		// (set) Token: 0x06002F62 RID: 12130 RVA: 0x000488FD File Offset: 0x00046AFD
		public TArray<FDestructibleChunkParameters> ChunkParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FDestructibleChunkParameters> result;
				if ((result = this._ChunkParameters) == null)
				{
					result = (this._ChunkParameters = new TArray<FDestructibleChunkParameters>(base.NativePtr + (IntPtr)UDestructibleFractureSettings.__PropertyOffset_ChunkParameters, this));
				}
				return result;
			}
			set
			{
				this.ChunkParameters.CopyAssign(value);
			}
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x0004890B File Offset: 0x00046B0B
		static UDestructibleFractureSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ApexDestruction.DestructibleFractureSettings");
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x00048919 File Offset: 0x00046B19
		protected UDestructibleFractureSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001468 RID: 5224
		public new const string __ObjectPath = "/Script/ApexDestruction.DestructibleFractureSettings";

		// Token: 0x04001469 RID: 5225
		private static IntPtr _ClassPtr;

		// Token: 0x0400146A RID: 5226
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400146B RID: 5227
		internal static int __PropertyOffset_CellSiteCount;

		// Token: 0x0400146C RID: 5228
		internal static int __PropertyOffset_FractureMaterialDesc;

		// Token: 0x0400146D RID: 5229
		[Nullable(2)]
		private FFractureMaterial _FractureMaterialDesc;

		// Token: 0x0400146E RID: 5230
		internal static int __PropertyOffset_RandomSeed;

		// Token: 0x0400146F RID: 5231
		internal static int __PropertyOffset_VoronoiSites;

		// Token: 0x04001470 RID: 5232
		[Nullable(2)]
		private TArray<FVector> _VoronoiSites;

		// Token: 0x04001471 RID: 5233
		internal static int __PropertyOffset_OriginalSubmeshCount;

		// Token: 0x04001472 RID: 5234
		internal static int __PropertyOffset_Materials;

		// Token: 0x04001473 RID: 5235
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _Materials;

		// Token: 0x04001474 RID: 5236
		internal static int __PropertyOffset_ChunkParameters;

		// Token: 0x04001475 RID: 5237
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FDestructibleChunkParameters> _ChunkParameters;
	}
}
