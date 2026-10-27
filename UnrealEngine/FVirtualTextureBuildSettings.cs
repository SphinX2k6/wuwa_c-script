using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001233 RID: 4659
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/Engine.VirtualTextureBuildSettings")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FVirtualTextureBuildSettings : IEqualityOperators<FVirtualTextureBuildSettings, FVirtualTextureBuildSettings, bool>, IEquatable<FVirtualTextureBuildSettings>, IUnrealScriptStruct
	{
		// Token: 0x06011219 RID: 70169 RVA: 0x001922F0 File Offset: 0x001904F0
		public FVirtualTextureBuildSettings(int TileSize, int TileBorderSize, bool bEnableCompressCrunch, bool bEnableCompressZlib)
		{
			this.TileSize = TileSize;
			this.TileBorderSize = TileBorderSize;
			this.bEnableCompressCrunch = bEnableCompressCrunch;
			this.bEnableCompressZlib = bEnableCompressZlib;
		}

		// Token: 0x0601121A RID: 70170 RVA: 0x0019230F File Offset: 0x0019050F
		public static bool operator ==(FVirtualTextureBuildSettings left, FVirtualTextureBuildSettings right)
		{
			return left.TileSize == right.TileSize && left.TileBorderSize == right.TileBorderSize && left.bEnableCompressCrunch == right.bEnableCompressCrunch && left.bEnableCompressZlib == right.bEnableCompressZlib;
		}

		// Token: 0x0601121B RID: 70171 RVA: 0x0019234B File Offset: 0x0019054B
		public static bool operator !=(FVirtualTextureBuildSettings left, FVirtualTextureBuildSettings right)
		{
			return !(left == right);
		}

		// Token: 0x0601121C RID: 70172 RVA: 0x00192357 File Offset: 0x00190557
		public bool Equals(FVirtualTextureBuildSettings other)
		{
			return this == other;
		}

		// Token: 0x0601121D RID: 70173 RVA: 0x00192368 File Offset: 0x00190568
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FVirtualTextureBuildSettings)
			{
				FVirtualTextureBuildSettings other = (FVirtualTextureBuildSettings)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601121E RID: 70174 RVA: 0x0019238D File Offset: 0x0019058D
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int, bool, bool>(this.TileSize, this.TileBorderSize, this.bEnableCompressCrunch, this.bEnableCompressZlib);
		}

		// Token: 0x0601121F RID: 70175 RVA: 0x001923AC File Offset: 0x001905AC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVirtualTextureBuildSettings._ScriptStructPtr != 0) ? FVirtualTextureBuildSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.VirtualTextureBuildSettings", ref FVirtualTextureBuildSettings._ScriptStructPtr);
		}

		// Token: 0x040092AE RID: 37550
		[FieldOffset(0)]
		public int TileSize;

		// Token: 0x040092AF RID: 37551
		[FieldOffset(4)]
		public int TileBorderSize;

		// Token: 0x040092B0 RID: 37552
		[FieldOffset(8)]
		public bool bEnableCompressCrunch;

		// Token: 0x040092B1 RID: 37553
		[FieldOffset(9)]
		public bool bEnableCompressZlib;

		// Token: 0x040092B2 RID: 37554
		public const string __ObjectPath = "/Script/Engine.VirtualTextureBuildSettings";

		// Token: 0x040092B3 RID: 37555
		private static IntPtr _ScriptStructPtr;
	}
}
