using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000527 RID: 1319
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSDK.BasicInfo")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FBasicInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007B1C RID: 31516 RVA: 0x000B4AF1 File Offset: 0x000B2CF1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBasicInfo._ScriptStructPtr != 0) ? FBasicInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSDK.BasicInfo", ref FBasicInfo._ScriptStructPtr);
		}

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x06007B1D RID: 31517 RVA: 0x000B4B15 File Offset: 0x000B2D15
		// (set) Token: 0x06007B1E RID: 31518 RVA: 0x000B4B29 File Offset: 0x000B2D29
		public unsafe string DeviceId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBasicInfo.__PropertyOffset_DeviceId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBasicInfo.__PropertyOffset_DeviceId)), value);
			}
		}

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x06007B1F RID: 31519 RVA: 0x000B4B3E File Offset: 0x000B2D3E
		// (set) Token: 0x06007B20 RID: 31520 RVA: 0x000B4B52 File Offset: 0x000B2D52
		public unsafe string Platform
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBasicInfo.__PropertyOffset_Platform)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBasicInfo.__PropertyOffset_Platform)), value);
			}
		}

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x06007B21 RID: 31521 RVA: 0x000B4B67 File Offset: 0x000B2D67
		// (set) Token: 0x06007B22 RID: 31522 RVA: 0x000B4B7B File Offset: 0x000B2D7B
		public unsafe string ModelName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBasicInfo.__PropertyOffset_ModelName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBasicInfo.__PropertyOffset_ModelName)), value);
			}
		}

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x06007B23 RID: 31523 RVA: 0x000B4B90 File Offset: 0x000B2D90
		// (set) Token: 0x06007B24 RID: 31524 RVA: 0x000B4BA4 File Offset: 0x000B2DA4
		public unsafe string CPUModelName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBasicInfo.__PropertyOffset_CPUModelName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBasicInfo.__PropertyOffset_CPUModelName)), value);
			}
		}

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x06007B25 RID: 31525 RVA: 0x000B4BB9 File Offset: 0x000B2DB9
		// (set) Token: 0x06007B26 RID: 31526 RVA: 0x000B4BC9 File Offset: 0x000B2DC9
		public unsafe bool bIsValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasicInfo.__PropertyOffset_bIsValid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasicInfo.__PropertyOffset_bIsValid) = (value ? 1 : 0);
			}
		}

		// Token: 0x06007B27 RID: 31527 RVA: 0x000B4BDA File Offset: 0x000B2DDA
		public FBasicInfo()
		{
		}

		// Token: 0x06007B28 RID: 31528 RVA: 0x000B4BE2 File Offset: 0x000B2DE2
		protected override IntPtr GetUStructPtr()
		{
			return FBasicInfo.StaticStruct();
		}

		// Token: 0x06007B29 RID: 31529 RVA: 0x000B4BEE File Offset: 0x000B2DEE
		[NullableContext(2)]
		public FBasicInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007B2A RID: 31530 RVA: 0x000B4BF8 File Offset: 0x000B2DF8
		public FBasicInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007B2B RID: 31531 RVA: 0x000B4C03 File Offset: 0x000B2E03
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBasicInfo(Pointer, false, true);
		}

		// Token: 0x06007B2C RID: 31532 RVA: 0x000B4C0D File Offset: 0x000B2E0D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBasicInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04003456 RID: 13398
		public const string __ObjectPath = "/Script/KuroSDK.BasicInfo";

		// Token: 0x04003457 RID: 13399
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003458 RID: 13400
		internal static int __PropertyOffset_DeviceId;

		// Token: 0x04003459 RID: 13401
		internal static int __PropertyOffset_Platform;

		// Token: 0x0400345A RID: 13402
		internal static int __PropertyOffset_ModelName;

		// Token: 0x0400345B RID: 13403
		internal static int __PropertyOffset_CPUModelName;

		// Token: 0x0400345C RID: 13404
		internal static int __PropertyOffset_bIsValid;
	}
}
