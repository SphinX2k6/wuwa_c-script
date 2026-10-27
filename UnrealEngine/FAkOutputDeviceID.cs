using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A78 RID: 10872
	[UnrealObjectPath("/Script/WwiseObjectUtils.AkOutputDeviceID")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FAkOutputDeviceID : FAkUInt64Wrapper, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602817C RID: 164220 RVA: 0x003D059F File Offset: 0x003CE79F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkOutputDeviceID._ScriptStructPtr != 0) ? FAkOutputDeviceID._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseObjectUtils.AkOutputDeviceID", ref FAkOutputDeviceID._ScriptStructPtr);
		}

		// Token: 0x0602817D RID: 164221 RVA: 0x003D05C3 File Offset: 0x003CE7C3
		public FAkOutputDeviceID()
		{
		}

		// Token: 0x0602817E RID: 164222 RVA: 0x003D05CB File Offset: 0x003CE7CB
		public FAkOutputDeviceID(ulong UInt64Value)
		{
			base.UInt64Value = UInt64Value;
		}

		// Token: 0x0602817F RID: 164223 RVA: 0x003D05DA File Offset: 0x003CE7DA
		protected override IntPtr GetUStructPtr()
		{
			return FAkOutputDeviceID.StaticStruct();
		}

		// Token: 0x06028180 RID: 164224 RVA: 0x003D05E6 File Offset: 0x003CE7E6
		[NullableContext(2)]
		public FAkOutputDeviceID(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028181 RID: 164225 RVA: 0x003D05F0 File Offset: 0x003CE7F0
		public FAkOutputDeviceID(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028182 RID: 164226 RVA: 0x003D05FB File Offset: 0x003CE7FB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkOutputDeviceID(Pointer, false, true);
		}

		// Token: 0x06028183 RID: 164227 RVA: 0x003D0605 File Offset: 0x003CE805
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkOutputDeviceID(Pointer, MemoryOwner);
		}

		// Token: 0x04016009 RID: 90121
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/WwiseObjectUtils.AkOutputDeviceID";

		// Token: 0x0401600A RID: 90122
		private static IntPtr _ScriptStructPtr;
	}
}
