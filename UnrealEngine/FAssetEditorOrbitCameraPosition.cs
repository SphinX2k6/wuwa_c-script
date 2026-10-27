using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000851 RID: 2129
	[UnrealObjectPath("/Script/Engine.AssetEditorOrbitCameraPosition")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FAssetEditorOrbitCameraPosition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060072D1 RID: 29393 RVA: 0x000A48CA File Offset: 0x000A2ACA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAssetEditorOrbitCameraPosition._ScriptStructPtr != 0) ? FAssetEditorOrbitCameraPosition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AssetEditorOrbitCameraPosition", ref FAssetEditorOrbitCameraPosition._ScriptStructPtr);
		}

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x060072D2 RID: 29394 RVA: 0x000A48EE File Offset: 0x000A2AEE
		// (set) Token: 0x060072D3 RID: 29395 RVA: 0x000A48FE File Offset: 0x000A2AFE
		public unsafe bool bIsSet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetEditorOrbitCameraPosition.__PropertyOffset_bIsSet) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetEditorOrbitCameraPosition.__PropertyOffset_bIsSet) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x060072D4 RID: 29396 RVA: 0x000A490F File Offset: 0x000A2B0F
		// (set) Token: 0x060072D5 RID: 29397 RVA: 0x000A4923 File Offset: 0x000A2B23
		public unsafe FVector CamOrbitPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetEditorOrbitCameraPosition.__PropertyOffset_CamOrbitPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetEditorOrbitCameraPosition.__PropertyOffset_CamOrbitPoint) = value;
			}
		}

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x060072D6 RID: 29398 RVA: 0x000A4938 File Offset: 0x000A2B38
		// (set) Token: 0x060072D7 RID: 29399 RVA: 0x000A494C File Offset: 0x000A2B4C
		public unsafe FVector CamOrbitZoom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetEditorOrbitCameraPosition.__PropertyOffset_CamOrbitZoom);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetEditorOrbitCameraPosition.__PropertyOffset_CamOrbitZoom) = value;
			}
		}

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x060072D8 RID: 29400 RVA: 0x000A4961 File Offset: 0x000A2B61
		// (set) Token: 0x060072D9 RID: 29401 RVA: 0x000A4975 File Offset: 0x000A2B75
		public unsafe FRotator CamOrbitRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetEditorOrbitCameraPosition.__PropertyOffset_CamOrbitRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetEditorOrbitCameraPosition.__PropertyOffset_CamOrbitRotation) = value;
			}
		}

		// Token: 0x060072DA RID: 29402 RVA: 0x000A498A File Offset: 0x000A2B8A
		public FAssetEditorOrbitCameraPosition()
		{
		}

		// Token: 0x060072DB RID: 29403 RVA: 0x000A4992 File Offset: 0x000A2B92
		public FAssetEditorOrbitCameraPosition(bool bIsSet, FVector CamOrbitPoint, FVector CamOrbitZoom, FRotator CamOrbitRotation)
		{
			this.bIsSet = bIsSet;
			this.CamOrbitPoint = CamOrbitPoint;
			this.CamOrbitZoom = CamOrbitZoom;
			this.CamOrbitRotation = CamOrbitRotation;
		}

		// Token: 0x060072DC RID: 29404 RVA: 0x000A49B7 File Offset: 0x000A2BB7
		protected override IntPtr GetUStructPtr()
		{
			return FAssetEditorOrbitCameraPosition.StaticStruct();
		}

		// Token: 0x060072DD RID: 29405 RVA: 0x000A49C3 File Offset: 0x000A2BC3
		[NullableContext(2)]
		public FAssetEditorOrbitCameraPosition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060072DE RID: 29406 RVA: 0x000A49CD File Offset: 0x000A2BCD
		public FAssetEditorOrbitCameraPosition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060072DF RID: 29407 RVA: 0x000A49D8 File Offset: 0x000A2BD8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAssetEditorOrbitCameraPosition(Pointer, false, true);
		}

		// Token: 0x060072E0 RID: 29408 RVA: 0x000A49E2 File Offset: 0x000A2BE2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAssetEditorOrbitCameraPosition(Pointer, MemoryOwner);
		}

		// Token: 0x0400372F RID: 14127
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AssetEditorOrbitCameraPosition";

		// Token: 0x04003730 RID: 14128
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003731 RID: 14129
		internal static int __PropertyOffset_bIsSet;

		// Token: 0x04003732 RID: 14130
		internal static int __PropertyOffset_CamOrbitPoint;

		// Token: 0x04003733 RID: 14131
		internal static int __PropertyOffset_CamOrbitZoom;

		// Token: 0x04003734 RID: 14132
		internal static int __PropertyOffset_CamOrbitRotation;
	}
}
