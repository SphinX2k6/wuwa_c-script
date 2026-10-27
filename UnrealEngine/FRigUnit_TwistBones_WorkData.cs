using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006F1 RID: 1777
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_TwistBones_WorkData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_TwistBones_WorkData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005F8A RID: 24458 RVA: 0x00088FB4 File Offset: 0x000871B4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_TwistBones_WorkData._ScriptStructPtr != 0) ? FRigUnit_TwistBones_WorkData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_TwistBones_WorkData", ref FRigUnit_TwistBones_WorkData._ScriptStructPtr);
		}

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x06005F8B RID: 24459 RVA: 0x00088FD8 File Offset: 0x000871D8
		// (set) Token: 0x06005F8C RID: 24460 RVA: 0x0008901B File Offset: 0x0008721B
		public TArray<FCachedRigElement> CachedItems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCachedRigElement> result;
				if ((result = this._CachedItems) == null)
				{
					result = (this._CachedItems = new TArray<FCachedRigElement>(base.NativePtr + (IntPtr)FRigUnit_TwistBones_WorkData.__PropertyOffset_CachedItems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CachedItems.CopyAssign(value);
			}
		}

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x06005F8D RID: 24461 RVA: 0x0008902C File Offset: 0x0008722C
		// (set) Token: 0x06005F8E RID: 24462 RVA: 0x0008906F File Offset: 0x0008726F
		public TArray<float> ItemRatios
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ItemRatios) == null)
				{
					result = (this._ItemRatios = new TArray<float>(base.NativePtr + (IntPtr)FRigUnit_TwistBones_WorkData.__PropertyOffset_ItemRatios, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ItemRatios.CopyAssign(value);
			}
		}

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x06005F8F RID: 24463 RVA: 0x00089080 File Offset: 0x00087280
		// (set) Token: 0x06005F90 RID: 24464 RVA: 0x000890C3 File Offset: 0x000872C3
		public TArray<FTransform> ItemTransforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._ItemTransforms) == null)
				{
					result = (this._ItemTransforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FRigUnit_TwistBones_WorkData.__PropertyOffset_ItemTransforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ItemTransforms.CopyAssign(value);
			}
		}

		// Token: 0x06005F91 RID: 24465 RVA: 0x000890D1 File Offset: 0x000872D1
		public FRigUnit_TwistBones_WorkData()
		{
		}

		// Token: 0x06005F92 RID: 24466 RVA: 0x000890D9 File Offset: 0x000872D9
		public FRigUnit_TwistBones_WorkData(TArray<FCachedRigElement> CachedItems, TArray<float> ItemRatios, TArray<FTransform> ItemTransforms)
		{
			this.CachedItems = CachedItems;
			this.ItemRatios = ItemRatios;
			this.ItemTransforms = ItemTransforms;
		}

		// Token: 0x06005F93 RID: 24467 RVA: 0x000890F6 File Offset: 0x000872F6
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_TwistBones_WorkData.StaticStruct();
		}

		// Token: 0x06005F94 RID: 24468 RVA: 0x00089102 File Offset: 0x00087302
		[NullableContext(2)]
		public FRigUnit_TwistBones_WorkData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005F95 RID: 24469 RVA: 0x0008910C File Offset: 0x0008730C
		public FRigUnit_TwistBones_WorkData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005F96 RID: 24470 RVA: 0x00089117 File Offset: 0x00087317
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_TwistBones_WorkData(Pointer, false, true);
		}

		// Token: 0x06005F97 RID: 24471 RVA: 0x00089121 File Offset: 0x00087321
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_TwistBones_WorkData(Pointer, MemoryOwner);
		}

		// Token: 0x04002CA9 RID: 11433
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_TwistBones_WorkData";

		// Token: 0x04002CAA RID: 11434
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002CAB RID: 11435
		internal static int __PropertyOffset_CachedItems;

		// Token: 0x04002CAC RID: 11436
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCachedRigElement> _CachedItems;

		// Token: 0x04002CAD RID: 11437
		internal static int __PropertyOffset_ItemRatios;

		// Token: 0x04002CAE RID: 11438
		[Nullable(2)]
		private TArray<float> _ItemRatios;

		// Token: 0x04002CAF RID: 11439
		internal static int __PropertyOffset_ItemTransforms;

		// Token: 0x04002CB0 RID: 11440
		[Nullable(2)]
		private TArray<FTransform> _ItemTransforms;
	}
}
