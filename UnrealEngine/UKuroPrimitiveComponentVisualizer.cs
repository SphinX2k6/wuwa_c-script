using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200184C RID: 6220
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroPrimitiveComponentVisualizer")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public abstract class UKuroPrimitiveComponentVisualizer : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016ED0 RID: 93904 RVA: 0x00217386 File Offset: 0x00215586
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPrimitiveComponentVisualizer._ClassPtr;
		}

		// Token: 0x06016ED1 RID: 93905 RVA: 0x00217392 File Offset: 0x00215592
		public void DrawWireSphere(in FVector Base, float Radius, in FLinearColor Color, float Thickness = 0f, int NumSides = 16, byte DepthPriority = 0)
		{
			UKuroPrimitiveComponentVisualizer.__DrawWireSphere_Internal(base.NativePtr, Base, Radius, Color, Thickness, NumSides, DepthPriority);
		}

		// Token: 0x06016ED2 RID: 93906 RVA: 0x002173A8 File Offset: 0x002155A8
		public void DrawLine(in FVector Start, in FVector End, in FLinearColor Color, float Thickness = 0f, bool bScreenSpace = false, byte DepthPriority = 0)
		{
			UKuroPrimitiveComponentVisualizer.__DrawLine_Internal(base.NativePtr, Start, End, Color, Thickness, bScreenSpace, DepthPriority);
		}

		// Token: 0x06016ED3 RID: 93907 RVA: 0x002173C0 File Offset: 0x002155C0
		public void DrawDashedLine(in FVector Start, in FVector End, in FLinearColor? Color = null, float DashSize = 50f, float Thickness = 0f, bool bScreenSpace = false, int MaxDashes = 40, byte DepthPriority = 0, float DepthBias = 0f)
		{
			IntPtr nativePtr = base.NativePtr;
			FLinearColor? flinearColor = Color;
			FLinearColor flinearColor2;
			FLinearColor flinearColor3;
			if (flinearColor == null)
			{
				flinearColor2 = new FLinearColor
				{
					R = 0f,
					G = 1f,
					B = 0f,
					A = 1f
				};
				flinearColor3 = flinearColor2;
			}
			else
			{
				flinearColor3 = flinearColor.GetValueOrDefault();
			}
			flinearColor2 = flinearColor3;
			UKuroPrimitiveComponentVisualizer.__DrawDashedLine_Internal(nativePtr, Start, End, flinearColor2, DashSize, Thickness, bScreenSpace, MaxDashes, DepthPriority, DepthBias);
		}

		// Token: 0x06016ED4 RID: 93908 RVA: 0x0021743C File Offset: 0x0021563C
		public void DrawCircle(in FVector Origin, float Radius = 100f, in FLinearColor? Color = null, float Thickness = 0f, in FVector? Normal = null, int LineSegments = 16, byte DepthPriority = 0)
		{
			IntPtr nativePtr = base.NativePtr;
			FLinearColor? flinearColor = Color;
			FLinearColor flinearColor2;
			FLinearColor flinearColor3;
			if (flinearColor == null)
			{
				flinearColor2 = new FLinearColor
				{
					R = 1f,
					G = 1f,
					B = 1f,
					A = 1f
				};
				flinearColor3 = flinearColor2;
			}
			else
			{
				flinearColor3 = flinearColor.GetValueOrDefault();
			}
			flinearColor2 = flinearColor3;
			FVector fvector = Normal ?? new FVector(0f, 0f, 1f);
			UKuroPrimitiveComponentVisualizer.__DrawCircle_Internal(nativePtr, Origin, Radius, flinearColor2, Thickness, fvector, LineSegments, DepthPriority);
		}

		// Token: 0x06016ED5 RID: 93909 RVA: 0x002174E1 File Offset: 0x002156E1
		public void DrawArrow(in FVector Start, in FVector End, in FLinearColor Color, float ArrowSize = 10f, float Thickness = 3f, bool bScreenSpace = false, byte DepthPriority = 0)
		{
			UKuroPrimitiveComponentVisualizer.__DrawArrow_Internal(base.NativePtr, Start, End, Color, ArrowSize, Thickness, bScreenSpace, DepthPriority);
		}

		// Token: 0x06016ED6 RID: 93910 RVA: 0x002174FC File Offset: 0x002156FC
		public void DrawArc(in FVector Base, float Angle, float Radius, in FVector Direction, in FLinearColor Color, float Thickness, in FVector Normal, int Sections, float InnerRadius = 0f, bool bDrawSides = false, byte DepthPriority = 0)
		{
			UKuroPrimitiveComponentVisualizer.__DrawArc_Internal(base.NativePtr, Base, Angle, Radius, Direction, Color, Thickness, Normal, Sections, InnerRadius, bDrawSides, DepthPriority);
		}

		// Token: 0x06016ED7 RID: 93911
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawWireSphere_Internal(IntPtr @this, in FVector Base, float Radius, in FLinearColor Color, float Thickness, int NumSides, byte DepthPriority);

		// Token: 0x06016ED8 RID: 93912
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawLine_Internal(IntPtr @this, in FVector Start, in FVector End, in FLinearColor Color, float Thickness, bool bScreenSpace, byte DepthPriority);

		// Token: 0x06016ED9 RID: 93913
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDashedLine_Internal(IntPtr @this, in FVector Start, in FVector End, in FLinearColor Color, float DashSize, float Thickness, bool bScreenSpace, int MaxDashes, byte DepthPriority, float DepthBias);

		// Token: 0x06016EDA RID: 93914
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawCircle_Internal(IntPtr @this, in FVector Origin, float Radius, in FLinearColor Color, float Thickness, in FVector Normal, int LineSegments, byte DepthPriority);

		// Token: 0x06016EDB RID: 93915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawArrow_Internal(IntPtr @this, in FVector Start, in FVector End, in FLinearColor Color, float ArrowSize, float Thickness, bool bScreenSpace, byte DepthPriority);

		// Token: 0x06016EDC RID: 93916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawArc_Internal(IntPtr @this, in FVector Base, float Angle, float Radius, in FVector Direction, in FLinearColor Color, float Thickness, in FVector Normal, int Sections, float InnerRadius, bool bDrawSides, byte DepthPriority);

		// Token: 0x06016EDD RID: 93917 RVA: 0x00217527 File Offset: 0x00215727
		static UKuroPrimitiveComponentVisualizer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFauxPhysics.KuroPrimitiveComponentVisualizer");
		}

		// Token: 0x06016EDE RID: 93918 RVA: 0x00217538 File Offset: 0x00215738
		protected UKuroPrimitiveComponentVisualizer() : this(BuiltinUtils.AllocNativeUObject(UKuroPrimitiveComponentVisualizer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016EDF RID: 93919 RVA: 0x00217560 File Offset: 0x00215760
		protected UKuroPrimitiveComponentVisualizer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C74E RID: 51022
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFauxPhysics.KuroPrimitiveComponentVisualizer";

		// Token: 0x0400C74F RID: 51023
		private static IntPtr _ClassPtr;

		// Token: 0x0400C750 RID: 51024
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
