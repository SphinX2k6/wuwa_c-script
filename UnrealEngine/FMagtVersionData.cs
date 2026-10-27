using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200227A RID: 8826
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MagtModule.MagtVersionData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMagtVersionData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060218F5 RID: 137461 RVA: 0x0031A313 File Offset: 0x00318513
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMagtVersionData._ScriptStructPtr != 0) ? FMagtVersionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MagtModule.MagtVersionData", ref FMagtVersionData._ScriptStructPtr);
		}

		// Token: 0x17008270 RID: 33392
		// (get) Token: 0x060218F6 RID: 137462 RVA: 0x0031A337 File Offset: 0x00318537
		// (set) Token: 0x060218F7 RID: 137463 RVA: 0x0031A34B File Offset: 0x0031854B
		public unsafe string SDKVersion
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMagtVersionData.__PropertyOffset_SDKVersion)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMagtVersionData.__PropertyOffset_SDKVersion)), value);
			}
		}

		// Token: 0x17008271 RID: 33393
		// (get) Token: 0x060218F8 RID: 137464 RVA: 0x0031A360 File Offset: 0x00318560
		// (set) Token: 0x060218F9 RID: 137465 RVA: 0x0031A370 File Offset: 0x00318570
		public unsafe int SDKVersionId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtVersionData.__PropertyOffset_SDKVersionId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtVersionData.__PropertyOffset_SDKVersionId) = value;
			}
		}

		// Token: 0x17008272 RID: 33394
		// (get) Token: 0x060218FA RID: 137466 RVA: 0x0031A381 File Offset: 0x00318581
		// (set) Token: 0x060218FB RID: 137467 RVA: 0x0031A395 File Offset: 0x00318595
		public unsafe string ServiceVersion
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMagtVersionData.__PropertyOffset_ServiceVersion)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMagtVersionData.__PropertyOffset_ServiceVersion)), value);
			}
		}

		// Token: 0x17008273 RID: 33395
		// (get) Token: 0x060218FC RID: 137468 RVA: 0x0031A3AA File Offset: 0x003185AA
		// (set) Token: 0x060218FD RID: 137469 RVA: 0x0031A3BA File Offset: 0x003185BA
		public unsafe int ServiceVersionId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtVersionData.__PropertyOffset_ServiceVersionId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtVersionData.__PropertyOffset_ServiceVersionId) = value;
			}
		}

		// Token: 0x060218FE RID: 137470 RVA: 0x0031A3CB File Offset: 0x003185CB
		public FMagtVersionData()
		{
		}

		// Token: 0x060218FF RID: 137471 RVA: 0x0031A3D3 File Offset: 0x003185D3
		public FMagtVersionData(string SDKVersion, int SDKVersionId, string ServiceVersion, int ServiceVersionId)
		{
			this.SDKVersion = SDKVersion;
			this.SDKVersionId = SDKVersionId;
			this.ServiceVersion = ServiceVersion;
			this.ServiceVersionId = ServiceVersionId;
		}

		// Token: 0x06021900 RID: 137472 RVA: 0x0031A3F8 File Offset: 0x003185F8
		protected override IntPtr GetUStructPtr()
		{
			return FMagtVersionData.StaticStruct();
		}

		// Token: 0x06021901 RID: 137473 RVA: 0x0031A404 File Offset: 0x00318604
		[NullableContext(2)]
		public FMagtVersionData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021902 RID: 137474 RVA: 0x0031A40E File Offset: 0x0031860E
		public FMagtVersionData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021903 RID: 137475 RVA: 0x0031A419 File Offset: 0x00318619
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMagtVersionData(Pointer, false, true);
		}

		// Token: 0x06021904 RID: 137476 RVA: 0x0031A423 File Offset: 0x00318623
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMagtVersionData(Pointer, MemoryOwner);
		}

		// Token: 0x04011EC6 RID: 73414
		public const string __ObjectPath = "/Script/MagtModule.MagtVersionData";

		// Token: 0x04011EC7 RID: 73415
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011EC8 RID: 73416
		internal static int __PropertyOffset_SDKVersion;

		// Token: 0x04011EC9 RID: 73417
		internal static int __PropertyOffset_SDKVersionId;

		// Token: 0x04011ECA RID: 73418
		internal static int __PropertyOffset_ServiceVersion;

		// Token: 0x04011ECB RID: 73419
		internal static int __PropertyOffset_ServiceVersionId;
	}
}
