using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200207C RID: 8316
	[UnrealObjectPath("/Script/LGUI.LGUIGeometryVertex")]
	[UnrealStructLayout(72, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FLGUIGeometryVertex : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F608 RID: 128520 RVA: 0x002E999D File Offset: 0x002E7B9D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIGeometryVertex._ScriptStructPtr != 0) ? FLGUIGeometryVertex._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIGeometryVertex", ref FLGUIGeometryVertex._ScriptStructPtr);
		}

		// Token: 0x17007BE4 RID: 31716
		// (get) Token: 0x0601F609 RID: 128521 RVA: 0x002E99C1 File Offset: 0x002E7BC1
		// (set) Token: 0x0601F60A RID: 128522 RVA: 0x002E99D5 File Offset: 0x002E7BD5
		public unsafe FVector position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIGeometryVertex.__PropertyOffset_position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIGeometryVertex.__PropertyOffset_position) = value;
			}
		}

		// Token: 0x17007BE5 RID: 31717
		// (get) Token: 0x0601F60B RID: 128523 RVA: 0x002E99EA File Offset: 0x002E7BEA
		// (set) Token: 0x0601F60C RID: 128524 RVA: 0x002E99FE File Offset: 0x002E7BFE
		public unsafe FColor color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIGeometryVertex.__PropertyOffset_color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIGeometryVertex.__PropertyOffset_color) = value;
			}
		}

		// Token: 0x17007BE6 RID: 31718
		// (get) Token: 0x0601F60D RID: 128525 RVA: 0x002E9A13 File Offset: 0x002E7C13
		// (set) Token: 0x0601F60E RID: 128526 RVA: 0x002E9A27 File Offset: 0x002E7C27
		public unsafe FVector2D uv0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIGeometryVertex.__PropertyOffset_uv0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIGeometryVertex.__PropertyOffset_uv0) = value;
			}
		}

		// Token: 0x17007BE7 RID: 31719
		// (get) Token: 0x0601F60F RID: 128527 RVA: 0x002E9A3C File Offset: 0x002E7C3C
		// (set) Token: 0x0601F610 RID: 128528 RVA: 0x002E9A50 File Offset: 0x002E7C50
		public unsafe FVector2D uv1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIGeometryVertex.__PropertyOffset_uv1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIGeometryVertex.__PropertyOffset_uv1) = value;
			}
		}

		// Token: 0x17007BE8 RID: 31720
		// (get) Token: 0x0601F611 RID: 128529 RVA: 0x002E9A65 File Offset: 0x002E7C65
		// (set) Token: 0x0601F612 RID: 128530 RVA: 0x002E9A79 File Offset: 0x002E7C79
		public unsafe FVector2D uv2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIGeometryVertex.__PropertyOffset_uv2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIGeometryVertex.__PropertyOffset_uv2) = value;
			}
		}

		// Token: 0x17007BE9 RID: 31721
		// (get) Token: 0x0601F613 RID: 128531 RVA: 0x002E9A8E File Offset: 0x002E7C8E
		// (set) Token: 0x0601F614 RID: 128532 RVA: 0x002E9AA2 File Offset: 0x002E7CA2
		public unsafe FVector2D uv3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIGeometryVertex.__PropertyOffset_uv3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIGeometryVertex.__PropertyOffset_uv3) = value;
			}
		}

		// Token: 0x17007BEA RID: 31722
		// (get) Token: 0x0601F615 RID: 128533 RVA: 0x002E9AB7 File Offset: 0x002E7CB7
		// (set) Token: 0x0601F616 RID: 128534 RVA: 0x002E9ACB File Offset: 0x002E7CCB
		public unsafe FVector normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIGeometryVertex.__PropertyOffset_normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIGeometryVertex.__PropertyOffset_normal) = value;
			}
		}

		// Token: 0x17007BEB RID: 31723
		// (get) Token: 0x0601F617 RID: 128535 RVA: 0x002E9AE0 File Offset: 0x002E7CE0
		// (set) Token: 0x0601F618 RID: 128536 RVA: 0x002E9AF4 File Offset: 0x002E7CF4
		public unsafe FVector tagent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIGeometryVertex.__PropertyOffset_tagent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIGeometryVertex.__PropertyOffset_tagent) = value;
			}
		}

		// Token: 0x0601F619 RID: 128537 RVA: 0x002E9B09 File Offset: 0x002E7D09
		public FLGUIGeometryVertex()
		{
		}

		// Token: 0x0601F61A RID: 128538 RVA: 0x002E9B14 File Offset: 0x002E7D14
		public FLGUIGeometryVertex(FVector position, FColor color, FVector2D uv0, FVector2D uv1, FVector2D uv2, FVector2D uv3, FVector normal, FVector tagent)
		{
			this.position = position;
			this.color = color;
			this.uv0 = uv0;
			this.uv1 = uv1;
			this.uv2 = uv2;
			this.uv3 = uv3;
			this.normal = normal;
			this.tagent = tagent;
		}

		// Token: 0x0601F61B RID: 128539 RVA: 0x002E9B64 File Offset: 0x002E7D64
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIGeometryVertex.StaticStruct();
		}

		// Token: 0x0601F61C RID: 128540 RVA: 0x002E9B70 File Offset: 0x002E7D70
		[NullableContext(2)]
		public FLGUIGeometryVertex(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F61D RID: 128541 RVA: 0x002E9B7A File Offset: 0x002E7D7A
		public FLGUIGeometryVertex(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F61E RID: 128542 RVA: 0x002E9B85 File Offset: 0x002E7D85
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIGeometryVertex(Pointer, false, true);
		}

		// Token: 0x0601F61F RID: 128543 RVA: 0x002E9B8F File Offset: 0x002E7D8F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIGeometryVertex(Pointer, MemoryOwner);
		}

		// Token: 0x04010F37 RID: 69431
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIGeometryVertex";

		// Token: 0x04010F38 RID: 69432
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010F39 RID: 69433
		internal static int __PropertyOffset_position;

		// Token: 0x04010F3A RID: 69434
		internal static int __PropertyOffset_color;

		// Token: 0x04010F3B RID: 69435
		internal static int __PropertyOffset_uv0;

		// Token: 0x04010F3C RID: 69436
		internal static int __PropertyOffset_uv1;

		// Token: 0x04010F3D RID: 69437
		internal static int __PropertyOffset_uv2;

		// Token: 0x04010F3E RID: 69438
		internal static int __PropertyOffset_uv3;

		// Token: 0x04010F3F RID: 69439
		internal static int __PropertyOffset_normal;

		// Token: 0x04010F40 RID: 69440
		internal static int __PropertyOffset_tagent;
	}
}
