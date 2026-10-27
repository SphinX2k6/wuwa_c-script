using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200222F RID: 8751
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkVertexNormal")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLiveLinkVertexNormal : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021509 RID: 136457 RVA: 0x003119C1 File Offset: 0x0030FBC1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkVertexNormal._ScriptStructPtr != 0) ? FLiveLinkVertexNormal._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkVertexNormal", ref FLiveLinkVertexNormal._ScriptStructPtr);
		}

		// Token: 0x17008202 RID: 33282
		// (get) Token: 0x0602150A RID: 136458 RVA: 0x003119E5 File Offset: 0x0030FBE5
		// (set) Token: 0x0602150B RID: 136459 RVA: 0x003119F5 File Offset: 0x0030FBF5
		public unsafe int VertexIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkVertexNormal.__PropertyOffset_VertexIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkVertexNormal.__PropertyOffset_VertexIndex) = value;
			}
		}

		// Token: 0x17008203 RID: 33283
		// (get) Token: 0x0602150C RID: 136460 RVA: 0x00311A06 File Offset: 0x0030FC06
		// (set) Token: 0x0602150D RID: 136461 RVA: 0x00311A1A File Offset: 0x0030FC1A
		public unsafe FVector Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkVertexNormal.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkVertexNormal.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x0602150E RID: 136462 RVA: 0x00311A2F File Offset: 0x0030FC2F
		public FLiveLinkVertexNormal()
		{
		}

		// Token: 0x0602150F RID: 136463 RVA: 0x00311A37 File Offset: 0x0030FC37
		public FLiveLinkVertexNormal(int VertexIndex, FVector Normal)
		{
			this.VertexIndex = VertexIndex;
			this.Normal = Normal;
		}

		// Token: 0x06021510 RID: 136464 RVA: 0x00311A4D File Offset: 0x0030FC4D
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkVertexNormal.StaticStruct();
		}

		// Token: 0x06021511 RID: 136465 RVA: 0x00311A59 File Offset: 0x0030FC59
		[NullableContext(2)]
		public FLiveLinkVertexNormal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021512 RID: 136466 RVA: 0x00311A63 File Offset: 0x0030FC63
		public FLiveLinkVertexNormal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021513 RID: 136467 RVA: 0x00311A6E File Offset: 0x0030FC6E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkVertexNormal(Pointer, false, true);
		}

		// Token: 0x06021514 RID: 136468 RVA: 0x00311A78 File Offset: 0x0030FC78
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkVertexNormal(Pointer, MemoryOwner);
		}

		// Token: 0x04011C3A RID: 72762
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkVertexNormal";

		// Token: 0x04011C3B RID: 72763
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011C3C RID: 72764
		internal static int __PropertyOffset_VertexIndex;

		// Token: 0x04011C3D RID: 72765
		internal static int __PropertyOffset_Normal;
	}
}
