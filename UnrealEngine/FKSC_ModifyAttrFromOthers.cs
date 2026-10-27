using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001E00 RID: 7680
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_ModifyAttrFromOthers")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FKSC_ModifyAttrFromOthers : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D564 RID: 120164 RVA: 0x002B4F8E File Offset: 0x002B318E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_ModifyAttrFromOthers._ScriptStructPtr != 0) ? FKSC_ModifyAttrFromOthers._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_ModifyAttrFromOthers", ref FKSC_ModifyAttrFromOthers._ScriptStructPtr);
		}

		// Token: 0x1700766E RID: 30318
		// (get) Token: 0x0601D565 RID: 120165 RVA: 0x002B4FB2 File Offset: 0x002B31B2
		// (set) Token: 0x0601D566 RID: 120166 RVA: 0x002B4FC2 File Offset: 0x002B31C2
		public unsafe EKSC_AttrType ToAttrId
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)FKSC_ModifyAttrFromOthers.__PropertyOffset_ToAttrId));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_ModifyAttrFromOthers.__PropertyOffset_ToAttrId) = (byte)value;
			}
		}

		// Token: 0x1700766F RID: 30319
		// (get) Token: 0x0601D567 RID: 120167 RVA: 0x002B4FD3 File Offset: 0x002B31D3
		// (set) Token: 0x0601D568 RID: 120168 RVA: 0x002B4FE3 File Offset: 0x002B31E3
		public unsafe EKSC_AttrType FromAttrId
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)FKSC_ModifyAttrFromOthers.__PropertyOffset_FromAttrId));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_ModifyAttrFromOthers.__PropertyOffset_FromAttrId) = (byte)value;
			}
		}

		// Token: 0x17007670 RID: 30320
		// (get) Token: 0x0601D569 RID: 120169 RVA: 0x002B4FF4 File Offset: 0x002B31F4
		// (set) Token: 0x0601D56A RID: 120170 RVA: 0x002B5004 File Offset: 0x002B3204
		public unsafe float Amplify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_ModifyAttrFromOthers.__PropertyOffset_Amplify);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_ModifyAttrFromOthers.__PropertyOffset_Amplify) = value;
			}
		}

		// Token: 0x0601D56B RID: 120171 RVA: 0x002B5015 File Offset: 0x002B3215
		public FKSC_ModifyAttrFromOthers()
		{
		}

		// Token: 0x0601D56C RID: 120172 RVA: 0x002B501D File Offset: 0x002B321D
		public FKSC_ModifyAttrFromOthers(EKSC_AttrType ToAttrId, EKSC_AttrType FromAttrId, float Amplify)
		{
			this.ToAttrId = ToAttrId;
			this.FromAttrId = FromAttrId;
			this.Amplify = Amplify;
		}

		// Token: 0x0601D56D RID: 120173 RVA: 0x002B503A File Offset: 0x002B323A
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_ModifyAttrFromOthers.StaticStruct();
		}

		// Token: 0x0601D56E RID: 120174 RVA: 0x002B5046 File Offset: 0x002B3246
		[NullableContext(2)]
		public FKSC_ModifyAttrFromOthers(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D56F RID: 120175 RVA: 0x002B5050 File Offset: 0x002B3250
		public FKSC_ModifyAttrFromOthers(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D570 RID: 120176 RVA: 0x002B505B File Offset: 0x002B325B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_ModifyAttrFromOthers(Pointer, false, true);
		}

		// Token: 0x0601D571 RID: 120177 RVA: 0x002B5065 File Offset: 0x002B3265
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_ModifyAttrFromOthers(Pointer, MemoryOwner);
		}

		// Token: 0x0400FEA3 RID: 65187
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_ModifyAttrFromOthers";

		// Token: 0x0400FEA4 RID: 65188
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FEA5 RID: 65189
		internal static int __PropertyOffset_ToAttrId;

		// Token: 0x0400FEA6 RID: 65190
		internal static int __PropertyOffset_FromAttrId;

		// Token: 0x0400FEA7 RID: 65191
		internal static int __PropertyOffset_Amplify;
	}
}
