using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C69 RID: 3177
	[UnrealObjectPath("/Script/Engine.InstanceRectangleGenerationArea")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FInstanceRectangleGenerationArea : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A19D RID: 41373 RVA: 0x000E5916 File Offset: 0x000E3B16
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInstanceRectangleGenerationArea._ScriptStructPtr != 0) ? FInstanceRectangleGenerationArea._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InstanceRectangleGenerationArea", ref FInstanceRectangleGenerationArea._ScriptStructPtr);
		}

		// Token: 0x17002679 RID: 9849
		// (get) Token: 0x0600A19E RID: 41374 RVA: 0x000E593A File Offset: 0x000E3B3A
		// (set) Token: 0x0600A19F RID: 41375 RVA: 0x000E594A File Offset: 0x000E3B4A
		public unsafe int NumCols
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInstanceRectangleGenerationArea.__PropertyOffset_NumCols);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInstanceRectangleGenerationArea.__PropertyOffset_NumCols) = value;
			}
		}

		// Token: 0x1700267A RID: 9850
		// (get) Token: 0x0600A1A0 RID: 41376 RVA: 0x000E595B File Offset: 0x000E3B5B
		// (set) Token: 0x0600A1A1 RID: 41377 RVA: 0x000E596B File Offset: 0x000E3B6B
		public unsafe int NumRows
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInstanceRectangleGenerationArea.__PropertyOffset_NumRows);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInstanceRectangleGenerationArea.__PropertyOffset_NumRows) = value;
			}
		}

		// Token: 0x1700267B RID: 9851
		// (get) Token: 0x0600A1A2 RID: 41378 RVA: 0x000E597C File Offset: 0x000E3B7C
		// (set) Token: 0x0600A1A3 RID: 41379 RVA: 0x000E598C File Offset: 0x000E3B8C
		public unsafe float Interval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInstanceRectangleGenerationArea.__PropertyOffset_Interval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInstanceRectangleGenerationArea.__PropertyOffset_Interval) = value;
			}
		}

		// Token: 0x1700267C RID: 9852
		// (get) Token: 0x0600A1A4 RID: 41380 RVA: 0x000E599D File Offset: 0x000E3B9D
		// (set) Token: 0x0600A1A5 RID: 41381 RVA: 0x000E59AD File Offset: 0x000E3BAD
		public unsafe float Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInstanceRectangleGenerationArea.__PropertyOffset_Width);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInstanceRectangleGenerationArea.__PropertyOffset_Width) = value;
			}
		}

		// Token: 0x1700267D RID: 9853
		// (get) Token: 0x0600A1A6 RID: 41382 RVA: 0x000E59BE File Offset: 0x000E3BBE
		// (set) Token: 0x0600A1A7 RID: 41383 RVA: 0x000E59CE File Offset: 0x000E3BCE
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInstanceRectangleGenerationArea.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInstanceRectangleGenerationArea.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x1700267E RID: 9854
		// (get) Token: 0x0600A1A8 RID: 41384 RVA: 0x000E59DF File Offset: 0x000E3BDF
		// (set) Token: 0x0600A1A9 RID: 41385 RVA: 0x000E59EF File Offset: 0x000E3BEF
		public unsafe bool bRandomRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInstanceRectangleGenerationArea.__PropertyOffset_bRandomRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInstanceRectangleGenerationArea.__PropertyOffset_bRandomRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600A1AA RID: 41386 RVA: 0x000E5A00 File Offset: 0x000E3C00
		public FInstanceRectangleGenerationArea()
		{
		}

		// Token: 0x0600A1AB RID: 41387 RVA: 0x000E5A08 File Offset: 0x000E3C08
		public FInstanceRectangleGenerationArea(int NumCols, int NumRows, float Interval, float Width, float Height, bool bRandomRotation)
		{
			this.NumCols = NumCols;
			this.NumRows = NumRows;
			this.Interval = Interval;
			this.Width = Width;
			this.Height = Height;
			this.bRandomRotation = bRandomRotation;
		}

		// Token: 0x0600A1AC RID: 41388 RVA: 0x000E5A3D File Offset: 0x000E3C3D
		protected override IntPtr GetUStructPtr()
		{
			return FInstanceRectangleGenerationArea.StaticStruct();
		}

		// Token: 0x0600A1AD RID: 41389 RVA: 0x000E5A49 File Offset: 0x000E3C49
		[NullableContext(2)]
		public FInstanceRectangleGenerationArea(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A1AE RID: 41390 RVA: 0x000E5A53 File Offset: 0x000E3C53
		public FInstanceRectangleGenerationArea(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A1AF RID: 41391 RVA: 0x000E5A5E File Offset: 0x000E3C5E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInstanceRectangleGenerationArea(Pointer, false, true);
		}

		// Token: 0x0600A1B0 RID: 41392 RVA: 0x000E5A68 File Offset: 0x000E3C68
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInstanceRectangleGenerationArea(Pointer, MemoryOwner);
		}

		// Token: 0x040058BF RID: 22719
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InstanceRectangleGenerationArea";

		// Token: 0x040058C0 RID: 22720
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040058C1 RID: 22721
		internal static int __PropertyOffset_NumCols;

		// Token: 0x040058C2 RID: 22722
		internal static int __PropertyOffset_NumRows;

		// Token: 0x040058C3 RID: 22723
		internal static int __PropertyOffset_Interval;

		// Token: 0x040058C4 RID: 22724
		internal static int __PropertyOffset_Width;

		// Token: 0x040058C5 RID: 22725
		internal static int __PropertyOffset_Height;

		// Token: 0x040058C6 RID: 22726
		internal static int __PropertyOffset_bRandomRotation;
	}
}
