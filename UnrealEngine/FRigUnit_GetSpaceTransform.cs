using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005BF RID: 1471
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_GetSpaceTransform")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_GetSpaceTransform : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004F73 RID: 20339 RVA: 0x000754E1 File Offset: 0x000736E1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_GetSpaceTransform._ScriptStructPtr != 0) ? FRigUnit_GetSpaceTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_GetSpaceTransform", ref FRigUnit_GetSpaceTransform._ScriptStructPtr);
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x06004F74 RID: 20340 RVA: 0x00075505 File Offset: 0x00073705
		// (set) Token: 0x06004F75 RID: 20341 RVA: 0x00075519 File Offset: 0x00073719
		public unsafe FName Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetSpaceTransform.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetSpaceTransform.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x06004F76 RID: 20342 RVA: 0x0007552E File Offset: 0x0007372E
		// (set) Token: 0x06004F77 RID: 20343 RVA: 0x0007553E File Offset: 0x0007373E
		public unsafe EBoneGetterSetterMode SpaceType
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_GetSpaceTransform.__PropertyOffset_SpaceType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetSpaceTransform.__PropertyOffset_SpaceType) = (byte)value;
			}
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x06004F78 RID: 20344 RVA: 0x0007554F File Offset: 0x0007374F
		// (set) Token: 0x06004F79 RID: 20345 RVA: 0x00075563 File Offset: 0x00073763
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetSpaceTransform.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetSpaceTransform.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x06004F7A RID: 20346 RVA: 0x00075578 File Offset: 0x00073778
		// (set) Token: 0x06004F7B RID: 20347 RVA: 0x000755BB File Offset: 0x000737BB
		public FCachedRigElement CachedSpaceIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedSpaceIndex) == null)
				{
					result = (this._CachedSpaceIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_GetSpaceTransform.__PropertyOffset_CachedSpaceIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetSpaceTransform.__PropertyOffset_CachedSpaceIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x000755DC File Offset: 0x000737DC
		public FRigUnit_GetSpaceTransform()
		{
		}

		// Token: 0x06004F7D RID: 20349 RVA: 0x000755E4 File Offset: 0x000737E4
		public FRigUnit_GetSpaceTransform(FName Space, EBoneGetterSetterMode SpaceType, FTransform Transform, FCachedRigElement CachedSpaceIndex)
		{
			this.Space = Space;
			this.SpaceType = SpaceType;
			this.Transform = Transform;
			this.CachedSpaceIndex = CachedSpaceIndex;
		}

		// Token: 0x06004F7E RID: 20350 RVA: 0x00075609 File Offset: 0x00073809
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_GetSpaceTransform.StaticStruct();
		}

		// Token: 0x06004F7F RID: 20351 RVA: 0x00075615 File Offset: 0x00073815
		[NullableContext(2)]
		public FRigUnit_GetSpaceTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004F80 RID: 20352 RVA: 0x0007561F File Offset: 0x0007381F
		public FRigUnit_GetSpaceTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004F81 RID: 20353 RVA: 0x0007562A File Offset: 0x0007382A
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_GetSpaceTransform(Pointer, false, true);
		}

		// Token: 0x06004F82 RID: 20354 RVA: 0x00075634 File Offset: 0x00073834
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_GetSpaceTransform(Pointer, MemoryOwner);
		}

		// Token: 0x0400265A RID: 9818
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_GetSpaceTransform";

		// Token: 0x0400265B RID: 9819
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400265C RID: 9820
		internal static int __PropertyOffset_Space;

		// Token: 0x0400265D RID: 9821
		internal static int __PropertyOffset_SpaceType;

		// Token: 0x0400265E RID: 9822
		internal static int __PropertyOffset_Transform;

		// Token: 0x0400265F RID: 9823
		internal static int __PropertyOffset_CachedSpaceIndex;

		// Token: 0x04002660 RID: 9824
		[Nullable(2)]
		private FCachedRigElement _CachedSpaceIndex;
	}
}
