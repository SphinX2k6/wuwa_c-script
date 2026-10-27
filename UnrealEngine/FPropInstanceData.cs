using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001814 RID: 6164
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroDynamicMeshBatch.PropInstanceData")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FPropInstanceData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016CD5 RID: 93397 RVA: 0x0021457A File Offset: 0x0021277A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPropInstanceData._ScriptStructPtr != 0) ? FPropInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroDynamicMeshBatch.PropInstanceData", ref FPropInstanceData._ScriptStructPtr);
		}

		// Token: 0x17005C14 RID: 23572
		// (get) Token: 0x06016CD6 RID: 93398 RVA: 0x0021459E File Offset: 0x0021279E
		// (set) Token: 0x06016CD7 RID: 93399 RVA: 0x002145B2 File Offset: 0x002127B2
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropInstanceData.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropInstanceData.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17005C15 RID: 23573
		// (get) Token: 0x06016CD8 RID: 93400 RVA: 0x002145C8 File Offset: 0x002127C8
		// (set) Token: 0x06016CD9 RID: 93401 RVA: 0x0021460B File Offset: 0x0021280B
		public FPropMaterialParams MaterialParams
		{
			get
			{
				base.FastCheckIsValid();
				FPropMaterialParams result;
				if ((result = this._MaterialParams) == null)
				{
					result = (this._MaterialParams = new FPropMaterialParams(base.NativePtr + (IntPtr)FPropInstanceData.__PropertyOffset_MaterialParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPropMaterialParams.StaticStruct(), base.NativePtr + (IntPtr)FPropInstanceData.__PropertyOffset_MaterialParams, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005C16 RID: 23574
		// (get) Token: 0x06016CDA RID: 93402 RVA: 0x0021462C File Offset: 0x0021282C
		// (set) Token: 0x06016CDB RID: 93403 RVA: 0x0021463C File Offset: 0x0021283C
		public unsafe bool bDynamicUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropInstanceData.__PropertyOffset_bDynamicUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropInstanceData.__PropertyOffset_bDynamicUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x06016CDC RID: 93404 RVA: 0x0021464D File Offset: 0x0021284D
		public FPropInstanceData()
		{
		}

		// Token: 0x06016CDD RID: 93405 RVA: 0x00214655 File Offset: 0x00212855
		public FPropInstanceData(FTransform Transform, FPropMaterialParams MaterialParams, bool bDynamicUpdate)
		{
			this.Transform = Transform;
			this.MaterialParams = MaterialParams;
			this.bDynamicUpdate = bDynamicUpdate;
		}

		// Token: 0x06016CDE RID: 93406 RVA: 0x00214672 File Offset: 0x00212872
		protected override IntPtr GetUStructPtr()
		{
			return FPropInstanceData.StaticStruct();
		}

		// Token: 0x06016CDF RID: 93407 RVA: 0x0021467E File Offset: 0x0021287E
		[NullableContext(2)]
		public FPropInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016CE0 RID: 93408 RVA: 0x00214688 File Offset: 0x00212888
		public FPropInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016CE1 RID: 93409 RVA: 0x00214693 File Offset: 0x00212893
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPropInstanceData(Pointer, false, true);
		}

		// Token: 0x06016CE2 RID: 93410 RVA: 0x0021469D File Offset: 0x0021289D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPropInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x0400C5EA RID: 50666
		public const string __ObjectPath = "/Script/KuroDynamicMeshBatch.PropInstanceData";

		// Token: 0x0400C5EB RID: 50667
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C5EC RID: 50668
		internal static int __PropertyOffset_Transform;

		// Token: 0x0400C5ED RID: 50669
		internal static int __PropertyOffset_MaterialParams;

		// Token: 0x0400C5EE RID: 50670
		[Nullable(2)]
		private FPropMaterialParams _MaterialParams;

		// Token: 0x0400C5EF RID: 50671
		internal static int __PropertyOffset_bDynamicUpdate;
	}
}
