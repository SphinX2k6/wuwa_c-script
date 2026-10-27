using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000816 RID: 2070
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimNode_ConvertComponentToLocalSpace")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FAnimNode_ConvertComponentToLocalSpace : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006F56 RID: 28502 RVA: 0x0009FC3D File Offset: 0x0009DE3D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_ConvertComponentToLocalSpace._ScriptStructPtr != 0) ? FAnimNode_ConvertComponentToLocalSpace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNode_ConvertComponentToLocalSpace", ref FAnimNode_ConvertComponentToLocalSpace._ScriptStructPtr);
		}

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x06006F57 RID: 28503 RVA: 0x0009FC64 File Offset: 0x0009DE64
		// (set) Token: 0x06006F58 RID: 28504 RVA: 0x0009FCA7 File Offset: 0x0009DEA7
		public FComponentSpacePoseLink ComponentPose
		{
			get
			{
				base.FastCheckIsValid();
				FComponentSpacePoseLink result;
				if ((result = this._ComponentPose) == null)
				{
					result = (this._ComponentPose = new FComponentSpacePoseLink(base.NativePtr + (IntPtr)FAnimNode_ConvertComponentToLocalSpace.__PropertyOffset_ComponentPose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FComponentSpacePoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ConvertComponentToLocalSpace.__PropertyOffset_ComponentPose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06006F59 RID: 28505 RVA: 0x0009FCC8 File Offset: 0x0009DEC8
		public FAnimNode_ConvertComponentToLocalSpace()
		{
		}

		// Token: 0x06006F5A RID: 28506 RVA: 0x0009FCD0 File Offset: 0x0009DED0
		public FAnimNode_ConvertComponentToLocalSpace(FComponentSpacePoseLink ComponentPose)
		{
			this.ComponentPose = ComponentPose;
		}

		// Token: 0x06006F5B RID: 28507 RVA: 0x0009FCDF File Offset: 0x0009DEDF
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_ConvertComponentToLocalSpace.StaticStruct();
		}

		// Token: 0x06006F5C RID: 28508 RVA: 0x0009FCEB File Offset: 0x0009DEEB
		[NullableContext(2)]
		public FAnimNode_ConvertComponentToLocalSpace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006F5D RID: 28509 RVA: 0x0009FCF5 File Offset: 0x0009DEF5
		public FAnimNode_ConvertComponentToLocalSpace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006F5E RID: 28510 RVA: 0x0009FD00 File Offset: 0x0009DF00
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_ConvertComponentToLocalSpace(Pointer, false, true);
		}

		// Token: 0x06006F5F RID: 28511 RVA: 0x0009FD0A File Offset: 0x0009DF0A
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_ConvertComponentToLocalSpace(Pointer, MemoryOwner);
		}

		// Token: 0x04003583 RID: 13699
		public new const string __ObjectPath = "/Script/Engine.AnimNode_ConvertComponentToLocalSpace";

		// Token: 0x04003584 RID: 13700
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003585 RID: 13701
		internal static int __PropertyOffset_ComponentPose;

		// Token: 0x04003586 RID: 13702
		[Nullable(2)]
		private FComponentSpacePoseLink _ComponentPose;
	}
}
