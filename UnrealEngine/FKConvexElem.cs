using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CC7 RID: 3271
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KConvexElem")]
	[UnrealStructLayout(192, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FKConvexElem : FKShapeElem, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A549 RID: 42313 RVA: 0x000EB18D File Offset: 0x000E938D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKConvexElem._ScriptStructPtr != 0) ? FKConvexElem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KConvexElem", ref FKConvexElem._ScriptStructPtr);
		}

		// Token: 0x1700274E RID: 10062
		// (get) Token: 0x0600A54A RID: 42314 RVA: 0x000EB1B4 File Offset: 0x000E93B4
		// (set) Token: 0x0600A54B RID: 42315 RVA: 0x000EB1F7 File Offset: 0x000E93F7
		public TArray<FVector> VertexData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._VertexData) == null)
				{
					result = (this._VertexData = new TArray<FVector>(base.NativePtr + (IntPtr)FKConvexElem.__PropertyOffset_VertexData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VertexData.CopyAssign(value);
			}
		}

		// Token: 0x1700274F RID: 10063
		// (get) Token: 0x0600A54C RID: 42316 RVA: 0x000EB208 File Offset: 0x000E9408
		// (set) Token: 0x0600A54D RID: 42317 RVA: 0x000EB24B File Offset: 0x000E944B
		public TArray<int> IndexData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._IndexData) == null)
				{
					result = (this._IndexData = new TArray<int>(base.NativePtr + (IntPtr)FKConvexElem.__PropertyOffset_IndexData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IndexData.CopyAssign(value);
			}
		}

		// Token: 0x17002750 RID: 10064
		// (get) Token: 0x0600A54E RID: 42318 RVA: 0x000EB259 File Offset: 0x000E9459
		// (set) Token: 0x0600A54F RID: 42319 RVA: 0x000EB26D File Offset: 0x000E946D
		public unsafe FBox ElemBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKConvexElem.__PropertyOffset_ElemBox);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKConvexElem.__PropertyOffset_ElemBox) = value;
			}
		}

		// Token: 0x17002751 RID: 10065
		// (get) Token: 0x0600A550 RID: 42320 RVA: 0x000EB282 File Offset: 0x000E9482
		// (set) Token: 0x0600A551 RID: 42321 RVA: 0x000EB296 File Offset: 0x000E9496
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKConvexElem.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKConvexElem.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x0600A552 RID: 42322 RVA: 0x000EB2AB File Offset: 0x000E94AB
		public FKConvexElem()
		{
		}

		// Token: 0x0600A553 RID: 42323 RVA: 0x000EB2B4 File Offset: 0x000E94B4
		public FKConvexElem(TArray<FVector> VertexData, TArray<int> IndexData, FBox ElemBox, FTransform Transform, float RestOffset, bool bIsGenerated, FName Name, bool bContributeToMass, [Nullable(0)] TEnumAsByte<ECollisionEnabled> CollisionEnabled)
		{
			this.VertexData = VertexData;
			this.IndexData = IndexData;
			this.ElemBox = ElemBox;
			this.Transform = Transform;
			base.RestOffset = RestOffset;
			base.Name = Name;
			base.bContributeToMass = bContributeToMass;
			base.CollisionEnabled = CollisionEnabled;
		}

		// Token: 0x0600A554 RID: 42324 RVA: 0x000EB304 File Offset: 0x000E9504
		protected override IntPtr GetUStructPtr()
		{
			return FKConvexElem.StaticStruct();
		}

		// Token: 0x0600A555 RID: 42325 RVA: 0x000EB310 File Offset: 0x000E9510
		[NullableContext(2)]
		public FKConvexElem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A556 RID: 42326 RVA: 0x000EB31A File Offset: 0x000E951A
		public FKConvexElem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A557 RID: 42327 RVA: 0x000EB325 File Offset: 0x000E9525
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKConvexElem(Pointer, false, true);
		}

		// Token: 0x0600A558 RID: 42328 RVA: 0x000EB32F File Offset: 0x000E952F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKConvexElem(Pointer, MemoryOwner);
		}

		// Token: 0x04005AEB RID: 23275
		public new const string __ObjectPath = "/Script/Engine.KConvexElem";

		// Token: 0x04005AEC RID: 23276
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005AED RID: 23277
		internal static int __PropertyOffset_VertexData;

		// Token: 0x04005AEE RID: 23278
		[Nullable(2)]
		private TArray<FVector> _VertexData;

		// Token: 0x04005AEF RID: 23279
		internal static int __PropertyOffset_IndexData;

		// Token: 0x04005AF0 RID: 23280
		[Nullable(2)]
		private TArray<int> _IndexData;

		// Token: 0x04005AF1 RID: 23281
		internal static int __PropertyOffset_ElemBox;

		// Token: 0x04005AF2 RID: 23282
		internal static int __PropertyOffset_Transform;
	}
}
