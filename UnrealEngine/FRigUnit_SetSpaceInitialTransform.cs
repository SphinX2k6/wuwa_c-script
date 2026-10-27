using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006CF RID: 1743
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetSpaceInitialTransform")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FRigUnit_SetSpaceInitialTransform : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005D49 RID: 23881 RVA: 0x00085E89 File Offset: 0x00084089
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetSpaceInitialTransform._ScriptStructPtr != 0) ? FRigUnit_SetSpaceInitialTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetSpaceInitialTransform", ref FRigUnit_SetSpaceInitialTransform._ScriptStructPtr);
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x06005D4A RID: 23882 RVA: 0x00085EAD File Offset: 0x000840AD
		// (set) Token: 0x06005D4B RID: 23883 RVA: 0x00085EC1 File Offset: 0x000840C1
		public unsafe FName SpaceName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetSpaceInitialTransform.__PropertyOffset_SpaceName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetSpaceInitialTransform.__PropertyOffset_SpaceName) = value;
			}
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x06005D4C RID: 23884 RVA: 0x00085ED6 File Offset: 0x000840D6
		// (set) Token: 0x06005D4D RID: 23885 RVA: 0x00085EEA File Offset: 0x000840EA
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetSpaceInitialTransform.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetSpaceInitialTransform.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x06005D4E RID: 23886 RVA: 0x00085EFF File Offset: 0x000840FF
		// (set) Token: 0x06005D4F RID: 23887 RVA: 0x00085F13 File Offset: 0x00084113
		public unsafe FTransform Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetSpaceInitialTransform.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetSpaceInitialTransform.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x06005D50 RID: 23888 RVA: 0x00085F28 File Offset: 0x00084128
		// (set) Token: 0x06005D51 RID: 23889 RVA: 0x00085F38 File Offset: 0x00084138
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_SetSpaceInitialTransform.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetSpaceInitialTransform.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06005D52 RID: 23890 RVA: 0x00085F4C File Offset: 0x0008414C
		// (set) Token: 0x06005D53 RID: 23891 RVA: 0x00085F8F File Offset: 0x0008418F
		public FCachedRigElement CachedSpaceIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedSpaceIndex) == null)
				{
					result = (this._CachedSpaceIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetSpaceInitialTransform.__PropertyOffset_CachedSpaceIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetSpaceInitialTransform.__PropertyOffset_CachedSpaceIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005D54 RID: 23892 RVA: 0x00085FB0 File Offset: 0x000841B0
		public FRigUnit_SetSpaceInitialTransform()
		{
		}

		// Token: 0x06005D55 RID: 23893 RVA: 0x00085FB8 File Offset: 0x000841B8
		public FRigUnit_SetSpaceInitialTransform(FName SpaceName, FTransform Transform, FTransform Result, EBoneGetterSetterMode Space, FCachedRigElement CachedSpaceIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.SpaceName = SpaceName;
			this.Transform = Transform;
			this.Result = Result;
			this.Space = Space;
			this.CachedSpaceIndex = CachedSpaceIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005D56 RID: 23894 RVA: 0x00085FED File Offset: 0x000841ED
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetSpaceInitialTransform.StaticStruct();
		}

		// Token: 0x06005D57 RID: 23895 RVA: 0x00085FF9 File Offset: 0x000841F9
		[NullableContext(2)]
		public FRigUnit_SetSpaceInitialTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D58 RID: 23896 RVA: 0x00086003 File Offset: 0x00084203
		public FRigUnit_SetSpaceInitialTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D59 RID: 23897 RVA: 0x0008600E File Offset: 0x0008420E
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetSpaceInitialTransform(Pointer, false, true);
		}

		// Token: 0x06005D5A RID: 23898 RVA: 0x00086018 File Offset: 0x00084218
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetSpaceInitialTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04002BA8 RID: 11176
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetSpaceInitialTransform";

		// Token: 0x04002BA9 RID: 11177
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002BAA RID: 11178
		internal static int __PropertyOffset_SpaceName;

		// Token: 0x04002BAB RID: 11179
		internal static int __PropertyOffset_Transform;

		// Token: 0x04002BAC RID: 11180
		internal static int __PropertyOffset_Result;

		// Token: 0x04002BAD RID: 11181
		internal static int __PropertyOffset_Space;

		// Token: 0x04002BAE RID: 11182
		internal static int __PropertyOffset_CachedSpaceIndex;

		// Token: 0x04002BAF RID: 11183
		[Nullable(2)]
		private FCachedRigElement _CachedSpaceIndex;
	}
}
