using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001052 RID: 4178
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/Engine.PSOGeneratorConfigSingleRenderTarget")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FPSOGeneratorConfigSingleRenderTarget : IEqualityOperators<FPSOGeneratorConfigSingleRenderTarget, FPSOGeneratorConfigSingleRenderTarget, bool>, IEquatable<FPSOGeneratorConfigSingleRenderTarget>, IUnrealScriptStruct
	{
		// Token: 0x0600EDB9 RID: 60857 RVA: 0x00160DBF File Offset: 0x0015EFBF
		public FPSOGeneratorConfigSingleRenderTarget(TEnumAsByte<EPSOGeneratorPixelFormat> Format, uint Flags)
		{
			this.Format = Format;
			this.Flags = Flags;
		}

		// Token: 0x0600EDBA RID: 60858 RVA: 0x00160DCF File Offset: 0x0015EFCF
		public static bool operator ==(FPSOGeneratorConfigSingleRenderTarget left, FPSOGeneratorConfigSingleRenderTarget right)
		{
			return left.Format == right.Format && left.Flags == right.Flags;
		}

		// Token: 0x0600EDBB RID: 60859 RVA: 0x00160DF4 File Offset: 0x0015EFF4
		public static bool operator !=(FPSOGeneratorConfigSingleRenderTarget left, FPSOGeneratorConfigSingleRenderTarget right)
		{
			return !(left == right);
		}

		// Token: 0x0600EDBC RID: 60860 RVA: 0x00160E00 File Offset: 0x0015F000
		public bool Equals(FPSOGeneratorConfigSingleRenderTarget other)
		{
			return this == other;
		}

		// Token: 0x0600EDBD RID: 60861 RVA: 0x00160E10 File Offset: 0x0015F010
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FPSOGeneratorConfigSingleRenderTarget)
			{
				FPSOGeneratorConfigSingleRenderTarget other = (FPSOGeneratorConfigSingleRenderTarget)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600EDBE RID: 60862 RVA: 0x00160E35 File Offset: 0x0015F035
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<EPSOGeneratorPixelFormat>, uint>(this.Format, this.Flags);
		}

		// Token: 0x0600EDBF RID: 60863 RVA: 0x00160E48 File Offset: 0x0015F048
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOGeneratorConfigSingleRenderTarget._ScriptStructPtr != 0) ? FPSOGeneratorConfigSingleRenderTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOGeneratorConfigSingleRenderTarget", ref FPSOGeneratorConfigSingleRenderTarget._ScriptStructPtr);
		}

		// Token: 0x040080C4 RID: 32964
		[FieldOffset(0)]
		public TEnumAsByte<EPSOGeneratorPixelFormat> Format;

		// Token: 0x040080C5 RID: 32965
		[FieldOffset(4)]
		public uint Flags;

		// Token: 0x040080C6 RID: 32966
		public const string __ObjectPath = "/Script/Engine.PSOGeneratorConfigSingleRenderTarget";

		// Token: 0x040080C7 RID: 32967
		private static IntPtr _ScriptStructPtr;
	}
}
