using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000854 RID: 2132
	[UnrealObjectPath("/Script/Engine.AssetImportInfo")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAssetImportInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007303 RID: 29443 RVA: 0x000A4CE2 File Offset: 0x000A2EE2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAssetImportInfo._ScriptStructPtr != 0) ? FAssetImportInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AssetImportInfo", ref FAssetImportInfo._ScriptStructPtr);
		}

		// Token: 0x06007304 RID: 29444 RVA: 0x000A4D06 File Offset: 0x000A2F06
		public FAssetImportInfo()
		{
		}

		// Token: 0x06007305 RID: 29445 RVA: 0x000A4D0E File Offset: 0x000A2F0E
		protected override IntPtr GetUStructPtr()
		{
			return FAssetImportInfo.StaticStruct();
		}

		// Token: 0x06007306 RID: 29446 RVA: 0x000A4D1A File Offset: 0x000A2F1A
		[NullableContext(2)]
		public FAssetImportInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007307 RID: 29447 RVA: 0x000A4D24 File Offset: 0x000A2F24
		public FAssetImportInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007308 RID: 29448 RVA: 0x000A4D2F File Offset: 0x000A2F2F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAssetImportInfo(Pointer, false, true);
		}

		// Token: 0x06007309 RID: 29449 RVA: 0x000A4D39 File Offset: 0x000A2F39
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAssetImportInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04003749 RID: 14153
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AssetImportInfo";

		// Token: 0x0400374A RID: 14154
		private static IntPtr _ScriptStructPtr;
	}
}
