using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C55 RID: 3157
	[UnrealObjectPath("/Script/Engine.InputAxisProperties")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FInputAxisProperties : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A00A RID: 40970 RVA: 0x000E3741 File Offset: 0x000E1941
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputAxisProperties._ScriptStructPtr != 0) ? FInputAxisProperties._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InputAxisProperties", ref FInputAxisProperties._ScriptStructPtr);
		}

		// Token: 0x17002622 RID: 9762
		// (get) Token: 0x0600A00B RID: 40971 RVA: 0x000E3765 File Offset: 0x000E1965
		// (set) Token: 0x0600A00C RID: 40972 RVA: 0x000E3775 File Offset: 0x000E1975
		public unsafe float DeadZone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputAxisProperties.__PropertyOffset_DeadZone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputAxisProperties.__PropertyOffset_DeadZone) = value;
			}
		}

		// Token: 0x17002623 RID: 9763
		// (get) Token: 0x0600A00D RID: 40973 RVA: 0x000E3786 File Offset: 0x000E1986
		// (set) Token: 0x0600A00E RID: 40974 RVA: 0x000E3796 File Offset: 0x000E1996
		public unsafe float Sensitivity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputAxisProperties.__PropertyOffset_Sensitivity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputAxisProperties.__PropertyOffset_Sensitivity) = value;
			}
		}

		// Token: 0x17002624 RID: 9764
		// (get) Token: 0x0600A00F RID: 40975 RVA: 0x000E37A7 File Offset: 0x000E19A7
		// (set) Token: 0x0600A010 RID: 40976 RVA: 0x000E37B7 File Offset: 0x000E19B7
		public unsafe float Exponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputAxisProperties.__PropertyOffset_Exponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputAxisProperties.__PropertyOffset_Exponent) = value;
			}
		}

		// Token: 0x17002625 RID: 9765
		// (get) Token: 0x0600A011 RID: 40977 RVA: 0x000E37C8 File Offset: 0x000E19C8
		// (set) Token: 0x0600A012 RID: 40978 RVA: 0x000E37E1 File Offset: 0x000E19E1
		public unsafe bool bInvert
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FInputAxisProperties.__PropertyOffset_bInvert) & FInputAxisProperties.__PropertyMask_bInvert) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FInputAxisProperties.__PropertyOffset_bInvert) = ((*(base.NativePtr + (IntPtr)FInputAxisProperties.__PropertyOffset_bInvert) & ~FInputAxisProperties.__PropertyMask_bInvert) | (value ? FInputAxisProperties.__PropertyMask_bInvert : 0));
			}
		}

		// Token: 0x0600A013 RID: 40979 RVA: 0x000E3811 File Offset: 0x000E1A11
		public FInputAxisProperties()
		{
		}

		// Token: 0x0600A014 RID: 40980 RVA: 0x000E3819 File Offset: 0x000E1A19
		public FInputAxisProperties(float DeadZone, float Sensitivity, float Exponent, bool bInvert)
		{
			this.DeadZone = DeadZone;
			this.Sensitivity = Sensitivity;
			this.Exponent = Exponent;
			this.bInvert = bInvert;
		}

		// Token: 0x0600A015 RID: 40981 RVA: 0x000E383E File Offset: 0x000E1A3E
		protected override IntPtr GetUStructPtr()
		{
			return FInputAxisProperties.StaticStruct();
		}

		// Token: 0x0600A016 RID: 40982 RVA: 0x000E384A File Offset: 0x000E1A4A
		[NullableContext(2)]
		public FInputAxisProperties(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A017 RID: 40983 RVA: 0x000E3854 File Offset: 0x000E1A54
		public FInputAxisProperties(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A018 RID: 40984 RVA: 0x000E385F File Offset: 0x000E1A5F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputAxisProperties(Pointer, false, true);
		}

		// Token: 0x0600A019 RID: 40985 RVA: 0x000E3869 File Offset: 0x000E1A69
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputAxisProperties(Pointer, MemoryOwner);
		}

		// Token: 0x04005810 RID: 22544
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InputAxisProperties";

		// Token: 0x04005811 RID: 22545
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005812 RID: 22546
		internal static int __PropertyOffset_DeadZone;

		// Token: 0x04005813 RID: 22547
		internal static int __PropertyOffset_Sensitivity;

		// Token: 0x04005814 RID: 22548
		internal static int __PropertyOffset_Exponent;

		// Token: 0x04005815 RID: 22549
		internal static int __PropertyOffset_bInvert;

		// Token: 0x04005816 RID: 22550
		internal static byte __PropertyMask_bInvert;
	}
}
