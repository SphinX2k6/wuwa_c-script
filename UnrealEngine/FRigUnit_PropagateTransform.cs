using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006A9 RID: 1705
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_PropagateTransform")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRigUnit_PropagateTransform : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005AD3 RID: 23251 RVA: 0x000827F8 File Offset: 0x000809F8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_PropagateTransform._ScriptStructPtr != 0) ? FRigUnit_PropagateTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_PropagateTransform", ref FRigUnit_PropagateTransform._ScriptStructPtr);
		}

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x06005AD4 RID: 23252 RVA: 0x0008281C File Offset: 0x00080A1C
		// (set) Token: 0x06005AD5 RID: 23253 RVA: 0x0008285F File Offset: 0x00080A5F
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_PropagateTransform.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_PropagateTransform.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x06005AD6 RID: 23254 RVA: 0x00082880 File Offset: 0x00080A80
		// (set) Token: 0x06005AD7 RID: 23255 RVA: 0x00082890 File Offset: 0x00080A90
		public unsafe bool bRecomputeGlobal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_PropagateTransform.__PropertyOffset_bRecomputeGlobal) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PropagateTransform.__PropertyOffset_bRecomputeGlobal) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x06005AD8 RID: 23256 RVA: 0x000828A1 File Offset: 0x00080AA1
		// (set) Token: 0x06005AD9 RID: 23257 RVA: 0x000828B1 File Offset: 0x00080AB1
		public unsafe bool bApplyToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_PropagateTransform.__PropertyOffset_bApplyToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PropagateTransform.__PropertyOffset_bApplyToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x06005ADA RID: 23258 RVA: 0x000828C2 File Offset: 0x00080AC2
		// (set) Token: 0x06005ADB RID: 23259 RVA: 0x000828D2 File Offset: 0x00080AD2
		public unsafe bool bRecursive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_PropagateTransform.__PropertyOffset_bRecursive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PropagateTransform.__PropertyOffset_bRecursive) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x06005ADC RID: 23260 RVA: 0x000828E4 File Offset: 0x00080AE4
		// (set) Token: 0x06005ADD RID: 23261 RVA: 0x00082927 File Offset: 0x00080B27
		public FCachedRigElement CachedIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedIndex) == null)
				{
					result = (this._CachedIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_PropagateTransform.__PropertyOffset_CachedIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_PropagateTransform.__PropertyOffset_CachedIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005ADE RID: 23262 RVA: 0x00082948 File Offset: 0x00080B48
		public FRigUnit_PropagateTransform()
		{
		}

		// Token: 0x06005ADF RID: 23263 RVA: 0x00082950 File Offset: 0x00080B50
		public FRigUnit_PropagateTransform(FRigElementKey Item, bool bRecomputeGlobal, bool bApplyToChildren, bool bRecursive, FCachedRigElement CachedIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.Item = Item;
			this.bRecomputeGlobal = bRecomputeGlobal;
			this.bApplyToChildren = bApplyToChildren;
			this.bRecursive = bRecursive;
			this.CachedIndex = CachedIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005AE0 RID: 23264 RVA: 0x00082985 File Offset: 0x00080B85
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_PropagateTransform.StaticStruct();
		}

		// Token: 0x06005AE1 RID: 23265 RVA: 0x00082991 File Offset: 0x00080B91
		[NullableContext(2)]
		public FRigUnit_PropagateTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005AE2 RID: 23266 RVA: 0x0008299B File Offset: 0x00080B9B
		public FRigUnit_PropagateTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005AE3 RID: 23267 RVA: 0x000829A6 File Offset: 0x00080BA6
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_PropagateTransform(Pointer, false, true);
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x000829B0 File Offset: 0x00080BB0
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_PropagateTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04002A8D RID: 10893
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_PropagateTransform";

		// Token: 0x04002A8E RID: 10894
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A8F RID: 10895
		internal static int __PropertyOffset_Item;

		// Token: 0x04002A90 RID: 10896
		[Nullable(2)]
		private FRigElementKey _Item;

		// Token: 0x04002A91 RID: 10897
		internal static int __PropertyOffset_bRecomputeGlobal;

		// Token: 0x04002A92 RID: 10898
		internal static int __PropertyOffset_bApplyToChildren;

		// Token: 0x04002A93 RID: 10899
		internal static int __PropertyOffset_bRecursive;

		// Token: 0x04002A94 RID: 10900
		internal static int __PropertyOffset_CachedIndex;

		// Token: 0x04002A95 RID: 10901
		[Nullable(2)]
		private FCachedRigElement _CachedIndex;
	}
}
