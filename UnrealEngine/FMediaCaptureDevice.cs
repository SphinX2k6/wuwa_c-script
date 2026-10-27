using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002295 RID: 8853
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MediaAssets.MediaCaptureDevice")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMediaCaptureDevice : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021A10 RID: 137744 RVA: 0x0031C17A File Offset: 0x0031A37A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMediaCaptureDevice._ScriptStructPtr != 0) ? FMediaCaptureDevice._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MediaAssets.MediaCaptureDevice", ref FMediaCaptureDevice._ScriptStructPtr);
		}

		// Token: 0x170082A5 RID: 33445
		// (get) Token: 0x06021A11 RID: 137745 RVA: 0x0031C1A0 File Offset: 0x0031A3A0
		// (set) Token: 0x06021A12 RID: 137746 RVA: 0x0031C1E3 File Offset: 0x0031A3E3
		public unsafe FText DisplayName
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._DisplayName) == null)
				{
					result = (this._DisplayName = new FText(base.NativePtr + (IntPtr)FMediaCaptureDevice.__PropertyOffset_DisplayName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FMediaCaptureDevice.__PropertyOffset_DisplayName)), value.NativePtr, 1);
			}
		}

		// Token: 0x170082A6 RID: 33446
		// (get) Token: 0x06021A13 RID: 137747 RVA: 0x0031C1FE File Offset: 0x0031A3FE
		// (set) Token: 0x06021A14 RID: 137748 RVA: 0x0031C212 File Offset: 0x0031A412
		public unsafe string Url
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMediaCaptureDevice.__PropertyOffset_Url)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMediaCaptureDevice.__PropertyOffset_Url)), value);
			}
		}

		// Token: 0x06021A15 RID: 137749 RVA: 0x0031C227 File Offset: 0x0031A427
		public FMediaCaptureDevice()
		{
		}

		// Token: 0x06021A16 RID: 137750 RVA: 0x0031C22F File Offset: 0x0031A42F
		public FMediaCaptureDevice(FText DisplayName, string Url)
		{
			this.DisplayName = DisplayName;
			this.Url = Url;
		}

		// Token: 0x06021A17 RID: 137751 RVA: 0x0031C245 File Offset: 0x0031A445
		protected override IntPtr GetUStructPtr()
		{
			return FMediaCaptureDevice.StaticStruct();
		}

		// Token: 0x06021A18 RID: 137752 RVA: 0x0031C251 File Offset: 0x0031A451
		[NullableContext(2)]
		public FMediaCaptureDevice(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021A19 RID: 137753 RVA: 0x0031C25B File Offset: 0x0031A45B
		public FMediaCaptureDevice(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021A1A RID: 137754 RVA: 0x0031C266 File Offset: 0x0031A466
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMediaCaptureDevice(Pointer, false, true);
		}

		// Token: 0x06021A1B RID: 137755 RVA: 0x0031C270 File Offset: 0x0031A470
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMediaCaptureDevice(Pointer, MemoryOwner);
		}

		// Token: 0x04011F6B RID: 73579
		public const string __ObjectPath = "/Script/MediaAssets.MediaCaptureDevice";

		// Token: 0x04011F6C RID: 73580
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011F6D RID: 73581
		internal static int __PropertyOffset_DisplayName;

		// Token: 0x04011F6E RID: 73582
		[Nullable(2)]
		private FText _DisplayName;

		// Token: 0x04011F6F RID: 73583
		internal static int __PropertyOffset_Url;
	}
}
