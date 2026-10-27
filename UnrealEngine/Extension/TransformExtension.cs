using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Extension
{
	// Token: 0x02002AE5 RID: 10981
	public static class TransformExtension
	{
		// Token: 0x06028404 RID: 164868 RVA: 0x003D3AA5 File Offset: 0x003D1CA5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetRotation(this FTransform transform, FQuat Rotation)
		{
			transform.Rotation = Rotation;
		}

		// Token: 0x06028405 RID: 164869 RVA: 0x003D3AAE File Offset: 0x003D1CAE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static FQuat GetRotation(this FTransform transform)
		{
			return transform.Rotation;
		}

		// Token: 0x06028406 RID: 164870 RVA: 0x003D3AB6 File Offset: 0x003D1CB6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTranslation(this FTransform transform, FVector Translation)
		{
			transform.Translation = Translation;
		}

		// Token: 0x06028407 RID: 164871 RVA: 0x003D3ABF File Offset: 0x003D1CBF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static FVector GetTranslation(this FTransform transform)
		{
			return transform.Translation;
		}

		// Token: 0x06028408 RID: 164872 RVA: 0x003D3AC7 File Offset: 0x003D1CC7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetScale3D(this FTransform transform, FVector Scale3D)
		{
			transform.Scale3D = Scale3D;
		}

		// Token: 0x06028409 RID: 164873 RVA: 0x003D3AD0 File Offset: 0x003D1CD0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static FVector GetScale3D(this FTransform transform)
		{
			return transform.Scale3D;
		}

		// Token: 0x0602840A RID: 164874 RVA: 0x003D3AD8 File Offset: 0x003D1CD8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetRotation(this FTransformDouble transform, FQuat Rotation)
		{
			transform.Rotation = Rotation;
		}

		// Token: 0x0602840B RID: 164875 RVA: 0x003D3AE1 File Offset: 0x003D1CE1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static FQuat GetRotation(this FTransformDouble transform)
		{
			return transform.Rotation;
		}

		// Token: 0x0602840C RID: 164876 RVA: 0x003D3AE9 File Offset: 0x003D1CE9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTranslation(this FTransformDouble transform, FVectorDouble Translation)
		{
			transform.Translation = Translation;
		}

		// Token: 0x0602840D RID: 164877 RVA: 0x003D3AF2 File Offset: 0x003D1CF2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static FVectorDouble GetTranslation(this FTransformDouble transform)
		{
			return transform.Translation;
		}

		// Token: 0x0602840E RID: 164878 RVA: 0x003D3AFA File Offset: 0x003D1CFA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetScale3D(this FTransformDouble transform, FVector Scale3D)
		{
			transform.Scale3D = Scale3D;
		}

		// Token: 0x0602840F RID: 164879 RVA: 0x003D3B03 File Offset: 0x003D1D03
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static FVector GetScale3D(this FTransformDouble transform)
		{
			return transform.Scale3D;
		}
	}
}
