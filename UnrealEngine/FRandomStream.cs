using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200001E RID: 30
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/CoreUObject.RandomStream")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FRandomStream : IEquatable<FRandomStream>, IEqualityOperators<FRandomStream, FRandomStream, bool>, IUnrealScriptStruct
	{
		// Token: 0x06000369 RID: 873 RVA: 0x00007131 File Offset: 0x00005331
		public FRandomStream()
		{
			this.InitialSeed = 0;
			this.Seed = 0U;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00007141 File Offset: 0x00005341
		public FRandomStream(int inSeed)
		{
			this.InitialSeed = inSeed;
			this.Seed = (uint)inSeed;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00007151 File Offset: 0x00005351
		public FRandomStream(FName inName)
		{
			this = default(FRandomStream);
			this.Initialize(inName);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00007161 File Offset: 0x00005361
		public void Initialize(int inSeed)
		{
			this.InitialSeed = inSeed;
			this.Seed = (uint)inSeed;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00007171 File Offset: 0x00005371
		public void Initialize(FName inName)
		{
			if (!inName.IsNone())
			{
				this.InitialSeed = inName.ToString().GetHashCode();
			}
			else
			{
				this.InitialSeed = Environment.TickCount;
			}
			this.Seed = (uint)this.InitialSeed;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000071AD File Offset: 0x000053AD
		public void Reset()
		{
			this.Seed = (uint)this.InitialSeed;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000071BB File Offset: 0x000053BB
		public int GetInitialSeed()
		{
			return this.InitialSeed;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000071C3 File Offset: 0x000053C3
		public void GenerateNewSeed()
		{
			this.Initialize(new Random().Next());
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000071D5 File Offset: 0x000053D5
		public float GetFraction()
		{
			this.MutateSeed();
			return BitConverter.UInt32BitsToSingle(1065353216U | this.Seed >> 9) - 1f;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000071F7 File Offset: 0x000053F7
		public uint GetUnsignedInt()
		{
			this.MutateSeed();
			return this.Seed;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00007208 File Offset: 0x00005408
		public FVector GetUnitVector()
		{
			FVector fvector;
			float num;
			do
			{
				fvector.X = this.GetFraction() * 2f - 1f;
				fvector.Y = this.GetFraction() * 2f - 1f;
				fvector.Z = this.GetFraction() * 2f - 1f;
				num = fvector.SizeSquared();
			}
			while (num > 1f || num < 0.0001f);
			return fvector.GetUnsafeNormal();
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000727F File Offset: 0x0000547F
		public int GetCurrentSeed()
		{
			return (int)this.Seed;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00007287 File Offset: 0x00005487
		public float FRand()
		{
			return this.GetFraction();
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000728F File Offset: 0x0000548F
		public int RandHelper(int a)
		{
			if (a <= 0)
			{
				return 0;
			}
			return (int)(this.GetFraction() * (float)a);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000072A1 File Offset: 0x000054A1
		public int RandRange(int min, int max)
		{
			return min + this.RandHelper(max - min + 1);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000072B0 File Offset: 0x000054B0
		public float FRandRange(float min, float max)
		{
			return min + (max - min) * this.FRand();
		}

		// Token: 0x06000379 RID: 889 RVA: 0x000072BE File Offset: 0x000054BE
		public FVector VRand()
		{
			return this.GetUnitVector();
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000072C8 File Offset: 0x000054C8
		public FVector VRandCone(FVector dir, float coneHalfAngleRad)
		{
			if (coneHalfAngleRad <= 0f)
			{
				return dir.GetSafeNormal(1E-08f);
			}
			float num = this.FRand();
			float num2 = this.FRand();
			float num3 = 6.2831855f * num;
			float num4 = FMath.Acos(2f * num2 - 1f);
			num4 %= coneHalfAngleRad;
			FRotator frotator = dir.Rotation();
			FMatrix fmatrix = FRotationMatrix.Make(frotator);
			FVector unitAxis = fmatrix.GetUnitAxis(EAxis.X);
			FVector unitAxis2 = fmatrix.GetUnitAxis(EAxis.Y);
			return dir.RotateAngleAxis(num4 * 180f / 3.1415927f, unitAxis2).RotateAngleAxis(num3 * 180f / 3.1415927f, unitAxis).GetSafeNormal(1E-08f);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000737C File Offset: 0x0000557C
		public FVector VRandCone(FVector dir, float horizontalConeHalfAngleRad, float verticalConeHalfAngleRad)
		{
			if (horizontalConeHalfAngleRad <= 0f || verticalConeHalfAngleRad <= 0f)
			{
				return dir.GetSafeNormal(1E-08f);
			}
			float num = this.FRand();
			float num2 = this.FRand();
			float num3 = 6.2831855f * num;
			float num4 = FMath.Acos(2f * num2 - 1f);
			float num5 = FMath.Cos(num3);
			float num6 = FMath.Sin(num3);
			float num7 = MathF.Sqrt(1f / (num5 * num5 / (verticalConeHalfAngleRad * verticalConeHalfAngleRad) + num6 * num6 / (horizontalConeHalfAngleRad * horizontalConeHalfAngleRad)));
			num4 %= num7;
			FRotator frotator = dir.Rotation();
			FMatrix fmatrix = FRotationMatrix.Make(frotator);
			FVector unitAxis = fmatrix.GetUnitAxis(EAxis.X);
			FVector unitAxis2 = fmatrix.GetUnitAxis(EAxis.Y);
			return dir.RotateAngleAxis(num4 * 180f / 3.1415927f, unitAxis2).RotateAngleAxis(num3 * 180f / 3.1415927f, unitAxis).GetSafeNormal(1E-08f);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00007466 File Offset: 0x00005666
		[NullableContext(1)]
		public bool ExportTextItem(out string valueStr, FRandomStream defaultValue, UObject parent, int portFlags, UObject exportRootScope)
		{
			valueStr = this.ToString();
			return true;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00007478 File Offset: 0x00005678
		[NullableContext(1)]
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 2);
			defaultInterpolatedStringHandler.AppendLiteral("FRandomStream(InitialSeed=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.InitialSeed);
			defaultInterpolatedStringHandler.AppendLiteral(", Seed=");
			defaultInterpolatedStringHandler.AppendFormatted<uint>(this.Seed);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000074D4 File Offset: 0x000056D4
		private void MutateSeed()
		{
			this.Seed = this.Seed * 196314165U + 907633515U;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x000074EE File Offset: 0x000056EE
		public static bool operator ==(FRandomStream left, FRandomStream right)
		{
			return left.InitialSeed == right.InitialSeed && left.Seed == right.Seed;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000750E File Offset: 0x0000570E
		public static bool operator !=(FRandomStream left, FRandomStream right)
		{
			return !(left == right);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000751A File Offset: 0x0000571A
		public bool Equals(FRandomStream other)
		{
			return this == other;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00007528 File Offset: 0x00005728
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FRandomStream)
			{
				FRandomStream other = (FRandomStream)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000754D File Offset: 0x0000574D
		public override int GetHashCode()
		{
			return HashCode.Combine<int, uint>(this.InitialSeed, this.Seed);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00007560 File Offset: 0x00005760
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRandomStream._ScriptStructPtr != 0) ? FRandomStream._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.RandomStream", ref FRandomStream._ScriptStructPtr);
		}

		// Token: 0x0400009F RID: 159
		[FieldOffset(0)]
		private int InitialSeed;

		// Token: 0x040000A0 RID: 160
		[FieldOffset(4)]
		private uint Seed;

		// Token: 0x040000A1 RID: 161
		public const string __ObjectPath = "/Script/CoreUObject.RandomStream";

		// Token: 0x040000A2 RID: 162
		private static IntPtr _ScriptStructPtr;
	}
}
