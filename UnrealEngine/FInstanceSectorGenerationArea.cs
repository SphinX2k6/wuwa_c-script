using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C6A RID: 3178
	[UnrealObjectPath("/Script/Engine.InstanceSectorGenerationArea")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FInstanceSectorGenerationArea : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A1B1 RID: 41393 RVA: 0x000E5A71 File Offset: 0x000E3C71
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInstanceSectorGenerationArea._ScriptStructPtr != 0) ? FInstanceSectorGenerationArea._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InstanceSectorGenerationArea", ref FInstanceSectorGenerationArea._ScriptStructPtr);
		}

		// Token: 0x1700267F RID: 9855
		// (get) Token: 0x0600A1B2 RID: 41394 RVA: 0x000E5A95 File Offset: 0x000E3C95
		// (set) Token: 0x0600A1B3 RID: 41395 RVA: 0x000E5AA5 File Offset: 0x000E3CA5
		public unsafe int NumInstances
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInstanceSectorGenerationArea.__PropertyOffset_NumInstances);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInstanceSectorGenerationArea.__PropertyOffset_NumInstances) = value;
			}
		}

		// Token: 0x17002680 RID: 9856
		// (get) Token: 0x0600A1B4 RID: 41396 RVA: 0x000E5AB6 File Offset: 0x000E3CB6
		// (set) Token: 0x0600A1B5 RID: 41397 RVA: 0x000E5AC6 File Offset: 0x000E3CC6
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInstanceSectorGenerationArea.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInstanceSectorGenerationArea.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17002681 RID: 9857
		// (get) Token: 0x0600A1B6 RID: 41398 RVA: 0x000E5AD7 File Offset: 0x000E3CD7
		// (set) Token: 0x0600A1B7 RID: 41399 RVA: 0x000E5AE7 File Offset: 0x000E3CE7
		public unsafe float Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInstanceSectorGenerationArea.__PropertyOffset_Angle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInstanceSectorGenerationArea.__PropertyOffset_Angle) = value;
			}
		}

		// Token: 0x17002682 RID: 9858
		// (get) Token: 0x0600A1B8 RID: 41400 RVA: 0x000E5AF8 File Offset: 0x000E3CF8
		// (set) Token: 0x0600A1B9 RID: 41401 RVA: 0x000E5B08 File Offset: 0x000E3D08
		public unsafe bool bRandomRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInstanceSectorGenerationArea.__PropertyOffset_bRandomRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInstanceSectorGenerationArea.__PropertyOffset_bRandomRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600A1BA RID: 41402 RVA: 0x000E5B19 File Offset: 0x000E3D19
		public FInstanceSectorGenerationArea()
		{
		}

		// Token: 0x0600A1BB RID: 41403 RVA: 0x000E5B21 File Offset: 0x000E3D21
		public FInstanceSectorGenerationArea(int NumInstances, float Radius, float Angle, bool bRandomRotation)
		{
			this.NumInstances = NumInstances;
			this.Radius = Radius;
			this.Angle = Angle;
			this.bRandomRotation = bRandomRotation;
		}

		// Token: 0x0600A1BC RID: 41404 RVA: 0x000E5B46 File Offset: 0x000E3D46
		protected override IntPtr GetUStructPtr()
		{
			return FInstanceSectorGenerationArea.StaticStruct();
		}

		// Token: 0x0600A1BD RID: 41405 RVA: 0x000E5B52 File Offset: 0x000E3D52
		[NullableContext(2)]
		public FInstanceSectorGenerationArea(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A1BE RID: 41406 RVA: 0x000E5B5C File Offset: 0x000E3D5C
		public FInstanceSectorGenerationArea(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A1BF RID: 41407 RVA: 0x000E5B67 File Offset: 0x000E3D67
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInstanceSectorGenerationArea(Pointer, false, true);
		}

		// Token: 0x0600A1C0 RID: 41408 RVA: 0x000E5B71 File Offset: 0x000E3D71
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInstanceSectorGenerationArea(Pointer, MemoryOwner);
		}

		// Token: 0x040058C7 RID: 22727
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InstanceSectorGenerationArea";

		// Token: 0x040058C8 RID: 22728
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040058C9 RID: 22729
		internal static int __PropertyOffset_NumInstances;

		// Token: 0x040058CA RID: 22730
		internal static int __PropertyOffset_Radius;

		// Token: 0x040058CB RID: 22731
		internal static int __PropertyOffset_Angle;

		// Token: 0x040058CC RID: 22732
		internal static int __PropertyOffset_bRandomRotation;
	}
}
