using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005BA RID: 1466
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_GetInitialBoneTransform")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_GetInitialBoneTransform : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004F1F RID: 20255 RVA: 0x00074D15 File Offset: 0x00072F15
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_GetInitialBoneTransform._ScriptStructPtr != 0) ? FRigUnit_GetInitialBoneTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_GetInitialBoneTransform", ref FRigUnit_GetInitialBoneTransform._ScriptStructPtr);
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x06004F20 RID: 20256 RVA: 0x00074D39 File Offset: 0x00072F39
		// (set) Token: 0x06004F21 RID: 20257 RVA: 0x00074D4D File Offset: 0x00072F4D
		public unsafe FName Bone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetInitialBoneTransform.__PropertyOffset_Bone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetInitialBoneTransform.__PropertyOffset_Bone) = value;
			}
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x06004F22 RID: 20258 RVA: 0x00074D62 File Offset: 0x00072F62
		// (set) Token: 0x06004F23 RID: 20259 RVA: 0x00074D72 File Offset: 0x00072F72
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_GetInitialBoneTransform.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetInitialBoneTransform.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x06004F24 RID: 20260 RVA: 0x00074D83 File Offset: 0x00072F83
		// (set) Token: 0x06004F25 RID: 20261 RVA: 0x00074D97 File Offset: 0x00072F97
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetInitialBoneTransform.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetInitialBoneTransform.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x06004F26 RID: 20262 RVA: 0x00074DAC File Offset: 0x00072FAC
		// (set) Token: 0x06004F27 RID: 20263 RVA: 0x00074DEF File Offset: 0x00072FEF
		public FCachedRigElement CachedBone
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedBone) == null)
				{
					result = (this._CachedBone = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_GetInitialBoneTransform.__PropertyOffset_CachedBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetInitialBoneTransform.__PropertyOffset_CachedBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004F28 RID: 20264 RVA: 0x00074E10 File Offset: 0x00073010
		public FRigUnit_GetInitialBoneTransform()
		{
		}

		// Token: 0x06004F29 RID: 20265 RVA: 0x00074E18 File Offset: 0x00073018
		public FRigUnit_GetInitialBoneTransform(FName Bone, EBoneGetterSetterMode Space, FTransform Transform, FCachedRigElement CachedBone)
		{
			this.Bone = Bone;
			this.Space = Space;
			this.Transform = Transform;
			this.CachedBone = CachedBone;
		}

		// Token: 0x06004F2A RID: 20266 RVA: 0x00074E3D File Offset: 0x0007303D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_GetInitialBoneTransform.StaticStruct();
		}

		// Token: 0x06004F2B RID: 20267 RVA: 0x00074E49 File Offset: 0x00073049
		[NullableContext(2)]
		public FRigUnit_GetInitialBoneTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004F2C RID: 20268 RVA: 0x00074E53 File Offset: 0x00073053
		public FRigUnit_GetInitialBoneTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004F2D RID: 20269 RVA: 0x00074E5E File Offset: 0x0007305E
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_GetInitialBoneTransform(Pointer, false, true);
		}

		// Token: 0x06004F2E RID: 20270 RVA: 0x00074E68 File Offset: 0x00073068
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_GetInitialBoneTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04002633 RID: 9779
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_GetInitialBoneTransform";

		// Token: 0x04002634 RID: 9780
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002635 RID: 9781
		internal static int __PropertyOffset_Bone;

		// Token: 0x04002636 RID: 9782
		internal static int __PropertyOffset_Space;

		// Token: 0x04002637 RID: 9783
		internal static int __PropertyOffset_Transform;

		// Token: 0x04002638 RID: 9784
		internal static int __PropertyOffset_CachedBone;

		// Token: 0x04002639 RID: 9785
		[Nullable(2)]
		private FCachedRigElement _CachedBone;
	}
}
