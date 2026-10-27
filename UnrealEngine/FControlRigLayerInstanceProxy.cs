using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004CB RID: 1227
	[UnrealObjectPath("/Script/ControlRig.ControlRigLayerInstanceProxy")]
	[UnrealStructLayout(2576, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2576)]
	public class FControlRigLayerInstanceProxy : FAnimInstanceProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004202 RID: 16898 RVA: 0x00062BA2 File Offset: 0x00060DA2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FControlRigLayerInstanceProxy._ScriptStructPtr != 0) ? FControlRigLayerInstanceProxy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ControlRigLayerInstanceProxy", ref FControlRigLayerInstanceProxy._ScriptStructPtr);
		}

		// Token: 0x06004203 RID: 16899 RVA: 0x00062BC6 File Offset: 0x00060DC6
		public FControlRigLayerInstanceProxy()
		{
		}

		// Token: 0x06004204 RID: 16900 RVA: 0x00062BCE File Offset: 0x00060DCE
		protected override IntPtr GetUStructPtr()
		{
			return FControlRigLayerInstanceProxy.StaticStruct();
		}

		// Token: 0x06004205 RID: 16901 RVA: 0x00062BDA File Offset: 0x00060DDA
		[NullableContext(2)]
		public FControlRigLayerInstanceProxy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004206 RID: 16902 RVA: 0x00062BE4 File Offset: 0x00060DE4
		public FControlRigLayerInstanceProxy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x00062BEF File Offset: 0x00060DEF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FControlRigLayerInstanceProxy(Pointer, false, true);
		}

		// Token: 0x06004208 RID: 16904 RVA: 0x00062BF9 File Offset: 0x00060DF9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FControlRigLayerInstanceProxy(Pointer, MemoryOwner);
		}

		// Token: 0x04001F5E RID: 8030
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.ControlRigLayerInstanceProxy";

		// Token: 0x04001F5F RID: 8031
		private static IntPtr _ScriptStructPtr;
	}
}
