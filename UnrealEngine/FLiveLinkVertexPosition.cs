using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002230 RID: 8752
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkVertexPosition")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLiveLinkVertexPosition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021515 RID: 136469 RVA: 0x00311A81 File Offset: 0x0030FC81
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkVertexPosition._ScriptStructPtr != 0) ? FLiveLinkVertexPosition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkVertexPosition", ref FLiveLinkVertexPosition._ScriptStructPtr);
		}

		// Token: 0x17008204 RID: 33284
		// (get) Token: 0x06021516 RID: 136470 RVA: 0x00311AA5 File Offset: 0x0030FCA5
		// (set) Token: 0x06021517 RID: 136471 RVA: 0x00311AB5 File Offset: 0x0030FCB5
		public unsafe int VertexIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkVertexPosition.__PropertyOffset_VertexIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkVertexPosition.__PropertyOffset_VertexIndex) = value;
			}
		}

		// Token: 0x17008205 RID: 33285
		// (get) Token: 0x06021518 RID: 136472 RVA: 0x00311AC6 File Offset: 0x0030FCC6
		// (set) Token: 0x06021519 RID: 136473 RVA: 0x00311ADA File Offset: 0x0030FCDA
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkVertexPosition.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkVertexPosition.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x0602151A RID: 136474 RVA: 0x00311AEF File Offset: 0x0030FCEF
		public FLiveLinkVertexPosition()
		{
		}

		// Token: 0x0602151B RID: 136475 RVA: 0x00311AF7 File Offset: 0x0030FCF7
		public FLiveLinkVertexPosition(int VertexIndex, FVector Position)
		{
			this.VertexIndex = VertexIndex;
			this.Position = Position;
		}

		// Token: 0x0602151C RID: 136476 RVA: 0x00311B0D File Offset: 0x0030FD0D
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkVertexPosition.StaticStruct();
		}

		// Token: 0x0602151D RID: 136477 RVA: 0x00311B19 File Offset: 0x0030FD19
		[NullableContext(2)]
		public FLiveLinkVertexPosition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602151E RID: 136478 RVA: 0x00311B23 File Offset: 0x0030FD23
		public FLiveLinkVertexPosition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602151F RID: 136479 RVA: 0x00311B2E File Offset: 0x0030FD2E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkVertexPosition(Pointer, false, true);
		}

		// Token: 0x06021520 RID: 136480 RVA: 0x00311B38 File Offset: 0x0030FD38
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkVertexPosition(Pointer, MemoryOwner);
		}

		// Token: 0x04011C3E RID: 72766
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkVertexPosition";

		// Token: 0x04011C3F RID: 72767
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011C40 RID: 72768
		internal static int __PropertyOffset_VertexIndex;

		// Token: 0x04011C41 RID: 72769
		internal static int __PropertyOffset_Position;
	}
}
