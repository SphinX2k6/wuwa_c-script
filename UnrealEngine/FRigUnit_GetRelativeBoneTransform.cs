using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005BC RID: 1468
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_GetRelativeBoneTransform")]
	[UnrealStructLayout(128, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FRigUnit_GetRelativeBoneTransform : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004F43 RID: 20291 RVA: 0x00074FF4 File Offset: 0x000731F4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_GetRelativeBoneTransform._ScriptStructPtr != 0) ? FRigUnit_GetRelativeBoneTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_GetRelativeBoneTransform", ref FRigUnit_GetRelativeBoneTransform._ScriptStructPtr);
		}

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x06004F44 RID: 20292 RVA: 0x00075018 File Offset: 0x00073218
		// (set) Token: 0x06004F45 RID: 20293 RVA: 0x0007502C File Offset: 0x0007322C
		public unsafe FName Bone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetRelativeBoneTransform.__PropertyOffset_Bone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetRelativeBoneTransform.__PropertyOffset_Bone) = value;
			}
		}

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06004F46 RID: 20294 RVA: 0x00075041 File Offset: 0x00073241
		// (set) Token: 0x06004F47 RID: 20295 RVA: 0x00075055 File Offset: 0x00073255
		public unsafe FName Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetRelativeBoneTransform.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetRelativeBoneTransform.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06004F48 RID: 20296 RVA: 0x0007506A File Offset: 0x0007326A
		// (set) Token: 0x06004F49 RID: 20297 RVA: 0x0007507E File Offset: 0x0007327E
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetRelativeBoneTransform.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetRelativeBoneTransform.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x06004F4A RID: 20298 RVA: 0x00075094 File Offset: 0x00073294
		// (set) Token: 0x06004F4B RID: 20299 RVA: 0x000750D7 File Offset: 0x000732D7
		public FCachedRigElement CachedBone
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedBone) == null)
				{
					result = (this._CachedBone = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_GetRelativeBoneTransform.__PropertyOffset_CachedBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetRelativeBoneTransform.__PropertyOffset_CachedBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x06004F4C RID: 20300 RVA: 0x000750F8 File Offset: 0x000732F8
		// (set) Token: 0x06004F4D RID: 20301 RVA: 0x0007513B File Offset: 0x0007333B
		public FCachedRigElement CachedSpace
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedSpace) == null)
				{
					result = (this._CachedSpace = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_GetRelativeBoneTransform.__PropertyOffset_CachedSpace, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetRelativeBoneTransform.__PropertyOffset_CachedSpace, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004F4E RID: 20302 RVA: 0x0007515C File Offset: 0x0007335C
		public FRigUnit_GetRelativeBoneTransform()
		{
		}

		// Token: 0x06004F4F RID: 20303 RVA: 0x00075164 File Offset: 0x00073364
		public FRigUnit_GetRelativeBoneTransform(FName Bone, FName Space, FTransform Transform, FCachedRigElement CachedBone, FCachedRigElement CachedSpace)
		{
			this.Bone = Bone;
			this.Space = Space;
			this.Transform = Transform;
			this.CachedBone = CachedBone;
			this.CachedSpace = CachedSpace;
		}

		// Token: 0x06004F50 RID: 20304 RVA: 0x00075191 File Offset: 0x00073391
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_GetRelativeBoneTransform.StaticStruct();
		}

		// Token: 0x06004F51 RID: 20305 RVA: 0x0007519D File Offset: 0x0007339D
		[NullableContext(2)]
		public FRigUnit_GetRelativeBoneTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004F52 RID: 20306 RVA: 0x000751A7 File Offset: 0x000733A7
		public FRigUnit_GetRelativeBoneTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004F53 RID: 20307 RVA: 0x000751B2 File Offset: 0x000733B2
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_GetRelativeBoneTransform(Pointer, false, true);
		}

		// Token: 0x06004F54 RID: 20308 RVA: 0x000751BC File Offset: 0x000733BC
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_GetRelativeBoneTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04002642 RID: 9794
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_GetRelativeBoneTransform";

		// Token: 0x04002643 RID: 9795
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002644 RID: 9796
		internal static int __PropertyOffset_Bone;

		// Token: 0x04002645 RID: 9797
		internal static int __PropertyOffset_Space;

		// Token: 0x04002646 RID: 9798
		internal static int __PropertyOffset_Transform;

		// Token: 0x04002647 RID: 9799
		internal static int __PropertyOffset_CachedBone;

		// Token: 0x04002648 RID: 9800
		[Nullable(2)]
		private FCachedRigElement _CachedBone;

		// Token: 0x04002649 RID: 9801
		internal static int __PropertyOffset_CachedSpace;

		// Token: 0x0400264A RID: 9802
		[Nullable(2)]
		private FCachedRigElement _CachedSpace;
	}
}
