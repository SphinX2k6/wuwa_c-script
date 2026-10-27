using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C57 RID: 3159
	[UnrealObjectPath("/Script/Engine.InputClampConstants")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FInputClampConstants : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A024 RID: 40996 RVA: 0x000E3934 File Offset: 0x000E1B34
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputClampConstants._ScriptStructPtr != 0) ? FInputClampConstants._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InputClampConstants", ref FInputClampConstants._ScriptStructPtr);
		}

		// Token: 0x17002627 RID: 9767
		// (get) Token: 0x0600A025 RID: 40997 RVA: 0x000E3958 File Offset: 0x000E1B58
		// (set) Token: 0x0600A026 RID: 40998 RVA: 0x000E3968 File Offset: 0x000E1B68
		public unsafe bool bClampResult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputClampConstants.__PropertyOffset_bClampResult) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputClampConstants.__PropertyOffset_bClampResult) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002628 RID: 9768
		// (get) Token: 0x0600A027 RID: 40999 RVA: 0x000E3979 File Offset: 0x000E1B79
		// (set) Token: 0x0600A028 RID: 41000 RVA: 0x000E3989 File Offset: 0x000E1B89
		public unsafe bool bInterpResult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputClampConstants.__PropertyOffset_bInterpResult) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputClampConstants.__PropertyOffset_bInterpResult) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002629 RID: 9769
		// (get) Token: 0x0600A029 RID: 41001 RVA: 0x000E399A File Offset: 0x000E1B9A
		// (set) Token: 0x0600A02A RID: 41002 RVA: 0x000E39AA File Offset: 0x000E1BAA
		public unsafe float ClampMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputClampConstants.__PropertyOffset_ClampMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputClampConstants.__PropertyOffset_ClampMin) = value;
			}
		}

		// Token: 0x1700262A RID: 9770
		// (get) Token: 0x0600A02B RID: 41003 RVA: 0x000E39BB File Offset: 0x000E1BBB
		// (set) Token: 0x0600A02C RID: 41004 RVA: 0x000E39CB File Offset: 0x000E1BCB
		public unsafe float ClampMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputClampConstants.__PropertyOffset_ClampMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputClampConstants.__PropertyOffset_ClampMax) = value;
			}
		}

		// Token: 0x1700262B RID: 9771
		// (get) Token: 0x0600A02D RID: 41005 RVA: 0x000E39DC File Offset: 0x000E1BDC
		// (set) Token: 0x0600A02E RID: 41006 RVA: 0x000E39EC File Offset: 0x000E1BEC
		public unsafe float InterpSpeedIncreasing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputClampConstants.__PropertyOffset_InterpSpeedIncreasing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputClampConstants.__PropertyOffset_InterpSpeedIncreasing) = value;
			}
		}

		// Token: 0x1700262C RID: 9772
		// (get) Token: 0x0600A02F RID: 41007 RVA: 0x000E39FD File Offset: 0x000E1BFD
		// (set) Token: 0x0600A030 RID: 41008 RVA: 0x000E3A0D File Offset: 0x000E1C0D
		public unsafe float InterpSpeedDecreasing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputClampConstants.__PropertyOffset_InterpSpeedDecreasing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputClampConstants.__PropertyOffset_InterpSpeedDecreasing) = value;
			}
		}

		// Token: 0x0600A031 RID: 41009 RVA: 0x000E3A1E File Offset: 0x000E1C1E
		public FInputClampConstants()
		{
		}

		// Token: 0x0600A032 RID: 41010 RVA: 0x000E3A26 File Offset: 0x000E1C26
		public FInputClampConstants(bool bClampResult, bool bInterpResult, float ClampMin, float ClampMax, float InterpSpeedIncreasing, float InterpSpeedDecreasing)
		{
			this.bClampResult = bClampResult;
			this.bInterpResult = bInterpResult;
			this.ClampMin = ClampMin;
			this.ClampMax = ClampMax;
			this.InterpSpeedIncreasing = InterpSpeedIncreasing;
			this.InterpSpeedDecreasing = InterpSpeedDecreasing;
		}

		// Token: 0x0600A033 RID: 41011 RVA: 0x000E3A5B File Offset: 0x000E1C5B
		protected override IntPtr GetUStructPtr()
		{
			return FInputClampConstants.StaticStruct();
		}

		// Token: 0x0600A034 RID: 41012 RVA: 0x000E3A67 File Offset: 0x000E1C67
		[NullableContext(2)]
		public FInputClampConstants(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A035 RID: 41013 RVA: 0x000E3A71 File Offset: 0x000E1C71
		public FInputClampConstants(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A036 RID: 41014 RVA: 0x000E3A7C File Offset: 0x000E1C7C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputClampConstants(Pointer, false, true);
		}

		// Token: 0x0600A037 RID: 41015 RVA: 0x000E3A86 File Offset: 0x000E1C86
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputClampConstants(Pointer, MemoryOwner);
		}

		// Token: 0x0400581B RID: 22555
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InputClampConstants";

		// Token: 0x0400581C RID: 22556
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400581D RID: 22557
		internal static int __PropertyOffset_bClampResult;

		// Token: 0x0400581E RID: 22558
		internal static int __PropertyOffset_bInterpResult;

		// Token: 0x0400581F RID: 22559
		internal static int __PropertyOffset_ClampMin;

		// Token: 0x04005820 RID: 22560
		internal static int __PropertyOffset_ClampMax;

		// Token: 0x04005821 RID: 22561
		internal static int __PropertyOffset_InterpSpeedIncreasing;

		// Token: 0x04005822 RID: 22562
		internal static int __PropertyOffset_InterpSpeedDecreasing;
	}
}
