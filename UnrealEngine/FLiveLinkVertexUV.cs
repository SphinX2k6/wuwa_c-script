using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002231 RID: 8753
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkVertexUV")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FLiveLinkVertexUV : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021521 RID: 136481 RVA: 0x00311B41 File Offset: 0x0030FD41
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkVertexUV._ScriptStructPtr != 0) ? FLiveLinkVertexUV._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkVertexUV", ref FLiveLinkVertexUV._ScriptStructPtr);
		}

		// Token: 0x17008206 RID: 33286
		// (get) Token: 0x06021522 RID: 136482 RVA: 0x00311B65 File Offset: 0x0030FD65
		// (set) Token: 0x06021523 RID: 136483 RVA: 0x00311B75 File Offset: 0x0030FD75
		public unsafe int VertexIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkVertexUV.__PropertyOffset_VertexIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkVertexUV.__PropertyOffset_VertexIndex) = value;
			}
		}

		// Token: 0x17008207 RID: 33287
		// (get) Token: 0x06021524 RID: 136484 RVA: 0x00311B86 File Offset: 0x0030FD86
		// (set) Token: 0x06021525 RID: 136485 RVA: 0x00311B9A File Offset: 0x0030FD9A
		public unsafe FVector2D UV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkVertexUV.__PropertyOffset_UV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkVertexUV.__PropertyOffset_UV) = value;
			}
		}

		// Token: 0x06021526 RID: 136486 RVA: 0x00311BAF File Offset: 0x0030FDAF
		public FLiveLinkVertexUV()
		{
		}

		// Token: 0x06021527 RID: 136487 RVA: 0x00311BB7 File Offset: 0x0030FDB7
		public FLiveLinkVertexUV(int VertexIndex, FVector2D UV)
		{
			this.VertexIndex = VertexIndex;
			this.UV = UV;
		}

		// Token: 0x06021528 RID: 136488 RVA: 0x00311BCD File Offset: 0x0030FDCD
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkVertexUV.StaticStruct();
		}

		// Token: 0x06021529 RID: 136489 RVA: 0x00311BD9 File Offset: 0x0030FDD9
		[NullableContext(2)]
		public FLiveLinkVertexUV(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602152A RID: 136490 RVA: 0x00311BE3 File Offset: 0x0030FDE3
		public FLiveLinkVertexUV(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602152B RID: 136491 RVA: 0x00311BEE File Offset: 0x0030FDEE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkVertexUV(Pointer, false, true);
		}

		// Token: 0x0602152C RID: 136492 RVA: 0x00311BF8 File Offset: 0x0030FDF8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkVertexUV(Pointer, MemoryOwner);
		}

		// Token: 0x04011C42 RID: 72770
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkVertexUV";

		// Token: 0x04011C43 RID: 72771
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011C44 RID: 72772
		internal static int __PropertyOffset_VertexIndex;

		// Token: 0x04011C45 RID: 72773
		internal static int __PropertyOffset_UV;
	}
}
