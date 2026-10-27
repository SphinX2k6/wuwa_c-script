using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005AF RID: 1455
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_GetBoneTransform")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_GetBoneTransform : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004E67 RID: 20071 RVA: 0x00073D9D File Offset: 0x00071F9D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_GetBoneTransform._ScriptStructPtr != 0) ? FRigUnit_GetBoneTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_GetBoneTransform", ref FRigUnit_GetBoneTransform._ScriptStructPtr);
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x06004E68 RID: 20072 RVA: 0x00073DC1 File Offset: 0x00071FC1
		// (set) Token: 0x06004E69 RID: 20073 RVA: 0x00073DD5 File Offset: 0x00071FD5
		public unsafe FName Bone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetBoneTransform.__PropertyOffset_Bone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetBoneTransform.__PropertyOffset_Bone) = value;
			}
		}

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x06004E6A RID: 20074 RVA: 0x00073DEA File Offset: 0x00071FEA
		// (set) Token: 0x06004E6B RID: 20075 RVA: 0x00073DFA File Offset: 0x00071FFA
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_GetBoneTransform.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetBoneTransform.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x06004E6C RID: 20076 RVA: 0x00073E0B File Offset: 0x0007200B
		// (set) Token: 0x06004E6D RID: 20077 RVA: 0x00073E1F File Offset: 0x0007201F
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetBoneTransform.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetBoneTransform.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x06004E6E RID: 20078 RVA: 0x00073E34 File Offset: 0x00072034
		// (set) Token: 0x06004E6F RID: 20079 RVA: 0x00073E77 File Offset: 0x00072077
		public FCachedRigElement CachedBone
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedBone) == null)
				{
					result = (this._CachedBone = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_GetBoneTransform.__PropertyOffset_CachedBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetBoneTransform.__PropertyOffset_CachedBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004E70 RID: 20080 RVA: 0x00073E98 File Offset: 0x00072098
		public FRigUnit_GetBoneTransform()
		{
		}

		// Token: 0x06004E71 RID: 20081 RVA: 0x00073EA0 File Offset: 0x000720A0
		public FRigUnit_GetBoneTransform(FName Bone, EBoneGetterSetterMode Space, FTransform Transform, FCachedRigElement CachedBone)
		{
			this.Bone = Bone;
			this.Space = Space;
			this.Transform = Transform;
			this.CachedBone = CachedBone;
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x00073EC5 File Offset: 0x000720C5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_GetBoneTransform.StaticStruct();
		}

		// Token: 0x06004E73 RID: 20083 RVA: 0x00073ED1 File Offset: 0x000720D1
		[NullableContext(2)]
		public FRigUnit_GetBoneTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004E74 RID: 20084 RVA: 0x00073EDB File Offset: 0x000720DB
		public FRigUnit_GetBoneTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004E75 RID: 20085 RVA: 0x00073EE6 File Offset: 0x000720E6
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_GetBoneTransform(Pointer, false, true);
		}

		// Token: 0x06004E76 RID: 20086 RVA: 0x00073EF0 File Offset: 0x000720F0
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_GetBoneTransform(Pointer, MemoryOwner);
		}

		// Token: 0x040025E3 RID: 9699
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_GetBoneTransform";

		// Token: 0x040025E4 RID: 9700
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040025E5 RID: 9701
		internal static int __PropertyOffset_Bone;

		// Token: 0x040025E6 RID: 9702
		internal static int __PropertyOffset_Space;

		// Token: 0x040025E7 RID: 9703
		internal static int __PropertyOffset_Transform;

		// Token: 0x040025E8 RID: 9704
		internal static int __PropertyOffset_CachedBone;

		// Token: 0x040025E9 RID: 9705
		[Nullable(2)]
		private FCachedRigElement _CachedBone;
	}
}
