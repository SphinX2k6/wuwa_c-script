using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002078 RID: 8312
	[UnrealObjectPath("/Script/LGUI.LGUIFixedInfo")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FLGUIFixedInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F5A7 RID: 128423 RVA: 0x002E9289 File Offset: 0x002E7489
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIFixedInfo._ScriptStructPtr != 0) ? FLGUIFixedInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIFixedInfo", ref FLGUIFixedInfo._ScriptStructPtr);
		}

		// Token: 0x17007BCA RID: 31690
		// (get) Token: 0x0601F5A8 RID: 128424 RVA: 0x002E92AD File Offset: 0x002E74AD
		// (set) Token: 0x0601F5A9 RID: 128425 RVA: 0x002E92BD File Offset: 0x002E74BD
		public unsafe int ResolutionWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIFixedInfo.__PropertyOffset_ResolutionWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIFixedInfo.__PropertyOffset_ResolutionWidth) = value;
			}
		}

		// Token: 0x17007BCB RID: 31691
		// (get) Token: 0x0601F5AA RID: 128426 RVA: 0x002E92CE File Offset: 0x002E74CE
		// (set) Token: 0x0601F5AB RID: 128427 RVA: 0x002E92DE File Offset: 0x002E74DE
		public unsafe int ResolutionHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIFixedInfo.__PropertyOffset_ResolutionHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIFixedInfo.__PropertyOffset_ResolutionHeight) = value;
			}
		}

		// Token: 0x17007BCC RID: 31692
		// (get) Token: 0x0601F5AC RID: 128428 RVA: 0x002E92EF File Offset: 0x002E74EF
		// (set) Token: 0x0601F5AD RID: 128429 RVA: 0x002E9303 File Offset: 0x002E7503
		public unsafe FVector OverlayLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIFixedInfo.__PropertyOffset_OverlayLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIFixedInfo.__PropertyOffset_OverlayLocation) = value;
			}
		}

		// Token: 0x17007BCD RID: 31693
		// (get) Token: 0x0601F5AE RID: 128430 RVA: 0x002E9318 File Offset: 0x002E7518
		// (set) Token: 0x0601F5AF RID: 128431 RVA: 0x002E932C File Offset: 0x002E752C
		public unsafe FRotator OverlayRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIFixedInfo.__PropertyOffset_OverlayRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIFixedInfo.__PropertyOffset_OverlayRotation) = value;
			}
		}

		// Token: 0x0601F5B0 RID: 128432 RVA: 0x002E9341 File Offset: 0x002E7541
		public FLGUIFixedInfo()
		{
		}

		// Token: 0x0601F5B1 RID: 128433 RVA: 0x002E9349 File Offset: 0x002E7549
		public FLGUIFixedInfo(int ResolutionWidth, int ResolutionHeight, FVector OverlayLocation, FRotator OverlayRotation)
		{
			this.ResolutionWidth = ResolutionWidth;
			this.ResolutionHeight = ResolutionHeight;
			this.OverlayLocation = OverlayLocation;
			this.OverlayRotation = OverlayRotation;
		}

		// Token: 0x0601F5B2 RID: 128434 RVA: 0x002E936E File Offset: 0x002E756E
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIFixedInfo.StaticStruct();
		}

		// Token: 0x0601F5B3 RID: 128435 RVA: 0x002E937A File Offset: 0x002E757A
		[NullableContext(2)]
		public FLGUIFixedInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F5B4 RID: 128436 RVA: 0x002E9384 File Offset: 0x002E7584
		public FLGUIFixedInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F5B5 RID: 128437 RVA: 0x002E938F File Offset: 0x002E758F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIFixedInfo(Pointer, false, true);
		}

		// Token: 0x0601F5B6 RID: 128438 RVA: 0x002E9399 File Offset: 0x002E7599
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIFixedInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04010F0E RID: 69390
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIFixedInfo";

		// Token: 0x04010F0F RID: 69391
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010F10 RID: 69392
		internal static int __PropertyOffset_ResolutionWidth;

		// Token: 0x04010F11 RID: 69393
		internal static int __PropertyOffset_ResolutionHeight;

		// Token: 0x04010F12 RID: 69394
		internal static int __PropertyOffset_OverlayLocation;

		// Token: 0x04010F13 RID: 69395
		internal static int __PropertyOffset_OverlayRotation;
	}
}
