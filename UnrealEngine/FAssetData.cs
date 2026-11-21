using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000F0 RID: 240
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/CoreUObject.AssetData")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FAssetData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060010B4 RID: 4276 RVA: 0x0001A929 File Offset: 0x00018B29
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAssetData._ScriptStructPtr != 0) ? FAssetData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.AssetData", ref FAssetData._ScriptStructPtr);
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x0001A94D File Offset: 0x00018B4D
		// (set) Token: 0x060010B6 RID: 4278 RVA: 0x0001A961 File Offset: 0x00018B61
		public unsafe FName ObjectPath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_ObjectPath);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_ObjectPath) = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x0001A976 File Offset: 0x00018B76
		// (set) Token: 0x060010B8 RID: 4280 RVA: 0x0001A98A File Offset: 0x00018B8A
		public unsafe FName PackageName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_PackageName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_PackageName) = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x0001A99F File Offset: 0x00018B9F
		// (set) Token: 0x060010BA RID: 4282 RVA: 0x0001A9B3 File Offset: 0x00018BB3
		public unsafe FName PackagePath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_PackagePath);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_PackagePath) = value;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x0001A9C8 File Offset: 0x00018BC8
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x0001A9DC File Offset: 0x00018BDC
		public unsafe FName AssetName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_AssetName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_AssetName) = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x0001A9F1 File Offset: 0x00018BF1
		// (set) Token: 0x060010BE RID: 4286 RVA: 0x0001AA05 File Offset: 0x00018C05
		public unsafe FName AssetClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_AssetClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_AssetClass) = value;
			}
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0001AA1A File Offset: 0x00018C1A
		public FAssetData()
		{
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x0001AA22 File Offset: 0x00018C22
		protected override IntPtr GetUStructPtr()
		{
			return FAssetData.StaticStruct();
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0001AA2E File Offset: 0x00018C2E
		[NullableContext(2)]
		public FAssetData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x0001AA38 File Offset: 0x00018C38
		public FAssetData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x0001AA43 File Offset: 0x00018C43
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAssetData(Pointer, false, true);
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x0001AA4D File Offset: 0x00018C4D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAssetData(Pointer, MemoryOwner);
		}

		// Token: 0x04000410 RID: 1040
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CoreUObject.AssetData";

		// Token: 0x04000411 RID: 1041
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000412 RID: 1042
		internal static int __PropertyOffset_ObjectPath;

		// Token: 0x04000413 RID: 1043
		internal static int __PropertyOffset_PackageName;

		// Token: 0x04000414 RID: 1044
		internal static int __PropertyOffset_PackagePath;

		// Token: 0x04000415 RID: 1045
		internal static int __PropertyOffset_AssetName;

		// Token: 0x04000416 RID: 1046
		internal static int __PropertyOffset_AssetClass;
	}
}
