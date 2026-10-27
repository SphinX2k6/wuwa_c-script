using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A86 RID: 10886
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseGroupValueInfo")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FWwiseGroupValueInfo : FWwiseObjectInfo, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602821D RID: 164381 RVA: 0x003D11ED File Offset: 0x003CF3ED
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseGroupValueInfo._ScriptStructPtr != 0) ? FWwiseGroupValueInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseGroupValueInfo", ref FWwiseGroupValueInfo._ScriptStructPtr);
		}

		// Token: 0x17009932 RID: 39218
		// (get) Token: 0x0602821E RID: 164382 RVA: 0x003D1211 File Offset: 0x003CF411
		// (set) Token: 0x0602821F RID: 164383 RVA: 0x003D1221 File Offset: 0x003CF421
		public unsafe uint GroupShortId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseGroupValueInfo.__PropertyOffset_GroupShortId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseGroupValueInfo.__PropertyOffset_GroupShortId) = (int)value;
			}
		}

		// Token: 0x06028220 RID: 164384 RVA: 0x003D1232 File Offset: 0x003CF432
		public FWwiseGroupValueInfo()
		{
		}

		// Token: 0x06028221 RID: 164385 RVA: 0x003D123A File Offset: 0x003CF43A
		public FWwiseGroupValueInfo(uint GroupShortId, FGuid WwiseGuid, uint WwiseShortId, FName WwiseName, uint HardCodedSoundBankShortId)
		{
			this.GroupShortId = GroupShortId;
			base.WwiseGuid = WwiseGuid;
			base.WwiseShortId = WwiseShortId;
			base.WwiseName = WwiseName;
			base.HardCodedSoundBankShortId = HardCodedSoundBankShortId;
		}

		// Token: 0x06028222 RID: 164386 RVA: 0x003D1267 File Offset: 0x003CF467
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseGroupValueInfo.StaticStruct();
		}

		// Token: 0x06028223 RID: 164387 RVA: 0x003D1273 File Offset: 0x003CF473
		[NullableContext(2)]
		public FWwiseGroupValueInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028224 RID: 164388 RVA: 0x003D127D File Offset: 0x003CF47D
		public FWwiseGroupValueInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028225 RID: 164389 RVA: 0x003D1288 File Offset: 0x003CF488
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseGroupValueInfo(Pointer, false, true);
		}

		// Token: 0x06028226 RID: 164390 RVA: 0x003D1292 File Offset: 0x003CF492
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseGroupValueInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0401604B RID: 90187
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseGroupValueInfo";

		// Token: 0x0401604C RID: 90188
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401604D RID: 90189
		internal static int __PropertyOffset_GroupShortId;
	}
}
