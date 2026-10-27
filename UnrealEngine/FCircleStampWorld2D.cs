using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A5A RID: 6746
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.CircleStampWorld2D")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FCircleStampWorld2D : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018F73 RID: 102259 RVA: 0x0024E7AE File Offset: 0x0024C9AE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCircleStampWorld2D._ScriptStructPtr != 0) ? FCircleStampWorld2D._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.CircleStampWorld2D", ref FCircleStampWorld2D._ScriptStructPtr);
		}

		// Token: 0x170062EE RID: 25326
		// (get) Token: 0x06018F74 RID: 102260 RVA: 0x0024E7D2 File Offset: 0x0024C9D2
		// (set) Token: 0x06018F75 RID: 102261 RVA: 0x0024E7E6 File Offset: 0x0024C9E6
		public unsafe FVectorDouble CenterWorld
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCircleStampWorld2D.__PropertyOffset_CenterWorld);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCircleStampWorld2D.__PropertyOffset_CenterWorld) = value;
			}
		}

		// Token: 0x170062EF RID: 25327
		// (get) Token: 0x06018F76 RID: 102262 RVA: 0x0024E7FB File Offset: 0x0024C9FB
		// (set) Token: 0x06018F77 RID: 102263 RVA: 0x0024E80B File Offset: 0x0024CA0B
		public unsafe float RadiusWorld
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCircleStampWorld2D.__PropertyOffset_RadiusWorld);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCircleStampWorld2D.__PropertyOffset_RadiusWorld) = value;
			}
		}

		// Token: 0x170062F0 RID: 25328
		// (get) Token: 0x06018F78 RID: 102264 RVA: 0x0024E81C File Offset: 0x0024CA1C
		// (set) Token: 0x06018F79 RID: 102265 RVA: 0x0024E82C File Offset: 0x0024CA2C
		public unsafe float SoftEdgeWidthWorld
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCircleStampWorld2D.__PropertyOffset_SoftEdgeWidthWorld);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCircleStampWorld2D.__PropertyOffset_SoftEdgeWidthWorld) = value;
			}
		}

		// Token: 0x170062F1 RID: 25329
		// (get) Token: 0x06018F7A RID: 102266 RVA: 0x0024E83D File Offset: 0x0024CA3D
		// (set) Token: 0x06018F7B RID: 102267 RVA: 0x0024E84D File Offset: 0x0024CA4D
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCircleStampWorld2D.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCircleStampWorld2D.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06018F7C RID: 102268 RVA: 0x0024E85E File Offset: 0x0024CA5E
		public FCircleStampWorld2D()
		{
		}

		// Token: 0x06018F7D RID: 102269 RVA: 0x0024E866 File Offset: 0x0024CA66
		public FCircleStampWorld2D(FVectorDouble CenterWorld, float RadiusWorld, float SoftEdgeWidthWorld, float Value)
		{
			this.CenterWorld = CenterWorld;
			this.RadiusWorld = RadiusWorld;
			this.SoftEdgeWidthWorld = SoftEdgeWidthWorld;
			this.Value = Value;
		}

		// Token: 0x06018F7E RID: 102270 RVA: 0x0024E88B File Offset: 0x0024CA8B
		protected override IntPtr GetUStructPtr()
		{
			return FCircleStampWorld2D.StaticStruct();
		}

		// Token: 0x06018F7F RID: 102271 RVA: 0x0024E897 File Offset: 0x0024CA97
		[NullableContext(2)]
		public FCircleStampWorld2D(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018F80 RID: 102272 RVA: 0x0024E8A1 File Offset: 0x0024CAA1
		public FCircleStampWorld2D(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018F81 RID: 102273 RVA: 0x0024E8AC File Offset: 0x0024CAAC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCircleStampWorld2D(Pointer, false, true);
		}

		// Token: 0x06018F82 RID: 102274 RVA: 0x0024E8B6 File Offset: 0x0024CAB6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCircleStampWorld2D(Pointer, MemoryOwner);
		}

		// Token: 0x0400D822 RID: 55330
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.CircleStampWorld2D";

		// Token: 0x0400D823 RID: 55331
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D824 RID: 55332
		internal static int __PropertyOffset_CenterWorld;

		// Token: 0x0400D825 RID: 55333
		internal static int __PropertyOffset_RadiusWorld;

		// Token: 0x0400D826 RID: 55334
		internal static int __PropertyOffset_SoftEdgeWidthWorld;

		// Token: 0x0400D827 RID: 55335
		internal static int __PropertyOffset_Value;
	}
}
