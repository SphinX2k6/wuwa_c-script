using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000817 RID: 2071
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimNode_ConvertLocalToComponentSpace")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FAnimNode_ConvertLocalToComponentSpace : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006F60 RID: 28512 RVA: 0x0009FD13 File Offset: 0x0009DF13
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_ConvertLocalToComponentSpace._ScriptStructPtr != 0) ? FAnimNode_ConvertLocalToComponentSpace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNode_ConvertLocalToComponentSpace", ref FAnimNode_ConvertLocalToComponentSpace._ScriptStructPtr);
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x06006F61 RID: 28513 RVA: 0x0009FD38 File Offset: 0x0009DF38
		// (set) Token: 0x06006F62 RID: 28514 RVA: 0x0009FD7B File Offset: 0x0009DF7B
		public FPoseLink LocalPose
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._LocalPose) == null)
				{
					result = (this._LocalPose = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_ConvertLocalToComponentSpace.__PropertyOffset_LocalPose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ConvertLocalToComponentSpace.__PropertyOffset_LocalPose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06006F63 RID: 28515 RVA: 0x0009FD9C File Offset: 0x0009DF9C
		public FAnimNode_ConvertLocalToComponentSpace()
		{
		}

		// Token: 0x06006F64 RID: 28516 RVA: 0x0009FDA4 File Offset: 0x0009DFA4
		public FAnimNode_ConvertLocalToComponentSpace(FPoseLink LocalPose)
		{
			this.LocalPose = LocalPose;
		}

		// Token: 0x06006F65 RID: 28517 RVA: 0x0009FDB3 File Offset: 0x0009DFB3
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_ConvertLocalToComponentSpace.StaticStruct();
		}

		// Token: 0x06006F66 RID: 28518 RVA: 0x0009FDBF File Offset: 0x0009DFBF
		[NullableContext(2)]
		public FAnimNode_ConvertLocalToComponentSpace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006F67 RID: 28519 RVA: 0x0009FDC9 File Offset: 0x0009DFC9
		public FAnimNode_ConvertLocalToComponentSpace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006F68 RID: 28520 RVA: 0x0009FDD4 File Offset: 0x0009DFD4
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_ConvertLocalToComponentSpace(Pointer, false, true);
		}

		// Token: 0x06006F69 RID: 28521 RVA: 0x0009FDDE File Offset: 0x0009DFDE
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_ConvertLocalToComponentSpace(Pointer, MemoryOwner);
		}

		// Token: 0x04003587 RID: 13703
		public new const string __ObjectPath = "/Script/Engine.AnimNode_ConvertLocalToComponentSpace";

		// Token: 0x04003588 RID: 13704
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003589 RID: 13705
		internal static int __PropertyOffset_LocalPose;

		// Token: 0x0400358A RID: 13706
		[Nullable(2)]
		private FPoseLink _LocalPose;
	}
}
