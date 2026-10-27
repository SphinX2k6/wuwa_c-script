using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200033E RID: 830
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.ReferenceBoneFrame")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FReferenceBoneFrame : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002E4F RID: 11855 RVA: 0x00046FDB File Offset: 0x000451DB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FReferenceBoneFrame._ScriptStructPtr != 0) ? FReferenceBoneFrame._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.ReferenceBoneFrame", ref FReferenceBoneFrame._ScriptStructPtr);
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06002E50 RID: 11856 RVA: 0x00047000 File Offset: 0x00045200
		// (set) Token: 0x06002E51 RID: 11857 RVA: 0x00047043 File Offset: 0x00045243
		public FBoneReference Bone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._Bone) == null)
				{
					result = (this._Bone = new FBoneReference(base.NativePtr + (IntPtr)FReferenceBoneFrame.__PropertyOffset_Bone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FReferenceBoneFrame.__PropertyOffset_Bone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06002E52 RID: 11858 RVA: 0x00047064 File Offset: 0x00045264
		// (set) Token: 0x06002E53 RID: 11859 RVA: 0x000470A7 File Offset: 0x000452A7
		public FAxis Axis
		{
			get
			{
				base.FastCheckIsValid();
				FAxis result;
				if ((result = this._Axis) == null)
				{
					result = (this._Axis = new FAxis(base.NativePtr + (IntPtr)FReferenceBoneFrame.__PropertyOffset_Axis, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAxis.StaticStruct(), base.NativePtr + (IntPtr)FReferenceBoneFrame.__PropertyOffset_Axis, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06002E54 RID: 11860 RVA: 0x000470C8 File Offset: 0x000452C8
		public FReferenceBoneFrame()
		{
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x000470D0 File Offset: 0x000452D0
		public FReferenceBoneFrame(FBoneReference Bone, FAxis Axis)
		{
			this.Bone = Bone;
			this.Axis = Axis;
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x000470E6 File Offset: 0x000452E6
		protected override IntPtr GetUStructPtr()
		{
			return FReferenceBoneFrame.StaticStruct();
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x000470F2 File Offset: 0x000452F2
		[NullableContext(2)]
		public FReferenceBoneFrame(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x000470FC File Offset: 0x000452FC
		public FReferenceBoneFrame(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x00047107 File Offset: 0x00045307
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FReferenceBoneFrame(Pointer, false, true);
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x00047111 File Offset: 0x00045311
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FReferenceBoneFrame(Pointer, MemoryOwner);
		}

		// Token: 0x040013D8 RID: 5080
		public const string __ObjectPath = "/Script/AnimGraphRuntime.ReferenceBoneFrame";

		// Token: 0x040013D9 RID: 5081
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040013DA RID: 5082
		internal static int __PropertyOffset_Bone;

		// Token: 0x040013DB RID: 5083
		[Nullable(2)]
		private FBoneReference _Bone;

		// Token: 0x040013DC RID: 5084
		internal static int __PropertyOffset_Axis;

		// Token: 0x040013DD RID: 5085
		[Nullable(2)]
		private FAxis _Axis;
	}
}
