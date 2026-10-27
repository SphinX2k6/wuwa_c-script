using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020029DB RID: 10715
	[UnrealObjectPath("/Script/UMG.SlateMeshVertex")]
	[UnrealStructLayout(60, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 60)]
	public class FSlateMeshVertex : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027A5C RID: 162396 RVA: 0x003C7644 File Offset: 0x003C5844
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSlateMeshVertex._ScriptStructPtr != 0) ? FSlateMeshVertex._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.SlateMeshVertex", ref FSlateMeshVertex._ScriptStructPtr);
		}

		// Token: 0x170097DF RID: 38879
		// (get) Token: 0x06027A5D RID: 162397 RVA: 0x003C7668 File Offset: 0x003C5868
		// (set) Token: 0x06027A5E RID: 162398 RVA: 0x003C767C File Offset: 0x003C587C
		public unsafe FVector2D Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateMeshVertex.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateMeshVertex.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x170097E0 RID: 38880
		// (get) Token: 0x06027A5F RID: 162399 RVA: 0x003C7691 File Offset: 0x003C5891
		// (set) Token: 0x06027A60 RID: 162400 RVA: 0x003C76A5 File Offset: 0x003C58A5
		public unsafe FColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateMeshVertex.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateMeshVertex.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x170097E1 RID: 38881
		// (get) Token: 0x06027A61 RID: 162401 RVA: 0x003C76BA File Offset: 0x003C58BA
		// (set) Token: 0x06027A62 RID: 162402 RVA: 0x003C76CE File Offset: 0x003C58CE
		public unsafe FVector2D UV0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateMeshVertex.__PropertyOffset_UV0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateMeshVertex.__PropertyOffset_UV0) = value;
			}
		}

		// Token: 0x170097E2 RID: 38882
		// (get) Token: 0x06027A63 RID: 162403 RVA: 0x003C76E3 File Offset: 0x003C58E3
		// (set) Token: 0x06027A64 RID: 162404 RVA: 0x003C76F7 File Offset: 0x003C58F7
		public unsafe FVector2D UV1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateMeshVertex.__PropertyOffset_UV1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateMeshVertex.__PropertyOffset_UV1) = value;
			}
		}

		// Token: 0x170097E3 RID: 38883
		// (get) Token: 0x06027A65 RID: 162405 RVA: 0x003C770C File Offset: 0x003C590C
		// (set) Token: 0x06027A66 RID: 162406 RVA: 0x003C7720 File Offset: 0x003C5920
		public unsafe FVector2D UV2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateMeshVertex.__PropertyOffset_UV2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateMeshVertex.__PropertyOffset_UV2) = value;
			}
		}

		// Token: 0x170097E4 RID: 38884
		// (get) Token: 0x06027A67 RID: 162407 RVA: 0x003C7735 File Offset: 0x003C5935
		// (set) Token: 0x06027A68 RID: 162408 RVA: 0x003C7749 File Offset: 0x003C5949
		public unsafe FVector2D UV3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateMeshVertex.__PropertyOffset_UV3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateMeshVertex.__PropertyOffset_UV3) = value;
			}
		}

		// Token: 0x170097E5 RID: 38885
		// (get) Token: 0x06027A69 RID: 162409 RVA: 0x003C775E File Offset: 0x003C595E
		// (set) Token: 0x06027A6A RID: 162410 RVA: 0x003C7772 File Offset: 0x003C5972
		public unsafe FVector2D UV4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateMeshVertex.__PropertyOffset_UV4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateMeshVertex.__PropertyOffset_UV4) = value;
			}
		}

		// Token: 0x170097E6 RID: 38886
		// (get) Token: 0x06027A6B RID: 162411 RVA: 0x003C7787 File Offset: 0x003C5987
		// (set) Token: 0x06027A6C RID: 162412 RVA: 0x003C779B File Offset: 0x003C599B
		public unsafe FVector2D UV5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateMeshVertex.__PropertyOffset_UV5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateMeshVertex.__PropertyOffset_UV5) = value;
			}
		}

		// Token: 0x06027A6D RID: 162413 RVA: 0x003C77B0 File Offset: 0x003C59B0
		public FSlateMeshVertex()
		{
		}

		// Token: 0x06027A6E RID: 162414 RVA: 0x003C77B8 File Offset: 0x003C59B8
		public FSlateMeshVertex(FVector2D Position, FColor Color, FVector2D UV0, FVector2D UV1, FVector2D UV2, FVector2D UV3, FVector2D UV4, FVector2D UV5)
		{
			this.Position = Position;
			this.Color = Color;
			this.UV0 = UV0;
			this.UV1 = UV1;
			this.UV2 = UV2;
			this.UV3 = UV3;
			this.UV4 = UV4;
			this.UV5 = UV5;
		}

		// Token: 0x06027A6F RID: 162415 RVA: 0x003C7808 File Offset: 0x003C5A08
		protected override IntPtr GetUStructPtr()
		{
			return FSlateMeshVertex.StaticStruct();
		}

		// Token: 0x06027A70 RID: 162416 RVA: 0x003C7814 File Offset: 0x003C5A14
		[NullableContext(2)]
		public FSlateMeshVertex(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027A71 RID: 162417 RVA: 0x003C781E File Offset: 0x003C5A1E
		public FSlateMeshVertex(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027A72 RID: 162418 RVA: 0x003C7829 File Offset: 0x003C5A29
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSlateMeshVertex(Pointer, false, true);
		}

		// Token: 0x06027A73 RID: 162419 RVA: 0x003C7833 File Offset: 0x003C5A33
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSlateMeshVertex(Pointer, MemoryOwner);
		}

		// Token: 0x04015B77 RID: 88951
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.SlateMeshVertex";

		// Token: 0x04015B78 RID: 88952
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015B79 RID: 88953
		internal static int __PropertyOffset_Position;

		// Token: 0x04015B7A RID: 88954
		internal static int __PropertyOffset_Color;

		// Token: 0x04015B7B RID: 88955
		internal static int __PropertyOffset_UV0;

		// Token: 0x04015B7C RID: 88956
		internal static int __PropertyOffset_UV1;

		// Token: 0x04015B7D RID: 88957
		internal static int __PropertyOffset_UV2;

		// Token: 0x04015B7E RID: 88958
		internal static int __PropertyOffset_UV3;

		// Token: 0x04015B7F RID: 88959
		internal static int __PropertyOffset_UV4;

		// Token: 0x04015B80 RID: 88960
		internal static int __PropertyOffset_UV5;
	}
}
