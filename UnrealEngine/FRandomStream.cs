using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000039 RID: 57
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/CoreUObject.RandomStream")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FRandomStream : IEquatable<FRandomStream>, IEqualityOperators<FRandomStream, FRandomStream, bool>, IUnrealScriptStruct
	{
		// Token: 0x060003E4 RID: 996 RVA: 0x0000A8C5 File Offset: 0x00008AC5
		public FRandomStream()
		{
			this.InitialSeed = 0;
			this.Seed = 0U;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000A8D5 File Offset: 0x00008AD5
		public FRandomStream(int inSeed)
		{
			this.InitialSeed = inSeed;
			this.Seed = (uint)inSeed;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000A8E5 File Offset: 0x00008AE5
		public FRandomStream(FName inName)
		{
			this = default(FRandomStream);
			this.Initialize(inName);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000A8F5 File Offset: 0x00008AF5
		public void Initialize(int inSeed)
		{
			this.InitialSeed = inSeed;
			this.Seed = (uint)inSeed;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000A905 File Offset: 0x00008B05
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

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000A941 File Offset: 0x00008B41
		public void Reset()
		{
			this.Seed = (uint)this.InitialSeed;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000A94F File Offset: 0x00008B4F
		public int GetInitialSeed()
		{
			return this.InitialSeed;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000A957 File Offset: 0x00008B57
		public void GenerateNewSeed()
		{
			this.Initialize(new Random().Next());
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000A969 File Offset: 0x00008B69
		public float GetFraction()
		{
			this.MutateSeed();
			return BitConverter.UInt32BitsToSingle(1065353216U | this.Seed >> 9) - 1f;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000A98B File Offset: 0x00008B8B
		public uint GetUnsignedInt()
		{
			this.MutateSeed();
			return this.Seed;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000A99C File Offset: 0x00008B9C
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

		// Token: 0x060003EF RID: 1007 RVA: 0x0000AA13 File Offset: 0x00008C13
		public int GetCurrentSeed()
		{
			return (int)this.Seed;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000AA1B File Offset: 0x00008C1B
		public float FRand()
		{
			return this.GetFraction();
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000AA23 File Offset: 0x00008C23
		public int RandHelper(int a)
		{
			if (a <= 0)
			{
				return 0;
			}
			return (int)(this.GetFraction() * (float)a);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000AA35 File Offset: 0x00008C35
		public int RandRange(int min, int max)
		{
			return min + this.RandHelper(max - min + 1);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000AA44 File Offset: 0x00008C44
		public float FRandRange(float min, float max)
		{
			return min + (max - min) * this.FRand();
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000AA52 File Offset: 0x00008C52
		public FVector VRand()
		{
			return this.GetUnitVector();
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000AA5C File Offset: 0x00008C5C
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

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000AB10 File Offset: 0x00008D10
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

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000ABFA File Offset: 0x00008DFA
		[NullableContext(1)]
		public bool ExportTextItem(out string valueStr, FRandomStream defaultValue, UObject parent, int portFlags, UObject exportRootScope)
		{
			valueStr = this.ToString();
			return true;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000AC0C File Offset: 0x00008E0C
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

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000AC68 File Offset: 0x00008E68
		private void MutateSeed()
		{
			this.Seed = this.Seed * 196314165U + 907633515U;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000AC82 File Offset: 0x00008E82
		public static bool operator ==(FRandomStream left, FRandomStream right)
		{
			return left.InitialSeed == right.InitialSeed && left.Seed == right.Seed;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000ACA2 File Offset: 0x00008EA2
		public static bool operator !=(FRandomStream left, FRandomStream right)
		{
			return !(left == right);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000ACAE File Offset: 0x00008EAE
		public bool Equals(FRandomStream other)
		{
			return this == other;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000ACBC File Offset: 0x00008EBC
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

		// Token: 0x060003FE RID: 1022 RVA: 0x0000ACE1 File Offset: 0x00008EE1
		public override int GetHashCode()
		{
			return HashCode.Combine<int, uint>(this.InitialSeed, this.Seed);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000ACF4 File Offset: 0x00008EF4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRandomStream._ScriptStructPtr != 0) ? FRandomStream._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.RandomStream", ref FRandomStream._ScriptStructPtr);
		}

		// Token: 0x040000E6 RID: 230
		[FieldOffset(0)]
		private int InitialSeed;

		// Token: 0x040000E7 RID: 231
		[FieldOffset(4)]
		private uint Seed;

		// Token: 0x040000E8 RID: 232
		public const string __ObjectPath = "/Script/CoreUObject.RandomStream";

		// Token: 0x040000E9 RID: 233
		private static IntPtr _ScriptStructPtr;
	}
}
