using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006BF RID: 1727
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetControlVisibility")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FRigUnit_SetControlVisibility : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005C53 RID: 23635 RVA: 0x00084889 File Offset: 0x00082A89
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetControlVisibility._ScriptStructPtr != 0) ? FRigUnit_SetControlVisibility._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetControlVisibility", ref FRigUnit_SetControlVisibility._ScriptStructPtr);
		}

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x06005C54 RID: 23636 RVA: 0x000848B0 File Offset: 0x00082AB0
		// (set) Token: 0x06005C55 RID: 23637 RVA: 0x000848F3 File Offset: 0x00082AF3
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_SetControlVisibility.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetControlVisibility.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x06005C56 RID: 23638 RVA: 0x00084914 File Offset: 0x00082B14
		// (set) Token: 0x06005C57 RID: 23639 RVA: 0x00084928 File Offset: 0x00082B28
		public unsafe string Pattern
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FRigUnit_SetControlVisibility.__PropertyOffset_Pattern)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FRigUnit_SetControlVisibility.__PropertyOffset_Pattern)), value);
			}
		}

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x06005C58 RID: 23640 RVA: 0x0008493D File Offset: 0x00082B3D
		// (set) Token: 0x06005C59 RID: 23641 RVA: 0x0008494D File Offset: 0x00082B4D
		public unsafe bool bVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlVisibility.__PropertyOffset_bVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlVisibility.__PropertyOffset_bVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x06005C5A RID: 23642 RVA: 0x00084960 File Offset: 0x00082B60
		// (set) Token: 0x06005C5B RID: 23643 RVA: 0x000849A3 File Offset: 0x00082BA3
		public TArray<FCachedRigElement> CachedControlIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCachedRigElement> result;
				if ((result = this._CachedControlIndices) == null)
				{
					result = (this._CachedControlIndices = new TArray<FCachedRigElement>(base.NativePtr + (IntPtr)FRigUnit_SetControlVisibility.__PropertyOffset_CachedControlIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CachedControlIndices.CopyAssign(value);
			}
		}

		// Token: 0x06005C5C RID: 23644 RVA: 0x000849B1 File Offset: 0x00082BB1
		public FRigUnit_SetControlVisibility()
		{
		}

		// Token: 0x06005C5D RID: 23645 RVA: 0x000849B9 File Offset: 0x00082BB9
		public FRigUnit_SetControlVisibility(FRigElementKey Item, string Pattern, bool bVisible, TArray<FCachedRigElement> CachedControlIndices, FControlRigExecuteContext ExecuteContext)
		{
			this.Item = Item;
			this.Pattern = Pattern;
			this.bVisible = bVisible;
			this.CachedControlIndices = CachedControlIndices;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005C5E RID: 23646 RVA: 0x000849E6 File Offset: 0x00082BE6
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetControlVisibility.StaticStruct();
		}

		// Token: 0x06005C5F RID: 23647 RVA: 0x000849F2 File Offset: 0x00082BF2
		[NullableContext(2)]
		public FRigUnit_SetControlVisibility(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005C60 RID: 23648 RVA: 0x000849FC File Offset: 0x00082BFC
		public FRigUnit_SetControlVisibility(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005C61 RID: 23649 RVA: 0x00084A07 File Offset: 0x00082C07
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetControlVisibility(Pointer, false, true);
		}

		// Token: 0x06005C62 RID: 23650 RVA: 0x00084A11 File Offset: 0x00082C11
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetControlVisibility(Pointer, MemoryOwner);
		}

		// Token: 0x04002B36 RID: 11062
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetControlVisibility";

		// Token: 0x04002B37 RID: 11063
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B38 RID: 11064
		internal static int __PropertyOffset_Item;

		// Token: 0x04002B39 RID: 11065
		[Nullable(2)]
		private FRigElementKey _Item;

		// Token: 0x04002B3A RID: 11066
		internal static int __PropertyOffset_Pattern;

		// Token: 0x04002B3B RID: 11067
		internal static int __PropertyOffset_bVisible;

		// Token: 0x04002B3C RID: 11068
		internal static int __PropertyOffset_CachedControlIndices;

		// Token: 0x04002B3D RID: 11069
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCachedRigElement> _CachedControlIndices;
	}
}
