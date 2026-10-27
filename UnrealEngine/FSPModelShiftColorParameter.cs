using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020019AB RID: 6571
	[UnrealObjectPath("/Script/KuroInteractionEffect.SPModelShiftColorParameter")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSPModelShiftColorParameter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601873B RID: 100155 RVA: 0x002408F4 File Offset: 0x0023EAF4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSPModelShiftColorParameter._ScriptStructPtr != 0) ? FSPModelShiftColorParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.SPModelShiftColorParameter", ref FSPModelShiftColorParameter._ScriptStructPtr);
		}

		// Token: 0x170061A8 RID: 25000
		// (get) Token: 0x0601873C RID: 100156 RVA: 0x00240918 File Offset: 0x0023EB18
		// (set) Token: 0x0601873D RID: 100157 RVA: 0x0024092C File Offset: 0x0023EB2C
		public unsafe FLinearColor LowGrayColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSPModelShiftColorParameter.__PropertyOffset_LowGrayColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSPModelShiftColorParameter.__PropertyOffset_LowGrayColor) = value;
			}
		}

		// Token: 0x170061A9 RID: 25001
		// (get) Token: 0x0601873E RID: 100158 RVA: 0x00240941 File Offset: 0x0023EB41
		// (set) Token: 0x0601873F RID: 100159 RVA: 0x00240955 File Offset: 0x0023EB55
		public unsafe FLinearColor HighGrayColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSPModelShiftColorParameter.__PropertyOffset_HighGrayColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSPModelShiftColorParameter.__PropertyOffset_HighGrayColor) = value;
			}
		}

		// Token: 0x06018740 RID: 100160 RVA: 0x0024096A File Offset: 0x0023EB6A
		public FSPModelShiftColorParameter()
		{
		}

		// Token: 0x06018741 RID: 100161 RVA: 0x00240972 File Offset: 0x0023EB72
		public FSPModelShiftColorParameter(FLinearColor LowGrayColor, FLinearColor HighGrayColor)
		{
			this.LowGrayColor = LowGrayColor;
			this.HighGrayColor = HighGrayColor;
		}

		// Token: 0x06018742 RID: 100162 RVA: 0x00240988 File Offset: 0x0023EB88
		protected override IntPtr GetUStructPtr()
		{
			return FSPModelShiftColorParameter.StaticStruct();
		}

		// Token: 0x06018743 RID: 100163 RVA: 0x00240994 File Offset: 0x0023EB94
		[NullableContext(2)]
		public FSPModelShiftColorParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018744 RID: 100164 RVA: 0x0024099E File Offset: 0x0023EB9E
		public FSPModelShiftColorParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018745 RID: 100165 RVA: 0x002409A9 File Offset: 0x0023EBA9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSPModelShiftColorParameter(Pointer, false, true);
		}

		// Token: 0x06018746 RID: 100166 RVA: 0x002409B3 File Offset: 0x0023EBB3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSPModelShiftColorParameter(Pointer, MemoryOwner);
		}

		// Token: 0x0400D35C RID: 54108
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroInteractionEffect.SPModelShiftColorParameter";

		// Token: 0x0400D35D RID: 54109
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D35E RID: 54110
		internal static int __PropertyOffset_LowGrayColor;

		// Token: 0x0400D35F RID: 54111
		internal static int __PropertyOffset_HighGrayColor;
	}
}
