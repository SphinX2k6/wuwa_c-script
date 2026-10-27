using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006D2 RID: 1746
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetTranslation")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FRigUnit_SetTranslation : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005D83 RID: 23939 RVA: 0x000863DC File Offset: 0x000845DC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetTranslation._ScriptStructPtr != 0) ? FRigUnit_SetTranslation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetTranslation", ref FRigUnit_SetTranslation._ScriptStructPtr);
		}

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x06005D84 RID: 23940 RVA: 0x00086400 File Offset: 0x00084600
		// (set) Token: 0x06005D85 RID: 23941 RVA: 0x00086443 File Offset: 0x00084643
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_SetTranslation.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetTranslation.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x06005D86 RID: 23942 RVA: 0x00086464 File Offset: 0x00084664
		// (set) Token: 0x06005D87 RID: 23943 RVA: 0x00086474 File Offset: 0x00084674
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_SetTranslation.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetTranslation.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x06005D88 RID: 23944 RVA: 0x00086485 File Offset: 0x00084685
		// (set) Token: 0x06005D89 RID: 23945 RVA: 0x00086499 File Offset: 0x00084699
		public unsafe FVector Translation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetTranslation.__PropertyOffset_Translation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetTranslation.__PropertyOffset_Translation) = value;
			}
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x06005D8A RID: 23946 RVA: 0x000864AE File Offset: 0x000846AE
		// (set) Token: 0x06005D8B RID: 23947 RVA: 0x000864BE File Offset: 0x000846BE
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetTranslation.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetTranslation.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x06005D8C RID: 23948 RVA: 0x000864CF File Offset: 0x000846CF
		// (set) Token: 0x06005D8D RID: 23949 RVA: 0x000864DF File Offset: 0x000846DF
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetTranslation.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetTranslation.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x06005D8E RID: 23950 RVA: 0x000864F0 File Offset: 0x000846F0
		// (set) Token: 0x06005D8F RID: 23951 RVA: 0x00086533 File Offset: 0x00084733
		public FCachedRigElement CachedIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedIndex) == null)
				{
					result = (this._CachedIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetTranslation.__PropertyOffset_CachedIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetTranslation.__PropertyOffset_CachedIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005D90 RID: 23952 RVA: 0x00086554 File Offset: 0x00084754
		public FRigUnit_SetTranslation()
		{
		}

		// Token: 0x06005D91 RID: 23953 RVA: 0x0008655C File Offset: 0x0008475C
		public FRigUnit_SetTranslation(FRigElementKey Item, EBoneGetterSetterMode Space, FVector Translation, float Weight, bool bPropagateToChildren, FCachedRigElement CachedIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.Item = Item;
			this.Space = Space;
			this.Translation = Translation;
			this.Weight = Weight;
			this.bPropagateToChildren = bPropagateToChildren;
			this.CachedIndex = CachedIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005D92 RID: 23954 RVA: 0x00086599 File Offset: 0x00084799
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetTranslation.StaticStruct();
		}

		// Token: 0x06005D93 RID: 23955 RVA: 0x000865A5 File Offset: 0x000847A5
		[NullableContext(2)]
		public FRigUnit_SetTranslation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D94 RID: 23956 RVA: 0x000865AF File Offset: 0x000847AF
		public FRigUnit_SetTranslation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D95 RID: 23957 RVA: 0x000865BA File Offset: 0x000847BA
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetTranslation(Pointer, false, true);
		}

		// Token: 0x06005D96 RID: 23958 RVA: 0x000865C4 File Offset: 0x000847C4
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetTranslation(Pointer, MemoryOwner);
		}

		// Token: 0x04002BC3 RID: 11203
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetTranslation";

		// Token: 0x04002BC4 RID: 11204
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002BC5 RID: 11205
		internal static int __PropertyOffset_Item;

		// Token: 0x04002BC6 RID: 11206
		[Nullable(2)]
		private FRigElementKey _Item;

		// Token: 0x04002BC7 RID: 11207
		internal static int __PropertyOffset_Space;

		// Token: 0x04002BC8 RID: 11208
		internal static int __PropertyOffset_Translation;

		// Token: 0x04002BC9 RID: 11209
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002BCA RID: 11210
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002BCB RID: 11211
		internal static int __PropertyOffset_CachedIndex;

		// Token: 0x04002BCC RID: 11212
		[Nullable(2)]
		private FCachedRigElement _CachedIndex;
	}
}
