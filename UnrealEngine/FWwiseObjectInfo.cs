using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A8E RID: 10894
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseObjectInfo")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FWwiseObjectInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028290 RID: 164496 RVA: 0x003D1B28 File Offset: 0x003CFD28
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseObjectInfo._ScriptStructPtr != 0) ? FWwiseObjectInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseObjectInfo", ref FWwiseObjectInfo._ScriptStructPtr);
		}

		// Token: 0x17009943 RID: 39235
		// (get) Token: 0x06028291 RID: 164497 RVA: 0x003D1B4C File Offset: 0x003CFD4C
		// (set) Token: 0x06028292 RID: 164498 RVA: 0x003D1B60 File Offset: 0x003CFD60
		public unsafe FGuid WwiseGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseObjectInfo.__PropertyOffset_WwiseGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseObjectInfo.__PropertyOffset_WwiseGuid) = value;
			}
		}

		// Token: 0x17009944 RID: 39236
		// (get) Token: 0x06028293 RID: 164499 RVA: 0x003D1B75 File Offset: 0x003CFD75
		// (set) Token: 0x06028294 RID: 164500 RVA: 0x003D1B85 File Offset: 0x003CFD85
		public unsafe uint WwiseShortId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseObjectInfo.__PropertyOffset_WwiseShortId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseObjectInfo.__PropertyOffset_WwiseShortId) = (int)value;
			}
		}

		// Token: 0x17009945 RID: 39237
		// (get) Token: 0x06028295 RID: 164501 RVA: 0x003D1B96 File Offset: 0x003CFD96
		// (set) Token: 0x06028296 RID: 164502 RVA: 0x003D1BAA File Offset: 0x003CFDAA
		public unsafe FName WwiseName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseObjectInfo.__PropertyOffset_WwiseName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseObjectInfo.__PropertyOffset_WwiseName) = value;
			}
		}

		// Token: 0x17009946 RID: 39238
		// (get) Token: 0x06028297 RID: 164503 RVA: 0x003D1BBF File Offset: 0x003CFDBF
		// (set) Token: 0x06028298 RID: 164504 RVA: 0x003D1BCF File Offset: 0x003CFDCF
		public unsafe uint HardCodedSoundBankShortId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseObjectInfo.__PropertyOffset_HardCodedSoundBankShortId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseObjectInfo.__PropertyOffset_HardCodedSoundBankShortId) = (int)value;
			}
		}

		// Token: 0x06028299 RID: 164505 RVA: 0x003D1BE0 File Offset: 0x003CFDE0
		public FWwiseObjectInfo()
		{
		}

		// Token: 0x0602829A RID: 164506 RVA: 0x003D1BE8 File Offset: 0x003CFDE8
		public FWwiseObjectInfo(FGuid WwiseGuid, uint WwiseShortId, FName WwiseName, uint HardCodedSoundBankShortId)
		{
			this.WwiseGuid = WwiseGuid;
			this.WwiseShortId = WwiseShortId;
			this.WwiseName = WwiseName;
			this.HardCodedSoundBankShortId = HardCodedSoundBankShortId;
		}

		// Token: 0x0602829B RID: 164507 RVA: 0x003D1C0D File Offset: 0x003CFE0D
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseObjectInfo.StaticStruct();
		}

		// Token: 0x0602829C RID: 164508 RVA: 0x003D1C19 File Offset: 0x003CFE19
		[NullableContext(2)]
		public FWwiseObjectInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602829D RID: 164509 RVA: 0x003D1C23 File Offset: 0x003CFE23
		public FWwiseObjectInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602829E RID: 164510 RVA: 0x003D1C2E File Offset: 0x003CFE2E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseObjectInfo(Pointer, false, true);
		}

		// Token: 0x0602829F RID: 164511 RVA: 0x003D1C38 File Offset: 0x003CFE38
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseObjectInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04016073 RID: 90227
		[Nullable(1)]
		public const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseObjectInfo";

		// Token: 0x04016074 RID: 90228
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016075 RID: 90229
		internal static int __PropertyOffset_WwiseGuid;

		// Token: 0x04016076 RID: 90230
		internal static int __PropertyOffset_WwiseShortId;

		// Token: 0x04016077 RID: 90231
		internal static int __PropertyOffset_WwiseName;

		// Token: 0x04016078 RID: 90232
		internal static int __PropertyOffset_HardCodedSoundBankShortId;
	}
}
