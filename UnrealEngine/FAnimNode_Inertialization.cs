using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000819 RID: 2073
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimNode_Inertialization")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FAnimNode_Inertialization : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006F78 RID: 28536 RVA: 0x0009FF33 File Offset: 0x0009E133
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_Inertialization._ScriptStructPtr != 0) ? FAnimNode_Inertialization._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNode_Inertialization", ref FAnimNode_Inertialization._ScriptStructPtr);
		}

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x06006F79 RID: 28537 RVA: 0x0009FF58 File Offset: 0x0009E158
		// (set) Token: 0x06006F7A RID: 28538 RVA: 0x0009FF9B File Offset: 0x0009E19B
		public FPoseLink Source
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._Source) == null)
				{
					result = (this._Source = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_Inertialization.__PropertyOffset_Source, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_Inertialization.__PropertyOffset_Source, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06006F7B RID: 28539 RVA: 0x0009FFBC File Offset: 0x0009E1BC
		public FAnimNode_Inertialization()
		{
		}

		// Token: 0x06006F7C RID: 28540 RVA: 0x0009FFC4 File Offset: 0x0009E1C4
		public FAnimNode_Inertialization(FPoseLink Source)
		{
			this.Source = Source;
		}

		// Token: 0x06006F7D RID: 28541 RVA: 0x0009FFD3 File Offset: 0x0009E1D3
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_Inertialization.StaticStruct();
		}

		// Token: 0x06006F7E RID: 28542 RVA: 0x0009FFDF File Offset: 0x0009E1DF
		[NullableContext(2)]
		public FAnimNode_Inertialization(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006F7F RID: 28543 RVA: 0x0009FFE9 File Offset: 0x0009E1E9
		public FAnimNode_Inertialization(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006F80 RID: 28544 RVA: 0x0009FFF4 File Offset: 0x0009E1F4
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_Inertialization(Pointer, false, true);
		}

		// Token: 0x06006F81 RID: 28545 RVA: 0x0009FFFE File Offset: 0x0009E1FE
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_Inertialization(Pointer, MemoryOwner);
		}

		// Token: 0x04003592 RID: 13714
		public new const string __ObjectPath = "/Script/Engine.AnimNode_Inertialization";

		// Token: 0x04003593 RID: 13715
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003594 RID: 13716
		internal static int __PropertyOffset_Source;

		// Token: 0x04003595 RID: 13717
		[Nullable(2)]
		private FPoseLink _Source;
	}
}
