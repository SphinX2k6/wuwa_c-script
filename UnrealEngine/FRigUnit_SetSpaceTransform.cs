using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006D0 RID: 1744
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetSpaceTransform")]
	[UnrealStructLayout(208, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FRigUnit_SetSpaceTransform : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005D5B RID: 23899 RVA: 0x00086021 File Offset: 0x00084221
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetSpaceTransform._ScriptStructPtr != 0) ? FRigUnit_SetSpaceTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetSpaceTransform", ref FRigUnit_SetSpaceTransform._ScriptStructPtr);
		}

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x06005D5C RID: 23900 RVA: 0x00086045 File Offset: 0x00084245
		// (set) Token: 0x06005D5D RID: 23901 RVA: 0x00086059 File Offset: 0x00084259
		public unsafe FName Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetSpaceTransform.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetSpaceTransform.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x06005D5E RID: 23902 RVA: 0x0008606E File Offset: 0x0008426E
		// (set) Token: 0x06005D5F RID: 23903 RVA: 0x0008607E File Offset: 0x0008427E
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetSpaceTransform.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetSpaceTransform.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x06005D60 RID: 23904 RVA: 0x0008608F File Offset: 0x0008428F
		// (set) Token: 0x06005D61 RID: 23905 RVA: 0x000860A3 File Offset: 0x000842A3
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetSpaceTransform.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetSpaceTransform.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x06005D62 RID: 23906 RVA: 0x000860B8 File Offset: 0x000842B8
		// (set) Token: 0x06005D63 RID: 23907 RVA: 0x000860C8 File Offset: 0x000842C8
		public unsafe EBoneGetterSetterMode SpaceType
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_SetSpaceTransform.__PropertyOffset_SpaceType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetSpaceTransform.__PropertyOffset_SpaceType) = (byte)value;
			}
		}

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x06005D64 RID: 23908 RVA: 0x000860DC File Offset: 0x000842DC
		// (set) Token: 0x06005D65 RID: 23909 RVA: 0x0008611F File Offset: 0x0008431F
		public FCachedRigElement CachedSpaceIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedSpaceIndex) == null)
				{
					result = (this._CachedSpaceIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetSpaceTransform.__PropertyOffset_CachedSpaceIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetSpaceTransform.__PropertyOffset_CachedSpaceIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005D66 RID: 23910 RVA: 0x00086140 File Offset: 0x00084340
		public FRigUnit_SetSpaceTransform()
		{
		}

		// Token: 0x06005D67 RID: 23911 RVA: 0x00086148 File Offset: 0x00084348
		public FRigUnit_SetSpaceTransform(FName Space, float Weight, FTransform Transform, EBoneGetterSetterMode SpaceType, FCachedRigElement CachedSpaceIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.Space = Space;
			this.Weight = Weight;
			this.Transform = Transform;
			this.SpaceType = SpaceType;
			this.CachedSpaceIndex = CachedSpaceIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005D68 RID: 23912 RVA: 0x0008617D File Offset: 0x0008437D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetSpaceTransform.StaticStruct();
		}

		// Token: 0x06005D69 RID: 23913 RVA: 0x00086189 File Offset: 0x00084389
		[NullableContext(2)]
		public FRigUnit_SetSpaceTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D6A RID: 23914 RVA: 0x00086193 File Offset: 0x00084393
		public FRigUnit_SetSpaceTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D6B RID: 23915 RVA: 0x0008619E File Offset: 0x0008439E
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetSpaceTransform(Pointer, false, true);
		}

		// Token: 0x06005D6C RID: 23916 RVA: 0x000861A8 File Offset: 0x000843A8
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetSpaceTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04002BB0 RID: 11184
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetSpaceTransform";

		// Token: 0x04002BB1 RID: 11185
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002BB2 RID: 11186
		internal static int __PropertyOffset_Space;

		// Token: 0x04002BB3 RID: 11187
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002BB4 RID: 11188
		internal static int __PropertyOffset_Transform;

		// Token: 0x04002BB5 RID: 11189
		internal static int __PropertyOffset_SpaceType;

		// Token: 0x04002BB6 RID: 11190
		internal static int __PropertyOffset_CachedSpaceIndex;

		// Token: 0x04002BB7 RID: 11191
		[Nullable(2)]
		private FCachedRigElement _CachedSpaceIndex;
	}
}
