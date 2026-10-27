using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A7B RID: 10875
	[UnrealObjectPath("/Script/WwiseObjectUtils.AkUniqueID")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FAkUniqueID : FAkUInt32Wrapper, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028198 RID: 164248 RVA: 0x003D072E File Offset: 0x003CE92E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkUniqueID._ScriptStructPtr != 0) ? FAkUniqueID._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseObjectUtils.AkUniqueID", ref FAkUniqueID._ScriptStructPtr);
		}

		// Token: 0x06028199 RID: 164249 RVA: 0x003D0752 File Offset: 0x003CE952
		public FAkUniqueID()
		{
		}

		// Token: 0x0602819A RID: 164250 RVA: 0x003D075A File Offset: 0x003CE95A
		public FAkUniqueID(uint UInt32Value)
		{
			base.UInt32Value = UInt32Value;
		}

		// Token: 0x0602819B RID: 164251 RVA: 0x003D0769 File Offset: 0x003CE969
		protected override IntPtr GetUStructPtr()
		{
			return FAkUniqueID.StaticStruct();
		}

		// Token: 0x0602819C RID: 164252 RVA: 0x003D0775 File Offset: 0x003CE975
		[NullableContext(2)]
		public FAkUniqueID(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602819D RID: 164253 RVA: 0x003D077F File Offset: 0x003CE97F
		public FAkUniqueID(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602819E RID: 164254 RVA: 0x003D078A File Offset: 0x003CE98A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkUniqueID(Pointer, false, true);
		}

		// Token: 0x0602819F RID: 164255 RVA: 0x003D0794 File Offset: 0x003CE994
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkUniqueID(Pointer, MemoryOwner);
		}

		// Token: 0x04016011 RID: 90129
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/WwiseObjectUtils.AkUniqueID";

		// Token: 0x04016012 RID: 90130
		private static IntPtr _ScriptStructPtr;
	}
}
