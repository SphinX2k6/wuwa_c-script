using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Extension
{
	// Token: 0x02000894 RID: 2196
	public static class TransformExtension
	{
		// Token: 0x0600BDB9 RID: 48569 RVA: 0x0012EDB5 File Offset: 0x0012CFB5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetRotation(this FTransform transform, FQuat Rotation)
		{
			transform.Rotation = Rotation;
		}

		// Token: 0x0600BDBA RID: 48570 RVA: 0x0012EDBE File Offset: 0x0012CFBE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static FQuat GetRotation(this FTransform transform)
		{
			return transform.Rotation;
		}

		// Token: 0x0600BDBB RID: 48571 RVA: 0x0012EDC6 File Offset: 0x0012CFC6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTranslation(this FTransform transform, FVector Translation)
		{
			transform.Translation = Translation;
		}

		// Token: 0x0600BDBC RID: 48572 RVA: 0x0012EDCF File Offset: 0x0012CFCF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static FVector GetTranslation(this FTransform transform)
		{
			return transform.Translation;
		}

		// Token: 0x0600BDBD RID: 48573 RVA: 0x0012EDD7 File Offset: 0x0012CFD7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetScale3D(this FTransform transform, FVector Scale3D)
		{
			transform.Scale3D = Scale3D;
		}

		// Token: 0x0600BDBE RID: 48574 RVA: 0x0012EDE0 File Offset: 0x0012CFE0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static FVector GetScale3D(this FTransform transform)
		{
			return transform.Scale3D;
		}

		// Token: 0x0600BDBF RID: 48575 RVA: 0x0012EDE8 File Offset: 0x0012CFE8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetRotation(this FTransformDouble transform, FQuat Rotation)
		{
			transform.Rotation = Rotation;
		}

		// Token: 0x0600BDC0 RID: 48576 RVA: 0x0012EDF1 File Offset: 0x0012CFF1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static FQuat GetRotation(this FTransformDouble transform)
		{
			return transform.Rotation;
		}

		// Token: 0x0600BDC1 RID: 48577 RVA: 0x0012EDF9 File Offset: 0x0012CFF9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTranslation(this FTransformDouble transform, FVectorDouble Translation)
		{
			transform.Translation = Translation;
		}

		// Token: 0x0600BDC2 RID: 48578 RVA: 0x0012EE02 File Offset: 0x0012D002
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static FVectorDouble GetTranslation(this FTransformDouble transform)
		{
			return transform.Translation;
		}

		// Token: 0x0600BDC3 RID: 48579 RVA: 0x0012EE0A File Offset: 0x0012D00A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetScale3D(this FTransformDouble transform, FVector Scale3D)
		{
			transform.Scale3D = Scale3D;
		}

		// Token: 0x0600BDC4 RID: 48580 RVA: 0x0012EE13 File Offset: 0x0012D013
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static FVector GetScale3D(this FTransformDouble transform)
		{
			return transform.Scale3D;
		}
	}
}
