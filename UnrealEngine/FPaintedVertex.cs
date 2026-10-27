using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000F3C RID: 3900
	[UnrealObjectPath("/Script/Engine.PaintedVertex")]
	[UnrealStructLayout(32, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FPaintedVertex : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600D25D RID: 53853 RVA: 0x0013448D File Offset: 0x0013268D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPaintedVertex._ScriptStructPtr != 0) ? FPaintedVertex._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PaintedVertex", ref FPaintedVertex._ScriptStructPtr);
		}

		// Token: 0x17003128 RID: 12584
		// (get) Token: 0x0600D25E RID: 53854 RVA: 0x001344B1 File Offset: 0x001326B1
		// (set) Token: 0x0600D25F RID: 53855 RVA: 0x001344C5 File Offset: 0x001326C5
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPaintedVertex.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPaintedVertex.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17003129 RID: 12585
		// (get) Token: 0x0600D260 RID: 53856 RVA: 0x001344DA File Offset: 0x001326DA
		// (set) Token: 0x0600D261 RID: 53857 RVA: 0x001344EE File Offset: 0x001326EE
		public unsafe FColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPaintedVertex.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPaintedVertex.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x1700312A RID: 12586
		// (get) Token: 0x0600D262 RID: 53858 RVA: 0x00134503 File Offset: 0x00132703
		// (set) Token: 0x0600D263 RID: 53859 RVA: 0x00134517 File Offset: 0x00132717
		public unsafe FVector4 Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPaintedVertex.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPaintedVertex.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x0600D264 RID: 53860 RVA: 0x0013452C File Offset: 0x0013272C
		public FPaintedVertex()
		{
		}

		// Token: 0x0600D265 RID: 53861 RVA: 0x00134534 File Offset: 0x00132734
		public FPaintedVertex(FVector Position, FColor Color, FVector4 Normal)
		{
			this.Position = Position;
			this.Color = Color;
			this.Normal = Normal;
		}

		// Token: 0x0600D266 RID: 53862 RVA: 0x00134551 File Offset: 0x00132751
		protected override IntPtr GetUStructPtr()
		{
			return FPaintedVertex.StaticStruct();
		}

		// Token: 0x0600D267 RID: 53863 RVA: 0x0013455D File Offset: 0x0013275D
		[NullableContext(2)]
		public FPaintedVertex(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D268 RID: 53864 RVA: 0x00134567 File Offset: 0x00132767
		public FPaintedVertex(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D269 RID: 53865 RVA: 0x00134572 File Offset: 0x00132772
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPaintedVertex(Pointer, false, true);
		}

		// Token: 0x0600D26A RID: 53866 RVA: 0x0013457C File Offset: 0x0013277C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPaintedVertex(Pointer, MemoryOwner);
		}

		// Token: 0x040070E5 RID: 28901
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PaintedVertex";

		// Token: 0x040070E6 RID: 28902
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040070E7 RID: 28903
		internal static int __PropertyOffset_Position;

		// Token: 0x040070E8 RID: 28904
		internal static int __PropertyOffset_Color;

		// Token: 0x040070E9 RID: 28905
		internal static int __PropertyOffset_Normal;
	}
}
